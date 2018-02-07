<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportar
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
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblConsultaExportar = New System.Windows.Forms.Label
        Me.lblNombreArchivo = New System.Windows.Forms.Label
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit
        Me.lblNombreConsulta = New System.Windows.Forms.Label
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(350, 72)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(453, 72)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'lblConsultaExportar
        '
        Me.lblConsultaExportar.AutoSize = True
        Me.lblConsultaExportar.Location = New System.Drawing.Point(12, 9)
        Me.lblConsultaExportar.Name = "lblConsultaExportar"
        Me.lblConsultaExportar.Size = New System.Drawing.Size(107, 13)
        Me.lblConsultaExportar.TabIndex = 8
        Me.lblConsultaExportar.Text = "Consulta a exportar:"
        '
        'lblNombreArchivo
        '
        Me.lblNombreArchivo.AutoSize = True
        Me.lblNombreArchivo.Location = New System.Drawing.Point(12, 34)
        Me.lblNombreArchivo.Name = "lblNombreArchivo"
        Me.lblNombreArchivo.Size = New System.Drawing.Size(101, 13)
        Me.lblNombreArchivo.TabIndex = 9
        Me.lblNombreArchivo.Text = "Nombre de archivo:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(522, 31)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(28, 20)
        Me.cmdBrowse.TabIndex = 1
        Me.cmdBrowse.Text = "..."
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(165, 31)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(351, 20)
        Me.txtFileName.TabIndex = 0
        '
        'lblNombreConsulta
        '
        Me.lblNombreConsulta.AutoSize = True
        Me.lblNombreConsulta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreConsulta.Location = New System.Drawing.Point(162, 9)
        Me.lblNombreConsulta.Name = "lblNombreConsulta"
        Me.lblNombreConsulta.Size = New System.Drawing.Size(103, 13)
        Me.lblNombreConsulta.TabIndex = 12
        Me.lblNombreConsulta.Text = "Nombre Consulta"
        '
        'frmExportar
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(562, 111)
        Me.Controls.Add(Me.lblNombreConsulta)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblNombreArchivo)
        Me.Controls.Add(Me.lblConsultaExportar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExportar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar consulta"
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblConsultaExportar As System.Windows.Forms.Label
    Friend WithEvents lblNombreArchivo As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombreConsulta As System.Windows.Forms.Label
End Class
