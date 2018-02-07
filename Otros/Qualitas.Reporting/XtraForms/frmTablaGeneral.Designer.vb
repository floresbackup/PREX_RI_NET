<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTablaGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTablaGeneral))
        Me.GridResultados = New DevExpress.XtraGrid.GridControl
        Me.gvwResultados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.picTip = New System.Windows.Forms.PictureBox
        Me.lblTip = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridResultados
        '
        Me.GridResultados.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridResultados.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridResultados.EmbeddedNavigator.Name = ""
        Me.GridResultados.Location = New System.Drawing.Point(0, 0)
        Me.GridResultados.MainView = Me.gvwResultados
        Me.GridResultados.Name = "GridResultados"
        Me.GridResultados.Size = New System.Drawing.Size(565, 329)
        Me.GridResultados.TabIndex = 0
        Me.GridResultados.UseEmbeddedNavigator = True
        Me.GridResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwResultados})
        '
        'gvwResultados
        '
        Me.gvwResultados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvwResultados.GridControl = Me.GridResultados
        Me.gvwResultados.Name = "gvwResultados"
        Me.gvwResultados.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvwResultados.OptionsBehavior.Editable = False
        Me.gvwResultados.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gvwResultados.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvwResultados.OptionsView.ColumnAutoWidth = False
        Me.gvwResultados.OptionsView.ShowAutoFilterRow = True
        Me.gvwResultados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvwResultados.OptionsView.ShowFooter = True
        Me.gvwResultados.OptionsView.ShowGroupPanel = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(311, 344)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(118, 26)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(435, 344)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(118, 26)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'picTip
        '
        Me.picTip.Image = CType(resources.GetObject("picTip.Image"), System.Drawing.Image)
        Me.picTip.Location = New System.Drawing.Point(12, 344)
        Me.picTip.Name = "picTip"
        Me.picTip.Size = New System.Drawing.Size(20, 22)
        Me.picTip.TabIndex = 11
        Me.picTip.TabStop = False
        '
        'lblTip
        '
        Me.lblTip.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblTip.Location = New System.Drawing.Point(38, 344)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(267, 13)
        Me.lblTip.TabIndex = 12
        Me.lblTip.Text = "<CTRL> tip"
        '
        'frmTablaGeneral
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(565, 385)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.picTip)
        Me.Controls.Add(Me.GridResultados)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTablaGeneral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de opciones"
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picTip As System.Windows.Forms.PictureBox
    Friend WithEvents lblTip As DevExpress.XtraEditors.LabelControl
End Class
