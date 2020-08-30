using Google.Apis.Auth.OAuth2;
using Google.Apis.Reseller.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin.Security.DataHandler.Encoder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Google.Apis.Iam.v1;
using Google.Apis.Iam.v1.Data;

namespace AdminSDKResellerQuickstart
{



	class Program
	{
		static void Main(string[] args)
		{

			//PruebaGSuite();

			UserCredential credential;
			
			using (var stream =	new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
			{
				// The file token.json stores the user's access and refresh tokens, and is created
				// automatically when the authorization flow completes for the first time.
				string credPath = "token.json";
				credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
					GoogleClientSecrets.Load(stream).Secrets,
					new List<string>() { @"https://www.googleapis.com/auth/admin.directory.user.readonly" },
					"user",
					CancellationToken.None,
					new FileDataStore(credPath, true)).Result;
				Console.WriteLine("Credential file saved to: " + credPath);
			}
			// Create G Suite Reseller API service.
			var service = new ResellerService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = "",
			});

			try
			{
				var s = new Google.Apis.Admin.Directory.directory_v1.UsersResource(service);
				var usuario = s.Get("cyberx");
				if (usuario != null)
				{
					var u = usuario.Execute();
				}
			}
			catch (Exception ex)
			{

			}
			
		}


		//static void Main(string[] args)
		//{
		//	var g = PruebaToken.GetAuthorizationToken();



		//	var utc0 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
		//	var issueTime = DateTime.Now.ToUniversalTime();

		//	var iat = (int)issueTime.Subtract(utc0).TotalSeconds;
		//	var exp = (int)issueTime.AddMinutes(55).Subtract(utc0).TotalSeconds; // Expiration time is up to 1 hour, but lets play on safe side

		//	//var payload = new
		//	//{
		//	//	iss = "managegsuiteusers@kibananaranjacom-1567620199723.iam.gserviceaccount.com",
		//	//	sub = "iam-nx@naranjax.com",
		//	//	scope = "https://www.googleapis.com/auth/admin.directory.user.readonly",
		//	//	aud = "https://oauth2.googleapis.com/token",
		//	//	exp = exp,
		//	//	iat = iat
		//	//};

		//	//var secret = File.ReadAllText("C:\\Prex\\Naranja X\\cert\\cert.pem"); 

		//	//IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
		//	//IJsonSerializer serializer = new JsonNetSerializer();
		//	//IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
		//	//IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

		//	//var token = encoder.Encode(payload, secret);
		//	//Console.WriteLine(token);

		//	string key = File.ReadAllText("C:\\Prex\\Naranja X\\cert\\cert.pem");
		//	var rsa = new RSACryptoServiceProvider(2048);

		//	var signingKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
		//	var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature);
		//	//var signingCredentials = new SigningCredentials(new RsaSecurityKey(rsa), SecurityAlgorithms.RsaSha256);

		//	var header = new JwtHeader(signingCredentials);


		//	var payload = new JwtPayload
		//	{
		//	   { "iss", "managegsuiteusers@kibananaranjacom-1567620199723.iam.gserviceaccount.com"},
		//	   { "iat", iat },
		//	   { "exp", exp},
		//	   { "sub", "iam-nx@naranjax.com" },
		//	   { "scope" , @"https://www.googleapis.com/auth/admin.directory.user.readonly"},
		//	   { "aud", @"https://oauth2.googleapis.com/token"}
		//	};

		//	var secToken = new JwtSecurityToken(header, payload);
		//	var tokenString = new JwtSecurityTokenHandler().WriteToken(secToken);

		//	var jsonWebTokenHandler = new JsonWebTokenHandler();
		//	var jsonWebTokenString = jsonWebTokenHandler.CreateToken(JsonConvert.SerializeObject(payload), signingCredentials);
		//	var jsonWebToken = new JsonWebToken(jsonWebTokenString);


		//	var w = Prex.Utils.Security.SSO.GoogleJsonWebToken.Encode("iam-nx@naranjax.com", "C:\\Prex\\Naranja X\\cert\\cert.pem");





		//	/*
		//	// Define parameters of request.
		//	SubscriptionsResource.ListRequest request = service.Subscriptions.List();
		//	request.MaxResults = 10;

		//	try
		//	{

		//		// List subscriptions.
		//		IList<Subscription> subscriptions = request.Execute().SubscriptionsValue;
		//		Console.WriteLine("Subscriptions:");
		//		if (subscriptions != null && subscriptions.Count > 0)
		//		{
		//			foreach (var subscription in subscriptions)
		//			{
		//				Console.WriteLine("{0} ({1}, {2})", subscription.CustomerId,
		//					subscription.SkuId, subscription.Plan.PlanName);
		//			}
		//		}
		//		else
		//		{
		//			Console.WriteLine("No subscriptions found.");
		//		}
		//	}
		//	catch (Exception ex)
		//	{

		//	}

		//	try
		//	{
		//		// Create Directory API service.
		//		var service2 = new DirectoryService(new BaseClientService.Initializer()
		//		{
		//			HttpClientInitializer = credential,
		//			ApplicationName = ApplicationName,
		//		});
		//		var us = service2.Users.Get("raul.gatti@naranjax.com").Execute();

		//		// Define parameters of request.
		//		UsersResource.ListRequest request2 = service2.Users.List();
		//		request2.Customer = "my_customer";
		//		request2.MaxResults = 10;
		//		request2.OrderBy = UsersResource.ListRequest.OrderByEnum.Email;

		//		// List users.
		//		IList<User> users = request2.Execute().UsersValue;
		//		Console.WriteLine("Users:");
		//		if (users != null && users.Count > 0)
		//		{
		//			foreach (var userItem in users)
		//			{
		//				Console.WriteLine("{0} ({1})", userItem.PrimaryEmail,
		//					userItem.Name.FullName);
		//			}
		//		}
		//		else
		//		{
		//			Console.WriteLine("No users found.");
		//		}
		//		Console.Read();
		//	}
		//	catch (Exception ex)
		//	{

		//	}
		//	Console.Read();
		//	*/
		//}

		public static void PruebaGSuite()
		{

			UserCredential credential;


			using (var stream =
				new FileStream("C:\\Prex\\Naranja X\\cert\\credentials.json", FileMode.Open, FileAccess.Read))
			{
				// The file token.json stores the user's access and refresh tokens, and is created
				// automatically when the authorization flow completes for the first time.
				string credPath = "token.json";
				credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
				GoogleClientSecrets.Load(stream).Secrets,
					new List<string>() { @"https://www.googleapis.com/auth/admin.directory.user.readonly" },
					"user",
					CancellationToken.None,
					new FileDataStore(credPath, true)).Result;
				Console.WriteLine("Credential file saved to: " + credPath);
			}

			// Create G Suite Reseller API service.
			var service = new ResellerService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = "",
			});

			try
			{
				var s = new Google.Apis.Admin.Directory.directory_v1.UsersResource(service);
				var usuario = s.Get("raul.gatti@naranjax.com");
				if (usuario != null)
				{ }
			}
			catch (Exception ex)
			{

			}

		}
	}

	

	public static class PruebaToken
	{
		public static string GetAuthorizationToken()
		{
			string jwt = CreateJwt();

			var dic = new Dictionary<string, string>
			{
				{ "grant_type", "urn:ietf:params:oauth:grant-type:jwt-bearer" },
				{ "assertion", jwt }
			};
			var content = new FormUrlEncodedContent(dic);

			var httpClient = new HttpClient { BaseAddress = new Uri("https://accounts.google.com") };
			var response = httpClient.PostAsync("/o/oauth2/token", content).Result;
			response.EnsureSuccessStatusCode();

			var dyn = response.Content.ReadAsStringAsync().Result;
			return dyn;//.access_token;
		}

		private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

		private static string CreateJwt()
		{
			var rawData = File.ReadAllText("C:\\Prex\\Naranja X\\cert\\cert.pem");

			//var certificate = new X509Certificate2(@"C:\\Prex\\Naranja X\\cert2.pem");

			DateTime now = DateTime.UtcNow;
			var claimset = new
			{
				iss = "managegsuiteusers@kibananaranjacom-1567620199723.iam.gserviceaccount.com",
				scope = "https://www.googleapis.com/auth/admin.directory.user.readonly",
				aud = "https://oauth2.googleapis.com/token",
				iat = ((int)now.Subtract(UnixEpoch).TotalSeconds).ToString(CultureInfo.InvariantCulture),
				exp = ((int)now.AddMinutes(59).Subtract(UnixEpoch).TotalSeconds).ToString(CultureInfo.InvariantCulture)
			};

			// header
			var header = new { typ = "JWT", alg = "RS256" };

			// encoded header
			var headerSerialized = JsonConvert.SerializeObject(header);
			var headerBytes = Encoding.UTF8.GetBytes(headerSerialized);
			var headerEncoded = TextEncodings.Base64Url.Encode(headerBytes);

			// encoded claimset
			var claimsetSerialized = JsonConvert.SerializeObject(claimset);
			var claimsetBytes = Encoding.UTF8.GetBytes(claimsetSerialized);
			var claimsetEncoded = TextEncodings.Base64Url.Encode(claimsetBytes);

			// input
			var input = String.Join(".", headerEncoded, claimsetEncoded);
			var inputBytes = Encoding.UTF8.GetBytes(input);

			// signiture

			RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
			//var publicKey = PublicKey.GetPublicKey();
			rsa.FromXmlString(
				"<RSAKeyValue>" +
					"<Modulus>" + rawData + "</Modulus>" +
					"<Exponent>AQAB</Exponent>" +
				"</RSAKeyValue>");
			var s = TextEncodings.Base64Url.Encode(rsa.Encrypt(inputBytes, false));

			var cspParam = new CspParameters
			{
				KeyContainerName = "privado",
				KeyNumber = rsa.CspKeyContainerInfo.KeyNumber == KeyNumber.Exchange ? 1 : 2
			};
			var cryptoServiceProvider = new RSACryptoServiceProvider(cspParam) {  PersistKeyInCsp = false };
			
			var signatureBytes = cryptoServiceProvider.SignData(inputBytes, "SHA256");
			var signatureEncoded = TextEncodings.Base64Url.Encode(signatureBytes);

			// jwt
			return String.Join(".", headerEncoded, claimsetEncoded, signatureEncoded);
		}
	}
}