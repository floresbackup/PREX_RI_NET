<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaccion
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaccion))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.tabPerfiles = New System.Windows.Forms.TabPage
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.cmdCarpeta = New System.Windows.Forms.Button
      Me.txtCarpeta = New System.Windows.Forms.TextBox
      Me.txtCodigo = New System.Windows.Forms.TextBox
      Me.txtNombre = New System.Windows.Forms.TextBox
      Me.txtPrograma = New System.Windows.Forms.TextBox
      Me.txtDescripcion = New System.Windows.Forms.TextBox
      Me.lvPerfiles = New System.Windows.Forms.ListView
      Me.TableLayoutPanel1.SuspendLayout()
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.tabPerfiles.SuspendLayout()
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(310, 284)
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
      Me.OK_Button.TabIndex = 0
      Me.OK_Button.Text = "Aceptar"
      '
      'Cancel_Button
      '
      Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
      Me.Cancel_Button.Name = "Cancel_Button"
      Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
      Me.Cancel_Button.TabIndex = 1
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
      Me.panTop.Size = New System.Drawing.Size(463, 45)
      Me.panTop.TabIndex = 18
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(21, 23)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(311, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Proporcione los datos de la transacción y haga clic en Aceptar..."
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(128, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Datos de Transacción"
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(402, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(61, 45)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Controls.Add(Me.tabPerfiles)
      Me.TabControl1.Location = New System.Drawing.Point(11, 51)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(442, 226)
      Me.TabControl1.TabIndex = 19
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.txtDescripcion)
      Me.TabPage1.Controls.Add(Me.txtPrograma)
      Me.TabPage1.Controls.Add(Me.txtNombre)
      Me.TabPage1.Controls.Add(Me.txtCodigo)
      Me.TabPage1.Controls.Add(Me.cmdCarpeta)
      Me.TabPage1.Controls.Add(Me.txtCarpeta)
      Me.TabPage1.Controls.Add(Me.Label5)
      Me.TabPage1.Controls.Add(Me.Label4)
      Me.TabPage1.Controls.Add(Me.Label3)
      Me.TabPage1.Controls.Add(Me.Label2)
      Me.TabPage1.Controls.Add(Me.Label1)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(434, 200)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Datos de la transacción"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'tabPerfiles
      '
      Me.tabPerfiles.Controls.Add(Me.lvPerfiles)
      Me.tabPerfiles.Location = New System.Drawing.Point(4, 22)
      Me.tabPerfiles.Name = "tabPerfiles"
      Me.tabPerfiles.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPerfiles.Size = New System.Drawing.Size(434, 200)
      Me.tabPerfiles.TabIndex = 1
      Me.tabPerfiles.Text = "Perfiles"
      Me.tabPerfiles.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(6, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(116, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Código de transacción:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(6, 34)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(47, 13)
      Me.Label2.TabIndex = 1
      Me.Label2.Text = "Nombre:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(6, 56)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(116, 13)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "Nombre del ejecutable:"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(6, 78)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(95, 13)
      Me.Label4.TabIndex = 3
      Me.Label4.Text = "Ubicar en carpeta:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(6, 100)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(66, 13)
      Me.Label5.TabIndex = 4
      Me.Label5.Text = "Descripción:"
      '
      'cmdCarpeta
      '
      Me.cmdCarpeta.Image = CType(resources.GetObject("cmdCarpeta.Image"), System.Drawing.Image)
      Me.cmdCarpeta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.cmdCarpeta.Location = New System.Drawing.Point(393, 75)
      Me.cmdCarpeta.Name = "cmdCarpeta"
      Me.cmdCarpeta.Size = New System.Drawing.Size(30, 20)
      Me.cmdCarpeta.TabIndex = 3
      Me.cmdCarpeta.UseVisualStyleBackColor = True
      '
      'txtCarpeta
      '
      Me.txtCarpeta.Enabled = False
      Me.txtCarpeta.Location = New System.Drawing.Point(131, 75)
      Me.txtCarpeta.Name = "txtCarpeta"
      Me.txtCarpeta.Size = New System.Drawing.Size(258, 20)
      Me.txtCarpeta.TabIndex = 9999
      Me.txtCarpeta.TabStop = False
      '
      'txtCodigo
      '
      Me.txtCodigo.Location = New System.Drawing.Point(131, 9)
      Me.txtCodigo.Name = "txtCodigo"
      Me.txtCodigo.Size = New System.Drawing.Size(292, 20)
      Me.txtCodigo.TabIndex = 0
      '
      'txtNombre
      '
      Me.txtNombre.Location = New System.Drawing.Point(131, 31)
      Me.txtNombre.Name = "txtNombre"
      Me.txtNombre.Size = New System.Drawing.Size(292, 20)
      Me.txtNombre.TabIndex = 1
      '
      'txtPrograma
      '
      Me.txtPrograma.Location = New System.Drawing.Point(131, 53)
      Me.txtPrograma.Name = "txtPrograma"
      Me.txtPrograma.Size = New System.Drawing.Size(292, 20)
      Me.txtPrograma.TabIndex = 2
      '
      'txtDescripcion
      '
      Me.txtDescripcion.Location = New System.Drawing.Point(131, 97)
      Me.txtDescripcion.Multiline = True
      Me.txtDescripcion.Name = "txtDescripcion"
      Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtDescripcion.Size = New System.Drawing.Size(292, 97)
      Me.txtDescripcion.TabIndex = 5
      '
      'lvPerfiles
      '
      Me.lvPerfiles.CheckBoxes = True
      Me.lvPerfiles.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvPerfiles.Location = New System.Drawing.Point(3, 3)
      Me.lvPerfiles.Name = "lvPerfiles"
      Me.lvPerfiles.Size = New System.Drawing.Size(428, 194)
      Me.lvPerfiles.TabIndex = 0
      Me.lvPerfiles.UseCompatibleStateImageBehavior = False
      Me.lvPerfiles.View = System.Windows.Forms.View.List
      '
      'frmTransaccion
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(463, 320)
      Me.Controls.Add(Me.TabControl1)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmTransaccion"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Transacción"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.tabPerfiles.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
   Friend WithEvents Cancel_Button As System.Windows.Forms.Button
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents tabPerfiles As System.Windows.Forms.TabPage
   Friend WithEvents cmdCarpeta As System.Windows.Forms.Button
   Friend WithEvents txtCarpeta As System.Windows.Forms.TextBox
   Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
   Friend WithEvents txtPrograma As System.Windows.Forms.TextBox
   Friend WithEvents txtNombre As System.Windows.Forms.TextBox
   Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
   Friend WithEvents lvPerfiles As System.Windows.Forms.ListView

End Class
