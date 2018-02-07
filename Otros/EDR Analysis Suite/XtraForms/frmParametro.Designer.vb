<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametro
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametro))
        Dim Document1 As ActiproSoftware.SyntaxEditor.Document = New ActiproSoftware.SyntaxEditor.Document
        Dim VisualStudio2005SyntaxEditorRenderer1 As ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer = New ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer
        Me.dslSQL = New ActiproSoftware.SyntaxEditor.Addons.Dynamic.DynamicSyntaxLanguage(Me.components)
        Me.Tabs = New DevExpress.XtraTab.XtraTabControl
        Me.tpGeneral = New DevExpress.XtraTab.XtraTabPage
        Me.txtValor2 = New DevExpress.XtraEditors.TextEdit
        Me.lblValor2 = New DevExpress.XtraEditors.LabelControl
        Me.txtValor1 = New DevExpress.XtraEditors.TextEdit
        Me.lblValor1 = New DevExpress.XtraEditors.LabelControl
        Me.cboValidacion = New DevExpress.XtraEditors.ComboBoxEdit
        Me.chkValidacion = New DevExpress.XtraEditors.CheckEdit
        Me.txtValorOmision = New DevExpress.XtraEditors.TextEdit
        Me.lblValorDefault = New DevExpress.XtraEditors.LabelControl
        Me.chkRequerido = New DevExpress.XtraEditors.CheckEdit
        Me.chkMultiseleccion = New DevExpress.XtraEditors.CheckEdit
        Me.txtParteSQL = New DevExpress.XtraEditors.TextEdit
        Me.lblParteSQL = New DevExpress.XtraEditors.LabelControl
        Me.txtVariable = New DevExpress.XtraEditors.TextEdit
        Me.lblVariable = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoControl = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblTipoControl = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoDatos = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblTipoDatos = New DevExpress.XtraEditors.LabelControl
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.lblNombre = New DevExpress.XtraEditors.LabelControl
        Me.txtOrden = New DevExpress.XtraEditors.SpinEdit
        Me.lblOrden = New DevExpress.XtraEditors.LabelControl
        Me.tpCustomHelp = New DevExpress.XtraTab.XtraTabPage
        Me.cmdAsistenteSQL = New DevExpress.XtraEditors.SimpleButton
        Me.txtIndiceColumna = New DevExpress.XtraEditors.SpinEdit
        Me.lblIndiceColumna = New DevExpress.XtraEditors.LabelControl
        Me.lblTipAyudaContextual = New DevExpress.XtraEditors.LabelControl
        Me.txtSQL = New ActiproSoftware.SyntaxEditor.SyntaxEditor
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        CType(Me.txtValor2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboValidacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkValidacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorOmision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRequerido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMultiseleccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParteSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVariable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDatos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCustomHelp.SuspendLayout()
        CType(Me.txtIndiceColumna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dslSQL
        '
        Me.dslSQL.DefinitionXml = resources.GetString("dslSQL.DefinitionXml")
        '
        'Tabs
        '
        Me.Tabs.Location = New System.Drawing.Point(5, 3)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedTabPage = Me.tpGeneral
        Me.Tabs.Size = New System.Drawing.Size(609, 378)
        Me.Tabs.TabIndex = 13
        Me.Tabs.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpGeneral, Me.tpCustomHelp})
        '
        'tpGeneral
        '
        Me.tpGeneral.Controls.Add(Me.txtValor2)
        Me.tpGeneral.Controls.Add(Me.lblValor2)
        Me.tpGeneral.Controls.Add(Me.txtValor1)
        Me.tpGeneral.Controls.Add(Me.lblValor1)
        Me.tpGeneral.Controls.Add(Me.cboValidacion)
        Me.tpGeneral.Controls.Add(Me.chkValidacion)
        Me.tpGeneral.Controls.Add(Me.txtValorOmision)
        Me.tpGeneral.Controls.Add(Me.lblValorDefault)
        Me.tpGeneral.Controls.Add(Me.chkRequerido)
        Me.tpGeneral.Controls.Add(Me.chkMultiseleccion)
        Me.tpGeneral.Controls.Add(Me.txtParteSQL)
        Me.tpGeneral.Controls.Add(Me.lblParteSQL)
        Me.tpGeneral.Controls.Add(Me.txtVariable)
        Me.tpGeneral.Controls.Add(Me.lblVariable)
        Me.tpGeneral.Controls.Add(Me.cboTipoControl)
        Me.tpGeneral.Controls.Add(Me.lblTipoControl)
        Me.tpGeneral.Controls.Add(Me.cboTipoDatos)
        Me.tpGeneral.Controls.Add(Me.lblTipoDatos)
        Me.tpGeneral.Controls.Add(Me.txtNombre)
        Me.tpGeneral.Controls.Add(Me.lblNombre)
        Me.tpGeneral.Controls.Add(Me.txtOrden)
        Me.tpGeneral.Controls.Add(Me.lblOrden)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Size = New System.Drawing.Size(600, 347)
        Me.tpGeneral.Text = "General"
        '
        'txtValor2
        '
        Me.txtValor2.Enabled = False
        Me.txtValor2.Location = New System.Drawing.Point(146, 306)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(134, 20)
        Me.txtValor2.TabIndex = 11
        '
        'lblValor2
        '
        Me.lblValor2.Enabled = False
        Me.lblValor2.Location = New System.Drawing.Point(42, 309)
        Me.lblValor2.Name = "lblValor2"
        Me.lblValor2.Size = New System.Drawing.Size(37, 13)
        Me.lblValor2.TabIndex = 25
        Me.lblValor2.Text = "Valor 2:"
        '
        'txtValor1
        '
        Me.txtValor1.Enabled = False
        Me.txtValor1.Location = New System.Drawing.Point(146, 280)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(134, 20)
        Me.txtValor1.TabIndex = 10
        '
        'lblValor1
        '
        Me.lblValor1.Enabled = False
        Me.lblValor1.Location = New System.Drawing.Point(42, 283)
        Me.lblValor1.Name = "lblValor1"
        Me.lblValor1.Size = New System.Drawing.Size(37, 13)
        Me.lblValor1.TabIndex = 23
        Me.lblValor1.Text = "Valor 1:"
        '
        'cboValidacion
        '
        Me.cboValidacion.Enabled = False
        Me.cboValidacion.Location = New System.Drawing.Point(146, 254)
        Me.cboValidacion.Name = "cboValidacion"
        Me.cboValidacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboValidacion.Properties.Items.AddRange(New Object() {"=", "<>", ">", "<", ">=", "<=", "BETWEEN"})
        Me.cboValidacion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboValidacion.Size = New System.Drawing.Size(134, 20)
        Me.cboValidacion.TabIndex = 9
        '
        'chkValidacion
        '
        Me.chkValidacion.Location = New System.Drawing.Point(4, 254)
        Me.chkValidacion.Name = "chkValidacion"
        Me.chkValidacion.Properties.Caption = "Validación:"
        Me.chkValidacion.Size = New System.Drawing.Size(132, 19)
        Me.chkValidacion.TabIndex = 8
        '
        'txtValorOmision
        '
        Me.txtValorOmision.Location = New System.Drawing.Point(146, 166)
        Me.txtValorOmision.Name = "txtValorOmision"
        Me.txtValorOmision.Size = New System.Drawing.Size(134, 20)
        Me.txtValorOmision.TabIndex = 5
        '
        'lblValorDefault
        '
        Me.lblValorDefault.Location = New System.Drawing.Point(5, 169)
        Me.lblValorDefault.Name = "lblValorDefault"
        Me.lblValorDefault.Size = New System.Drawing.Size(85, 13)
        Me.lblValorDefault.TabIndex = 19
        Me.lblValorDefault.Text = "Valor por omisión:"
        '
        'chkRequerido
        '
        Me.chkRequerido.Location = New System.Drawing.Point(4, 229)
        Me.chkRequerido.Name = "chkRequerido"
        Me.chkRequerido.Properties.Caption = "Parámetro requerido"
        Me.chkRequerido.Size = New System.Drawing.Size(198, 19)
        Me.chkRequerido.TabIndex = 7
        '
        'chkMultiseleccion
        '
        Me.chkMultiseleccion.Location = New System.Drawing.Point(4, 204)
        Me.chkMultiseleccion.Name = "chkMultiseleccion"
        Me.chkMultiseleccion.Properties.Caption = "Permitir múltiples filtros"
        Me.chkMultiseleccion.Size = New System.Drawing.Size(198, 19)
        Me.chkMultiseleccion.TabIndex = 6
        '
        'txtParteSQL
        '
        Me.txtParteSQL.Location = New System.Drawing.Point(146, 140)
        Me.txtParteSQL.Name = "txtParteSQL"
        Me.txtParteSQL.Size = New System.Drawing.Size(451, 20)
        Me.txtParteSQL.TabIndex = 4
        '
        'lblParteSQL
        '
        Me.lblParteSQL.Location = New System.Drawing.Point(5, 143)
        Me.lblParteSQL.Name = "lblParteSQL"
        Me.lblParteSQL.Size = New System.Drawing.Size(79, 13)
        Me.lblParteSQL.TabIndex = 15
        Me.lblParteSQL.Text = "Instrucción SQL:"
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(146, 114)
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(134, 20)
        Me.txtVariable.TabIndex = 3
        '
        'lblVariable
        '
        Me.lblVariable.Location = New System.Drawing.Point(5, 117)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(42, 13)
        Me.lblVariable.TabIndex = 13
        Me.lblVariable.Text = "Variable:"
        '
        'cboTipoControl
        '
        Me.cboTipoControl.Location = New System.Drawing.Point(146, 88)
        Me.cboTipoControl.Name = "cboTipoControl"
        Me.cboTipoControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoControl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoControl.Size = New System.Drawing.Size(243, 20)
        Me.cboTipoControl.TabIndex = 2
        '
        'lblTipoControl
        '
        Me.lblTipoControl.Location = New System.Drawing.Point(5, 91)
        Me.lblTipoControl.Name = "lblTipoControl"
        Me.lblTipoControl.Size = New System.Drawing.Size(75, 13)
        Me.lblTipoControl.TabIndex = 11
        Me.lblTipoControl.Text = "Tipo de control:"
        '
        'cboTipoDatos
        '
        Me.cboTipoDatos.Location = New System.Drawing.Point(146, 62)
        Me.cboTipoDatos.Name = "cboTipoDatos"
        Me.cboTipoDatos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDatos.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoDatos.Size = New System.Drawing.Size(134, 20)
        Me.cboTipoDatos.TabIndex = 1
        '
        'lblTipoDatos
        '
        Me.lblTipoDatos.Location = New System.Drawing.Point(5, 65)
        Me.lblTipoDatos.Name = "lblTipoDatos"
        Me.lblTipoDatos.Size = New System.Drawing.Size(69, 13)
        Me.lblTipoDatos.TabIndex = 9
        Me.lblTipoDatos.Text = "Tipo de datos:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(146, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(243, 20)
        Me.txtNombre.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(5, 39)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(41, 13)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre:"
        '
        'txtOrden
        '
        Me.txtOrden.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtOrden.Location = New System.Drawing.Point(146, 12)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtOrden.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOrden.Properties.IsFloatValue = False
        Me.txtOrden.Properties.Mask.EditMask = "N00"
        Me.txtOrden.Properties.MaxValue = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txtOrden.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtOrden.Size = New System.Drawing.Size(71, 20)
        Me.txtOrden.TabIndex = 12
        '
        'lblOrden
        '
        Me.lblOrden.Location = New System.Drawing.Point(5, 15)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(34, 13)
        Me.lblOrden.TabIndex = 4
        Me.lblOrden.Text = "Orden:"
        '
        'tpCustomHelp
        '
        Me.tpCustomHelp.Controls.Add(Me.cmdAsistenteSQL)
        Me.tpCustomHelp.Controls.Add(Me.txtIndiceColumna)
        Me.tpCustomHelp.Controls.Add(Me.lblIndiceColumna)
        Me.tpCustomHelp.Controls.Add(Me.lblTipAyudaContextual)
        Me.tpCustomHelp.Controls.Add(Me.txtSQL)
        Me.tpCustomHelp.Name = "tpCustomHelp"
        Me.tpCustomHelp.Size = New System.Drawing.Size(600, 347)
        Me.tpCustomHelp.Text = "Ayuda contextual"
        '
        'cmdAsistenteSQL
        '
        Me.cmdAsistenteSQL.Location = New System.Drawing.Point(488, 314)
        Me.cmdAsistenteSQL.Name = "cmdAsistenteSQL"
        Me.cmdAsistenteSQL.Size = New System.Drawing.Size(109, 26)
        Me.cmdAsistenteSQL.TabIndex = 16
        Me.cmdAsistenteSQL.Text = "Asistente SQL..."
        '
        'txtIndiceColumna
        '
        Me.txtIndiceColumna.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtIndiceColumna.Location = New System.Drawing.Point(264, 320)
        Me.txtIndiceColumna.Name = "txtIndiceColumna"
        Me.txtIndiceColumna.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtIndiceColumna.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIndiceColumna.Properties.IsFloatValue = False
        Me.txtIndiceColumna.Properties.Mask.EditMask = "N00"
        Me.txtIndiceColumna.Properties.MaxValue = New Decimal(New Integer() {256, 0, 0, 0})
        Me.txtIndiceColumna.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtIndiceColumna.Size = New System.Drawing.Size(71, 20)
        Me.txtIndiceColumna.TabIndex = 15
        '
        'lblIndiceColumna
        '
        Me.lblIndiceColumna.Location = New System.Drawing.Point(4, 323)
        Me.lblIndiceColumna.Name = "lblIndiceColumna"
        Me.lblIndiceColumna.Size = New System.Drawing.Size(232, 13)
        Me.lblIndiceColumna.TabIndex = 6
        Me.lblIndiceColumna.Text = "Indice de la columna que devolverá el resultado:"
        '
        'lblTipAyudaContextual
        '
        Me.lblTipAyudaContextual.Location = New System.Drawing.Point(4, 7)
        Me.lblTipAyudaContextual.Name = "lblTipAyudaContextual"
        Me.lblTipAyudaContextual.Size = New System.Drawing.Size(407, 13)
        Me.lblTipAyudaContextual.TabIndex = 5
        Me.lblTipAyudaContextual.Text = "Instrucción SQL cuyos resultados ofrecerán las opciones a seleccionar por el usua" & _
            "rio:"
        '
        'txtSQL
        '
        Me.txtSQL.DefaultContextMenuEnabled = False
        Document1.Language = Me.dslSQL
        Me.txtSQL.Document = Document1
        Me.txtSQL.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQL.Location = New System.Drawing.Point(-3, 26)
        Me.txtSQL.Name = "txtSQL"
        VisualStudio2005SyntaxEditorRenderer1.ResetAllPropertiesOnSystemColorChange = False
        Me.txtSQL.Renderer = VisualStudio2005SyntaxEditorRenderer1
        Me.txtSQL.Size = New System.Drawing.Size(603, 282)
        Me.txtSQL.TabIndex = 14
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(372, 387)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(118, 26)
        Me.cmdAceptar.TabIndex = 16
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(496, 387)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(118, 26)
        Me.cmdCancelar.TabIndex = 17
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmParametro
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(618, 422)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Tabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParametro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetro"
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        CType(Me.txtValor2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboValidacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkValidacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorOmision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRequerido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMultiseleccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParteSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVariable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDatos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCustomHelp.ResumeLayout(False)
        Me.tpCustomHelp.PerformLayout()
        CType(Me.txtIndiceColumna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpGeneral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombre As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrden As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblOrden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tpCustomHelp As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblTipoDatos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtParteSQL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblParteSQL As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVariable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblVariable As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoControl As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblTipoControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoDatos As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkRequerido As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMultiseleccion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboValidacion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkValidacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtValorOmision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValorDefault As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValor2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValor2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValor1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValor1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIndiceColumna As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblIndiceColumna As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTipAyudaContextual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSQL As ActiproSoftware.SyntaxEditor.SyntaxEditor
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dslSQL As ActiproSoftware.SyntaxEditor.Addons.Dynamic.DynamicSyntaxLanguage
    Friend WithEvents cmdAsistenteSQL As DevExpress.XtraEditors.SimpleButton
End Class
