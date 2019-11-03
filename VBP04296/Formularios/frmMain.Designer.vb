<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.toolMain = New System.Windows.Forms.ToolStrip()
        Me.lblTransaccion = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAyuda = New System.Windows.Forms.ToolStripButton()
        Me.tsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblVersion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanTop = New DevExpress.XtraEditors.PanelControl()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.pnlMain = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StandaloneBarDockControl2 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdSave = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdSaveNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdObtenerCampos = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnNueva = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GridCons = New DevExpress.XtraGrid.GridControl()
        Me.GridViewCons = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombreConsulta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodTran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodCon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabPanel = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPageFormulario = New DevExpress.XtraTab.XtraTabPage()
        Me.cmdValidarUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBaja = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDrillDown = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdValidaNuevoDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdQueryNDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModValida = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdQueryUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAltaValida = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAlta = New DevExpress.XtraEditors.SimpleButton()
        Me.chkGroup = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDrillDown = New DevExpress.XtraEditors.CheckEdit()
        Me.chkNDesde = New DevExpress.XtraEditors.CheckEdit()
        Me.chkABM = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAlta = New DevExpress.XtraEditors.CheckEdit()
        Me.chkBaja = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDescriCab = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCodTraCab = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreCab = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tabPageQuery = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPageColumnas = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPageProcesos = New DevExpress.XtraTab.XtraTabPage()
        Me.toolMain.SuspendLayout()
        Me.sbMain.SuspendLayout()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTop.SuspendLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.tabPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPanel.SuspendLayout()
        Me.tabPageFormulario.SuspendLayout()
        CType(Me.chkGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDrillDown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkABM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescriCab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodTraCab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolMain
        '
        Me.toolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTransaccion, Me.btnSalir, Me.tsSep1, Me.btnAyuda, Me.tsSep2, Me.lblVersion, Me.ToolStripSeparator6})
        Me.toolMain.Location = New System.Drawing.Point(0, 0)
        Me.toolMain.Name = "toolMain"
        Me.toolMain.Size = New System.Drawing.Size(1060, 25)
        Me.toolMain.TabIndex = 10
        Me.toolMain.Text = "ToolStrip1"
        '
        'lblTransaccion
        '
        Me.lblTransaccion.AutoSize = False
        Me.lblTransaccion.Image = Global.VBP04296.My.Resources.Resources.About
        Me.lblTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransaccion.Name = "lblTransaccion"
        Me.lblTransaccion.Size = New System.Drawing.Size(390, 22)
        Me.lblTransaccion.Text = "Transacción"
        Me.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.VBP04296.My.Resources.Resources.Cross
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
        Me.btnAyuda.Image = Global.VBP04296.My.Resources.Resources.Help_2
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
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
        Me.sbMain.Location = New System.Drawing.Point(0, 652)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(1060, 25)
        Me.sbMain.SizingGrip = False
        Me.sbMain.TabIndex = 11
        '
        'lblUsuario
        '
        Me.lblUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblUsuario.Image = Global.VBP04296.My.Resources.Resources.Messenger_Information
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(906, 20)
        Me.lblUsuario.Spring = True
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntidad
        '
        Me.lblEntidad.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblEntidad.Image = Global.VBP04296.My.Resources.Resources.Home
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(139, 20)
        Me.lblEntidad.Text = "Banco de Prueba S.A."
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
        Me.PanTop.Size = New System.Drawing.Size(1060, 54)
        Me.PanTop.TabIndex = 12
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.Location = New System.Drawing.Point(34, 29)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(66, 13)
        Me.lblSubtitulo.TabIndex = 2
        Me.lblSubtitulo.Text = "LabelControl2"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(78, 13)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "LabelControl1"
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.picLogo.EditValue = Global.VBP04296.My.Resources.Resources.logo_prex
        Me.picLogo.Location = New System.Drawing.Point(999, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Properties.Appearance.Options.UseBackColor = True
        Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.picLogo.Size = New System.Drawing.Size(59, 50)
        Me.picLogo.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.SplitContainerControl1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 79)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1060, 573)
        Me.pnlMain.TabIndex = 13
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1056, 569)
        Me.SplitContainerControl1.SplitterPosition = 233
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.StandaloneBarDockControl2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GridCons, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(233, 569)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'StandaloneBarDockControl2
        '
        Me.StandaloneBarDockControl2.CausesValidation = False
        Me.StandaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StandaloneBarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl2.Manager = Me.BarManager1
        Me.StandaloneBarDockControl2.Margin = New System.Windows.Forms.Padding(0)
        Me.StandaloneBarDockControl2.Name = "StandaloneBarDockControl2"
        Me.StandaloneBarDockControl2.Size = New System.Drawing.Size(233, 24)
        Me.StandaloneBarDockControl2.Text = "StandaloneBarDockControl2"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl2)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdSave, Me.cmdSaveNuevo, Me.cmdObtenerCampos, Me.cmdCancelar, Me.BarButtonItem1, Me.btnNueva, Me.btnEliminar, Me.btnEditar})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 8
        '
        'Bar2
        '
        Me.Bar2.BarName = "Personalizada 4"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar2.FloatLocation = New System.Drawing.Point(272, 242)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.cmdSave, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "", ""), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdSaveNuevo), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdObtenerCampos, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawBorder = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.StandaloneBarDockControl = Me.StandaloneBarDockControl1
        Me.Bar2.Text = "Personalizada 4"
        '
        'cmdSave
        '
        Me.cmdSave.Hint = "Guardar"
        Me.cmdSave.Id = 0
        Me.cmdSave.ImageOptions.Image = CType(resources.GetObject("cmdSave.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSave.ImageOptions.LargeImage = CType(resources.GetObject("cmdSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdSave.Name = "cmdSave"
        '
        'cmdSaveNuevo
        '
        Me.cmdSaveNuevo.Hint = "Guardar Nueva"
        Me.cmdSaveNuevo.Id = 1
        Me.cmdSaveNuevo.ImageOptions.Image = CType(resources.GetObject("cmdSaveNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSaveNuevo.ImageOptions.LargeImage = CType(resources.GetObject("cmdSaveNuevo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdSaveNuevo.Name = "cmdSaveNuevo"
        '
        'cmdObtenerCampos
        '
        Me.cmdObtenerCampos.Caption = "Obtener Campos"
        Me.cmdObtenerCampos.Id = 2
        Me.cmdObtenerCampos.ImageOptions.Image = CType(resources.GetObject("cmdObtenerCampos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdObtenerCampos.ImageOptions.LargeImage = CType(resources.GetObject("cmdObtenerCampos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdObtenerCampos.Name = "cmdObtenerCampos"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Caption = "Cancelar"
        Me.cmdCancelar.Id = 3
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageOptions.LargeImage = CType(resources.GetObject("cmdCancelar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Generar Script"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.CausesValidation = False
        Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl1.Manager = Me.BarManager1
        Me.StandaloneBarDockControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(818, 24)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Personalizada 5"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.FloatLocation = New System.Drawing.Point(217, 227)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnNueva), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditar)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.StandaloneBarDockControl = Me.StandaloneBarDockControl2
        Me.Bar1.Text = "Personalizada 5"
        '
        'btnNueva
        '
        Me.btnNueva.Hint = "Nueva Consulta"
        Me.btnNueva.Id = 5
        Me.btnNueva.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNueva.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNueva.Name = "btnNueva"
        '
        'btnEliminar
        '
        Me.btnEliminar.Hint = "Eliminar Consulta"
        Me.btnEliminar.Id = 6
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEliminar.Name = "btnEliminar"
        '
        'btnEditar
        '
        Me.btnEditar.Hint = "Editar Consulta"
        Me.btnEditar.Id = 7
        Me.btnEditar.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditar.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEditar.Name = "btnEditar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1060, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 677)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1060, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 677)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1060, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 677)
        '
        'GridCons
        '
        Me.GridCons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCons.Location = New System.Drawing.Point(0, 27)
        Me.GridCons.MainView = Me.GridViewCons
        Me.GridCons.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.GridCons.Name = "GridCons"
        Me.GridCons.Size = New System.Drawing.Size(233, 542)
        Me.GridCons.TabIndex = 0
        Me.GridCons.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCons})
        '
        'GridViewCons
        '
        Me.GridViewCons.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightBlue
        Me.GridViewCons.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridViewCons.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombreConsulta, Me.colCodTran, Me.colCodCon})
        Me.GridViewCons.GridControl = Me.GridCons
        Me.GridViewCons.Name = "GridViewCons"
        Me.GridViewCons.OptionsBehavior.AllowPartialRedrawOnScrolling = False
        Me.GridViewCons.OptionsBehavior.AllowValidationErrors = False
        Me.GridViewCons.OptionsBehavior.Editable = False
        Me.GridViewCons.OptionsBehavior.ReadOnly = True
        Me.GridViewCons.OptionsCustomization.AllowColumnMoving = False
        Me.GridViewCons.OptionsCustomization.AllowColumnResizing = False
        Me.GridViewCons.OptionsCustomization.AllowFilter = False
        Me.GridViewCons.OptionsCustomization.AllowGroup = False
        Me.GridViewCons.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridViewCons.OptionsCustomization.AllowSort = False
        Me.GridViewCons.OptionsPrint.PrintHorzLines = False
        Me.GridViewCons.OptionsPrint.PrintVertLines = False
        Me.GridViewCons.OptionsView.ShowColumnHeaders = False
        Me.GridViewCons.OptionsView.ShowDetailButtons = False
        Me.GridViewCons.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GridViewCons.OptionsView.ShowGroupPanel = False
        Me.GridViewCons.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewCons.OptionsView.ShowIndicator = False
        Me.GridViewCons.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewCons.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'colNombreConsulta
        '
        Me.colNombreConsulta.FieldName = "XX_DESCRI"
        Me.colNombreConsulta.Name = "colNombreConsulta"
        Me.colNombreConsulta.Visible = True
        Me.colNombreConsulta.VisibleIndex = 0
        '
        'colCodTran
        '
        Me.colCodTran.Caption = "CS_CODTRAN"
        Me.colCodTran.FieldName = "CS_CODTRAN"
        Me.colCodTran.Name = "colCodTran"
        '
        'colCodCon
        '
        Me.colCodCon.FieldName = "CS_CODCON"
        Me.colCodCon.Name = "colCodCon"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.StandaloneBarDockControl1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tabPanel, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(818, 569)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'tabPanel
        '
        Me.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPanel.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.tabPanel.Location = New System.Drawing.Point(0, 24)
        Me.tabPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.tabPanel.Name = "tabPanel"
        Me.tabPanel.SelectedTabPage = Me.tabPageFormulario
        Me.tabPanel.Size = New System.Drawing.Size(818, 545)
        Me.tabPanel.TabIndex = 1
        Me.tabPanel.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPageFormulario, Me.tabPageQuery, Me.tabPageColumnas, Me.tabPageProcesos})
        '
        'tabPageFormulario
        '
        Me.tabPageFormulario.Controls.Add(Me.cmdValidarUpdate)
        Me.tabPageFormulario.Controls.Add(Me.cmdBaja)
        Me.tabPageFormulario.Controls.Add(Me.SimpleButton7)
        Me.tabPageFormulario.Controls.Add(Me.cmdDrillDown)
        Me.tabPageFormulario.Controls.Add(Me.cmdValidaNuevoDesde)
        Me.tabPageFormulario.Controls.Add(Me.cmdQueryNDesde)
        Me.tabPageFormulario.Controls.Add(Me.cmdModValida)
        Me.tabPageFormulario.Controls.Add(Me.cmdQueryUpdate)
        Me.tabPageFormulario.Controls.Add(Me.cmdAltaValida)
        Me.tabPageFormulario.Controls.Add(Me.cmdAlta)
        Me.tabPageFormulario.Controls.Add(Me.chkGroup)
        Me.tabPageFormulario.Controls.Add(Me.chkDrillDown)
        Me.tabPageFormulario.Controls.Add(Me.chkNDesde)
        Me.tabPageFormulario.Controls.Add(Me.chkABM)
        Me.tabPageFormulario.Controls.Add(Me.chkAlta)
        Me.tabPageFormulario.Controls.Add(Me.chkBaja)
        Me.tabPageFormulario.Controls.Add(Me.txtDescriCab)
        Me.tabPageFormulario.Controls.Add(Me.txtCodTraCab)
        Me.tabPageFormulario.Controls.Add(Me.txtNombreCab)
        Me.tabPageFormulario.Controls.Add(Me.LabelControl3)
        Me.tabPageFormulario.Controls.Add(Me.LabelControl2)
        Me.tabPageFormulario.Controls.Add(Me.LabelControl1)
        Me.tabPageFormulario.ImageOptions.Image = CType(resources.GetObject("tabPageFormulario.ImageOptions.Image"), System.Drawing.Image)
        Me.tabPageFormulario.Margin = New System.Windows.Forms.Padding(0)
        Me.tabPageFormulario.Name = "tabPageFormulario"
        Me.tabPageFormulario.Size = New System.Drawing.Size(812, 514)
        Me.tabPageFormulario.Text = "Formulario"
        '
        'cmdValidarUpdate
        '
        Me.cmdValidarUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdValidarUpdate.Appearance.Options.UseFont = True
        Me.cmdValidarUpdate.Location = New System.Drawing.Point(502, 202)
        Me.cmdValidarUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdValidarUpdate.Name = "cmdValidarUpdate"
        Me.cmdValidarUpdate.Size = New System.Drawing.Size(100, 20)
        Me.cmdValidarUpdate.TabIndex = 22
        Me.cmdValidarUpdate.Text = "Validación ABM"
        '
        'cmdBaja
        '
        Me.cmdBaja.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdBaja.Appearance.Options.UseFont = True
        Me.cmdBaja.Location = New System.Drawing.Point(276, 177)
        Me.cmdBaja.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdBaja.Name = "cmdBaja"
        Me.cmdBaja.Size = New System.Drawing.Size(100, 20)
        Me.cmdBaja.TabIndex = 21
        Me.cmdBaja.Text = "&Query de Baja"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.Location = New System.Drawing.Point(390, 252)
        Me.SimpleButton7.Margin = New System.Windows.Forms.Padding(0)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(100, 20)
        Me.SimpleButton7.TabIndex = 20
        Me.SimpleButton7.Text = "&Query de Validación"
        '
        'cmdDrillDown
        '
        Me.cmdDrillDown.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdDrillDown.Appearance.Options.UseFont = True
        Me.cmdDrillDown.Location = New System.Drawing.Point(276, 252)
        Me.cmdDrillDown.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdDrillDown.Name = "cmdDrillDown"
        Me.cmdDrillDown.Size = New System.Drawing.Size(100, 20)
        Me.cmdDrillDown.TabIndex = 19
        Me.cmdDrillDown.Text = "&Query Drill Down"
        '
        'cmdValidaNuevoDesde
        '
        Me.cmdValidaNuevoDesde.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdValidaNuevoDesde.Appearance.Options.UseFont = True
        Me.cmdValidaNuevoDesde.Location = New System.Drawing.Point(390, 227)
        Me.cmdValidaNuevoDesde.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdValidaNuevoDesde.Name = "cmdValidaNuevoDesde"
        Me.cmdValidaNuevoDesde.Size = New System.Drawing.Size(100, 20)
        Me.cmdValidaNuevoDesde.TabIndex = 18
        Me.cmdValidaNuevoDesde.Text = "&Query de Validación"
        '
        'cmdQueryNDesde
        '
        Me.cmdQueryNDesde.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdQueryNDesde.Appearance.Options.UseFont = True
        Me.cmdQueryNDesde.Location = New System.Drawing.Point(276, 227)
        Me.cmdQueryNDesde.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdQueryNDesde.Name = "cmdQueryNDesde"
        Me.cmdQueryNDesde.Size = New System.Drawing.Size(100, 20)
        Me.cmdQueryNDesde.TabIndex = 17
        Me.cmdQueryNDesde.Text = "&Query"
        '
        'cmdModValida
        '
        Me.cmdModValida.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdModValida.Appearance.Options.UseFont = True
        Me.cmdModValida.Location = New System.Drawing.Point(390, 202)
        Me.cmdModValida.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdModValida.Name = "cmdModValida"
        Me.cmdModValida.Size = New System.Drawing.Size(100, 20)
        Me.cmdModValida.TabIndex = 16
        Me.cmdModValida.Text = "&Query de Validación"
        '
        'cmdQueryUpdate
        '
        Me.cmdQueryUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdQueryUpdate.Appearance.Options.UseFont = True
        Me.cmdQueryUpdate.Location = New System.Drawing.Point(276, 202)
        Me.cmdQueryUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdQueryUpdate.Name = "cmdQueryUpdate"
        Me.cmdQueryUpdate.Size = New System.Drawing.Size(100, 20)
        Me.cmdQueryUpdate.TabIndex = 15
        Me.cmdQueryUpdate.Text = "&Query de Modif."
        '
        'cmdAltaValida
        '
        Me.cmdAltaValida.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdAltaValida.Appearance.Options.UseFont = True
        Me.cmdAltaValida.Location = New System.Drawing.Point(390, 151)
        Me.cmdAltaValida.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdAltaValida.Name = "cmdAltaValida"
        Me.cmdAltaValida.Size = New System.Drawing.Size(100, 20)
        Me.cmdAltaValida.TabIndex = 14
        Me.cmdAltaValida.Text = "Validación ABM"
        '
        'cmdAlta
        '
        Me.cmdAlta.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.cmdAlta.Appearance.Options.UseFont = True
        Me.cmdAlta.Location = New System.Drawing.Point(276, 151)
        Me.cmdAlta.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdAlta.Name = "cmdAlta"
        Me.cmdAlta.Size = New System.Drawing.Size(100, 20)
        Me.cmdAlta.TabIndex = 13
        Me.cmdAlta.Text = "&Query de Alta"
        '
        'chkGroup
        '
        Me.chkGroup.Location = New System.Drawing.Point(113, 276)
        Me.chkGroup.MenuManager = Me.BarManager1
        Me.chkGroup.Name = "chkGroup"
        Me.chkGroup.Properties.Caption = "Mostrar cuadro de a&grupación en grilla"
        Me.chkGroup.Size = New System.Drawing.Size(230, 19)
        Me.chkGroup.TabIndex = 12
        '
        'chkDrillDown
        '
        Me.chkDrillDown.Location = New System.Drawing.Point(113, 251)
        Me.chkDrillDown.MenuManager = Me.BarManager1
        Me.chkDrillDown.Name = "chkDrillDown"
        Me.chkDrillDown.Properties.Caption = "Utilizar &Dril lDown"
        Me.chkDrillDown.Size = New System.Drawing.Size(180, 19)
        Me.chkDrillDown.TabIndex = 11
        '
        'chkNDesde
        '
        Me.chkNDesde.Location = New System.Drawing.Point(113, 226)
        Me.chkNDesde.MenuManager = Me.BarManager1
        Me.chkNDesde.Name = "chkNDesde"
        Me.chkNDesde.Properties.Caption = "Permite &Nuevo Desde"
        Me.chkNDesde.Size = New System.Drawing.Size(180, 19)
        Me.chkNDesde.TabIndex = 10
        '
        'chkABM
        '
        Me.chkABM.Location = New System.Drawing.Point(113, 201)
        Me.chkABM.MenuManager = Me.BarManager1
        Me.chkABM.Name = "chkABM"
        Me.chkABM.Properties.Caption = "Permite &Modificar Registros"
        Me.chkABM.Size = New System.Drawing.Size(180, 19)
        Me.chkABM.TabIndex = 9
        '
        'chkAlta
        '
        Me.chkAlta.Location = New System.Drawing.Point(113, 151)
        Me.chkAlta.MenuManager = Me.BarManager1
        Me.chkAlta.Name = "chkAlta"
        Me.chkAlta.Properties.Caption = "Permite &Alta de Registros"
        Me.chkAlta.Size = New System.Drawing.Size(180, 19)
        Me.chkAlta.TabIndex = 8
        '
        'chkBaja
        '
        Me.chkBaja.Location = New System.Drawing.Point(113, 176)
        Me.chkBaja.MenuManager = Me.BarManager1
        Me.chkBaja.Name = "chkBaja"
        Me.chkBaja.Properties.Caption = "Permite &Baja de Registros"
        Me.chkBaja.Size = New System.Drawing.Size(180, 19)
        Me.chkBaja.TabIndex = 7
        '
        'txtDescriCab
        '
        Me.txtDescriCab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescriCab.Location = New System.Drawing.Point(113, 68)
        Me.txtDescriCab.MenuManager = Me.BarManager1
        Me.txtDescriCab.Name = "txtDescriCab"
        Me.txtDescriCab.Size = New System.Drawing.Size(660, 67)
        Me.txtDescriCab.TabIndex = 6
        '
        'txtCodTraCab
        '
        Me.txtCodTraCab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodTraCab.Location = New System.Drawing.Point(113, 40)
        Me.txtCodTraCab.MenuManager = Me.BarManager1
        Me.txtCodTraCab.Name = "txtCodTraCab"
        Me.txtCodTraCab.Size = New System.Drawing.Size(660, 20)
        Me.txtCodTraCab.TabIndex = 5
        '
        'txtNombreCab
        '
        Me.txtNombreCab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCab.Location = New System.Drawing.Point(113, 14)
        Me.txtNombreCab.MenuManager = Me.BarManager1
        Me.txtNombreCab.Name = "txtNombreCab"
        Me.txtNombreCab.Size = New System.Drawing.Size(660, 20)
        Me.txtNombreCab.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(49, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Descripción:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(46, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Transacción:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(66, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre:"
        '
        'tabPageQuery
        '
        Me.tabPageQuery.ImageOptions.Image = CType(resources.GetObject("tabPageQuery.ImageOptions.Image"), System.Drawing.Image)
        Me.tabPageQuery.Margin = New System.Windows.Forms.Padding(0)
        Me.tabPageQuery.Name = "tabPageQuery"
        Me.tabPageQuery.Size = New System.Drawing.Size(812, 514)
        Me.tabPageQuery.Text = "Query"
        '
        'tabPageColumnas
        '
        Me.tabPageColumnas.ImageOptions.Image = CType(resources.GetObject("tabPageColumnas.ImageOptions.Image"), System.Drawing.Image)
        Me.tabPageColumnas.Margin = New System.Windows.Forms.Padding(0)
        Me.tabPageColumnas.Name = "tabPageColumnas"
        Me.tabPageColumnas.Size = New System.Drawing.Size(812, 514)
        Me.tabPageColumnas.Text = "Columnas"
        '
        'tabPageProcesos
        '
        Me.tabPageProcesos.ImageOptions.Image = CType(resources.GetObject("tabPageProcesos.ImageOptions.Image"), System.Drawing.Image)
        Me.tabPageProcesos.Margin = New System.Windows.Forms.Padding(0)
        Me.tabPageProcesos.Name = "tabPageProcesos"
        Me.tabPageProcesos.Size = New System.Drawing.Size(812, 514)
        Me.tabPageProcesos.Text = "Procesos Previos"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 677)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.PanTop)
        Me.Controls.Add(Me.sbMain)
        Me.Controls.Add(Me.toolMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.toolMain.ResumeLayout(False)
        Me.toolMain.PerformLayout()
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.tabPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPanel.ResumeLayout(False)
        Me.tabPageFormulario.ResumeLayout(False)
        Me.tabPageFormulario.PerformLayout()
        CType(Me.chkGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDrillDown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkABM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescriCab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodTraCab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolMain As ToolStrip
    Friend WithEvents lblTransaccion As ToolStripLabel
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents tsSep1 As ToolStripSeparator
    Friend WithEvents btnAyuda As ToolStripButton
    Friend WithEvents tsSep2 As ToolStripSeparator
    Friend WithEvents lblVersion As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents sbMain As StatusStrip
    Public WithEvents lblUsuario As ToolStripStatusLabel
    Friend WithEvents lblEntidad As ToolStripStatusLabel
    Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GridCons As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCons As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNombreConsulta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodTran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodCon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents tabPanel As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPageFormulario As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPageQuery As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPageColumnas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPageProcesos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdSaveNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdObtenerCampos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents StandaloneBarDockControl2 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnNueva As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtCodTraCab As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreCab As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkGroup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDrillDown As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNDesde As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkABM As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAlta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkBaja As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDescriCab As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdAltaValida As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAlta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdValidarUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBaja As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDrillDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdValidaNuevoDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdQueryNDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModValida As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdQueryUpdate As DevExpress.XtraEditors.SimpleButton
End Class
