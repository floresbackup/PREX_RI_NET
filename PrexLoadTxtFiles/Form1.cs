using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrexLoadTxtFiles
{
    public class Columna
    {
        public string Nombre      { get; set; }
        public SqlDbType TipoDato { get; set; }
        public int LongitudCampo  { get; set; }
        public object Valor       { get; set; }
        public int Indice         { get; set; }

        public Columna(string nombre, int indice, int longitud, SqlDbType tipo)
        {
            Nombre = nombre;
            Indice = indice;
            LongitudCampo = longitud;
            TipoDato = tipo;
        }
    }

    public partial class frmMain : Form
    {
        private enum DisenioTxt
        {
            D4305 = 4305,
            D4306 = 4306,
            D4307 = 4307
        }

        #region Variables y propiedades
        private Dictionary<DisenioTxt, List<Columna>> _formatos = new Dictionary<DisenioTxt, List<Columna>>();
        private Prex.Satelite.Utils.Configuracion _configuracion;

        private string ConfigFileName => "configuracion.json";
        private string ConfigFilePath => Environment.CurrentDirectory + "\\" + ConfigFileName;
        private string TableName => Path.GetFileNameWithoutExtension(txtPathBCP.Text);
        private string GetFullConnectionString => $"Password={txtUserPass.Text.Trim()};User Id={txtSQLUser.Text.Trim()};Initial Catalog={txtDataBase.Text.Trim()};Data Source={txtSQLServer.Text.Trim()}".Replace(";;", ";");
        private Prex.Satelite.Utils.Configuracion ConfiguracionProceso
        {
            get
            {
                if (_configuracion == null) _configuracion = new Prex.Satelite.Utils.Configuracion();

                _configuracion.DB               = txtDataBase.Text.Trim();
                _configuracion.Usuario          = txtSQLUser.Text.Trim();
                _configuracion.Servidor         = txtSQLServer.Text.Trim();
                _configuracion.Pass             = txtUserPass.Text.Trim();
                _configuracion.DecimalSeparator = txtDecimalSeparator.Text.Trim();
                _configuracion.PathBCP          = txtPathBCP.Text.Trim();

                return _configuracion;
            }  
        }

        #endregion

        #region Eventos

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (CargarConfiguracion()) btnProcesar.Select();
        }

        private void btnDialogBCP_Click(object sender, EventArgs e)
        {
            var OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(ConfiguracionProceso.PathBCP);
            OpenFileDialog1.FileName = "*.txt";

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                txtPathBCP.Text = OpenFileDialog1.FileName;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Prex.Satelite.Utils.ConfigFile.GuardarConfiguracion(ConfigFilePath, ConfiguracionProceso);

            CargarFormatos(DisenioTxt.D4305);
            var conn = new SqlConnection(GetFullConnectionString);
            SqlTransaction tran = null;
            try
            {
                conn.Open();
                DropYCrearTabla(DisenioTxt.D4305,conn, tran);

                //tran = conn.BeginTransaction();
                var archivo = File.ReadLines(txtPathBCP.Text);
                var count = archivo.Count();
                var lineas = archivo.Select(l => l.Split(txtDecimalSeparator.Text.Trim().ToCharArray()).ToList());

                var lineas4305 = lineas.Where(l => l[0] == ((int)DisenioTxt.D4305).ToString()).ToList();
                lineas4305.AsParallel().WithDegreeOfParallelism(1).ForAll(reg => {
                    InsertarRegistroDisenio((DisenioTxt)Enum.Parse(typeof(DisenioTxt), reg[0]), reg, conn, tran);
                });


                if (tran != null) tran.Commit();
                conn.Close();
                MessageBox.Show("Proceso finalizado!", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                if (tran != null) tran.Rollback();

                if (conn.State == ConnectionState.Open) conn.Close();

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos
        private void InsertarRegistroDisenio(DisenioTxt disenio, List<string> registro, SqlConnection conn, SqlTransaction tran)
        {
            var cmdInsert = new SqlCommand("");
            cmdInsert.Connection = conn;
            cmdInsert.Transaction = tran;

            switch (disenio)
            {
                case DisenioTxt.D4305:
                    #region Insert 4305
                    cmdInsert.CommandText = "INSERT INTO DEUDORES_4305 (";
                    _formatos[disenio].ForEach(d => cmdInsert.CommandText += $"{d.Nombre}{(d.Indice < _formatos[disenio].Count() ? "," : string.Empty)} ");
                    cmdInsert.CommandText += ") Values ( ";
                    _formatos[disenio].ForEach(d => cmdInsert.CommandText += $"@{d.Nombre}{(d.Indice < _formatos[disenio].Count() ? "," : string.Empty)} ");
                    cmdInsert.CommandText += ")";
                    _formatos[disenio].ForEach(d => cmdInsert.Parameters.Add(d.Nombre, d.TipoDato));

                    #endregion
                    break;
                case DisenioTxt.D4306:
                    break;
                case DisenioTxt.D4307:
                    break;
                default:
                    break;
            }

          
            _formatos[disenio].ForEach(d =>
            {
                try
                {

                    switch (d.TipoDato)
                    {
                        case SqlDbType.BigInt:
                            cmdInsert.Parameters[d.Nombre].Value = (registro[d.Indice].ToString().Any() ? long.Parse(registro[d.Indice]) : (object)DBNull.Value);
                            break;
                        case SqlDbType.Int:
                            cmdInsert.Parameters[d.Nombre].Value = (registro[d.Indice].ToString().Any() ? int.Parse(registro[d.Indice]) : (object)DBNull.Value);
                            break;
                        case SqlDbType.VarChar:
                            cmdInsert.Parameters[d.Nombre].Value = (registro[d.Indice].ToString().Any() ? registro[d.Indice].ToString() : (object)DBNull.Value);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            });
       

            cmdInsert.ExecuteNonQuery();
        }

        private bool CargarConfiguracion()
        {

            _configuracion = Prex.Satelite.Utils.ConfigFile.GetConfiguracion(ConfigFilePath);
            if (_configuracion == null) return false;

            txtDataBase.Text  = _configuracion.DB;
            txtSQLServer.Text = _configuracion.Servidor;
            txtSQLUser.Text   = _configuracion.Usuario;
            txtUserPass.Text  = _configuracion.Pass;
            txtPathBCP.Text   = _configuracion.PathBCP;
            txtDecimalSeparator.Text = _configuracion.DecimalSeparator;


            return true;
        }


        private void DropYCrearTabla(DisenioTxt disenio, SqlConnection conn, SqlTransaction tran)
        {
            var cmdCreateTable = new SqlCommand($"IF OBJECT_ID('dbo.{TableName}_{((int)disenio)}', 'U') IS NOT NULL DROP TABLE {TableName}_{((int)disenio)}", conn);
            cmdCreateTable.Transaction = tran;

            cmdCreateTable.ExecuteNonQuery();

            cmdCreateTable.CommandText = $"CREATE TABLE {TableName}_{((int)disenio)} (";

            _formatos[disenio].OrderBy(d => d.Indice).ToList().ForEach(d => {
                switch (d.TipoDato)
                {
                    case SqlDbType.BigInt:
                        cmdCreateTable.CommandText += $"{d.Nombre} BIGINT NULL ";
                        break;
                    case SqlDbType.Int:
                        cmdCreateTable.CommandText += $"{d.Nombre} INT NULL ";
                        break;
                    case SqlDbType.VarChar:
                        cmdCreateTable.CommandText += $"{d.Nombre} VARCHAR({d.LongitudCampo}) NULL ";
                        break;
                    default:
                        break;
                }
                if (d.Indice < _formatos[disenio].Count())
                    cmdCreateTable.CommandText += ", ";
            });

            cmdCreateTable.CommandText += ")";


            cmdCreateTable.ExecuteNonQuery();
        }


        private void CargarFormatos(DisenioTxt disenio)
        {
            if (!_formatos.ContainsKey(disenio)) _formatos.Add(disenio, new List<Columna>());

            _formatos[disenio].Clear();

            switch (disenio)
            {
                case DisenioTxt.D4305:
                    #region diseño 4305
                    _formatos[disenio].Add(new Columna("TipoIdentificacion", 1, 2               , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("NroIdentificacion", 2, 11               , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("Denominacion", 3, 55                    , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("Categoria", 4, 1                        , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("ResidenciaSector", 5, 1                 , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("Gobierno", 6, 1                         , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("Provincia", 7, 2                        , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("Situacion", 8, 2                        , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("Vinculacion", 9, 1                      , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("PrevisionesAsistenciaCrediticia", 10, 12, SqlDbType.BigInt ));
                    _formatos[disenio].Add(new Columna("PrevisionesParticipaciones", 11, 12     , SqlDbType.BigInt ));
                    _formatos[disenio].Add(new Columna("PrevRespEventGtiaOtorgadas", 12, 12     , SqlDbType.BigInt ));
                    _formatos[disenio].Add(new Columna("IncPrevMinPermCat4o5Gral", 13, 12       , SqlDbType.BigInt ));
                    _formatos[disenio].Add(new Columna("IncPrevMinPermCat4o5Normas", 14, 12     , SqlDbType.BigInt ));
                    _formatos[disenio].Add(new Columna("MaxAsistCliVincODeuda05", 15, 14        , SqlDbType.BigInt ));
                    _formatos[disenio].Add(new Columna("TotalFinancionesDeudor", 16, 14         , SqlDbType.BigInt ));
                    _formatos[disenio].Add(new Columna("ActividadPrincipal", 17, 3              , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("InformacionTransitoria", 18, 1          , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("DeudorLey25326Art26", 19, 1             , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("Refinanciaciones", 20, 1                , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("RecatObligatoria", 21, 1                , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("SituacionJuridica", 22, 1               , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("IrrecuperablesDispTecnica", 23, 1       , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("DiasAtrasoEnPago", 24, 4                , SqlDbType.Int    ));
                    _formatos[disenio].Add(new Columna("MiPyME", 25, 2                          , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("SituacionSinReclasificar", 26, 2        , SqlDbType.VarChar));
                    #endregion
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}
