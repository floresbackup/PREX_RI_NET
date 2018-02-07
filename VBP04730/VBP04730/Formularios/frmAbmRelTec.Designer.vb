<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmRelTec
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmRelTec))
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.txtCodPar = New System.Windows.Forms.TextBox
      Me.cboCodEnt = New System.Windows.Forms.ComboBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.panTop = New System.Windows.Forms.Panel
      Me.lblSubtitulo = New System.Windows.Forms.Label
      Me.lblTitulo = New System.Windows.Forms.Label
      Me.cboCuadro = New System.Windows.Forms.ComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.cmdCodPar = New System.Windows.Forms.Button
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.cmdCODRTC = New System.Windows.Forms.Button
      Me.txtCODRTC = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cmdEOAFNG = New System.Windows.Forms.Button
      Me.txtEOAFNG = New System.Windows.Forms.TextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboFecVig = New System.Windows.Forms.ComboBox
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 231)
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
      'txtCodPar
      '
      Me.txtCodPar.Location = New System.Drawing.Point(112, 145)
      Me.txtCodPar.Name = "txtCodPar"
      Me.txtCodPar.Size = New System.Drawing.Size(276, 20)
      Me.txtCodPar.TabIndex = 30
      '
      'cboCodEnt
      '
      Me.cboCodEnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboCodEnt.FormattingEnabled = True
      Me.cboCodEnt.Location = New System.Drawing.Point(112, 91)
      Me.cboCodEnt.Name = "cboCodEnt"
      Me.cboCodEnt.Size = New System.Drawing.Size(308, 21)
      Me.cboCodEnt.TabIndex = 28
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(10, 148)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(43, 13)
      Me.Label6.TabIndex = 33
      Me.Label6.Text = "Partida:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(10, 94)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(46, 13)
      Me.Label5.TabIndex = 32
      Me.Label5.Text = "Entidad:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(10, 69)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(83, 13)
      Me.Label3.TabIndex = 31
      Me.Label3.Text = "Fecha vigencia:"
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
      Me.panTop.Size = New System.Drawing.Size(435, 51)
      Me.panTop.TabIndex = 29
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.AutoSize = True
      Me.lblSubtitulo.Location = New System.Drawing.Point(25, 29)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(149, 13)
      Me.lblSubtitulo.TabIndex = 1
      Me.lblSubtitulo.Text = "Detalle de la Relación técnica"
      '
      'lblTitulo
      '
      Me.lblTitulo.AutoSize = True
      Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(99, 13)
      Me.lblTitulo.TabIndex = 0
      Me.lblTitulo.Text = "Relación técnica"
      '
      'cboCuadro
      '
      Me.cboCuadro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboCuadro.FormattingEnabled = True
      Me.cboCuadro.Location = New System.Drawing.Point(112, 118)
      Me.cboCuadro.Name = "cboCuadro"
      Me.cboCuadro.Size = New System.Drawing.Size(308, 21)
      Me.cboCuadro.TabIndex = 34
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(10, 121)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(44, 13)
      Me.Label1.TabIndex = 35
      Me.Label1.Text = "Cuadro:"
      '
      'cmdCodPar
      '
      Me.cmdCodPar.Image = Global.VBP04730.My.Resources.Resources.Search
      Me.cmdCodPar.Location = New System.Drawing.Point(391, 145)
      Me.cmdCodPar.Name = "cmdCodPar"
      Me.cmdCodPar.Size = New System.Drawing.Size(29, 20)
      Me.cmdCodPar.TabIndex = 36
      Me.cmdCodPar.UseVisualStyleBackColor = True
      '
      'PictureBox1
      '
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(365, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 15, 20, 20)
      Me.PictureBox1.Size = New System.Drawing.Size(70, 51)
      Me.PictureBox1.TabIndex = 2
      Me.PictureBox1.TabStop = False
      '
      'cmdCODRTC
      '
      Me.cmdCODRTC.Image = Global.VBP04730.My.Resources.Resources.Search
      Me.cmdCODRTC.Location = New System.Drawing.Point(391, 171)
      Me.cmdCODRTC.Name = "cmdCODRTC"
      Me.cmdCODRTC.Size = New System.Drawing.Size(29, 20)
      Me.cmdCODRTC.TabIndex = 39
      Me.cmdCODRTC.UseVisualStyleBackColor = True
      '
      'txtCODRTC
      '
      Me.txtCODRTC.Location = New System.Drawing.Point(112, 171)
      Me.txtCODRTC.Name = "txtCODRTC"
      Me.txtCODRTC.Size = New System.Drawing.Size(276, 20)
      Me.txtCODRTC.TabIndex = 37
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(10, 174)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(61, 13)
      Me.Label2.TabIndex = 38
      Me.Label2.Text = "Relación 1:"
      '
      'cmdEOAFNG
      '
      Me.cmdEOAFNG.Image = Global.VBP04730.My.Resources.Resources.Search
      Me.cmdEOAFNG.Location = New System.Drawing.Point(391, 197)
      Me.cmdEOAFNG.Name = "cmdEOAFNG"
      Me.cmdEOAFNG.Size = New System.Drawing.Size(29, 20)
      Me.cmdEOAFNG.TabIndex = 42
      Me.cmdEOAFNG.UseVisualStyleBackColor = True
      '
      'txtEOAFNG
      '
      Me.txtEOAFNG.Location = New System.Drawing.Point(112, 197)
      Me.txtEOAFNG.Name = "txtEOAFNG"
      Me.txtEOAFNG.Size = New System.Drawing.Size(276, 20)
      Me.txtEOAFNG.TabIndex = 40
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(10, 200)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(61, 13)
      Me.Label4.TabIndex = 41
      Me.Label4.Text = "Relación 2:"
      '
      'cboFecVig
      '
      Me.cboFecVig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboFecVig.FormattingEnabled = True
      Me.cboFecVig.Location = New System.Drawing.Point(112, 66)
      Me.cboFecVig.Name = "cboFecVig"
      Me.cboFecVig.Size = New System.Drawing.Size(308, 21)
      Me.cboFecVig.TabIndex = 43
      '
      'frmAbmRelTec
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(435, 272)
      Me.Controls.Add(Me.cboFecVig)
      Me.Controls.Add(Me.cmdEOAFNG)
      Me.Controls.Add(Me.txtEOAFNG)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.cmdCODRTC)
      Me.Controls.Add(Me.txtCODRTC)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.cmdCodPar)
      Me.Controls.Add(Me.cboCuadro)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.txtCodPar)
      Me.Controls.Add(Me.cboCodEnt)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.panTop)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmAbmRelTec"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Relación técnica"
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
   Friend WithEvents txtCodPar As System.Windows.Forms.TextBox
   Friend WithEvents cboCodEnt As System.Windows.Forms.ComboBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents panTop As System.Windows.Forms.Panel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents cboCuadro As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmdCodPar As System.Windows.Forms.Button
   Friend WithEvents cmdCODRTC As System.Windows.Forms.Button
   Friend WithEvents txtCODRTC As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmdEOAFNG As System.Windows.Forms.Button
   Friend WithEvents txtEOAFNG As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboFecVig As System.Windows.Forms.ComboBox

End Class
