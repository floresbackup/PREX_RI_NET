<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditorExpresion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditorExpresion))
        Me.lblInclusion = New DevExpress.XtraEditors.LabelControl
        Me.cboInclusion = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboColumna = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblColumna = New DevExpress.XtraEditors.LabelControl
        Me.cboComparacion = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblComparacion = New DevExpress.XtraEditors.LabelControl
        Me.cboValor = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblValor = New DevExpress.XtraEditors.LabelControl
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cboInclusion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboColumna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboComparacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInclusion
        '
        Me.lblInclusion.Location = New System.Drawing.Point(13, 13)
        Me.lblInclusion.Name = "lblInclusion"
        Me.lblInclusion.Size = New System.Drawing.Size(46, 13)
        Me.lblInclusion.TabIndex = 0
        Me.lblInclusion.Text = "Inclusión:"
        '
        'cboInclusion
        '
        Me.cboInclusion.Location = New System.Drawing.Point(103, 10)
        Me.cboInclusion.Name = "cboInclusion"
        Me.cboInclusion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboInclusion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboInclusion.Size = New System.Drawing.Size(100, 20)
        Me.cboInclusion.TabIndex = 1
        '
        'cboColumna
        '
        Me.cboColumna.Location = New System.Drawing.Point(103, 36)
        Me.cboColumna.Name = "cboColumna"
        Me.cboColumna.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColumna.Size = New System.Drawing.Size(287, 20)
        Me.cboColumna.TabIndex = 3
        '
        'lblColumna
        '
        Me.lblColumna.Location = New System.Drawing.Point(13, 39)
        Me.lblColumna.Name = "lblColumna"
        Me.lblColumna.Size = New System.Drawing.Size(45, 13)
        Me.lblColumna.TabIndex = 2
        Me.lblColumna.Text = "Columna:"
        '
        'cboComparacion
        '
        Me.cboComparacion.EditValue = "="
        Me.cboComparacion.Location = New System.Drawing.Point(103, 62)
        Me.cboComparacion.Name = "cboComparacion"
        Me.cboComparacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboComparacion.Properties.Items.AddRange(New Object() {"=", "<>", ">", "<", ">=", "<=", "IN ( ... )", "NOT IN ( ... )"})
        Me.cboComparacion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboComparacion.Size = New System.Drawing.Size(100, 20)
        Me.cboComparacion.TabIndex = 5
        '
        'lblComparacion
        '
        Me.lblComparacion.Location = New System.Drawing.Point(13, 65)
        Me.lblComparacion.Name = "lblComparacion"
        Me.lblComparacion.Size = New System.Drawing.Size(66, 13)
        Me.lblComparacion.TabIndex = 4
        Me.lblComparacion.Text = "Comparación:"
        '
        'cboValor
        '
        Me.cboValor.Location = New System.Drawing.Point(103, 88)
        Me.cboValor.Name = "cboValor"
        Me.cboValor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboValor.Size = New System.Drawing.Size(287, 20)
        Me.cboValor.TabIndex = 7
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(13, 91)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(28, 13)
        Me.lblValor.TabIndex = 6
        Me.lblValor.Text = "Valor:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(190, 139)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(293, 139)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmEditorExpresion
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(406, 177)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cboValor)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.cboComparacion)
        Me.Controls.Add(Me.lblComparacion)
        Me.Controls.Add(Me.cboColumna)
        Me.Controls.Add(Me.lblColumna)
        Me.Controls.Add(Me.cboInclusion)
        Me.Controls.Add(Me.lblInclusion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditorExpresion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Construir expresión"
        CType(Me.cboInclusion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboColumna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboComparacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInclusion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboInclusion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboColumna As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblColumna As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboComparacion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblComparacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboValor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
End Class
