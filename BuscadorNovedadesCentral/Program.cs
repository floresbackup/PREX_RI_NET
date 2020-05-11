using HtmlAgilityPack;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

namespace BuscadorNovedadesCentral
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Iniciando proceso");

			var url = System.Configuration.ConfigurationManager.AppSettings["urlCentral"];
			var dominioCentral = (new Uri(url)).GetLeftPart(UriPartial.Authority);
			var carpetaDestino = System.Configuration.ConfigurationManager.AppSettings["destino"];
			var maxComunicaciones = int.Parse(System.Configuration.ConfigurationManager.AppSettings["maxRegistros"]);
			var listTipos = new List<string>() { "A", "B", "C" };

			Console.WriteLine("Configuracion:");
			Console.WriteLine($"	* Url: {url}");
			Console.WriteLine($"	* Tipos: {String.Join("-", listTipos)}");
			Console.WriteLine($"	* Max reg: {maxComunicaciones}");
			Console.WriteLine($"	* Carpeta Destino: {carpetaDestino}");
			Console.WriteLine();

			if (!Directory.Exists(carpetaDestino))
				Directory.CreateDirectory(carpetaDestino);
			

			listTipos.ForEach(tipo => {
					try
				{
					Console.WriteLine($"Buscando novedades del tipo {tipo}...");

					var html = GetHtmlCentral(tipo, url);
					if (html.Contains("No existen registros"))
					{
						Console.Write("    [No existen registros]");
						return;
					}

					if (html.Any())
					{
						HtmlDocument doc = new HtmlDocument();
						doc.LoadHtml(html);

						var tds = doc.DocumentNode.SelectNodes("//table[contains(@class, 'table-BCRA')]//tbody//tr//td[2]").Take(maxComunicaciones).ToList();

						tds.ForEach(cell =>
						{
							var hy = cell.SelectSingleNode("a");
							if (hy != null && hy.OuterHtml.Contains($"{cell.InnerText}.pdf"))
							{
								var href = hy.Attributes["href"].Value;
								if (href.Any())
									DescargarArchivoFull(href.Replace("..", dominioCentral), carpetaDestino);
							}
						}) ;


					}
				}
				catch (Exception ex)
				{

				}
			});

		}
		private static void DescargarArchivoFull(string url, string rutaDestino)
		{
			try
			{
				var fileName = Path.GetFileName(url);
				var pathDestino = Path.Combine(rutaDestino, fileName);
				if (File.Exists(pathDestino))
				{
					Console.WriteLine($"	-Sin novedad {fileName}");
					return;
				}

				using (URLHelp helper = new URLHelp())
				{
					helper.GetFileFromWebAndSave(url, pathDestino);
					Console.WriteLine($"	-Copiado {pathDestino}");
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ocurrio un error al descargar archivo {url}");
			}
		}

		private static void DescargarArchivo(string url, string rutaDestino)
		{
			try
			{

				MemoryStream ms = null;
				var fileName    = Path.GetFileName(url);

				using (URLHelp helper = new URLHelp())
				{
					ms = helper.GetFileFromWeb(url);
				}

				//System.Threading.Thread.Sleep(5000);

				if (ms == null || ms.Length == 0)
				{
					Console.WriteLine($"	-No se encontro file {fileName}");
					return;
				}

				var pathDestino = Path.Combine(rutaDestino, fileName);


				if (File.Exists(pathDestino))
					File.Delete(pathDestino);

				using (FileStream file = new FileStream(pathDestino, FileMode.Create, FileAccess.Write))
				{
					byte[] bytes = new byte[ms.Length];
					ms.Read(bytes, 0, (int)ms.Length);
					file.Write(bytes, 0, bytes.Length);
					ms.Close();
				}


				Console.WriteLine($"	-Copiado {pathDestino}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ocurrio un error al descargar archivo {url}");
			}
		}

		private static string GetHtmlCentral(string tipo, string urlCentral)
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
			return response.Content;
		}




		public class URLHelp: IDisposable	
		{
			public URLHelp() { }

			public void Dispose()
			{
				
			}



			public MemoryStream GetFileFromWeb(string URL) => GetFileFromWeb(URL, true);

			public MemoryStream GetFileFromWeb(string URL, bool force)
			{
				var sURL = URL.Trim();

				try
				{
					Console.Write($"Descargando {URL}");
					if (!sURL.ToLower().StartsWith("http://") && !sURL.ToLower().StartsWith("https://")) sURL = "http://" + sURL;


					HttpWebRequest request = ((HttpWebRequest)(WebRequest.Create(URL)));

					request.Method = "GET";

					WebResponse response = request.GetResponse();

					var encoding = ((System.Net.HttpWebResponse)(response)).ContentEncoding;
					var objwebClient = new WebClient
					{
						UseDefaultCredentials = true,
						Encoding = System.Text.Encoding.UTF8
					};

					var file = objwebClient.DownloadData(sURL);

					MemoryStream objImage = null;
					if (encoding.ToLower().Trim() == "gzip")
					{

						objImage = new MemoryStream();

						var stream = new GZipStream(new MemoryStream(file), CompressionMode.Decompress);

						var size = 4096;
						if (size > file.Length) size = file.Length;
						var buffer = new byte[file.Length];

						var count = 0;
						do
						{
							count = stream.Read(buffer, 0, size);

							if (count > 0)
								objImage.Write(buffer, 0, count);

						} while (count > 0);
					}
					else
						objImage = new MemoryStream(file);



					objwebClient.Dispose();
					objwebClient = null;

					return objImage;


				}
				catch (Exception ex)
				{
					if (((System.Net.WebException)ex).Status == WebExceptionStatus.Timeout && force)
						return GetFileFromWeb(URL, false);

					throw ex;
				}

			}

			public void GetFileFromWebAndSave(string URL, string fileName)
			{
				var sURL = URL.Trim();

				try
				{
					if (File.Exists(fileName))
						File.Delete(fileName);

					Console.Write($"Descargando {URL}");
					if (!sURL.ToLower().StartsWith("http://") && !sURL.ToLower().StartsWith("https://")) sURL = "http://" + sURL;

					var objwebClient = new WebClient
					{
						UseDefaultCredentials = true,
						Encoding = System.Text.Encoding.UTF8
					};

					objwebClient.DownloadFile(sURL, fileName);
				}
				catch (Exception ex)
				{

					throw ex;
				}

			}
		}

	}
}
