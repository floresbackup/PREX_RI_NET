<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreLogin = New DevExpress.XtraEditors.TextEdit
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.lblLoginName = New DevExpress.XtraEditors.LabelControl
        Me.lblTip = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lblDominio = New DevExpress.XtraEditors.LabelControl
        Me.txtDominio = New DevExpress.XtraEditors.TextEdit
        Me.picProducto = New System.Windows.Forms.PictureBox
        CType(Me.txtNombreLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDominio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(191, 200)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(294, 200)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'txtNombreLogin
        '
        Me.txtNombreLogin.Location = New System.Drawing.Point(149, 104)
        Me.txtNombreLogin.Name = "txtNombreLogin"
        Me.txtNombreLogin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreLogin.Properties.Appearance.Options.UseFont = True
        Me.txtNombreLogin.Size = New System.Drawing.Size(242, 20)
        Me.txtNombreLogin.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Appearance.Options.UseBackColor = True
        Me.lblPassword.Location = New System.Drawing.Point(13, 133)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 13)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtPassword
        '
        Me.txtPassword.EditValue = ""
        Me.txtPassword.Location = New System.Drawing.Point(149, 130)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(242, 20)
        Me.txtPassword.TabIndex = 0
        '
        'lblLoginName
        '
        Me.lblLoginName.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginName.Appearance.Options.UseBackColor = True
        Me.lblLoginName.Location = New System.Drawing.Point(13, 107)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(130, 13)
        Me.lblLoginName.TabIndex = 7
        Me.lblLoginName.Text = "Nombre de inicio de sesión:"
        '
        'lblTip
        '
        Me.lblTip.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblTip.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.Appearance.Options.UseBackColor = True
        Me.lblTip.Appearance.Options.UseFont = True
        Me.lblTip.Location = New System.Drawing.Point(8, 79)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(378, 13)
        Me.lblTip.TabIndex = 11
        Me.lblTip.Text = "Proporcione su nombre de usuario y contraseña para iniciar sesión."
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(-84, 189)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(600, 2)
        Me.PanelControl1.TabIndex = 19
        '
        'lblDominio
        '
        Me.lblDominio.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblDominio.Appearance.Options.UseBackColor = True
        Me.lblDominio.Location = New System.Drawing.Point(13, 159)
        Me.lblDominio.Name = "lblDominio"
        Me.lblDominio.Size = New System.Drawing.Size(41, 13)
        Me.lblDominio.TabIndex = 21
        Me.lblDominio.Text = "Dominio:"
        Me.lblDominio.Visible = False
        '
        'txtDominio
        '
        Me.txtDominio.Location = New System.Drawing.Point(149, 156)
        Me.txtDominio.Name = "txtDominio"
        Me.txtDominio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDominio.Properties.Appearance.Options.UseFont = True
        Me.txtDominio.Size = New System.Drawing.Size(242, 20)
        Me.txtDominio.TabIndex = 22
        Me.txtDominio.Visible = False
        '
        'picProducto
        '
        Me.picProducto.BackColor = System.Drawing.Color.Transparent
        Me.picProducto.ErrorImage = Nothing
        Me.picProducto.Image = CType(resources.GetObject("picProducto.Image"), System.Drawing.Image)
        Me.picProducto.Location = New System.Drawing.Point(0, -5)
        Me.picProducto.Name = "picProducto"
        Me.picProducto.Size = New System.Drawing.Size(402, 76)
        Me.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProducto.TabIndex = 18
        Me.picProducto.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(401, 238)
        Me.Controls.Add(Me.txtDominio)
        Me.Controls.Add(Me.lblDominio)
        Me.Controls.Add(Me.picProducto)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.txtNombreLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblLoginName)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        CType(Me.txtNombreLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDominio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreLogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLoginName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTip As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblDominio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDominio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picProducto As System.Windows.Forms.PictureBox
End Class
