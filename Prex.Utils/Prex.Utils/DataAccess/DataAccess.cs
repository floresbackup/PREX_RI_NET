using System;
using System.Data.SqlClient;

namespace Prex.Utils
{
    public static class DataAccess
    {
        public static SqlDataReader GetReader(string sql)
        {
            try
            {
                var con = new SqlConnection();
                var cmd = new SqlCommand(sql, con);

                con.Open();

                var r = cmd.ExecuteReader();
                
                con.Close();

                return r;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener reader", ex);
            }
        }
    }
}
