<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicenseKey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLicenseKey))
        Me.lbl004 = New DevExpress.XtraEditors.LabelControl
        Me.lbl001 = New DevExpress.XtraEditors.LabelControl
        Me.lbl002 = New DevExpress.XtraEditors.LabelControl
        Me.txtAuthenticationKey = New DevExpress.XtraEditors.TextEdit
        Me.txtLicenseKey = New DevExpress.XtraEditors.TextEdit
        Me.lbl003 = New DevExpress.XtraEditors.LabelControl
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblAppStatus = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtAuthenticationKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLicenseKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl004
        '
        Me.lbl004.Location = New System.Drawing.Point(12, 204)
        Me.lbl004.Name = "lbl004"
        Me.lbl004.Size = New System.Drawing.Size(128, 13)
        Me.lbl004.TabIndex = 0
        Me.lbl004.Text = "Current application status:"
        '
        'lbl001
        '
        Me.lbl001.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl001.Location = New System.Drawing.Point(12, 50)
        Me.lbl001.Name = "lbl001"
        Me.lbl001.Size = New System.Drawing.Size(445, 26)
        Me.lbl001.TabIndex = 1
        Me.lbl001.Text = "Please enter the license key in the corresnponding textbox. If you don't have a l" & _
            "icense key, please contact EDR Software to obtain it, based upon this authentica" & _
            "tion key."
        '
        'lbl002
        '
        Me.lbl002.Location = New System.Drawing.Point(33, 103)
        Me.lbl002.Name = "lbl002"
        Me.lbl002.Size = New System.Drawing.Size(95, 13)
        Me.lbl002.TabIndex = 2
        Me.lbl002.Text = "Authentication KEY:"
        '
        'txtAuthenticationKey
        '
        Me.txtAuthenticationKey.Location = New System.Drawing.Point(165, 100)
        Me.txtAuthenticationKey.Name = "txtAuthenticationKey"
        Me.txtAuthenticationKey.Properties.ReadOnly = True
        Me.txtAuthenticationKey.Size = New System.Drawing.Size(254, 20)
        Me.txtAuthenticationKey.TabIndex = 3
        '
        'txtLicenseKey
        '
        Me.txtLicenseKey.Location = New System.Drawing.Point(165, 126)
        Me.txtLicenseKey.Name = "txtLicenseKey"
        Me.txtLicenseKey.Size = New System.Drawing.Size(254, 20)
        Me.txtLicenseKey.TabIndex = 5
        '
        'lbl003
        '
        Me.lbl003.Location = New System.Drawing.Point(33, 129)
        Me.lbl003.Name = "lbl003"
        Me.lbl003.Size = New System.Drawing.Size(60, 13)
        Me.lbl003.TabIndex = 4
        Me.lbl003.Text = "License KEY:"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(354, 204)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(97, 26)
        Me.cmdOK.TabIndex = 6
        Me.cmdOK.Text = "OK"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(457, 204)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(434, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(147, 19)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Qualitas Licensing"
        '
        'lblAppStatus
        '
        Me.lblAppStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppStatus.Appearance.Options.UseFont = True
        Me.lblAppStatus.Location = New System.Drawing.Point(146, 204)
        Me.lblAppStatus.Name = "lblAppStatus"
        Me.lblAppStatus.Size = New System.Drawing.Size(67, 13)
        Me.lblAppStatus.TabIndex = 10
        Me.lblAppStatus.Text = "DEMO MODE"
        '
        'frmLicenseKey
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(566, 242)
        Me.Controls.Add(Me.lblAppStatus)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtLicenseKey)
        Me.Controls.Add(Me.lbl003)
        Me.Controls.Add(Me.txtAuthenticationKey)
        Me.Controls.Add(Me.lbl002)
        Me.Controls.Add(Me.lbl001)
        Me.Controls.Add(Me.lbl004)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLicenseKey"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "License key"
        CType(Me.txtAuthenticationKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLicenseKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl004 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl001 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl002 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAuthenticationKey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLicenseKey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl003 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAppStatus As DevExpress.XtraEditors.LabelControl
End Class
