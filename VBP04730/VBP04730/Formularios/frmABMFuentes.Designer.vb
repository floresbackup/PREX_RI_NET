<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMFuentes
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMFuentes))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.panTop = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.txtDescri = New System.Windows.Forms.TextBox
      Me.cboCodEnt = New System.Windows.Forms.ComboBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.fecFecVig = New System.Windows.Forms.DateTimePicker
      Me.chkActiva = New System.Windows.Forms.CheckBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtCodCue = New System.Windows.Forms.TextBox
      Me.txtTabla = New System.Windows.Forms.TextBox
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(290, 215)
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
      Me.OK_Button.TabIndex = 5
      Me.OK_Button.Text = "Aceptar"
      '
      'Cancel_Button
      '
      Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
      Me.Cancel_Button.Name = "Cancel_Button"
      Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
      Me.Cancel_Button.TabIndex = 6
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
      Me.panTop.Size = New System.Drawing.Size(448, 51)
      Me.panTop.TabIndex = 2
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(378, 0)
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
      Me.lblSubtitulo.Size = New System.Drawing.Size(143, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Detalle de la fuente de datos"
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(99, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Fuente de Datos"
      '
      'txtDescri
      '
      Me.txtDescri.Location = New System.Drawing.Point(112, 143)
      Me.txtDescri.Multiline = True
      Me.txtDescri.Name = "txtDescri"
      Me.txtDescri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtDescri.Size = New System.Drawing.Size(323, 49)
      Me.txtDescri.TabIndex = 3
      '
      'cboCodEnt
      '
      Me.cboCodEnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboCodEnt.FormattingEnabled = True
      Me.cboCodEnt.Location = New System.Drawing.Point(112, 89)
      Me.cboCodEnt.Name = "cboCodEnt"
      Me.cboCodEnt.Size = New System.Drawing.Size(323, 21)
      Me.cboCodEnt.TabIndex = 1
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(10, 146)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(66, 13)
      Me.Label9.TabIndex = 27
      Me.Label9.Text = "Descripción:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(10, 119)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(43, 13)
      Me.Label6.TabIndex = 26
      Me.Label6.Text = "Código:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(10, 92)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(46, 13)
      Me.Label5.TabIndex = 25
      Me.Label5.Text = "Entidad:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(10, 67)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(83, 13)
      Me.Label3.TabIndex = 24
      Me.Label3.Text = "Fecha vigencia:"
      '
      'fecFecVig
      '
      Me.fecFecVig.CustomFormat = "dd/MM/yyyy"
      Me.fecFecVig.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.fecFecVig.Location = New System.Drawing.Point(112, 63)
      Me.fecFecVig.Name = "fecFecVig"
      Me.fecFecVig.Size = New System.Drawing.Size(323, 20)
      Me.fecFecVig.TabIndex = 0
      '
      'chkActiva
      '
      Me.chkActiva.AutoSize = True
      Me.chkActiva.Location = New System.Drawing.Point(112, 198)
      Me.chkActiva.Name = "chkActiva"
      Me.chkActiva.Size = New System.Drawing.Size(15, 14)
      Me.chkActiva.TabIndex = 4
      Me.chkActiva.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(10, 198)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(40, 13)
      Me.Label1.TabIndex = 30
      Me.Label1.Text = "Activa:"
      '
      'txtCodCue
      '
      Me.txtCodCue.Location = New System.Drawing.Point(112, 116)
      Me.txtCodCue.Name = "txtCodCue"
      Me.txtCodCue.Size = New System.Drawing.Size(321, 20)
      Me.txtCodCue.TabIndex = 2
      '
      'txtTabla
      '
      Me.txtTabla.Location = New System.Drawing.Point(13, 224)
      Me.txtTabla.Name = "txtTabla"
      Me.txtTabla.Size = New System.Drawing.Size(100, 20)
      Me.txtTabla.TabIndex = 31
      Me.txtTabla.Visible = False
      '
      'frmABMFuentes
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(448, 256)
      Me.Controls.Add(Me.txtTabla)
      Me.Controls.Add(Me.txtCodCue)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.chkActiva)
      Me.Controls.Add(Me.fecFecVig)
      Me.Controls.Add(Me.txtDescri)
      Me.Controls.Add(Me.cboCodEnt)
      Me.Controls.Add(Me.Label9)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmABMFuentes"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " Fuente de Datos"
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
   Public WithEvents txtDescri As System.Windows.Forms.TextBox
   Friend WithEvents cboCodEnt As System.Windows.Forms.ComboBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents fecFecVig As System.Windows.Forms.DateTimePicker
   Friend WithEvents chkActiva As System.Windows.Forms.CheckBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCodCue As System.Windows.Forms.TextBox
   Friend WithEvents txtTabla As System.Windows.Forms.TextBox

End Class
