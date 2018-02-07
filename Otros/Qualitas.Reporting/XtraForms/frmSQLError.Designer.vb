<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQLError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSQLError))
        Me.Tabs = New DevExpress.XtraTab.XtraTabControl
        Me.tpError = New DevExpress.XtraTab.XtraTabPage
        Me.txtError = New DevExpress.XtraEditors.MemoEdit
        Me.tpSQL = New DevExpress.XtraTab.XtraTabPage
        Me.txtSQL = New DevExpress.XtraEditors.MemoEdit
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCopy = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.tpError.SuspendLayout()
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSQL.SuspendLayout()
        CType(Me.txtSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Location = New System.Drawing.Point(3, 3)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedTabPage = Me.tpError
        Me.Tabs.Size = New System.Drawing.Size(491, 277)
        Me.Tabs.TabIndex = 0
        Me.Tabs.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpError, Me.tpSQL})
        '
        'tpError
        '
        Me.tpError.Controls.Add(Me.txtError)
        Me.tpError.Name = "tpError"
        Me.tpError.Size = New System.Drawing.Size(482, 246)
        Me.tpError.Text = "Error"
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(6, 3)
        Me.txtError.Name = "txtError"
        Me.txtError.Properties.ReadOnly = True
        Me.txtError.Size = New System.Drawing.Size(472, 240)
        Me.txtError.TabIndex = 0
        '
        'tpSQL
        '
        Me.tpSQL.Controls.Add(Me.txtSQL)
        Me.tpSQL.Name = "tpSQL"
        Me.tpSQL.Size = New System.Drawing.Size(482, 246)
        Me.tpSQL.Text = "SQL"
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(6, 3)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQL.Properties.Appearance.Options.UseFont = True
        Me.txtSQL.Properties.ReadOnly = True
        Me.txtSQL.Size = New System.Drawing.Size(472, 240)
        Me.txtSQL.TabIndex = 1
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(395, 285)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(95, 28)
        Me.cmdCerrar.TabIndex = 10
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdCopy
        '
        Me.cmdCopy.Image = CType(resources.GetObject("cmdCopy.Image"), System.Drawing.Image)
        Me.cmdCopy.Location = New System.Drawing.Point(359, 285)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(30, 28)
        Me.cmdCopy.TabIndex = 11
        Me.cmdCopy.Visible = False
        '
        'frmSQLError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(496, 321)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.Tabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSQLError"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Error"
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.tpError.ResumeLayout(False)
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSQL.ResumeLayout(False)
        CType(Me.txtSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpError As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpSQL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtError As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSQL As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdCopy As DevExpress.XtraEditors.SimpleButton
End Class
