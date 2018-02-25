Imports System.Windows.Forms

Public Class frmOpciones

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      MULTIEXEC = IIf(optVarios.Checked, 1, 0)

      MINIMIZAR_AL_CERRAR = IIf(chkMinimizar.Checked, 1, 0)
      INICIAR_EN_TRAY = IIf(chkInicioTray.Checked, 1, 0)
      CONFIRMAR_AL_SALIR = IIf(chkConfirmarSalir.Checked, 1, 0)
      SIEMPRE_ICONOS_GRANDES = IIf(chkSiempreIG.Checked, 1, 0)

      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub frmOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      If MULTIEXEC Then
         optVarios.Checked = True
      Else
         optUno.Checked = True
      End If

      chkMinimizar.Checked = CBool(MINIMIZAR_AL_CERRAR)
      chkInicioTray.Checked = CBool(INICIAR_EN_TRAY)
      chkConfirmarSalir.Checked = CBool(CONFIRMAR_AL_SALIR)
      chkSiempreIG.Checked = CBool(SIEMPRE_ICONOS_GRANDES)

   End Sub

End Class
