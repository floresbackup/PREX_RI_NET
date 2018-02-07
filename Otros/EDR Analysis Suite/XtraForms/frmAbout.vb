Public Class frmAbout 

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        On Error Resume Next

        picProducto.Image = Image.FromFile(LOGO_ABOUT_PRODUCT_PATH)
        picLogo.Image = Image.FromFile(LOGO_ABOUT_LOGO_PATH)

    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWeb.Click
        On Error Resume Next
        Shell(cmdWeb.Text)
    End Sub

    Private Sub pc001_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pc001.Paint

    End Sub
End Class