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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrillDown))
        Me.PanTop = New DevExpress.XtraEditors.PanelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.cmdImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.cmdGuardarLaoyut = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTop.SuspendLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanTop.Size = New System.Drawing.Size(598, 54)
        Me.PanTop.TabIndex = 16
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(56, 13)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Drill Down"
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.picLogo.EditValue = Global.VBP04295.My.Resources.Resources.Grid_2
        Me.picLogo.Location = New System.Drawing.Point(537, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Properties.Appearance.Options.UseBackColor = True
        Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picLogo.Size = New System.Drawing.Size(59, 50)
        Me.picLogo.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Grid)
        Me.PanelControl1.Controls.Add(Me.StandaloneBarDockControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 54)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(598, 384)
        Me.PanelControl1.TabIndex = 24
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.CausesValidation = False
        Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(2, 2)
        Me.StandaloneBarDockControl1.Manager = Me.BarManager1
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(594, 35)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdImprimir, Me.cmdGuardar, Me.cmdCerrar, Me.cmdGuardarLaoyut})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarItemHorzIndent = 18
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Standalone
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.FloatLocation = New System.Drawing.Point(209, 259)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdGuardarLaoyut), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdCerrar)})
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.StandaloneBarDockControl = Me.StandaloneBarDockControl1
        Me.Bar1.Text = "Herramientas"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdImprimir.Caption = "Imprimir"
        Me.cmdImprimir.Id = 0
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageOptions.LargeImage = CType(resources.GetObject("cmdImprimir.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdGuardar.Caption = "Exportar"
        Me.cmdGuardar.Id = 1
        Me.cmdGuardar.ImageOptions.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageOptions.LargeImage = CType(resources.GetObject("cmdGuardar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCerrar.Caption = "Cerrar"
        Me.cmdCerrar.Id = 2
        Me.cmdCerrar.ImageOptions.Image = CType(resources.GetObject("cmdCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageOptions.LargeImage = CType(resources.GetObject("cmdCerrar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(598, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 438)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(598, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 438)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(598, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 438)
        '
        'Grid
        '
        Me.Grid.AllowDrop = True
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(2, 37)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.Grid.LookAndFeel.UseWindowsXPTheme = True
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(594, 345)
        Me.Grid.TabIndex = 7
        Me.Grid.UseEmbeddedNavigator = True
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsLayout.Columns.StoreAllOptions = True
        Me.GridView1.OptionsLayout.Columns.StoreAppearance = True
        Me.GridView1.OptionsLayout.StoreAllOptions = True
        Me.GridView1.OptionsLayout.StoreAppearance = True
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.PaintStyleName = "WindowsXP"
        Me.GridView1.RowHeight = 19
        '
        'Bar4
        '
        Me.Bar4.BarName = "Personalizada 5"
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.FloatLocation = New System.Drawing.Point(68, 140)
        Me.Bar4.Offset = 25
        Me.Bar4.Text = "Personalizada 5"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.Location = New System.Drawing.Point(24, 28)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(47, 13)
        Me.lblSubtitulo.TabIndex = 2
        Me.lblSubtitulo.Text = "Drill Down"
        '
        'cmdGuardarLaoyut
        '
        Me.cmdGuardarLaoyut.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdGuardarLaoyut.Caption = "Guardar Layout"
        Me.cmdGuardarLaoyut.Id = 4
        Me.cmdGuardarLaoyut.ImageOptions.Image = CType(resources.GetObject("cmdGuardarLaoyut.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardarLaoyut.ImageOptions.LargeImage = CType(resources.GetObject("cmdGuardarLaoyut.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cmdGuardarLaoyut.Name = "cmdGuardarLaoyut"
        Me.cmdGuardarLaoyut.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'frmDrillDown
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 461)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanTop)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDrillDown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drill Down"
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdGuardarLaoyut As DevExpress.XtraBars.BarButtonItem
End Class
