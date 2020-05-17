using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Prex.Utils.Misc
{
	public static class MailSender
	{
		private static string SmtpServer => @"http://webmail.proyectoexcelencia.com.ar/";
		private static int SmtpPort      => 25;
		private static string User       => "prex_sql@proyectoexcelencia.com.ar";
		private static string Pass       => "Ihc438";

		public static void EnviarMail(string deNombre, string deMAil, string destinatarios, string asunto, string mensaje, bool IsHtml)
		{
			if (destinatarios.IsNullOrEmpty()) return;

			var destinatarioList = destinatarios.Split(";".ToCharArray()).ToList();
			if (!destinatarioList.Any()) return;

			try
			{
				MailAddress mailAddress;
				if (deNombre.IsNullOrEmpty())
					mailAddress = new MailAddress(deMAil);
				else
					mailAddress = new MailAddress(deMAil, deNombre);

				var message = new System.Net.Mail.MailMessage
				{
					From = mailAddress
				};

				foreach (var item in destinatarioList.Where(x => x.Length > 5))
				{
					message.To.Add(item);
				}

				message.Body = mensaje;
				/*
				If attachments IsNot Nothing And Not attachments.IsEmpty Then
					message.Attachments.AddRange(attachments, True)
				End If
				*/
				message.Subject = asunto;
				message.IsBodyHtml = IsHtml;


				var emailClient = new SmtpClient("smtp.proyectoexcelencia.com.ar", SmtpPort);
				emailClient.Credentials = new System.Net.NetworkCredential(User, Pass);

				emailClient.Timeout = 100000;

				emailClient.EnableSsl = true;
				ServicePointManager.ServerCertificateValidationCallback =  delegate (object s, X509Certificate certificate,	X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

				emailClient.Send(message);
			}
			catch (SmtpFailedRecipientsException ex)
			{
				throw new SmtpFailedRecipientsException("No se pudo entregar el mail a todos los detinatarios ", ex);
			}
			catch (SmtpFailedRecipientException ex)
			{
				throw new SmtpFailedRecipientException("No se pudo entregar el mail al siguiente destinatario " + ex.FailedRecipient, ex);
			}
			catch (Exception ex)
			{
				throw new Exception("Error enviando mails ", ex);
			}
		}
	}
}
