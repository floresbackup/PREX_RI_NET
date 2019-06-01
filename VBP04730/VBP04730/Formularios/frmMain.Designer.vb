<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.  
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim StyleFormatCondition3 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition()
        Me.colTK_ACTIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTU_ACTIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGeneraTXT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTransaccion = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAyuda = New System.Windows.Forms.ToolStripButton()
        Me.tsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblVersion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolMain = New System.Windows.Forms.ToolStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panBotones = New System.Windows.Forms.Panel()
        Me.cmdCopiar = New System.Windows.Forms.Button()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabPartidas = New System.Windows.Forms.TabPage()
        Me.GridPartidas = New DevExpress.XtraGrid.GridControl()
        Me.gPartidas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTK_FECVIG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_CODENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_CODPAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_CAMPO8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_DESCRI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_DCORTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_CREOREND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_CUADRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_MONFIJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_ORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_OPERACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_ESQUEMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_NIVEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_GENERATXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_NIVELTAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_RELATIVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTK_INDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolAbmPartidas = New System.Windows.Forms.ToolStrip()
        Me.btnNuevaPartida = New System.Windows.Forms.ToolStripButton()
        Me.btnModifPartida = New System.Windows.Forms.ToolStripButton()
        Me.btnDesactivarPartida = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirPartidas = New System.Windows.Forms.ToolStripButton()
        Me.btnExportarPartidas = New System.Windows.Forms.ToolStripButton()
        Me.toolPartidas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFecVigPartida = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCuadrosPartidas = New System.Windows.Forms.ToolStripComboBox()
        Me.btnPresentarPartidas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpiarPartidas = New System.Windows.Forms.ToolStripButton()
        Me.TabFuenteDatos = New System.Windows.Forms.TabPage()
        Me.GridFuentes = New DevExpress.XtraGrid.GridControl()
        Me.gFuentes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTU_FECVIG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTU_CODENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTU_CODCUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTU_DESCRI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTU_TABLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolABMFuentes = New System.Windows.Forms.ToolStrip()
        Me.btnNuevaFuente = New System.Windows.Forms.ToolStripButton()
        Me.btnModifFuente = New System.Windows.Forms.ToolStripButton()
        Me.btnDesactivarFuente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirFuentes = New System.Windows.Forms.ToolStripButton()
        Me.btnExportarFuentes = New System.Windows.Forms.ToolStripButton()
        Me.toolFuentes = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFecVigFuentes = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cboTablaFuentes = New System.Windows.Forms.ToolStripComboBox()
        Me.btnPresentarFuentes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpiarFuentes = New System.Windows.Forms.ToolStripButton()
        Me.TabRelFuenteDatos = New System.Windows.Forms.TabPage()
        Me.splitRel = New System.Windows.Forms.SplitContainer()
        Me.lvNoRel = New System.Windows.Forms.ListView()
        Me.col1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmdNoTodosRel = New System.Windows.Forms.Button()
        Me.cmdNoUnoRel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvSiRel = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdSiUnoRel = New System.Windows.Forms.Button()
        Me.cmdSiTodosRel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panRelBotton = New System.Windows.Forms.Panel()
        Me.cmdGuardarRel = New System.Windows.Forms.Button()
        Me.cmdCancelarRel = New System.Windows.Forms.Button()
        Me.cmdExportarRel = New System.Windows.Forms.Button()
        Me.cmdImprimirRel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panRelTop = New System.Windows.Forms.Panel()
        Me.cmdLimpiarRel = New System.Windows.Forms.Button()
        Me.cmdPresentarRel = New System.Windows.Forms.Button()
        Me.cboTablaRel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCodParRel = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboFecVigRel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCampo8Rel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCuadroRel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPartidasRdo = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lvNoRdo = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.cmdNoTodosRdo = New System.Windows.Forms.Button()
        Me.cmdNoUnoRdo = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lvSiRdo = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cmdSiUnoRdo = New System.Windows.Forms.Button()
        Me.cmdSiTodosRdo = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.cmdGuardarRdo = New System.Windows.Forms.Button()
        Me.cmdCancelarRdo = New System.Windows.Forms.Button()
        Me.cmdExportarRdo = New System.Windows.Forms.Button()
        Me.cmdImprimirRdo = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.toolRdo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFecVigRdo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCodParRdo = New System.Windows.Forms.ToolStripComboBox()
        Me.btnPresentarRdo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpiarRdo = New System.Windows.Forms.ToolStripButton()
        Me.TabRelTec = New System.Windows.Forms.TabPage()
        Me.GridRelTec = New DevExpress.XtraGrid.GridControl()
        Me.gRelTec = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRT_CODENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colXX_ENTIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRT_CODRTC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRT_FECVIG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRT_CODPAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRT_EOAFNG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRT_CUADRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XX_CUADRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolAbmRelTec = New System.Windows.Forms.ToolStrip()
        Me.btnNuevaRelTec = New System.Windows.Forms.ToolStripButton()
        Me.btnModifRelTec = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminarRelTec = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirRelTec = New System.Windows.Forms.ToolStripButton()
        Me.btnExportarRelTec = New System.Windows.Forms.ToolStripButton()
        Me.toolRelTec = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFecVigRelTec = New System.Windows.Forms.ToolStripComboBox()
        Me.btnPresentarRelTec = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpiarRelTec = New System.Windows.Forms.ToolStripButton()
        Me.TabEstructura = New System.Windows.Forms.TabPage()
        Me.tlEstructura = New DevExpress.XtraTreeList.TreeList()
        Me.colPartida = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colDescri = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colCampo8 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colClave = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.toolEstructura = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFecVigEstructura = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCuadroEstructura = New System.Windows.Forms.ToolStripComboBox()
        Me.btnPresentarEstructura = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpiarEstructura = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardarEstructura = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sbMain.SuspendLayout()
        Me.ToolMain.SuspendLayout()
        Me.panBotones.SuspendLayout()
        Me.Tabs.SuspendLayout()
        Me.TabPartidas.SuspendLayout()
        CType(Me.GridPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolAbmPartidas.SuspendLayout()
        Me.toolPartidas.SuspendLayout()
        Me.TabFuenteDatos.SuspendLayout()
        CType(Me.GridFuentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gFuentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolABMFuentes.SuspendLayout()
        Me.toolFuentes.SuspendLayout()
        Me.TabRelFuenteDatos.SuspendLayout()
        CType(Me.splitRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitRel.Panel1.SuspendLayout()
        Me.splitRel.Panel2.SuspendLayout()
        Me.splitRel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panRelBotton.SuspendLayout()
        Me.panRelTop.SuspendLayout()
        Me.TabPartidasRdo.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.toolRdo.SuspendLayout()
        Me.TabRelTec.SuspendLayout()
        CType(Me.GridRelTec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gRelTec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolAbmRelTec.SuspendLayout()
        Me.toolRelTec.SuspendLayout()
        Me.TabEstructura.SuspendLayout()
        CType(Me.tlEstructura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolEstructura.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'colTK_ACTIVA
        '
        Me.colTK_ACTIVA.Caption = "TK_ACTIVA"
        Me.colTK_ACTIVA.FieldName = "TK_ACTIVA"
        Me.colTK_ACTIVA.Name = "colTK_ACTIVA"
        '
        'colTU_ACTIVA
        '
        Me.colTU_ACTIVA.Caption = "TU_ACTIVA"
        Me.colTU_ACTIVA.FieldName = "TU_ACTIVA"
        Me.colTU_ACTIVA.Name = "colTU_ACTIVA"
        '
        'colGeneraTXT
        '
        Me.colGeneraTXT.Caption = "Genera TXT"
        Me.colGeneraTXT.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colGeneraTXT.FieldName = "TK_GENERATXT"
        Me.colGeneraTXT.Name = "colGeneraTXT"
        Me.colGeneraTXT.Visible = True
        Me.colGeneraTXT.VisibleIndex = 3
        Me.colGeneraTXT.Width = 80
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
        Me.sbMain.Location = New System.Drawing.Point(0, 399)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(691, 25)
        Me.sbMain.TabIndex = 8
        '
        'lblUsuario
        '
        Me.lblUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblUsuario.Image = Global.VBP04730.My.Resources.Resources.Messenger_Information
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(537, 20)
        Me.lblUsuario.Spring = True
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntidad
        '
        Me.lblEntidad.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblEntidad.Image = Global.VBP04730.My.Resources.Resources.Home
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(139, 20)
        Me.lblEntidad.Text = "Banco de Prueba S.A."
        '
        'lblTransaccion
        '
        Me.lblTransaccion.Image = Global.VBP04730.My.Resources.Resources.About
        Me.lblTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransaccion.Name = "lblTransaccion"
        Me.lblTransaccion.Size = New System.Drawing.Size(87, 22)
        Me.lblTransaccion.Text = "Transacción"
        Me.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.VBP04730.My.Resources.Resources.Cross
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
        Me.btnAyuda.Image = Global.VBP04730.My.Resources.Resources.Help_2
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
        'ToolMain
        '
        Me.ToolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTransaccion, Me.btnSalir, Me.tsSep1, Me.btnAyuda, Me.tsSep2, Me.lblVersion, Me.ToolStripSeparator6})
        Me.ToolMain.Location = New System.Drawing.Point(0, 0)
        Me.ToolMain.Name = "ToolMain"
        Me.ToolMain.Size = New System.Drawing.Size(691, 25)
        Me.ToolMain.TabIndex = 9
        Me.ToolMain.Text = "ToolStrip1"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 374)
        Me.Panel1.TabIndex = 10
        '
        'panBotones
        '
        Me.panBotones.Controls.Add(Me.cmdCopiar)
        Me.panBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panBotones.Location = New System.Drawing.Point(0, 368)
        Me.panBotones.Name = "panBotones"
        Me.panBotones.Size = New System.Drawing.Size(691, 31)
        Me.panBotones.TabIndex = 11
        '
        'cmdCopiar
        '
        Me.cmdCopiar.Location = New System.Drawing.Point(3, 4)
        Me.cmdCopiar.Name = "cmdCopiar"
        Me.cmdCopiar.Size = New System.Drawing.Size(101, 23)
        Me.cmdCopiar.TabIndex = 1
        Me.cmdCopiar.Text = "&Copiar de..."
        Me.cmdCopiar.UseVisualStyleBackColor = True
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabPartidas)
        Me.Tabs.Controls.Add(Me.TabFuenteDatos)
        Me.Tabs.Controls.Add(Me.TabRelFuenteDatos)
        Me.Tabs.Controls.Add(Me.TabPartidasRdo)
        Me.Tabs.Controls.Add(Me.TabRelTec)
        Me.Tabs.Controls.Add(Me.TabEstructura)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(0, 25)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(691, 343)
        Me.Tabs.TabIndex = 0
        '
        'TabPartidas
        '
        Me.TabPartidas.Controls.Add(Me.GridPartidas)
        Me.TabPartidas.Controls.Add(Me.toolAbmPartidas)
        Me.TabPartidas.Controls.Add(Me.toolPartidas)
        Me.TabPartidas.Location = New System.Drawing.Point(4, 22)
        Me.TabPartidas.Name = "TabPartidas"
        Me.TabPartidas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPartidas.Size = New System.Drawing.Size(683, 317)
        Me.TabPartidas.TabIndex = 0
        Me.TabPartidas.Text = "Partidas"
        Me.TabPartidas.UseVisualStyleBackColor = True
        '
        'GridPartidas
        '
        Me.GridPartidas.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPartidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPartidas.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridPartidas.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridPartidas.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridPartidas.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridPartidas.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridPartidas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPartidas.Location = New System.Drawing.Point(3, 53)
        Me.GridPartidas.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GridPartidas.LookAndFeel.UseWindowsXPTheme = True
        Me.GridPartidas.MainView = Me.gPartidas
        Me.GridPartidas.Name = "GridPartidas"
        Me.GridPartidas.Size = New System.Drawing.Size(677, 261)
        Me.GridPartidas.TabIndex = 19
        Me.GridPartidas.UseEmbeddedNavigator = True
        Me.GridPartidas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gPartidas})
        '
        'gPartidas
        '
        Me.gPartidas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTK_FECVIG, Me.colTK_CODENT, Me.colTK_CODPAR, Me.colTK_CAMPO8, Me.colTK_DESCRI, Me.colTK_DCORTA, Me.colTK_ACTIVA, Me.colTK_CREOREND, Me.colTK_CUADRO, Me.colTK_MONFIJ, Me.colTK_ORDEN, Me.colTK_OPERACION, Me.colTK_ESQUEMA, Me.colTK_NIVEL, Me.colTK_GENERATXT, Me.colTK_NIVELTAB, Me.colTK_RELATIVO, Me.colTK_INDEX})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colTK_ACTIVA
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "0"
        Me.gPartidas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gPartidas.GridControl = Me.GridPartidas
        Me.gPartidas.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.gPartidas.Name = "gPartidas"
        Me.gPartidas.OptionsBehavior.Editable = False
        Me.gPartidas.OptionsMenu.EnableColumnMenu = False
        Me.gPartidas.OptionsView.ColumnAutoWidth = False
        Me.gPartidas.OptionsView.ShowGroupPanel = False
        Me.gPartidas.PaintStyleName = "WindowsXP"
        Me.gPartidas.RowHeight = 19
        '
        'colTK_FECVIG
        '
        Me.colTK_FECVIG.Caption = "Fecha vigencia"
        Me.colTK_FECVIG.FieldName = "TK_FECVIG"
        Me.colTK_FECVIG.Name = "colTK_FECVIG"
        Me.colTK_FECVIG.Visible = True
        Me.colTK_FECVIG.VisibleIndex = 0
        '
        'colTK_CODENT
        '
        Me.colTK_CODENT.Caption = "TK_CODENT"
        Me.colTK_CODENT.FieldName = "TK_CODENT"
        Me.colTK_CODENT.Name = "colTK_CODENT"
        '
        'colTK_CODPAR
        '
        Me.colTK_CODPAR.Caption = "Partida"
        Me.colTK_CODPAR.FieldName = "TK_CODPAR"
        Me.colTK_CODPAR.Name = "colTK_CODPAR"
        Me.colTK_CODPAR.Visible = True
        Me.colTK_CODPAR.VisibleIndex = 1
        '
        'colTK_CAMPO8
        '
        Me.colTK_CAMPO8.Caption = "Referencia"
        Me.colTK_CAMPO8.FieldName = "TK_CAMPO8"
        Me.colTK_CAMPO8.Name = "colTK_CAMPO8"
        Me.colTK_CAMPO8.Visible = True
        Me.colTK_CAMPO8.VisibleIndex = 2
        '
        'colTK_DESCRI
        '
        Me.colTK_DESCRI.Caption = "Descripción"
        Me.colTK_DESCRI.FieldName = "TK_DESCRI"
        Me.colTK_DESCRI.Name = "colTK_DESCRI"
        Me.colTK_DESCRI.Visible = True
        Me.colTK_DESCRI.VisibleIndex = 3
        Me.colTK_DESCRI.Width = 200
        '
        'colTK_DCORTA
        '
        Me.colTK_DCORTA.Caption = "Descrip. corta"
        Me.colTK_DCORTA.FieldName = "TK_DCORTA"
        Me.colTK_DCORTA.Name = "colTK_DCORTA"
        Me.colTK_DCORTA.Visible = True
        Me.colTK_DCORTA.VisibleIndex = 4
        Me.colTK_DCORTA.Width = 150
        '
        'colTK_CREOREND
        '
        Me.colTK_CREOREND.Caption = "Crecim. o Rend."
        Me.colTK_CREOREND.FieldName = "TK_CREOREND"
        Me.colTK_CREOREND.Name = "colTK_CREOREND"
        Me.colTK_CREOREND.Visible = True
        Me.colTK_CREOREND.VisibleIndex = 5
        '
        'colTK_CUADRO
        '
        Me.colTK_CUADRO.Caption = "TK_CUADRO"
        Me.colTK_CUADRO.FieldName = "TK_CUADRO"
        Me.colTK_CUADRO.Name = "colTK_CUADRO"
        '
        'colTK_MONFIJ
        '
        Me.colTK_MONFIJ.Caption = "Monto Fijo"
        Me.colTK_MONFIJ.FieldName = "TK_MONFIJ"
        Me.colTK_MONFIJ.Name = "colTK_MONFIJ"
        Me.colTK_MONFIJ.Visible = True
        Me.colTK_MONFIJ.VisibleIndex = 6
        '
        'colTK_ORDEN
        '
        Me.colTK_ORDEN.Caption = "TK_ORDEN"
        Me.colTK_ORDEN.FieldName = "TK_ORDEN"
        Me.colTK_ORDEN.Name = "colTK_ORDEN"
        '
        'colTK_OPERACION
        '
        Me.colTK_OPERACION.Caption = "Operación"
        Me.colTK_OPERACION.FieldName = "TK_OPERACION"
        Me.colTK_OPERACION.Name = "colTK_OPERACION"
        '
        'colTK_ESQUEMA
        '
        Me.colTK_ESQUEMA.Caption = "TK_ESQUEMA"
        Me.colTK_ESQUEMA.FieldName = "TK_ESQUEMA"
        Me.colTK_ESQUEMA.Name = "colTK_ESQUEMA"
        '
        'colTK_NIVEL
        '
        Me.colTK_NIVEL.Caption = "TK_NIVEL"
        Me.colTK_NIVEL.FieldName = "TK_NIVEL"
        Me.colTK_NIVEL.Name = "colTK_NIVEL"
        '
        'colTK_GENERATXT
        '
        Me.colTK_GENERATXT.Caption = "TK_GENERATXT"
        Me.colTK_GENERATXT.FieldName = "TK_GENERATXT"
        Me.colTK_GENERATXT.Name = "colTK_GENERATXT"
        '
        'colTK_NIVELTAB
        '
        Me.colTK_NIVELTAB.Caption = "TK_NIVELTAB"
        Me.colTK_NIVELTAB.FieldName = "TK_NIVELTAB"
        Me.colTK_NIVELTAB.Name = "colTK_NIVELTAB"
        '
        'colTK_RELATIVO
        '
        Me.colTK_RELATIVO.Caption = "TK_RELATIVO"
        Me.colTK_RELATIVO.FieldName = "TK_RELATIVO"
        Me.colTK_RELATIVO.Name = "colTK_RELATIVO"
        '
        'colTK_INDEX
        '
        Me.colTK_INDEX.Caption = "TK_INDEX"
        Me.colTK_INDEX.FieldName = "TK_INDEX"
        Me.colTK_INDEX.Name = "colTK_INDEX"
        '
        'toolAbmPartidas
        '
        Me.toolAbmPartidas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaPartida, Me.btnModifPartida, Me.btnDesactivarPartida, Me.ToolStripSeparator3, Me.btnImprimirPartidas, Me.btnExportarPartidas})
        Me.toolAbmPartidas.Location = New System.Drawing.Point(3, 28)
        Me.toolAbmPartidas.Name = "toolAbmPartidas"
        Me.toolAbmPartidas.Size = New System.Drawing.Size(677, 25)
        Me.toolAbmPartidas.TabIndex = 18
        Me.toolAbmPartidas.Text = "ToolStrip2"
        '
        'btnNuevaPartida
        '
        Me.btnNuevaPartida.Enabled = False
        Me.btnNuevaPartida.Image = Global.VBP04730.My.Resources.Resources._New
        Me.btnNuevaPartida.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevaPartida.Name = "btnNuevaPartida"
        Me.btnNuevaPartida.Size = New System.Drawing.Size(101, 22)
        Me.btnNuevaPartida.Text = "&Nueva Partida"
        '
        'btnModifPartida
        '
        Me.btnModifPartida.Enabled = False
        Me.btnModifPartida.Image = Global.VBP04730.My.Resources.Resources.Edit
        Me.btnModifPartida.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModifPartida.Name = "btnModifPartida"
        Me.btnModifPartida.Size = New System.Drawing.Size(78, 22)
        Me.btnModifPartida.Text = "&Modificar"
        '
        'btnDesactivarPartida
        '
        Me.btnDesactivarPartida.Enabled = False
        Me.btnDesactivarPartida.Image = Global.VBP04730.My.Resources.Resources.Delete_Blue
        Me.btnDesactivarPartida.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDesactivarPartida.Name = "btnDesactivarPartida"
        Me.btnDesactivarPartida.Size = New System.Drawing.Size(81, 22)
        Me.btnDesactivarPartida.Text = "Desactivar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimirPartidas
        '
        Me.btnImprimirPartidas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimirPartidas.Enabled = False
        Me.btnImprimirPartidas.Image = Global.VBP04730.My.Resources.Resources.Print
        Me.btnImprimirPartidas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirPartidas.Name = "btnImprimirPartidas"
        Me.btnImprimirPartidas.Size = New System.Drawing.Size(23, 22)
        Me.btnImprimirPartidas.Text = "Imprimir"
        Me.btnImprimirPartidas.ToolTipText = "Vista Previa de impresión"
        '
        'btnExportarPartidas
        '
        Me.btnExportarPartidas.Enabled = False
        Me.btnExportarPartidas.Image = Global.VBP04730.My.Resources.Resources.Export_Excel1
        Me.btnExportarPartidas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarPartidas.Name = "btnExportarPartidas"
        Me.btnExportarPartidas.Size = New System.Drawing.Size(70, 22)
        Me.btnExportarPartidas.Text = "Exportar"
        Me.btnExportarPartidas.ToolTipText = "Exportar grilla"
        '
        'toolPartidas
        '
        Me.toolPartidas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5, Me.cboFecVigPartida, Me.ToolStripLabel2, Me.cboCuadrosPartidas, Me.btnPresentarPartidas, Me.ToolStripSeparator2, Me.btnLimpiarPartidas})
        Me.toolPartidas.Location = New System.Drawing.Point(3, 3)
        Me.toolPartidas.Name = "toolPartidas"
        Me.toolPartidas.Size = New System.Drawing.Size(677, 25)
        Me.toolPartidas.TabIndex = 0
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel5.Text = "Período:"
        '
        'cboFecVigPartida
        '
        Me.cboFecVigPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFecVigPartida.Name = "cboFecVigPartida"
        Me.cboFecVigPartida.Size = New System.Drawing.Size(90, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel2.Text = "    Cuadro:"
        '
        'cboCuadrosPartidas
        '
        Me.cboCuadrosPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuadrosPartidas.Name = "cboCuadrosPartidas"
        Me.cboCuadrosPartidas.Size = New System.Drawing.Size(210, 25)
        '
        'btnPresentarPartidas
        '
        Me.btnPresentarPartidas.Image = Global.VBP04730.My.Resources.Resources.Execute
        Me.btnPresentarPartidas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPresentarPartidas.Name = "btnPresentarPartidas"
        Me.btnPresentarPartidas.Size = New System.Drawing.Size(76, 22)
        Me.btnPresentarPartidas.Text = "&Presentar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpiarPartidas
        '
        Me.btnLimpiarPartidas.Enabled = False
        Me.btnLimpiarPartidas.Image = Global.VBP04730.My.Resources.Resources.Undo
        Me.btnLimpiarPartidas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpiarPartidas.Name = "btnLimpiarPartidas"
        Me.btnLimpiarPartidas.Size = New System.Drawing.Size(67, 22)
        Me.btnLimpiarPartidas.Text = "&Limpiar"
        '
        'TabFuenteDatos
        '
        Me.TabFuenteDatos.Controls.Add(Me.GridFuentes)
        Me.TabFuenteDatos.Controls.Add(Me.toolABMFuentes)
        Me.TabFuenteDatos.Controls.Add(Me.toolFuentes)
        Me.TabFuenteDatos.Location = New System.Drawing.Point(4, 22)
        Me.TabFuenteDatos.Name = "TabFuenteDatos"
        Me.TabFuenteDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFuenteDatos.Size = New System.Drawing.Size(683, 317)
        Me.TabFuenteDatos.TabIndex = 1
        Me.TabFuenteDatos.Text = "Fuente de datos"
        Me.TabFuenteDatos.UseVisualStyleBackColor = True
        '
        'GridFuentes
        '
        Me.GridFuentes.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridFuentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFuentes.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridFuentes.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridFuentes.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridFuentes.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridFuentes.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridFuentes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridFuentes.Location = New System.Drawing.Point(3, 53)
        Me.GridFuentes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GridFuentes.LookAndFeel.UseWindowsXPTheme = True
        Me.GridFuentes.MainView = Me.gFuentes
        Me.GridFuentes.Name = "GridFuentes"
        Me.GridFuentes.Size = New System.Drawing.Size(677, 261)
        Me.GridFuentes.TabIndex = 22
        Me.GridFuentes.UseEmbeddedNavigator = True
        Me.GridFuentes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gFuentes})
        '
        'gFuentes
        '
        Me.gFuentes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTU_FECVIG, Me.colTU_CODENT, Me.colTU_CODCUE, Me.colTU_DESCRI, Me.colTU_ACTIVA, Me.colTU_TABLA})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colTU_ACTIVA
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "0"
        Me.gFuentes.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.gFuentes.GridControl = Me.GridFuentes
        Me.gFuentes.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.gFuentes.Name = "gFuentes"
        Me.gFuentes.OptionsBehavior.Editable = False
        Me.gFuentes.OptionsMenu.EnableColumnMenu = False
        Me.gFuentes.OptionsView.ColumnAutoWidth = False
        Me.gFuentes.OptionsView.ShowGroupPanel = False
        Me.gFuentes.PaintStyleName = "WindowsXP"
        Me.gFuentes.RowHeight = 19
        '
        'colTU_FECVIG
        '
        Me.colTU_FECVIG.Caption = "Fecha vigencia"
        Me.colTU_FECVIG.FieldName = "TU_FECVIG"
        Me.colTU_FECVIG.Name = "colTU_FECVIG"
        Me.colTU_FECVIG.Visible = True
        Me.colTU_FECVIG.VisibleIndex = 0
        Me.colTU_FECVIG.Width = 100
        '
        'colTU_CODENT
        '
        Me.colTU_CODENT.Caption = "TU_CODENT"
        Me.colTU_CODENT.FieldName = "TU_CODENT"
        Me.colTU_CODENT.Name = "colTU_CODENT"
        '
        'colTU_CODCUE
        '
        Me.colTU_CODCUE.Caption = "Código cuenta"
        Me.colTU_CODCUE.FieldName = "TU_CODCUE"
        Me.colTU_CODCUE.Name = "colTU_CODCUE"
        Me.colTU_CODCUE.Visible = True
        Me.colTU_CODCUE.VisibleIndex = 1
        Me.colTU_CODCUE.Width = 100
        '
        'colTU_DESCRI
        '
        Me.colTU_DESCRI.Caption = "Descripción"
        Me.colTU_DESCRI.FieldName = "TU_DESCRI"
        Me.colTU_DESCRI.Name = "colTU_DESCRI"
        Me.colTU_DESCRI.Visible = True
        Me.colTU_DESCRI.VisibleIndex = 2
        Me.colTU_DESCRI.Width = 300
        '
        'colTU_TABLA
        '
        Me.colTU_TABLA.Caption = "TU_TABLA"
        Me.colTU_TABLA.FieldName = "TU_TABLA"
        Me.colTU_TABLA.Name = "colTU_TABLA"
        '
        'toolABMFuentes
        '
        Me.toolABMFuentes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaFuente, Me.btnModifFuente, Me.btnDesactivarFuente, Me.ToolStripSeparator1, Me.btnImprimirFuentes, Me.btnExportarFuentes})
        Me.toolABMFuentes.Location = New System.Drawing.Point(3, 28)
        Me.toolABMFuentes.Name = "toolABMFuentes"
        Me.toolABMFuentes.Size = New System.Drawing.Size(677, 25)
        Me.toolABMFuentes.TabIndex = 21
        Me.toolABMFuentes.Text = "ToolStrip2"
        '
        'btnNuevaFuente
        '
        Me.btnNuevaFuente.Enabled = False
        Me.btnNuevaFuente.Image = Global.VBP04730.My.Resources.Resources._New
        Me.btnNuevaFuente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevaFuente.Name = "btnNuevaFuente"
        Me.btnNuevaFuente.Size = New System.Drawing.Size(100, 22)
        Me.btnNuevaFuente.Text = "&Nueva Fuente"
        '
        'btnModifFuente
        '
        Me.btnModifFuente.Enabled = False
        Me.btnModifFuente.Image = Global.VBP04730.My.Resources.Resources.Edit
        Me.btnModifFuente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModifFuente.Name = "btnModifFuente"
        Me.btnModifFuente.Size = New System.Drawing.Size(78, 22)
        Me.btnModifFuente.Text = "&Modificar"
        '
        'btnDesactivarFuente
        '
        Me.btnDesactivarFuente.Enabled = False
        Me.btnDesactivarFuente.Image = Global.VBP04730.My.Resources.Resources.Delete_Blue
        Me.btnDesactivarFuente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDesactivarFuente.Name = "btnDesactivarFuente"
        Me.btnDesactivarFuente.Size = New System.Drawing.Size(81, 22)
        Me.btnDesactivarFuente.Text = "Desactivar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimirFuentes
        '
        Me.btnImprimirFuentes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimirFuentes.Enabled = False
        Me.btnImprimirFuentes.Image = Global.VBP04730.My.Resources.Resources.Print
        Me.btnImprimirFuentes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirFuentes.Name = "btnImprimirFuentes"
        Me.btnImprimirFuentes.Size = New System.Drawing.Size(23, 22)
        Me.btnImprimirFuentes.Text = "Imprimir"
        Me.btnImprimirFuentes.ToolTipText = "Vista Previa de impresión"
        '
        'btnExportarFuentes
        '
        Me.btnExportarFuentes.Enabled = False
        Me.btnExportarFuentes.Image = Global.VBP04730.My.Resources.Resources.Export_Excel1
        Me.btnExportarFuentes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarFuentes.Name = "btnExportarFuentes"
        Me.btnExportarFuentes.Size = New System.Drawing.Size(70, 22)
        Me.btnExportarFuentes.Text = "Exportar"
        Me.btnExportarFuentes.ToolTipText = "Exportar grilla"
        '
        'toolFuentes
        '
        Me.toolFuentes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.cboFecVigFuentes, Me.ToolStripLabel4, Me.cboTablaFuentes, Me.btnPresentarFuentes, Me.ToolStripSeparator4, Me.btnLimpiarFuentes})
        Me.toolFuentes.Location = New System.Drawing.Point(3, 3)
        Me.toolFuentes.Name = "toolFuentes"
        Me.toolFuentes.Size = New System.Drawing.Size(677, 25)
        Me.toolFuentes.TabIndex = 20
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel3.Text = "Período:"
        '
        'cboFecVigFuentes
        '
        Me.cboFecVigFuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFecVigFuentes.Name = "cboFecVigFuentes"
        Me.cboFecVigFuentes.Size = New System.Drawing.Size(90, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel4.Text = "    Tabla:"
        '
        'cboTablaFuentes
        '
        Me.cboTablaFuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTablaFuentes.Name = "cboTablaFuentes"
        Me.cboTablaFuentes.Size = New System.Drawing.Size(220, 25)
        '
        'btnPresentarFuentes
        '
        Me.btnPresentarFuentes.Image = Global.VBP04730.My.Resources.Resources.Execute
        Me.btnPresentarFuentes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPresentarFuentes.Name = "btnPresentarFuentes"
        Me.btnPresentarFuentes.Size = New System.Drawing.Size(76, 22)
        Me.btnPresentarFuentes.Text = "&Presentar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpiarFuentes
        '
        Me.btnLimpiarFuentes.Enabled = False
        Me.btnLimpiarFuentes.Image = Global.VBP04730.My.Resources.Resources.Undo
        Me.btnLimpiarFuentes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpiarFuentes.Name = "btnLimpiarFuentes"
        Me.btnLimpiarFuentes.Size = New System.Drawing.Size(67, 22)
        Me.btnLimpiarFuentes.Text = "&Limpiar"
        '
        'TabRelFuenteDatos
        '
        Me.TabRelFuenteDatos.Controls.Add(Me.splitRel)
        Me.TabRelFuenteDatos.Controls.Add(Me.panRelBotton)
        Me.TabRelFuenteDatos.Controls.Add(Me.panRelTop)
        Me.TabRelFuenteDatos.Location = New System.Drawing.Point(4, 22)
        Me.TabRelFuenteDatos.Name = "TabRelFuenteDatos"
        Me.TabRelFuenteDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRelFuenteDatos.Size = New System.Drawing.Size(683, 317)
        Me.TabRelFuenteDatos.TabIndex = 2
        Me.TabRelFuenteDatos.Text = "Relación fuentes de datos"
        Me.TabRelFuenteDatos.UseVisualStyleBackColor = True
        '
        'splitRel
        '
        Me.splitRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitRel.Location = New System.Drawing.Point(3, 84)
        Me.splitRel.Name = "splitRel"
        '
        'splitRel.Panel1
        '
        Me.splitRel.Panel1.Controls.Add(Me.lvNoRel)
        Me.splitRel.Panel1.Controls.Add(Me.Panel2)
        '
        'splitRel.Panel2
        '
        Me.splitRel.Panel2.Controls.Add(Me.lvSiRel)
        Me.splitRel.Panel2.Controls.Add(Me.Panel3)
        Me.splitRel.Size = New System.Drawing.Size(677, 172)
        Me.splitRel.SplitterDistance = 338
        Me.splitRel.TabIndex = 2
        '
        'lvNoRel
        '
        Me.lvNoRel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col1})
        Me.lvNoRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNoRel.FullRowSelect = True
        Me.lvNoRel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvNoRel.Location = New System.Drawing.Point(0, 33)
        Me.lvNoRel.MultiSelect = False
        Me.lvNoRel.Name = "lvNoRel"
        Me.lvNoRel.ShowGroups = False
        Me.lvNoRel.Size = New System.Drawing.Size(338, 139)
        Me.lvNoRel.TabIndex = 2
        Me.lvNoRel.UseCompatibleStateImageBehavior = False
        Me.lvNoRel.View = System.Windows.Forms.View.Details
        '
        'col1
        '
        Me.col1.Text = "No Integra"
        Me.col1.Width = 316
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 33)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmdNoTodosRel)
        Me.Panel4.Controls.Add(Me.cmdNoUnoRel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(273, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(65, 33)
        Me.Panel4.TabIndex = 2
        '
        'cmdNoTodosRel
        '
        Me.cmdNoTodosRel.Image = Global.VBP04730.My.Resources.Resources.mm_Rewind
        Me.cmdNoTodosRel.Location = New System.Drawing.Point(36, 3)
        Me.cmdNoTodosRel.Name = "cmdNoTodosRel"
        Me.cmdNoTodosRel.Size = New System.Drawing.Size(28, 28)
        Me.cmdNoTodosRel.TabIndex = 4
        Me.cmdNoTodosRel.UseVisualStyleBackColor = True
        '
        'cmdNoUnoRel
        '
        Me.cmdNoUnoRel.Image = Global.VBP04730.My.Resources.Resources.mm_First
        Me.cmdNoUnoRel.Location = New System.Drawing.Point(6, 3)
        Me.cmdNoUnoRel.Name = "cmdNoUnoRel"
        Me.cmdNoUnoRel.Size = New System.Drawing.Size(28, 28)
        Me.cmdNoUnoRel.TabIndex = 3
        Me.cmdNoUnoRel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Integra"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvSiRel
        '
        Me.lvSiRel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvSiRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSiRel.FullRowSelect = True
        Me.lvSiRel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvSiRel.Location = New System.Drawing.Point(0, 33)
        Me.lvSiRel.MultiSelect = False
        Me.lvSiRel.Name = "lvSiRel"
        Me.lvSiRel.ShowGroups = False
        Me.lvSiRel.Size = New System.Drawing.Size(335, 139)
        Me.lvSiRel.TabIndex = 3
        Me.lvSiRel.UseCompatibleStateImageBehavior = False
        Me.lvSiRel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No Integra"
        Me.ColumnHeader1.Width = 316
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdSiUnoRel)
        Me.Panel3.Controls.Add(Me.cmdSiTodosRel)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 33)
        Me.Panel3.TabIndex = 0
        '
        'cmdSiUnoRel
        '
        Me.cmdSiUnoRel.Image = Global.VBP04730.My.Resources.Resources.mm_Last
        Me.cmdSiUnoRel.Location = New System.Drawing.Point(31, 3)
        Me.cmdSiUnoRel.Name = "cmdSiUnoRel"
        Me.cmdSiUnoRel.Size = New System.Drawing.Size(28, 28)
        Me.cmdSiUnoRel.TabIndex = 6
        Me.cmdSiUnoRel.UseVisualStyleBackColor = True
        '
        'cmdSiTodosRel
        '
        Me.cmdSiTodosRel.Image = Global.VBP04730.My.Resources.Resources.mm_Fast_Forward
        Me.cmdSiTodosRel.Location = New System.Drawing.Point(1, 3)
        Me.cmdSiTodosRel.Name = "cmdSiTodosRel"
        Me.cmdSiTodosRel.Size = New System.Drawing.Size(28, 28)
        Me.cmdSiTodosRel.TabIndex = 5
        Me.cmdSiTodosRel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Si Integra"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panRelBotton
        '
        Me.panRelBotton.Controls.Add(Me.cmdGuardarRel)
        Me.panRelBotton.Controls.Add(Me.cmdCancelarRel)
        Me.panRelBotton.Controls.Add(Me.cmdExportarRel)
        Me.panRelBotton.Controls.Add(Me.cmdImprimirRel)
        Me.panRelBotton.Controls.Add(Me.Label4)
        Me.panRelBotton.Controls.Add(Me.Label3)
        Me.panRelBotton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panRelBotton.Location = New System.Drawing.Point(3, 256)
        Me.panRelBotton.Name = "panRelBotton"
        Me.panRelBotton.Size = New System.Drawing.Size(677, 58)
        Me.panRelBotton.TabIndex = 1
        '
        'cmdGuardarRel
        '
        Me.cmdGuardarRel.Enabled = False
        Me.cmdGuardarRel.Location = New System.Drawing.Point(85, 5)
        Me.cmdGuardarRel.Name = "cmdGuardarRel"
        Me.cmdGuardarRel.Size = New System.Drawing.Size(79, 23)
        Me.cmdGuardarRel.TabIndex = 10
        Me.cmdGuardarRel.Text = "&Guardar"
        Me.cmdGuardarRel.UseVisualStyleBackColor = True
        '
        'cmdCancelarRel
        '
        Me.cmdCancelarRel.Location = New System.Drawing.Point(85, 35)
        Me.cmdCancelarRel.Name = "cmdCancelarRel"
        Me.cmdCancelarRel.Size = New System.Drawing.Size(79, 23)
        Me.cmdCancelarRel.TabIndex = 12
        Me.cmdCancelarRel.Text = "&Cancelar"
        Me.cmdCancelarRel.UseVisualStyleBackColor = True
        '
        'cmdExportarRel
        '
        Me.cmdExportarRel.Enabled = False
        Me.cmdExportarRel.Location = New System.Drawing.Point(0, 35)
        Me.cmdExportarRel.Name = "cmdExportarRel"
        Me.cmdExportarRel.Size = New System.Drawing.Size(79, 23)
        Me.cmdExportarRel.TabIndex = 11
        Me.cmdExportarRel.Text = "&Exportar"
        Me.cmdExportarRel.UseVisualStyleBackColor = True
        '
        'cmdImprimirRel
        '
        Me.cmdImprimirRel.Enabled = False
        Me.cmdImprimirRel.Location = New System.Drawing.Point(0, 5)
        Me.cmdImprimirRel.Name = "cmdImprimirRel"
        Me.cmdImprimirRel.Size = New System.Drawing.Size(79, 23)
        Me.cmdImprimirRel.TabIndex = 9
        Me.cmdImprimirRel.Text = "&Imprimir"
        Me.cmdImprimirRel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(168, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cuentas Seleccionadas:"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(168, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(495, 43)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'panRelTop
        '
        Me.panRelTop.Controls.Add(Me.cmdLimpiarRel)
        Me.panRelTop.Controls.Add(Me.cmdPresentarRel)
        Me.panRelTop.Controls.Add(Me.cboTablaRel)
        Me.panRelTop.Controls.Add(Me.Label9)
        Me.panRelTop.Controls.Add(Me.cboCodParRel)
        Me.panRelTop.Controls.Add(Me.Label8)
        Me.panRelTop.Controls.Add(Me.cboFecVigRel)
        Me.panRelTop.Controls.Add(Me.Label7)
        Me.panRelTop.Controls.Add(Me.cboCampo8Rel)
        Me.panRelTop.Controls.Add(Me.Label6)
        Me.panRelTop.Controls.Add(Me.cboCuadroRel)
        Me.panRelTop.Controls.Add(Me.Label5)
        Me.panRelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panRelTop.Location = New System.Drawing.Point(3, 3)
        Me.panRelTop.Name = "panRelTop"
        Me.panRelTop.Size = New System.Drawing.Size(677, 81)
        Me.panRelTop.TabIndex = 0
        '
        'cmdLimpiarRel
        '
        Me.cmdLimpiarRel.Location = New System.Drawing.Point(571, 55)
        Me.cmdLimpiarRel.Name = "cmdLimpiarRel"
        Me.cmdLimpiarRel.Size = New System.Drawing.Size(96, 21)
        Me.cmdLimpiarRel.TabIndex = 6
        Me.cmdLimpiarRel.Text = "&Limpiar"
        Me.cmdLimpiarRel.UseVisualStyleBackColor = True
        '
        'cmdPresentarRel
        '
        Me.cmdPresentarRel.Location = New System.Drawing.Point(471, 55)
        Me.cmdPresentarRel.Name = "cmdPresentarRel"
        Me.cmdPresentarRel.Size = New System.Drawing.Size(96, 21)
        Me.cmdPresentarRel.TabIndex = 5
        Me.cmdPresentarRel.Text = "&Presentar"
        Me.cmdPresentarRel.UseVisualStyleBackColor = True
        '
        'cboTablaRel
        '
        Me.cboTablaRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTablaRel.FormattingEnabled = True
        Me.cboTablaRel.Location = New System.Drawing.Point(78, 55)
        Me.cboTablaRel.Name = "cboTablaRel"
        Me.cboTablaRel.Size = New System.Drawing.Size(255, 21)
        Me.cboTablaRel.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tabla:"
        '
        'cboCodParRel
        '
        Me.cboCodParRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodParRel.FormattingEnabled = True
        Me.cboCodParRel.Location = New System.Drawing.Point(78, 31)
        Me.cboCodParRel.Name = "cboCodParRel"
        Me.cboCodParRel.Size = New System.Drawing.Size(255, 21)
        Me.cboCodParRel.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Partida:"
        '
        'cboFecVigRel
        '
        Me.cboFecVigRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFecVigRel.FormattingEnabled = True
        Me.cboFecVigRel.Location = New System.Drawing.Point(78, 7)
        Me.cboFecVigRel.Name = "cboFecVigRel"
        Me.cboFecVigRel.Size = New System.Drawing.Size(255, 21)
        Me.cboFecVigRel.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Período:"
        '
        'cboCampo8Rel
        '
        Me.cboCampo8Rel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampo8Rel.FormattingEnabled = True
        Me.cboCampo8Rel.Location = New System.Drawing.Point(412, 30)
        Me.cboCampo8Rel.Name = "cboCampo8Rel"
        Me.cboCampo8Rel.Size = New System.Drawing.Size(255, 21)
        Me.cboCampo8Rel.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Referencia:"
        '
        'cboCuadroRel
        '
        Me.cboCuadroRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuadroRel.FormattingEnabled = True
        Me.cboCuadroRel.Location = New System.Drawing.Point(412, 7)
        Me.cboCuadroRel.Name = "cboCuadroRel"
        Me.cboCuadroRel.Size = New System.Drawing.Size(255, 21)
        Me.cboCuadroRel.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cuadro:"
        '
        'TabPartidasRdo
        '
        Me.TabPartidasRdo.Controls.Add(Me.SplitContainer2)
        Me.TabPartidasRdo.Controls.Add(Me.Panel13)
        Me.TabPartidasRdo.Controls.Add(Me.toolRdo)
        Me.TabPartidasRdo.Location = New System.Drawing.Point(4, 22)
        Me.TabPartidasRdo.Name = "TabPartidasRdo"
        Me.TabPartidasRdo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPartidasRdo.Size = New System.Drawing.Size(683, 317)
        Me.TabPartidasRdo.TabIndex = 3
        Me.TabPartidasRdo.Text = "Relación Partidas Rtdo."
        Me.TabPartidasRdo.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvNoRdo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel10)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lvSiRdo)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel12)
        Me.SplitContainer2.Size = New System.Drawing.Size(677, 228)
        Me.SplitContainer2.SplitterDistance = 338
        Me.SplitContainer2.TabIndex = 8
        '
        'lvNoRdo
        '
        Me.lvNoRdo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.lvNoRdo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNoRdo.FullRowSelect = True
        Me.lvNoRdo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvNoRdo.Location = New System.Drawing.Point(0, 33)
        Me.lvNoRdo.MultiSelect = False
        Me.lvNoRdo.Name = "lvNoRdo"
        Me.lvNoRdo.ShowGroups = False
        Me.lvNoRdo.Size = New System.Drawing.Size(338, 195)
        Me.lvNoRdo.TabIndex = 2
        Me.lvNoRdo.UseCompatibleStateImageBehavior = False
        Me.lvNoRdo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No Integra"
        Me.ColumnHeader4.Width = 316
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Label19)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(338, 33)
        Me.Panel10.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.cmdNoTodosRdo)
        Me.Panel11.Controls.Add(Me.cmdNoUnoRdo)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(273, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(65, 33)
        Me.Panel11.TabIndex = 2
        '
        'cmdNoTodosRdo
        '
        Me.cmdNoTodosRdo.Image = Global.VBP04730.My.Resources.Resources.mm_Rewind
        Me.cmdNoTodosRdo.Location = New System.Drawing.Point(36, 3)
        Me.cmdNoTodosRdo.Name = "cmdNoTodosRdo"
        Me.cmdNoTodosRdo.Size = New System.Drawing.Size(28, 28)
        Me.cmdNoTodosRdo.TabIndex = 4
        Me.cmdNoTodosRdo.UseVisualStyleBackColor = True
        '
        'cmdNoUnoRdo
        '
        Me.cmdNoUnoRdo.Image = Global.VBP04730.My.Resources.Resources.mm_First
        Me.cmdNoUnoRdo.Location = New System.Drawing.Point(6, 3)
        Me.cmdNoUnoRdo.Name = "cmdNoUnoRdo"
        Me.cmdNoUnoRdo.Size = New System.Drawing.Size(28, 28)
        Me.cmdNoUnoRdo.TabIndex = 3
        Me.cmdNoUnoRdo.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 33)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "No Integra"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvSiRdo
        '
        Me.lvSiRdo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5})
        Me.lvSiRdo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSiRdo.FullRowSelect = True
        Me.lvSiRdo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvSiRdo.Location = New System.Drawing.Point(0, 33)
        Me.lvSiRdo.MultiSelect = False
        Me.lvSiRdo.Name = "lvSiRdo"
        Me.lvSiRdo.ShowGroups = False
        Me.lvSiRdo.Size = New System.Drawing.Size(335, 195)
        Me.lvSiRdo.TabIndex = 3
        Me.lvSiRdo.UseCompatibleStateImageBehavior = False
        Me.lvSiRdo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "No Integra"
        Me.ColumnHeader5.Width = 316
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.cmdSiUnoRdo)
        Me.Panel12.Controls.Add(Me.cmdSiTodosRdo)
        Me.Panel12.Controls.Add(Me.Label20)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(335, 33)
        Me.Panel12.TabIndex = 0
        '
        'cmdSiUnoRdo
        '
        Me.cmdSiUnoRdo.Image = Global.VBP04730.My.Resources.Resources.mm_Last
        Me.cmdSiUnoRdo.Location = New System.Drawing.Point(31, 3)
        Me.cmdSiUnoRdo.Name = "cmdSiUnoRdo"
        Me.cmdSiUnoRdo.Size = New System.Drawing.Size(28, 28)
        Me.cmdSiUnoRdo.TabIndex = 6
        Me.cmdSiUnoRdo.UseVisualStyleBackColor = True
        '
        'cmdSiTodosRdo
        '
        Me.cmdSiTodosRdo.Image = Global.VBP04730.My.Resources.Resources.mm_Fast_Forward
        Me.cmdSiTodosRdo.Location = New System.Drawing.Point(1, 3)
        Me.cmdSiTodosRdo.Name = "cmdSiTodosRdo"
        Me.cmdSiTodosRdo.Size = New System.Drawing.Size(28, 28)
        Me.cmdSiTodosRdo.TabIndex = 5
        Me.cmdSiTodosRdo.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(273, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 33)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Si Integra"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.cmdGuardarRdo)
        Me.Panel13.Controls.Add(Me.cmdCancelarRdo)
        Me.Panel13.Controls.Add(Me.cmdExportarRdo)
        Me.Panel13.Controls.Add(Me.cmdImprimirRdo)
        Me.Panel13.Controls.Add(Me.Label22)
        Me.Panel13.Controls.Add(Me.Label21)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(3, 256)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(677, 58)
        Me.Panel13.TabIndex = 7
        '
        'cmdGuardarRdo
        '
        Me.cmdGuardarRdo.Location = New System.Drawing.Point(85, 5)
        Me.cmdGuardarRdo.Name = "cmdGuardarRdo"
        Me.cmdGuardarRdo.Size = New System.Drawing.Size(79, 23)
        Me.cmdGuardarRdo.TabIndex = 10
        Me.cmdGuardarRdo.Text = "&Guardar"
        Me.cmdGuardarRdo.UseVisualStyleBackColor = True
        '
        'cmdCancelarRdo
        '
        Me.cmdCancelarRdo.Location = New System.Drawing.Point(85, 35)
        Me.cmdCancelarRdo.Name = "cmdCancelarRdo"
        Me.cmdCancelarRdo.Size = New System.Drawing.Size(79, 23)
        Me.cmdCancelarRdo.TabIndex = 12
        Me.cmdCancelarRdo.Text = "&Cancelar"
        Me.cmdCancelarRdo.UseVisualStyleBackColor = True
        '
        'cmdExportarRdo
        '
        Me.cmdExportarRdo.Enabled = False
        Me.cmdExportarRdo.Location = New System.Drawing.Point(0, 35)
        Me.cmdExportarRdo.Name = "cmdExportarRdo"
        Me.cmdExportarRdo.Size = New System.Drawing.Size(79, 23)
        Me.cmdExportarRdo.TabIndex = 11
        Me.cmdExportarRdo.Text = "&Exportar"
        Me.cmdExportarRdo.UseVisualStyleBackColor = True
        '
        'cmdImprimirRdo
        '
        Me.cmdImprimirRdo.Enabled = False
        Me.cmdImprimirRdo.Location = New System.Drawing.Point(0, 5)
        Me.cmdImprimirRdo.Name = "cmdImprimirRdo"
        Me.cmdImprimirRdo.Size = New System.Drawing.Size(79, 23)
        Me.cmdImprimirRdo.TabIndex = 9
        Me.cmdImprimirRdo.Text = "&Imprimir"
        Me.cmdImprimirRdo.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(168, 4)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(144, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Cuentas Seleccionadas:"
        '
        'Label21
        '
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(168, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(495, 43)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = resources.GetString("Label21.Text")
        '
        'toolRdo
        '
        Me.toolRdo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboFecVigRdo, Me.ToolStripLabel7, Me.cboCodParRdo, Me.btnPresentarRdo, Me.ToolStripSeparator8, Me.btnLimpiarRdo})
        Me.toolRdo.Location = New System.Drawing.Point(3, 3)
        Me.toolRdo.Name = "toolRdo"
        Me.toolRdo.Size = New System.Drawing.Size(677, 25)
        Me.toolRdo.TabIndex = 6
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel1.Text = "Período:"
        '
        'cboFecVigRdo
        '
        Me.cboFecVigRdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFecVigRdo.Name = "cboFecVigRdo"
        Me.cboFecVigRdo.Size = New System.Drawing.Size(90, 25)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel7.Text = "    Partida:"
        '
        'cboCodParRdo
        '
        Me.cboCodParRdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodParRdo.Name = "cboCodParRdo"
        Me.cboCodParRdo.Size = New System.Drawing.Size(300, 25)
        '
        'btnPresentarRdo
        '
        Me.btnPresentarRdo.Image = Global.VBP04730.My.Resources.Resources.Execute
        Me.btnPresentarRdo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPresentarRdo.Name = "btnPresentarRdo"
        Me.btnPresentarRdo.Size = New System.Drawing.Size(76, 22)
        Me.btnPresentarRdo.Text = "&Presentar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpiarRdo
        '
        Me.btnLimpiarRdo.Enabled = False
        Me.btnLimpiarRdo.Image = Global.VBP04730.My.Resources.Resources.Undo
        Me.btnLimpiarRdo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpiarRdo.Name = "btnLimpiarRdo"
        Me.btnLimpiarRdo.Size = New System.Drawing.Size(67, 22)
        Me.btnLimpiarRdo.Text = "&Limpiar"
        '
        'TabRelTec
        '
        Me.TabRelTec.Controls.Add(Me.GridRelTec)
        Me.TabRelTec.Controls.Add(Me.toolAbmRelTec)
        Me.TabRelTec.Controls.Add(Me.toolRelTec)
        Me.TabRelTec.Location = New System.Drawing.Point(4, 22)
        Me.TabRelTec.Name = "TabRelTec"
        Me.TabRelTec.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRelTec.Size = New System.Drawing.Size(683, 317)
        Me.TabRelTec.TabIndex = 4
        Me.TabRelTec.Text = "Relaciones técnicas"
        Me.TabRelTec.UseVisualStyleBackColor = True
        '
        'GridRelTec
        '
        Me.GridRelTec.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridRelTec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRelTec.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridRelTec.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridRelTec.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridRelTec.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridRelTec.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridRelTec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridRelTec.Location = New System.Drawing.Point(3, 28)
        Me.GridRelTec.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GridRelTec.LookAndFeel.UseWindowsXPTheme = True
        Me.GridRelTec.MainView = Me.gRelTec
        Me.GridRelTec.Name = "GridRelTec"
        Me.GridRelTec.Size = New System.Drawing.Size(677, 286)
        Me.GridRelTec.TabIndex = 22
        Me.GridRelTec.UseEmbeddedNavigator = True
        Me.GridRelTec.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gRelTec})
        '
        'gRelTec
        '
        Me.gRelTec.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRT_CODENT, Me.colXX_ENTIDA, Me.colRT_CODRTC, Me.colRT_FECVIG, Me.colRT_CODPAR, Me.colRT_EOAFNG, Me.colRT_CUADRO, Me.XX_CUADRO})
        Me.gRelTec.GridControl = Me.GridRelTec
        Me.gRelTec.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.gRelTec.Name = "gRelTec"
        Me.gRelTec.OptionsBehavior.Editable = False
        Me.gRelTec.OptionsMenu.EnableColumnMenu = False
        Me.gRelTec.OptionsView.ColumnAutoWidth = False
        Me.gRelTec.OptionsView.ShowGroupPanel = False
        Me.gRelTec.PaintStyleName = "WindowsXP"
        Me.gRelTec.RowHeight = 19
        '
        'colRT_CODENT
        '
        Me.colRT_CODENT.FieldName = "RT_CODENT"
        Me.colRT_CODENT.Name = "colRT_CODENT"
        Me.colRT_CODENT.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        '
        'colXX_ENTIDA
        '
        Me.colXX_ENTIDA.Caption = "Entidad"
        Me.colXX_ENTIDA.FieldName = "XX_ENTIDA"
        Me.colXX_ENTIDA.Name = "colXX_ENTIDA"
        Me.colXX_ENTIDA.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colXX_ENTIDA.Visible = True
        Me.colXX_ENTIDA.VisibleIndex = 1
        Me.colXX_ENTIDA.Width = 150
        '
        'colRT_CODRTC
        '
        Me.colRT_CODRTC.Caption = "Relación 1"
        Me.colRT_CODRTC.FieldName = "RT_CODRTC"
        Me.colRT_CODRTC.Name = "colRT_CODRTC"
        Me.colRT_CODRTC.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colRT_CODRTC.Visible = True
        Me.colRT_CODRTC.VisibleIndex = 2
        Me.colRT_CODRTC.Width = 100
        '
        'colRT_FECVIG
        '
        Me.colRT_FECVIG.Caption = "Fecha vig."
        Me.colRT_FECVIG.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colRT_FECVIG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colRT_FECVIG.FieldName = "RT_FECVIG"
        Me.colRT_FECVIG.Name = "colRT_FECVIG"
        Me.colRT_FECVIG.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colRT_FECVIG.Visible = True
        Me.colRT_FECVIG.VisibleIndex = 0
        Me.colRT_FECVIG.Width = 90
        '
        'colRT_CODPAR
        '
        Me.colRT_CODPAR.Caption = "Cód. Partida"
        Me.colRT_CODPAR.FieldName = "RT_CODPAR"
        Me.colRT_CODPAR.Name = "colRT_CODPAR"
        Me.colRT_CODPAR.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colRT_CODPAR.Visible = True
        Me.colRT_CODPAR.VisibleIndex = 3
        Me.colRT_CODPAR.Width = 100
        '
        'colRT_EOAFNG
        '
        Me.colRT_EOAFNG.Caption = "Relación 2"
        Me.colRT_EOAFNG.FieldName = "RT_EOAFNG"
        Me.colRT_EOAFNG.Name = "colRT_EOAFNG"
        Me.colRT_EOAFNG.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colRT_EOAFNG.Visible = True
        Me.colRT_EOAFNG.VisibleIndex = 4
        Me.colRT_EOAFNG.Width = 100
        '
        'colRT_CUADRO
        '
        Me.colRT_CUADRO.Caption = "Cod. Cuadro"
        Me.colRT_CUADRO.FieldName = "RT_CUADRO"
        Me.colRT_CUADRO.Name = "colRT_CUADRO"
        Me.colRT_CUADRO.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colRT_CUADRO.Width = 100
        '
        'XX_CUADRO
        '
        Me.XX_CUADRO.Caption = "Cuadro"
        Me.XX_CUADRO.FieldName = "XX_CUADRO"
        Me.XX_CUADRO.Name = "XX_CUADRO"
        Me.XX_CUADRO.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.XX_CUADRO.Visible = True
        Me.XX_CUADRO.VisibleIndex = 5
        Me.XX_CUADRO.Width = 120
        '
        'toolAbmRelTec
        '
        Me.toolAbmRelTec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaRelTec, Me.btnModifRelTec, Me.btnEliminarRelTec, Me.ToolStripSeparator9, Me.btnImprimirRelTec, Me.btnExportarRelTec})
        Me.toolAbmRelTec.Location = New System.Drawing.Point(3, 28)
        Me.toolAbmRelTec.Name = "toolAbmRelTec"
        Me.toolAbmRelTec.Size = New System.Drawing.Size(677, 25)
        Me.toolAbmRelTec.TabIndex = 21
        Me.toolAbmRelTec.Text = "ToolStrip2"
        Me.toolAbmRelTec.Visible = False
        '
        'btnNuevaRelTec
        '
        Me.btnNuevaRelTec.Enabled = False
        Me.btnNuevaRelTec.Image = Global.VBP04730.My.Resources.Resources._New
        Me.btnNuevaRelTec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevaRelTec.Name = "btnNuevaRelTec"
        Me.btnNuevaRelTec.Size = New System.Drawing.Size(69, 22)
        Me.btnNuevaRelTec.Text = "&Agregar"
        '
        'btnModifRelTec
        '
        Me.btnModifRelTec.Enabled = False
        Me.btnModifRelTec.Image = Global.VBP04730.My.Resources.Resources.Edit
        Me.btnModifRelTec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModifRelTec.Name = "btnModifRelTec"
        Me.btnModifRelTec.Size = New System.Drawing.Size(78, 22)
        Me.btnModifRelTec.Text = "&Modificar"
        '
        'btnEliminarRelTec
        '
        Me.btnEliminarRelTec.Enabled = False
        Me.btnEliminarRelTec.Image = Global.VBP04730.My.Resources.Resources.Delete_Blue
        Me.btnEliminarRelTec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarRelTec.Name = "btnEliminarRelTec"
        Me.btnEliminarRelTec.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminarRelTec.Text = "Eliminar"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimirRelTec
        '
        Me.btnImprimirRelTec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimirRelTec.Enabled = False
        Me.btnImprimirRelTec.Image = Global.VBP04730.My.Resources.Resources.Print
        Me.btnImprimirRelTec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirRelTec.Name = "btnImprimirRelTec"
        Me.btnImprimirRelTec.Size = New System.Drawing.Size(23, 22)
        Me.btnImprimirRelTec.Text = "Imprimir"
        Me.btnImprimirRelTec.ToolTipText = "Vista Previa de impresión"
        '
        'btnExportarRelTec
        '
        Me.btnExportarRelTec.Enabled = False
        Me.btnExportarRelTec.Image = Global.VBP04730.My.Resources.Resources.Export_Excel1
        Me.btnExportarRelTec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarRelTec.Name = "btnExportarRelTec"
        Me.btnExportarRelTec.Size = New System.Drawing.Size(70, 22)
        Me.btnExportarRelTec.Text = "Exportar"
        Me.btnExportarRelTec.ToolTipText = "Exportar grilla"
        '
        'toolRelTec
        '
        Me.toolRelTec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel9, Me.cboFecVigRelTec, Me.btnPresentarRelTec, Me.ToolStripSeparator10, Me.btnLimpiarRelTec})
        Me.toolRelTec.Location = New System.Drawing.Point(3, 3)
        Me.toolRelTec.Name = "toolRelTec"
        Me.toolRelTec.Size = New System.Drawing.Size(677, 25)
        Me.toolRelTec.TabIndex = 20
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel9.Text = "Período:"
        '
        'cboFecVigRelTec
        '
        Me.cboFecVigRelTec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFecVigRelTec.Name = "cboFecVigRelTec"
        Me.cboFecVigRelTec.Size = New System.Drawing.Size(90, 25)
        '
        'btnPresentarRelTec
        '
        Me.btnPresentarRelTec.Image = Global.VBP04730.My.Resources.Resources.Execute
        Me.btnPresentarRelTec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPresentarRelTec.Name = "btnPresentarRelTec"
        Me.btnPresentarRelTec.Size = New System.Drawing.Size(76, 22)
        Me.btnPresentarRelTec.Text = "&Presentar"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpiarRelTec
        '
        Me.btnLimpiarRelTec.Enabled = False
        Me.btnLimpiarRelTec.Image = Global.VBP04730.My.Resources.Resources.Undo
        Me.btnLimpiarRelTec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpiarRelTec.Name = "btnLimpiarRelTec"
        Me.btnLimpiarRelTec.Size = New System.Drawing.Size(67, 22)
        Me.btnLimpiarRelTec.Text = "&Limpiar"
        '
        'TabEstructura
        '
        Me.TabEstructura.Controls.Add(Me.tlEstructura)
        Me.TabEstructura.Controls.Add(Me.toolEstructura)
        Me.TabEstructura.Location = New System.Drawing.Point(4, 22)
        Me.TabEstructura.Name = "TabEstructura"
        Me.TabEstructura.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEstructura.Size = New System.Drawing.Size(683, 317)
        Me.TabEstructura.TabIndex = 5
        Me.TabEstructura.Text = "Estructura"
        Me.TabEstructura.UseVisualStyleBackColor = True
        '
        'tlEstructura
        '
        Me.tlEstructura.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colPartida, Me.colDescri, Me.colCampo8, Me.colClave, Me.colGeneraTXT})
        Me.tlEstructura.DataSource = Nothing
        Me.tlEstructura.Dock = System.Windows.Forms.DockStyle.Fill
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colGeneraTXT
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = False
        Me.tlEstructura.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition3})
        Me.tlEstructura.Location = New System.Drawing.Point(3, 28)
        Me.tlEstructura.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.tlEstructura.LookAndFeel.UseDefaultLookAndFeel = False
        Me.tlEstructura.LookAndFeel.UseWindowsXPTheme = True
        Me.tlEstructura.Name = "tlEstructura"
        Me.tlEstructura.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.[Single]
        Me.tlEstructura.OptionsSelection.MultiSelect = True
        Me.tlEstructura.OptionsView.ShowHorzLines = False
        Me.tlEstructura.OptionsView.ShowIndicator = False
        Me.tlEstructura.OptionsView.ShowVertLines = False
        Me.tlEstructura.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.tlEstructura.Size = New System.Drawing.Size(677, 286)
        Me.tlEstructura.TabIndex = 3
        '
        'colPartida
        '
        Me.colPartida.Caption = "Partida"
        Me.colPartida.FieldName = "TK_CODPAR"
        Me.colPartida.Name = "colPartida"
        Me.colPartida.OptionsColumn.AllowEdit = False
        Me.colPartida.Visible = True
        Me.colPartida.VisibleIndex = 0
        Me.colPartida.Width = 128
        '
        'colDescri
        '
        Me.colDescri.Caption = "Descripción"
        Me.colDescri.FieldName = "TK_DESCRI"
        Me.colDescri.Name = "colDescri"
        Me.colDescri.OptionsColumn.AllowEdit = False
        Me.colDescri.Visible = True
        Me.colDescri.VisibleIndex = 1
        Me.colDescri.Width = 298
        '
        'colCampo8
        '
        Me.colCampo8.Caption = "Relación"
        Me.colCampo8.FieldName = "TK_CAMPO8"
        Me.colCampo8.Name = "colCampo8"
        Me.colCampo8.OptionsColumn.AllowEdit = False
        Me.colCampo8.Visible = True
        Me.colCampo8.VisibleIndex = 2
        Me.colCampo8.Width = 234
        '
        'colClave
        '
        Me.colClave.Caption = "Clave"
        Me.colClave.FieldName = "Clave"
        Me.colClave.Name = "colClave"
        '
        'toolEstructura
        '
        Me.toolEstructura.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel6, Me.cboFecVigEstructura, Me.ToolStripLabel8, Me.cboCuadroEstructura, Me.btnPresentarEstructura, Me.ToolStripSeparator5, Me.btnLimpiarEstructura, Me.ToolStripSeparator7, Me.btnGuardarEstructura})
        Me.toolEstructura.Location = New System.Drawing.Point(3, 3)
        Me.toolEstructura.Name = "toolEstructura"
        Me.toolEstructura.Size = New System.Drawing.Size(677, 25)
        Me.toolEstructura.TabIndex = 2
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel6.Text = "Período:"
        '
        'cboFecVigEstructura
        '
        Me.cboFecVigEstructura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFecVigEstructura.Name = "cboFecVigEstructura"
        Me.cboFecVigEstructura.Size = New System.Drawing.Size(90, 25)
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel8.Text = "    Cuadro:"
        '
        'cboCuadroEstructura
        '
        Me.cboCuadroEstructura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuadroEstructura.Name = "cboCuadroEstructura"
        Me.cboCuadroEstructura.Size = New System.Drawing.Size(210, 25)
        '
        'btnPresentarEstructura
        '
        Me.btnPresentarEstructura.Image = Global.VBP04730.My.Resources.Resources.Execute
        Me.btnPresentarEstructura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPresentarEstructura.Name = "btnPresentarEstructura"
        Me.btnPresentarEstructura.Size = New System.Drawing.Size(76, 22)
        Me.btnPresentarEstructura.Text = "&Presentar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpiarEstructura
        '
        Me.btnLimpiarEstructura.Enabled = False
        Me.btnLimpiarEstructura.Image = Global.VBP04730.My.Resources.Resources.Undo
        Me.btnLimpiarEstructura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpiarEstructura.Name = "btnLimpiarEstructura"
        Me.btnLimpiarEstructura.Size = New System.Drawing.Size(67, 22)
        Me.btnLimpiarEstructura.Text = "&Limpiar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardarEstructura
        '
        Me.btnGuardarEstructura.Enabled = False
        Me.btnGuardarEstructura.Image = Global.VBP04730.My.Resources.Resources.Save
        Me.btnGuardarEstructura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardarEstructura.Name = "btnGuardarEstructura"
        Me.btnGuardarEstructura.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardarEstructura.Text = "&Guardar"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 84)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel7)
        Me.SplitContainer1.Size = New System.Drawing.Size(677, 198)
        Me.SplitContainer1.SplitterDistance = 338
        Me.SplitContainer1.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.Location = New System.Drawing.Point(0, 33)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(338, 165)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No Integra"
        Me.ColumnHeader2.Width = 316
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(338, 33)
        Me.Panel5.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(273, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(65, 33)
        Me.Panel6.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Image = Global.VBP04730.My.Resources.Resources.mm_Rewind
        Me.Button1.Location = New System.Drawing.Point(36, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.VBP04730.My.Resources.Resources.mm_First
        Me.Button2.Location = New System.Drawing.Point(6, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 33)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "No Integra"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView2.Location = New System.Drawing.Point(0, 33)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.ShowGroups = False
        Me.ListView2.Size = New System.Drawing.Size(335, 165)
        Me.ListView2.TabIndex = 3
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "No Integra"
        Me.ColumnHeader3.Width = 316
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Controls.Add(Me.Button4)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(335, 33)
        Me.Panel7.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Image = Global.VBP04730.My.Resources.Resources.mm_Last
        Me.Button3.Location = New System.Drawing.Point(31, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.VBP04730.My.Resources.Resources.mm_Fast_Forward
        Me.Button4.Location = New System.Drawing.Point(1, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(28, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(273, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 33)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Si Integra"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Button5)
        Me.Panel8.Controls.Add(Me.Button6)
        Me.Panel8.Controls.Add(Me.Button7)
        Me.Panel8.Controls.Add(Me.Button8)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(3, 282)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(677, 58)
        Me.Panel8.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(85, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "&Guardar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(85, 35)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(79, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "&Cancelar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(0, 35)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(79, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "&Exportar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(0, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "&Imprimir"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(168, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Cuentas Seleccionadas:"
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(168, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(495, 43)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Button9)
        Me.Panel9.Controls.Add(Me.Button10)
        Me.Panel9.Controls.Add(Me.ComboBox1)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Controls.Add(Me.ComboBox2)
        Me.Panel9.Controls.Add(Me.Label15)
        Me.Panel9.Controls.Add(Me.ComboBox3)
        Me.Panel9.Controls.Add(Me.Label16)
        Me.Panel9.Controls.Add(Me.ComboBox4)
        Me.Panel9.Controls.Add(Me.Label17)
        Me.Panel9.Controls.Add(Me.ComboBox5)
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(677, 81)
        Me.Panel9.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(571, 55)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 21)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "&Limpiar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(471, 55)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(96, 21)
        Me.Button10.TabIndex = 5
        Me.Button10.Text = "&Presentar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(78, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(255, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Tabla:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(78, 31)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(255, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Partida:"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(78, 7)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(255, 21)
        Me.ComboBox3.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Período:"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(412, 30)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(255, 21)
        Me.ComboBox4.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(340, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Referencia:"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(412, 7)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(255, 21)
        Me.ComboBox5.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(340, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Cuadro:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 424)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.panBotones)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolMain)
        Me.Controls.Add(Me.sbMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.ToolMain.ResumeLayout(False)
        Me.ToolMain.PerformLayout()
        Me.panBotones.ResumeLayout(False)
        Me.Tabs.ResumeLayout(False)
        Me.TabPartidas.ResumeLayout(False)
        Me.TabPartidas.PerformLayout()
        CType(Me.GridPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolAbmPartidas.ResumeLayout(False)
        Me.toolAbmPartidas.PerformLayout()
        Me.toolPartidas.ResumeLayout(False)
        Me.toolPartidas.PerformLayout()
        Me.TabFuenteDatos.ResumeLayout(False)
        Me.TabFuenteDatos.PerformLayout()
        CType(Me.GridFuentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gFuentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolABMFuentes.ResumeLayout(False)
        Me.toolABMFuentes.PerformLayout()
        Me.toolFuentes.ResumeLayout(False)
        Me.toolFuentes.PerformLayout()
        Me.TabRelFuenteDatos.ResumeLayout(False)
        Me.splitRel.Panel1.ResumeLayout(False)
        Me.splitRel.Panel2.ResumeLayout(False)
        CType(Me.splitRel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitRel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.panRelBotton.ResumeLayout(False)
        Me.panRelBotton.PerformLayout()
        Me.panRelTop.ResumeLayout(False)
        Me.panRelTop.PerformLayout()
        Me.TabPartidasRdo.ResumeLayout(False)
        Me.TabPartidasRdo.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.toolRdo.ResumeLayout(False)
        Me.toolRdo.PerformLayout()
        Me.TabRelTec.ResumeLayout(False)
        Me.TabRelTec.PerformLayout()
        CType(Me.GridRelTec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gRelTec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolAbmRelTec.ResumeLayout(False)
        Me.toolAbmRelTec.PerformLayout()
        Me.toolRelTec.ResumeLayout(False)
        Me.toolRelTec.PerformLayout()
        Me.TabEstructura.ResumeLayout(False)
        Me.TabEstructura.PerformLayout()
        CType(Me.tlEstructura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolEstructura.ResumeLayout(False)
        Me.toolEstructura.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
   Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents lblEntidad As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents lblTransaccion As System.Windows.Forms.ToolStripLabel
   Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsSep1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnAyuda As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsSep2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents lblVersion As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolMain As System.Windows.Forms.ToolStrip
   Friend WithEvents panBotones As System.Windows.Forms.Panel
   Friend WithEvents cmdCopiar As System.Windows.Forms.Button
   Friend WithEvents Tabs As System.Windows.Forms.TabControl
   Friend WithEvents TabPartidas As System.Windows.Forms.TabPage
   Friend WithEvents TabFuenteDatos As System.Windows.Forms.TabPage
   Friend WithEvents TabRelFuenteDatos As System.Windows.Forms.TabPage
   Friend WithEvents TabRelTec As System.Windows.Forms.TabPage
   Friend WithEvents toolPartidas As System.Windows.Forms.ToolStrip
   Friend WithEvents cboFecVigPartida As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboCuadrosPartidas As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents GridPartidas As DevExpress.XtraGrid.GridControl
   Friend WithEvents gPartidas As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents toolAbmPartidas As System.Windows.Forms.ToolStrip
   Friend WithEvents btnNuevaPartida As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnModifPartida As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnDesactivarPartida As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnPresentarPartidas As System.Windows.Forms.ToolStripButton
   Friend WithEvents colTK_FECVIG As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_CODENT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_CODPAR As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_CAMPO8 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_DESCRI As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_DCORTA As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_ACTIVA As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_CREOREND As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_CUADRO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_MONFIJ As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_ORDEN As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_OPERACION As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_ESQUEMA As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_NIVEL As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_GENERATXT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_NIVELTAB As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_RELATIVO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTK_INDEX As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnLimpiarPartidas As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnImprimirPartidas As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnExportarPartidas As System.Windows.Forms.ToolStripButton
   Friend WithEvents GridFuentes As DevExpress.XtraGrid.GridControl
   Friend WithEvents gFuentes As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents toolABMFuentes As System.Windows.Forms.ToolStrip
   Friend WithEvents btnNuevaFuente As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnModifFuente As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnDesactivarFuente As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnImprimirFuentes As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnExportarFuentes As System.Windows.Forms.ToolStripButton
   Friend WithEvents toolFuentes As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboFecVigFuentes As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboTablaFuentes As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnPresentarFuentes As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnLimpiarFuentes As System.Windows.Forms.ToolStripButton
   Friend WithEvents colTU_FECVIG As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTU_CODENT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTU_CODCUE As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTU_DESCRI As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTU_ACTIVA As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTU_TABLA As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents splitRel As System.Windows.Forms.SplitContainer
   Friend WithEvents panRelBotton As System.Windows.Forms.Panel
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents panRelTop As System.Windows.Forms.Panel
   Friend WithEvents cmdGuardarRel As System.Windows.Forms.Button
   Friend WithEvents cmdCancelarRel As System.Windows.Forms.Button
   Friend WithEvents cmdExportarRel As System.Windows.Forms.Button
   Friend WithEvents cmdImprimirRel As System.Windows.Forms.Button
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboCodParRel As System.Windows.Forms.ComboBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents cboFecVigRel As System.Windows.Forms.ComboBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents cboCampo8Rel As System.Windows.Forms.ComboBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents cboCuadroRel As System.Windows.Forms.ComboBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cmdLimpiarRel As System.Windows.Forms.Button
   Friend WithEvents cmdPresentarRel As System.Windows.Forms.Button
   Friend WithEvents cboTablaRel As System.Windows.Forms.ComboBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Panel4 As System.Windows.Forms.Panel
   Friend WithEvents cmdNoUnoRel As System.Windows.Forms.Button
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Panel3 As System.Windows.Forms.Panel
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmdNoTodosRel As System.Windows.Forms.Button
   Friend WithEvents cmdSiUnoRel As System.Windows.Forms.Button
   Friend WithEvents cmdSiTodosRel As System.Windows.Forms.Button
   Friend WithEvents lvNoRel As System.Windows.Forms.ListView
   Friend WithEvents col1 As System.Windows.Forms.ColumnHeader
   Friend WithEvents lvSiRel As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
   Friend WithEvents TabEstructura As System.Windows.Forms.TabPage
   Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents toolEstructura As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboFecVigEstructura As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents ToolStripLabel8 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboCuadroEstructura As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnPresentarEstructura As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnLimpiarEstructura As System.Windows.Forms.ToolStripButton
   Friend WithEvents tlEstructura As DevExpress.XtraTreeList.TreeList
   Friend WithEvents colPartida As DevExpress.XtraTreeList.Columns.TreeListColumn
   Friend WithEvents colDescri As DevExpress.XtraTreeList.Columns.TreeListColumn
   Friend WithEvents colCampo8 As DevExpress.XtraTreeList.Columns.TreeListColumn
   Friend WithEvents colClave As DevExpress.XtraTreeList.Columns.TreeListColumn
   Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnGuardarEstructura As System.Windows.Forms.ToolStripButton
   Friend WithEvents colGeneraTXT As DevExpress.XtraTreeList.Columns.TreeListColumn
   Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents TabPartidasRdo As System.Windows.Forms.TabPage
   Friend WithEvents toolRdo As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboFecVigRdo As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboCodParRdo As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnPresentarRdo As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnLimpiarRdo As System.Windows.Forms.ToolStripButton
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents ListView1 As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
   Friend WithEvents Panel5 As System.Windows.Forms.Panel
   Friend WithEvents Panel6 As System.Windows.Forms.Panel
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents Button2 As System.Windows.Forms.Button
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents ListView2 As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
   Friend WithEvents Panel7 As System.Windows.Forms.Panel
   Friend WithEvents Button3 As System.Windows.Forms.Button
   Friend WithEvents Button4 As System.Windows.Forms.Button
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Panel8 As System.Windows.Forms.Panel
   Friend WithEvents Button5 As System.Windows.Forms.Button
   Friend WithEvents Button6 As System.Windows.Forms.Button
   Friend WithEvents Button7 As System.Windows.Forms.Button
   Friend WithEvents Button8 As System.Windows.Forms.Button
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Panel9 As System.Windows.Forms.Panel
   Friend WithEvents Button9 As System.Windows.Forms.Button
   Friend WithEvents Button10 As System.Windows.Forms.Button
   Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
   Friend WithEvents lvNoRdo As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
   Friend WithEvents Panel10 As System.Windows.Forms.Panel
   Friend WithEvents Panel11 As System.Windows.Forms.Panel
   Friend WithEvents cmdNoTodosRdo As System.Windows.Forms.Button
   Friend WithEvents cmdNoUnoRdo As System.Windows.Forms.Button
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents lvSiRdo As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
   Friend WithEvents Panel12 As System.Windows.Forms.Panel
   Friend WithEvents cmdSiUnoRdo As System.Windows.Forms.Button
   Friend WithEvents cmdSiTodosRdo As System.Windows.Forms.Button
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Panel13 As System.Windows.Forms.Panel
   Friend WithEvents cmdGuardarRdo As System.Windows.Forms.Button
   Friend WithEvents cmdCancelarRdo As System.Windows.Forms.Button
   Friend WithEvents cmdExportarRdo As System.Windows.Forms.Button
   Friend WithEvents cmdImprimirRdo As System.Windows.Forms.Button
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents GridRelTec As DevExpress.XtraGrid.GridControl
   Friend WithEvents gRelTec As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents toolAbmRelTec As System.Windows.Forms.ToolStrip
   Friend WithEvents btnNuevaRelTec As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnModifRelTec As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnEliminarRelTec As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnImprimirRelTec As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnExportarRelTec As System.Windows.Forms.ToolStripButton
   Friend WithEvents toolRelTec As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripLabel9 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboFecVigRelTec As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnPresentarRelTec As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnLimpiarRelTec As System.Windows.Forms.ToolStripButton
   Friend WithEvents colRT_FECVIG As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colRT_CODENT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colXX_ENTIDA As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colRT_CODRTC As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colRT_CODPAR As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colRT_EOAFNG As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colRT_CUADRO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents XX_CUADRO As DevExpress.XtraGrid.Columns.GridColumn
End Class
