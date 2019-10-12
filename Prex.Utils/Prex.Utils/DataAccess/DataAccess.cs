﻿using System;
using System.Data.SqlClient;

namespace Prex.Utils
{
    public static class DataAccess
    {
        public static void Execute(string sql)
        {
            try
            {
                var con = new SqlConnection(Configuration.PrexConfig.CONN_LOCAL_ADO);
                var cmd = new SqlCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener reader", ex);
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
                throw new Exception("Ocurrió un error al obtener reader", ex);
            }
        }
    }
}