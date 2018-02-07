<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMDiseno
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMDiseno))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtCampo = New System.Windows.Forms.TextBox
      Me.txtDescri = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtInicio = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtLongitud = New System.Windows.Forms.TextBox
      Me.panLongitud = New System.Windows.Forms.Panel
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtRelacion = New System.Windows.Forms.TextBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtNroClave = New System.Windows.Forms.TextBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboTipo = New System.Windows.Forms.ComboBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.cboValida = New System.Windows.Forms.ComboBox
      Me.cboFormato = New System.Windows.Forms.ComboBox
      Me.lblFin = New System.Windows.Forms.Label
      Me.TableLayoutPanel1.SuspendLayout()
      Me.panTop.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panLongitud.SuspendLayout()
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(378, 271)
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
      Me.panTop.Size = New System.Drawing.Size(532, 51)
      Me.panTop.TabIndex = 1
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(103, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Diseño de campo"
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(25, 29)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(172, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Complete la información del campo"
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(462, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 15, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(70, 51)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(10, 63)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(44, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Campo:"
      '
      'txtCampo
      '
      Me.txtCampo.Location = New System.Drawing.Point(103, 60)
      Me.txtCampo.Name = "txtCampo"
      Me.txtCampo.Size = New System.Drawing.Size(418, 21)
      Me.txtCampo.TabIndex = 3
      '
      'txtDescri
      '
      Me.txtDescri.Location = New System.Drawing.Point(103, 86)
      Me.txtDescri.Name = "txtDescri"
      Me.txtDescri.Size = New System.Drawing.Size(418, 21)
      Me.txtDescri.TabIndex = 5
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(10, 89)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(61, 13)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "Descripción"
      '
      'txtInicio
      '
      Me.txtInicio.Location = New System.Drawing.Point(103, 112)
      Me.txtInicio.Name = "txtInicio"
      Me.txtInicio.Size = New System.Drawing.Size(39, 21)
      Me.txtInicio.TabIndex = 7
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(10, 115)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(87, 13)
      Me.Label3.TabIndex = 6
      Me.Label3.Text = "Inicio / Longitud:"
      '
      'txtLongitud
      '
      Me.txtLongitud.Location = New System.Drawing.Point(148, 112)
      Me.txtLongitud.Name = "txtLongitud"
      Me.txtLongitud.Size = New System.Drawing.Size(39, 21)
      Me.txtLongitud.TabIndex = 8
      '
      'panLongitud
      '
      Me.panLongitud.BackColor = System.Drawing.SystemColors.Info
      Me.panLongitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panLongitud.Controls.Add(Me.lblFin)
      Me.panLongitud.Controls.Add(Me.Label4)
      Me.panLongitud.Location = New System.Drawing.Point(193, 112)
      Me.panLongitud.Name = "panLongitud"
      Me.panLongitud.Size = New System.Drawing.Size(328, 20)
      Me.panLongitud.TabIndex = 9
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
      Me.Label4.Location = New System.Drawing.Point(3, 2)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(25, 13)
      Me.Label4.TabIndex = 0
      Me.Label4.Text = "Fin:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(10, 168)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(51, 13)
      Me.Label5.TabIndex = 10
      Me.Label5.Text = "Formato:"
      '
      'txtRelacion
      '
      Me.txtRelacion.Location = New System.Drawing.Point(103, 191)
      Me.txtRelacion.Name = "txtRelacion"
      Me.txtRelacion.Size = New System.Drawing.Size(418, 21)
      Me.txtRelacion.TabIndex = 13
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(10, 194)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(51, 13)
      Me.Label6.TabIndex = 12
      Me.Label6.Text = "Relación:"
      '
      'txtNroClave
      '
      Me.txtNroClave.Location = New System.Drawing.Point(103, 243)
      Me.txtNroClave.Name = "txtNroClave"
      Me.txtNroClave.Size = New System.Drawing.Size(418, 21)
      Me.txtNroClave.TabIndex = 15
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(10, 246)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(62, 13)
      Me.Label7.TabIndex = 14
      Me.Label7.Text = "Nº de clave"
      '
      'cboTipo
      '
      Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboTipo.FormattingEnabled = True
      Me.cboTipo.Location = New System.Drawing.Point(103, 138)
      Me.cboTipo.Name = "cboTipo"
      Me.cboTipo.Size = New System.Drawing.Size(418, 21)
      Me.cboTipo.TabIndex = 16
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Location = New System.Drawing.Point(10, 141)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(56, 13)
      Me.Label8.TabIndex = 17
      Me.Label8.Text = "Tipo dato:"
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(10, 220)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(43, 13)
      Me.Label9.TabIndex = 19
      Me.Label9.Text = "Validar:"
      '
      'cboValida
      '
      Me.cboValida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboValida.FormattingEnabled = True
      Me.cboValida.Location = New System.Drawing.Point(103, 217)
      Me.cboValida.Name = "cboValida"
      Me.cboValida.Size = New System.Drawing.Size(418, 21)
      Me.cboValida.TabIndex = 18
      '
      'cboFormato
      '
      Me.cboFormato.FormattingEnabled = True
      Me.cboFormato.Location = New System.Drawing.Point(103, 165)
      Me.cboFormato.Name = "cboFormato"
      Me.cboFormato.Size = New System.Drawing.Size(418, 21)
      Me.cboFormato.TabIndex = 20
      '
      'lblFin
      '
      Me.lblFin.AutoSize = True
      Me.lblFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFin.ForeColor = System.Drawing.SystemColors.InfoText
      Me.lblFin.Location = New System.Drawing.Point(27, 2)
      Me.lblFin.Name = "lblFin"
      Me.lblFin.Size = New System.Drawing.Size(13, 13)
      Me.lblFin.TabIndex = 1
      Me.lblFin.Text = "0"
      '
      'frmABMDiseno
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(532, 307)
      Me.Controls.Add(Me.cboFormato)
      Me.Controls.Add(Me.Label9)
      Me.Controls.Add(Me.cboValida)
      Me.Controls.Add(Me.Label8)
      Me.Controls.Add(Me.cboTipo)
      Me.Controls.Add(Me.txtNroClave)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.txtRelacion)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.panLongitud)
      Me.Controls.Add(Me.txtLongitud)
      Me.Controls.Add(Me.txtInicio)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtDescri)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.txtCampo)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmABMDiseno"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Diseño de campo"
      Me.TableLayoutPanel1.ResumeLayout(False)
      Me.panTop.ResumeLayout(False)
      Me.panTop.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panLongitud.ResumeLayout(False)
      Me.panLongitud.PerformLayout()
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
   Friend WithEvents txtCampo As System.Windows.Forms.TextBox
   Friend WithEvents txtDescri As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtInicio As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtLongitud As System.Windows.Forms.TextBox
   Friend WithEvents panLongitud As System.Windows.Forms.Panel
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtRelacion As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtNroClave As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents cboValida As System.Windows.Forms.ComboBox
   Friend WithEvents cboFormato As System.Windows.Forms.ComboBox
   Friend WithEvents lblFin As System.Windows.Forms.Label

End Class
