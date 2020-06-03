<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
		Me.LookAndFeelGeneral = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
		Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
		Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
		Me.txtConnString = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.btnConnString = New DevExpress.XtraEditors.SimpleButton()
		Me.txtFFecha = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.CarpetaDialogo = New System.Windows.Forms.FolderBrowserDialog()
		Me.txtCarpetaLocal = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.txtArchivoConfig = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
		Me.cmdCarpetaLocal = New DevExpress.XtraEditors.SimpleButton()
		Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
		Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		Me.GuardarDialogo = New System.Windows.Forms.SaveFileDialog()
		Me.lvConfig = New System.Windows.Forms.ListView()
		Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
		Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton()
		Me.DsConfig = New PrexConfig.dsConfig()
		Me.CONFIGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.btnBuscarSgLibrary = New DevExpress.XtraEditors.SimpleButton()
		Me.txtSGLibrary = New DevExpress.XtraEditors.TextEdit()
		Me.lblSgLibrary = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
		Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
		Me.ckSeguridadIntegrada = New DevExpress.XtraEditors.CheckEdit()
		Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
		Me.txtBaseDeDatos = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
		Me.txtServidor = New DevExpress.XtraEditors.TextEdit()
		Me.btnProbarConexion = New DevExpress.XtraEditors.SimpleButton()
		CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtConnString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCarpetaLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtArchivoConfig.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsConfig, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CONFIGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSGLibrary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ckSeguridadIntegrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtBaseDeDatos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtServidor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RepositoryItemTextEdit3
		'
		Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
		'
		'LookAndFeelGeneral
		'
		Me.LookAndFeelGeneral.LookAndFeel.SkinName = "Blue"
		Me.LookAndFeelGeneral.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
		'
		'btnAceptar
		'
		Me.btnAceptar.Location = New System.Drawing.Point(524, 529)
		Me.btnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnAceptar.Name = "btnAceptar"
		Me.btnAceptar.Size = New System.Drawing.Size(106, 27)
		Me.btnAceptar.TabIndex = 10
		Me.btnAceptar.Text = "&Aceptar"
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(637, 529)
		Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(106, 27)
		Me.btnCancelar.TabIndex = 11
		Me.btnCancelar.Text = "&Cancelar"
		'
		'txtConnString
		'
		Me.txtConnString.Location = New System.Drawing.Point(174, 143)
		Me.txtConnString.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtConnString.Name = "txtConnString"
		Me.txtConnString.Properties.ReadOnly = True
		Me.txtConnString.Size = New System.Drawing.Size(527, 24)
		Me.txtConnString.TabIndex = 13
		Me.txtConnString.Visible = False
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(48, 148)
		Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(120, 16)
		Me.LabelControl1.TabIndex = 15
		Me.LabelControl1.Text = "Cadena de conexión:"
		Me.LabelControl1.Visible = False
		'
		'btnConnString
		'
		Me.btnConnString.Location = New System.Drawing.Point(708, 143)
		Me.btnConnString.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnConnString.Name = "btnConnString"
		Me.btnConnString.Size = New System.Drawing.Size(29, 26)
		Me.btnConnString.TabIndex = 14
		Me.btnConnString.Text = "..."
		Me.btnConnString.Visible = False
		'
		'txtFFecha
		'
		Me.txtFFecha.EditValue = "yyyy/MM/dd"
		Me.txtFFecha.Location = New System.Drawing.Point(174, 223)
		Me.txtFFecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtFFecha.Name = "txtFFecha"
		Me.txtFFecha.Size = New System.Drawing.Size(146, 24)
		Me.txtFFecha.TabIndex = 16
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(63, 228)
		Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(106, 16)
		Me.LabelControl2.TabIndex = 17
		Me.LabelControl2.Text = "Formato de fecha:"
		'
		'txtCarpetaLocal
		'
		Me.txtCarpetaLocal.EditValue = "C:\Prex"
		Me.txtCarpetaLocal.Location = New System.Drawing.Point(174, 255)
		Me.txtCarpetaLocal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtCarpetaLocal.Name = "txtCarpetaLocal"
		Me.txtCarpetaLocal.Size = New System.Drawing.Size(527, 24)
		Me.txtCarpetaLocal.TabIndex = 19
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(85, 261)
		Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(83, 16)
		Me.LabelControl3.TabIndex = 20
		Me.LabelControl3.Text = "Carpeta Local:"
		'
		'txtArchivoConfig
		'
		Me.txtArchivoConfig.EditValue = "Prex.config"
		Me.txtArchivoConfig.Location = New System.Drawing.Point(174, 288)
		Me.txtArchivoConfig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtArchivoConfig.Name = "txtArchivoConfig"
		Me.txtArchivoConfig.Size = New System.Drawing.Size(527, 24)
		Me.txtArchivoConfig.TabIndex = 21
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(44, 294)
		Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(127, 16)
		Me.LabelControl4.TabIndex = 22
		Me.LabelControl4.Text = "Nombre Config  Local:"
		'
		'cmdCarpetaLocal
		'
		Me.cmdCarpetaLocal.Location = New System.Drawing.Point(708, 256)
		Me.cmdCarpetaLocal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.cmdCarpetaLocal.Name = "cmdCarpetaLocal"
		Me.cmdCarpetaLocal.Size = New System.Drawing.Size(29, 26)
		Me.cmdCarpetaLocal.TabIndex = 23
		Me.cmdCarpetaLocal.Text = "..."
		'
		'SimpleButton3
		'
		Me.SimpleButton3.Location = New System.Drawing.Point(708, 289)
		Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.SimpleButton3.Name = "SimpleButton3"
		Me.SimpleButton3.Size = New System.Drawing.Size(29, 26)
		Me.SimpleButton3.TabIndex = 24
		Me.SimpleButton3.Text = "..."
		'
		'txtPassword
		'
		Me.txtPassword.EditValue = ""
		Me.txtPassword.Location = New System.Drawing.Point(554, 172)
		Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(146, 24)
		Me.txtPassword.TabIndex = 25
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(423, 177)
		Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(124, 16)
		Me.LabelControl5.TabIndex = 26
		Me.LabelControl5.Text = "Contraseña conexión:"
		'
		'lvConfig
		'
		Me.lvConfig.AutoArrange = False
		Me.lvConfig.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Valor})
		Me.lvConfig.FullRowSelect = True
		Me.lvConfig.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lvConfig.HideSelection = False
		Me.lvConfig.Location = New System.Drawing.Point(45, 351)
		Me.lvConfig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.lvConfig.MultiSelect = False
		Me.lvConfig.Name = "lvConfig"
		Me.lvConfig.Size = New System.Drawing.Size(691, 159)
		Me.lvConfig.TabIndex = 28
		Me.lvConfig.UseCompatibleStateImageBehavior = False
		Me.lvConfig.View = System.Windows.Forms.View.Details
		'
		'Nombre
		'
		Me.Nombre.Text = "Nombre"
		Me.Nombre.Width = 200
		'
		'Valor
		'
		Me.Valor.Text = "Valor"
		Me.Valor.Width = 389
		'
		'btnAgregar
		'
		Me.btnAgregar.Location = New System.Drawing.Point(45, 490)
		Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(26, 23)
		Me.btnAgregar.TabIndex = 29
		Me.btnAgregar.Text = "+"
		'
		'btnQuitar
		'
		Me.btnQuitar.Location = New System.Drawing.Point(77, 490)
		Me.btnQuitar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnQuitar.Name = "btnQuitar"
		Me.btnQuitar.Size = New System.Drawing.Size(26, 23)
		Me.btnQuitar.TabIndex = 30
		Me.btnQuitar.Text = "-"
		'
		'DsConfig
		'
		Me.DsConfig.DataSetName = "dsConfig"
		Me.DsConfig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'CONFIGBindingSource
		'
		Me.CONFIGBindingSource.DataMember = "CONFIG"
		Me.CONFIGBindingSource.DataSource = Me.DsConfig
		'
		'btnBuscarSgLibrary
		'
		Me.btnBuscarSgLibrary.Location = New System.Drawing.Point(708, 321)
		Me.btnBuscarSgLibrary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnBuscarSgLibrary.Name = "btnBuscarSgLibrary"
		Me.btnBuscarSgLibrary.Size = New System.Drawing.Size(29, 26)
		Me.btnBuscarSgLibrary.TabIndex = 33
		Me.btnBuscarSgLibrary.Text = "..."
		'
		'txtSGLibrary
		'
		Me.txtSGLibrary.EditValue = "config.xml"
		Me.txtSGLibrary.Location = New System.Drawing.Point(174, 320)
		Me.txtSGLibrary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtSGLibrary.Name = "txtSGLibrary"
		Me.txtSGLibrary.Size = New System.Drawing.Size(527, 24)
		Me.txtSGLibrary.TabIndex = 31
		'
		'lblSgLibrary
		'
		Me.lblSgLibrary.Location = New System.Drawing.Point(56, 326)
		Me.lblSgLibrary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.lblSgLibrary.Name = "lblSgLibrary"
		Me.lblSgLibrary.Size = New System.Drawing.Size(113, 16)
		Me.lblSgLibrary.TabIndex = 32
		Me.lblSgLibrary.Text = "Ruta config.xml SG:"
		'
		'LabelControl6
		'
		Me.LabelControl6.Location = New System.Drawing.Point(447, 146)
		Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.LabelControl6.Name = "LabelControl6"
		Me.LabelControl6.Size = New System.Drawing.Size(102, 16)
		Me.LabelControl6.TabIndex = 26
		Me.LabelControl6.Text = "Usuario conexión:"
		'
		'txtUsuario
		'
		Me.txtUsuario.EditValue = ""
		Me.txtUsuario.Location = New System.Drawing.Point(554, 142)
		Me.txtUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.Size = New System.Drawing.Size(146, 24)
		Me.txtUsuario.TabIndex = 25
		'
		'ckSeguridadIntegrada
		'
		Me.ckSeguridadIntegrada.Location = New System.Drawing.Point(421, 210)
		Me.ckSeguridadIntegrada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.ckSeguridadIntegrada.Name = "ckSeguridadIntegrada"
		Me.ckSeguridadIntegrada.Properties.Caption = "Utilizar Seguridad Integrada"
		Me.ckSeguridadIntegrada.Size = New System.Drawing.Size(182, 20)
		Me.ckSeguridadIntegrada.TabIndex = 34
		'
		'LabelControl8
		'
		Me.LabelControl8.Location = New System.Drawing.Point(83, 177)
		Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.LabelControl8.Name = "LabelControl8"
		Me.LabelControl8.Size = New System.Drawing.Size(85, 16)
		Me.LabelControl8.TabIndex = 26
		Me.LabelControl8.Text = "Base de datos:"
		'
		'txtBaseDeDatos
		'
		Me.txtBaseDeDatos.EditValue = ""
		Me.txtBaseDeDatos.Location = New System.Drawing.Point(174, 172)
		Me.txtBaseDeDatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtBaseDeDatos.Name = "txtBaseDeDatos"
		Me.txtBaseDeDatos.Size = New System.Drawing.Size(230, 24)
		Me.txtBaseDeDatos.TabIndex = 25
		'
		'LabelControl9
		'
		Me.LabelControl9.Location = New System.Drawing.Point(50, 146)
		Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.LabelControl9.Name = "LabelControl9"
		Me.LabelControl9.Size = New System.Drawing.Size(121, 16)
		Me.LabelControl9.TabIndex = 26
		Me.LabelControl9.Text = "Nombre del servidor:"
		'
		'txtServidor
		'
		Me.txtServidor.EditValue = ""
		Me.txtServidor.Location = New System.Drawing.Point(174, 142)
		Me.txtServidor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtServidor.Name = "txtServidor"
		Me.txtServidor.Size = New System.Drawing.Size(230, 24)
		Me.txtServidor.TabIndex = 25
		'
		'btnProbarConexion
		'
		Me.btnProbarConexion.Appearance.Image = CType(resources.GetObject("btnProbarConexion.Appearance.Image"), System.Drawing.Image)
		Me.btnProbarConexion.Appearance.Options.UseImage = True
		Me.btnProbarConexion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
		Me.btnProbarConexion.ImageOptions.Image = CType(resources.GetObject("btnProbarConexion.ImageOptions.Image"), System.Drawing.Image)
		Me.btnProbarConexion.Location = New System.Drawing.Point(607, 208)
		Me.btnProbarConexion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnProbarConexion.Name = "btnProbarConexion"
		Me.btnProbarConexion.Size = New System.Drawing.Size(131, 27)
		Me.btnProbarConexion.TabIndex = 35
		Me.btnProbarConexion.Text = "&Probar conexión"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
		Me.BackgroundImageStore = Global.PrexConfig.My.Resources.Resources.fondo_degrade_prex_con_cuadro2
		Me.ClientSize = New System.Drawing.Size(750, 567)
		Me.Controls.Add(Me.btnProbarConexion)
		Me.Controls.Add(Me.ckSeguridadIntegrada)
		Me.Controls.Add(Me.btnBuscarSgLibrary)
		Me.Controls.Add(Me.txtSGLibrary)
		Me.Controls.Add(Me.lblSgLibrary)
		Me.Controls.Add(Me.btnQuitar)
		Me.Controls.Add(Me.btnAgregar)
		Me.Controls.Add(Me.lvConfig)
		Me.Controls.Add(Me.txtServidor)
		Me.Controls.Add(Me.txtUsuario)
		Me.Controls.Add(Me.LabelControl9)
		Me.Controls.Add(Me.LabelControl6)
		Me.Controls.Add(Me.txtBaseDeDatos)
		Me.Controls.Add(Me.LabelControl8)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.LabelControl5)
		Me.Controls.Add(Me.SimpleButton3)
		Me.Controls.Add(Me.cmdCarpetaLocal)
		Me.Controls.Add(Me.txtArchivoConfig)
		Me.Controls.Add(Me.LabelControl4)
		Me.Controls.Add(Me.txtCarpetaLocal)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.txtFFecha)
		Me.Controls.Add(Me.LabelControl2)
		Me.Controls.Add(Me.txtConnString)
		Me.Controls.Add(Me.LabelControl1)
		Me.Controls.Add(Me.btnConnString)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.btnAceptar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.LookAndFeel.SkinName = "Blue"
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.Text = " Configuración"
		CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtConnString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCarpetaLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtArchivoConfig.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsConfig, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CONFIGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSGLibrary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ckSeguridadIntegrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtBaseDeDatos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtServidor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LookAndFeelGeneral As DevExpress.LookAndFeel.DefaultLookAndFeel
   Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents txtConnString As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents btnConnString As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents txtFFecha As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents CarpetaDialogo As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents txtCarpetaLocal As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents txtArchivoConfig As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents cmdCarpetaLocal As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GuardarDialogo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
   Friend WithEvents DsConfig As PrexConfig.dsConfig
   Friend WithEvents CONFIGBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents lvConfig As System.Windows.Forms.ListView
   Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
   Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
   Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarSgLibrary As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSGLibrary As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSgLibrary As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckSeguridadIntegrada As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBaseDeDatos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServidor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnProbarConexion As DevExpress.XtraEditors.SimpleButton
End Class
