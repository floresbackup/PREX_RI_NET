namespace Prex.Utils.Misc.Forms
{
	partial class FrmCopyFiles
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCopyFiles));
			this.lblProgreso = new System.Windows.Forms.Label();
			this.lblArchivo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProgreso
			// 
			this.lblProgreso.AutoSize = true;
			this.lblProgreso.Location = new System.Drawing.Point(12, 9);
			this.lblProgreso.Name = "lblProgreso";
			this.lblProgreso.Size = new System.Drawing.Size(529, 17);
			this.lblProgreso.TabIndex = 0;
			this.lblProgreso.Text = "Copiando [porcProgeso] archivos desde servidor . Aguarde un instante por favor..." +
    "";
			// 
			// lblArchivo
			// 
			this.lblArchivo.AutoSize = true;
			this.lblArchivo.Location = new System.Drawing.Point(12, 29);
			this.lblArchivo.Name = "lblArchivo";
			this.lblArchivo.Size = new System.Drawing.Size(185, 17);
			this.lblArchivo.TabIndex = 1;
			this.lblArchivo.Text = "Copiando archivo [fileName]";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(95, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(309, 125);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// FrmCopyFiles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(556, 186);
			this.ControlBox = false;
			this.Controls.Add(this.lblArchivo);
			this.Controls.Add(this.lblProgreso);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmCopyFiles";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Copiando...";
			this.Load += new System.EventHandler(this.FrmCopyFiles_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblProgreso;
		private System.Windows.Forms.Label lblArchivo;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}