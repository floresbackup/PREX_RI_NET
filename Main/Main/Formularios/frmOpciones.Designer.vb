<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpciones
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpciones))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.GroupBox1 = New System.Windows.Forms.GroupBox
      Me.optVarios = New System.Windows.Forms.RadioButton
      Me.optUno = New System.Windows.Forms.RadioButton
      Me.GroupBox2 = New System.Windows.Forms.GroupBox
      Me.chkConfirmarSalir = New System.Windows.Forms.CheckBox
      Me.chkSiempreIG = New System.Windows.Forms.CheckBox
      Me.chkInicioTray = New System.Windows.Forms.CheckBox
      Me.chkMinimizar = New System.Windows.Forms.CheckBox
      Me.TableLayoutPanel1.SuspendLayout()
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox1.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(281, 249)
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
      Me.panTop.Size = New System.Drawing.Size(435, 45)
      Me.panTop.TabIndex = 16
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(365, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(30, 10, 10, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(70, 45)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(21, 23)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(273, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Presione el botón Aceptar para guardar sus preferencias"
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 6)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(143, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Preferencias del usuario"
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.optVarios)
      Me.GroupBox1.Controls.Add(Me.optUno)
      Me.GroupBox1.Location = New System.Drawing.Point(9, 51)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(417, 70)
      Me.GroupBox1.TabIndex = 17
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Ejecución de programas"
      '
      'optVarios
      '
      Me.optVarios.AutoSize = True
      Me.optVarios.Location = New System.Drawing.Point(26, 43)
      Me.optVarios.Name = "optVarios"
      Me.optVarios.Size = New System.Drawing.Size(73, 17)
      Me.optVarios.TabIndex = 1
      Me.optVarios.TabStop = True
      Me.optVarios.Text = "Sin límites"
      Me.optVarios.UseVisualStyleBackColor = True
      '
      'optUno
      '
      Me.optUno.AutoSize = True
      Me.optUno.Location = New System.Drawing.Point(26, 20)
      Me.optUno.Name = "optUno"
      Me.optUno.Size = New System.Drawing.Size(181, 17)
      Me.optUno.TabIndex = 0
      Me.optUno.TabStop = True
      Me.optUno.Text = "De a uno por vez (recomendado)"
      Me.optUno.UseVisualStyleBackColor = True
      '
      'GroupBox2
      '
      Me.GroupBox2.Controls.Add(Me.chkConfirmarSalir)
      Me.GroupBox2.Controls.Add(Me.chkSiempreIG)
      Me.GroupBox2.Controls.Add(Me.chkInicioTray)
      Me.GroupBox2.Controls.Add(Me.chkMinimizar)
      Me.GroupBox2.Location = New System.Drawing.Point(9, 127)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(417, 116)
      Me.GroupBox2.TabIndex = 18
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Otras opciones"
      '
      'chkConfirmarSalir
      '
      Me.chkConfirmarSalir.AutoSize = True
      Me.chkConfirmarSalir.Location = New System.Drawing.Point(26, 91)
      Me.chkConfirmarSalir.Name = "chkConfirmarSalir"
      Me.chkConfirmarSalir.Size = New System.Drawing.Size(191, 17)
      Me.chkConfirmarSalir.TabIndex = 3
      Me.chkConfirmarSalir.Text = "&Solicitar confirmación antes de salir"
      Me.chkConfirmarSalir.UseVisualStyleBackColor = True
      '
      'chkSiempreIG
      '
      Me.chkSiempreIG.AutoSize = True
      Me.chkSiempreIG.Location = New System.Drawing.Point(26, 67)
      Me.chkSiempreIG.Name = "chkSiempreIG"
      Me.chkSiempreIG.Size = New System.Drawing.Size(268, 17)
      Me.chkSiempreIG.TabIndex = 2
      Me.chkSiempreIG.Text = "&Utilizar siempre iconos grandes en el menú principal"
      Me.chkSiempreIG.UseVisualStyleBackColor = True
      '
      'chkInicioTray
      '
      Me.chkInicioTray.AutoSize = True
      Me.chkInicioTray.Location = New System.Drawing.Point(26, 43)
      Me.chkInicioTray.Name = "chkInicioTray"
      Me.chkInicioTray.Size = New System.Drawing.Size(230, 17)
      Me.chkInicioTray.TabIndex = 1
      Me.chkInicioTray.Text = "&Iniciar minimizado en el área de notificación"
      Me.chkInicioTray.UseVisualStyleBackColor = True
      '
      'chkMinimizar
      '
      Me.chkMinimizar.AutoSize = True
      Me.chkMinimizar.Location = New System.Drawing.Point(26, 19)
      Me.chkMinimizar.Name = "chkMinimizar"
      Me.chkMinimizar.Size = New System.Drawing.Size(262, 17)
      Me.chkMinimizar.TabIndex = 0
      Me.chkMinimizar.Text = "&Minimizar al área de notificación en lugar de cerrar"
      Me.chkMinimizar.UseVisualStyleBackColor = True
      '
      'frmOpciones
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(435, 284)
      Me.Controls.Add(Me.GroupBox2)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmOpciones"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Preferencias del usuario"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents OK_Button As System.Windows.Forms.Button
   Friend WithEvents Cancel_Button As System.Windows.Forms.Button
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents optVarios As System.Windows.Forms.RadioButton
   Friend WithEvents optUno As System.Windows.Forms.RadioButton
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents chkConfirmarSalir As System.Windows.Forms.CheckBox
   Friend WithEvents chkSiempreIG As System.Windows.Forms.CheckBox
   Friend WithEvents chkInicioTray As System.Windows.Forms.CheckBox
   Friend WithEvents chkMinimizar As System.Windows.Forms.CheckBox

End Class
