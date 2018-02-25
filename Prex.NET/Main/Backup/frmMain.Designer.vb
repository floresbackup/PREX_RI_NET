<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
      Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menú")
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
      Me.sbMain = New System.Windows.Forms.StatusStrip
      Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
      Me.tbMain = New System.Windows.Forms.ToolStrip
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
      Me.txtCodTra = New System.Windows.Forms.ToolStripTextBox
      Me.btnIr = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.btnSubir = New System.Windows.Forms.ToolStripButton
      Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
      Me.IconosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
      Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
      Me.DetallesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
      Me.btnSalir = New System.Windows.Forms.ToolStripButton
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
      Me.tvMenu = New System.Windows.Forms.TreeView
      Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
      Me.lvTrans = New System.Windows.Forms.ListView
      Me.DESCRI = New System.Windows.Forms.ColumnHeader
      Me.CODTRA = New System.Windows.Forms.ColumnHeader
      Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
      Me.il16x16 = New System.Windows.Forms.ImageList(Me.components)
      Me.mnuMain = New System.Windows.Forms.MenuStrip
      Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
      Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
      Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
      Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
      Me.sbMain.SuspendLayout()
      Me.tbMain.SuspendLayout()
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      Me.mnuMain.SuspendLayout()
      Me.SuspendLayout()
      '
      'sbMain
      '
      Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
      Me.sbMain.Location = New System.Drawing.Point(0, 351)
      Me.sbMain.Name = "sbMain"
      Me.sbMain.Size = New System.Drawing.Size(553, 22)
      Me.sbMain.TabIndex = 0
      '
      'ToolStripStatusLabel1
      '
      Me.ToolStripStatusLabel1.Image = Global.Prex.My.Resources.Resources.User
      Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
      Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(95, 17)
      Me.ToolStripStatusLabel1.Text = "Usuario activo:"
      Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'tbMain
      '
      Me.tbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtCodTra, Me.btnIr, Me.ToolStripSeparator1, Me.btnSubir, Me.ToolStripSplitButton1, Me.ToolStripSeparator2, Me.btnSalir})
      Me.tbMain.Location = New System.Drawing.Point(0, 24)
      Me.tbMain.Name = "tbMain"
      Me.tbMain.Size = New System.Drawing.Size(553, 25)
      Me.tbMain.TabIndex = 1
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
      Me.btnIr.Image = Global.Prex.My.Resources.Resources.db_Next_2
      Me.btnIr.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnIr.Name = "btnIr"
      Me.btnIr.Size = New System.Drawing.Size(35, 22)
      Me.btnIr.Text = "Ir"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'btnSubir
      '
      Me.btnSubir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnSubir.Image = Global.Prex.My.Resources.Resources.Up_One_Level
      Me.btnSubir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnSubir.Name = "btnSubir"
      Me.btnSubir.Size = New System.Drawing.Size(23, 22)
      Me.btnSubir.Text = "ToolStripButton1"
      '
      'ToolStripSplitButton1
      '
      Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IconosToolStripMenuItem, Me.ListaToolStripMenuItem, Me.DetallesToolStripMenuItem})
      Me.ToolStripSplitButton1.Image = Global.Prex.My.Resources.Resources.Views
      Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
      Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 22)
      Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
      '
      'IconosToolStripMenuItem
      '
      Me.IconosToolStripMenuItem.Image = Global.Prex.My.Resources.Resources.View_Large_Icons
      Me.IconosToolStripMenuItem.Name = "IconosToolStripMenuItem"
      Me.IconosToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
      Me.IconosToolStripMenuItem.Text = "Iconos"
      '
      'ListaToolStripMenuItem
      '
      Me.ListaToolStripMenuItem.Image = Global.Prex.My.Resources.Resources.View_List
      Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
      Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
      Me.ListaToolStripMenuItem.Text = "Lista"
      '
      'DetallesToolStripMenuItem
      '
      Me.DetallesToolStripMenuItem.Image = Global.Prex.My.Resources.Resources.View_Details
      Me.DetallesToolStripMenuItem.Name = "DetallesToolStripMenuItem"
      Me.DetallesToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
      Me.DetallesToolStripMenuItem.Text = "Detalles"
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'btnSalir
      '
      Me.btnSalir.Image = Global.Prex.My.Resources.Resources.Cross
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
      Me.SplitContainer1.Size = New System.Drawing.Size(553, 302)
      Me.SplitContainer1.SplitterDistance = 181
      Me.SplitContainer1.TabIndex = 2
      '
      'tvMenu
      '
      Me.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tvMenu.ImageIndex = 0
      Me.tvMenu.ImageList = Me.ilMain
      Me.tvMenu.Location = New System.Drawing.Point(0, 0)
      Me.tvMenu.Name = "tvMenu"
      TreeNode2.Name = "Menu"
      TreeNode2.Text = "Menú"
      Me.tvMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
      Me.tvMenu.SelectedImageIndex = 0
      Me.tvMenu.Size = New System.Drawing.Size(181, 302)
      Me.tvMenu.TabIndex = 0
      '
      'ilMain
      '
      Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilMain.Images.SetKeyName(0, "Abierta")
      Me.ilMain.Images.SetKeyName(1, "Cerrada")
      Me.ilMain.Images.SetKeyName(2, "Menu")
      '
      'lvTrans
      '
      Me.lvTrans.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
      Me.lvTrans.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DESCRI, Me.CODTRA})
      Me.lvTrans.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvTrans.LargeImageList = Me.il32x32
      Me.lvTrans.Location = New System.Drawing.Point(0, 0)
      Me.lvTrans.Name = "lvTrans"
      Me.lvTrans.Size = New System.Drawing.Size(368, 302)
      Me.lvTrans.SmallImageList = Me.il16x16
      Me.lvTrans.TabIndex = 0
      Me.lvTrans.UseCompatibleStateImageBehavior = False
      Me.lvTrans.View = System.Windows.Forms.View.Details
      '
      'DESCRI
      '
      Me.DESCRI.Text = "Descripción"
      Me.DESCRI.Width = 200
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
      '
      'il16x16
      '
      Me.il16x16.ImageStream = CType(resources.GetObject("il16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.il16x16.TransparentColor = System.Drawing.Color.Transparent
      Me.il16x16.Images.SetKeyName(0, "Transaccion")
      Me.il16x16.Images.SetKeyName(1, "Carpeta")
      '
      'mnuMain
      '
      Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.AyudaToolStripMenuItem})
      Me.mnuMain.Location = New System.Drawing.Point(0, 0)
      Me.mnuMain.Name = "mnuMain"
      Me.mnuMain.Size = New System.Drawing.Size(553, 24)
      Me.mnuMain.TabIndex = 3
      Me.mnuMain.Text = "MenuStrip1"
      '
      'SistemaToolStripMenuItem
      '
      Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
      Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
      Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
      Me.SistemaToolStripMenuItem.Text = "&Sistema"
      '
      'SalirToolStripMenuItem
      '
      Me.SalirToolStripMenuItem.Image = Global.Prex.My.Resources.Resources.Cross
      Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
      Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
      Me.SalirToolStripMenuItem.Text = "&Salir"
      '
      'AyudaToolStripMenuItem
      '
      Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
      Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
      Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
      Me.AyudaToolStripMenuItem.Text = "&Ayuda"
      '
      'AcercaDeToolStripMenuItem
      '
      Me.AcercaDeToolStripMenuItem.Image = Global.Prex.My.Resources.Resources.About
      Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
      Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
      Me.AcercaDeToolStripMenuItem.Text = "&Acerca de..."
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(553, 373)
      Me.Controls.Add(Me.SplitContainer1)
      Me.Controls.Add(Me.tbMain)
      Me.Controls.Add(Me.sbMain)
      Me.Controls.Add(Me.mnuMain)
      Me.MainMenuStrip = Me.mnuMain
      Me.Name = "frmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Prex"
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      Me.sbMain.ResumeLayout(False)
      Me.sbMain.PerformLayout()
      Me.tbMain.ResumeLayout(False)
      Me.tbMain.PerformLayout()
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      Me.SplitContainer1.ResumeLayout(False)
      Me.mnuMain.ResumeLayout(False)
      Me.mnuMain.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
   Friend WithEvents tbMain As System.Windows.Forms.ToolStrip
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents tvMenu As System.Windows.Forms.TreeView
   Friend WithEvents lvTrans As System.Windows.Forms.ListView
   Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
   Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ilMain As System.Windows.Forms.ImageList
   Friend WithEvents il32x32 As System.Windows.Forms.ImageList
   Friend WithEvents il16x16 As System.Windows.Forms.ImageList
   Friend WithEvents CODTRA As System.Windows.Forms.ColumnHeader
   Friend WithEvents DESCRI As System.Windows.Forms.ColumnHeader
   Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents txtCodTra As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents btnIr As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnSubir As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
   Friend WithEvents IconosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents DetallesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
