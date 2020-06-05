<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioSesion))
		Me.UsernameLabel = New System.Windows.Forms.Label()
		Me.PasswordLabel = New System.Windows.Forms.Label()
		Me.txtUsuario = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.OK = New System.Windows.Forms.Button()
		Me.Cancel = New System.Windows.Forms.Button()
		Me.cboDominio = New System.Windows.Forms.ComboBox()
		Me.Panel = New System.Windows.Forms.Panel()
		Me.lblDescri = New System.Windows.Forms.Label()
		Me.lblHeader = New System.Windows.Forms.Label()
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.lblDominio = New System.Windows.Forms.Label()
		Me.lblEntidad = New System.Windows.Forms.Label()
		Me.cboEntidad = New System.Windows.Forms.ComboBox()
		Me.lblciti = New System.Windows.Forms.Label()
		Me.picOkCiberrark = New System.Windows.Forms.PictureBox()
		Me.picErrorCiberrark = New System.Windows.Forms.PictureBox()
		Me.pblCitiCiberrark = New System.Windows.Forms.Panel()
		Me.Panel.SuspendLayout()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picOkCiberrark, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picErrorCiberrark, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pblCitiCiberrark.SuspendLayout()
		Me.SuspendLayout()
		'
		'UsernameLabel
		'
		Me.UsernameLabel.Location = New System.Drawing.Point(16, 98)
		Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.UsernameLabel.Name = "UsernameLabel"
		Me.UsernameLabel.Size = New System.Drawing.Size(179, 28)
		Me.UsernameLabel.TabIndex = 6
		Me.UsernameLabel.Text = "&Nombre de usuario"
		Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PasswordLabel
		'
		Me.PasswordLabel.Location = New System.Drawing.Point(16, 130)
		Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.PasswordLabel.Name = "PasswordLabel"
		Me.PasswordLabel.Size = New System.Drawing.Size(159, 28)
		Me.PasswordLabel.TabIndex = 7
		Me.PasswordLabel.Text = "&Contraseña"
		Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtUsuario
		'
		Me.txtUsuario.Location = New System.Drawing.Point(196, 102)
		Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.Size = New System.Drawing.Size(425, 22)
		Me.txtUsuario.TabIndex = 0
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(196, 134)
		Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(425, 22)
		Me.txtPassword.TabIndex = 1
		Me.txtPassword.UseSystemPasswordChar = True
		'
		'OK
		'
		Me.OK.Location = New System.Drawing.Point(365, 238)
		Me.OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.OK.Name = "OK"
		Me.OK.Size = New System.Drawing.Size(125, 28)
		Me.OK.TabIndex = 4
		Me.OK.Text = "&Aceptar"
		'
		'Cancel
		'
		Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel.Location = New System.Drawing.Point(499, 238)
		Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Cancel.Name = "Cancel"
		Me.Cancel.Size = New System.Drawing.Size(125, 28)
		Me.Cancel.TabIndex = 5
		Me.Cancel.Text = "&Cancelar"
		'
		'cboDominio
		'
		Me.cboDominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDominio.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cboDominio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDominio.FormattingEnabled = True
		Me.cboDominio.Location = New System.Drawing.Point(196, 166)
		Me.cboDominio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cboDominio.Name = "cboDominio"
		Me.cboDominio.Size = New System.Drawing.Size(425, 25)
		Me.cboDominio.TabIndex = 2
		'
		'Panel
		'
		Me.Panel.BackColor = System.Drawing.Color.White
		Me.Panel.Controls.Add(Me.lblDescri)
		Me.Panel.Controls.Add(Me.lblHeader)
		Me.Panel.Controls.Add(Me.LogoPictureBox)
		Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel.Location = New System.Drawing.Point(0, 0)
		Me.Panel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Panel.Name = "Panel"
		Me.Panel.Size = New System.Drawing.Size(639, 84)
		Me.Panel.TabIndex = 7
		'
		'lblDescri
		'
		Me.lblDescri.AutoSize = True
		Me.lblDescri.Location = New System.Drawing.Point(48, 46)
		Me.lblDescri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblDescri.Name = "lblDescri"
		Me.lblDescri.Size = New System.Drawing.Size(302, 17)
		Me.lblDescri.TabIndex = 90
		Me.lblDescri.Text = "Ingrese su nombre de usuario y su contraseña"
		'
		'lblHeader
		'
		Me.lblHeader.AutoSize = True
		Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeader.Location = New System.Drawing.Point(16, 23)
		Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblHeader.Name = "lblHeader"
		Me.lblHeader.Size = New System.Drawing.Size(116, 23)
		Me.lblHeader.TabIndex = 0
		Me.lblHeader.Text = "Bienvenido"
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
		Me.LogoPictureBox.Location = New System.Drawing.Point(385, -10)
		Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(357, 169)
		Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.LogoPictureBox.TabIndex = 2
		Me.LogoPictureBox.TabStop = False
		'
		'lblDominio
		'
		Me.lblDominio.AutoSize = True
		Me.lblDominio.Location = New System.Drawing.Point(16, 170)
		Me.lblDominio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblDominio.Name = "lblDominio"
		Me.lblDominio.Size = New System.Drawing.Size(96, 17)
		Me.lblDominio.TabIndex = 8
		Me.lblDominio.Text = "Conectarse a:"
		'
		'lblEntidad
		'
		Me.lblEntidad.AutoSize = True
		Me.lblEntidad.Location = New System.Drawing.Point(16, 203)
		Me.lblEntidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblEntidad.Name = "lblEntidad"
		Me.lblEntidad.Size = New System.Drawing.Size(60, 17)
		Me.lblEntidad.TabIndex = 9
		Me.lblEntidad.Text = "Entidad:"
		'
		'cboEntidad
		'
		Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboEntidad.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cboEntidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboEntidad.FormattingEnabled = True
		Me.cboEntidad.Location = New System.Drawing.Point(196, 199)
		Me.cboEntidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cboEntidad.Name = "cboEntidad"
		Me.cboEntidad.Size = New System.Drawing.Size(425, 25)
		Me.cboEntidad.TabIndex = 3
		'
		'lblciti
		'
		Me.lblciti.AutoSize = True
		Me.lblciti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblciti.Location = New System.Drawing.Point(33, 16)
		Me.lblciti.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblciti.Name = "lblciti"
		Me.lblciti.Size = New System.Drawing.Size(137, 17)
		Me.lblciti.TabIndex = 10
		Me.lblciti.Text = "Conexión CyberRark"
		'
		'picOkCiberrark
		'
		Me.picOkCiberrark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picOkCiberrark.Image = CType(resources.GetObject("picOkCiberrark.Image"), System.Drawing.Image)
		Me.picOkCiberrark.Location = New System.Drawing.Point(5, 11)
		Me.picOkCiberrark.Margin = New System.Windows.Forms.Padding(4)
		Me.picOkCiberrark.Name = "picOkCiberrark"
		Me.picOkCiberrark.Size = New System.Drawing.Size(24, 24)
		Me.picOkCiberrark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picOkCiberrark.TabIndex = 11
		Me.picOkCiberrark.TabStop = False
		'
		'picErrorCiberrark
		'
		Me.picErrorCiberrark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picErrorCiberrark.Image = CType(resources.GetObject("picErrorCiberrark.Image"), System.Drawing.Image)
		Me.picErrorCiberrark.Location = New System.Drawing.Point(6, 11)
		Me.picErrorCiberrark.Margin = New System.Windows.Forms.Padding(4)
		Me.picErrorCiberrark.Name = "picErrorCiberrark"
		Me.picErrorCiberrark.Size = New System.Drawing.Size(24, 24)
		Me.picErrorCiberrark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picErrorCiberrark.TabIndex = 11
		Me.picErrorCiberrark.TabStop = False
		'
		'pblCitiCiberrark
		'
		Me.pblCitiCiberrark.Controls.Add(Me.picErrorCiberrark)
		Me.pblCitiCiberrark.Controls.Add(Me.lblciti)
		Me.pblCitiCiberrark.Controls.Add(Me.picOkCiberrark)
		Me.pblCitiCiberrark.Location = New System.Drawing.Point(12, 231)
		Me.pblCitiCiberrark.Name = "pblCitiCiberrark"
		Me.pblCitiCiberrark.Size = New System.Drawing.Size(322, 49)
		Me.pblCitiCiberrark.TabIndex = 12
		Me.pblCitiCiberrark.Visible = False
		'
		'frmInicioSesion
		'
		Me.AcceptButton = Me.OK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.Cancel
		Me.ClientSize = New System.Drawing.Size(639, 281)
		Me.Controls.Add(Me.pblCitiCiberrark)
		Me.Controls.Add(Me.lblEntidad)
		Me.Controls.Add(Me.cboEntidad)
		Me.Controls.Add(Me.lblDominio)
		Me.Controls.Add(Me.Panel)
		Me.Controls.Add(Me.cboDominio)
		Me.Controls.Add(Me.Cancel)
		Me.Controls.Add(Me.OK)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.txtUsuario)
		Me.Controls.Add(Me.PasswordLabel)
		Me.Controls.Add(Me.UsernameLabel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmInicioSesion"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Inicio de sesión"
		Me.Panel.ResumeLayout(False)
		Me.Panel.PerformLayout()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picOkCiberrark, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picErrorCiberrark, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pblCitiCiberrark.ResumeLayout(False)
		Me.pblCitiCiberrark.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents cboDominio As System.Windows.Forms.ComboBox
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescri As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblDominio As System.Windows.Forms.Label
    Friend WithEvents lblEntidad As System.Windows.Forms.Label
    Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
	Friend WithEvents lblciti As Label
	Friend WithEvents picOkCiberrark As PictureBox
	Friend WithEvents picErrorCiberrark As PictureBox
	Friend WithEvents pblCitiCiberrark As Panel
End Class
