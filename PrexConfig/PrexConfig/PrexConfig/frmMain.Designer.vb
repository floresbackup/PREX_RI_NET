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
        Me.btnAceptar.Location = New System.Drawing.Point(449, 430)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(91, 22)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(546, 430)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 22)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "&Cancelar"
        '
        'txtConnString
        '
        Me.txtConnString.Location = New System.Drawing.Point(149, 116)
        Me.txtConnString.Name = "txtConnString"
        Me.txtConnString.Properties.ReadOnly = True
        Me.txtConnString.Size = New System.Drawing.Size(452, 22)
        Me.txtConnString.TabIndex = 13
        Me.txtConnString.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(41, 120)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Cadena de conexión:"
        Me.LabelControl1.Visible = False
        '
        'btnConnString
        '
        Me.btnConnString.Location = New System.Drawing.Point(607, 116)
        Me.btnConnString.Name = "btnConnString"
        Me.btnConnString.Size = New System.Drawing.Size(25, 21)
        Me.btnConnString.TabIndex = 14
        Me.btnConnString.Text = "..."
        Me.btnConnString.Visible = False
        '
        'txtFFecha
        '
        Me.txtFFecha.EditValue = "yyyy/MM/dd"
        Me.txtFFecha.Location = New System.Drawing.Point(149, 181)
        Me.txtFFecha.Name = "txtFFecha"
        Me.txtFFecha.Size = New System.Drawing.Size(125, 22)
        Me.txtFFecha.TabIndex = 16
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(54, 185)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Formato de fecha:"
        '
        'txtCarpetaLocal
        '
        Me.txtCarpetaLocal.EditValue = "C:\Prex"
        Me.txtCarpetaLocal.Location = New System.Drawing.Point(149, 207)
        Me.txtCarpetaLocal.Name = "txtCarpetaLocal"
        Me.txtCarpetaLocal.Size = New System.Drawing.Size(452, 22)
        Me.txtCarpetaLocal.TabIndex = 19
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(73, 212)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Carpeta Local:"
        '
        'txtArchivoConfig
        '
        Me.txtArchivoConfig.EditValue = "Prex.config"
        Me.txtArchivoConfig.Location = New System.Drawing.Point(149, 234)
        Me.txtArchivoConfig.Name = "txtArchivoConfig"
        Me.txtArchivoConfig.Size = New System.Drawing.Size(452, 22)
        Me.txtArchivoConfig.TabIndex = 21
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(38, 239)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Nombre Config  Local:"
        '
        'cmdCarpetaLocal
        '
        Me.cmdCarpetaLocal.Location = New System.Drawing.Point(607, 208)
        Me.cmdCarpetaLocal.Name = "cmdCarpetaLocal"
        Me.cmdCarpetaLocal.Size = New System.Drawing.Size(25, 21)
        Me.cmdCarpetaLocal.TabIndex = 23
        Me.cmdCarpetaLocal.Text = "..."
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(607, 235)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(25, 21)
        Me.SimpleButton3.TabIndex = 24
        Me.SimpleButton3.Text = "..."
        '
        'txtPassword
        '
        Me.txtPassword.EditValue = ""
        Me.txtPassword.Location = New System.Drawing.Point(475, 140)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(125, 22)
        Me.txtPassword.TabIndex = 25
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(363, 144)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(106, 13)
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
        Me.lvConfig.Location = New System.Drawing.Point(39, 285)
        Me.lvConfig.MultiSelect = False
        Me.lvConfig.Name = "lvConfig"
        Me.lvConfig.Size = New System.Drawing.Size(593, 130)
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
        Me.btnAgregar.Location = New System.Drawing.Point(39, 398)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(22, 19)
        Me.btnAgregar.TabIndex = 29
        Me.btnAgregar.Text = "+"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(66, 398)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(22, 19)
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
        Me.btnBuscarSgLibrary.Location = New System.Drawing.Point(607, 261)
        Me.btnBuscarSgLibrary.Name = "btnBuscarSgLibrary"
        Me.btnBuscarSgLibrary.Size = New System.Drawing.Size(25, 21)
        Me.btnBuscarSgLibrary.TabIndex = 33
        Me.btnBuscarSgLibrary.Text = "..."
        '
        'txtSGLibrary
        '
        Me.txtSGLibrary.EditValue = "config.xml"
        Me.txtSGLibrary.Location = New System.Drawing.Point(149, 260)
        Me.txtSGLibrary.Name = "txtSGLibrary"
        Me.txtSGLibrary.Size = New System.Drawing.Size(452, 22)
        Me.txtSGLibrary.TabIndex = 31
        '
        'lblSgLibrary
        '
        Me.lblSgLibrary.Location = New System.Drawing.Point(48, 265)
        Me.lblSgLibrary.Name = "lblSgLibrary"
        Me.lblSgLibrary.Size = New System.Drawing.Size(95, 13)
        Me.lblSgLibrary.TabIndex = 32
        Me.lblSgLibrary.Text = "Ruta config.xml SG:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(383, 119)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl6.TabIndex = 26
        Me.LabelControl6.Text = "Usuario conexión:"
        '
        'txtUsuario
        '
        Me.txtUsuario.EditValue = ""
        Me.txtUsuario.Location = New System.Drawing.Point(475, 115)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(125, 22)
        Me.txtUsuario.TabIndex = 25
        '
        'ckSeguridadIntegrada
        '
        Me.ckSeguridadIntegrada.Location = New System.Drawing.Point(361, 171)
        Me.ckSeguridadIntegrada.Name = "ckSeguridadIntegrada"
        Me.ckSeguridadIntegrada.Properties.Caption = "Utilizar Seguridad Integrada"
        Me.ckSeguridadIntegrada.Size = New System.Drawing.Size(156, 17)
        Me.ckSeguridadIntegrada.TabIndex = 34
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(71, 144)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl8.TabIndex = 26
        Me.LabelControl8.Text = "Base de datos:"
        '
        'txtBaseDeDatos
        '
        Me.txtBaseDeDatos.EditValue = ""
        Me.txtBaseDeDatos.Location = New System.Drawing.Point(149, 140)
        Me.txtBaseDeDatos.Name = "txtBaseDeDatos"
        Me.txtBaseDeDatos.Size = New System.Drawing.Size(197, 22)
        Me.txtBaseDeDatos.TabIndex = 25
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(43, 119)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl9.TabIndex = 26
        Me.LabelControl9.Text = "Nombre del servidor:"
        '
        'txtServidor
        '
        Me.txtServidor.EditValue = ""
        Me.txtServidor.Location = New System.Drawing.Point(149, 115)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(197, 22)
        Me.txtServidor.TabIndex = 25
        '
        'btnProbarConexion
        '
        Me.btnProbarConexion.Appearance.Image = CType(resources.GetObject("btnProbarConexion.Appearance.Image"), System.Drawing.Image)
        Me.btnProbarConexion.Appearance.Options.UseImage = True
        Me.btnProbarConexion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnProbarConexion.ImageOptions.Image = CType(resources.GetObject("btnProbarConexion.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProbarConexion.Location = New System.Drawing.Point(520, 169)
        Me.btnProbarConexion.Name = "btnProbarConexion"
        Me.btnProbarConexion.Size = New System.Drawing.Size(112, 22)
        Me.btnProbarConexion.TabIndex = 35
        Me.btnProbarConexion.Text = "&Probar conexión"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.PrexConfig.My.Resources.Resources.fondo_degrade_prex_con_cuadro2
        Me.ClientSize = New System.Drawing.Size(643, 461)
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
