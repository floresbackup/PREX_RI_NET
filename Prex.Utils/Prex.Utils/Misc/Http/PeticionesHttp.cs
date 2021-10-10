using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Prex.Utils.Misc.Http
{
	public class ResponseResult
	{ 
		public HttpStatusCode StatusCode { get; private set; }
		public string Content { get; private set; }

		public ResponseResult(IRestResponse restResponse): this(restResponse.StatusCode, restResponse.Content)
		{
		}

        public ResponseResult(HttpStatusCode httpStatusCode, string content)
        {
            StatusCode = httpStatusCode;
            Content = content;
        }


    }

    public static class PeticionesHttp
	{
		public static ResponseResult GetResponse(string url, SecurityProtocolType? securityProtocolType = null) => GetResponse(url, null, securityProtocolType);
		public static ResponseResult GetResponse(string url, string mediaTypeBody, SecurityProtocolType? securityProtocolType = null) => ExecuteRequest(url, string.Empty, Method.GET, null, mediaTypeBody, securityProtocolType);
		public static ResponseResult GetResponse(string url, string certificatePath, string secretKey, string mediaTypeBody, SecurityProtocolType? securityProtocolType = null) => ExecuteRequest(url, string.Empty, Method.GET, BuildCertificado(certificatePath, secretKey), mediaTypeBody, securityProtocolType);


		public static ResponseResult PostRequest(string url, string body, string certificatePath, string secretKey, string mediaTypeBody, SecurityProtocolType? securityProtocolType = null) => ExecuteRequest(url, body, Method.POST, BuildCertificado(certificatePath, secretKey), mediaTypeBody, securityProtocolType);
		public static ResponseResult PostRequest(string url, string body, string mediaTypeBody, SecurityProtocolType? securityProtocolType = null) => ExecuteRequest(url, body, Method.POST, null, mediaTypeBody, securityProtocolType);

		private static X509Certificate2 BuildCertificado(string certificatePath, string secretKey)
		{

			if (!File.Exists(certificatePath))
				throw new ArgumentException("No se encuentra ruta o archivo certificado");

			//if (Path.GetExtension(certificatePath) != ".pfx")
			//	throw new ArgumentException("El certificado debe ser PFX");
			try
			{
				return new X509Certificate2(certificatePath, secretKey);
			}
			catch (Exception ex)
			{
				throw new Exception("No fue posible construir certificado.", ex);
			}
		}

		private static ResponseResult ExecuteRequest(string url, string body, Method httpMethod, X509Certificate2 certificate, string mediaTypeBody, SecurityProtocolType? securityProtocolType)
		{

//			ServicePointManager.Expect100Continue = true;
//			ServicePointManager.DefaultConnectionLimit = 9999;

            if (securityProtocolType != null)
                ServicePointManager.SecurityProtocol = securityProtocolType.Value;
            
            ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate2, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            var client = new RestClient(url);
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
			var rest = (RestResponse)response;

			
			return new ResponseResult(response);
		}


        public static ResponseResult GestionarPeticion(string url, string data, HttpMethod method, string ContentType, Dictionary<string, string> Headers, TimeSpan? timeOut, SecurityProtocolType? securityProtocolType = null) => GestionarPeticion(url, data, method, ContentType, Headers, null, timeOut, securityProtocolType);
        public static ResponseResult GestionarPeticion(string url, string data, HttpMethod method, string ContentType, Dictionary<string, string> Headers, string certificatePath, string secretKey, TimeSpan? timeOut, SecurityProtocolType? securityProtocolType = null) => GestionarPeticion(url, data, method, ContentType, Headers, BuildCertificado(certificatePath, secretKey), timeOut, securityProtocolType);
        private static ResponseResult GestionarPeticion(string url, string data, HttpMethod method, string ContentType, Dictionary<string, string> Headers, X509Certificate2 certificate, TimeSpan? timeOut, SecurityProtocolType? securityProtocolType)
        {

            //https://www.it-swarm-es.com/es/c%23/el-cliente-y-el-servidor-no-pueden-comunicarse-porque-no-poseen-un-algoritmo-comun-asp.net-c-iis/1048821062/
            if (securityProtocolType != null)
                ServicePointManager.SecurityProtocol = securityProtocolType.Value;
            
            ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate2, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            HttpWebRequest request = WebRequest.Create(new Uri(url)) as HttpWebRequest;
            if (certificate != null)
                request.ClientCertificates = new X509CertificateCollection() { certificate };


            string returnContent;
            request.Method = method.ToString();
            request.Accept = ContentType;
            request.ContentType = ContentType;
            request.KeepAlive = false;
            var httpStatusCode = HttpStatusCode.NoContent;

            if (timeOut.HasValue)
            {
                request.ReadWriteTimeout = (int)Math.Round(timeOut.Value.TotalMilliseconds);
                request.Timeout = (int)Math.Round(timeOut.Value.TotalMilliseconds);
            }

            if (Headers != null)
            {
                Headers.ToList().ForEach(h => request.Headers.Add(h.Key, h.Value));
            }

            if (!data.IsNullOrEmpty())
            {
                var byteData = System.Text.Encoding.UTF8.GetBytes(data);
                request.ContentLength = byteData.Length;
                using (var postStream = request.GetRequestStream())
                {
                    postStream.Write(byteData, 0, byteData.Length);
                    postStream.Close();
                }
            }

            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    var reader = new StreamReader(response.GetResponseStream());
                    returnContent = reader.ReadToEnd();
                    reader.Close();
                    httpStatusCode = response.StatusCode;

                    if (response.StatusCode == HttpStatusCode.NoContent | returnContent.IsNullOrEmpty())
                        returnContent = Newtonsoft.Json.JsonConvert.SerializeObject((new { Status = Convert.ToInt32((int)response.StatusCode) }));

                    response.Close();
                }
            }
            catch (WebException wex)
            {
                returnContent = $"{wex.GetFullTextStack()} - WebStatusCode: {wex.Status}";
                httpStatusCode = HttpStatusCode.InternalServerError;

                if (wex.Status == WebExceptionStatus.ProtocolError)
                {
                    var errorResponse = wex.Response as HttpWebResponse;
                    if (errorResponse != null)
                    {
                        var reader = new StreamReader(errorResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                        returnContent = reader.ReadToEnd();
                        reader.Close();
                        errorResponse.Close();
                        httpStatusCode = errorResponse.StatusCode;
                    }
                }
              
              
            }
            finally
            {
                request.Abort();
            }

            return new ResponseResult(httpStatusCode, returnContent);
        }

    }
}
