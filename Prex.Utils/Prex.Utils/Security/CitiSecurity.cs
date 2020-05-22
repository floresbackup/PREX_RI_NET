using Prex.Utils.CitCiberarkService;
using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;

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

				client.ClientCredentials.ClientCertificate.Certificate = new X509Certificate2(sCertifcatePath, sCertificatePwd);

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
