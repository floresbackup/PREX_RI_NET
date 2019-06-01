<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolMain = New System.Windows.Forms.ToolStrip()
        Me.lblTransaccion = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAyuda = New System.Windows.Forms.ToolStripButton()
        Me.tsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblVersion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PanTop = New DevExpress.XtraEditors.PanelControl()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.tabResultados = New DevExpress.XtraTab.XtraTabPage()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.barResultado = New DevExpress.XtraBars.Bar()
        Me.cmdNuevaConsultaResultado = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdVistaPrevia = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdExportarResultado = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdCopiarResultados = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdColumnasResultados = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdMostrarAgrupamiento = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarToggleSwitchItem1 = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabParametros = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GridParametros = New DevExpress.XtraGrid.GridControl()
        Me.GridViewParametros = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodParametro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParametro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditorParametro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCD_HELP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEjecutarConsulta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAbrirConsulta = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblCategoriaConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescripcionConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNombreConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodigoConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.tabPanel = New DevExpress.XtraTab.XtraTabControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.sbMain.SuspendLayout()
        Me.toolMain.SuspendLayout()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTop.SuspendLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResultados.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabParametros.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GridParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
        Me.sbMain.Location = New System.Drawing.Point(0, 404)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(739, 25)
        Me.sbMain.SizingGrip = False
        Me.sbMain.TabIndex = 8
        '
        'lblUsuario
        '
        Me.lblUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblUsuario.Image = Global.VBP04000.My.Resources.Resources.Messenger_Information1
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(585, 20)
        Me.lblUsuario.Spring = True
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntidad
        '
        Me.lblEntidad.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblEntidad.Image = Global.VBP04000.My.Resources.Resources.Home
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(139, 20)
        Me.lblEntidad.Text = "Banco de Prueba S.A."
        '
        'toolMain
        '
        Me.toolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTransaccion, Me.btnSalir, Me.tsSep1, Me.btnAyuda, Me.tsSep2, Me.lblVersion, Me.ToolStripSeparator6})
        Me.toolMain.Location = New System.Drawing.Point(0, 0)
        Me.toolMain.Name = "toolMain"
        Me.toolMain.Size = New System.Drawing.Size(739, 25)
        Me.toolMain.TabIndex = 9
        Me.toolMain.Text = "ToolStrip1"
        '
        'lblTransaccion
        '
        Me.lblTransaccion.AutoSize = False
        Me.lblTransaccion.Image = Global.VBP04000.My.Resources.Resources.About
        Me.lblTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransaccion.Name = "lblTransaccion"
        Me.lblTransaccion.Size = New System.Drawing.Size(390, 22)
        Me.lblTransaccion.Text = "Transacción"
        Me.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.VBP04000.My.Resources.Resources.Cross
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
        Me.btnAyuda.Image = Global.VBP04000.My.Resources.Resources.Help_21
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
        'PanTop
        '
        Me.PanTop.Appearance.BackColor = System.Drawing.Color.White
        Me.PanTop.Appearance.Options.UseBackColor = True
        Me.PanTop.Controls.Add(Me.lblSubtitulo)
        Me.PanTop.Controls.Add(Me.lblTitulo)
        Me.PanTop.Controls.Add(Me.picLogo)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 25)
        Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(739, 54)
        Me.PanTop.TabIndex = 15
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
        Me.picLogo.EditValue = Global.VBP04000.My.Resources.Resources.logo_prex
        Me.picLogo.Location = New System.Drawing.Point(678, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Properties.Appearance.Options.UseBackColor = True
        Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picLogo.Size = New System.Drawing.Size(59, 50)
        Me.picLogo.TabIndex = 0
        '
        'tabResultados
        '
        Me.tabResultados.Controls.Add(Me.StandaloneBarDockControl1)
        Me.tabResultados.Controls.Add(Me.Grid)
        Me.tabResultados.ImageOptions.Image = CType(resources.GetObject("tabResultados.ImageOptions.Image"), System.Drawing.Image)
        Me.tabResultados.Name = "tabResultados"
        Me.tabResultados.Size = New System.Drawing.Size(733, 294)
        Me.tabResultados.Text = "Resultados"
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.CausesValidation = False
        Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl1.Manager = Me.BarManager1
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(733, 24)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barResultado})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdNuevaConsultaResultado, Me.cmdVistaPrevia, Me.cmdExportarResultado, Me.cmdCopiarResultados, Me.BarEditItem1, Me.cmdColumnasResultados, Me.cmdMostrarAgrupamiento, Me.BarToggleSwitchItem1})
        Me.BarManager1.MainMenu = Me.barResultado
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'barResultado
        '
        Me.barResultado.BarName = "Menú principal"
        Me.barResultado.DockCol = 0
        Me.barResultado.DockRow = 0
        Me.barResultado.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barResultado.FloatLocation = New System.Drawing.Point(69, 273)
        Me.barResultado.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdNuevaConsultaResultado, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdVistaPrevia, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdExportarResultado, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdCopiarResultados, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdColumnasResultados, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdMostrarAgrupamiento, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barResultado.OptionsBar.UseWholeRow = True
        Me.barResultado.StandaloneBarDockControl = Me.StandaloneBarDockControl1
        Me.barResultado.Text = "mnuResultados"
        '
        'cmdNuevaConsultaResultado
        '
        Me.cmdNuevaConsultaResultado.Caption = "Nueva consulta"
        Me.cmdNuevaConsultaResultado.Enabled = False
        Me.cmdNuevaConsultaResultado.Id = 0
        Me.cmdNuevaConsultaResultado.ImageOptions.Image = CType(resources.GetObject("cmdNuevaConsultaResultado.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevaConsultaResultado.ImageOptions.LargeImage = CType(resources.GetObject("cmdNuevaConsultaResultado.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdNuevaConsultaResultado.Name = "cmdNuevaConsultaResultado"
        '
        'cmdVistaPrevia
        '
        Me.cmdVistaPrevia.Caption = "Vista previa"
        Me.cmdVistaPrevia.Enabled = False
        Me.cmdVistaPrevia.Id = 1
        Me.cmdVistaPrevia.ImageOptions.Image = CType(resources.GetObject("cmdVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVistaPrevia.ImageOptions.LargeImage = CType(resources.GetObject("cmdVistaPrevia.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdVistaPrevia.Name = "cmdVistaPrevia"
        '
        'cmdExportarResultado
        '
        Me.cmdExportarResultado.Caption = "Exportar"
        Me.cmdExportarResultado.Enabled = False
        Me.cmdExportarResultado.Id = 2
        Me.cmdExportarResultado.ImageOptions.Image = Global.VBP04000.My.Resources.Resources.page_excel
        Me.cmdExportarResultado.Name = "cmdExportarResultado"
        '
        'cmdCopiarResultados
        '
        Me.cmdCopiarResultados.Caption = "Copiar"
        Me.cmdCopiarResultados.Enabled = False
        Me.cmdCopiarResultados.Id = 3
        Me.cmdCopiarResultados.ImageOptions.Image = CType(resources.GetObject("cmdCopiarResultados.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCopiarResultados.ImageOptions.LargeImage = CType(resources.GetObject("cmdCopiarResultados.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdCopiarResultados.Name = "cmdCopiarResultados"
        '
        'cmdColumnasResultados
        '
        Me.cmdColumnasResultados.Caption = "Columnas"
        Me.cmdColumnasResultados.Enabled = False
        Me.cmdColumnasResultados.Id = 5
        Me.cmdColumnasResultados.ImageOptions.Image = CType(resources.GetObject("cmdColumnasResultados.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdColumnasResultados.ImageOptions.LargeImage = CType(resources.GetObject("cmdColumnasResultados.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdColumnasResultados.Name = "cmdColumnasResultados"
        '
        'cmdMostrarAgrupamiento
        '
        Me.cmdMostrarAgrupamiento.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.cmdMostrarAgrupamiento.Down = True
        Me.cmdMostrarAgrupamiento.Enabled = False
        Me.cmdMostrarAgrupamiento.Hint = "Mostrar u ocultar cuadro de agrupamiento"
        Me.cmdMostrarAgrupamiento.Id = 6
        Me.cmdMostrarAgrupamiento.ImageOptions.Image = CType(resources.GetObject("cmdMostrarAgrupamiento.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdMostrarAgrupamiento.ImageOptions.LargeImage = CType(resources.GetObject("cmdMostrarAgrupamiento.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdMostrarAgrupamiento.ItemAppearance.Pressed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdMostrarAgrupamiento.ItemAppearance.Pressed.Options.UseBackColor = True
        Me.cmdMostrarAgrupamiento.Name = "cmdMostrarAgrupamiento"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(739, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 429)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(739, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 429)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(739, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 429)
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 4
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarToggleSwitchItem1
        '
        Me.BarToggleSwitchItem1.Id = 7
        Me.BarToggleSwitchItem1.Name = "BarToggleSwitchItem1"
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grid.Location = New System.Drawing.Point(0, 24)
        Me.Grid.MainView = Me.GridResultado
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(733, 270)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridResultado})
        '
        'GridResultado
        '
        Me.GridResultado.GridControl = Me.Grid
        Me.GridResultado.GroupFormat = "[#image]{1} {2}"
        Me.GridResultado.Name = "GridResultado"
        Me.GridResultado.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridResultado.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridResultado.OptionsBehavior.Editable = False
        Me.GridResultado.OptionsBehavior.ReadOnly = True
        '
        'tabParametros
        '
        Me.tabParametros.Controls.Add(Me.TableLayoutPanel1)
        Me.tabParametros.ImageOptions.Image = CType(resources.GetObject("tabParametros.ImageOptions.Image"), System.Drawing.Image)
        Me.tabParametros.Name = "tabParametros"
        Me.tabParametros.Size = New System.Drawing.Size(733, 294)
        Me.tabParametros.Text = "Parámetros de la consulta"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GridParametros, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(733, 294)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GridParametros
        '
        Me.GridParametros.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridParametros.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridParametros.Location = New System.Drawing.Point(3, 162)
        Me.GridParametros.MainView = Me.GridViewParametros
        Me.GridParametros.Name = "GridParametros"
        Me.GridParametros.Size = New System.Drawing.Size(727, 129)
        Me.GridParametros.TabIndex = 7
        Me.GridParametros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewParametros})
        '
        'GridViewParametros
        '
        Me.GridViewParametros.AppearancePrint.FooterPanel.Options.UseTextOptions = True
        Me.GridViewParametros.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewParametros.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridViewParametros.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewParametros.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridViewParametros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodParametro, Me.colParametro, Me.colEditorParametro, Me.colCD_HELP})
        Me.GridViewParametros.GridControl = Me.GridParametros
        Me.GridViewParametros.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.GridViewParametros.Name = "GridViewParametros"
        Me.GridViewParametros.OptionsView.ShowColumnHeaders = False
        Me.GridViewParametros.OptionsView.ShowGroupPanel = False
        Me.GridViewParametros.RowHeight = 19
        '
        'colCodParametro
        '
        Me.colCodParametro.Caption = "CodParametro"
        Me.colCodParametro.Name = "colCodParametro"
        '
        'colParametro
        '
        Me.colParametro.Caption = "colParametro"
        Me.colParametro.FieldName = "CD_NOMPAR"
        Me.colParametro.Name = "colParametro"
        Me.colParametro.OptionsColumn.AllowEdit = False
        Me.colParametro.Visible = True
        Me.colParametro.VisibleIndex = 0
        '
        'colEditorParametro
        '
        Me.colEditorParametro.Caption = "colEditorParametro"
        Me.colEditorParametro.FieldName = "Valor"
        Me.colEditorParametro.Name = "colEditorParametro"
        Me.colEditorParametro.Visible = True
        Me.colEditorParametro.VisibleIndex = 1
        '
        'colCD_HELP
        '
        Me.colCD_HELP.FieldName = "CD_HELP"
        Me.colCD_HELP.Name = "colCD_HELP"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(729, 24)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(567, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Seleccione la consulta que desea hacer y a continuación, ingrese los parámetros. " &
    "Luego presione el botón Consultar..."
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(2, 2)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(16, 20)
        Me.PictureEdit1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnEjecutarConsulta)
        Me.Panel1.Controls.Add(Me.btnAbrirConsulta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 28)
        Me.Panel1.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(189, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnEjecutarConsulta
        '
        Me.btnEjecutarConsulta.Enabled = False
        Me.btnEjecutarConsulta.ImageOptions.Image = CType(resources.GetObject("btnEjecutarConsulta.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEjecutarConsulta.Location = New System.Drawing.Point(108, 3)
        Me.btnEjecutarConsulta.Name = "btnEjecutarConsulta"
        Me.btnEjecutarConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutarConsulta.TabIndex = 1
        Me.btnEjecutarConsulta.Text = "&Ejecutar"
        '
        'btnAbrirConsulta
        '
        Me.btnAbrirConsulta.ImageOptions.Image = CType(resources.GetObject("btnAbrirConsulta.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAbrirConsulta.Location = New System.Drawing.Point(3, 3)
        Me.btnAbrirConsulta.Name = "btnAbrirConsulta"
        Me.btnAbrirConsulta.Size = New System.Drawing.Size(99, 23)
        Me.btnAbrirConsulta.TabIndex = 1
        Me.btnAbrirConsulta.Text = "&Abrir consulta"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblCategoriaConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.lblDescripcionConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.lblNombreConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.lblCodigoConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 58)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(729, 71)
        Me.PanelControl2.TabIndex = 3
        '
        'lblCategoriaConsulta
        '
        Me.lblCategoriaConsulta.Location = New System.Drawing.Point(73, 53)
        Me.lblCategoriaConsulta.Name = "lblCategoriaConsulta"
        Me.lblCategoriaConsulta.Size = New System.Drawing.Size(0, 13)
        Me.lblCategoriaConsulta.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(9, 53)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Categoría:"
        '
        'lblDescripcionConsulta
        '
        Me.lblDescripcionConsulta.Location = New System.Drawing.Point(73, 36)
        Me.lblDescripcionConsulta.Name = "lblDescripcionConsulta"
        Me.lblDescripcionConsulta.Size = New System.Drawing.Size(0, 13)
        Me.lblDescripcionConsulta.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 36)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Descripción:"
        '
        'lblNombreConsulta
        '
        Me.lblNombreConsulta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombreConsulta.Appearance.Options.UseFont = True
        Me.lblNombreConsulta.Location = New System.Drawing.Point(73, 19)
        Me.lblNombreConsulta.Name = "lblNombreConsulta"
        Me.lblNombreConsulta.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreConsulta.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Consulta:"
        '
        'lblCodigoConsulta
        '
        Me.lblCodigoConsulta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCodigoConsulta.Appearance.Options.UseFont = True
        Me.lblCodigoConsulta.Location = New System.Drawing.Point(73, 3)
        Me.lblCodigoConsulta.Name = "lblCodigoConsulta"
        Me.lblCodigoConsulta.Size = New System.Drawing.Size(0, 13)
        Me.lblCodigoConsulta.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Código:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureEdit2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 131)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(733, 28)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LabelControl6)
        Me.Panel3.Controls.Add(Me.PictureEdit3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(733, 28)
        Me.Panel3.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(23, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(160, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "= Parámetros de la consulta"
        '
        'PictureEdit3
        '
        Me.PictureEdit3.EditValue = CType(resources.GetObject("PictureEdit3.EditValue"), Object)
        Me.PictureEdit3.Location = New System.Drawing.Point(4, 3)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Size = New System.Drawing.Size(16, 20)
        Me.PictureEdit3.TabIndex = 2
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(4, 3)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Size = New System.Drawing.Size(16, 20)
        Me.PictureEdit2.TabIndex = 2
        '
        'tabPanel
        '
        Me.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPanel.Location = New System.Drawing.Point(0, 79)
        Me.tabPanel.Name = "tabPanel"
        Me.tabPanel.SelectedTabPage = Me.tabParametros
        Me.tabPanel.Size = New System.Drawing.Size(739, 325)
        Me.tabPanel.TabIndex = 16
        Me.tabPanel.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabParametros, Me.tabResultados})
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 429)
        Me.Controls.Add(Me.tabPanel)
        Me.Controls.Add(Me.PanTop)
        Me.Controls.Add(Me.toolMain)
        Me.Controls.Add(Me.sbMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procesos del sistema"
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.toolMain.ResumeLayout(False)
        Me.toolMain.PerformLayout()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResultados.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabParametros.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GridParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEntidad As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolMain As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTransaccion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAyuda As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabResultados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabParametros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEjecutarConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAbrirConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabPanel As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents lblCategoriaConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescripcionConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNombreConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCodigoConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GridParametros As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewParametros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodParametro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParametro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditorParametro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD_HELP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barResultado As DevExpress.XtraBars.Bar
    Friend WithEvents cmdNuevaConsultaResultado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdVistaPrevia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdExportarResultado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCopiarResultados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdColumnasResultados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmdMostrarAgrupamiento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarToggleSwitchItem1 As DevExpress.XtraBars.BarToggleSwitchItem
    Public WithEvents lblUsuario As ToolStripStatusLabel
End Class
