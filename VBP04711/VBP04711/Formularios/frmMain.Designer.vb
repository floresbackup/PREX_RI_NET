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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Skin = New DevExpress.LookAndFeel.DefaultLookAndFeel()
        Me.PanControles = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigosTransaccion = New DevExpress.XtraEditors.TextEdit()
        Me.cmdConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBuscarAcciones = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAcciones = New DevExpress.XtraEditors.SpinEdit()
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
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem()
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanGrid = New DevExpress.XtraEditors.PanelControl()
        Me.PanGrilla = New DevExpress.XtraEditors.PanelControl()
        Me.PanTool = New DevExpress.XtraEditors.PanelControl()
        Me.ToolBarra = New System.Windows.Forms.ToolStrip()
        Me.btnNuevaConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnVerAdjunto = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolTipText = New System.Windows.Forms.ToolTip()
        CType(Me.PanControles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanControles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigosTransaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigosTransaccion)
        Me.GroupBox1.Controls.Add(Me.cmdConsultar)
        Me.GroupBox1.Controls.Add(Me.cmdBuscarAcciones)
        Me.GroupBox1.Controls.Add(Me.txtAcciones)
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
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(376, 70)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(171, 20)
        Me.txtUsuario.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(376, 44)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(171, 20)
        Me.txtDescripcion.TabIndex = 7
        '
        'txtCodigosTransaccion
        '
        Me.txtCodigosTransaccion.Location = New System.Drawing.Point(376, 18)
        Me.txtCodigosTransaccion.Name = "txtCodigosTransaccion"
        Me.txtCodigosTransaccion.Size = New System.Drawing.Size(171, 20)
        Me.txtCodigosTransaccion.TabIndex = 7
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(553, 68)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(76, 23)
        Me.cmdConsultar.TabIndex = 6
        Me.cmdConsultar.Text = "&Consultar"
        '
        'cmdBuscarAcciones
        '
        Me.cmdBuscarAcciones.ImageOptions.Image = Global.VBP04711.My.Resources.Resources.edit_find_3
        Me.cmdBuscarAcciones.Location = New System.Drawing.Point(169, 66)
        Me.cmdBuscarAcciones.Name = "cmdBuscarAcciones"
        Me.cmdBuscarAcciones.Size = New System.Drawing.Size(23, 23)
        Me.cmdBuscarAcciones.TabIndex = 6
        '
        'txtAcciones
        '
        Me.txtAcciones.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAcciones.Location = New System.Drawing.Point(92, 68)
        Me.txtAcciones.Name = "txtAcciones"
        Me.txtAcciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtAcciones.Size = New System.Drawing.Size(71, 20)
        Me.txtAcciones.TabIndex = 5
        Me.txtAcciones.UseWaitCursor = True
        '
        'txtHasta
        '
        Me.txtHasta.EditValue = Nothing
        Me.txtHasta.Location = New System.Drawing.Point(92, 44)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtHasta.TabIndex = 4
        '
        'txtDesde
        '
        Me.txtDesde.EditValue = Nothing
        Me.txtDesde.Location = New System.Drawing.Point(92, 20)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDesde.TabIndex = 4
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
        Me.Label5.Text = "Descripción de trnas. contiene:"
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
        Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.Grid.LookAndFeel.UseWindowsXPTheme = True
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(635, 244)
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
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
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
        Me.PanGrid.Location = New System.Drawing.Point(0, 157)
        Me.PanGrid.Name = "PanGrid"
        Me.PanGrid.Size = New System.Drawing.Size(635, 273)
        Me.PanGrid.TabIndex = 3
        '
        'PanGrilla
        '
        Me.PanGrilla.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanGrilla.Controls.Add(Me.Grid)
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
        Me.ToolBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaConsulta, Me.ToolStripSeparator5, Me.btnVerAdjunto, Me.btnImprimir, Me.btnExportar, Me.ToolStripButton2})
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
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(111, 26)
        Me.btnNuevaConsulta.Text = "Nueva Consulta"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 29)
        '
        'btnVerAdjunto
        '
        Me.btnVerAdjunto.Image = Global.VBP04711.My.Resources.Resources.page_attach
        Me.btnVerAdjunto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerAdjunto.Name = "btnVerAdjunto"
        Me.btnVerAdjunto.Size = New System.Drawing.Size(90, 26)
        Me.btnVerAdjunto.Text = "Ver Adjunto"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(87, 26)
        Me.btnImprimir.Text = "Vista previa"
        Me.btnImprimir.ToolTipText = "Vista previa impresión"
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 26)
        Me.btnExportar.Text = "Exportar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.VBP04711.My.Resources.Resources.Copy
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(62, 26)
        Me.ToolStripButton2.Text = "Copiar"
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
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigosTransaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBuscarAcciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAcciones As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnVerAdjunto As ToolStripButton
End Class
