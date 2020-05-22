using Google.Apis.Admin.Directory.directory_v1;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Reseller.v1;
using Google.Apis.Reseller.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.Owin.Security.Google;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace AdminSDKResellerQuickstart
{
	class Program
	{
		// If modifying these scopes, delete your previously saved credentials
		// at ~/.credentials/reseller-dotnet-quickstart.json
		static string[] Scopes = { ResellerService.Scope.AppsOrder };
		static string ApplicationName = "G Suite Reseller API .NET Quickstart";

		static void Main(string[] args)
		{
			UserCredential credential;
				

			using (var stream =
				new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
			{
				// The file token.json stores the user's access and refresh tokens, and is created
				// automatically when the authorization flow completes for the first time.
				string credPath = "token.json";
				credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
					GoogleClientSecrets.Load(stream).Secrets,
					Scopes,
					"user",
					CancellationToken.None,
					new FileDataStore(credPath, true)).Result;
				Console.WriteLine("Credential file saved to: " + credPath);
			}

			var xCred = new ServiceAccountCredential(new ServiceAccountCredential.Initializer("floresbackup@gmai.com")
			{
				Scopes = new[] {
					ResellerService.Scope.AppsOrder
					}
			}.FromPrivateKey("SjCqED2rgNz8WsBbzSbTkvKo"));



			// Create G Suite Reseller API service.
			var service = new ResellerService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = ApplicationName,
			});

			// Define parameters of request.
			SubscriptionsResource.ListRequest request = service.Subscriptions.List();
			request.MaxResults = 10;

			try
			{

				// List subscriptions.
				IList<Subscription> subscriptions = request.Execute().SubscriptionsValue;
				Console.WriteLine("Subscriptions:");
				if (subscriptions != null && subscriptions.Count > 0)
				{
					foreach (var subscription in subscriptions)
					{
						Console.WriteLine("{0} ({1}, {2})", subscription.CustomerId,
							subscription.SkuId, subscription.Plan.PlanName);
					}
				}
				else
				{
					Console.WriteLine("No subscriptions found.");
				}
			}
			catch (Exception ex)
			{

			}

			try
			{
				// Create Directory API service.
				var service2 = new DirectoryService(new BaseClientService.Initializer()
				{
					HttpClientInitializer = credential,
					ApplicationName = ApplicationName,
				});
				var us = service2.Users.Get("raul.gatti@naranjax.com").Execute();

				// Define parameters of request.
				UsersResource.ListRequest request2 = service2.Users.List();
				request2.Customer = "my_customer";
				request2.MaxResults = 10;
				request2.OrderBy = UsersResource.ListRequest.OrderByEnum.Email;

				// List users.
				IList<User> users = request2.Execute().UsersValue;
				Console.WriteLine("Users:");
				if (users != null && users.Count > 0)
				{
					foreach (var userItem in users)
					{
						Console.WriteLine("{0} ({1})", userItem.PrimaryEmail,
							userItem.Name.FullName);
					}
				}
				else
				{
					Console.WriteLine("No users found.");
				}
				Console.Read();
			}
			catch (Exception ex)
			{

			}
			Console.Read();
		}
	}
}