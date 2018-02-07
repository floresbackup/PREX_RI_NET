Public Module modGlobalDeclaraciones

    Public APP_NAME As String
    Public DOMAIN_DEFAULT As String
    Public VALIDATE_NT As Boolean
    Public RES_PATH As String
    Public LOGO_SPLASH_PATH As String
    Public LOGO_LOGIN_PATH As String
    Public LOGO_WELCOME_BACK_PATH As String
    Public LOGO_WELCOME_LEFT_PATH As String
    Public LOGO_WELCOME_RIGHT_PATH As String
    Public LOGO_ABOUT_LOGO_PATH As String
    Public LOGO_ABOUT_PRODUCT_PATH As String

    Public CMD_READY As Boolean
    Public CONSULTA_CANCELADA As Boolean
    Public CONSULTA_SELECCIONADA As Integer
    Public PASSWORD_OK As Boolean

    Public REPORTE_PUBLICO As Boolean
    Public REPORTE_NOMBRE As String

    Public CONN_LOCAL As String
    Public CONN_DEFAULT As String
    Public SIMBOLO_DECIMAL As String
    Public LITERAL_CADENAS As String
    Public LITERAL_FECHAS As String
    Public FORMATO_FECHAS As String
    Public HELP_PATH As String

    Public USUARIO_ACTUAL As Integer
    Public USUARIO_ACTUAL_NOMBRE As String
    Public USUARIO_ACTUAL_PMS_EJECUTAR As Boolean
    Public USUARIO_ACTUAL_PMS_DISENAR As Boolean
    Public USUARIO_ACTUAL_PMS_IMPORTAR As Boolean
    Public USUARIO_ACTUAL_PMS_EXPORTAR As Boolean
    Public USUARIO_ACTUAL_PMS_CATEGORIAS As Boolean
    Public USUARIO_ACTUAL_PMS_SEGURIDAD As Boolean
    Public USUARIO_ACTUAL_PMS_CONEXIONES As Boolean
    Public USUARIO_ACTUAL_PMS_OPCIONES_GRALES As Boolean
    Public USUARIO_ACTUAL_PMS_ELIMINAR As Boolean

    Public APP_ACTUAL As String
    Public LOCALE_PATH As String
    Public SQL_ASISTENTE As String
    Public VARIABLE_SELECCIONADA As String

    Public SPOOL_PATH As String
    Public LOCAL_FOLDER As String
    Public LOCAL_COMMON_INI_PATH As String
    Public LAST_USER As Integer
    Public LAST_USER_NAME As String

    Public IDIOMA_ACTUAL As Integer
    Public THEME_ACTUAL As String
    Public USER_FOLDER As String
    Public AUTOSAVE_LAYOUTS As Integer
    Public COLLAPSE_RIBBON As Integer
    Public GRID_LAYOUTS_PATH As String
    Public CUBE_LAYOUTS_PATH As String
    Public DESIGN_SPLIT As Integer
    Public USE_INTELLIPROMPT As Integer
    Public SHOW_WELCOME As Integer

    ' Variables para generar algoritmos
    Public SERVER_NAME As String
    Public SERVER_EDITION As String
    Public SERVER_VERSION As String

    ' Keys
    Public AUTHENTICATION_KEY As String
    Public LICENSE_KEY_OK As String
    Public LICENSE_KEY As String
    Public MODO_DEMO As Boolean

    Public Const INTENTOS_FALLIDOS = 3

    Public Structure Consulta
        Public Codigo As Integer
        Public Nombre As String
        Public Descripcion As String
        Public CodigoCategoria As Integer
        Public DescripcionCategoria As String
        Public SQLPrevio As String
        Public SQLInicial As String
        Public SQLFinal As String
        Public SQLPosterior As String
        Public CadenaConexion As String
        Public CodigoConexion As Integer
        Public NombreConexion As String
        Public Protegida As Boolean
        Public Password As String
        Public OpcionesDefault As Boolean
        Public SimboloDecimal As String
        Public LiteralCadenas As String
        Public LiteralFechas As String
        Public FormatoFechas As String
        Public ModoServidor As Boolean
        Public TipoConexion As Integer
        Public EjecucionAsincrona As Boolean
        Public Detalles() As DetalleConsulta
        Public Formatos() As FormatoConsulta
        Public Resultados() As ResultadoConsulta
    End Structure

    Public Structure DetalleConsulta
        Public Orden As Integer
        Public Nombre As String
        Public TipoControl As Integer
        Public TipoDatos As String
        Public Variable As String
        Public ParteSQL As String
        Public EsIN As Boolean
        Public TipoHelp As Integer
        Public Requerido As Boolean
        Public SQLTablaGeneral As String
        Public CampoRetorno As Integer
        Public ValorDefault As String
        Public Valor As String
        Public OperadorValidacion As String
        Public ValidacionValor1 As String
        Public ValidacionValor2 As String
    End Structure

    Public Structure FormatoConsulta
        Public ColumnaKey As String
        Public Formato As String
        Public TipoColumna As Integer
    End Structure

    Public Structure ResultadoConsulta
        Public Orden As Integer
        Public Nombre As String
    End Structure

    Public oConsultaActual As Consulta

    Public RETORNO_CONSULTA_GENERAL As String


End Module
