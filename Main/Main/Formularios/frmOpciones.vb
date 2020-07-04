Imports System.Windows.Forms

Public Class frmOpciones

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Prex.Utils.Configuration.PrexConfigLocal.MultiExec = IIf(optVarios.Checked, 1, 0)
        Prex.Utils.Configuration.PrexConfigLocal.MinimizarAlCerrar = IIf(chkMinimizar.Checked, 1, 0)
        Prex.Utils.Configuration.PrexConfigLocal.InicioTray = IIf(chkInicioTray.Checked, 1, 0)
        Prex.Utils.Configuration.PrexConfigLocal.ConfirmarAlSalir = IIf(chkConfirmarSalir.Checked, 1, 0)
        Prex.Utils.Configuration.PrexConfigLocal.SiempreIG = IIf(chkSiempreIG.Checked, 1, 0)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub frmOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Prex.Utils.Configuration.PrexConfigLocal.MultiExec = 1 Then
            optVarios.Checked = True
        Else
            optUno.Checked = True
        End If

        chkMinimizar.Checked = CBool(Prex.Utils.Configuration.PrexConfigLocal.MinimizarAlCerrar)
        chkInicioTray.Checked = CBool(Prex.Utils.Configuration.PrexConfigLocal.InicioTray)
        chkConfirmarSalir.Checked = CBool(Prex.Utils.Configuration.PrexConfigLocal.ConfirmarAlSalir)
        chkSiempreIG.Checked = CBool(Prex.Utils.Configuration.PrexConfigLocal.SiempreIG)

    End Sub

End Class
