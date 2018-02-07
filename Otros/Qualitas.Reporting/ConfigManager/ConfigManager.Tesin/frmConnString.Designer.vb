<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnString
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnString))
        Me.cmdGenerarCadena = New DevExpress.XtraEditors.SimpleButton
        Me.txtCadena = New DevExpress.XtraEditors.MemoEdit
        Me.lblCadena = New DevExpress.XtraEditors.LabelControl
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRestoreDB = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtCadena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGenerarCadena
        '
        Me.cmdGenerarCadena.Image = CType(resources.GetObject("cmdGenerarCadena.Image"), System.Drawing.Image)
        Me.cmdGenerarCadena.Location = New System.Drawing.Point(12, 296)
        Me.cmdGenerarCadena.Name = "cmdGenerarCadena"
        Me.cmdGenerarCadena.Size = New System.Drawing.Size(180, 26)
        Me.cmdGenerarCadena.TabIndex = 6
        Me.cmdGenerarCadena.Text = "Build connection string..."
        '
        'txtCadena
        '
        Me.txtCadena.Location = New System.Drawing.Point(12, 171)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(549, 108)
        Me.txtCadena.TabIndex = 5
        '
        'lblCadena
        '
        Me.lblCadena.Appearance.Options.UseTextOptions = True
        Me.lblCadena.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCadena.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblCadena.Location = New System.Drawing.Point(12, 107)
        Me.lblCadena.Name = "lblCadena"
        Me.lblCadena.Size = New System.Drawing.Size(549, 26)
        Me.lblCadena.TabIndex = 7
        Me.lblCadena.Text = "Specify the connection string to connect to the local database. Take note that mo" & _
            "difying this connection string may change authentication key and produce and inv" & _
            "alid license key."
        '
        'cmdOK
        '
        Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
        Me.cmdOK.Location = New System.Drawing.Point(361, 296)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(97, 26)
        Me.cmdOK.TabIndex = 8
        Me.cmdOK.Text = "OK"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(464, 296)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdRestoreDB
        '
        Me.cmdRestoreDB.Image = CType(resources.GetObject("cmdRestoreDB.Image"), System.Drawing.Image)
        Me.cmdRestoreDB.Location = New System.Drawing.Point(196, 64)
        Me.cmdRestoreDB.Name = "cmdRestoreDB"
        Me.cmdRestoreDB.Size = New System.Drawing.Size(180, 26)
        Me.cmdRestoreDB.TabIndex = 10
        Me.cmdRestoreDB.Text = "Restore original database..."
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(549, 39)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = resources.GetString("LabelControl1.Text")
        '
        'pc001
        '
        Me.pc001.Location = New System.Drawing.Point(-314, 98)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(1200, 2)
        Me.pc001.TabIndex = 22
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(12, 139)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(549, 26)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "NOTE: Connection string must use OLEDB provider in order to connect succesfully t" & _
            "o local database"
        '
        'frmConnString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 334)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.pc001)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdRestoreDB)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdGenerarCadena)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.lblCadena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnString"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Local database connection"
        CType(Me.txtCadena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdGenerarCadena As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCadena As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblCadena As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRestoreDB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
