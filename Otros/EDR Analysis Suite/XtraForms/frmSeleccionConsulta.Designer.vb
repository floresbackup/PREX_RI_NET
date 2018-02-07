<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionConsulta
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
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resultados de la búsqueda", 4, 4)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionConsulta))
        Me.oSplitter = New DevExpress.XtraEditors.SplitContainerControl
        Me.tvMain = New System.Windows.Forms.TreeView
        Me.il16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.GridResultados = New DevExpress.XtraGrid.GridControl
        Me.gvwResultados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cboImages = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.chkCategorias = New DevExpress.XtraEditors.CheckEdit
        Me.lblSeleccionarConsulta = New DevExpress.XtraEditors.GroupControl
        Me.picIcon = New System.Windows.Forms.PictureBox
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit
        Me.lblTip = New DevExpress.XtraEditors.LabelControl
        CType(Me.oSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitter.SuspendLayout()
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCategorias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeleccionarConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblSeleccionarConsulta.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'oSplitter
        '
        Me.oSplitter.Location = New System.Drawing.Point(4, 87)
        Me.oSplitter.Name = "oSplitter"
        Me.oSplitter.Panel1.Controls.Add(Me.tvMain)
        Me.oSplitter.Panel1.Text = "Panel1"
        Me.oSplitter.Panel2.Controls.Add(Me.GridResultados)
        Me.oSplitter.Panel2.Text = "Panel2"
        Me.oSplitter.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.oSplitter.Size = New System.Drawing.Size(707, 364)
        Me.oSplitter.SplitterPosition = 245
        Me.oSplitter.TabIndex = 0
        Me.oSplitter.Text = "SplitContainerControl1"
        '
        'tvMain
        '
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
        TreeNode2.ImageIndex = 4
        TreeNode2.Name = "nodBusqueda"
        TreeNode2.SelectedImageIndex = 4
        TreeNode2.Text = "Resultados de la búsqueda"
        Me.tvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.tvMain.SelectedImageIndex = 0
        Me.tvMain.ShowNodeToolTips = True
        Me.tvMain.Size = New System.Drawing.Size(0, 0)
        Me.tvMain.TabIndex = 2
        '
        'il16x16
        '
        Me.il16x16.ImageStream = CType(resources.GetObject("il16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.il16x16.Images.SetKeyName(0, "Resultados.png")
        Me.il16x16.Images.SetKeyName(1, "CarpetaAbierta.png")
        Me.il16x16.Images.SetKeyName(2, "CarpetaCerrada.png")
        Me.il16x16.Images.SetKeyName(3, "Database.png")
        Me.il16x16.Images.SetKeyName(4, "Buscar.png")
        '
        'GridResultados
        '
        Me.GridResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridResultados.EmbeddedNavigator.Name = ""
        Me.GridResultados.Location = New System.Drawing.Point(0, 0)
        Me.GridResultados.MainView = Me.gvwResultados
        Me.GridResultados.Name = "GridResultados"
        Me.GridResultados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboImages})
        Me.GridResultados.Size = New System.Drawing.Size(703, 360)
        Me.GridResultados.TabIndex = 11
        Me.GridResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwResultados})
        '
        'gvwResultados
        '
        Me.gvwResultados.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvwResultados.Appearance.Row.Options.UseFont = True
        Me.gvwResultados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvwResultados.GridControl = Me.GridResultados
        Me.gvwResultados.Name = "gvwResultados"
        Me.gvwResultados.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvwResultados.OptionsBehavior.Editable = False
        Me.gvwResultados.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gvwResultados.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvwResultados.OptionsView.RowAutoHeight = True
        Me.gvwResultados.OptionsView.ShowColumnHeaders = False
        Me.gvwResultados.OptionsView.ShowGroupPanel = False
        Me.gvwResultados.OptionsView.ShowIndicator = False
        Me.gvwResultados.OptionsView.ShowPreview = True
        '
        'cboImages
        '
        Me.cboImages.AutoHeight = False
        Me.cboImages.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboImages.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 3)})
        Me.cboImages.Name = "cboImages"
        Me.cboImages.SmallImages = Me.il16x16
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(469, 457)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(118, 26)
        Me.cmdAceptar.TabIndex = 11
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(593, 457)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(118, 26)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'chkCategorias
        '
        Me.chkCategorias.Location = New System.Drawing.Point(6, 461)
        Me.chkCategorias.Name = "chkCategorias"
        Me.chkCategorias.Properties.Caption = "Categorías"
        Me.chkCategorias.Size = New System.Drawing.Size(180, 19)
        Me.chkCategorias.TabIndex = 12
        '
        'lblSeleccionarConsulta
        '
        Me.lblSeleccionarConsulta.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarConsulta.AppearanceCaption.Options.UseFont = True
        Me.lblSeleccionarConsulta.Controls.Add(Me.picIcon)
        Me.lblSeleccionarConsulta.Controls.Add(Me.txtBusqueda)
        Me.lblSeleccionarConsulta.Controls.Add(Me.lblTip)
        Me.lblSeleccionarConsulta.Location = New System.Drawing.Point(4, 3)
        Me.lblSeleccionarConsulta.Name = "lblSeleccionarConsulta"
        Me.lblSeleccionarConsulta.Size = New System.Drawing.Size(707, 78)
        Me.lblSeleccionarConsulta.TabIndex = 13
        Me.lblSeleccionarConsulta.Text = "Seleccionar consulta"
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.Transparent
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(631, 11)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(70, 59)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIcon.TabIndex = 5
        Me.picIcon.TabStop = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(15, 45)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(465, 20)
        Me.txtBusqueda.TabIndex = 3
        '
        'lblTip
        '
        Me.lblTip.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTip.Appearance.Options.UseForeColor = True
        Me.lblTip.Location = New System.Drawing.Point(15, 30)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(465, 13)
        Me.lblTip.TabIndex = 4
        Me.lblTip.Text = "Seleccione la consulta o bien escriba parte de su nombre o descripción y presione" & _
            " el botón Buscar"
        '
        'frmSeleccionConsulta
        '
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(717, 490)
        Me.Controls.Add(Me.lblSeleccionarConsulta)
        Me.Controls.Add(Me.chkCategorias)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.oSplitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionConsulta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar consulta"
        CType(Me.oSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitter.ResumeLayout(False)
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCategorias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeleccionarConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblSeleccionarConsulta.ResumeLayout(False)
        Me.lblSeleccionarConsulta.PerformLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents oSplitter As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents il16x16 As System.Windows.Forms.ImageList
    Friend WithEvents tvMain As System.Windows.Forms.TreeView
    Friend WithEvents GridResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboImages As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents chkCategorias As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblSeleccionarConsulta As DevExpress.XtraEditors.GroupControl
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTip As DevExpress.XtraEditors.LabelControl
End Class
