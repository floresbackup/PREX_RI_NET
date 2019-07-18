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
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.txtSQLServer = new System.Windows.Forms.TextBox();
            this.txtSQLUser = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrefijoTabla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.chkDiseno4307 = new System.Windows.Forms.CheckBox();
            this.chkDiseno4306 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(333, 55);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(123, 20);
            this.txtUserPass.TabIndex = 15;
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(333, 29);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(123, 20);
            this.txtDataBase.TabIndex = 13;
            // 
            // txtSQLServer
            // 
            this.txtSQLServer.Location = new System.Drawing.Point(84, 29);
            this.txtSQLServer.Name = "txtSQLServer";
            this.txtSQLServer.Size = new System.Drawing.Size(136, 20);
            this.txtSQLServer.TabIndex = 12;
            // 
            // txtSQLUser
            // 
            this.txtSQLUser.Location = new System.Drawing.Point(83, 55);
            this.txtSQLUser.Name = "txtSQLUser";
            this.txtSQLUser.Size = new System.Drawing.Size(137, 20);
            this.txtSQLUser.TabIndex = 14;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(35, 58);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 13);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Usuario";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(226, 32);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(101, 13);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "Base Datos Destino";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(266, 58);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Contraseña";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 32);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Servidor SQL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrefijoTabla);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSQLServer);
            this.groupBox1.Controls.Add(this.txtUserPass);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.txtDataBase);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.txtSQLUser);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 115);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión con DB";
            // 
            // txtPrefijoTabla
            // 
            this.txtPrefijoTabla.Location = new System.Drawing.Point(332, 81);
            this.txtPrefijoTabla.Name = "txtPrefijoTabla";
            this.txtPrefijoTabla.Size = new System.Drawing.Size(124, 20);
            this.txtPrefijoTabla.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Agregar prefijo de tabla";
            // 
            // txtPathBCP
            // 
            this.txtPathBCP.Location = new System.Drawing.Point(149, 135);
            this.txtPathBCP.Name = "txtPathBCP";
            this.txtPathBCP.ReadOnly = true;
            this.txtPathBCP.Size = new System.Drawing.Size(319, 20);
            this.txtPathBCP.TabIndex = 20;
            this.txtPathBCP.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 138);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(129, 13);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Directorio de archivo TXT";
            // 
            // txtDecimalSeparator
            // 
            this.txtDecimalSeparator.Location = new System.Drawing.Point(149, 162);
            this.txtDecimalSeparator.Name = "txtDecimalSeparator";
            this.txtDecimalSeparator.Size = new System.Drawing.Size(25, 20);
            this.txtDecimalSeparator.TabIndex = 21;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(41, 165);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(102, 13);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Separador Terminos";
            // 
            // btnDialogBCP
            // 
            this.btnDialogBCP.Image = global::PrexLoadTxtFiles.Properties.Resources.folder_drag_accept_3;
            this.btnDialogBCP.Location = new System.Drawing.Point(474, 133);
            this.btnDialogBCP.Name = "btnDialogBCP";
            this.btnDialogBCP.Size = new System.Drawing.Size(26, 23);
            this.btnDialogBCP.TabIndex = 19;
            this.btnDialogBCP.UseVisualStyleBackColor = true;
            this.btnDialogBCP.Click += new System.EventHandler(this.btnDialogBCP_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Image = global::PrexLoadTxtFiles.Properties.Resources.document_save_4;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(419, 290);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 17;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(14, 270);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(59, 13);
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
            this.progressBar.Location = new System.Drawing.Point(17, 290);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(386, 23);
            this.progressBar.TabIndex = 25;
            this.progressBar.Visible = false;
            // 
            // chkDiseno4305
            // 
            this.chkDiseno4305.AutoSize = true;
            this.chkDiseno4305.Checked = true;
            this.chkDiseno4305.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiseno4305.Location = new System.Drawing.Point(47, 33);
            this.chkDiseno4305.Name = "chkDiseno4305";
            this.chkDiseno4305.Size = new System.Drawing.Size(50, 17);
            this.chkDiseno4305.TabIndex = 26;
            this.chkDiseno4305.Text = "4305";
            this.chkDiseno4305.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDiseno4306);
            this.groupBox2.Controls.Add(this.chkDiseno4307);
            this.groupBox2.Controls.Add(this.chkDiseno4305);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 67);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diseños a procesar";
            // 
            // chkDiseno4307
            // 
            this.chkDiseno4307.AutoSize = true;
            this.chkDiseno4307.Checked = true;
            this.chkDiseno4307.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiseno4307.Location = new System.Drawing.Point(311, 33);
            this.chkDiseno4307.Name = "chkDiseno4307";
            this.chkDiseno4307.Size = new System.Drawing.Size(50, 17);
            this.chkDiseno4307.TabIndex = 27;
            this.chkDiseno4307.Text = "4307";
            this.chkDiseno4307.UseVisualStyleBackColor = true;
            // 
            // chkDiseno4306
            // 
            this.chkDiseno4306.AutoSize = true;
            this.chkDiseno4306.Checked = true;
            this.chkDiseno4306.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiseno4306.Location = new System.Drawing.Point(186, 33);
            this.chkDiseno4306.Name = "chkDiseno4306";
            this.chkDiseno4306.Size = new System.Drawing.Size(50, 17);
            this.chkDiseno4306.TabIndex = 28;
            this.chkDiseno4306.Text = "4306";
            this.chkDiseno4306.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.txtDecimalSeparator);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnDialogBCP);
            this.Controls.Add(this.txtPathBCP);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Importador de TXT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtUserPass;
        internal System.Windows.Forms.TextBox txtDataBase;
        internal System.Windows.Forms.TextBox txtSQLServer;
        internal System.Windows.Forms.TextBox txtSQLUser;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnProcesar;
        internal System.Windows.Forms.Button btnDialogBCP;
        internal System.Windows.Forms.TextBox txtPathBCP;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDecimalSeparator;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtPrefijoTabla;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblProgreso;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDiseno4306;
        private System.Windows.Forms.CheckBox chkDiseno4307;
        private System.Windows.Forms.CheckBox chkDiseno4305;
    }
}

