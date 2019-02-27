Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1

#Region "Variables"
	Private _configuracion As Configuracion
	Private _dicFormato As New List(Of Formato)
	Private objMyLock As New Object
#End Region

#Region "Propiedades"
	Private ReadOnly Property TableName As String
		Get
			Return Path.GetFileNameWithoutExtension(txtPathBCP.Text)
		End Get
	End Property

	Private ReadOnly Property ConfiguracionProceso As Configuracion
		Get
			If _configuracion Is Nothing Then _configuracion = New Configuracion()
			_configuracion.DB = txtDataBase.Text.Trim()
			_configuracion.Usuario = txtSQLUser.Text.Trim()
			_configuracion.Servidor = txtSQLServer.Text.Trim()
			_configuracion.Pass = txtUserPass.Text.Trim()
			_configuracion.DecimalSeparator = txtDecimalSeparator.Text.Trim()
			_configuracion.PathBCP = txtPathBCP.Text.Trim()
			_configuracion.PathFMT = txtPathFMT.Text.Trim()

			Return _configuracion
		End Get
	End Property

	Private ReadOnly Property GetFullConnectionString As String
		Get
			Dim con = "Integrated Security=SSPI;Password=" & txtUserPass.Text.Trim() & ";User Id=" & txtSQLUser.Text.Trim()
			con &= ";Initial Catalog=" & txtDataBase.Text.Trim() & ";Data Source=" & txtSQLServer.Text.Trim()
			Return con.Replace(";;", ";")
		End Get
	End Property

	Private ReadOnly Property ConfigFileName As String
		Get
			Return "configuracion.json"
		End Get
	End Property

	Private ReadOnly Property ConfigFilePath As String
		Get
			Return Environment.CurrentDirectory & "\" & ConfigFileName
		End Get
	End Property
#End Region

