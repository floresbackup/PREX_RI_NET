<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.cmdWeb = New DevExpress.XtraEditors.SimpleButton
        Me.lblInfoPropiedad = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lblCopyright = New DevExpress.XtraEditors.LabelControl
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.picProducto = New System.Windows.Forms.PictureBox
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.cmdWeb)
        Me.pc001.Controls.Add(Me.lblInfoPropiedad)
        Me.pc001.Controls.Add(Me.LabelControl3)
        Me.pc001.Controls.Add(Me.LabelControl4)
        Me.pc001.Controls.Add(Me.LabelControl1)
        Me.pc001.Controls.Add(Me.LabelControl2)
        Me.pc001.Controls.Add(Me.lblCopyright)
        Me.pc001.Controls.Add(Me.lblVersion)
        Me.pc001.Controls.Add(Me.cmdOk)
        Me.pc001.Controls.Add(Me.picLogo)
        Me.pc001.Controls.Add(Me.picProducto)
        Me.pc001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pc001.Location = New System.Drawing.Point(0, 0)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(556, 291)
        Me.pc001.TabIndex = 16
        '
        'cmdWeb
        '
        Me.cmdWeb.Location = New System.Drawing.Point(427, 109)
        Me.cmdWeb.Name = "cmdWeb"
        Me.cmdWeb.Size = New System.Drawing.Size(124, 28)
        Me.cmdWeb.TabIndex = 25
        Me.cmdWeb.Text = "www.tqcorp.com"
        Me.cmdWeb.Visible = False
        '
        'lblInfoPropiedad
        '
        Me.lblInfoPropiedad.Location = New System.Drawing.Point(12, 264)
        Me.lblInfoPropiedad.Name = "lblInfoPropiedad"
        Me.lblInfoPropiedad.Size = New System.Drawing.Size(358, 13)
        Me.lblInfoPropiedad.TabIndex = 28
        Me.lblInfoPropiedad.Text = "Registrado ante el RPI bajo expediente nro. 653217. República Argentina."
        '
        'LabelControl3
        '
        Me.LabelControl3.AutoEllipsis = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 162)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(211, 13)
        Me.LabelControl3.TabIndex = 27
        Me.LabelControl3.Text = "Versión para Microsoft  .NET Framework 2.0"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 143)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(144, 13)
        Me.LabelControl4.TabIndex = 26
        Me.LabelControl4.Text = "Información de la versión"
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoEllipsis = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(12, 206)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(358, 52)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = resources.GetString("LabelControl1.Text")
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 187)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(144, 13)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "Información de Copyright"
        '
        'lblCopyright
        '
        Me.lblCopyright.Location = New System.Drawing.Point(12, 124)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(371, 13)
        Me.lblCopyright.TabIndex = 21
        Me.lblCopyright.Text = "Todos los derechos reservados. EDR Software 2008@. Patente nro. 653217."
        '
        'lblVersion
        '
        Me.lblVersion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Appearance.Options.UseFont = True
        Me.lblVersion.Location = New System.Drawing.Point(12, 105)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(42, 13)
        Me.lblVersion.TabIndex = 20
        Me.lblVersion.Text = "Versión"
        '
        'cmdOk
        '
        Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOk.Location = New System.Drawing.Point(427, 249)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(124, 28)
        Me.cmdOk.TabIndex = 18
        Me.cmdOk.Text = "Cerrar"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.ErrorImage = Nothing
        Me.picLogo.Location = New System.Drawing.Point(454, 5)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(97, 132)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 16
        Me.picLogo.TabStop = False
        '
        'picProducto
        '
        Me.picProducto.BackColor = System.Drawing.Color.Transparent
        Me.picProducto.ErrorImage = Nothing
        Me.picProducto.Location = New System.Drawing.Point(5, 5)
        Me.picProducto.Name = "picProducto"
        Me.picProducto.Size = New System.Drawing.Size(443, 93)
        Me.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProducto.TabIndex = 17
        Me.picProducto.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 291)
        Me.Controls.Add(Me.pc001)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de EDR Analysis Suite"
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        Me.pc001.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdWeb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblInfoPropiedad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCopyright As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picProducto As System.Windows.Forms.PictureBox
End Class
