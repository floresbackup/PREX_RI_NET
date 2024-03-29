Imports DevExpress.XtraGrid.Localization

Public Class cGridLocalizer

   Inherits GridLocalizer
   ' overriding the GetLocalizedString method
   Public Overrides Function GetLocalizedString(ByVal id As GridStringId) As String

            Dim sTexto As String = ""
            Dim sSQL As String = ""
            Dim ds As DataSet
            Dim oRow As DataRow
            Dim da As OleDb.OleDbDataAdapter
            Dim cb As OleDb.OleDbCommandBuilder

            Dim oAdmTablas As New AdmTablas

            oAdmTablas.ConnectionString = CONN_LOCAL

            sSQL = "SELECT    * " & _
                   "FROM      CULTUR " & _
                   "WHERE     CU_CULTUR = '" & CulturaActual.ToString & "' " & _
                   "AND       CU_ORIGEN = 'GridLocalizer' " & _
                   "AND       CU_OBJETO = '" & id.ToString & "' "

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            If ds.Tables(0).Rows.Count = 0 Then

                With ds.Tables(0)

                    oRow = .NewRow()
                    oRow.Item("CU_CULTUR") = CulturaActual.ToString
                    oRow.Item("CU_ORIGEN") = "GridLocalizer"
                    oRow.Item("CU_OBJETO") = id.ToString
                    oRow.Item("CU_TEXTO") = ""

                    .Rows.Add(oRow)

                End With

                da.Update(ds)
                ds.AcceptChanges()

            End If

            Return CulturaTexto("GridLocalizer", id.ToString)

    End Function

End Class
