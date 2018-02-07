<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarLayout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarLayout))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Propios", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Compartidos", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "00000"}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("1234", 1)
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.lvLayouts = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblOtrosLayouts = New DevExpress.XtraEditors.LabelControl
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        Me.SuspendLayout()
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "img001")
        Me.il32x32.Images.SetKeyName(1, "img002")
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.lvLayouts)
        Me.pc001.Location = New System.Drawing.Point(12, 31)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(605, 296)
        Me.pc001.TabIndex = 11
        '
        'lvLayouts
        '
        Me.lvLayouts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvLayouts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002})
        Me.lvLayouts.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Propios"
        ListViewGroup1.Name = "lvg001"
        ListViewGroup2.Header = "Compartidos"
        ListViewGroup2.Name = "lvg002"
        Me.lvLayouts.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvLayouts.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup2
        Me.lvLayouts.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lvLayouts.LargeImageList = Me.il32x32
        Me.lvLayouts.Location = New System.Drawing.Point(2, 2)
        Me.lvLayouts.MultiSelect = False
        Me.lvLayouts.Name = "lvLayouts"
        Me.lvLayouts.Size = New System.Drawing.Size(601, 292)
        Me.lvLayouts.SmallImageList = Me.il32x32
        Me.lvLayouts.TabIndex = 3
        Me.lvLayouts.TileSize = New System.Drawing.Size(450, 36)
        Me.lvLayouts.UseCompatibleStateImageBehavior = False
        Me.lvLayouts.View = System.Windows.Forms.View.Tile
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(417, 338)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(520, 338)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'lblOtrosLayouts
        '
        Me.lblOtrosLayouts.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtrosLayouts.Appearance.Options.UseFont = True
        Me.lblOtrosLayouts.Location = New System.Drawing.Point(12, 12)
        Me.lblOtrosLayouts.Name = "lblOtrosLayouts"
        Me.lblOtrosLayouts.Size = New System.Drawing.Size(263, 13)
        Me.lblOtrosLayouts.TabIndex = 15
        Me.lblOtrosLayouts.Text = "Otros diseños almacenados para esta consulta"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(12, 338)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(33, 26)
        Me.cmdEliminar.TabIndex = 16
        '
        'frmCargarLayout
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(629, 376)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.lblOtrosLayouts)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.pc001)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCargarLayout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar diseño"
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lvLayouts As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblOtrosLayouts As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
End Class
