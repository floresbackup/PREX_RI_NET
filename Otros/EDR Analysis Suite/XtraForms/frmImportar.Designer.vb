<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportar
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultas almacenadas")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportar))
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtFileName = New DevExpress.XtraEditors.TextEdit
        Me.lblFileName = New DevExpress.XtraEditors.LabelControl
        Me.cmdValidar = New DevExpress.XtraEditors.SimpleButton
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.popTreeViewCategorias = New DevExpress.XtraEditors.PopupContainerControl
        Me.tvMain = New System.Windows.Forms.TreeView
        Me.il16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.cboConexion = New DevExpress.XtraEditors.ImageComboBoxEdit
        Me.lblConexion = New DevExpress.XtraEditors.LabelControl
        Me.cboCategoria = New DevExpress.XtraEditors.PopupContainerEdit
        Me.lblCategoria = New DevExpress.XtraEditors.LabelControl
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit
        Me.lblDescripcion = New DevExpress.XtraEditors.LabelControl
        Me.txtNombreConsulta = New DevExpress.XtraEditors.TextEdit
        Me.lblNombreConsulta = New DevExpress.XtraEditors.LabelControl
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.popTreeViewCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popTreeViewCategorias.SuspendLayout()
        CType(Me.cboConexion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreConsulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(438, 10)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(28, 24)
        Me.cmdBrowse.TabIndex = 4
        Me.cmdBrowse.Text = "..."
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(123, 12)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(309, 20)
        Me.txtFileName.TabIndex = 3
        '
        'lblFileName
        '
        Me.lblFileName.Location = New System.Drawing.Point(12, 15)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(94, 13)
        Me.lblFileName.TabIndex = 2
        Me.lblFileName.Text = "Nombre de archivo:"
        '
        'cmdValidar
        '
        Me.cmdValidar.Location = New System.Drawing.Point(472, 10)
        Me.cmdValidar.Name = "cmdValidar"
        Me.cmdValidar.Size = New System.Drawing.Size(106, 24)
        Me.cmdValidar.TabIndex = 5
        Me.cmdValidar.Text = "Validar"
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.popTreeViewCategorias)
        Me.grpMain.Controls.Add(Me.cboConexion)
        Me.grpMain.Controls.Add(Me.lblConexion)
        Me.grpMain.Controls.Add(Me.cboCategoria)
        Me.grpMain.Controls.Add(Me.lblCategoria)
        Me.grpMain.Controls.Add(Me.txtDescripcion)
        Me.grpMain.Controls.Add(Me.lblDescripcion)
        Me.grpMain.Controls.Add(Me.txtNombreConsulta)
        Me.grpMain.Controls.Add(Me.lblNombreConsulta)
        Me.grpMain.Location = New System.Drawing.Point(12, 47)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(566, 252)
        Me.grpMain.TabIndex = 6
        Me.grpMain.Text = "Información de la consulta"
        '
        'popTreeViewCategorias
        '
        Me.popTreeViewCategorias.Controls.Add(Me.tvMain)
        Me.popTreeViewCategorias.Location = New System.Drawing.Point(501, 20)
        Me.popTreeViewCategorias.Name = "popTreeViewCategorias"
        Me.popTreeViewCategorias.Size = New System.Drawing.Size(266, 232)
        Me.popTreeViewCategorias.TabIndex = 18
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
        Me.tvMain.Location = New System.Drawing.Point(0, 0)
        Me.tvMain.Name = "tvMain"
        TreeNode1.Checked = True
        TreeNode1.ImageIndex = 0
        TreeNode1.Name = "nodRaiz"
        TreeNode1.Text = "Consultas almacenadas"
        Me.tvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvMain.SelectedImageIndex = 0
        Me.tvMain.ShowNodeToolTips = True
        Me.tvMain.Size = New System.Drawing.Size(266, 232)
        Me.tvMain.TabIndex = 7
        '
        'il16x16
        '
        Me.il16x16.ImageStream = CType(resources.GetObject("il16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.il16x16.Images.SetKeyName(0, "Resultados.png")
        Me.il16x16.Images.SetKeyName(1, "CarpetaAbierta.png")
        Me.il16x16.Images.SetKeyName(2, "CarpetaCerrada.png")
        Me.il16x16.Images.SetKeyName(3, "Database.png")
        Me.il16x16.Images.SetKeyName(4, "Tabla")
        Me.il16x16.Images.SetKeyName(5, "Vista")
        Me.il16x16.Images.SetKeyName(6, "Columna")
        Me.il16x16.Images.SetKeyName(7, "Procedimiento")
        Me.il16x16.Images.SetKeyName(8, "PalabraRes")
        Me.il16x16.Images.SetKeyName(9, "FuncionX")
        Me.il16x16.Images.SetKeyName(10, "Patron")
        Me.il16x16.Images.SetKeyName(11, "TipoDatos")
        '
        'cboConexion
        '
        Me.cboConexion.Enabled = False
        Me.cboConexion.Location = New System.Drawing.Point(171, 161)
        Me.cboConexion.Name = "cboConexion"
        Me.cboConexion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboConexion.Size = New System.Drawing.Size(266, 20)
        Me.cboConexion.TabIndex = 17
        '
        'lblConexion
        '
        Me.lblConexion.Location = New System.Drawing.Point(13, 164)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(49, 13)
        Me.lblConexion.TabIndex = 16
        Me.lblConexion.Text = "Conexión:"
        '
        'cboCategoria
        '
        Me.cboCategoria.Enabled = False
        Me.cboCategoria.Location = New System.Drawing.Point(171, 135)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategoria.Properties.PopupControl = Me.popTreeViewCategorias
        Me.cboCategoria.Size = New System.Drawing.Size(266, 20)
        Me.cboCategoria.TabIndex = 15
        '
        'lblCategoria
        '
        Me.lblCategoria.Location = New System.Drawing.Point(13, 138)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(51, 13)
        Me.lblCategoria.TabIndex = 14
        Me.lblCategoria.Text = "Categoría:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(171, 58)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(368, 71)
        Me.txtDescripcion.TabIndex = 13
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 61)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(58, 13)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtNombreConsulta
        '
        Me.txtNombreConsulta.Enabled = False
        Me.txtNombreConsulta.Location = New System.Drawing.Point(171, 32)
        Me.txtNombreConsulta.Name = "txtNombreConsulta"
        Me.txtNombreConsulta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreConsulta.Properties.Appearance.Options.UseFont = True
        Me.txtNombreConsulta.Size = New System.Drawing.Size(235, 20)
        Me.txtNombreConsulta.TabIndex = 11
        '
        'lblNombreConsulta
        '
        Me.lblNombreConsulta.Location = New System.Drawing.Point(13, 35)
        Me.lblNombreConsulta.Name = "lblNombreConsulta"
        Me.lblNombreConsulta.Size = New System.Drawing.Size(41, 13)
        Me.lblNombreConsulta.TabIndex = 10
        Me.lblNombreConsulta.Text = "Nombre:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(378, 314)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(481, 314)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmImportar
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(588, 355)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.cmdValidar)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblFileName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar"
        CType(Me.txtFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.popTreeViewCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popTreeViewCategorias.ResumeLayout(False)
        CType(Me.cboConexion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreConsulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFileName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdValidar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboConexion As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents lblConexion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCategoria As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents lblCategoria As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreConsulta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNombreConsulta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents il16x16 As System.Windows.Forms.ImageList
    Friend WithEvents popTreeViewCategorias As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents tvMain As System.Windows.Forms.TreeView
End Class
