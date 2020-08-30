using Google.Apis.Oauth2.v2.Data;
using Newtonsoft.Json;

namespace Prex.Utils.Security.SSO.Google
{
	public class UserInfoWrapper
	{
		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("family_name")]
		public string Apellido { get; set; }

		[JsonProperty("gender")]
		public string Genero { get; set; }

		[JsonProperty("given_name")]
		public string Nombre { get; set; }

		[JsonProperty("hd")]
		public string Dominio { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("locale")]
		public string Locale { get; set; }

		[JsonProperty("name")]
		public string NombreCompleto { get; set; }

		[JsonProperty("picture")]
		public virtual string Foto { get; set; }


		public UserInfoWrapper()
		{ }

	}
}
