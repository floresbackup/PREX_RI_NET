<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrilla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrilla))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.Grid = New DevExpress.XtraGrid.GridControl
      Me.gResult = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.cmdExportar = New System.Windows.Forms.Button
      Me.cmdImprimir = New System.Windows.Forms.Button
      Me.TableLayoutPanel1.SuspendLayout()
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.gResult, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'TableLayoutPanel1
      '
      Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TableLayoutPanel1.ColumnCount = 1
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(432, 388)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 1
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(108, 27)
      Me.TableLayoutPanel1.TabIndex = 1
      '
      'OK_Button
      '
      Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.OK_Button.Location = New System.Drawing.Point(15, 3)
      Me.OK_Button.Name = "OK_Button"
      Me.OK_Button.Size = New System.Drawing.Size(78, 21)
      Me.OK_Button.TabIndex = 0
      Me.OK_Button.Text = "Cerrar"
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
      Me.panTop.Size = New System.Drawing.Size(545, 45)
      Me.panTop.TabIndex = 4
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(475, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(70, 45)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(21, 23)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(445, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Puede exportar o imprimir las cuentas listadas abajo para relacionarlas en el map" & _
          "a de gestión."
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(239, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Las siguientes cuentas no tienen relación"
      '
      'Grid
      '
      Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
      Me.Grid.EmbeddedNavigator.Buttons.Append.Visible = False
      Me.Grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
      Me.Grid.EmbeddedNavigator.Buttons.Edit.Visible = False
      Me.Grid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
      Me.Grid.EmbeddedNavigator.Buttons.Remove.Visible = False
      Me.Grid.EmbeddedNavigator.Name = ""
      Me.Grid.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}"
      Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Grid.Location = New System.Drawing.Point(5, 50)
      Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
      Me.Grid.LookAndFeel.UseWindowsXPTheme = True
      Me.Grid.MainView = Me.gResult
      Me.Grid.Name = "Grid"
      Me.Grid.Size = New System.Drawing.Size(534, 332)
      Me.Grid.TabIndex = 16
      Me.Grid.UseEmbeddedNavigator = True
      Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gResult})
      '
      'gResult
      '
      Me.gResult.GridControl = Me.Grid
      Me.gResult.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
      Me.gResult.Name = "gResult"
      Me.gResult.OptionsMenu.EnableColumnMenu = False
      Me.gResult.OptionsView.ColumnAutoWidth = False
      Me.gResult.OptionsView.ShowGroupPanel = False
      Me.gResult.PaintStyleName = "WindowsXP"
      Me.gResult.RowHeight = 19
      '
      'cmdExportar
      '
      Me.cmdExportar.Location = New System.Drawing.Point(5, 391)
      Me.cmdExportar.Name = "cmdExportar"
      Me.cmdExportar.Size = New System.Drawing.Size(79, 21)
      Me.cmdExportar.TabIndex = 17
      Me.cmdExportar.Text = "&Exportar"
      Me.cmdExportar.UseVisualStyleBackColor = True
      '
      'cmdImprimir
      '
      Me.cmdImprimir.Location = New System.Drawing.Point(90, 391)
      Me.cmdImprimir.Name = "cmdImprimir"
      Me.cmdImprimir.Size = New System.Drawing.Size(79, 21)
      Me.cmdImprimir.TabIndex = 18
      Me.cmdImprimir.Text = "&Imprimir"
      Me.cmdImprimir.UseVisualStyleBackColor = True
      '
      'frmGrilla
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.OK_Button
      Me.ClientSize = New System.Drawing.Size(545, 419)
      Me.Controls.Add(Me.cmdImprimir)
      Me.Controls.Add(Me.cmdExportar)
      Me.Controls.Add(Me.Grid)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmGrilla"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Cuentas sin relación"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.gResult, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents OK_Button As System.Windows.Forms.Button
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
   Friend WithEvents gResult As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents cmdExportar As System.Windows.Forms.Button
   Friend WithEvents cmdImprimir As System.Windows.Forms.Button

End Class
