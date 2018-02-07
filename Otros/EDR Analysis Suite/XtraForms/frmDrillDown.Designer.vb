<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrillDown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrillDown))
        Me.rbcMain = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.btnVistaPrevia = New DevExpress.XtraBars.BarButtonItem
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem
        Me.btnPDF = New DevExpress.XtraBars.BarButtonItem
        Me.btnXML = New DevExpress.XtraBars.BarButtonItem
        Me.btnResults000 = New DevExpress.XtraBars.BarButtonItem
        Me.btnHTML = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalir = New DevExpress.XtraBars.BarButtonItem
        Me.rpOpciones = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgImpresion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgExportacion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgOtros = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.GridResultados = New DevExpress.XtraGrid.GridControl
        Me.gvwResultados = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbcMain
        '
        Me.rbcMain.ApplicationButtonKeyTip = ""
        Me.rbcMain.ApplicationIcon = Nothing
        Me.rbcMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnVistaPrevia, Me.btnImprimir, Me.btnExcel, Me.btnPDF, Me.btnXML, Me.btnResults000, Me.btnHTML, Me.btnSalir})
        Me.rbcMain.Location = New System.Drawing.Point(0, 0)
        Me.rbcMain.MaxItemId = 18
        Me.rbcMain.Name = "rbcMain"
        Me.rbcMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpOpciones})
        Me.rbcMain.SelectedPage = Me.rpOpciones
        Me.rbcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.rbcMain.ShowToolbarCustomizeItem = False
        Me.rbcMain.Size = New System.Drawing.Size(687, 146)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnVistaPrevia, True)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnImprimir)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnExcel, True)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnHTML)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnPDF)
        Me.rbcMain.Toolbar.ItemLinks.Add(Me.btnSalir, True)
        Me.rbcMain.Toolbar.ShowCustomizeItem = False
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
        Me.btnImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        'btnXML
        '
        Me.btnXML.Caption = "&XML"
        Me.btnXML.Glyph = CType(resources.GetObject("btnXML.Glyph"), System.Drawing.Image)
        Me.btnXML.Id = 9
        Me.btnXML.LargeGlyph = CType(resources.GetObject("btnXML.LargeGlyph"), System.Drawing.Image)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnResults000
        '
        Me.btnResults000.Caption = "(Predeterminado)"
        Me.btnResults000.Id = 10
        Me.btnResults000.Name = "btnResults000"
        '
        'btnHTML
        '
        Me.btnHTML.Caption = "Página web"
        Me.btnHTML.Glyph = CType(resources.GetObject("btnHTML.Glyph"), System.Drawing.Image)
        Me.btnHTML.Id = 11
        Me.btnHTML.LargeGlyph = CType(resources.GetObject("btnHTML.LargeGlyph"), System.Drawing.Image)
        Me.btnHTML.Name = "btnHTML"
        '
        'btnSalir
        '
        Me.btnSalir.Caption = "Cerrar"
        Me.btnSalir.Glyph = CType(resources.GetObject("btnSalir.Glyph"), System.Drawing.Image)
        Me.btnSalir.Id = 17
        Me.btnSalir.LargeGlyph = CType(resources.GetObject("btnSalir.LargeGlyph"), System.Drawing.Image)
        Me.btnSalir.Name = "btnSalir"
        '
        'rpOpciones
        '
        Me.rpOpciones.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgImpresion, Me.rpgExportacion, Me.rpgOtros})
        Me.rpOpciones.KeyTip = ""
        Me.rpOpciones.Name = "rpOpciones"
        Me.rpOpciones.Text = "Opciones de los resultados"
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
        Me.rpgExportacion.ItemLinks.Add(Me.btnXML)
        Me.rpgExportacion.KeyTip = ""
        Me.rpgExportacion.Name = "rpgExportacion"
        Me.rpgExportacion.ShowCaptionButton = False
        Me.rpgExportacion.Text = "Exportación"
        '
        'rpgOtros
        '
        Me.rpgOtros.ItemLinks.Add(Me.btnSalir, True)
        Me.rpgOtros.KeyTip = ""
        Me.rpgOtros.Name = "rpgOtros"
        Me.rpgOtros.ShowCaptionButton = False
        Me.rpgOtros.Text = "Otras opciones"
        '
        'GridResultados
        '
        Me.GridResultados.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridResultados.EmbeddedNavigator.Name = ""
        Me.GridResultados.Location = New System.Drawing.Point(0, 146)
        Me.GridResultados.MainView = Me.gvwResultados
        Me.GridResultados.MenuManager = Me.rbcMain
        Me.GridResultados.Name = "GridResultados"
        Me.GridResultados.ServerMode = True
        Me.GridResultados.Size = New System.Drawing.Size(687, 261)
        Me.GridResultados.TabIndex = 8
        Me.GridResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwResultados})
        '
        'gvwResultados
        '
        Me.gvwResultados.BestFitMaxRowCount = 100
        Me.gvwResultados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvwResultados.GridControl = Me.GridResultados
        Me.gvwResultados.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.gvwResultados.Name = "gvwResultados"
        Me.gvwResultados.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvwResultados.OptionsBehavior.Editable = False
        Me.gvwResultados.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gvwResultados.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvwResultados.OptionsView.ColumnAutoWidth = False
        Me.gvwResultados.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gvwResultados.OptionsView.ShowAutoFilterRow = True
        Me.gvwResultados.OptionsView.ShowFooter = True
        '
        'frmDrillDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 485)
        Me.Controls.Add(Me.GridResultados)
        Me.Controls.Add(Me.rbcMain)
        Me.MinimizeBox = False
        Me.Name = "frmDrillDown"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drill Down"
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbcMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnVistaPrevia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnXML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnResults000 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnHTML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpOpciones As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgImpresion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgExportacion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgOtros As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwResultados As DevExpress.XtraGrid.Views.Grid.GridView
End Class
