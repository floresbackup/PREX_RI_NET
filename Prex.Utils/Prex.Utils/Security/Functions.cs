
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Prex.Utils.Security
{

	public enum TiposValidacion
	{
		CantidadNum,
		CantidadAlfa,
		CantidadEsp
	}


	public class UsuarioPassword
	{
		private bool _isAdmin = false;

		public Dictionary<string, string> DicUsuPass = new Dictionary<string, string>();

		public long CodUsuario   { get; private set; }
		public string PassActual { get; private set; }
		public DateTime FechaVto { get; private set; }

		public DateTime FechaVtoCalculada => _isAdmin ? (CodUsuario > 1 ? DateTime.Now : DateTime.Parse("1999-12-31")) : DateTime.Now.AddDays(30/*DIAS_VTO_PASSWORD*/);

		public UsuarioPassword(IDataRecord reader, bool isAdmin)
		{
			_isAdmin = isAdmin;
			if ((int)reader["US_BLOQUE"] != 0 || ((DateTime)reader["US_FECBAJ"]) > DateTime.Parse("1900-01-01"))
				throw new Exception("No se puede cambiar la contraseña - Usuario bloqueado o dado de baja");
			else
				PassActual = reader["US_PASSWO"].ToString();

			CodUsuario = (int)reader["US_CODUSU"];
			FechaVto   = DateTime.Parse(reader["US_FECVTO"].ToStringOrEmpty()).Date;

			DicUsuPass.Add("US_PASS04", reader["US_PASS04"].ToStringOrEmpty());
			DicUsuPass.Add("US_PASS03", reader["US_PASS03"].ToStringOrEmpty());
			DicUsuPass.Add("US_PASS02", reader["US_PASS02"].ToStringOrEmpty());
			DicUsuPass.Add("US_PASS01", reader["US_PASS01"].ToStringOrEmpty());
		}
	}

	public static class Functions
	{
		public static string CalculateMD5(string cadena)
		{
			var retorno = string.Empty;
			var oMD5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
			var oHash = System.Text.Encoding.ASCII.GetBytes(cadena);

			oHash = oMD5.ComputeHash(oHash);

			foreach (var b in oHash)
			{
				retorno += b.ToString("x2");
			}

			return retorno;

		}
		public static bool CambiarPassword(string nombreUsuario, string nuevaPassword) => CambiarPassword(nombreUsuario, nuevaPassword, false);

		public static bool CambiarPassword(string nombreUsuario, string nuevaPassword, bool isAdmin)
		{
			var usuario = GetUsuarioPassWord(nombreUsuario, true);

			ActualizarPassUsuario(usuario, nuevaPassword, !isAdmin);

			return true;
		}

		public static void ActualizarPassUsuario(UsuarioPassword usuario, string nuevaPass, bool ejecutaValidaciones)
		{
			var nuevaPassMD5 = CalculateMD5(nuevaPass);
			if (ejecutaValidaciones)
			{
				var directiva = GetDirectivasVigentes();
				if (directiva == null) directiva = new DirectivasSeguridad();

				if (DateTime.Now.AddDays(directiva.DIAS_ANTES_RENOVACION).Date < usuario.FechaVto.Date)
					throw new Exception("No se puede renovar la contraseña en este momento");

				if (nuevaPassMD5 == usuario.PassActual)
					throw new Exception("Contraseña no válida para renovación");

				if (directiva.CANT_PASS_CONTROLADAS > 0)
				{
					for (int i = 1; i <= 3; i++)
					{
						if (nuevaPassMD5 == usuario.DicUsuPass[$"US_PASS0{i}"])
							throw new Exception("Su nueva contraseña debe diferir de sus claves anteriores");
					}
				}

				if (directiva.CANTIDAD_ALFA > 0)
				{
					if (CantidadCaracteres(TiposValidacion.CantidadAlfa, nuevaPass) < directiva.CANTIDAD_ALFA)
						throw new Exception("La cantidad de caracteres alfabéticos ingresada no es suficiente para satisfacer la directiva de seguridad actual");
				}


				if (directiva.CANTIDAD_NUM > 0)
				{
					if (CantidadCaracteres(TiposValidacion.CantidadNum, nuevaPass) < directiva.CANTIDAD_NUM)
						throw new Exception("La cantidad de caracteres numéricos ingresada no es suficiente para satisfacer la directiva de seguridad actual");
				}


				if (directiva.CANTIDAD_ESP > 0)
				{
					if (CantidadCaracteres(TiposValidacion.CantidadEsp, nuevaPass) < directiva.CANTIDAD_ESP)
						throw new Exception("La cantidad de caracteres especiales ingresada no es suficiente para satisfacer la directiva de seguridad actual");
				}
			}

			var cmdUpdate = new SqlCommand("update USUARI set " +
								"US_FECVTO = @US_FECVTO, " +
								"US_PASS05 = @US_PASS05, " +
								"US_PASS04 = @US_PASS04, " +
								"US_PASS03 = @US_PASS03, " +
								"US_PASS02 = @US_PASS02, " +
								"US_PASS01 = @US_PASS01, " +
								"US_PASSWO = @US_PASSWO, " +
								"US_ENCRYP = '', " +
								"US_GRACIA = 3 " + //INTENTOS_PARA_BLOQUEAR
								" WHERE US_CODUSU = @US_CODUSU");

			cmdUpdate.Parameters.Add("US_FECVTO", SqlDbType.DateTime).Value = usuario.FechaVtoCalculada;
			cmdUpdate.Parameters.Add("US_PASS05", SqlDbType.VarChar).Value = usuario.DicUsuPass["US_PASS04"];
			cmdUpdate.Parameters.Add("US_PASS04", SqlDbType.VarChar).Value = usuario.DicUsuPass["US_PASS03"];
			cmdUpdate.Parameters.Add("US_PASS03", SqlDbType.VarChar).Value = usuario.DicUsuPass["US_PASS02"];
			cmdUpdate.Parameters.Add("US_PASS02", SqlDbType.VarChar).Value = usuario.DicUsuPass["US_PASS01"];
			cmdUpdate.Parameters.Add("US_PASS01", SqlDbType.VarChar).Value = usuario.PassActual;
			cmdUpdate.Parameters.Add("US_PASSWO", SqlDbType.VarChar).Value = nuevaPassMD5;
			cmdUpdate.Parameters.Add("US_CODUSU", SqlDbType.BigInt).Value = usuario.CodUsuario;

			Prex.Utils.DataAccess.Execute(cmdUpdate);
		}

		public static DirectivasSeguridad GetDirectivasVigentes()
		{
			DirectivasSeguridad directivas = null;
			using (var reader = DataAccess.GetReader("SELECT * FROM DIRSEG WHERE DS_VIGENT = 1"))
			{
				if (!reader.HasRows) throw new Exception("No se encontró directiva de seguridad vigente");
				while (reader.Read())
				{
					if (directivas != null) throw new Exception("Existe más de una directiva de seguridad vigente");
					directivas = new DirectivasSeguridad(reader);
				}
				reader.Close();
			}
			return directivas;
		}

		public static UsuarioPassword GetUsuarioPassWord(string nombre, bool isAdmin)
		{
			var sSQL = $"SELECT * FROM USUARI WHERE US_NOMBRE = '{nombre}'";

			UsuarioPassword usuario = null;
			using (var reader = Prex.Utils.DataAccess.GetReader(sSQL))
			{
				if (!reader.HasRows) throw new Exception("El usuario proporcionado no existe");
				while (reader.Read())
				{
					if (usuario != null)
						throw new Exception("Existe más de un usuario con el criterio de búsqueda");
					usuario = new UsuarioPassword(reader, isAdmin);
				}
				reader.Close();
			}
			return usuario;
		}

		public static Usuario GetUsuario(string nombre)
		{
			var sSQL = $"SELECT * FROM USUARI WHERE US_NOMBRE = '{nombre}'";

			Usuario usuario = null;
			using (var reader = Prex.Utils.DataAccess.GetReader(sSQL))
			{
				if (!reader.HasRows) throw new Exception("El usuario proporcionado no existe");
				while (reader.Read())
				{
					if (usuario != null)
						throw new Exception("Existe más de un usuario con el criterio de búsqueda");
					usuario = new Usuario(reader);
				}
				reader.Close();
			}
			return usuario;
		}


		private static int CantidadCaracteres(TiposValidacion tipoVal, string pass)
		{
			string sCadenaComp = string.Empty;
			int nTemp=0;

			switch (tipoVal)
			{
				case TiposValidacion.CantidadNum:
					sCadenaComp = "1234567890";
					break;
				case TiposValidacion.CantidadAlfa:
					sCadenaComp = @"abcdefghijklmnñopqrstuvwxyzáéíóúäëïöüABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚÄËÏÖÜ";
					break;
				case TiposValidacion.CantidadEsp:
					sCadenaComp = @"|°!#$%&/()=?¡¿'´+¨*}]{[-_.:,;^~\<>";
					break;
				default:
					break;
			}

			for (int i = 0; i < pass.Length - 1; i++)
			{
				if (sCadenaComp.IndexOf(pass.Substring(i, 1)) > 0)
					nTemp += 1;
			}

			return nTemp;
		}



	} 
}
