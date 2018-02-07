<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarHTML
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
        Me.lblFileName = New DevExpress.XtraEditors.LabelControl
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblBorderWidth = New DevExpress.XtraEditors.LabelControl
        Me.txtBorderWidth = New DevExpress.XtraEditors.SpinEdit
        Me.txtPageTitle = New DevExpress.XtraEditors.TextEdit
        Me.lblPageTitle = New DevExpress.XtraEditors.LabelControl
        Me.lblBorderColor = New DevExpress.XtraEditors.LabelControl
        Me.cboColor = New DevExpress.XtraEditors.ColorEdit
        Me.lblPageModo = New DevExpress.XtraEditors.LabelControl
        Me.cboPaginado = New DevExpress.XtraEditors.ComboBoxEdit
        Me.chkRemoveSymbols = New DevExpress.XtraEditors.CheckEdit
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBorderWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPaginado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRemoveSymbols.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtFileName.Location = New System.Drawing.Point(123, 9)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(345, 20)
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
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(260, 173)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(118, 26)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(384, 173)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(118, 26)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'lblBorderWidth
        '
        Me.lblBorderWidth.Location = New System.Drawing.Point(12, 64)
        Me.lblBorderWidth.Name = "lblBorderWidth"
        Me.lblBorderWidth.Size = New System.Drawing.Size(82, 13)
        Me.lblBorderWidth.TabIndex = 6
        Me.lblBorderWidth.Text = "Ancho del borde:"
        '
        'txtBorderWidth
        '
        Me.txtBorderWidth.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtBorderWidth.Location = New System.Drawing.Point(123, 61)
        Me.txtBorderWidth.Name = "txtBorderWidth"
        Me.txtBorderWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtBorderWidth.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtBorderWidth.Size = New System.Drawing.Size(62, 20)
        Me.txtBorderWidth.TabIndex = 3
        '
        'txtPageTitle
        '
        Me.txtPageTitle.Location = New System.Drawing.Point(123, 35)
        Me.txtPageTitle.Name = "txtPageTitle"
        Me.txtPageTitle.Size = New System.Drawing.Size(255, 20)
        Me.txtPageTitle.TabIndex = 2
        '
        'lblPageTitle
        '
        Me.lblPageTitle.Location = New System.Drawing.Point(12, 38)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(80, 13)
        Me.lblPageTitle.TabIndex = 9
        Me.lblPageTitle.Text = "Título de página:"
        '
        'lblBorderColor
        '
        Me.lblBorderColor.Location = New System.Drawing.Point(12, 90)
        Me.lblBorderColor.Name = "lblBorderColor"
        Me.lblBorderColor.Size = New System.Drawing.Size(77, 13)
        Me.lblBorderColor.TabIndex = 11
        Me.lblBorderColor.Text = "Color del borde:"
        '
        'cboColor
        '
        Me.cboColor.EditValue = System.Drawing.Color.Black
        Me.cboColor.Location = New System.Drawing.Point(123, 87)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColor.Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboColor.Size = New System.Drawing.Size(62, 20)
        Me.cboColor.TabIndex = 4
        '
        'lblPageModo
        '
        Me.lblPageModo.Location = New System.Drawing.Point(12, 116)
        Me.lblPageModo.Name = "lblPageModo"
        Me.lblPageModo.Size = New System.Drawing.Size(48, 13)
        Me.lblPageModo.TabIndex = 13
        Me.lblPageModo.Text = "Paginado:"
        '
        'cboPaginado
        '
        Me.cboPaginado.EditValue = "Un solo archivo - Un encabezado por página"
        Me.cboPaginado.Location = New System.Drawing.Point(123, 113)
        Me.cboPaginado.Name = "cboPaginado"
        Me.cboPaginado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPaginado.Properties.Items.AddRange(New Object() {"Un solo archivo - Un solo encabezado", "Un solo archivo - Un encabezado por página", "Un archivo por página"})
        Me.cboPaginado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPaginado.Size = New System.Drawing.Size(255, 20)
        Me.cboPaginado.TabIndex = 5
        '
        'chkRemoveSymbols
        '
        Me.chkRemoveSymbols.EditValue = True
        Me.chkRemoveSymbols.Location = New System.Drawing.Point(121, 139)
        Me.chkRemoveSymbols.Name = "chkRemoveSymbols"
        Me.chkRemoveSymbols.Properties.Caption = "Quitar símbolos secundarios"
        Me.chkRemoveSymbols.Size = New System.Drawing.Size(257, 18)
        Me.chkRemoveSymbols.TabIndex = 6
        '
        'frmExportarHTML
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(512, 211)
        Me.Controls.Add(Me.chkRemoveSymbols)
        Me.Controls.Add(Me.cboPaginado)
        Me.Controls.Add(Me.lblPageModo)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.lblBorderColor)
        Me.Controls.Add(Me.txtPageTitle)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Controls.Add(Me.txtBorderWidth)
        Me.Controls.Add(Me.lblBorderWidth)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblFileName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExportarHTML"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar a HTML"
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBorderWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPaginado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRemoveSymbols.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFileName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblBorderWidth As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBorderWidth As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtPageTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPageTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBorderColor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboColor As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents lblPageModo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPaginado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkRemoveSymbols As DevExpress.XtraEditors.CheckEdit
End Class
