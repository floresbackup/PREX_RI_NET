<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Informes propios de esta consulta", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Informes de esta consulta compartidos con otros usuarios", System.Windows.Forms.HorizontalAlignment.Left)
        Me.GridResultados = New DevExpress.XtraGrid.GridControl
        Me.gvwResultados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.rbcMain = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.popConjuntos = New DevExpress.XtraBars.BarSubItem
        Me.btnResults000 = New DevExpress.XtraBars.BarButtonItem
        Me.btnVistaPrevia = New DevExpress.XtraBars.BarButtonItem
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem
        Me.btnPDF = New DevExpress.XtraBars.BarButtonItem
        Me.btnHTML = New DevExpress.XtraBars.BarButtonItem
        Me.btnGuardarLayout = New DevExpress.XtraBars.BarButtonItem
        Me.btnAutofiltro = New DevExpress.XtraBars.BarButtonItem
        Me.btnFilasSubtotales = New DevExpress.XtraBars.BarButtonItem
        Me.btnFilaTotales = New DevExpress.XtraBars.BarButtonItem
        Me.btnGroupByBox = New DevExpress.XtraBars.BarButtonItem
        Me.btnColumnas = New DevExpress.XtraBars.BarButtonItem
        Me.mnuContextNuevoReporte = New DevExpress.XtraBars.BarButtonItem
        Me.mnuContextAbrirReporte = New DevExpress.XtraBars.BarButtonItem
        Me.mnuContextDisenarReporte = New DevExpress.XtraBars.BarButtonItem
        Me.mnuContextEliminarReporte = New DevExpress.XtraBars.BarButtonItem
        Me.mnuContextCargarDesdeArchivo = New DevExpress.XtraBars.BarButtonItem
        Me.btnCargarLayout = New DevExpress.XtraBars.BarButtonItem
        Me.rpOpciones = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgConjuntos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgImpresion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgExportacion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgOtros = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.Tabs = New DevExpress.XtraTab.XtraTabControl
        Me.tpParametros = New DevExpress.XtraTab.XtraTabPage
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.lblDescripcion = New DevExpress.XtraEditors.LabelControl
        Me.lblConexion = New DevExpress.XtraEditors.LabelControl
        Me.lblTituloConexion = New System.Windows.Forms.Label
        Me.lblTituloDescripcion = New System.Windows.Forms.Label
        Me.cmdEjecutar = New DevExpress.XtraEditors.SimpleButton
        Me.GridParametros = New DevExpress.XtraVerticalGrid.VGridControl
        Me.catRow = New DevExpress.XtraVerticalGrid.Rows.CategoryRow
        Me.lblNombre = New System.Windows.Forms.Label
        Me.picIcon = New System.Windows.Forms.PictureBox
        Me.tpResultados = New DevExpress.XtraTab.XtraTabPage
        Me.tpCubo = New DevExpress.XtraTab.XtraTabPage
        Me.rbcCubo = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.btnCuboCustomizeFields = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerEjeX = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerEjeY = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerLeyendas = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerValores = New DevExpress.XtraBars.BarButtonItem
        Me.popTipoGrafico = New DevExpress.XtraBars.BarSubItem
        Me.bsi2D = New DevExpress.XtraBars.BarSubItem
        Me.btnPuntos2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnLineas2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnStepLine2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnSpline2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnBarras2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnBarrasApiladas2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnArea2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnStackedArea2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnFullStackedArea2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnSplineArea2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnStackedSplineArea2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnFullStackedSplineArea2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnRadarPoint2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnRadarLine2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnRadarArea2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnTorta2D = New DevExpress.XtraBars.BarButtonItem
        Me.btnDoughnut2D = New DevExpress.XtraBars.BarButtonItem
        Me.bsi3D = New DevExpress.XtraBars.BarSubItem
        Me.btnPuntos3D = New DevExpress.XtraBars.BarButtonItem
        Me.btnLineas3D = New DevExpress.XtraBars.BarButtonItem
        Me.btnBarras3D = New DevExpress.XtraBars.BarButtonItem
        Me.btnBarrasApiladas3D = New DevExpress.XtraBars.BarButtonItem
        Me.btnArea3D = New DevExpress.XtraBars.BarButtonItem
        Me.btnTorta3D = New DevExpress.XtraBars.BarButtonItem
        Me.popOrientacion = New DevExpress.XtraBars.BarSubItem
        Me.btnOrientacionVertical = New DevExpress.XtraBars.BarButtonItem
        Me.btnOrientacionHorizontal = New DevExpress.XtraBars.BarButtonItem
        Me.btnGuardarLayoutCubo = New DevExpress.XtraBars.BarButtonItem
        Me.btnVistaPreviaCubo = New DevExpress.XtraBars.BarButtonItem
        Me.btnImprimirCubo = New DevExpress.XtraBars.BarButtonItem
        Me.btnExcelCubo = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlternarVisibilidad = New DevExpress.XtraBars.BarButtonItem
        Me.btnExcelGrafico = New DevExpress.XtraBars.BarButtonItem
        Me.btnImagenGrafico = New DevExpress.XtraBars.BarButtonItem
        Me.btnVistaPreviaGrafico = New DevExpress.XtraBars.BarButtonItem
        Me.btnRotado = New DevExpress.XtraBars.BarButtonItem
        Me.btnColumnasCubo = New DevExpress.XtraBars.BarButtonItem
        Me.btnCargarLayoutCubo = New DevExpress.XtraBars.BarButtonItem
        Me.rpCuboGrafico = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgComun = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgCubo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgGrafico = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.oSplitter = New DevExpress.XtraEditors.SplitContainerControl
        Me.pgCubo = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.riProgressBar = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
        Me.chrGrafico = New DevExpress.XtraCharts.ChartControl
        Me.tpReporte = New DevExpress.XtraTab.XtraTabPage
        Me.cmdCargarDesdeArchivo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEliminarReporte = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDisenarReporte = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAbrirReporte = New DevExpress.XtraEditors.SimpleButton
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.lvReportes = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdNuevoReporte = New DevExpress.XtraEditors.SimpleButton
        Me.popResultados = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.popContextReportes = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.tpParametros.SuspendLayout()
        CType(Me.GridParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpResultados.SuspendLayout()
        Me.tpCubo.SuspendLayout()
        CType(Me.oSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitter.SuspendLayout()
        CType(Me.pgCubo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReporte.SuspendLayout()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        CType(Me.popResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popContextReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridResultados
        '
        Me.GridResultados.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridResultados.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridResultados.EmbeddedNavigator.Name = ""
        Me.GridResultados.Location = New System.Drawing.Point(0, 0)
        Me.GridResultados.MainView = Me.gvwResultados
        Me.GridResultados.MenuManager = Me.rbcMain
        Me.GridResultados.Name = "GridResultados"
        Me.GridResultados.ServerMode = True
        Me.GridResultados.Size = New System.Drawing.Size(819, 242)
        Me.GridResultados.TabIndex = 6
        Me.GridResultados.UseEmbeddedNavigator = True
        Me.GridResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwResultados})
        '
        'gvwResultados
        '
        Me.gvwResultados.BestFitMaxRowCount = 100
        Me.gvwResultados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvwResultados.GridControl = Me.GridResultados
        Me.gvwResultados.Name = "gvwResultados"
        Me.gvwResultados.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvwResultados.OptionsBehavior.Editable = False
        Me.gvwResultados.OptionsFilter.MaxCheckedListItemCount = 10000
        Me.gvwResultados.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gvwResultados.OptionsPrint.ExpandAllGroups = False
        Me.gvwResultados.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvwResultados.OptionsView.ColumnAutoWidth = False
        Me.gvwResultados.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gvwResultados.OptionsView.ShowAutoFilterRow = True
        Me.gvwResultados.OptionsView.ShowFooter = True
        '
        'rbcMain
        '
        Me.rbcMain.ApplicationButtonKeyTip = ""
        Me.rbcMain.ApplicationIcon = Nothing
        Me.rbcMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbcMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.popConjuntos, Me.btnVistaPrevia, Me.btnImprimir, Me.btnExcel, Me.btnPDF, Me.btnResults000, Me.btnHTML, Me.btnGuardarLayout, Me.btnAutofiltro, Me.btnFilasSubtotales, Me.btnFilaTotales, Me.btnGroupByBox, Me.btnColumnas, Me.mnuContextNuevoReporte, Me.mnuContextAbrirReporte, Me.mnuContextDisenarReporte, Me.mnuContextEliminarReporte, Me.mnuContextCargarDesdeArchivo, Me.btnCargarLayout})
        Me.rbcMain.Location = New System.Drawing.Point(0, 321)
        Me.rbcMain.MaxItemId = 24
        Me.rbcMain.Name = "rbcMain"
        Me.rbcMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpOpciones})
        Me.rbcMain.SelectedPage = Me.rpOpciones
        Me.rbcMain.Size = New System.Drawing.Size(819, 142)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.popConjuntos)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnVistaPrevia, True)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnImprimir)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnExcel, True)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnHTML)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnPDF)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnAutofiltro, True)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnGroupByBox)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnFilasSubtotales)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnFilaTotales)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnColumnas)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnGuardarLayout, True)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnCargarLayout)
        Me.rbcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below
        '
        'popConjuntos
        '
        Me.popConjuntos.Caption = "(Predeterminado)"
        Me.popConjuntos.Glyph = CType(resources.GetObject("popConjuntos.Glyph"), System.Drawing.Image)
        Me.popConjuntos.Id = 3
        Me.popConjuntos.LargeGlyph = CType(resources.GetObject("popConjuntos.LargeGlyph"), System.Drawing.Image)
        Me.popConjuntos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnResults000)})
        Me.popConjuntos.Name = "popConjuntos"
        Me.popConjuntos.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnResults000
        '
        Me.btnResults000.Caption = "(Predeterminado)"
        Me.btnResults000.Id = 10
        Me.btnResults000.Name = "btnResults000"
        Me.btnResults000.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Caption = "&Vista previa"
        Me.btnVistaPrevia.Glyph = CType(resources.GetObject("btnVistaPrevia.Glyph"), System.Drawing.Image)
        Me.btnVistaPrevia.Id = 4
        Me.btnVistaPrevia.LargeGlyph = CType(resources.GetObject("btnVistaPrevia.LargeGlyph"), System.Drawing.Image)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        '
        'btnImprimir
        '
        Me.btnImprimir.Caption = "&Imprimir"
        Me.btnImprimir.Glyph = CType(resources.GetObject("btnImprimir.Glyph"), System.Drawing.Image)
        Me.btnImprimir.Id = 5
        Me.btnImprimir.LargeGlyph = CType(resources.GetObject("btnImprimir.LargeGlyph"), System.Drawing.Image)
        Me.btnImprimir.Name = "btnImprimir"
        '
        'btnExcel
        '
        Me.btnExcel.Caption = "&Excel"
        Me.btnExcel.Glyph = CType(resources.GetObject("btnExcel.Glyph"), System.Drawing.Image)
        Me.btnExcel.Id = 6
        Me.btnExcel.LargeGlyph = CType(resources.GetObject("btnExcel.LargeGlyph"), System.Drawing.Image)
        Me.btnExcel.Name = "btnExcel"
        '
        'btnPDF
        '
        Me.btnPDF.Caption = "&PDF"
        Me.btnPDF.Glyph = CType(resources.GetObject("btnPDF.Glyph"), System.Drawing.Image)
        Me.btnPDF.Id = 7
        Me.btnPDF.LargeGlyph = CType(resources.GetObject("btnPDF.LargeGlyph"), System.Drawing.Image)
        Me.btnPDF.Name = "btnPDF"
        '
        'btnHTML
        '
        Me.btnHTML.Caption = "Página web"
        Me.btnHTML.Glyph = CType(resources.GetObject("btnHTML.Glyph"), System.Drawing.Image)
        Me.btnHTML.Id = 11
        Me.btnHTML.LargeGlyph = CType(resources.GetObject("btnHTML.LargeGlyph"), System.Drawing.Image)
        Me.btnHTML.Name = "btnHTML"
        '
        'btnGuardarLayout
        '
        Me.btnGuardarLayout.Caption = "Guardar diseño"
        Me.btnGuardarLayout.Glyph = CType(resources.GetObject("btnGuardarLayout.Glyph"), System.Drawing.Image)
        Me.btnGuardarLayout.Id = 12
        Me.btnGuardarLayout.LargeGlyph = CType(resources.GetObject("btnGuardarLayout.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardarLayout.Name = "btnGuardarLayout"
        '
        'btnAutofiltro
        '
        Me.btnAutofiltro.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnAutofiltro.Caption = "Autofiltro"
        Me.btnAutofiltro.Down = True
        Me.btnAutofiltro.Glyph = CType(resources.GetObject("btnAutofiltro.Glyph"), System.Drawing.Image)
        Me.btnAutofiltro.Id = 13
        Me.btnAutofiltro.LargeGlyph = CType(resources.GetObject("btnAutofiltro.LargeGlyph"), System.Drawing.Image)
        Me.btnAutofiltro.Name = "btnAutofiltro"
        '
        'btnFilasSubtotales
        '
        Me.btnFilasSubtotales.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnFilasSubtotales.Caption = "Filas de subtotales"
        Me.btnFilasSubtotales.Down = True
        Me.btnFilasSubtotales.Glyph = CType(resources.GetObject("btnFilasSubtotales.Glyph"), System.Drawing.Image)
        Me.btnFilasSubtotales.Id = 14
        Me.btnFilasSubtotales.LargeGlyph = CType(resources.GetObject("btnFilasSubtotales.LargeGlyph"), System.Drawing.Image)
        Me.btnFilasSubtotales.Name = "btnFilasSubtotales"
        '
        'btnFilaTotales
        '
        Me.btnFilaTotales.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnFilaTotales.Caption = "Fila de total"
        Me.btnFilaTotales.Down = True
        Me.btnFilaTotales.Glyph = CType(resources.GetObject("btnFilaTotales.Glyph"), System.Drawing.Image)
        Me.btnFilaTotales.Id = 15
        Me.btnFilaTotales.LargeGlyph = CType(resources.GetObject("btnFilaTotales.LargeGlyph"), System.Drawing.Image)
        Me.btnFilaTotales.Name = "btnFilaTotales"
        '
        'btnGroupByBox
        '
        Me.btnGroupByBox.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnGroupByBox.Caption = "Cuadro para agrupar"
        Me.btnGroupByBox.Down = True
        Me.btnGroupByBox.Glyph = CType(resources.GetObject("btnGroupByBox.Glyph"), System.Drawing.Image)
        Me.btnGroupByBox.Id = 16
        Me.btnGroupByBox.LargeGlyph = CType(resources.GetObject("btnGroupByBox.LargeGlyph"), System.Drawing.Image)
        Me.btnGroupByBox.Name = "btnGroupByBox"
        '
        'btnColumnas
        '
        Me.btnColumnas.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnColumnas.Caption = "Columnas"
        Me.btnColumnas.Glyph = CType(resources.GetObject("btnColumnas.Glyph"), System.Drawing.Image)
        Me.btnColumnas.Id = 17
        Me.btnColumnas.LargeGlyph = CType(resources.GetObject("btnColumnas.LargeGlyph"), System.Drawing.Image)
        Me.btnColumnas.Name = "btnColumnas"
        '
        'mnuContextNuevoReporte
        '
        Me.mnuContextNuevoReporte.Caption = "Nuevo informe"
        Me.mnuContextNuevoReporte.Glyph = CType(resources.GetObject("mnuContextNuevoReporte.Glyph"), System.Drawing.Image)
        Me.mnuContextNuevoReporte.Id = 18
        Me.mnuContextNuevoReporte.Name = "mnuContextNuevoReporte"
        '
        'mnuContextAbrirReporte
        '
        Me.mnuContextAbrirReporte.Caption = "Abrir informe"
        Me.mnuContextAbrirReporte.Glyph = CType(resources.GetObject("mnuContextAbrirReporte.Glyph"), System.Drawing.Image)
        Me.mnuContextAbrirReporte.Id = 19
        Me.mnuContextAbrirReporte.Name = "mnuContextAbrirReporte"
        Me.mnuContextAbrirReporte.OwnFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuContextAbrirReporte.UseOwnFont = True
        '
        'mnuContextDisenarReporte
        '
        Me.mnuContextDisenarReporte.Caption = "Diseñar informe"
        Me.mnuContextDisenarReporte.Glyph = CType(resources.GetObject("mnuContextDisenarReporte.Glyph"), System.Drawing.Image)
        Me.mnuContextDisenarReporte.Id = 20
        Me.mnuContextDisenarReporte.Name = "mnuContextDisenarReporte"
        '
        'mnuContextEliminarReporte
        '
        Me.mnuContextEliminarReporte.Caption = "Eliminar informe"
        Me.mnuContextEliminarReporte.Glyph = CType(resources.GetObject("mnuContextEliminarReporte.Glyph"), System.Drawing.Image)
        Me.mnuContextEliminarReporte.Id = 21
        Me.mnuContextEliminarReporte.Name = "mnuContextEliminarReporte"
        '
        'mnuContextCargarDesdeArchivo
        '
        Me.mnuContextCargarDesdeArchivo.Caption = "Cargar desde archivo..."
        Me.mnuContextCargarDesdeArchivo.Glyph = CType(resources.GetObject("mnuContextCargarDesdeArchivo.Glyph"), System.Drawing.Image)
        Me.mnuContextCargarDesdeArchivo.Id = 22
        Me.mnuContextCargarDesdeArchivo.Name = "mnuContextCargarDesdeArchivo"
        '
        'btnCargarLayout
        '
        Me.btnCargarLayout.Caption = "Cargar diseño"
        Me.btnCargarLayout.Glyph = CType(resources.GetObject("btnCargarLayout.Glyph"), System.Drawing.Image)
        Me.btnCargarLayout.Id = 23
        Me.btnCargarLayout.LargeGlyph = CType(resources.GetObject("btnCargarLayout.LargeGlyph"), System.Drawing.Image)
        Me.btnCargarLayout.Name = "btnCargarLayout"
        '
        'rpOpciones
        '
        Me.rpOpciones.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgConjuntos, Me.rpgImpresion, Me.rpgExportacion, Me.rpgOtros})
        Me.rpOpciones.KeyTip = ""
        Me.rpOpciones.Name = "rpOpciones"
        Me.rpOpciones.Text = "Opciones de los resultados"
        '
        'rpgConjuntos
        '
        Me.rpgConjuntos.ItemLinks.Add(Me.popConjuntos)
        Me.rpgConjuntos.KeyTip = ""
        Me.rpgConjuntos.Name = "rpgConjuntos"
        Me.rpgConjuntos.ShowCaptionButton = False
        Me.rpgConjuntos.Text = "Conjuntos de resultados"
        '
        'rpgImpresion
        '
        Me.rpgImpresion.ItemLinks.Add(Me.btnVistaPrevia)
        Me.rpgImpresion.ItemLinks.Add(Me.btnImprimir)
        Me.rpgImpresion.KeyTip = ""
        Me.rpgImpresion.Name = "rpgImpresion"
        Me.rpgImpresion.ShowCaptionButton = False
        Me.rpgImpresion.Text = "Impresión"
        '
        'rpgExportacion
        '
        Me.rpgExportacion.ItemLinks.Add(Me.btnExcel)
        Me.rpgExportacion.ItemLinks.Add(Me.btnHTML)
        Me.rpgExportacion.ItemLinks.Add(Me.btnPDF)
        Me.rpgExportacion.KeyTip = ""
        Me.rpgExportacion.Name = "rpgExportacion"
        Me.rpgExportacion.ShowCaptionButton = False
        Me.rpgExportacion.Text = "Exportación"
        '
        'rpgOtros
        '
        Me.rpgOtros.ItemLinks.Add(Me.btnAutofiltro)
        Me.rpgOtros.ItemLinks.Add(Me.btnGroupByBox)
        Me.rpgOtros.ItemLinks.Add(Me.btnFilasSubtotales)
        Me.rpgOtros.ItemLinks.Add(Me.btnFilaTotales)
        Me.rpgOtros.ItemLinks.Add(Me.btnColumnas)
        Me.rpgOtros.ItemLinks.Add(Me.btnGuardarLayout, True)
        Me.rpgOtros.ItemLinks.Add(Me.btnCargarLayout)
        Me.rpgOtros.KeyTip = ""
        Me.rpgOtros.Name = "rpgOtros"
        Me.rpgOtros.ShowCaptionButton = False
        Me.rpgOtros.Text = "Otras opciones"
        '
        'Tabs
        '
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabs.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.Tabs.Location = New System.Drawing.Point(0, 0)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedTabPage = Me.tpParametros
        Me.Tabs.Size = New System.Drawing.Size(828, 496)
        Me.Tabs.TabIndex = 2
        Me.Tabs.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpParametros, Me.tpResultados, Me.tpCubo, Me.tpReporte})
        '
        'tpParametros
        '
        Me.tpParametros.Controls.Add(Me.cmdCerrar)
        Me.tpParametros.Controls.Add(Me.lblDescripcion)
        Me.tpParametros.Controls.Add(Me.lblConexion)
        Me.tpParametros.Controls.Add(Me.lblTituloConexion)
        Me.tpParametros.Controls.Add(Me.lblTituloDescripcion)
        Me.tpParametros.Controls.Add(Me.cmdEjecutar)
        Me.tpParametros.Controls.Add(Me.GridParametros)
        Me.tpParametros.Controls.Add(Me.lblNombre)
        Me.tpParametros.Controls.Add(Me.picIcon)
        Me.tpParametros.Image = CType(resources.GetObject("tpParametros.Image"), System.Drawing.Image)
        Me.tpParametros.Name = "tpParametros"
        Me.tpParametros.Size = New System.Drawing.Size(819, 463)
        Me.tpParametros.Text = "Parámetros"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.Location = New System.Drawing.Point(290, 93)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(100, 35)
        Me.cmdCerrar.TabIndex = 12
        Me.cmdCerrar.Text = "&Cerrar"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescripcion.Appearance.Options.UseForeColor = True
        Me.lblDescripcion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblDescripcion.Location = New System.Drawing.Point(220, 51)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(391, 13)
        Me.lblDescripcion.TabIndex = 11
        Me.lblDescripcion.Text = "Descripcion de esta consulta"
        '
        'lblConexion
        '
        Me.lblConexion.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblConexion.Appearance.Options.UseForeColor = True
        Me.lblConexion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblConexion.Location = New System.Drawing.Point(220, 32)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(391, 13)
        Me.lblConexion.TabIndex = 10
        Me.lblConexion.Text = "Conexion de esta consulta"
        '
        'lblTituloConexion
        '
        Me.lblTituloConexion.AutoSize = True
        Me.lblTituloConexion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloConexion.Location = New System.Drawing.Point(142, 32)
        Me.lblTituloConexion.Name = "lblTituloConexion"
        Me.lblTituloConexion.Size = New System.Drawing.Size(62, 13)
        Me.lblTituloConexion.TabIndex = 9
        Me.lblTituloConexion.Text = "Conexión:"
        '
        'lblTituloDescripcion
        '
        Me.lblTituloDescripcion.AutoSize = True
        Me.lblTituloDescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloDescripcion.Location = New System.Drawing.Point(142, 51)
        Me.lblTituloDescripcion.Name = "lblTituloDescripcion"
        Me.lblTituloDescripcion.Size = New System.Drawing.Size(75, 13)
        Me.lblTituloDescripcion.TabIndex = 7
        Me.lblTituloDescripcion.Text = "Descripción:"
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Image = CType(resources.GetObject("cmdEjecutar.Image"), System.Drawing.Image)
        Me.cmdEjecutar.Location = New System.Drawing.Point(137, 93)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(147, 35)
        Me.cmdEjecutar.TabIndex = 6
        Me.cmdEjecutar.Text = "&Ejecutar consulta"
        '
        'GridParametros
        '
        Me.GridParametros.Location = New System.Drawing.Point(0, 134)
        Me.GridParametros.Name = "GridParametros"
        Me.GridParametros.RecordWidth = 363
        Me.GridParametros.RowHeaderWidth = 241
        Me.GridParametros.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.catRow})
        Me.GridParametros.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways
        Me.GridParametros.Size = New System.Drawing.Size(611, 251)
        Me.GridParametros.TabIndex = 0
        '
        'catRow
        '
        Me.catRow.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.catRow.Appearance.Options.UseFont = True
        Me.catRow.Height = 19
        Me.catRow.Name = "catRow"
        Me.catRow.Properties.Caption = "Parámetros de la consulta"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(137, 6)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(80, 19)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Consulta"
        '
        'picIcon
        '
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(3, 0)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(128, 128)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picIcon.TabIndex = 0
        Me.picIcon.TabStop = False
        '
        'tpResultados
        '
        Me.tpResultados.Controls.Add(Me.rbcMain)
        Me.tpResultados.Controls.Add(Me.GridResultados)
        Me.tpResultados.Image = CType(resources.GetObject("tpResultados.Image"), System.Drawing.Image)
        Me.tpResultados.Name = "tpResultados"
        Me.tpResultados.PageEnabled = False
        Me.tpResultados.Size = New System.Drawing.Size(819, 463)
        Me.tpResultados.Text = "Resultados"
        '
        'tpCubo
        '
        Me.tpCubo.Controls.Add(Me.rbcCubo)
        Me.tpCubo.Controls.Add(Me.oSplitter)
        Me.tpCubo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpCubo.Image = CType(resources.GetObject("tpCubo.Image"), System.Drawing.Image)
        Me.tpCubo.Name = "tpCubo"
        Me.tpCubo.PageEnabled = False
        Me.tpCubo.Size = New System.Drawing.Size(819, 463)
        Me.tpCubo.Text = "Tabla dinámica y gráfico"
        '
        'rbcCubo
        '
        Me.rbcCubo.ApplicationButtonKeyTip = ""
        Me.rbcCubo.ApplicationIcon = Nothing
        Me.rbcCubo.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbcCubo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbcCubo.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCuboCustomizeFields, Me.btnVerEjeX, Me.btnVerEjeY, Me.btnVerLeyendas, Me.btnVerValores, Me.popTipoGrafico, Me.bsi2D, Me.bsi3D, Me.btnPuntos2D, Me.btnLineas2D, Me.btnBarras2D, Me.btnBarrasApiladas2D, Me.btnArea2D, Me.btnTorta2D, Me.btnPuntos3D, Me.btnLineas3D, Me.btnBarras3D, Me.btnBarrasApiladas3D, Me.btnArea3D, Me.btnTorta3D, Me.popOrientacion, Me.btnOrientacionVertical, Me.btnOrientacionHorizontal, Me.btnGuardarLayoutCubo, Me.btnVistaPreviaCubo, Me.btnImprimirCubo, Me.btnExcelCubo, Me.btnAlternarVisibilidad, Me.btnExcelGrafico, Me.btnImagenGrafico, Me.btnVistaPreviaGrafico, Me.btnRotado, Me.btnColumnasCubo, Me.btnCargarLayoutCubo, Me.btnStepLine2D, Me.btnSpline2D, Me.btnSplineArea2D, Me.btnStackedArea2D, Me.btnStackedSplineArea2D, Me.btnFullStackedArea2D, Me.btnFullStackedSplineArea2D, Me.btnRadarPoint2D, Me.btnRadarLine2D, Me.btnRadarArea2D, Me.btnDoughnut2D})
        Me.rbcCubo.Location = New System.Drawing.Point(0, 321)
        Me.rbcCubo.MaxItemId = 47
        Me.rbcCubo.Name = "rbcCubo"
        Me.rbcCubo.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpCuboGrafico})
        Me.rbcCubo.SelectedPage = Me.rpCuboGrafico
        Me.rbcCubo.Size = New System.Drawing.Size(819, 142)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnAlternarVisibilidad)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnCuboCustomizeFields, True)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnVistaPreviaCubo)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnExcelCubo)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnGuardarLayoutCubo)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnCargarLayoutCubo)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnColumnasCubo)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.popOrientacion, True)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnVerLeyendas)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnVerValores)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.popTipoGrafico)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnExcelGrafico, True)
        Me.rbcCubo.Toolbar.ItemLinks.Add(Me.btnImagenGrafico)
        Me.rbcCubo.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below
        '
        'btnCuboCustomizeFields
        '
        Me.btnCuboCustomizeFields.Caption = "Personalizar campos"
        Me.btnCuboCustomizeFields.Glyph = CType(resources.GetObject("btnCuboCustomizeFields.Glyph"), System.Drawing.Image)
        Me.btnCuboCustomizeFields.Id = 0
        Me.btnCuboCustomizeFields.LargeGlyph = CType(resources.GetObject("btnCuboCustomizeFields.LargeGlyph"), System.Drawing.Image)
        Me.btnCuboCustomizeFields.Name = "btnCuboCustomizeFields"
        '
        'btnVerEjeX
        '
        Me.btnVerEjeX.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnVerEjeX.Caption = "Eje X"
        Me.btnVerEjeX.Down = True
        Me.btnVerEjeX.Glyph = CType(resources.GetObject("btnVerEjeX.Glyph"), System.Drawing.Image)
        Me.btnVerEjeX.Id = 2
        Me.btnVerEjeX.Name = "btnVerEjeX"
        '
        'btnVerEjeY
        '
        Me.btnVerEjeY.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnVerEjeY.Caption = "Eje Y"
        Me.btnVerEjeY.Down = True
        Me.btnVerEjeY.Glyph = CType(resources.GetObject("btnVerEjeY.Glyph"), System.Drawing.Image)
        Me.btnVerEjeY.Id = 3
        Me.btnVerEjeY.Name = "btnVerEjeY"
        '
        'btnVerLeyendas
        '
        Me.btnVerLeyendas.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnVerLeyendas.Caption = "Leyendas"
        Me.btnVerLeyendas.Down = True
        Me.btnVerLeyendas.Glyph = CType(resources.GetObject("btnVerLeyendas.Glyph"), System.Drawing.Image)
        Me.btnVerLeyendas.Id = 4
        Me.btnVerLeyendas.LargeGlyph = CType(resources.GetObject("btnVerLeyendas.LargeGlyph"), System.Drawing.Image)
        Me.btnVerLeyendas.Name = "btnVerLeyendas"
        '
        'btnVerValores
        '
        Me.btnVerValores.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnVerValores.Caption = "Valores"
        Me.btnVerValores.Down = True
        Me.btnVerValores.Glyph = CType(resources.GetObject("btnVerValores.Glyph"), System.Drawing.Image)
        Me.btnVerValores.Id = 5
        Me.btnVerValores.LargeGlyph = CType(resources.GetObject("btnVerValores.LargeGlyph"), System.Drawing.Image)
        Me.btnVerValores.Name = "btnVerValores"
        '
        'popTipoGrafico
        '
        Me.popTipoGrafico.Caption = "Estilo"
        Me.popTipoGrafico.Glyph = CType(resources.GetObject("popTipoGrafico.Glyph"), System.Drawing.Image)
        Me.popTipoGrafico.Id = 6
        Me.popTipoGrafico.LargeGlyph = CType(resources.GetObject("popTipoGrafico.LargeGlyph"), System.Drawing.Image)
        Me.popTipoGrafico.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bsi2D), New DevExpress.XtraBars.LinkPersistInfo(Me.bsi3D)})
        Me.popTipoGrafico.Name = "popTipoGrafico"
        '
        'bsi2D
        '
        Me.bsi2D.Caption = "2D"
        Me.bsi2D.Id = 7
        Me.bsi2D.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPuntos2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLineas2D, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnStepLine2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSpline2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBarras2D, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBarrasApiladas2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnArea2D, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnStackedArea2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFullStackedArea2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSplineArea2D, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnStackedSplineArea2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFullStackedSplineArea2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRadarPoint2D, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRadarLine2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRadarArea2D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnTorta2D, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDoughnut2D)})
        Me.bsi2D.Name = "bsi2D"
        '
        'btnPuntos2D
        '
        Me.btnPuntos2D.Caption = "Puntos"
        Me.btnPuntos2D.Id = 9
        Me.btnPuntos2D.Name = "btnPuntos2D"
        '
        'btnLineas2D
        '
        Me.btnLineas2D.Caption = "Líneas"
        Me.btnLineas2D.Id = 10
        Me.btnLineas2D.Name = "btnLineas2D"
        '
        'btnStepLine2D
        '
        Me.btnStepLine2D.Caption = "Líneas - Histograma"
        Me.btnStepLine2D.Id = 36
        Me.btnStepLine2D.Name = "btnStepLine2D"
        '
        'btnSpline2D
        '
        Me.btnSpline2D.Caption = "Línea curvada"
        Me.btnSpline2D.Id = 37
        Me.btnSpline2D.Name = "btnSpline2D"
        '
        'btnBarras2D
        '
        Me.btnBarras2D.Caption = "Barras"
        Me.btnBarras2D.Id = 11
        Me.btnBarras2D.Name = "btnBarras2D"
        '
        'btnBarrasApiladas2D
        '
        Me.btnBarrasApiladas2D.Caption = "Barras apiladas"
        Me.btnBarrasApiladas2D.Id = 12
        Me.btnBarrasApiladas2D.Name = "btnBarrasApiladas2D"
        '
        'btnArea2D
        '
        Me.btnArea2D.Caption = "Área"
        Me.btnArea2D.Id = 13
        Me.btnArea2D.Name = "btnArea2D"
        '
        'btnStackedArea2D
        '
        Me.btnStackedArea2D.Caption = "Area apilada"
        Me.btnStackedArea2D.Id = 39
        Me.btnStackedArea2D.Name = "btnStackedArea2D"
        '
        'btnFullStackedArea2D
        '
        Me.btnFullStackedArea2D.Caption = "Area apilada completa"
        Me.btnFullStackedArea2D.Id = 41
        Me.btnFullStackedArea2D.Name = "btnFullStackedArea2D"
        '
        'btnSplineArea2D
        '
        Me.btnSplineArea2D.Caption = "Area curvada"
        Me.btnSplineArea2D.Id = 38
        Me.btnSplineArea2D.Name = "btnSplineArea2D"
        '
        'btnStackedSplineArea2D
        '
        Me.btnStackedSplineArea2D.Caption = "Area curvada apilada"
        Me.btnStackedSplineArea2D.Id = 40
        Me.btnStackedSplineArea2D.Name = "btnStackedSplineArea2D"
        '
        'btnFullStackedSplineArea2D
        '
        Me.btnFullStackedSplineArea2D.Caption = "Area curvada apilada completa"
        Me.btnFullStackedSplineArea2D.Id = 42
        Me.btnFullStackedSplineArea2D.Name = "btnFullStackedSplineArea2D"
        '
        'btnRadarPoint2D
        '
        Me.btnRadarPoint2D.Caption = "Radar - Puntos"
        Me.btnRadarPoint2D.Id = 43
        Me.btnRadarPoint2D.Name = "btnRadarPoint2D"
        '
        'btnRadarLine2D
        '
        Me.btnRadarLine2D.Caption = "Radar - Líneas"
        Me.btnRadarLine2D.Id = 44
        Me.btnRadarLine2D.Name = "btnRadarLine2D"
        '
        'btnRadarArea2D
        '
        Me.btnRadarArea2D.Caption = "Radar - Area"
        Me.btnRadarArea2D.Id = 45
        Me.btnRadarArea2D.Name = "btnRadarArea2D"
        '
        'btnTorta2D
        '
        Me.btnTorta2D.Caption = "Torta"
        Me.btnTorta2D.Id = 14
        Me.btnTorta2D.Name = "btnTorta2D"
        '
        'btnDoughnut2D
        '
        Me.btnDoughnut2D.Caption = "Dona"
        Me.btnDoughnut2D.Id = 46
        Me.btnDoughnut2D.Name = "btnDoughnut2D"
        '
        'bsi3D
        '
        Me.bsi3D.Caption = "3D"
        Me.bsi3D.Id = 8
        Me.bsi3D.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPuntos3D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLineas3D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBarras3D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBarrasApiladas3D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnArea3D), New DevExpress.XtraBars.LinkPersistInfo(Me.btnTorta3D)})
        Me.bsi3D.Name = "bsi3D"
        '
        'btnPuntos3D
        '
        Me.btnPuntos3D.Caption = "Puntos"
        Me.btnPuntos3D.Id = 15
        Me.btnPuntos3D.Name = "btnPuntos3D"
        Me.btnPuntos3D.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnLineas3D
        '
        Me.btnLineas3D.Caption = "Líneas"
        Me.btnLineas3D.Id = 16
        Me.btnLineas3D.Name = "btnLineas3D"
        '
        'btnBarras3D
        '
        Me.btnBarras3D.Caption = "Barras"
        Me.btnBarras3D.Id = 17
        Me.btnBarras3D.Name = "btnBarras3D"
        '
        'btnBarrasApiladas3D
        '
        Me.btnBarrasApiladas3D.Caption = "Barras apiladas"
        Me.btnBarrasApiladas3D.Id = 18
        Me.btnBarrasApiladas3D.Name = "btnBarrasApiladas3D"
        Me.btnBarrasApiladas3D.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnArea3D
        '
        Me.btnArea3D.Caption = "Área"
        Me.btnArea3D.Id = 19
        Me.btnArea3D.Name = "btnArea3D"
        '
        'btnTorta3D
        '
        Me.btnTorta3D.Caption = "Torta"
        Me.btnTorta3D.Id = 20
        Me.btnTorta3D.Name = "btnTorta3D"
        '
        'popOrientacion
        '
        Me.popOrientacion.Caption = "Orientación"
        Me.popOrientacion.Glyph = CType(resources.GetObject("popOrientacion.Glyph"), System.Drawing.Image)
        Me.popOrientacion.Id = 21
        Me.popOrientacion.LargeGlyph = CType(resources.GetObject("popOrientacion.LargeGlyph"), System.Drawing.Image)
        Me.popOrientacion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnOrientacionVertical), New DevExpress.XtraBars.LinkPersistInfo(Me.btnOrientacionHorizontal)})
        Me.popOrientacion.Name = "popOrientacion"
        '
        'btnOrientacionVertical
        '
        Me.btnOrientacionVertical.Caption = "Vertical"
        Me.btnOrientacionVertical.Id = 22
        Me.btnOrientacionVertical.Name = "btnOrientacionVertical"
        '
        'btnOrientacionHorizontal
        '
        Me.btnOrientacionHorizontal.Caption = "Horizontal"
        Me.btnOrientacionHorizontal.Id = 23
        Me.btnOrientacionHorizontal.Name = "btnOrientacionHorizontal"
        '
        'btnGuardarLayoutCubo
        '
        Me.btnGuardarLayoutCubo.Caption = "Guardar diseño"
        Me.btnGuardarLayoutCubo.Glyph = CType(resources.GetObject("btnGuardarLayoutCubo.Glyph"), System.Drawing.Image)
        Me.btnGuardarLayoutCubo.Id = 24
        Me.btnGuardarLayoutCubo.LargeGlyph = CType(resources.GetObject("btnGuardarLayoutCubo.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardarLayoutCubo.Name = "btnGuardarLayoutCubo"
        '
        'btnVistaPreviaCubo
        '
        Me.btnVistaPreviaCubo.Caption = "Vista previa"
        Me.btnVistaPreviaCubo.Glyph = CType(resources.GetObject("btnVistaPreviaCubo.Glyph"), System.Drawing.Image)
        Me.btnVistaPreviaCubo.Id = 25
        Me.btnVistaPreviaCubo.LargeGlyph = CType(resources.GetObject("btnVistaPreviaCubo.LargeGlyph"), System.Drawing.Image)
        Me.btnVistaPreviaCubo.Name = "btnVistaPreviaCubo"
        '
        'btnImprimirCubo
        '
        Me.btnImprimirCubo.Caption = "Imprimir"
        Me.btnImprimirCubo.Glyph = CType(resources.GetObject("btnImprimirCubo.Glyph"), System.Drawing.Image)
        Me.btnImprimirCubo.Id = 26
        Me.btnImprimirCubo.LargeGlyph = CType(resources.GetObject("btnImprimirCubo.LargeGlyph"), System.Drawing.Image)
        Me.btnImprimirCubo.Name = "btnImprimirCubo"
        Me.btnImprimirCubo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnExcelCubo
        '
        Me.btnExcelCubo.Caption = "Excel"
        Me.btnExcelCubo.Glyph = CType(resources.GetObject("btnExcelCubo.Glyph"), System.Drawing.Image)
        Me.btnExcelCubo.Id = 27
        Me.btnExcelCubo.LargeGlyph = CType(resources.GetObject("btnExcelCubo.LargeGlyph"), System.Drawing.Image)
        Me.btnExcelCubo.Name = "btnExcelCubo"
        '
        'btnAlternarVisibilidad
        '
        Me.btnAlternarVisibilidad.Caption = "Alternar"
        Me.btnAlternarVisibilidad.Glyph = CType(resources.GetObject("btnAlternarVisibilidad.Glyph"), System.Drawing.Image)
        Me.btnAlternarVisibilidad.Id = 28
        Me.btnAlternarVisibilidad.LargeGlyph = CType(resources.GetObject("btnAlternarVisibilidad.LargeGlyph"), System.Drawing.Image)
        Me.btnAlternarVisibilidad.Name = "btnAlternarVisibilidad"
        '
        'btnExcelGrafico
        '
        Me.btnExcelGrafico.Caption = "Excel"
        Me.btnExcelGrafico.Glyph = CType(resources.GetObject("btnExcelGrafico.Glyph"), System.Drawing.Image)
        Me.btnExcelGrafico.Id = 29
        Me.btnExcelGrafico.LargeGlyph = CType(resources.GetObject("btnExcelGrafico.LargeGlyph"), System.Drawing.Image)
        Me.btnExcelGrafico.Name = "btnExcelGrafico"
        '
        'btnImagenGrafico
        '
        Me.btnImagenGrafico.Caption = "Imagen"
        Me.btnImagenGrafico.Glyph = CType(resources.GetObject("btnImagenGrafico.Glyph"), System.Drawing.Image)
        Me.btnImagenGrafico.Id = 30
        Me.btnImagenGrafico.LargeGlyph = CType(resources.GetObject("btnImagenGrafico.LargeGlyph"), System.Drawing.Image)
        Me.btnImagenGrafico.Name = "btnImagenGrafico"
        '
        'btnVistaPreviaGrafico
        '
        Me.btnVistaPreviaGrafico.Caption = "Vista previa"
        Me.btnVistaPreviaGrafico.Glyph = CType(resources.GetObject("btnVistaPreviaGrafico.Glyph"), System.Drawing.Image)
        Me.btnVistaPreviaGrafico.Id = 31
        Me.btnVistaPreviaGrafico.LargeGlyph = CType(resources.GetObject("btnVistaPreviaGrafico.LargeGlyph"), System.Drawing.Image)
        Me.btnVistaPreviaGrafico.Name = "btnVistaPreviaGrafico"
        '
        'btnRotado
        '
        Me.btnRotado.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnRotado.Caption = "Rotado"
        Me.btnRotado.Glyph = CType(resources.GetObject("btnRotado.Glyph"), System.Drawing.Image)
        Me.btnRotado.Id = 33
        Me.btnRotado.LargeGlyph = CType(resources.GetObject("btnRotado.LargeGlyph"), System.Drawing.Image)
        Me.btnRotado.Name = "btnRotado"
        '
        'btnColumnasCubo
        '
        Me.btnColumnasCubo.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnColumnasCubo.Caption = "Columnas"
        Me.btnColumnasCubo.Glyph = CType(resources.GetObject("btnColumnasCubo.Glyph"), System.Drawing.Image)
        Me.btnColumnasCubo.Id = 34
        Me.btnColumnasCubo.LargeGlyph = CType(resources.GetObject("btnColumnasCubo.LargeGlyph"), System.Drawing.Image)
        Me.btnColumnasCubo.Name = "btnColumnasCubo"
        '
        'btnCargarLayoutCubo
        '
        Me.btnCargarLayoutCubo.Caption = "Cargar diseño"
        Me.btnCargarLayoutCubo.Glyph = CType(resources.GetObject("btnCargarLayoutCubo.Glyph"), System.Drawing.Image)
        Me.btnCargarLayoutCubo.Id = 35
        Me.btnCargarLayoutCubo.LargeGlyph = CType(resources.GetObject("btnCargarLayoutCubo.LargeGlyph"), System.Drawing.Image)
        Me.btnCargarLayoutCubo.Name = "btnCargarLayoutCubo"
        '
        'rpCuboGrafico
        '
        Me.rpCuboGrafico.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgComun, Me.rpgCubo, Me.rpgGrafico})
        Me.rpCuboGrafico.KeyTip = ""
        Me.rpCuboGrafico.Name = "rpCuboGrafico"
        Me.rpCuboGrafico.Text = "Opciones del gráfico y la tabla dinámica"
        '
        'rpgComun
        '
        Me.rpgComun.ItemLinks.Add(Me.btnAlternarVisibilidad)
        Me.rpgComun.KeyTip = ""
        Me.rpgComun.Name = "rpgComun"
        Me.rpgComun.ShowCaptionButton = False
        Me.rpgComun.Text = "Visibilidad"
        '
        'rpgCubo
        '
        Me.rpgCubo.ItemLinks.Add(Me.btnCuboCustomizeFields)
        Me.rpgCubo.ItemLinks.Add(Me.btnVistaPreviaCubo, True)
        Me.rpgCubo.ItemLinks.Add(Me.btnImprimirCubo)
        Me.rpgCubo.ItemLinks.Add(Me.btnExcelCubo)
        Me.rpgCubo.ItemLinks.Add(Me.btnColumnasCubo, True)
        Me.rpgCubo.ItemLinks.Add(Me.btnGuardarLayoutCubo)
        Me.rpgCubo.ItemLinks.Add(Me.btnCargarLayoutCubo)
        Me.rpgCubo.KeyTip = ""
        Me.rpgCubo.Name = "rpgCubo"
        Me.rpgCubo.ShowCaptionButton = False
        Me.rpgCubo.Text = "Tabla dinámica"
        '
        'rpgGrafico
        '
        Me.rpgGrafico.ItemLinks.Add(Me.btnVistaPreviaGrafico)
        Me.rpgGrafico.ItemLinks.Add(Me.popOrientacion)
        Me.rpgGrafico.ItemLinks.Add(Me.btnVerEjeX, True)
        Me.rpgGrafico.ItemLinks.Add(Me.btnVerEjeY)
        Me.rpgGrafico.ItemLinks.Add(Me.btnVerLeyendas)
        Me.rpgGrafico.ItemLinks.Add(Me.btnVerValores)
        Me.rpgGrafico.ItemLinks.Add(Me.btnRotado)
        Me.rpgGrafico.ItemLinks.Add(Me.popTipoGrafico, True)
        Me.rpgGrafico.ItemLinks.Add(Me.btnExcelGrafico, True)
        Me.rpgGrafico.ItemLinks.Add(Me.btnImagenGrafico)
        Me.rpgGrafico.KeyTip = ""
        Me.rpgGrafico.Name = "rpgGrafico"
        Me.rpgGrafico.ShowCaptionButton = False
        Me.rpgGrafico.Text = "Gráfico"
        '
        'oSplitter
        '
        Me.oSplitter.Dock = System.Windows.Forms.DockStyle.Top
        Me.oSplitter.Horizontal = False
        Me.oSplitter.Location = New System.Drawing.Point(0, 0)
        Me.oSplitter.Name = "oSplitter"
        Me.oSplitter.Panel1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oSplitter.Panel1.AppearanceCaption.Options.UseFont = True
        Me.oSplitter.Panel1.Controls.Add(Me.pgCubo)
        Me.oSplitter.Panel1.ShowCaption = True
        Me.oSplitter.Panel1.Text = "Tabla dinámica"
        Me.oSplitter.Panel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oSplitter.Panel2.Appearance.Options.UseFont = True
        Me.oSplitter.Panel2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oSplitter.Panel2.AppearanceCaption.Options.UseFont = True
        Me.oSplitter.Panel2.Controls.Add(Me.chrGrafico)
        Me.oSplitter.Panel2.ShowCaption = True
        Me.oSplitter.Panel2.Text = "Gráfico"
        Me.oSplitter.Size = New System.Drawing.Size(819, 332)
        Me.oSplitter.SplitterPosition = 213
        Me.oSplitter.TabIndex = 2
        '
        'pgCubo
        '
        Me.pgCubo.Cursor = System.Windows.Forms.Cursors.Default
        Me.pgCubo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgCubo.Location = New System.Drawing.Point(0, 0)
        Me.pgCubo.MenuManager = Me.rbcCubo
        Me.pgCubo.Name = "pgCubo"
        Me.pgCubo.OptionsLayout.Columns.StoreAllOptions = True
        Me.pgCubo.OptionsLayout.Columns.StoreAppearance = True
        Me.pgCubo.OptionsLayout.StoreAllOptions = True
        Me.pgCubo.OptionsLayout.StoreAppearance = True
        Me.pgCubo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.pgCubo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riProgressBar})
        Me.pgCubo.Size = New System.Drawing.Size(815, 191)
        Me.pgCubo.TabIndex = 1
        '
        'riProgressBar
        '
        Me.riProgressBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.riProgressBar.Name = "riProgressBar"
        Me.riProgressBar.ShowTitle = True
        '
        'chrGrafico
        '
        Me.chrGrafico.AppearanceName = "Terracotta Pie"
        Me.chrGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chrGrafico.Location = New System.Drawing.Point(0, 0)
        Me.chrGrafico.Name = "chrGrafico"
        Me.chrGrafico.RuntimeSelection = True
        Me.chrGrafico.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.chrGrafico.Size = New System.Drawing.Size(815, 91)
        Me.chrGrafico.TabIndex = 3
        '
        'tpReporte
        '
        Me.tpReporte.Controls.Add(Me.cmdCargarDesdeArchivo)
        Me.tpReporte.Controls.Add(Me.cmdEliminarReporte)
        Me.tpReporte.Controls.Add(Me.cmdDisenarReporte)
        Me.tpReporte.Controls.Add(Me.cmdAbrirReporte)
        Me.tpReporte.Controls.Add(Me.pc001)
        Me.tpReporte.Controls.Add(Me.cmdNuevoReporte)
        Me.tpReporte.Image = CType(resources.GetObject("tpReporte.Image"), System.Drawing.Image)
        Me.tpReporte.Name = "tpReporte"
        Me.tpReporte.PageEnabled = False
        Me.tpReporte.Size = New System.Drawing.Size(819, 463)
        Me.tpReporte.Text = "Informes"
        '
        'cmdCargarDesdeArchivo
        '
        Me.cmdCargarDesdeArchivo.Appearance.Options.UseTextOptions = True
        Me.cmdCargarDesdeArchivo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdCargarDesdeArchivo.Image = CType(resources.GetObject("cmdCargarDesdeArchivo.Image"), System.Drawing.Image)
        Me.cmdCargarDesdeArchivo.Location = New System.Drawing.Point(565, 6)
        Me.cmdCargarDesdeArchivo.Name = "cmdCargarDesdeArchivo"
        Me.cmdCargarDesdeArchivo.Size = New System.Drawing.Size(133, 34)
        Me.cmdCargarDesdeArchivo.TabIndex = 18
        Me.cmdCargarDesdeArchivo.Text = "Cargar desde archivo..."
        '
        'cmdEliminarReporte
        '
        Me.cmdEliminarReporte.Appearance.Options.UseTextOptions = True
        Me.cmdEliminarReporte.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEliminarReporte.Image = CType(resources.GetObject("cmdEliminarReporte.Image"), System.Drawing.Image)
        Me.cmdEliminarReporte.Location = New System.Drawing.Point(426, 6)
        Me.cmdEliminarReporte.Name = "cmdEliminarReporte"
        Me.cmdEliminarReporte.Size = New System.Drawing.Size(133, 34)
        Me.cmdEliminarReporte.TabIndex = 17
        Me.cmdEliminarReporte.Text = "Eliminar informe seleccionado"
        '
        'cmdDisenarReporte
        '
        Me.cmdDisenarReporte.Appearance.Options.UseTextOptions = True
        Me.cmdDisenarReporte.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdDisenarReporte.Image = CType(resources.GetObject("cmdDisenarReporte.Image"), System.Drawing.Image)
        Me.cmdDisenarReporte.Location = New System.Drawing.Point(287, 6)
        Me.cmdDisenarReporte.Name = "cmdDisenarReporte"
        Me.cmdDisenarReporte.Size = New System.Drawing.Size(133, 34)
        Me.cmdDisenarReporte.TabIndex = 16
        Me.cmdDisenarReporte.Text = "Diseñar informe seleccionado"
        '
        'cmdAbrirReporte
        '
        Me.cmdAbrirReporte.Appearance.Options.UseTextOptions = True
        Me.cmdAbrirReporte.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAbrirReporte.Image = CType(resources.GetObject("cmdAbrirReporte.Image"), System.Drawing.Image)
        Me.cmdAbrirReporte.Location = New System.Drawing.Point(148, 6)
        Me.cmdAbrirReporte.Name = "cmdAbrirReporte"
        Me.cmdAbrirReporte.Size = New System.Drawing.Size(133, 34)
        Me.cmdAbrirReporte.TabIndex = 15
        Me.cmdAbrirReporte.Text = "Abrir informe seleccionado"
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.lvReportes)
        Me.pc001.Location = New System.Drawing.Point(9, 49)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(550, 318)
        Me.pc001.TabIndex = 14
        '
        'lvReportes
        '
        Me.lvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvReportes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002})
        Me.lvReportes.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Informes propios de esta consulta"
        ListViewGroup1.Name = "lvg001"
        ListViewGroup2.Header = "Informes de esta consulta compartidos con otros usuarios"
        ListViewGroup2.Name = "lvg002"
        Me.lvReportes.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvReportes.HideSelection = False
        Me.lvReportes.LargeImageList = Me.il32x32
        Me.lvReportes.Location = New System.Drawing.Point(2, 2)
        Me.lvReportes.MultiSelect = False
        Me.lvReportes.Name = "lvReportes"
        Me.lvReportes.Size = New System.Drawing.Size(546, 314)
        Me.lvReportes.TabIndex = 6
        Me.lvReportes.TileSize = New System.Drawing.Size(600, 35)
        Me.lvReportes.UseCompatibleStateImageBehavior = False
        Me.lvReportes.View = System.Windows.Forms.View.Tile
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "ReporteDiseno.png")
        Me.il32x32.Images.SetKeyName(1, "ReportePublico.png")
        '
        'cmdNuevoReporte
        '
        Me.cmdNuevoReporte.Appearance.Options.UseTextOptions = True
        Me.cmdNuevoReporte.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdNuevoReporte.Image = CType(resources.GetObject("cmdNuevoReporte.Image"), System.Drawing.Image)
        Me.cmdNuevoReporte.Location = New System.Drawing.Point(9, 6)
        Me.cmdNuevoReporte.Name = "cmdNuevoReporte"
        Me.cmdNuevoReporte.Size = New System.Drawing.Size(133, 34)
        Me.cmdNuevoReporte.TabIndex = 13
        Me.cmdNuevoReporte.Text = "Nuevo informe"
        '
        'popResultados
        '
        Me.popResultados.Name = "popResultados"
        '
        'popContextReportes
        '
        Me.popContextReportes.ItemLinks.Add(Me.mnuContextNuevoReporte)
        Me.popContextReportes.ItemLinks.Add(Me.mnuContextAbrirReporte, True)
        Me.popContextReportes.ItemLinks.Add(Me.mnuContextDisenarReporte)
        Me.popContextReportes.ItemLinks.Add(Me.mnuContextEliminarReporte)
        Me.popContextReportes.ItemLinks.Add(Me.mnuContextCargarDesdeArchivo, True)
        Me.popContextReportes.Name = "popContextReportes"
        Me.popContextReportes.Ribbon = Me.rbcMain
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 496)
        Me.Controls.Add(Me.Tabs)
        Me.Name = "frmConsulta"
        Me.Text = "Consulta"
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.tpParametros.ResumeLayout(False)
        Me.tpParametros.PerformLayout()
        CType(Me.GridParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpResultados.ResumeLayout(False)
        Me.tpCubo.ResumeLayout(False)
        CType(Me.oSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitter.ResumeLayout(False)
        CType(Me.pgCubo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReporte.ResumeLayout(False)
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        CType(Me.popResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popContextReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpParametros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdEjecutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridParametros As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents catRow As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents tpResultados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rbcMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents popConjuntos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnResults000 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVistaPrevia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnHTML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpOpciones As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgConjuntos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgImpresion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgExportacion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgOtros As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tpCubo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents oSplitter As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents pgCubo As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents chrGrafico As DevExpress.XtraCharts.ChartControl
    Friend WithEvents popResultados As DevExpress.XtraBars.PopupMenu
    Friend WithEvents rbcCubo As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rpCuboGrafico As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgCubo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgGrafico As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnGuardarLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAutofiltro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFilasSubtotales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFilaTotales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGroupByBox As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCuboCustomizeFields As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerEjeX As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerEjeY As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerLeyendas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerValores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popTipoGrafico As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bsi2D As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnPuntos2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLineas2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBarras2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBarrasApiladas2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnArea2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTorta2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsi3D As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnPuntos3D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLineas3D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBarras3D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBarrasApiladas3D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnArea3D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTorta3D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popOrientacion As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnOrientacionVertical As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOrientacionHorizontal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardarLayoutCubo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVistaPreviaCubo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImprimirCubo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcelCubo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnColumnas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgComun As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAlternarVisibilidad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcelGrafico As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImagenGrafico As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVistaPreviaGrafico As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRotado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnColumnasCubo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblTituloDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblTituloConexion As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblConexion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tpReporte As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdNuevoReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lvReportes As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents cmdDisenarReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAbrirReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminarReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents popContextReportes As DevExpress.XtraBars.PopupMenu
    Friend WithEvents mnuContextNuevoReporte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuContextAbrirReporte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuContextDisenarReporte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuContextEliminarReporte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuContextCargarDesdeArchivo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCargarDesdeArchivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCargarLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCargarLayoutCubo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnStepLine2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSpline2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnStackedArea2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFullStackedArea2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSplineArea2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnStackedSplineArea2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFullStackedSplineArea2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRadarPoint2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRadarLine2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRadarArea2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDoughnut2D As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents riProgressBar As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
End Class
