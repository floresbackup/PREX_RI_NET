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
		Me.cmdGenerarScipt = New DevExpress.XtraBars.BarButtonItem()
		Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
		Me.Bar1 = New DevExpress.XtraBars.Bar()
		Me.btnNueva = New DevExpress.XtraBars.BarButtonItem()
		Me.btnEliminar = New DevExpress.XtraBars.BarButtonItem()
		Me.btnEditar = New DevExpress.XtraBars.BarButtonItem()
		Me.barProcesos = New DevExpress.XtraBars.Bar()
		Me.cmdNuevoProceso = New DevExpress.XtraBars.BarButtonItem()
		Me.cmdEditarProceso = New DevExpress.XtraBars.BarButtonItem()
		Me.cmdEliminarProceso = New DevExpress.XtraBars.BarButtonItem()
		Me.cmdSubirOrdenProceso = New DevExpress.XtraBars.BarButtonItem()
		Me.cmdBajarOrdenProceso = New DevExpress.XtraBars.BarButtonItem()
		Me.StandaloneBarDockControl3 = New DevExpress.XtraBars.StandaloneBarDockControl()
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnEditarVariable = New DevExpress.XtraBars.BarButtonItem()
		Me.btnNuevaVariable = New DevExpress.XtraBars.BarButtonItem()
		Me.btnEliminarVariable = New DevExpress.XtraBars.BarButtonItem()
		Me.btnSubirVariable = New DevExpress.XtraBars.BarButtonItem()
		Me.btnVariableBajarOrden = New DevExpress.XtraBars.BarButtonItem()
		Me.StandaloneBarDockControl4 = New DevExpress.XtraBars.StandaloneBarDockControl()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		Me.GridCons = New DevExpress.XtraGrid.GridControl()
		Me.GridViewCons = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colNombreConsulta = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCodTran = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCodCon = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.ColNombre = New DevExpress.XtraGrid.Columns.GridColumn()
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
		Me.lyVariables = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
		Me.gridVariables = New DevExpress.XtraGrid.GridControl()
		Me.gridViewVariables = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
		Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
		Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
		Me.txtVarOrden = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
		Me.txtVarNombre = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
		Me.txtVarTitulo = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
		Me.txtVarDato = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
		Me.txtVarHelp = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
		Me.pnlQuery = New System.Windows.Forms.Panel()
		Me.tabPageColumnas = New DevExpress.XtraTab.XtraTabPage()
		Me.tabPageProcesos = New DevExpress.XtraTab.XtraTabPage()
		Me.gridProc = New DevExpress.XtraGrid.GridControl()
		Me.gridViewProc = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.txtDescriPro = New DevExpress.XtraEditors.TextEdit()
		Me.txtParamPro = New DevExpress.XtraEditors.TextEdit()
		Me.txtTituloPro = New DevExpress.XtraEditors.TextEdit()
		Me.txtNombrePro = New DevExpress.XtraEditors.TextEdit()
		Me.txtOrdenPro = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
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
		Me.tabPageQuery.SuspendLayout()
		Me.lyVariables.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		CType(Me.gridVariables, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridViewVariables, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl6.SuspendLayout()
		CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl7.SuspendLayout()
		CType(Me.txtVarOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVarNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVarTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVarDato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVarHelp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabPageProcesos.SuspendLayout()
		CType(Me.gridProc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridViewProc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDescriPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtParamPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTituloPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNombrePro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtOrdenPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'toolMain
		'
		Me.toolMain.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.toolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTransaccion, Me.btnSalir, Me.tsSep1, Me.btnAyuda, Me.tsSep2, Me.lblVersion, Me.ToolStripSeparator6})
		Me.toolMain.Location = New System.Drawing.Point(0, 0)
		Me.toolMain.Name = "toolMain"
		Me.toolMain.Size = New System.Drawing.Size(1413, 27)
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
		Me.btnSalir.Size = New System.Drawing.Size(66, 24)
		Me.btnSalir.Text = " Salir"
		'
		'tsSep1
		'
		Me.tsSep1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.tsSep1.Name = "tsSep1"
		Me.tsSep1.Size = New System.Drawing.Size(6, 27)
		'
		'btnAyuda
		'
		Me.btnAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.btnAyuda.Image = Global.VBP04296.My.Resources.Resources.Help_2
		Me.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnAyuda.Name = "btnAyuda"
		Me.btnAyuda.Size = New System.Drawing.Size(79, 24)
		Me.btnAyuda.Text = " Ayuda"
		'
		'tsSep2
		'
		Me.tsSep2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.tsSep2.Name = "tsSep2"
		Me.tsSep2.Size = New System.Drawing.Size(6, 27)
		'
		'lblVersion
		'
		Me.lblVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(94, 24)
		Me.lblVersion.Text = "Versión: 1.0.0"
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
		'
		'sbMain
		'
		Me.sbMain.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
		Me.sbMain.Location = New System.Drawing.Point(0, 803)
		Me.sbMain.Name = "sbMain"
		Me.sbMain.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
		Me.sbMain.Size = New System.Drawing.Size(1413, 30)
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
		Me.lblUsuario.Size = New System.Drawing.Size(1220, 24)
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
		Me.lblEntidad.Size = New System.Drawing.Size(173, 24)
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
		Me.PanTop.Location = New System.Drawing.Point(0, 27)
		Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
		Me.PanTop.Margin = New System.Windows.Forms.Padding(4)
		Me.PanTop.Name = "PanTop"
		Me.PanTop.Size = New System.Drawing.Size(1413, 66)
		Me.PanTop.TabIndex = 12
		'
		'lblSubtitulo
		'
		Me.lblSubtitulo.Location = New System.Drawing.Point(45, 36)
		Me.lblSubtitulo.Margin = New System.Windows.Forms.Padding(4)
		Me.lblSubtitulo.Name = "lblSubtitulo"
		Me.lblSubtitulo.Size = New System.Drawing.Size(78, 16)
		Me.lblSubtitulo.TabIndex = 2
		Me.lblSubtitulo.Text = "LabelControl2"
		'
		'lblTitulo
		'
		Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.lblTitulo.Appearance.Options.UseFont = True
		Me.lblTitulo.Location = New System.Drawing.Point(16, 11)
		Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(97, 17)
		Me.lblTitulo.TabIndex = 1
		Me.lblTitulo.Text = "LabelControl1"
		'
		'picLogo
		'
		Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
		Me.picLogo.EditValue = Global.VBP04296.My.Resources.Resources.logo_prex
		Me.picLogo.Location = New System.Drawing.Point(1332, 2)
		Me.picLogo.Margin = New System.Windows.Forms.Padding(4)
		Me.picLogo.Name = "picLogo"
		Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
		Me.picLogo.Properties.Appearance.Options.UseBackColor = True
		Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
		Me.picLogo.Size = New System.Drawing.Size(79, 62)
		Me.picLogo.TabIndex = 0
		'
		'pnlMain
		'
		Me.pnlMain.Controls.Add(Me.SplitContainerControl1)
		Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlMain.Location = New System.Drawing.Point(0, 93)
		Me.pnlMain.Margin = New System.Windows.Forms.Padding(4)
		Me.pnlMain.Name = "pnlMain"
		Me.pnlMain.Size = New System.Drawing.Size(1413, 710)
		Me.pnlMain.TabIndex = 13
		'
		'SplitContainerControl1
		'
		Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 2)
		Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(4)
		Me.SplitContainerControl1.Name = "SplitContainerControl1"
		Me.SplitContainerControl1.Panel1.Controls.Add(Me.TableLayoutPanel1)
		Me.SplitContainerControl1.Panel1.Text = "Panel1"
		Me.SplitContainerControl1.Panel2.Controls.Add(Me.TableLayoutPanel2)
		Me.SplitContainerControl1.Panel2.Text = "Panel2"
		Me.SplitContainerControl1.Size = New System.Drawing.Size(1409, 706)
		Me.SplitContainerControl1.SplitterPosition = 311
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
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(311, 706)
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
		Me.StandaloneBarDockControl2.Size = New System.Drawing.Size(311, 30)
		Me.StandaloneBarDockControl2.Text = "StandaloneBarDockControl2"
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar1, Me.barProcesos, Me.Bar3})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
		Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl2)
		Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl3)
		Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl4)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdSave, Me.cmdSaveNuevo, Me.cmdObtenerCampos, Me.cmdCancelar, Me.cmdGenerarScipt, Me.btnNueva, Me.btnEliminar, Me.btnEditar, Me.cmdNuevoProceso, Me.cmdEditarProceso, Me.cmdSubirOrdenProceso, Me.cmdBajarOrdenProceso, Me.cmdEliminarProceso, Me.btnNuevaVariable, Me.btnEditarVariable, Me.btnEliminarVariable, Me.btnSubirVariable, Me.btnVariableBajarOrden})
		Me.BarManager1.MainMenu = Me.Bar2
		Me.BarManager1.MaxItemId = 18
		'
		'Bar2
		'
		Me.Bar2.BarName = "Personalizada 4"
		Me.Bar2.DockCol = 0
		Me.Bar2.DockRow = 0
		Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
		Me.Bar2.FloatLocation = New System.Drawing.Point(272, 242)
		Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.cmdSave, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "", ""), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdSaveNuevo), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdObtenerCampos, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdGenerarScipt, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
		'cmdGenerarScipt
		'
		Me.cmdGenerarScipt.Caption = "Generar Script"
		Me.cmdGenerarScipt.Id = 4
		Me.cmdGenerarScipt.ImageOptions.Image = CType(resources.GetObject("cmdGenerarScipt.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdGenerarScipt.ImageOptions.LargeImage = CType(resources.GetObject("cmdGenerarScipt.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.cmdGenerarScipt.Name = "cmdGenerarScipt"
		'
		'StandaloneBarDockControl1
		'
		Me.StandaloneBarDockControl1.CausesValidation = False
		Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
		Me.StandaloneBarDockControl1.Manager = Me.BarManager1
		Me.StandaloneBarDockControl1.Margin = New System.Windows.Forms.Padding(0)
		Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
		Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(1092, 30)
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
		Me.btnNueva.ImageOptions.Image = CType(resources.GetObject("btnNueva.ImageOptions.Image"), System.Drawing.Image)
		Me.btnNueva.ImageOptions.LargeImage = CType(resources.GetObject("btnNueva.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.btnNueva.Name = "btnNueva"
		'
		'btnEliminar
		'
		Me.btnEliminar.Hint = "Eliminar Consulta"
		Me.btnEliminar.Id = 6
		Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
		Me.btnEliminar.ImageOptions.LargeImage = CType(resources.GetObject("btnEliminar.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.btnEliminar.Name = "btnEliminar"
		'
		'btnEditar
		'
		Me.btnEditar.Hint = "Editar Consulta"
		Me.btnEditar.Id = 7
		Me.btnEditar.ImageOptions.Image = CType(resources.GetObject("btnEditar.ImageOptions.Image"), System.Drawing.Image)
		Me.btnEditar.ImageOptions.LargeImage = CType(resources.GetObject("btnEditar.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.btnEditar.Name = "btnEditar"
		'
		'barProcesos
		'
		Me.barProcesos.BarName = "Personalizada 6"
		Me.barProcesos.DockCol = 0
		Me.barProcesos.DockRow = 0
		Me.barProcesos.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
		Me.barProcesos.FloatLocation = New System.Drawing.Point(363, 419)
		Me.barProcesos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdNuevoProceso), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdEditarProceso), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdEliminarProceso), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdSubirOrdenProceso, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdBajarOrdenProceso)})
		Me.barProcesos.OptionsBar.AllowQuickCustomization = False
		Me.barProcesos.OptionsBar.DrawDragBorder = False
		Me.barProcesos.StandaloneBarDockControl = Me.StandaloneBarDockControl3
		Me.barProcesos.Text = "Personalizada 6"
		'
		'cmdNuevoProceso
		'
		Me.cmdNuevoProceso.Caption = "Nuevo"
		Me.cmdNuevoProceso.Id = 8
		Me.cmdNuevoProceso.ImageOptions.Image = CType(resources.GetObject("cmdNuevoProceso.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdNuevoProceso.ImageOptions.LargeImage = CType(resources.GetObject("cmdNuevoProceso.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.cmdNuevoProceso.Name = "cmdNuevoProceso"
		'
		'cmdEditarProceso
		'
		Me.cmdEditarProceso.Caption = "Editar"
		Me.cmdEditarProceso.Enabled = False
		Me.cmdEditarProceso.Id = 9
		Me.cmdEditarProceso.ImageOptions.Image = CType(resources.GetObject("cmdEditarProceso.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdEditarProceso.ImageOptions.LargeImage = CType(resources.GetObject("cmdEditarProceso.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.cmdEditarProceso.Name = "cmdEditarProceso"
		'
		'cmdEliminarProceso
		'
		Me.cmdEliminarProceso.Caption = "Eliminar"
		Me.cmdEliminarProceso.Enabled = False
		Me.cmdEliminarProceso.Id = 12
		Me.cmdEliminarProceso.ImageOptions.Image = CType(resources.GetObject("cmdEliminarProceso.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdEliminarProceso.ImageOptions.LargeImage = CType(resources.GetObject("cmdEliminarProceso.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.cmdEliminarProceso.Name = "cmdEliminarProceso"
		'
		'cmdSubirOrdenProceso
		'
		Me.cmdSubirOrdenProceso.Caption = "Subir"
		Me.cmdSubirOrdenProceso.Enabled = False
		Me.cmdSubirOrdenProceso.Id = 10
		Me.cmdSubirOrdenProceso.ImageOptions.Image = CType(resources.GetObject("cmdSubirOrdenProceso.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdSubirOrdenProceso.ImageOptions.LargeImage = CType(resources.GetObject("cmdSubirOrdenProceso.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.cmdSubirOrdenProceso.Name = "cmdSubirOrdenProceso"
		'
		'cmdBajarOrdenProceso
		'
		Me.cmdBajarOrdenProceso.Caption = "Bajar"
		Me.cmdBajarOrdenProceso.Enabled = False
		Me.cmdBajarOrdenProceso.Id = 11
		Me.cmdBajarOrdenProceso.ImageOptions.Image = CType(resources.GetObject("cmdBajarOrdenProceso.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdBajarOrdenProceso.ImageOptions.LargeImage = CType(resources.GetObject("cmdBajarOrdenProceso.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.cmdBajarOrdenProceso.Name = "cmdBajarOrdenProceso"
		'
		'StandaloneBarDockControl3
		'
		Me.StandaloneBarDockControl3.Appearance.BackColor = System.Drawing.Color.White
		Me.StandaloneBarDockControl3.Appearance.BackColor2 = System.Drawing.Color.White
		Me.StandaloneBarDockControl3.Appearance.Options.UseBackColor = True
		Me.StandaloneBarDockControl3.AutoSize = True
		Me.StandaloneBarDockControl3.CausesValidation = False
		Me.StandaloneBarDockControl3.Location = New System.Drawing.Point(37, 207)
		Me.StandaloneBarDockControl3.Manager = Me.BarManager1
		Me.StandaloneBarDockControl3.Margin = New System.Windows.Forms.Padding(0)
		Me.StandaloneBarDockControl3.Name = "StandaloneBarDockControl3"
		Me.StandaloneBarDockControl3.Size = New System.Drawing.Size(223, 39)
		Me.StandaloneBarDockControl3.Text = "StandaloneBarDockControl3"
		'
		'Bar3
		'
		Me.Bar3.BarName = "barVariables"
		Me.Bar3.DockCol = 0
		Me.Bar3.DockRow = 0
		Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
		Me.Bar3.FloatLocation = New System.Drawing.Point(1237, 313)
		Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEditarVariable, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnNuevaVariable, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEliminarVariable, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSubirVariable, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVariableBajarOrden, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.Bar3.OptionsBar.AllowQuickCustomization = False
		Me.Bar3.OptionsBar.DrawDragBorder = False
		Me.Bar3.StandaloneBarDockControl = Me.StandaloneBarDockControl4
		Me.Bar3.Text = "barVariables"
		'
		'btnEditarVariable
		'
		Me.btnEditarVariable.Hint = "Editar Variable"
		Me.btnEditarVariable.Id = 14
		Me.btnEditarVariable.ImageOptions.Image = CType(resources.GetObject("btnEditarVariable.ImageOptions.Image"), System.Drawing.Image)
		Me.btnEditarVariable.ImageOptions.LargeImage = CType(resources.GetObject("btnEditarVariable.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.btnEditarVariable.Name = "btnEditarVariable"
		'
		'btnNuevaVariable
		'
		Me.btnNuevaVariable.Hint = "Nueva Variable"
		Me.btnNuevaVariable.Id = 13
		Me.btnNuevaVariable.ImageOptions.Image = CType(resources.GetObject("btnNuevaVariable.ImageOptions.Image"), System.Drawing.Image)
		Me.btnNuevaVariable.ImageOptions.LargeImage = CType(resources.GetObject("btnNuevaVariable.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.btnNuevaVariable.Name = "btnNuevaVariable"
		'
		'btnEliminarVariable
		'
		Me.btnEliminarVariable.Id = 15
		Me.btnEliminarVariable.ImageOptions.Image = CType(resources.GetObject("btnEliminarVariable.ImageOptions.Image"), System.Drawing.Image)
		Me.btnEliminarVariable.ImageOptions.LargeImage = CType(resources.GetObject("btnEliminarVariable.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.btnEliminarVariable.Name = "btnEliminarVariable"
		'
		'btnSubirVariable
		'
		Me.btnSubirVariable.Hint = "Subir orden"
		Me.btnSubirVariable.Id = 16
		Me.btnSubirVariable.ImageOptions.Image = CType(resources.GetObject("btnSubirVariable.ImageOptions.Image"), System.Drawing.Image)
		Me.btnSubirVariable.ImageOptions.LargeImage = CType(resources.GetObject("btnSubirVariable.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.btnSubirVariable.Name = "btnSubirVariable"
		'
		'btnVariableBajarOrden
		'
		Me.btnVariableBajarOrden.Hint = "Bajar orden"
		Me.btnVariableBajarOrden.Id = 17
		Me.btnVariableBajarOrden.ImageOptions.Image = CType(resources.GetObject("btnVariableBajarOrden.ImageOptions.Image"), System.Drawing.Image)
		Me.btnVariableBajarOrden.ImageOptions.LargeImage = CType(resources.GetObject("btnVariableBajarOrden.ImageOptions.LargeImage"), System.Drawing.Image)
		Me.btnVariableBajarOrden.Name = "btnVariableBajarOrden"
		'
		'StandaloneBarDockControl4
		'
		Me.StandaloneBarDockControl4.CausesValidation = False
		Me.StandaloneBarDockControl4.Dock = System.Windows.Forms.DockStyle.Top
		Me.StandaloneBarDockControl4.Location = New System.Drawing.Point(3, 3)
		Me.StandaloneBarDockControl4.Manager = Me.BarManager1
		Me.StandaloneBarDockControl4.Margin = New System.Windows.Forms.Padding(4)
		Me.StandaloneBarDockControl4.Name = "StandaloneBarDockControl4"
		Me.StandaloneBarDockControl4.Size = New System.Drawing.Size(244, 34)
		Me.StandaloneBarDockControl4.Text = "StandaloneBarDockControl4"
		'
		'barDockControlTop
		'
		Me.barDockControlTop.CausesValidation = False
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Manager = Me.BarManager1
		Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
		Me.barDockControlTop.Size = New System.Drawing.Size(1413, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 833)
		Me.barDockControlBottom.Manager = Me.BarManager1
		Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
		Me.barDockControlBottom.Size = New System.Drawing.Size(1413, 0)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlLeft.Manager = Me.BarManager1
		Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 833)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(1413, 0)
		Me.barDockControlRight.Manager = Me.BarManager1
		Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 833)
		'
		'GridCons
		'
		Me.GridCons.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GridCons.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
		Me.GridCons.Location = New System.Drawing.Point(0, 34)
		Me.GridCons.MainView = Me.GridViewCons
		Me.GridCons.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.GridCons.Name = "GridCons"
		Me.GridCons.Size = New System.Drawing.Size(311, 672)
		Me.GridCons.TabIndex = 0
		Me.GridCons.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCons})
		'
		'GridViewCons
		'
		Me.GridViewCons.Appearance.SelectedRow.BackColor = System.Drawing.SystemColors.Highlight
		Me.GridViewCons.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.GridViewCons.Appearance.SelectedRow.Options.UseBackColor = True
		Me.GridViewCons.Appearance.SelectedRow.Options.UseBorderColor = True
		Me.GridViewCons.Appearance.SelectedRow.Options.UseFont = True
		Me.GridViewCons.Appearance.SelectedRow.Options.UseTextOptions = True
		Me.GridViewCons.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombreConsulta, Me.colCodTran, Me.colCodCon, Me.ColNombre})
		Me.GridViewCons.GridControl = Me.GridCons
		Me.GridViewCons.Name = "GridViewCons"
		Me.GridViewCons.OptionsBehavior.Editable = False
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
		Me.colCodTran.FieldName = "CS_CODTRA"
		Me.colCodTran.Name = "colCodTran"
		'
		'colCodCon
		'
		Me.colCodCon.FieldName = "CS_CODCON"
		Me.colCodCon.Name = "colCodCon"
		'
		'ColNombre
		'
		Me.ColNombre.FieldName = "CS_NOMBRE"
		Me.ColNombre.Name = "ColNombre"
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
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(1092, 706)
		Me.TableLayoutPanel2.TabIndex = 2
		'
		'tabPanel
		'
		Me.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabPanel.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
		Me.tabPanel.Location = New System.Drawing.Point(0, 30)
		Me.tabPanel.Margin = New System.Windows.Forms.Padding(0)
		Me.tabPanel.Name = "tabPanel"
		Me.tabPanel.SelectedTabPage = Me.tabPageFormulario
		Me.tabPanel.Size = New System.Drawing.Size(1092, 676)
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
		Me.tabPageFormulario.Size = New System.Drawing.Size(1085, 642)
		Me.tabPageFormulario.Text = "Formulario"
		'
		'cmdValidarUpdate
		'
		Me.cmdValidarUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdValidarUpdate.Appearance.Options.UseFont = True
		Me.cmdValidarUpdate.Enabled = False
		Me.cmdValidarUpdate.Location = New System.Drawing.Point(669, 249)
		Me.cmdValidarUpdate.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdValidarUpdate.Name = "cmdValidarUpdate"
		Me.cmdValidarUpdate.Size = New System.Drawing.Size(133, 25)
		Me.cmdValidarUpdate.TabIndex = 22
		Me.cmdValidarUpdate.Text = "Validación ABM"
		'
		'cmdBaja
		'
		Me.cmdBaja.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdBaja.Appearance.Options.UseFont = True
		Me.cmdBaja.Enabled = False
		Me.cmdBaja.Location = New System.Drawing.Point(368, 218)
		Me.cmdBaja.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdBaja.Name = "cmdBaja"
		Me.cmdBaja.Size = New System.Drawing.Size(133, 25)
		Me.cmdBaja.TabIndex = 21
		Me.cmdBaja.Text = "&Query de Baja"
		'
		'SimpleButton7
		'
		Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.SimpleButton7.Appearance.Options.UseFont = True
		Me.SimpleButton7.Enabled = False
		Me.SimpleButton7.Location = New System.Drawing.Point(520, 310)
		Me.SimpleButton7.Margin = New System.Windows.Forms.Padding(0)
		Me.SimpleButton7.Name = "SimpleButton7"
		Me.SimpleButton7.Size = New System.Drawing.Size(133, 25)
		Me.SimpleButton7.TabIndex = 20
		Me.SimpleButton7.Text = "&Query de Validación"
		'
		'cmdDrillDown
		'
		Me.cmdDrillDown.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdDrillDown.Appearance.Options.UseFont = True
		Me.cmdDrillDown.Enabled = False
		Me.cmdDrillDown.Location = New System.Drawing.Point(368, 310)
		Me.cmdDrillDown.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdDrillDown.Name = "cmdDrillDown"
		Me.cmdDrillDown.Size = New System.Drawing.Size(133, 25)
		Me.cmdDrillDown.TabIndex = 19
		Me.cmdDrillDown.Text = "&Query Drill Down"
		'
		'cmdValidaNuevoDesde
		'
		Me.cmdValidaNuevoDesde.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdValidaNuevoDesde.Appearance.Options.UseFont = True
		Me.cmdValidaNuevoDesde.Enabled = False
		Me.cmdValidaNuevoDesde.Location = New System.Drawing.Point(520, 279)
		Me.cmdValidaNuevoDesde.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdValidaNuevoDesde.Name = "cmdValidaNuevoDesde"
		Me.cmdValidaNuevoDesde.Size = New System.Drawing.Size(133, 25)
		Me.cmdValidaNuevoDesde.TabIndex = 18
		Me.cmdValidaNuevoDesde.Text = "&Query de Validación"
		'
		'cmdQueryNDesde
		'
		Me.cmdQueryNDesde.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdQueryNDesde.Appearance.Options.UseFont = True
		Me.cmdQueryNDesde.Enabled = False
		Me.cmdQueryNDesde.Location = New System.Drawing.Point(368, 279)
		Me.cmdQueryNDesde.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdQueryNDesde.Name = "cmdQueryNDesde"
		Me.cmdQueryNDesde.Size = New System.Drawing.Size(133, 25)
		Me.cmdQueryNDesde.TabIndex = 17
		Me.cmdQueryNDesde.Text = "&Query"
		'
		'cmdModValida
		'
		Me.cmdModValida.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdModValida.Appearance.Options.UseFont = True
		Me.cmdModValida.Enabled = False
		Me.cmdModValida.Location = New System.Drawing.Point(520, 249)
		Me.cmdModValida.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdModValida.Name = "cmdModValida"
		Me.cmdModValida.Size = New System.Drawing.Size(133, 25)
		Me.cmdModValida.TabIndex = 16
		Me.cmdModValida.Text = "&Query de Validación"
		'
		'cmdQueryUpdate
		'
		Me.cmdQueryUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdQueryUpdate.Appearance.Options.UseFont = True
		Me.cmdQueryUpdate.Enabled = False
		Me.cmdQueryUpdate.Location = New System.Drawing.Point(368, 249)
		Me.cmdQueryUpdate.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdQueryUpdate.Name = "cmdQueryUpdate"
		Me.cmdQueryUpdate.Size = New System.Drawing.Size(133, 25)
		Me.cmdQueryUpdate.TabIndex = 15
		Me.cmdQueryUpdate.Text = "&Query de Modif."
		'
		'cmdAltaValida
		'
		Me.cmdAltaValida.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdAltaValida.Appearance.Options.UseFont = True
		Me.cmdAltaValida.Enabled = False
		Me.cmdAltaValida.Location = New System.Drawing.Point(520, 186)
		Me.cmdAltaValida.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdAltaValida.Name = "cmdAltaValida"
		Me.cmdAltaValida.Size = New System.Drawing.Size(133, 25)
		Me.cmdAltaValida.TabIndex = 14
		Me.cmdAltaValida.Text = "Validación ABM"
		'
		'cmdAlta
		'
		Me.cmdAlta.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
		Me.cmdAlta.Appearance.Options.UseFont = True
		Me.cmdAlta.Enabled = False
		Me.cmdAlta.Location = New System.Drawing.Point(368, 186)
		Me.cmdAlta.Margin = New System.Windows.Forms.Padding(0)
		Me.cmdAlta.Name = "cmdAlta"
		Me.cmdAlta.Size = New System.Drawing.Size(133, 25)
		Me.cmdAlta.TabIndex = 13
		Me.cmdAlta.Text = "&Query de Alta"
		'
		'chkGroup
		'
		Me.chkGroup.Location = New System.Drawing.Point(151, 340)
		Me.chkGroup.Margin = New System.Windows.Forms.Padding(4)
		Me.chkGroup.MenuManager = Me.BarManager1
		Me.chkGroup.Name = "chkGroup"
		Me.chkGroup.Properties.Caption = "Mostrar cuadro de a&grupación en grilla"
		Me.chkGroup.Size = New System.Drawing.Size(307, 20)
		Me.chkGroup.TabIndex = 12
		'
		'chkDrillDown
		'
		Me.chkDrillDown.Location = New System.Drawing.Point(151, 309)
		Me.chkDrillDown.Margin = New System.Windows.Forms.Padding(4)
		Me.chkDrillDown.MenuManager = Me.BarManager1
		Me.chkDrillDown.Name = "chkDrillDown"
		Me.chkDrillDown.Properties.Caption = "Utilizar &Dril lDown"
		Me.chkDrillDown.Size = New System.Drawing.Size(240, 20)
		Me.chkDrillDown.TabIndex = 11
		'
		'chkNDesde
		'
		Me.chkNDesde.Location = New System.Drawing.Point(151, 278)
		Me.chkNDesde.Margin = New System.Windows.Forms.Padding(4)
		Me.chkNDesde.MenuManager = Me.BarManager1
		Me.chkNDesde.Name = "chkNDesde"
		Me.chkNDesde.Properties.Caption = "Permite &Nuevo Desde"
		Me.chkNDesde.Size = New System.Drawing.Size(240, 20)
		Me.chkNDesde.TabIndex = 10
		'
		'chkABM
		'
		Me.chkABM.Location = New System.Drawing.Point(151, 247)
		Me.chkABM.Margin = New System.Windows.Forms.Padding(4)
		Me.chkABM.MenuManager = Me.BarManager1
		Me.chkABM.Name = "chkABM"
		Me.chkABM.Properties.Caption = "Permite &Modificar Registros"
		Me.chkABM.Size = New System.Drawing.Size(240, 20)
		Me.chkABM.TabIndex = 9
		'
		'chkAlta
		'
		Me.chkAlta.Location = New System.Drawing.Point(151, 186)
		Me.chkAlta.Margin = New System.Windows.Forms.Padding(4)
		Me.chkAlta.MenuManager = Me.BarManager1
		Me.chkAlta.Name = "chkAlta"
		Me.chkAlta.Properties.Caption = "Permite &Alta de Registros"
		Me.chkAlta.Size = New System.Drawing.Size(240, 20)
		Me.chkAlta.TabIndex = 8
		'
		'chkBaja
		'
		Me.chkBaja.Location = New System.Drawing.Point(151, 217)
		Me.chkBaja.Margin = New System.Windows.Forms.Padding(4)
		Me.chkBaja.MenuManager = Me.BarManager1
		Me.chkBaja.Name = "chkBaja"
		Me.chkBaja.Properties.Caption = "Permite &Baja de Registros"
		Me.chkBaja.Size = New System.Drawing.Size(240, 20)
		Me.chkBaja.TabIndex = 7
		'
		'txtDescriCab
		'
		Me.txtDescriCab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtDescriCab.Location = New System.Drawing.Point(151, 84)
		Me.txtDescriCab.Margin = New System.Windows.Forms.Padding(4)
		Me.txtDescriCab.MenuManager = Me.BarManager1
		Me.txtDescriCab.Name = "txtDescriCab"
		Me.txtDescriCab.Size = New System.Drawing.Size(881, 82)
		Me.txtDescriCab.TabIndex = 6
		'
		'txtCodTraCab
		'
		Me.txtCodTraCab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCodTraCab.Location = New System.Drawing.Point(151, 49)
		Me.txtCodTraCab.Margin = New System.Windows.Forms.Padding(4)
		Me.txtCodTraCab.MenuManager = Me.BarManager1
		Me.txtCodTraCab.Name = "txtCodTraCab"
		Me.txtCodTraCab.Size = New System.Drawing.Size(881, 22)
		Me.txtCodTraCab.TabIndex = 5
		'
		'txtNombreCab
		'
		Me.txtNombreCab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtNombreCab.Location = New System.Drawing.Point(151, 17)
		Me.txtNombreCab.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNombreCab.MenuManager = Me.BarManager1
		Me.txtNombreCab.Name = "txtNombreCab"
		Me.txtNombreCab.Size = New System.Drawing.Size(881, 22)
		Me.txtNombreCab.TabIndex = 3
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(65, 85)
		Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(70, 16)
		Me.LabelControl3.TabIndex = 2
		Me.LabelControl3.Text = "Descripción:"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(61, 53)
		Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(74, 16)
		Me.LabelControl2.TabIndex = 1
		Me.LabelControl2.Text = "Transacción:"
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(88, 21)
		Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(50, 16)
		Me.LabelControl1.TabIndex = 0
		Me.LabelControl1.Text = "Nombre:"
		'
		'tabPageQuery
		'
		Me.tabPageQuery.Controls.Add(Me.lyVariables)
		Me.tabPageQuery.ImageOptions.Image = CType(resources.GetObject("tabPageQuery.ImageOptions.Image"), System.Drawing.Image)
		Me.tabPageQuery.Margin = New System.Windows.Forms.Padding(0)
		Me.tabPageQuery.Name = "tabPageQuery"
		Me.tabPageQuery.Size = New System.Drawing.Size(1085, 642)
		Me.tabPageQuery.Text = "Query"
		'
		'lyVariables
		'
		Me.lyVariables.ColumnCount = 2
		Me.lyVariables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.lyVariables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
		Me.lyVariables.Controls.Add(Me.TableLayoutPanel3, 1, 0)
		Me.lyVariables.Controls.Add(Me.pnlQuery, 0, 0)
		Me.lyVariables.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lyVariables.Location = New System.Drawing.Point(0, 0)
		Me.lyVariables.Margin = New System.Windows.Forms.Padding(0)
		Me.lyVariables.Name = "lyVariables"
		Me.lyVariables.RowCount = 1
		Me.lyVariables.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.lyVariables.Size = New System.Drawing.Size(1085, 642)
		Me.lyVariables.TabIndex = 0
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 1
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.PanelControl1, 0, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.PanelControl6, 0, 1)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(835, 0)
		Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 3
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(250, 642)
		Me.TableLayoutPanel3.TabIndex = 2
		'
		'PanelControl1
		'
		Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
		Me.PanelControl1.Appearance.Options.UseBackColor = True
		Me.PanelControl1.Controls.Add(Me.gridVariables)
		Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanelControl1.Location = New System.Drawing.Point(4, 252)
		Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
		Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
		Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
		Me.PanelControl1.Name = "PanelControl1"
		Me.PanelControl1.Size = New System.Drawing.Size(242, 386)
		Me.PanelControl1.TabIndex = 0
		'
		'gridVariables
		'
		Me.gridVariables.Dock = System.Windows.Forms.DockStyle.Fill
		Me.gridVariables.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
		Me.gridVariables.Location = New System.Drawing.Point(3, 3)
		Me.gridVariables.MainView = Me.gridViewVariables
		Me.gridVariables.Margin = New System.Windows.Forms.Padding(0)
		Me.gridVariables.MenuManager = Me.BarManager1
		Me.gridVariables.Name = "gridVariables"
		Me.gridVariables.Size = New System.Drawing.Size(236, 380)
		Me.gridVariables.TabIndex = 3
		Me.gridVariables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewVariables})
		'
		'gridViewVariables
		'
		Me.gridViewVariables.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSkyBlue
		Me.gridViewVariables.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightSkyBlue
		Me.gridViewVariables.Appearance.FocusedRow.Options.UseBackColor = True
		Me.gridViewVariables.GridControl = Me.gridVariables
		Me.gridViewVariables.Name = "gridViewVariables"
		Me.gridViewVariables.OptionsBehavior.Editable = False
		Me.gridViewVariables.OptionsSelection.MultiSelect = True
		Me.gridViewVariables.OptionsSelection.UseIndicatorForSelection = False
		Me.gridViewVariables.OptionsView.ShowGroupPanel = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Panel1.Controls.Add(Me.LabelControl16)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(4, 4)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(242, 20)
		Me.Panel1.TabIndex = 1
		'
		'LabelControl16
		'
		Me.LabelControl16.Location = New System.Drawing.Point(13, 2)
		Me.LabelControl16.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl16.Name = "LabelControl16"
		Me.LabelControl16.Size = New System.Drawing.Size(119, 16)
		Me.LabelControl16.TabIndex = 0
		Me.LabelControl16.Text = "Variables de entrada"
		'
		'PanelControl6
		'
		Me.PanelControl6.Appearance.BackColor = System.Drawing.Color.White
		Me.PanelControl6.Appearance.Options.UseBackColor = True
		Me.PanelControl6.Controls.Add(Me.PanelControl7)
		Me.PanelControl6.Controls.Add(Me.StandaloneBarDockControl4)
		Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanelControl6.Location = New System.Drawing.Point(0, 28)
		Me.PanelControl6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
		Me.PanelControl6.LookAndFeel.UseDefaultLookAndFeel = False
		Me.PanelControl6.Margin = New System.Windows.Forms.Padding(0)
		Me.PanelControl6.Name = "PanelControl6"
		Me.PanelControl6.Size = New System.Drawing.Size(250, 220)
		Me.PanelControl6.TabIndex = 2
		'
		'PanelControl7
		'
		Me.PanelControl7.Appearance.BackColor = System.Drawing.Color.White
		Me.PanelControl7.Appearance.Options.UseBackColor = True
		Me.PanelControl7.Controls.Add(Me.txtVarOrden)
		Me.PanelControl7.Controls.Add(Me.LabelControl21)
		Me.PanelControl7.Controls.Add(Me.txtVarNombre)
		Me.PanelControl7.Controls.Add(Me.LabelControl20)
		Me.PanelControl7.Controls.Add(Me.txtVarTitulo)
		Me.PanelControl7.Controls.Add(Me.LabelControl19)
		Me.PanelControl7.Controls.Add(Me.txtVarDato)
		Me.PanelControl7.Controls.Add(Me.LabelControl18)
		Me.PanelControl7.Controls.Add(Me.txtVarHelp)
		Me.PanelControl7.Controls.Add(Me.LabelControl17)
		Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanelControl7.Location = New System.Drawing.Point(3, 37)
		Me.PanelControl7.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
		Me.PanelControl7.LookAndFeel.UseDefaultLookAndFeel = False
		Me.PanelControl7.Margin = New System.Windows.Forms.Padding(4)
		Me.PanelControl7.Name = "PanelControl7"
		Me.PanelControl7.Size = New System.Drawing.Size(244, 180)
		Me.PanelControl7.TabIndex = 1
		'
		'txtVarOrden
		'
		Me.txtVarOrden.Location = New System.Drawing.Point(74, 8)
		Me.txtVarOrden.Margin = New System.Windows.Forms.Padding(4)
		Me.txtVarOrden.MaximumSize = New System.Drawing.Size(99, 25)
		Me.txtVarOrden.MinimumSize = New System.Drawing.Size(150, 25)
		Me.txtVarOrden.Name = "txtVarOrden"
		Me.txtVarOrden.Properties.Appearance.Options.UseTextOptions = True
		Me.txtVarOrden.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarOrden.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtVarOrden.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtVarOrden.Properties.AppearanceReadOnly.Options.UseTextOptions = True
		Me.txtVarOrden.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarOrden.Properties.AutoHeight = False
		Me.txtVarOrden.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtVarOrden.Properties.ReadOnly = True
		Me.txtVarOrden.Size = New System.Drawing.Size(150, 25)
		Me.txtVarOrden.TabIndex = 24
		'
		'LabelControl21
		'
		Me.LabelControl21.Location = New System.Drawing.Point(25, 12)
		Me.LabelControl21.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl21.Name = "LabelControl21"
		Me.LabelControl21.Size = New System.Drawing.Size(40, 16)
		Me.LabelControl21.TabIndex = 23
		Me.LabelControl21.Text = "Orden:"
		'
		'txtVarNombre
		'
		Me.txtVarNombre.Location = New System.Drawing.Point(74, 41)
		Me.txtVarNombre.Margin = New System.Windows.Forms.Padding(4)
		Me.txtVarNombre.MaximumSize = New System.Drawing.Size(99, 25)
		Me.txtVarNombre.MinimumSize = New System.Drawing.Size(150, 25)
		Me.txtVarNombre.Name = "txtVarNombre"
		Me.txtVarNombre.Properties.Appearance.Options.UseTextOptions = True
		Me.txtVarNombre.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarNombre.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtVarNombre.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtVarNombre.Properties.AppearanceReadOnly.Options.UseTextOptions = True
		Me.txtVarNombre.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarNombre.Properties.AutoHeight = False
		Me.txtVarNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtVarNombre.Properties.ReadOnly = True
		Me.txtVarNombre.Size = New System.Drawing.Size(150, 25)
		Me.txtVarNombre.TabIndex = 22
		'
		'LabelControl20
		'
		Me.LabelControl20.Location = New System.Drawing.Point(15, 45)
		Me.LabelControl20.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl20.Name = "LabelControl20"
		Me.LabelControl20.Size = New System.Drawing.Size(50, 16)
		Me.LabelControl20.TabIndex = 21
		Me.LabelControl20.Text = "Nombre:"
		'
		'txtVarTitulo
		'
		Me.txtVarTitulo.Location = New System.Drawing.Point(74, 74)
		Me.txtVarTitulo.Margin = New System.Windows.Forms.Padding(4)
		Me.txtVarTitulo.MaximumSize = New System.Drawing.Size(99, 25)
		Me.txtVarTitulo.MinimumSize = New System.Drawing.Size(150, 25)
		Me.txtVarTitulo.Name = "txtVarTitulo"
		Me.txtVarTitulo.Properties.Appearance.Options.UseTextOptions = True
		Me.txtVarTitulo.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarTitulo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtVarTitulo.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtVarTitulo.Properties.AppearanceReadOnly.Options.UseTextOptions = True
		Me.txtVarTitulo.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarTitulo.Properties.AutoHeight = False
		Me.txtVarTitulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtVarTitulo.Properties.ReadOnly = True
		Me.txtVarTitulo.Size = New System.Drawing.Size(150, 25)
		Me.txtVarTitulo.TabIndex = 20
		'
		'LabelControl19
		'
		Me.LabelControl19.Location = New System.Drawing.Point(28, 78)
		Me.LabelControl19.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl19.Name = "LabelControl19"
		Me.LabelControl19.Size = New System.Drawing.Size(37, 16)
		Me.LabelControl19.TabIndex = 19
		Me.LabelControl19.Text = "Título:"
		'
		'txtVarDato
		'
		Me.txtVarDato.Location = New System.Drawing.Point(74, 107)
		Me.txtVarDato.Margin = New System.Windows.Forms.Padding(4)
		Me.txtVarDato.MaximumSize = New System.Drawing.Size(99, 25)
		Me.txtVarDato.MinimumSize = New System.Drawing.Size(150, 25)
		Me.txtVarDato.Name = "txtVarDato"
		Me.txtVarDato.Properties.Appearance.Options.UseTextOptions = True
		Me.txtVarDato.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarDato.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtVarDato.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtVarDato.Properties.AppearanceReadOnly.Options.UseTextOptions = True
		Me.txtVarDato.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarDato.Properties.AutoHeight = False
		Me.txtVarDato.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtVarDato.Properties.ReadOnly = True
		Me.txtVarDato.Size = New System.Drawing.Size(150, 25)
		Me.txtVarDato.TabIndex = 18
		'
		'LabelControl18
		'
		Me.LabelControl18.Location = New System.Drawing.Point(34, 111)
		Me.LabelControl18.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl18.Name = "LabelControl18"
		Me.LabelControl18.Size = New System.Drawing.Size(31, 16)
		Me.LabelControl18.TabIndex = 17
		Me.LabelControl18.Text = "Dato:"
		'
		'txtVarHelp
		'
		Me.txtVarHelp.Location = New System.Drawing.Point(75, 140)
		Me.txtVarHelp.Margin = New System.Windows.Forms.Padding(4)
		Me.txtVarHelp.MaximumSize = New System.Drawing.Size(99, 25)
		Me.txtVarHelp.MinimumSize = New System.Drawing.Size(150, 25)
		Me.txtVarHelp.Name = "txtVarHelp"
		Me.txtVarHelp.Properties.Appearance.Options.UseTextOptions = True
		Me.txtVarHelp.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarHelp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
		Me.txtVarHelp.Properties.AppearanceReadOnly.Options.UseBackColor = True
		Me.txtVarHelp.Properties.AppearanceReadOnly.Options.UseTextOptions = True
		Me.txtVarHelp.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
		Me.txtVarHelp.Properties.AutoHeight = False
		Me.txtVarHelp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtVarHelp.Properties.ReadOnly = True
		Me.txtVarHelp.Size = New System.Drawing.Size(150, 25)
		Me.txtVarHelp.TabIndex = 16
		'
		'LabelControl17
		'
		Me.LabelControl17.Location = New System.Drawing.Point(35, 144)
		Me.LabelControl17.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl17.Name = "LabelControl17"
		Me.LabelControl17.Size = New System.Drawing.Size(30, 16)
		Me.LabelControl17.TabIndex = 15
		Me.LabelControl17.Text = "Help:"
		'
		'pnlQuery
		'
		Me.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlQuery.Location = New System.Drawing.Point(0, 0)
		Me.pnlQuery.Margin = New System.Windows.Forms.Padding(0)
		Me.pnlQuery.Name = "pnlQuery"
		Me.pnlQuery.Size = New System.Drawing.Size(835, 642)
		Me.pnlQuery.TabIndex = 0
		'
		'tabPageColumnas
		'
		Me.tabPageColumnas.ImageOptions.Image = CType(resources.GetObject("tabPageColumnas.ImageOptions.Image"), System.Drawing.Image)
		Me.tabPageColumnas.Margin = New System.Windows.Forms.Padding(0)
		Me.tabPageColumnas.Name = "tabPageColumnas"
		Me.tabPageColumnas.Size = New System.Drawing.Size(1085, 642)
		Me.tabPageColumnas.Text = "Columnas"
		'
		'tabPageProcesos
		'
		Me.tabPageProcesos.Controls.Add(Me.StandaloneBarDockControl3)
		Me.tabPageProcesos.Controls.Add(Me.gridProc)
		Me.tabPageProcesos.Controls.Add(Me.txtDescriPro)
		Me.tabPageProcesos.Controls.Add(Me.txtParamPro)
		Me.tabPageProcesos.Controls.Add(Me.txtTituloPro)
		Me.tabPageProcesos.Controls.Add(Me.txtNombrePro)
		Me.tabPageProcesos.Controls.Add(Me.txtOrdenPro)
		Me.tabPageProcesos.Controls.Add(Me.LabelControl8)
		Me.tabPageProcesos.Controls.Add(Me.LabelControl7)
		Me.tabPageProcesos.Controls.Add(Me.LabelControl6)
		Me.tabPageProcesos.Controls.Add(Me.LabelControl5)
		Me.tabPageProcesos.Controls.Add(Me.LabelControl4)
		Me.tabPageProcesos.ImageOptions.Image = CType(resources.GetObject("tabPageProcesos.ImageOptions.Image"), System.Drawing.Image)
		Me.tabPageProcesos.Margin = New System.Windows.Forms.Padding(0)
		Me.tabPageProcesos.Name = "tabPageProcesos"
		Me.tabPageProcesos.Size = New System.Drawing.Size(1085, 638)
		Me.tabPageProcesos.Text = "Procesos Previos"
		'
		'gridProc
		'
		Me.gridProc.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
		Me.gridProc.Location = New System.Drawing.Point(37, 246)
		Me.gridProc.MainView = Me.gridViewProc
		Me.gridProc.Margin = New System.Windows.Forms.Padding(4)
		Me.gridProc.MenuManager = Me.BarManager1
		Me.gridProc.Name = "gridProc"
		Me.gridProc.Size = New System.Drawing.Size(557, 246)
		Me.gridProc.TabIndex = 2
		Me.gridProc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewProc})
		'
		'gridViewProc
		'
		Me.gridViewProc.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSkyBlue
		Me.gridViewProc.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightSkyBlue
		Me.gridViewProc.Appearance.FocusedRow.Options.UseBackColor = True
		Me.gridViewProc.GridControl = Me.gridProc
		Me.gridViewProc.Name = "gridViewProc"
		Me.gridViewProc.OptionsBehavior.Editable = False
		Me.gridViewProc.OptionsSelection.MultiSelect = True
		Me.gridViewProc.OptionsView.ShowGroupPanel = False
		'
		'txtDescriPro
		'
		Me.txtDescriPro.Location = New System.Drawing.Point(124, 111)
		Me.txtDescriPro.Margin = New System.Windows.Forms.Padding(4)
		Me.txtDescriPro.Name = "txtDescriPro"
		Me.txtDescriPro.Properties.ReadOnly = True
		Me.txtDescriPro.Size = New System.Drawing.Size(471, 22)
		Me.txtDescriPro.TabIndex = 1
		'
		'txtParamPro
		'
		Me.txtParamPro.Location = New System.Drawing.Point(124, 143)
		Me.txtParamPro.Margin = New System.Windows.Forms.Padding(4)
		Me.txtParamPro.Name = "txtParamPro"
		Me.txtParamPro.Properties.ReadOnly = True
		Me.txtParamPro.Size = New System.Drawing.Size(471, 22)
		Me.txtParamPro.TabIndex = 1
		'
		'txtTituloPro
		'
		Me.txtTituloPro.Location = New System.Drawing.Point(124, 79)
		Me.txtTituloPro.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTituloPro.Name = "txtTituloPro"
		Me.txtTituloPro.Properties.ReadOnly = True
		Me.txtTituloPro.Size = New System.Drawing.Size(471, 22)
		Me.txtTituloPro.TabIndex = 1
		'
		'txtNombrePro
		'
		Me.txtNombrePro.Location = New System.Drawing.Point(124, 47)
		Me.txtNombrePro.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNombrePro.Name = "txtNombrePro"
		Me.txtNombrePro.Properties.ReadOnly = True
		Me.txtNombrePro.Size = New System.Drawing.Size(471, 22)
		Me.txtNombrePro.TabIndex = 1
		'
		'txtOrdenPro
		'
		Me.txtOrdenPro.Location = New System.Drawing.Point(124, 15)
		Me.txtOrdenPro.Margin = New System.Windows.Forms.Padding(4)
		Me.txtOrdenPro.MenuManager = Me.BarManager1
		Me.txtOrdenPro.Name = "txtOrdenPro"
		Me.txtOrdenPro.Properties.ReadOnly = True
		Me.txtOrdenPro.Size = New System.Drawing.Size(471, 22)
		Me.txtOrdenPro.TabIndex = 1
		'
		'LabelControl8
		'
		Me.LabelControl8.Location = New System.Drawing.Point(37, 146)
		Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl8.Name = "LabelControl8"
		Me.LabelControl8.Size = New System.Drawing.Size(71, 16)
		Me.LabelControl8.TabIndex = 0
		Me.LabelControl8.Text = "Parametros:"
		'
		'LabelControl7
		'
		Me.LabelControl7.Location = New System.Drawing.Point(37, 114)
		Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl7.Name = "LabelControl7"
		Me.LabelControl7.Size = New System.Drawing.Size(70, 16)
		Me.LabelControl7.TabIndex = 0
		Me.LabelControl7.Text = "Descripcion:"
		'
		'LabelControl6
		'
		Me.LabelControl6.Location = New System.Drawing.Point(76, 82)
		Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl6.Name = "LabelControl6"
		Me.LabelControl6.Size = New System.Drawing.Size(37, 16)
		Me.LabelControl6.TabIndex = 0
		Me.LabelControl6.Text = "Titulo:"
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(61, 50)
		Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(50, 16)
		Me.LabelControl5.TabIndex = 0
		Me.LabelControl5.Text = "Nombre:"
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(71, 18)
		Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(40, 16)
		Me.LabelControl4.TabIndex = 0
		Me.LabelControl4.Text = "Orden:"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1413, 833)
		Me.Controls.Add(Me.pnlMain)
		Me.Controls.Add(Me.PanTop)
		Me.Controls.Add(Me.sbMain)
		Me.Controls.Add(Me.toolMain)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
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
		Me.tabPageQuery.ResumeLayout(False)
		Me.lyVariables.ResumeLayout(False)
		Me.TableLayoutPanel3.ResumeLayout(False)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		CType(Me.gridVariables, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridViewVariables, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl6.ResumeLayout(False)
		CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl7.ResumeLayout(False)
		Me.PanelControl7.PerformLayout()
		CType(Me.txtVarOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVarNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVarTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVarDato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVarHelp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabPageProcesos.ResumeLayout(False)
		Me.tabPageProcesos.PerformLayout()
		CType(Me.gridProc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridViewProc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDescriPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtParamPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTituloPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNombrePro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtOrdenPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdGenerarScipt As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents ColNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDescriPro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtParamPro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTituloPro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombrePro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOrdenPro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridProc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewProc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barProcesos As DevExpress.XtraBars.Bar
    Friend WithEvents cmdNuevoProceso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdEditarProceso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdEliminarProceso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdSubirOrdenProceso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdBajarOrdenProceso As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents StandaloneBarDockControl3 As DevExpress.XtraBars.StandaloneBarDockControl
	Friend WithEvents lyVariables As TableLayoutPanel
	Friend WithEvents pnlQuery As Panel
	Friend WithEvents StandaloneBarDockControl4 As DevExpress.XtraBars.StandaloneBarDockControl
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
	Friend WithEvents gridVariables As DevExpress.XtraGrid.GridControl
	Friend WithEvents gridViewVariables As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents Panel1 As Panel
	Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
	Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
	Friend WithEvents txtVarOrden As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtVarNombre As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtVarTitulo As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtVarDato As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtVarHelp As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
	Friend WithEvents btnNuevaVariable As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnEditarVariable As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnEliminarVariable As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnSubirVariable As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnVariableBajarOrden As DevExpress.XtraBars.BarButtonItem
End Class
