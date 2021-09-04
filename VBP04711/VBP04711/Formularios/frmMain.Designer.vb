<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.Skin = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
		Me.PanControles = New DevExpress.XtraEditors.PanelControl()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtAcciones = New DevExpress.XtraEditors.TextEdit()
		Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
		Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
		Me.txtCodigosTransaccion = New DevExpress.XtraEditors.TextEdit()
		Me.cmdConsultar = New DevExpress.XtraEditors.SimpleButton()
		Me.cmdBuscarAcciones = New DevExpress.XtraEditors.SimpleButton()
		Me.txtHasta = New DevExpress.XtraEditors.DateEdit()
		Me.txtDesde = New DevExpress.XtraEditors.DateEdit()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PanTop = New DevExpress.XtraEditors.PanelControl()
		Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
		Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
		Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
		Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
		Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
		Me.GridDiseno = New DevExpress.XtraGrid.GridControl()
		Me.gDiseno = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colEstacionTrabajo = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHora = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCodTrans = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colTransaccion = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colAccion = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.RepositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
		Me.PanGrid = New DevExpress.XtraEditors.PanelControl()
		Me.PanGrilla = New DevExpress.XtraEditors.PanelControl()
		Me.PanTool = New DevExpress.XtraEditors.PanelControl()
		Me.ToolBarra = New System.Windows.Forms.ToolStrip()
		Me.btnNuevaConsulta = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
		Me.btnExportar = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnVerAdjunto = New System.Windows.Forms.ToolStripButton()
		Me.ToolTipText = New System.Windows.Forms.ToolTip(Me.components)
		Me.colExtra = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.PanControles, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanControles.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.txtAcciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCodigosTransaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanTop.SuspendLayout()
		CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridDiseno, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gDiseno, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PanGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanGrid.SuspendLayout()
		CType(Me.PanGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanGrilla.SuspendLayout()
		CType(Me.PanTool, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanTool.SuspendLayout()
		Me.ToolBarra.SuspendLayout()
		Me.SuspendLayout()
		'
		'Skin
		'
		Me.Skin.LookAndFeel.SkinName = "Black"
		'
		'PanControles
		'
		Me.PanControles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.PanControles.Controls.Add(Me.GroupBox1)
		Me.PanControles.Controls.Add(Me.PanTop)
		Me.PanControles.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanControles.Location = New System.Drawing.Point(0, 0)
		Me.PanControles.Name = "PanControles"
		Me.PanControles.Size = New System.Drawing.Size(635, 157)
		Me.PanControles.TabIndex = 0
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtAcciones)
		Me.GroupBox1.Controls.Add(Me.txtUsuario)
		Me.GroupBox1.Controls.Add(Me.txtDescripcion)
		Me.GroupBox1.Controls.Add(Me.txtCodigosTransaccion)
		Me.GroupBox1.Controls.Add(Me.cmdConsultar)
		Me.GroupBox1.Controls.Add(Me.cmdBuscarAcciones)
		Me.GroupBox1.Controls.Add(Me.txtHasta)
		Me.GroupBox1.Controls.Add(Me.txtDesde)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
		Me.GroupBox1.Location = New System.Drawing.Point(0, 54)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(635, 103)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Filtros de la consulta"
		'
		'txtAcciones
		'
		Me.txtAcciones.Location = New System.Drawing.Point(92, 68)
		Me.txtAcciones.Name = "txtAcciones"
		Me.txtAcciones.Size = New System.Drawing.Size(71, 20)
		Me.txtAcciones.TabIndex = 7
		'
		'txtUsuario
		'
		Me.txtUsuario.Location = New System.Drawing.Point(376, 68)
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.Size = New System.Drawing.Size(171, 20)
		Me.txtUsuario.TabIndex = 7
		'
		'txtDescripcion
		'
		Me.txtDescripcion.Location = New System.Drawing.Point(376, 42)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(171, 20)
		Me.txtDescripcion.TabIndex = 6
		'
		'txtCodigosTransaccion
		'
		Me.txtCodigosTransaccion.Location = New System.Drawing.Point(376, 18)
		Me.txtCodigosTransaccion.Name = "txtCodigosTransaccion"
		Me.txtCodigosTransaccion.Size = New System.Drawing.Size(171, 20)
		Me.txtCodigosTransaccion.TabIndex = 5
		'
		'cmdConsultar
		'
		Me.cmdConsultar.Location = New System.Drawing.Point(553, 68)
		Me.cmdConsultar.Name = "cmdConsultar"
		Me.cmdConsultar.Size = New System.Drawing.Size(79, 23)
		Me.cmdConsultar.TabIndex = 8
		Me.cmdConsultar.Text = "&Consultar"
		'
		'cmdBuscarAcciones
		'
		Me.cmdBuscarAcciones.ImageOptions.Image = Global.VBP04711.My.Resources.Resources.edit_find_3
		Me.cmdBuscarAcciones.Location = New System.Drawing.Point(169, 66)
		Me.cmdBuscarAcciones.Name = "cmdBuscarAcciones"
		Me.cmdBuscarAcciones.Size = New System.Drawing.Size(23, 23)
		Me.cmdBuscarAcciones.TabIndex = 4
		'
		'txtHasta
		'
		Me.txtHasta.EditValue = Nothing
		Me.txtHasta.Location = New System.Drawing.Point(92, 44)
		Me.txtHasta.Name = "txtHasta"
		Me.txtHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtHasta.Size = New System.Drawing.Size(100, 20)
		Me.txtHasta.TabIndex = 2
		'
		'txtDesde
		'
		Me.txtDesde.EditValue = Nothing
		Me.txtDesde.Location = New System.Drawing.Point(92, 20)
		Me.txtDesde.Name = "txtDesde"
		Me.txtDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtDesde.Size = New System.Drawing.Size(100, 20)
		Me.txtDesde.TabIndex = 1
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(214, 71)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(147, 13)
		Me.Label4.TabIndex = 1
		Me.Label4.Text = "Nombre del usuario contiene:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(214, 47)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(156, 13)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Descripción de trans. contiene:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(214, 23)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(96, 13)
		Me.Label6.TabIndex = 3
		Me.Label6.Text = "Códigos de trans.:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 71)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 13)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Acciones:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 47)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(71, 13)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Hasta Fecha:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Desde Fecha:"
		'
		'PanTop
		'
		Me.PanTop.Appearance.BackColor = System.Drawing.Color.White
		Me.PanTop.Appearance.Options.UseBackColor = True
		Me.PanTop.Controls.Add(Me.lblSubtitulo)
		Me.PanTop.Controls.Add(Me.lblTitulo)
		Me.PanTop.Controls.Add(Me.picLogo)
		Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanTop.Location = New System.Drawing.Point(0, 0)
		Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
		Me.PanTop.Name = "PanTop"
		Me.PanTop.Size = New System.Drawing.Size(635, 54)
		Me.PanTop.TabIndex = 6
		'
		'lblSubtitulo
		'
		Me.lblSubtitulo.Location = New System.Drawing.Point(34, 29)
		Me.lblSubtitulo.Name = "lblSubtitulo"
		Me.lblSubtitulo.Size = New System.Drawing.Size(0, 13)
		Me.lblSubtitulo.TabIndex = 2
		'
		'lblTitulo
		'
		Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.lblTitulo.Appearance.Options.UseFont = True
		Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(0, 13)
		Me.lblTitulo.TabIndex = 1
		'
		'picLogo
		'
		Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
		Me.picLogo.EditValue = Global.VBP04711.My.Resources.Resources.logo_prex
		Me.picLogo.Location = New System.Drawing.Point(574, 2)
		Me.picLogo.Name = "picLogo"
		Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
		Me.picLogo.Properties.Appearance.Options.UseBackColor = True
		Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.picLogo.Size = New System.Drawing.Size(59, 50)
		Me.picLogo.TabIndex = 0
		'
		'PrintingSystem1
		'
		Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
		'
		'PrintableComponentLink1
		'
		Me.PrintableComponentLink1.Component = Me.GridDiseno
		Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
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
		Me.GridDiseno.Size = New System.Drawing.Size(635, 244)
		Me.GridDiseno.TabIndex = 16
		Me.GridDiseno.UseEmbeddedNavigator = True
		Me.GridDiseno.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gDiseno})
		'
		'gDiseno
		'
		Me.gDiseno.Appearance.Preview.Options.UseTextOptions = True
		Me.gDiseno.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
		Me.gDiseno.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colUsuario, Me.colEstacionTrabajo, Me.colFecha, Me.colHora, Me.colCodTrans, Me.colTransaccion, Me.colAccion})
		Me.gDiseno.GridControl = Me.GridDiseno
		Me.gDiseno.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
		Me.gDiseno.Name = "gDiseno"
		Me.gDiseno.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
		Me.gDiseno.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
		Me.gDiseno.OptionsBehavior.AllowValidationErrors = False
		Me.gDiseno.OptionsBehavior.Editable = False
		Me.gDiseno.OptionsBehavior.ReadOnly = True
		Me.gDiseno.OptionsMenu.EnableColumnMenu = False
		Me.gDiseno.OptionsPrint.PrintDetails = True
		Me.gDiseno.OptionsPrint.PrintPreview = True
		Me.gDiseno.OptionsView.AutoCalcPreviewLineCount = True
		Me.gDiseno.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
		Me.gDiseno.OptionsView.ShowPreview = True
		Me.gDiseno.PaintStyleName = "WindowsXP"
		Me.gDiseno.PreviewFieldName = "LS_EXTRA"
		Me.gDiseno.RowHeight = 19
		Me.gDiseno.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colId, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'colId
		'
		Me.colId.Caption = "Id"
		Me.colId.FieldName = "LS_SECUEN"
		Me.colId.Name = "colId"
		Me.colId.OptionsColumn.AllowEdit = False
		Me.colId.Visible = True
		Me.colId.VisibleIndex = 0
		'
		'colUsuario
		'
		Me.colUsuario.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.colUsuario.AppearanceCell.Options.UseFont = True
		Me.colUsuario.Caption = "Usuario"
		Me.colUsuario.FieldName = "US_DESCRI"
		Me.colUsuario.Name = "colUsuario"
		Me.colUsuario.OptionsColumn.AllowEdit = False
		Me.colUsuario.Visible = True
		Me.colUsuario.VisibleIndex = 1
		'
		'colEstacionTrabajo
		'
		Me.colEstacionTrabajo.Caption = "Estación de Trabajo"
		Me.colEstacionTrabajo.FieldName = "LS_WKSTAT"
		Me.colEstacionTrabajo.Name = "colEstacionTrabajo"
		Me.colEstacionTrabajo.OptionsColumn.AllowEdit = False
		Me.colEstacionTrabajo.Visible = True
		Me.colEstacionTrabajo.VisibleIndex = 2
		'
		'colFecha
		'
		Me.colFecha.Caption = "Fecha"
		Me.colFecha.DisplayFormat.FormatString = "MMM/d/yyyy"
		Me.colFecha.FieldName = "LS_FECLOG"
		Me.colFecha.Name = "colFecha"
		Me.colFecha.OptionsColumn.AllowEdit = False
		Me.colFecha.Visible = True
		Me.colFecha.VisibleIndex = 3
		'
		'colHora
		'
		Me.colHora.Caption = "Hora"
		Me.colHora.DisplayFormat.FormatString = "hh:mm tt"
		Me.colHora.FieldName = "LS_HORLOG"
		Me.colHora.Name = "colHora"
		Me.colHora.Visible = True
		Me.colHora.VisibleIndex = 4
		'
		'colCodTrans
		'
		Me.colCodTrans.Caption = "Cód. Trans."
		Me.colCodTrans.FieldName = "LS_CODTRA"
		Me.colCodTrans.Name = "colCodTrans"
		Me.colCodTrans.Visible = True
		Me.colCodTrans.VisibleIndex = 5
		'
		'colTransaccion
		'
		Me.colTransaccion.Caption = "Transacción"
		Me.colTransaccion.FieldName = "MU_TRANSA"
		Me.colTransaccion.Name = "colTransaccion"
		Me.colTransaccion.Visible = True
		Me.colTransaccion.VisibleIndex = 6
		'
		'colAccion
		'
		Me.colAccion.AppearanceCell.Options.UseTextOptions = True
		Me.colAccion.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None
		Me.colAccion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
		Me.colAccion.Caption = "Acción"
		Me.colAccion.FieldName = "TG_DESCRI"
		Me.colAccion.Name = "colAccion"
		Me.colAccion.Visible = True
		Me.colAccion.VisibleIndex = 7
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
		'PanGrid
		'
		Me.PanGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.PanGrid.Controls.Add(Me.PanGrilla)
		Me.PanGrid.Controls.Add(Me.PanTool)
		Me.PanGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanGrid.Location = New System.Drawing.Point(0, 157)
		Me.PanGrid.Name = "PanGrid"
		Me.PanGrid.Size = New System.Drawing.Size(635, 273)
		Me.PanGrid.TabIndex = 3
		'
		'PanGrilla
		'
		Me.PanGrilla.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.PanGrilla.Controls.Add(Me.GridDiseno)
		Me.PanGrilla.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanGrilla.Location = New System.Drawing.Point(0, 29)
		Me.PanGrilla.Name = "PanGrilla"
		Me.PanGrilla.Size = New System.Drawing.Size(635, 244)
		Me.PanGrilla.TabIndex = 1
		'
		'PanTool
		'
		Me.PanTool.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.PanTool.Controls.Add(Me.ToolBarra)
		Me.PanTool.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanTool.Location = New System.Drawing.Point(0, 0)
		Me.PanTool.Name = "PanTool"
		Me.PanTool.Size = New System.Drawing.Size(635, 29)
		Me.PanTool.TabIndex = 0
		'
		'ToolBarra
		'
		Me.ToolBarra.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolBarra.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ToolBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaConsulta, Me.ToolStripSeparator5, Me.btnImprimir, Me.btnExportar, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.btnVerAdjunto})
		Me.ToolBarra.Location = New System.Drawing.Point(0, 0)
		Me.ToolBarra.Name = "ToolBarra"
		Me.ToolBarra.Size = New System.Drawing.Size(635, 29)
		Me.ToolBarra.TabIndex = 0
		Me.ToolBarra.Text = "ToolStrip1"
		'
		'btnNuevaConsulta
		'
		Me.btnNuevaConsulta.Image = Global.VBP04711.My.Resources.Resources.document_new_5
		Me.btnNuevaConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
		Me.btnNuevaConsulta.Size = New System.Drawing.Size(115, 26)
		Me.btnNuevaConsulta.Text = "Nueva Consulta"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 29)
		'
		'btnImprimir
		'
		Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
		Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnImprimir.Name = "btnImprimir"
		Me.btnImprimir.Size = New System.Drawing.Size(91, 26)
		Me.btnImprimir.Text = "Vista previa"
		Me.btnImprimir.ToolTipText = "Vista previa impresión"
		'
		'btnExportar
		'
		Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
		Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnExportar.Name = "btnExportar"
		Me.btnExportar.Size = New System.Drawing.Size(75, 26)
		Me.btnExportar.Text = "Exportar"
		'
		'ToolStripButton2
		'
		Me.ToolStripButton2.Image = Global.VBP04711.My.Resources.Resources.Copy
		Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton2.Name = "ToolStripButton2"
		Me.ToolStripButton2.Size = New System.Drawing.Size(66, 26)
		Me.ToolStripButton2.Text = "Copiar"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
		'
		'btnVerAdjunto
		'
		Me.btnVerAdjunto.Image = Global.VBP04711.My.Resources.Resources.page_attach
		Me.btnVerAdjunto.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnVerAdjunto.Name = "btnVerAdjunto"
		Me.btnVerAdjunto.Size = New System.Drawing.Size(70, 26)
		Me.btnVerAdjunto.Text = "Ver Txts"
		'
		'colExtra
		'
		Me.colExtra.Caption = "Extra"
		Me.colExtra.FieldName = "LS_EXTRA"
		Me.colExtra.Name = "colExtra"
		Me.colExtra.Visible = True
		Me.colExtra.VisibleIndex = 6
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "GridColumn1"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(635, 430)
		Me.Controls.Add(Me.PanGrid)
		Me.Controls.Add(Me.PanControles)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmMain"
		Me.Text = "Gestión RI | 4711 - 02 - Consulta de LOG del sistema"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.PanControles, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanControles.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.txtAcciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCodigosTransaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanTop.ResumeLayout(False)
		Me.PanTop.PerformLayout()
		CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridDiseno, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gDiseno, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PanGrid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanGrid.ResumeLayout(False)
		CType(Me.PanGrilla, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanGrilla.ResumeLayout(False)
		CType(Me.PanTool, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanTool.ResumeLayout(False)
		Me.PanTool.PerformLayout()
		Me.ToolBarra.ResumeLayout(False)
		Me.ToolBarra.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Skin As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PanControles As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanGrid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanGrilla As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanTool As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ToolBarra As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTipText As System.Windows.Forms.ToolTip
    Friend WithEvents btnNuevaConsulta As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigosTransaccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdBuscarAcciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVerAdjunto As ToolStripButton
    Friend WithEvents cmdConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodTrans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransaccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtra As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridDiseno As DevExpress.XtraGrid.GridControl
    Private WithEvents gDiseno As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAcciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstacionTrabajo As DevExpress.XtraGrid.Columns.GridColumn
End Class
