using Prex.Utils.CitCiberarkService;
using System;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Windows.Forms;

namespace Prex.Utils.Security
{
	public static class CitiSecurity
	{
		/*
		Try {
        String WSDL = ConfigurationManager.AppSettings["WSDL"].ToString();
		String certifcatePath = ConfigurationManager.AppSettings["Certifcate"].ToString();
		String certificatePassword = ConfigurationManager.AppSettings["CertificatePwd"].ToString();
		String appId = ConfigurationManager.AppSettings["AppID"].ToString();
		String safe = ConfigurationManager.AppSettings["Safe"].ToString();
		String folder = ConfigurationManager.AppSettings["Folder"].ToString();
		String objectText = ConfigurationManager.AppSettings["Object"].ToString();
		String reason = ConfigurationManager.AppSettings["Reason"].ToString();

		String password = CyberarkService.GetPassword(WSDL, certifcatePath, certificatePassword, appId, safe, folder, objectText, reason);

		var strcnn =
			New SqlConnectionStringBuilder(
				ConfigurationManager.ConnectionStrings["eBalanceConnectionString"].ToString())
		{
			Password = password

			};
		cnn = New SqlConnection(strcnn.ToString());
	}
	Catch
    {
        var strcnn =
			New SqlConnectionStringBuilder(
				ConfigurationManager.ConnectionStrings["eBalanceConnectionString"].ToString());
	cnn = New SqlConnection(strcnn.ToString());
}
		*/
		public static string GetPassWordCyberRark(string WSDL, string certifcatePath, string certificatePassword, string appId, string safe, string folder, string objectText, string reason)
		{
			string sPassword, sCertifcatePath, sCertificatePwd = string.Empty;
			try
			{

				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
				ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; 
				BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);

				binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;

				var ea = new EndpointAddress(WSDL);
				var client = new AIMServiceSoapClient(binding, ea);

				sCertifcatePath = certifcatePath;

				sCertificatePwd = certificatePassword;
				try
				{
					client.ClientCredentials.ClientCertificate.Certificate = new X509Certificate2(sCertifcatePath, sCertificatePwd);
				}
				catch (Exception ex)
				{
					throw new Exception("No se puede abrir el certificado X509", ex);
				}

				PasswordRequest pr = new PasswordRequest
				{
					AppID  = appId,
					Safe   = safe,
					Folder = folder,
					Object = objectText,
					Reason = reason
				};

				PasswordResponse Prs1 = new PasswordResponse();
				Prs1 = client.GetPassword(pr);
				sPassword = Prs1.Content;

				return sPassword;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}



		public static (string connectionString, string password) ConsultarCyberRark(string WSDL, string certifcatePath, string certificatePassword, string appId, string safe, string folder, string objectText, string reason)
		{
			if (Configuration.PrexConfig.ID_SISTEMA <= 0)
				return (string.Empty, string.Empty);
		
			try
			{
				//MessageBox.Show($"WSDL: {WSDL}, CertifcatePath: {certifcatePath}, " +
				//		$"CertifcatePass: {certificatePassword}, APPID: {appId}, " +
				//		$"SAFE: {safe}, STR_FOLDER: {folder}, " +
				//		$"STR_OBJECT: {objectText}, STR_REASON: {reason}", "Parametros del servicio: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

				var pass = GetPassWordCyberRark(WSDL, certifcatePath, certificatePassword, appId, safe, folder, objectText, reason);
				//MessageBox.Show("CyberRark Pass: " & pass);
				if (pass.IsNullOrEmpty()) return (string.Empty, string.Empty);
				pass = pass.Trim();

				var builder = new OleDbConnectionStringBuilder(Configuration.PrexConfig.CONN_LOCAL);
				var passAnt = string.Empty;
				var teniaPass = false;

				if (builder.ContainsKey("Password"))
				{
					passAnt = builder["Password"].ToString();

					teniaPass = true;
					builder.Remove("Password");

				}

				builder.Add("Password", pass);


				try
				{
					var conn = new OleDbConnection(builder.ConnectionString);
					conn.Open();
					if (conn.State == ConnectionState.Open)
					{
						conn.Close();
					}

					Configuration.PrexConfig.CYBERRARKPASS = pass;
					Configuration.PrexConfig.CONN_LOCAL = builder.ConnectionString;

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error armando conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);


					builder.Remove("Password");

					if (teniaPass)
					{
						builder.Add("Password", passAnt);
						pass = passAnt;
					}
				}

				return (Configuration.PrexConfig.CONN_LOCAL, pass);

			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message, "Error GetPassWordCyberRark", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return (string.Empty, string.Empty);
			}

		}
	}



	/*
			public static string GetPassWordCyberRark(string WSDL, string certifcatePath, string certificatePassword, string appId, string safe, string folder, string objectText, string reason)
			{
				//Para referencia del servicio
				//https://stackoverflow.com/questions/9482773/web-service-without-adding-a-reference
				try
				{
					AIMServiceSoapClient 
					var pass = string.Empty;

					WebService ws = new WebService(WSDL, "GetPassword");
					ws.Params.Add("AppID", appId);
					ws.Params.Add("Safe", safe);
					ws.Params.Add("Folder", folder);
					ws.Params.Add("Object", objectText);
					ws.Params.Add("Reason", reason);
					ws.Invoke();

					return ws.ResultString;
				}
				catch (Exception ex)
				{
					Prex.Utils.ManejarErrores.TratarError(ex, "GetPassWordCyberRark");
					return string.Empty;
				}
			}

		}
		*/
}
