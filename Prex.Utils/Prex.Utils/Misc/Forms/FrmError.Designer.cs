namespace Prex.Utils
{
    partial class frmError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
            this.panTop = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lnkMail = new System.Windows.Forms.LinkLabel();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
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
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(521, 45);
            this.panTop.TabIndex = 16;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(451, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.PictureBox1.Size = new System.Drawing.Size(70, 45);
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(21, 23);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(217, 13);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Presione el botón Aceptar para volver atrás";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(104, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Error del Sistema";
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.BackColor = System.Drawing.SystemColors.Control;
            this.OK_Button.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.Location = new System.Drawing.Point(422, 294);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(88, 23);
            this.OK_Button.TabIndex = 29;
            this.OK_Button.Text = "Aceptar";
            this.OK_Button.UseVisualStyleBackColor = false;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // txtHora
            // 
            this.txtHora.AutoSize = true;
            this.txtHora.BackColor = System.Drawing.Color.Transparent;
            this.txtHora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHora.Location = new System.Drawing.Point(74, 135);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(0, 13);
            this.txtHora.TabIndex = 28;
            this.txtHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.BackColor = System.Drawing.Color.Transparent;
            this.txtFecha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFecha.Location = new System.Drawing.Point(74, 115);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(0, 13);
            this.txtFecha.TabIndex = 27;
            this.txtFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFuncion
            // 
            this.txtFuncion.AutoSize = true;
            this.txtFuncion.BackColor = System.Drawing.Color.Transparent;
            this.txtFuncion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFuncion.Location = new System.Drawing.Point(74, 95);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(0, 13);
            this.txtFuncion.TabIndex = 26;
            this.txtFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrigen
            // 
            this.txtOrigen.AutoSize = true;
            this.txtOrigen.BackColor = System.Drawing.Color.Transparent;
            this.txtOrigen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOrigen.Location = new System.Drawing.Point(74, 75);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(0, 13);
            this.txtOrigen.TabIndex = 25;
            this.txtOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo.Location = new System.Drawing.Point(74, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo.TabIndex = 24;
            this.txtCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(13, 135);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(34, 13);
            this.Label7.TabIndex = 23;
            this.Label7.Text = "Hora:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(13, 115);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(40, 13);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Fecha:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(13, 95);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 13);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Función:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(13, 75);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 13);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Orígen:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(13, 55);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 13);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Código:";
            // 
            // lnkMail
            // 
            this.lnkMail.AutoSize = true;
            this.lnkMail.BackColor = System.Drawing.Color.Transparent;
            this.lnkMail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMail.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkMail.Location = new System.Drawing.Point(10, 299);
            this.lnkMail.Name = "lnkMail";
            this.lnkMail.Size = new System.Drawing.Size(199, 13);
            this.lnkMail.TabIndex = 18;
            this.lnkMail.TabStop = true;
            this.lnkMail.Text = "Enviar un informe por correo electrónico";
            this.lnkMail.VisitedLinkColor = System.Drawing.Color.DarkGreen;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(13, 155);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(497, 121);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.Text = "";
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 325);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lnkMail);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.panTop);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmError";
            this.ShowInTaskbar = false;
            this.Text = "Error";
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panTop;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblSubtitulo;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Label txtHora;
        internal System.Windows.Forms.Label txtFecha;
        internal System.Windows.Forms.Label txtFuncion;
        internal System.Windows.Forms.Label txtOrigen;
        internal System.Windows.Forms.Label txtCodigo;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.LinkLabel lnkMail;
        internal System.Windows.Forms.RichTextBox txtDescripcion;
    }
}