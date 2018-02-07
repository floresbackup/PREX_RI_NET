<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuardarReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuardarReporte))
        Me.lblNombreReporte = New DevExpress.XtraEditors.LabelControl
        Me.txtNombreReporte = New DevExpress.XtraEditors.TextEdit
        Me.txtPath = New DevExpress.XtraEditors.TextEdit
        Me.lblRuta = New DevExpress.XtraEditors.LabelControl
        Me.chkPublico = New DevExpress.XtraEditors.CheckEdit
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtNombreReporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPublico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreReporte
        '
        Me.lblNombreReporte.Location = New System.Drawing.Point(12, 12)
        Me.lblNombreReporte.Name = "lblNombreReporte"
        Me.lblNombreReporte.Size = New System.Drawing.Size(97, 13)
        Me.lblNombreReporte.TabIndex = 0
        Me.lblNombreReporte.Text = "Nombre del informe:"
        '
        'txtNombreReporte
        '
        Me.txtNombreReporte.Location = New System.Drawing.Point(151, 9)
        Me.txtNombreReporte.Name = "txtNombreReporte"
        Me.txtNombreReporte.Size = New System.Drawing.Size(325, 20)
        Me.txtNombreReporte.TabIndex = 0
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(151, 35)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(325, 20)
        Me.txtPath.TabIndex = 1
        '
        'lblRuta
        '
        Me.lblRuta.Location = New System.Drawing.Point(12, 38)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(78, 13)
        Me.lblRuta.TabIndex = 2
        Me.lblRuta.Text = "Ruta de acceso:"
        '
        'chkPublico
        '
        Me.chkPublico.Location = New System.Drawing.Point(10, 89)
        Me.chkPublico.Name = "chkPublico"
        Me.chkPublico.Properties.Caption = "Informe compartido"
        Me.chkPublico.Size = New System.Drawing.Size(221, 19)
        Me.chkPublico.TabIndex = 2
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(276, 82)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(379, 82)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmGuardarReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 120)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.chkPublico)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.txtNombreReporte)
        Me.Controls.Add(Me.lblNombreReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGuardarReporte"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guardar informe"
        CType(Me.txtNombreReporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPublico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreReporte As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreReporte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRuta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkPublico As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
End Class
