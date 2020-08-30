
using Google.Apis.Auth.OAuth2;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Prueba
{
    public static class IAPClient
    {
        /// <summary>
        /// Authenticates using the client id and credentials, then fetches
        /// the uri.
        /// </summary>
        /// <param name="iapClientId">The client id observed on
        /// https://console.cloud.google.com/apis/credentials. </param>
        /// <param name="credentialsFilePath">Path to the credentials .json file
        /// downloaded from https://console.cloud.google.com/apis/credentials.
        /// </param>
        /// <param name="uri">HTTP uri to fetch.</param>
        /// <returns>The http response body as a string.</returns>
        public static async Task<string> InvokeRequestAsync(string iapClientId, string credentialsFilePath, string uri)
        {
            // Read credentials from the credentials .json file.
            ServiceAccountCredential saCredential;
            using (var fs = new FileStream(credentialsFilePath, FileMode.Open, FileAccess.Read))
            {
                saCredential = ServiceAccountCredential.FromServiceAccountData(fs);
            }

            // Request an OIDC token for the Cloud IAP-secured client ID.
            OidcToken oidcToken = await saCredential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience(iapClientId)).ConfigureAwait(false);
            // Always request the string token from the OIDC token, the OIDC token will refresh the string token if it expires.
            string token = await oidcToken.GetAccessTokenAsync().ConfigureAwait(false);

            // Include the OIDC token in an Authorization: Bearer header to
            // IAP-secured resource
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                string response = await httpClient.GetStringAsync(uri).ConfigureAwait(false);
                return response;
            }
        }
    }
}