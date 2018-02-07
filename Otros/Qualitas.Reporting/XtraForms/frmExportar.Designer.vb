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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportar))
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.grpExportar = New DevExpress.XtraEditors.GroupControl
        Me.chkExportarReportes = New DevExpress.XtraEditors.CheckEdit
        Me.chkExportarLayouts = New DevExpress.XtraEditors.CheckEdit
        Me.lblNombreConsulta = New System.Windows.Forms.Label
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit
        Me.lblNombreArchivo = New System.Windows.Forms.Label
        Me.lblConsultaExportar = New System.Windows.Forms.Label
        CType(Me.grpExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExportar.SuspendLayout()
        CType(Me.chkExportarReportes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExportarLayouts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(350, 189)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(453, 189)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'grpExportar
        '
        Me.grpExportar.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExportar.AppearanceCaption.Options.UseFont = True
        Me.grpExportar.Controls.Add(Me.chkExportarReportes)
        Me.grpExportar.Controls.Add(Me.chkExportarLayouts)
        Me.grpExportar.Controls.Add(Me.lblNombreConsulta)
        Me.grpExportar.Controls.Add(Me.cmdBrowse)
        Me.grpExportar.Controls.Add(Me.txtFileName)
        Me.grpExportar.Controls.Add(Me.lblNombreArchivo)
        Me.grpExportar.Controls.Add(Me.lblConsultaExportar)
        Me.grpExportar.Location = New System.Drawing.Point(12, 12)
        Me.grpExportar.Name = "grpExportar"
        Me.grpExportar.Size = New System.Drawing.Size(538, 162)
        Me.grpExportar.TabIndex = 13
        Me.grpExportar.Text = "Exportar consulta"
        '
        'chkExportarReportes
        '
        Me.chkExportarReportes.EditValue = True
        Me.chkExportarReportes.Location = New System.Drawing.Point(19, 125)
        Me.chkExportarReportes.Name = "chkExportarReportes"
        Me.chkExportarReportes.Properties.Caption = "Exportar informes públicos"
        Me.chkExportarReportes.Size = New System.Drawing.Size(305, 19)
        Me.chkExportarReportes.TabIndex = 19
        '
        'chkExportarLayouts
        '
        Me.chkExportarLayouts.EditValue = True
        Me.chkExportarLayouts.Location = New System.Drawing.Point(19, 100)
        Me.chkExportarLayouts.Name = "chkExportarLayouts"
        Me.chkExportarLayouts.Properties.Caption = "Exportar diseños de vista compartidos"
        Me.chkExportarLayouts.Size = New System.Drawing.Size(305, 19)
        Me.chkExportarLayouts.TabIndex = 18
        '
        'lblNombreConsulta
        '
        Me.lblNombreConsulta.AutoSize = True
        Me.lblNombreConsulta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreConsulta.Location = New System.Drawing.Point(166, 31)
        Me.lblNombreConsulta.Name = "lblNombreConsulta"
        Me.lblNombreConsulta.Size = New System.Drawing.Size(103, 13)
        Me.lblNombreConsulta.TabIndex = 17
        Me.lblNombreConsulta.Text = "Nombre Consulta"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(492, 53)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(28, 20)
        Me.cmdBrowse.TabIndex = 14
        Me.cmdBrowse.Text = "..."
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(169, 53)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(317, 20)
        Me.txtFileName.TabIndex = 13
        '
        'lblNombreArchivo
        '
        Me.lblNombreArchivo.AutoSize = True
        Me.lblNombreArchivo.Location = New System.Drawing.Point(16, 56)
        Me.lblNombreArchivo.Name = "lblNombreArchivo"
        Me.lblNombreArchivo.Size = New System.Drawing.Size(101, 13)
        Me.lblNombreArchivo.TabIndex = 16
        Me.lblNombreArchivo.Text = "Nombre de archivo:"
        '
        'lblConsultaExportar
        '
        Me.lblConsultaExportar.AutoSize = True
        Me.lblConsultaExportar.Location = New System.Drawing.Point(16, 31)
        Me.lblConsultaExportar.Name = "lblConsultaExportar"
        Me.lblConsultaExportar.Size = New System.Drawing.Size(107, 13)
        Me.lblConsultaExportar.TabIndex = 15
        Me.lblConsultaExportar.Text = "Consulta a exportar:"
        '
        'frmExportar
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(562, 227)
        Me.Controls.Add(Me.grpExportar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExportar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar consulta"
        CType(Me.grpExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExportar.ResumeLayout(False)
        Me.grpExportar.PerformLayout()
        CType(Me.chkExportarReportes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExportarLayouts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpExportar As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkExportarReportes As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkExportarLayouts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblNombreConsulta As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombreArchivo As System.Windows.Forms.Label
    Friend WithEvents lblConsultaExportar As System.Windows.Forms.Label
End Class
