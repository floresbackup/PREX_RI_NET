
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub cmdTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        Response.Redirect("pages/queryexec.aspx?queryid=1")
    End Sub
End Class
