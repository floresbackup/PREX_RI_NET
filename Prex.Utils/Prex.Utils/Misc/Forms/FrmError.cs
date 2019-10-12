using System;
using System.Linq;
using System.Windows.Forms;

namespace Prex.Utils
{
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        public void CargarFormulario(Exception ex) => CargarFormulario(ex, string.Empty, ex.Message);
        
        public void CargarFormulario(Exception ex, string nombreFuncion, string customDescripcion)
        {

            CargarFormulario(ex.GetHashCode().ToString(), string.Empty, nombreFuncion, customDescripcion.Any()? customDescripcion:ex.Message);
            if (ex.Source != null && ex.TargetSite != null) txtOrigen.Text = ex.Source + " - " + ex.TargetSite.Name;
            txtDescripcion.Text = txtDescripcion.Text + Environment.NewLine + "TRAZA:" + Environment.NewLine + ex.StackTrace;
        }
        public void CargarFormulario(string codigoError, string textoOriginal, string nombreFuncion, string customDescripcion)
        {
            txtCodigo.Text = codigoError;
            txtOrigen.Text = textoOriginal;
            txtFuncion.Text = nombreFuncion;
            txtFecha.Text = DateTime.Today.ToShortDateString();
            txtHora.Text = DateTime.Now.ToShortDateString();

            if (customDescripcion.Any())
                txtDescripcion.Text = customDescripcion;

        }
    }
}
