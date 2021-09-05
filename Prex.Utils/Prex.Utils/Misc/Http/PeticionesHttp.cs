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
		public static ResponseResult GetResponse(string url) => GetResponse(url, null);
		public static ResponseResult GetResponse(string url, string mediaTypeBody) => ExecuteRequest(url, string.Empty, Method.GET, null, mediaTypeBody);
		public static ResponseResult GetResponse(string url, string certificatePath, string secretKey, string mediaTypeBody) => ExecuteRequest(url, string.Empty, Method.GET, BuildCertificado(certificatePath, secretKey), mediaTypeBody);


		public static ResponseResult PostRequest(string url, string body, string certificatePath, string secretKey, string mediaTypeBody) => ExecuteRequest(url, body, Method.POST, BuildCertificado(certificatePath, secretKey), mediaTypeBody);
		public static ResponseResult PostRequest(string url, string body, string mediaTypeBody) => ExecuteRequest(url, body, Method.POST, null, mediaTypeBody);

		private static X509Certificate2 BuildCertificado(string certificatePath, string secretKey)
		{

			if (!File.Exists(certificatePath))
				throw new ArgumentException("No se encuentra ruta o archivo certificado");

			if (Path.GetExtension(certificatePath) != ".pfx")
				throw new ArgumentException("El certificado debe ser PFX");
			try
			{
				return new X509Certificate2(certificatePath, secretKey);
			}
			catch (Exception ex)
			{
				throw new Exception("No fue posible construir certificado.", ex);
			}
		}

		private static ResponseResult ExecuteRequest(string url, string body, Method httpMethod, X509Certificate2 certificate, string mediaTypeBody)
		{
			var client = new RestClient(url);

			ServicePointManager.Expect100Continue = true;
			ServicePointManager.DefaultConnectionLimit = 9999;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

			if (certificate != null)
				client.ClientCertificates = new X509CertificateCollection() { certificate };

			client.Timeout = -1;

			var restrequest = new RestRequest(httpMethod);
			if (!body.IsNullOrEmpty())
			{
				if (mediaTypeBody.IsNullOrEmpty())
					throw new ArgumentNullException("mediaTypeBody");

				restrequest.AddParameter(mediaTypeBody, body, ParameterType.RequestBody);
				//restrequest.AddJsonBody(Newtonsoft.Json.JsonConvert.DeserializeObject(body), mediaTypeBody);
			}

			//restrequest.AddHeader("Cache-Control", "no-cache");
			//restrequest.AddHeader("Accept", "application/json");
			//restrequest.AddHeader("Content-Type", "application/json");
			//restrequest.AddParameter("myStuff", ParameterType.RequestBody);

			var response = client.Execute(restrequest);

			return new ResponseResult(response);
		}
	}
}
