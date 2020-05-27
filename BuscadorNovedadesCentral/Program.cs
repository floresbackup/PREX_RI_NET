using HtmlAgilityPack;
using RestSharp;
using System;
using System.Collections.Concurrent;
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

			var url               = System.Configuration.ConfigurationManager.AppSettings["urlCentral"];
			var dominioCentral    = (new Uri(url)).GetLeftPart(UriPartial.Authority);
			var carpetaDestino    = System.Configuration.ConfigurationManager.AppSettings["destino"];
			var maxComunicaciones = int.Parse(System.Configuration.ConfigurationManager.AppSettings["maxRegistros"]);
			var listTipos         = new List<string>() { "A", "B", "C" };
			var destinatarios     = System.Configuration.ConfigurationManager.AppSettings["destinatarios"].ToString();
			var asunto            = System.Configuration.ConfigurationManager.AppSettings["emailSubject"].ToString();
			var deNombre          = System.Configuration.ConfigurationManager.AppSettings["emailFromName"].ToString();

			Console.WriteLine("Configuracion:");
			Console.WriteLine($"	* Url: {url}");
			Console.WriteLine($"	* Tipos: {String.Join("-", listTipos)}");
			Console.WriteLine($"	* Max reg: {maxComunicaciones}");
			Console.WriteLine($"	* Carpeta Destino: {carpetaDestino}");
			Console.WriteLine();

			if (!Directory.Exists(carpetaDestino))
				Directory.CreateDirectory(carpetaDestino);

			var archivosEncontrados = new ConcurrentBag<string>();
			var cuerpoMail = string.Empty;

			listTipos.ForEach(tipo => {
				try
				{
					Console.WriteLine($"Buscando novedades del tipo {tipo}...");

					var html = Prex.Utils.Misc.Html.GetHtmlFromWeb.GetHtmlString(tipo, url);
					if (html.Contains("No existen registros"))
					{
						Console.Write("    [No existen registros]");
						return;
					}

					if (html.Any())
					{
						HtmlDocument doc = new HtmlDocument();
						doc.LoadHtml(html);

						if (!cuerpoMail.Any())
						{
							var thead = doc.DocumentNode.SelectSingleNode("//table[contains(@class, 'table-BCRA')]//thead");
							cuerpoMail = $"<table style='border: 1px solid black;'>{thead.OuterHtml}";
						}
						var trs = doc.DocumentNode.SelectNodes("//table[contains(@class, 'table-BCRA')]//tbody").Take(maxComunicaciones).ToList();

						trs.ForEach(row =>
						{
							//var cell = row.SelectSingleNode("//tr//td[2]");
							var hy = row.SelectSingleNode("tr/td[2]/a");
							if (hy != null && hy.OuterHtml.Contains($".pdf"))
							{
								var href = hy.Attributes["href"].Value;
								if (href.Any())
								{ 
									var fileName = Path.Combine(carpetaDestino, Path.GetFileName(href));
									if (!File.Exists(fileName))
									{
										try
										{
											archivosEncontrados.Add(fileName);
											Prex.Utils.Misc.Html.mdFileHttp.GetFileFromWebAndSave(href.Replace("..", dominioCentral), carpetaDestino);
										}
										catch (Exception ex)
										{
										}
										cuerpoMail += row.OuterHtml.Replace(href, href.Replace("..", dominioCentral));
									}
								}
							}
						}) ;


					}
				}
				catch (Exception ex)
				{

				}
			});

			cuerpoMail += "</table>";
			if (archivosEncontrados.Any())
			{ 
				Console.WriteLine($"{archivosEncontrados.Count()} Comunicados encontrados");
				Console.WriteLine("	* Enviando correo...");
				if (!asunto.Trim().Any())
					asunto = $"Novedad Central - ({archivosEncontrados.Count()} comunicados nuevos)";

				if (!deNombre.Trim().Any())
					deNombre = "Prex - Novedad Central";
				asunto = asunto.Replace("@CntNotif", archivosEncontrados.Count().ToString());

				Prex.Utils.Misc.MailSender.EnviarMail(deNombre, Prex.Utils.Misc.MailSender.User, destinatarios, asunto, $"<b>Fecha ejecución: {DateTime.Now.ToString()}</b><br /><div style='margin-top: 15px;'>{cuerpoMail}</div>", true);
			}

		}



	}
}
