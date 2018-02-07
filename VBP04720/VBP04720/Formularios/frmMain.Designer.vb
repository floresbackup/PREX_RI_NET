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
      Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
      Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
      Me.colUS_FECBAJ = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colDS_VIGENT = New DevExpress.XtraGrid.Columns.GridColumn
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
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.tabPerfiles = New System.Windows.Forms.TabPage
      Me.panTreeView = New System.Windows.Forms.Panel
      Me.tvMenu = New System.Windows.Forms.TreeView
      Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
      Me.panBotones = New System.Windows.Forms.Panel
      Me.cmdCancelarPerfil = New System.Windows.Forms.Button
      Me.cmdGuardarPerfil = New System.Windows.Forms.Button
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.toolPerfil = New System.Windows.Forms.ToolStrip
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
      Me.cboPerfilPerfiles = New System.Windows.Forms.ToolStripComboBox
      Me.btnPresentarPerfil = New System.Windows.Forms.ToolStripButton
      Me.btnLimpiarPerfil = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.btnNuevoPerfil = New System.Windows.Forms.ToolStripButton
      Me.btnEliminarPerfil = New System.Windows.Forms.ToolStripButton
      Me.tabUsuarios = New System.Windows.Forms.TabPage
      Me.GridUsuarios = New DevExpress.XtraGrid.GridControl
      Me.gUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.colUS_CODUSU = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_DESCRI = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_PASSWO = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_PASS01 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_PASS02 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_PASS03 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_PASS04 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_PASS05 = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_FECALT = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_FECVTO = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_ENCRYP = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_BLOQUE = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_GRACIA = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_ADMIN = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_CODENT = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_CORREO = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUS_INTERN = New DevExpress.XtraGrid.Columns.GridColumn
      Me.toolUsuarios = New System.Windows.Forms.ToolStrip
      Me.btnNuevoUsuario = New System.Windows.Forms.ToolStripButton
      Me.btnEditarUsuario = New System.Windows.Forms.ToolStripButton
      Me.btnUsuarioBaja = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
      Me.btnCambiarPassUsuario = New System.Windows.Forms.ToolStripButton
      Me.tabGrupos = New System.Windows.Forms.TabPage
      Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
      Me.lvNoGrupo = New System.Windows.Forms.ListView
      Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
      Me.Panel10 = New System.Windows.Forms.Panel
      Me.Panel11 = New System.Windows.Forms.Panel
      Me.cmdNoTodosGrupos = New System.Windows.Forms.Button
      Me.cmdNoUnoGrupo = New System.Windows.Forms.Button
      Me.Label19 = New System.Windows.Forms.Label
      Me.lvSiGrupo = New System.Windows.Forms.ListView
      Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
      Me.Panel12 = New System.Windows.Forms.Panel
      Me.cmdSiUnoGrupo = New System.Windows.Forms.Button
      Me.cmdSiTodosGrupos = New System.Windows.Forms.Button
      Me.Label20 = New System.Windows.Forms.Label
      Me.Panel13 = New System.Windows.Forms.Panel
      Me.cmdGuardarGrupo = New System.Windows.Forms.Button
      Me.cmdCancelarGrupo = New System.Windows.Forms.Button
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label21 = New System.Windows.Forms.Label
      Me.toolGrupos = New System.Windows.Forms.ToolStrip
      Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel
      Me.cboGrupos = New System.Windows.Forms.ToolStripComboBox
      Me.btnPresentarGrupos = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
      Me.btnLimpiarGrupos = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
      Me.btnNuevoGrupo = New System.Windows.Forms.ToolStripButton
      Me.btnEliminarGrupo = New System.Windows.Forms.ToolStripButton
      Me.tabAsignacion = New System.Windows.Forms.TabPage
      Me.gridAsig = New DevExpress.XtraGrid.GridControl
      Me.gAsig = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.colGR_DESCRI = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colCP_DESCRI = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colHA_TIPOBJ = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colHA_CODOBJ = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colHA_CODPER = New DevExpress.XtraGrid.Columns.GridColumn
      Me.toolAsignacion = New System.Windows.Forms.ToolStrip
      Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
      Me.cboGrupoAsig = New System.Windows.Forms.ToolStripComboBox
      Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
      Me.cboPerfilAsig = New System.Windows.Forms.ToolStripComboBox
      Me.btnAsignarAsig = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
      Me.btnEliminarAsig = New System.Windows.Forms.ToolStripButton
      Me.tabDirectivas = New System.Windows.Forms.TabPage
      Me.GridDirSeg = New DevExpress.XtraGrid.GridControl
      Me.gDirSeg = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.colDS_CODDIR = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colDS_DESCRI = New DevExpress.XtraGrid.Columns.GridColumn
      Me.toolDirSeg = New System.Windows.Forms.ToolStrip
      Me.btnNuevaDirSeg = New System.Windows.Forms.ToolStripButton
      Me.btnPropDirSeg = New System.Windows.Forms.ToolStripButton
      Me.btnEliminarDirSeg = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
      Me.btnPredetermDirSeg = New System.Windows.Forms.ToolStripButton
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
      Me.TabControl1.SuspendLayout()
      Me.tabPerfiles.SuspendLayout()
      Me.panTreeView.SuspendLayout()
      Me.panBotones.SuspendLayout()
      Me.toolPerfil.SuspendLayout()
      Me.tabUsuarios.SuspendLayout()
      CType(Me.GridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.gUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.toolUsuarios.SuspendLayout()
      Me.tabGrupos.SuspendLayout()
      Me.SplitContainer2.Panel1.SuspendLayout()
      Me.SplitContainer2.Panel2.SuspendLayout()
      Me.SplitContainer2.SuspendLayout()
      Me.Panel10.SuspendLayout()
      Me.Panel11.SuspendLayout()
      Me.Panel12.SuspendLayout()
      Me.Panel13.SuspendLayout()
      Me.toolGrupos.SuspendLayout()
      Me.tabAsignacion.SuspendLayout()
      CType(Me.gridAsig, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.gAsig, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.toolAsignacion.SuspendLayout()
      Me.tabDirectivas.SuspendLayout()
      CType(Me.GridDirSeg, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.gDirSeg, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.toolDirSeg.SuspendLayout()
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
      'colUS_FECBAJ
      '
      Me.colUS_FECBAJ.Caption = "Fecha baja"
      Me.colUS_FECBAJ.FieldName = "US_FECBAJ"
      Me.colUS_FECBAJ.Name = "colUS_FECBAJ"
      '
      'colDS_VIGENT
      '
      Me.colDS_VIGENT.Caption = "DS_VIGENT"
      Me.colDS_VIGENT.FieldName = "DS_VIGENT"
      Me.colDS_VIGENT.Name = "colDS_VIGENT"
      '
      'sbMain
      '
      Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
      Me.sbMain.Location = New System.Drawing.Point(0, 430)
      Me.sbMain.Name = "sbMain"
      Me.sbMain.Size = New System.Drawing.Size(615, 25)
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
      Me.lblUsuario.Size = New System.Drawing.Size(468, 20)
      Me.lblUsuario.Spring = True
      Me.lblUsuario.Text = "Sebastián Buceta"
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
      Me.ToolMain.Size = New System.Drawing.Size(615, 25)
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
      Me.Panel1.Controls.Add(Me.TabControl1)
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.Panel1.Location = New System.Drawing.Point(0, 25)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(615, 405)
      Me.Panel1.TabIndex = 10
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.tabPerfiles)
      Me.TabControl1.Controls.Add(Me.tabUsuarios)
      Me.TabControl1.Controls.Add(Me.tabGrupos)
      Me.TabControl1.Controls.Add(Me.tabAsignacion)
      Me.TabControl1.Controls.Add(Me.tabDirectivas)
      Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TabControl1.Location = New System.Drawing.Point(0, 0)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(615, 405)
      Me.TabControl1.TabIndex = 0
      '
      'tabPerfiles
      '
      Me.tabPerfiles.Controls.Add(Me.panTreeView)
      Me.tabPerfiles.Controls.Add(Me.panBotones)
      Me.tabPerfiles.Controls.Add(Me.toolPerfil)
      Me.tabPerfiles.Location = New System.Drawing.Point(4, 22)
      Me.tabPerfiles.Name = "tabPerfiles"
      Me.tabPerfiles.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPerfiles.Size = New System.Drawing.Size(607, 379)
      Me.tabPerfiles.TabIndex = 0
      Me.tabPerfiles.Text = "Perfiles"
      Me.tabPerfiles.UseVisualStyleBackColor = True
      '
      'panTreeView
      '
      Me.panTreeView.Controls.Add(Me.tvMenu)
      Me.panTreeView.Dock = System.Windows.Forms.DockStyle.Fill
      Me.panTreeView.Location = New System.Drawing.Point(3, 28)
      Me.panTreeView.Name = "panTreeView"
      Me.panTreeView.Size = New System.Drawing.Size(601, 290)
      Me.panTreeView.TabIndex = 7
      '
      'tvMenu
      '
      Me.tvMenu.CheckBoxes = True
      Me.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tvMenu.HideSelection = False
      Me.tvMenu.ImageIndex = 0
      Me.tvMenu.ImageList = Me.ilMain
      Me.tvMenu.Location = New System.Drawing.Point(0, 0)
      Me.tvMenu.Name = "tvMenu"
      Me.tvMenu.SelectedImageIndex = 0
      Me.tvMenu.Size = New System.Drawing.Size(601, 290)
      Me.tvMenu.TabIndex = 9
      '
      'ilMain
      '
      Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilMain.Images.SetKeyName(0, "Abierta")
      Me.ilMain.Images.SetKeyName(1, "Cerrada")
      Me.ilMain.Images.SetKeyName(2, "Trx")
      Me.ilMain.Images.SetKeyName(3, "Menu")
      Me.ilMain.Images.SetKeyName(4, "Usuario")
      '
      'panBotones
      '
      Me.panBotones.Controls.Add(Me.cmdCancelarPerfil)
      Me.panBotones.Controls.Add(Me.cmdGuardarPerfil)
      Me.panBotones.Controls.Add(Me.Label4)
      Me.panBotones.Controls.Add(Me.Label3)
      Me.panBotones.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.panBotones.Location = New System.Drawing.Point(3, 318)
      Me.panBotones.Name = "panBotones"
      Me.panBotones.Size = New System.Drawing.Size(601, 58)
      Me.panBotones.TabIndex = 6
      '
      'cmdCancelarPerfil
      '
      Me.cmdCancelarPerfil.Enabled = False
      Me.cmdCancelarPerfil.Location = New System.Drawing.Point(0, 35)
      Me.cmdCancelarPerfil.Name = "cmdCancelarPerfil"
      Me.cmdCancelarPerfil.Size = New System.Drawing.Size(79, 23)
      Me.cmdCancelarPerfil.TabIndex = 14
      Me.cmdCancelarPerfil.Text = "&Cancelar"
      Me.cmdCancelarPerfil.UseVisualStyleBackColor = True
      '
      'cmdGuardarPerfil
      '
      Me.cmdGuardarPerfil.Enabled = False
      Me.cmdGuardarPerfil.Location = New System.Drawing.Point(0, 6)
      Me.cmdGuardarPerfil.Name = "cmdGuardarPerfil"
      Me.cmdGuardarPerfil.Size = New System.Drawing.Size(79, 23)
      Me.cmdGuardarPerfil.TabIndex = 13
      Me.cmdGuardarPerfil.Text = "&Guardar"
      Me.cmdGuardarPerfil.UseVisualStyleBackColor = True
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
      Me.Label4.Location = New System.Drawing.Point(82, 11)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(119, 13)
      Me.Label4.TabIndex = 12
      Me.Label4.Text = "Perfil seleccionado:"
      '
      'Label3
      '
      Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
      Me.Label3.Location = New System.Drawing.Point(85, 28)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(495, 30)
      Me.Label3.TabIndex = 11
      Me.Label3.Text = "Active aquellos items que forman parte del perfil. Los items restantes serán desh" & _
          "abilitados al usuario o grupo al que se asigne este perfil."
      '
      'toolPerfil
      '
      Me.toolPerfil.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboPerfilPerfiles, Me.btnPresentarPerfil, Me.btnLimpiarPerfil, Me.ToolStripSeparator1, Me.btnNuevoPerfil, Me.btnEliminarPerfil})
      Me.toolPerfil.Location = New System.Drawing.Point(3, 3)
      Me.toolPerfil.Name = "toolPerfil"
      Me.toolPerfil.Size = New System.Drawing.Size(601, 25)
      Me.toolPerfil.TabIndex = 5
      Me.toolPerfil.Text = "ToolStrip1"
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
      Me.ToolStripLabel1.Text = "Perfil:"
      '
      'cboPerfilPerfiles
      '
      Me.cboPerfilPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboPerfilPerfiles.Name = "cboPerfilPerfiles"
      Me.cboPerfilPerfiles.Size = New System.Drawing.Size(200, 25)
      '
      'btnPresentarPerfil
      '
      Me.btnPresentarPerfil.Image = CType(resources.GetObject("btnPresentarPerfil.Image"), System.Drawing.Image)
      Me.btnPresentarPerfil.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnPresentarPerfil.Name = "btnPresentarPerfil"
      Me.btnPresentarPerfil.Size = New System.Drawing.Size(74, 22)
      Me.btnPresentarPerfil.Text = "Presentar"
      '
      'btnLimpiarPerfil
      '
      Me.btnLimpiarPerfil.Enabled = False
      Me.btnLimpiarPerfil.Image = CType(resources.GetObject("btnLimpiarPerfil.Image"), System.Drawing.Image)
      Me.btnLimpiarPerfil.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnLimpiarPerfil.Name = "btnLimpiarPerfil"
      Me.btnLimpiarPerfil.Size = New System.Drawing.Size(60, 22)
      Me.btnLimpiarPerfil.Text = "Limpiar"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'btnNuevoPerfil
      '
      Me.btnNuevoPerfil.Image = CType(resources.GetObject("btnNuevoPerfil.Image"), System.Drawing.Image)
      Me.btnNuevoPerfil.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnNuevoPerfil.Name = "btnNuevoPerfil"
      Me.btnNuevoPerfil.Size = New System.Drawing.Size(85, 22)
      Me.btnNuevoPerfil.Text = "Nuevo perfil"
      '
      'btnEliminarPerfil
      '
      Me.btnEliminarPerfil.Enabled = False
      Me.btnEliminarPerfil.Image = CType(resources.GetObject("btnEliminarPerfil.Image"), System.Drawing.Image)
      Me.btnEliminarPerfil.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnEliminarPerfil.Name = "btnEliminarPerfil"
      Me.btnEliminarPerfil.Size = New System.Drawing.Size(90, 22)
      Me.btnEliminarPerfil.Text = "Eliminar perfil"
      '
      'tabUsuarios
      '
      Me.tabUsuarios.Controls.Add(Me.GridUsuarios)
      Me.tabUsuarios.Controls.Add(Me.toolUsuarios)
      Me.tabUsuarios.Location = New System.Drawing.Point(4, 22)
      Me.tabUsuarios.Name = "tabUsuarios"
      Me.tabUsuarios.Padding = New System.Windows.Forms.Padding(3)
      Me.tabUsuarios.Size = New System.Drawing.Size(607, 379)
      Me.tabUsuarios.TabIndex = 1
      Me.tabUsuarios.Text = "Usuarios"
      Me.tabUsuarios.UseVisualStyleBackColor = True
      '
      'GridUsuarios
      '
      Me.GridUsuarios.Cursor = System.Windows.Forms.Cursors.Default
      Me.GridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridUsuarios.EmbeddedNavigator.Buttons.Append.Visible = False
      Me.GridUsuarios.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
      Me.GridUsuarios.EmbeddedNavigator.Buttons.Edit.Visible = False
      Me.GridUsuarios.EmbeddedNavigator.Buttons.EndEdit.Visible = False
      Me.GridUsuarios.EmbeddedNavigator.Buttons.Remove.Visible = False
      Me.GridUsuarios.EmbeddedNavigator.Name = ""
      Me.GridUsuarios.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}"
      Me.GridUsuarios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GridUsuarios.Location = New System.Drawing.Point(3, 28)
      Me.GridUsuarios.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
      Me.GridUsuarios.LookAndFeel.UseWindowsXPTheme = True
      Me.GridUsuarios.MainView = Me.gUsuarios
      Me.GridUsuarios.Name = "GridUsuarios"
      Me.GridUsuarios.Size = New System.Drawing.Size(601, 348)
      Me.GridUsuarios.TabIndex = 22
      Me.GridUsuarios.UseEmbeddedNavigator = True
      Me.GridUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gUsuarios})
      '
      'gUsuarios
      '
      Me.gUsuarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUS_CODUSU, Me.colUS_NOMBRE, Me.colUS_DESCRI, Me.colUS_PASSWO, Me.colUS_PASS01, Me.colUS_PASS02, Me.colUS_PASS03, Me.colUS_PASS04, Me.colUS_PASS05, Me.colUS_FECALT, Me.colUS_FECVTO, Me.colUS_ENCRYP, Me.colUS_BLOQUE, Me.colUS_GRACIA, Me.colUS_ADMIN, Me.colUS_CODENT, Me.colUS_CORREO, Me.colUS_INTERN, Me.colUS_FECBAJ})
      StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Strikeout)
      StyleFormatCondition1.Appearance.Options.UseFont = True
      StyleFormatCondition1.ApplyToRow = True
      StyleFormatCondition1.Column = Me.colUS_FECBAJ
      StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
      StyleFormatCondition1.Value1 = New Date(1900, 1, 1, 0, 0, 0, 0)
      Me.gUsuarios.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
      Me.gUsuarios.GridControl = Me.GridUsuarios
      Me.gUsuarios.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
      Me.gUsuarios.Name = "gUsuarios"
      Me.gUsuarios.OptionsBehavior.Editable = False
      Me.gUsuarios.OptionsMenu.EnableColumnMenu = False
      Me.gUsuarios.OptionsView.ColumnAutoWidth = False
      Me.gUsuarios.OptionsView.ShowGroupPanel = False
      Me.gUsuarios.PaintStyleName = "WindowsXP"
      Me.gUsuarios.RowHeight = 19
      '
      'colUS_CODUSU
      '
      Me.colUS_CODUSU.Caption = "Cód."
      Me.colUS_CODUSU.FieldName = "US_CODUSU"
      Me.colUS_CODUSU.Name = "colUS_CODUSU"
      Me.colUS_CODUSU.Visible = True
      Me.colUS_CODUSU.VisibleIndex = 0
      Me.colUS_CODUSU.Width = 50
      '
      'colUS_NOMBRE
      '
      Me.colUS_NOMBRE.Caption = "Nombre"
      Me.colUS_NOMBRE.FieldName = "US_NOMBRE"
      Me.colUS_NOMBRE.Name = "colUS_NOMBRE"
      Me.colUS_NOMBRE.Visible = True
      Me.colUS_NOMBRE.VisibleIndex = 1
      Me.colUS_NOMBRE.Width = 95
      '
      'colUS_DESCRI
      '
      Me.colUS_DESCRI.Caption = "Descripción"
      Me.colUS_DESCRI.FieldName = "US_DESCRI"
      Me.colUS_DESCRI.Name = "colUS_DESCRI"
      Me.colUS_DESCRI.Visible = True
      Me.colUS_DESCRI.VisibleIndex = 2
      Me.colUS_DESCRI.Width = 149
      '
      'colUS_PASSWO
      '
      Me.colUS_PASSWO.Caption = "US_PASSWO"
      Me.colUS_PASSWO.FieldName = "US_PASSWO"
      Me.colUS_PASSWO.Name = "colUS_PASSWO"
      '
      'colUS_PASS01
      '
      Me.colUS_PASS01.Caption = "US_PASS01"
      Me.colUS_PASS01.FieldName = "US_PASS01"
      Me.colUS_PASS01.Name = "colUS_PASS01"
      '
      'colUS_PASS02
      '
      Me.colUS_PASS02.Caption = "US_PASS02"
      Me.colUS_PASS02.FieldName = "US_PASS02"
      Me.colUS_PASS02.Name = "colUS_PASS02"
      '
      'colUS_PASS03
      '
      Me.colUS_PASS03.Caption = "US_PASS03"
      Me.colUS_PASS03.FieldName = "US_PASS03"
      Me.colUS_PASS03.Name = "colUS_PASS03"
      '
      'colUS_PASS04
      '
      Me.colUS_PASS04.Caption = "US_PASS04"
      Me.colUS_PASS04.FieldName = "US_PASS04"
      Me.colUS_PASS04.Name = "colUS_PASS04"
      '
      'colUS_PASS05
      '
      Me.colUS_PASS05.Caption = "US_PASS05"
      Me.colUS_PASS05.FieldName = "US_PASS05"
      Me.colUS_PASS05.Name = "colUS_PASS05"
      '
      'colUS_FECALT
      '
      Me.colUS_FECALT.Caption = "Fecha alta"
      Me.colUS_FECALT.FieldName = "US_FECALT"
      Me.colUS_FECALT.Name = "colUS_FECALT"
      Me.colUS_FECALT.Visible = True
      Me.colUS_FECALT.VisibleIndex = 4
      '
      'colUS_FECVTO
      '
      Me.colUS_FECVTO.Caption = "Fecha vto."
      Me.colUS_FECVTO.FieldName = "US_FECVTO"
      Me.colUS_FECVTO.Name = "colUS_FECVTO"
      Me.colUS_FECVTO.Visible = True
      Me.colUS_FECVTO.VisibleIndex = 3
      '
      'colUS_ENCRYP
      '
      Me.colUS_ENCRYP.Caption = "US_ENCRYP"
      Me.colUS_ENCRYP.FieldName = "US_ENCRYP"
      Me.colUS_ENCRYP.Name = "colUS_ENCRYP"
      '
      'colUS_BLOQUE
      '
      Me.colUS_BLOQUE.Caption = "Bloqueado"
      Me.colUS_BLOQUE.FieldName = "US_BLOQUE"
      Me.colUS_BLOQUE.Name = "colUS_BLOQUE"
      Me.colUS_BLOQUE.Visible = True
      Me.colUS_BLOQUE.VisibleIndex = 5
      Me.colUS_BLOQUE.Width = 70
      '
      'colUS_GRACIA
      '
      Me.colUS_GRACIA.Caption = "US_GRACIA"
      Me.colUS_GRACIA.FieldName = "US_GRACIA"
      Me.colUS_GRACIA.Name = "colUS_GRACIA"
      '
      'colUS_ADMIN
      '
      Me.colUS_ADMIN.Caption = "Admin."
      Me.colUS_ADMIN.FieldName = "US_ADMIN"
      Me.colUS_ADMIN.Name = "colUS_ADMIN"
      Me.colUS_ADMIN.Visible = True
      Me.colUS_ADMIN.VisibleIndex = 6
      Me.colUS_ADMIN.Width = 55
      '
      'colUS_CODENT
      '
      Me.colUS_CODENT.Caption = "US_CODENT"
      Me.colUS_CODENT.FieldName = "US_CODENT"
      Me.colUS_CODENT.Name = "colUS_CODENT"
      '
      'colUS_CORREO
      '
      Me.colUS_CORREO.Caption = "US_CORREO"
      Me.colUS_CORREO.FieldName = "US_CORREO"
      Me.colUS_CORREO.Name = "colUS_CORREO"
      '
      'colUS_INTERN
      '
      Me.colUS_INTERN.Caption = "US_INTERN"
      Me.colUS_INTERN.FieldName = "US_INTERN"
      Me.colUS_INTERN.Name = "colUS_INTERN"
      '
      'toolUsuarios
      '
      Me.toolUsuarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoUsuario, Me.btnEditarUsuario, Me.btnUsuarioBaja, Me.ToolStripSeparator2, Me.btnCambiarPassUsuario})
      Me.toolUsuarios.Location = New System.Drawing.Point(3, 3)
      Me.toolUsuarios.Name = "toolUsuarios"
      Me.toolUsuarios.Size = New System.Drawing.Size(601, 25)
      Me.toolUsuarios.TabIndex = 0
      '
      'btnNuevoUsuario
      '
      Me.btnNuevoUsuario.Image = CType(resources.GetObject("btnNuevoUsuario.Image"), System.Drawing.Image)
      Me.btnNuevoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
      Me.btnNuevoUsuario.Size = New System.Drawing.Size(96, 22)
      Me.btnNuevoUsuario.Text = "Nuevo usuario"
      '
      'btnEditarUsuario
      '
      Me.btnEditarUsuario.Image = CType(resources.GetObject("btnEditarUsuario.Image"), System.Drawing.Image)
      Me.btnEditarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnEditarUsuario.Name = "btnEditarUsuario"
      Me.btnEditarUsuario.Size = New System.Drawing.Size(86, 22)
      Me.btnEditarUsuario.Text = "Propiedades"
      '
      'btnUsuarioBaja
      '
      Me.btnUsuarioBaja.Image = CType(resources.GetObject("btnUsuarioBaja.Image"), System.Drawing.Image)
      Me.btnUsuarioBaja.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnUsuarioBaja.Name = "btnUsuarioBaja"
      Me.btnUsuarioBaja.Size = New System.Drawing.Size(101, 22)
      Me.btnUsuarioBaja.Text = "Baja de usuario"
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'btnCambiarPassUsuario
      '
      Me.btnCambiarPassUsuario.Image = CType(resources.GetObject("btnCambiarPassUsuario.Image"), System.Drawing.Image)
      Me.btnCambiarPassUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnCambiarPassUsuario.Name = "btnCambiarPassUsuario"
      Me.btnCambiarPassUsuario.Size = New System.Drawing.Size(123, 22)
      Me.btnCambiarPassUsuario.Text = "Cambiar contraseña"
      '
      'tabGrupos
      '
      Me.tabGrupos.Controls.Add(Me.SplitContainer2)
      Me.tabGrupos.Controls.Add(Me.Panel13)
      Me.tabGrupos.Controls.Add(Me.toolGrupos)
      Me.tabGrupos.Location = New System.Drawing.Point(4, 22)
      Me.tabGrupos.Name = "tabGrupos"
      Me.tabGrupos.Padding = New System.Windows.Forms.Padding(3)
      Me.tabGrupos.Size = New System.Drawing.Size(607, 379)
      Me.tabGrupos.TabIndex = 2
      Me.tabGrupos.Text = "Grupos"
      Me.tabGrupos.UseVisualStyleBackColor = True
      '
      'SplitContainer2
      '
      Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer2.Location = New System.Drawing.Point(3, 28)
      Me.SplitContainer2.Name = "SplitContainer2"
      '
      'SplitContainer2.Panel1
      '
      Me.SplitContainer2.Panel1.Controls.Add(Me.lvNoGrupo)
      Me.SplitContainer2.Panel1.Controls.Add(Me.Panel10)
      '
      'SplitContainer2.Panel2
      '
      Me.SplitContainer2.Panel2.Controls.Add(Me.lvSiGrupo)
      Me.SplitContainer2.Panel2.Controls.Add(Me.Panel12)
      Me.SplitContainer2.Size = New System.Drawing.Size(601, 290)
      Me.SplitContainer2.SplitterDistance = 300
      Me.SplitContainer2.TabIndex = 11
      '
      'lvNoGrupo
      '
      Me.lvNoGrupo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
      Me.lvNoGrupo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvNoGrupo.FullRowSelect = True
      Me.lvNoGrupo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
      Me.lvNoGrupo.Location = New System.Drawing.Point(0, 33)
      Me.lvNoGrupo.MultiSelect = False
      Me.lvNoGrupo.Name = "lvNoGrupo"
      Me.lvNoGrupo.ShowGroups = False
      Me.lvNoGrupo.Size = New System.Drawing.Size(300, 257)
      Me.lvNoGrupo.SmallImageList = Me.ilMain
      Me.lvNoGrupo.TabIndex = 2
      Me.lvNoGrupo.UseCompatibleStateImageBehavior = False
      Me.lvNoGrupo.View = System.Windows.Forms.View.Details
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
      Me.Panel10.Size = New System.Drawing.Size(300, 33)
      Me.Panel10.TabIndex = 1
      '
      'Panel11
      '
      Me.Panel11.Controls.Add(Me.cmdNoTodosGrupos)
      Me.Panel11.Controls.Add(Me.cmdNoUnoGrupo)
      Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
      Me.Panel11.Location = New System.Drawing.Point(235, 0)
      Me.Panel11.Name = "Panel11"
      Me.Panel11.Size = New System.Drawing.Size(65, 33)
      Me.Panel11.TabIndex = 2
      '
      'cmdNoTodosGrupos
      '
      Me.cmdNoTodosGrupos.Image = CType(resources.GetObject("cmdNoTodosGrupos.Image"), System.Drawing.Image)
      Me.cmdNoTodosGrupos.Location = New System.Drawing.Point(36, 3)
      Me.cmdNoTodosGrupos.Name = "cmdNoTodosGrupos"
      Me.cmdNoTodosGrupos.Size = New System.Drawing.Size(28, 28)
      Me.cmdNoTodosGrupos.TabIndex = 4
      Me.cmdNoTodosGrupos.UseVisualStyleBackColor = True
      '
      'cmdNoUnoGrupo
      '
      Me.cmdNoUnoGrupo.Image = CType(resources.GetObject("cmdNoUnoGrupo.Image"), System.Drawing.Image)
      Me.cmdNoUnoGrupo.Location = New System.Drawing.Point(6, 3)
      Me.cmdNoUnoGrupo.Name = "cmdNoUnoGrupo"
      Me.cmdNoUnoGrupo.Size = New System.Drawing.Size(28, 28)
      Me.cmdNoUnoGrupo.TabIndex = 3
      Me.cmdNoUnoGrupo.UseVisualStyleBackColor = True
      '
      'Label19
      '
      Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(0, 0)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(120, 33)
      Me.Label19.TabIndex = 1
      Me.Label19.Text = "No son miembros"
      Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'lvSiGrupo
      '
      Me.lvSiGrupo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5})
      Me.lvSiGrupo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvSiGrupo.FullRowSelect = True
      Me.lvSiGrupo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
      Me.lvSiGrupo.Location = New System.Drawing.Point(0, 33)
      Me.lvSiGrupo.MultiSelect = False
      Me.lvSiGrupo.Name = "lvSiGrupo"
      Me.lvSiGrupo.ShowGroups = False
      Me.lvSiGrupo.Size = New System.Drawing.Size(297, 257)
      Me.lvSiGrupo.SmallImageList = Me.ilMain
      Me.lvSiGrupo.TabIndex = 3
      Me.lvSiGrupo.UseCompatibleStateImageBehavior = False
      Me.lvSiGrupo.View = System.Windows.Forms.View.Details
      '
      'ColumnHeader5
      '
      Me.ColumnHeader5.Text = "No Integra"
      Me.ColumnHeader5.Width = 316
      '
      'Panel12
      '
      Me.Panel12.Controls.Add(Me.cmdSiUnoGrupo)
      Me.Panel12.Controls.Add(Me.cmdSiTodosGrupos)
      Me.Panel12.Controls.Add(Me.Label20)
      Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
      Me.Panel12.Location = New System.Drawing.Point(0, 0)
      Me.Panel12.Name = "Panel12"
      Me.Panel12.Size = New System.Drawing.Size(297, 33)
      Me.Panel12.TabIndex = 0
      '
      'cmdSiUnoGrupo
      '
      Me.cmdSiUnoGrupo.Image = CType(resources.GetObject("cmdSiUnoGrupo.Image"), System.Drawing.Image)
      Me.cmdSiUnoGrupo.Location = New System.Drawing.Point(31, 3)
      Me.cmdSiUnoGrupo.Name = "cmdSiUnoGrupo"
      Me.cmdSiUnoGrupo.Size = New System.Drawing.Size(28, 28)
      Me.cmdSiUnoGrupo.TabIndex = 6
      Me.cmdSiUnoGrupo.UseVisualStyleBackColor = True
      '
      'cmdSiTodosGrupos
      '
      Me.cmdSiTodosGrupos.Image = CType(resources.GetObject("cmdSiTodosGrupos.Image"), System.Drawing.Image)
      Me.cmdSiTodosGrupos.Location = New System.Drawing.Point(1, 3)
      Me.cmdSiTodosGrupos.Name = "cmdSiTodosGrupos"
      Me.cmdSiTodosGrupos.Size = New System.Drawing.Size(28, 28)
      Me.cmdSiTodosGrupos.TabIndex = 5
      Me.cmdSiTodosGrupos.UseVisualStyleBackColor = True
      '
      'Label20
      '
      Me.Label20.Dock = System.Windows.Forms.DockStyle.Right
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(207, 0)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(90, 33)
      Me.Label20.TabIndex = 1
      Me.Label20.Text = "Son miembros"
      Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'Panel13
      '
      Me.Panel13.Controls.Add(Me.cmdGuardarGrupo)
      Me.Panel13.Controls.Add(Me.cmdCancelarGrupo)
      Me.Panel13.Controls.Add(Me.Label22)
      Me.Panel13.Controls.Add(Me.Label21)
      Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.Panel13.Location = New System.Drawing.Point(3, 318)
      Me.Panel13.Name = "Panel13"
      Me.Panel13.Size = New System.Drawing.Size(601, 58)
      Me.Panel13.TabIndex = 10
      '
      'cmdGuardarGrupo
      '
      Me.cmdGuardarGrupo.Enabled = False
      Me.cmdGuardarGrupo.Location = New System.Drawing.Point(6, 5)
      Me.cmdGuardarGrupo.Name = "cmdGuardarGrupo"
      Me.cmdGuardarGrupo.Size = New System.Drawing.Size(79, 23)
      Me.cmdGuardarGrupo.TabIndex = 10
      Me.cmdGuardarGrupo.Text = "&Guardar"
      Me.cmdGuardarGrupo.UseVisualStyleBackColor = True
      '
      'cmdCancelarGrupo
      '
      Me.cmdCancelarGrupo.Enabled = False
      Me.cmdCancelarGrupo.Location = New System.Drawing.Point(6, 35)
      Me.cmdCancelarGrupo.Name = "cmdCancelarGrupo"
      Me.cmdCancelarGrupo.Size = New System.Drawing.Size(79, 23)
      Me.cmdCancelarGrupo.TabIndex = 12
      Me.cmdCancelarGrupo.Text = "&Cancelar"
      Me.cmdCancelarGrupo.UseVisualStyleBackColor = True
      '
      'Label22
      '
      Me.Label22.AutoSize = True
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
      Me.Label22.Location = New System.Drawing.Point(89, 4)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(144, 13)
      Me.Label22.TabIndex = 1
      Me.Label22.Text = "Cuentas Seleccionadas:"
      '
      'Label21
      '
      Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
      Me.Label21.Location = New System.Drawing.Point(89, 20)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(495, 43)
      Me.Label21.TabIndex = 0
      Me.Label21.Text = resources.GetString("Label21.Text")
      '
      'toolGrupos
      '
      Me.toolGrupos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel7, Me.cboGrupos, Me.btnPresentarGrupos, Me.ToolStripSeparator8, Me.btnLimpiarGrupos, Me.ToolStripSeparator4, Me.btnNuevoGrupo, Me.btnEliminarGrupo})
      Me.toolGrupos.Location = New System.Drawing.Point(3, 3)
      Me.toolGrupos.Name = "toolGrupos"
      Me.toolGrupos.Size = New System.Drawing.Size(601, 25)
      Me.toolGrupos.TabIndex = 9
      '
      'ToolStripLabel7
      '
      Me.ToolStripLabel7.Name = "ToolStripLabel7"
      Me.ToolStripLabel7.Size = New System.Drawing.Size(57, 22)
      Me.ToolStripLabel7.Text = "    Grupos:"
      '
      'cboGrupos
      '
      Me.cboGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboGrupos.Name = "cboGrupos"
      Me.cboGrupos.Size = New System.Drawing.Size(200, 25)
      '
      'btnPresentarGrupos
      '
      Me.btnPresentarGrupos.Image = CType(resources.GetObject("btnPresentarGrupos.Image"), System.Drawing.Image)
      Me.btnPresentarGrupos.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnPresentarGrupos.Name = "btnPresentarGrupos"
      Me.btnPresentarGrupos.Size = New System.Drawing.Size(74, 22)
      Me.btnPresentarGrupos.Text = "&Presentar"
      '
      'ToolStripSeparator8
      '
      Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
      Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
      '
      'btnLimpiarGrupos
      '
      Me.btnLimpiarGrupos.Enabled = False
      Me.btnLimpiarGrupos.Image = CType(resources.GetObject("btnLimpiarGrupos.Image"), System.Drawing.Image)
      Me.btnLimpiarGrupos.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnLimpiarGrupos.Name = "btnLimpiarGrupos"
      Me.btnLimpiarGrupos.Size = New System.Drawing.Size(60, 22)
      Me.btnLimpiarGrupos.Text = "&Limpiar"
      '
      'ToolStripSeparator4
      '
      Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
      Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
      '
      'btnNuevoGrupo
      '
      Me.btnNuevoGrupo.Image = CType(resources.GetObject("btnNuevoGrupo.Image"), System.Drawing.Image)
      Me.btnNuevoGrupo.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnNuevoGrupo.Name = "btnNuevoGrupo"
      Me.btnNuevoGrupo.Size = New System.Drawing.Size(58, 22)
      Me.btnNuevoGrupo.Text = "Nuevo"
      '
      'btnEliminarGrupo
      '
      Me.btnEliminarGrupo.Enabled = False
      Me.btnEliminarGrupo.Image = CType(resources.GetObject("btnEliminarGrupo.Image"), System.Drawing.Image)
      Me.btnEliminarGrupo.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnEliminarGrupo.Name = "btnEliminarGrupo"
      Me.btnEliminarGrupo.Size = New System.Drawing.Size(63, 22)
      Me.btnEliminarGrupo.Text = "Eliminar"
      '
      'tabAsignacion
      '
      Me.tabAsignacion.Controls.Add(Me.gridAsig)
      Me.tabAsignacion.Controls.Add(Me.toolAsignacion)
      Me.tabAsignacion.Location = New System.Drawing.Point(4, 22)
      Me.tabAsignacion.Name = "tabAsignacion"
      Me.tabAsignacion.Padding = New System.Windows.Forms.Padding(3)
      Me.tabAsignacion.Size = New System.Drawing.Size(607, 379)
      Me.tabAsignacion.TabIndex = 3
      Me.tabAsignacion.Text = "Asignación de perfiles"
      Me.tabAsignacion.UseVisualStyleBackColor = True
      '
      'gridAsig
      '
      Me.gridAsig.Cursor = System.Windows.Forms.Cursors.Default
      Me.gridAsig.Dock = System.Windows.Forms.DockStyle.Fill
      Me.gridAsig.EmbeddedNavigator.Buttons.Append.Visible = False
      Me.gridAsig.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
      Me.gridAsig.EmbeddedNavigator.Buttons.Edit.Visible = False
      Me.gridAsig.EmbeddedNavigator.Buttons.EndEdit.Visible = False
      Me.gridAsig.EmbeddedNavigator.Buttons.Remove.Visible = False
      Me.gridAsig.EmbeddedNavigator.Name = ""
      Me.gridAsig.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}"
      Me.gridAsig.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gridAsig.Location = New System.Drawing.Point(3, 28)
      Me.gridAsig.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
      Me.gridAsig.LookAndFeel.UseWindowsXPTheme = True
      Me.gridAsig.MainView = Me.gAsig
      Me.gridAsig.Name = "gridAsig"
      Me.gridAsig.Size = New System.Drawing.Size(601, 348)
      Me.gridAsig.TabIndex = 23
      Me.gridAsig.UseEmbeddedNavigator = True
      Me.gridAsig.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gAsig})
      '
      'gAsig
      '
      Me.gAsig.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGR_DESCRI, Me.colCP_DESCRI, Me.colHA_TIPOBJ, Me.colHA_CODOBJ, Me.colHA_CODPER})
      Me.gAsig.GridControl = Me.gridAsig
      Me.gAsig.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
      Me.gAsig.Name = "gAsig"
      Me.gAsig.OptionsBehavior.Editable = False
      Me.gAsig.OptionsMenu.EnableColumnMenu = False
      Me.gAsig.OptionsView.ColumnAutoWidth = False
      Me.gAsig.OptionsView.ShowGroupPanel = False
      Me.gAsig.PaintStyleName = "WindowsXP"
      Me.gAsig.RowHeight = 19
      '
      'colGR_DESCRI
      '
      Me.colGR_DESCRI.Caption = "Grupo o usuario"
      Me.colGR_DESCRI.FieldName = "GR_DESCRI"
      Me.colGR_DESCRI.Name = "colGR_DESCRI"
      Me.colGR_DESCRI.Visible = True
      Me.colGR_DESCRI.VisibleIndex = 0
      Me.colGR_DESCRI.Width = 200
      '
      'colCP_DESCRI
      '
      Me.colCP_DESCRI.Caption = "Perfil"
      Me.colCP_DESCRI.FieldName = "CP_DESCRI"
      Me.colCP_DESCRI.Name = "colCP_DESCRI"
      Me.colCP_DESCRI.Visible = True
      Me.colCP_DESCRI.VisibleIndex = 1
      Me.colCP_DESCRI.Width = 200
      '
      'colHA_TIPOBJ
      '
      Me.colHA_TIPOBJ.Caption = "Tipo"
      Me.colHA_TIPOBJ.FieldName = "HA_TIPOBJ"
      Me.colHA_TIPOBJ.Name = "colHA_TIPOBJ"
      Me.colHA_TIPOBJ.Visible = True
      Me.colHA_TIPOBJ.VisibleIndex = 2
      Me.colHA_TIPOBJ.Width = 120
      '
      'colHA_CODOBJ
      '
      Me.colHA_CODOBJ.Caption = "HA_CODOBJ"
      Me.colHA_CODOBJ.FieldName = "HA_CODOBJ"
      Me.colHA_CODOBJ.Name = "colHA_CODOBJ"
      '
      'colHA_CODPER
      '
      Me.colHA_CODPER.Caption = "HA_CODPER"
      Me.colHA_CODPER.FieldName = "HA_CODPER"
      Me.colHA_CODPER.Name = "colHA_CODPER"
      '
      'toolAsignacion
      '
      Me.toolAsignacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.cboGrupoAsig, Me.ToolStripLabel3, Me.cboPerfilAsig, Me.btnAsignarAsig, Me.ToolStripSeparator3, Me.btnEliminarAsig})
      Me.toolAsignacion.Location = New System.Drawing.Point(3, 3)
      Me.toolAsignacion.Name = "toolAsignacion"
      Me.toolAsignacion.Size = New System.Drawing.Size(601, 25)
      Me.toolAsignacion.TabIndex = 0
      Me.toolAsignacion.Text = "ToolStrip3"
      '
      'ToolStripLabel2
      '
      Me.ToolStripLabel2.Name = "ToolStripLabel2"
      Me.ToolStripLabel2.Size = New System.Drawing.Size(87, 22)
      Me.ToolStripLabel2.Text = "Grupo o usuario:"
      '
      'cboGrupoAsig
      '
      Me.cboGrupoAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboGrupoAsig.DropDownWidth = 200
      Me.cboGrupoAsig.Name = "cboGrupoAsig"
      Me.cboGrupoAsig.Size = New System.Drawing.Size(121, 25)
      '
      'ToolStripLabel3
      '
      Me.ToolStripLabel3.Name = "ToolStripLabel3"
      Me.ToolStripLabel3.Size = New System.Drawing.Size(35, 22)
      Me.ToolStripLabel3.Text = "Perfil:"
      '
      'cboPerfilAsig
      '
      Me.cboPerfilAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboPerfilAsig.DropDownWidth = 200
      Me.cboPerfilAsig.Name = "cboPerfilAsig"
      Me.cboPerfilAsig.Size = New System.Drawing.Size(121, 25)
      '
      'btnAsignarAsig
      '
      Me.btnAsignarAsig.Image = CType(resources.GetObject("btnAsignarAsig.Image"), System.Drawing.Image)
      Me.btnAsignarAsig.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnAsignarAsig.Name = "btnAsignarAsig"
      Me.btnAsignarAsig.Size = New System.Drawing.Size(63, 22)
      Me.btnAsignarAsig.Text = "Asignar"
      '
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'btnEliminarAsig
      '
      Me.btnEliminarAsig.Image = CType(resources.GetObject("btnEliminarAsig.Image"), System.Drawing.Image)
      Me.btnEliminarAsig.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnEliminarAsig.Name = "btnEliminarAsig"
      Me.btnEliminarAsig.Size = New System.Drawing.Size(63, 22)
      Me.btnEliminarAsig.Text = "Eliminar"
      '
      'tabDirectivas
      '
      Me.tabDirectivas.Controls.Add(Me.GridDirSeg)
      Me.tabDirectivas.Controls.Add(Me.toolDirSeg)
      Me.tabDirectivas.Location = New System.Drawing.Point(4, 22)
      Me.tabDirectivas.Name = "tabDirectivas"
      Me.tabDirectivas.Padding = New System.Windows.Forms.Padding(3)
      Me.tabDirectivas.Size = New System.Drawing.Size(607, 379)
      Me.tabDirectivas.TabIndex = 4
      Me.tabDirectivas.Text = "Directivas de seguridad"
      Me.tabDirectivas.UseVisualStyleBackColor = True
      '
      'GridDirSeg
      '
      Me.GridDirSeg.Cursor = System.Windows.Forms.Cursors.Default
      Me.GridDirSeg.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridDirSeg.EmbeddedNavigator.Buttons.Append.Visible = False
      Me.GridDirSeg.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
      Me.GridDirSeg.EmbeddedNavigator.Buttons.Edit.Visible = False
      Me.GridDirSeg.EmbeddedNavigator.Buttons.EndEdit.Visible = False
      Me.GridDirSeg.EmbeddedNavigator.Buttons.Remove.Visible = False
      Me.GridDirSeg.EmbeddedNavigator.Name = ""
      Me.GridDirSeg.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}"
      Me.GridDirSeg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GridDirSeg.Location = New System.Drawing.Point(3, 28)
      Me.GridDirSeg.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
      Me.GridDirSeg.LookAndFeel.UseWindowsXPTheme = True
      Me.GridDirSeg.MainView = Me.gDirSeg
      Me.GridDirSeg.Name = "GridDirSeg"
      Me.GridDirSeg.Size = New System.Drawing.Size(601, 348)
      Me.GridDirSeg.TabIndex = 25
      Me.GridDirSeg.UseEmbeddedNavigator = True
      Me.GridDirSeg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gDirSeg})
      '
      'gDirSeg
      '
      Me.gDirSeg.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDS_CODDIR, Me.colDS_DESCRI, Me.colDS_VIGENT})
      StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
      StyleFormatCondition2.Appearance.Options.UseFont = True
      StyleFormatCondition2.ApplyToRow = True
      StyleFormatCondition2.Column = Me.colDS_VIGENT
      StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
      StyleFormatCondition2.Value1 = "0"
      Me.gDirSeg.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
      Me.gDirSeg.GridControl = Me.GridDirSeg
      Me.gDirSeg.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
      Me.gDirSeg.Name = "gDirSeg"
      Me.gDirSeg.OptionsBehavior.Editable = False
      Me.gDirSeg.OptionsMenu.EnableColumnMenu = False
      Me.gDirSeg.OptionsView.ColumnAutoWidth = False
      Me.gDirSeg.OptionsView.ShowGroupPanel = False
      Me.gDirSeg.PaintStyleName = "WindowsXP"
      Me.gDirSeg.RowHeight = 19
      '
      'colDS_CODDIR
      '
      Me.colDS_CODDIR.Caption = "Código"
      Me.colDS_CODDIR.FieldName = "DS_CODDIR"
      Me.colDS_CODDIR.Name = "colDS_CODDIR"
      Me.colDS_CODDIR.Visible = True
      Me.colDS_CODDIR.VisibleIndex = 0
      Me.colDS_CODDIR.Width = 82
      '
      'colDS_DESCRI
      '
      Me.colDS_DESCRI.Caption = "Descripción de la directiva"
      Me.colDS_DESCRI.FieldName = "DS_DESCRI"
      Me.colDS_DESCRI.Name = "colDS_DESCRI"
      Me.colDS_DESCRI.Visible = True
      Me.colDS_DESCRI.VisibleIndex = 1
      Me.colDS_DESCRI.Width = 417
      '
      'toolDirSeg
      '
      Me.toolDirSeg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaDirSeg, Me.btnPropDirSeg, Me.btnEliminarDirSeg, Me.ToolStripSeparator5, Me.btnPredetermDirSeg})
      Me.toolDirSeg.Location = New System.Drawing.Point(3, 3)
      Me.toolDirSeg.Name = "toolDirSeg"
      Me.toolDirSeg.Size = New System.Drawing.Size(601, 25)
      Me.toolDirSeg.TabIndex = 24
      Me.toolDirSeg.Text = "ToolStrip3"
      '
      'btnNuevaDirSeg
      '
      Me.btnNuevaDirSeg.Image = CType(resources.GetObject("btnNuevaDirSeg.Image"), System.Drawing.Image)
      Me.btnNuevaDirSeg.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnNuevaDirSeg.Name = "btnNuevaDirSeg"
      Me.btnNuevaDirSeg.Size = New System.Drawing.Size(102, 22)
      Me.btnNuevaDirSeg.Text = "Nueva directiva"
      '
      'btnPropDirSeg
      '
      Me.btnPropDirSeg.Image = CType(resources.GetObject("btnPropDirSeg.Image"), System.Drawing.Image)
      Me.btnPropDirSeg.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnPropDirSeg.Name = "btnPropDirSeg"
      Me.btnPropDirSeg.Size = New System.Drawing.Size(86, 22)
      Me.btnPropDirSeg.Text = "Propiedades"
      '
      'btnEliminarDirSeg
      '
      Me.btnEliminarDirSeg.Image = CType(resources.GetObject("btnEliminarDirSeg.Image"), System.Drawing.Image)
      Me.btnEliminarDirSeg.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnEliminarDirSeg.Name = "btnEliminarDirSeg"
      Me.btnEliminarDirSeg.Size = New System.Drawing.Size(63, 22)
      Me.btnEliminarDirSeg.Text = "Eliminar"
      '
      'ToolStripSeparator5
      '
      Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
      Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
      '
      'btnPredetermDirSeg
      '
      Me.btnPredetermDirSeg.Image = CType(resources.GetObject("btnPredetermDirSeg.Image"), System.Drawing.Image)
      Me.btnPredetermDirSeg.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnPredetermDirSeg.Name = "btnPredetermDirSeg"
      Me.btnPredetermDirSeg.Size = New System.Drawing.Size(188, 22)
      Me.btnPredetermDirSeg.Text = "Establecer como directiva vigente"
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
      Me.ClientSize = New System.Drawing.Size(615, 455)
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
      Me.TabControl1.ResumeLayout(False)
      Me.tabPerfiles.ResumeLayout(False)
      Me.tabPerfiles.PerformLayout()
      Me.panTreeView.ResumeLayout(False)
      Me.panBotones.ResumeLayout(False)
      Me.panBotones.PerformLayout()
      Me.toolPerfil.ResumeLayout(False)
      Me.toolPerfil.PerformLayout()
      Me.tabUsuarios.ResumeLayout(False)
      Me.tabUsuarios.PerformLayout()
      CType(Me.GridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.gUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
      Me.toolUsuarios.ResumeLayout(False)
      Me.toolUsuarios.PerformLayout()
      Me.tabGrupos.ResumeLayout(False)
      Me.tabGrupos.PerformLayout()
      Me.SplitContainer2.Panel1.ResumeLayout(False)
      Me.SplitContainer2.Panel2.ResumeLayout(False)
      Me.SplitContainer2.ResumeLayout(False)
      Me.Panel10.ResumeLayout(False)
      Me.Panel11.ResumeLayout(False)
      Me.Panel12.ResumeLayout(False)
      Me.Panel13.ResumeLayout(False)
      Me.Panel13.PerformLayout()
      Me.toolGrupos.ResumeLayout(False)
      Me.toolGrupos.PerformLayout()
      Me.tabAsignacion.ResumeLayout(False)
      Me.tabAsignacion.PerformLayout()
      CType(Me.gridAsig, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.gAsig, System.ComponentModel.ISupportInitialize).EndInit()
      Me.toolAsignacion.ResumeLayout(False)
      Me.toolAsignacion.PerformLayout()
      Me.tabDirectivas.ResumeLayout(False)
      Me.tabDirectivas.PerformLayout()
      CType(Me.GridDirSeg, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.gDirSeg, System.ComponentModel.ISupportInitialize).EndInit()
      Me.toolDirSeg.ResumeLayout(False)
      Me.toolDirSeg.PerformLayout()
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
   Friend WithEvents ilMain As System.Windows.Forms.ImageList
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents tabPerfiles As System.Windows.Forms.TabPage
   Friend WithEvents tabUsuarios As System.Windows.Forms.TabPage
   Friend WithEvents tabGrupos As System.Windows.Forms.TabPage
   Friend WithEvents tabAsignacion As System.Windows.Forms.TabPage
   Friend WithEvents tabDirectivas As System.Windows.Forms.TabPage
   Friend WithEvents toolPerfil As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboPerfilPerfiles As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnPresentarPerfil As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnLimpiarPerfil As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnNuevoPerfil As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnEliminarPerfil As System.Windows.Forms.ToolStripButton
   Friend WithEvents panBotones As System.Windows.Forms.Panel
   Friend WithEvents panTreeView As System.Windows.Forms.Panel
   Friend WithEvents tvMenu As System.Windows.Forms.TreeView
   Friend WithEvents cmdCancelarPerfil As System.Windows.Forms.Button
   Friend WithEvents cmdGuardarPerfil As System.Windows.Forms.Button
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents toolUsuarios As System.Windows.Forms.ToolStrip
   Friend WithEvents btnNuevoUsuario As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnEditarUsuario As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnUsuarioBaja As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnCambiarPassUsuario As System.Windows.Forms.ToolStripButton
   Friend WithEvents GridUsuarios As DevExpress.XtraGrid.GridControl
   Friend WithEvents gUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents colUS_CODUSU As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_DESCRI As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_PASSWO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_PASS01 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_PASS02 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_PASS03 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_PASS04 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_PASS05 As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_FECALT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_FECVTO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_ENCRYP As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_BLOQUE As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_GRACIA As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_CODENT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_CORREO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_INTERN As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUS_FECBAJ As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents toolAsignacion As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboGrupoAsig As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboPerfilAsig As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnAsignarAsig As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnEliminarAsig As System.Windows.Forms.ToolStripButton
   Friend WithEvents colUS_ADMIN As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
   Friend WithEvents lvNoGrupo As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
   Friend WithEvents Panel10 As System.Windows.Forms.Panel
   Friend WithEvents Panel11 As System.Windows.Forms.Panel
   Friend WithEvents cmdNoTodosGrupos As System.Windows.Forms.Button
   Friend WithEvents cmdNoUnoGrupo As System.Windows.Forms.Button
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents lvSiGrupo As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
   Friend WithEvents Panel12 As System.Windows.Forms.Panel
   Friend WithEvents cmdSiUnoGrupo As System.Windows.Forms.Button
   Friend WithEvents cmdSiTodosGrupos As System.Windows.Forms.Button
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Panel13 As System.Windows.Forms.Panel
   Friend WithEvents cmdGuardarGrupo As System.Windows.Forms.Button
   Friend WithEvents cmdCancelarGrupo As System.Windows.Forms.Button
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents toolGrupos As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboGrupos As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnPresentarGrupos As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnLimpiarGrupos As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnNuevoGrupo As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnEliminarGrupo As System.Windows.Forms.ToolStripButton
   Friend WithEvents gridAsig As DevExpress.XtraGrid.GridControl
   Friend WithEvents gAsig As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents colGR_DESCRI As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colCP_DESCRI As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colHA_TIPOBJ As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colHA_CODOBJ As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colHA_CODPER As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents GridDirSeg As DevExpress.XtraGrid.GridControl
   Friend WithEvents gDirSeg As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents toolDirSeg As System.Windows.Forms.ToolStrip
   Friend WithEvents btnNuevaDirSeg As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnPropDirSeg As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnPredetermDirSeg As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnEliminarDirSeg As System.Windows.Forms.ToolStripButton
   Friend WithEvents colDS_CODDIR As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colDS_DESCRI As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colDS_VIGENT As DevExpress.XtraGrid.Columns.GridColumn
End Class
