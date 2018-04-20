Imports System.Windows.Forms

Public Class frmInputGeneral

   Private sInputGeneral As String

   Public ReadOnly Property ResultadoInput() As String
      Get
         Return sInputGeneral
      End Get
   End Property

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If txtResultado.Text.Trim <> "" Then
         sInputGeneral = txtResultado.Text
         INPUT_GENERAL = txtResultado.Text
         Me.DialogResult = System.Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MensajeError("Dato no válido")
         txtResultado.Focus()
      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      INPUT_GENERAL = ""
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Public Sub PasarInfoVentana(ByVal sCaption As String, _
                               ByVal sLabel As String)

      Me.Text = sCaption
      lblTip.Text = sLabel

   End Sub

End Class
