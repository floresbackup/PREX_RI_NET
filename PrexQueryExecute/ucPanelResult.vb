Public Class ucPanelResult


	Public Sub SetResultado(data As DataTable)

		pnlResult.Padding = New Padding(0, 0, 0, 0)

		txtResultsError.Text = String.Empty
		txtResultsError.Dock = DockStyle.Bottom
		txtResultsError.Visible = False

		grdResults.Dock = DockStyle.Fill
		grdResults.Visible = True
		gridViewResults.OptionsView.ColumnAutoWidth = False
		gridViewResults.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.Default

		gridViewResults.Columns.Clear()
		grdResults.DataSource = data
		grdResults.RefreshDataSource()
		grdResults.Refresh()

		gridViewResults.BestFitColumns()

		If data Is Nothing Then ShowMessageResult("Error: No fue posible obtener DataTable (ISNULL)", True)

		gridViewResults.Focus()
	End Sub


	Private Sub ShowMessageResult(ByVal errorMessage As String, isError As Boolean)
		If isError Then MessageBox.Show(Me, "Ocurrió un error al ejecutar consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		grdResults.Visible = False
		grdResults.DataSource = Nothing
		grdResults.Dock = DockStyle.Bottom

		mnuExportToExcel.Enabled = False

		If isError Then
			txtResultsError.ForeColor = Color.Red
		Else
			txtResultsError.ForeColor = Color.Blue
		End If

		pnlResult.Padding = New Padding(10, 10, 0, 0)

		txtResultsError.ScrollBars = RichTextBoxScrollBars.Both
		txtResultsError.Text = errorMessage
		txtResultsError.Dock = DockStyle.Fill
		txtResultsError.Visible = True
		txtResultsError.SelectionStart = 0
		txtResultsError.Focus()

		ActiveResultPage()
	End Sub
End Class
