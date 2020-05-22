using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Prex.Utils
{
    #region Clases

    public class Usuario
    {

        public string Nombre      { get; set; }
        public string Descripcion { get; set; }
        public long Codigo      { get; set; }
        public bool Admin         { get; set; }
        public bool SoloLectura   { get; set; }
        public string Password    { get; set; }
        public string Dominio     { get; set; }
        public long Entidad       { get; set; }

        public Usuario() { }
    }

    public class PrexConfigLocal
    {
        public int Vista             { get; protected set; }
        public int MultiExec         { get; protected set; }
        public int MinimizarAlCerrar { get; protected set; }
        public int InicioTray        { get; protected set; }
        public int ConfirmarAlSalir  { get; protected set; }
        public string LastUser       { get; protected set; }
        public int SiempreIG         { get; protected set; }

        public PrexConfigLocal() { }

        internal PrexConfigLocal(XmlDocument xml)
        {
            foreach (XmlNode nodo in xml.DocumentElement.ChildNodes)
            {
                var valor = nodo.LastChild.InnerText;
                var nombre = nodo.FirstChild.InnerText;
                var propertyInfo = this.GetType().GetProperty(nombre);
                if (propertyInfo != null)
                    propertyInfo.SetValue(this, Convert.ChangeType(valor, propertyInfo.PropertyType));
            }
        }
    }

    public class PrexConfig
    {
        #region Propiedades

        public string CONN_LOCAL         { get; internal set; }
        public string CONN_LOCAL_ADO => CONN_LOCAL.Substring(CONN_LOCAL.IndexOf(';')+1, CONN_LOCAL.Length-(CONN_LOCAL.IndexOf(';') + 1));
        public  string FFECHA     { get; internal set; }
        public string CARPETA_LOCAL      { get; internal set; }
        public string RUTAENCR_RA { get; protected set; }
        public string RUTA_BIN           { get; internal set; }
        public string RUTA_AYUDA         { get; internal set; }
        public string NOMBRE_INI_LOCAL   { get; internal set; }
        public string NOMBRE_SISTEMA     { get; internal set; }
        public string LAST_USER          { get; internal set; }
        public  string INPUT_GENERAL     { get; internal set; }
        public  string NOMBRE_EMPRESA    { get; internal set; }
        public  string NOMBRE_ENTIDAD    { get; set; }
        public string CODIGO_ENTIDAD     { get; set; }
        public long CODIGO_TRANSACCION   { get; set; }
        public string SIMBOLO_DECIMAL    { get; internal set; }
        public string DOMINIO            { get; internal set; }
        public string DBTYPE             { get; internal set; }
        public CultureInfo CulturaActual { get; set; }

        public bool CONSULTA_CANCELADA   { get; internal set; }

        //GENERAL
        public bool AUTENTICACIONSQL     { get; internal set; }

        // BANCO DE CORDOBA
        public bool SEGURIDAD_INTEGRADA  { get; internal set; }
        public string NOMBRE_SQLSERVER   { get; internal set; }
        public string IDENTIFICACION_PC  { get; internal set; }
        public string NOMBRE_BD          { get; internal set; } 
        public string NUMERO_SISTEMA     { get; internal set; } 
        public string LOG_AUDITORIA      { get; internal set; }
        

        //JP Morgan
        public bool bJPMORGAN            { get; internal set; }
        public string WEBSERNAME         { get; internal set; }
        public string SRVORIGEN          { get; internal set; }
        public string USUARIO_DB         { get; internal set; }
        public string PASSWORD_DB        { get; internal set; }

        //Citi
        public long ID_SISTEMA           { get; internal set; }
        public string SG_CONFIG          { get; internal set; }
		public long APPID                { get; internal set; }
		public string WSDL               { get; internal set; }
		public string CertifcatePath     { get; internal set; }
		public string CertifcatePass     { get; internal set; }
		public bool SAFE                 { get; internal set; }
		public string STR_FOLDER         { get; internal set; }
		public string STR_OBJECT         { get; internal set; }
		public string STR_REASON         { get; internal set; }

		public Usuario UsuarioActual { get; internal set; }
        #endregion

        #region Contructor

        public PrexConfig()
        {
            UsuarioActual = new Usuario();
        }

        internal PrexConfig(XmlDocument xml) : this()
        {

            foreach (XmlNode nodo in xml.DocumentElement.ChildNodes)
            {
                var valor = nodo.LastChild.InnerText;
                var nombre = nodo.FirstChild.InnerText;

                if (nombre.Equals("CONN_LOCAL"))
                    CONN_LOCAL = Encoding.UTF8.GetString(Convert.FromBase64String(valor));
                else if (nombre.Equals("SIMBOLO_DECIMAL"))
                    SIMBOLO_DECIMAL = valor.Substring(0, 1);
                else
                {
                    var propertyInfo = this.GetType().GetProperty(nombre);
                    if (propertyInfo != null) propertyInfo.SetValue(this, Convert.ChangeType((propertyInfo.PropertyType.FullName == "System.Boolean" ? (valor.ToString() == "0" ? "false" : "true") : valor), propertyInfo.PropertyType));
                }
            }
            if (!CARPETA_LOCAL.EndsWith("\\")) CARPETA_LOCAL += "\\";

        }
        #endregion
    }
    #endregion

    public static class Configuration
    {
        private static PrexConfig _config;
        private static PrexConfigLocal _configLocal;

        public static string ARCHIVO_CONFIG
        {
            get
            {

#if DEBUG
				return @"C:\Prex\DebugLocal\Prex.config";
#else
				return Environment.CurrentDirectory + @"\Prex.config";
#endif
            }
        }

        public static string ARCHIVO_CONFIG_LOCAL => _config?.CARPETA_LOCAL + _config?.NOMBRE_INI_LOCAL;

        public static PrexConfig PrexConfig
        {
            get
            {
                if (_config == null) LeerXML();
                return _config;
            }
        }

        public static PrexConfigLocal PrexConfigLocal
        {
            get
            {
                if (_configLocal == null) LeerXMLLocal();
                return _configLocal;
            }
        }

        public static bool TieneConfigLocal => _config != null && File.Exists(ARCHIVO_CONFIG_LOCAL);

        public static void LeerXML()
        {
            try
            {
                string sTemp = string.Empty;

                if (File.Exists(ARCHIVO_CONFIG))
                {
                    var prexConfig = new XmlDocument();
                    prexConfig.Load(ARCHIVO_CONFIG);

                    _config = new PrexConfig(prexConfig);

                }
                else
                {
                    throw new Exception("No se encontró archivo Prex.config");
                }



                if (_config.AUTENTICACIONSQL)
                {

                    if (File.Exists(_config.CARPETA_LOCAL + "TEMP\\conn.enc"))
                    {

                        string sUser = string.Empty;
                        string sPass = string.Empty;

                        //LeerArchivoEncriptado(CARPETA_LOCAL & "TEMP\conn.enc", sUser, sPass)
                        _config.CONN_LOCAL += ";User id=" + sUser + ";Password=" + sPass + ";";
                    }
                    else
                    {

                        //  if (Command().Trim <> "" And Command().ToUpper <> "/IDE" Then
                        //      {
                        //      MensajeError("No se encuentra el archivo encriptado con la conexion SQL")
                        //End
                    }

                }

                LeerXMLLocal();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al leer archivo Prex.config", ex);
            }
        }

        private static void LeerXMLLocal()
        {
            try
            {

                if (!TieneConfigLocal)
                {
                    GuardarXMLLocal();
                }
                else
                {
                    var prexConfig = new XmlDocument();
                    prexConfig.Load(ARCHIVO_CONFIG_LOCAL);
                    _configLocal = new PrexConfigLocal(prexConfig);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al leer Prex.config LOCAL", ex);
            }

        }

        private static T GetDefaultType<T>(T propiedad)
        {
            return default(T);
        }

        public static void GuardarXMLLocal()
        {

            var _xmlLocal = new XmlDocument();
            var dec = _xmlLocal.CreateXmlDeclaration("1.0", "", "yes");
            _xmlLocal.AppendChild(dec);

            _configLocal = new PrexConfigLocal();

            var dsConfig = _xmlLocal.CreateElement("dsConfig");

            foreach (var property in _configLocal.GetType().GetProperties())
            {
                var nodoConfig = _xmlLocal.CreateNode(XmlNodeType.Element, "CONFIG",string.Empty);


                var node1 = _xmlLocal.CreateNode(XmlNodeType.Element, "NOMBRE", string.Empty);
                node1.InnerText = property.Name;
                nodoConfig.AppendChild(node1);

                var node2 = _xmlLocal.CreateNode(XmlNodeType.Element, "VALOR", string.Empty);
                node2.InnerText = property.GetValue(_configLocal)?.ToString();

                nodoConfig.AppendChild(node2);
                dsConfig.AppendChild(nodoConfig);
            }
            _xmlLocal.AppendChild(dsConfig);
            _xmlLocal.Save(ARCHIVO_CONFIG_LOCAL);
        }
        //    //Vista
        //    var node11 = _xmlLocal.CreateNode(XmlNodeType.Element, "NOMBRE", "dsConfig/config");
        //    node11.InnerText = "Vista";
        //    var node12 = _xmlLocal.CreateNode(XmlNodeType.Element, "VALOR", "dsConfig/config");
        //    node11.InnerText = "0";

        //    //MultiExec
        //    var node21 = _xmlLocal.CreateNode(XmlNodeType.Element, "NOMBRE", "dsConfig/config");
        //    node21.InnerText = "MultiExec";
        //    var node22 = _xmlLocal.CreateNode(XmlNodeType.Element, "VALOR", "dsConfig/config");
        //    node21.InnerText = "0";

        //    //MinimizarAlCerrar
        //    var node31 = _xmlLocal.CreateNode(XmlNodeType.Element, "NOMBRE", "dsConfig/config");
        //    node31.InnerText = "MinimizarAlCerrar";
        //    var node32 = _xmlLocal.CreateNode(XmlNodeType.Element, "VALOR", "dsConfig/config");
        //    node32.InnerText = "0";

        //    //Vista
        //    var node11 = _xmlLocal.CreateNode(XmlNodeType.Element, "NOMBRE", "dsConfig/config");
        //    node1.InnerText = "Vista";
        //    var node12 = _xmlLocal.CreateNode(XmlNodeType.Element, "VALOR", "dsConfig/config");
        //    node1.InnerText = "0";

        //    //Vista
        //    var node11 = _xmlLocal.CreateNode(XmlNodeType.Element, "NOMBRE", "dsConfig/config");
        //    node1.InnerText = "Vista";
        //    var node12 = _xmlLocal.CreateNode(XmlNodeType.Element, "VALOR", "dsConfig/config");
        //    node1.InnerText = "0";

        //    _xmlLocal.AppendChild()

        //Dim ds As New dsConfig
        //Dim dr As DataRow
        //Dim dt As DataTable = ds.Tables("CONFIG")

        //Try

        //    Dim sRuta As String

        //    sRuta = CARPETA_LOCAL & NOMBRE_INI_LOCAL

        //    'Conexión Base de datos
        //    dr = dt.NewRow()
        //    dr("NOMBRE") = "Vista"
        //    dr("VALOR") = VISTA_ACTUAL
        //    dt.Rows.Add(dr)
        //    ds.AcceptChanges()

        //    'Formato de Fecha del Servidor SQL
        //    dr = dt.NewRow()
        //    dr("NOMBRE") = "MultiExec"
        //    dr("VALOR") = MULTIEXEC
        //    dt.Rows.Add(dr)
        //    ds.AcceptChanges()

        //    'Ruta a la carpeta local
        //    dr = dt.NewRow()
        //    dr("NOMBRE") = "MinimizarAlCerrar"
        //    dr("VALOR") = MINIMIZAR_AL_CERRAR
        //    dt.Rows.Add(dr)
        //    ds.AcceptChanges()

        //    'Nombre de archivo de configuración local
        //    dr = dt.NewRow()
        //    dr("NOMBRE") = "InicioTray"
        //    dr("VALOR") = INICIAR_EN_TRAY
        //    dt.Rows.Add(dr)
        //    ds.AcceptChanges()

        //    'Nombre de archivo de configuración local
        //    dr = dt.NewRow()
        //    dr("NOMBRE") = "ConfirmarAlSalir"
        //    dr("VALOR") = CONFIRMAR_AL_SALIR
        //    dt.Rows.Add(dr)
        //    ds.AcceptChanges()

        //    'Nombre de archivo de configuración local
        //    dr = dt.NewRow()
        //    dr("NOMBRE") = "LastUser"
        //    dr("VALOR") = UsuarioActual.Nombre
        //    dt.Rows.Add(dr)
        //    ds.AcceptChanges()

        //    'Nombre de archivo de configuración local
        //    dr = dt.NewRow()
        //    dr("NOMBRE") = "SiempreIG"
        //    dr("VALOR") = SIEMPRE_ICONOS_GRANDES
        //    dt.Rows.Add(dr)
        //    ds.AcceptChanges()

        //    ds.WriteXml(sRuta)

        //Catch ex As Exception
        //    TratarError(ex, "GuardarXMLLocal")
        //End Try

    }

    
}
