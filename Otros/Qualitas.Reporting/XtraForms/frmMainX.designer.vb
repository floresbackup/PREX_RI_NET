<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainX
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainX))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultas almacenadas")
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Consultas favoritas", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "00000"}, 0)
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.mnuConsulta = New DevExpress.XtraBars.BarButtonItem
        Me.popConsultas = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnCrearConsulta = New DevExpress.XtraBars.BarButtonItem
        Me.btnAbrirConsulta = New DevExpress.XtraBars.BarButtonItem
        Me.btnDisenarConsulta = New DevExpress.XtraBars.BarButtonItem
        Me.btnImportarConsulta = New DevExpress.XtraBars.BarButtonItem
        Me.btnExportarConsulta = New DevExpress.XtraBars.BarButtonItem
        Me.btnEliminarConsulta = New DevExpress.XtraBars.BarButtonItem
        Me.mnuConfiguracion = New DevExpress.XtraBars.BarButtonItem
        Me.popOpciones = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnPreferencias = New DevExpress.XtraBars.BarButtonItem
        Me.btnOpcionesGenerales = New DevExpress.XtraBars.BarButtonItem
        Me.mnuVer = New DevExpress.XtraBars.BarSubItem
        Me.btnVerPC = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerPF = New DevExpress.XtraBars.BarButtonItem
        Me.mnuVentanas = New DevExpress.XtraBars.BarSubItem
        Me.mnuVentana = New DevExpress.XtraBars.BarMdiChildrenListItem
        Me.btnCategorias = New DevExpress.XtraBars.BarButtonItem
        Me.btnAdministracionSeguridad = New DevExpress.XtraBars.BarButtonItem
        Me.btnConexiones = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalir = New DevExpress.XtraBars.BarButtonItem
        Me.il16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.stcStatus = New DevExpress.XtraBars.BarStaticItem
        Me.stcUsuario = New DevExpress.XtraBars.BarStaticItem
        Me.stcHora = New DevExpress.XtraBars.BarStaticItem
        Me.btnContenido = New DevExpress.XtraBars.BarButtonItem
        Me.btnAbout = New DevExpress.XtraBars.BarButtonItem
        Me.btnAbrirContext = New DevExpress.XtraBars.BarButtonItem
        Me.btnDisenarContext = New DevExpress.XtraBars.BarButtonItem
        Me.btnExportarContext = New DevExpress.XtraBars.BarButtonItem
        Me.btnAgregarFavoritasContext = New DevExpress.XtraBars.BarButtonItem
        Me.btnEliminarContext = New DevExpress.XtraBars.BarButtonItem
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.rpConsultas = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgConsultas = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgImportacion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgConfiguracion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgOtros = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgAyuda = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpOtros = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.popInicio = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.mdiTabs = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.dckManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.pnlConsultas = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.tvMain = New System.Windows.Forms.TreeView
        Me.pnlFavoritas = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.lvFavoritas = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        Me.tmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.oLAF = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.popContext = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mdiTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dckManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConsultas.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.pnlFavoritas.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.popContext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.RibbonControl.ApplicationButtonKeyTip = ""
        Me.RibbonControl.ApplicationIcon = CType(resources.GetObject("RibbonControl.ApplicationIcon"), System.Drawing.Bitmap)
        Me.RibbonControl.Images = Me.il16x16
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.stcStatus, Me.stcUsuario, Me.stcHora, Me.mnuConsulta, Me.mnuConfiguracion, Me.btnAdministracionSeguridad, Me.btnConexiones, Me.btnSalir, Me.btnCrearConsulta, Me.btnAbrirConsulta, Me.btnDisenarConsulta, Me.btnImportarConsulta, Me.btnExportarConsulta, Me.btnCategorias, Me.mnuVer, Me.btnVerPC, Me.btnVerPF, Me.btnPreferencias, Me.btnOpcionesGenerales, Me.btnContenido, Me.btnAbout, Me.btnAbrirContext, Me.btnDisenarContext, Me.btnExportarContext, Me.btnAgregarFavoritasContext, Me.mnuVentana, Me.mnuVentanas, Me.btnEliminarConsulta, Me.btnEliminarContext})
        Me.RibbonControl.LargeImages = Me.il32x32
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 34
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpConsultas, Me.rpOtros})
        Me.RibbonControl.SelectedPage = Me.rpConsultas
        Me.RibbonControl.Size = New System.Drawing.Size(792, 147)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'appMenu
        '
        Me.appMenu.BottomPaneControlContainer = Nothing
        Me.appMenu.ItemLinks.Add(Me.mnuConsulta)
        Me.appMenu.ItemLinks.Add(Me.mnuConfiguracion)
        Me.appMenu.ItemLinks.Add(Me.mnuVer)
        Me.appMenu.ItemLinks.Add(Me.btnCategorias, True)
        Me.appMenu.ItemLinks.Add(Me.btnAdministracionSeguridad)
        Me.appMenu.ItemLinks.Add(Me.btnConexiones)
        Me.appMenu.ItemLinks.Add(Me.btnSalir, True)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.RibbonControl
        Me.appMenu.RightPaneControlContainer = Nothing
        Me.appMenu.RightPaneWidth = 240
        Me.appMenu.ShowRightPane = True
        '
        'mnuConsulta
        '
        Me.mnuConsulta.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.mnuConsulta.Caption = "Consulta"
        Me.mnuConsulta.DropDownControl = Me.popConsultas
        Me.mnuConsulta.Glyph = CType(resources.GetObject("mnuConsulta.Glyph"), System.Drawing.Image)
        Me.mnuConsulta.Id = 7
        Me.mnuConsulta.LargeGlyph = CType(resources.GetObject("mnuConsulta.LargeGlyph"), System.Drawing.Image)
        Me.mnuConsulta.Name = "mnuConsulta"
        '
        'popConsultas
        '
        Me.popConsultas.ItemLinks.Add(Me.btnCrearConsulta)
        Me.popConsultas.ItemLinks.Add(Me.btnAbrirConsulta, True)
        Me.popConsultas.ItemLinks.Add(Me.btnDisenarConsulta)
        Me.popConsultas.ItemLinks.Add(Me.btnImportarConsulta, True)
        Me.popConsultas.ItemLinks.Add(Me.btnExportarConsulta)
        Me.popConsultas.ItemLinks.Add(Me.btnEliminarConsulta, True)
        Me.popConsultas.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesTextDescription
        Me.popConsultas.Name = "popConsultas"
        Me.popConsultas.Ribbon = Me.RibbonControl
        '
        'btnCrearConsulta
        '
        Me.btnCrearConsulta.Caption = "Nueva consulta"
        Me.btnCrearConsulta.Description = "Inicia el diseño de una nueva consulta"
        Me.btnCrearConsulta.Glyph = CType(resources.GetObject("btnCrearConsulta.Glyph"), System.Drawing.Image)
        Me.btnCrearConsulta.Id = 12
        Me.btnCrearConsulta.LargeGlyph = CType(resources.GetObject("btnCrearConsulta.LargeGlyph"), System.Drawing.Image)
        Me.btnCrearConsulta.Name = "btnCrearConsulta"
        '
        'btnAbrirConsulta
        '
        Me.btnAbrirConsulta.Caption = "Abrir"
        Me.btnAbrirConsulta.Description = "Permite seleccionar una consulta para su ejecución"
        Me.btnAbrirConsulta.Glyph = CType(resources.GetObject("btnAbrirConsulta.Glyph"), System.Drawing.Image)
        Me.btnAbrirConsulta.Id = 13
        Me.btnAbrirConsulta.LargeGlyph = CType(resources.GetObject("btnAbrirConsulta.LargeGlyph"), System.Drawing.Image)
        Me.btnAbrirConsulta.Name = "btnAbrirConsulta"
        '
        'btnDisenarConsulta
        '
        Me.btnDisenarConsulta.Caption = "Diseñar"
        Me.btnDisenarConsulta.Description = "Permite seleccionar una consulta para abrirla en modo diseño"
        Me.btnDisenarConsulta.Glyph = CType(resources.GetObject("btnDisenarConsulta.Glyph"), System.Drawing.Image)
        Me.btnDisenarConsulta.Id = 14
        Me.btnDisenarConsulta.LargeGlyph = CType(resources.GetObject("btnDisenarConsulta.LargeGlyph"), System.Drawing.Image)
        Me.btnDisenarConsulta.Name = "btnDisenarConsulta"
        '
        'btnImportarConsulta
        '
        Me.btnImportarConsulta.Caption = "Importar"
        Me.btnImportarConsulta.Description = "Importar una consulta desde un archivo en disco"
        Me.btnImportarConsulta.Glyph = CType(resources.GetObject("btnImportarConsulta.Glyph"), System.Drawing.Image)
        Me.btnImportarConsulta.Id = 15
        Me.btnImportarConsulta.LargeGlyph = CType(resources.GetObject("btnImportarConsulta.LargeGlyph"), System.Drawing.Image)
        Me.btnImportarConsulta.Name = "btnImportarConsulta"
        '
        'btnExportarConsulta
        '
        Me.btnExportarConsulta.Caption = "Exportar"
        Me.btnExportarConsulta.Description = "Exportar el diseño de la consulta a un archivo"
        Me.btnExportarConsulta.Glyph = CType(resources.GetObject("btnExportarConsulta.Glyph"), System.Drawing.Image)
        Me.btnExportarConsulta.Id = 16
        Me.btnExportarConsulta.LargeGlyph = CType(resources.GetObject("btnExportarConsulta.LargeGlyph"), System.Drawing.Image)
        Me.btnExportarConsulta.Name = "btnExportarConsulta"
        '
        'btnEliminarConsulta
        '
        Me.btnEliminarConsulta.Caption = "Eliminar"
        Me.btnEliminarConsulta.Glyph = CType(resources.GetObject("btnEliminarConsulta.Glyph"), System.Drawing.Image)
        Me.btnEliminarConsulta.Id = 32
        Me.btnEliminarConsulta.LargeGlyph = CType(resources.GetObject("btnEliminarConsulta.LargeGlyph"), System.Drawing.Image)
        Me.btnEliminarConsulta.Name = "btnEliminarConsulta"
        '
        'mnuConfiguracion
        '
        Me.mnuConfiguracion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.mnuConfiguracion.Caption = "Configuración"
        Me.mnuConfiguracion.DropDownControl = Me.popOpciones
        Me.mnuConfiguracion.Glyph = CType(resources.GetObject("mnuConfiguracion.Glyph"), System.Drawing.Image)
        Me.mnuConfiguracion.Id = 8
        Me.mnuConfiguracion.LargeGlyph = CType(resources.GetObject("mnuConfiguracion.LargeGlyph"), System.Drawing.Image)
        Me.mnuConfiguracion.Name = "mnuConfiguracion"
        '
        'popOpciones
        '
        Me.popOpciones.ItemLinks.Add(Me.btnPreferencias)
        Me.popOpciones.ItemLinks.Add(Me.btnOpcionesGenerales)
        Me.popOpciones.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesTextDescription
        Me.popOpciones.Name = "popOpciones"
        Me.popOpciones.Ribbon = Me.RibbonControl
        '
        'btnPreferencias
        '
        Me.btnPreferencias.Caption = "Preferencias del usuario"
        Me.btnPreferencias.Description = "Opciones de configuración para el usuario que inición la sesión"
        Me.btnPreferencias.Glyph = CType(resources.GetObject("btnPreferencias.Glyph"), System.Drawing.Image)
        Me.btnPreferencias.Id = 22
        Me.btnPreferencias.LargeGlyph = CType(resources.GetObject("btnPreferencias.LargeGlyph"), System.Drawing.Image)
        Me.btnPreferencias.Name = "btnPreferencias"
        '
        'btnOpcionesGenerales
        '
        Me.btnOpcionesGenerales.Caption = "Opciones generales"
        Me.btnOpcionesGenerales.Description = "Configuración global de EDR Analysis Suite"
        Me.btnOpcionesGenerales.Glyph = CType(resources.GetObject("btnOpcionesGenerales.Glyph"), System.Drawing.Image)
        Me.btnOpcionesGenerales.Id = 23
        Me.btnOpcionesGenerales.LargeGlyph = CType(resources.GetObject("btnOpcionesGenerales.LargeGlyph"), System.Drawing.Image)
        Me.btnOpcionesGenerales.Name = "btnOpcionesGenerales"
        '
        'mnuVer
        '
        Me.mnuVer.Caption = "Ver"
        Me.mnuVer.Id = 19
        Me.mnuVer.LargeGlyph = CType(resources.GetObject("mnuVer.LargeGlyph"), System.Drawing.Image)
        Me.mnuVer.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVerPC), New DevExpress.XtraBars.LinkPersistInfo(Me.btnVerPF), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuVentanas)})
        Me.mnuVer.Name = "mnuVer"
        '
        'btnVerPC
        '
        Me.btnVerPC.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnVerPC.Caption = "Panel de consultas"
        Me.btnVerPC.Description = "Muestra u oculta el panel de consultas"
        Me.btnVerPC.Id = 20
        Me.btnVerPC.Name = "btnVerPC"
        '
        'btnVerPF
        '
        Me.btnVerPF.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnVerPF.Caption = "Panel de favoritas"
        Me.btnVerPF.Description = "Muestra u oculta el panel de favoritas"
        Me.btnVerPF.Id = 21
        Me.btnVerPF.Name = "btnVerPF"
        '
        'mnuVentanas
        '
        Me.mnuVentanas.Caption = "Ventana"
        Me.mnuVentanas.Id = 31
        Me.mnuVentanas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuVentana)})
        Me.mnuVentanas.Name = "mnuVentanas"
        '
        'mnuVentana
        '
        Me.mnuVentana.Caption = "Ventana"
        Me.mnuVentana.Id = 30
        Me.mnuVentana.Name = "mnuVentana"
        '
        'btnCategorias
        '
        Me.btnCategorias.Caption = "Categorías"
        Me.btnCategorias.Glyph = CType(resources.GetObject("btnCategorias.Glyph"), System.Drawing.Image)
        Me.btnCategorias.Id = 17
        Me.btnCategorias.LargeGlyph = CType(resources.GetObject("btnCategorias.LargeGlyph"), System.Drawing.Image)
        Me.btnCategorias.Name = "btnCategorias"
        '
        'btnAdministracionSeguridad
        '
        Me.btnAdministracionSeguridad.Caption = "Seguridad y usuarios"
        Me.btnAdministracionSeguridad.Glyph = CType(resources.GetObject("btnAdministracionSeguridad.Glyph"), System.Drawing.Image)
        Me.btnAdministracionSeguridad.Id = 9
        Me.btnAdministracionSeguridad.LargeGlyph = CType(resources.GetObject("btnAdministracionSeguridad.LargeGlyph"), System.Drawing.Image)
        Me.btnAdministracionSeguridad.Name = "btnAdministracionSeguridad"
        '
        'btnConexiones
        '
        Me.btnConexiones.Caption = "Conexiones"
        Me.btnConexiones.Glyph = CType(resources.GetObject("btnConexiones.Glyph"), System.Drawing.Image)
        Me.btnConexiones.Id = 10
        Me.btnConexiones.LargeGlyph = CType(resources.GetObject("btnConexiones.LargeGlyph"), System.Drawing.Image)
        Me.btnConexiones.Name = "btnConexiones"
        '
        'btnSalir
        '
        Me.btnSalir.Caption = "&Salir"
        Me.btnSalir.Glyph = CType(resources.GetObject("btnSalir.Glyph"), System.Drawing.Image)
        Me.btnSalir.Id = 11
        Me.btnSalir.LargeGlyph = CType(resources.GetObject("btnSalir.LargeGlyph"), System.Drawing.Image)
        Me.btnSalir.Name = "btnSalir"
        '
        'il16x16
        '
        Me.il16x16.ImageStream = CType(resources.GetObject("il16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.il16x16.Images.SetKeyName(0, "Resultados.png")
        Me.il16x16.Images.SetKeyName(1, "CarpetaAbierta.png")
        Me.il16x16.Images.SetKeyName(2, "CarpetaCerrada.png")
        Me.il16x16.Images.SetKeyName(3, "Database.png")
        Me.il16x16.Images.SetKeyName(4, "DesignMode.png")
        '
        'stcStatus
        '
        Me.stcStatus.Caption = "Preparado"
        Me.stcStatus.Id = 1
        Me.stcStatus.Name = "stcStatus"
        Me.stcStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'stcUsuario
        '
        Me.stcUsuario.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.stcUsuario.Id = 2
        Me.stcUsuario.Name = "stcUsuario"
        Me.stcUsuario.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'stcHora
        '
        Me.stcHora.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.stcHora.Caption = "Hora"
        Me.stcHora.Id = 3
        Me.stcHora.Name = "stcHora"
        Me.stcHora.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnContenido
        '
        Me.btnContenido.Caption = "Contenido"
        Me.btnContenido.Glyph = CType(resources.GetObject("btnContenido.Glyph"), System.Drawing.Image)
        Me.btnContenido.Id = 24
        Me.btnContenido.LargeGlyph = CType(resources.GetObject("btnContenido.LargeGlyph"), System.Drawing.Image)
        Me.btnContenido.Name = "btnContenido"
        '
        'btnAbout
        '
        Me.btnAbout.Caption = "Acerca de Qualitas Reporting"
        Me.btnAbout.Glyph = CType(resources.GetObject("btnAbout.Glyph"), System.Drawing.Image)
        Me.btnAbout.Id = 25
        Me.btnAbout.LargeGlyph = CType(resources.GetObject("btnAbout.LargeGlyph"), System.Drawing.Image)
        Me.btnAbout.Name = "btnAbout"
        '
        'btnAbrirContext
        '
        Me.btnAbrirContext.Caption = "Abrir"
        Me.btnAbrirContext.Id = 26
        Me.btnAbrirContext.Name = "btnAbrirContext"
        '
        'btnDisenarContext
        '
        Me.btnDisenarContext.Caption = "Diseñar"
        Me.btnDisenarContext.Id = 27
        Me.btnDisenarContext.Name = "btnDisenarContext"
        '
        'btnExportarContext
        '
        Me.btnExportarContext.Caption = "Exportar"
        Me.btnExportarContext.Id = 28
        Me.btnExportarContext.Name = "btnExportarContext"
        '
        'btnAgregarFavoritasContext
        '
        Me.btnAgregarFavoritasContext.Caption = "Agregar a favoritas"
        Me.btnAgregarFavoritasContext.Id = 29
        Me.btnAgregarFavoritasContext.Name = "btnAgregarFavoritasContext"
        '
        'btnEliminarContext
        '
        Me.btnEliminarContext.Caption = "Eliminar"
        Me.btnEliminarContext.Id = 33
        Me.btnEliminarContext.Name = "btnEliminarContext"
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "AppIconV2.png")
        Me.il32x32.Images.SetKeyName(1, "007.png")
        Me.il32x32.Images.SetKeyName(2, "008.png")
        Me.il32x32.Images.SetKeyName(3, "009.png")
        '
        'rpConsultas
        '
        Me.rpConsultas.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgConsultas, Me.rpgImportacion, Me.rpgConfiguracion, Me.rpgOtros, Me.rpgAyuda})
        Me.rpConsultas.KeyTip = ""
        Me.rpConsultas.Name = "rpConsultas"
        Me.rpConsultas.Text = "Consultas"
        '
        'rpgConsultas
        '
        Me.rpgConsultas.ItemLinks.Add(Me.btnCrearConsulta)
        Me.rpgConsultas.ItemLinks.Add(Me.btnAbrirConsulta, True)
        Me.rpgConsultas.ItemLinks.Add(Me.btnDisenarConsulta)
        Me.rpgConsultas.ItemLinks.Add(Me.btnEliminarConsulta)
        Me.rpgConsultas.KeyTip = ""
        Me.rpgConsultas.Name = "rpgConsultas"
        Me.rpgConsultas.ShowCaptionButton = False
        Me.rpgConsultas.Text = "Común"
        '
        'rpgImportacion
        '
        Me.rpgImportacion.ItemLinks.Add(Me.btnImportarConsulta)
        Me.rpgImportacion.ItemLinks.Add(Me.btnExportarConsulta)
        Me.rpgImportacion.KeyTip = ""
        Me.rpgImportacion.Name = "rpgImportacion"
        Me.rpgImportacion.ShowCaptionButton = False
        Me.rpgImportacion.Text = "Importación"
        '
        'rpgConfiguracion
        '
        Me.rpgConfiguracion.ItemLinks.Add(Me.btnPreferencias)
        Me.rpgConfiguracion.ItemLinks.Add(Me.btnOpcionesGenerales)
        Me.rpgConfiguracion.KeyTip = ""
        Me.rpgConfiguracion.Name = "rpgConfiguracion"
        Me.rpgConfiguracion.ShowCaptionButton = False
        Me.rpgConfiguracion.Text = "Configuración"
        '
        'rpgOtros
        '
        Me.rpgOtros.ItemLinks.Add(Me.btnAdministracionSeguridad)
        Me.rpgOtros.ItemLinks.Add(Me.btnConexiones)
        Me.rpgOtros.ItemLinks.Add(Me.btnCategorias)
        Me.rpgOtros.ItemLinks.Add(Me.mnuVer, True)
        Me.rpgOtros.KeyTip = ""
        Me.rpgOtros.Name = "rpgOtros"
        Me.rpgOtros.ShowCaptionButton = False
        Me.rpgOtros.Text = "Otros"
        '
        'rpgAyuda
        '
        Me.rpgAyuda.ItemLinks.Add(Me.btnContenido)
        Me.rpgAyuda.ItemLinks.Add(Me.btnAbout)
        Me.rpgAyuda.KeyTip = ""
        Me.rpgAyuda.Name = "rpgAyuda"
        Me.rpgAyuda.ShowCaptionButton = False
        Me.rpgAyuda.Text = "Ayuda"
        '
        'rpOtros
        '
        Me.rpOtros.KeyTip = ""
        Me.rpOtros.Name = "rpOtros"
        Me.rpOtros.Text = "Otros"
        Me.rpOtros.Visible = False
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.stcStatus)
        Me.RibbonStatusBar.ItemLinks.Add(Me.stcUsuario)
        Me.RibbonStatusBar.ItemLinks.Add(Me.stcHora, True)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 510)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(792, 23)
        '
        'popInicio
        '
        Me.popInicio.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText
        Me.popInicio.Name = "popInicio"
        Me.popInicio.Ribbon = Me.RibbonControl
        '
        'mdiTabs
        '
        Me.mdiTabs.MdiParent = Me
        '
        'dckManager
        '
        Me.dckManager.Form = Me
        Me.dckManager.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.pnlConsultas, Me.pnlFavoritas})
        Me.dckManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'pnlConsultas
        '
        Me.pnlConsultas.Controls.Add(Me.DockPanel2_Container)
        Me.pnlConsultas.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.pnlConsultas.ID = New System.Guid("2668bb81-07b6-4b1e-b0f6-5819cf8996e4")
        Me.pnlConsultas.Location = New System.Drawing.Point(3, 24)
        Me.pnlConsultas.Name = "pnlConsultas"
        Me.pnlConsultas.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.pnlConsultas.SavedIndex = 0
        Me.pnlConsultas.SavedParent = Me.pnlFavoritas
        Me.pnlConsultas.SavedTabbed = True
        Me.pnlConsultas.Size = New System.Drawing.Size(256, 315)
        Me.pnlConsultas.Text = "Consultas"
        Me.pnlConsultas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.tvMain)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(256, 315)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'tvMain
        '
        Me.tvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvMain.ImageIndex = 0
        Me.tvMain.ImageList = Me.il16x16
        Me.tvMain.LineColor = System.Drawing.Color.Empty
        Me.tvMain.Location = New System.Drawing.Point(0, 0)
        Me.tvMain.Name = "tvMain"
        TreeNode1.Name = "nodRaiz"
        TreeNode1.Text = "Consultas almacenadas"
        Me.tvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvMain.SelectedImageIndex = 0
        Me.tvMain.Size = New System.Drawing.Size(256, 315)
        Me.tvMain.TabIndex = 0
        '
        'pnlFavoritas
        '
        Me.pnlFavoritas.Controls.Add(Me.DockPanel1_Container)
        Me.pnlFavoritas.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlFavoritas.FloatVertical = True
        Me.pnlFavoritas.ID = New System.Guid("ca8fd115-143b-4194-8757-c08b1eb94e88")
        Me.pnlFavoritas.Location = New System.Drawing.Point(530, 147)
        Me.pnlFavoritas.Name = "pnlFavoritas"
        Me.pnlFavoritas.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlFavoritas.SavedIndex = 0
        Me.pnlFavoritas.Size = New System.Drawing.Size(262, 363)
        Me.pnlFavoritas.Text = "Favoritas"
        Me.pnlFavoritas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.lvFavoritas)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 24)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(256, 336)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'lvFavoritas
        '
        Me.lvFavoritas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvFavoritas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002})
        Me.lvFavoritas.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Consultas favoritas"
        ListViewGroup1.Name = "lvg001"
        Me.lvFavoritas.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lvFavoritas.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        Me.lvFavoritas.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvFavoritas.LargeImageList = Me.il32x32
        Me.lvFavoritas.Location = New System.Drawing.Point(0, 0)
        Me.lvFavoritas.MultiSelect = False
        Me.lvFavoritas.Name = "lvFavoritas"
        Me.lvFavoritas.Size = New System.Drawing.Size(256, 336)
        Me.lvFavoritas.SmallImageList = Me.il32x32
        Me.lvFavoritas.TabIndex = 7
        Me.lvFavoritas.TileSize = New System.Drawing.Size(250, 36)
        Me.lvFavoritas.UseCompatibleStateImageBehavior = False
        Me.lvFavoritas.View = System.Windows.Forms.View.Tile
        '
        'tmrFechaHora
        '
        Me.tmrFechaHora.Enabled = True
        Me.tmrFechaHora.Interval = 60000
        '
        'oLAF
        '
        Me.oLAF.LookAndFeel.SkinName = "Office 2007 Black"
        Me.oLAF.LookAndFeel.UseWindowsXPTheme = True
        '
        'popContext
        '
        Me.popContext.ItemLinks.Add(Me.btnAbrirContext)
        Me.popContext.ItemLinks.Add(Me.btnDisenarContext)
        Me.popContext.ItemLinks.Add(Me.btnExportarContext)
        Me.popContext.ItemLinks.Add(Me.btnEliminarContext)
        Me.popContext.ItemLinks.Add(Me.btnAgregarFavoritasContext, True)
        Me.popContext.Name = "popContext"
        Me.popContext.Ribbon = Me.RibbonControl
        '
        'frmMainX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 533)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMainX"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mdiTabs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dckManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConsultas.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.pnlFavoritas.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.popContext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rpConsultas As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgConsultas As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents mdiTabs As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents dckManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents oLAF As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents il16x16 As System.Windows.Forms.ImageList
    Friend WithEvents stcStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents stcUsuario As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents stcHora As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents popInicio As DevExpress.XtraBars.PopupMenu
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents mnuConsulta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuConfiguracion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAdministracionSeguridad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConexiones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pnlFavoritas As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents pnlConsultas As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents tvMain As System.Windows.Forms.TreeView
    Friend WithEvents rpOtros As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnCrearConsulta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popConsultas As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnAbrirConsulta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDisenarConsulta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImportarConsulta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportarConsulta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCategorias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuVer As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnVerPC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerPF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popOpciones As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnPreferencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOpcionesGenerales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgImportacion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgConfiguracion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgOtros As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnContenido As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAbout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgAyuda As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents popContext As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnAbrirContext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDisenarContext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportarContext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAgregarFavoritasContext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuVentana As DevExpress.XtraBars.BarMdiChildrenListItem
    Friend WithEvents mnuVentanas As DevExpress.XtraBars.BarSubItem
    Friend WithEvents lvFavoritas As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEliminarConsulta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminarContext As DevExpress.XtraBars.BarButtonItem


End Class
