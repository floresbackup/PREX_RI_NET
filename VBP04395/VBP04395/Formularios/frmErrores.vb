Imports System.Windows.Forms

Public Class frmErrores

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

   Public Sub PasarDatos(ByVal sError As String)

      txtError.Text = sError

   End Sub

End Class
