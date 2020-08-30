Imports System.Data.SqlClient
Imports DevExpress.XtraTab
Imports Prex.Utils.Misc.Forms

Public Class frmMain

#Region "Variables/Propiedades"
	Private txtQuery As ScintillaNET.Scintilla

	Private ReadOnly Property Query As String
		Get
			If txtQuery.SelectedText.Any() Then Return txtQuery.SelectedText.Trim()
			Return txtQuery.Text.Trim()
		End Get
	End Property
#End Region


#Region "Constructores"
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		txtQuery = New ScintillaNET.Scintilla()
		pnlQuery.Controls.Add(txtQuery)
		txtQuery.Dock = DockStyle.Fill
		ScintillaSQL.InitialiseScintilla(txtQuery)

		AddHandler txtQuery.TextChanged, AddressOf txtQuery_TextChanged
	End Sub

#End Region

#Region "Eventos del formulario"

	Private Sub txtQuery_TextChanged(sender As Object, e As EventArgs)
		EnabledMenu()
	End Sub


	Private Sub frmMain_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
		If e.Control AndAlso e.KeyCode = Keys.C Then
			ClearQuery()
		End If
	End Sub

	Private Sub mnuClearConsulta_Click(sender As Object, e As EventArgs) Handles mnuClearConsulta.Click
		ClearQuery()
	End Sub

	Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyCode = Keys.F5 Then
			ExecuteQuery()
		End If
	End Sub

	Private Sub mnuExecuteQuery_Click(sender As Object, e As EventArgs) Handles mnuExecuteQuery.Click
		ExecuteQuery()
	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		EnabledMenu()
	End Sub

	Private Sub tabControl_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabControl.SelectedPageChanged
		If tabControl.SelectedTabPageIndex = 0 Then
			txtQuery.Focus()
		ElseIf grdResults.Visible Then
			gridViewResults.Focus()
		Else
			txtResultsError.Focus()
		End If
	End Sub

	Private Sub subMnuSaveQuery_Click(sender As Object, e As EventArgs) Handles subMnuSaveQuery.Click
		Dim fileName = GetSaveFile("Guardar consulta...", "SQL (*.sql)|*sql", ".sql", False)
		If fileName.Any() Then
			IO.File.WriteAllLines(fileName, txtQuery.Lines)
		End If
	End Sub

	Private Sub mnuExportToExcel_Click(sender As Object, e As EventArgs) Handles mnuExportToExcel.Click
		Try

			Dim fileName = GetSaveFile("Exportara Excel", "Excel (*.xlsx)|*.xlsx", ".xlsx", False)
			If fileName.Any() Then
				gridViewResults.ExportToXlsx(fileName)
				If MessageBox.Show("Se exportó consulta a Excel." & vbCrLf & "¿Desea abrirlo?", "Exportar a Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then Process.Start(fileName)
			End If
		Catch ex As Exception
			MessageBox.Show("Ocurrió un error al exportar a Excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

#End Region


#Region "Metodos"

	Private Sub EnabledMenu()
		If txtQuery.Text.Any() Then
			mnuClearConsulta.Enabled = True
			mnuExecuteQuery.Enabled = True
			subMnuSaveQuery.Enabled = True
		Else
			mnuClearConsulta.Enabled = False
			mnuExecuteQuery.Enabled = False
			subMnuSaveQuery.Enabled = False
		End If
	End Sub

	Private Sub ExecuteQuery()
		Try
			Cursor = Cursors.WaitCursor
			Try
				Dim tabs = New List(Of XtraTabPage)
				tabs.AddRange(tabControl.TabPages.Skip(2).ToList())
				tabs.ForEach(Sub(t) tabControl.TabPages.Remove(t))

				If Not Query.Trim().Any() Then
					MessageBox.Show(Me, "No se completó consulta SQL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Else
					If GetTypeSQL() <> Nothing Then
						ShowResultsGrid(ExecuteQueryResults())
					Else
						ExecuteQueryDefault()
					End If
				End If
			Catch ex As Exception
				ShowMessageResult(ex.Message, True)
			End Try
		Finally
			Cursor = Cursors.Default
		End Try
	End Sub

	Private Function ExecuteQueryResults() As List(Of DataTable)
		Dim conn As New SqlConnection(Prex.Utils.Configuration.PrexConfig.CONN_LOCAL_ADO)
		Try

			Try



				conn.Open()

				'Dim da As New SqlDataAdapter(Query, conn)
				'da.SelectCommand.CommandType = GetTypeSQL()
				'Dim dt As New DataTable()
				'da.Fill(dt)
				'dt.Rows

				Dim listdt As New List(Of DataTable)
				Dim cmd = New SqlCommand(Query, conn)
				Dim reader = cmd.ExecuteReader()

				Do
					'reader.Read()
					Dim d1 As New DataTable()
					d1.Load(reader)
					listdt.Add(d1)
				Loop While Not reader.IsClosed AndAlso reader.NextResult

				reader.Close()

				'Return dt
				Return listdt
			Catch ex As Exception
				Throw ex
			End Try
		Finally
			conn.Close()
		End Try
	End Function

	Private Function GetTypeSQL() As CommandType
		If Query.ToUpper().StartsWith("EXEC") OrElse Query.ToUpper().StartsWith("SP_") Then Return CommandType.StoredProcedure
		If Query.ToUpper().StartsWith("SELECT") Then Return CommandType.Text

		Return Nothing
	End Function


	Private Sub ExecuteQueryDefault()
		Dim conn As New SqlConnection(Prex.Utils.Configuration.PrexConfig.CONN_LOCAL_ADO)
		Dim cmd As New SqlCommand(Query, conn)
		Try
			AddHandler conn.InfoMessage, New SqlInfoMessageEventHandler(AddressOf OnInfoMessage)

			conn.Open()
			cmd.Connection = conn
			cmd.ExecuteNonQuery()
		Finally
			conn.Close()
		End Try
	End Sub

	Private Sub OnInfoMessage(sender As Object, args As SqlInfoMessageEventArgs)
		Dim err As SqlError
		Dim errors = args.Message
		For Each err In args.Errors
			If err.Message = args.Message Then Continue For
			errors = errors & vbCrLf & err.Message
		Next
		If errors = args.Message Then
			ShowMessageResult(args.Message, False)
		Else
			ShowMessageResult(errors, True)
		End If
	End Sub

	Private Sub ShowResultsGrid(ByVal dataTables As List(Of DataTable))

		For index = 0 To dataTables.Count() - 1
			Dim data = dataTables(index)
			Dim newTab As XtraTabPage = IIf(index > 0, tabControl.TabPages.Add(), tabResults)
			newTab.Name = IIf(index > 0, $"tabResultados{index}", newTab.Name)
			newTab.Text = IIf(dataTables.Count() > 0, $"Resultados &{index}", "&Resultados")

			Dim ucresult As New ucPanelResult()
			ucresult.SetResultado(data)

			mnuExportToExcel.Enabled = mnuExportToExcel.Enabled OrElse ucresult.gridViewResults.RowCount > 0

		Next

		ActiveResultPage(tabControl.TabPages.LastOrDefault())
	End Sub


	Private Sub ActiveResultPage(tab As XtraTabPage)
		tab.Enabled = True
		tab.PageEnabled = True
		tabControl.SelectedTabPage = tab
		tab.Select()
		tab.Focus()
	End Sub

	Private Sub ClearQuery()
		txtQuery.Text = String.Empty
		txtQuery.SelectionStart = 0
		txtQuery.Focus()
	End Sub

	Private Sub subMnuOpenQuery_Click(sender As Object, e As EventArgs) Handles subMnuOpenQuery.Click
		openFileDialog.DefaultExt = ".sql"
		openFileDialog.CheckFileExists = True
		openFileDialog.FileName = "*.sql"
		openFileDialog.Filter = "SQL (*.sql)|*.sql"
		If openFileDialog.ShowDialog() = DialogResult.OK Then
			Dim fileName = openFileDialog.FileName
			txtQuery.Text = IO.File.ReadAllText(fileName)
		End If
	End Sub

	Private Function GetSaveFile(title As String, filter As String, ext As String) As String
		Return GetSaveFile(title, filter, ext, True)
	End Function

	Private Function GetSaveFile(title As String, filter As String, ext As String, checkExistFile As Boolean) As String
		Dim saveControl As New SaveFileDialog()
		saveControl.Title = title
		saveControl.DefaultExt = ext
		saveControl.CheckPathExists = True
		saveControl.CheckFileExists = checkExistFile
		saveControl.Filter = filter
		If saveControl.ShowDialog(Me) = DialogResult.OK Then
			Return saveControl.FileName
		End If
		Return String.Empty
	End Function
#End Region

End Class
