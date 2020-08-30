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

        /// <summary>
        /// Constructor. Get the conexion string
        /// for your database.
        /// </summary>
        public SQLGoogleDataStore()
        {
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
                var conn = DataAccess.GetConnection();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM USUTOK WHERE UT_NOMBRE = @Nombre", conn);
                cmd.Parameters.AddWithValue("Nombre", key);
                try
                {
                    var res = cmd.ExecuteScalar();
                    if ((int)res == 0)
                    {
                        // Insert token
                        cmd = new SqlCommand("INSERT INTO USUTOK (UT_CODUSU, UT_NOMBRE, UT_TOKEN) VALUES (@Usuario, @Nombre, @Token)", conn);
                        cmd.Parameters.AddWithValue("Usuario", Configuration.PrexConfig.UsuarioActual.Codigo);
                    }
                    else //Update token
                        cmd = new SqlCommand("UPDATE USUTOK SET UT_TOKEN = @Token, UT_FECHAACT = GetDate() WHERE UT_NOMBRE = @Nombre", conn);

                    cmd.Parameters.AddWithValue("Nombre", key);
                    cmd.Parameters.AddWithValue("Token", contents);
                    var exec = cmd.ExecuteNonQuery();
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
                var conn = Prex.Utils.DataAccess.GetConnection();
                var comm = new SqlCommand("DELETE USUTOK WHERE UT_NOMBRE = @Nombre", conn);
                comm.Parameters.AddWithValue("Nombre", key);
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
            var conn = Prex.Utils.DataAccess.GetConnection();
            var comm = new SqlCommand("SELECT UT_TOKEN FROM USUTOK WHERE UT_NOMBRE = @Nombre", conn);
            comm.Parameters.AddWithValue("Nombre", key);
            try
            {
                var res = comm.ExecuteScalar();
                if (res == null || string.IsNullOrWhiteSpace(res.ToString()))
                    completionSource.SetResult(default(T));
                else
                    completionSource.SetResult(Newtonsoft.Json.JsonConvert.DeserializeObject<T>(res.ToString()));
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

                var conn = Prex.Utils.DataAccess.GetConnection();
                var comm = new SqlCommand("TRUNCATE TABLE USUTOK", conn);
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
