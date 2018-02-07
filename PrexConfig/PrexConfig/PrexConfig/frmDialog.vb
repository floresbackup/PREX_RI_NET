Imports System.Windows.Forms

Public Class frmDialog

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      frmMain.PasarDatos(txtNombre.Text, txtValor.Text)
      Me.Close()
   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Friend Sub PasarDatos(ByVal sNombre As String, _
                         ByVal sValor As String)

      txtNombre.Text = sNombre
      txtValor.Text = sValor

   End Sub

End Class
