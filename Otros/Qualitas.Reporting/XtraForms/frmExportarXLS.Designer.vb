<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarXLS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportarXLS))
        Me.lblFileName = New DevExpress.XtraEditors.LabelControl
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.chkLines = New DevExpress.XtraEditors.CheckEdit
        Me.chkNative = New DevExpress.XtraEditors.CheckEdit
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNative.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFileName
        '
        Me.lblFileName.Location = New System.Drawing.Point(12, 12)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(55, 13)
        Me.lblFileName.TabIndex = 0
        Me.lblFileName.Text = "Exportar a:"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(93, 9)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(375, 20)
        Me.txtFileName.TabIndex = 0
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(474, 9)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(28, 20)
        Me.cmdBrowse.TabIndex = 1
        Me.cmdBrowse.Text = "..."
        '
        'chkLines
        '
        Me.chkLines.EditValue = True
        Me.chkLines.Location = New System.Drawing.Point(93, 42)
        Me.chkLines.Name = "chkLines"
        Me.chkLines.Properties.Caption = "Bordes de celdas"
        Me.chkLines.Size = New System.Drawing.Size(159, 19)
        Me.chkLines.TabIndex = 2
        '
        'chkNative
        '
        Me.chkNative.EditValue = True
        Me.chkNative.Location = New System.Drawing.Point(93, 67)
        Me.chkNative.Name = "chkNative"
        Me.chkNative.Properties.Caption = "Formato nativo"
        Me.chkNative.Size = New System.Drawing.Size(159, 19)
        Me.chkNative.TabIndex = 3
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(258, 60)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(118, 26)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(382, 60)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(118, 26)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmExportarXLS
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(512, 101)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.chkNative)
        Me.Controls.Add(Me.chkLines)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblFileName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExportarXLS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar a Excel"
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNative.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFileName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkLines As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNative As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
End Class
