<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.tabProp = New System.Windows.Forms.TabPage
      Me.frPassword = New System.Windows.Forms.GroupBox
      Me.txtConfirmacion = New System.Windows.Forms.TextBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtPassword = New System.Windows.Forms.TextBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.txtIntentosRestantes = New System.Windows.Forms.TextBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.txtFechaBaja = New System.Windows.Forms.TextBox
      Me.txtFechaAlta = New System.Windows.Forms.TextBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.chkSoloLectura = New System.Windows.Forms.CheckBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.chkAdmin = New System.Windows.Forms.CheckBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.chkBloqueado = New System.Windows.Forms.CheckBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtInterno = New System.Windows.Forms.TextBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtCorreo = New System.Windows.Forms.TextBox
      Me.txtFechaVtoPassword = New System.Windows.Forms.TextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.cboEntidad = New System.Windows.Forms.ComboBox
      Me.txtNombreCompleto = New System.Windows.Forms.TextBox
      Me.txtNombreInicioSesion = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.tabGrupos = New System.Windows.Forms.TabPage
      Me.lvGrupos = New System.Windows.Forms.ListView
      Me.toolGrupos = New System.Windows.Forms.ToolStrip
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
      Me.cboGrupos = New System.Windows.Forms.ToolStripComboBox
      Me.btnAgregar = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.btnQuitar = New System.Windows.Forms.ToolStripButton
      Me.tabHab = New System.Windows.Forms.TabPage
      Me.splitHabilitaciones = New System.Windows.Forms.SplitContainer
      Me.panHab = New System.Windows.Forms.Panel
      Me.lvHab = New System.Windows.Forms.ListView
      Me.panDeshab = New System.Windows.Forms.Panel
      Me.lvDeshab = New System.Windows.Forms.ListView
      Me.cmdQuitarHab = New System.Windows.Forms.Button
      Me.cmdAgregarHab = New System.Windows.Forms.Button
      Me.cmdAgregarDeshab = New System.Windows.Forms.Button
      Me.cmdQuitarDeshab = New System.Windows.Forms.Button
      Me.panLabelHab = New System.Windows.Forms.Panel
      Me.cboHab = New System.Windows.Forms.ComboBox
      Me.lblHab = New System.Windows.Forms.Label
      Me.panLabelDeshab = New System.Windows.Forms.Panel
      Me.cboDesHab = New System.Windows.Forms.ComboBox
      Me.lblDesHab = New System.Windows.Forms.Label
      Me.TableLayoutPanel1.SuspendLayout()
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabControl1.SuspendLayout()
      Me.tabProp.SuspendLayout()
      Me.frPassword.SuspendLayout()
      Me.tabGrupos.SuspendLayout()
      Me.toolGrupos.SuspendLayout()
      Me.tabHab.SuspendLayout()
      Me.splitHabilitaciones.Panel1.SuspendLayout()
      Me.splitHabilitaciones.Panel2.SuspendLayout()
      Me.splitHabilitaciones.SuspendLayout()
      Me.panHab.SuspendLayout()
      Me.panDeshab.SuspendLayout()
      Me.panLabelHab.SuspendLayout()
      Me.panLabelDeshab.SuspendLayout()
      Me.SuspendLayout()
      '
      'TableLayoutPanel1
      '
      Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TableLayoutPanel1.ColumnCount = 2
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
      Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(480, 426)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 1
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
      Me.TableLayoutPanel1.TabIndex = 0
      '
      'OK_Button
      '
      Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.OK_Button.Location = New System.Drawing.Point(3, 3)
      Me.OK_Button.Name = "OK_Button"
      Me.OK_Button.Size = New System.Drawing.Size(67, 23)
      Me.OK_Button.TabIndex = 17
      Me.OK_Button.Text = "Aceptar"
      '
      'Cancel_Button
      '
      Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
      Me.Cancel_Button.Name = "Cancel_Button"
      Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
      Me.Cancel_Button.TabIndex = 18
      Me.Cancel_Button.Text = "Cancelar"
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
      Me.panTop.Size = New System.Drawing.Size(632, 45)
      Me.panTop.TabIndex = 18
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(571, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(61, 45)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(21, 23)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(292, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Ingrese los datos requeridos y haga clic en el botón Aceptar."
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(142, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Propiedades del usuario"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.tabProp)
      Me.TabControl1.Controls.Add(Me.tabGrupos)
      Me.TabControl1.Controls.Add(Me.tabHab)
      Me.TabControl1.Location = New System.Drawing.Point(7, 51)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(616, 369)
      Me.TabControl1.TabIndex = 19
      '
      'tabProp
      '
      Me.tabProp.Controls.Add(Me.frPassword)
      Me.tabProp.Controls.Add(Me.txtIntentosRestantes)
      Me.tabProp.Controls.Add(Me.Label10)
      Me.tabProp.Controls.Add(Me.txtFechaBaja)
      Me.tabProp.Controls.Add(Me.txtFechaAlta)
      Me.tabProp.Controls.Add(Me.Label11)
      Me.tabProp.Controls.Add(Me.Label12)
      Me.tabProp.Controls.Add(Me.chkSoloLectura)
      Me.tabProp.Controls.Add(Me.Label9)
      Me.tabProp.Controls.Add(Me.chkAdmin)
      Me.tabProp.Controls.Add(Me.Label8)
      Me.tabProp.Controls.Add(Me.chkBloqueado)
      Me.tabProp.Controls.Add(Me.Label7)
      Me.tabProp.Controls.Add(Me.txtInterno)
      Me.tabProp.Controls.Add(Me.Label6)
      Me.tabProp.Controls.Add(Me.txtCorreo)
      Me.tabProp.Controls.Add(Me.txtFechaVtoPassword)
      Me.tabProp.Controls.Add(Me.Label4)
      Me.tabProp.Controls.Add(Me.Label5)
      Me.tabProp.Controls.Add(Me.cboEntidad)
      Me.tabProp.Controls.Add(Me.txtNombreCompleto)
      Me.tabProp.Controls.Add(Me.txtNombreInicioSesion)
      Me.tabProp.Controls.Add(Me.Label3)
      Me.tabProp.Controls.Add(Me.Label2)
      Me.tabProp.Controls.Add(Me.Label1)
      Me.tabProp.Location = New System.Drawing.Point(4, 22)
      Me.tabProp.Name = "tabProp"
      Me.tabProp.Padding = New System.Windows.Forms.Padding(3)
      Me.tabProp.Size = New System.Drawing.Size(608, 343)
      Me.tabProp.TabIndex = 0
      Me.tabProp.Text = "Propiedades"
      Me.tabProp.UseVisualStyleBackColor = True
      '
      'frPassword
      '
      Me.frPassword.Controls.Add(Me.txtConfirmacion)
      Me.frPassword.Controls.Add(Me.Label13)
      Me.frPassword.Controls.Add(Me.txtPassword)
      Me.frPassword.Controls.Add(Me.Label14)
      Me.frPassword.Location = New System.Drawing.Point(9, 271)
      Me.frPassword.Name = "frPassword"
      Me.frPassword.Size = New System.Drawing.Size(588, 64)
      Me.frPassword.TabIndex = 22
      Me.frPassword.TabStop = False
      Me.frPassword.Text = "Contraseña inicial:"
      '
      'txtConfirmacion
      '
      Me.txtConfirmacion.Location = New System.Drawing.Point(176, 39)
      Me.txtConfirmacion.Name = "txtConfirmacion"
      Me.txtConfirmacion.Size = New System.Drawing.Size(151, 20)
      Me.txtConfirmacion.TabIndex = 13
      Me.txtConfirmacion.UseSystemPasswordChar = True
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.Location = New System.Drawing.Point(6, 42)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(71, 13)
      Me.Label13.TabIndex = 25
      Me.Label13.Text = "Confirmación:"
      '
      'txtPassword
      '
      Me.txtPassword.Location = New System.Drawing.Point(176, 16)
      Me.txtPassword.Name = "txtPassword"
      Me.txtPassword.Size = New System.Drawing.Size(151, 20)
      Me.txtPassword.TabIndex = 12
      Me.txtPassword.UseSystemPasswordChar = True
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.Location = New System.Drawing.Point(6, 19)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(64, 13)
      Me.Label14.TabIndex = 23
      Me.Label14.Text = "Contraseña:"
      '
      'txtIntentosRestantes
      '
      Me.txtIntentosRestantes.Enabled = False
      Me.txtIntentosRestantes.Location = New System.Drawing.Point(185, 251)
      Me.txtIntentosRestantes.Name = "txtIntentosRestantes"
      Me.txtIntentosRestantes.Size = New System.Drawing.Size(64, 20)
      Me.txtIntentosRestantes.TabIndex = 11
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.Location = New System.Drawing.Point(6, 254)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(134, 13)
      Me.Label10.TabIndex = 21
      Me.Label10.Text = "Intentos de login restantes:"
      '
      'txtFechaBaja
      '
      Me.txtFechaBaja.Enabled = False
      Me.txtFechaBaja.Location = New System.Drawing.Point(185, 229)
      Me.txtFechaBaja.Name = "txtFechaBaja"
      Me.txtFechaBaja.Size = New System.Drawing.Size(151, 20)
      Me.txtFechaBaja.TabIndex = 10
      '
      'txtFechaAlta
      '
      Me.txtFechaAlta.Enabled = False
      Me.txtFechaAlta.Location = New System.Drawing.Point(185, 207)
      Me.txtFechaAlta.Name = "txtFechaAlta"
      Me.txtFechaAlta.Size = New System.Drawing.Size(151, 20)
      Me.txtFechaAlta.TabIndex = 9
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.Location = New System.Drawing.Point(6, 232)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(78, 13)
      Me.Label11.TabIndex = 19
      Me.Label11.Text = "Fecha de baja:"
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.Location = New System.Drawing.Point(6, 210)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(75, 13)
      Me.Label12.TabIndex = 16
      Me.Label12.Text = "Fecha de alta:"
      '
      'chkSoloLectura
      '
      Me.chkSoloLectura.AutoSize = True
      Me.chkSoloLectura.Location = New System.Drawing.Point(185, 188)
      Me.chkSoloLectura.Name = "chkSoloLectura"
      Me.chkSoloLectura.Size = New System.Drawing.Size(15, 14)
      Me.chkSoloLectura.TabIndex = 8
      Me.chkSoloLectura.UseVisualStyleBackColor = True
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(6, 188)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(122, 13)
      Me.Label9.TabIndex = 14
      Me.Label9.Text = "Solo lectura en cuadros:"
      '
      'chkAdmin
      '
      Me.chkAdmin.AutoSize = True
      Me.chkAdmin.Location = New System.Drawing.Point(185, 166)
      Me.chkAdmin.Name = "chkAdmin"
      Me.chkAdmin.Size = New System.Drawing.Size(15, 14)
      Me.chkAdmin.TabIndex = 7
      Me.chkAdmin.UseVisualStyleBackColor = True
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Location = New System.Drawing.Point(6, 166)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(111, 13)
      Me.Label8.TabIndex = 12
      Me.Label8.Text = "Usuario administrador:"
      '
      'chkBloqueado
      '
      Me.chkBloqueado.AutoSize = True
      Me.chkBloqueado.Location = New System.Drawing.Point(185, 144)
      Me.chkBloqueado.Name = "chkBloqueado"
      Me.chkBloqueado.Size = New System.Drawing.Size(15, 14)
      Me.chkBloqueado.TabIndex = 6
      Me.chkBloqueado.UseVisualStyleBackColor = True
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(6, 144)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(99, 13)
      Me.Label7.TabIndex = 10
      Me.Label7.Text = "Usuario bloqueado:"
      '
      'txtInterno
      '
      Me.txtInterno.Location = New System.Drawing.Point(185, 119)
      Me.txtInterno.Name = "txtInterno"
      Me.txtInterno.Size = New System.Drawing.Size(64, 20)
      Me.txtInterno.TabIndex = 5
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(6, 122)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(64, 13)
      Me.Label6.TabIndex = 9
      Me.Label6.Text = "Interno nro.:"
      '
      'txtCorreo
      '
      Me.txtCorreo.Location = New System.Drawing.Point(185, 97)
      Me.txtCorreo.Name = "txtCorreo"
      Me.txtCorreo.Size = New System.Drawing.Size(412, 20)
      Me.txtCorreo.TabIndex = 4
      '
      'txtFechaVtoPassword
      '
      Me.txtFechaVtoPassword.Location = New System.Drawing.Point(185, 75)
      Me.txtFechaVtoPassword.Name = "txtFechaVtoPassword"
      Me.txtFechaVtoPassword.Size = New System.Drawing.Size(151, 20)
      Me.txtFechaVtoPassword.TabIndex = 3
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(6, 100)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(96, 13)
      Me.Label4.TabIndex = 7
      Me.Label4.Text = "Correo electrónico:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(6, 78)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(158, 13)
      Me.Label5.TabIndex = 4
      Me.Label5.Text = "Fecha de vto. de la contraseña:"
      '
      'cboEntidad
      '
      Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboEntidad.FormattingEnabled = True
      Me.cboEntidad.Location = New System.Drawing.Point(185, 53)
      Me.cboEntidad.Name = "cboEntidad"
      Me.cboEntidad.Size = New System.Drawing.Size(412, 21)
      Me.cboEntidad.TabIndex = 2
      '
      'txtNombreCompleto
      '
      Me.txtNombreCompleto.Location = New System.Drawing.Point(185, 31)
      Me.txtNombreCompleto.Name = "txtNombreCompleto"
      Me.txtNombreCompleto.Size = New System.Drawing.Size(412, 20)
      Me.txtNombreCompleto.TabIndex = 1
      '
      'txtNombreInicioSesion
      '
      Me.txtNombreInicioSesion.Location = New System.Drawing.Point(185, 9)
      Me.txtNombreInicioSesion.Name = "txtNombreInicioSesion"
      Me.txtNombreInicioSesion.Size = New System.Drawing.Size(151, 20)
      Me.txtNombreInicioSesion.TabIndex = 0
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(6, 56)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(46, 13)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "Entidad:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(6, 34)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(93, 13)
      Me.Label2.TabIndex = 1
      Me.Label2.Text = "Nombre completo:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(6, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(137, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Nombre de inicio de sesión:"
      '
      'tabGrupos
      '
      Me.tabGrupos.Controls.Add(Me.lvGrupos)
      Me.tabGrupos.Controls.Add(Me.toolGrupos)
      Me.tabGrupos.Location = New System.Drawing.Point(4, 22)
      Me.tabGrupos.Name = "tabGrupos"
      Me.tabGrupos.Padding = New System.Windows.Forms.Padding(3)
      Me.tabGrupos.Size = New System.Drawing.Size(608, 343)
      Me.tabGrupos.TabIndex = 1
      Me.tabGrupos.Text = "Grupos"
      Me.tabGrupos.UseVisualStyleBackColor = True
      '
      'lvGrupos
      '
      Me.lvGrupos.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvGrupos.Location = New System.Drawing.Point(3, 28)
      Me.lvGrupos.Name = "lvGrupos"
      Me.lvGrupos.Size = New System.Drawing.Size(602, 312)
      Me.lvGrupos.TabIndex = 14
      Me.lvGrupos.UseCompatibleStateImageBehavior = False
      Me.lvGrupos.View = System.Windows.Forms.View.List
      '
      'toolGrupos
      '
      Me.toolGrupos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboGrupos, Me.btnAgregar, Me.ToolStripSeparator1, Me.btnQuitar})
      Me.toolGrupos.Location = New System.Drawing.Point(3, 3)
      Me.toolGrupos.Name = "toolGrupos"
      Me.toolGrupos.Size = New System.Drawing.Size(602, 25)
      Me.toolGrupos.TabIndex = 1
      Me.toolGrupos.Text = "ToolStrip1"
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(87, 22)
      Me.ToolStripLabel1.Text = "Lista de grupos: "
      '
      'cboGrupos
      '
      Me.cboGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboGrupos.DropDownWidth = 300
      Me.cboGrupos.Name = "cboGrupos"
      Me.cboGrupos.Size = New System.Drawing.Size(220, 25)
      '
      'btnAgregar
      '
      Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
      Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnAgregar.Name = "btnAgregar"
      Me.btnAgregar.Size = New System.Drawing.Size(66, 22)
      Me.btnAgregar.Text = "Agregar"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'btnQuitar
      '
      Me.btnQuitar.Image = CType(resources.GetObject("btnQuitar.Image"), System.Drawing.Image)
      Me.btnQuitar.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnQuitar.Name = "btnQuitar"
      Me.btnQuitar.Size = New System.Drawing.Size(57, 22)
      Me.btnQuitar.Text = "Quitar"
      '
      'tabHab
      '
      Me.tabHab.Controls.Add(Me.splitHabilitaciones)
      Me.tabHab.Location = New System.Drawing.Point(4, 22)
      Me.tabHab.Name = "tabHab"
      Me.tabHab.Padding = New System.Windows.Forms.Padding(3)
      Me.tabHab.Size = New System.Drawing.Size(608, 343)
      Me.tabHab.TabIndex = 2
      Me.tabHab.Text = "Habilitaciones especiales"
      Me.tabHab.UseVisualStyleBackColor = True
      '
      'splitHabilitaciones
      '
      Me.splitHabilitaciones.Dock = System.Windows.Forms.DockStyle.Fill
      Me.splitHabilitaciones.Location = New System.Drawing.Point(3, 3)
      Me.splitHabilitaciones.Name = "splitHabilitaciones"
      '
      'splitHabilitaciones.Panel1
      '
      Me.splitHabilitaciones.Panel1.Controls.Add(Me.lvHab)
      Me.splitHabilitaciones.Panel1.Controls.Add(Me.panHab)
      '
      'splitHabilitaciones.Panel2
      '
      Me.splitHabilitaciones.Panel2.Controls.Add(Me.lvDeshab)
      Me.splitHabilitaciones.Panel2.Controls.Add(Me.panDeshab)
      Me.splitHabilitaciones.Size = New System.Drawing.Size(602, 337)
      Me.splitHabilitaciones.SplitterDistance = 299
      Me.splitHabilitaciones.TabIndex = 2
      '
      'panHab
      '
      Me.panHab.Controls.Add(Me.cboHab)
      Me.panHab.Controls.Add(Me.panLabelHab)
      Me.panHab.Controls.Add(Me.cmdAgregarHab)
      Me.panHab.Controls.Add(Me.cmdQuitarHab)
      Me.panHab.Dock = System.Windows.Forms.DockStyle.Top
      Me.panHab.Location = New System.Drawing.Point(0, 0)
      Me.panHab.Name = "panHab"
      Me.panHab.Size = New System.Drawing.Size(299, 66)
      Me.panHab.TabIndex = 0
      '
      'lvHab
      '
      Me.lvHab.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvHab.Location = New System.Drawing.Point(0, 66)
      Me.lvHab.Name = "lvHab"
      Me.lvHab.Size = New System.Drawing.Size(299, 271)
      Me.lvHab.TabIndex = 16
      Me.lvHab.UseCompatibleStateImageBehavior = False
      Me.lvHab.View = System.Windows.Forms.View.List
      '
      'panDeshab
      '
      Me.panDeshab.Controls.Add(Me.cboDesHab)
      Me.panDeshab.Controls.Add(Me.panLabelDeshab)
      Me.panDeshab.Controls.Add(Me.cmdAgregarDeshab)
      Me.panDeshab.Controls.Add(Me.cmdQuitarDeshab)
      Me.panDeshab.Dock = System.Windows.Forms.DockStyle.Top
      Me.panDeshab.Location = New System.Drawing.Point(0, 0)
      Me.panDeshab.Name = "panDeshab"
      Me.panDeshab.Size = New System.Drawing.Size(299, 66)
      Me.panDeshab.TabIndex = 0
      '
      'lvDeshab
      '
      Me.lvDeshab.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvDeshab.Location = New System.Drawing.Point(0, 66)
      Me.lvDeshab.Name = "lvDeshab"
      Me.lvDeshab.Size = New System.Drawing.Size(299, 271)
      Me.lvDeshab.TabIndex = 17
      Me.lvDeshab.UseCompatibleStateImageBehavior = False
      Me.lvDeshab.View = System.Windows.Forms.View.List
      '
      'cmdQuitarHab
      '
      Me.cmdQuitarHab.Location = New System.Drawing.Point(82, 39)
      Me.cmdQuitarHab.Name = "cmdQuitarHab"
      Me.cmdQuitarHab.Size = New System.Drawing.Size(75, 23)
      Me.cmdQuitarHab.TabIndex = 1
      Me.cmdQuitarHab.Text = "Quitar"
      Me.cmdQuitarHab.UseVisualStyleBackColor = True
      '
      'cmdAgregarHab
      '
      Me.cmdAgregarHab.Location = New System.Drawing.Point(1, 39)
      Me.cmdAgregarHab.Name = "cmdAgregarHab"
      Me.cmdAgregarHab.Size = New System.Drawing.Size(75, 23)
      Me.cmdAgregarHab.TabIndex = 2
      Me.cmdAgregarHab.Text = "Agregar"
      Me.cmdAgregarHab.UseVisualStyleBackColor = True
      '
      'cmdAgregarDeshab
      '
      Me.cmdAgregarDeshab.Location = New System.Drawing.Point(2, 39)
      Me.cmdAgregarDeshab.Name = "cmdAgregarDeshab"
      Me.cmdAgregarDeshab.Size = New System.Drawing.Size(75, 23)
      Me.cmdAgregarDeshab.TabIndex = 5
      Me.cmdAgregarDeshab.Text = "Agregar"
      Me.cmdAgregarDeshab.UseVisualStyleBackColor = True
      '
      'cmdQuitarDeshab
      '
      Me.cmdQuitarDeshab.Location = New System.Drawing.Point(83, 39)
      Me.cmdQuitarDeshab.Name = "cmdQuitarDeshab"
      Me.cmdQuitarDeshab.Size = New System.Drawing.Size(75, 23)
      Me.cmdQuitarDeshab.TabIndex = 4
      Me.cmdQuitarDeshab.Text = "Quitar"
      Me.cmdQuitarDeshab.UseVisualStyleBackColor = True
      '
      'panLabelHab
      '
      Me.panLabelHab.Controls.Add(Me.lblHab)
      Me.panLabelHab.Dock = System.Windows.Forms.DockStyle.Top
      Me.panLabelHab.Location = New System.Drawing.Point(0, 0)
      Me.panLabelHab.Name = "panLabelHab"
      Me.panLabelHab.Size = New System.Drawing.Size(299, 15)
      Me.panLabelHab.TabIndex = 3
      '
      'cboHab
      '
      Me.cboHab.Dock = System.Windows.Forms.DockStyle.Top
      Me.cboHab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboHab.FormattingEnabled = True
      Me.cboHab.Location = New System.Drawing.Point(0, 15)
      Me.cboHab.Name = "cboHab"
      Me.cboHab.Size = New System.Drawing.Size(299, 21)
      Me.cboHab.TabIndex = 4
      '
      'lblHab
      '
      Me.lblHab.AutoSize = True
      Me.lblHab.Dock = System.Windows.Forms.DockStyle.Top
      Me.lblHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblHab.Location = New System.Drawing.Point(0, 0)
      Me.lblHab.Name = "lblHab"
      Me.lblHab.Size = New System.Drawing.Size(159, 13)
      Me.lblHab.TabIndex = 0
      Me.lblHab.Text = "Transacciones habilitadas:"
      '
      'panLabelDeshab
      '
      Me.panLabelDeshab.Controls.Add(Me.lblDesHab)
      Me.panLabelDeshab.Dock = System.Windows.Forms.DockStyle.Top
      Me.panLabelDeshab.Location = New System.Drawing.Point(0, 0)
      Me.panLabelDeshab.Name = "panLabelDeshab"
      Me.panLabelDeshab.Size = New System.Drawing.Size(299, 15)
      Me.panLabelDeshab.TabIndex = 6
      '
      'cboDesHab
      '
      Me.cboDesHab.Dock = System.Windows.Forms.DockStyle.Top
      Me.cboDesHab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboDesHab.FormattingEnabled = True
      Me.cboDesHab.Location = New System.Drawing.Point(0, 15)
      Me.cboDesHab.Name = "cboDesHab"
      Me.cboDesHab.Size = New System.Drawing.Size(299, 21)
      Me.cboDesHab.TabIndex = 7
      '
      'lblDesHab
      '
      Me.lblDesHab.AutoSize = True
      Me.lblDesHab.Dock = System.Windows.Forms.DockStyle.Top
      Me.lblDesHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDesHab.Location = New System.Drawing.Point(0, 0)
      Me.lblDesHab.Name = "lblDesHab"
      Me.lblDesHab.Size = New System.Drawing.Size(170, 13)
      Me.lblDesHab.TabIndex = 1
      Me.lblDesHab.Text = "Transacciones Inhabilitadas:"
      '
      'frmUsuario
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(632, 460)
      Me.Controls.Add(Me.TabControl1)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmUsuario"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Usuario"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabControl1.ResumeLayout(False)
      Me.tabProp.ResumeLayout(False)
      Me.tabProp.PerformLayout()
      Me.frPassword.ResumeLayout(False)
      Me.frPassword.PerformLayout()
      Me.tabGrupos.ResumeLayout(False)
      Me.tabGrupos.PerformLayout()
      Me.toolGrupos.ResumeLayout(False)
      Me.toolGrupos.PerformLayout()
      Me.tabHab.ResumeLayout(False)
      Me.splitHabilitaciones.Panel1.ResumeLayout(False)
      Me.splitHabilitaciones.Panel2.ResumeLayout(False)
      Me.splitHabilitaciones.ResumeLayout(False)
      Me.panHab.ResumeLayout(False)
      Me.panDeshab.ResumeLayout(False)
      Me.panLabelHab.ResumeLayout(False)
      Me.panLabelHab.PerformLayout()
      Me.panLabelDeshab.ResumeLayout(False)
      Me.panLabelDeshab.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents OK_Button As System.Windows.Forms.Button
   Friend WithEvents Cancel_Button As System.Windows.Forms.Button
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents tabProp As System.Windows.Forms.TabPage
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents tabGrupos As System.Windows.Forms.TabPage
   Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreInicioSesion As System.Windows.Forms.TextBox
   Friend WithEvents tabHab As System.Windows.Forms.TabPage
   Friend WithEvents lvGrupos As System.Windows.Forms.ListView
   Friend WithEvents toolGrupos As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboGrupos As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnQuitar As System.Windows.Forms.ToolStripButton
   Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
   Friend WithEvents txtIntentosRestantes As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtFechaBaja As System.Windows.Forms.TextBox
   Friend WithEvents txtFechaAlta As System.Windows.Forms.TextBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents chkSoloLectura As System.Windows.Forms.CheckBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents chkBloqueado As System.Windows.Forms.CheckBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtInterno As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
   Friend WithEvents txtFechaVtoPassword As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents frPassword As System.Windows.Forms.GroupBox
   Friend WithEvents txtConfirmacion As System.Windows.Forms.TextBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtPassword As System.Windows.Forms.TextBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents splitHabilitaciones As System.Windows.Forms.SplitContainer
   Friend WithEvents lvHab As System.Windows.Forms.ListView
   Friend WithEvents panHab As System.Windows.Forms.Panel
   Friend WithEvents cmdAgregarHab As System.Windows.Forms.Button
   Friend WithEvents cmdQuitarHab As System.Windows.Forms.Button
   Friend WithEvents lvDeshab As System.Windows.Forms.ListView
   Friend WithEvents panDeshab As System.Windows.Forms.Panel
   Friend WithEvents cmdAgregarDeshab As System.Windows.Forms.Button
   Friend WithEvents cmdQuitarDeshab As System.Windows.Forms.Button
   Friend WithEvents cboHab As System.Windows.Forms.ComboBox
   Friend WithEvents panLabelHab As System.Windows.Forms.Panel
   Friend WithEvents lblHab As System.Windows.Forms.Label
   Friend WithEvents panLabelDeshab As System.Windows.Forms.Panel
   Friend WithEvents cboDesHab As System.Windows.Forms.ComboBox
   Friend WithEvents lblDesHab As System.Windows.Forms.Label

End Class
