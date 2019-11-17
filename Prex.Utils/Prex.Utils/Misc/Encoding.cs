using System;

namespace Prex.Utils.Misc
{
    public static class Encoding
    {
        public static string Base64Encode(string plainText) => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(plainText));
        public static string Base64DeCode(string base64) => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(base64));
        
    }
}
