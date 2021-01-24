using Google.Apis.Admin.Directory.directory_v1.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Prex.Utils.Security.SSO.Google
{
	public class UserInfoWrapper
	{
		private UserCredential _credentials;

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

		public string userId => credentials.UserId;
		public UserCredential credentials { get; set; }
		public UserDirectoryInfoWrapper DirectoryData { get; set; }

		public UserInfoWrapper()
		{ }

	}


	#region DirectoryData
	public class PREXRole
	{
		[JsonProperty("PREX-Role")]
		public string Role { get; set; }
	}

	public class CustomSchemas
	{
		public PREXRole PREX { get; set; }
	}

	public class Email
	{
		public string address { get; set; }
		public bool primary { get; set; }
	}

	public class Name
	{
		public string familyName { get; set; }
		public string fullName { get; set; }
		public string givenName { get; set; }
	}

	public class Organization
	{
		public string customType { get; set; }
		public string department { get; set; }
		public string description { get; set; }
		public bool primary { get; set; }
		public string title { get; set; }
	}

	public class Relation
	{
		public string type { get; set; }
		public string value { get; set; }
	}

	public class UserDirectoryInfoWrapper
	{
		public CustomSchemas customSchemas { get; set; }
		public List<Email> emails { get; set; }
		public string etag { get; set; }
		public string id { get; set; }
		public string kind { get; set; }
		public Name name { get; set; }
		public List<Organization> organizations { get; set; }
		public string primaryEmail { get; set; }
		public List<Relation> relations { get; set; }

		public UserDirectoryInfoWrapper()
		{ }
	}

	#endregion


}
