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
      Me.txtDescripcion = New System.Windows.Forms.RichTextBox
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
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
      Me.TableLayoutPanel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'txtDescripcion
      '
      Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDescripcion.Location = New System.Drawing.Point(12, 213)
      Me.txtDescripcion.Name = "txtDescripcion"
      Me.txtDescripcion.Size = New System.Drawing.Size(497, 121)
      Me.txtDescripcion.TabIndex = 1
      Me.txtDescripcion.Text = ""
      '
      'TableLayoutPanel1
      '
      Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
      Me.TableLayoutPanel1.ColumnCount = 2
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
      Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(348, 340)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 1
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(161, 29)
      Me.TableLayoutPanel1.TabIndex = 0
      '
      'OK_Button
      '
      Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.OK_Button.BackColor = System.Drawing.SystemColors.Control
      Me.OK_Button.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.OK_Button.Location = New System.Drawing.Point(3, 3)
      Me.OK_Button.Name = "OK_Button"
      Me.OK_Button.Size = New System.Drawing.Size(74, 23)
      Me.OK_Button.TabIndex = 0
      Me.OK_Button.Text = "Aceptar"
      Me.OK_Button.UseVisualStyleBackColor = False
      '
      'Cancel_Button
      '
      Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Cancel_Button.BackColor = System.Drawing.SystemColors.Control
      Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Cancel_Button.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Cancel_Button.Location = New System.Drawing.Point(83, 3)
      Me.Cancel_Button.Name = "Cancel_Button"
      Me.Cancel_Button.Size = New System.Drawing.Size(74, 23)
      Me.Cancel_Button.TabIndex = 1
      Me.Cancel_Button.Text = "Cancelar"
      Me.Cancel_Button.UseVisualStyleBackColor = False
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.Label1.Location = New System.Drawing.Point(191, 19)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(119, 16)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Error del Sistema"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.Label2.Location = New System.Drawing.Point(191, 44)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(217, 13)
      Me.Label2.TabIndex = 3
      Me.Label2.Text = "Precione el botón Aceptar para volver atrás"
      '
      'lnkMail
      '
      Me.lnkMail.AutoSize = True
      Me.lnkMail.BackColor = System.Drawing.Color.Transparent
      Me.lnkMail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lnkMail.LinkColor = System.Drawing.Color.DarkGreen
      Me.lnkMail.Location = New System.Drawing.Point(9, 353)
      Me.lnkMail.Name = "lnkMail"
      Me.lnkMail.Size = New System.Drawing.Size(210, 13)
      Me.lnkMail.TabIndex = 4
      Me.lnkMail.TabStop = True
      Me.lnkMail.Text = "Enviar un informe por correo elecectrónico"
      Me.lnkMail.VisitedLinkColor = System.Drawing.Color.DarkGreen
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.Label3.Location = New System.Drawing.Point(12, 105)
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
      Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.Label4.Location = New System.Drawing.Point(12, 125)
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
      Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.Label5.Location = New System.Drawing.Point(12, 145)
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
      Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.Label6.Location = New System.Drawing.Point(12, 165)
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
      Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.Label7.Location = New System.Drawing.Point(12, 185)
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
      Me.txtHora.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.txtHora.Location = New System.Drawing.Point(73, 185)
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
      Me.txtFecha.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.txtFecha.Location = New System.Drawing.Point(73, 165)
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
      Me.txtOrigen.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.txtOrigen.Location = New System.Drawing.Point(73, 125)
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
      Me.txtCodigo.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.txtCodigo.Location = New System.Drawing.Point(73, 105)
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
      Me.txtFuncion.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.txtFuncion.Location = New System.Drawing.Point(73, 145)
      Me.txtFuncion.Name = "txtFuncion"
      Me.txtFuncion.Size = New System.Drawing.Size(0, 13)
      Me.txtFuncion.TabIndex = 12
      Me.txtFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'frmError
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackgroundImage = Global.VBP04296.My.Resources.Resources.dialog2
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(521, 378)
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
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.txtDescripcion)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmError"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Error"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents OK_Button As System.Windows.Forms.Button
   Friend WithEvents Cancel_Button As System.Windows.Forms.Button
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
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

End Class
