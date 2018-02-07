Public Class frmOpcionesSeguridad 

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionOpcionesSeguridad)

        chkAutenticacionNT.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesSeguridad_ValidarNT)
        lblDominio.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesSeguridad_Dominio)
        chkEnableCmdLogin.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesSeguridad_HabilitarCmdLogin)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub GuardarOpciones()

        Dim sIniPath As String = Application.StartupPath & "\Config.ini"
        Dim sSQL As String
        Dim ds As DataSet


        DOMAIN_DEFAULT = txtDominio.Text.Trim
        VALIDATE_NT = chkAutenticacionNT.Checked
        CMDLINE_HABILITAR_LOGIN = chkEnableCmdLogin.Checked

        INIWrite(sIniPath, "OPCIONES", "DOMAIN", DOMAIN_DEFAULT)
        INIWrite(sIniPath, "OPCIONES", "AD_VALIDATION", IIf(VALIDATE_NT, 1, 0))
        INIWrite(sIniPath, "OPCIONES", "ENABLE_CMD_LOGIN", IIf(CMDLINE_HABILITAR_LOGIN, 1, 0))

        Me.Close()

    End Sub

    Private Sub frmOpcionesSeguridad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkAutenticacionNT.Checked = VALIDATE_NT
        txtDominio.Text = DOMAIN_DEFAULT
        chkEnableCmdLogin.Checked = CMDLINE_HABILITAR_LOGIN

        LocalizarFormulario()

    End Sub

    Private Sub chkAutenticacionNT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutenticacionNT.CheckedChanged
        txtDominio.Enabled = chkAutenticacionNT.Checked

        If chkAutenticacionNT.Checked Then
            txtDominio.Focus()
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        GuardarOpciones()
    End Sub
End Class