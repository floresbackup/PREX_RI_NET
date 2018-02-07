<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestoreDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestoreDB))
        Me.lblServerName = New DevExpress.XtraEditors.LabelControl
        Me.lblAuthentication = New DevExpress.XtraEditors.LabelControl
        Me.txtServerName = New DevExpress.XtraEditors.TextEdit
        Me.optWindows = New DevExpress.XtraEditors.CheckEdit
        Me.optSQL = New DevExpress.XtraEditors.CheckEdit
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit
        Me.lblUserName = New DevExpress.XtraEditors.LabelControl
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl
        Me.cmdConnect = New DevExpress.XtraEditors.SimpleButton
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.lblRestoreInfo = New DevExpress.XtraEditors.LabelControl
        Me.txtBackupFile = New DevExpress.XtraEditors.TextEdit
        Me.lblBackupFile = New DevExpress.XtraEditors.LabelControl
        Me.txtDBName = New DevExpress.XtraEditors.TextEdit
        Me.lblDBName = New DevExpress.XtraEditors.LabelControl
        Me.txtDataFile = New DevExpress.XtraEditors.TextEdit
        Me.lblDataFile = New DevExpress.XtraEditors.LabelControl
        Me.txtLogFile = New DevExpress.XtraEditors.TextEdit
        Me.lblLogFile = New DevExpress.XtraEditors.LabelControl
        Me.chkForceRestore = New DevExpress.XtraEditors.CheckEdit
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtServerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optWindows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBackupFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDBName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkForceRestore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblServerName
        '
        Me.lblServerName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerName.Appearance.Options.UseFont = True
        Me.lblServerName.Location = New System.Drawing.Point(18, 25)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(87, 13)
        Me.lblServerName.TabIndex = 4
        Me.lblServerName.Text = "SQL Server name:"
        '
        'lblAuthentication
        '
        Me.lblAuthentication.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthentication.Appearance.Options.UseFont = True
        Me.lblAuthentication.Location = New System.Drawing.Point(18, 57)
        Me.lblAuthentication.Name = "lblAuthentication"
        Me.lblAuthentication.Size = New System.Drawing.Size(84, 13)
        Me.lblAuthentication.TabIndex = 5
        Me.lblAuthentication.Text = "Authentication"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(140, 22)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(302, 20)
        Me.txtServerName.TabIndex = 6
        '
        'optWindows
        '
        Me.optWindows.EditValue = True
        Me.optWindows.Location = New System.Drawing.Point(42, 85)
        Me.optWindows.Name = "optWindows"
        Me.optWindows.Properties.Caption = "Windows authentication"
        Me.optWindows.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.optWindows.Properties.RadioGroupIndex = 0
        Me.optWindows.Size = New System.Drawing.Size(170, 19)
        Me.optWindows.TabIndex = 7
        '
        'optSQL
        '
        Me.optSQL.Location = New System.Drawing.Point(42, 110)
        Me.optSQL.Name = "optSQL"
        Me.optSQL.Properties.Caption = "SQL Server authentication"
        Me.optSQL.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.optSQL.Properties.RadioGroupIndex = 0
        Me.optSQL.Size = New System.Drawing.Size(170, 19)
        Me.optSQL.TabIndex = 8
        Me.optSQL.TabStop = False
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(140, 145)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(184, 20)
        Me.txtUserName.TabIndex = 10
        '
        'lblUserName
        '
        Me.lblUserName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Appearance.Options.UseFont = True
        Me.lblUserName.Enabled = False
        Me.lblUserName.Location = New System.Drawing.Point(59, 148)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(55, 13)
        Me.lblUserName.TabIndex = 9
        Me.lblUserName.Text = "User name:"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(140, 171)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(184, 20)
        Me.txtPassword.TabIndex = 12
        '
        'lblPassword
        '
        Me.lblPassword.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Appearance.Options.UseFont = True
        Me.lblPassword.Enabled = False
        Me.lblPassword.Location = New System.Drawing.Point(59, 174)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(50, 13)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Password:"
        '
        'cmdConnect
        '
        Me.cmdConnect.Image = CType(resources.GetObject("cmdConnect.Image"), System.Drawing.Image)
        Me.cmdConnect.Location = New System.Drawing.Point(339, 165)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(103, 26)
        Me.cmdConnect.TabIndex = 13
        Me.cmdConnect.Text = "Connect"
        '
        'pc001
        '
        Me.pc001.Location = New System.Drawing.Point(-371, 199)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(1200, 2)
        Me.pc001.TabIndex = 23
        '
        'lblRestoreInfo
        '
        Me.lblRestoreInfo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestoreInfo.Appearance.Options.UseFont = True
        Me.lblRestoreInfo.Enabled = False
        Me.lblRestoreInfo.Location = New System.Drawing.Point(18, 221)
        Me.lblRestoreInfo.Name = "lblRestoreInfo"
        Me.lblRestoreInfo.Size = New System.Drawing.Size(114, 13)
        Me.lblRestoreInfo.TabIndex = 24
        Me.lblRestoreInfo.Text = "Restore information"
        '
        'txtBackupFile
        '
        Me.txtBackupFile.Enabled = False
        Me.txtBackupFile.Location = New System.Drawing.Point(140, 252)
        Me.txtBackupFile.Name = "txtBackupFile"
        Me.txtBackupFile.Size = New System.Drawing.Size(302, 20)
        Me.txtBackupFile.TabIndex = 26
        '
        'lblBackupFile
        '
        Me.lblBackupFile.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackupFile.Appearance.Options.UseFont = True
        Me.lblBackupFile.Enabled = False
        Me.lblBackupFile.Location = New System.Drawing.Point(18, 255)
        Me.lblBackupFile.Name = "lblBackupFile"
        Me.lblBackupFile.Size = New System.Drawing.Size(84, 13)
        Me.lblBackupFile.TabIndex = 25
        Me.lblBackupFile.Text = "Backup file name:"
        '
        'txtDBName
        '
        Me.txtDBName.Enabled = False
        Me.txtDBName.Location = New System.Drawing.Point(140, 278)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(184, 20)
        Me.txtDBName.TabIndex = 28
        '
        'lblDBName
        '
        Me.lblDBName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBName.Appearance.Options.UseFont = True
        Me.lblDBName.Enabled = False
        Me.lblDBName.Location = New System.Drawing.Point(18, 281)
        Me.lblDBName.Name = "lblDBName"
        Me.lblDBName.Size = New System.Drawing.Size(79, 13)
        Me.lblDBName.TabIndex = 27
        Me.lblDBName.Text = "Database name:"
        '
        'txtDataFile
        '
        Me.txtDataFile.Enabled = False
        Me.txtDataFile.Location = New System.Drawing.Point(140, 304)
        Me.txtDataFile.Name = "txtDataFile"
        Me.txtDataFile.Size = New System.Drawing.Size(302, 20)
        Me.txtDataFile.TabIndex = 30
        '
        'lblDataFile
        '
        Me.lblDataFile.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFile.Appearance.Options.UseFont = True
        Me.lblDataFile.Enabled = False
        Me.lblDataFile.Location = New System.Drawing.Point(18, 307)
        Me.lblDataFile.Name = "lblDataFile"
        Me.lblDataFile.Size = New System.Drawing.Size(115, 13)
        Me.lblDataFile.TabIndex = 29
        Me.lblDataFile.Text = "Restore Data file to (*):"
        '
        'txtLogFile
        '
        Me.txtLogFile.Enabled = False
        Me.txtLogFile.Location = New System.Drawing.Point(140, 330)
        Me.txtLogFile.Name = "txtLogFile"
        Me.txtLogFile.Size = New System.Drawing.Size(302, 20)
        Me.txtLogFile.TabIndex = 32
        '
        'lblLogFile
        '
        Me.lblLogFile.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogFile.Appearance.Options.UseFont = True
        Me.lblLogFile.Enabled = False
        Me.lblLogFile.Location = New System.Drawing.Point(18, 333)
        Me.lblLogFile.Name = "lblLogFile"
        Me.lblLogFile.Size = New System.Drawing.Size(109, 13)
        Me.lblLogFile.TabIndex = 31
        Me.lblLogFile.Text = "Restore Log file to (*):"
        '
        'chkForceRestore
        '
        Me.chkForceRestore.Enabled = False
        Me.chkForceRestore.Location = New System.Drawing.Point(12, 365)
        Me.chkForceRestore.Name = "chkForceRestore"
        Me.chkForceRestore.Properties.Caption = "Force restore over existing database"
        Me.chkForceRestore.Size = New System.Drawing.Size(222, 19)
        Me.chkForceRestore.TabIndex = 33
        '
        'cmdOK
        '
        Me.cmdOK.Enabled = False
        Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
        Me.cmdOK.Location = New System.Drawing.Point(242, 411)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(97, 26)
        Me.cmdOK.TabIndex = 34
        Me.cmdOK.Text = "OK"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(345, 411)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancel.TabIndex = 35
        Me.cmdCancel.Text = "Cancel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 415)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(133, 13)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "(*) SQL Server phisical path"
        '
        'frmRestoreDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 448)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.chkForceRestore)
        Me.Controls.Add(Me.txtLogFile)
        Me.Controls.Add(Me.lblLogFile)
        Me.Controls.Add(Me.txtDataFile)
        Me.Controls.Add(Me.lblDataFile)
        Me.Controls.Add(Me.txtDBName)
        Me.Controls.Add(Me.lblDBName)
        Me.Controls.Add(Me.txtBackupFile)
        Me.Controls.Add(Me.lblBackupFile)
        Me.Controls.Add(Me.lblRestoreInfo)
        Me.Controls.Add(Me.pc001)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.optSQL)
        Me.Controls.Add(Me.optWindows)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.lblAuthentication)
        Me.Controls.Add(Me.lblServerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRestoreDB"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore initial local database"
        CType(Me.txtServerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optWindows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBackupFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDBName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkForceRestore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblServerName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAuthentication As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents optWindows As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents optSQL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdConnect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblRestoreInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBackupFile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBackupFile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDBName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDBName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDataFile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDataFile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLogFile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLogFile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkForceRestore As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
