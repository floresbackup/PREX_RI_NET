<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmDirSeg
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmDirSeg))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtNombre = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtDIASRE = New System.Windows.Forms.TextBox
      Me.txtDIASVT = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtCANTPC = New System.Windows.Forms.TextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.txtINTBLO = New System.Windows.Forms.TextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtPASCAR = New System.Windows.Forms.TextBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtPASNUM = New System.Windows.Forms.TextBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtPASESP = New System.Windows.Forms.TextBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtMININA = New System.Windows.Forms.TextBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.chkSeguridadNT = New System.Windows.Forms.CheckBox
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(257, 340)
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
      Me.panTop.Size = New System.Drawing.Size(409, 45)
      Me.panTop.TabIndex = 17
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(21, 23)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(178, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Complete los campos para continuar"
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(140, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Directivas de seguridad"
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(345, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 7, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(64, 45)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(7, 53)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(139, 13)
      Me.Label1.TabIndex = 18
      Me.Label1.Text = "Nombre de la directiva:"
      '
      'txtNombre
      '
      Me.txtNombre.Location = New System.Drawing.Point(10, 69)
      Me.txtNombre.Name = "txtNombre"
      Me.txtNombre.Size = New System.Drawing.Size(389, 20)
      Me.txtNombre.TabIndex = 19
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(12, 103)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(243, 13)
      Me.Label2.TabIndex = 20
      Me.Label2.Text = "Cantidad de días para permitir el cambio de clave:"
      '
      'txtDIASRE
      '
      Me.txtDIASRE.Location = New System.Drawing.Point(299, 100)
      Me.txtDIASRE.Name = "txtDIASRE"
      Me.txtDIASRE.Size = New System.Drawing.Size(100, 20)
      Me.txtDIASRE.TabIndex = 21
      '
      'txtDIASVT
      '
      Me.txtDIASVT.Location = New System.Drawing.Point(299, 126)
      Me.txtDIASVT.Name = "txtDIASVT"
      Me.txtDIASVT.Size = New System.Drawing.Size(100, 20)
      Me.txtDIASVT.TabIndex = 23
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(12, 129)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(241, 13)
      Me.Label3.TabIndex = 22
      Me.Label3.Text = "Cantidad de días para el vencimiento de la clave:"
      '
      'txtCANTPC
      '
      Me.txtCANTPC.Location = New System.Drawing.Point(299, 152)
      Me.txtCANTPC.Name = "txtCANTPC"
      Me.txtCANTPC.Size = New System.Drawing.Size(100, 20)
      Me.txtCANTPC.TabIndex = 25
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(12, 155)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(247, 13)
      Me.Label4.TabIndex = 24
      Me.Label4.Text = "Cantidad de claves recordadas para no duplicidad:"
      '
      'txtINTBLO
      '
      Me.txtINTBLO.Location = New System.Drawing.Point(299, 178)
      Me.txtINTBLO.Name = "txtINTBLO"
      Me.txtINTBLO.Size = New System.Drawing.Size(100, 20)
      Me.txtINTBLO.TabIndex = 27
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(12, 181)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(278, 13)
      Me.Label5.TabIndex = 26
      Me.Label5.Text = "Cantidad de intentos fallidos antes de bloquear al usuario:"
      '
      'txtPASCAR
      '
      Me.txtPASCAR.Location = New System.Drawing.Point(299, 204)
      Me.txtPASCAR.Name = "txtPASCAR"
      Me.txtPASCAR.Size = New System.Drawing.Size(100, 20)
      Me.txtPASCAR.TabIndex = 29
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(12, 207)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(280, 13)
      Me.Label6.TabIndex = 28
      Me.Label6.Text = "Cantidad mín. de caracteres alfabéticos en la contraseña:"
      '
      'txtPASNUM
      '
      Me.txtPASNUM.Location = New System.Drawing.Point(299, 230)
      Me.txtPASNUM.Name = "txtPASNUM"
      Me.txtPASNUM.Size = New System.Drawing.Size(100, 20)
      Me.txtPASNUM.TabIndex = 31
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(12, 233)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(277, 13)
      Me.Label7.TabIndex = 30
      Me.Label7.Text = "Cantidad mín. de caracteres numéricos en la contraseña:"
      '
      'txtPASESP
      '
      Me.txtPASESP.Location = New System.Drawing.Point(299, 256)
      Me.txtPASESP.Name = "txtPASESP"
      Me.txtPASESP.Size = New System.Drawing.Size(100, 20)
      Me.txtPASESP.TabIndex = 33
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Location = New System.Drawing.Point(12, 259)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(279, 13)
      Me.Label8.TabIndex = 32
      Me.Label8.Text = "Cantidad mín. de caracteres especiales en la contraseña:"
      '
      'txtMININA
      '
      Me.txtMININA.Location = New System.Drawing.Point(299, 282)
      Me.txtMININA.Name = "txtMININA"
      Me.txtMININA.Size = New System.Drawing.Size(100, 20)
      Me.txtMININA.TabIndex = 35
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(12, 285)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(280, 13)
      Me.Label9.TabIndex = 34
      Me.Label9.Text = "Minutos de inactividad permitidos antes de bloquear term.:"
      '
      'chkSeguridadNT
      '
      Me.chkSeguridadNT.AutoSize = True
      Me.chkSeguridadNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSeguridadNT.Location = New System.Drawing.Point(15, 313)
      Me.chkSeguridadNT.Name = "chkSeguridadNT"
      Me.chkSeguridadNT.Size = New System.Drawing.Size(356, 17)
      Me.chkSeguridadNT.TabIndex = 36
      Me.chkSeguridadNT.Text = "Validar contraseñas con el dominio de Windows NT/2000:"
      Me.chkSeguridadNT.UseVisualStyleBackColor = True
      '
      'frmAbmDirSeg
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(409, 374)
      Me.Controls.Add(Me.chkSeguridadNT)
      Me.Controls.Add(Me.txtMININA)
      Me.Controls.Add(Me.Label9)
      Me.Controls.Add(Me.txtPASESP)
      Me.Controls.Add(Me.Label8)
      Me.Controls.Add(Me.txtPASNUM)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.txtPASCAR)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.txtINTBLO)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.txtCANTPC)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.txtDIASVT)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtDIASRE)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.txtNombre)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmAbmDirSeg"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Directivas de seguridad"
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
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtDIASRE As System.Windows.Forms.TextBox
   Friend WithEvents txtDIASVT As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtCANTPC As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtINTBLO As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtPASCAR As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtPASNUM As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtPASESP As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtMININA As System.Windows.Forms.TextBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents chkSeguridadNT As System.Windows.Forms.CheckBox

End Class
