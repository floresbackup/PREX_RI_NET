<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultado
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
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblNombre = New DevExpress.XtraEditors.LabelControl
        Me.txtOrden = New DevExpress.XtraEditors.SpinEdit
        Me.lblOrden = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(226, 75)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(129, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(297, 20)
        Me.txtNombre.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(329, 75)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(12, 41)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 13)
        Me.lblNombre.TabIndex = 24
        Me.lblNombre.Text = "Descripción:"
        '
        'txtOrden
        '
        Me.txtOrden.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtOrden.Location = New System.Drawing.Point(129, 12)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtOrden.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOrden.Properties.IsFloatValue = False
        Me.txtOrden.Properties.Mask.EditMask = "N00"
        Me.txtOrden.Properties.MaxValue = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtOrden.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtOrden.Size = New System.Drawing.Size(71, 20)
        Me.txtOrden.TabIndex = 3
        '
        'lblOrden
        '
        Me.lblOrden.Location = New System.Drawing.Point(12, 15)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(34, 13)
        Me.lblOrden.TabIndex = 25
        Me.lblOrden.Text = "Orden:"
        '
        'frmResultado
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(434, 115)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResultado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultado"
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNombre As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrden As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblOrden As DevExpress.XtraEditors.LabelControl
End Class
