<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarpeta
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarpeta))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtNombre = New System.Windows.Forms.TextBox
      Me.txtCarpeta = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cmdCarpeta = New System.Windows.Forms.Button
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.TableLayoutPanel1.SuspendLayout()
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'TableLayoutPanel1
      '
      Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TableLayoutPanel1.ColumnCount = 2
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
      Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 127)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 1
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
      Me.TableLayoutPanel1.TabIndex = 0
      '
      'OK_Button
      '
      Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.OK_Button.Location = New System.Drawing.Point(3, 3)
      Me.OK_Button.Name = "OK_Button"
      Me.OK_Button.Size = New System.Drawing.Size(67, 23)
      Me.OK_Button.TabIndex = 2
      Me.OK_Button.Text = "Aceptar"
      '
      'Cancel_Button
      '
      Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
      Me.Cancel_Button.Name = "Cancel_Button"
      Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
      Me.Cancel_Button.TabIndex = 3
      Me.Cancel_Button.Text = "Cancelar"
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
      Me.panTop.Size = New System.Drawing.Size(435, 45)
      Me.panTop.TabIndex = 17
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(21, 23)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(174, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Proporcione los datos de la carpeta"
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(90, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Nueva Carpeta"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(12, 69)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(47, 13)
      Me.Label1.TabIndex = 18
      Me.Label1.Text = "Nombre:"
      '
      'txtNombre
      '
      Me.txtNombre.Location = New System.Drawing.Point(113, 66)
      Me.txtNombre.Name = "txtNombre"
      Me.txtNombre.Size = New System.Drawing.Size(307, 20)
      Me.txtNombre.TabIndex = 0
      '
      'txtCarpeta
      '
      Me.txtCarpeta.Enabled = False
      Me.txtCarpeta.Location = New System.Drawing.Point(113, 94)
      Me.txtCarpeta.Name = "txtCarpeta"
      Me.txtCarpeta.Size = New System.Drawing.Size(271, 20)
      Me.txtCarpeta.TabIndex = 1
      Me.txtCarpeta.TabStop = False
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(12, 97)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(95, 13)
      Me.Label2.TabIndex = 20
      Me.Label2.Text = "Ubicar en carpeta:"
      '
      'cmdCarpeta
      '
      Me.cmdCarpeta.Image = CType(resources.GetObject("cmdCarpeta.Image"), System.Drawing.Image)
      Me.cmdCarpeta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.cmdCarpeta.Location = New System.Drawing.Point(390, 94)
      Me.cmdCarpeta.Name = "cmdCarpeta"
      Me.cmdCarpeta.Size = New System.Drawing.Size(30, 20)
      Me.cmdCarpeta.TabIndex = 1
      Me.cmdCarpeta.UseVisualStyleBackColor = True
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(374, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(61, 45)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'frmCarpeta
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(435, 168)
      Me.Controls.Add(Me.cmdCarpeta)
      Me.Controls.Add(Me.txtCarpeta)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.txtNombre)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCarpeta"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Carpeta"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents OK_Button As System.Windows.Forms.Button
   Friend WithEvents Cancel_Button As System.Windows.Forms.Button
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtNombre As System.Windows.Forms.TextBox
   Friend WithEvents txtCarpeta As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmdCarpeta As System.Windows.Forms.Button

End Class
