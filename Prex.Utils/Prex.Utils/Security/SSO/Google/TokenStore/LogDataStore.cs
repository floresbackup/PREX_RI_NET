using Google.Apis.Util.Store;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Prex.Utils.Security.SSO.Google
{
	public class LogDataStore : IDataStore
	{

		public LogDataStore()
		{ }

		public Task ClearAsync()
		{
			throw new System.NotImplementedException();
		}

		public Task DeleteAsync<T>(string key)
		{
			return Task.Run(() =>
			{
				Thread.Sleep(500);
			});
		}

		public Task<T> GetAsync<T>(string key)
		{
			return Task.Run(() =>
			{
				Thread.Sleep(500);
				return default(T);
			});
		}

		public Task StoreAsync<T>(string key, T value)
		{
			if (string.IsNullOrEmpty(key))
				throw new ArgumentException("Key MUST have a value");

			return Task.Run(() => {
				try
				{
					string contents = Newtonsoft.Json.JsonConvert.SerializeObject((object)value);
					//Logging.Log.GuardarLog(Logging.AccionesLOG.AL_INGRESO_SISTEMA, $"Autenticacion Google {Environment.NewLine} Usuario: {Configuration.PrexConfig.UsuarioActual.Codigo} / Token:{contents}");
				}
				catch (Exception ex)
				{
					//Logging.Log.GuardarLog(Logging.AccionesLOG.AL_ERROR_SISTEMA, $"Error al guardar json Token{Environment.NewLine}Detalle: {ex.Message}");
				}
			});
		}
	}
}
