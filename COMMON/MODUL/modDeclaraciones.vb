Module modDeclaraciones

   Public Enum AccionesLOG

      AL_INGRESO_SISTEMA = 1
      AL_SALIDA_SISTEMA = 2
      AL_INGRESO_TRANSACCION = 3
      AL_ERROR_SISTEMA = 4
      AL_VIOLACION_SEGURIDAD = 5

   End Enum

   'DATASET DE CONFIGURACIÓN (COMO EL VIEJO INI)
   Public oConfig As New dsConfig

   Public ARCHIVO_CONFIG As String = Application.StartupPath & "\Prex.config"
   'Public ARCHIVO_CONFIG_DEV As String = "D:\Develop\Proyectos.NET\Prex.config"
   Public ARCHIVO_CONFIG_DEV As String = "\\10.0.0.100\e$\Develop\PREX_RI (Versión NET)\BIN\Prex.config"

   Public CONN_LOCAL As String = ""
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
