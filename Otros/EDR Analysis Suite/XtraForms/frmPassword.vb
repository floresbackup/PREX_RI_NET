Public Class frmPassword 

    Private sPass As String

    Public Sub IniciarOpciones()
        LocalizarFormulario()
        PASSWORD_OK = False
    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionPassword)

        lblPassword.Text = DescripcionCadena(Cadenas.CDN_frmPassword_IngresePassword)
        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Public Sub PasarPassword(ByVal sPassword As String)
        sPass = sPassword
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtPassword.Text = sPass Then
            PASSWORD_OK = True
            Me.Close()
        Else
            MensajeError(DescripcionCadena(Cadenas.CDN_frmPassword_PasswordIncorrecto))
            txtPassword.Focus()
        End If
    End Sub

    Private Sub frmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class