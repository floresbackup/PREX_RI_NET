<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalizarCubo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonalizarCubo))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Columnas", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Item1", "00000"}, 0)
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPropiedades = New DevExpress.XtraEditors.SimpleButton
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.grpTotales = New DevExpress.XtraEditors.GroupControl
        Me.chkGrandesTotalesColumnas = New DevExpress.XtraEditors.CheckEdit
        Me.chkTotalesColumnas = New DevExpress.XtraEditors.CheckEdit
        Me.chkGrandesTotalesFilas = New DevExpress.XtraEditors.CheckEdit
        Me.chkTotalesFilas = New DevExpress.XtraEditors.CheckEdit
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.lvCampos = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        CType(Me.grpTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotales.SuspendLayout()
        CType(Me.chkGrandesTotalesColumnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTotalesColumnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGrandesTotalesFilas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTotalesFilas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(404, 408)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(95, 28)
        Me.cmdCerrar.TabIndex = 9
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(402, 281)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(95, 28)
        Me.cmdEliminar.TabIndex = 8
        Me.cmdEliminar.Text = "Eliminar"
        '
        'cmdPropiedades
        '
        Me.cmdPropiedades.Enabled = False
        Me.cmdPropiedades.Location = New System.Drawing.Point(301, 281)
        Me.cmdPropiedades.Name = "cmdPropiedades"
        Me.cmdPropiedades.Size = New System.Drawing.Size(95, 28)
        Me.cmdPropiedades.TabIndex = 7
        Me.cmdPropiedades.Text = "Propiedades"
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "imgFiltro")
        Me.il32x32.Images.SetKeyName(1, "imgFila")
        Me.il32x32.Images.SetKeyName(2, "imgColumna")
        Me.il32x32.Images.SetKeyName(3, "imgTotales")
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(200, 281)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(95, 28)
        Me.cmdAgregar.TabIndex = 6
        Me.cmdAgregar.Text = "Agregar"
        '
        'grpTotales
        '
        Me.grpTotales.Controls.Add(Me.chkGrandesTotalesColumnas)
        Me.grpTotales.Controls.Add(Me.chkTotalesColumnas)
        Me.grpTotales.Controls.Add(Me.chkGrandesTotalesFilas)
        Me.grpTotales.Controls.Add(Me.chkTotalesFilas)
        Me.grpTotales.Location = New System.Drawing.Point(12, 320)
        Me.grpTotales.Name = "grpTotales"
        Me.grpTotales.Size = New System.Drawing.Size(485, 78)
        Me.grpTotales.TabIndex = 10
        Me.grpTotales.Text = "Totales"
        '
        'chkGrandesTotalesColumnas
        '
        Me.chkGrandesTotalesColumnas.Location = New System.Drawing.Point(243, 48)
        Me.chkGrandesTotalesColumnas.Name = "chkGrandesTotalesColumnas"
        Me.chkGrandesTotalesColumnas.Properties.Caption = "CheckEdit1"
        Me.chkGrandesTotalesColumnas.Size = New System.Drawing.Size(237, 19)
        Me.chkGrandesTotalesColumnas.TabIndex = 3
        '
        'chkTotalesColumnas
        '
        Me.chkTotalesColumnas.Location = New System.Drawing.Point(243, 23)
        Me.chkTotalesColumnas.Name = "chkTotalesColumnas"
        Me.chkTotalesColumnas.Properties.Caption = "CheckEdit1"
        Me.chkTotalesColumnas.Size = New System.Drawing.Size(237, 19)
        Me.chkTotalesColumnas.TabIndex = 2
        '
        'chkGrandesTotalesFilas
        '
        Me.chkGrandesTotalesFilas.Location = New System.Drawing.Point(5, 48)
        Me.chkGrandesTotalesFilas.Name = "chkGrandesTotalesFilas"
        Me.chkGrandesTotalesFilas.Properties.Caption = "CheckEdit1"
        Me.chkGrandesTotalesFilas.Size = New System.Drawing.Size(232, 19)
        Me.chkGrandesTotalesFilas.TabIndex = 1
        '
        'chkTotalesFilas
        '
        Me.chkTotalesFilas.Location = New System.Drawing.Point(5, 23)
        Me.chkTotalesFilas.Name = "chkTotalesFilas"
        Me.chkTotalesFilas.Properties.Caption = "CheckEdit1"
        Me.chkTotalesFilas.Size = New System.Drawing.Size(232, 19)
        Me.chkTotalesFilas.TabIndex = 0
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.lvCampos)
        Me.pc001.Location = New System.Drawing.Point(12, 12)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(487, 263)
        Me.pc001.TabIndex = 11
        '
        'lvCampos
        '
        Me.lvCampos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvCampos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002})
        Me.lvCampos.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Columnas"
        ListViewGroup1.Name = "lvg001"
        Me.lvCampos.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lvCampos.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        Me.lvCampos.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvCampos.LargeImageList = Me.il32x32
        Me.lvCampos.Location = New System.Drawing.Point(2, 2)
        Me.lvCampos.MultiSelect = False
        Me.lvCampos.Name = "lvCampos"
        Me.lvCampos.Size = New System.Drawing.Size(483, 259)
        Me.lvCampos.SmallImageList = Me.il32x32
        Me.lvCampos.TabIndex = 6
        Me.lvCampos.UseCompatibleStateImageBehavior = False
        Me.lvCampos.View = System.Windows.Forms.View.Tile
        '
        'frmPersonalizarCubo
        '
        Me.AcceptButton = Me.cmdPropiedades
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(509, 448)
        Me.Controls.Add(Me.pc001)
        Me.Controls.Add(Me.grpTotales)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdPropiedades)
        Me.Controls.Add(Me.cmdAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonalizarCubo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personalizar tabla dinámica"
        CType(Me.grpTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTotales.ResumeLayout(False)
        CType(Me.chkGrandesTotalesColumnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTotalesColumnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGrandesTotalesFilas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTotalesFilas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPropiedades As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpTotales As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkTotalesFilas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGrandesTotalesColumnas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTotalesColumnas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGrandesTotalesFilas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lvCampos As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
End Class
