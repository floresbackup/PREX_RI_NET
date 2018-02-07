<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConexion
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConexion))
        Me.lblNombreConexion = New DevExpress.XtraEditors.LabelControl
        Me.lblDesipcrionConexion = New DevExpress.XtraEditors.LabelControl
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit
        Me.lblCadena = New DevExpress.XtraEditors.LabelControl
        Me.txtCadena = New DevExpress.XtraEditors.MemoEdit
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGenerarCadena = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDiccionarioDatos = New DevExpress.XtraEditors.SimpleButton
        Me.lblTipoConexion = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoConexion = New DevExpress.XtraEditors.ComboBoxEdit
        Me.chkEjecucionAsincrona = New DevExpress.XtraEditors.CheckEdit
        Me.txtFormatoFechas = New DevExpress.XtraEditors.TextEdit
        Me.lblFormatoFechas = New DevExpress.XtraEditors.LabelControl
        Me.txtLiteralFechas = New DevExpress.XtraEditors.TextEdit
        Me.lblLiteralFechas = New DevExpress.XtraEditors.LabelControl
        Me.txtLiteralCadenas = New DevExpress.XtraEditors.TextEdit
        Me.lblLiteralCadenas = New DevExpress.XtraEditors.LabelControl
        Me.txtSimboloDecimal = New DevExpress.XtraEditors.TextEdit
        Me.lblSimboloDecimal = New DevExpress.XtraEditors.LabelControl
        Me.chkOpcionesDefault = New DevExpress.XtraEditors.CheckEdit
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCadena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoConexion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEjecucionAsincrona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormatoFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLiteralFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLiteralCadenas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSimboloDecimal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOpcionesDefault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreConexion
        '
        Me.lblNombreConexion.Location = New System.Drawing.Point(12, 12)
        Me.lblNombreConexion.Name = "lblNombreConexion"
        Me.lblNombreConexion.Size = New System.Drawing.Size(41, 13)
        Me.lblNombreConexion.TabIndex = 0
        Me.lblNombreConexion.Text = "Nombre:"
        '
        'lblDesipcrionConexion
        '
        Me.lblDesipcrionConexion.Location = New System.Drawing.Point(12, 38)
        Me.lblDesipcrionConexion.Name = "lblDesipcrionConexion"
        Me.lblDesipcrionConexion.Size = New System.Drawing.Size(58, 13)
        Me.lblDesipcrionConexion.TabIndex = 1
        Me.lblDesipcrionConexion.Text = "Descripción:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 9)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.Appearance.Options.UseFont = True
        Me.txtNombre.Size = New System.Drawing.Size(210, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 35)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(441, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'lblCadena
        '
        Me.lblCadena.Location = New System.Drawing.Point(13, 234)
        Me.lblCadena.Name = "lblCadena"
        Me.lblCadena.Size = New System.Drawing.Size(102, 13)
        Me.lblCadena.TabIndex = 4
        Me.lblCadena.Text = "Cadena de conexión:"
        '
        'txtCadena
        '
        Me.txtCadena.Location = New System.Drawing.Point(12, 253)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(549, 85)
        Me.txtCadena.TabIndex = 2
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(361, 344)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(464, 344)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGenerarCadena
        '
        Me.cmdGenerarCadena.Location = New System.Drawing.Point(12, 344)
        Me.cmdGenerarCadena.Name = "cmdGenerarCadena"
        Me.cmdGenerarCadena.Size = New System.Drawing.Size(145, 26)
        Me.cmdGenerarCadena.TabIndex = 3
        Me.cmdGenerarCadena.Text = "Generar conexión..."
        '
        'cmdDiccionarioDatos
        '
        Me.cmdDiccionarioDatos.Location = New System.Drawing.Point(163, 344)
        Me.cmdDiccionarioDatos.Name = "cmdDiccionarioDatos"
        Me.cmdDiccionarioDatos.Size = New System.Drawing.Size(167, 26)
        Me.cmdDiccionarioDatos.TabIndex = 6
        Me.cmdDiccionarioDatos.Text = "Diccionario de datos..."
        Me.cmdDiccionarioDatos.Visible = False
        '
        'lblTipoConexion
        '
        Me.lblTipoConexion.Location = New System.Drawing.Point(12, 64)
        Me.lblTipoConexion.Name = "lblTipoConexion"
        Me.lblTipoConexion.Size = New System.Drawing.Size(85, 13)
        Me.lblTipoConexion.TabIndex = 7
        Me.lblTipoConexion.Text = "Tipo de conexión:"
        '
        'cboTipoConexion
        '
        Me.cboTipoConexion.EditValue = "OLEDB"
        Me.cboTipoConexion.Location = New System.Drawing.Point(120, 61)
        Me.cboTipoConexion.Name = "cboTipoConexion"
        Me.cboTipoConexion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoConexion.Properties.Items.AddRange(New Object() {"OLEDB", "MS SQL Server", "Oracle", "ODBC"})
        Me.cboTipoConexion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoConexion.Size = New System.Drawing.Size(210, 20)
        Me.cboTipoConexion.TabIndex = 8
        '
        'chkEjecucionAsincrona
        '
        Me.chkEjecucionAsincrona.Enabled = False
        Me.chkEjecucionAsincrona.Location = New System.Drawing.Point(336, 61)
        Me.chkEjecucionAsincrona.Name = "chkEjecucionAsincrona"
        Me.chkEjecucionAsincrona.Properties.Caption = "Permitir ejecución asíncrona"
        Me.chkEjecucionAsincrona.Size = New System.Drawing.Size(184, 19)
        Me.chkEjecucionAsincrona.TabIndex = 18
        '
        'txtFormatoFechas
        '
        Me.txtFormatoFechas.Enabled = False
        Me.txtFormatoFechas.Location = New System.Drawing.Point(163, 198)
        Me.txtFormatoFechas.Name = "txtFormatoFechas"
        Me.txtFormatoFechas.Size = New System.Drawing.Size(89, 20)
        Me.txtFormatoFechas.TabIndex = 35
        '
        'lblFormatoFechas
        '
        Me.lblFormatoFechas.Enabled = False
        Me.lblFormatoFechas.Location = New System.Drawing.Point(32, 201)
        Me.lblFormatoFechas.Name = "lblFormatoFechas"
        Me.lblFormatoFechas.Size = New System.Drawing.Size(94, 13)
        Me.lblFormatoFechas.TabIndex = 34
        Me.lblFormatoFechas.Text = "Formato de fechas:"
        '
        'txtLiteralFechas
        '
        Me.txtLiteralFechas.Enabled = False
        Me.txtLiteralFechas.Location = New System.Drawing.Point(163, 172)
        Me.txtLiteralFechas.Name = "txtLiteralFechas"
        Me.txtLiteralFechas.Size = New System.Drawing.Size(58, 20)
        Me.txtLiteralFechas.TabIndex = 33
        '
        'lblLiteralFechas
        '
        Me.lblLiteralFechas.Enabled = False
        Me.lblLiteralFechas.Location = New System.Drawing.Point(32, 175)
        Me.lblLiteralFechas.Name = "lblLiteralFechas"
        Me.lblLiteralFechas.Size = New System.Drawing.Size(83, 13)
        Me.lblLiteralFechas.TabIndex = 32
        Me.lblLiteralFechas.Text = "Literal de fechas:"
        '
        'txtLiteralCadenas
        '
        Me.txtLiteralCadenas.Enabled = False
        Me.txtLiteralCadenas.Location = New System.Drawing.Point(163, 146)
        Me.txtLiteralCadenas.Name = "txtLiteralCadenas"
        Me.txtLiteralCadenas.Size = New System.Drawing.Size(58, 20)
        Me.txtLiteralCadenas.TabIndex = 31
        '
        'lblLiteralCadenas
        '
        Me.lblLiteralCadenas.Enabled = False
        Me.lblLiteralCadenas.Location = New System.Drawing.Point(32, 149)
        Me.lblLiteralCadenas.Name = "lblLiteralCadenas"
        Me.lblLiteralCadenas.Size = New System.Drawing.Size(91, 13)
        Me.lblLiteralCadenas.TabIndex = 30
        Me.lblLiteralCadenas.Text = "Literal de cadenas:"
        '
        'txtSimboloDecimal
        '
        Me.txtSimboloDecimal.Enabled = False
        Me.txtSimboloDecimal.Location = New System.Drawing.Point(163, 122)
        Me.txtSimboloDecimal.Name = "txtSimboloDecimal"
        Me.txtSimboloDecimal.Size = New System.Drawing.Size(58, 20)
        Me.txtSimboloDecimal.TabIndex = 29
        '
        'lblSimboloDecimal
        '
        Me.lblSimboloDecimal.Enabled = False
        Me.lblSimboloDecimal.Location = New System.Drawing.Point(32, 125)
        Me.lblSimboloDecimal.Name = "lblSimboloDecimal"
        Me.lblSimboloDecimal.Size = New System.Drawing.Size(78, 13)
        Me.lblSimboloDecimal.TabIndex = 28
        Me.lblSimboloDecimal.Text = "Símbolo decimal:"
        '
        'chkOpcionesDefault
        '
        Me.chkOpcionesDefault.EditValue = True
        Me.chkOpcionesDefault.Location = New System.Drawing.Point(10, 97)
        Me.chkOpcionesDefault.Name = "chkOpcionesDefault"
        Me.chkOpcionesDefault.Properties.Caption = "Utilizar opciones predeterminadas"
        Me.chkOpcionesDefault.Size = New System.Drawing.Size(211, 19)
        Me.chkOpcionesDefault.TabIndex = 27
        '
        'frmConexion
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(573, 382)
        Me.Controls.Add(Me.txtFormatoFechas)
        Me.Controls.Add(Me.lblFormatoFechas)
        Me.Controls.Add(Me.txtLiteralFechas)
        Me.Controls.Add(Me.lblLiteralFechas)
        Me.Controls.Add(Me.txtLiteralCadenas)
        Me.Controls.Add(Me.lblLiteralCadenas)
        Me.Controls.Add(Me.txtSimboloDecimal)
        Me.Controls.Add(Me.lblSimboloDecimal)
        Me.Controls.Add(Me.chkOpcionesDefault)
        Me.Controls.Add(Me.chkEjecucionAsincrona)
        Me.Controls.Add(Me.cboTipoConexion)
        Me.Controls.Add(Me.lblTipoConexion)
        Me.Controls.Add(Me.cmdDiccionarioDatos)
        Me.Controls.Add(Me.cmdGenerarCadena)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.lblCadena)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDesipcrionConexion)
        Me.Controls.Add(Me.lblNombreConexion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConexion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conexión"
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCadena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoConexion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEjecucionAsincrona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormatoFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLiteralFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLiteralCadenas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSimboloDecimal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOpcionesDefault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreConexion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDesipcrionConexion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCadena As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCadena As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGenerarCadena As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDiccionarioDatos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTipoConexion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoConexion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkEjecucionAsincrona As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFormatoFechas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFormatoFechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLiteralFechas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLiteralFechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLiteralCadenas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLiteralCadenas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSimboloDecimal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSimboloDecimal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkOpcionesDefault As DevExpress.XtraEditors.CheckEdit
End Class
