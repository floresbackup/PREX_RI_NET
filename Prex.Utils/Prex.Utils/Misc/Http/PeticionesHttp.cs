using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Prex.Utils.Misc.Http
{
	public class ResponseResult
	{ 
		public HttpStatusCode StatusCode { get; private set; }
		public string Content { get; private set; }

		public ResponseResult(IRestResponse restResponse)
		{
			StatusCode = restResponse.StatusCode;
			Content = restResponse.Content;
		}
	}

	public static class PeticionesHttp
	{
		public static ResponseResult GetResponse(string url)
		{
			return ExecuteRequest(url, string.Empty, Method.GET, null);
		}

		public static ResponseResult GetResponse(string url, string certificatePath, string secretKey)
		{
			if (!File.Exists(certificatePath))
				throw new ArgumentException("No se encuentra ruta o archivo certificado");

			if (Path.GetExtension(certificatePath) != ".pfx")
				throw new ArgumentException("El certificado debe ser PFX");

			return ExecuteRequest(url, string.Empty, Method.GET, BuildCertificado(certificatePath, secretKey));
		}


		public static ResponseResult PostRequest(string url, string body, string certificatePath, string secretKey) => ExecuteRequest(url, body, Method.POST, BuildCertificado(certificatePath, secretKey));

		public static ResponseResult PostRequest(string url, string body) => ExecuteRequest(url, body, Method.POST, null);

		private static X509Certificate2 BuildCertificado(string certificatePath, string secretKey)
		{
			if (!File.Exists(certificatePath))
				throw new ArgumentException("No se encuentra ruta o archivo certificado");

			if (Path.GetExtension(certificatePath) != ".pfx")
				throw new ArgumentException("El certificado debe ser PFX");

			return new X509Certificate2(certificatePath, secretKey);
		}

		private static ResponseResult ExecuteRequest(string url, string body, Method httpMethod, X509Certificate2 certificate)
		{
			var client = new RestClient(url);

			ServicePointManager.Expect100Continue = true;
			ServicePointManager.DefaultConnectionLimit = 9999;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

			if (certificate != null)
				client.ClientCertificates = new X509CertificateCollection() { certificate };

			client.Proxy = new WebProxy();

			var restrequest = new RestRequest(httpMethod);
			if (!body.IsNullOrEmpty())
				restrequest.AddParameter("text/plain", body, ParameterType.RequestBody);

			//restrequest.AddHeader("Cache-Control", "no-cache");
			//restrequest.AddHeader("Accept", "application/json");
			//restrequest.AddHeader("Content-Type", "application/json");
			//restrequest.AddParameter("myStuff", ParameterType.RequestBody);

			var response = client.Execute(restrequest);

			return new ResponseResult(response);
		}
	}
}
