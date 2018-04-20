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
      Me.cmdAceptar = New System.Windows.Forms.Button
      Me.cmdCancelar = New System.Windows.Forms.Button
      Me.GridResultados = New DevExpress.XtraGrid.GridControl
      Me.gvwResultados = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cmdAceptar
      '
      Me.cmdAceptar.Location = New System.Drawing.Point(231, 386)
      Me.cmdAceptar.Name = "cmdAceptar"
      Me.cmdAceptar.Size = New System.Drawing.Size(84, 23)
      Me.cmdAceptar.TabIndex = 9
      Me.cmdAceptar.Text = "&Aceptar"
      '
      'cmdCancelar
      '
      Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.cmdCancelar.Location = New System.Drawing.Point(321, 386)
      Me.cmdCancelar.Name = "cmdCancelar"
      Me.cmdCancelar.Size = New System.Drawing.Size(84, 23)
      Me.cmdCancelar.TabIndex = 10
      Me.cmdCancelar.Text = "&Cancelar"
      '
      'GridResultados
      '
      Me.GridResultados.Cursor = System.Windows.Forms.Cursors.Default
      Me.GridResultados.EmbeddedNavigator.Buttons.Append.Visible = False
      Me.GridResultados.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
      Me.GridResultados.EmbeddedNavigator.Buttons.Edit.Visible = False
      Me.GridResultados.EmbeddedNavigator.Buttons.EndEdit.Visible = False
      Me.GridResultados.EmbeddedNavigator.Buttons.Remove.Visible = False
      Me.GridResultados.EmbeddedNavigator.Name = ""
      Me.GridResultados.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}"
      Me.GridResultados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GridResultados.Location = New System.Drawing.Point(0, 48)
      Me.GridResultados.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
      Me.GridResultados.LookAndFeel.UseWindowsXPTheme = True
      Me.GridResultados.MainView = Me.gvwResultados
      Me.GridResultados.Name = "GridResultados"
      Me.GridResultados.Size = New System.Drawing.Size(407, 332)
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
      Me.panTop.BackColor = System.Drawing.SystemColors.ButtonHighlight
      Me.panTop.Controls.Add(Me.PictureBox1)
      Me.panTop.Controls.Add(Me.lblSubtitulo)
      Me.panTop.Controls.Add(Me.lblTitulo)
      Me.panTop.Dock = System.Windows.Forms.DockStyle.Top
      Me.panTop.Location = New System.Drawing.Point(0, 0)
      Me.panTop.Name = "panTop"
      Me.panTop.Size = New System.Drawing.Size(407, 47)
      Me.panTop.TabIndex = 15
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(348, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 10, 10, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(59, 47)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(25, 27)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(200, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Seleccione al menos un ítem de la lista..."
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(72, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Descripción"
      '
      'frmTablaGeneral
      '
      Me.AcceptButton = Me.cmdAceptar
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.cmdCancelar
      Me.ClientSize = New System.Drawing.Size(407, 415)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.GridResultados)
      Me.Controls.Add(Me.cmdCancelar)
      Me.Controls.Add(Me.cmdAceptar)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmTablaGeneral"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Tabla general"
      CType(Me.GridResultados, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.gvwResultados, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents cmdAceptar As System.Windows.Forms.Button
   Friend WithEvents cmdCancelar As System.Windows.Forms.Button
   Friend WithEvents GridResultados As DevExpress.XtraGrid.GridControl
   Friend WithEvents gvwResultados As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
