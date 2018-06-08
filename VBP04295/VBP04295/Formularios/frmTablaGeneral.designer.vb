<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTablaGeneral
   Inherits System.Windows.Forms.Form

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
        Me.GridResultados = New DevExpress.XtraGrid.GridControl()
        Me.gvwResultados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.panTop = New DevExpress.XtraEditors.PanelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnInvertirSel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSelectAll = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTop.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridResultados
        '
        Me.GridResultados.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridResultados.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridResultados.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridResultados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridResultados.Location = New System.Drawing.Point(0, 50)
        Me.GridResultados.MainView = Me.gvwResultados
        Me.GridResultados.Margin = New System.Windows.Forms.Padding(0)
        Me.GridResultados.Name = "GridResultados"
        Me.GridResultados.Size = New System.Drawing.Size(407, 335)
        Me.GridResultados.TabIndex = 14
        Me.GridResultados.UseEmbeddedNavigator = True
        Me.GridResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwResultados})
        '
        'gvwResultados
        '
        Me.gvwResultados.GridControl = Me.GridResultados
        Me.gvwResultados.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.gvwResultados.Name = "gvwResultados"
        Me.gvwResultados.OptionsBehavior.Editable = False
        Me.gvwResultados.OptionsMenu.EnableColumnMenu = False
        Me.gvwResultados.OptionsView.ColumnAutoWidth = False
        Me.gvwResultados.OptionsView.ShowGroupPanel = False
        Me.gvwResultados.PaintStyleName = "WindowsXP"
        Me.gvwResultados.RowHeight = 19
        '
        'panTop
        '
        Me.panTop.Controls.Add(Me.PictureEdit1)
        Me.panTop.Controls.Add(Me.lblTitulo)
        Me.panTop.Controls.Add(Me.lblSubtitulo)
        Me.panTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTop.Location = New System.Drawing.Point(0, 0)
        Me.panTop.Margin = New System.Windows.Forms.Padding(0)
        Me.panTop.Name = "panTop"
        Me.panTop.Size = New System.Drawing.Size(407, 50)
        Me.panTop.TabIndex = 3
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(352, 2)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(53, 46)
        Me.PictureEdit1.TabIndex = 5
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(72, 13)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Descripción"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Location = New System.Drawing.Point(12, 27)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(200, 13)
        Me.lblSubtitulo.TabIndex = 2
        Me.lblSubtitulo.Text = "Seleccione al menos un ítem de la lista..."
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnInvertirSel)
        Me.PanelControl1.Controls.Add(Me.btnSelectAll)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 385)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(407, 30)
        Me.PanelControl1.TabIndex = 17
        '
        'btnInvertirSel
        '
        Me.btnInvertirSel.ImageOptions.Image = CType(resources.GetObject("btnInvertirSel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInvertirSel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnInvertirSel.Location = New System.Drawing.Point(25, 8)
        Me.btnInvertirSel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInvertirSel.Name = "btnInvertirSel"
        Me.btnInvertirSel.Size = New System.Drawing.Size(16, 16)
        Me.btnInvertirSel.TabIndex = 19
        Me.btnInvertirSel.ToolTip = "Invertir selección" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnSelectAll
        '
        Me.btnSelectAll.ImageOptions.Image = CType(resources.GetObject("btnSelectAll.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSelectAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSelectAll.Location = New System.Drawing.Point(4, 8)
        Me.btnSelectAll.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(16, 16)
        Me.btnSelectAll.TabIndex = 20
        Me.btnSelectAll.ToolTip = "Seleccionar todo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(318, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(84, 23)
        Me.cmdCancelar.TabIndex = 18
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(228, 4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(84, 23)
        Me.cmdAceptar.TabIndex = 17
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.GridResultados, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.panTop, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(407, 415)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'frmTablaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 415)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTablaGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tabla general"
        CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTop.ResumeLayout(False)
        Me.panTop.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents panTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnInvertirSel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSelectAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
