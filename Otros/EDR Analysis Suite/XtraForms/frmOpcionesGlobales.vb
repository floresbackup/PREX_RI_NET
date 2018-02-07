Public Class frmOpcionesGlobales 

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LocalizarFormulario()
        CargarOpciones()

    End Sub

    Private Sub CargarOpciones()

        txtRutaLocal.Text = LOCAL_FOLDER
        txtFormatoFechas.Text = FORMATO_FECHAS
        txtSimboloDecimal.Text = SIMBOLO_DECIMAL
        txtLiteralCadenas.Text = LITERAL_CADENAS
        txtLiteralFechas.Text = LITERAL_FECHAS

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionOpcionesGloables)

        lblTitulo.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_Titulo)
        lblRutaLocal.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_RutaLocal)
        lblInterpretacion.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_InterpretacionSQL)

        lblSimboloDecimal.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblSimboloDecimal)
        lblLiteralCadenas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblLiteralCadenas)
        lblLiteralFechas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblLiteralFechas)
        lblFormatoFechas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblFormatoFechas)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub GuardarOpciones()

        Dim sIniPath As String = Application.StartupPath & "\Config.ini"

        SIMBOLO_DECIMAL = txtSimboloDecimal.Text.Trim
        LITERAL_CADENAS = txtLiteralCadenas.Text.Trim
        LITERAL_FECHAS = txtLiteralFechas.Text.Trim
        FORMATO_FECHAS = txtFormatoFechas.Text.Trim
        LOCAL_FOLDER = txtRutaLocal.Text.Trim

        If Not LOCAL_FOLDER.EndsWith("\") Then
            LOCAL_FOLDER = LOCAL_FOLDER & "\"
        End If

        INIWrite(sIniPath, "OPCIONES", "SIMBOLO_DECIMAL", SIMBOLO_DECIMAL)
        INIWrite(sIniPath, "OPCIONES", "LITERAL_CADENAS", LITERAL_CADENAS)
        INIWrite(sIniPath, "OPCIONES", "LITERAL_FECHAS", LITERAL_FECHAS)
        INIWrite(sIniPath, "OPCIONES", "FORMATO_FECHAS", FORMATO_FECHAS)
        INIWrite(sIniPath, "OPCIONES", "LOCAL_FOLDER", LOCAL_FOLDER)

        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        GuardarOpciones()
    End Sub
End Class
