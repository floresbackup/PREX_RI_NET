using Google.Apis.Admin.Directory.directory_v1;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Oauth2.v2;
using Google.Apis.Reseller.v1;
using Google.Apis.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Prex.Utils.Security.SSO.Google
{
	//https://www.codeproject.com/Articles/1088092/ADO-NET-Implementation-of-Google-API-IDataStore
	public class GoogleWebAuthorization
    {
		#region Variables

        private ResellerService gsuiteResellerService;
        private Oauth2Service oauth2Service;
        private DirectoryService gsuiteDirectoryService;
        #endregion

        #region Propiedades

        public string ApplicationName => "Prex";
        public UserCredential UserCredentials { get; private set; }
        public ClientSecrets ClientSecrets { get; private set; }


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

        public DirectoryService GSuiteDirectoryService
        {
            get 
            {
                if (gsuiteDirectoryService != null) return gsuiteDirectoryService;

                return gsuiteDirectoryService = new DirectoryService(new BaseClientService.Initializer()
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

        public UserDirectoryInfoWrapper GetDirectoryData(string userEmail)
        {
			try
			{
                var d = GSuiteDirectoryService.Users.Get(userEmail);
                d.Projection = UsersResource.GetRequest.ProjectionEnum.Full;
                d.ViewType = UsersResource.GetRequest.ViewTypeEnum.DomainPublic;
                var user = d.Execute();
                if (user == null) return null;
                var jsonUser = JsonConvert.SerializeObject(user, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                return JsonConvert.DeserializeObject<UserDirectoryInfoWrapper>(jsonUser);
			}
			catch (System.Exception ex)
			{
                return null;
			}
        }

        public UserInfoWrapper GetUserInfo()
        {
			try
			{
                var ui = Oauth2Service.Userinfo.Get().Execute();
                if (ui == null || ui.Name.IsNullOrEmpty()) return null;
                var json = JsonConvert.SerializeObject(ui);
                var userInfo = JsonConvert.DeserializeObject<UserInfoWrapper>(json);
                userInfo.DirectoryData = GetDirectoryData(userInfo.Email);
                userInfo.credentials = UserCredentials;
                return userInfo;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }


}
