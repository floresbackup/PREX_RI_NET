<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionesSeguridad
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
        Me.chkAutenticacionNT = New DevExpress.XtraEditors.CheckEdit
        Me.lblDominio = New DevExpress.XtraEditors.LabelControl
        Me.txtDominio = New DevExpress.XtraEditors.TextEdit
        CType(Me.chkAutenticacionNT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDominio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(179, 117)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(282, 117)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'chkAutenticacionNT
        '
        Me.chkAutenticacionNT.Location = New System.Drawing.Point(12, 12)
        Me.chkAutenticacionNT.Name = "chkAutenticacionNT"
        Me.chkAutenticacionNT.Properties.Caption = "Autenticar usuarios mediante Active Directory"
        Me.chkAutenticacionNT.Size = New System.Drawing.Size(296, 19)
        Me.chkAutenticacionNT.TabIndex = 3
        '
        'lblDominio
        '
        Me.lblDominio.Location = New System.Drawing.Point(32, 46)
        Me.lblDominio.Name = "lblDominio"
        Me.lblDominio.Size = New System.Drawing.Size(120, 13)
        Me.lblDominio.TabIndex = 43
        Me.lblDominio.Text = "Dominio predeterminado:"
        '
        'txtDominio
        '
        Me.txtDominio.Enabled = False
        Me.txtDominio.Location = New System.Drawing.Point(156, 43)
        Me.txtDominio.Name = "txtDominio"
        Me.txtDominio.Size = New System.Drawing.Size(223, 20)
        Me.txtDominio.TabIndex = 0
        '
        'frmOpcionesSeguridad
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(393, 155)
        Me.Controls.Add(Me.txtDominio)
        Me.Controls.Add(Me.lblDominio)
        Me.Controls.Add(Me.chkAutenticacionNT)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcionesSeguridad"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones de seguridad"
        CType(Me.chkAutenticacionNT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDominio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkAutenticacionNT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblDominio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDominio As DevExpress.XtraEditors.TextEdit
End Class
