<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrigenDB
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
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.lblServer = New System.Windows.Forms.Label
      Me.Servidor = New System.Windows.Forms.TextBox
      Me.txtDB = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Pass = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Usuario = New System.Windows.Forms.TextBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.chkNT = New System.Windows.Forms.CheckBox
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(196, 199)
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
      Me.panTop.Size = New System.Drawing.Size(354, 45)
      Me.panTop.TabIndex = 3
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = Global.VBP04801.My.Resources.Resources.Database
      Me.PictureBox1.Location = New System.Drawing.Point(284, 0)
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
      Me.lblSubtitulo.Size = New System.Drawing.Size(142, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Indique los datos pertinentes"
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(10, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(68, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Origen SQL"
      '
      'lblServer
      '
      Me.lblServer.AutoSize = True
      Me.lblServer.Location = New System.Drawing.Point(10, 58)
      Me.lblServer.Name = "lblServer"
      Me.lblServer.Size = New System.Drawing.Size(49, 13)
      Me.lblServer.TabIndex = 4
      Me.lblServer.Text = "Servidor:"
      '
      'Servidor
      '
      Me.Servidor.Location = New System.Drawing.Point(96, 55)
      Me.Servidor.Name = "Servidor"
      Me.Servidor.Size = New System.Drawing.Size(246, 20)
      Me.Servidor.TabIndex = 5
      '
      'txtDB
      '
      Me.txtDB.Location = New System.Drawing.Point(96, 81)
      Me.txtDB.Name = "txtDB"
      Me.txtDB.Size = New System.Drawing.Size(246, 20)
      Me.txtDB.TabIndex = 7
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(10, 84)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(78, 13)
      Me.Label3.TabIndex = 6
      Me.Label3.Text = "Base de datos:"
      '
      'Pass
      '
      Me.Pass.Location = New System.Drawing.Point(96, 167)
      Me.Pass.Name = "Pass"
      Me.Pass.Size = New System.Drawing.Size(246, 20)
      Me.Pass.TabIndex = 11
      Me.Pass.UseSystemPasswordChar = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(10, 170)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(64, 13)
      Me.Label2.TabIndex = 10
      Me.Label2.Text = "Contraseña:"
      '
      'Usuario
      '
      Me.Usuario.Location = New System.Drawing.Point(96, 141)
      Me.Usuario.Name = "Usuario"
      Me.Usuario.Size = New System.Drawing.Size(246, 20)
      Me.Usuario.TabIndex = 9
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(10, 144)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(46, 13)
      Me.Label1.TabIndex = 8
      Me.Label1.Text = "Usuario:"
      '
      'chkNT
      '
      Me.chkNT.AutoSize = True
      Me.chkNT.Location = New System.Drawing.Point(96, 107)
      Me.chkNT.Name = "chkNT"
      Me.chkNT.Size = New System.Drawing.Size(235, 17)
      Me.chkNT.TabIndex = 12
      Me.chkNT.Text = "&Usar la seguridad integrada de Windows NT"
      Me.chkNT.UseVisualStyleBackColor = True
      '
      'frmOrigenDB
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(354, 240)
      Me.Controls.Add(Me.chkNT)
      Me.Controls.Add(Me.Pass)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Usuario)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.txtDB)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Servidor)
      Me.Controls.Add(Me.lblServer)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmOrigenDB"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Origen de datos"
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
   Friend WithEvents lblServer As System.Windows.Forms.Label
   Friend WithEvents Servidor As System.Windows.Forms.TextBox
   Friend WithEvents txtDB As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Pass As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Usuario As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents chkNT As System.Windows.Forms.CheckBox

End Class
