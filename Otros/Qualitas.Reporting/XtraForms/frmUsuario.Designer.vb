<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Usuarios", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "00000"}, 0)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Usuarios", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "00000"}, 0)
        Me.Tabs = New DevExpress.XtraTab.XtraTabControl
        Me.tpGeneral = New DevExpress.XtraTab.XtraTabPage
        Me.grpEstado = New DevExpress.XtraEditors.GroupControl
        Me.txtIntentos = New DevExpress.XtraEditors.TextEdit
        Me.lblContadorFallidos = New DevExpress.XtraEditors.LabelControl
        Me.chkBloqueado = New DevExpress.XtraEditors.CheckEdit
        Me.chkEstado = New DevExpress.XtraEditors.CheckEdit
        Me.grpPermisos = New DevExpress.XtraEditors.GroupControl
        Me.chkPermisoEliminar = New DevExpress.XtraEditors.CheckEdit
        Me.chkOpcionesGenerales = New DevExpress.XtraEditors.CheckEdit
        Me.chkPermisoConexiones = New DevExpress.XtraEditors.CheckEdit
        Me.chkPermisoCategorias = New DevExpress.XtraEditors.CheckEdit
        Me.chkPermisoSeguridad = New DevExpress.XtraEditors.CheckEdit
        Me.chkPermisoExportar = New DevExpress.XtraEditors.CheckEdit
        Me.chkPermisoImportar = New DevExpress.XtraEditors.CheckEdit
        Me.chkPermisoDisenar = New DevExpress.XtraEditors.CheckEdit
        Me.chkPermisoEjecutar = New DevExpress.XtraEditors.CheckEdit
        Me.txtNombreCompleto = New DevExpress.XtraEditors.TextEdit
        Me.txtNombreLogin = New DevExpress.XtraEditors.TextEdit
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.lblNombreCompleto = New DevExpress.XtraEditors.LabelControl
        Me.lblLoginName = New DevExpress.XtraEditors.LabelControl
        Me.tpPermisos = New DevExpress.XtraTab.XtraTabPage
        Me.btnHabilitarTodas = New DevExpress.XtraEditors.SimpleButton
        Me.btnHabilitarSeleccion = New DevExpress.XtraEditors.SimpleButton
        Me.btnInhabilitarTodas = New DevExpress.XtraEditors.SimpleButton
        Me.btnInhablitarSeleccion = New DevExpress.XtraEditors.SimpleButton
        Me.oSplitter = New DevExpress.XtraEditors.SplitContainerControl
        Me.lvHabilitadas = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.lvNoHabilitadas = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblNoHabilitadas = New DevExpress.XtraEditors.LabelControl
        Me.lblHabilitadas = New DevExpress.XtraEditors.LabelControl
        Me.picProhibir = New System.Windows.Forms.PictureBox
        Me.picPermitir = New System.Windows.Forms.PictureBox
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        CType(Me.grpEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstado.SuspendLayout()
        CType(Me.txtIntentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBloqueado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPermisos.SuspendLayout()
        CType(Me.chkPermisoEliminar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOpcionesGenerales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPermisoConexiones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPermisoCategorias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPermisoSeguridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPermisoExportar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPermisoImportar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPermisoDisenar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPermisoEjecutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCompleto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPermisos.SuspendLayout()
        CType(Me.oSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitter.SuspendLayout()
        CType(Me.picProhibir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPermitir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Location = New System.Drawing.Point(8, 5)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedTabPage = Me.tpGeneral
        Me.Tabs.Size = New System.Drawing.Size(491, 456)
        Me.Tabs.TabIndex = 0
        Me.Tabs.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpGeneral, Me.tpPermisos})
        '
        'tpGeneral
        '
        Me.tpGeneral.Controls.Add(Me.grpEstado)
        Me.tpGeneral.Controls.Add(Me.grpPermisos)
        Me.tpGeneral.Controls.Add(Me.txtNombreCompleto)
        Me.tpGeneral.Controls.Add(Me.txtNombreLogin)
        Me.tpGeneral.Controls.Add(Me.lblPassword)
        Me.tpGeneral.Controls.Add(Me.txtPassword)
        Me.tpGeneral.Controls.Add(Me.lblNombreCompleto)
        Me.tpGeneral.Controls.Add(Me.lblLoginName)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Size = New System.Drawing.Size(482, 425)
        Me.tpGeneral.Text = "General"
        '
        'grpEstado
        '
        Me.grpEstado.Controls.Add(Me.txtIntentos)
        Me.grpEstado.Controls.Add(Me.lblContadorFallidos)
        Me.grpEstado.Controls.Add(Me.chkBloqueado)
        Me.grpEstado.Controls.Add(Me.chkEstado)
        Me.grpEstado.Location = New System.Drawing.Point(10, 281)
        Me.grpEstado.Name = "grpEstado"
        Me.grpEstado.Size = New System.Drawing.Size(459, 75)
        Me.grpEstado.TabIndex = 0
        Me.grpEstado.Text = "Estado"
        '
        'txtIntentos
        '
        Me.txtIntentos.EditValue = "0"
        Me.txtIntentos.Enabled = False
        Me.txtIntentos.Location = New System.Drawing.Point(411, 47)
        Me.txtIntentos.Name = "txtIntentos"
        Me.txtIntentos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIntentos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIntentos.Size = New System.Drawing.Size(43, 20)
        Me.txtIntentos.TabIndex = 12
        '
        'lblContadorFallidos
        '
        Me.lblContadorFallidos.Appearance.Options.UseTextOptions = True
        Me.lblContadorFallidos.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblContadorFallidos.Location = New System.Drawing.Point(184, 51)
        Me.lblContadorFallidos.Name = "lblContadorFallidos"
        Me.lblContadorFallidos.Size = New System.Drawing.Size(221, 13)
        Me.lblContadorFallidos.TabIndex = 5
        Me.lblContadorFallidos.Text = "Contador de intentos fallidos al inciciar sesión:"
        '
        'chkBloqueado
        '
        Me.chkBloqueado.Location = New System.Drawing.Point(5, 48)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Properties.Caption = "Bloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(162, 19)
        Me.chkBloqueado.TabIndex = 11
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(5, 23)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Properties.Caption = "Suspendido"
        Me.chkEstado.Size = New System.Drawing.Size(162, 19)
        Me.chkEstado.TabIndex = 10
        '
        'grpPermisos
        '
        Me.grpPermisos.Controls.Add(Me.chkPermisoEliminar)
        Me.grpPermisos.Controls.Add(Me.chkOpcionesGenerales)
        Me.grpPermisos.Controls.Add(Me.chkPermisoConexiones)
        Me.grpPermisos.Controls.Add(Me.chkPermisoCategorias)
        Me.grpPermisos.Controls.Add(Me.chkPermisoSeguridad)
        Me.grpPermisos.Controls.Add(Me.chkPermisoExportar)
        Me.grpPermisos.Controls.Add(Me.chkPermisoImportar)
        Me.grpPermisos.Controls.Add(Me.chkPermisoDisenar)
        Me.grpPermisos.Controls.Add(Me.chkPermisoEjecutar)
        Me.grpPermisos.Location = New System.Drawing.Point(10, 108)
        Me.grpPermisos.Name = "grpPermisos"
        Me.grpPermisos.Size = New System.Drawing.Size(459, 148)
        Me.grpPermisos.TabIndex = 6
        Me.grpPermisos.Text = "Permisos"
        '
        'chkPermisoEliminar
        '
        Me.chkPermisoEliminar.Location = New System.Drawing.Point(5, 119)
        Me.chkPermisoEliminar.Name = "chkPermisoEliminar"
        Me.chkPermisoEliminar.Properties.Caption = "Eliminar consultas"
        Me.chkPermisoEliminar.Size = New System.Drawing.Size(207, 19)
        Me.chkPermisoEliminar.TabIndex = 7
        '
        'chkOpcionesGenerales
        '
        Me.chkOpcionesGenerales.Location = New System.Drawing.Point(221, 95)
        Me.chkOpcionesGenerales.Name = "chkOpcionesGenerales"
        Me.chkOpcionesGenerales.Properties.Caption = "Modificar opciones globales"
        Me.chkOpcionesGenerales.Size = New System.Drawing.Size(233, 19)
        Me.chkOpcionesGenerales.TabIndex = 10
        '
        'chkPermisoConexiones
        '
        Me.chkPermisoConexiones.Location = New System.Drawing.Point(221, 71)
        Me.chkPermisoConexiones.Name = "chkPermisoConexiones"
        Me.chkPermisoConexiones.Properties.Caption = "Administrar conexiones"
        Me.chkPermisoConexiones.Size = New System.Drawing.Size(233, 19)
        Me.chkPermisoConexiones.TabIndex = 9
        '
        'chkPermisoCategorias
        '
        Me.chkPermisoCategorias.Location = New System.Drawing.Point(221, 47)
        Me.chkPermisoCategorias.Name = "chkPermisoCategorias"
        Me.chkPermisoCategorias.Properties.Caption = "Administrar categorías"
        Me.chkPermisoCategorias.Size = New System.Drawing.Size(233, 19)
        Me.chkPermisoCategorias.TabIndex = 8
        '
        'chkPermisoSeguridad
        '
        Me.chkPermisoSeguridad.Location = New System.Drawing.Point(221, 23)
        Me.chkPermisoSeguridad.Name = "chkPermisoSeguridad"
        Me.chkPermisoSeguridad.Properties.Caption = "Administrar seguridad"
        Me.chkPermisoSeguridad.Size = New System.Drawing.Size(233, 19)
        Me.chkPermisoSeguridad.TabIndex = 7
        '
        'chkPermisoExportar
        '
        Me.chkPermisoExportar.Location = New System.Drawing.Point(5, 95)
        Me.chkPermisoExportar.Name = "chkPermisoExportar"
        Me.chkPermisoExportar.Properties.Caption = "Exportar consultas"
        Me.chkPermisoExportar.Size = New System.Drawing.Size(207, 19)
        Me.chkPermisoExportar.TabIndex = 6
        '
        'chkPermisoImportar
        '
        Me.chkPermisoImportar.Location = New System.Drawing.Point(5, 71)
        Me.chkPermisoImportar.Name = "chkPermisoImportar"
        Me.chkPermisoImportar.Properties.Caption = "Importar consultas"
        Me.chkPermisoImportar.Size = New System.Drawing.Size(207, 19)
        Me.chkPermisoImportar.TabIndex = 5
        '
        'chkPermisoDisenar
        '
        Me.chkPermisoDisenar.Location = New System.Drawing.Point(5, 47)
        Me.chkPermisoDisenar.Name = "chkPermisoDisenar"
        Me.chkPermisoDisenar.Properties.Caption = "Diseñar consultas"
        Me.chkPermisoDisenar.Size = New System.Drawing.Size(207, 19)
        Me.chkPermisoDisenar.TabIndex = 4
        '
        'chkPermisoEjecutar
        '
        Me.chkPermisoEjecutar.Location = New System.Drawing.Point(5, 23)
        Me.chkPermisoEjecutar.Name = "chkPermisoEjecutar"
        Me.chkPermisoEjecutar.Properties.Caption = "Ejecutar consultas"
        Me.chkPermisoEjecutar.Size = New System.Drawing.Size(207, 19)
        Me.chkPermisoEjecutar.TabIndex = 3
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Location = New System.Drawing.Point(156, 40)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(288, 20)
        Me.txtNombreCompleto.TabIndex = 1
        '
        'txtNombreLogin
        '
        Me.txtNombreLogin.Location = New System.Drawing.Point(156, 14)
        Me.txtNombreLogin.Name = "txtNombreLogin"
        Me.txtNombreLogin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreLogin.Properties.Appearance.Options.UseFont = True
        Me.txtNombreLogin.Size = New System.Drawing.Size(154, 20)
        Me.txtNombreLogin.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(10, 69)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtPassword
        '
        Me.txtPassword.EditValue = ""
        Me.txtPassword.Location = New System.Drawing.Point(156, 66)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtPassword.TabIndex = 2
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.Location = New System.Drawing.Point(10, 43)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(87, 13)
        Me.lblNombreCompleto.TabIndex = 1
        Me.lblNombreCompleto.Text = "Nombre completo:"
        '
        'lblLoginName
        '
        Me.lblLoginName.Location = New System.Drawing.Point(10, 17)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(130, 13)
        Me.lblLoginName.TabIndex = 0
        Me.lblLoginName.Text = "Nombre de inicio de sesión:"
        '
        'tpPermisos
        '
        Me.tpPermisos.Controls.Add(Me.btnHabilitarTodas)
        Me.tpPermisos.Controls.Add(Me.btnHabilitarSeleccion)
        Me.tpPermisos.Controls.Add(Me.btnInhabilitarTodas)
        Me.tpPermisos.Controls.Add(Me.btnInhablitarSeleccion)
        Me.tpPermisos.Controls.Add(Me.oSplitter)
        Me.tpPermisos.Controls.Add(Me.lblNoHabilitadas)
        Me.tpPermisos.Controls.Add(Me.lblHabilitadas)
        Me.tpPermisos.Controls.Add(Me.picProhibir)
        Me.tpPermisos.Controls.Add(Me.picPermitir)
        Me.tpPermisos.Name = "tpPermisos"
        Me.tpPermisos.Size = New System.Drawing.Size(482, 425)
        Me.tpPermisos.Text = "Permisos sobre consultas"
        '
        'btnHabilitarTodas
        '
        Me.btnHabilitarTodas.Image = CType(resources.GetObject("btnHabilitarTodas.Image"), System.Drawing.Image)
        Me.btnHabilitarTodas.Location = New System.Drawing.Point(444, 390)
        Me.btnHabilitarTodas.Name = "btnHabilitarTodas"
        Me.btnHabilitarTodas.Size = New System.Drawing.Size(33, 32)
        Me.btnHabilitarTodas.TabIndex = 18
        '
        'btnHabilitarSeleccion
        '
        Me.btnHabilitarSeleccion.Image = CType(resources.GetObject("btnHabilitarSeleccion.Image"), System.Drawing.Image)
        Me.btnHabilitarSeleccion.Location = New System.Drawing.Point(405, 390)
        Me.btnHabilitarSeleccion.Name = "btnHabilitarSeleccion"
        Me.btnHabilitarSeleccion.Size = New System.Drawing.Size(33, 32)
        Me.btnHabilitarSeleccion.TabIndex = 17
        '
        'btnInhabilitarTodas
        '
        Me.btnInhabilitarTodas.Image = CType(resources.GetObject("btnInhabilitarTodas.Image"), System.Drawing.Image)
        Me.btnInhabilitarTodas.Location = New System.Drawing.Point(444, 3)
        Me.btnInhabilitarTodas.Name = "btnInhabilitarTodas"
        Me.btnInhabilitarTodas.Size = New System.Drawing.Size(33, 32)
        Me.btnInhabilitarTodas.TabIndex = 14
        '
        'btnInhablitarSeleccion
        '
        Me.btnInhablitarSeleccion.Image = CType(resources.GetObject("btnInhablitarSeleccion.Image"), System.Drawing.Image)
        Me.btnInhablitarSeleccion.Location = New System.Drawing.Point(405, 3)
        Me.btnInhablitarSeleccion.Name = "btnInhablitarSeleccion"
        Me.btnInhablitarSeleccion.Size = New System.Drawing.Size(33, 32)
        Me.btnInhablitarSeleccion.TabIndex = 13
        '
        'oSplitter
        '
        Me.oSplitter.Horizontal = False
        Me.oSplitter.Location = New System.Drawing.Point(3, 41)
        Me.oSplitter.Name = "oSplitter"
        Me.oSplitter.Panel1.Controls.Add(Me.lvHabilitadas)
        Me.oSplitter.Panel1.Text = "Panel1"
        Me.oSplitter.Panel2.Controls.Add(Me.lvNoHabilitadas)
        Me.oSplitter.Panel2.Text = "Panel2"
        Me.oSplitter.Size = New System.Drawing.Size(476, 343)
        Me.oSplitter.SplitterPosition = 168
        Me.oSplitter.TabIndex = 4
        '
        'lvHabilitadas
        '
        Me.lvHabilitadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvHabilitadas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002})
        Me.lvHabilitadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvHabilitadas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup1.Header = "Usuarios"
        ListViewGroup1.Name = "lvg001"
        Me.lvHabilitadas.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lvHabilitadas.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        Me.lvHabilitadas.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvHabilitadas.LargeImageList = Me.il32x32
        Me.lvHabilitadas.Location = New System.Drawing.Point(0, 0)
        Me.lvHabilitadas.MultiSelect = False
        Me.lvHabilitadas.Name = "lvHabilitadas"
        Me.lvHabilitadas.Size = New System.Drawing.Size(472, 164)
        Me.lvHabilitadas.SmallImageList = Me.il32x32
        Me.lvHabilitadas.TabIndex = 15
        Me.lvHabilitadas.TileSize = New System.Drawing.Size(400, 32)
        Me.lvHabilitadas.UseCompatibleStateImageBehavior = False
        Me.lvHabilitadas.View = System.Windows.Forms.View.Tile
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "007.png")
        '
        'lvNoHabilitadas
        '
        Me.lvNoHabilitadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvNoHabilitadas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvNoHabilitadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNoHabilitadas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup2.Header = "Usuarios"
        ListViewGroup2.Name = "lvg001"
        Me.lvNoHabilitadas.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup2})
        Me.lvNoHabilitadas.HideSelection = False
        ListViewItem2.Group = ListViewGroup2
        Me.lvNoHabilitadas.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lvNoHabilitadas.LargeImageList = Me.il32x32
        Me.lvNoHabilitadas.Location = New System.Drawing.Point(0, 0)
        Me.lvNoHabilitadas.MultiSelect = False
        Me.lvNoHabilitadas.Name = "lvNoHabilitadas"
        Me.lvNoHabilitadas.Size = New System.Drawing.Size(472, 165)
        Me.lvNoHabilitadas.SmallImageList = Me.il32x32
        Me.lvNoHabilitadas.TabIndex = 16
        Me.lvNoHabilitadas.TileSize = New System.Drawing.Size(400, 32)
        Me.lvNoHabilitadas.UseCompatibleStateImageBehavior = False
        Me.lvNoHabilitadas.View = System.Windows.Forms.View.Tile
        '
        'lblNoHabilitadas
        '
        Me.lblNoHabilitadas.Location = New System.Drawing.Point(41, 400)
        Me.lblNoHabilitadas.Name = "lblNoHabilitadas"
        Me.lblNoHabilitadas.Size = New System.Drawing.Size(200, 13)
        Me.lblNoHabilitadas.TabIndex = 3
        Me.lblNoHabilitadas.Text = "Consultas no habilitadas para la ejecución"
        '
        'lblHabilitadas
        '
        Me.lblHabilitadas.Location = New System.Drawing.Point(41, 11)
        Me.lblHabilitadas.Name = "lblHabilitadas"
        Me.lblHabilitadas.Size = New System.Drawing.Size(185, 13)
        Me.lblHabilitadas.TabIndex = 2
        Me.lblHabilitadas.Text = "Consultas habilitadas para la ejecución"
        '
        'picProhibir
        '
        Me.picProhibir.Image = CType(resources.GetObject("picProhibir.Image"), System.Drawing.Image)
        Me.picProhibir.Location = New System.Drawing.Point(3, 390)
        Me.picProhibir.Name = "picProhibir"
        Me.picProhibir.Size = New System.Drawing.Size(32, 32)
        Me.picProhibir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picProhibir.TabIndex = 1
        Me.picProhibir.TabStop = False
        '
        'picPermitir
        '
        Me.picPermitir.Image = CType(resources.GetObject("picPermitir.Image"), System.Drawing.Image)
        Me.picPermitir.Location = New System.Drawing.Point(3, 3)
        Me.picPermitir.Name = "picPermitir"
        Me.picPermitir.Size = New System.Drawing.Size(32, 32)
        Me.picPermitir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPermitir.TabIndex = 0
        Me.picPermitir.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(315, 467)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(89, 26)
        Me.cmdAceptar.TabIndex = 19
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(410, 467)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(89, 26)
        Me.cmdCancelar.TabIndex = 20
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmUsuario
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(506, 502)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Tabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        CType(Me.Tabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        CType(Me.grpEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstado.ResumeLayout(False)
        Me.grpEstado.PerformLayout()
        CType(Me.txtIntentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBloqueado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPermisos.ResumeLayout(False)
        CType(Me.chkPermisoEliminar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOpcionesGenerales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPermisoConexiones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPermisoCategorias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPermisoSeguridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPermisoExportar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPermisoImportar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPermisoDisenar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPermisoEjecutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCompleto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPermisos.ResumeLayout(False)
        Me.tpPermisos.PerformLayout()
        CType(Me.oSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitter.ResumeLayout(False)
        CType(Me.picProhibir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPermitir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpGeneral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpPermisos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblLoginName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNombreCompleto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEstado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpPermisos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkPermisoEjecutar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNombreCompleto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreLogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPermisoCategorias As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPermisoSeguridad As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPermisoExportar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPermisoImportar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPermisoDisenar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPermisoConexiones As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkBloqueado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtIntentos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblContadorFallidos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents oSplitter As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lblNoHabilitadas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHabilitadas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picProhibir As System.Windows.Forms.PictureBox
    Friend WithEvents picPermitir As System.Windows.Forms.PictureBox
    Friend WithEvents lvHabilitadas As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents btnInhablitarSeleccion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lvNoHabilitadas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnHabilitarTodas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHabilitarSeleccion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInhabilitarTodas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkOpcionesGenerales As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPermisoEliminar As DevExpress.XtraEditors.CheckEdit
End Class
