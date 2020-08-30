using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.GData.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prueba
{
    public class GmailLogin
    {
        private static string xoauthKey;
        private static string userEmail;
        private static string userName;
        private static UserCredential credential;
        private static string[] contacts;
        private static string[,] contactDetails;
        private static int totContacts;
        private static ContactsRequest cr;
        private static readonly GmailLogin m_Instance = new GmailLogin();

        // Prevent instance creation from other classes using singleton design pattern
        public GmailLogin()
        {
        }

        public static GmailLogin Instance

        {
            get
            {
                return m_Instance;
            }
        }

        public bool GoogleLogin()
        {
            // Request Gmail IMAP/SMTP scope and the e-mail address scope.
            string[] scopes = new string[] { "https://www.googleapis.com/auth/admin.directory.user.readonly" }; //"https://mail.google.com/", Oauth2Service.Scope.UserinfoEmail, Oauth2Service.Scope.UserinfoProfile, "https://www.google.com/m8/feeds/" 
            Console.WriteLine("Requesting authorization");
            var secret = File.ReadAllText("C:\\Prex\\Naranja X\\cert\\cert.pem"); 

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "managegsuiteusers@kibananaranjacom-1567620199723.iam.gserviceaccount.com",
                    ClientSecret = secret,
                },
            scopes,
            "user",
            CancellationToken.None).Result;
            Console.WriteLine("Authorization granted or not required( if the saved access token already available)");
            /*
             * 
             * access token is also saved locally in a persistent location
             * C:\Users\UserName\AppData\Roaming\Google.Apis.Auth\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user 
             * for later use.
             */
            if (credential.Token.IsExpired(credential.Flow.Clock))
            {
                Console.WriteLine("The access token has expired, refreshing it");
                try
                {
                    if (credential.RefreshTokenAsync(CancellationToken.None).Result)
                    {
                        Console.WriteLine("The access token is now refreshed");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("The access token has expired but we can’t refresh it");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("The access token is OK, continue");
                return true;
            }
        }

        public void RequestEmail()
        {
            Console.WriteLine("Requesting the e - mail address of the user from Google");

            Oauth2Service oauthService = new Oauth2Service(
                new BaseClientService.Initializer()
                {
                    HttpClientInitializer = GmailLogin.getCredential()
                });
            var userInfo = oauthService.Userinfo.Get().ExecuteAsync().Result;
            userEmail = userInfo.Email;
            userName = userInfo.Name;
            Console.WriteLine("E - mail address is " +userEmail);
            //to access user’s contact list
            RequestSettings settings = new RequestSettings("Google Sync.", GmailLogin.getCredential().Token.AccessToken)
            {
                AutoPaging = true,
                UseSSL = true
            };
            //cr = new ContactsRequest(settings);
            //FetchAllContacts(cr, userEmail);


            // Build XOAUTH2 token to use Gmail IMAP or SMTP.
           // xoauthKey = Google.Apis.Auth.OAuth2.GetXOAuthKeyStatic(userEmail, GmailLogin.getCredential().Token.AccessToken);
            // return true;
        }

        public void RevokeAccessToken()
        {
            FileDataStore ds = new FileDataStore(GoogleWebAuthorizationBroker.Folder);
            ds.DeleteAsync<TokenResponse>("user").Wait();
        }

        public static string getUserEmail()
        {
            return userEmail;
        }

       /* public void FetchAllContacts(ContactsRequest cr, String email)
        {
            Feed<Contact> feed = cr.GetContacts(email);
            int i = 0;
            Console.WriteLine(feed.TotalResults);
            contacts = new string[feed.TotalResults];
            contactDetails = new string[feed.TotalResults, 3];
            totContacts = feed.TotalResults;
            foreach (var entry in feed.Entries)
            {
                //Console.WriteLine(entry.Name.FullName);
                //entry.Id
                contactDetails[i, 0] = entry.Id;
                contactDetails[i, 1] = entry.Name.FullName;

                foreach (var e in entry.Emails)
                {
                    Console.WriteLine("\t" +e.Address);
                    contacts[i] = e.Address;
                    // Console.WriteLine(contacts[i]);
                    contactDetails[i, 2] = e.Address;
                    i++;
                }
            }
        }
       */
        public static string[] getContacts()
        {
            return contacts;
        }

        public static string[,]

        getContactDetails()
        {
            return contactDetails;
        }

        public static string getUserName()
        {
            return userName;
        }

        public static string getOauthKey()
        {
            return xoauthKey;
        }

        public static int getTotContacts()
        {
            return totContacts;
        }
/*
        public static bool DeleteContact(Uri contactURL)
        {
            // Retrieving the contact is required in order to get the Etag.
            Contact contact = cr.Retrieve<Contact>(contactURL);
            try
            {
                cr.Delete(contact);
                return true;
            }
            catch (GDataVersionConflictException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
*/
        public static UserCredential getCredential()
        {
            return credential;
        }
    }
}

