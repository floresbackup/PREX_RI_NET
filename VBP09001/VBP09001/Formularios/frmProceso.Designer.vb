<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProceso))
        Me.panTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panBotones = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.panMargen = New System.Windows.Forms.Panel()
        Me.panTabs = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gridTXT = New DevExpress.XtraGrid.GridControl()
        Me.viewTXT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTN_CODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTN_NOMBRETXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTN_PROCES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gridDis = New DevExpress.XtraGrid.GridControl()
        Me.viewDis = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTD_FECHAVIG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTD_CODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTD_ORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTD_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTD_TIPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTD_INICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTD_LONGITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTD_CANTDECIMALES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTD_FORMATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gridRel = New DevExpress.XtraGrid.GridControl()
        Me.viewRel = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTR_FECHAVIG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTR_CODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTR_CUADRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTR_TABLATRABAJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTR_CAMPOTRABAJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTR_ORDENTXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTR_DATOFIJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cmSQL = New AxCodeMax.AxCodeMax()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panBotones.SuspendLayout()
        Me.panTabs.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gridTXT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewTXT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewDis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.gridRel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.cmSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panTop
        '
        Me.panTop.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panTop.Controls.Add(Me.PictureBox1)
        Me.panTop.Controls.Add(Me.lblSubtitulo)
        Me.panTop.Controls.Add(Me.lblTitulo)
        Me.panTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTop.Location = New System.Drawing.Point(0, 0)
        Me.panTop.Name = "panTop"
        Me.panTop.Size = New System.Drawing.Size(590, 45)
        Me.panTop.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.VBP09001.My.Resources.Resources.Design
        Me.PictureBox1.Location = New System.Drawing.Point(520, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
        Me.PictureBox1.Size = New System.Drawing.Size(70, 45)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Location = New System.Drawing.Point(21, 23)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(431, 13)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Seleccione un diseño en el Tab Nombre para poder especificar diseño, relación y p" &
    "roceso"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(86, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Diseño de TXT"
        '
        'panBotones
        '
        Me.panBotones.Controls.Add(Me.Label1)
        Me.panBotones.Controls.Add(Me.cmdCerrar)
        Me.panBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panBotones.Location = New System.Drawing.Point(0, 403)
        Me.panBotones.Name = "panBotones"
        Me.panBotones.Size = New System.Drawing.Size(590, 36)
        Me.panBotones.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ATENCION: Los comodines son @FECDES, @FECHAS, @FECVIG, @CODENT"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(4, 7)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(101, 23)
        Me.cmdCerrar.TabIndex = 0
        Me.cmdCerrar.Text = "&Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'panMargen
        '
        Me.panMargen.Dock = System.Windows.Forms.DockStyle.Top
        Me.panMargen.Location = New System.Drawing.Point(0, 45)
        Me.panMargen.Name = "panMargen"
        Me.panMargen.Size = New System.Drawing.Size(590, 5)
        Me.panMargen.TabIndex = 7
        '
        'panTabs
        '
        Me.panTabs.Controls.Add(Me.TabControl1)
        Me.panTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTabs.Location = New System.Drawing.Point(0, 50)
        Me.panTabs.Name = "panTabs"
        Me.panTabs.Size = New System.Drawing.Size(590, 353)
        Me.panTabs.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 353)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridTXT)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(582, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nombre"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gridTXT
        '
        Me.gridTXT.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridTXT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTXT.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gridTXT.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridTXT.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gridTXT.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridTXT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridTXT.Location = New System.Drawing.Point(3, 3)
        Me.gridTXT.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.gridTXT.LookAndFeel.UseWindowsXPTheme = True
        Me.gridTXT.MainView = Me.viewTXT
        Me.gridTXT.Name = "gridTXT"
        Me.gridTXT.Size = New System.Drawing.Size(576, 321)
        Me.gridTXT.TabIndex = 7
        Me.gridTXT.UseEmbeddedNavigator = True
        Me.gridTXT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewTXT})
        '
        'viewTXT
        '
        Me.viewTXT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTN_CODIGO, Me.colTN_NOMBRETXT, Me.colTN_PROCES})
        Me.viewTXT.GridControl = Me.gridTXT
        Me.viewTXT.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.viewTXT.Name = "viewTXT"
        Me.viewTXT.NewItemRowText = "Agregar nuevo archivo"
        Me.viewTXT.OptionsBehavior.AutoPopulateColumns = False
        Me.viewTXT.OptionsMenu.EnableColumnMenu = False
        Me.viewTXT.OptionsView.ColumnAutoWidth = False
        Me.viewTXT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.viewTXT.PaintStyleName = "WindowsXP"
        Me.viewTXT.RowHeight = 19
        '
        'colTN_CODIGO
        '
        Me.colTN_CODIGO.Caption = "Cód. Diseño"
        Me.colTN_CODIGO.FieldName = "TN_CODIGO"
        Me.colTN_CODIGO.Name = "colTN_CODIGO"
        Me.colTN_CODIGO.Visible = True
        Me.colTN_CODIGO.VisibleIndex = 0
        '
        'colTN_NOMBRETXT
        '
        Me.colTN_NOMBRETXT.Caption = "Nombre TXT"
        Me.colTN_NOMBRETXT.FieldName = "TN_NOMBRETXT"
        Me.colTN_NOMBRETXT.Name = "colTN_NOMBRETXT"
        Me.colTN_NOMBRETXT.Visible = True
        Me.colTN_NOMBRETXT.VisibleIndex = 1
        Me.colTN_NOMBRETXT.Width = 349
        '
        'colTN_PROCES
        '
        Me.colTN_PROCES.Caption = "TN_PROCES"
        Me.colTN_PROCES.FieldName = "TN_PROCES"
        Me.colTN_PROCES.Name = "colTN_PROCES"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridDis)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(582, 327)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Diseño"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridDis
        '
        Me.gridDis.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridDis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDis.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gridDis.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridDis.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gridDis.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridDis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDis.Location = New System.Drawing.Point(3, 3)
        Me.gridDis.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.gridDis.LookAndFeel.UseWindowsXPTheme = True
        Me.gridDis.MainView = Me.viewDis
        Me.gridDis.Name = "gridDis"
        Me.gridDis.Size = New System.Drawing.Size(576, 321)
        Me.gridDis.TabIndex = 9
        Me.gridDis.UseEmbeddedNavigator = True
        Me.gridDis.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewDis})
        '
        'viewDis
        '
        Me.viewDis.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTD_FECHAVIG, Me.colTD_CODIGO, Me.colTD_ORDEN, Me.colTD_DESCRIPCION, Me.colTD_TIPO, Me.colTD_INICIO, Me.colTD_LONGITUD, Me.colTD_CANTDECIMALES, Me.colTD_FORMATO})
        Me.viewDis.GridControl = Me.gridDis
        Me.viewDis.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.viewDis.Name = "viewDis"
        Me.viewDis.NewItemRowText = "Agregar nuevo registro de diseño"
        Me.viewDis.OptionsBehavior.AutoPopulateColumns = False
        Me.viewDis.OptionsMenu.EnableColumnMenu = False
        Me.viewDis.OptionsView.ColumnAutoWidth = False
        Me.viewDis.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.viewDis.PaintStyleName = "WindowsXP"
        Me.viewDis.RowHeight = 19
        '
        'colTD_FECHAVIG
        '
        Me.colTD_FECHAVIG.Caption = "Vigencia"
        Me.colTD_FECHAVIG.FieldName = "TD_FECHAVIG"
        Me.colTD_FECHAVIG.Name = "colTD_FECHAVIG"
        Me.colTD_FECHAVIG.Visible = True
        Me.colTD_FECHAVIG.VisibleIndex = 0
        Me.colTD_FECHAVIG.Width = 66
        '
        'colTD_CODIGO
        '
        Me.colTD_CODIGO.Caption = "Cód. Diseño"
        Me.colTD_CODIGO.FieldName = "TD_CODIGO"
        Me.colTD_CODIGO.Name = "colTD_CODIGO"
        Me.colTD_CODIGO.Visible = True
        Me.colTD_CODIGO.VisibleIndex = 1
        Me.colTD_CODIGO.Width = 69
        '
        'colTD_ORDEN
        '
        Me.colTD_ORDEN.Caption = "Orden"
        Me.colTD_ORDEN.FieldName = "TD_ORDEN"
        Me.colTD_ORDEN.Name = "colTD_ORDEN"
        Me.colTD_ORDEN.Visible = True
        Me.colTD_ORDEN.VisibleIndex = 2
        Me.colTD_ORDEN.Width = 42
        '
        'colTD_DESCRIPCION
        '
        Me.colTD_DESCRIPCION.Caption = "Descripción"
        Me.colTD_DESCRIPCION.FieldName = "TD_DESCRIPCION"
        Me.colTD_DESCRIPCION.Name = "colTD_DESCRIPCION"
        Me.colTD_DESCRIPCION.Visible = True
        Me.colTD_DESCRIPCION.VisibleIndex = 3
        Me.colTD_DESCRIPCION.Width = 149
        '
        'colTD_TIPO
        '
        Me.colTD_TIPO.Caption = "Tipo"
        Me.colTD_TIPO.FieldName = "TD_TIPO"
        Me.colTD_TIPO.Name = "colTD_TIPO"
        Me.colTD_TIPO.Visible = True
        Me.colTD_TIPO.VisibleIndex = 4
        Me.colTD_TIPO.Width = 88
        '
        'colTD_INICIO
        '
        Me.colTD_INICIO.Caption = "Pos. Ini."
        Me.colTD_INICIO.FieldName = "TD_INICIO"
        Me.colTD_INICIO.Name = "colTD_INICIO"
        Me.colTD_INICIO.Visible = True
        Me.colTD_INICIO.VisibleIndex = 5
        Me.colTD_INICIO.Width = 50
        '
        'colTD_LONGITUD
        '
        Me.colTD_LONGITUD.Caption = "Longitud"
        Me.colTD_LONGITUD.FieldName = "TD_LONGITUD"
        Me.colTD_LONGITUD.Name = "colTD_LONGITUD"
        Me.colTD_LONGITUD.Visible = True
        Me.colTD_LONGITUD.VisibleIndex = 6
        Me.colTD_LONGITUD.Width = 54
        '
        'colTD_CANTDECIMALES
        '
        Me.colTD_CANTDECIMALES.Caption = "Decimales"
        Me.colTD_CANTDECIMALES.FieldName = "TD_CANTDECIMALES"
        Me.colTD_CANTDECIMALES.Name = "colTD_CANTDECIMALES"
        Me.colTD_CANTDECIMALES.Visible = True
        Me.colTD_CANTDECIMALES.VisibleIndex = 7
        Me.colTD_CANTDECIMALES.Width = 57
        '
        'colTD_FORMATO
        '
        Me.colTD_FORMATO.Caption = "Formato"
        Me.colTD_FORMATO.FieldName = "TD_FORMATO"
        Me.colTD_FORMATO.Name = "colTD_FORMATO"
        Me.colTD_FORMATO.Visible = True
        Me.colTD_FORMATO.VisibleIndex = 8
        Me.colTD_FORMATO.Width = 70
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gridRel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(582, 327)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Relación"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gridRel
        '
        Me.gridRel.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRel.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gridRel.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gridRel.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gridRel.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gridRel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridRel.Location = New System.Drawing.Point(3, 3)
        Me.gridRel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.gridRel.LookAndFeel.UseWindowsXPTheme = True
        Me.gridRel.MainView = Me.viewRel
        Me.gridRel.Name = "gridRel"
        Me.gridRel.Size = New System.Drawing.Size(576, 321)
        Me.gridRel.TabIndex = 11
        Me.gridRel.UseEmbeddedNavigator = True
        Me.gridRel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewRel})
        '
        'viewRel
        '
        Me.viewRel.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTR_FECHAVIG, Me.colTR_CODIGO, Me.colTR_CUADRO, Me.colTR_TABLATRABAJO, Me.colTR_CAMPOTRABAJO, Me.colTR_ORDENTXT, Me.colTR_DATOFIJO})
        Me.viewRel.GridControl = Me.gridRel
        Me.viewRel.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.viewRel.Name = "viewRel"
        Me.viewRel.NewItemRowText = "Agregar nuevo registro de diseño"
        Me.viewRel.OptionsBehavior.AutoPopulateColumns = False
        Me.viewRel.OptionsMenu.EnableColumnMenu = False
        Me.viewRel.OptionsView.ColumnAutoWidth = False
        Me.viewRel.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.viewRel.PaintStyleName = "WindowsXP"
        Me.viewRel.RowHeight = 19
        '
        'colTR_FECHAVIG
        '
        Me.colTR_FECHAVIG.Caption = "Vigencia"
        Me.colTR_FECHAVIG.FieldName = "TR_FECHAVIG"
        Me.colTR_FECHAVIG.Name = "colTR_FECHAVIG"
        Me.colTR_FECHAVIG.Visible = True
        Me.colTR_FECHAVIG.VisibleIndex = 0
        Me.colTR_FECHAVIG.Width = 66
        '
        'colTR_CODIGO
        '
        Me.colTR_CODIGO.Caption = "Cód. Diseño"
        Me.colTR_CODIGO.FieldName = "TR_CODIGO"
        Me.colTR_CODIGO.Name = "colTR_CODIGO"
        Me.colTR_CODIGO.Visible = True
        Me.colTR_CODIGO.VisibleIndex = 1
        '
        'colTR_CUADRO
        '
        Me.colTR_CUADRO.Caption = "Cuadro"
        Me.colTR_CUADRO.FieldName = "TR_CUADRO"
        Me.colTR_CUADRO.Name = "colTR_CUADRO"
        Me.colTR_CUADRO.Visible = True
        Me.colTR_CUADRO.VisibleIndex = 2
        Me.colTR_CUADRO.Width = 62
        '
        'colTR_TABLATRABAJO
        '
        Me.colTR_TABLATRABAJO.Caption = "Tabla trabajo"
        Me.colTR_TABLATRABAJO.FieldName = "TR_TABLATRABAJO"
        Me.colTR_TABLATRABAJO.Name = "colTR_TABLATRABAJO"
        Me.colTR_TABLATRABAJO.Visible = True
        Me.colTR_TABLATRABAJO.VisibleIndex = 3
        Me.colTR_TABLATRABAJO.Width = 94
        '
        'colTR_CAMPOTRABAJO
        '
        Me.colTR_CAMPOTRABAJO.Caption = "Campo trabajo"
        Me.colTR_CAMPOTRABAJO.FieldName = "TR_CAMPOTRABAJO"
        Me.colTR_CAMPOTRABAJO.Name = "colTR_CAMPOTRABAJO"
        Me.colTR_CAMPOTRABAJO.Visible = True
        Me.colTR_CAMPOTRABAJO.VisibleIndex = 4
        Me.colTR_CAMPOTRABAJO.Width = 101
        '
        'colTR_ORDENTXT
        '
        Me.colTR_ORDENTXT.Caption = "Orden"
        Me.colTR_ORDENTXT.FieldName = "TR_ORDENTXT"
        Me.colTR_ORDENTXT.Name = "colTR_ORDENTXT"
        Me.colTR_ORDENTXT.Visible = True
        Me.colTR_ORDENTXT.VisibleIndex = 5
        Me.colTR_ORDENTXT.Width = 48
        '
        'colTR_DATOFIJO
        '
        Me.colTR_DATOFIJO.Caption = "Dato fijo"
        Me.colTR_DATOFIJO.FieldName = "TR_DATOFIJO"
        Me.colTR_DATOFIJO.Name = "colTR_DATOFIJO"
        Me.colTR_DATOFIJO.Visible = True
        Me.colTR_DATOFIJO.VisibleIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cmSQL)
        Me.TabPage4.Controls.Add(Me.Panel1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(582, 327)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Proceso"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cmSQL
        '
        Me.cmSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmSQL.Location = New System.Drawing.Point(0, 0)
        Me.cmSQL.Name = "cmSQL"
        Me.cmSQL.OcxState = CType(resources.GetObject("cmSQL.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmSQL.Size = New System.Drawing.Size(0, 0)
        Me.cmSQL.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 298)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 26)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Actualizar Proceso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 439)
        Me.Controls.Add(Me.panTabs)
        Me.Controls.Add(Me.panMargen)
        Me.Controls.Add(Me.panBotones)
        Me.Controls.Add(Me.panTop)
        Me.Name = "frmProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modo diseño"
        Me.panTop.ResumeLayout(False)
        Me.panTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panBotones.ResumeLayout(False)
        Me.panBotones.PerformLayout()
        Me.panTabs.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.gridTXT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewTXT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewDis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.gridRel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewRel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.cmSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents panBotones As System.Windows.Forms.Panel
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmdCerrar As System.Windows.Forms.Button
   Friend WithEvents panMargen As System.Windows.Forms.Panel
   Friend WithEvents panTabs As System.Windows.Forms.Panel
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
   Friend WithEvents gridTXT As DevExpress.XtraGrid.GridControl
   Friend WithEvents viewTXT As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents colTN_CODIGO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTN_NOMBRETXT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTN_PROCES As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents gridDis As DevExpress.XtraGrid.GridControl
   Friend WithEvents viewDis As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents colTD_FECHAVIG As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTD_CODIGO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTD_ORDEN As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTD_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTD_TIPO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTD_INICIO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTD_LONGITUD As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTD_CANTDECIMALES As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTD_FORMATO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents gridRel As DevExpress.XtraGrid.GridControl
   Friend WithEvents viewRel As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents colTR_FECHAVIG As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTR_CODIGO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTR_CUADRO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTR_TABLATRABAJO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTR_CAMPOTRABAJO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTR_ORDENTXT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colTR_DATOFIJO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents cmSQL As AxCodeMax.AxCodeMax
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
