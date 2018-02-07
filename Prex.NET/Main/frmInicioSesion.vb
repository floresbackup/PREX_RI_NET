Public Class frmInicioSesion

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim oAuth As AutenticacionActiveDirectory = New AutenticacionActiveDirectory()
        Dim sError As String = ""

        oAuth.Usuario = txtUsuario.Text
        oAuth.Password = txtPassword.Text
        oAuth.Dominio = cboDominio.Text
        oAuth.TipoAutenticacion = DirectoryServices.AuthenticationTypes.SecureSocketsLayer

        If oAuth.Autenticar(sError) Then
            frmMain.Show()
            Me.Close()
        Else
            MessageBox.Show(sError, "Error de autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Cargar()

        'Usuario NT
        txtUsuario.Text = SystemInformation.UserName

        'Dominios disponibles
        Dim oDominios() As ServerInfo = SQLConnector.GetSQLServers(SQLConnector.EServerTypes.SV_TYPE_DOMAIN_ENUM)

        cboDominio.Items.Clear()
        cboDominio.Items.Add(SystemInformation.UserDomainName.ToString)
        cboDominio.Text = SystemInformation.UserDomainName.ToString

        If Not oDominios Is Nothing Then
            For Each oDominio As ServerInfo In oDominios
                If oDominio.Name <> SystemInformation.UserDomainName.ToString Then
                    cboDominio.Items.Add(oDominio.Name)
                End If
            Next
        End If

        'Entidades
        '        Dim sSQL As String = "SELECT * FROM TABGEN WHERE TG_CODTAB = 1 AND TG_CODCON <> 999999 ORDER BY TG_DESCRI"
        '        Dim oConn As New SQLConnector()

        'dim dt      as New DataTable (
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Cargar()
    End Sub

    Private Sub frmInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
