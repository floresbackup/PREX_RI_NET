<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguridad
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Usuarios", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "00000"}, 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguridad))
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.lvUsuarios = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPropiedades = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOpcionesSeguridad = New DevExpress.XtraEditors.SimpleButton
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        Me.SuspendLayout()
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.lvUsuarios)
        Me.pc001.Location = New System.Drawing.Point(12, 12)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(600, 263)
        Me.pc001.TabIndex = 15
        '
        'lvUsuarios
        '
        Me.lvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvUsuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002})
        Me.lvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvUsuarios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup1.Header = "Usuarios"
        ListViewGroup1.Name = "lvg001"
        Me.lvUsuarios.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lvUsuarios.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        Me.lvUsuarios.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvUsuarios.LargeImageList = Me.il32x32
        Me.lvUsuarios.Location = New System.Drawing.Point(2, 2)
        Me.lvUsuarios.MultiSelect = False
        Me.lvUsuarios.Name = "lvUsuarios"
        Me.lvUsuarios.Size = New System.Drawing.Size(596, 259)
        Me.lvUsuarios.SmallImageList = Me.il32x32
        Me.lvUsuarios.TabIndex = 6
        Me.lvUsuarios.TileSize = New System.Drawing.Size(450, 36)
        Me.lvUsuarios.UseCompatibleStateImageBehavior = False
        Me.lvUsuarios.View = System.Windows.Forms.View.Tile
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "Usuario.png")
        Me.il32x32.Images.SetKeyName(1, "UsuarioBloqueado.png")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(517, 286)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(95, 28)
        Me.cmdCerrar.TabIndex = 14
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(214, 286)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(95, 28)
        Me.cmdEliminar.TabIndex = 13
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdPropiedades
        '
        Me.cmdPropiedades.Enabled = False
        Me.cmdPropiedades.Location = New System.Drawing.Point(113, 286)
        Me.cmdPropiedades.Name = "cmdPropiedades"
        Me.cmdPropiedades.Size = New System.Drawing.Size(95, 28)
        Me.cmdPropiedades.TabIndex = 12
        Me.cmdPropiedades.Text = "Propiedades"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(12, 286)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(95, 28)
        Me.cmdAgregar.TabIndex = 11
        Me.cmdAgregar.Text = "Agregar"
        '
        'cmdOpcionesSeguridad
        '
        Me.cmdOpcionesSeguridad.Location = New System.Drawing.Point(367, 286)
        Me.cmdOpcionesSeguridad.Name = "cmdOpcionesSeguridad"
        Me.cmdOpcionesSeguridad.Size = New System.Drawing.Size(144, 28)
        Me.cmdOpcionesSeguridad.TabIndex = 16
        Me.cmdOpcionesSeguridad.Text = "Opciones de seguridad..."
        '
        'frmSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(624, 326)
        Me.Controls.Add(Me.cmdOpcionesSeguridad)
        Me.Controls.Add(Me.pc001)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdPropiedades)
        Me.Controls.Add(Me.cmdAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeguridad"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguridad y usuarios"
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lvUsuarios As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPropiedades As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOpcionesSeguridad As DevExpress.XtraEditors.SimpleButton
End Class
