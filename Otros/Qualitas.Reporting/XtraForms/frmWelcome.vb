Public Class frmWelcome 

    Private CANCEL_NAVIGATION As Boolean

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionWelcome)

        lblDemo.Visible = MODO_DEMO
        pcBottom.Visible = MODO_DEMO

    End Sub

    Private Sub frmWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        On Error Resume Next

        'Me.BackgroundImage = Image.FromFile(LOGO_WELCOME_BACK_PATH)
        'Me.BackgroundImageLayout = ImageLayout.Center
        'Me.pic001.Image = Image.FromFile(LOGO_WELCOME_LEFT_PATH)
        'Me.pic002.Image = Image.FromFile(LOGO_WELCOME_RIGHT_PATH)

        oBrowser.Navigate(Application.StartupPath & "\HTML\" & Format(IDIOMA_ACTUAL, "000") & ".html")
        CANCEL_NAVIGATION = True

    End Sub

    Private Sub oBrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles oBrowser.DocumentCompleted

    End Sub

    Private Sub oBrowser_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles oBrowser.Navigating

        On Error Resume Next

        Dim sLink As String

        sLink = e.Url.AbsolutePath.Remove(0, InStrRev(e.Url.AbsolutePath, "/")).ToUpper


        Select Case sLink
            Case "NEW"
                frmMainX.PreCrearConsulta()
            Case "OPEN"
                frmMainX.PreAperturaConsulta()
            Case "DESIGN"
                frmMainX.PreDisenoConsulta()
            Case "DELETE"
                frmMainX.PreEliminacionConsulta()
            Case "IMPORT"
                frmMainX.PreImportarConsulta()
            Case "EXPORT"
                frmMainX.PreExportarConsulta()
            Case "CONNECTIONS"
                frmMainX.AdministrarConexiones()
            Case "SECURITY"
                frmMainX.VentanaUsuarios()
            Case "CATEGORIES"
                frmMainX.AdministrarCategorias()
            Case "USERPREF"
                frmMainX.OpcionesUsuario()
            Case "GLOBALPREF"
                frmMainX.OpcionesGenerales()
            Case "HELP"
                frmMainX.Ayuda()

        End Select

        e.Cancel = CANCEL_NAVIGATION

    End Sub
End Class