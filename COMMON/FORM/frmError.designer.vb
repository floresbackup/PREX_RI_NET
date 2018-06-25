<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmError
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmError))
      Me.txtDescripcion = New System.Windows.Forms.RichTextBox
      Me.lnkMail = New System.Windows.Forms.LinkLabel
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtHora = New System.Windows.Forms.Label
      Me.txtFecha = New System.Windows.Forms.Label
      Me.txtOrigen = New System.Windows.Forms.Label
      Me.txtCodigo = New System.Windows.Forms.Label
      Me.txtFuncion = New System.Windows.Forms.Label
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.OK_Button = New System.Windows.Forms.Button
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'txtDescripcion
      '
      Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDescripcion.Location = New System.Drawing.Point(12, 162)
      Me.txtDescripcion.Name = "txtDescripcion"
      Me.txtDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
      Me.txtDescripcion.Size = New System.Drawing.Size(497, 121)
      Me.txtDescripcion.TabIndex = 1
      Me.txtDescripcion.Text = ""
      '
      'lnkMail
      '
      Me.lnkMail.AutoSize = True
      Me.lnkMail.BackColor = System.Drawing.Color.Transparent
      Me.lnkMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lnkMail.LinkColor = System.Drawing.SystemColors.HotTrack
      Me.lnkMail.Location = New System.Drawing.Point(9, 298)
      Me.lnkMail.Name = "lnkMail"
      Me.lnkMail.Size = New System.Drawing.Size(210, 13)
      Me.lnkMail.TabIndex = 4
      Me.lnkMail.TabStop = True
        Me.lnkMail.Text = "Enviar un informe por correo electrónico"
        Me.lnkMail.VisitedLinkColor = System.Drawing.Color.DarkGreen
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
      Me.Label3.Location = New System.Drawing.Point(12, 54)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(44, 13)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "Código:"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
      Me.Label4.Location = New System.Drawing.Point(12, 74)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(43, 13)
      Me.Label4.TabIndex = 6
      Me.Label4.Text = "Orígen:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
      Me.Label5.Location = New System.Drawing.Point(12, 94)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(48, 13)
      Me.Label5.TabIndex = 7
      Me.Label5.Text = "Función:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
      Me.Label6.Location = New System.Drawing.Point(12, 114)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(40, 13)
      Me.Label6.TabIndex = 8
      Me.Label6.Text = "Fecha:"
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
      Me.Label7.Location = New System.Drawing.Point(12, 134)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(34, 13)
      Me.Label7.TabIndex = 9
      Me.Label7.Text = "Hora:"
      '
      'txtHora
      '
      Me.txtHora.AutoSize = True
      Me.txtHora.BackColor = System.Drawing.Color.Transparent
      Me.txtHora.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtHora.ForeColor = System.Drawing.SystemColors.ControlText
      Me.txtHora.Location = New System.Drawing.Point(73, 134)
      Me.txtHora.Name = "txtHora"
      Me.txtHora.Size = New System.Drawing.Size(0, 13)
      Me.txtHora.TabIndex = 14
      Me.txtHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'txtFecha
      '
      Me.txtFecha.AutoSize = True
      Me.txtFecha.BackColor = System.Drawing.Color.Transparent
      Me.txtFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFecha.ForeColor = System.Drawing.SystemColors.ControlText
      Me.txtFecha.Location = New System.Drawing.Point(73, 114)
      Me.txtFecha.Name = "txtFecha"
      Me.txtFecha.Size = New System.Drawing.Size(0, 13)
      Me.txtFecha.TabIndex = 13
      Me.txtFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'txtOrigen
      '
      Me.txtOrigen.AutoSize = True
      Me.txtOrigen.BackColor = System.Drawing.Color.Transparent
      Me.txtOrigen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtOrigen.ForeColor = System.Drawing.SystemColors.ControlText
      Me.txtOrigen.Location = New System.Drawing.Point(73, 74)
      Me.txtOrigen.Name = "txtOrigen"
      Me.txtOrigen.Size = New System.Drawing.Size(0, 13)
      Me.txtOrigen.TabIndex = 11
      Me.txtOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'txtCodigo
      '
      Me.txtCodigo.AutoSize = True
      Me.txtCodigo.BackColor = System.Drawing.Color.Transparent
      Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlText
      Me.txtCodigo.Location = New System.Drawing.Point(73, 54)
      Me.txtCodigo.Name = "txtCodigo"
      Me.txtCodigo.Size = New System.Drawing.Size(0, 13)
      Me.txtCodigo.TabIndex = 10
      Me.txtCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'txtFuncion
      '
      Me.txtFuncion.AutoSize = True
      Me.txtFuncion.BackColor = System.Drawing.Color.Transparent
      Me.txtFuncion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFuncion.ForeColor = System.Drawing.SystemColors.ControlText
      Me.txtFuncion.Location = New System.Drawing.Point(73, 94)
      Me.txtFuncion.Name = "txtFuncion"
      Me.txtFuncion.Size = New System.Drawing.Size(0, 13)
      Me.txtFuncion.TabIndex = 12
      Me.txtFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
      Me.panTop.Size = New System.Drawing.Size(521, 45)
      Me.panTop.TabIndex = 15
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(451, 0)
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
      Me.lblSubtitulo.Size = New System.Drawing.Size(217, 13)
      Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Presione el botón Aceptar para volver atrás"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(104, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Error del Sistema"
      '
      'OK_Button
      '
      Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.OK_Button.BackColor = System.Drawing.SystemColors.Control
      Me.OK_Button.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.OK_Button.Location = New System.Drawing.Point(421, 293)
      Me.OK_Button.Name = "OK_Button"
      Me.OK_Button.Size = New System.Drawing.Size(88, 23)
      Me.OK_Button.TabIndex = 16
      Me.OK_Button.Text = "Aceptar"
      Me.OK_Button.UseVisualStyleBackColor = False
      '
      'frmError
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(521, 325)
      Me.Controls.Add(Me.OK_Button)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.txtHora)
      Me.Controls.Add(Me.txtFecha)
      Me.Controls.Add(Me.txtFuncion)
      Me.Controls.Add(Me.txtOrigen)
      Me.Controls.Add(Me.txtCodigo)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.lnkMail)
      Me.Controls.Add(Me.txtDescripcion)
      Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmError"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Error"
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
   Friend WithEvents lnkMail As System.Windows.Forms.LinkLabel
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtHora As System.Windows.Forms.Label
   Friend WithEvents txtFecha As System.Windows.Forms.Label
   Friend WithEvents txtOrigen As System.Windows.Forms.Label
   Friend WithEvents txtCodigo As System.Windows.Forms.Label
   Friend WithEvents txtFuncion As System.Windows.Forms.Label
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents OK_Button As System.Windows.Forms.Button

End Class
