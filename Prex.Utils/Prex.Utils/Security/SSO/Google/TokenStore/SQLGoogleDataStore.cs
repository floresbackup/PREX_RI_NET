using Google.Apis.Util.Store;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Prex.Utils.Security.SSO.Google
{
	/// <summary>
	/// Store Gmail token in the database
	/// The information is stored in table OauthToken
	/// OAuth token has only three fields 
	/// ID UserKey and Token
	/// </summary>
	public class SQLGoogleDataStore : IDataStore
    {
        private readonly string conextionDb;

        /// <summary>
        /// Constructor. Get the conexion string
        /// for your database.
        /// </summary>
        /// <param name="conexionString"></param>
        public SQLGoogleDataStore(string conexionString)
        {
            conextionDb = conexionString;
        }

        #region Implementation of IDataStore

        /// <summary>
        /// Asynchronously stores the given value for the given key (replacing any existing value).
        /// </summary>
        /// <typeparam name="T">The type to store in the data store.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="value">The value to store.</param>
        public Task StoreAsync<T>(string key, T value)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key MUST have a value");
            return Task.Run(() =>
            {
                string contents = Newtonsoft.Json.JsonConvert.SerializeObject((object)value);
                var conn = new SqlConnection(conextionDb);
                var comm = new SqlCommand("SELECT COUNT(*) FROM OAuthToken WHERE UserKey = @Param1", conn);
                comm.Parameters.AddWithValue("@Param1", key);
                conn.Open();
                try
                {
                    var res = comm.ExecuteScalar();
                    if ((int)res == 0)
                    {
                        // Insert token
                        comm = new SqlCommand("INSERT INTO OAuthToken (UserKey, Token) VALUES(@Param1, @Param2)", conn);
                        comm.Parameters.AddWithValue("@Param1", key);
                        comm.Parameters.AddWithValue("@Param2", contents);
                    }
                    else
                    {
                        //Update token
                        comm = new SqlCommand("UPDATE OAuthToken SET Token = @Param2 WHERE UserKey = @Param1", conn);
                        comm.Parameters.AddWithValue("@Param1", key);
                        comm.Parameters.AddWithValue("@Param2", contents);
                    }

                    var exec = comm.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            });
            
        }

        /// <summary>
        /// Asynchronously deletes the given key. The type is provided here as well 
        /// because the "real" saved key should
        /// contain type information as well, so the data store will be able to store 
        /// the same key for different types.
        /// </summary>
        /// <typeparam name="T">
        /// The type to delete from the data store.
        /// </typeparam>
        /// <param name="key">The key to delete.</param>
        public Task DeleteAsync<T>(string key)
        {
            return Task.Run(() =>
            {
                var conn = new SqlConnection(conextionDb);
                var comm = new SqlCommand("DELETE OAuthToken WHERE UserKey = @Param1", conn);
                comm.Parameters.AddWithValue("@Param1", key);
                conn.Open();
                try
                {
                    var res = comm.ExecuteScalar();
                }
                finally
                {
                    conn.Close();
                }
            });

        }

        /// <summary>
        /// Asynchronously returns the stored value for the given key or <c>null</c> if not found.
        /// </summary>
        /// <typeparam name="T">The type to retrieve from the data store.</typeparam>
        /// <param name="key">The key to retrieve its value.</param>
        /// <returns>
        /// The stored object.
        /// </returns>
        public Task<T> GetAsync<T>(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Key MUST have a value");
            }

            TaskCompletionSource<T> completionSource = new TaskCompletionSource<T>();
            var conn = new SqlConnection(conextionDb);
            var comm = new SqlCommand("SELECT Token FROM OAuthToken WHERE UserKey = @Param1", conn);
            comm.Parameters.AddWithValue("@Param1", key);
            conn.Open();
            try
            {
                var res = comm.ExecuteScalar();
                if (res == null || string.IsNullOrWhiteSpace(res.ToString()))
                {
                    completionSource.SetResult(default(T));
                }
                else
                {
                    completionSource.SetResult(Newtonsoft.Json.JsonConvert.DeserializeObject<T>(res.ToString()));
                }
            }
            catch (Exception ex)
            {
                completionSource.SetException(ex);
            }
            finally
            {
                conn.Close();
            }
            return completionSource.Task;
        }

        /// <summary>
        /// Asynchronously clears all values in the data store.
        /// </summary>
        public Task ClearAsync()
        {
            return Task.Run(() =>
            {

                var conn = new SqlConnection(conextionDb);
                var comm = new SqlCommand("TRUNCATE TABLE OAuthToken", conn);
                conn.Open();
                try
                {
                    var res = comm.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            });
        }

        #endregion
    }
}
