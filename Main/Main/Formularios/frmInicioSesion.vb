Imports Microsoft.VisualBasic.ApplicationServices
Imports Prex.Utils

Public Class frmInicioSesion

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Public Enum eModoAutenticacion As Integer
        AutenticacionExterna = 0
        AutenticacionInterna = 1
        AutenticacionNT = 2
        AutenticacionSQL = 3
    End Enum

    Private nModoAutenticacion As eModoAutenticacion = eModoAutenticacion.AutenticacionInterna

    Public Property ModoAutenticacion() As eModoAutenticacion
        Get
            Return nModoAutenticacion
        End Get
        Set(ByVal nModo As eModoAutenticacion)
            nModoAutenticacion = nModo
        End Set
    End Property

    Private bAutenticadoOK As Boolean = False

    Public ReadOnly Property Autenticado() As Boolean
        Get
            Return bAutenticadoOK
        End Get
    End Property

    Private bIntegraNT As Boolean
    Private nDiasPreviosRenov As Double
    Private oAdmTablas As New AdmTablas
    Private oAdmUsuarios As New AdmUsuarios
    Private datosUsuario As Usuario

    'Private bSoloAutorizar As Boolean = False

    'Public Sub SoloAutorizar()

    '    bSoloAutorizar = True

    '    lblHeader.Text = "Ejecutar como..."
    '    Me.Text = "Ejecutar como..."

    'End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If DatosOK() Then
            Validar()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Cargar()
        'Verifico la configuración de seguridad
        If Not AUTENTICACIONSQL AndAlso Not AUTENTICACIONGOOGLE Then
            ParametrosSeguridadNT()
        End If

        If bIntegraNT AndAlso Not AUTENTICACIONGOOGLE Then

            'Usuario NT
            txtUsuario.Text = SystemInformation.UserName

            'Dominios disponibles
            Dim oDominios() As ServerInfo = SQLConnector.GetSQLServers(SQLConnector.EServerTypes.SV_TYPE_DOMAIN_ENUM)

            cboDominio.Items.Clear()
            cboDominio.Items.Add(SystemInformation.UserDomainName)
            cboDominio.Text = SystemInformation.UserDomainName

            If Not oDominios Is Nothing Then
                For Each oDominio As ServerInfo In oDominios
                    If oDominio.Name <> SystemInformation.UserDomainName.ToString Then
                        cboDominio.Items.Add(oDominio.Name)
                    End If
                Next
            End If

        Else
            If AUTENTICACIONGOOGLE AndAlso
                    String.IsNullOrEmpty(Configuration.PrexConfigLocal.LastUser) OrElse (
                Not String.IsNullOrEmpty(Configuration.PrexConfigLocal.LastUser) AndAlso
                Configuration.PrexConfigLocal.LastUser.ToStringOrEmpty().ToUpper() <> SystemInformation.UserName.ToStringOrEmpty().ToUpper()) Then
                txtUsuario.Text = SystemInformation.UserName.ToStringOrEmpty()
            Else
                txtUsuario.Text = Prex.Utils.Configuration.PrexConfigLocal.LastUser.ToStringOrEmpty()
            End If

            txtPassword.Focus()
            cboDominio.Items.Add("(Ninguno)")
            cboDominio.Text = "(Ninguno)"
            cboDominio.Enabled = False
        End If

        If Not AUTENTICACIONSQL Then
            CargarEntidades()
        End If

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not AUTENTICACIONSQL Then
            oAdmTablas.ConnectionString = CONN_LOCAL
        End If

        Cargar()

    End Sub

    Private Sub ParametrosSeguridadNT()

        Dim sSQL As String
        Dim ds As DataSet

        Try

            sSQL = "SELECT    * " &
                "FROM      DIRSEG " &
                "WHERE     DS_VIGENT = 1"

            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)

                If .Rows.Count <> 0 Then

                    bIntegraNT = CBool(.Rows(0).Item("DS_SEGUNT"))
                    nDiasPreviosRenov = Val(.Rows(0).Item("DS_DIASRE"))
                    If bIntegraNT Then
                        ModoAutenticacion = eModoAutenticacion.AutenticacionNT
                    End If
                End If

            End With

            ds = Nothing

            Exit Sub

        Catch ex As Exception
            TratarError(ex, "ParametrosSeguridadNT")
        End Try

    End Sub

    Private Function DatosOK() As Boolean

        If txtUsuario.Text.Trim = "" Then
            txtUsuario.Focus()
            MensajeError("Proporcione el nombre de usuario")
            Return False
            Exit Function
        End If

        If txtPassword.Text.Trim = "" And txtPassword.Enabled Then
            txtPassword.Focus()
            MensajeError("Proporcione su contraseña")
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub CargarEntidades()

        Dim ad As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim dr As DataRow
        Dim nC As Integer = 0
        Dim sSQL As String = "SELECT TG_CODCON, TG_DESCRI FROM TABGEN WHERE TG_CODTAB = 1 AND TG_CODCON <> 999999 ORDER BY TG_DESCRI"
        Dim sConnTemp As String = CONN_LOCAL

        Try

            If AUTENTICACIONSQL Then
                sConnTemp = CONN_LOCAL & ";User id=" & txtUsuario.Text & ";password=" & txtPassword.Text & ";"
            End If

            ad = New OleDb.OleDbDataAdapter(sSQL, sConnTemp)
            dt = New DataTable

            ad.Fill(dt)

            cboEntidad.Items.Clear()

            For Each dr In dt.Rows
                cboEntidad.Items.Add(New Prex.Utils.Entities.clsItem(Convert.ToInt64(dr(0).ToString), dr(1).ToString))
            Next

            Application.DoEvents()

            If cboEntidad.Items.Count > 0 Then
                'Entidad predeterminada
                SelCombo(cboEntidad, oAdmTablas.DevolverValor("TABGEN", "TG_DESCRI", "TG_CODTAB = 1 AND TG_NUME01 = 1").ToString)
            End If

        Catch ex As Exception
            TratarError(ex, "CargarCombo")
        End Try

    End Sub

    Private Function InicioSQL() As Boolean

        Dim sConnTemp As String

        Try

            sConnTemp = CONN_LOCAL & ";User id=" & txtUsuario.Text & ";password=" & txtPassword.Text & ";"
            oAdmTablas.ConnectionString = sConnTemp

            If oAdmTablas.EjecutarComandoAsincrono("SELECT GETDATE()") Then
                ParametrosSeguridadNT()
                'Cargar()
                cboEntidad.Enabled = True
                CargarEntidades()
                bIntegraNT = True
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TratarError(ex, "InicioSQL")
        End Try

    End Function

    Private Sub cboEntidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEntidad.GotFocus

        'SOLO PARA AUTENTICACION SQL
        If AUTENTICACIONSQL Then
            If DatosOK() Then
                If Not InicioSQL() Then
                    txtUsuario.Focus()
                    MensajeError("Nombre de usuario o contraseña SQL incorrecto")
                End If
            End If
        End If

    End Sub

    Public Sub Validar()


        Select Case nModoAutenticacion

            Case eModoAutenticacion.AutenticacionExterna
                bAutenticadoOK = True

            Case eModoAutenticacion.AutenticacionInterna
                bAutenticadoOK = AutenticacionInterna()

            Case eModoAutenticacion.AutenticacionNT
                bAutenticadoOK = AutenticacionNT()

            Case eModoAutenticacion.AutenticacionSQL
                bAutenticadoOK = AutenticacionModoSQL()

            Case Else
                bAutenticadoOK = False

        End Select

        If bAutenticadoOK Then
            Me.Close()
        End If

    End Sub

    Private Function ValidarInicioNT() As Boolean

        Dim sError As String = ""
        Dim oAuth As AutenticacionActiveDirectory = New AutenticacionActiveDirectory()

        oAuth.Usuario = datosUsuario.Nombre
        oAuth.Password = datosUsuario.Password
        oAuth.Dominio = datosUsuario.Dominio
        oAuth.TipoAutenticacion = DirectoryServices.AuthenticationTypes.SecureSocketsLayer

        If oAuth.Autenticar(sError) Then
            Return True
        Else
            MensajeError(sError)
        End If

    End Function

    Private Function UsuarioOK(ByVal sNombreUsuario As String) As Boolean

        Dim sSQL As String
        Dim ds As DataSet

        Try

            sSQL = "SELECT    * " &
                "FROM      USUARI " &
                "WHERE     US_NOMBRE = '" & sNombreUsuario & "'"
            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds.Tables(0)

                If .Rows.Count > 0 Then
                    If .Rows(0).Item("US_BLOQUE") = 0 Then
                        If .Rows(0).Item("US_FECBAJ") = CDate("01-01-1900") Then

                            datosUsuario.Nombre = sNombreUsuario
                            datosUsuario.Codigo = .Rows(0).Item("US_CODUSU")
                            datosUsuario.Password = txtPassword.Text
                            datosUsuario.Dominio = cboDominio.Text.Trim
                            datosUsuario.Entidad = Val(LlaveCombo(cboEntidad))

                            Return True

                        End If
                    End If
                End If

            End With

            ds = Nothing

        Catch ex As Exception
            TratarError(ex, "UsuarioOK")
        End Try

    End Function

    Private Function AutenticacionModoSQL() As Boolean

        Dim bResult As Boolean = InicioSQL()

        If bResult Then
            'Si no estoy ejecutando "Ejecutar como.."
            If Not bSoloAutorizar Then
                CONN_LOCAL = CONN_LOCAL & ";User id=" & txtUsuario.Text.Trim & ";password=" & txtPassword.Text & ";"
                oAdmTablas.ConnectionString = CONN_LOCAL
            End If
        Else
            MensajeError("Nombre de usuario o contraseña SQL incorrecto")
        End If

        Return bResult

    End Function

    Private Function AutenticacionExterna() As Boolean

        ' TIPO BANCO DE CORDOBA
        If SEGURIDAD_INTEGRADA Then

            If UsuarioOK(txtUsuario.Text.Trim) Then
                Return True
            Else
                MensajeError("El usuario proporcionado no existe o bien no está habilitado para iniciar la sesión")
            End If

        End If

    End Function

    Private Function AutenticacionNT() As Boolean

        Dim bResult As Boolean

        If bIntegraNT And txtUsuario.Text.ToUpper <> "ADMIN" Then

            If Not UsuarioOK(txtUsuario.Text.Trim) Then
                MensajeError("El usuario proporcionado no existe o bien no está habilitado para iniciar la sesión")
                Return False
                Exit Function
            End If

            bResult = ValidarInicioNT()
            If bResult Then
                If bSoloAutorizar Then
                    USUARIO_AUTORIZADO = True
                    NOMBRE_USU_AUTORIZADO = txtUsuario.Text.Trim
                    CODIGO_ENTIDAD_AUTH = Val(LlaveCombo(cboEntidad))
                Else
                    NOMBRE_ENTIDAD = cboEntidad.Text
                    CODIGO_ENTIDAD = Val(LlaveCombo(cboEntidad))
                    UsuarioActual.Entidad = CODIGO_ENTIDAD
                    UsuarioActual.Codigo = oAdmTablas.DevolverValor("USUARI", "US_CODUSU", "US_NOMBRE='" & txtUsuario.Text & "'")
                    UsuarioActual.Nombre = txtUsuario.Text.Trim
                    UsuarioActual.Descripcion = oAdmTablas.DevolverValor("USUARI", "US_DESCRI", "US_NOMBRE='" & txtUsuario.Text & "'")
                    UsuarioActual.Dominio = cboDominio.Text
                    GuardarLOG(AccionesLOG.AL_INGRESO_SISTEMA, "")
                End If
                Return True
            Else
                Return False
            End If
        ElseIf txtUsuario.Text.ToUpper = "ADMIN" Then

            bResult = AutenticacionInterna()
            Return bResult
        End If
        Return False
    End Function

    Private Function AutenticacionInterna() As Boolean

        Dim sMotivoError As String
        Dim nCantidadDiasVto As Double
        Dim bLoginOK As Boolean
        Dim eRespuesta As DialogResult
        Try
            Me.Cursor = Cursors.WaitCursor

            Try

                If AUTENTICACIONGOOGLE Then Return AutenticarGoogle(True)

                Dim bResult = oAdmUsuarios.ValidarUsuario(txtUsuario.Text, txtPassword.Text, Val(LlaveCombo(cboEntidad)), nCantidadDiasVto, sMotivoError)


                If Not bResult Then
                    MensajeError(sMotivoError)
                    txtUsuario.Focus()
                    Return False
                    Exit Function
                End If

                'Si el loggin fue exitoso:
                If nCantidadDiasVto > nDiasPreviosRenov Then
                    bLoginOK = True
                Else
                    If nCantidadDiasVto > 0 Then
                        eRespuesta = MessageBox.Show("Su contraseña vencerá en " & nCantidadDiasVto & " día(s)." & vbCrLf & vbCrLf & "¿Desea renovarla ahora?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Else
                        eRespuesta = MessageBox.Show("Su contaseña ha vencido. Presione el botón Aceptar para renovarla", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    If (eRespuesta = DialogResult.OK OrElse eRespuesta = DialogResult.Yes) Then

                        Dim frmCambiarPassword As New Prex.Utils.Security.Forms.fmrChangePass

                        frmCambiarPassword.PasarDatos(txtUsuario.Text.Trim, True, txtPassword.Text)

                        If frmCambiarPassword.ShowDialog = DialogResult.OK Then
                            If eRespuesta = DialogResult.Yes Then MensajeInformacion("Recuerde renovar su contraseña la próxima vez que inicie la sesión")
                            bLoginOK = True
                        Else
                            bLoginOK = False
                        End If
                    Else
                        bLoginOK = True
                    End If
                End If

                ' Por ahora continuamos
                If bLoginOK Then
                    SetearDatosDeAcceso()

                    GuardarLOG(AccionesLOG.AL_INGRESO_SISTEMA, "")
                    'End If

                    Return True
                Else
                    MensajeError("Imposible iniciar sesión en este momento. Renueve su contraseña la próxima vez que inicie el sistema e inténtelo nuevamente")
                End If

            Catch ex As Exception
                TratarError(ex, "AutenticacionInterna")
            End Try

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Sub SetearDatosDeAcceso()
        NOMBRE_ENTIDAD = cboEntidad.Text
        CODIGO_ENTIDAD = Val(LlaveCombo(cboEntidad))
        UsuarioActual.Entidad = CODIGO_ENTIDAD
        UsuarioActual.Codigo = oAdmTablas.DevolverValor("USUARI", "US_CODUSU", "US_NOMBRE='" & txtUsuario.Text & "'", 0)
        UsuarioActual.Nombre = txtUsuario.Text.Trim
        UsuarioActual.Descripcion = oAdmTablas.DevolverValor("USUARI", "US_DESCRI", "US_NOMBRE='" & txtUsuario.Text & "'", String.Empty)
        UsuarioActual.Dominio = cboDominio.Text
        If UsuarioActual.Codigo > 0 Then
            Prex.Utils.Configuration.CargarUsuarioActual(UsuarioActual.Nombre)
        End If
    End Sub

    Private Function AutenticarGoogle(reintento As Boolean) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim userInfo As Security.SSO.Google.UserInfoWrapper = Nothing
            Try


                userInfo = Security.NaranjaSecurity.AutenticarConGoogle(txtUsuario.Text)
                If userInfo Is Nothing OrElse userInfo.Nombre.IsNullOrEmpty Then
                    Return False
                End If

                If userInfo.DirectoryData?.customSchemas?.PREX Is Nothing OrElse
                        userInfo.DirectoryData.customSchemas?.PREX?.Role?.IsNullOrEmpty() Then
                    Throw New UnauthorizedAccessException("rol_access_denied")
                End If


                Dim ds = oAdmUsuarios.ValidarUsuario(txtUsuario.Text)

                If ds Is Nothing Then
                    CODIGO_ENTIDAD = Val(LlaveCombo(cboEntidad))
                    Dim frm As New FrmAltaUsuarioNaranja(txtUsuario.Text.Trim, userInfo)
                    If frm.ShowDialog() = DialogResult.OK Then
                        SetearDatosDeAcceso()
                        Return True
                    Else
                        Return False
                    End If
                Else
                    SetearDatosDeAcceso()
                    Return True
                End If
            Catch ex As Exception
                If TypeOf ex Is UnauthorizedAccessException Then
                    Dim extraData = String.Empty
                    If userInfo IsNot Nothing Then
                        If userInfo.DirectoryData?.customSchemas?.PREX Is Nothing Then
                            extraData = " (CustomSchemas.PREX is nothing - "
                        Else
                            extraData = $" (CustomSchemas.PREX is Rol - "
                        End If
                        If String.IsNullOrEmpty(userInfo.DirectoryData.customSchemas?.PREX?.Role) Then
                            extraData += "PREX.Role is nothing)"
                        Else
                            extraData += $"PREX.Role is {userInfo.DirectoryData.customSchemas?.PREX?.Role})"
                        End If
                    End If
                    Select Case ex.Message
                        Case "invalid_grant"
                            If reintento AndAlso Prex.Utils.MensajesForms.MostrarPregunta("No posee los permisos suficientes. ¿Desea volver autenticar?") = DialogResult.Yes Then
                                Return AutenticarGoogle(False)
                            Else
                                MensajesForms.MostrarError("Se denegó el acceso a la aplicación." + extraData)
                                Return False
                            End If
                        Case "access_denied"
                            MensajesForms.MostrarError("Se denegó el acceso a la aplicación." + extraData)
                            Return False
                        Case "rol_access_denied"
                            MensajesForms.MostrarError($"No posee permisos para acceder a la aplicación {extraData}. Contáctese con el administrador.")
                            Return False
                        Case Else

                    End Select
                End If

                ManejarErrores.TratarError(ex, "AutenticarGoogle", "Ocurrió un error al intentar autenticar usuario en google", True, True)
                Return False
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function



    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus

      'SOLO PARA AUTENTICACION SQL
      If AUTENTICACIONSQL Then
         InicioSQL()
      End If

   End Sub

   Private Sub frmInicioSesion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

		If txtUsuario.Text.Trim.Equals("") Then
			txtUsuario.Focus()
		Else
			txtPassword.Select()

		End If

		If ID_SISTEMA > 0 Then
			pblCitiCiberrark.Visible = True
			picErrorCiberrark.Visible = CYBERRARKPASS.Trim = String.Empty
			picOkCiberrark.Visible = Not picErrorCiberrark.Visible
			If picErrorCiberrark.Visible Then
				lblciti.Text = "Error conexión con Cyberark"
				lblciti.ForeColor = Color.DarkRed
			Else
				lblciti.Text = "Conexión con Cyberark"
				lblciti.ForeColor = Color.DarkGreen
			End If
		Else
			pblCitiCiberrark.Visible = False
		End If
	End Sub
End Class
