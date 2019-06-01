<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportar
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportar))
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.PanTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tabExportar = New System.Windows.Forms.TabControl()
        Me.tpGeneral = New System.Windows.Forms.TabPage()
        Me.chkAbrir = New System.Windows.Forms.CheckBox()
        Me.lblExportarA = New System.Windows.Forms.Label()
        Me.cboExportarA = New System.Windows.Forms.ComboBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.tpOpciones = New System.Windows.Forms.TabPage()
        Me.panHTML = New System.Windows.Forms.Panel()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.cmdColor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SpinEdit1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanCSV = New System.Windows.Forms.Panel()
        Me.chkTexto = New System.Windows.Forms.CheckBox()
        Me.txtSep = New System.Windows.Forms.TextBox()
        Me.lblSep = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.cboColor = New DevExpress.XtraEditors.ColorEdit()
        Me.txtPageTitle = New System.Windows.Forms.TextBox()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.txtBorderWidth = New System.Windows.Forms.NumericUpDown()
        Me.lblBorderWidth = New System.Windows.Forms.Label()
        Me.ColorDialogExport = New System.Windows.Forms.ColorDialog()
        Me.PanTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabExportar.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        Me.tpOpciones.SuspendLayout()
        Me.panHTML.SuspendLayout()
        CType(Me.SpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanCSV.SuspendLayout()
        CType(Me.cboColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBorderWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(293, 219)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(102, 23)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "&Exportar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(399, 219)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 23)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'PanTop
        '
        Me.PanTop.BackColor = System.Drawing.Color.White
        Me.PanTop.Controls.Add(Me.PictureBox1)
        Me.PanTop.Controls.Add(Me.lblSubtitulo)
        Me.PanTop.Controls.Add(Me.lblTitulo)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 0)
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(512, 54)
        Me.PanTop.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(450, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(20, 14, 20, 20)
        Me.PictureBox1.Size = New System.Drawing.Size(62, 54)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Location = New System.Drawing.Point(24, 29)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(414, 13)
        Me.lblSubtitulo.TabIndex = 2
        Me.lblSubtitulo.Text = "Seleccione el formato e indique el nombre del archivo de salida y haga clic en ex" &
    "portar"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(54, 13)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Exportar"
        '
        'tabExportar
        '
        Me.tabExportar.Controls.Add(Me.tpGeneral)
        Me.tabExportar.Controls.Add(Me.tpOpciones)
        Me.tabExportar.Location = New System.Drawing.Point(11, 64)
        Me.tabExportar.Name = "tabExportar"
        Me.tabExportar.SelectedIndex = 0
        Me.tabExportar.Size = New System.Drawing.Size(490, 147)
        Me.tabExportar.TabIndex = 3
        '
        'tpGeneral
        '
        Me.tpGeneral.Controls.Add(Me.chkAbrir)
        Me.tpGeneral.Controls.Add(Me.lblExportarA)
        Me.tpGeneral.Controls.Add(Me.cboExportarA)
        Me.tpGeneral.Controls.Add(Me.cmdBrowse)
        Me.tpGeneral.Controls.Add(Me.txtFileName)
        Me.tpGeneral.Controls.Add(Me.lblFileName)
        Me.tpGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeneral.Size = New System.Drawing.Size(482, 121)
        Me.tpGeneral.TabIndex = 0
        Me.tpGeneral.Text = "General"
        Me.tpGeneral.UseVisualStyleBackColor = True
        '
        'chkAbrir
        '
        Me.chkAbrir.Location = New System.Drawing.Point(73, 77)
        Me.chkAbrir.Name = "chkAbrir"
        Me.chkAbrir.Size = New System.Drawing.Size(227, 19)
        Me.chkAbrir.TabIndex = 21
        Me.chkAbrir.Text = " &Abrir archivo al finalizar"
        '
        'lblExportarA
        '
        Me.lblExportarA.AutoSize = True
        Me.lblExportarA.Location = New System.Drawing.Point(6, 27)
        Me.lblExportarA.Name = "lblExportarA"
        Me.lblExportarA.Size = New System.Drawing.Size(58, 13)
        Me.lblExportarA.TabIndex = 20
        Me.lblExportarA.Text = "Exportar a:"
        '
        'cboExportarA
        '
        Me.cboExportarA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExportarA.Items.AddRange(New Object() {"Planilla Excel", "Archivo PDF", "Archivo HTML", "Archivo de Texto", "Archivo delimitado", "Texto enriquecido"})
        Me.cboExportarA.Location = New System.Drawing.Point(73, 24)
        Me.cboExportarA.Name = "cboExportarA"
        Me.cboExportarA.Size = New System.Drawing.Size(402, 21)
        Me.cboExportarA.TabIndex = 19
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(447, 51)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(28, 20)
        Me.cmdBrowse.TabIndex = 18
        Me.cmdBrowse.Text = "..."
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(73, 51)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(369, 20)
        Me.txtFileName.TabIndex = 16
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(6, 54)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(46, 13)
        Me.lblFileName.TabIndex = 17
        Me.lblFileName.Text = "Archivo:"
        '
        'tpOpciones
        '
        Me.tpOpciones.Controls.Add(Me.panHTML)
        Me.tpOpciones.Controls.Add(Me.PanCSV)
        Me.tpOpciones.Location = New System.Drawing.Point(4, 22)
        Me.tpOpciones.Name = "tpOpciones"
        Me.tpOpciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOpciones.Size = New System.Drawing.Size(482, 121)
        Me.tpOpciones.TabIndex = 1
        Me.tpOpciones.Text = "Opciones"
        Me.tpOpciones.UseVisualStyleBackColor = True
        '
        'panHTML
        '
        Me.panHTML.BackColor = System.Drawing.Color.Transparent
        Me.panHTML.Controls.Add(Me.txtColor)
        Me.panHTML.Controls.Add(Me.cmdColor)
        Me.panHTML.Controls.Add(Me.Label1)
        Me.panHTML.Controls.Add(Me.TextBox1)
        Me.panHTML.Controls.Add(Me.Label2)
        Me.panHTML.Controls.Add(Me.SpinEdit1)
        Me.panHTML.Controls.Add(Me.Label3)
        Me.panHTML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHTML.Location = New System.Drawing.Point(3, 3)
        Me.panHTML.Name = "panHTML"
        Me.panHTML.Size = New System.Drawing.Size(476, 115)
        Me.panHTML.TabIndex = 3
        Me.panHTML.Visible = False
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(76, 70)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(62, 20)
        Me.txtColor.TabIndex = 25
        '
        'cmdColor
        '
        Me.cmdColor.Location = New System.Drawing.Point(144, 70)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(26, 20)
        Me.cmdColor.TabIndex = 24
        Me.cmdColor.Text = "..."
        Me.cmdColor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Color:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(380, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Título:"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.Location = New System.Drawing.Point(76, 43)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Size = New System.Drawing.Size(62, 20)
        Me.SpinEdit1.TabIndex = 19
        Me.SpinEdit1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Borde:"
        '
        'PanCSV
        '
        Me.PanCSV.BackColor = System.Drawing.Color.Transparent
        Me.PanCSV.Controls.Add(Me.chkTexto)
        Me.PanCSV.Controls.Add(Me.txtSep)
        Me.PanCSV.Controls.Add(Me.lblSep)
        Me.PanCSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCSV.Location = New System.Drawing.Point(3, 3)
        Me.PanCSV.Name = "PanCSV"
        Me.PanCSV.Size = New System.Drawing.Size(476, 115)
        Me.PanCSV.TabIndex = 2
        Me.PanCSV.Visible = False
        '
        'chkTexto
        '
        Me.chkTexto.Checked = True
        Me.chkTexto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTexto.Location = New System.Drawing.Point(12, 58)
        Me.chkTexto.Name = "chkTexto"
        Me.chkTexto.Size = New System.Drawing.Size(434, 19)
        Me.chkTexto.TabIndex = 23
        Me.chkTexto.Text = "Utilizar comillas para delimitar texto"
        '
        'txtSep
        '
        Me.txtSep.Location = New System.Drawing.Point(76, 31)
        Me.txtSep.Name = "txtSep"
        Me.txtSep.Size = New System.Drawing.Size(62, 20)
        Me.txtSep.TabIndex = 18
        Me.txtSep.Text = ";"
        '
        'lblSep
        '
        Me.lblSep.AutoSize = True
        Me.lblSep.Location = New System.Drawing.Point(9, 34)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(59, 13)
        Me.lblSep.TabIndex = 22
        Me.lblSep.Text = "Separador:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(9, 73)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 23
        Me.lblColor.Text = "Color:"
        '
        'cboColor
        '
        Me.cboColor.EditValue = System.Drawing.Color.Black
        Me.cboColor.Location = New System.Drawing.Point(76, 69)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColor.Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboColor.Size = New System.Drawing.Size(62, 20)
        Me.cboColor.TabIndex = 20
        '
        'txtPageTitle
        '
        Me.txtPageTitle.Location = New System.Drawing.Point(76, 17)
        Me.txtPageTitle.Name = "txtPageTitle"
        Me.txtPageTitle.Size = New System.Drawing.Size(337, 20)
        Me.txtPageTitle.TabIndex = 18
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Location = New System.Drawing.Point(9, 20)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(38, 13)
        Me.lblPageTitle.TabIndex = 22
        Me.lblPageTitle.Text = "Título:"
        '
        'txtBorderWidth
        '
        Me.txtBorderWidth.Location = New System.Drawing.Point(76, 43)
        Me.txtBorderWidth.Name = "txtBorderWidth"
        Me.txtBorderWidth.Size = New System.Drawing.Size(62, 20)
        Me.txtBorderWidth.TabIndex = 19
        '
        'lblBorderWidth
        '
        Me.lblBorderWidth.AutoSize = True
        Me.lblBorderWidth.Location = New System.Drawing.Point(9, 47)
        Me.lblBorderWidth.Name = "lblBorderWidth"
        Me.lblBorderWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblBorderWidth.TabIndex = 21
        Me.lblBorderWidth.Text = "Borde:"
        '
        'frmExportar
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(512, 252)
        Me.Controls.Add(Me.tabExportar)
        Me.Controls.Add(Me.PanTop)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExportar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar"
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabExportar.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        Me.tpOpciones.ResumeLayout(False)
        Me.panHTML.ResumeLayout(False)
        Me.panHTML.PerformLayout()
        CType(Me.SpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanCSV.ResumeLayout(False)
        Me.PanCSV.PerformLayout()
        CType(Me.cboColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBorderWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
   Friend WithEvents cmdCancelar As System.Windows.Forms.Button
   Friend WithEvents PanTop As System.Windows.Forms.Panel
   Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
   Friend WithEvents lblTitulo As System.Windows.Forms.Label
   Friend WithEvents tabExportar As System.Windows.Forms.TabControl
   Friend WithEvents tpGeneral As System.Windows.Forms.TabPage
   Friend WithEvents tpOpciones As System.Windows.Forms.TabPage
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents chkAbrir As System.Windows.Forms.CheckBox
   Friend WithEvents lblExportarA As System.Windows.Forms.Label
   Friend WithEvents cboExportarA As System.Windows.Forms.ComboBox
   Friend WithEvents cmdBrowse As System.Windows.Forms.Button
   Friend WithEvents txtFileName As System.Windows.Forms.TextBox
   Friend WithEvents lblFileName As System.Windows.Forms.Label
   Friend WithEvents PanCSV As System.Windows.Forms.Panel
   Friend WithEvents chkTexto As System.Windows.Forms.CheckBox
   Friend WithEvents txtSep As System.Windows.Forms.TextBox
   Friend WithEvents lblSep As System.Windows.Forms.Label
   Friend WithEvents panHTML As System.Windows.Forms.Panel
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents SpinEdit1 As System.Windows.Forms.NumericUpDown
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents lblColor As System.Windows.Forms.Label
   Friend WithEvents cboColor As DevExpress.XtraEditors.ColorEdit
   Friend WithEvents txtPageTitle As System.Windows.Forms.TextBox
   Friend WithEvents lblPageTitle As System.Windows.Forms.Label
   Friend WithEvents txtBorderWidth As System.Windows.Forms.NumericUpDown
   Friend WithEvents lblBorderWidth As System.Windows.Forms.Label
   Friend WithEvents txtColor As System.Windows.Forms.TextBox
   Friend WithEvents cmdColor As System.Windows.Forms.Button
   Friend WithEvents ColorDialogExport As System.Windows.Forms.ColorDialog
End Class
