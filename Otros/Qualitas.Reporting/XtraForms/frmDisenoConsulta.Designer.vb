<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisenoConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisenoConsulta))
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultas almacenadas")
        Dim Document5 As ActiproSoftware.SyntaxEditor.Document = New ActiproSoftware.SyntaxEditor.Document
        Dim VisualStudio2005SyntaxEditorRenderer5 As ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer = New ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer
        Dim Document6 As ActiproSoftware.SyntaxEditor.Document = New ActiproSoftware.SyntaxEditor.Document
        Dim VisualStudio2005SyntaxEditorRenderer6 As ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer = New ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer
        Dim Document7 As ActiproSoftware.SyntaxEditor.Document = New ActiproSoftware.SyntaxEditor.Document
        Dim VisualStudio2005SyntaxEditorRenderer7 As ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer = New ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer
        Dim Document8 As ActiproSoftware.SyntaxEditor.Document = New ActiproSoftware.SyntaxEditor.Document
        Dim VisualStudio2005SyntaxEditorRenderer8 As ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer = New ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer
        Me.dslSQL = New ActiproSoftware.SyntaxEditor.Addons.Dynamic.DynamicSyntaxLanguage(Me.components)
        Me.dxBars = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.btnSQLInicial = New DevExpress.XtraBars.BarButtonItem
        Me.btnSQLFinal = New DevExpress.XtraBars.BarButtonItem
        Me.btnSQLPrevio = New DevExpress.XtraBars.BarButtonItem
        Me.btnSQLPosterior = New DevExpress.XtraBars.BarButtonItem
        Me.mnuDeshacer = New DevExpress.XtraBars.BarButtonItem
        Me.mnuRehacer = New DevExpress.XtraBars.BarButtonItem
        Me.mnuCopiar = New DevExpress.XtraBars.BarButtonItem
        Me.mnuCortar = New DevExpress.XtraBars.BarButtonItem
        Me.mnuPegar = New DevExpress.XtraBars.BarButtonItem
        Me.mnuEliminar = New DevExpress.XtraBars.BarButtonItem
        Me.mnuSeleccionarTodo = New DevExpress.XtraBars.BarButtonItem
        Me.mnuBuscar = New DevExpress.XtraBars.BarButtonItem
        Me.mnuReemplazar = New DevExpress.XtraBars.BarButtonItem
        Me.mnuInsertarVariable = New DevExpress.XtraBars.BarButtonItem
        Me.popMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Tabs = New DevExpress.XtraTab.XtraTabControl
        Me.tpGeneral = New DevExpress.XtraTab.XtraTabPage
        Me.grpOpciones = New DevExpress.XtraEditors.GroupControl
        Me.txtFormatoFechas = New DevExpress.XtraEditors.TextEdit
        Me.rbcMain = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSQLInicialFinal = New DevExpress.XtraBars.BarButtonItem
        Me.popInicialFinal = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnSQLPrevioPosterior = New DevExpress.XtraBars.BarButtonItem
        Me.popPrevioPosterior = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnAsistenteSQL = New DevExpress.XtraBars.BarButtonItem
        Me.btnAgregarParametro = New DevExpress.XtraBars.BarButtonItem
        Me.btnModificarParametro = New DevExpress.XtraBars.BarButtonItem
        Me.btnEliminarParametro = New DevExpress.XtraBars.BarButtonItem
        Me.btnAgregarFormato = New DevExpress.XtraBars.BarButtonItem
        Me.btnEliminarFormato = New DevExpress.XtraBars.BarButtonItem
        Me.btnAgregarResultados = New DevExpress.XtraBars.BarButtonItem
        Me.btnEliminarResultados = New DevExpress.XtraBars.BarButtonItem
        Me.btnModoSplitter = New DevExpress.XtraBars.BarButtonItem
        Me.rpOpciones = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgComun = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgSQL = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgParametros = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgFormatos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgResultados = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.lblFormatoFechas = New DevExpress.XtraEditors.LabelControl
        Me.txtLiteralFechas = New DevExpress.XtraEditors.TextEdit
        Me.lblLiteralFechas = New DevExpress.XtraEditors.LabelControl
        Me.txtLiteralCadenas = New DevExpress.XtraEditors.TextEdit
        Me.lblLiteralCadenas = New DevExpress.XtraEditors.LabelControl
        Me.txtSimboloDecimal = New DevExpress.XtraEditors.TextEdit
        Me.lblSimboloDecimal = New DevExpress.XtraEditors.LabelControl
        Me.chkOpcionesDefault = New DevExpress.XtraEditors.CheckEdit
        Me.chkEjecucionAsincrona = New DevExpress.XtraEditors.CheckEdit
        Me.chkNativoSQL = New DevExpress.XtraEditors.CheckEdit
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.chkPasswordProtected = New DevExpress.XtraEditors.CheckEdit
        Me.cboConexion = New DevExpress.XtraEditors.ImageComboBoxEdit
        Me.lblConexion = New DevExpress.XtraEditors.LabelControl
        Me.popTreeViewCategorias = New DevExpress.XtraEditors.PopupContainerControl
        Me.tvMain = New System.Windows.Forms.TreeView
        Me.il16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.cboCategoria = New DevExpress.XtraEditors.PopupContainerEdit
        Me.lblCategoria = New DevExpress.XtraEditors.LabelControl
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit
        Me.lblDescripcion = New DevExpress.XtraEditors.LabelControl
        Me.txtNombreConsulta = New DevExpress.XtraEditors.TextEdit
        Me.chkServerMode = New DevExpress.XtraEditors.CheckEdit
        Me.lblNombreConsulta = New DevExpress.XtraEditors.LabelControl
        Me.tpSQL = New DevExpress.XtraTab.XtraTabPage
        Me.spInicialFinal = New DevExpress.XtraEditors.SplitContainerControl
        Me.txtSQLInicial = New ActiproSoftware.SyntaxEditor.SyntaxEditor
        Me.txtSQLFinal = New ActiproSoftware.SyntaxEditor.SyntaxEditor
        Me.spPrevioPosterior = New DevExpress.XtraEditors.SplitContainerControl
        Me.txtSQLPrevio = New ActiproSoftware.SyntaxEditor.SyntaxEditor
        Me.txtSQLPosterior = New ActiproSoftware.SyntaxEditor.SyntaxEditor
        Me.tpParametros = New DevExpress.XtraTab.XtraTabPage
        Me.GridParametros = New DevExpress.XtraGrid.GridControl
        Me.gvwParametros = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tpFormatos = New DevExpress.XtraTab.XtraTabPage
        Me.GridFormatos = New DevExpress.XtraGrid.GridControl
        Me.gwvFormatos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tpResultados = New DevExpress.XtraTab.XtraTabPage
        Me.GridResultados = New DevExpress.XtraGrid.GridControl
        Me.gvwResultados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtPasswordDiseno = New DevExpress.XtraEditors.TextEdit
        Me.chkPasswordDiseno = New DevExpress.XtraEditors.CheckEdit
        CType(Me.dxBars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        CType(Me.grpOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpciones.SuspendLayout()
        CType(Me.txtFormatoFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popInicialFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popPrevioPosterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLiteralFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLiteralCadenas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSimboloDecimal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOpcionesDefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEjecucionAsincrona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNativoSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPasswordProtected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConexion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popTreeViewCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popTreeViewCategorias.SuspendLayout()
        CType(Me.cboCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreConsulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkServerMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSQL.SuspendLayout()
        CType(Me.spInicialFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spInicialFinal.SuspendLayout()
        CType(Me.spPrevioPosterior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spPrevioPosterior.SuspendLayout()
        Me.tpParametros.SuspendLayout()
        CType(Me.GridParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFormatos.SuspendLayout()
        CType(Me.GridFormatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gwvFormatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpResultados.SuspendLayout()
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPasswordDiseno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPasswordDiseno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dslSQL
        '
        Me.dslSQL.DefinitionXml = resources.GetString("dslSQL.DefinitionXml")
        '
        'dxBars
        '
        Me.dxBars.DockControls.Add(Me.barDockControlTop)
        Me.dxBars.DockControls.Add(Me.barDockControlBottom)
        Me.dxBars.DockControls.Add(Me.barDockControlLeft)
        Me.dxBars.DockControls.Add(Me.barDockControlRight)
        Me.dxBars.Form = Me
        Me.dxBars.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSQLInicial, Me.btnSQLFinal, Me.btnSQLPrevio, Me.btnSQLPosterior, Me.mnuDeshacer, Me.mnuRehacer, Me.mnuCopiar, Me.mnuCortar, Me.mnuPegar, Me.mnuEliminar, Me.mnuSeleccionarTodo, Me.mnuBuscar, Me.mnuReemplazar, Me.mnuInsertarVariable})
        Me.dxBars.MaxItemId = 16
        '
        'btnSQLInicial
        '
        Me.btnSQLInicial.Caption = "Instrucción SQL inicial"
        Me.btnSQLInicial.Id = 2
        Me.btnSQLInicial.Name = "btnSQLInicial"
        '
        'btnSQLFinal
        '
        Me.btnSQLFinal.Caption = "Instrucción SQL final"
        Me.btnSQLFinal.Id = 3
        Me.btnSQLFinal.Name = "btnSQLFinal"
        '
        'btnSQLPrevio
        '
        Me.btnSQLPrevio.Caption = "Instrucción SQL previa a la consulta"
        Me.btnSQLPrevio.Id = 4
        Me.btnSQLPrevio.Name = "btnSQLPrevio"
        '
        'btnSQLPosterior
        '
        Me.btnSQLPosterior.Caption = "Instrucción SQL posterior a la consulta"
        Me.btnSQLPosterior.Id = 5
        Me.btnSQLPosterior.Name = "btnSQLPosterior"
        '
        'mnuDeshacer
        '
        Me.mnuDeshacer.Caption = "Deshacer"
        Me.mnuDeshacer.Id = 6
        Me.mnuDeshacer.Name = "mnuDeshacer"
        '
        'mnuRehacer
        '
        Me.mnuRehacer.Caption = "Rehacer"
        Me.mnuRehacer.Id = 7
        Me.mnuRehacer.Name = "mnuRehacer"
        '
        'mnuCopiar
        '
        Me.mnuCopiar.Caption = "Copiar"
        Me.mnuCopiar.Id = 8
        Me.mnuCopiar.Name = "mnuCopiar"
        '
        'mnuCortar
        '
        Me.mnuCortar.Caption = "Cortar"
        Me.mnuCortar.Id = 9
        Me.mnuCortar.Name = "mnuCortar"
        '
        'mnuPegar
        '
        Me.mnuPegar.Caption = "Pegar"
        Me.mnuPegar.Id = 10
        Me.mnuPegar.Name = "mnuPegar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Caption = "Eliminar"
        Me.mnuEliminar.Id = 11
        Me.mnuEliminar.Name = "mnuEliminar"
        '
        'mnuSeleccionarTodo
        '
        Me.mnuSeleccionarTodo.Caption = "Seleccionar todo"
        Me.mnuSeleccionarTodo.Id = 12
        Me.mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        '
        'mnuBuscar
        '
        Me.mnuBuscar.Caption = "Buscar"
        Me.mnuBuscar.Id = 13
        Me.mnuBuscar.Name = "mnuBuscar"
        '
        'mnuReemplazar
        '
        Me.mnuReemplazar.Caption = "Reemplazar"
        Me.mnuReemplazar.Id = 14
        Me.mnuReemplazar.Name = "mnuReemplazar"
        '
        'mnuInsertarVariable
        '
        Me.mnuInsertarVariable.Caption = "Insertar variable"
        Me.mnuInsertarVariable.Id = 15
        Me.mnuInsertarVariable.Name = "mnuInsertarVariable"
        '
        'popMenu
        '
        Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDeshacer), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuRehacer), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuCopiar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuCortar), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuPegar), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuEliminar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuSeleccionarTodo), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuBuscar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuReemplazar), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuInsertarVariable, True)})
        Me.popMenu.Manager = Me.dxBars
        Me.popMenu.Name = "popMenu"
        '
        'Tabs
        '
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.Tabs.Location = New System.Drawing.Point(0, 95)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedTabPage = Me.tpGeneral
        Me.Tabs.Size = New System.Drawing.Size(744, 432)
        Me.Tabs.TabIndex = 5
        Me.Tabs.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpGeneral, Me.tpSQL, Me.tpParametros, Me.tpFormatos, Me.tpResultados})
        '
        'tpGeneral
        '
        Me.tpGeneral.AutoScroll = True
        Me.tpGeneral.Controls.Add(Me.txtPasswordDiseno)
        Me.tpGeneral.Controls.Add(Me.chkPasswordDiseno)
        Me.tpGeneral.Controls.Add(Me.grpOpciones)
        Me.tpGeneral.Controls.Add(Me.txtPassword)
        Me.tpGeneral.Controls.Add(Me.chkPasswordProtected)
        Me.tpGeneral.Controls.Add(Me.cboConexion)
        Me.tpGeneral.Controls.Add(Me.lblConexion)
        Me.tpGeneral.Controls.Add(Me.popTreeViewCategorias)
        Me.tpGeneral.Controls.Add(Me.cboCategoria)
        Me.tpGeneral.Controls.Add(Me.lblCategoria)
        Me.tpGeneral.Controls.Add(Me.txtDescripcion)
        Me.tpGeneral.Controls.Add(Me.lblDescripcion)
        Me.tpGeneral.Controls.Add(Me.txtNombreConsulta)
        Me.tpGeneral.Controls.Add(Me.chkServerMode)
        Me.tpGeneral.Controls.Add(Me.lblNombreConsulta)
        Me.tpGeneral.Image = CType(resources.GetObject("tpGeneral.Image"), System.Drawing.Image)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Size = New System.Drawing.Size(735, 399)
        Me.tpGeneral.Text = "General"
        '
        'grpOpciones
        '
        Me.grpOpciones.Controls.Add(Me.txtFormatoFechas)
        Me.grpOpciones.Controls.Add(Me.lblFormatoFechas)
        Me.grpOpciones.Controls.Add(Me.txtLiteralFechas)
        Me.grpOpciones.Controls.Add(Me.lblLiteralFechas)
        Me.grpOpciones.Controls.Add(Me.txtLiteralCadenas)
        Me.grpOpciones.Controls.Add(Me.lblLiteralCadenas)
        Me.grpOpciones.Controls.Add(Me.txtSimboloDecimal)
        Me.grpOpciones.Controls.Add(Me.lblSimboloDecimal)
        Me.grpOpciones.Controls.Add(Me.chkOpcionesDefault)
        Me.grpOpciones.Controls.Add(Me.chkEjecucionAsincrona)
        Me.grpOpciones.Controls.Add(Me.chkNativoSQL)
        Me.grpOpciones.Location = New System.Drawing.Point(9, 216)
        Me.grpOpciones.Name = "grpOpciones"
        Me.grpOpciones.Size = New System.Drawing.Size(534, 154)
        Me.grpOpciones.TabIndex = 15
        Me.grpOpciones.Text = "Opciones de la conexión"
        Me.grpOpciones.Visible = False
        '
        'txtFormatoFechas
        '
        Me.txtFormatoFechas.Enabled = False
        Me.txtFormatoFechas.Location = New System.Drawing.Point(423, 124)
        Me.txtFormatoFechas.MenuManager = Me.rbcMain
        Me.txtFormatoFechas.Name = "txtFormatoFechas"
        Me.txtFormatoFechas.Size = New System.Drawing.Size(89, 20)
        Me.txtFormatoFechas.TabIndex = 26
        '
        'rbcMain
        '
        Me.rbcMain.ApplicationButtonKeyTip = ""
        Me.rbcMain.ApplicationIcon = Nothing
        Me.rbcMain.AutoSizeItems = True
        Me.rbcMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnGuardar, Me.btnCerrar, Me.btnSQLInicialFinal, Me.btnSQLPrevioPosterior, Me.btnAsistenteSQL, Me.btnAgregarParametro, Me.btnModificarParametro, Me.btnEliminarParametro, Me.btnAgregarFormato, Me.btnEliminarFormato, Me.btnAgregarResultados, Me.btnEliminarResultados, Me.btnModoSplitter})
        Me.rbcMain.Location = New System.Drawing.Point(0, 0)
        Me.rbcMain.MaxItemId = 19
        Me.rbcMain.Name = "rbcMain"
        Me.rbcMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpOpciones})
        Me.rbcMain.SelectedPage = Me.rpOpciones
        Me.rbcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.rbcMain.Size = New System.Drawing.Size(744, 95)
        Me.rbcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Glyph = CType(resources.GetObject("btnGuardar.Glyph"), System.Drawing.Image)
        Me.btnGuardar.Id = 1
        Me.btnGuardar.LargeGlyph = CType(resources.GetObject("btnGuardar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 2
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnSQLInicialFinal
        '
        Me.btnSQLInicialFinal.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btnSQLInicialFinal.Caption = "Instrucciones SQL"
        Me.btnSQLInicialFinal.DropDownControl = Me.popInicialFinal
        Me.btnSQLInicialFinal.Glyph = CType(resources.GetObject("btnSQLInicialFinal.Glyph"), System.Drawing.Image)
        Me.btnSQLInicialFinal.Id = 4
        Me.btnSQLInicialFinal.LargeGlyph = CType(resources.GetObject("btnSQLInicialFinal.LargeGlyph"), System.Drawing.Image)
        Me.btnSQLInicialFinal.Name = "btnSQLInicialFinal"
        '
        'popInicialFinal
        '
        Me.popInicialFinal.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSQLInicial), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSQLFinal)})
        Me.popInicialFinal.Manager = Me.dxBars
        Me.popInicialFinal.Name = "popInicialFinal"
        '
        'btnSQLPrevioPosterior
        '
        Me.btnSQLPrevioPosterior.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btnSQLPrevioPosterior.Caption = "Previo y posterior a la consulta"
        Me.btnSQLPrevioPosterior.DropDownControl = Me.popPrevioPosterior
        Me.btnSQLPrevioPosterior.Glyph = CType(resources.GetObject("btnSQLPrevioPosterior.Glyph"), System.Drawing.Image)
        Me.btnSQLPrevioPosterior.Id = 6
        Me.btnSQLPrevioPosterior.LargeGlyph = CType(resources.GetObject("btnSQLPrevioPosterior.LargeGlyph"), System.Drawing.Image)
        Me.btnSQLPrevioPosterior.Name = "btnSQLPrevioPosterior"
        '
        'popPrevioPosterior
        '
        Me.popPrevioPosterior.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSQLPrevio), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSQLPosterior)})
        Me.popPrevioPosterior.Manager = Me.dxBars
        Me.popPrevioPosterior.Name = "popPrevioPosterior"
        '
        'btnAsistenteSQL
        '
        Me.btnAsistenteSQL.Caption = "Asistente SQL"
        Me.btnAsistenteSQL.Glyph = CType(resources.GetObject("btnAsistenteSQL.Glyph"), System.Drawing.Image)
        Me.btnAsistenteSQL.Id = 8
        Me.btnAsistenteSQL.LargeGlyph = CType(resources.GetObject("btnAsistenteSQL.LargeGlyph"), System.Drawing.Image)
        Me.btnAsistenteSQL.Name = "btnAsistenteSQL"
        '
        'btnAgregarParametro
        '
        Me.btnAgregarParametro.Caption = "Agregar"
        Me.btnAgregarParametro.Id = 9
        Me.btnAgregarParametro.LargeGlyph = CType(resources.GetObject("btnAgregarParametro.LargeGlyph"), System.Drawing.Image)
        Me.btnAgregarParametro.Name = "btnAgregarParametro"
        '
        'btnModificarParametro
        '
        Me.btnModificarParametro.Caption = "Propiedades"
        Me.btnModificarParametro.Id = 10
        Me.btnModificarParametro.LargeGlyph = CType(resources.GetObject("btnModificarParametro.LargeGlyph"), System.Drawing.Image)
        Me.btnModificarParametro.Name = "btnModificarParametro"
        '
        'btnEliminarParametro
        '
        Me.btnEliminarParametro.Caption = "Eliminar"
        Me.btnEliminarParametro.Id = 11
        Me.btnEliminarParametro.LargeGlyph = CType(resources.GetObject("btnEliminarParametro.LargeGlyph"), System.Drawing.Image)
        Me.btnEliminarParametro.Name = "btnEliminarParametro"
        '
        'btnAgregarFormato
        '
        Me.btnAgregarFormato.Caption = "Agregar"
        Me.btnAgregarFormato.Id = 12
        Me.btnAgregarFormato.LargeGlyph = CType(resources.GetObject("btnAgregarFormato.LargeGlyph"), System.Drawing.Image)
        Me.btnAgregarFormato.Name = "btnAgregarFormato"
        '
        'btnEliminarFormato
        '
        Me.btnEliminarFormato.Caption = "Eliminar"
        Me.btnEliminarFormato.Id = 13
        Me.btnEliminarFormato.LargeGlyph = CType(resources.GetObject("btnEliminarFormato.LargeGlyph"), System.Drawing.Image)
        Me.btnEliminarFormato.Name = "btnEliminarFormato"
        '
        'btnAgregarResultados
        '
        Me.btnAgregarResultados.Caption = "Agregar"
        Me.btnAgregarResultados.Id = 16
        Me.btnAgregarResultados.LargeGlyph = CType(resources.GetObject("btnAgregarResultados.LargeGlyph"), System.Drawing.Image)
        Me.btnAgregarResultados.Name = "btnAgregarResultados"
        '
        'btnEliminarResultados
        '
        Me.btnEliminarResultados.Caption = "Eliminar"
        Me.btnEliminarResultados.Id = 17
        Me.btnEliminarResultados.LargeGlyph = CType(resources.GetObject("btnEliminarResultados.LargeGlyph"), System.Drawing.Image)
        Me.btnEliminarResultados.Name = "btnEliminarResultados"
        '
        'btnModoSplitter
        '
        Me.btnModoSplitter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnModoSplitter.Caption = "Vertical"
        Me.btnModoSplitter.Id = 18
        Me.btnModoSplitter.LargeGlyph = CType(resources.GetObject("btnModoSplitter.LargeGlyph"), System.Drawing.Image)
        Me.btnModoSplitter.Name = "btnModoSplitter"
        '
        'rpOpciones
        '
        Me.rpOpciones.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgComun, Me.rpgSQL, Me.rpgParametros, Me.rpgFormatos, Me.rpgResultados})
        Me.rpOpciones.KeyTip = ""
        Me.rpOpciones.Name = "rpOpciones"
        Me.rpOpciones.Text = "Opciones"
        '
        'rpgComun
        '
        Me.rpgComun.ItemLinks.Add(Me.btnGuardar)
        Me.rpgComun.ItemLinks.Add(Me.btnCerrar)
        Me.rpgComun.KeyTip = ""
        Me.rpgComun.Name = "rpgComun"
        Me.rpgComun.ShowCaptionButton = False
        Me.rpgComun.Text = "Común"
        '
        'rpgSQL
        '
        Me.rpgSQL.ItemLinks.Add(Me.btnSQLInicialFinal)
        Me.rpgSQL.ItemLinks.Add(Me.btnSQLPrevioPosterior)
        Me.rpgSQL.ItemLinks.Add(Me.btnModoSplitter)
        Me.rpgSQL.ItemLinks.Add(Me.btnAsistenteSQL, True)
        Me.rpgSQL.KeyTip = ""
        Me.rpgSQL.Name = "rpgSQL"
        Me.rpgSQL.ShowCaptionButton = False
        Me.rpgSQL.Text = "SQL"
        '
        'rpgParametros
        '
        Me.rpgParametros.ItemLinks.Add(Me.btnAgregarParametro)
        Me.rpgParametros.ItemLinks.Add(Me.btnModificarParametro)
        Me.rpgParametros.ItemLinks.Add(Me.btnEliminarParametro)
        Me.rpgParametros.KeyTip = ""
        Me.rpgParametros.Name = "rpgParametros"
        Me.rpgParametros.ShowCaptionButton = False
        Me.rpgParametros.Text = "Parámetros"
        '
        'rpgFormatos
        '
        Me.rpgFormatos.ItemLinks.Add(Me.btnAgregarFormato)
        Me.rpgFormatos.ItemLinks.Add(Me.btnEliminarFormato)
        Me.rpgFormatos.KeyTip = ""
        Me.rpgFormatos.Name = "rpgFormatos"
        Me.rpgFormatos.ShowCaptionButton = False
        Me.rpgFormatos.Text = "Formatos"
        '
        'rpgResultados
        '
        Me.rpgResultados.ItemLinks.Add(Me.btnAgregarResultados)
        Me.rpgResultados.ItemLinks.Add(Me.btnEliminarResultados)
        Me.rpgResultados.KeyTip = ""
        Me.rpgResultados.Name = "rpgResultados"
        Me.rpgResultados.ShowCaptionButton = False
        Me.rpgResultados.Text = "Resultados"
        '
        'lblFormatoFechas
        '
        Me.lblFormatoFechas.Enabled = False
        Me.lblFormatoFechas.Location = New System.Drawing.Point(323, 127)
        Me.lblFormatoFechas.Name = "lblFormatoFechas"
        Me.lblFormatoFechas.Size = New System.Drawing.Size(94, 13)
        Me.lblFormatoFechas.TabIndex = 25
        Me.lblFormatoFechas.Text = "Formato de fechas:"
        '
        'txtLiteralFechas
        '
        Me.txtLiteralFechas.Enabled = False
        Me.txtLiteralFechas.Location = New System.Drawing.Point(454, 98)
        Me.txtLiteralFechas.MenuManager = Me.rbcMain
        Me.txtLiteralFechas.Name = "txtLiteralFechas"
        Me.txtLiteralFechas.Size = New System.Drawing.Size(58, 20)
        Me.txtLiteralFechas.TabIndex = 24
        '
        'lblLiteralFechas
        '
        Me.lblLiteralFechas.Enabled = False
        Me.lblLiteralFechas.Location = New System.Drawing.Point(323, 101)
        Me.lblLiteralFechas.Name = "lblLiteralFechas"
        Me.lblLiteralFechas.Size = New System.Drawing.Size(83, 13)
        Me.lblLiteralFechas.TabIndex = 23
        Me.lblLiteralFechas.Text = "Literal de fechas:"
        '
        'txtLiteralCadenas
        '
        Me.txtLiteralCadenas.Enabled = False
        Me.txtLiteralCadenas.Location = New System.Drawing.Point(454, 72)
        Me.txtLiteralCadenas.MenuManager = Me.rbcMain
        Me.txtLiteralCadenas.Name = "txtLiteralCadenas"
        Me.txtLiteralCadenas.Size = New System.Drawing.Size(58, 20)
        Me.txtLiteralCadenas.TabIndex = 22
        '
        'lblLiteralCadenas
        '
        Me.lblLiteralCadenas.Enabled = False
        Me.lblLiteralCadenas.Location = New System.Drawing.Point(323, 75)
        Me.lblLiteralCadenas.Name = "lblLiteralCadenas"
        Me.lblLiteralCadenas.Size = New System.Drawing.Size(91, 13)
        Me.lblLiteralCadenas.TabIndex = 21
        Me.lblLiteralCadenas.Text = "Literal de cadenas:"
        '
        'txtSimboloDecimal
        '
        Me.txtSimboloDecimal.Enabled = False
        Me.txtSimboloDecimal.Location = New System.Drawing.Point(454, 48)
        Me.txtSimboloDecimal.MenuManager = Me.rbcMain
        Me.txtSimboloDecimal.Name = "txtSimboloDecimal"
        Me.txtSimboloDecimal.Size = New System.Drawing.Size(58, 20)
        Me.txtSimboloDecimal.TabIndex = 20
        '
        'lblSimboloDecimal
        '
        Me.lblSimboloDecimal.Enabled = False
        Me.lblSimboloDecimal.Location = New System.Drawing.Point(323, 51)
        Me.lblSimboloDecimal.Name = "lblSimboloDecimal"
        Me.lblSimboloDecimal.Size = New System.Drawing.Size(78, 13)
        Me.lblSimboloDecimal.TabIndex = 19
        Me.lblSimboloDecimal.Text = "Símbolo decimal:"
        '
        'chkOpcionesDefault
        '
        Me.chkOpcionesDefault.EditValue = True
        Me.chkOpcionesDefault.Location = New System.Drawing.Point(301, 23)
        Me.chkOpcionesDefault.Name = "chkOpcionesDefault"
        Me.chkOpcionesDefault.Properties.Caption = "Utilizar opciones predeterminadas"
        Me.chkOpcionesDefault.Size = New System.Drawing.Size(211, 19)
        Me.chkOpcionesDefault.TabIndex = 18
        '
        'chkEjecucionAsincrona
        '
        Me.chkEjecucionAsincrona.Enabled = False
        Me.chkEjecucionAsincrona.Location = New System.Drawing.Point(21, 73)
        Me.chkEjecucionAsincrona.Name = "chkEjecucionAsincrona"
        Me.chkEjecucionAsincrona.Properties.Caption = "Permitir ejecución asíncrona"
        Me.chkEjecucionAsincrona.Size = New System.Drawing.Size(184, 19)
        Me.chkEjecucionAsincrona.TabIndex = 17
        '
        'chkNativoSQL
        '
        Me.chkNativoSQL.Location = New System.Drawing.Point(5, 48)
        Me.chkNativoSQL.Name = "chkNativoSQL"
        Me.chkNativoSQL.Properties.Caption = "Conexión nativa a SQL Server"
        Me.chkNativoSQL.Size = New System.Drawing.Size(184, 19)
        Me.chkNativoSQL.TabIndex = 16
        '
        'txtPassword
        '
        Me.txtPassword.EditValue = ""
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(175, 161)
        Me.txtPassword.MenuManager = Me.rbcMain
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(183, 20)
        Me.txtPassword.TabIndex = 11
        '
        'chkPasswordProtected
        '
        Me.chkPasswordProtected.Location = New System.Drawing.Point(7, 162)
        Me.chkPasswordProtected.Name = "chkPasswordProtected"
        Me.chkPasswordProtected.Properties.Caption = "Contraseña de ejecución:"
        Me.chkPasswordProtected.Size = New System.Drawing.Size(162, 19)
        Me.chkPasswordProtected.TabIndex = 10
        '
        'cboConexion
        '
        Me.cboConexion.Location = New System.Drawing.Point(175, 135)
        Me.cboConexion.Name = "cboConexion"
        Me.cboConexion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConexion.Size = New System.Drawing.Size(266, 20)
        Me.cboConexion.TabIndex = 9
        '
        'lblConexion
        '
        Me.lblConexion.Location = New System.Drawing.Point(9, 138)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(49, 13)
        Me.lblConexion.TabIndex = 8
        Me.lblConexion.Text = "Conexión:"
        '
        'popTreeViewCategorias
        '
        Me.popTreeViewCategorias.Controls.Add(Me.tvMain)
        Me.popTreeViewCategorias.Location = New System.Drawing.Point(569, 112)
        Me.popTreeViewCategorias.Name = "popTreeViewCategorias"
        Me.popTreeViewCategorias.Size = New System.Drawing.Size(266, 232)
        Me.popTreeViewCategorias.TabIndex = 7
        '
        'tvMain
        '
        Me.tvMain.AllowDrop = True
        Me.tvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvMain.HideSelection = False
        Me.tvMain.ImageIndex = 0
        Me.tvMain.ImageList = Me.il16x16
        Me.tvMain.Location = New System.Drawing.Point(0, 0)
        Me.tvMain.Name = "tvMain"
        TreeNode2.Checked = True
        TreeNode2.ImageIndex = 0
        TreeNode2.Name = "nodRaiz"
        TreeNode2.Text = "Consultas almacenadas"
        Me.tvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.tvMain.SelectedImageIndex = 0
        Me.tvMain.ShowNodeToolTips = True
        Me.tvMain.Size = New System.Drawing.Size(266, 232)
        Me.tvMain.TabIndex = 7
        '
        'il16x16
        '
        Me.il16x16.ImageStream = CType(resources.GetObject("il16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.il16x16.Images.SetKeyName(0, "Resultados.png")
        Me.il16x16.Images.SetKeyName(1, "CarpetaAbierta.png")
        Me.il16x16.Images.SetKeyName(2, "CarpetaCerrada.png")
        Me.il16x16.Images.SetKeyName(3, "Database.png")
        Me.il16x16.Images.SetKeyName(4, "Tabla")
        Me.il16x16.Images.SetKeyName(5, "Vista")
        Me.il16x16.Images.SetKeyName(6, "Columna")
        Me.il16x16.Images.SetKeyName(7, "Procedimiento")
        Me.il16x16.Images.SetKeyName(8, "PalabraRes")
        Me.il16x16.Images.SetKeyName(9, "FuncionX")
        Me.il16x16.Images.SetKeyName(10, "Patron")
        Me.il16x16.Images.SetKeyName(11, "TipoDatos")
        '
        'cboCategoria
        '
        Me.cboCategoria.Location = New System.Drawing.Point(175, 109)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategoria.Properties.PopupControl = Me.popTreeViewCategorias
        Me.cboCategoria.Size = New System.Drawing.Size(266, 20)
        Me.cboCategoria.TabIndex = 5
        '
        'lblCategoria
        '
        Me.lblCategoria.Location = New System.Drawing.Point(9, 112)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(51, 13)
        Me.lblCategoria.TabIndex = 4
        Me.lblCategoria.Text = "Categoría:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(175, 32)
        Me.txtDescripcion.MenuManager = Me.rbcMain
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(368, 71)
        Me.txtDescripcion.TabIndex = 3
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(9, 34)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(58, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtNombreConsulta
        '
        Me.txtNombreConsulta.Location = New System.Drawing.Point(175, 6)
        Me.txtNombreConsulta.MenuManager = Me.rbcMain
        Me.txtNombreConsulta.Name = "txtNombreConsulta"
        Me.txtNombreConsulta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreConsulta.Properties.Appearance.Options.UseFont = True
        Me.txtNombreConsulta.Size = New System.Drawing.Size(235, 20)
        Me.txtNombreConsulta.TabIndex = 1
        '
        'chkServerMode
        '
        Me.chkServerMode.EditValue = True
        Me.chkServerMode.Location = New System.Drawing.Point(381, 163)
        Me.chkServerMode.Name = "chkServerMode"
        Me.chkServerMode.Properties.Caption = "Modo servidor"
        Me.chkServerMode.Size = New System.Drawing.Size(162, 19)
        Me.chkServerMode.TabIndex = 15
        '
        'lblNombreConsulta
        '
        Me.lblNombreConsulta.Location = New System.Drawing.Point(9, 9)
        Me.lblNombreConsulta.Name = "lblNombreConsulta"
        Me.lblNombreConsulta.Size = New System.Drawing.Size(41, 13)
        Me.lblNombreConsulta.TabIndex = 0
        Me.lblNombreConsulta.Text = "Nombre:"
        '
        'tpSQL
        '
        Me.tpSQL.Controls.Add(Me.spInicialFinal)
        Me.tpSQL.Controls.Add(Me.spPrevioPosterior)
        Me.tpSQL.Image = CType(resources.GetObject("tpSQL.Image"), System.Drawing.Image)
        Me.tpSQL.Name = "tpSQL"
        Me.tpSQL.Size = New System.Drawing.Size(735, 364)
        Me.tpSQL.Text = "SQL"
        '
        'spInicialFinal
        '
        Me.spInicialFinal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.spInicialFinal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spInicialFinal.Horizontal = False
        Me.spInicialFinal.Location = New System.Drawing.Point(0, 0)
        Me.spInicialFinal.Name = "spInicialFinal"
        Me.spInicialFinal.Panel1.Controls.Add(Me.txtSQLInicial)
        Me.spInicialFinal.Panel1.ShowCaption = True
        Me.spInicialFinal.Panel1.Text = "Instruccion SQL inicial"
        Me.spInicialFinal.Panel2.Controls.Add(Me.txtSQLFinal)
        Me.spInicialFinal.Panel2.ShowCaption = True
        Me.spInicialFinal.Panel2.Text = "Instruccion SQL final"
        Me.spInicialFinal.ShowCaption = True
        Me.spInicialFinal.Size = New System.Drawing.Size(735, 364)
        Me.spInicialFinal.SplitterPosition = 163
        Me.spInicialFinal.TabIndex = 2
        Me.spInicialFinal.Text = "Instrucciones SQL"
        '
        'txtSQLInicial
        '
        Me.txtSQLInicial.DefaultContextMenuEnabled = False
        Me.txtSQLInicial.Dock = System.Windows.Forms.DockStyle.Fill
        Document5.Language = Me.dslSQL
        Me.txtSQLInicial.Document = Document5
        Me.txtSQLInicial.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLInicial.Location = New System.Drawing.Point(0, 0)
        Me.txtSQLInicial.Name = "txtSQLInicial"
        VisualStudio2005SyntaxEditorRenderer5.ResetAllPropertiesOnSystemColorChange = False
        Me.txtSQLInicial.Renderer = VisualStudio2005SyntaxEditorRenderer5
        Me.txtSQLInicial.Size = New System.Drawing.Size(731, 141)
        Me.txtSQLInicial.TabIndex = 2
        '
        'txtSQLFinal
        '
        Me.txtSQLFinal.DefaultContextMenuEnabled = False
        Me.txtSQLFinal.Dock = System.Windows.Forms.DockStyle.Fill
        Document6.Language = Me.dslSQL
        Me.txtSQLFinal.Document = Document6
        Me.txtSQLFinal.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLFinal.Location = New System.Drawing.Point(0, 0)
        Me.txtSQLFinal.Name = "txtSQLFinal"
        VisualStudio2005SyntaxEditorRenderer6.ResetAllPropertiesOnSystemColorChange = False
        Me.txtSQLFinal.Renderer = VisualStudio2005SyntaxEditorRenderer6
        Me.txtSQLFinal.Size = New System.Drawing.Size(731, 173)
        Me.txtSQLFinal.TabIndex = 3
        '
        'spPrevioPosterior
        '
        Me.spPrevioPosterior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.spPrevioPosterior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spPrevioPosterior.Horizontal = False
        Me.spPrevioPosterior.Location = New System.Drawing.Point(0, 0)
        Me.spPrevioPosterior.Name = "spPrevioPosterior"
        Me.spPrevioPosterior.Panel1.Controls.Add(Me.txtSQLPrevio)
        Me.spPrevioPosterior.Panel1.ShowCaption = True
        Me.spPrevioPosterior.Panel1.Text = "Instruccion SQL inicial"
        Me.spPrevioPosterior.Panel2.Controls.Add(Me.txtSQLPosterior)
        Me.spPrevioPosterior.Panel2.ShowCaption = True
        Me.spPrevioPosterior.Panel2.Text = "Instruccion SQL final"
        Me.spPrevioPosterior.ShowCaption = True
        Me.spPrevioPosterior.Size = New System.Drawing.Size(735, 364)
        Me.spPrevioPosterior.SplitterPosition = 199
        Me.spPrevioPosterior.TabIndex = 3
        Me.spPrevioPosterior.Text = "Instrucciones SQL"
        Me.spPrevioPosterior.Visible = False
        '
        'txtSQLPrevio
        '
        Me.txtSQLPrevio.DefaultContextMenuEnabled = False
        Me.txtSQLPrevio.Dock = System.Windows.Forms.DockStyle.Fill
        Document7.Language = Me.dslSQL
        Me.txtSQLPrevio.Document = Document7
        Me.txtSQLPrevio.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLPrevio.Location = New System.Drawing.Point(0, 0)
        Me.txtSQLPrevio.Name = "txtSQLPrevio"
        VisualStudio2005SyntaxEditorRenderer7.ResetAllPropertiesOnSystemColorChange = False
        Me.txtSQLPrevio.Renderer = VisualStudio2005SyntaxEditorRenderer7
        Me.txtSQLPrevio.Size = New System.Drawing.Size(731, 177)
        Me.txtSQLPrevio.TabIndex = 2
        '
        'txtSQLPosterior
        '
        Me.txtSQLPosterior.DefaultContextMenuEnabled = False
        Me.txtSQLPosterior.Dock = System.Windows.Forms.DockStyle.Fill
        Document8.Language = Me.dslSQL
        Me.txtSQLPosterior.Document = Document8
        Me.txtSQLPosterior.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLPosterior.Location = New System.Drawing.Point(0, 0)
        Me.txtSQLPosterior.Name = "txtSQLPosterior"
        VisualStudio2005SyntaxEditorRenderer8.ResetAllPropertiesOnSystemColorChange = False
        Me.txtSQLPosterior.Renderer = VisualStudio2005SyntaxEditorRenderer8
        Me.txtSQLPosterior.Size = New System.Drawing.Size(731, 137)
        Me.txtSQLPosterior.TabIndex = 3
        '
        'tpParametros
        '
        Me.tpParametros.Controls.Add(Me.GridParametros)
        Me.tpParametros.Image = CType(resources.GetObject("tpParametros.Image"), System.Drawing.Image)
        Me.tpParametros.Name = "tpParametros"
        Me.tpParametros.Size = New System.Drawing.Size(735, 364)
        Me.tpParametros.Text = "Parametros"
        '
        'GridParametros
        '
        Me.GridParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridParametros.EmbeddedNavigator.Name = ""
        Me.GridParametros.Location = New System.Drawing.Point(0, 0)
        Me.GridParametros.MainView = Me.gvwParametros
        Me.GridParametros.Name = "GridParametros"
        Me.GridParametros.Size = New System.Drawing.Size(735, 364)
        Me.GridParametros.TabIndex = 0
        Me.GridParametros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwParametros})
        '
        'gvwParametros
        '
        Me.gvwParametros.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvwParametros.GridControl = Me.GridParametros
        Me.gvwParametros.Name = "gvwParametros"
        Me.gvwParametros.OptionsBehavior.Editable = False
        Me.gvwParametros.OptionsCustomization.AllowColumnMoving = False
        Me.gvwParametros.OptionsCustomization.AllowFilter = False
        Me.gvwParametros.OptionsCustomization.AllowGroup = False
        Me.gvwParametros.OptionsMenu.EnableColumnMenu = False
        Me.gvwParametros.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvwParametros.OptionsView.ColumnAutoWidth = False
        Me.gvwParametros.OptionsView.ShowGroupPanel = False
        Me.gvwParametros.OptionsView.ShowIndicator = False
        '
        'tpFormatos
        '
        Me.tpFormatos.Controls.Add(Me.GridFormatos)
        Me.tpFormatos.Image = CType(resources.GetObject("tpFormatos.Image"), System.Drawing.Image)
        Me.tpFormatos.Name = "tpFormatos"
        Me.tpFormatos.Size = New System.Drawing.Size(735, 364)
        Me.tpFormatos.Text = "Formatos"
        '
        'GridFormatos
        '
        Me.GridFormatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFormatos.EmbeddedNavigator.Name = ""
        Me.GridFormatos.Location = New System.Drawing.Point(0, 0)
        Me.GridFormatos.MainView = Me.gwvFormatos
        Me.GridFormatos.Name = "GridFormatos"
        Me.GridFormatos.Size = New System.Drawing.Size(735, 364)
        Me.GridFormatos.TabIndex = 1
        Me.GridFormatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gwvFormatos})
        '
        'gwvFormatos
        '
        Me.gwvFormatos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gwvFormatos.GridControl = Me.GridFormatos
        Me.gwvFormatos.Name = "gwvFormatos"
        Me.gwvFormatos.OptionsBehavior.Editable = False
        Me.gwvFormatos.OptionsCustomization.AllowColumnMoving = False
        Me.gwvFormatos.OptionsCustomization.AllowFilter = False
        Me.gwvFormatos.OptionsCustomization.AllowGroup = False
        Me.gwvFormatos.OptionsMenu.EnableColumnMenu = False
        Me.gwvFormatos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gwvFormatos.OptionsView.ColumnAutoWidth = False
        Me.gwvFormatos.OptionsView.ShowGroupPanel = False
        Me.gwvFormatos.OptionsView.ShowIndicator = False
        '
        'tpResultados
        '
        Me.tpResultados.Controls.Add(Me.GridResultados)
        Me.tpResultados.Image = CType(resources.GetObject("tpResultados.Image"), System.Drawing.Image)
        Me.tpResultados.Name = "tpResultados"
        Me.tpResultados.Size = New System.Drawing.Size(735, 364)
        Me.tpResultados.Text = "Resultados"
        '
        'GridResultados
        '
        Me.GridResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridResultados.EmbeddedNavigator.Name = ""
        Me.GridResultados.Location = New System.Drawing.Point(0, 0)
        Me.GridResultados.MainView = Me.gvwResultados
        Me.GridResultados.Name = "GridResultados"
        Me.GridResultados.Size = New System.Drawing.Size(735, 364)
        Me.GridResultados.TabIndex = 1
        Me.GridResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwResultados})
        '
        'gvwResultados
        '
        Me.gvwResultados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvwResultados.GridControl = Me.GridResultados
        Me.gvwResultados.Name = "gvwResultados"
        Me.gvwResultados.OptionsBehavior.Editable = False
        Me.gvwResultados.OptionsCustomization.AllowColumnMoving = False
        Me.gvwResultados.OptionsCustomization.AllowFilter = False
        Me.gvwResultados.OptionsCustomization.AllowGroup = False
        Me.gvwResultados.OptionsMenu.EnableColumnMenu = False
        Me.gvwResultados.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvwResultados.OptionsView.ColumnAutoWidth = False
        Me.gvwResultados.OptionsView.ShowGroupPanel = False
        Me.gvwResultados.OptionsView.ShowIndicator = False
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "imgDB")
        '
        'txtPasswordDiseno
        '
        Me.txtPasswordDiseno.EditValue = ""
        Me.txtPasswordDiseno.Enabled = False
        Me.txtPasswordDiseno.Location = New System.Drawing.Point(175, 187)
        Me.txtPasswordDiseno.MenuManager = Me.rbcMain
        Me.txtPasswordDiseno.Name = "txtPasswordDiseno"
        Me.txtPasswordDiseno.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordDiseno.Size = New System.Drawing.Size(183, 20)
        Me.txtPasswordDiseno.TabIndex = 17
        '
        'chkPasswordDiseno
        '
        Me.chkPasswordDiseno.Location = New System.Drawing.Point(7, 188)
        Me.chkPasswordDiseno.Name = "chkPasswordDiseno"
        Me.chkPasswordDiseno.Properties.Caption = "Contraseña de diseño:"
        Me.chkPasswordDiseno.Size = New System.Drawing.Size(162, 19)
        Me.chkPasswordDiseno.TabIndex = 16
        '
        'frmDisenoConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 527)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.rbcMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmDisenoConsulta"
        Me.Text = "Diseño de consulta"
        CType(Me.dxBars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        CType(Me.grpOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpciones.ResumeLayout(False)
        Me.grpOpciones.PerformLayout()
        CType(Me.txtFormatoFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popInicialFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popPrevioPosterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLiteralFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLiteralCadenas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSimboloDecimal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOpcionesDefault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEjecucionAsincrona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNativoSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPasswordProtected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConexion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popTreeViewCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popTreeViewCategorias.ResumeLayout(False)
        CType(Me.cboCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreConsulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkServerMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSQL.ResumeLayout(False)
        CType(Me.spInicialFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spInicialFinal.ResumeLayout(False)
        CType(Me.spPrevioPosterior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spPrevioPosterior.ResumeLayout(False)
        Me.tpParametros.ResumeLayout(False)
        CType(Me.GridParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFormatos.ResumeLayout(False)
        CType(Me.GridFormatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gwvFormatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpResultados.ResumeLayout(False)
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPasswordDiseno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPasswordDiseno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dxBars As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents popMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Tabs As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpGeneral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpSQL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpParametros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpFormatos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpResultados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreConsulta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombreConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCategoria As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents lblCategoria As DevExpress.XtraEditors.LabelControl
    Friend WithEvents il16x16 As System.Windows.Forms.ImageList
    Friend WithEvents popTreeViewCategorias As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents tvMain As System.Windows.Forms.TreeView
    Friend WithEvents cboConexion As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents lblConexion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkPasswordProtected As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbcMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rpOpciones As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgComun As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgSQL As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgParametros As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgFormatos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgResultados As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSQLInicialFinal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSQLPrevioPosterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAsistenteSQL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAgregarParametro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModificarParametro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminarParametro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAgregarFormato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminarFormato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents spInicialFinal As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtSQLInicial As ActiproSoftware.SyntaxEditor.SyntaxEditor
    Friend WithEvents txtSQLFinal As ActiproSoftware.SyntaxEditor.SyntaxEditor
    Friend WithEvents spPrevioPosterior As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtSQLPrevio As ActiproSoftware.SyntaxEditor.SyntaxEditor
    Friend WithEvents txtSQLPosterior As ActiproSoftware.SyntaxEditor.SyntaxEditor
    Friend WithEvents btnAgregarResultados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminarResultados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grpOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFormatoFechas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFormatoFechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLiteralFechas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLiteralFechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLiteralCadenas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLiteralCadenas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSimboloDecimal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSimboloDecimal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkOpcionesDefault As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEjecucionAsincrona As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNativoSQL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkServerMode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents GridParametros As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwParametros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridFormatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gwvFormatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSQLInicial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSQLFinal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSQLPrevio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSQLPosterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popInicialFinal As DevExpress.XtraBars.PopupMenu
    Friend WithEvents popPrevioPosterior As DevExpress.XtraBars.PopupMenu
    Friend WithEvents mnuDeshacer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuRehacer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuCopiar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuCortar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuPegar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuSeleccionarTodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuReemplazar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuInsertarVariable As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModoSplitter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dslSQL As ActiproSoftware.SyntaxEditor.Addons.Dynamic.DynamicSyntaxLanguage
    Friend WithEvents txtPasswordDiseno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkPasswordDiseno As DevExpress.XtraEditors.CheckEdit
End Class
