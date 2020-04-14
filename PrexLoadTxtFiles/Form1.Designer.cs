namespace PrexLoadTxtFiles
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.txtPathBCP = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtDecimalSeparator = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.btnDialogBCP = new System.Windows.Forms.Button();
			this.btnProcesar = new System.Windows.Forms.Button();
			this.lblProgreso = new System.Windows.Forms.Label();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.chkDiseno4305 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkDiseno4306 = new System.Windows.Forms.CheckBox();
			this.chkDiseno4307 = new System.Windows.Forms.CheckBox();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.pgTXT = new System.Windows.Forms.TabPage();
			this.txtPrefijoArchivo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPathDestino = new System.Windows.Forms.TextBox();
			this.btnDialogDestino = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.chkTXT = new System.Windows.Forms.CheckBox();
			this.pgSQL = new System.Windows.Forms.TabPage();
			this.chkSQL = new System.Windows.Forms.CheckBox();
			this.txtPrefijoTabla = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSQLServer = new System.Windows.Forms.TextBox();
			this.txtUserPass = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtDataBase = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtSQLUser = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.pgTXT.SuspendLayout();
			this.pgSQL.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPathBCP
			// 
			this.txtPathBCP.Location = new System.Drawing.Point(199, 228);
			this.txtPathBCP.Margin = new System.Windows.Forms.Padding(4);
			this.txtPathBCP.Name = "txtPathBCP";
			this.txtPathBCP.ReadOnly = true;
			this.txtPathBCP.Size = new System.Drawing.Size(424, 22);
			this.txtPathBCP.TabIndex = 20;
			this.txtPathBCP.TabStop = false;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(19, 232);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(170, 17);
			this.Label1.TabIndex = 18;
			this.Label1.Text = "Directorio de archivo TXT";
			// 
			// txtDecimalSeparator
			// 
			this.txtDecimalSeparator.Location = new System.Drawing.Point(199, 261);
			this.txtDecimalSeparator.Margin = new System.Windows.Forms.Padding(4);
			this.txtDecimalSeparator.Name = "txtDecimalSeparator";
			this.txtDecimalSeparator.Size = new System.Drawing.Size(32, 22);
			this.txtDecimalSeparator.TabIndex = 21;
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(55, 265);
			this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(138, 17);
			this.Label4.TabIndex = 22;
			this.Label4.Text = "Separador Terminos";
			// 
			// btnDialogBCP
			// 
			this.btnDialogBCP.Image = global::PrexLoadTxtFiles.Properties.Resources.folder_drag_accept_3;
			this.btnDialogBCP.Location = new System.Drawing.Point(632, 226);
			this.btnDialogBCP.Margin = new System.Windows.Forms.Padding(4);
			this.btnDialogBCP.Name = "btnDialogBCP";
			this.btnDialogBCP.Size = new System.Drawing.Size(35, 28);
			this.btnDialogBCP.TabIndex = 19;
			this.btnDialogBCP.UseVisualStyleBackColor = true;
			this.btnDialogBCP.Click += new System.EventHandler(this.btnDialogBCP_Click);
			// 
			// btnProcesar
			// 
			this.btnProcesar.Image = global::PrexLoadTxtFiles.Properties.Resources.document_save_4;
			this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProcesar.Location = new System.Drawing.Point(559, 419);
			this.btnProcesar.Margin = new System.Windows.Forms.Padding(4);
			this.btnProcesar.Name = "btnProcesar";
			this.btnProcesar.Size = new System.Drawing.Size(100, 28);
			this.btnProcesar.TabIndex = 17;
			this.btnProcesar.Text = "Procesar";
			this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProcesar.UseVisualStyleBackColor = true;
			this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
			// 
			// lblProgreso
			// 
			this.lblProgreso.AutoSize = true;
			this.lblProgreso.Location = new System.Drawing.Point(19, 394);
			this.lblProgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProgreso.Name = "lblProgreso";
			this.lblProgreso.Size = new System.Drawing.Size(80, 17);
			this.lblProgreso.TabIndex = 24;
			this.lblProgreso.Text = "lblProgreso";
			this.lblProgreso.Visible = false;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(23, 419);
			this.progressBar.Margin = new System.Windows.Forms.Padding(4);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(515, 28);
			this.progressBar.TabIndex = 25;
			this.progressBar.Visible = false;
			// 
			// chkDiseno4305
			// 
			this.chkDiseno4305.AutoSize = true;
			this.chkDiseno4305.Checked = true;
			this.chkDiseno4305.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDiseno4305.Location = new System.Drawing.Point(63, 41);
			this.chkDiseno4305.Margin = new System.Windows.Forms.Padding(4);
			this.chkDiseno4305.Name = "chkDiseno4305";
			this.chkDiseno4305.Size = new System.Drawing.Size(62, 21);
			this.chkDiseno4305.TabIndex = 26;
			this.chkDiseno4305.Text = "4305";
			this.chkDiseno4305.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkDiseno4306);
			this.groupBox2.Controls.Add(this.chkDiseno4307);
			this.groupBox2.Controls.Add(this.chkDiseno4305);
			this.groupBox2.Location = new System.Drawing.Point(16, 297);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(643, 82);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Diseños a procesar";
			// 
			// chkDiseno4306
			// 
			this.chkDiseno4306.AutoSize = true;
			this.chkDiseno4306.Checked = true;
			this.chkDiseno4306.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDiseno4306.Location = new System.Drawing.Point(253, 41);
			this.chkDiseno4306.Margin = new System.Windows.Forms.Padding(4);
			this.chkDiseno4306.Name = "chkDiseno4306";
			this.chkDiseno4306.Size = new System.Drawing.Size(62, 21);
			this.chkDiseno4306.TabIndex = 28;
			this.chkDiseno4306.Text = "4306";
			this.chkDiseno4306.UseVisualStyleBackColor = true;
			// 
			// chkDiseno4307
			// 
			this.chkDiseno4307.AutoSize = true;
			this.chkDiseno4307.Checked = true;
			this.chkDiseno4307.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDiseno4307.Location = new System.Drawing.Point(443, 41);
			this.chkDiseno4307.Margin = new System.Windows.Forms.Padding(4);
			this.chkDiseno4307.Name = "chkDiseno4307";
			this.chkDiseno4307.Size = new System.Drawing.Size(62, 21);
			this.chkDiseno4307.TabIndex = 27;
			this.chkDiseno4307.Text = "4307";
			this.chkDiseno4307.UseVisualStyleBackColor = true;
			// 
			// TabControl1
			// 
			this.TabControl1.Controls.Add(this.pgTXT);
			this.TabControl1.Controls.Add(this.pgSQL);
			this.TabControl1.Location = new System.Drawing.Point(12, 12);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(657, 207);
			this.TabControl1.TabIndex = 28;
			// 
			// pgTXT
			// 
			this.pgTXT.Controls.Add(this.txtPrefijoArchivo);
			this.pgTXT.Controls.Add(this.label9);
			this.pgTXT.Controls.Add(this.txtPathDestino);
			this.pgTXT.Controls.Add(this.btnDialogDestino);
			this.pgTXT.Controls.Add(this.label8);
			this.pgTXT.Controls.Add(this.chkTXT);
			this.pgTXT.Location = new System.Drawing.Point(4, 25);
			this.pgTXT.Name = "pgTXT";
			this.pgTXT.Padding = new System.Windows.Forms.Padding(3);
			this.pgTXT.Size = new System.Drawing.Size(649, 178);
			this.pgTXT.TabIndex = 1;
			this.pgTXT.Text = "Destino TXT";
			this.pgTXT.UseVisualStyleBackColor = true;
			// 
			// txtPrefijoArchivo
			// 
			this.txtPrefijoArchivo.Enabled = false;
			this.txtPrefijoArchivo.Location = new System.Drawing.Point(180, 100);
			this.txtPrefijoArchivo.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrefijoArchivo.Name = "txtPrefijoArchivo";
			this.txtPrefijoArchivo.Size = new System.Drawing.Size(164, 22);
			this.txtPrefijoArchivo.TabIndex = 34;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(70, 103);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 17);
			this.label9.TabIndex = 33;
			this.label9.Text = "Agregar prefijo";
			// 
			// txtPathDestino
			// 
			this.txtPathDestino.Enabled = false;
			this.txtPathDestino.Location = new System.Drawing.Point(180, 61);
			this.txtPathDestino.Margin = new System.Windows.Forms.Padding(4);
			this.txtPathDestino.Name = "txtPathDestino";
			this.txtPathDestino.Size = new System.Drawing.Size(394, 22);
			this.txtPathDestino.TabIndex = 32;
			// 
			// btnDialogDestino
			// 
			this.btnDialogDestino.Enabled = false;
			this.btnDialogDestino.Image = global::PrexLoadTxtFiles.Properties.Resources.folder_drag_accept_3;
			this.btnDialogDestino.Location = new System.Drawing.Point(582, 58);
			this.btnDialogDestino.Margin = new System.Windows.Forms.Padding(4);
			this.btnDialogDestino.Name = "btnDialogDestino";
			this.btnDialogDestino.Size = new System.Drawing.Size(35, 28);
			this.btnDialogDestino.TabIndex = 31;
			this.btnDialogDestino.UseVisualStyleBackColor = true;
			this.btnDialogDestino.Click += new System.EventHandler(this.button1_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(39, 64);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 17);
			this.label8.TabIndex = 30;
			this.label8.Text = "Destino de archivos";
			// 
			// chkTXT
			// 
			this.chkTXT.AutoSize = true;
			this.chkTXT.Location = new System.Drawing.Point(21, 17);
			this.chkTXT.Margin = new System.Windows.Forms.Padding(4);
			this.chkTXT.Name = "chkTXT";
			this.chkTXT.Size = new System.Drawing.Size(163, 21);
			this.chkTXT.TabIndex = 29;
			this.chkTXT.Text = "Habilitar destino TXT";
			this.chkTXT.UseVisualStyleBackColor = true;
			this.chkTXT.CheckedChanged += new System.EventHandler(this.chkTXT_CheckedChanged);
			// 
			// pgSQL
			// 
			this.pgSQL.Controls.Add(this.chkSQL);
			this.pgSQL.Controls.Add(this.txtPrefijoTabla);
			this.pgSQL.Controls.Add(this.label2);
			this.pgSQL.Controls.Add(this.txtSQLServer);
			this.pgSQL.Controls.Add(this.txtUserPass);
			this.pgSQL.Controls.Add(this.Label3);
			this.pgSQL.Controls.Add(this.txtDataBase);
			this.pgSQL.Controls.Add(this.Label5);
			this.pgSQL.Controls.Add(this.Label7);
			this.pgSQL.Controls.Add(this.txtSQLUser);
			this.pgSQL.Controls.Add(this.Label6);
			this.pgSQL.Location = new System.Drawing.Point(4, 25);
			this.pgSQL.Name = "pgSQL";
			this.pgSQL.Padding = new System.Windows.Forms.Padding(3);
			this.pgSQL.Size = new System.Drawing.Size(649, 178);
			this.pgSQL.TabIndex = 0;
			this.pgSQL.Text = "Destino SQL";
			this.pgSQL.UseVisualStyleBackColor = true;
			// 
			// chkSQL
			// 
			this.chkSQL.AutoSize = true;
			this.chkSQL.Location = new System.Drawing.Point(21, 17);
			this.chkSQL.Margin = new System.Windows.Forms.Padding(4);
			this.chkSQL.Name = "chkSQL";
			this.chkSQL.Size = new System.Drawing.Size(164, 21);
			this.chkSQL.TabIndex = 28;
			this.chkSQL.Text = "Habilitar destino SQL";
			this.chkSQL.UseVisualStyleBackColor = true;
			this.chkSQL.CheckedChanged += new System.EventHandler(this.chkSQL_CheckedChanged);
			// 
			// txtPrefijoTabla
			// 
			this.txtPrefijoTabla.Enabled = false;
			this.txtPrefijoTabla.Location = new System.Drawing.Point(450, 125);
			this.txtPrefijoTabla.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrefijoTabla.Name = "txtPrefijoTabla";
			this.txtPrefijoTabla.Size = new System.Drawing.Size(164, 22);
			this.txtPrefijoTabla.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Enabled = false;
			this.label2.Location = new System.Drawing.Point(288, 128);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 17);
			this.label2.TabIndex = 26;
			this.label2.Text = "Agregar prefijo de tabla";
			// 
			// txtSQLServer
			// 
			this.txtSQLServer.Enabled = false;
			this.txtSQLServer.Location = new System.Drawing.Point(119, 61);
			this.txtSQLServer.Margin = new System.Windows.Forms.Padding(4);
			this.txtSQLServer.Name = "txtSQLServer";
			this.txtSQLServer.Size = new System.Drawing.Size(180, 22);
			this.txtSQLServer.TabIndex = 22;
			// 
			// txtUserPass
			// 
			this.txtUserPass.Enabled = false;
			this.txtUserPass.Location = new System.Drawing.Point(451, 93);
			this.txtUserPass.Margin = new System.Windows.Forms.Padding(4);
			this.txtUserPass.Name = "txtUserPass";
			this.txtUserPass.PasswordChar = '*';
			this.txtUserPass.Size = new System.Drawing.Size(163, 22);
			this.txtUserPass.TabIndex = 25;
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Enabled = false;
			this.Label3.Location = new System.Drawing.Point(18, 64);
			this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(93, 17);
			this.Label3.TabIndex = 21;
			this.Label3.Text = "Servidor SQL";
			// 
			// txtDataBase
			// 
			this.txtDataBase.Enabled = false;
			this.txtDataBase.Location = new System.Drawing.Point(451, 61);
			this.txtDataBase.Margin = new System.Windows.Forms.Padding(4);
			this.txtDataBase.Name = "txtDataBase";
			this.txtDataBase.Size = new System.Drawing.Size(163, 22);
			this.txtDataBase.TabIndex = 23;
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Enabled = false;
			this.Label5.Location = new System.Drawing.Point(362, 96);
			this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(81, 17);
			this.Label5.TabIndex = 20;
			this.Label5.Text = "Contraseña";
			// 
			// Label7
			// 
			this.Label7.AutoSize = true;
			this.Label7.Enabled = false;
			this.Label7.Location = new System.Drawing.Point(308, 64);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(133, 17);
			this.Label7.TabIndex = 19;
			this.Label7.Text = "Base Datos Destino";
			// 
			// txtSQLUser
			// 
			this.txtSQLUser.Enabled = false;
			this.txtSQLUser.Location = new System.Drawing.Point(118, 93);
			this.txtSQLUser.Margin = new System.Windows.Forms.Padding(4);
			this.txtSQLUser.Name = "txtSQLUser";
			this.txtSQLUser.Size = new System.Drawing.Size(181, 22);
			this.txtSQLUser.TabIndex = 24;
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Enabled = false;
			this.Label6.Location = new System.Drawing.Point(54, 96);
			this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(57, 17);
			this.Label6.TabIndex = 18;
			this.Label6.Text = "Usuario";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 463);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblProgreso);
			this.Controls.Add(this.txtDecimalSeparator);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.btnDialogBCP);
			this.Controls.Add(this.txtPathBCP);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnProcesar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "Importador de TXT";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.pgTXT.ResumeLayout(false);
			this.pgTXT.PerformLayout();
			this.pgSQL.ResumeLayout(false);
			this.pgSQL.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnProcesar;
        internal System.Windows.Forms.Button btnDialogBCP;
        internal System.Windows.Forms.TextBox txtPathBCP;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDecimalSeparator;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblProgreso;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDiseno4306;
        private System.Windows.Forms.CheckBox chkDiseno4307;
        private System.Windows.Forms.CheckBox chkDiseno4305;
		private System.Windows.Forms.TabControl TabControl1;
		private System.Windows.Forms.TabPage pgTXT;
		internal System.Windows.Forms.TextBox txtPrefijoArchivo;
		internal System.Windows.Forms.Label label9;
		internal System.Windows.Forms.TextBox txtPathDestino;
		internal System.Windows.Forms.Button btnDialogDestino;
		internal System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox chkTXT;
		private System.Windows.Forms.TabPage pgSQL;
		private System.Windows.Forms.CheckBox chkSQL;
		internal System.Windows.Forms.TextBox txtPrefijoTabla;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox txtSQLServer;
		internal System.Windows.Forms.TextBox txtUserPass;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtDataBase;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtSQLUser;
		internal System.Windows.Forms.Label Label6;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

