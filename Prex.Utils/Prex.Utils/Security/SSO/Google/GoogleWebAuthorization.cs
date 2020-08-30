using DevExpress.Printing.Core.PdfExport.Metafile;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Gmail.v1;
using Google.Apis.Oauth2.v2;
using Google.Apis.Reseller.v1;
using Google.Apis.Services;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Prex.Utils.Security.SSO.Google
{
	//https://www.codeproject.com/Articles/1088092/ADO-NET-Implementation-of-Google-API-IDataStore
	public class GoogleWebAuthorization
    {
		#region Variables

		private GmailService gmailService;
        private ResellerService gsuiteResellerService;
        private Oauth2Service oauth2Service;
		#endregion

		#region Propiedades

		public string ApplicationName => "Prex";
        public UserCredential UserCredentials { get; private set; }
        public ClientSecrets ClientSecrets { get; private set; }
        public GmailService GmailService
        {
            get 
            {
                if (gmailService != null) return gmailService;
                return gmailService = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = UserCredentials,
                    ApplicationName = ApplicationName,
                });
                
            }
        }

        public Oauth2Service Oauth2Service
        {
            get 
            {
                if (oauth2Service != null) return oauth2Service;

                return oauth2Service = new Oauth2Service(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = UserCredentials,
                        ApplicationName = ApplicationName,
                    });

            }

        }
		#endregion

		#region Constructores

		public ResellerService GsuiteService
        {
            get 
            {
                if (gsuiteResellerService != null) return gsuiteResellerService;
                return gsuiteResellerService = new ResellerService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = UserCredentials,
                    ApplicationName = ApplicationName,
                });
            }
        }

        public GoogleWebAuthorization(string jsonCredentials)
        {
            ClientSecrets = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientSecrets>(jsonCredentials);
        }

        public GoogleWebAuthorization(FileStream stream)
        {
            ClientSecrets = GoogleClientSecrets.Load(stream).Secrets;
        }
        #endregion


        public UserCredential Autenticar(string usuario, IList<string> scopes)
        {
            // The file token.json stores the user's access and refresh tokens, and is created
            // automatically when the authorization flow completes for the first time.
            UserCredentials = GoogleWebAuthorizationBroker.AuthorizeAsync(ClientSecrets,
                scopes, 
                usuario,
                CancellationToken.None,
                new SQLGoogleDataStore()).Result;


            return UserCredentials;

        }


        public void RefreshToken(string usuario)
        {
            var flow = new GoogleAuthorizationCodeFlow(
                     new GoogleAuthorizationCodeFlow.Initializer()
                     {
                         ClientSecrets = ClientSecrets
                     });

            var cred = new UserCredential(flow, usuario, UserCredentials.Token);
            
            var refreshToken = cred.Flow.RefreshTokenAsync(usuario, UserCredentials.Token.RefreshToken, CancellationToken.None).Result;
          
        }
    }


}
