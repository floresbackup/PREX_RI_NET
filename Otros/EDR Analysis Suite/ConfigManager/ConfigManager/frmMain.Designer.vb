<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl
        Me.lblSubTitulo = New DevExpress.XtraEditors.LabelControl
        Me.lblStep01 = New DevExpress.XtraEditors.LabelControl
        Me.cmdConfigureConnection = New DevExpress.XtraEditors.SimpleButton
        Me.txtConnString = New DevExpress.XtraEditors.MemoEdit
        Me.cmdLicenseKey = New DevExpress.XtraEditors.SimpleButton
        Me.lblStep02 = New DevExpress.XtraEditors.LabelControl
        Me.cmdAddConnections = New DevExpress.XtraEditors.SimpleButton
        Me.lblStep03 = New DevExpress.XtraEditors.LabelControl
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConnString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(405, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(209, 61)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(302, 19)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Licensing and Configuration Manager"
        '
        'lblSubTitulo
        '
        Me.lblSubTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblSubTitulo.Location = New System.Drawing.Point(12, 37)
        Me.lblSubTitulo.Name = "lblSubTitulo"
        Me.lblSubTitulo.Size = New System.Drawing.Size(377, 26)
        Me.lblSubTitulo.TabIndex = 2
        Me.lblSubTitulo.Text = "Use this tool to add licences to use new database connections. You can also confi" & _
            "gure the connection string to connect to the application local database."
        '
        'lblStep01
        '
        Me.lblStep01.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep01.Appearance.Options.UseFont = True
        Me.lblStep01.Location = New System.Drawing.Point(12, 87)
        Me.lblStep01.Name = "lblStep01"
        Me.lblStep01.Size = New System.Drawing.Size(36, 13)
        Me.lblStep01.TabIndex = 3
        Me.lblStep01.Text = "Step 1"
        '
        'cmdConfigureConnection
        '
        Me.cmdConfigureConnection.Image = CType(resources.GetObject("cmdConfigureConnection.Image"), System.Drawing.Image)
        Me.cmdConfigureConnection.Location = New System.Drawing.Point(12, 106)
        Me.cmdConfigureConnection.Name = "cmdConfigureConnection"
        Me.cmdConfigureConnection.Size = New System.Drawing.Size(253, 30)
        Me.cmdConfigureConnection.TabIndex = 4
        Me.cmdConfigureConnection.Text = "Configure local database connection string"
        '
        'txtConnString
        '
        Me.txtConnString.Enabled = False
        Me.txtConnString.Location = New System.Drawing.Point(12, 142)
        Me.txtConnString.Name = "txtConnString"
        Me.txtConnString.Size = New System.Drawing.Size(592, 49)
        Me.txtConnString.TabIndex = 5
        '
        'cmdLicenseKey
        '
        Me.cmdLicenseKey.Image = CType(resources.GetObject("cmdLicenseKey.Image"), System.Drawing.Image)
        Me.cmdLicenseKey.Location = New System.Drawing.Point(12, 223)
        Me.cmdLicenseKey.Name = "cmdLicenseKey"
        Me.cmdLicenseKey.Size = New System.Drawing.Size(192, 30)
        Me.cmdLicenseKey.TabIndex = 7
        Me.cmdLicenseKey.Text = "Configure your license key..."
        '
        'lblStep02
        '
        Me.lblStep02.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep02.Appearance.Options.UseFont = True
        Me.lblStep02.Location = New System.Drawing.Point(12, 204)
        Me.lblStep02.Name = "lblStep02"
        Me.lblStep02.Size = New System.Drawing.Size(36, 13)
        Me.lblStep02.TabIndex = 6
        Me.lblStep02.Text = "Step 2"
        '
        'cmdAddConnections
        '
        Me.cmdAddConnections.Image = CType(resources.GetObject("cmdAddConnections.Image"), System.Drawing.Image)
        Me.cmdAddConnections.Location = New System.Drawing.Point(387, 223)
        Me.cmdAddConnections.Name = "cmdAddConnections"
        Me.cmdAddConnections.Size = New System.Drawing.Size(217, 30)
        Me.cmdAddConnections.TabIndex = 9
        Me.cmdAddConnections.Text = "Configure additional connections..."
        Me.cmdAddConnections.Visible = False
        '
        'lblStep03
        '
        Me.lblStep03.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep03.Appearance.Options.UseFont = True
        Me.lblStep03.Location = New System.Drawing.Point(568, 204)
        Me.lblStep03.Name = "lblStep03"
        Me.lblStep03.Size = New System.Drawing.Size(36, 13)
        Me.lblStep03.TabIndex = 8
        Me.lblStep03.Text = "Step 3"
        Me.lblStep03.Visible = False
        '
        'pc001
        '
        Me.pc001.Location = New System.Drawing.Point(-71, 272)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(1200, 2)
        Me.pc001.TabIndex = 21
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(507, 290)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(97, 26)
        Me.cmdClose.TabIndex = 20
        Me.cmdClose.Text = "Close"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(616, 332)
        Me.Controls.Add(Me.pc001)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAddConnections)
        Me.Controls.Add(Me.lblStep03)
        Me.Controls.Add(Me.cmdLicenseKey)
        Me.Controls.Add(Me.lblStep02)
        Me.Controls.Add(Me.txtConnString)
        Me.Controls.Add(Me.cmdConfigureConnection)
        Me.Controls.Add(Me.lblStep01)
        Me.Controls.Add(Me.lblSubTitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Infinitus - Licensing and configuration Manager"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConnString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSubTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStep01 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdConfigureConnection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtConnString As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdLicenseKey As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblStep02 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAddConnections As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblStep03 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
End Class
