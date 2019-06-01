Module modDeclaraciones

   Public Enum AccionesLOG

      AL_INGRESO_SISTEMA = 1
      AL_SALIDA_SISTEMA = 2
      AL_INGRESO_TRANSACCION = 3
      AL_ERROR_SISTEMA = 4
      AL_VIOLACION_SEGURIDAD = 5
        Consulta_Perfil = 10
        Modifica_Perfil = 11
        Consulta_Usuario = 12
        Modifica_Usuario = 13
        Consulta_Grupo = 14
        Modifica_Grupo = 15
        Consulta_Asignación = 16
        Alta_Asignación = 17
        Baja_Asignación = 18
        Consulta_Directiva = 19
        Modifica_Directiva = 20
        Alta_Directiva = 21
        Baja_Directiva = 22
        Alta_Usuario = 23
        Baja_Usuario = 24
        Cambio_Password = 25
        Error_Cambio_Password = 26
        Consulta_LOG = 27
        Impresión_LOG = 28
        Exportación_LOG = 29
        Alta_Grupo = 30
        Eliminación_Grupo = 31
        Asigna_Usuario_Grupo = 32
        Quita_Asignacion_Usuario_Grupo = 33
        Alta_Perfil = 34
        Baja_Perfil = 35
        Copia_LOG = 36
        Intruccion_SQL_Automatica = 37
        ModificacionDeDatos = 38
        EliminarDatosEnCuadros = 39
        ParametrosDeSeleccionProcesos = 40
        EjecucionSubProceso = 41
        FinSubProceso = 42
        ErrorSubProceso = 43
        ParametrosSeleccionFormularios = 50
        ImprimeDatosDeCuadro = 51
        ExportacionDeDatos = 52
        CopiaDeDatos = 53
        GeneracionDeSalidaPDF = 54
        ActualizacionDeComentarios = 55
        ActualizacionDeArchivosAdjuntos = 56
    End Enum

   'DATASET DE CONFIGURACIÓN (COMO EL VIEJO INI)
   Public oConfig As New dsConfig
#If DEBUG Then
    Public ARCHIVO_CONFIG As String = "C:\Prex\DebugLocal\Prex.config"
#Else
    Public ARCHIVO_CONFIG As String = Application.StartupPath & "\Prex.config"
#End If
    'Public ARCHIVO_CONFIG_DEV As String = "D:\Develop\Proyectos.NET\Prex.config"
    ' Public ARCHIVO_CONFIG_DEV As String = "\\10.0.0.100\e$\Develop\PREX_RI (Versión NET)\BIN\Prex.config"
    '28-11-2014 AGREGADO PARA RUN AS
    Public RUTA_PREFERIDA As String = ""
    Public RUTAENCR_RA As String = ""
    Public DOMINIO_DEFAULT As String = ""
    Public GENERAR_LOG_SQL As Boolean
    Public TIPO_LOG_SQL As Integer
    Public CONN_LOCAL As String = ""
    Public CONN_SIB As String = ""
    Public FORMATO_FECHA As String = ""
    Public CARPETA_LOCAL As String = ""
    Public RUTA_BIN As String = ""
    Public RUTA_AYUDA As String = ""
    Public NOMBRE_INI_LOCAL As String = ""
    Public LAST_USER As String = ""
    Public INPUT_GENERAL As String = ""
    Public NOMBRE_EMPRESA As String = ""
    Public NOMBRE_ENTIDAD As String = ""
    Public CODIGO_ENTIDAD As Long = 0
    Public CODIGO_TRANSACCION As Long = 0
    Public SIMBOLO_DECIMAL As Char
    Public SG_CONFIG As String = ""
    Public CITI_PERFIL As String = ""

    Public CulturaActual As System.Globalization.CultureInfo   'Cultura

    Public CONSULTA_CANCELADA As Boolean

    'GENERAL
    Public AUTENTICACIONSQL As Boolean

   ' BANCO DE CORDOBA
   Public SEGURIDAD_INTEGRADA As Boolean
   Public NOMBRE_SQLSERVER As String
   Public IDENTIFICACION_PC As String
   Public NOMBRE_BD As String
   Public NUMERO_SISTEMA As String
   Public LOG_AUDITORIA As String

   'JP Morgan
   Public bJPMORGAN As Boolean
   Public WEBSERNAME As String
   Public SRVORIGEN As String
   Public USUARIO_DB As String
   Public PASSWORD_DB As String

   'Citi
   Public ID_SISTEMA As Long

   Public Structure Usuario

      Public Nombre As String
      Public Descripcion As String
      Public Codigo As Long
      Public Admin As Boolean
      Public SoloLectura As Boolean
      Public Password As String
      Public Dominio As String
      Public Entidad As Long

   End Structure

   Public UsuarioActual As Usuario

End Module
