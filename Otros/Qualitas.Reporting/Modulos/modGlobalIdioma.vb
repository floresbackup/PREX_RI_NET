Module modGlobalIdioma

    Public Const IDIOMA_INGLES = 2

    Public Structure CadenaIdioma
        Public CodigoCadena As Cadenas
        Public DescripcionCadena As String
    End Structure

    Public colCadenas As New Collection

    Public Enum Cadenas
        CDN_mnuArchivo = 1
        CDN_mnuArchivoPreferencias = 2
        CDN_mnuArchivoSalir = 3
        CDN_mnuConsulta = 4
        CDN_mnuConsultaCrear = 5
        CDN_mnuConsultaAbrir = 6
        CDN_mnuConsultaDisenar = 7
        CDN_mnuConsultaImportar = 8
        CDN_mnuConsultaExportar = 9
        CDN_mnuConsultaCategorias = 10
        CDN_mnuVer = 11
        CDN_mnuVerBH = 12
        CDN_mnuVerBE = 13
        CDN_mnuVerPanelConsultas = 14
        CDN_mnuVerPanelFavoritas = 15
        CDN_mnuVentana = 16
        CDN_mnuAyuda = 17
        CDN_mnuAyudaContenido = 18
        CDN_mnuAyudaAcercaDe = 19
        CDN_mnuArchivoOpcionesGlobales = 20
        CDN_mnuArchivoSeguridadUsuarios = 21
        CDN_mnuArchivoConexiones = 22

        CDN_mnuAgregarFavoritas = 30
        CDN_mnuConfiguracion = 31
        CDN_rpConsultas = 32
        CDN_rpOtros = 33
        CDN_rpgAyuda = 34
        CDN_rpgImportacion = 35
        CDN_rpgComun = 36
        CDN_GrupoListViewFavoritas = 37
        CDN_WarningEliminarFavorita = 38
        CDN_mnuEliminarConsulta = 39


        CDN_Descripciones_NuevaConsulta = 50
        CDN_Descripciones_AbrirConsulta = 51
        CDN_Descripciones_DisenarConsulta = 52
        CDN_Descripciones_ImportarConsulta = 53
        CDN_Descripciones_ExportarConsulta = 54
        CDN_Descripciones_OpcionesUsuario = 55
        CDN_Descripciones_OpcionesGlobales = 56
        CDN_Descripciones_VerPanelConsultas = 57
        CDN_Descripciones_VerPanelFavoritas = 58
        CDN_Descripciones_Ventanas = 59
        CDN_Descripciones_Seguridad = 60
        CDN_Descripciones_Conexiones = 61
        CDN_Descripciones_Categorias = 62
        CDN_Descripciones_Ver = 63
        CDN_Descripciones_Contenido = 64
        CDN_Descripciones_About = 65
        CDN_Descripciones_Eliminar = 66


        CDN_pnlConsultas = 100
        CDN_pnlFavoritas = 101
        CDN_nodRaizConsultas = 170
        CDN_nodRaizResultadosBusqueda = 171
        CDN_stcStatus = 200

        'Caption de ventanas
        CDN_WindowCaptionTablaGeneral = 180
        CDN_WindowCaptionExportarXLS = 181
        CDN_WindowCaptionSeleccionConsulta = 182
        CDN_WindowCaptionExportarHTML = 183
        CDN_WindowCaptionDrillDown = 184
        CDN_WindowCaptionPersonalizarCubo = 185
        CDN_WindowCaptionColumnaCubo = 186
        CDN_WindowCaptionConexiones = 187
        CDN_WindowCaptionConexion = 188
        CDN_WindowCaptionExportarImagen = 189
        CDN_WindowCaptionCategorias = 190
        CDN_WindowCaptionOpcionesUsuario = 191
        CDN_WindowCaptionDisenoConsulta = 192
        CDN_WindowCaptionParametro = 193
        CDN_WindowCaptionFormato = 194
        CDN_WindowCaptionResultado = 195
        CDN_WindowCaptionBuscarReemplazar = 196
        CDN_WindowCaptionPassword = 197
        CDN_WindowCaptionSeguridad = 198
        CDN_WindowCaptionUsuario = 199
        CDN_WindowCaptionLogin = 179
        CDN_WindowCaptionGuardarInforme = 178
        CDN_WindowCaptionWelcome = 177
        CDN_WindowCaptionExportarConsulta = 176
        CDN_WindowCaptionQueryBuilder = 175
        CDN_WindowCaptionVariables = 174
        CDN_WindowCaptionImportarConsulta = 173
        CDN_WindowCaptionEliminarConsulta = 172
        CDN_WindowCaptionOpcionesGloables = 169
        CDN_WindowCaptionOpcionesSeguridad = 168
        CDN_WindowCaptionGuardarLayout = 167
        CDN_WindowCaptionCargarLayout = 166
        CDN_WindowCaptionDisenoCustomSearch = 165
        CDN_WindowCaptionConstruirExpresion = 164
        CDN_WindowCaptionFormatoCondicional = 163

        'Varios
        CDN_lblProcesando = 300
        CDN_lblProcesandoTip = 301
        CDN_lblProcesandoTipNoCancelar = 302

        CDN_ConsultaCancelada = 310

        CDN_ParametroRequerido = 320
        CDN_ParametroNoNumerico = 321
        CDN_ParametroNoFecha = 323
        CDN_ParametroNoValidaIGUAL = 324
        CDN_ParametroNoValidaDISTINTO = 325
        CDN_ParametroNoValidaMAYOR = 326
        CDN_ParametroNoValidaMENOR = 327
        CDN_ParametroNoValidaMAYORoIGUAL = 328
        CDN_ParametroNoValidaMENORoIGUAL = 329
        CDN_ParametroNoValidaENTRE = 330


        CDN_GeneralOK = 10000
        CDN_GeneralCancelar = 10001
        CDN_GeneralCerrar = 10002
        CDN_GeneralSi = 10005
        CDN_GeneralNo = 10006
        CDN_GeneralConexion = 10010
        CDN_GeneralDescripcion = 10011
        CDN_GeneralHasta3ConsultasModoDemo = 10020
        CDN_GeneralImportarNoHabilitadoModoDemo = 10021

        CDN_GeneralOcurrencias = 10050
        CDN_GeneralAbriendoConsulta = 10061
        CDN_GeneralAbriendoConsultaTip = 10062
        CDN_GeneralSinPermisos = 10063
        CDN_GeneralSinPermisosConsulta = 10064

        CDN_GeneralNoHayConexiones = 10070

        ' Formulario de ejecucion de consulta

        CDN_frmConsulta_btnEjecutar = 1000
        CDN_frmConsulta_HeaderParametros = 1001
        CDN_frmConsulta_TabParametros = 1002
        CDN_frmConsulta_TabResultados = 1003
        CDN_frmConsulta_TabCubo = 1004
        CDN_frmConsulta_RibbonPageOpciones = 1010
        CDN_frmConsulta_BotonResultados = 1015
        CDN_frmConsulta_GrupoConjuntos = 1016
        CDN_frmConsulta_GrupoImpresion = 1018
        CDN_frmConsulta_GrupoExportar = 1019
        CDN_frmConsulta_GrupoOtrasOpciones = 1020
        CDN_frmConsulta_RibbonPageCubo = 1021
        CDN_frmConsulta_GrupoCubo = 1022
        CDN_frmConsulta_GrupoGrafico = 1023
        CDN_frmConsulta_GrupoComun = 1024

        CDN_frmConsulta_BotonPreview = 1030
        CDN_frmConsulta_BotonImprimir = 1031
        CDN_frmConsulta_BotonExportarHTML = 1032
        CDN_frmConsulta_Autofiltro = 1033
        CDN_frmConsulta_FilasSubtotales = 1034
        CDN_frmConsulta_FilaTotal = 1035
        CDN_frmConsulta_GuardarLayout = 1036
        CDN_frmConsulta_GroupByBox = 1037
        CDN_frmConsulta_FieldChooser = 1038
        CDN_frmConsulta_CargarLayout = 1057

        CDN_frmConsulta_PersonalizarCamposCubo = 1039
        CDN_frmConsulta_OrientacionGrafico = 1040
        CDN_frmConsulta_OrientacionVertical = 1041
        CDN_frmConsulta_OrientacionHorizontal = 1042
        CDN_frmConsulta_EjeX = 1043
        CDN_frmConsulta_EjeY = 1044
        CDN_frmConsulta_Leyendas = 1045
        CDN_frmConsulta_Valores = 1046
        CDN_frmConsulta_EstiloGrafico = 1047
        CDN_frmConsulta_EstiloPuntos = 1048
        CDN_frmConsulta_EstiloLineas = 1049
        CDN_frmConsulta_EstiloBarras = 1050
        CDN_frmConsulta_EstiloBarrasApiladas = 1051
        CDN_frmConsulta_EstiloArea = 1052
        CDN_frmConsulta_EstiloTorta = 1053
        CDN_frmConsulta_AlternarVisibilidad = 1054
        CDN_frmConsulta_ImagenGrafico = 1055
        CDN_frmConsulta_GraficoRotado = 1056
        CDN_frmConsulta_EstiloLineaHistograma = 1060
        CDN_frmConsulta_EstiloLineaCurva = 1061
        CDN_frmConsulta_EstiloAreaCurva = 1062
        CDN_frmConsulta_EstiloAreaApilada = 1063
        CDN_frmConsulta_EstiloAreaCurvaApilada = 1064
        CDN_frmConsulta_EstiloAreaApiladaCompleta = 1065
        CDN_frmConsulta_EstiloAreaCurvaApiladaCompleta = 1066
        CDN_frmConsulta_EstiloRadarPunto = 1067
        CDN_frmConsulta_EstiloRadarLinea = 1068
        CDN_frmConsulta_EstiloRadarArea = 1069
        CDN_frmConsulta_EstiloDona = 1070

        CDN_frmConsulta_TabInformes = 1080
        CDN_frmConsulta_InformeGrupoLVPropios = 1081
        CDN_frmConsulta_InformeGrupoLVPublicos = 1082
        CDN_frmConsulta_InformePublico = 1083
        CDN_frmConsulta_InformeBotonNuevo = 1084
        CDN_frmConsulta_InformeBotonAbrir = 1085
        CDN_frmConsulta_InformeBotonDisenar = 1086
        CDN_frmConsulta_InformeBotonEliminar = 1087
        CDN_frmConsulta_InformeMenuNuevo = 1088
        CDN_frmConsulta_InformeMenuAbrir = 1089
        CDN_frmConsulta_InformeMenuDisenar = 1090
        CDN_frmConsulta_InformeMenuEliminar = 1091
        CDN_frmConsulta_InformeEdicionNoPermitida = 1092
        CDN_frmConsulta_InformeEliminacionNoPermitida = 1093
        CDN_frmConsulta_InformeWarningEliminar = 1094
        CDN_frmConsulta_InformeCargarDesdeArchivo = 1095

        ' Formulario de guardar el informe

        CDN_frmGuardarInforme_NombreArchivo = 1100
        CDN_frmGuardarInforme_Publico = 1101
        CDN_frmGuardarInforme_NombreInforme = 1102
        CDN_frmGuardarInforme_WarningNombreVacio = 1110
        CDN_frmGuardarInforme_WarningNombreExiste = 1111


        ' Formulario seleccion de tabla general

        CDN_frmTablaGeneral_CTRLTip = 2000

        ' Formulario de exportacion a Excel

        CDN_frmExportarXLS_lblFileName = 2100
        CDN_frmExportarXLS_chkCellBorders = 2101
        CDN_frmExportarXLS_chkNativeFormat = 2102
        CDN_frmExportarXLS_SaveDialogFilter = 2103
        CDN_frmExportarXLS_FileAlreadyExists = 2104

        ' Varios de formatos de export
        CDN_FormatoExportacion_PDF_FilterDialog = 2198
        CDN_FormatoExportacion_XML_FilterDialog = 2199

        ' Formulario de seleccion de consulta

        CDN_frmSeleccionConsulta_lblSeleccionarConsulta = 2200
        CDN_frmSeleccionConsulta_lblTip = 2201

        ' Formulario de exportacion a HTML

        CDN_frmExportarHTML_lblFileName = 2300
        CDN_frmExportarHTML_lblPageTitle = 2301
        CDN_frmExportarHTML_lblBorderWidth = 2302
        CDN_frmExportarHTML_lblBorderColor = 2303
        CDN_frmExportarHTML_lblPaginado = 2304
        CDN_frmExportarHTML_SaveDialogFilter = 2305
        CDN_frmExportarHTML_PaginadoOpcion00 = 2306
        CDN_frmExportarHTML_PaginadoOpcion01 = 2307
        CDN_frmExportarHTML_PaginadoOpcion02 = 2308
        CDN_frmExportarHTML_QuitarSimbolos = 2309

        ' Formulario de exportar a imagen
        CDN_frmExportarImagen_lblFileName = 2400
        CDN_frmExportarImagen_lblFormato = 2401

        ' Formulario de personalizar tabla dinamica

        CDN_frmPersonalizarCubo_HeaderListView = 2500
        CDN_frmPersonalizarCubo_Agregar = 2501
        CDN_frmPersonalizarCubo_Propiedades = 2502
        CDN_frmPersonalizarCubo_Eliminar = 2503
        CDN_frmPersonalizarCubo_WarningEliminar = 2505
        CDN_frmPersonalizarCubo_AreaFiltros = 2510
        CDN_frmPersonalizarCubo_AreaFilas = 2511
        CDN_frmPersonalizarCubo_AreaColumnas = 2512
        CDN_frmPersonalizarCubo_AreaTotales = 2513
        CDN_frmPersonalizarCubo_TotalesFilas = 2520
        CDN_frmPersonalizarCubo_GrandesTotalesFilas = 2521
        CDN_frmPersonalizarCubo_TotalesColumnas = 2522
        CDN_frmPersonalizarCubo_GrandesTotalesColumnas = 2523
        CDN_frmPersonalizarCubo_GrupoTotales = 2524


        ' Formulario de ABM de columna tabla dinamica

        CDN_frmColumnaCubo_NombreCampo = 2600
        CDN_frmColumnaCubo_Titulo = 2601
        CDN_frmColumnaCubo_Formato = 2603
        CDN_frmColumnaCubo_Ubicacion = 2604
        CDN_frmColumnaCubo_FuncionAgr = 2605
        CDN_frmColumnaCubo_TipoResumen = 2606
        CDN_frmColumnaCubo_Recuento = 2610
        CDN_frmColumnaCubo_Suma = 2611
        CDN_frmColumnaCubo_Minimo = 2612
        CDN_frmColumnaCubo_Maximo = 2613
        CDN_frmColumnaCubo_Promedio = 2614
        CDN_frmColumnaCubo_StdDevEst = 2615
        CDN_frmColumnaCubo_StdDev = 2616
        CDN_frmColumnaCubo_VarEst = 2617
        CDN_frmColumnaCubo_Var = 2618
        CDN_frmColumnaCubo_Predeterminado = 2620
        CDN_frmColumnaCubo_VariacionAbsoluta = 2621
        CDN_frmColumnaCubo_VariacionPrc = 2622
        CDN_frmColumnaCubo_PrcSobreColumna = 2623
        CDN_frmColumnaCubo_PrcSobreFila = 2624

        CDN_frmColumnaCubo_FormatoNinguno = 2630
        CDN_frmColumnaCubo_FormatoNumero = 2631
        CDN_frmColumnaCubo_FormatoFecha = 2632

        CDN_frmColumnaCubo_IntervaloGrupo = 2640
        CDN_frmColumnaCubo_IntervaloGrupoRangoNumericos = 2641

        CDN_frmColumnaCubo_IntervaloAlfabetico = 2650
        CDN_frmColumnaCubo_IntervaloNumerico = 2651
        CDN_frmColumnaCubo_IntervaloFecha = 2652
        CDN_frmColumnaCubo_IntervaloDiaSemana = 2653
        CDN_frmColumnaCubo_IntervaloDiaMes = 2654
        CDN_frmColumnaCubo_IntervaloDiaAnio = 2655
        CDN_frmColumnaCubo_IntervaloSemanaMes = 2656
        CDN_frmColumnaCubo_IntervaloSemanaAnio = 2657
        CDN_frmColumnaCubo_IntervaloMes = 2658
        CDN_frmColumnaCubo_IntervaloCuatrimestre = 2659
        CDN_frmColumnaCubo_IntervaloAnio = 2660
        CDN_frmColumnaCubo_IntervaloEdadDias = 2661
        CDN_frmColumnaCubo_IntervaloEdadSemanas = 2662
        CDN_frmColumnaCubo_IntervaloEdadMeses = 2663
        CDN_frmColumnaCubo_IntervaloEdadAnios = 2664
        CDN_frmColumnaCubo_IntervaloHora = 2665
        CDN_frmColumnaCubo_IntervaloPredeterminado = 2666



        ' Formulario ABM conexiones

        CDN_frmConexiones_Agregar = 2700
        CDN_frmConexiones_Propiedades = 2701
        CDN_frmConexiones_Eliminar = 2702

        ' Formulario Conexion

        CDN_frmConexion_Nombre = 2800
        CDN_frmConexion_Descripcion = 2801
        CDN_frmConexion_CadenaConexion = 2802
        CDN_frmConexion_GenerarCadena = 2803
        CDN_frmConexion_ValidarNombre = 2804
        CDN_frmConexion_ValidarCadena = 2805
        CDN_frmConexion_ImposibleEliminar = 2806
        CDN_frmConexion_WarningEliminar = 2807
        CDN_frmConexion_DiccionarioDatos = 2808
        CDN_frmConexion_TipoConexion = 3050

        ' Formulario Categorias

        CDN_frmCategorias_MenuAgregar = 2900
        CDN_frmCategorias_MenuRenombrar = 2901
        CDN_frmCategorias_MenuEliminar = 2902
        CDN_frmCategorias_Tip = 2903
        CDN_frmCategorias_ImposibleEliminar = 2904
        CDN_frmCategorias_WarningEliminar = 2905
        CDN_frmCategorias_DefaultNueva = 2906

        ' Form opciones usuario

        CDN_frmOpcionesUsuario_Idioma = 2950
        CDN_frmOpcionesUsuario_GuardarLayoutsAuto = 2951
        CDN_frmOpcionesUsuario_RestablecerLayouts = 2952
        CDN_frmOpcionesUsuario_RibbonsColapsadas = 2953
        CDN_frmOpcionesUsuario_WarningRestablecer = 2954
        CDN_frmOpcionesUsuario_PreguntaReiniciarApp = 2955
        CDN_frmOpcionesUsuario_Tema = 2956
        CDN_frmOpcionesUsuario_Intelliprompt = 2957
        CDN_frmOpcionesUsuario_Welcome = 2958
        CDN_frmOpcionesUsuario_Multifiltro = 2959
        CDN_frmOpcionesUsuario_ShowPB = 2960

        ' Formulario diseño de consulta

        CDN_frmDisenoConsulta_FichaGeneral = 3000
        CDN_frmDisenoConsulta_FichaSQL = 3001
        CDN_frmDisenoConsulta_FichaParametros = 3002
        CDN_frmDisenoConsulta_FichaFormatos = 3003
        CDN_frmDisenoConsulta_FichaResultados = 3004
        CDN_frmDisenoConsulta_RibbonGroupComun = 3005
        CDN_frmDisenoConsulta_BotonInstruccionesSQL = 3006
        CDN_frmDisenoConsulta_BotonSQLPrevioPosterior = 3007
        CDN_frmDisenoConsulta_BotonAsistenteSQL = 3008
        CDN_frmDisenoConsulta_Agregar = 3009
        CDN_frmDisenoConsulta_Propiedades = 3010
        CDN_frmDisenoConsulta_Eliminar = 3011
        CDN_frmDisenoConsulta_lblNombre = 3012
        CDN_frmDisenoConsulta_lblDescripcion = 3013
        CDN_frmDisenoConsulta_lblCategoria = 3014
        CDN_frmDisenoConsulta_lblConexion = 3015
        CDN_frmDisenoConsulta_chkPassword = 3016
        CDN_frmDisenoConsulta_chkPasswordDiseno = 3051
        CDN_frmDisenoConsulta_FrameOpciones = 3017
        CDN_frmDisenoConsulta_chkModoServidor = 3018
        CDN_frmDisenoConsulta_chkNativoSQL = 3019
        CDN_frmDisenoConsulta_chkAsincrona = 3020
        CDN_frmDisenoConsulta_chkOpcionesDefault = 3021
        CDN_frmDisenoConsulta_lblSimboloDecimal = 3022
        CDN_frmDisenoConsulta_lblLiteralCadenas = 3023
        CDN_frmDisenoConsulta_lblLiteralFechas = 3024
        CDN_frmDisenoConsulta_lblFormatoFechas = 3025
        CDN_frmDisenoConsulta_HeaderSQLInicial = 3026
        CDN_frmDisenoConsulta_HeaderSQLFinal = 3027
        CDN_frmDisenoConsulta_HeaderSQLPrevio = 3028
        CDN_frmDisenoConsulta_HeaderSQLPosterior = 3029
        CDN_frmDisenoConsulta_colTituloNombre = 3030
        CDN_frmDisenoConsulta_colTituloOrden = 3031
        CDN_frmDisenoConsulta_colTituloRequerido = 3032
        CDN_frmDisenoConsulta_colTituloColumna = 3033
        CDN_frmDisenoConsulta_colTituloFormato = 3034
        CDN_frmDisenoConsulta_BotonGuardar = 3035
        CDN_frmDisenoConsulta_BotonCustomSearch = 3036
        CDN_frmDisenoConsulta_colTituloRealColumna = 3037
        CDN_frmDisenoConsulta_colVisibleEnGrillas = 3038

        CDN_frmDisenoConsulta_DatosOK_NombreVacio = 3040
        CDN_frmDisenoConsulta_DatosOK_SinCategoria = 3041
        CDN_frmDisenoConsulta_DatosOK_SinConexion = 3042
        CDN_frmDisenoConsulta_DatosOK_SinPassword = 3043
        CDN_frmDisenoConsulta_DatosOK_SinSQLInicialNiFinal = 3044
        CDN_frmDisenoConsulta_WarningSinParametros = 3045
        CDN_frmDisenoConsulta_WarningNombreExiste = 3046



        ' Formulario Parametro

        CDN_frmParametro_TabGeneral = 3100
        CDN_frmParametro_TabAyudaContextual = 3101
        CDN_frmParametro_Orden = 3102
        CDN_frmParametro_Nombre = 3103
        CDN_frmParametro_TipoDatos = 3104
        CDN_frmParametro_TipoControl = 3105
        CDN_frmParametro_Variable = 3106
        CDN_frmParametro_InstruccionSQL = 3107
        CDN_frmParametro_ValorDefault = 3108
        CDN_frmParametro_PermitirMultifiltro = 3109
        CDN_frmParametro_Requerido = 3110
        CDN_frmParametro_Validacion = 3111
        CDN_frmParametro_Valor1 = 3112
        CDN_frmParametro_Valor2 = 3113
        CDN_frmParametro_TipSQLHelp = 3114
        CDN_frmParametro_IndiceColumna = 3115

        CDN_frmParametro_TipoDatosNumerico = 3120
        CDN_frmParametro_TipoDatosFecha = 3121
        CDN_frmParametro_TipoDatosTexto = 3122

        CDN_frmParametro_TipoControlTextEdit = 3130     '0
        CDN_frmParametro_TipoControlButtonEdit = 3131   '1
        CDN_frmParametro_TipoControlDateEdit = 3132     '2
        CDN_frmParametro_TipoControlSpinEdit = 3133     '3
        CDN_frmParametro_TipoControlCheckEdit = 3134    '4
        CDN_frmParametro_TipoControlMemoEdit = 3135     '5
        CDN_frmParametro_TipoControlTimeEdit = 3136     '6
        CDN_frmParametro_TipoControlTrackBar = 3137     '7
        CDN_frmParametro_TipoControlZoomTrackBar = 3138 '8
        CDN_frmParametro_TipoControlCalcEdit = 3139     '9

        CDN_frmParametro_ValidacionEntre = 3140

        CDN_frmParametro_DatosOK_OrdenExiste = 3150
        CDN_frmParametro_DatosOK_NombreVacio = 3151
        CDN_frmParametro_DatosOK_VariableVacia = 3152
        CDN_frmParametro_DatosOK_ParteSQLVacia = 3153
        CDN_frmParametro_DatosOK_Valor1Vacio = 3154
        CDN_frmParametro_DatosOK_Valor2Vacio = 3155
        CDN_frmParametro_DatosOK_HelpSQLVacio = 3156

        CDN_frmParametro_WarningEliminarParametro = 3160

        CDN_frmParametro_mnuDeshacer = 3170
        CDN_frmParametro_mnuRehacer = 3171
        CDN_frmParametro_mnuCopiar = 3172
        CDN_frmParametro_mnuCortar = 3173
        CDN_frmParametro_mnuPegar = 3174
        CDN_frmParametro_mnuEliminar = 3175
        CDN_frmParametro_mnuSeleccionarTodo = 3176
        CDN_frmParametro_mnuBuscar = 3177
        CDN_frmParametro_mnuReemplazar = 3178
        CDN_frmParametro_mnuInsertarVariable = 3179

        ' Formulario Formato

        CDN_frmFormato_NombreColumna = 3200
        CDN_frmFormato_Formato = 3201
        CDN_frmFormato_TipoDatos = 3202
        CDN_frmFormato_NombreColumnaExiste = 3205
        CDN_frmFormato_NombreVacio = 3206
        CDN_frmFormato_FormatoVacio = 3207

        CDN_frmFormato_WarningEliminarFormato = 3210

        ' Formulario Resultado

        CDN_frmResultado_Orden = 3300
        CDN_frmResultado_Nombre = 3301
        CDN_frmResultado_OrdenExiste = 3305
        CDN_frmResultado_NombreVacio = 3306

        CDN_frmResultado_WarningEliminarResultado = 3310

        ' Formulario Buscar y reemplazar

        CDN_frmBuscarReemplazar_Buscar = 3400
        CDN_frmBuscarReemplazar_ReemplazarCon = 3401
        CDN_frmBuscarReemplazar_Mayusculas = 3402
        CDN_frmBuscarReemplazar_PalabraCompleta = 3403
        CDN_frmBuscarReemplazar_SoloSeleccion = 3404
        CDN_frmBuscarReemplazar_BuscarSiguiente = 3405
        CDN_frmBuscarReemplazar_Reemplazar = 3406
        CDN_frmBuscarReemplazar_ReemplazarTodo = 3407
        CDN_frmBuscarReemplazar_MarcarTodo = 3408

        CDN_frmBuscarReemplazar_sMsgNoMatch = 3410
        CDN_frmBuscarReemplazar_sMsgFinishFind = 3411
        CDN_frmBuscarReemplazar_sMsgFinishReplace = 3412
        CDN_frmBuscarReemplazar_sMsgFindCount = 3413
        CDN_frmBuscarReemplazar_sMsgReplaceCount = 3414

        ' Formulario password

        CDN_frmPassword_IngresePassword = 3500
        CDN_frmPassword_PasswordIncorrecto = 3501

        ' Formulario seguridad

        CDN_frmSeguridad_Usuarios = 3600
        CDN_frmSeguridad_UsuarioSuspendido = 3601
        CDN_frmSeguridad_UsuarioBloqueado = 3602
        CDN_frmSeguridad_Agregar = 3603
        CDN_frmSeguridad_Propiedades = 3604
        CDN_frmSeguridad_Eliminar = 3605
        CDN_frmSeguridad_OpcionesSeguridad = 3606
        CDN_frmSeguridad_WarningEliminar = 3607
        CDN_frmSeguridad_ImposibleEliminar = 3608

        ' Formulario Usuario

        CDN_frmUsuario_TabGeneral = 3700
        CDN_frmUsuario_TabPermisosConsultas = 3701
        CDN_frmUsuario_NombreLogin = 3702
        CDN_frmUsuario_NombreCompleto = 3703
        CDN_frmUsuario_Password = 3704
        CDN_frmUsuario_GrupoPermisos = 3705
        CDN_frmUsuario_GrupoEstado = 3706
        CDN_frmUsuario_PermisoEjecutar = 3707
        CDN_frmUsuario_PermisoDisenar = 3708
        CDN_frmUsuario_PermisoImportar = 3709
        CDN_frmUsuario_PermisoExportar = 3710
        CDN_frmUsuario_PermisoSeguridad = 3711
        CDN_frmUsuario_PermisoCategorias = 3712
        CDN_frmUsuario_PermisoConexiones = 3713
        CDN_frmUsuario_EstadoSuspendido = 3714
        CDN_frmUsuario_EstadoBloqueado = 3715
        CDN_frmUsuario_ContadorLoginsFallidos = 3716
        CDN_frmUsuario_ConsultasHabilitadas = 3717
        CDN_frmUsuario_ConsultasNoHabilitadas = 3718
        CDN_frmUsuario_PermisoOpcionesGrales = 3719
        CDN_frmUsuario_PermisoEliminar = 3720
        'Validacion
        CDN_frmUsuario_ValidarNombreLoginVacio = 3730
        CDN_frmUsuario_ValidarNombreLoginExiste = 3731
        CDN_frmUsuario_ValidarNombreCompletoVacio = 3732
        CDN_frmUsuario_ValidarPasswordVacia = 3733

        ' Formulario LOGIN

        CDN_frmLogin_TipUsuarioPassword = 3800
        CDN_frmLogin_Usuario = 3801
        CDN_frmLogin_Password = 3802
        CDN_frmLogin_Dominio = 3803
        'Valdaciones
        CDN_frmLogin_ValidacionUsuarioNoExiste = 3810
        CDN_frmLogin_ValidacionPasswordIncorrecta = 3811
        CDN_frmLogin_ValidacionUsuarioBloqueado = 3813
        CDN_frmLogin_ValidacionUsuarioSuspendido = 3812


        ' Formulario Exportar consulta

        CDN_frmExportar_NombreConsulta = 3900
        CDN_frmExportar_NombreArchivo = 3901
        CDN_frmExportar_SaveDialogFilter = 3902
        CDN_frmExportar_InfoExportacionOK = 3903
        CDN_frmExportar_ExportarLayouts = 3904
        CDN_frmExportar_ExportarReportes = 3905


        ' Formulario Query Builder

        CDN_frmSQLWizard_BotonAgregarObjeto = 4000
        CDN_frmSQLWizard_BotonPropiedades = 4001
        CDN_frmSQLWizard_Expresiones = 4010
        CDN_frmSQLWizard_Objetos = 4011
        CDN_frmSQLWizard_Uniones = 4012
        CDN_frmSQLWizard_WarningReplace = 4020

        ' Formulario Insertar Variable

        CDN_frmVariable_Variable = 4100
        CDN_frmVariable_Descripcion = 4101
        CDN_frmVariable_Ayer = 4150
        CDN_frmVariable_Hoy = 4151
        CDN_frmVariable_Mes = 4152
        CDN_frmVariable_Dia = 4153
        CDN_frmVariable_InicioMes = 4154
        CDN_frmVariable_UltimoFinMes = 4155
        CDN_frmVariable_UsuarioWindows = 4156
        CDN_frmVariable_Terminal = 4157
        CDN_frmVariable_VersionWindows = 4158
        CDN_frmVariable_DirectorioApp = 4159
        CDN_frmVariable_UsuarioActual = 4160
        CDN_frmVariable_Parametro01 = 4161
        CDN_frmVariable_Parametro02 = 4162
        CDN_frmVariable_Parametro03 = 4163
        CDN_frmVariable_Parametro04 = 4164
        CDN_frmVariable_Parametro05 = 4165
        CDN_frmVariable_Parametro06 = 4166
        CDN_frmVariable_Parametro07 = 4167
        CDN_frmVariable_Parametro08 = 4168
        CDN_frmVariable_Parametro09 = 4169
        CDN_frmVariable_Parametro10 = 4170
        CDN_frmVariable_Parametro11 = 4171
        CDN_frmVariable_Parametro12 = 4172
        CDN_frmVariable_Parametro13 = 4173
        CDN_frmVariable_Parametro14 = 4174
        CDN_frmVariable_Parametro15 = 4175
        CDN_frmVariable_Parametro16 = 4176
        CDN_frmVariable_Parametro17 = 4177
        CDN_frmVariable_Parametro18 = 4178
        CDN_frmVariable_Parametro19 = 4179
        CDN_frmVariable_Parametro20 = 4180
        CDN_frmVariable_Parametro21 = 4181
        CDN_frmVariable_Parametro22 = 4182
        CDN_frmVariable_Parametro23 = 4183
        CDN_frmVariable_Parametro24 = 4184
        CDN_frmVariable_Parametro25 = 4185
        CDN_frmVariable_Parametro26 = 4186
        CDN_frmVariable_Parametro27 = 4187
        CDN_frmVariable_Parametro28 = 4188
        CDN_frmVariable_Parametro29 = 4189
        CDN_frmVariable_Parametro30 = 4190
        CDN_frmVariable_Parametro31 = 4191
        CDN_frmVariable_Parametro32 = 4192
        CDN_frmVariable_Parametro33 = 4193
        CDN_frmVariable_Parametro34 = 4194
        CDN_frmVariable_Parametro35 = 4195
        CDN_frmVariable_Parametro36 = 4196
        CDN_frmVariable_Parametro37 = 4197
        CDN_frmVariable_Parametro38 = 4198
        CDN_frmVariable_Parametro39 = 4199
        CDN_frmVariable_Parametro40 = 4200
        CDN_frmVariable_Parametro41 = 4201
        CDN_frmVariable_Parametro42 = 4202
        CDN_frmVariable_Parametro43 = 4203
        CDN_frmVariable_Parametro44 = 4204
        CDN_frmVariable_Parametro45 = 4205
        CDN_frmVariable_Parametro46 = 4206
        CDN_frmVariable_Parametro47 = 4207
        CDN_frmVariable_Parametro48 = 4208
        CDN_frmVariable_Parametro49 = 4209
        CDN_frmVariable_Parametro50 = 4210
        CDN_frmVariable_Parametro51 = 4211
        CDN_frmVariable_Parametro52 = 4212
        CDN_frmVariable_Parametro53 = 4213
        CDN_frmVariable_Parametro54 = 4214
        CDN_frmVariable_Parametro55 = 4215
        CDN_frmVariable_Parametro56 = 4216
        CDN_frmVariable_Parametro57 = 4217
        CDN_frmVariable_Parametro58 = 4218
        CDN_frmVariable_Parametro59 = 4219
        CDN_frmVariable_Parametro60 = 4220
        CDN_frmVariable_Parametro61 = 4221
        CDN_frmVariable_Parametro62 = 4222
        CDN_frmVariable_Parametro63 = 4223
        CDN_frmVariable_Parametro64 = 4224
        CDN_frmVariable_Parametro65 = 4225
        CDN_frmVariable_Parametro66 = 4226
        CDN_frmVariable_Parametro67 = 4227
        CDN_frmVariable_Parametro68 = 4228
        CDN_frmVariable_Parametro69 = 4229
        CDN_frmVariable_Parametro70 = 4230
        CDN_frmVariable_Parametro71 = 4231
        CDN_frmVariable_Parametro72 = 4232
        CDN_frmVariable_Parametro73 = 4233
        CDN_frmVariable_Parametro74 = 4234
        CDN_frmVariable_Parametro75 = 4235
        CDN_frmVariable_Parametro76 = 4236
        CDN_frmVariable_Parametro77 = 4237
        CDN_frmVariable_Parametro78 = 4238
        CDN_frmVariable_Parametro79 = 4239
        CDN_frmVariable_Parametro80 = 4240
        CDN_frmVariable_Parametro81 = 4241
        CDN_frmVariable_Parametro82 = 4242
        CDN_frmVariable_Parametro83 = 4243
        CDN_frmVariable_Parametro84 = 4244
        CDN_frmVariable_Parametro85 = 4245
        CDN_frmVariable_Parametro86 = 4246
        CDN_frmVariable_Parametro87 = 4247
        CDN_frmVariable_Parametro88 = 4248
        CDN_frmVariable_Parametro89 = 4249
        CDN_frmVariable_Parametro90 = 4250
        CDN_frmVariable_Parametro91 = 4251
        CDN_frmVariable_Parametro92 = 4252
        CDN_frmVariable_Parametro93 = 4253
        CDN_frmVariable_Parametro94 = 4254
        CDN_frmVariable_Parametro95 = 4255
        CDN_frmVariable_Parametro96 = 4256
        CDN_frmVariable_Parametro97 = 4257
        CDN_frmVariable_Parametro98 = 4258
        CDN_frmVariable_Parametro99 = 4259

        ' Form importar consulta

        CDN_frmImportar_NombreArchivo = 4300
        CDN_frmImportar_Validar = 4301
        CDN_frmImportar_HeaderInfoConsulta = 4302
        CDN_frmImportar_NombreConsulta = 4303
        CDN_frmImportar_DescripcionConsulta = 4304
        CDN_frmImportar_Categoria = 4305
        CDN_frmImportar_Conexion = 4306

        ' Form Eliminar consulta

        CDN_frmEliminarConsulta_Warning01 = 4400
        CDN_frmEliminarConsulta_Warning02 = 4401

        ' Form opciones globales

        CDN_frmOpcionesGlobales_Titulo = 4500
        CDN_frmOpcionesGlobales_RutaLocal = 4501
        CDN_frmOpcionesGlobales_InterpretacionSQL = 4502
        CDN_frmOpcionesGlobales_EdicionSQLHabilitada = 4503
        CDN_frmOpcionesGlobales_MostrarEnAQB = 4504
        CDN_frmOpcionesGlobales_Tablas = 4505
        CDN_frmOpcionesGlobales_Vistas = 4506
        CDN_frmOpcionesGlobales_Procedimientos = 4507
        CDN_frmOpcionesGlobales_OtrasOpciones = 4508

        ' Form opciones seguridad

        CDN_frmOpcionesSeguridad_ValidarNT = 4600
        CDN_frmOpcionesSeguridad_Dominio = 4601
        CDN_frmOpcionesSeguridad_HabilitarCmdLogin = 4602

        ' Form guardar layout

        CDN_frmGuardarLayout_Nombre = 4700
        CDN_frmGuardarLayout_Descripcion = 4701
        CDN_frmGuardarLayout_OtrosTip = 4702
        CDN_frmGuardarLayout_LVGroup = 4703
        CDN_frmGuardarLayout_Compartido = 4704
        CDN_frmGuardarLayout_NombreVacio = 4705
        CDN_frmGuardarLayout_ConfirmarSobreescribir = 4706

        ' Form cargar layout

        CDN_frmCargarLayout_OtrosTip = 4750
        CDN_frmCargarLayout_LVGroupPropios = 4751
        CDN_frmCargarLayout_LVGroupCompartidos = 4752
        CDN_frmCargarLayout_ConfirmarEliminar = 4753

        ' Form Diseño Busqueda pers.

        CDN_frmDisenoCustomSearch_Habilitada = 4800
        CDN_frmDisenoCustomSearch_TituloFrame = 4801
        CDN_frmDisenoCustomSearch_Mensaje = 4802
        CDN_frmDisenoCustomSearch_Variable = 4803
        CDN_frmDisenoCustomSearch_ErrorVacio = 4804

        ' Form construir expresion

        CDN_frmEditorExpresion_Inclusion = 4900
        CDN_frmEditorExpresion_Columna = 4901
        CDN_frmEditorExpresion_Comparacion = 4902
        CDN_frmEditorExpresion_Valor = 4903
        CDN_frmEditorExpresion_AND = 4904
        CDN_frmEditorExpresion_OR = 4905
        CDN_frmEditorExpresion_ColumnaVacia = 4906
        CDN_frmEditorExpresion_ValorVacio = 4907
        CDN_frmEditorExpresion_AND_NOT = 4908
        CDN_frmEditorExpresion_OR_NOT = 4909

        ' Form Formato Condicional

        CDN_frmFormatoCondicional_Columna = 5000
        CDN_frmFormatoCondicional_Comparador = 5001
        CDN_frmFormatoCondicional_Valor1 = 5002
        CDN_frmFormatoCondicional_Valor2 = 5003
        CDN_frmFormatoCondicional_Negrita = 5004
        CDN_frmFormatoCondicional_Cursiva = 5005
        CDN_frmFormatoCondicional_Subrayado = 5006
        CDN_frmFormatoCondicional_ColorFuente = 5007
        CDN_frmFormatoCondicional_ColorFondo = 5008
        CDN_frmFormatoCondicional_Agregar = 5009
        CDN_frmFormatoCondicional_Modificar = 5010
        CDN_frmFormatoCondicional_ErrorValor1 = 5011
        CDN_frmFormatoCondicional_ConfirmaEliminar = 5012
        CDN_frmFormatoCondicional_HeaderGrupoDatos = 5013
        CDN_frmFormatoCondicional_HeaderGrupoFormatos = 5014
        CDN_frmFormatoCondicional_AplicaA = 5015
        CDN_frmFormatoCondicional_ColorFondo2 = 5016
        CDN_frmFormatoCondicional_Formato = 5017
        CDN_frmFormatoCondicional_Tachado = 5018
        CDN_frmFormatoCondicional_Degradado = 5019
        CDN_frmFormatoCondicional_TipoDegradadoHorizontal = 5020
        CDN_frmFormatoCondicional_TipoDegradadoVertical = 5021
        CDN_frmFormatoCondicional_TipoDegradadoDiagonalAdelante = 5022
        CDN_frmFormatoCondicional_TipoDegradadoDiagonalAtras = 5023
        CDN_frmFormatoCondicional_AplicaCelda = 5024
        CDN_frmFormatoCondicional_AplicaCeldaTotal = 5025
        CDN_frmFormatoCondicional_AplicaCeldaGranTotal = 5026
        CDN_frmFormatoCondicional_AplicaCeldaTotalPersonalizado = 5027
        CDN_frmFormatoCondicional_CondicionNinguna = 5028
        CDN_frmFormatoCondicional_CondicionIgual = 5029
        CDN_frmFormatoCondicional_CondicionDistinto = 5030
        CDN_frmFormatoCondicional_CondicionEntre = 5031
        CDN_frmFormatoCondicional_CondicionNoEntre = 5032
        CDN_frmFormatoCondicional_CondicionMenor = 5033
        CDN_frmFormatoCondicional_CondicionMayor = 5034
        CDN_frmFormatoCondicional_CondicionMayorIgual = 5035
        CDN_frmFormatoCondicional_CondicionMenorIgual = 5036
        CDN_frmFormatoCondicional_WarningEliminar = 5037



    End Enum

    Public Sub LeerCadenas(ByVal nCodigoIdioma As Integer)

        Dim sSQL As String
        Dim ds As DataSet
        Dim oAdmTablas As New AdmTablas
        Dim nI As Integer
        Dim oCadena As CadenaIdioma

        sSQL = "SELECT  * " & _
               "FROM    IDIOMA " & _
               "WHERE   IO_CODIDI = " & nCodigoIdioma

        oAdmTablas.ConnectionString = CONN_LOCAL
        ds = oAdmTablas.AbrirDataset(sSQL)

        colCadenas.Clear()

        For nI = 0 To ds.Tables(0).Rows.Count - 1
            oCadena = New CadenaIdioma
            oCadena.CodigoCadena = ds.Tables(0).Rows(nI)("IO_CODCAD")
            oCadena.DescripcionCadena = ds.Tables(0).Rows(nI)("IO_DESCRI")
            colCadenas.Add(oCadena, "K" & ds.Tables(0).Rows(nI)("IO_CODCAD"))
        Next

    End Sub

    Public Function DescripcionCadena(ByVal nCodigoCadena As Cadenas, Optional ByVal sOrigen As String = "") As String

        On Error Resume Next
        Dim oCadena As CadenaIdioma

        oCadena = colCadenas("K" & nCodigoCadena)

        If oCadena.DescripcionCadena Is Nothing Then
            DescripcionCadena = "N/A"
            Debug.Print(nCodigoCadena & " (Origen: " & sOrigen & ")")
        Else
            DescripcionCadena = oCadena.DescripcionCadena
        End If


    End Function

End Module
