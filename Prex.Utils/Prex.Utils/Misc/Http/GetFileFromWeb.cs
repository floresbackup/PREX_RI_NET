using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Utils.Misc.Http
{
	public class URLHelp : IDisposable
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

	public static class mdFileHttp
	{ 
		public static void GetFileFromWebAndSave(string url, string rutaDestino)
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

		public static void GetFileFromWeb(string url, string rutaDestino)
		{
			try
			{

				MemoryStream ms = null;
				var fileName = Path.GetFileName(url);

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
	}
}
