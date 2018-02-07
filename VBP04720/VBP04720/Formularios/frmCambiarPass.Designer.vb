<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarPass
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
   Friend WithEvents PasswordLabel As System.Windows.Forms.Label
   Friend WithEvents txtActual As System.Windows.Forms.TextBox
   Friend WithEvents OK As System.Windows.Forms.Button
   Friend WithEvents Cancel As System.Windows.Forms.Button

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.  
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarPass))
      Me.PasswordLabel = New System.Windows.Forms.Label
      Me.txtActual = New System.Windows.Forms.TextBox
      Me.OK = New System.Windows.Forms.Button
      Me.Cancel = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.lblUsuario = New System.Windows.Forms.Label
      Me.lblDescripcion = New System.Windows.Forms.Label
      Me.txtNueva = New System.Windows.Forms.TextBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtConfirmacion = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'PasswordLabel
      '
      Me.PasswordLabel.AutoSize = True
      Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.PasswordLabel.Location = New System.Drawing.Point(12, 113)
      Me.PasswordLabel.Name = "PasswordLabel"
      Me.PasswordLabel.Size = New System.Drawing.Size(114, 13)
      Me.PasswordLabel.TabIndex = 2
      Me.PasswordLabel.Text = "Contraseña &actual:"
      Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'txtActual
      '
      Me.txtActual.Location = New System.Drawing.Point(174, 110)
      Me.txtActual.Name = "txtActual"
      Me.txtActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtActual.Size = New System.Drawing.Size(220, 20)
      Me.txtActual.TabIndex = 0
      '
      'OK
      '
      Me.OK.Location = New System.Drawing.Point(197, 193)
      Me.OK.Name = "OK"
      Me.OK.Size = New System.Drawing.Size(94, 23)
      Me.OK.TabIndex = 3
      Me.OK.Text = "&Aceptar"
      '
      'Cancel
      '
      Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Cancel.Location = New System.Drawing.Point(300, 193)
      Me.Cancel.Name = "Cancel"
      Me.Cancel.Size = New System.Drawing.Size(94, 23)
      Me.Cancel.TabIndex = 4
      Me.Cancel.Text = "&Cancelar"
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
      Me.panTop.Size = New System.Drawing.Size(401, 45)
      Me.panTop.TabIndex = 16
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(346, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 13, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(55, 45)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(21, 23)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(258, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Proporcione la nueva contraseña y su confirmación..."
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(121, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Cambiar contraseña"
      '
      'lblUsuario
      '
      Me.lblUsuario.AutoSize = True
      Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblUsuario.Location = New System.Drawing.Point(12, 59)
      Me.lblUsuario.Name = "lblUsuario"
      Me.lblUsuario.Size = New System.Drawing.Size(54, 13)
      Me.lblUsuario.TabIndex = 17
      Me.lblUsuario.Text = "Usuario:"
      '
      'lblDescripcion
      '
      Me.lblDescripcion.AutoSize = True
      Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescripcion.Location = New System.Drawing.Point(12, 83)
      Me.lblDescripcion.Name = "lblDescripcion"
      Me.lblDescripcion.Size = New System.Drawing.Size(54, 13)
      Me.lblDescripcion.TabIndex = 18
      Me.lblDescripcion.Text = "Nombre:"
      '
      'txtNueva
      '
      Me.txtNueva.Location = New System.Drawing.Point(174, 136)
      Me.txtNueva.Name = "txtNueva"
      Me.txtNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtNueva.Size = New System.Drawing.Size(220, 20)
      Me.txtNueva.TabIndex = 1
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(12, 139)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(97, 13)
      Me.Label1.TabIndex = 19
      Me.Label1.Text = "Contraseña &nueva:"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'txtConfirmacion
      '
      Me.txtConfirmacion.Location = New System.Drawing.Point(174, 162)
      Me.txtConfirmacion.Name = "txtConfirmacion"
      Me.txtConfirmacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtConfirmacion.Size = New System.Drawing.Size(220, 20)
      Me.txtConfirmacion.TabIndex = 2
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(12, 165)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(71, 13)
      Me.Label2.TabIndex = 21
      Me.Label2.Text = "&Confirmación:"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'frmCambiarPass
      '
      Me.AcceptButton = Me.OK
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel
      Me.ClientSize = New System.Drawing.Size(401, 224)
      Me.Controls.Add(Me.txtConfirmacion)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.txtNueva)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.lblDescripcion)
      Me.Controls.Add(Me.lblUsuario)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.Cancel)
      Me.Controls.Add(Me.OK)
      Me.Controls.Add(Me.txtActual)
      Me.Controls.Add(Me.PasswordLabel)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCambiarPass"
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Cambiar contraseña de usuario"
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents lblUsuario As System.Windows.Forms.Label
   Friend WithEvents lblDescripcion As System.Windows.Forms.Label
   Friend WithEvents txtNueva As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtConfirmacion As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
