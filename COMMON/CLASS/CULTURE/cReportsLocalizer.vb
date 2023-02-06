'Imports DevExpress.XtraReports.Localization

'Public Class cReportsLocalizer

'    Inherits ReportLocalizer
'    ' overriding the GetLocalizedString method
'   'Public Overrides Function GetLocalizedString(ByVal id As ReportStringId) As String

'   ' Return CulturaTexto("ReportLocalizer", CStr(id))

'   'End Function

'   Public Overrides Function GetLocalizedString(ByVal id As ReportStringId) As String

'      Dim sTexto As String = ""
'      Dim sSQL As String
'      Dim ds As DataSet
'      Dim oRow As DataRow
'      Dim da As OleDb.OleDbDataAdapter
'      Dim cb As OleDb.OleDbCommandBuilder

'      Dim oAdmTablas As New AdmTablas

'      oAdmTablas.ConnectionString = CONN_LOCAL

'      sSQL = "SELECT    * " & _
'             "FROM      CULTUR " & _
'             "WHERE     CU_CULTUR = '" & CulturaActual.ToString & "' " & _
'             "AND       CU_ORIGEN = 'ReportLocalizer' " & _
'             "AND       CU_OBJETO = '" & id.ToString & "' "

'      ds = oAdmTablas.AbrirDataset(sSQL, da)

'      With ds.Tables(0)

'         oRow = .NewRow()
'         oRow.Item("CU_CULTUR") = CulturaActual.ToString
'         oRow.Item("CU_ORIGEN") = "ReportLocalizer"
'         oRow.Item("CU_OBJETO") = id.ToString
'         oRow.Item("CU_TEXTO") = ""

'         .Rows.Add(oRow)

'      End With

'      da.Update(ds)
'      ds.AcceptChanges()

'      Return sTexto

'   End Function

'End Class
