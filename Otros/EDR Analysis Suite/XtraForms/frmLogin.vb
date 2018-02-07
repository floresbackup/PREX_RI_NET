Public Class frmLogin 

    Private oAdmTablas As New AdmTablas
    Private nCodUsuario As Long
    Private sNombreCompletoUsuario As String
    Private nIntentos As Integer

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LocalizarFormulario()
        USUARIO_ACTUAL = -1

        oAdmTablas.ConnectionString = CONN_LOCAL
        txtNombreLogin.Text = LAST_USER_NAME

        Me.Focus()

        On Error Resume Next

        TratamientoDominio()
        picProducto.Image = Image.FromFile(LOGO_LOGIN_PATH)


    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionLogin)

        lblTip.Text = DescripcionCadena(Cadenas.CDN_frmLogin_TipUsuarioPassword)
        lblLoginName.Text = DescripcionCadena(Cadenas.CDN_frmLogin_Usuario)
        lblPassword.Text = DescripcionCadena(Cadenas.CDN_frmLogin_Password)
        lblDominio.Text = DescripcionCadena(Cadenas.CDN_frmLogin_Dominio)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Function DatosOK() As Boolean

        Dim bUserExists As Boolean
        Dim bSuspendido As Boolean
        Dim bBloqueado As Boolean
        Dim sPassword As String

        If txtNombreLogin.Text.Trim = "" Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmLogin_ValidacionUsuarioNoExiste))
            txtNombreLogin.Focus()
            Exit Function
        End If

        bUserExists = DatosUsuario(txtNombreLogin.Text.Trim, bSuspendido, bBloqueado, sPassword, nCodUsuario, nIntentos, sNombreCompletoUsuario)

        If Not bUserExists Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmLogin_ValidacionUsuarioNoExiste))
            txtNombreLogin.Focus()
            Exit Function
        End If

        If txtPassword.EditValue.ToString = "" Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmLogin_ValidacionPasswordIncorrecta))
            txtPassword.Focus()
            Exit Function
        End If

        If bSuspendido Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmLogin_ValidacionUsuarioSuspendido))
            txtNombreLogin.Focus()
            Exit Function
        End If

        If bBloqueado Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmLogin_ValidacionUsuarioBloqueado))
            txtNombreLogin.Focus()
            Exit Function
        End If

        If txtNombreLogin.Text.Trim.ToUpper = "ADMIN" Or Not VALIDATE_NT Then

            If txtPassword.EditValue <> sPassword Then

                If nIntentos < INTENTOS_FALLIDOS Then
                    IncrementarContadorFallas(nCodUsuario)
                Else
                    BloquearUsuario(nCodUsuario)
                End If

                MensajeError(DescripcionCadena(Cadenas.CDN_frmLogin_ValidacionPasswordIncorrecta))
                txtPassword.Focus()
                Exit Function
            End If

        Else

            Dim cAut As New cAutenticacionLDAP

            If Not cAut.ValidateActiveDirectoryLogin(txtDominio.Text.Trim, txtNombreLogin.Text.Trim, txtPassword.Text) Then
                MensajeError(DescripcionCadena(Cadenas.CDN_frmLogin_ValidacionPasswordIncorrecta))
                txtPassword.Focus()
                Exit Function
            End If

        End If

        DatosOK = True

    End Function

    Private Function DatosUsuario(ByVal sNombreUsuario As String, ByRef bSuspendido As Boolean, ByRef bLocked As Boolean, ByRef sPass As String, ByRef nCodigoUsuario As Long, ByRef nFailedCount As Integer, ByRef sNombreCompleto As String) As Boolean

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = "SELECT      * " & _
               "FROM        USUARI " & _
               "WHERE       US_NOMBRE = '" & sNombreUsuario & "'"

        Try
            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)

                If .Rows.Count <= 0 Then
                    bSuspendido = False
                    bLocked = False
                    sPass = ""
                    nCodigoUsuario = -1
                    nFailedCount = 0
                    sNombreCompleto = ""
                    Return False
                Else
                    bSuspendido = .Rows(0)("US_ESTADO") <> 0
                    bLocked = .Rows(0)("US_LOCKED") <> 0
                    sPass = cEncrypt.DecryptString128Bit(.Rows(0)("US_PASSWD"))
                    nCodigoUsuario = .Rows(0)("US_CODUSU")
                    nFailedCount = .Rows(0)("US_INTENT")
                    sNombreCompleto = .Rows(0)("US_DESCRI")
                    Return True
                End If

            End With


        Catch ex As Exception
            TratarError(ex)
        End Try

    End Function

    Private Sub IncrementarContadorFallas(ByVal nCodUsu As Long)

        Dim sSQL As String

        sSQL = "UPDATE  USUARI " & _
               "SET     US_INTENT = US_INTENT + 1 " & _
               "WHERE   US_CODUSU = " & nCodUsu

        If oAdmTablas.EjecutarComandoSQL(sSQL) Then
            nIntentos = nIntentos + 1
        End If

    End Sub

    Private Sub ResetearContadorFallas(ByVal nCodUsu As Long)

        Dim sSQL As String

        sSQL = "UPDATE  USUARI " & _
               "SET     US_INTENT = 0 " & _
               "WHERE   US_CODUSU = " & nCodUsu

        Call oAdmTablas.EjecutarComandoSQL(sSQL)

    End Sub

    Private Sub BloquearUsuario(ByVal nCodUsu As Long)

        Dim sSQL As String

        sSQL = "UPDATE  USUARI " & _
               "SET     US_LOCKED = 1 " & _
               "WHERE   US_CODUSU = " & nCodUsu

        Call oAdmTablas.EjecutarComandoSQL(sSQL)

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If DatosOK() Then
            USUARIO_ACTUAL = nCodUsuario
            USUARIO_ACTUAL_NOMBRE = sNombreCompletoUsuario
            ResetearContadorFallas(USUARIO_ACTUAL)

            INIWrite(LOCAL_COMMON_INI_PATH, "Opciones", "LAST_USER", USUARIO_ACTUAL)
            INIWrite(LOCAL_COMMON_INI_PATH, "Opciones", "LAST_USER_NAME", txtNombreLogin.Text.Trim)
            Me.Close()
        End If

    End Sub

    Private Sub TratamientoDominio()

        If VALIDATE_NT Then
            lblDominio.Visible = True
            txtDominio.Visible = True
            txtDominio.Text = DOMAIN_DEFAULT
        End If

    End Sub

End Class