#Region "Eventos"

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If CargarConfiguracion() Then btnProcesar.Select()
		btnDialogBCP.Select()
	End Sub

	Private Sub btnDialogBCP_Click(sender As Object, e As EventArgs) Handles btnDialogBCP.Click
		OpenFileDialog1.FileName = "*.txt"
		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			txtPathBCP.Text = OpenFileDialog1.FileName
		End If
	End Sub

	Private Sub btnDialogFMT_Click(sender As Object, e As EventArgs) Handles btnDialogFMT.Click
		OpenFileDialog1.FileName = "*.fmt"

		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			txtPathFMT.Text = OpenFileDialog1.FileName
		End If
	End Sub

	Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
		Cursor = Cursors.WaitCursor
		progressBar.Value = 0
		lblProgress.Visible = True
		progressBar.Visible = True
		lblProgress.Text = "Guardando configuracion..."
		GuardarConfiguracion()
		progressBar.Value = 30
		BloquearControles(True)
		Dim conn = New SqlConnection(Me.GetFullConnectionString())
		Dim tran As SqlTransaction = Nothing
		Dim isTransaccion = False
		Try

			Try
				lblProgress.Text = "Cargando formato..."
				progressBar.Value = 60

				ObtenerDiccionarioFormato()

				lblProgress.Text = "Conectando con SQL..."
				conn.Open()

				'	tran = conn.BeginTransaction
				'	isTransaccion = True

				lblProgress.Text = ""
				progressBar.Value = 0

				Dim cmd As New SqlCommand("", conn)
				Dim dropTable = False

				lblProgress.Text = "Leyendo archivo BCP..."
				Dim lines = File.ReadLines(txtPathBCP.Text)

				progressBar.Maximum = lines.Count()
				lblProgress.Text = "Insertando registros..."
				If lines.Count() > 200800 Then

					For Each items As List(Of String) In lines.Partir(150000)
						If Not dropTable Then
							Dim terminos = items.Select(Function(i) PartirTerminos(i).ToList()).ToList()
							dropTable = DropearYCrearTabla(conn, tran, terminos)
						End If
						BulkCopy(conn, items, False)
					Next
				Else
					BulkCopy(conn, lines)
				End If

				''For Each LineBCP As String In lines
				'lines.AsParallel() _
				'.WithDegreeOfParallelism(4) _
				'.ForAll(Sub(LineBCP)
				'			Try
				'				Invoke(Sub()
				'						   progressBar.Value += 1
				'						   lblProgress.Text = "Insertando registros " & progressBar.Value & "/" & progressBar.Maximum
				'					   End Sub)
				'				Dim terminos = Partir(LineBCP)

				'				If Not dropTable Then dropTable = DropearYCrearTabla(conn, tran, terminos)

				'				If cmd.Parameters.Count() = 0 OrElse cmd.CommandText.Count() = 0 Then
				'					SyncLock objMyLock
				'						cmd = CrearCommandInsert(cmd, terminos)
				'						cmd.Transaction = tran
				'					End SyncLock
				'				Else
				'					cmd = CargarParametros(cmd, terminos)
				'				End If
				'				cmd.ExecuteNonQuery()
				'			Catch ex As Exception
				'				Throw ex
				'			End Try
				'		End Sub)
				''Next


				If isTransaccion Then tran.Commit()
				conn.Close()
				MessageBox.Show("Proceso finalizado OK " & vbCrLf & "* Total de " & lines.Count() & " registros copiados en la tabla " & TableName, "Copiar BCP", MessageBoxButtons.OK, MessageBoxIcon.Information)

			Catch ex As Exception
				If isTransaccion Then tran.Rollback()
				If conn.State = ConnectionState.Open Then conn.Close()
				MessageBox.Show("Error: " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		Finally
			lblProgress.Text = ""
			progressBar.Value = 0
			lblProgress.Visible = False
			progressBar.Visible = False
			BloquearControles(False)
			Cursor = Cursors.Default
		End Try
	End Sub
#End Region

	Private Function CrearCommandInsert(cmd As SqlCommand, terminos As List(Of String)) As SqlCommand
		cmd.CommandText = "Insert into " & TableName & " ("
		_dicFormato.ForEach(Sub(f)
								cmd.CommandText += f.NombreColumna
								If _dicFormato.IndexOf(f) < _dicFormato.Count() - 1 Then cmd.CommandText += ","
							End Sub)
		cmd.CommandText += ") " & vbCrLf & "values " & vbCrLf & "("
		_dicFormato.ForEach(Sub(f)
								cmd.CommandText += "@" & f.NombreColumna
								If _dicFormato.IndexOf(f) < _dicFormato.Count() - 1 Then cmd.CommandText += ","
								cmd.Parameters.Add(f.NombreColumna, f.SQLType).Value = terminos(f.Index)
							End Sub)

		cmd.CommandText += ")"
		Return cmd
	End Function



	Private Function CargarParametros(cmd As SqlCommand, terminos As List(Of String)) As SqlCommand
		_dicFormato.ForEach(Sub(f)
								If terminos(f.Index).Trim().Count() = 0 Then
									cmd.Parameters.Item(f.NombreColumna).Value = DBNull.Value
								Else
									cmd.Parameters.Item(f.NombreColumna).Value = terminos(f.Index).Trim()
								End If
							End Sub)
		Return cmd
	End Function

	Private Function DropearYCrearTabla(conn As SqlConnection, tran As SqlTransaction, terminos As List(Of List(Of String))) As Boolean
		SyncLock objMyLock
			Dim cmdCreateTable As New SqlCommand("IF OBJECT_ID('dbo." & TableName & "', 'U') IS NOT NULL " & vbCrLf _
																 & "DROP TABLE " & TableName & vbCrLf _
																 , conn)
			cmdCreateTable.Transaction = tran
			cmdCreateTable.ExecuteNonQuery()
			cmdCreateTable.CommandText = "CREATE TABLE " & TableName & vbCrLf & " (" & vbCrLf
			_dicFormato.ForEach(Sub(l)
									Dim o = Nothing
									If terminos.All(Function(t) IsNumeric(t(l.Index).Trim)) Then
										Dim valor = terminos.OrderByDescending(Function(t) t(l.Index).Trim.Count()).FirstOrDefault()(l.Index).Trim()
										If valor.Contains(txtDecimalSeparator.Text) AndAlso IsNumeric(valor.Replace(txtDecimalSeparator.Text, String.Empty)) Then
											cmdCreateTable.CommandText += l.NombreColumna & " DECIMAL(16,4) NULL"
											l.SQLType = SqlDbType.Decimal
											'ElseIf IsNumeric(valor.Trim) AndAlso Integer.TryParse(valor, o) Then
											'	cmdCreateTable.CommandText += l.NombreColumna & " INT NULL"
											'	l.SQLType = SqlDbType.Int
										ElseIf IsNumeric(valor.Trim) AndAlso Int64.TryParse(valor, o) Then
											cmdCreateTable.CommandText += l.NombreColumna & " BIGINT NULL"
											l.SQLType = SqlDbType.BigInt
										End If
									Else
										cmdCreateTable.CommandText += l.NombreColumna & " VARCHAR(" & l.Tamanio + 5 & ") NULL"
										l.SQLType = SqlDbType.VarChar
									End If

									If _dicFormato.IndexOf(l) < _dicFormato.Count() - 1 Then
										cmdCreateTable.CommandText += "," & vbCrLf
									End If
								End Sub)
			cmdCreateTable.CommandText += ")"

			cmdCreateTable.ExecuteNonQuery()
		End SyncLock
		Return True
	End Function

	Private Sub ObtenerDiccionarioFormato()
		_dicFormato.Clear()
		For Each LineFMT As String In File.ReadLines(txtPathFMT.Text)
			Dim terminos = LineFMT.Split(vbTab)
			If terminos.Where(Function(t) t.Count() > 0).Count() <= 1 Then Continue For

			If _dicFormato.Count() = 0 Then
				_dicFormato.Add(New Formato(terminos(6), 0, terminos(3), _dicFormato.Count()))
			Else
				_dicFormato.Add(New Formato(terminos(6), _dicFormato.Sum(Function(x) x.Tamanio), terminos(3), _dicFormato.Count()))
			End If
		Next
	End Sub

	Private Function PartirTerminos(linea As String) As List(Of String)
		Dim l As New List(Of String)
		If linea.Count < _dicFormato.Max(Function(f) f.Inicio) Then Return l
		_dicFormato.ForEach(Sub(f)
								l.Add(linea.Substring(f.Inicio, f.Tamanio))
							End Sub)
			Return l
	End Function

	Private Sub GuardarConfiguracion()
		If System.IO.File.Exists(ConfigFilePath) Then System.IO.File.Delete(ConfigFilePath)
		Dim objWriter As New System.IO.StreamWriter(ConfigFilePath)

		objWriter.Write(Newtonsoft.Json.JsonConvert.SerializeObject(ConfiguracionProceso))
		objWriter.Close()
	End Sub

	Private Function CargarConfiguracion() As Boolean
		If Not System.IO.File.Exists(ConfigFilePath) Then Return False

		_configuracion = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Configuracion)(System.IO.File.ReadAllText(ConfigFilePath))

		txtDataBase.Text = _configuracion.DB
		txtDecimalSeparator.Text = _configuracion.DecimalSeparator
		txtPathBCP.Text = _configuracion.PathBCP
		txtPathFMT.Text = _configuracion.PathFMT
		txtSQLServer.Text = _configuracion.Servidor
		txtSQLUser.Text = _configuracion.Usuario
		txtUserPass.Text = _configuracion.Pass
		Return True

	End Function

	Private Sub BloquearControles(bloquear As Boolean)
		txtDataBase.Enabled = Not bloquear
		txtDecimalSeparator.Enabled = Not bloquear
		txtSQLServer.Enabled = Not bloquear
		txtSQLUser.Enabled = Not bloquear
		txtUserPass.Enabled = Not bloquear

		btnProcesar.Enabled = Not bloquear

	End Sub


	Private Function MakeTable(lines As List(Of String)) As DataTable
		' Create a new DataTable named NewProducts.

		Dim tablaSQL As DataTable = New DataTable(TableName)
		_dicFormato.ForEach(Sub(f)
								Dim col As DataColumn = New DataColumn()
								Select Case f.SQLType
									Case SqlDbType.BigInt
										col.DataType = System.Type.GetType("System.Int64")
									Case SqlDbType.Int
										col.DataType = System.Type.GetType("System.Int32")
									Case SqlDbType.VarChar
										col.DataType = System.Type.GetType("System.String")
									Case SqlDbType.Decimal
										col.DataType = System.Type.GetType("System.Decimal")
									Case Else
										col.DataType = System.Type.GetType("System.String")
								End Select
								col.ColumnName = f.NombreColumna
								tablaSQL.Columns.Add(col)
							End Sub)
		lines.ForEach(Sub(l)
						  Dim terminos = PartirTerminos(l)
						  If terminos.Count() > 0 Then

							  Dim row As DataRow
							  row = tablaSQL.NewRow()
							  _dicFormato.ForEach(Sub(f)
													  Try
														  If (terminos(f.Index).Trim.Count() = 0) Then
															  row(f.NombreColumna) = DBNull.Value
														  Else
															  Select Case f.SQLType
																  Case SqlDbType.VarChar
																	  row(f.NombreColumna) = terminos(f.Index).Trim()
																  Case SqlDbType.Decimal
																	  row(f.NombreColumna) = Decimal.Parse(terminos(f.Index).Trim())
																  Case SqlDbType.Int
																	  row(f.NombreColumna) = Int32.Parse(terminos(f.Index).Trim())
																  Case SqlDbType.BigInt
																	  row(f.NombreColumna) = Int64.Parse(terminos(f.Index).Trim())
																  Case Else
																	  row(f.NombreColumna) = terminos(f.Index).Trim()
															  End Select
														  End If
													  Catch ex As Exception
														  Throw ex
													  End Try
												  End Sub)
							  tablaSQL.Rows.Add(row)
						  End If
					  End Sub)
		Return tablaSQL
	End Function

	Private Sub BulkCopy(conn As SqlConnection, lineas As List(Of String))
		BulkCopy(conn, lineas, True)
	End Sub
	Private Sub BulkCopy(conn As SqlConnection, lineas As List(Of String), dropYCrear As Boolean)
		Dim terminos = lineas.Select(Function(l) PartirTerminos(l)).ToList()
		Dim usarDataTable = Not dropYCrear
		If dropYCrear Then usarDataTable = DropearYCrearTabla(conn, Nothing, terminos)
		If Not usarDataTable Then Exit Sub

		Dim newProducts As DataTable = MakeTable(lineas)
		Using bulkCopy As SqlBulkCopy = New SqlBulkCopy(conn)
			bulkCopy.DestinationTableName = "dbo." & TableName

			Try
				' Write from the source to the destination.
				bulkCopy.WriteToServer(newProducts)

			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
		End Using
	End Sub


