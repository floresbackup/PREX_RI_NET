using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Utils.Logging
{
    public enum AccionesLOG
    {
        AL_INGRESO_SISTEMA = 1,
        AL_SALIDA_SISTEMA = 2,
        AL_INGRESO_TRANSACCION = 3,
        AL_ERROR_SISTEMA = 4,
        AL_VIOLACION_SEGURIDAD = 5
    }

    public static class Log
    {
        public static void GuardarLog(AccionesLOG accion, string extra) => GuardarLog(accion, extra, -1, -1);
        public static void GuardarLog(AccionesLOG accion, string extra, long codTransaccion, long codUsuario)
        {
            SqlConnection conn = new SqlConnection(Configuration.PrexConfig.CONN_LOCAL_ADO);
            try
            {
               
                SqlCommand cmd = new SqlCommand("INSERT INTO LOGSIS "
                                                +"	( "
                                                +"		LS_CODUSU, "
                                                +"		LS_FECLOG, "
                                                +"		LS_HORLOG, "
                                                +"		LS_ACCION, "
                                                +"		LS_CODTRA, "
                                                +"		LS_EXTRA "
                                                +"	) "
                                                +"VALUES "
                                                +"	( "
                                                +"		@CODUSU, "
                                                +"		@FECLOG, "
                                                +"		@HORLOG, "
                                                +"		@ACCION, "
                                                +"		@CODTRA, "
                                                +"		@EXTRA "
                                                +"  ) ", conn);
                try
                {
                    if (codUsuario == -1) codUsuario = Configuration.PrexConfig.UsuarioActual.Codigo;
                    if (codTransaccion == 0) codTransaccion = -1;


                    cmd.Parameters.AddWithValue("@CODUSU", codUsuario);
                    cmd.Parameters.AddWithValue("@FECLOG", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@HORLOG", DateTime.Now.TimeOfDay);
                    cmd.Parameters.AddWithValue("@ACCION", accion);
                    cmd.Parameters.AddWithValue("@CODTRA", codTransaccion);
                    cmd.Parameters.AddWithValue("@EXTRA ", extra);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                }
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    try
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                    catch 
                    {
                        
                    }
                }
            }
        }

                
    }
}
