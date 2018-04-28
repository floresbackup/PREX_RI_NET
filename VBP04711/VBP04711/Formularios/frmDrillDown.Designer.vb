<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrillDown
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
Me.PanTop = New DevExpress.XtraEditors.PanelControl
Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl
Me.lblTitulo = New DevExpress.XtraEditors.LabelControl
Me.picLogo = New DevExpress.XtraEditors.PictureEdit
Me.panBotones = New DevExpress.XtraEditors.PanelControl
Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
Me.Grid = New DevExpress.XtraGrid.GridControl
Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
Me.PanTop.SuspendLayout()
CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.panBotones, System.ComponentModel.ISupportInitialize).BeginInit()
Me.panBotones.SuspendLayout()
CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.PanelControl1.SuspendLayout()
CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'PanTop
'
Me.PanTop.Appearance.BackColor = System.Drawing.Color.White
Me.PanTop.Appearance.Options.UseBackColor = True
Me.PanTop.Controls.Add(Me.lblSubtitulo)
Me.PanTop.Controls.Add(Me.lblTitulo)
Me.PanTop.Controls.Add(Me.picLogo)
Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
Me.PanTop.Location = New System.Drawing.Point(0, 0)
Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
Me.PanTop.Name = "PanTop"
Me.PanTop.Size = New System.Drawing.Size(598, 54)
Me.PanTop.TabIndex = 16
'
'lblSubtitulo
'
Me.lblSubtitulo.Location = New System.Drawing.Point(24, 29)
Me.lblSubtitulo.Name = "lblSubtitulo"
Me.lblSubtitulo.Size = New System.Drawing.Size(90, 13)
Me.lblSubtitulo.TabIndex = 2
Me.lblSubtitulo.Text = "Elija una operación"
'
'lblTitulo
'
Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
Me.lblTitulo.Appearance.Options.UseFont = True
Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
Me.lblTitulo.Name = "lblTitulo"
Me.lblTitulo.Size = New System.Drawing.Size(56, 13)
Me.lblTitulo.TabIndex = 1
Me.lblTitulo.Text = "Drill Down"
'
'picLogo
'
Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.picLogo.EditValue = Global.VBP04711.My.Resources.Resources.Grid_2
        Me.picLogo.Location = New System.Drawing.Point(537, 2)
Me.picLogo.Name = "picLogo"
Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
Me.picLogo.Properties.Appearance.Options.UseBackColor = True
Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
Me.picLogo.Size = New System.Drawing.Size(59, 50)
Me.picLogo.TabIndex = 0
'
'panBotones
'
Me.panBotones.Controls.Add(Me.cmdImprimir)
Me.panBotones.Controls.Add(Me.cmdGuardar)
Me.panBotones.Controls.Add(Me.cmdCerrar)
Me.panBotones.Dock = System.Windows.Forms.DockStyle.Bottom
Me.panBotones.Location = New System.Drawing.Point(0, 428)
Me.panBotones.Name = "panBotones"
Me.panBotones.Size = New System.Drawing.Size(598, 33)
Me.panBotones.TabIndex = 23
'
'cmdImprimir
'
Me.cmdImprimir.Location = New System.Drawing.Point(5, 5)
Me.cmdImprimir.Name = "cmdImprimir"
Me.cmdImprimir.Size = New System.Drawing.Size(75, 23)
Me.cmdImprimir.TabIndex = 2
Me.cmdImprimir.Text = "&Imprimir"
'
'cmdGuardar
'
Me.cmdGuardar.Location = New System.Drawing.Point(86, 5)
Me.cmdGuardar.Name = "cmdGuardar"
Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
Me.cmdGuardar.TabIndex = 1
Me.cmdGuardar.Text = "&Exportar"
'
'cmdCerrar
'
Me.cmdCerrar.Location = New System.Drawing.Point(167, 5)
Me.cmdCerrar.Name = "cmdCerrar"
Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
Me.cmdCerrar.TabIndex = 0
Me.cmdCerrar.Text = "&Cerrar"
'
'PanelControl1
'
Me.PanelControl1.Controls.Add(Me.Grid)
Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelControl1.Location = New System.Drawing.Point(0, 54)
Me.PanelControl1.Name = "PanelControl1"
Me.PanelControl1.Size = New System.Drawing.Size(598, 374)
Me.PanelControl1.TabIndex = 24
'
'Grid
'
Me.Grid.AllowDrop = True
Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
Me.Grid.EmbeddedNavigator.Buttons.Append.Visible = False
Me.Grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
Me.Grid.EmbeddedNavigator.Buttons.Edit.Visible = False
Me.Grid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
Me.Grid.EmbeddedNavigator.Buttons.Remove.Visible = False
Me.Grid.EmbeddedNavigator.Name = ""
Me.Grid.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}"
Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Grid.Location = New System.Drawing.Point(2, 2)
Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
Me.Grid.LookAndFeel.UseWindowsXPTheme = True
Me.Grid.MainView = Me.GridView1
Me.Grid.Name = "Grid"
Me.Grid.Size = New System.Drawing.Size(594, 370)
Me.Grid.TabIndex = 7
Me.Grid.UseEmbeddedNavigator = True
Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
'
'GridView1
'
Me.GridView1.GridControl = Me.Grid
Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridView1.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
Me.GridView1.Name = "GridView1"
Me.GridView1.OptionsBehavior.Editable = False
Me.GridView1.OptionsLayout.Columns.StoreAllOptions = True
Me.GridView1.OptionsLayout.Columns.StoreAppearance = True
Me.GridView1.OptionsLayout.StoreAllOptions = True
Me.GridView1.OptionsLayout.StoreAppearance = True
Me.GridView1.OptionsView.ShowFooter = True
Me.GridView1.PaintStyleName = "WindowsXP"
Me.GridView1.RowHeight = 19
'
'frmDrillDown
'
Me.AllowDrop = True
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(598, 461)
Me.Controls.Add(Me.PanelControl1)
Me.Controls.Add(Me.panBotones)
Me.Controls.Add(Me.PanTop)
Me.Name = "frmDrillDown"
Me.Text = "Drill Down"
CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
Me.PanTop.ResumeLayout(False)
Me.PanTop.PerformLayout()
CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.panBotones, System.ComponentModel.ISupportInitialize).EndInit()
Me.panBotones.ResumeLayout(False)
CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
Me.PanelControl1.ResumeLayout(False)
CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
   Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
   Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
   Friend WithEvents panBotones As DevExpress.XtraEditors.PanelControl
   Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
   Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
