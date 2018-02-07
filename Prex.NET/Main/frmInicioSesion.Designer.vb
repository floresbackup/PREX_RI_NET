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
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.cboDominio = New System.Windows.Forms.ComboBox
        Me.Panel = New System.Windows.Forms.Panel
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblDescri = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.lblDominio = New System.Windows.Forms.Label
        Me.lblEntidad = New System.Windows.Forms.Label
        Me.cboEntidad = New System.Windows.Forms.ComboBox
        Me.Panel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 80)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(134, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 106)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(119, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(147, 83)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(320, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(147, 109)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(320, 20)
        Me.txtPassword.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(274, 193)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Aceptar"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(374, 193)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancelar"
        '
        'cboDominio
        '
        Me.cboDominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDominio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDominio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDominio.FormattingEnabled = True
        Me.cboDominio.Location = New System.Drawing.Point(147, 135)
        Me.cboDominio.Name = "cboDominio"
        Me.cboDominio.Size = New System.Drawing.Size(320, 21)
        Me.cboDominio.TabIndex = 6
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.Controls.Add(Me.lblDescri)
        Me.Panel.Controls.Add(Me.lblHeader)
        Me.Panel.Controls.Add(Me.LogoPictureBox)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(479, 68)
        Me.Panel.TabIndex = 7
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 19)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(91, 18)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Bienvenido"
        '
        'lblDescri
        '
        Me.lblDescri.AutoSize = True
        Me.lblDescri.Location = New System.Drawing.Point(36, 37)
        Me.lblDescri.Name = "lblDescri"
        Me.lblDescri.Size = New System.Drawing.Size(224, 13)
        Me.lblDescri.TabIndex = 1
        Me.lblDescri.Text = "Ingrese su nombre de usuario y su contraseña"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(289, -8)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(268, 137)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 2
        Me.LogoPictureBox.TabStop = False
        '
        'lblDominio
        '
        Me.lblDominio.AutoSize = True
        Me.lblDominio.Location = New System.Drawing.Point(12, 138)
        Me.lblDominio.Name = "lblDominio"
        Me.lblDominio.Size = New System.Drawing.Size(73, 13)
        Me.lblDominio.TabIndex = 8
        Me.lblDominio.Text = "Conectarse a:"
        '
        'lblEntidad
        '
        Me.lblEntidad.AutoSize = True
        Me.lblEntidad.Location = New System.Drawing.Point(12, 165)
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(46, 13)
        Me.lblEntidad.TabIndex = 10
        Me.lblEntidad.Text = "Entidad:"
        '
        'cboEntidad
        '
        Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEntidad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboEntidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEntidad.FormattingEnabled = True
        Me.cboEntidad.Location = New System.Drawing.Point(147, 162)
        Me.cboEntidad.Name = "cboEntidad"
        Me.cboEntidad.Size = New System.Drawing.Size(320, 21)
        Me.cboEntidad.TabIndex = 9
        '
        'frmInicioSesion
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(479, 228)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicioSesion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
