<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVariables))
        Me.il32x32 = New System.Windows.Forms.ImageList(Me.components)
        Me.pc001 = New DevExpress.XtraEditors.PanelControl
        Me.lvVariables = New System.Windows.Forms.ListView
        Me.col001 = New System.Windows.Forms.ColumnHeader
        Me.col002 = New System.Windows.Forms.ColumnHeader
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pc001.SuspendLayout()
        Me.SuspendLayout()
        '
        'il32x32
        '
        Me.il32x32.ImageStream = CType(resources.GetObject("il32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32x32.Images.SetKeyName(0, "Variable.png")
        '
        'pc001
        '
        Me.pc001.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pc001.Controls.Add(Me.lvVariables)
        Me.pc001.Location = New System.Drawing.Point(12, 12)
        Me.pc001.Name = "pc001"
        Me.pc001.Size = New System.Drawing.Size(487, 270)
        Me.pc001.TabIndex = 11
        '
        'lvVariables
        '
        Me.lvVariables.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvVariables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvVariables.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col001, Me.col002})
        Me.lvVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvVariables.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvVariables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvVariables.HideSelection = False
        Me.lvVariables.LargeImageList = Me.il32x32
        Me.lvVariables.Location = New System.Drawing.Point(2, 2)
        Me.lvVariables.MultiSelect = False
        Me.lvVariables.Name = "lvVariables"
        Me.lvVariables.Size = New System.Drawing.Size(483, 266)
        Me.lvVariables.SmallImageList = Me.il32x32
        Me.lvVariables.TabIndex = 6
        Me.lvVariables.TileSize = New System.Drawing.Size(450, 32)
        Me.lvVariables.UseCompatibleStateImageBehavior = False
        Me.lvVariables.View = System.Windows.Forms.View.Details
        '
        'col001
        '
        Me.col001.Width = 130
        '
        'col002
        '
        Me.col002.Width = 322
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(315, 294)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(89, 26)
        Me.cmdAceptar.TabIndex = 21
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(410, 294)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(89, 26)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmVariables
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(511, 332)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.pc001)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVariables"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insertar variable"
        CType(Me.pc001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pc001.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents il32x32 As System.Windows.Forms.ImageList
    Friend WithEvents pc001 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lvVariables As System.Windows.Forms.ListView
    Friend WithEvents col001 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col002 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
End Class
