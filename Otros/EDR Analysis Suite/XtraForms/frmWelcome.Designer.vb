<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.pcBottom = New DevExpress.XtraEditors.PanelControl
        Me.lblDemo = New DevExpress.XtraEditors.LabelControl
        Me.pic001 = New System.Windows.Forms.PictureBox
        Me.pic002 = New System.Windows.Forms.PictureBox
        CType(Me.pcBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcBottom.SuspendLayout()
        CType(Me.pic001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic002, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcBottom
        '
        Me.pcBottom.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pcBottom.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.pcBottom.Appearance.Options.UseBackColor = True
        Me.pcBottom.Appearance.Options.UseBorderColor = True
        Me.pcBottom.Controls.Add(Me.lblDemo)
        Me.pcBottom.Controls.Add(Me.pic001)
        Me.pcBottom.Controls.Add(Me.pic002)
        Me.pcBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pcBottom.Location = New System.Drawing.Point(0, 347)
        Me.pcBottom.Name = "pcBottom"
        Me.pcBottom.Size = New System.Drawing.Size(646, 48)
        Me.pcBottom.TabIndex = 0
        '
        'lblDemo
        '
        Me.lblDemo.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDemo.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblDemo.Appearance.Options.UseFont = True
        Me.lblDemo.Appearance.Options.UseForeColor = True
        Me.lblDemo.Appearance.Options.UseTextOptions = True
        Me.lblDemo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblDemo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDemo.Location = New System.Drawing.Point(184, 2)
        Me.lblDemo.Name = "lblDemo"
        Me.lblDemo.Size = New System.Drawing.Size(278, 44)
        Me.lblDemo.TabIndex = 2
        Me.lblDemo.Text = "DEMO"
        '
        'pic001
        '
        Me.pic001.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic001.Location = New System.Drawing.Point(2, 2)
        Me.pic001.Name = "pic001"
        Me.pic001.Size = New System.Drawing.Size(182, 44)
        Me.pic001.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic001.TabIndex = 0
        Me.pic001.TabStop = False
        '
        'pic002
        '
        Me.pic002.Dock = System.Windows.Forms.DockStyle.Right
        Me.pic002.Location = New System.Drawing.Point(462, 2)
        Me.pic002.Name = "pic002"
        Me.pic002.Size = New System.Drawing.Size(182, 44)
        Me.pic002.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic002.TabIndex = 1
        Me.pic002.TabStop = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 395)
        Me.Controls.Add(Me.pcBottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmWelcome"
        Me.ShowInTaskbar = False
        Me.Text = "Bienvenido"
        CType(Me.pcBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcBottom.ResumeLayout(False)
        CType(Me.pic001, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcBottom As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pic001 As System.Windows.Forms.PictureBox
    Friend WithEvents pic002 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDemo As DevExpress.XtraEditors.LabelControl
End Class
