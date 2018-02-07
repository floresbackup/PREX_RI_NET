<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
      Dim Document1 As ActiproSoftware.SyntaxEditor.Document = New ActiproSoftware.SyntaxEditor.Document
      Dim VisualStudio2005SyntaxEditorRenderer1 As ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer = New ActiproSoftware.SyntaxEditor.VisualStudio2005SyntaxEditorRenderer
      Me.SyntaxSQL = New ActiproSoftware.SyntaxEditor.Addons.Dynamic.DynamicSyntaxLanguage(Me.components)
      Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl
      Me.mnuRibbon = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
      Me.btnNuevo = New DevExpress.XtraBars.BarButtonItem
      Me.btnAbrir = New DevExpress.XtraBars.BarButtonItem
      Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem
      Me.btnGuardarComo = New DevExpress.XtraBars.BarButtonItem
      Me.btnSalir = New DevExpress.XtraBars.BarButtonItem
      Me.TabPrincipal = New DevExpress.XtraBars.Ribbon.RibbonPage
      Me.RibbonPrincipal = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
      Me.RibbonSalir = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
      Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
      Me.ClientPanel = New DevExpress.XtraEditors.PanelControl
      Me.TabCtrl = New DevExpress.XtraTab.XtraTabControl
      Me.TabProp = New DevExpress.XtraTab.XtraTabPage
      Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
      Me.cboEntidad = New DevExpress.XtraEditors.ComboBoxEdit
      Me.txtDescri = New DevExpress.XtraEditors.TextEdit
      Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
      Me.txtCodTra = New DevExpress.XtraEditors.TextEdit
      Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
      Me.txtNombre = New DevExpress.XtraEditors.TextEdit
      Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
      Me.TabQuery = New DevExpress.XtraTab.XtraTabPage
      Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
      Me.lstVariables = New DevExpress.XtraEditors.ListBoxControl
      Me.PanelVarTools = New DevExpress.XtraEditors.PanelControl
      Me.btnVarAbajo = New DevExpress.XtraEditors.SimpleButton
      Me.btnVarArriba = New DevExpress.XtraEditors.SimpleButton
      Me.btnVarProp = New DevExpress.XtraEditors.SimpleButton
      Me.btnVarQuitar = New DevExpress.XtraEditors.SimpleButton
      Me.btnVarAgregar = New DevExpress.XtraEditors.SimpleButton
      Me.apSQL = New ActiproSoftware.SyntaxEditor.SyntaxEditor
      Me.PanelQueryTools = New DevExpress.XtraEditors.PanelControl
      Me.btnQueryCampos = New DevExpress.XtraEditors.SimpleButton
      Me.btnQueryPost = New DevExpress.XtraEditors.SimpleButton
      Me.btnQueryGrid = New DevExpress.XtraEditors.SimpleButton
      Me.btnQueryPrevio = New DevExpress.XtraEditors.SimpleButton
      Me.TabGrilla = New DevExpress.XtraTab.XtraTabPage
      Me.SplitGrilla = New DevExpress.XtraEditors.SplitContainerControl
      Me.TabFMT = New DevExpress.XtraTab.XtraTabPage
      Me.TabPreview = New DevExpress.XtraTab.XtraTabPage
      Me.Grid = New DevExpress.XtraGrid.GridControl
      Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.colTG_CODTAB = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_CODCON = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_DESCRI = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_NUME01 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_NUME02 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_ALFA01 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_ALFA02 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_FECH01 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_FECH02 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colTG_ALFA03 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.LookAndFeelApp = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
      Me.icGeneral = New DevExpress.Utils.ImageCollection(Me.components)
      CType(Me.mnuRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ClientPanel.SuspendLayout()
      CType(Me.TabCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabCtrl.SuspendLayout()
      Me.TabProp.SuspendLayout()
      CType(Me.cboEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDescri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCodTra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabQuery.SuspendLayout()
      CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainerControl1.SuspendLayout()
      CType(Me.lstVariables, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PanelVarTools, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanelVarTools.SuspendLayout()
      CType(Me.PanelQueryTools, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanelQueryTools.SuspendLayout()
      Me.TabGrilla.SuspendLayout()
      CType(Me.SplitGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitGrilla.SuspendLayout()
      Me.TabPreview.SuspendLayout()
      CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.icGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'SyntaxSQL
      '
      Me.SyntaxSQL.DefinitionXml = resources.GetString("SyntaxSQL.DefinitionXml")
      '
      'RibbonControl
      '
      Me.RibbonControl.ApplicationButtonDropDownControl = Me.mnuRibbon
      Me.RibbonControl.ApplicationButtonKeyTip = ""
      Me.RibbonControl.ApplicationIcon = CType(resources.GetObject("RibbonControl.ApplicationIcon"), System.Drawing.Bitmap)
      Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalir, Me.btnNuevo, Me.btnAbrir, Me.btnGuardar, Me.btnGuardarComo})
      Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
      Me.RibbonControl.MaxItemId = 10
      Me.RibbonControl.Name = "RibbonControl"
      Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.TabPrincipal})
      Me.RibbonControl.SelectedPage = Me.TabPrincipal
      Me.RibbonControl.Size = New System.Drawing.Size(711, 149)
      Me.RibbonControl.Toolbar.ItemLinks.Add(Me.btnNuevo)
      Me.RibbonControl.Toolbar.ItemLinks.Add(Me.btnAbrir)
      Me.RibbonControl.Toolbar.ItemLinks.Add(Me.btnGuardar)
      Me.RibbonControl.Toolbar.ItemLinks.Add(Me.btnGuardarComo)
      '
      'mnuRibbon
      '
      Me.mnuRibbon.BottomPaneControlContainer = Nothing
      Me.mnuRibbon.ItemLinks.Add(Me.btnNuevo, True)
      Me.mnuRibbon.ItemLinks.Add(Me.btnAbrir, True)
      Me.mnuRibbon.ItemLinks.Add(Me.btnGuardar, True)
      Me.mnuRibbon.ItemLinks.Add(Me.btnGuardarComo)
      Me.mnuRibbon.ItemLinks.Add(Me.btnSalir, True)
      Me.mnuRibbon.Name = "mnuRibbon"
      Me.mnuRibbon.Ribbon = Me.RibbonControl
      Me.mnuRibbon.RightPaneControlContainer = Nothing
      Me.mnuRibbon.RightPaneWidth = 240
      Me.mnuRibbon.ShowRightPane = True
      '
      'btnNuevo
      '
      Me.btnNuevo.Caption = " &Nuevo"
      Me.btnNuevo.Glyph = Global.VBP04296.My.Resources.Resources._New
      Me.btnNuevo.Id = 2
      Me.btnNuevo.LargeGlyph = Global.VBP04296.My.Resources.Resources.New1
      Me.btnNuevo.Name = "btnNuevo"
      Me.btnNuevo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
      '
      'btnAbrir
      '
      Me.btnAbrir.Caption = " &Abrir"
      Me.btnAbrir.Glyph = Global.VBP04296.My.Resources.Resources.Open
      Me.btnAbrir.Id = 5
      Me.btnAbrir.LargeGlyph = Global.VBP04296.My.Resources.Resources.Open1
      Me.btnAbrir.Name = "btnAbrir"
      Me.btnAbrir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
      '
      'btnGuardar
      '
      Me.btnGuardar.Caption = " &Guardar"
      Me.btnGuardar.Glyph = Global.VBP04296.My.Resources.Resources.Save
      Me.btnGuardar.Id = 6
      Me.btnGuardar.LargeGlyph = Global.VBP04296.My.Resources.Resources.Save1
      Me.btnGuardar.Name = "btnGuardar"
      Me.btnGuardar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
      '
      'btnGuardarComo
      '
      Me.btnGuardarComo.Caption = " Guardar &Como"
      Me.btnGuardarComo.Glyph = Global.VBP04296.My.Resources.Resources.Save_As
      Me.btnGuardarComo.Id = 8
      Me.btnGuardarComo.LargeGlyph = Global.VBP04296.My.Resources.Resources.Save_As1
      Me.btnGuardarComo.Name = "btnGuardarComo"
      Me.btnGuardarComo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
      '
      'btnSalir
      '
      Me.btnSalir.Caption = " &Salir"
      Me.btnSalir.Glyph = Global.VBP04296.My.Resources.Resources.close_16
      Me.btnSalir.Id = 0
      Me.btnSalir.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4))
      Me.btnSalir.LargeGlyph = Global.VBP04296.My.Resources.Resources.close_32
      Me.btnSalir.Name = "btnSalir"
      Me.btnSalir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
      Me.btnSalir.UseOwnFont = True
      '
      'TabPrincipal
      '
      Me.TabPrincipal.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPrincipal, Me.RibbonSalir})
      Me.TabPrincipal.KeyTip = ""
      Me.TabPrincipal.Name = "TabPrincipal"
      Me.TabPrincipal.Text = "Principal"
      '
      'RibbonPrincipal
      '
      Me.RibbonPrincipal.ItemLinks.Add(Me.btnNuevo)
      Me.RibbonPrincipal.ItemLinks.Add(Me.btnAbrir)
      Me.RibbonPrincipal.ItemLinks.Add(Me.btnGuardar)
      Me.RibbonPrincipal.ItemLinks.Add(Me.btnGuardarComo)
      Me.RibbonPrincipal.KeyTip = ""
      Me.RibbonPrincipal.Name = "RibbonPrincipal"
      Me.RibbonPrincipal.Text = "Acciones"
      '
      'RibbonSalir
      '
      Me.RibbonSalir.ItemLinks.Add(Me.btnSalir)
      Me.RibbonSalir.KeyTip = ""
      Me.RibbonSalir.Name = "RibbonSalir"
      Me.RibbonSalir.Text = "Salir"
      '
      'RibbonStatusBar
      '
      Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 433)
      Me.RibbonStatusBar.Name = "RibbonStatusBar"
      Me.RibbonStatusBar.Ribbon = Me.RibbonControl
      Me.RibbonStatusBar.Size = New System.Drawing.Size(711, 23)
      '
      'ClientPanel
      '
      Me.ClientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
      Me.ClientPanel.Controls.Add(Me.TabCtrl)
      Me.ClientPanel.Dock = System.Windows.Forms.DockStyle.Fill
      Me.ClientPanel.Location = New System.Drawing.Point(0, 149)
      Me.ClientPanel.Name = "ClientPanel"
      Me.ClientPanel.Size = New System.Drawing.Size(711, 284)
      Me.ClientPanel.TabIndex = 2
      '
      'TabCtrl
      '
      Me.TabCtrl.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TabCtrl.Location = New System.Drawing.Point(0, 0)
      Me.TabCtrl.Name = "TabCtrl"
      Me.TabCtrl.SelectedTabPage = Me.TabProp
      Me.TabCtrl.Size = New System.Drawing.Size(711, 284)
      Me.TabCtrl.TabIndex = 0
      Me.TabCtrl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabProp, Me.TabQuery, Me.TabGrilla, Me.TabFMT, Me.TabPreview})
      '
      'TabProp
      '
      Me.TabProp.Controls.Add(Me.LabelControl4)
      Me.TabProp.Controls.Add(Me.cboEntidad)
      Me.TabProp.Controls.Add(Me.txtDescri)
      Me.TabProp.Controls.Add(Me.LabelControl3)
      Me.TabProp.Controls.Add(Me.txtCodTra)
      Me.TabProp.Controls.Add(Me.LabelControl2)
      Me.TabProp.Controls.Add(Me.txtNombre)
      Me.TabProp.Controls.Add(Me.LabelControl1)
      Me.TabProp.Name = "TabProp"
      Me.TabProp.Size = New System.Drawing.Size(702, 254)
      Me.TabProp.Text = "Propiedades"
      '
      'LabelControl4
      '
      Me.LabelControl4.Location = New System.Drawing.Point(9, 45)
      Me.LabelControl4.Name = "LabelControl4"
      Me.LabelControl4.Size = New System.Drawing.Size(40, 13)
      Me.LabelControl4.TabIndex = 7
      Me.LabelControl4.Text = "Entidad:"
      '
      'cboEntidad
      '
      Me.cboEntidad.Location = New System.Drawing.Point(106, 42)
      Me.cboEntidad.Name = "cboEntidad"
      Me.cboEntidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
      Me.cboEntidad.Size = New System.Drawing.Size(570, 20)
      Me.cboEntidad.TabIndex = 6
      '
      'txtDescri
      '
      Me.txtDescri.Location = New System.Drawing.Point(106, 94)
      Me.txtDescri.Name = "txtDescri"
      Me.txtDescri.Size = New System.Drawing.Size(570, 20)
      Me.txtDescri.TabIndex = 5
      '
      'LabelControl3
      '
      Me.LabelControl3.Location = New System.Drawing.Point(9, 97)
      Me.LabelControl3.Name = "LabelControl3"
      Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
      Me.LabelControl3.TabIndex = 4
      Me.LabelControl3.Text = "Descripción:"
      '
      'txtCodTra
      '
      Me.txtCodTra.Location = New System.Drawing.Point(106, 68)
      Me.txtCodTra.Name = "txtCodTra"
      Me.txtCodTra.Properties.Mask.EditMask = "f0"
      Me.txtCodTra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
      Me.txtCodTra.Size = New System.Drawing.Size(121, 20)
      Me.txtCodTra.TabIndex = 3
      '
      'LabelControl2
      '
      Me.LabelControl2.Location = New System.Drawing.Point(9, 71)
      Me.LabelControl2.Name = "LabelControl2"
      Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
      Me.LabelControl2.TabIndex = 2
      Me.LabelControl2.Text = "Transacción:"
      '
      'txtNombre
      '
      Me.txtNombre.Location = New System.Drawing.Point(106, 16)
      Me.txtNombre.Name = "txtNombre"
      Me.txtNombre.Size = New System.Drawing.Size(570, 20)
      Me.txtNombre.TabIndex = 1
      '
      'LabelControl1
      '
      Me.LabelControl1.Location = New System.Drawing.Point(9, 19)
      Me.LabelControl1.Name = "LabelControl1"
      Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
      Me.LabelControl1.TabIndex = 0
      Me.LabelControl1.Text = "Nombre:"
      '
      'TabQuery
      '
      Me.TabQuery.Controls.Add(Me.SplitContainerControl1)
      Me.TabQuery.Name = "TabQuery"
      Me.TabQuery.Size = New System.Drawing.Size(702, 254)
      Me.TabQuery.Text = "Consulta SQL"
      '
      'SplitContainerControl1
      '
      Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainerControl1.Name = "SplitContainerControl1"
      Me.SplitContainerControl1.Panel1.Controls.Add(Me.lstVariables)
      Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelVarTools)
      Me.SplitContainerControl1.Panel1.Text = "PanelVariables"
      Me.SplitContainerControl1.Panel2.Controls.Add(Me.apSQL)
      Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelQueryTools)
      Me.SplitContainerControl1.Panel2.Text = "PanelQuery"
      Me.SplitContainerControl1.Size = New System.Drawing.Size(702, 254)
      Me.SplitContainerControl1.SplitterPosition = 191
      Me.SplitContainerControl1.TabIndex = 2
      Me.SplitContainerControl1.Text = "SplitQuery"
      '
      'lstVariables
      '
      Me.lstVariables.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lstVariables.Location = New System.Drawing.Point(0, 33)
      Me.lstVariables.Name = "lstVariables"
      Me.lstVariables.Size = New System.Drawing.Size(187, 217)
      Me.lstVariables.TabIndex = 2
      '
      'PanelVarTools
      '
      Me.PanelVarTools.Controls.Add(Me.btnVarAbajo)
      Me.PanelVarTools.Controls.Add(Me.btnVarArriba)
      Me.PanelVarTools.Controls.Add(Me.btnVarProp)
      Me.PanelVarTools.Controls.Add(Me.btnVarQuitar)
      Me.PanelVarTools.Controls.Add(Me.btnVarAgregar)
      Me.PanelVarTools.Dock = System.Windows.Forms.DockStyle.Top
      Me.PanelVarTools.Location = New System.Drawing.Point(0, 0)
      Me.PanelVarTools.Name = "PanelVarTools"
      Me.PanelVarTools.Size = New System.Drawing.Size(187, 33)
      Me.PanelVarTools.TabIndex = 1
      '
      'btnVarAbajo
      '
      Me.btnVarAbajo.Image = Global.VBP04296.My.Resources.Resources.Outline_Move_Down
      Me.btnVarAbajo.Location = New System.Drawing.Point(117, 4)
      Me.btnVarAbajo.Name = "btnVarAbajo"
      Me.btnVarAbajo.Size = New System.Drawing.Size(26, 24)
      Me.btnVarAbajo.TabIndex = 4
      '
      'btnVarArriba
      '
      Me.btnVarArriba.Image = Global.VBP04296.My.Resources.Resources.Outline_Move_Up
      Me.btnVarArriba.Location = New System.Drawing.Point(89, 4)
      Me.btnVarArriba.Name = "btnVarArriba"
      Me.btnVarArriba.Size = New System.Drawing.Size(26, 24)
      Me.btnVarArriba.TabIndex = 3
      '
      'btnVarProp
      '
      Me.btnVarProp.Image = Global.VBP04296.My.Resources.Resources.Edit1
      Me.btnVarProp.Location = New System.Drawing.Point(61, 4)
      Me.btnVarProp.Name = "btnVarProp"
      Me.btnVarProp.Size = New System.Drawing.Size(26, 24)
      Me.btnVarProp.TabIndex = 2
      '
      'btnVarQuitar
      '
      Me.btnVarQuitar.Image = Global.VBP04296.My.Resources.Resources.Outline_Collapse
      Me.btnVarQuitar.Location = New System.Drawing.Point(32, 4)
      Me.btnVarQuitar.Name = "btnVarQuitar"
      Me.btnVarQuitar.Size = New System.Drawing.Size(26, 24)
      Me.btnVarQuitar.TabIndex = 1
      '
      'btnVarAgregar
      '
      Me.btnVarAgregar.Image = Global.VBP04296.My.Resources.Resources.Outline_Expand
      Me.btnVarAgregar.Location = New System.Drawing.Point(4, 4)
      Me.btnVarAgregar.Name = "btnVarAgregar"
      Me.btnVarAgregar.Size = New System.Drawing.Size(26, 24)
      Me.btnVarAgregar.TabIndex = 0
      '
      'apSQL
      '
      Me.apSQL.AllowDrop = True
      Me.apSQL.BracketHighlightingVisible = True
      Me.apSQL.Dock = System.Windows.Forms.DockStyle.Fill
      Document1.Filename = ""
      Document1.Language = Me.SyntaxSQL
      Document1.LineModificationMarkingEnabled = True
      Document1.Outlining.Mode = ActiproSoftware.SyntaxEditor.OutliningMode.Automatic
      Me.apSQL.Document = Document1
      Me.apSQL.IntelliPrompt.DropShadowEnabled = True
      Me.apSQL.IntelliPrompt.SmartTag.ClearOnDocumentModification = True
      Me.apSQL.IntelliPrompt.SmartTag.MultipleSmartTagsEnabled = False
      Me.apSQL.LineNumberMarginVisible = True
      Me.apSQL.Location = New System.Drawing.Point(0, 33)
      Me.apSQL.Name = "apSQL"
      VisualStudio2005SyntaxEditorRenderer1.ResetAllPropertiesOnSystemColorChange = False
      Me.apSQL.Renderer = VisualStudio2005SyntaxEditorRenderer1
      Me.apSQL.Size = New System.Drawing.Size(501, 217)
      Me.apSQL.TabIndex = 7
      '
      'PanelQueryTools
      '
      Me.PanelQueryTools.Controls.Add(Me.btnQueryCampos)
      Me.PanelQueryTools.Controls.Add(Me.btnQueryPost)
      Me.PanelQueryTools.Controls.Add(Me.btnQueryGrid)
      Me.PanelQueryTools.Controls.Add(Me.btnQueryPrevio)
      Me.PanelQueryTools.Dock = System.Windows.Forms.DockStyle.Top
      Me.PanelQueryTools.Location = New System.Drawing.Point(0, 0)
      Me.PanelQueryTools.Name = "PanelQueryTools"
      Me.PanelQueryTools.Size = New System.Drawing.Size(501, 33)
      Me.PanelQueryTools.TabIndex = 0
      '
      'btnQueryCampos
      '
      Me.btnQueryCampos.Location = New System.Drawing.Point(320, 5)
      Me.btnQueryCampos.Name = "btnQueryCampos"
      Me.btnQueryCampos.Size = New System.Drawing.Size(108, 23)
      Me.btnQueryCampos.TabIndex = 4
      Me.btnQueryCampos.Text = "Obtener Campos"
      '
      'btnQueryPost
      '
      Me.btnQueryPost.Location = New System.Drawing.Point(215, 5)
      Me.btnQueryPost.Name = "btnQueryPost"
      Me.btnQueryPost.Size = New System.Drawing.Size(99, 23)
      Me.btnQueryPost.TabIndex = 3
      Me.btnQueryPost.Text = "Query Posterior"
      '
      'btnQueryGrid
      '
      Me.btnQueryGrid.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
      Me.btnQueryGrid.Appearance.Options.UseFont = True
      Me.btnQueryGrid.Location = New System.Drawing.Point(110, 5)
      Me.btnQueryGrid.Name = "btnQueryGrid"
      Me.btnQueryGrid.Size = New System.Drawing.Size(99, 23)
      Me.btnQueryGrid.TabIndex = 2
      Me.btnQueryGrid.Text = "Query Grilla"
      '
      'btnQueryPrevio
      '
      Me.btnQueryPrevio.Location = New System.Drawing.Point(5, 5)
      Me.btnQueryPrevio.Name = "btnQueryPrevio"
      Me.btnQueryPrevio.Size = New System.Drawing.Size(99, 23)
      Me.btnQueryPrevio.TabIndex = 1
      Me.btnQueryPrevio.Text = "Query Previo"
      '
      'TabGrilla
      '
      Me.TabGrilla.Controls.Add(Me.SplitGrilla)
      Me.TabGrilla.Name = "TabGrilla"
      Me.TabGrilla.Size = New System.Drawing.Size(702, 254)
      Me.TabGrilla.Text = "Diseño Grilla"
      '
      'SplitGrilla
      '
      Me.SplitGrilla.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitGrilla.Location = New System.Drawing.Point(0, 0)
      Me.SplitGrilla.Name = "SplitGrilla"
      Me.SplitGrilla.Panel1.Text = "PanelGridProp"
      Me.SplitGrilla.Panel2.Text = "PanelGrid"
      Me.SplitGrilla.Size = New System.Drawing.Size(702, 254)
      Me.SplitGrilla.SplitterPosition = 191
      Me.SplitGrilla.TabIndex = 0
      Me.SplitGrilla.Text = "SplitGrid"
      '
      'TabFMT
      '
      Me.TabFMT.Name = "TabFMT"
      Me.TabFMT.Size = New System.Drawing.Size(702, 254)
      Me.TabFMT.Text = "Formatos Condicionales"
      '
      'TabPreview
      '
      Me.TabPreview.Controls.Add(Me.Grid)
      Me.TabPreview.Name = "TabPreview"
      Me.TabPreview.Size = New System.Drawing.Size(702, 254)
      Me.TabPreview.Text = "Vista Previa"
      '
      'Grid
      '
      Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
      Me.Grid.EmbeddedNavigator.Name = ""
      Me.Grid.Location = New System.Drawing.Point(0, 0)
      Me.Grid.MainView = Me.GridView1
      Me.Grid.Name = "Grid"
      Me.Grid.Size = New System.Drawing.Size(702, 254)
      Me.Grid.TabIndex = 3
      Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
      '
      'GridView1
      '
      Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTG_CODTAB, Me.colTG_CODCON, Me.colTG_DESCRI, Me.colTG_NUME01, Me.colTG_NUME02, Me.colTG_ALFA01, Me.colTG_ALFA02, Me.colTG_FECH01, Me.colTG_FECH02, Me.colTG_ALFA03})
      Me.GridView1.GridControl = Me.Grid
      Me.GridView1.Name = "GridView1"
      '
      'colTG_CODTAB
      '
      Me.colTG_CODTAB.Caption = "TG_CODTAB"
      Me.colTG_CODTAB.FieldName = "TG_CODTAB"
      Me.colTG_CODTAB.Name = "colTG_CODTAB"
      Me.colTG_CODTAB.Visible = True
      Me.colTG_CODTAB.VisibleIndex = 0
      '
      'colTG_CODCON
      '
      Me.colTG_CODCON.Caption = "TG_CODCON"
      Me.colTG_CODCON.FieldName = "TG_CODCON"
      Me.colTG_CODCON.Name = "colTG_CODCON"
      Me.colTG_CODCON.Visible = True
      Me.colTG_CODCON.VisibleIndex = 1
      '
      'colTG_DESCRI
      '
      Me.colTG_DESCRI.Caption = "TG_DESCRI"
      Me.colTG_DESCRI.FieldName = "TG_DESCRI"
      Me.colTG_DESCRI.Name = "colTG_DESCRI"
      Me.colTG_DESCRI.Visible = True
      Me.colTG_DESCRI.VisibleIndex = 2
      '
      'colTG_NUME01
      '
      Me.colTG_NUME01.Caption = "TG_NUME01"
      Me.colTG_NUME01.FieldName = "TG_NUME01"
      Me.colTG_NUME01.Name = "colTG_NUME01"
      Me.colTG_NUME01.Visible = True
      Me.colTG_NUME01.VisibleIndex = 3
      '
      'colTG_NUME02
      '
      Me.colTG_NUME02.Caption = "TG_NUME02"
      Me.colTG_NUME02.FieldName = "TG_NUME02"
      Me.colTG_NUME02.Name = "colTG_NUME02"
      Me.colTG_NUME02.Visible = True
      Me.colTG_NUME02.VisibleIndex = 4
      '
      'colTG_ALFA01
      '
      Me.colTG_ALFA01.Caption = "TG_ALFA01"
      Me.colTG_ALFA01.FieldName = "TG_ALFA01"
      Me.colTG_ALFA01.Name = "colTG_ALFA01"
      Me.colTG_ALFA01.Visible = True
      Me.colTG_ALFA01.VisibleIndex = 5
      '
      'colTG_ALFA02
      '
      Me.colTG_ALFA02.Caption = "TG_ALFA02"
      Me.colTG_ALFA02.FieldName = "TG_ALFA02"
      Me.colTG_ALFA02.Name = "colTG_ALFA02"
      Me.colTG_ALFA02.Visible = True
      Me.colTG_ALFA02.VisibleIndex = 6
      '
      'colTG_FECH01
      '
      Me.colTG_FECH01.Caption = "TG_FECH01"
      Me.colTG_FECH01.FieldName = "TG_FECH01"
      Me.colTG_FECH01.Name = "colTG_FECH01"
      Me.colTG_FECH01.Visible = True
      Me.colTG_FECH01.VisibleIndex = 7
      '
      'colTG_FECH02
      '
      Me.colTG_FECH02.Caption = "TG_FECH02"
      Me.colTG_FECH02.FieldName = "TG_FECH02"
      Me.colTG_FECH02.Name = "colTG_FECH02"
      Me.colTG_FECH02.Visible = True
      Me.colTG_FECH02.VisibleIndex = 8
      '
      'colTG_ALFA03
      '
      Me.colTG_ALFA03.Caption = "TG_ALFA03"
      Me.colTG_ALFA03.FieldName = "TG_ALFA03"
      Me.colTG_ALFA03.Name = "colTG_ALFA03"
      Me.colTG_ALFA03.Visible = True
      Me.colTG_ALFA03.VisibleIndex = 9
      '
      'GridView2
      '
      Me.GridView2.GridControl = Me.Grid
      Me.GridView2.Name = "GridView2"
      '
      'LookAndFeelApp
      '
      Me.LookAndFeelApp.LookAndFeel.SkinName = "Black"
      '
      'icGeneral
      '
      Me.icGeneral.ImageStream = CType(resources.GetObject("icGeneral.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(711, 456)
      Me.Controls.Add(Me.ClientPanel)
      Me.Controls.Add(Me.RibbonStatusBar)
      Me.Controls.Add(Me.RibbonControl)
      Me.Name = "frmMain"
      Me.Ribbon = Me.RibbonControl
      Me.StatusBar = Me.RibbonStatusBar
      Me.Text = "Diseñador de formularios"
      CType(Me.mnuRibbon, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ClientPanel.ResumeLayout(False)
      CType(Me.TabCtrl, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabCtrl.ResumeLayout(False)
      Me.TabProp.ResumeLayout(False)
      Me.TabProp.PerformLayout()
      CType(Me.cboEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDescri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCodTra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabQuery.ResumeLayout(False)
      CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainerControl1.ResumeLayout(False)
      CType(Me.lstVariables, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PanelVarTools, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanelVarTools.ResumeLayout(False)
      CType(Me.PanelQueryTools, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanelQueryTools.ResumeLayout(False)
      Me.TabGrilla.ResumeLayout(False)
      CType(Me.SplitGrilla, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitGrilla.ResumeLayout(False)
      Me.TabPreview.ResumeLayout(False)
      CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.icGeneral, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
   Friend WithEvents TabPrincipal As DevExpress.XtraBars.Ribbon.RibbonPage
   Friend WithEvents RibbonPrincipal As DevExpress.XtraBars.Ribbon.RibbonPageGroup
   Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
   Friend WithEvents ClientPanel As DevExpress.XtraEditors.PanelControl
   Friend WithEvents LookAndFeelApp As DevExpress.LookAndFeel.DefaultLookAndFeel
   Friend WithEvents icGeneral As DevExpress.Utils.ImageCollection
   Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents btnNuevo As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents RibbonSalir As DevExpress.XtraBars.Ribbon.RibbonPageGroup
   Friend WithEvents btnAbrir As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents btnGuardarComo As DevExpress.XtraBars.BarButtonItem
   Friend WithEvents TabCtrl As DevExpress.XtraTab.XtraTabControl
   Friend WithEvents TabProp As DevExpress.XtraTab.XtraTabPage
   Friend WithEvents TabQuery As DevExpress.XtraTab.XtraTabPage
   Friend WithEvents TabGrilla As DevExpress.XtraTab.XtraTabPage
   Friend WithEvents SyntaxSQL As ActiproSoftware.SyntaxEditor.Addons.Dynamic.DynamicSyntaxLanguage
   Friend WithEvents mnuRibbon As DevExpress.XtraBars.Ribbon.ApplicationMenu
   Friend WithEvents SplitGrilla As DevExpress.XtraEditors.SplitContainerControl
   Friend WithEvents TabFMT As DevExpress.XtraTab.XtraTabPage
   Friend WithEvents TabPreview As DevExpress.XtraTab.XtraTabPage
   Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
   Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents colTG_CODTAB As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_CODCON As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_DESCRI As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_NUME01 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_NUME02 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_ALFA01 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_ALFA02 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_FECH01 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_FECH02 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTG_ALFA03 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
   Friend WithEvents lstVariables As DevExpress.XtraEditors.ListBoxControl
   Friend WithEvents PanelVarTools As DevExpress.XtraEditors.PanelControl
   Friend WithEvents btnVarAgregar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnVarQuitar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnVarArriba As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnVarProp As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnVarAbajo As DevExpress.XtraEditors.SimpleButton
   Private WithEvents apSQL As ActiproSoftware.SyntaxEditor.SyntaxEditor
   Friend WithEvents PanelQueryTools As DevExpress.XtraEditors.PanelControl
   Friend WithEvents btnQueryPost As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnQueryGrid As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnQueryPrevio As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnQueryCampos As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents txtDescri As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents txtCodTra As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents cboEntidad As DevExpress.XtraEditors.ComboBoxEdit


End Class
