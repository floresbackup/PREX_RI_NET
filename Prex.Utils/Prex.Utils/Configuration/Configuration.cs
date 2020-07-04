using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Prex.Utils
{
    #region Clases

    public class Usuario
    {

        public string Nombre         { get; set; }
        public string Descripcion    { get; set; }
        public long Codigo           { get; set; }
        public bool Admin            { get; set; }
        public bool SoloLectura      { get; set; }
        public string Password       { get; set; }
        public string Dominio        { get; set; }
        public long Entidad          { get; set; }
		public DateTime FechaVtoPass { get; set; }
		public DateTime FechaAlta    { get; set; }
		public DateTime FechaBaja    { get; set; }
		public bool IsBloqueado      { get; set; }
		public int ReintentosIngreso { get; set; }
		public bool IsAdmin          { get; set; }
		public int CodEntidad        { get; set; }
		public string Email          { get; set; }
		public string IdInterno      { get; set; }

		public Usuario() { }

		public Usuario(IDataRecord reader)
		{
			Codigo            = (int)reader["US_CODUSU"];
			Nombre            = reader["US_NOMBRE"].ToStringOrEmpty();
			Descripcion       = reader["US_DESCRI"].ToStringOrEmpty();
			Password          = reader["US_PASSWO"].ToStringOrEmpty();

			FechaVtoPass      = DateTime.Parse(reader["US_FECVTO"].ToStringOrEmpty());
			FechaAlta         = DateTime.Parse(reader["US_FECALT"].ToStringOrEmpty());
			FechaBaja         = DateTime.Parse(reader["US_FECBAJ"].ToStringOrEmpty());

			IsBloqueado       = ((int)reader["US_BLOQUE"]) == 0 ? false :  true;
			ReintentosIngreso = (int)reader["US_GRACIA"];
			IsAdmin           = ((int)reader["US_ADMIN"]) == 0 ? false : true;
			CodEntidad        = int.Parse(reader["US_CODENT"].ToString());
			Email             = reader["US_CORREO"].ToStringOrEmpty();
			IdInterno         = reader["US_INTERN"].ToStringOrEmpty();
			
			if (reader.ContainsField("US_READER"))
				SoloLectura   = ((int)reader["US_READER"]) == 0 ? false : true;
		}
    }

    public class PrexConfigLocal
    {
        public int Vista             { get; set; }
        public int MultiExec         { get; set; }
        public int MinimizarAlCerrar { get; set; }
        public int InicioTray        { get; set; }
        public int ConfirmarAlSalir  { get; set; }
        public string LastUser       { get; set; }
        public int SiempreIG         { get; set; }

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
		public string CertificatePath    { get; internal set; }
		public string CertificatePass    { get; internal set; }
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
            if (!CARPETA_LOCAL.ToStringOrEmpty().EndsWith("\\")) CARPETA_LOCAL += "\\";

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

        public static string ARCHIVO_CONFIG_LOCAL 
        {
            get
            {
                var usuario = System.Security.Principal.WindowsIdentity.GetCurrent();
				string carpetaConusuario;
				if (usuario.Name.Split(@"\".ToCharArray()).Count() > 1)
                    carpetaConusuario = Path.Combine(PrexConfig.CARPETA_LOCAL, usuario.Name.Split(@"\".ToCharArray()).LastOrDefault());
                else
                    carpetaConusuario = Path.Combine(PrexConfig.CARPETA_LOCAL, usuario.Name);

                if (!Directory.Exists(carpetaConusuario))
                    Directory.CreateDirectory(carpetaConusuario);

                var sRuta = Path.Combine(carpetaConusuario, PrexConfig.NOMBRE_INI_LOCAL);
                var sRutaIni = Path.Combine(PrexConfig.CARPETA_LOCAL, PrexConfig.NOMBRE_INI_LOCAL);

                if (File.Exists(sRutaIni) && !File.Exists(sRuta))
                    File.Copy(sRutaIni, sRuta);

                return sRuta;
            }
        }

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

        public static bool TieneConfigLocal =>/* _config != null &&*/ File.Exists(ARCHIVO_CONFIG_LOCAL);

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

        public static void LeerXMLLocal()
        {
            try
            {
                if (!TieneConfigLocal)
                    GuardarXMLLocal();
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

        public static void GuardarXMLLocal()
        {

            var _xmlLocal = new XmlDocument();
            var dec = _xmlLocal.CreateXmlDeclaration("1.0", "", "yes");
            _xmlLocal.AppendChild(dec);

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


    }

    
}
