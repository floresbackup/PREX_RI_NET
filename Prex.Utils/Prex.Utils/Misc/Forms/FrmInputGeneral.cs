using System;
using System.Windows.Forms;

namespace Prex.Utils.Misc.Forms
{
    public partial class FrmInputGeneral : Form
    {

        private string sInputGeneral;
        public string ResultadoInput => sInputGeneral;

        public FrmInputGeneral()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Trim() != "")
            {
                sInputGeneral = txtResultado.Text;
                Configuration.PrexConfig.INPUT_GENERAL = txtResultado.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                Prex.Utils.MensajesForms.MostrarError("Dato no válido");
                txtResultado.Focus();
            }

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Configuration.PrexConfig.INPUT_GENERAL = "";
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        public void PasarInfoVentana(string titulo, string label)
        {
            Text = titulo;
            lblTip.Text = label;
        }
    }
}
