<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
   Inherits System.Windows.Forms.Form

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.Skin = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
		Me.PanControles = New DevExpress.XtraEditors.PanelControl()
		Me.PanTop = New DevExpress.XtraEditors.PanelControl()
		Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
		Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
		Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
		Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
		Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
		Me.Grid = New DevExpress.XtraGrid.GridControl()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.PanGrid = New DevExpress.XtraEditors.PanelControl()
		Me.PanGrilla = New DevExpress.XtraEditors.PanelControl()
		Me.PanTool = New DevExpress.XtraEditors.PanelControl()
		Me.ToolBarra = New System.Windows.Forms.ToolStrip()
		Me.btnAlta = New System.Windows.Forms.ToolStripButton()
		Me.btnModif = New System.Windows.Forms.ToolStripButton()
		Me.btnBaja = New System.Windows.Forms.ToolStripButton()
		Me.btnNDesde = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnMostrarBuscador = New System.Windows.Forms.ToolStripButton()
		Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
		Me.btnExportar = New System.Windows.Forms.ToolStripButton()
		Me.btnCopiar = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnDrillDown = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnComent = New System.Windows.Forms.ToolStripButton()
		Me.btnAdjuntarArchivo = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnEjecutar = New System.Windows.Forms.ToolStripButton()
		Me.ToolTipText = New System.Windows.Forms.ToolTip(Me.components)
		CType(Me.PanControles, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanControles.SuspendLayout()
		CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanTop.SuspendLayout()
		CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.PanControles.Controls.Add(Me.PanTop)
		Me.PanControles.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanControles.Location = New System.Drawing.Point(0, 0)
		Me.PanControles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PanControles.Name = "PanControles"
		Me.PanControles.Size = New System.Drawing.Size(847, 134)
		Me.PanControles.TabIndex = 0
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
		Me.PanTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PanTop.Name = "PanTop"
		Me.PanTop.Size = New System.Drawing.Size(847, 66)
		Me.PanTop.TabIndex = 6
		'
		'lblSubtitulo
		'
		Me.lblSubtitulo.Location = New System.Drawing.Point(45, 36)
		Me.lblSubtitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lblSubtitulo.Name = "lblSubtitulo"
		Me.lblSubtitulo.Size = New System.Drawing.Size(0, 16)
		Me.lblSubtitulo.TabIndex = 2
		'
		'lblTitulo
		'
		Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.lblTitulo.Appearance.Options.UseFont = True
		Me.lblTitulo.Location = New System.Drawing.Point(16, 11)
		Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(0, 17)
		Me.lblTitulo.TabIndex = 1
		'
		'picLogo
		'
		Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
		Me.picLogo.EditValue = Global.VBP04295.My.Resources.Resources.logo_prex
		Me.picLogo.Location = New System.Drawing.Point(766, 2)
		Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.picLogo.Name = "picLogo"
		Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
		Me.picLogo.Properties.Appearance.Options.UseBackColor = True
		Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.picLogo.Size = New System.Drawing.Size(79, 62)
		Me.picLogo.TabIndex = 0
		'
		'PrintingSystem1
		'
		Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
		'
		'PrintableComponentLink1
		'
		Me.PrintableComponentLink1.Component = Me.Grid
		Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
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
		Me.Grid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Grid.Location = New System.Drawing.Point(0, 0)
		Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
		Me.Grid.LookAndFeel.UseWindowsXPTheme = True
		Me.Grid.MainView = Me.GridView1
		Me.Grid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Grid.Name = "Grid"
		Me.Grid.Size = New System.Drawing.Size(847, 359)
		Me.Grid.TabIndex = 6
		Me.Grid.UseEmbeddedNavigator = True
		Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
		'
		'GridView1
		'
		Me.GridView1.AppearancePrint.FooterPanel.Options.UseTextOptions = True
		Me.GridView1.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.GridView1.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
		Me.GridView1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.GridView1.AppearancePrint.HeaderPanel.Options.UseFont = True
		Me.GridView1.GridControl = Me.Grid
		Me.GridView1.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsBehavior.AutoPopulateColumns = False
		Me.GridView1.OptionsBehavior.Editable = False
		Me.GridView1.OptionsFilter.AllowFilterEditor = False
		Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
		Me.GridView1.OptionsView.ColumnAutoWidth = False
		Me.GridView1.OptionsView.ShowFooter = True
		Me.GridView1.OptionsView.ShowGroupedColumns = True
		Me.GridView1.PaintStyleName = "WindowsXP"
		Me.GridView1.RowHeight = 19
		'
		'PanGrid
		'
		Me.PanGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.PanGrid.Controls.Add(Me.PanGrilla)
		Me.PanGrid.Controls.Add(Me.PanTool)
		Me.PanGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanGrid.Location = New System.Drawing.Point(0, 134)
		Me.PanGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PanGrid.Name = "PanGrid"
		Me.PanGrid.Size = New System.Drawing.Size(847, 395)
		Me.PanGrid.TabIndex = 3
		'
		'PanGrilla
		'
		Me.PanGrilla.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.PanGrilla.Controls.Add(Me.Grid)
		Me.PanGrilla.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanGrilla.Location = New System.Drawing.Point(0, 36)
		Me.PanGrilla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PanGrilla.Name = "PanGrilla"
		Me.PanGrilla.Size = New System.Drawing.Size(847, 359)
		Me.PanGrilla.TabIndex = 1
		'
		'PanTool
		'
		Me.PanTool.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.PanTool.Controls.Add(Me.ToolBarra)
		Me.PanTool.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanTool.Location = New System.Drawing.Point(0, 0)
		Me.PanTool.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PanTool.Name = "PanTool"
		Me.PanTool.Size = New System.Drawing.Size(847, 36)
		Me.PanTool.TabIndex = 0
		'
		'ToolBarra
		'
		Me.ToolBarra.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolBarra.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ToolBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAlta, Me.btnModif, Me.btnBaja, Me.btnNDesde, Me.ToolStripSeparator2, Me.btnMostrarBuscador, Me.btnImprimir, Me.btnExportar, Me.btnCopiar, Me.ToolStripSeparator5, Me.btnDrillDown, Me.ToolStripSeparator6, Me.btnComent, Me.btnAdjuntarArchivo, Me.ToolStripSeparator4, Me.btnEjecutar})
		Me.ToolBarra.Location = New System.Drawing.Point(0, 0)
		Me.ToolBarra.Name = "ToolBarra"
		Me.ToolBarra.Size = New System.Drawing.Size(847, 36)
		Me.ToolBarra.TabIndex = 0
		Me.ToolBarra.TabStop = True
		Me.ToolBarra.Text = "ToolStrip1"
		'
		'btnAlta
		'
		Me.btnAlta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnAlta.Image = Global.VBP04295.My.Resources.Resources.Note_New
		Me.btnAlta.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnAlta.Name = "btnAlta"
		Me.btnAlta.Size = New System.Drawing.Size(29, 33)
		Me.btnAlta.Text = "Alta"
		'
		'btnModif
		'
		Me.btnModif.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnModif.Image = Global.VBP04295.My.Resources.Resources.Note_Edit
		Me.btnModif.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnModif.Name = "btnModif"
		Me.btnModif.Size = New System.Drawing.Size(29, 33)
		Me.btnModif.Text = "Modificación"
		'
		'btnBaja
		'
		Me.btnBaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnBaja.Image = Global.VBP04295.My.Resources.Resources.Note_Delete
		Me.btnBaja.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnBaja.Name = "btnBaja"
		Me.btnBaja.Size = New System.Drawing.Size(29, 33)
		Me.btnBaja.Text = "Baja"
		'
		'btnNDesde
		'
		Me.btnNDesde.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnNDesde.Image = Global.VBP04295.My.Resources.Resources.Note_Add
		Me.btnNDesde.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnNDesde.Name = "btnNDesde"
		Me.btnNDesde.Size = New System.Drawing.Size(29, 33)
		Me.btnNDesde.Text = "Nuevo desde"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 36)
		'
		'btnMostrarBuscador
		'
		Me.btnMostrarBuscador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnMostrarBuscador.Enabled = False
		Me.btnMostrarBuscador.Image = CType(resources.GetObject("btnMostrarBuscador.Image"), System.Drawing.Image)
		Me.btnMostrarBuscador.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnMostrarBuscador.Name = "btnMostrarBuscador"
		Me.btnMostrarBuscador.Size = New System.Drawing.Size(29, 33)
		Me.btnMostrarBuscador.Text = "Mostrar/Ocultar buscador en grilla"
		Me.btnMostrarBuscador.ToolTipText = "Mostrar/Ocultar buscador"
		'
		'btnImprimir
		'
		Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnImprimir.Enabled = False
		Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
		Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnImprimir.Name = "btnImprimir"
		Me.btnImprimir.Size = New System.Drawing.Size(29, 33)
		Me.btnImprimir.Text = "Vista previa"
		Me.btnImprimir.ToolTipText = "Vista previa impresión"
		'
		'btnExportar
		'
		Me.btnExportar.Enabled = False
		Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
		Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnExportar.Name = "btnExportar"
		Me.btnExportar.Size = New System.Drawing.Size(29, 33)
		Me.btnExportar.ToolTipText = "Exportar a Excel"
		'
		'btnCopiar
		'
		Me.btnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnCopiar.Enabled = False
		Me.btnCopiar.Image = Global.VBP04295.My.Resources.Resources.Copy
		Me.btnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnCopiar.Name = "btnCopiar"
		Me.btnCopiar.Size = New System.Drawing.Size(29, 33)
		Me.btnCopiar.ToolTipText = "Copiar resultados"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 36)
		'
		'btnDrillDown
		'
		Me.btnDrillDown.Image = Global.VBP04295.My.Resources.Resources.Grid_2
		Me.btnDrillDown.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnDrillDown.Name = "btnDrillDown"
		Me.btnDrillDown.Size = New System.Drawing.Size(104, 33)
		Me.btnDrillDown.Text = "Drill Down"
		Me.btnDrillDown.ToolTipText = "Presenta el drill down"
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 36)
		'
		'btnComent
		'
		Me.btnComent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnComent.Image = Global.VBP04295.My.Resources.Resources.Note
		Me.btnComent.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnComent.Name = "btnComent"
		Me.btnComent.Size = New System.Drawing.Size(29, 33)
		Me.btnComent.Text = "Comentarios"
		Me.btnComent.ToolTipText = "Ver/Agregar comentarios"
		'
		'btnAdjuntarArchivo
		'
		Me.btnAdjuntarArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnAdjuntarArchivo.Enabled = False
		Me.btnAdjuntarArchivo.Image = CType(resources.GetObject("btnAdjuntarArchivo.Image"), System.Drawing.Image)
		Me.btnAdjuntarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnAdjuntarArchivo.Name = "btnAdjuntarArchivo"
		Me.btnAdjuntarArchivo.Size = New System.Drawing.Size(29, 33)
		Me.btnAdjuntarArchivo.ToolTipText = "Adjuntar un archivo"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 36)
		'
		'btnEjecutar
		'
		Me.btnEjecutar.Image = CType(resources.GetObject("btnEjecutar.Image"), System.Drawing.Image)
		Me.btnEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnEjecutar.Name = "btnEjecutar"
		Me.btnEjecutar.Size = New System.Drawing.Size(137, 33)
		Me.btnEjecutar.Text = "Presentar Datos"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(847, 529)
		Me.Controls.Add(Me.PanGrid)
		Me.Controls.Add(Me.PanControles)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "frmMain"
		Me.Text = " VBP04295"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.PanControles, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanControles.ResumeLayout(False)
		CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanTop.ResumeLayout(False)
		Me.PanTop.PerformLayout()
		CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
   Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
   Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents PanTool As DevExpress.XtraEditors.PanelControl
   Friend WithEvents ToolBarra As System.Windows.Forms.ToolStrip
   Friend WithEvents btnEjecutar As System.Windows.Forms.ToolStripButton
   Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnAlta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModif As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBaja As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNDesde As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnComent As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDrillDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTipText As System.Windows.Forms.ToolTip
    Friend WithEvents btnCopiar As ToolStripButton
    Friend WithEvents btnAdjuntarArchivo As ToolStripButton
    Friend WithEvents btnMostrarBuscador As ToolStripButton
End Class
