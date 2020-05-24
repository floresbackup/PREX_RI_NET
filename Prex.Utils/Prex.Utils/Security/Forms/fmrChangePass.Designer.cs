namespace Prex.Utils.Security.Forms
{
	partial class fmrChangePass
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrChangePass));
			this.panTop = new System.Windows.Forms.Panel();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtConfirmacion = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtNueva = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.txtActual = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
			this.panTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panTop
			// 
			this.panTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panTop.Controls.Add(this.PictureBox1);
			this.panTop.Controls.Add(this.lblSubtitulo);
			this.panTop.Controls.Add(this.lblTitulo);
			this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panTop.Location = new System.Drawing.Point(0, 0);
			this.panTop.Margin = new System.Windows.Forms.Padding(4);
			this.panTop.Name = "panTop";
			this.panTop.Size = new System.Drawing.Size(535, 55);
			this.panTop.TabIndex = 17;
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(462, 0);
			this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Padding = new System.Windows.Forms.Padding(27, 16, 27, 25);
			this.PictureBox1.Size = new System.Drawing.Size(73, 55);
			this.PictureBox1.TabIndex = 2;
			this.PictureBox1.TabStop = false;
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Location = new System.Drawing.Point(28, 28);
			this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(344, 17);
			this.lblSubtitulo.TabIndex = 1;
			this.lblSubtitulo.Text = "Proporcione la nueva contraseña y su confirmación...";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(16, 7);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(146, 17);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Cambiar contraseña";
			// 
			// txtConfirmacion
			// 
			this.txtConfirmacion.Location = new System.Drawing.Point(166, 198);
			this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4);
			this.txtConfirmacion.Name = "txtConfirmacion";
			this.txtConfirmacion.PasswordChar = '*';
			this.txtConfirmacion.Size = new System.Drawing.Size(355, 22);
			this.txtConfirmacion.TabIndex = 24;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(13, 202);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(94, 17);
			this.Label2.TabIndex = 31;
			this.Label2.Text = "&Confirmación:";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNueva
			// 
			this.txtNueva.Location = new System.Drawing.Point(166, 166);
			this.txtNueva.Margin = new System.Windows.Forms.Padding(4);
			this.txtNueva.Name = "txtNueva";
			this.txtNueva.PasswordChar = '*';
			this.txtNueva.Size = new System.Drawing.Size(355, 22);
			this.txtNueva.TabIndex = 23;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(13, 170);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(128, 17);
			this.Label1.TabIndex = 30;
			this.Label1.Text = "Contraseña &nueva:";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescripcion.Location = new System.Drawing.Point(13, 101);
			this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(69, 17);
			this.lblDescripcion.TabIndex = 29;
			this.lblDescripcion.Text = "Nombre:";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(13, 72);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(69, 17);
			this.lblUsuario.TabIndex = 28;
			this.lblUsuario.Text = "Usuario:";
			// 
			// txtActual
			// 
			this.txtActual.Location = new System.Drawing.Point(166, 134);
			this.txtActual.Margin = new System.Windows.Forms.Padding(4);
			this.txtActual.Name = "txtActual";
			this.txtActual.PasswordChar = '*';
			this.txtActual.Size = new System.Drawing.Size(355, 22);
			this.txtActual.TabIndex = 22;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordLabel.Location = new System.Drawing.Point(13, 138);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(145, 17);
			this.PasswordLabel.TabIndex = 25;
			this.PasswordLabel.Text = "Contraseña &actual:";
			this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAceptar
			// 
			this.btnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.Image")));
			this.btnAceptar.Location = new System.Drawing.Point(303, 237);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(106, 28);
			this.btnAceptar.TabIndex = 32;
			this.btnAceptar.Text = "&Cambiar";
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(415, 237);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(106, 28);
			this.btnCancelar.TabIndex = 33;
			this.btnCancelar.Text = "Cancela&r";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// fmrChangePass
			// 
			this.ClientSize = new System.Drawing.Size(535, 276);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtConfirmacion);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.txtNueva);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lblDescripcion);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtActual);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.panTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fmrChangePass";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambiar contraseña de usuario";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmrChangePass_FormClosing);
			this.panTop.ResumeLayout(false);
			this.panTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraEditors.SimpleButton btnOk;
		internal System.Windows.Forms.Panel panTop;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label lblSubtitulo;
		internal System.Windows.Forms.Label lblTitulo;
		internal System.Windows.Forms.TextBox txtConfirmacion;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtNueva;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label lblDescripcion;
		internal System.Windows.Forms.Label lblUsuario;
		internal System.Windows.Forms.TextBox txtActual;
		internal System.Windows.Forms.Label PasswordLabel;
		private DevExpress.XtraEditors.SimpleButton btnAceptar;
		private DevExpress.XtraEditors.SimpleButton btnCancelar;
	}
}