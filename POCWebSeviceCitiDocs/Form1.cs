using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using Prex.Utils;
using Prex.Utils.Misc.Http;

namespace POCWebSeviceCitiDocs
{
	public partial class FrmMain : Form
	{

		private SecurityProtocolType? ProtocolType
		{
			get 
			{
				SecurityProtocolType? protocol = null;

				if (ckSsl3.Checked) protocol = protocol == null ? SecurityProtocolType.Ssl3 : protocol | SecurityProtocolType.Ssl3;
				if (ckTls1.Checked) protocol = protocol == null ? SecurityProtocolType.Tls : protocol | SecurityProtocolType.Tls;
				if (ckTls11.Checked) protocol = protocol == null ? SecurityProtocolType.Tls11 : protocol | SecurityProtocolType.Tls11;
				if (ckTls12.Checked) protocol = protocol == null ? SecurityProtocolType.Tls12 : protocol | SecurityProtocolType.Tls12;

				return protocol;
			}
		}


		private HttpMethod HttpMethod 
		{
			get 
			{
				if (cmbHttpMethod.Text.IsNullOrEmpty()) return null;
				if (cmbHttpMethod.Text.EsIgual(HttpMethod.Get.Method)) return HttpMethod.Get;
				if (cmbHttpMethod.Text.EsIgual(HttpMethod.Post.Method)) return HttpMethod.Post;
				return null;
			}
		}
		private string MediaType
		{
			get
			{
				if (cmbHttpRequestType.Text.IsNullOrEmpty()) return null;
				if (cmbHttpRequestType.Text.Contains("Ninguno (vacio)")) return null;
				return cmbHttpRequestType.Text.Trim();
			}
		}

		public FrmMain() => InitializeComponent();

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnDialogCertificado_Click(object sender, EventArgs e)
		{
			fileDialog.FileName = string.Empty;
			fileDialog.Filter = "|*.*";
			txtCertPath.Text = string.Empty;
			if (fileDialog.ShowDialog() == DialogResult.OK)
				txtCertPath.Text = fileDialog.FileName;
		}

		private void cmbHttpMethod_SelectedIndexChanged(object sender, EventArgs e) => txtRequestBody.Enabled = HttpMethod == HttpMethod.Post;

		private void btnProcesar_Click(object sender, EventArgs e)
		{
			if (ValidarDatosEntrada())
				EjecutarRequest();
		}


		private void EjecutarRequest()
		{
			btnProcesar.Enabled = false;
			btnLimpiarCampos.Enabled = false;
			btnDialogCertificado.Enabled = false;
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				lblStatusCode.Text = string.Empty;
				ResponseResult response = null;
				switch (HttpMethod.Method)
				{
					case "GET":
						response = GetResponse();
						break;
					case "POST":
						response = PostResponse();
						break;
				}

				if (response != null)
				{
					txtResponse.Text = response.Content;
					lblStatusCode.Text = $"StatusCode: {response.StatusCode}";
				}
				else
				{
					txtResponse.Text = "NoContent";
					lblStatusCode.Text = string.Empty;
				}

			}
			catch (Exception ex)
			{
				txtResponse.Text = ex.GetFullTextStack();
				lblStatusCode.Text = "Error";
			}
			finally
			{
				btnProcesar.Enabled = true;
				btnLimpiarCampos.Enabled = true;
				btnDialogCertificado.Enabled = true;

				Cursor.Current = Cursors.Default;
			}
		}

		private ResponseResult PostResponse()
		{
			ResponseResult response = null;

			if (selRestSharp.Checked)
			{
				if (txtCertPath.Text.IsNullOrEmpty())
					response = PeticionesHttp.PostRequest(txtUrl.Text, txtRequestBody.Text.Trim(), MediaType, ProtocolType);
				else
					response = PeticionesHttp.PostRequest(txtUrl.Text, txtRequestBody.Text.Trim(), txtCertPath.Text, txtCertPass.Text, MediaType, ProtocolType);
			}

			if (selNetRequest.Checked)
			{
				if (txtCertPath.Text.IsNullOrEmpty())
					response = PeticionesHttp.GestionarPeticion(txtUrl.Text, txtRequestBody.Text.Trim(), HttpMethod.Post, MediaType, null, null, ProtocolType);
				else
					response = PeticionesHttp.GestionarPeticion(txtUrl.Text, string.Empty, HttpMethod.Post, MediaType, null, txtCertPath.Text, txtCertPass.Text, null, ProtocolType);

			}
			return response;

		}

		private ResponseResult GetResponse()
		{
			ResponseResult response = null;

			if (selRestSharp.Checked)
			{
				if (txtCertPath.Text.IsNullOrEmpty())
					response = PeticionesHttp.GetResponse(txtUrl.Text, MediaType, ProtocolType);
				else
					response = PeticionesHttp.GetResponse(txtUrl.Text, txtCertPath.Text, txtCertPass.Text, MediaType, ProtocolType);
			}

			if (selNetRequest.Checked)
			{
				if (txtCertPath.Text.IsNullOrEmpty())
					response = PeticionesHttp.GestionarPeticion(txtUrl.Text, string.Empty, HttpMethod.Get, MediaType, null, null, ProtocolType);
				else
					response = PeticionesHttp.GestionarPeticion(txtUrl.Text, string.Empty, HttpMethod.Get, MediaType, null, txtCertPath.Text, txtCertPass.Text, null, ProtocolType);

			}

			return response;

		}

		private bool ValidarDatosEntrada()
		{
			try
			{

				if (txtUrl.Text.IsNullOrEmpty()) throw new Exception("Debe completar url");
				if (!txtUrl.Text.IsValidUri()) throw new Exception("Formato url inválido");
				if (HttpMethod == null) throw new Exception("Debe elegir un método HTTP");
				if (String.IsNullOrEmpty(MediaType) && !String.IsNullOrEmpty(txtRequestBody.Text.Trim())) throw new Exception("Debe elegir Media Type");

				//if (HttpMethod == HttpMethod.Post && txtRequestBody.Text.IsNullOrEmpty()) throw new Exception("Debe completar el BODY para realizar un método POST");
				if (!txtCertPath.IsNullOrEmpty())
				{
					if (txtCertPass.IsNullOrEmpty()) throw new Exception("Debe especificar password del certificado");
					if (!fileDialog.CheckFileExists) throw new Exception("No se encontró el archivo de certificado");
				}

				return true;
			}
			catch (Exception ex)
			{
				Prex.Utils.MensajesForms.MostrarError(ex.Message);
				return false;
			}
		}

		private void btnLimpiarCampos_Click(object sender, EventArgs e)
		{
			txtCertPass.Text = string.Empty;
			txtCertPath.Text = string.Empty;
			txtRequestBody.Text = string.Empty;
			txtUrl.Text = string.Empty;
			cmbHttpMethod.Text = string.Empty;
			lblStatusCode.Text = string.Empty;
			cmbHttpMethod.Text = string.Empty;
		}

	}
}
