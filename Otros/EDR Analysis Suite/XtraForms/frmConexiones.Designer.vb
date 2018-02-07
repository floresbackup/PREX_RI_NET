<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConexiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConexiones))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Columnas", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "00000"}, 0)
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPropiedades = New DevExpress.XtraEditors.SimpleButton
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.lvConexiones = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(404, 281)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(95, 28)
        Me.cmdCerrar.TabIndex = 9
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(214, 281)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(95, 28)
        Me.cmdEliminar.TabIndex = 8
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdPropiedades
        '
        Me.cmdPropiedades.Enabled = False
        Me.cmdPropiedades.Location = New System.Drawing.Point(113, 281)
        Me.cmdPropiedades.Name = "cmdPropiedades"
        Me.cmdPropiedades.Size = New System.Drawing.Size(95, 28)
        Me.cmdPropiedades.TabIndex = 7
        Me.cmdPropiedades.Text = "Propiedades"
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "Database.png")
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(12, 281)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(95, 28)
        Me.cmdAgregar.TabIndex = 6
        Me.cmdAgregar.Text = "Agregar"
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.lvConexiones)
        Me.pc001.Location = New System.Drawing.Point(12, 12)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(487, 263)
        Me.pc001.TabIndex = 10
        '
        'lvConexiones
        '
        Me.lvConexiones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvConexiones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002})
        Me.lvConexiones.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Columnas"
        ListViewGroup1.Name = "lvg001"
        Me.lvConexiones.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lvConexiones.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        Me.lvConexiones.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvConexiones.LargeImageList = Me.il32x32
        Me.lvConexiones.Location = New System.Drawing.Point(2, 2)
        Me.lvConexiones.MultiSelect = False
        Me.lvConexiones.Name = "lvConexiones"
        Me.lvConexiones.Size = New System.Drawing.Size(483, 259)
        Me.lvConexiones.SmallImageList = Me.il32x32
        Me.lvConexiones.TabIndex = 6
        Me.lvConexiones.TileSize = New System.Drawing.Size(450, 32)
        Me.lvConexiones.UseCompatibleStateImageBehavior = False
        Me.lvConexiones.View = System.Windows.Forms.View.Tile
        '
        'frmConexiones
        '
        Me.AcceptButton = Me.cmdPropiedades
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(509, 321)
        Me.Controls.Add(Me.pc001)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdPropiedades)
        Me.Controls.Add(Me.cmdAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConexiones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conexiones"
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPropiedades As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lvConexiones As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
End Class
