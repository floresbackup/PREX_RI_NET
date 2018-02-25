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
      Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menú")
      Me.sbMain = New System.Windows.Forms.StatusStrip
      Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel
      Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel
      Me.mnuMain = New System.Windows.Forms.MenuStrip
      Me.mnuSistema = New System.Windows.Forms.ToolStripMenuItem
      Me.mnuActualizar = New System.Windows.Forms.ToolStripMenuItem
      Me.mnuPreferencias = New System.Windows.Forms.ToolStripMenuItem
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
      Me.mnuAyuda = New System.Windows.Forms.ToolStripMenuItem
      Me.mnuAcerca = New System.Windows.Forms.ToolStripMenuItem
      Me.tbMain = New System.Windows.Forms.ToolStrip
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
      Me.txtCodTra = New System.Windows.Forms.ToolStripTextBox
      Me.btnIr = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
      Me.btnSubir = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
      Me.mnuIconos = New System.Windows.Forms.ToolStripMenuItem
      Me.mnuLista = New System.Windows.Forms.ToolStripMenuItem
      Me.mnuDetalle = New System.Windows.Forms.ToolStripMenuItem
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
      Me.btnSalir = New System.Windows.Forms.ToolStripButton
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
      Me.tvMenu = New System.Windows.Forms.TreeView
      Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
      Me.lvTrans = New System.Windows.Forms.ListView
      Me.MEN = New System.Windows.Forms.ColumnHeader
      Me.DESCRIP = New System.Windows.Forms.ColumnHeader
      Me.CODTRA = New System.Windows.Forms.ColumnHeader
      Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
      Me.il16x16 = New System.Windows.Forms.ImageList(Me.components)
      Me.sbMain.SuspendLayout()
      Me.mnuMain.SuspendLayout()
      Me.tbMain.SuspendLayout()
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      Me.SuspendLayout()
      '
      'sbMain
      '
      Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
      Me.sbMain.Location = New System.Drawing.Point(0, 390)
      Me.sbMain.Name = "sbMain"
      Me.sbMain.Size = New System.Drawing.Size(626, 25)
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
      Me.lblUsuario.Size = New System.Drawing.Size(479, 20)
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
      'mnuMain
      '
      Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSistema, Me.mnuAyuda})
      Me.mnuMain.Location = New System.Drawing.Point(0, 0)
      Me.mnuMain.Name = "mnuMain"
      Me.mnuMain.Size = New System.Drawing.Size(626, 24)
      Me.mnuMain.TabIndex = 15
      Me.mnuMain.Text = "MenuStrip1"
      '
      'mnuSistema
      '
      Me.mnuSistema.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuActualizar, Me.mnuPreferencias, Me.ToolStripSeparator1, Me.mnuSalir})
      Me.mnuSistema.Name = "mnuSistema"
      Me.mnuSistema.Size = New System.Drawing.Size(56, 20)
      Me.mnuSistema.Text = "&Sistema"
      '
      'mnuActualizar
      '
      Me.mnuActualizar.Image = CType(resources.GetObject("mnuActualizar.Image"), System.Drawing.Image)
      Me.mnuActualizar.Name = "mnuActualizar"
      Me.mnuActualizar.Size = New System.Drawing.Size(229, 22)
      Me.mnuActualizar.Text = "&Actualizar menús y perfil..."
      '
      'mnuPreferencias
      '
      Me.mnuPreferencias.Image = CType(resources.GetObject("mnuPreferencias.Image"), System.Drawing.Image)
      Me.mnuPreferencias.Name = "mnuPreferencias"
      Me.mnuPreferencias.ShortcutKeys = System.Windows.Forms.Keys.F2
      Me.mnuPreferencias.Size = New System.Drawing.Size(229, 22)
      Me.mnuPreferencias.Text = "&Preferencias de usuario..."
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
      '
      'mnuSalir
      '
      Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
      Me.mnuSalir.Name = "mnuSalir"
      Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
      Me.mnuSalir.Size = New System.Drawing.Size(229, 22)
      Me.mnuSalir.Text = "&Salir"
      '
      'mnuAyuda
      '
      Me.mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcerca})
      Me.mnuAyuda.Name = "mnuAyuda"
      Me.mnuAyuda.Size = New System.Drawing.Size(50, 20)
      Me.mnuAyuda.Text = "&Ayuda"
      '
      'mnuAcerca
      '
      Me.mnuAcerca.Image = CType(resources.GetObject("mnuAcerca.Image"), System.Drawing.Image)
      Me.mnuAcerca.Name = "mnuAcerca"
      Me.mnuAcerca.Size = New System.Drawing.Size(145, 22)
      Me.mnuAcerca.Text = "&Acerca de..."
      '
      'tbMain
      '
      Me.tbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtCodTra, Me.btnIr, Me.ToolStripSeparator2, Me.btnSubir, Me.ToolStripSplitButton1, Me.ToolStripSeparator3, Me.btnSalir})
      Me.tbMain.Location = New System.Drawing.Point(0, 24)
      Me.tbMain.Name = "tbMain"
      Me.tbMain.Size = New System.Drawing.Size(626, 25)
      Me.tbMain.TabIndex = 16
      Me.tbMain.Text = "ToolStrip1"
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(117, 22)
      Me.ToolStripLabel1.Text = "Código de transacción:"
      '
      'txtCodTra
      '
      Me.txtCodTra.Name = "txtCodTra"
      Me.txtCodTra.Size = New System.Drawing.Size(100, 25)
      '
      'btnIr
      '
      Me.btnIr.Image = CType(resources.GetObject("btnIr.Image"), System.Drawing.Image)
      Me.btnIr.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnIr.Name = "btnIr"
      Me.btnIr.Size = New System.Drawing.Size(35, 22)
      Me.btnIr.Text = "Ir"
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'btnSubir
      '
      Me.btnSubir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnSubir.Image = CType(resources.GetObject("btnSubir.Image"), System.Drawing.Image)
      Me.btnSubir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnSubir.Name = "btnSubir"
      Me.btnSubir.Size = New System.Drawing.Size(23, 22)
      Me.btnSubir.Text = "Volver"
      '
      'ToolStripSplitButton1
      '
      Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIconos, Me.mnuLista, Me.mnuDetalle})
      Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
      Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
      Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 22)
      Me.ToolStripSplitButton1.Text = "Vista ventana"
      '
      'mnuIconos
      '
      Me.mnuIconos.Image = CType(resources.GetObject("mnuIconos.Image"), System.Drawing.Image)
      Me.mnuIconos.Name = "mnuIconos"
      Me.mnuIconos.Size = New System.Drawing.Size(123, 22)
      Me.mnuIconos.Text = "Iconos"
      '
      'mnuLista
      '
      Me.mnuLista.Image = CType(resources.GetObject("mnuLista.Image"), System.Drawing.Image)
      Me.mnuLista.Name = "mnuLista"
      Me.mnuLista.Size = New System.Drawing.Size(123, 22)
      Me.mnuLista.Text = "Lista"
      '
      'mnuDetalle
      '
      Me.mnuDetalle.Image = CType(resources.GetObject("mnuDetalle.Image"), System.Drawing.Image)
      Me.mnuDetalle.Name = "mnuDetalle"
      Me.mnuDetalle.Size = New System.Drawing.Size(123, 22)
      Me.mnuDetalle.Text = "Detalles"
      '
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'btnSalir
      '
      Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
      Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnSalir.Name = "btnSalir"
      Me.btnSalir.Size = New System.Drawing.Size(50, 22)
      Me.btnSalir.Text = " Salir"
      '
      'SplitContainer1
      '
      Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
      Me.SplitContainer1.Name = "SplitContainer1"
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.Controls.Add(Me.tvMenu)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.lvTrans)
      Me.SplitContainer1.Size = New System.Drawing.Size(626, 341)
      Me.SplitContainer1.SplitterDistance = 208
      Me.SplitContainer1.TabIndex = 17
      '
      'tvMenu
      '
      Me.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tvMenu.HideSelection = False
      Me.tvMenu.ImageIndex = 0
      Me.tvMenu.ImageList = Me.ilMain
      Me.tvMenu.Location = New System.Drawing.Point(0, 0)
      Me.tvMenu.Name = "tvMenu"
      TreeNode1.Name = "Menu"
      TreeNode1.Text = "Menú"
      Me.tvMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
      Me.tvMenu.SelectedImageIndex = 0
      Me.tvMenu.Size = New System.Drawing.Size(208, 341)
      Me.tvMenu.TabIndex = 1
      '
      'ilMain
      '
      Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilMain.Images.SetKeyName(0, "Abierta2")
      Me.ilMain.Images.SetKeyName(1, "Cerrada2")
      Me.ilMain.Images.SetKeyName(2, "Menu2")
      Me.ilMain.Images.SetKeyName(3, "Abierta")
      Me.ilMain.Images.SetKeyName(4, "Cerrada")
      Me.ilMain.Images.SetKeyName(5, "Menu")
      '
      'lvTrans
      '
      Me.lvTrans.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
      Me.lvTrans.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MEN, Me.DESCRIP, Me.CODTRA})
      Me.lvTrans.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvTrans.LargeImageList = Me.il32x32
      Me.lvTrans.Location = New System.Drawing.Point(0, 0)
      Me.lvTrans.Name = "lvTrans"
      Me.lvTrans.Size = New System.Drawing.Size(414, 341)
      Me.lvTrans.SmallImageList = Me.il16x16
      Me.lvTrans.TabIndex = 1
      Me.lvTrans.UseCompatibleStateImageBehavior = False
      Me.lvTrans.View = System.Windows.Forms.View.Details
      '
      'MEN
      '
      Me.MEN.Text = "Menù"
      Me.MEN.Width = 200
      '
      'DESCRIP
      '
      Me.DESCRIP.Text = "Descripción"
      Me.DESCRIP.Width = 200
      '
      'CODTRA
      '
      Me.CODTRA.Text = "Cod. Trx."
      '
      'il32x32
      '
      Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
      Me.il32x32.Images.SetKeyName(0, "Transaccion")
      Me.il32x32.Images.SetKeyName(1, "Carpeta")
      Me.il32x32.Images.SetKeyName(2, "Procesos")
      Me.il32x32.Images.SetKeyName(3, "Formularios")
      Me.il32x32.Images.SetKeyName(4, "Controles")
      Me.il32x32.Images.SetKeyName(5, "Actualizador")
      Me.il32x32.Images.SetKeyName(6, "Administracion")
      Me.il32x32.Images.SetKeyName(7, "Calculadora")
      Me.il32x32.Images.SetKeyName(8, "Consolida")
      Me.il32x32.Images.SetKeyName(9, "Consultas")
      Me.il32x32.Images.SetKeyName(10, "Equivalencias")
      Me.il32x32.Images.SetKeyName(11, "ExportExcel")
      Me.il32x32.Images.SetKeyName(12, "Feriados")
      Me.il32x32.Images.SetKeyName(13, "GeneraTXT")
      Me.il32x32.Images.SetKeyName(14, "Logs")
      Me.il32x32.Images.SetKeyName(15, "Notas")
      Me.il32x32.Images.SetKeyName(16, "Relaciones")
      Me.il32x32.Images.SetKeyName(17, "Seguridad")
      Me.il32x32.Images.SetKeyName(18, "Spool")
      Me.il32x32.Images.SetKeyName(19, "Tabgen")
      '
      'il16x16
      '
      Me.il16x16.ImageStream = CType(resources.GetObject("il16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.il16x16.TransparentColor = System.Drawing.Color.Transparent
      Me.il16x16.Images.SetKeyName(0, "Transaccion")
      Me.il16x16.Images.SetKeyName(1, "Carpeta2")
      Me.il16x16.Images.SetKeyName(2, "Carpeta")
      Me.il16x16.Images.SetKeyName(3, "Actualizador")
      Me.il16x16.Images.SetKeyName(4, "Administracion")
      Me.il16x16.Images.SetKeyName(5, "Calculadora")
      Me.il16x16.Images.SetKeyName(6, "Consolida")
      Me.il16x16.Images.SetKeyName(7, "Consultas")
      Me.il16x16.Images.SetKeyName(8, "Control")
      Me.il16x16.Images.SetKeyName(9, "Equivalencias")
      Me.il16x16.Images.SetKeyName(10, "ExportExcel")
      Me.il16x16.Images.SetKeyName(11, "Feriados")
      Me.il16x16.Images.SetKeyName(12, "GeneraTXT")
      Me.il16x16.Images.SetKeyName(13, "Logs")
      Me.il16x16.Images.SetKeyName(14, "Notas")
      Me.il16x16.Images.SetKeyName(15, "Relaciones")
      Me.il16x16.Images.SetKeyName(16, "Seguridad")
      Me.il16x16.Images.SetKeyName(17, "Spool")
      Me.il16x16.Images.SetKeyName(18, "Tabgen")
      Me.il16x16.Images.SetKeyName(19, "procesos.ico")
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(626, 415)
      Me.Controls.Add(Me.SplitContainer1)
      Me.Controls.Add(Me.tbMain)
      Me.Controls.Add(Me.sbMain)
      Me.Controls.Add(Me.mnuMain)
      Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MainMenuStrip = Me.mnuMain
      Me.Name = "frmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Menú principal"
      Me.sbMain.ResumeLayout(False)
      Me.sbMain.PerformLayout()
      Me.mnuMain.ResumeLayout(False)
      Me.mnuMain.PerformLayout()
      Me.tbMain.ResumeLayout(False)
      Me.tbMain.PerformLayout()
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      Me.SplitContainer1.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblEntidad As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPreferencias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAcerca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbMain As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtCodTra As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnIr As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSubir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents mnuIconos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLista As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents il16x16 As System.Windows.Forms.ImageList
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents ilMain As System.Windows.Forms.ImageList
    Friend WithEvents tvMenu As System.Windows.Forms.TreeView
    Friend WithEvents lvTrans As System.Windows.Forms.ListView
    Friend WithEvents MEN As System.Windows.Forms.ColumnHeader
    Friend WithEvents CODTRA As System.Windows.Forms.ColumnHeader
    Friend WithEvents DESCRIP As System.Windows.Forms.ColumnHeader
End Class
