using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2.Data;
using Prex.Utils.Security.SSO.Google;
using System;
using System.Collections.Generic;
using System.IO;

namespace Prex.Utils.Security
{
	public static class NaranjaSecurity
	{

		public static UserInfoWrapper AutenticarConGoogle() => AutenticarConGoogle(Configuration.PrexConfig.UsuarioActual.Nombre);
		public static UserInfoWrapper AutenticarConGoogle(string userName)
		{
			if (userName.IsNullOrEmpty())
				throw new ArgumentException("No se pudo leer parámetro userName");

			if (Configuration.PrexConfig.FILE_GOOGLE_CREDENTIALS.IsNullOrEmpty())
				throw new ArgumentException("No se pudo leer parámetro FILE_GOOGLE_CREDENTIALS");

			if (!File.Exists(Configuration.PrexConfig.FILE_GOOGLE_CREDENTIALS.Trim()))
				throw new Exception($"No se encontró archivo json de credenciales de aplicacion (Path: {Configuration.PrexConfig.FILE_GOOGLE_CREDENTIALS})");

			try
			{
				UserCredential credentials = null;
				using (var file = new FileStream(Configuration.PrexConfig.FILE_GOOGLE_CREDENTIALS.Trim(), FileMode.Open, FileAccess.Read))
				{
					var googleWebAutorization = new GoogleWebAuthorization(file);
					credentials = googleWebAutorization.Autenticar(userName, new List<string>() { @"https://www.googleapis.com/auth/userinfo.profile", @"https://www.googleapis.com/auth/userinfo.email", @"https://www.googleapis.com/auth/admin.directory.user" }); // @"https://www.googleapis.com/auth/admin.directory.user.readonly"  });
					return googleWebAutorization.GetUserInfo();
				}
			}
			catch (Exception ex)
			{
				var strMsg = string.Empty;
				if (ex.Message.Contains("invalid_grant") || (ex.InnerException != null && ex.InnerException.Message.Contains("invalid_grant")))
					strMsg = "invalid_grant";
				if (ex.Message.Contains("access_denied") || (ex.InnerException != null && ex.InnerException.Message.Contains("access_denied")))
					strMsg = "access_denied";

				if (!strMsg.IsNullOrEmpty()) throw new UnauthorizedAccessException(strMsg);

				throw new Exception("Ocurrio un error al intentar autenticar con Google", ex);
			}
		}
	}
}
