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
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
      Me.sbMain = New System.Windows.Forms.StatusStrip
      Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel
      Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel
      Me.tsSep1 = New System.Windows.Forms.ToolStripSeparator
      Me.tsSep2 = New System.Windows.Forms.ToolStripSeparator
      Me.lblVersion = New System.Windows.Forms.ToolStripLabel
      Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
      Me.ToolMain = New System.Windows.Forms.ToolStrip
      Me.lblTransaccion = New System.Windows.Forms.ToolStripLabel
      Me.btnSalir = New System.Windows.Forms.ToolStripButton
      Me.btnAyuda = New System.Windows.Forms.ToolStripButton
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.GridTG = New DevExpress.XtraGrid.GridControl
      Me.gUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.toolTransacciones = New System.Windows.Forms.ToolStrip
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
      Me.cboTabla = New System.Windows.Forms.ToolStripComboBox
      Me.btnPresentar = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.btnLimpiar = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
      Me.btnNuevaTabla = New System.Windows.Forms.ToolStripButton
      Me.btnParamTabla = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
      Me.btnNuevoReg = New System.Windows.Forms.ToolStripButton
      Me.btnEditarReg = New System.Windows.Forms.ToolStripButton
      Me.btnEliminarReg = New System.Windows.Forms.ToolStripButton
      Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
      Me.ListView1 = New System.Windows.Forms.ListView
      Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
      Me.Panel5 = New System.Windows.Forms.Panel
      Me.Panel6 = New System.Windows.Forms.Panel
      Me.Button1 = New System.Windows.Forms.Button
      Me.Button2 = New System.Windows.Forms.Button
      Me.Label10 = New System.Windows.Forms.Label
      Me.ListView2 = New System.Windows.Forms.ListView
      Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
      Me.Panel7 = New System.Windows.Forms.Panel
      Me.Button3 = New System.Windows.Forms.Button
      Me.Button4 = New System.Windows.Forms.Button
      Me.Label11 = New System.Windows.Forms.Label
      Me.Panel8 = New System.Windows.Forms.Panel
      Me.Button5 = New System.Windows.Forms.Button
      Me.Button6 = New System.Windows.Forms.Button
      Me.Button7 = New System.Windows.Forms.Button
      Me.Button8 = New System.Windows.Forms.Button
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.Panel9 = New System.Windows.Forms.Panel
      Me.Button9 = New System.Windows.Forms.Button
      Me.Button10 = New System.Windows.Forms.Button
      Me.ComboBox1 = New System.Windows.Forms.ComboBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.ComboBox2 = New System.Windows.Forms.ComboBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.ComboBox3 = New System.Windows.Forms.ComboBox
      Me.Label16 = New System.Windows.Forms.Label
      Me.ComboBox4 = New System.Windows.Forms.ComboBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.ComboBox5 = New System.Windows.Forms.ComboBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.sbMain.SuspendLayout()
      Me.ToolMain.SuspendLayout()
      Me.Panel1.SuspendLayout()
      CType(Me.GridTG, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.gUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.toolTransacciones.SuspendLayout()
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
      'sbMain
      '
      Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
      Me.sbMain.Location = New System.Drawing.Point(0, 425)
      Me.sbMain.Name = "sbMain"
      Me.sbMain.Size = New System.Drawing.Size(691, 25)
      Me.sbMain.TabIndex = 8
      '
      'lblUsuario
      '
      Me.lblUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
      Me.lblUsuario.Image = CType(resources.GetObject("lblUsuario.Image"), System.Drawing.Image)
      Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.lblUsuario.Name = "lblUsuario"
      Me.lblUsuario.Size = New System.Drawing.Size(544, 20)
      Me.lblUsuario.Spring = True
        Me.lblUsuario.Text = ""
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'lblEntidad
      '
      Me.lblEntidad.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
      Me.lblEntidad.Image = CType(resources.GetObject("lblEntidad.Image"), System.Drawing.Image)
      Me.lblEntidad.Name = "lblEntidad"
      Me.lblEntidad.Size = New System.Drawing.Size(132, 20)
      Me.lblEntidad.Text = "Banco de Prueba S.A."
      '
      'tsSep1
      '
      Me.tsSep1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
      Me.tsSep1.Name = "tsSep1"
      Me.tsSep1.Size = New System.Drawing.Size(6, 25)
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
      Me.lblVersion.Size = New System.Drawing.Size(75, 22)
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
      'lblTransaccion
      '
      Me.lblTransaccion.Image = CType(resources.GetObject("lblTransaccion.Image"), System.Drawing.Image)
      Me.lblTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.lblTransaccion.Name = "lblTransaccion"
      Me.lblTransaccion.Size = New System.Drawing.Size(80, 22)
      Me.lblTransaccion.Text = "Transacción"
      Me.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'btnSalir
      '
      Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
      Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
      Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnSalir.Name = "btnSalir"
      Me.btnSalir.Size = New System.Drawing.Size(50, 22)
      Me.btnSalir.Text = " Salir"
      '
      'btnAyuda
      '
      Me.btnAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
      Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
      Me.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnAyuda.Name = "btnAyuda"
      Me.btnAyuda.Size = New System.Drawing.Size(61, 22)
      Me.btnAyuda.Text = " Ayuda"
      '
      'Panel1
      '
      Me.Panel1.Controls.Add(Me.GridTG)
      Me.Panel1.Controls.Add(Me.toolTransacciones)
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.Panel1.Location = New System.Drawing.Point(0, 25)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(691, 400)
      Me.Panel1.TabIndex = 10
      '
      'GridTG
      '
      Me.GridTG.Cursor = System.Windows.Forms.Cursors.Default
      Me.GridTG.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridTG.EmbeddedNavigator.Buttons.Append.Visible = False
      Me.GridTG.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
      Me.GridTG.EmbeddedNavigator.Buttons.Edit.Visible = False
      Me.GridTG.EmbeddedNavigator.Buttons.EndEdit.Visible = False
      Me.GridTG.EmbeddedNavigator.Buttons.Remove.Visible = False
      Me.GridTG.EmbeddedNavigator.Name = ""
      Me.GridTG.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}"
      Me.GridTG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GridTG.Location = New System.Drawing.Point(0, 25)
      Me.GridTG.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
      Me.GridTG.LookAndFeel.UseWindowsXPTheme = True
      Me.GridTG.MainView = Me.gUsuarios
      Me.GridTG.Name = "GridTG"
      Me.GridTG.Size = New System.Drawing.Size(691, 375)
      Me.GridTG.TabIndex = 23
      Me.GridTG.UseEmbeddedNavigator = True
      Me.GridTG.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gUsuarios})
      '
      'gUsuarios
      '
      Me.gUsuarios.GridControl = Me.GridTG
      Me.gUsuarios.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
      Me.gUsuarios.Name = "gUsuarios"
      Me.gUsuarios.OptionsBehavior.Editable = False
      Me.gUsuarios.OptionsMenu.EnableColumnMenu = False
      Me.gUsuarios.OptionsView.ColumnAutoWidth = False
      Me.gUsuarios.OptionsView.ShowGroupPanel = False
      Me.gUsuarios.PaintStyleName = "WindowsXP"
      Me.gUsuarios.RowHeight = 19
      '
      'toolTransacciones
      '
      Me.toolTransacciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboTabla, Me.btnPresentar, Me.ToolStripSeparator1, Me.btnLimpiar, Me.ToolStripSeparator2, Me.btnNuevaTabla, Me.btnParamTabla, Me.ToolStripSeparator3, Me.btnNuevoReg, Me.btnEditarReg, Me.btnEliminarReg})
      Me.toolTransacciones.Location = New System.Drawing.Point(0, 0)
      Me.toolTransacciones.Name = "toolTransacciones"
      Me.toolTransacciones.Size = New System.Drawing.Size(691, 25)
      Me.toolTransacciones.TabIndex = 0
      Me.toolTransacciones.Text = "ToolStrip1"
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 22)
      Me.ToolStripLabel1.Text = "  Tabla general:"
      '
      'cboTabla
      '
      Me.cboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboTabla.DropDownWidth = 400
      Me.cboTabla.Name = "cboTabla"
      Me.cboTabla.Size = New System.Drawing.Size(200, 25)
      '
      'btnPresentar
      '
      Me.btnPresentar.Image = CType(resources.GetObject("btnPresentar.Image"), System.Drawing.Image)
      Me.btnPresentar.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnPresentar.Name = "btnPresentar"
      Me.btnPresentar.Size = New System.Drawing.Size(74, 22)
      Me.btnPresentar.Text = "Presentar"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'btnLimpiar
      '
      Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
      Me.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnLimpiar.Name = "btnLimpiar"
      Me.btnLimpiar.Size = New System.Drawing.Size(60, 22)
      Me.btnLimpiar.Text = "Limpiar"
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'btnNuevaTabla
      '
      Me.btnNuevaTabla.Image = CType(resources.GetObject("btnNuevaTabla.Image"), System.Drawing.Image)
      Me.btnNuevaTabla.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnNuevaTabla.Name = "btnNuevaTabla"
      Me.btnNuevaTabla.Size = New System.Drawing.Size(85, 22)
      Me.btnNuevaTabla.Text = "Nueva tabla"
      '
      'btnParamTabla
      '
      Me.btnParamTabla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnParamTabla.Image = CType(resources.GetObject("btnParamTabla.Image"), System.Drawing.Image)
      Me.btnParamTabla.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnParamTabla.Name = "btnParamTabla"
      Me.btnParamTabla.Size = New System.Drawing.Size(23, 22)
      Me.btnParamTabla.Text = "Parametría tabla"
      '
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'btnNuevoReg
      '
      Me.btnNuevoReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnNuevoReg.Image = CType(resources.GetObject("btnNuevoReg.Image"), System.Drawing.Image)
      Me.btnNuevoReg.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnNuevoReg.Name = "btnNuevoReg"
      Me.btnNuevoReg.Size = New System.Drawing.Size(23, 22)
      Me.btnNuevoReg.Text = "Nuevo registro"
      '
      'btnEditarReg
      '
      Me.btnEditarReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnEditarReg.Image = CType(resources.GetObject("btnEditarReg.Image"), System.Drawing.Image)
      Me.btnEditarReg.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnEditarReg.Name = "btnEditarReg"
      Me.btnEditarReg.Size = New System.Drawing.Size(23, 22)
      Me.btnEditarReg.Text = "Editar registro"
      '
      'btnEliminarReg
      '
      Me.btnEliminarReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnEliminarReg.Image = CType(resources.GetObject("btnEliminarReg.Image"), System.Drawing.Image)
      Me.btnEliminarReg.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnEliminarReg.Name = "btnEliminarReg"
      Me.btnEliminarReg.Size = New System.Drawing.Size(23, 22)
      Me.btnEliminarReg.Text = "Eliminar registro"
      '
      'ilMain
      '
      Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilMain.Images.SetKeyName(0, "Abierta")
      Me.ilMain.Images.SetKeyName(1, "Cerrada")
      Me.ilMain.Images.SetKeyName(2, "Menu")
      Me.ilMain.Images.SetKeyName(3, "Trx")
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
      Me.Button1.Location = New System.Drawing.Point(36, 3)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(28, 28)
      Me.Button1.TabIndex = 4
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Button2
      '
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
      Me.Button3.Location = New System.Drawing.Point(31, 3)
      Me.Button3.Name = "Button3"
      Me.Button3.Size = New System.Drawing.Size(28, 28)
      Me.Button3.TabIndex = 6
      Me.Button3.UseVisualStyleBackColor = True
      '
      'Button4
      '
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
      Me.ClientSize = New System.Drawing.Size(691, 450)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.ToolMain)
      Me.Controls.Add(Me.sbMain)
      Me.Name = "frmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "frmMain"
      Me.sbMain.ResumeLayout(False)
      Me.sbMain.PerformLayout()
      Me.ToolMain.ResumeLayout(False)
      Me.ToolMain.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      CType(Me.GridTG, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.gUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
      Me.toolTransacciones.ResumeLayout(False)
      Me.toolTransacciones.PerformLayout()
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel2.ResumeLayout(False)
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
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents toolTransacciones As System.Windows.Forms.ToolStrip
   Friend WithEvents ilMain As System.Windows.Forms.ImageList
   Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboTabla As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnPresentar As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnLimpiar As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnParamTabla As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnNuevaTabla As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnNuevoReg As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnEditarReg As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnEliminarReg As System.Windows.Forms.ToolStripButton
   Friend WithEvents GridTG As DevExpress.XtraGrid.GridControl
   Friend WithEvents gUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
End Class
