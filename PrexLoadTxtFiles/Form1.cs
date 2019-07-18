using Prex.Satelite.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrexLoadTxtFiles
{
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
        private string TableName => $"{(txtPrefijoTabla.Text.Trim().Any() ? txtPrefijoTabla.Text.Trim() + "_" : string.Empty)}{Path.GetFileNameWithoutExtension(txtPathBCP.Text)}";
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
                _configuracion.PrefijoTabla = txtPrefijoTabla.Text.Trim();

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
        delegate void ChangeProgressDelegado(ProgressBar ctrl, int valor);
        public static void IncrementarProgress(ProgressBar ctrl, int valor)
        {
            if (ctrl.InvokeRequired)
            {
                ChangeProgressDelegado del = new ChangeProgressDelegado(IncrementarProgress);
                ctrl.Invoke(del, ctrl, valor);
            }
            else
            {
                ctrl.Increment(valor);
            }
        }

        delegate void ChangeMyTextDelegate(Control ctrl, string text);
        public static void SetLabelProgreso(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                ChangeMyTextDelegate del = new ChangeMyTextDelegate(SetLabelProgreso);
                ctrl.Invoke(del, ctrl, text);
            }
            else
            {
                ctrl.Text = text;
                Thread.Sleep(200);
            }
        }

        private async void btnProcesar_Click(object sender, EventArgs e)
        {
            List<List<string>> lineas = new List<List<string>>();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lblProgreso.Visible = true;
                progressBar.Visible = true;
                btnProcesar.Enabled = false;

                SetLabelProgreso(lblProgreso,"Guardando configuración...");

                Prex.Satelite.Utils.ConfigFile.GuardarConfiguracion(ConfigFilePath, ConfiguracionProceso);

                SetLabelProgreso(lblProgreso, "Cargando diseños...");
                CargarFormatos(DisenioTxt.D4305);
                CargarFormatos(DisenioTxt.D4306);
                CargarFormatos(DisenioTxt.D4307);

                var conn = new SqlConnection(GetFullConnectionString);
                SqlTransaction tran = null;
                try
                {

                    //tran = conn.BeginTransaction();

                    await Task.Run(() =>
                    {
                        SetLabelProgreso(lblProgreso, "Leyendo archivo txt...");
                        var archivo = File.ReadLines(txtPathBCP.Text);
                        lineas.AddRange(archivo.Select(l => l.Split(txtDecimalSeparator.Text.Trim().ToCharArray()).ToList()));
                    });

                    conn.Open();
                    await Task.Run(() =>
                    {
                        SetLabelProgreso(lblProgreso, $"Creando tablas {TableName} ...");
                        if (chkDiseno4305.Checked)
                            DropYCrearTabla(DisenioTxt.D4305, conn, tran);
                        if (chkDiseno4306.Checked)
                            DropYCrearTabla(DisenioTxt.D4306, conn, tran);
                        if (chkDiseno4307.Checked)
                            DropYCrearTabla(DisenioTxt.D4307, conn, tran);
                    });

                    if (chkDiseno4305.Checked)
                        await ProcesarFormato(DisenioTxt.D4305, lineas, conn, tran);

                    if (chkDiseno4306.Checked)
                        await ProcesarFormato(DisenioTxt.D4306, lineas, conn, tran);

                    if (chkDiseno4307.Checked)
                        await ProcesarFormato(DisenioTxt.D4307, lineas, conn, tran);


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
            finally
            {
                this.Cursor = Cursors.Default;
                lblProgreso.Visible = false;
                progressBar.Visible = false;
                progressBar.Value = 0;
                btnProcesar.Enabled = true;
                lineas.Clear();
                lineas = null;
            }
        }

        private async Task ProcesarFormato(DisenioTxt formato, List<List<string>> lineas, SqlConnection conn, SqlTransaction tran)
        {
            List<List<string>> lineasDisenio = new List<List<string>>();
            IEnumerable<IEnumerable<List<string>>> lineasBulk = null;

            try
            {

                await Task.Run(() =>
                {
                    SetLabelProgreso(lblProgreso, "Obteniendo registros del diseño " + ((int)formato).ToString() +"...");
                    lineasDisenio.AddRange(lineas.Where(l => l[0] == ((int)formato).ToString()));
                });

                lineasBulk = lineasDisenio.Partir(10000);
                progressBar.Maximum = lineasBulk.Count();
                progressBar.Value = 0;
                await Task.Run(() =>
                {
                    SetLabelProgreso(lblProgreso, "Procesando diseño "+((int)formato).ToString()+"...");

                    lineasBulk.ToList().ForEach(lin => {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, tran))
                        {
                            bulkCopy.DestinationTableName = "dbo." + TableName + "_" + ((int)formato).ToString();

                            try
                            {
                                bulkCopy.WriteToServer(MakeTable(lin.ToList(), formato));
                                IncrementarProgress(progressBar, 1);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    });
                });

            }
            finally
            {
                lineas.RemoveAll(r => r[0] == ((int)formato).ToString());
                lineasDisenio.Clear();
                lineasDisenio = null;
                lineasBulk = null;
            }
        }

        private DataTable MakeTable(List<List<string>> lines, DisenioTxt formato)
        {
            // Create a new DataTable named NewProducts.

            DataTable tablaSQL = new DataTable(TableName + "_4305");
            _formatos[formato].ForEach(f =>
            {
                try
                {
                    DataColumn col = new DataColumn();
                    switch (f.TipoDato)
                    {
                        case SqlDbType.BigInt:
                                col.DataType = System.Type.GetType("System.Int64");
                                break;
                        case SqlDbType.Int:
                                col.DataType = System.Type.GetType("System.Int32");
                                break;
                        case SqlDbType.VarChar:
                                col.DataType = System.Type.GetType("System.String");
                                break;
                        case SqlDbType.Decimal:
                            col.DataType = System.Type.GetType("System.Decimal");
                            break;
                        case SqlDbType.DateTime:
                            col.DataType = System.Type.GetType("System.DateTime");
                            break;
                        default:
                                col.DataType = System.Type.GetType("System.String");
                                break;
                    }
                    col.ColumnName = f.Nombre;
                    tablaSQL.Columns.Add(col);
                    return;
                }
                catch (Exception ex)
                {
                    return;
                }
            });

            lines.ForEach(l =>
            {
                var terminos = l;
                if (terminos.Count() > 0)
                {
                    DataRow row;
                    row = tablaSQL.NewRow();
                    _formatos[formato].ForEach(f =>
                    {
                        try
                        {
                            if ((terminos[f.Indice].Trim().Count() == 0))
                                row[f.Nombre] = DBNull.Value;
                            else
                                switch (f.TipoDato)
                                {
                                    case SqlDbType.VarChar:
                                        row[f.Nombre] = terminos[f.Indice].Trim();
                                        break;
                                    case SqlDbType.Decimal:
                                        row[f.Nombre] = Decimal.Parse(terminos[f.Indice].Trim());
                                        break;
                                    case SqlDbType.Int:
                                        row[f.Nombre] = Int32.Parse(terminos[f.Indice].Trim());
                                        break;
                                    case SqlDbType.BigInt:
                                        row[f.Nombre] = Int64.Parse(terminos[f.Indice].Trim());
                                        break;
                                    case SqlDbType.DateTime:
                                        var d = DateTime.ParseExact(terminos[f.Indice].Trim(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                                        row[f.Nombre] = DateTime.Parse(d.Trim());
                                        break;
                                    default:
                                        row[f.Nombre] = terminos[f.Indice].Trim();
                                        break;
                                }
                        }
                        catch (Exception ex)
                        {
                            // Throw ex
                            return;
                        }
                    });
                    tablaSQL.Rows.Add(row);
                }
            });
            return tablaSQL;
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
                    cmdInsert.CommandText = "INSERT INTO " + TableName + "_4305 (";
                    break;
                case DisenioTxt.D4306:
                    cmdInsert.CommandText = "INSERT INTO " + TableName + "_4306 (";
                    break;
                case DisenioTxt.D4307:
                    cmdInsert.CommandText = "INSERT INTO " + TableName + "_4307 (";
                    break;
                default:
                    break;
            }

            _formatos[disenio].ForEach(d => cmdInsert.CommandText += $"{d.Nombre}{(d.Indice < _formatos[disenio].Count() ? "," : string.Empty)} ");
            cmdInsert.CommandText += ") Values ( ";
            _formatos[disenio].ForEach(d => cmdInsert.CommandText += $"@{d.Nombre}{(d.Indice < _formatos[disenio].Count() ? "," : string.Empty)} ");
            cmdInsert.CommandText += ")";
            _formatos[disenio].ForEach(d => cmdInsert.Parameters.Add(d.Nombre, d.TipoDato));


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
                        case SqlDbType.Decimal:
                            cmdInsert.Parameters[d.Nombre].Value = (registro[d.Indice].ToString().Any() ? Decimal.Parse(registro[d.Indice]) : (object)DBNull.Value);
                            break;
                        case SqlDbType.VarChar:
                            cmdInsert.Parameters[d.Nombre].Value = (registro[d.Indice].ToString().Any() ? registro[d.Indice].ToString() : (object)DBNull.Value);
                            break;
                        case SqlDbType.DateTime:
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
            txtPrefijoTabla.Text     = _configuracion.PrefijoTabla;

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
                    case SqlDbType.Decimal:
                        cmdCreateTable.CommandText += $"{d.Nombre} Decimal(18,4) NULL ";
                        break;
                    case SqlDbType.VarChar:
                        cmdCreateTable.CommandText += $"{d.Nombre} VARCHAR({d.LongitudCampo}) NULL ";
                        break;
                    case SqlDbType.DateTime:
                        cmdCreateTable.CommandText += $"{d.Nombre} DATETIME NULL ";
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
                    _formatos[disenio].Add(new Columna("PrevisionesAsistenciaCrediticia", 10, 12, SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("PrevisionesParticipaciones", 11, 12     , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("PrevRespEventGtiaOtorgadas", 12, 12     , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("IncPrevMinPermCat4o5Gral", 13, 12       , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("IncPrevMinPermCat4o5Normas", 14, 12     , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("MaxAsistCliVincODeuda05", 15, 14        , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("TotalFinancionesDeudor", 16, 14         , SqlDbType.Decimal));
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
                case DisenioTxt.D4306:
                    #region Diseño 4306
                    _formatos[disenio].Add(new Columna("TipoIdentificacion", 1, 2                       , SqlDbType.VarChar ));
                    _formatos[disenio].Add(new Columna("NroIdentificacion", 2, 11                       , SqlDbType.VarChar ));
                    _formatos[disenio].Add(new Columna("TipoAsistenciaCrediticia", 3, 2                 , SqlDbType.Int     ));
                    _formatos[disenio].Add(new Columna("GtiaPrefACapIntDevengDeudaVenc", 4, 12          , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("GtiaPrefACapIntDevengDeudaTotal", 5, 12         , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("GtiaPrefACapIntDevengNoPrevDeudaVenc", 6, 12    , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("GtiaPrefACapIntDevengNoPrevDeudaTotal", 7, 12   , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("GtiaPrefBIntDevengPrevDeudaVenc", 8, 12         , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("GtiaPrefBIntDevengPrevDeudaTotal", 9, 12        , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("SinGtiaPrefCapIntDevengNoPrevDeudaVenc", 10, 12 , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("SinGtiaPrefCapIntDevengNoPrevDeudaTotal", 11, 12, SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("SinGtiaPrefIntDevengPrevDeudaVenc", 12, 12      , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("SinGtiaPrefIntDevengPrevDeudaTotal", 13, 12     , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("PrevMinCreAdicionales", 14, 12                  , SqlDbType.Decimal ));
                    _formatos[disenio].Add(new Columna("FechaUltimaRefinanciacion", 15, 8               , SqlDbType.DateTime));
                    _formatos[disenio].Add(new Columna("FinanciacionParaMiPyMEs", 16, 12                , SqlDbType.Decimal ));
                    #endregion
                    break;
                case DisenioTxt.D4307:
                    #region Diseño 4307
                    _formatos[disenio].Add(new Columna("TipoIdentificacion", 1, 2                           , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("NroIdentificacion", 2, 11                           , SqlDbType.VarChar));
                    _formatos[disenio].Add(new Columna("ParticiOtrasSociedadesDeducRPC", 3, 12              , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("ParticiOtrasSociedadesNoDeducRPC", 4, 12            , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("AdelCtaCteAcordadosConContragtiasPrefA", 5, 12      , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("AdelCtaCteAcordadosConContragtiasPrefB", 6, 12      , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("AdelCtaCteAcordadosSinContragtiasPref", 7, 12       , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("ResponsEventualesConContragtiasPrefA", 8, 12        , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("ResponsEventualesConContragtiasPrefB", 9, 12        , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("ResponsEventualesSinContragtiasPref", 10, 12        , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("GtiasOtorgadasConContragtiasPrefA", 11, 12          , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("GtiasOtorgadasConContragtiasPrefB", 12, 12          , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("GtiasOtorgadasSinContragtiasPref", 13, 12           , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("MontoPorIrrecuperablesCtasOrden", 14, 12            , SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("FinanciacionesFianzasAvalesOtrasRespOtorExt", 15, 12, SqlDbType.Decimal));
                    _formatos[disenio].Add(new Columna("DiferenciaPorAdquisicionCartera", 16, 12            , SqlDbType.Decimal));

                    #endregion
                    break;
                default:
                    break;
            }

        }
        #endregion
        
    }

    public class Columna
    {
        public string Nombre { get; set; }
        public SqlDbType TipoDato { get; set; }
        public int LongitudCampo { get; set; }
        public object Valor { get; set; }
        public int Indice { get; set; }

        public Columna(string nombre, int indice, int longitud, SqlDbType tipo)
        {
            Nombre = nombre;
            Indice = indice;
            LongitudCampo = longitud;
            TipoDato = tipo;
        }
    }


}
