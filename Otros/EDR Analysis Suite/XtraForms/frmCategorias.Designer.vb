<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategorias))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultas almacenadas")
        Me.il16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.popContext = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnNueva = New DevExpress.XtraBars.BarButtonItem
        Me.btnCambiarNombre = New DevExpress.XtraBars.BarButtonItem
        Me.btnEliminar = New DevExpress.XtraBars.BarButtonItem
        Me.dxBars = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.lblTip = New DevExpress.XtraEditors.LabelControl
        Me.picTip = New System.Windows.Forms.PictureBox
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.tvMain = New System.Windows.Forms.TreeView
        CType(Me.popContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxBars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        Me.SuspendLayout()
        '
        'il16x16
        '
        Me.il16x16.ImageStream = CType(resources.GetObject("il16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.il16x16.Images.SetKeyName(0, "Resultados.png")
        Me.il16x16.Images.SetKeyName(1, "CarpetaAbierta.png")
        Me.il16x16.Images.SetKeyName(2, "CarpetaCerrada.png")
        Me.il16x16.Images.SetKeyName(3, "Database.png")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(444, 455)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(102, 27)
        Me.cmdCerrar.TabIndex = 2
        Me.cmdCerrar.Text = "&Cerrar"
        '
        'popContext
        '
        Me.popContext.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnNueva), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCambiarNombre), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEliminar)})
        Me.popContext.Manager = Me.dxBars
        Me.popContext.Name = "popContext"
        '
        'btnNueva
        '
        Me.btnNueva.Caption = "Nueva categoría"
        Me.btnNueva.Id = 0
        Me.btnNueva.Name = "btnNueva"
        '
        'btnCambiarNombre
        '
        Me.btnCambiarNombre.Caption = "Cambiar nombre"
        Me.btnCambiarNombre.Id = 1
        Me.btnCambiarNombre.Name = "btnCambiarNombre"
        '
        'btnEliminar
        '
        Me.btnEliminar.Caption = "Eliminar"
        Me.btnEliminar.Id = 2
        Me.btnEliminar.Name = "btnEliminar"
        '
        'dxBars
        '
        Me.dxBars.DockControls.Add(Me.barDockControlTop)
        Me.dxBars.DockControls.Add(Me.barDockControlBottom)
        Me.dxBars.DockControls.Add(Me.barDockControlLeft)
        Me.dxBars.DockControls.Add(Me.barDockControlRight)
        Me.dxBars.Form = Me
        Me.dxBars.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnNueva, Me.btnCambiarNombre, Me.btnEliminar})
        Me.dxBars.MaxItemId = 3
        '
        'lblTip
        '
        Me.lblTip.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblTip.Location = New System.Drawing.Point(28, 443)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(300, 13)
        Me.lblTip.TabIndex = 14
        Me.lblTip.Text = "<CTRL> tip"
        '
        'picTip
        '
        Me.picTip.Image = CType(resources.GetObject("picTip.Image"), System.Drawing.Image)
        Me.picTip.Location = New System.Drawing.Point(6, 441)
        Me.picTip.Name = "picTip"
        Me.picTip.Size = New System.Drawing.Size(20, 22)
        Me.picTip.TabIndex = 13
        Me.picTip.TabStop = False
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.tvMain)
        Me.pc001.Location = New System.Drawing.Point(6, 6)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(540, 424)
        Me.pc001.TabIndex = 16
        '
        'tvMain
        '
        Me.tvMain.AllowDrop = True
        Me.tvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvMain.HideSelection = False
        Me.tvMain.ImageIndex = 0
        Me.tvMain.ImageList = Me.il16x16
        Me.tvMain.LabelEdit = True
        Me.tvMain.Location = New System.Drawing.Point(2, 2)
        Me.tvMain.Name = "tvMain"
        TreeNode1.Checked = True
        TreeNode1.ImageIndex = 0
        TreeNode1.Name = "nodRaiz"
        TreeNode1.Text = "Consultas almacenadas"
        Me.tvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvMain.SelectedImageIndex = 0
        Me.tvMain.ShowNodeToolTips = True
        Me.tvMain.Size = New System.Drawing.Size(536, 420)
        Me.tvMain.TabIndex = 2
        '
        'frmCategorias
        '
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(553, 494)
        Me.Controls.Add(Me.pc001)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.picTip)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCategorias"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorías"
        CType(Me.popContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxBars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents il16x16 As System.Windows.Forms.ImageList
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents popContext As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnNueva As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCambiarNombre As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dxBars As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lblTip As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picTip As System.Windows.Forms.PictureBox
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tvMain As System.Windows.Forms.TreeView
End Class
