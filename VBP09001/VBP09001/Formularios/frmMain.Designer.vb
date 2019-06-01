<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.frDiv = New System.Windows.Forms.GroupBox()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.chkOpen = New System.Windows.Forms.CheckBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtCarpeta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkRectivicativa = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAno = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.toolMain = New System.Windows.Forms.ToolStrip()
        Me.lblTransaccion = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAyuda = New System.Windows.Forms.ToolStripButton()
        Me.tsSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblVersion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboArchivos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEntidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboDia = New System.Windows.Forms.ComboBox()
        Me.toolMain.SuspendLayout()
        Me.sbMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'frDiv
        '
        Me.frDiv.Location = New System.Drawing.Point(12, 178)
        Me.frDiv.Name = "frDiv"
        Me.frDiv.Size = New System.Drawing.Size(504, 8)
        Me.frDiv.TabIndex = 37
        Me.frDiv.TabStop = False
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Location = New System.Drawing.Point(419, 192)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(97, 23)
        Me.cmdGenerar.TabIndex = 36
        Me.cmdGenerar.Text = "&Generar"
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'chkOpen
        '
        Me.chkOpen.AutoSize = True
        Me.chkOpen.Location = New System.Drawing.Point(12, 157)
        Me.chkOpen.Name = "chkOpen"
        Me.chkOpen.Size = New System.Drawing.Size(283, 17)
        Me.chkOpen.TabIndex = 35
        Me.chkOpen.Text = "&Abrir el documento generado al finalizar la generación"
        Me.chkOpen.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(413, 127)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(103, 21)
        Me.cmdBrowse.TabIndex = 34
        Me.cmdBrowse.Text = "&Examinar..."
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtCarpeta
        '
        Me.txtCarpeta.Location = New System.Drawing.Point(142, 127)
        Me.txtCarpeta.Name = "txtCarpeta"
        Me.txtCarpeta.Size = New System.Drawing.Size(265, 21)
        Me.txtCarpeta.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Guardar en carpeta:"
        '
        'chkRectivicativa
        '
        Me.chkRectivicativa.AutoSize = True
        Me.chkRectivicativa.Location = New System.Drawing.Point(142, 99)
        Me.chkRectivicativa.Name = "chkRectivicativa"
        Me.chkRectivicativa.Size = New System.Drawing.Size(15, 14)
        Me.chkRectivicativa.TabIndex = 31
        Me.chkRectivicativa.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Genera rectificativa:"
        '
        'cboAno
        '
        Me.cboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAno.FormattingEnabled = True
        Me.cboAno.Location = New System.Drawing.Point(413, 66)
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Size = New System.Drawing.Size(103, 21)
        Me.cboAno.TabIndex = 29
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(142, 66)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(265, 21)
        Me.cboMes.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Período de presentación:"
        '
        'toolMain
        '
        Me.toolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTransaccion, Me.btnSalir, Me.tsSep1, Me.btnAyuda, Me.tsSep2, Me.lblVersion, Me.ToolStripSeparator6})
        Me.toolMain.Location = New System.Drawing.Point(0, 0)
        Me.toolMain.Name = "toolMain"
        Me.toolMain.Size = New System.Drawing.Size(526, 25)
        Me.toolMain.TabIndex = 26
        Me.toolMain.Text = "ToolStrip1"
        '
        'lblTransaccion
        '
        Me.lblTransaccion.AutoSize = False
        Me.lblTransaccion.Image = Global.VBP09001.My.Resources.Resources.About
        Me.lblTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransaccion.Name = "lblTransaccion"
        Me.lblTransaccion.Size = New System.Drawing.Size(260, 22)
        Me.lblTransaccion.Text = "Transacción"
        Me.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.VBP09001.My.Resources.Resources.Cross
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 22)
        Me.btnSalir.Text = " Salir"
        '
        'tsSep1
        '
        Me.tsSep1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep1.Name = "tsSep1"
        Me.tsSep1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAyuda
        '
        Me.btnAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAyuda.Image = Global.VBP09001.My.Resources.Resources.Help_2
        Me.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(64, 22)
        Me.btnAyuda.Text = " Ayuda"
        '
        'tsSep2
        '
        Me.tsSep2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep2.Name = "tsSep2"
        Me.tsSep2.Size = New System.Drawing.Size(6, 25)
        '
        'lblVersion
        '
        Me.lblVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(76, 22)
        Me.lblVersion.Text = "Versión: 1.0.0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'cboArchivos
        '
        Me.cboArchivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArchivos.FormattingEnabled = True
        Me.cboArchivos.Location = New System.Drawing.Point(142, 35)
        Me.cboArchivos.Name = "cboArchivos"
        Me.cboArchivos.Size = New System.Drawing.Size(374, 21)
        Me.cboArchivos.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Seleccione el archivo:"
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblEntidad})
        Me.sbMain.Location = New System.Drawing.Point(0, 222)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(526, 25)
        Me.sbMain.SizingGrip = False
        Me.sbMain.TabIndex = 38
        '
        'lblUsuario
        '
        Me.lblUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblUsuario.Image = Global.VBP09001.My.Resources.Resources.Messenger_Information
        Me.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(372, 20)
        Me.lblUsuario.Spring = True
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntidad
        '
        Me.lblEntidad.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblEntidad.Image = Global.VBP09001.My.Resources.Resources.Home
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(139, 20)
        Me.lblEntidad.Text = "Banco de Prueba S.A."
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(9, 197)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 39
        '
        'cboDia
        '
        Me.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDia.FormattingEnabled = True
        Me.cboDia.Location = New System.Drawing.Point(142, 66)
        Me.cboDia.Name = "cboDia"
        Me.cboDia.Size = New System.Drawing.Size(75, 21)
        Me.cboDia.TabIndex = 28
        Me.cboDia.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 247)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.sbMain)
        Me.Controls.Add(Me.frDiv)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.chkOpen)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtCarpeta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkRectivicativa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboAno)
        Me.Controls.Add(Me.cboDia)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.toolMain)
        Me.Controls.Add(Me.cboArchivos)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar TXT"
        Me.toolMain.ResumeLayout(False)
        Me.toolMain.PerformLayout()
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frDiv As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGenerar As System.Windows.Forms.Button
    Friend WithEvents chkOpen As System.Windows.Forms.CheckBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents txtCarpeta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkRectivicativa As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAno As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents toolMain As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTransaccion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAyuda As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboArchivos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblEntidad As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboDia As ComboBox
End Class