End Class

Public Module Extensiones
	<Extension>
	Public Function Clone(Of Tipo)(ByVal list As IEnumerable(Of Tipo)) As IList(Of Tipo)
		Return list.ToList.Clone
	End Function

	<Extension()>
	Public Function Clone(Of Tipo)(ByVal list As IList(Of Tipo)) As IList(Of Tipo)
		Dim NewList As New List(Of Tipo)
		NewList.AddRange(list)
		Return NewList
	End Function

	<Extension>
	Public Iterator Function Partir(Of TipoObjeto)(Lista As IEnumerable(Of TipoObjeto), Cantidad As Integer) As IEnumerable(Of IEnumerable(Of TipoObjeto))
		Dim newList As New List(Of TipoObjeto)
		'Dim newListaSpliteada As New List(Of IEnumerable(Of TipoObjeto))

		Dim Cnt As Integer = 1
		For Each item In Lista
			newList.Add(item)
			Cnt += 1
			If Cnt > Cantidad Then
				Yield newList.Clone
				newList.Clear()
				Cnt = 1
			End If
		Next
		If newList.Count > 0 Then Yield newList.Clone
		'Return newListaSpliteada
	End Function
End Module

Public Class Configuracion
	Public Property Servidor As String
	Public Property DB As String
	Public Property Usuario As String
	Public Property Pass As String
	Public Property PathBCP As String
	Public Property PathFMT As String
	Public Property DecimalSeparator As String
End Class

Public Class Formato
	Public ReadOnly Property NombreColumna As String
	Public ReadOnly Property Inicio As Integer
	Public ReadOnly Property Tamanio As Integer
	Public ReadOnly Property Index As Integer
	Public Property SQLType As SqlDbType

	Public Sub New(nombre As String, init As Integer, tam As Integer, i As Integer)
		NombreColumna = nombre
		Inicio = init
		Tamanio = tam
		Index = i
	End Sub
End Class

