using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Prex.Utils
{
    public static class DataAccess
    {
        public static SqlConnection GetConnection()
        {
            var con = new SqlConnection(Configuration.PrexConfig.CONN_LOCAL_ADO);
            con.Open();
            return con;
        }

        public static void Execute(string sql) => Execute(sql, new SqlConnection(Configuration.PrexConfig.CONN_LOCAL_ADO));
        public static void Execute(string sql, SqlConnection con)
        {
            try
            {

                var cmd = new SqlCommand(sql, con);

                if (con.State == System.Data.ConnectionState.Closed) con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception ex)
            {
                Prex.Utils.Logging.Log.GuardarLog(Prex.Utils.Logging.AccionesLOG.AL_ERROR_SISTEMA, $"Ocurrió un error execute DB - {ex.Message}", Configuration.PrexConfig.CODIGO_TRANSACCION);

                throw new Exception("Ocurrió un error en execute DB", ex);
            }
        }

        public static object GetScalar(string sql)
        {
            try
            {
                var con = new SqlConnection(Configuration.PrexConfig.CONN_LOCAL_ADO);
                var cmd = new SqlCommand(sql, con);

                con.Open();

                var r = cmd.ExecuteScalar();

                con.Close();

                return r;
            }
            catch (Exception ex)
            {
                Prex.Utils.Logging.Log.GuardarLog(Prex.Utils.Logging.AccionesLOG.AL_ERROR_SISTEMA, $"Ocurrió un error al obtener Scalar - {ex.Message}", Configuration.PrexConfig.CODIGO_TRANSACCION);

                throw new Exception("Ocurrió un error al obtener Scalar", ex);
            }
        }



        public static DataTable GetDataTable(string sql)
        {
            try
            {
                var dtb = new DataTable();
                var con = new SqlConnection(Configuration.PrexConfig.CONN_LOCAL_ADO);
                con.Open();

                var dad = new SqlDataAdapter(sql, con);
                dad.Fill(dtb);
                con.Close();
                return dtb;
            }
            catch (Exception ex)
            {
                Prex.Utils.Logging.Log.GuardarLog(Prex.Utils.Logging.AccionesLOG.AL_ERROR_SISTEMA, $"Ocurrió un error al  obtener DataTable - {ex.Message}", Configuration.PrexConfig.CODIGO_TRANSACCION);
                throw new Exception("Ocurrió un error al obtener DataTable", ex);
            }

        }

        public static SqlDataReader GetReader(string sql)
        {
            try
            {
                var con = new SqlConnection(Configuration.PrexConfig.CONN_LOCAL_ADO);
                var cmd = new SqlCommand(sql, con);

                con.Open();

                var r = cmd.ExecuteReader();

                //con.Close();

                return r;
            }
            catch (Exception ex)
            {
                Prex.Utils.Logging.Log.GuardarLog(Prex.Utils.Logging.AccionesLOG.AL_ERROR_SISTEMA, $"Ocurrió un error al obtener reader - {ex.Message}", Configuration.PrexConfig.CODIGO_TRANSACCION);

                throw new Exception("Ocurrió un error al obtener reader", ex);
            }
        }

        public static long ProximoID(string tabla, string campoClave) => ProximoID(tabla, campoClave, string.Empty);

        public static long ProximoID(string tabla, string campoClave, string filtro)
        {

            long proximo = 1;
            var sSQL = $"SELECT  MAX({campoClave}) FROM {tabla}";
            if (filtro.Any()) sSQL += $" where {filtro}";
            try
            {
                proximo = long.Parse(GetScalar(sSQL).ToString()) + 1;
                return proximo;
            }
            catch (Exception ex)
            {
                Prex.Utils.Logging.Log.GuardarLog(Prex.Utils.Logging.AccionesLOG.AL_ERROR_SISTEMA, $"Error: ProximoID - {ex.Message}", Configuration.PrexConfig.CODIGO_TRANSACCION);
                throw new Exception($"Error: ProximoID", ex);
            }
        }

        public static string FechaSQL(DateTime fecha)
        {
            if (fecha == DateTime.MinValue)
                return "'" + String.Format(Configuration.PrexConfig.FFECHA, FechaCorrecta(1, 1900)) + "'";
            return fecha.ToString( Configuration.PrexConfig.FFECHA);

        }

        public static DateTime FechaCorrecta(int mes, int anio) => mes == 12?DateTime.Parse((anio + 1).ToString() + "-01-01").AddDays(-1):DateTime.Parse(anio.ToString() + "-" + (mes + 1).ToString().PadLeft(2, '0') + "-01").AddDays(-1);

        public static string FlotanteSQL(double numero) => Math.Round(numero, 6).ToString().Replace(",", ".");

		public static int TipoDatosRS(string tipo)
		{
			switch (tipo.ToLower())
			{
				case "datetime": 
					return 135;
				case "time":
					return 134;
				case "date":
					return 133;
				case "smalldatetime":
					return 135;
				case "binary":
					return 123;
				case "char":
					return 129;
				case "nchar":
					return 130;
				case "varchar":
					return 200;
				case "text":
					return 201;
				case "nvarchar":
					return 202;
				case "ntext":
					return 203;
				case "bigint":
					return 20;
				case "bit":
					return 11;
				case "money":
				case "smallmoney":
					return 6;
				case "float":
					return 5;
				case "decimal":
				case "numeric":
					return 131;
				case "real":
					return 4;
				case "smallint":
					return 2;
				case "tinyint":
					return 17;
				case "int":
					return 3;
				default:
					return 200;
			}

		}

		public static TipoDatosDAO TipoDatosDao(string tipo)
		{
			int i = 0;
			return TipoDatosDao(tipo, ref i); 
		}
		public static TipoDatosDAO TipoDatosDao(string tipo, ref int tipoDato)
		{
			switch (tipo.ToLower())
			{
				case "datetime": case "time":
				case "smalldatetime":
				case "date":
					return TipoDatosDAO.FechaHora;
				case "binary":	case "varbinary": case "xml":
				case "varchar": case "char": case "text":
				case "nchar": case "nvarchar": case "ntext":
					tipoDato = 1;
					return TipoDatosDAO.Texto;
				default:
					tipoDato = 0;
					return TipoDatosDAO.Numerico;
			}
		}
    }
}
