<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMPartida
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMPartida))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtDCorta = New System.Windows.Forms.TextBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.cboActiva = New System.Windows.Forms.ComboBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboMonFij = New System.Windows.Forms.ComboBox
      Me.txtOrden = New System.Windows.Forms.TextBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.fecFecVig = New System.Windows.Forms.DateTimePicker
      Me.cboEntidad = New System.Windows.Forms.ComboBox
      Me.cboCuadro = New System.Windows.Forms.ComboBox
      Me.cboCampo8 = New System.Windows.Forms.ComboBox
      Me.txtDescri = New System.Windows.Forms.TextBox
      Me.cboCreoRend = New System.Windows.Forms.ComboBox
      Me.txtOperacion = New System.Windows.Forms.TextBox
      Me.txtCodPar = New System.Windows.Forms.TextBox
      Me.txtNivel = New System.Windows.Forms.TextBox
      Me.txtRelativo = New System.Windows.Forms.TextBox
      Me.txtIndex = New System.Windows.Forms.TextBox
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(292, 377)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 1
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
      Me.TableLayoutPanel1.TabIndex = 12
      '
      'OK_Button
      '
      Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.OK_Button.Location = New System.Drawing.Point(3, 3)
      Me.OK_Button.Name = "OK_Button"
      Me.OK_Button.Size = New System.Drawing.Size(67, 22)
      Me.OK_Button.TabIndex = 0
      Me.OK_Button.Text = "Aceptar"
      '
      'Cancel_Button
      '
      Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
      Me.Cancel_Button.Name = "Cancel_Button"
      Me.Cancel_Button.Size = New System.Drawing.Size(67, 22)
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
      Me.panTop.Size = New System.Drawing.Size(445, 51)
      Me.panTop.TabIndex = 1
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(375, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 15, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(70, 51)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(25, 29)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(232, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Detalle de las partidas habilitadas en el sistema"
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(133, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Estructura de partidas"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(10, 63)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(82, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Fecha vigencia:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(10, 89)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(47, 13)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "Entidad:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(10, 115)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(46, 13)
      Me.Label3.TabIndex = 6
      Me.Label3.Text = "Cuadro:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(10, 142)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(96, 13)
      Me.Label5.TabIndex = 10
      Me.Label5.Text = "Código de partida:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(10, 168)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(63, 13)
      Me.Label6.TabIndex = 12
      Me.Label6.Text = "Referencia:"
      '
      'txtDCorta
      '
      Me.txtDCorta.Location = New System.Drawing.Point(112, 246)
      Me.txtDCorta.MaxLength = 50
      Me.txtDCorta.Name = "txtDCorta"
      Me.txtDCorta.Size = New System.Drawing.Size(323, 21)
      Me.txtDCorta.TabIndex = 6
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(10, 249)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(93, 13)
      Me.Label7.TabIndex = 14
      Me.Label7.Text = "Descripción corta:"
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(10, 194)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(65, 13)
      Me.Label9.TabIndex = 19
      Me.Label9.Text = "Descripción:"
      '
      'cboActiva
      '
      Me.cboActiva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboActiva.FormattingEnabled = True
      Me.cboActiva.Location = New System.Drawing.Point(112, 272)
      Me.cboActiva.Name = "cboActiva"
      Me.cboActiva.Size = New System.Drawing.Size(323, 21)
      Me.cboActiva.TabIndex = 7
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(10, 327)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(59, 13)
      Me.Label4.TabIndex = 27
      Me.Label4.Text = "Monto fijo:"
      '
      'cboMonFij
      '
      Me.cboMonFij.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboMonFij.FormattingEnabled = True
      Me.cboMonFij.Location = New System.Drawing.Point(112, 324)
      Me.cboMonFij.Name = "cboMonFij"
      Me.cboMonFij.Size = New System.Drawing.Size(323, 21)
      Me.cboMonFij.TabIndex = 9
      '
      'txtOrden
      '
      Me.txtOrden.Location = New System.Drawing.Point(112, 350)
      Me.txtOrden.MaxLength = 10
      Me.txtOrden.Name = "txtOrden"
      Me.txtOrden.Size = New System.Drawing.Size(81, 21)
      Me.txtOrden.TabIndex = 10
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.Location = New System.Drawing.Point(10, 353)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(41, 13)
      Me.Label10.TabIndex = 24
      Me.Label10.Text = "Orden:"
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.Location = New System.Drawing.Point(10, 301)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(75, 13)
      Me.Label11.TabIndex = 22
      Me.Label11.Text = "Crec. o rend.:"
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.Location = New System.Drawing.Point(10, 275)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(41, 13)
      Me.Label12.TabIndex = 21
      Me.Label12.Text = "Activa:"
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.Location = New System.Drawing.Point(289, 353)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(60, 13)
      Me.Label13.TabIndex = 29
      Me.Label13.Text = "Operación:"
      '
      'fecFecVig
      '
      Me.fecFecVig.CustomFormat = "dd/MM/yyyy"
      Me.fecFecVig.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.fecFecVig.Location = New System.Drawing.Point(112, 59)
      Me.fecFecVig.Name = "fecFecVig"
      Me.fecFecVig.Size = New System.Drawing.Size(323, 21)
      Me.fecFecVig.TabIndex = 0
      '
      'cboEntidad
      '
      Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboEntidad.FormattingEnabled = True
      Me.cboEntidad.Location = New System.Drawing.Point(112, 86)
      Me.cboEntidad.Name = "cboEntidad"
      Me.cboEntidad.Size = New System.Drawing.Size(323, 21)
      Me.cboEntidad.TabIndex = 1
      '
      'cboCuadro
      '
      Me.cboCuadro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboCuadro.FormattingEnabled = True
      Me.cboCuadro.Location = New System.Drawing.Point(112, 112)
      Me.cboCuadro.Name = "cboCuadro"
      Me.cboCuadro.Size = New System.Drawing.Size(323, 21)
      Me.cboCuadro.TabIndex = 2
      '
      'cboCampo8
      '
      Me.cboCampo8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboCampo8.FormattingEnabled = True
      Me.cboCampo8.Location = New System.Drawing.Point(112, 165)
      Me.cboCampo8.Name = "cboCampo8"
      Me.cboCampo8.Size = New System.Drawing.Size(323, 21)
      Me.cboCampo8.TabIndex = 4
      '
      'txtDescri
      '
      Me.txtDescri.Location = New System.Drawing.Point(112, 191)
      Me.txtDescri.Multiline = True
      Me.txtDescri.Name = "txtDescri"
      Me.txtDescri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtDescri.Size = New System.Drawing.Size(323, 49)
      Me.txtDescri.TabIndex = 5
      '
      'cboCreoRend
      '
      Me.cboCreoRend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboCreoRend.FormattingEnabled = True
      Me.cboCreoRend.Location = New System.Drawing.Point(112, 298)
      Me.cboCreoRend.Name = "cboCreoRend"
      Me.cboCreoRend.Size = New System.Drawing.Size(323, 21)
      Me.cboCreoRend.TabIndex = 8
      '
      'txtOperacion
      '
      Me.txtOperacion.Location = New System.Drawing.Point(368, 350)
      Me.txtOperacion.MaxLength = 10
      Me.txtOperacion.Name = "txtOperacion"
      Me.txtOperacion.Size = New System.Drawing.Size(67, 21)
      Me.txtOperacion.TabIndex = 11
      '
      'txtCodPar
      '
      Me.txtCodPar.Location = New System.Drawing.Point(112, 139)
      Me.txtCodPar.MaxLength = 18
      Me.txtCodPar.Name = "txtCodPar"
      Me.txtCodPar.Size = New System.Drawing.Size(321, 21)
      Me.txtCodPar.TabIndex = 3
      '
      'txtNivel
      '
      Me.txtNivel.Location = New System.Drawing.Point(12, 381)
      Me.txtNivel.Name = "txtNivel"
      Me.txtNivel.Size = New System.Drawing.Size(57, 21)
      Me.txtNivel.TabIndex = 30
      Me.txtNivel.Visible = False
      '
      'txtRelativo
      '
      Me.txtRelativo.Location = New System.Drawing.Point(75, 382)
      Me.txtRelativo.Name = "txtRelativo"
      Me.txtRelativo.Size = New System.Drawing.Size(57, 21)
      Me.txtRelativo.TabIndex = 31
      Me.txtRelativo.Visible = False
      '
      'txtIndex
      '
      Me.txtIndex.Location = New System.Drawing.Point(138, 382)
      Me.txtIndex.Name = "txtIndex"
      Me.txtIndex.Size = New System.Drawing.Size(57, 21)
      Me.txtIndex.TabIndex = 32
      Me.txtIndex.Visible = False
      '
      'frmABMPartida
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(445, 412)
      Me.Controls.Add(Me.txtIndex)
      Me.Controls.Add(Me.txtRelativo)
      Me.Controls.Add(Me.txtNivel)
      Me.Controls.Add(Me.txtCodPar)
      Me.Controls.Add(Me.txtOperacion)
      Me.Controls.Add(Me.cboCreoRend)
      Me.Controls.Add(Me.txtDescri)
      Me.Controls.Add(Me.cboCampo8)
      Me.Controls.Add(Me.cboCuadro)
      Me.Controls.Add(Me.cboEntidad)
      Me.Controls.Add(Me.fecFecVig)
      Me.Controls.Add(Me.Label13)
      Me.Controls.Add(Me.cboActiva)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.cboMonFij)
      Me.Controls.Add(Me.txtOrden)
      Me.Controls.Add(Me.Label10)
      Me.Controls.Add(Me.Label11)
      Me.Controls.Add(Me.Label12)
      Me.Controls.Add(Me.Label9)
      Me.Controls.Add(Me.txtDCorta)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmABMPartida"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Partida"
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
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtDCorta As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents cboActiva As System.Windows.Forms.ComboBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboMonFij As System.Windows.Forms.ComboBox
   Friend WithEvents txtOrden As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents fecFecVig As System.Windows.Forms.DateTimePicker
   Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
   Friend WithEvents cboCuadro As System.Windows.Forms.ComboBox
   Friend WithEvents cboCampo8 As System.Windows.Forms.ComboBox
   Public WithEvents txtDescri As System.Windows.Forms.TextBox
   Friend WithEvents cboCreoRend As System.Windows.Forms.ComboBox
   Friend WithEvents txtOperacion As System.Windows.Forms.TextBox
   Friend WithEvents txtCodPar As System.Windows.Forms.TextBox
   Friend WithEvents txtNivel As System.Windows.Forms.TextBox
   Friend WithEvents txtRelativo As System.Windows.Forms.TextBox
   Friend WithEvents txtIndex As System.Windows.Forms.TextBox

End Class
