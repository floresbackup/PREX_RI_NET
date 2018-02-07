<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionesGlobales
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
        Me.txtFormatoFechas = New DevExpress.XtraEditors.TextEdit
        Me.lblFormatoFechas = New DevExpress.XtraEditors.LabelControl
        Me.txtLiteralFechas = New DevExpress.XtraEditors.TextEdit
        Me.lblLiteralFechas = New DevExpress.XtraEditors.LabelControl
        Me.txtLiteralCadenas = New DevExpress.XtraEditors.TextEdit
        Me.lblLiteralCadenas = New DevExpress.XtraEditors.LabelControl
        Me.txtSimboloDecimal = New DevExpress.XtraEditors.TextEdit
        Me.lblSimboloDecimal = New DevExpress.XtraEditors.LabelControl
        Me.lblRutaLocal = New DevExpress.XtraEditors.LabelControl
        Me.txtRutaLocal = New DevExpress.XtraEditors.TextEdit
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblInterpretacion = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtFormatoFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLiteralFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLiteralCadenas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSimboloDecimal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRutaLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFormatoFechas
        '
        Me.txtFormatoFechas.Location = New System.Drawing.Point(193, 174)
        Me.txtFormatoFechas.Name = "txtFormatoFechas"
        Me.txtFormatoFechas.Size = New System.Drawing.Size(89, 20)
        Me.txtFormatoFechas.TabIndex = 34
        '
        'lblFormatoFechas
        '
        Me.lblFormatoFechas.Location = New System.Drawing.Point(12, 177)
        Me.lblFormatoFechas.Name = "lblFormatoFechas"
        Me.lblFormatoFechas.Size = New System.Drawing.Size(94, 13)
        Me.lblFormatoFechas.TabIndex = 33
        Me.lblFormatoFechas.Text = "Formato de fechas:"
        '
        'txtLiteralFechas
        '
        Me.txtLiteralFechas.Location = New System.Drawing.Point(193, 148)
        Me.txtLiteralFechas.Name = "txtLiteralFechas"
        Me.txtLiteralFechas.Size = New System.Drawing.Size(58, 20)
        Me.txtLiteralFechas.TabIndex = 32
        '
        'lblLiteralFechas
        '
        Me.lblLiteralFechas.Location = New System.Drawing.Point(12, 151)
        Me.lblLiteralFechas.Name = "lblLiteralFechas"
        Me.lblLiteralFechas.Size = New System.Drawing.Size(83, 13)
        Me.lblLiteralFechas.TabIndex = 31
        Me.lblLiteralFechas.Text = "Literal de fechas:"
        '
        'txtLiteralCadenas
        '
        Me.txtLiteralCadenas.Location = New System.Drawing.Point(193, 122)
        Me.txtLiteralCadenas.Name = "txtLiteralCadenas"
        Me.txtLiteralCadenas.Size = New System.Drawing.Size(58, 20)
        Me.txtLiteralCadenas.TabIndex = 30
        '
        'lblLiteralCadenas
        '
        Me.lblLiteralCadenas.Location = New System.Drawing.Point(12, 125)
        Me.lblLiteralCadenas.Name = "lblLiteralCadenas"
        Me.lblLiteralCadenas.Size = New System.Drawing.Size(91, 13)
        Me.lblLiteralCadenas.TabIndex = 29
        Me.lblLiteralCadenas.Text = "Literal de cadenas:"
        '
        'txtSimboloDecimal
        '
        Me.txtSimboloDecimal.Location = New System.Drawing.Point(193, 98)
        Me.txtSimboloDecimal.Name = "txtSimboloDecimal"
        Me.txtSimboloDecimal.Size = New System.Drawing.Size(58, 20)
        Me.txtSimboloDecimal.TabIndex = 28
        '
        'lblSimboloDecimal
        '
        Me.lblSimboloDecimal.Location = New System.Drawing.Point(12, 101)
        Me.lblSimboloDecimal.Name = "lblSimboloDecimal"
        Me.lblSimboloDecimal.Size = New System.Drawing.Size(78, 13)
        Me.lblSimboloDecimal.TabIndex = 27
        Me.lblSimboloDecimal.Text = "Símbolo decimal:"
        '
        'lblRutaLocal
        '
        Me.lblRutaLocal.Location = New System.Drawing.Point(12, 42)
        Me.lblRutaLocal.Name = "lblRutaLocal"
        Me.lblRutaLocal.Size = New System.Drawing.Size(175, 13)
        Me.lblRutaLocal.TabIndex = 35
        Me.lblRutaLocal.Text = "Ruta de acceso de información local:"
        '
        'txtRutaLocal
        '
        Me.txtRutaLocal.Location = New System.Drawing.Point(193, 39)
        Me.txtRutaLocal.Name = "txtRutaLocal"
        Me.txtRutaLocal.Size = New System.Drawing.Size(320, 20)
        Me.txtRutaLocal.TabIndex = 36
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(110, 13)
        Me.lblTitulo.TabIndex = 37
        Me.lblTitulo.Text = "Opciones generales"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(313, 201)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 38
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(416, 201)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 39
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'lblInterpretacion
        '
        Me.lblInterpretacion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterpretacion.Appearance.Options.UseFont = True
        Me.lblInterpretacion.Location = New System.Drawing.Point(12, 72)
        Me.lblInterpretacion.Name = "lblInterpretacion"
        Me.lblInterpretacion.Size = New System.Drawing.Size(107, 13)
        Me.lblInterpretacion.TabIndex = 40
        Me.lblInterpretacion.Text = "Interpretación SQL"
        '
        'frmOpcionesGlobales
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(525, 239)
        Me.Controls.Add(Me.lblInterpretacion)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtRutaLocal)
        Me.Controls.Add(Me.lblRutaLocal)
        Me.Controls.Add(Me.txtFormatoFechas)
        Me.Controls.Add(Me.lblFormatoFechas)
        Me.Controls.Add(Me.txtLiteralFechas)
        Me.Controls.Add(Me.lblLiteralFechas)
        Me.Controls.Add(Me.txtLiteralCadenas)
        Me.Controls.Add(Me.lblLiteralCadenas)
        Me.Controls.Add(Me.txtSimboloDecimal)
        Me.Controls.Add(Me.lblSimboloDecimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcionesGlobales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones globales"
        CType(Me.txtFormatoFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLiteralFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLiteralCadenas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSimboloDecimal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRutaLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFormatoFechas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFormatoFechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLiteralFechas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLiteralFechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLiteralCadenas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLiteralCadenas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSimboloDecimal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSimboloDecimal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRutaLocal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRutaLocal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblInterpretacion As DevExpress.XtraEditors.LabelControl
End Class
