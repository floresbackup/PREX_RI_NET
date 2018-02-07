<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormatoCondicional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormatoCondicional))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "00000"}, 0)
        Me.grpDatosFormato = New DevExpress.XtraEditors.GroupControl
        Me.cboColumna = New DevExpress.XtraEditors.ComboBoxEdit
        Me.chkTachado = New DevExpress.XtraEditors.CheckEdit
        Me.chkTotalPersonalizadoCelda = New DevExpress.XtraEditors.CheckEdit
        Me.chkGranTotalCelda = New DevExpress.XtraEditors.CheckEdit
        Me.chkSubtotalCelda = New DevExpress.XtraEditors.CheckEdit
        Me.chkCelda = New DevExpress.XtraEditors.CheckEdit
        Me.lblAplicaA = New DevExpress.XtraEditors.LabelControl
        Me.lblFormato = New DevExpress.XtraEditors.LabelControl
        Me.cboDegradado = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblDegradado = New DevExpress.XtraEditors.LabelControl
        Me.cboColorFondo2 = New DevExpress.XtraEditors.ColorEdit
        Me.lblColorFondo2 = New DevExpress.XtraEditors.LabelControl
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.cboColorFondo = New DevExpress.XtraEditors.ColorEdit
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cboColorFuente = New DevExpress.XtraEditors.ColorEdit
        Me.lblColorFondo = New DevExpress.XtraEditors.LabelControl
        Me.lblColorFuente = New DevExpress.XtraEditors.LabelControl
        Me.chkSubrayado = New DevExpress.XtraEditors.CheckEdit
        Me.chkCursiva = New DevExpress.XtraEditors.CheckEdit
        Me.chkNegrita = New DevExpress.XtraEditors.CheckEdit
        Me.txtValor2 = New DevExpress.XtraEditors.TextEdit
        Me.txtValor1 = New DevExpress.XtraEditors.TextEdit
        Me.lblValor2 = New DevExpress.XtraEditors.LabelControl
        Me.lblValor1 = New DevExpress.XtraEditors.LabelControl
        Me.cboCondicion = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblCondicion = New DevExpress.XtraEditors.LabelControl
        Me.lblColumna = New DevExpress.XtraEditors.LabelControl
        Me.il16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.grpFormatos = New DevExpress.XtraEditors.GroupControl
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.lvFormatos = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        Me.col003 = New System.Windows.Forms.ColumnHeader
        Me.col004 = New System.Windows.Forms.ColumnHeader
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpDatosFormato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosFormato.SuspendLayout()
        CType(Me.cboColumna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTachado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTotalPersonalizadoCelda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGranTotalCelda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSubtotalCelda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCelda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDegradado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboColorFondo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboColorFondo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboColorFuente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSubrayado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCursiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNegrita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCondicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFormatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFormatos.SuspendLayout()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatosFormato
        '
        Me.grpDatosFormato.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosFormato.AppearanceCaption.Options.UseFont = True
        Me.grpDatosFormato.Controls.Add(Me.cboColumna)
        Me.grpDatosFormato.Controls.Add(Me.chkTachado)
        Me.grpDatosFormato.Controls.Add(Me.chkTotalPersonalizadoCelda)
        Me.grpDatosFormato.Controls.Add(Me.chkGranTotalCelda)
        Me.grpDatosFormato.Controls.Add(Me.chkSubtotalCelda)
        Me.grpDatosFormato.Controls.Add(Me.chkCelda)
        Me.grpDatosFormato.Controls.Add(Me.lblAplicaA)
        Me.grpDatosFormato.Controls.Add(Me.lblFormato)
        Me.grpDatosFormato.Controls.Add(Me.cboDegradado)
        Me.grpDatosFormato.Controls.Add(Me.lblDegradado)
        Me.grpDatosFormato.Controls.Add(Me.cboColorFondo2)
        Me.grpDatosFormato.Controls.Add(Me.lblColorFondo2)
        Me.grpDatosFormato.Controls.Add(Me.cmdUpdate)
        Me.grpDatosFormato.Controls.Add(Me.cboColorFondo)
        Me.grpDatosFormato.Controls.Add(Me.cmdCancelar)
        Me.grpDatosFormato.Controls.Add(Me.cboColorFuente)
        Me.grpDatosFormato.Controls.Add(Me.lblColorFondo)
        Me.grpDatosFormato.Controls.Add(Me.lblColorFuente)
        Me.grpDatosFormato.Controls.Add(Me.chkSubrayado)
        Me.grpDatosFormato.Controls.Add(Me.chkCursiva)
        Me.grpDatosFormato.Controls.Add(Me.chkNegrita)
        Me.grpDatosFormato.Controls.Add(Me.txtValor2)
        Me.grpDatosFormato.Controls.Add(Me.txtValor1)
        Me.grpDatosFormato.Controls.Add(Me.lblValor2)
        Me.grpDatosFormato.Controls.Add(Me.lblValor1)
        Me.grpDatosFormato.Controls.Add(Me.cboCondicion)
        Me.grpDatosFormato.Controls.Add(Me.lblCondicion)
        Me.grpDatosFormato.Controls.Add(Me.lblColumna)
        Me.grpDatosFormato.Location = New System.Drawing.Point(13, 13)
        Me.grpDatosFormato.Name = "grpDatosFormato"
        Me.grpDatosFormato.Size = New System.Drawing.Size(659, 223)
        Me.grpDatosFormato.TabIndex = 0
        Me.grpDatosFormato.Text = "Condición y formato"
        '
        'cboColumna
        '
        Me.cboColumna.Location = New System.Drawing.Point(91, 28)
        Me.cboColumna.Name = "cboColumna"
        Me.cboColumna.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColumna.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboColumna.Size = New System.Drawing.Size(261, 20)
        Me.cboColumna.TabIndex = 26
        '
        'chkTachado
        '
        Me.chkTachado.Location = New System.Drawing.Point(12, 189)
        Me.chkTachado.Name = "chkTachado"
        Me.chkTachado.Properties.Caption = "Tachado"
        Me.chkTachado.Size = New System.Drawing.Size(75, 19)
        Me.chkTachado.TabIndex = 25
        '
        'chkTotalPersonalizadoCelda
        '
        Me.chkTotalPersonalizadoCelda.EditValue = True
        Me.chkTotalPersonalizadoCelda.Location = New System.Drawing.Point(366, 189)
        Me.chkTotalPersonalizadoCelda.Name = "chkTotalPersonalizadoCelda"
        Me.chkTotalPersonalizadoCelda.Properties.Caption = "CheckEdit1"
        Me.chkTotalPersonalizadoCelda.Size = New System.Drawing.Size(179, 19)
        Me.chkTotalPersonalizadoCelda.TabIndex = 24
        '
        'chkGranTotalCelda
        '
        Me.chkGranTotalCelda.EditValue = True
        Me.chkGranTotalCelda.Location = New System.Drawing.Point(366, 163)
        Me.chkGranTotalCelda.Name = "chkGranTotalCelda"
        Me.chkGranTotalCelda.Properties.Caption = "CheckEdit1"
        Me.chkGranTotalCelda.Size = New System.Drawing.Size(179, 19)
        Me.chkGranTotalCelda.TabIndex = 23
        '
        'chkSubtotalCelda
        '
        Me.chkSubtotalCelda.EditValue = True
        Me.chkSubtotalCelda.Location = New System.Drawing.Point(366, 139)
        Me.chkSubtotalCelda.Name = "chkSubtotalCelda"
        Me.chkSubtotalCelda.Properties.Caption = "CheckEdit1"
        Me.chkSubtotalCelda.Size = New System.Drawing.Size(179, 19)
        Me.chkSubtotalCelda.TabIndex = 22
        '
        'chkCelda
        '
        Me.chkCelda.EditValue = True
        Me.chkCelda.Location = New System.Drawing.Point(366, 114)
        Me.chkCelda.Name = "chkCelda"
        Me.chkCelda.Properties.Caption = "CheckEdit1"
        Me.chkCelda.Size = New System.Drawing.Size(179, 19)
        Me.chkCelda.TabIndex = 21
        '
        'lblAplicaA
        '
        Me.lblAplicaA.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAplicaA.Appearance.Options.UseFont = True
        Me.lblAplicaA.Location = New System.Drawing.Point(368, 91)
        Me.lblAplicaA.Name = "lblAplicaA"
        Me.lblAplicaA.Size = New System.Drawing.Size(44, 13)
        Me.lblAplicaA.TabIndex = 20
        Me.lblAplicaA.Text = "Aplica a"
        '
        'lblFormato
        '
        Me.lblFormato.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormato.Appearance.Options.UseFont = True
        Me.lblFormato.Location = New System.Drawing.Point(14, 91)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(48, 13)
        Me.lblFormato.TabIndex = 19
        Me.lblFormato.Text = "Formato"
        '
        'cboDegradado
        '
        Me.cboDegradado.Location = New System.Drawing.Point(224, 188)
        Me.cboDegradado.Name = "cboDegradado"
        Me.cboDegradado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDegradado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDegradado.Size = New System.Drawing.Size(128, 20)
        Me.cboDegradado.TabIndex = 18
        '
        'lblDegradado
        '
        Me.lblDegradado.Location = New System.Drawing.Point(106, 191)
        Me.lblDegradado.Name = "lblDegradado"
        Me.lblDegradado.Size = New System.Drawing.Size(57, 13)
        Me.lblDegradado.TabIndex = 17
        Me.lblDegradado.Text = "Degradado:"
        '
        'cboColorFondo2
        '
        Me.cboColorFondo2.EditValue = System.Drawing.Color.Empty
        Me.cboColorFondo2.Location = New System.Drawing.Point(224, 164)
        Me.cboColorFondo2.Name = "cboColorFondo2"
        Me.cboColorFondo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColorFondo2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboColorFondo2.Size = New System.Drawing.Size(128, 20)
        Me.cboColorFondo2.TabIndex = 16
        '
        'lblColorFondo2
        '
        Me.lblColorFondo2.Location = New System.Drawing.Point(106, 166)
        Me.lblColorFondo2.Name = "lblColorFondo2"
        Me.lblColorFondo2.Size = New System.Drawing.Size(75, 13)
        Me.lblColorFondo2.TabIndex = 15
        Me.lblColorFondo2.Text = "Color de fondo:"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(557, 159)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(97, 26)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "&Agregar"
        '
        'cboColorFondo
        '
        Me.cboColorFondo.EditValue = System.Drawing.Color.Empty
        Me.cboColorFondo.Location = New System.Drawing.Point(224, 139)
        Me.cboColorFondo.Name = "cboColorFondo"
        Me.cboColorFondo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColorFondo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboColorFondo.Size = New System.Drawing.Size(128, 20)
        Me.cboColorFondo.TabIndex = 14
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(557, 191)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cboColorFuente
        '
        Me.cboColorFuente.EditValue = System.Drawing.Color.Empty
        Me.cboColorFuente.Location = New System.Drawing.Point(224, 114)
        Me.cboColorFuente.Name = "cboColorFuente"
        Me.cboColorFuente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColorFuente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboColorFuente.Size = New System.Drawing.Size(128, 20)
        Me.cboColorFuente.TabIndex = 13
        '
        'lblColorFondo
        '
        Me.lblColorFondo.Location = New System.Drawing.Point(106, 142)
        Me.lblColorFondo.Name = "lblColorFondo"
        Me.lblColorFondo.Size = New System.Drawing.Size(75, 13)
        Me.lblColorFondo.TabIndex = 12
        Me.lblColorFondo.Text = "Color de fondo:"
        '
        'lblColorFuente
        '
        Me.lblColorFuente.Location = New System.Drawing.Point(106, 116)
        Me.lblColorFuente.Name = "lblColorFuente"
        Me.lblColorFuente.Size = New System.Drawing.Size(79, 13)
        Me.lblColorFuente.TabIndex = 11
        Me.lblColorFuente.Text = "Color de fuente:"
        '
        'chkSubrayado
        '
        Me.chkSubrayado.Location = New System.Drawing.Point(12, 164)
        Me.chkSubrayado.Name = "chkSubrayado"
        Me.chkSubrayado.Properties.Caption = "Subrayado"
        Me.chkSubrayado.Size = New System.Drawing.Size(75, 19)
        Me.chkSubrayado.TabIndex = 10
        '
        'chkCursiva
        '
        Me.chkCursiva.Location = New System.Drawing.Point(12, 139)
        Me.chkCursiva.Name = "chkCursiva"
        Me.chkCursiva.Properties.Caption = "Cursiva"
        Me.chkCursiva.Size = New System.Drawing.Size(126, 19)
        Me.chkCursiva.TabIndex = 9
        '
        'chkNegrita
        '
        Me.chkNegrita.Location = New System.Drawing.Point(12, 114)
        Me.chkNegrita.Name = "chkNegrita"
        Me.chkNegrita.Properties.Caption = "Negrita"
        Me.chkNegrita.Size = New System.Drawing.Size(126, 19)
        Me.chkNegrita.TabIndex = 8
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(437, 55)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 7
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(437, 28)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 6
        '
        'lblValor2
        '
        Me.lblValor2.Location = New System.Drawing.Point(368, 58)
        Me.lblValor2.Name = "lblValor2"
        Me.lblValor2.Size = New System.Drawing.Size(37, 13)
        Me.lblValor2.TabIndex = 5
        Me.lblValor2.Text = "Valor 2:"
        '
        'lblValor1
        '
        Me.lblValor1.Location = New System.Drawing.Point(368, 32)
        Me.lblValor1.Name = "lblValor1"
        Me.lblValor1.Size = New System.Drawing.Size(37, 13)
        Me.lblValor1.TabIndex = 4
        Me.lblValor1.Text = "Valor 1:"
        '
        'cboCondicion
        '
        Me.cboCondicion.Location = New System.Drawing.Point(91, 55)
        Me.cboCondicion.Name = "cboCondicion"
        Me.cboCondicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCondicion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCondicion.Size = New System.Drawing.Size(261, 20)
        Me.cboCondicion.TabIndex = 3
        '
        'lblCondicion
        '
        Me.lblCondicion.Location = New System.Drawing.Point(14, 58)
        Me.lblCondicion.Name = "lblCondicion"
        Me.lblCondicion.Size = New System.Drawing.Size(50, 13)
        Me.lblCondicion.TabIndex = 2
        Me.lblCondicion.Text = "Condición:"
        '
        'lblColumna
        '
        Me.lblColumna.Location = New System.Drawing.Point(14, 32)
        Me.lblColumna.Name = "lblColumna"
        Me.lblColumna.Size = New System.Drawing.Size(45, 13)
        Me.lblColumna.TabIndex = 0
        Me.lblColumna.Text = "Columna:"
        '
        'il16x16
        '
        Me.il16x16.ImageStream = CType(resources.GetObject("il16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.il16x16.Images.SetKeyName(0, "img001")
        Me.il16x16.Images.SetKeyName(1, "img002")
        '
        'grpFormatos
        '
        Me.grpFormatos.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFormatos.Appearance.Options.UseFont = True
        Me.grpFormatos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFormatos.AppearanceCaption.Options.UseFont = True
        Me.grpFormatos.Controls.Add(Me.cmdEliminar)
        Me.grpFormatos.Controls.Add(Me.pc001)
        Me.grpFormatos.Location = New System.Drawing.Point(13, 242)
        Me.grpFormatos.Name = "grpFormatos"
        Me.grpFormatos.Size = New System.Drawing.Size(659, 175)
        Me.grpFormatos.TabIndex = 1
        Me.grpFormatos.Text = "Formatos condicionales ingresados"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(5, 139)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(38, 26)
        Me.cmdEliminar.TabIndex = 13
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.lvFormatos)
        Me.pc001.Location = New System.Drawing.Point(5, 23)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(649, 110)
        Me.pc001.TabIndex = 11
        '
        'lvFormatos
        '
        Me.lvFormatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvFormatos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002, Me.col003, Me.col004})
        Me.lvFormatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvFormatos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFormatos.FullRowSelect = True
        Me.lvFormatos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvFormatos.HideSelection = False
        Me.lvFormatos.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvFormatos.Location = New System.Drawing.Point(2, 2)
        Me.lvFormatos.MultiSelect = False
        Me.lvFormatos.Name = "lvFormatos"
        Me.lvFormatos.Size = New System.Drawing.Size(645, 106)
        Me.lvFormatos.SmallImageList = Me.il16x16
        Me.lvFormatos.TabIndex = 6
        Me.lvFormatos.TileSize = New System.Drawing.Size(450, 36)
        Me.lvFormatos.UseCompatibleStateImageBehavior = False
        Me.lvFormatos.View = System.Windows.Forms.View.Details
        '
        'col001
        '
        Me.col001.Text = "Columna"
        Me.col001.Width = 194
        '
        'col002
        '
        Me.col002.Text = "Condición"
        Me.col002.Width = 200
        '
        'col003
        '
        Me.col003.Text = "Valor 1"
        Me.col003.Width = 96
        '
        'col004
        '
        Me.col004.Text = "Valor 2"
        Me.col004.Width = 92
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(575, 435)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCerrar.TabIndex = 8
        Me.cmdCerrar.Text = "C&errar"
        '
        'frmFormatoCondicional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(684, 473)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.grpFormatos)
        Me.Controls.Add(Me.grpDatosFormato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFormatoCondicional"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formato condicional"
        CType(Me.grpDatosFormato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosFormato.ResumeLayout(False)
        Me.grpDatosFormato.PerformLayout()
        CType(Me.cboColumna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTachado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTotalPersonalizadoCelda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGranTotalCelda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSubtotalCelda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCelda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDegradado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboColorFondo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboColorFondo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboColorFuente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSubrayado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCursiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNegrita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCondicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFormatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFormatos.ResumeLayout(False)
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatosFormato As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpFormatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboCondicion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblCondicion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblColumna As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboColorFondo As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents cboColorFuente As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents lblColorFondo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblColorFuente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSubrayado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCursiva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNegrita As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtValor2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValor1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValor2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValor1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents il16x16 As System.Windows.Forms.ImageList
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lvFormatos As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col003 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col004 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboDegradado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblDegradado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboColorFondo2 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents lblColorFondo2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAplicaA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFormato As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkTachado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTotalPersonalizadoCelda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGranTotalCelda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSubtotalCelda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCelda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboColumna As DevExpress.XtraEditors.ComboBoxEdit
End Class
