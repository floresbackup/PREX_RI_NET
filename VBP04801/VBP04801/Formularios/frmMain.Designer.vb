<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.  
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblTransaccion = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAyuda = New System.Windows.Forms.ToolStripButton()
        Me.tsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblVersion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabDiseno = New System.Windows.Forms.TabControl()
        Me.tabTablas = New System.Windows.Forms.TabPage()
        Me.PanGridDiseno = New System.Windows.Forms.Panel()
        Me.GridDiseno = New DevExpress.XtraGrid.GridControl()
        Me.gDiseno = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCampodestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCampo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colLongitud = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colFin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodEnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClave = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.PanTool = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTabla1 = New System.Windows.Forms.ComboBox()
        Me.cboPeriodo1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminarTabla1 = New System.Windows.Forms.Button()
        Me.btnOtra1 = New System.Windows.Forms.Button()
        Me.chkTodas = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.PanGridResult = New System.Windows.Forms.Panel()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.gResult = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanOrigen = New System.Windows.Forms.Panel()
        Me.chkEqui = New System.Windows.Forms.CheckBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnExportarResult = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimirResult = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRegistros = New System.Windows.Forms.ToolStripLabel()
        Me.txtCantidad = New System.Windows.Forms.ToolStripTextBox()
        Me.lblSep = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSep = New System.Windows.Forms.TextBox()
        Me.txtCualif = New System.Windows.Forms.TextBox()
        Me.txtSymbol = New System.Windows.Forms.TextBox()
        Me.cmdCancelarVP = New System.Windows.Forms.Button()
        Me.cmdIncorporar = New System.Windows.Forms.Button()
        Me.cmdExaminar = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkEncabezado = New System.Windows.Forms.CheckBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DsTabla = New VBP04801.dsTabla()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSolapaAnt = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSolapaSig = New DevExpress.XtraEditors.SimpleButton()
        Me.sbMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabDiseno.SuspendLayout()
        Me.tabTablas.SuspendLayout()
        Me.PanGridDiseno.SuspendLayout()
        CType(Me.GridDiseno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gDiseno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTool.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.PanGridResult.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanOrigen.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.DsTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
        Me.sbMain.Location = New System.Drawing.Point(0, 425)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(685, 25)
        Me.sbMain.TabIndex = 8
        '
        'lblUsuario
        '
        Me.lblUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblUsuario.Image = Global.VBP04801.My.Resources.Resources.Messenger_Information
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(531, 20)
        Me.lblUsuario.Spring = True
        Me.lblUsuario.Text = "Sebastián Buceta"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntidad
        '
        Me.lblEntidad.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblEntidad.Image = Global.VBP04801.My.Resources.Resources.Home
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(139, 20)
        Me.lblEntidad.Text = "Banco de Prueba S.A."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTransaccion, Me.btnSalir, Me.tsSep1, Me.btnAyuda, Me.tsSep2, Me.lblVersion, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(685, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblTransaccion
        '
        Me.lblTransaccion.Image = Global.VBP04801.My.Resources.Resources.About
        Me.lblTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransaccion.Name = "lblTransaccion"
        Me.lblTransaccion.Size = New System.Drawing.Size(87, 22)
        Me.lblTransaccion.Text = "Transacción"
        Me.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.VBP04801.My.Resources.Resources.Cross
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 22)
        Me.btnSalir.Text = " Salir"
        '
        'tsSep1
        '
        Me.tsSep1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep1.Name = "tsSep1"
        Me.tsSep1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAyuda
        '
        Me.btnAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAyuda.Image = Global.VBP04801.My.Resources.Resources.Help_2
        Me.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(64, 22)
        Me.btnAyuda.Text = " Ayuda"
        '
        'tsSep2
        '
        Me.tsSep2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep2.Name = "tsSep2"
        Me.tsSep2.Size = New System.Drawing.Size(6, 25)
        '
        'lblVersion
        '
        Me.lblVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(76, 22)
        Me.lblVersion.Text = "Versión: 1.0.0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'TabDiseno
        '
        Me.TabDiseno.Controls.Add(Me.tabTablas)
        Me.TabDiseno.Controls.Add(Me.tabDatos)
        Me.TabDiseno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDiseno.Location = New System.Drawing.Point(0, 0)
        Me.TabDiseno.Margin = New System.Windows.Forms.Padding(0)
        Me.TabDiseno.Name = "TabDiseno"
        Me.TabDiseno.SelectedIndex = 0
        Me.TabDiseno.Size = New System.Drawing.Size(685, 370)
        Me.TabDiseno.TabIndex = 13
        '
        'tabTablas
        '
        Me.tabTablas.Controls.Add(Me.PanGridDiseno)
        Me.tabTablas.Controls.Add(Me.PanTool)
        Me.tabTablas.Location = New System.Drawing.Point(4, 22)
        Me.tabTablas.Name = "tabTablas"
        Me.tabTablas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTablas.Size = New System.Drawing.Size(677, 344)
        Me.tabTablas.TabIndex = 0
        Me.tabTablas.Text = "Diseño de tablas"
        Me.tabTablas.UseVisualStyleBackColor = True
        '
        'PanGridDiseno
        '
        Me.PanGridDiseno.Controls.Add(Me.GridDiseno)
        Me.PanGridDiseno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanGridDiseno.Location = New System.Drawing.Point(3, 80)
        Me.PanGridDiseno.Name = "PanGridDiseno"
        Me.PanGridDiseno.Size = New System.Drawing.Size(671, 261)
        Me.PanGridDiseno.TabIndex = 18
        '
        'GridDiseno
        '
        Me.GridDiseno.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridDiseno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiseno.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridDiseno.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridDiseno.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridDiseno.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridDiseno.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridDiseno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDiseno.Location = New System.Drawing.Point(0, 0)
        Me.GridDiseno.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GridDiseno.LookAndFeel.UseWindowsXPTheme = True
        Me.GridDiseno.MainView = Me.gDiseno
        Me.GridDiseno.Name = "GridDiseno"
        Me.GridDiseno.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1, Me.RepositoryItemSpinEdit2, Me.RepositoryItemSpinEdit3})
        Me.GridDiseno.Size = New System.Drawing.Size(671, 261)
        Me.GridDiseno.TabIndex = 15
        Me.GridDiseno.UseEmbeddedNavigator = True
        Me.GridDiseno.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gDiseno})
        '
        'gDiseno
        '
        Me.gDiseno.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCampodestino, Me.colNombre, Me.colCampo, Me.colInicio, Me.colLongitud, Me.colFin, Me.colRelacion, Me.colTipo, Me.colFormato, Me.colMarca, Me.colValida, Me.colCodEnt, Me.colFecha, Me.colClave})
        Me.gDiseno.GridControl = Me.GridDiseno
        Me.gDiseno.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.gDiseno.Name = "gDiseno"
        Me.gDiseno.OptionsMenu.EnableColumnMenu = False
        Me.gDiseno.OptionsView.ColumnAutoWidth = False
        Me.gDiseno.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gDiseno.OptionsView.ShowGroupPanel = False
        Me.gDiseno.PaintStyleName = "WindowsXP"
        Me.gDiseno.RowHeight = 19
        '
        'colCampodestino
        '
        Me.colCampodestino.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCampodestino.AppearanceCell.Options.UseBackColor = True
        Me.colCampodestino.Caption = "Nombre de campo"
        Me.colCampodestino.FieldName = "Campo destino"
        Me.colCampodestino.Name = "colCampodestino"
        Me.colCampodestino.Visible = True
        Me.colCampodestino.VisibleIndex = 0
        Me.colCampodestino.Width = 120
        '
        'colNombre
        '
        Me.colNombre.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNombre.AppearanceCell.Options.UseBackColor = True
        Me.colNombre.Caption = "Nombre de campo"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Width = 120
        '
        'colCampo
        '
        Me.colCampo.Caption = "Campo"
        Me.colCampo.FieldName = "Campo"
        Me.colCampo.Name = "colCampo"
        Me.colCampo.Visible = True
        Me.colCampo.VisibleIndex = 1
        Me.colCampo.Width = 200
        '
        'colInicio
        '
        Me.colInicio.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInicio.AppearanceCell.Options.UseBackColor = True
        Me.colInicio.Caption = "Inicio"
        Me.colInicio.ColumnEdit = Me.RepositoryItemSpinEdit2
        Me.colInicio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInicio.FieldName = "Inicio"
        Me.colInicio.Name = "colInicio"
        Me.colInicio.Visible = True
        Me.colInicio.VisibleIndex = 2
        Me.colInicio.Width = 50
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit2.IsFloatValue = False
        Me.RepositoryItemSpinEdit2.Mask.EditMask = "N00"
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'colLongitud
        '
        Me.colLongitud.Caption = "Longitud"
        Me.colLongitud.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colLongitud.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLongitud.FieldName = "Longitud"
        Me.colLongitud.Name = "colLongitud"
        Me.colLongitud.Visible = True
        Me.colLongitud.VisibleIndex = 3
        Me.colLongitud.Width = 50
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.IsFloatValue = False
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "N00"
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {999, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colFin
        '
        Me.colFin.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colFin.AppearanceCell.Options.UseBackColor = True
        Me.colFin.Caption = "Fin"
        Me.colFin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFin.FieldName = "Fin"
        Me.colFin.Name = "colFin"
        Me.colFin.OptionsColumn.AllowEdit = False
        Me.colFin.Visible = True
        Me.colFin.VisibleIndex = 4
        Me.colFin.Width = 50
        '
        'colRelacion
        '
        Me.colRelacion.Caption = "Relacion"
        Me.colRelacion.FieldName = "Relacion"
        Me.colRelacion.Name = "colRelacion"
        Me.colRelacion.Visible = True
        Me.colRelacion.VisibleIndex = 7
        Me.colRelacion.Width = 100
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo dato"
        Me.colTipo.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(), New DevExpress.XtraGrid.GridColumnSummaryItem()})
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 5
        Me.colTipo.Width = 100
        '
        'colFormato
        '
        Me.colFormato.Caption = "Formato"
        Me.colFormato.FieldName = "Formato"
        Me.colFormato.Name = "colFormato"
        Me.colFormato.Visible = True
        Me.colFormato.VisibleIndex = 6
        '
        'colMarca
        '
        Me.colMarca.Caption = "Marca"
        Me.colMarca.FieldName = "Marca"
        Me.colMarca.Name = "colMarca"
        '
        'colValida
        '
        Me.colValida.Caption = "Validar"
        Me.colValida.FieldName = "Valida"
        Me.colValida.Name = "colValida"
        Me.colValida.Visible = True
        Me.colValida.VisibleIndex = 8
        Me.colValida.Width = 120
        '
        'colCodEnt
        '
        Me.colCodEnt.Caption = "CodEnt"
        Me.colCodEnt.FieldName = "CodEnt"
        Me.colCodEnt.Name = "colCodEnt"
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        '
        'colClave
        '
        Me.colClave.Caption = "Nº de Clave"
        Me.colClave.FieldName = "Clave"
        Me.colClave.Name = "colClave"
        Me.colClave.Visible = True
        Me.colClave.VisibleIndex = 9
        Me.colClave.Width = 100
        '
        'RepositoryItemSpinEdit3
        '
        Me.RepositoryItemSpinEdit3.AutoHeight = False
        Me.RepositoryItemSpinEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit3.IsFloatValue = False
        Me.RepositoryItemSpinEdit3.Mask.EditMask = "N00"
        Me.RepositoryItemSpinEdit3.MaxValue = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.RepositoryItemSpinEdit3.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit3.Name = "RepositoryItemSpinEdit3"
        '
        'PanTool
        '
        Me.PanTool.Controls.Add(Me.TableLayoutPanel1)
        Me.PanTool.Controls.Add(Me.ToolStrip2)
        Me.PanTool.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTool.Location = New System.Drawing.Point(3, 3)
        Me.PanTool.Name = "PanTool"
        Me.PanTool.Size = New System.Drawing.Size(671, 77)
        Me.PanTool.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 471.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboTabla1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboPeriodo1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(671, 52)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tabla:"
        '
        'cboTabla1
        '
        Me.cboTabla1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTabla1.FormattingEnabled = True
        Me.cboTabla1.Location = New System.Drawing.Point(53, 3)
        Me.cboTabla1.Name = "cboTabla1"
        Me.cboTabla1.Size = New System.Drawing.Size(194, 21)
        Me.cboTabla1.TabIndex = 1
        '
        'cboPeriodo1
        '
        Me.cboPeriodo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboPeriodo1.FormattingEnabled = True
        Me.cboPeriodo1.Location = New System.Drawing.Point(53, 28)
        Me.cboPeriodo1.Name = "cboPeriodo1"
        Me.cboPeriodo1.Size = New System.Drawing.Size(194, 21)
        Me.cboPeriodo1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEliminarTabla1)
        Me.Panel1.Controls.Add(Me.btnOtra1)
        Me.Panel1.Controls.Add(Me.chkTodas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(250, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 25)
        Me.Panel1.TabIndex = 4
        '
        'btnEliminarTabla1
        '
        Me.btnEliminarTabla1.Enabled = False
        Me.btnEliminarTabla1.Location = New System.Drawing.Point(186, 2)
        Me.btnEliminarTabla1.Name = "btnEliminarTabla1"
        Me.btnEliminarTabla1.Size = New System.Drawing.Size(100, 20)
        Me.btnEliminarTabla1.TabIndex = 2
        Me.btnEliminarTabla1.Text = "&Eliminar tabla"
        Me.btnEliminarTabla1.UseVisualStyleBackColor = True
        '
        'btnOtra1
        '
        Me.btnOtra1.Location = New System.Drawing.Point(80, 2)
        Me.btnOtra1.Name = "btnOtra1"
        Me.btnOtra1.Size = New System.Drawing.Size(100, 20)
        Me.btnOtra1.TabIndex = 1
        Me.btnOtra1.Text = "Ver &otra tabla"
        Me.btnOtra1.UseVisualStyleBackColor = True
        '
        'chkTodas
        '
        Me.chkTodas.AutoSize = True
        Me.chkTodas.Location = New System.Drawing.Point(3, 5)
        Me.chkTodas.Name = "chkTodas"
        Me.chkTodas.Size = New System.Drawing.Size(71, 17)
        Me.chkTodas.TabIndex = 0
        Me.chkTodas.Text = "&Ver todas"
        Me.chkTodas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Período:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.ToolStripSeparator1, Me.btnImprimir, Me.btnExportar, Me.ToolStripSeparator5})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(671, 25)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.VBP04801.My.Resources.Resources.Save
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipText = "Guardar el diseño actual"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = Global.VBP04801.My.Resources.Resources.Print
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(23, 22)
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipText = "Vista Previa de impresión"
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.VBP04801.My.Resources.Resources.Export_Excel1
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 22)
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.ToolTipText = "Exportar grilla"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.PanGridResult)
        Me.tabDatos.Controls.Add(Me.PanOrigen)
        Me.tabDatos.Location = New System.Drawing.Point(4, 22)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatos.Size = New System.Drawing.Size(677, 344)
        Me.tabDatos.TabIndex = 1
        Me.tabDatos.Text = "Incorporar datos"
        Me.tabDatos.UseVisualStyleBackColor = True
        '
        'PanGridResult
        '
        Me.PanGridResult.Controls.Add(Me.Grid)
        Me.PanGridResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanGridResult.Location = New System.Drawing.Point(3, 139)
        Me.PanGridResult.Name = "PanGridResult"
        Me.PanGridResult.Size = New System.Drawing.Size(671, 202)
        Me.PanGridResult.TabIndex = 1
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.Grid.LookAndFeel.UseWindowsXPTheme = True
        Me.Grid.MainView = Me.gResult
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(671, 202)
        Me.Grid.TabIndex = 15
        Me.Grid.UseEmbeddedNavigator = True
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gResult})
        '
        'gResult
        '
        Me.gResult.GridControl = Me.Grid
        Me.gResult.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.gResult.Name = "gResult"
        Me.gResult.OptionsMenu.EnableColumnMenu = False
        Me.gResult.OptionsView.ColumnAutoWidth = False
        Me.gResult.OptionsView.ShowGroupPanel = False
        Me.gResult.PaintStyleName = "WindowsXP"
        Me.gResult.RowHeight = 19
        '
        'PanOrigen
        '
        Me.PanOrigen.Controls.Add(Me.chkEqui)
        Me.PanOrigen.Controls.Add(Me.ToolStrip3)
        Me.PanOrigen.Controls.Add(Me.lblSep)
        Me.PanOrigen.Controls.Add(Me.Label4)
        Me.PanOrigen.Controls.Add(Me.txtSep)
        Me.PanOrigen.Controls.Add(Me.txtCualif)
        Me.PanOrigen.Controls.Add(Me.txtSymbol)
        Me.PanOrigen.Controls.Add(Me.cmdCancelarVP)
        Me.PanOrigen.Controls.Add(Me.cmdIncorporar)
        Me.PanOrigen.Controls.Add(Me.cmdExaminar)
        Me.PanOrigen.Controls.Add(Me.txtFecha)
        Me.PanOrigen.Controls.Add(Me.chkEncabezado)
        Me.PanOrigen.Controls.Add(Me.cboTipo)
        Me.PanOrigen.Controls.Add(Me.txtOrigen)
        Me.PanOrigen.Controls.Add(Me.Label3)
        Me.PanOrigen.Controls.Add(Me.Label2)
        Me.PanOrigen.Controls.Add(Me.Label1)
        Me.PanOrigen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanOrigen.Location = New System.Drawing.Point(3, 3)
        Me.PanOrigen.Name = "PanOrigen"
        Me.PanOrigen.Size = New System.Drawing.Size(671, 136)
        Me.PanOrigen.TabIndex = 0
        '
        'chkEqui
        '
        Me.chkEqui.AutoSize = True
        Me.chkEqui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEqui.Location = New System.Drawing.Point(118, 26)
        Me.chkEqui.Name = "chkEqui"
        Me.chkEqui.Size = New System.Drawing.Size(243, 17)
        Me.chkEqui.TabIndex = 18
        Me.chkEqui.Text = "&Procesar reemplazos de equivalencias"
        Me.chkEqui.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportarResult, Me.btnImprimirResult, Me.ToolStripSeparator7, Me.lblRegistros, Me.txtCantidad})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 111)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(671, 25)
        Me.ToolStrip3.TabIndex = 17
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnExportarResult
        '
        Me.btnExportarResult.Image = Global.VBP04801.My.Resources.Resources.Export_Excel1
        Me.btnExportarResult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarResult.Name = "btnExportarResult"
        Me.btnExportarResult.Size = New System.Drawing.Size(70, 22)
        Me.btnExportarResult.Text = "Exportar"
        '
        'btnImprimirResult
        '
        Me.btnImprimirResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimirResult.Image = Global.VBP04801.My.Resources.Resources.Print
        Me.btnImprimirResult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirResult.Name = "btnImprimirResult"
        Me.btnImprimirResult.Size = New System.Drawing.Size(23, 22)
        Me.btnImprimirResult.Text = "Vista previa de impresión"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'lblRegistros
        '
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(243, 22)
        Me.lblRegistros.Text = "Cantidad de registros a visualizar (0=Todos): "
        '
        'txtCantidad
        '
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(50, 25)
        Me.txtCantidad.Text = "100"
        '
        'lblSep
        '
        Me.lblSep.AutoSize = True
        Me.lblSep.Location = New System.Drawing.Point(359, 78)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(96, 13)
        Me.lblSep.TabIndex = 16
        Me.lblSep.Text = "Sep./Cualif. Texto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Símbolo decimal:"
        '
        'txtSep
        '
        Me.txtSep.Location = New System.Drawing.Point(455, 75)
        Me.txtSep.Name = "txtSep"
        Me.txtSep.Size = New System.Drawing.Size(32, 20)
        Me.txtSep.TabIndex = 10
        Me.txtSep.Text = ";"
        '
        'txtCualif
        '
        Me.txtCualif.Location = New System.Drawing.Point(489, 75)
        Me.txtCualif.Name = "txtCualif"
        Me.txtCualif.Size = New System.Drawing.Size(33, 20)
        Me.txtCualif.TabIndex = 11
        Me.txtCualif.Text = """"
        '
        'txtSymbol
        '
        Me.txtSymbol.Location = New System.Drawing.Point(455, 50)
        Me.txtSymbol.Name = "txtSymbol"
        Me.txtSymbol.Size = New System.Drawing.Size(68, 20)
        Me.txtSymbol.TabIndex = 9
        Me.txtSymbol.Text = "."
        '
        'cmdCancelarVP
        '
        Me.cmdCancelarVP.Location = New System.Drawing.Point(529, 74)
        Me.cmdCancelarVP.Name = "cmdCancelarVP"
        Me.cmdCancelarVP.Size = New System.Drawing.Size(75, 21)
        Me.cmdCancelarVP.TabIndex = 15
        Me.cmdCancelarVP.Text = "&Cancelar"
        Me.cmdCancelarVP.UseVisualStyleBackColor = True
        '
        'cmdIncorporar
        '
        Me.cmdIncorporar.Location = New System.Drawing.Point(529, 49)
        Me.cmdIncorporar.Name = "cmdIncorporar"
        Me.cmdIncorporar.Size = New System.Drawing.Size(75, 21)
        Me.cmdIncorporar.TabIndex = 14
        Me.cmdIncorporar.Text = "&Vista previa"
        Me.cmdIncorporar.UseVisualStyleBackColor = True
        '
        'cmdExaminar
        '
        Me.cmdExaminar.Location = New System.Drawing.Point(529, 4)
        Me.cmdExaminar.Name = "cmdExaminar"
        Me.cmdExaminar.Size = New System.Drawing.Size(75, 21)
        Me.cmdExaminar.TabIndex = 13
        Me.cmdExaminar.Text = "E&xaminar..."
        Me.cmdExaminar.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.CustomFormat = "dd/MM/yyyy"
        Me.txtFecha.Location = New System.Drawing.Point(118, 46)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(235, 20)
        Me.txtFecha.TabIndex = 7
        Me.txtFecha.Value = New Date(2009, 11, 12, 0, 0, 0, 0)
        '
        'chkEncabezado
        '
        Me.chkEncabezado.AutoSize = True
        Me.chkEncabezado.Location = New System.Drawing.Point(118, 92)
        Me.chkEncabezado.Name = "chkEncabezado"
        Me.chkEncabezado.Size = New System.Drawing.Size(235, 17)
        Me.chkEncabezado.TabIndex = 12
        Me.chkEncabezado.Text = "&La primera linea corresponde al encabezado"
        Me.chkEncabezado.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(118, 70)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(235, 21)
        Me.cboTipo.TabIndex = 8
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(118, 4)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(405, 20)
        Me.txtOrigen.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo de archivo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha a incorporar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Orígen de datos:"
        '
        'DsTabla
        '
        Me.DsTabla.DataSetName = "dsTabla"
        Me.DsTabla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TabDiseno, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(685, 400)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSolapaAnt)
        Me.Panel2.Controls.Add(Me.btnSolapaSig)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 370)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(685, 30)
        Me.Panel2.TabIndex = 14
        '
        'btnSolapaAnt
        '
        Me.btnSolapaAnt.Enabled = False
        Me.btnSolapaAnt.Location = New System.Drawing.Point(525, 4)
        Me.btnSolapaAnt.Name = "btnSolapaAnt"
        Me.btnSolapaAnt.Size = New System.Drawing.Size(75, 23)
        Me.btnSolapaAnt.TabIndex = 16
        Me.btnSolapaAnt.Text = "< &Anterior"
        '
        'btnSolapaSig
        '
        Me.btnSolapaSig.Location = New System.Drawing.Point(606, 4)
        Me.btnSolapaSig.Name = "btnSolapaSig"
        Me.btnSolapaSig.Size = New System.Drawing.Size(75, 23)
        Me.btnSolapaSig.TabIndex = 15
        Me.btnSolapaSig.Text = "&Siguiente >"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 450)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.sbMain)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabDiseno.ResumeLayout(False)
        Me.tabTablas.ResumeLayout(False)
        Me.PanGridDiseno.ResumeLayout(False)
        CType(Me.GridDiseno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gDiseno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTool.ResumeLayout(False)
        Me.PanTool.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.tabDatos.ResumeLayout(False)
        Me.PanGridResult.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanOrigen.ResumeLayout(False)
        Me.PanOrigen.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.DsTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblEntidad As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTransaccion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAyuda As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabDiseno As System.Windows.Forms.TabControl
    Friend WithEvents tabTablas As System.Windows.Forms.TabPage
    Friend WithEvents PanTool As System.Windows.Forms.Panel
    Friend WithEvents tabDatos As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PanGridResult As System.Windows.Forms.Panel
    Friend WithEvents PanOrigen As System.Windows.Forms.Panel
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkEncabezado As System.Windows.Forms.CheckBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelarVP As System.Windows.Forms.Button
    Friend WithEvents cmdIncorporar As System.Windows.Forms.Button
    Friend WithEvents cmdExaminar As System.Windows.Forms.Button
    Friend WithEvents lblSep As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSep As System.Windows.Forms.TextBox
    Friend WithEvents txtCualif As System.Windows.Forms.TextBox
    Friend WithEvents txtSymbol As System.Windows.Forms.TextBox
    Friend WithEvents DsTabla As VBP04801.dsTabla
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnExportarResult As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimirResult As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblRegistros As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtCantidad As System.Windows.Forms.ToolStripTextBox
    Private WithEvents Grid As DevExpress.XtraGrid.GridControl
    Private WithEvents gResult As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents cboTabla1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboPeriodo1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkTodas As CheckBox
    Friend WithEvents btnEliminarTabla1 As Button
    Friend WithEvents btnOtra1 As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PanGridDiseno As Panel
    Private WithEvents GridDiseno As DevExpress.XtraGrid.GridControl
    Private WithEvents gDiseno As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents colCampodestino As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colCampo As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colInicio As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colLongitud As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colFin As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colRelacion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colFormato As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colMarca As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colValida As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colCodEnt As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colClave As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSolapaAnt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSolapaSig As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkEqui As CheckBox
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
