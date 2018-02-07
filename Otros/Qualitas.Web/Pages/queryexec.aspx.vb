
Partial Class Pages_queryexec
    Inherits System.Web.UI.Page

    Private CONSULTA_ID As Long

    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CONSULTA_ID = Request("queryid")
        Response.Write(CONSULTA_ID)

        oChart.Width = "700"

        Dim oRow As New HtmlTableRow

        Dim oCell As New HtmlTableCell
        oCell.InnerText = "Mi parámetro"

        Dim oEdit As New DevExpress.Web.ASPxEditors.ASPxDateEdit
        oEdit.ID = "PEPE"
        oEdit.Width = 111



        Dim oCell2 As New HtmlTableCell

        oCell2.Controls.Add(oEdit)
        oRow.Cells.Add(oCell)
        oRow.Cells.Add(oCell2)

        tabParametros.Rows.Add(oRow)


    End Sub

    Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ASPxButton1.Click

        Dim oEdit As DevExpress.Web.ASPxEditors.ASPxDateEdit
        Dim oCont As Web.UI.Control

        For Each oCont In tabParametros.Rows(1).Cells(1).Controls
            'Response.Write(oCont.ID)
        Next

        oEdit = tabParametros.Rows(1).Cells(1).Controls(0)

        ASPxButton1.Text = oEdit.Value

    End Sub
End Class
