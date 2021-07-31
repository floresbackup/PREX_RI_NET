using RestSharp;
using System;

namespace Prex.Utils.Misc.Http
{
	public static class GetHtmlFromWeb
	{
		public static string GetHtmlString(string tipo, string urlCentral)
		{
			var client = new RestClient(urlCentral)
			{
				Timeout = -1
			};
			var request = new RestRequest(Method.POST);
			
			request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
			request.AddHeader("Cookie", "f5_cspm=1234; ASPSESSIONIDCCQDDASB=JMKAHDCAEPOPODCCHODBJLLH; TS015a32b2=01532640e84cf7eac607081f2b8844a01ad03eb93b5259629c734d93d6737598e2926f96b82a3d1d11810e8341d320156747ae8243b24a98f49cd0b15331876336ca18d699f32bfb80f21b069068dce6a3baa86f76");
			request.AddParameter("tipo", tipo);
			request.AddParameter("B1", "Enviar");
			IRestResponse response = client.Execute(request);
			System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("ISO-8859-1"); 
			var resultEnc = encoding.GetString(response.RawBytes); 

			return resultEnc;
		}
	}

}
