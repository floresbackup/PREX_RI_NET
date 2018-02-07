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

        chkEnableSQL.Checked = IIf(EDICION_SQL_HABILITADA = 0, False, True)
        chkTablas.Checked = IIf(AQB_MOSTRAR_TABLAS = 0, False, True)
        chkVistas.Checked = IIf(AQB_MOSTRAR_VISTAS = 0, False, True)
        chkSPs.Checked = IIf(AQB_MOSTRAR_SPS = 0, False, True)

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionOpcionesGloables)

        grpTitulo.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_Titulo)
        lblRutaLocal.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_RutaLocal)
        grpInterpretacion.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_InterpretacionSQL)
        chkEnableSQL.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_EdicionSQLHabilitada)
        grpDisenadoVisual.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_MostrarEnAQB)
        chkTablas.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_Tablas)
        chkVistas.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_Vistas)
        chkSPs.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_Procedimientos)
        grpOtras.Text = DescripcionCadena(Cadenas.CDN_frmOpcionesGlobales_OtrasOpciones)

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
        EDICION_SQL_HABILITADA = IIf(chkEnableSQL.Checked, 1, 0)
        AQB_MOSTRAR_TABLAS = IIf(chkTablas.Checked, 1, 0)
        AQB_MOSTRAR_VISTAS = IIf(chkVistas.Checked, 1, 0)
        AQB_MOSTRAR_SPS = IIf(chkSPs.Checked, 1, 0)

        If Not LOCAL_FOLDER.EndsWith("\") Then
            LOCAL_FOLDER = LOCAL_FOLDER & "\"
        End If

        INIWrite(sIniPath, "OPCIONES", "SIMBOLO_DECIMAL", SIMBOLO_DECIMAL)
        INIWrite(sIniPath, "OPCIONES", "LITERAL_CADENAS", LITERAL_CADENAS)
        INIWrite(sIniPath, "OPCIONES", "LITERAL_FECHAS", LITERAL_FECHAS)
        INIWrite(sIniPath, "OPCIONES", "FORMATO_FECHAS", FORMATO_FECHAS)
        INIWrite(sIniPath, "OPCIONES", "LOCAL_FOLDER", LOCAL_FOLDER)
        INIWrite(sIniPath, "OPCIONES", "SQL_EDIT_ENABLED", EDICION_SQL_HABILITADA.ToString)
        INIWrite(sIniPath, "OPCIONES", "SHOW_TABLES", AQB_MOSTRAR_TABLAS.ToString)
        INIWrite(sIniPath, "OPCIONES", "SHOW_VIEWS", AQB_MOSTRAR_VISTAS.ToString)
        INIWrite(sIniPath, "OPCIONES", "SHOW_SPS", AQB_MOSTRAR_SPS.ToString)

        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        GuardarOpciones()
    End Sub

End Class
