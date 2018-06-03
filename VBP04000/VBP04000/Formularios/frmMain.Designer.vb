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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolMain = New System.Windows.Forms.ToolStrip()
        Me.lblTransaccion = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAyuda = New System.Windows.Forms.ToolStripButton()
        Me.tsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblVersion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PanTop = New DevExpress.XtraEditors.PanelControl()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.tabResultados = New DevExpress.XtraTab.XtraTabPage()
        Me.tabParametros = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEjecutarConsulta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAbrirConsulta = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblCategoriaConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescripcionConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNombreConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodigoConsulta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.tabPanel = New DevExpress.XtraTab.XtraTabControl()
        Me.GridParametros = New DevExpress.XtraGrid.GridControl()
        Me.GridViewParametros = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sbMain.SuspendLayout()
        Me.toolMain.SuspendLayout()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTop.SuspendLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabParametros.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPanel.SuspendLayout()
        CType(Me.GridParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
        Me.sbMain.Location = New System.Drawing.Point(0, 404)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(739, 25)
        Me.sbMain.SizingGrip = False
        Me.sbMain.TabIndex = 8
        '
        'lblUsuario
        '
        Me.lblUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblUsuario.Image = Global.VBP04000.My.Resources.Resources.Messenger_Information1
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(585, 20)
        Me.lblUsuario.Spring = True
        Me.lblUsuario.Text = "Sebastián Buceta"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntidad
        '
        Me.lblEntidad.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblEntidad.Image = Global.VBP04000.My.Resources.Resources.Home
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(139, 20)
        Me.lblEntidad.Text = "Banco de Prueba S.A."
        '
        'toolMain
        '
        Me.toolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTransaccion, Me.btnSalir, Me.tsSep1, Me.btnAyuda, Me.tsSep2, Me.lblVersion, Me.ToolStripSeparator6})
        Me.toolMain.Location = New System.Drawing.Point(0, 0)
        Me.toolMain.Name = "toolMain"
        Me.toolMain.Size = New System.Drawing.Size(739, 25)
        Me.toolMain.TabIndex = 9
        Me.toolMain.Text = "ToolStrip1"
        '
        'lblTransaccion
        '
        Me.lblTransaccion.AutoSize = False
        Me.lblTransaccion.Image = Global.VBP04000.My.Resources.Resources.About
        Me.lblTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransaccion.Name = "lblTransaccion"
        Me.lblTransaccion.Size = New System.Drawing.Size(390, 22)
        Me.lblTransaccion.Text = "Transacción"
        Me.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.VBP04000.My.Resources.Resources.Cross
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
        Me.btnAyuda.Image = Global.VBP04000.My.Resources.Resources.Help_21
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
        Me.lblVersion.Size = New System.Drawing.Size(75, 22)
        Me.lblVersion.Text = "Versión: 1.0.0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'PanTop
        '
        Me.PanTop.Appearance.BackColor = System.Drawing.Color.White
        Me.PanTop.Appearance.Options.UseBackColor = True
        Me.PanTop.Controls.Add(Me.lblSubtitulo)
        Me.PanTop.Controls.Add(Me.lblTitulo)
        Me.PanTop.Controls.Add(Me.picLogo)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 25)
        Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(739, 54)
        Me.PanTop.TabIndex = 15
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
        Me.picLogo.EditValue = Global.VBP04000.My.Resources.Resources.logo_prex
        Me.picLogo.Location = New System.Drawing.Point(678, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Properties.Appearance.Options.UseBackColor = True
        Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picLogo.Size = New System.Drawing.Size(59, 50)
        Me.picLogo.TabIndex = 0
        '
        'tabResultados
        '
        Me.tabResultados.ImageOptions.Image = CType(resources.GetObject("tabResultados.ImageOptions.Image"), System.Drawing.Image)
        Me.tabResultados.Name = "tabResultados"
        Me.tabResultados.Size = New System.Drawing.Size(733, 294)
        Me.tabResultados.Text = "Resultados"
        '
        'tabParametros
        '
        Me.tabParametros.Controls.Add(Me.TableLayoutPanel1)
        Me.tabParametros.ImageOptions.Image = CType(resources.GetObject("tabParametros.ImageOptions.Image"), System.Drawing.Image)
        Me.tabParametros.Name = "tabParametros"
        Me.tabParametros.Size = New System.Drawing.Size(733, 294)
        Me.tabParametros.Text = "Parámetros de la consulta"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GridParametros, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(733, 294)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(729, 24)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(567, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Seleccione la consulta que desea hacer y a continuación, ingrese los parámetros. " &
    "Luego presione el botón Consultar..."
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(2, 2)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(16, 20)
        Me.PictureEdit1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnEjecutarConsulta)
        Me.Panel1.Controls.Add(Me.btnAbrirConsulta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 28)
        Me.Panel1.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(189, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnEjecutarConsulta
        '
        Me.btnEjecutarConsulta.Enabled = False
        Me.btnEjecutarConsulta.ImageOptions.Image = CType(resources.GetObject("btnEjecutarConsulta.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEjecutarConsulta.Location = New System.Drawing.Point(108, 3)
        Me.btnEjecutarConsulta.Name = "btnEjecutarConsulta"
        Me.btnEjecutarConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutarConsulta.TabIndex = 1
        Me.btnEjecutarConsulta.Text = "&Ejecutar"
        '
        'btnAbrirConsulta
        '
        Me.btnAbrirConsulta.ImageOptions.Image = CType(resources.GetObject("btnAbrirConsulta.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAbrirConsulta.Location = New System.Drawing.Point(3, 3)
        Me.btnAbrirConsulta.Name = "btnAbrirConsulta"
        Me.btnAbrirConsulta.Size = New System.Drawing.Size(99, 23)
        Me.btnAbrirConsulta.TabIndex = 1
        Me.btnAbrirConsulta.Text = "&Abrir consulta"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblCategoriaConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.lblDescripcionConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.lblNombreConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.lblCodigoConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 58)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(729, 71)
        Me.PanelControl2.TabIndex = 3
        '
        'lblCategoriaConsulta
        '
        Me.lblCategoriaConsulta.Location = New System.Drawing.Point(73, 53)
        Me.lblCategoriaConsulta.Name = "lblCategoriaConsulta"
        Me.lblCategoriaConsulta.Size = New System.Drawing.Size(0, 13)
        Me.lblCategoriaConsulta.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(9, 53)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Categoría:"
        '
        'lblDescripcionConsulta
        '
        Me.lblDescripcionConsulta.Location = New System.Drawing.Point(73, 36)
        Me.lblDescripcionConsulta.Name = "lblDescripcionConsulta"
        Me.lblDescripcionConsulta.Size = New System.Drawing.Size(0, 13)
        Me.lblDescripcionConsulta.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 36)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Descripción:"
        '
        'lblNombreConsulta
        '
        Me.lblNombreConsulta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombreConsulta.Appearance.Options.UseFont = True
        Me.lblNombreConsulta.Location = New System.Drawing.Point(73, 19)
        Me.lblNombreConsulta.Name = "lblNombreConsulta"
        Me.lblNombreConsulta.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreConsulta.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Consulta:"
        '
        'lblCodigoConsulta
        '
        Me.lblCodigoConsulta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCodigoConsulta.Appearance.Options.UseFont = True
        Me.lblCodigoConsulta.Location = New System.Drawing.Point(73, 3)
        Me.lblCodigoConsulta.Name = "lblCodigoConsulta"
        Me.lblCodigoConsulta.Size = New System.Drawing.Size(0, 13)
        Me.lblCodigoConsulta.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Código:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureEdit2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 131)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(733, 28)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LabelControl6)
        Me.Panel3.Controls.Add(Me.PictureEdit3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(733, 28)
        Me.Panel3.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(23, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(160, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "= Parámetros de la consulta"
        '
        'PictureEdit3
        '
        Me.PictureEdit3.EditValue = CType(resources.GetObject("PictureEdit3.EditValue"), Object)
        Me.PictureEdit3.Location = New System.Drawing.Point(4, 3)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Size = New System.Drawing.Size(16, 20)
        Me.PictureEdit3.TabIndex = 2
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(4, 3)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Size = New System.Drawing.Size(16, 20)
        Me.PictureEdit2.TabIndex = 2
        '
        'tabPanel
        '
        Me.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPanel.Location = New System.Drawing.Point(0, 79)
        Me.tabPanel.Name = "tabPanel"
        Me.tabPanel.SelectedTabPage = Me.tabParametros
        Me.tabPanel.Size = New System.Drawing.Size(739, 325)
        Me.tabPanel.TabIndex = 16
        Me.tabPanel.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabParametros, Me.tabResultados})
        '
        'GridParametros
        '
        Me.GridParametros.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridParametros.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridParametros.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridParametros.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridParametros.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridParametros.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridParametros.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridParametros.Location = New System.Drawing.Point(3, 162)
        Me.GridParametros.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GridParametros.LookAndFeel.UseWindowsXPTheme = True
        Me.GridParametros.MainView = Me.GridViewParametros
        Me.GridParametros.Name = "GridParametros"
        Me.GridParametros.Size = New System.Drawing.Size(727, 129)
        Me.GridParametros.TabIndex = 7
        Me.GridParametros.UseEmbeddedNavigator = True
        Me.GridParametros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewParametros})
        '
        'GridViewParametros
        '
        Me.GridViewParametros.AppearancePrint.FooterPanel.Options.UseTextOptions = True
        Me.GridViewParametros.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewParametros.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridViewParametros.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewParametros.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridViewParametros.GridControl = Me.GridParametros
        Me.GridViewParametros.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.GridViewParametros.Name = "GridViewParametros"
        Me.GridViewParametros.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewParametros.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewParametros.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewParametros.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewParametros.OptionsBehavior.AllowValidationErrors = False
        Me.GridViewParametros.OptionsBehavior.AutoPopulateColumns = False
        Me.GridViewParametros.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridViewParametros.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridViewParametros.OptionsBehavior.Editable = False
        Me.GridViewParametros.OptionsCustomization.AllowColumnMoving = False
        Me.GridViewParametros.OptionsCustomization.AllowFilter = False
        Me.GridViewParametros.OptionsCustomization.AllowGroup = False
        Me.GridViewParametros.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridViewParametros.OptionsCustomization.AllowSort = False
        Me.GridViewParametros.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridViewParametros.OptionsFilter.AllowFilterEditor = False
        Me.GridViewParametros.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.GridViewParametros.OptionsFilter.AllowMRUFilterList = False
        Me.GridViewParametros.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = False
        Me.GridViewParametros.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = False
        Me.GridViewParametros.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.GridViewParametros.OptionsFind.AllowFindPanel = False
        Me.GridViewParametros.OptionsFind.ShowClearButton = False
        Me.GridViewParametros.OptionsFind.ShowCloseButton = False
        Me.GridViewParametros.OptionsFind.ShowFindButton = False
        Me.GridViewParametros.OptionsHint.ShowFooterHints = False
        Me.GridViewParametros.OptionsMenu.EnableColumnMenu = False
        Me.GridViewParametros.OptionsMenu.EnableFooterMenu = False
        Me.GridViewParametros.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridViewParametros.OptionsMenu.ShowAutoFilterRowItem = False
        Me.GridViewParametros.OptionsMenu.ShowDateTimeGroupIntervalItems = False
        Me.GridViewParametros.OptionsMenu.ShowGroupSortSummaryItems = False
        Me.GridViewParametros.OptionsMenu.ShowSplitItem = False
        Me.GridViewParametros.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridViewParametros.OptionsNavigation.UseOfficePageNavigation = False
        Me.GridViewParametros.OptionsNavigation.UseTabKey = False
        Me.GridViewParametros.OptionsView.ColumnAutoWidth = False
        Me.GridViewParametros.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GridViewParametros.OptionsView.ShowGroupPanel = False
        Me.GridViewParametros.PaintStyleName = "WindowsXP"
        Me.GridViewParametros.RowHeight = 19
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 429)
        Me.Controls.Add(Me.tabPanel)
        Me.Controls.Add(Me.PanTop)
        Me.Controls.Add(Me.toolMain)
        Me.Controls.Add(Me.sbMain)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procesos del sistema"
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.toolMain.ResumeLayout(False)
        Me.toolMain.PerformLayout()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabParametros.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPanel.ResumeLayout(False)
        CType(Me.GridParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
   Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents lblEntidad As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents toolMain As System.Windows.Forms.ToolStrip
   Friend WithEvents lblTransaccion As System.Windows.Forms.ToolStripLabel
   Friend WithEvents tsSep1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnAyuda As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsSep2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
   Friend WithEvents lblVersion As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabResultados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabParametros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEjecutarConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAbrirConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabPanel As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents lblCategoriaConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescripcionConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNombreConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCodigoConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GridParametros As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewParametros As DevExpress.XtraGrid.Views.Grid.GridView
End Class
