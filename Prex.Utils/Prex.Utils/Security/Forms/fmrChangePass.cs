using System;
using System.Windows.Forms;

namespace Prex.Utils.Security.Forms
{
	public partial class fmrChangePass : Form
	{
		private Usuario _usuarioActual;
		private bool salir;

		public fmrChangePass()
		{
			InitializeComponent();
		}

		public void PasarDatos(string usuario) => PasarDatos(usuario, false, string.Empty);

		public void PasarDatos(string usuario, bool renueva, string passActual)
		{

			_usuarioActual = Prex.Utils.Security.Functions.GetUsuario(usuario);
			if (_usuarioActual == null)
				throw new Exception("No se encontró usuario para cambiar contraseña");


			lblUsuario.Text = "Usuario: " + usuario;
			lblDescripcion.Text = "Nombre: " + _usuarioActual.Descripcion;

			txtActual.Enabled = renueva;

			PasswordLabel.Enabled = renueva;

		}

		private bool DatosOK()
		{
			if (txtNueva.Text.Trim() == "")
			{
				MensajesForms.MostrarError("Debe ingresar una nueva contraseña");
				txtNueva.Focus();
				return false;
			}

			if (txtNueva.Text != txtConfirmacion.Text)
			{
				MensajesForms.MostrarError("La contraseña nueva y la confirmación no coinciden");
				txtNueva.Focus();
				return false;
			}


			if (txtActual.Enabled)
			{
				if (txtActual.Text.Trim().ToUpper() == txtNueva.Text.Trim().ToUpper())
				{
					MensajesForms.MostrarError("La nueva contraseña debe diferir de la anterior, sin distinguir mayúsculas de minúsculas");
					txtNueva.Focus();
					return false;
				}
			}

			if (txtActual.Enabled)
			{
				if (Functions.CalculateMD5(txtActual.Text) != _usuarioActual.Password)
				{
					MensajesForms.MostrarError("La contraseña actual es incorrecta");
					txtActual.Focus();
					return false;
				}
			}
			return true;

		}


		private bool Guardar()
		{

			try
			{
				return Functions.CambiarPassword(_usuarioActual.Nombre, txtNueva.Text, Configuration.PrexConfig.UsuarioActual.Codigo > 1);
			}
			catch (Exception ex)
			{
				Prex.Utils.ManejarErrores.TratarError(ex, "GuardarCambairContraseña");
				return false;
			}
		}

		private void ValidarYGuardar()
		{
			try
			{
				Cursor = Cursors.WaitCursor;
				salir = false;
				if (DatosOK())
				{
					if (Guardar())
					{
						DialogResult = DialogResult.OK;
						salir = true;
						Close();
					}
				}
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void fmrChangePass_FormClosing(object sender, FormClosingEventArgs e)
		{
				e.Cancel = !salir;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			ValidarYGuardar();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			salir = true;
			Close();
		}
	}
}