Public Class frmWelcome 

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionWelcome)

        lblDemo.Visible = MODO_DEMO

    End Sub

    Private Sub frmWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        On Error Resume Next

        Me.BackgroundImage = Image.FromFile(LOGO_WELCOME_BACK_PATH)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.pic001.Image = Image.FromFile(LOGO_WELCOME_LEFT_PATH)
        Me.pic002.Image = Image.FromFile(LOGO_WELCOME_RIGHT_PATH)

    End Sub
End Class