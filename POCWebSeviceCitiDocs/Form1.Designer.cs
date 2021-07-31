namespace POCWebSeviceCitiDocs
{
	partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.label1 = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.btnProcesar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.txtCertPath = new System.Windows.Forms.TextBox();
			this.btnDialogCertificado = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCertPass = new System.Windows.Forms.MaskedTextBox();
			this.cmbHttpMethod = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRequestBody = new DevExpress.XtraEditors.MemoEdit();
			this.label5 = new System.Windows.Forms.Label();
			this.txtResponse = new DevExpress.XtraEditors.MemoEdit();
			this.label6 = new System.Windows.Forms.Label();
			this.btnLimpiarCampos = new System.Windows.Forms.Button();
			this.lblStatusCode = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtRequestBody.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResponse.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL Servicio:";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(123, 45);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(490, 20);
			this.txtUrl.TabIndex = 1;
			// 
			// btnProcesar
			// 
			this.btnProcesar.Location = new System.Drawing.Point(540, 274);
			this.btnProcesar.Name = "btnProcesar";
			this.btnProcesar.Size = new System.Drawing.Size(75, 35);
			this.btnProcesar.TabIndex = 8;
			this.btnProcesar.Text = "&Procesar";
			this.btnProcesar.UseVisualStyleBackColor = true;
			this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ruta certificado:";
			// 
			// fileDialog
			// 
			this.fileDialog.DefaultExt = "*.pfx";
			this.fileDialog.FileName = "openFileDialog1";
			this.fileDialog.Multiselect = true;
			// 
			// txtCertPath
			// 
			this.txtCertPath.Location = new System.Drawing.Point(123, 74);
			this.txtCertPath.Name = "txtCertPath";
			this.txtCertPath.ReadOnly = true;
			this.txtCertPath.Size = new System.Drawing.Size(430, 20);
			this.txtCertPath.TabIndex = 2;
			// 
			// btnDialogCertificado
			// 
			this.btnDialogCertificado.Location = new System.Drawing.Point(559, 74);
			this.btnDialogCertificado.Name = "btnDialogCertificado";
			this.btnDialogCertificado.Size = new System.Drawing.Size(54, 20);
			this.btnDialogCertificado.TabIndex = 3;
			this.btnDialogCertificado.Text = "&Buscar";
			this.btnDialogCertificado.UseVisualStyleBackColor = true;
			this.btnDialogCertificado.Click += new System.EventHandler(this.btnDialogCertificado_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password Certificado:";
			// 
			// txtCertPass
			// 
			this.txtCertPass.Location = new System.Drawing.Point(123, 104);
			this.txtCertPass.Name = "txtCertPass";
			this.txtCertPass.Size = new System.Drawing.Size(159, 20);
			this.txtCertPass.TabIndex = 4;
			// 
			// cmbHttpMethod
			// 
			this.cmbHttpMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbHttpMethod.FormattingEnabled = true;
			this.cmbHttpMethod.Items.AddRange(new object[] {
            "GET",
            "POST"});
			this.cmbHttpMethod.Location = new System.Drawing.Point(123, 134);
			this.cmbHttpMethod.Name = "cmbHttpMethod";
			this.cmbHttpMethod.Size = new System.Drawing.Size(159, 21);
			this.cmbHttpMethod.TabIndex = 5;
			this.cmbHttpMethod.SelectedIndexChanged += new System.EventHandler(this.cmbHttpMethod_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(43, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "HTTP Method:";
			// 
			// txtRequestBody
			// 
			this.txtRequestBody.Enabled = false;
			this.txtRequestBody.Location = new System.Drawing.Point(123, 172);
			this.txtRequestBody.Name = "txtRequestBody";
			this.txtRequestBody.Size = new System.Drawing.Size(490, 96);
			this.txtRequestBody.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(38, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Request BODY:";
			// 
			// txtResponse
			// 
			this.txtResponse.Location = new System.Drawing.Point(15, 330);
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtResponse.Properties.Appearance.Options.UseBackColor = true;
			this.txtResponse.Properties.ReadOnly = true;
			this.txtResponse.Size = new System.Drawing.Size(598, 205);
			this.txtResponse.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 314);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Response:";
			// 
			// btnLimpiarCampos
			// 
			this.btnLimpiarCampos.Location = new System.Drawing.Point(459, 274);
			this.btnLimpiarCampos.Name = "btnLimpiarCampos";
			this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 35);
			this.btnLimpiarCampos.TabIndex = 7;
			this.btnLimpiarCampos.Text = "&Vaciar campos";
			this.btnLimpiarCampos.UseVisualStyleBackColor = true;
			this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
			// 
			// lblStatusCode
			// 
			this.lblStatusCode.AutoSize = true;
			this.lblStatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusCode.Location = new System.Drawing.Point(85, 314);
			this.lblStatusCode.Name = "lblStatusCode";
			this.lblStatusCode.Size = new System.Drawing.Size(67, 13);
			this.lblStatusCode.TabIndex = 13;
			this.lblStatusCode.Text = "Response:";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 547);
			this.Controls.Add(this.lblStatusCode);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtResponse);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtRequestBody);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbHttpMethod);
			this.Controls.Add(this.txtCertPass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnDialogCertificado);
			this.Controls.Add(this.txtCertPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnLimpiarCampos);
			this.Controls.Add(this.btnProcesar);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta WebService";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtRequestBody.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResponse.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnProcesar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.TextBox txtCertPath;
		private System.Windows.Forms.Button btnDialogCertificado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox txtCertPass;
		private System.Windows.Forms.ComboBox cmbHttpMethod;
		private System.Windows.Forms.Label label4;
		private DevExpress.XtraEditors.MemoEdit txtRequestBody;
		private System.Windows.Forms.Label label5;
		private DevExpress.XtraEditors.MemoEdit txtResponse;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnLimpiarCampos;
		private System.Windows.Forms.Label lblStatusCode;
	}
}

