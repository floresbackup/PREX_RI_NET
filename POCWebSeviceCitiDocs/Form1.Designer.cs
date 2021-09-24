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
			this.label7 = new System.Windows.Forms.Label();
			this.cmbHttpRequestType = new System.Windows.Forms.ComboBox();
			this.selRestSharp = new System.Windows.Forms.RadioButton();
			this.selNetRequest = new System.Windows.Forms.RadioButton();
			this.ckSsl3 = new System.Windows.Forms.CheckBox();
			this.ckTls1 = new System.Windows.Forms.CheckBox();
			this.ckTls11 = new System.Windows.Forms.CheckBox();
			this.ckTls12 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.txtRequestBody.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResponse.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL Servicio:";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(123, 61);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(490, 20);
			this.txtUrl.TabIndex = 1;
			// 
			// btnProcesar
			// 
			this.btnProcesar.Location = new System.Drawing.Point(540, 321);
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
			this.label2.Location = new System.Drawing.Point(36, 93);
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
			this.txtCertPath.Location = new System.Drawing.Point(123, 90);
			this.txtCertPath.Name = "txtCertPath";
			this.txtCertPath.ReadOnly = true;
			this.txtCertPath.Size = new System.Drawing.Size(430, 20);
			this.txtCertPath.TabIndex = 2;
			// 
			// btnDialogCertificado
			// 
			this.btnDialogCertificado.Location = new System.Drawing.Point(559, 90);
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
			this.label3.Location = new System.Drawing.Point(12, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password Certificado:";
			// 
			// txtCertPass
			// 
			this.txtCertPass.Location = new System.Drawing.Point(123, 120);
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
			this.cmbHttpMethod.Location = new System.Drawing.Point(123, 150);
			this.cmbHttpMethod.Name = "cmbHttpMethod";
			this.cmbHttpMethod.Size = new System.Drawing.Size(159, 21);
			this.cmbHttpMethod.TabIndex = 5;
			this.cmbHttpMethod.SelectedIndexChanged += new System.EventHandler(this.cmbHttpMethod_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(43, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "HTTP Method:";
			// 
			// txtRequestBody
			// 
			this.txtRequestBody.Enabled = false;
			this.txtRequestBody.Location = new System.Drawing.Point(123, 219);
			this.txtRequestBody.Name = "txtRequestBody";
			this.txtRequestBody.Size = new System.Drawing.Size(490, 96);
			this.txtRequestBody.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(38, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Request BODY:";
			// 
			// txtResponse
			// 
			this.txtResponse.Location = new System.Drawing.Point(15, 362);
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtResponse.Properties.Appearance.Options.UseBackColor = true;
			this.txtResponse.Properties.ReadOnly = true;
			this.txtResponse.Size = new System.Drawing.Size(598, 173);
			this.txtResponse.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 345);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Response:";
			// 
			// btnLimpiarCampos
			// 
			this.btnLimpiarCampos.Location = new System.Drawing.Point(459, 321);
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
			this.lblStatusCode.Location = new System.Drawing.Point(85, 345);
			this.lblStatusCode.Name = "lblStatusCode";
			this.lblStatusCode.Size = new System.Drawing.Size(67, 13);
			this.lblStatusCode.TabIndex = 13;
			this.lblStatusCode.Text = "Response:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(55, 188);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Media Type:";
			// 
			// cmbHttpRequestType
			// 
			this.cmbHttpRequestType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbHttpRequestType.FormattingEnabled = true;
			this.cmbHttpRequestType.Items.AddRange(new object[] {
            "application/json",
            "text/plain",
            "application/xml",
            "Ninguno (vacio)"});
			this.cmbHttpRequestType.Location = new System.Drawing.Point(123, 185);
			this.cmbHttpRequestType.Name = "cmbHttpRequestType";
			this.cmbHttpRequestType.Size = new System.Drawing.Size(159, 21);
			this.cmbHttpRequestType.TabIndex = 14;
			// 
			// selRestSharp
			// 
			this.selRestSharp.AutoSize = true;
			this.selRestSharp.Checked = true;
			this.selRestSharp.Location = new System.Drawing.Point(123, 13);
			this.selRestSharp.Name = "selRestSharp";
			this.selRestSharp.Size = new System.Drawing.Size(100, 17);
			this.selRestSharp.TabIndex = 16;
			this.selRestSharp.TabStop = true;
			this.selRestSharp.Text = "Usar RestSharp";
			this.selRestSharp.UseVisualStyleBackColor = true;
			// 
			// selNetRequest
			// 
			this.selNetRequest.AutoSize = true;
			this.selNetRequest.Location = new System.Drawing.Point(235, 13);
			this.selNetRequest.Name = "selNetRequest";
			this.selNetRequest.Size = new System.Drawing.Size(113, 17);
			this.selNetRequest.TabIndex = 16;
			this.selNetRequest.Text = "Usar .Net Request";
			this.selNetRequest.UseVisualStyleBackColor = true;
			// 
			// ckSsl3
			// 
			this.ckSsl3.AutoSize = true;
			this.ckSsl3.Location = new System.Drawing.Point(123, 38);
			this.ckSsl3.Name = "ckSsl3";
			this.ckSsl3.Size = new System.Drawing.Size(49, 17);
			this.ckSsl3.TabIndex = 17;
			this.ckSsl3.Text = "Ssl 3";
			this.ckSsl3.UseVisualStyleBackColor = true;
			// 
			// ckTls1
			// 
			this.ckTls1.AutoSize = true;
			this.ckTls1.Location = new System.Drawing.Point(202, 38);
			this.ckTls1.Name = "ckTls1";
			this.ckTls1.Size = new System.Drawing.Size(49, 17);
			this.ckTls1.TabIndex = 17;
			this.ckTls1.Text = "Tls 1";
			this.ckTls1.UseVisualStyleBackColor = true;
			// 
			// ckTls11
			// 
			this.ckTls11.AutoSize = true;
			this.ckTls11.Location = new System.Drawing.Point(288, 38);
			this.ckTls11.Name = "ckTls11";
			this.ckTls11.Size = new System.Drawing.Size(58, 17);
			this.ckTls11.TabIndex = 17;
			this.ckTls11.Text = "Tls 1.1";
			this.ckTls11.UseVisualStyleBackColor = true;
			// 
			// ckTls12
			// 
			this.ckTls12.AutoSize = true;
			this.ckTls12.Location = new System.Drawing.Point(374, 38);
			this.ckTls12.Name = "ckTls12";
			this.ckTls12.Size = new System.Drawing.Size(58, 17);
			this.ckTls12.TabIndex = 17;
			this.ckTls12.Text = "Tls 1.2";
			this.ckTls12.UseVisualStyleBackColor = true;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 547);
			this.Controls.Add(this.ckTls12);
			this.Controls.Add(this.ckTls11);
			this.Controls.Add(this.ckTls1);
			this.Controls.Add(this.ckSsl3);
			this.Controls.Add(this.selNetRequest);
			this.Controls.Add(this.selRestSharp);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbHttpRequestType);
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
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbHttpRequestType;
		private System.Windows.Forms.RadioButton selRestSharp;
		private System.Windows.Forms.RadioButton selNetRequest;
		private System.Windows.Forms.CheckBox ckSsl3;
		private System.Windows.Forms.CheckBox ckTls1;
		private System.Windows.Forms.CheckBox ckTls11;
		private System.Windows.Forms.CheckBox ckTls12;
	}
}

