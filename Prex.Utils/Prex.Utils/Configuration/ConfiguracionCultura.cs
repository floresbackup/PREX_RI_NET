using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Utils
{
    public static class ConfiguracionCultura
    {
        public static Dictionary<string, Cultura> CulturaTextos;
        public class CadenaIdioma
        {
            public Cadenas CodigoCadena;
            public string DescripcionCadena;
        }

        public enum Cadenas
        {
            CDN_mnuArchivo = 1
        }

        public class Cultura
        {

            public string IdCultura;
            public string Origen;
            public string Objeto;
            public string Texto;
            public string Key;
        }


        //Public Sub LeerCadenas(ByVal nCodigoIdioma As Integer)
        //
        //Dim sSQL As String
        //Dim ds As DataSet
        //Dim oAdmTablas As New AdmTablas
        //Dim nI As Integer
        //Dim oCadena As CadenaIdioma
        //
        //   sSQL = "SELECT  * " & _
        //          "FROM    [SVR-DOM-F001\SQLPREX].QUALITAS.DBO.IDIOMA " & _
        //          "WHERE   IO_CODIDI = " & nCodigoIdioma
        //
        //      oAdmTablas.ConnectionString = CONN_LOCAL
        //      ds = oAdmTablas.AbrirDataset(sSQL)
        //
        //      colCadenas.Clear()
        //
        //      For nI = 0 To ds.Tables(0).Rows.Count - 1
        //         oCadena = New CadenaIdioma
        //         oCadena.CodigoCadena = ds.Tables(0).Rows(nI)("IO_CODCAD")
        //         oCadena.DescripcionCadena = ds.Tables(0).Rows(nI)("IO_DESCRI")
        //         colCadenas.Add(oCadena, "K" & ds.Tables(0).Rows(nI)("IO_CODCAD") - 1)
        //      Next
        //
        //   End Sub

        public static void CulturaCargarTextos(string idCultura)
        {
            if (CulturaTextos == null)
                CulturaTextos = new Dictionary<string, Cultura>();
            else
                CulturaTextos.Clear();

            var sSQL = "SELECT  * " +
             "FROM    CULTUR " +
             "WHERE   CU_CULTUR = '" + idCultura + "'";

            var cmd = new SqlCommand(sSQL)
            {
                Connection = new SqlConnection(Configuration.PrexConfig.CONN_LOCAL)
            };

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    var cu = new Cultura
                    {
                        IdCultura = reader["CU_CULTUR"].ToString(),
                        Origen = reader["CU_ORIGEN"].ToString(),
                        Objeto = reader["CU_OBJETO"].ToString(),
                        Texto = reader["CU_TEXTO"].ToString(),
                        Key = reader["CU_ORIGEN"].ToString() + "." + reader["CU_OBJETO"].ToString()
                    };
                    CulturaTextos.Add(cu.Key, cu);
                }
                reader.Close();
            }

            //EstablecerLenguaje()

        }


        public static string CulturaTexto(string origen, string objeto)
        {
            var cultura = CulturaTextos[origen + "." + objeto];

            if (!cultura.Texto.Any() ||  cultura.Texto == null)
                return "N/A";
            else
                return cultura.Texto;
        }
        /*
   public string DescripcionCadena(string codigoCadena)
   {
            try
            {
                CadenaIdioma cadena = null;
                cadena = colCadenas("K" + nCodigoCadena);





                if (cadena.DescripcionCadena == null)
                    return "N/A";
                else
                    return cadena.DescripcionCadena;
      
            }
            catch (Exception)
            {
                throw;
            }

    }
    //Public Sub EstablecerLenguaje()
    //
    //   BarLocalizer.Active = New cBarsLocalizer()
    //   GridLocalizer.Active = New cGridLocalizer()
    //   PivotGridLocalizer.Active = New cPivotGridLocalizer()
    //   ChartLocalizer.Active = New cChartLocalizer()
    //   PreviewLocalizer.Active = New cPrintingLocalizer()
    //   BarLocalizer.Active = New cBarsLocalizer()
    //   Localizer.Active = New cEditorsLocalizer()
    //   ReportLocalizer.Active = New cReportsLocalizer()
    //
    //End Sub
    */
    }
}
