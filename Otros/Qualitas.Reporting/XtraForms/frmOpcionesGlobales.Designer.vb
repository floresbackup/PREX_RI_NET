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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcionesGlobales))
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.grpTitulo = New DevExpress.XtraEditors.GroupControl
        Me.txtRutaLocal = New DevExpress.XtraEditors.TextEdit
        Me.lblRutaLocal = New DevExpress.XtraEditors.LabelControl
        Me.grpOtras = New DevExpress.XtraEditors.GroupControl
        Me.chkEnableSQL = New DevExpress.XtraEditors.CheckEdit
        Me.grpDisenadoVisual = New DevExpress.XtraEditors.GroupControl
        Me.chkSPs = New DevExpress.XtraEditors.CheckEdit
        Me.chkVistas = New DevExpress.XtraEditors.CheckEdit
        Me.chkTablas = New DevExpress.XtraEditors.CheckEdit
        Me.grpInterpretacion = New DevExpress.XtraEditors.GroupControl
        Me.txtFormatoFechas = New DevExpress.XtraEditors.TextEdit
        Me.lblFormatoFechas = New DevExpress.XtraEditors.LabelControl
        Me.txtLiteralFechas = New DevExpress.XtraEditors.TextEdit
        Me.lblLiteralFechas = New DevExpress.XtraEditors.LabelControl
        Me.txtLiteralCadenas = New DevExpress.XtraEditors.TextEdit
        Me.lblLiteralCadenas = New DevExpress.XtraEditors.LabelControl
        Me.txtSimboloDecimal = New DevExpress.XtraEditors.TextEdit
        Me.lblSimboloDecimal = New DevExpress.XtraEditors.LabelControl
        CType(Me.grpTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitulo.SuspendLayout()
        CType(Me.txtRutaLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOtras.SuspendLayout()
        CType(Me.chkEnableSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDisenadoVisual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDisenadoVisual.SuspendLayout()
        CType(Me.chkSPs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVistas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTablas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpInterpretacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInterpretacion.SuspendLayout()
        CType(Me.txtFormatoFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLiteralFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLiteralCadenas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSimboloDecimal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(312, 312)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(415, 312)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'grpTitulo
        '
        Me.grpTitulo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTitulo.AppearanceCaption.Options.UseFont = True
        Me.grpTitulo.Controls.Add(Me.txtRutaLocal)
        Me.grpTitulo.Controls.Add(Me.lblRutaLocal)
        Me.grpTitulo.Location = New System.Drawing.Point(12, 12)
        Me.grpTitulo.Name = "grpTitulo"
        Me.grpTitulo.Size = New System.Drawing.Size(500, 64)
        Me.grpTitulo.TabIndex = 45
        Me.grpTitulo.Text = "Opciones generales"
        '
        'txtRutaLocal
        '
        Me.txtRutaLocal.Location = New System.Drawing.Point(186, 29)
        Me.txtRutaLocal.Name = "txtRutaLocal"
        Me.txtRutaLocal.Size = New System.Drawing.Size(297, 20)
        Me.txtRutaLocal.TabIndex = 0
        '
        'lblRutaLocal
        '
        Me.lblRutaLocal.Location = New System.Drawing.Point(5, 32)
        Me.lblRutaLocal.Name = "lblRutaLocal"
        Me.lblRutaLocal.Size = New System.Drawing.Size(175, 13)
        Me.lblRutaLocal.TabIndex = 37
        Me.lblRutaLocal.Text = "Ruta de acceso de información local:"
        '
        'grpOtras
        '
        Me.grpOtras.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOtras.AppearanceCaption.Options.UseFont = True
        Me.grpOtras.Controls.Add(Me.chkEnableSQL)
        Me.grpOtras.Location = New System.Drawing.Point(12, 232)
        Me.grpOtras.Name = "grpOtras"
        Me.grpOtras.Size = New System.Drawing.Size(500, 64)
        Me.grpOtras.TabIndex = 46
        Me.grpOtras.Text = "Otras opciones"
        '
        'chkEnableSQL
        '
        Me.chkEnableSQL.Location = New System.Drawing.Point(8, 29)
        Me.chkEnableSQL.Name = "chkEnableSQL"
        Me.chkEnableSQL.Properties.Caption = "Edición SQL habilitada"
        Me.chkEnableSQL.Size = New System.Drawing.Size(208, 19)
        Me.chkEnableSQL.TabIndex = 8
        '
        'grpDisenadoVisual
        '
        Me.grpDisenadoVisual.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDisenadoVisual.AppearanceCaption.Options.UseFont = True
        Me.grpDisenadoVisual.Controls.Add(Me.chkSPs)
        Me.grpDisenadoVisual.Controls.Add(Me.chkVistas)
        Me.grpDisenadoVisual.Controls.Add(Me.chkTablas)
        Me.grpDisenadoVisual.Location = New System.Drawing.Point(12, 85)
        Me.grpDisenadoVisual.Name = "grpDisenadoVisual"
        Me.grpDisenadoVisual.Size = New System.Drawing.Size(212, 141)
        Me.grpDisenadoVisual.TabIndex = 47
        Me.grpDisenadoVisual.Text = "Mostrar en el diseñador visual"
        '
        'chkSPs
        '
        Me.chkSPs.Location = New System.Drawing.Point(8, 79)
        Me.chkSPs.Name = "chkSPs"
        Me.chkSPs.Properties.Caption = "Procedimientos"
        Me.chkSPs.Size = New System.Drawing.Size(147, 19)
        Me.chkSPs.TabIndex = 3
        '
        'chkVistas
        '
        Me.chkVistas.Location = New System.Drawing.Point(8, 54)
        Me.chkVistas.Name = "chkVistas"
        Me.chkVistas.Properties.Caption = "Vistas"
        Me.chkVistas.Size = New System.Drawing.Size(147, 19)
        Me.chkVistas.TabIndex = 2
        '
        'chkTablas
        '
        Me.chkTablas.Location = New System.Drawing.Point(8, 29)
        Me.chkTablas.Name = "chkTablas"
        Me.chkTablas.Properties.Caption = "Tablas"
        Me.chkTablas.Size = New System.Drawing.Size(147, 19)
        Me.chkTablas.TabIndex = 1
        '
        'grpInterpretacion
        '
        Me.grpInterpretacion.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInterpretacion.AppearanceCaption.Options.UseFont = True
        Me.grpInterpretacion.Controls.Add(Me.txtFormatoFechas)
        Me.grpInterpretacion.Controls.Add(Me.lblFormatoFechas)
        Me.grpInterpretacion.Controls.Add(Me.txtLiteralFechas)
        Me.grpInterpretacion.Controls.Add(Me.lblLiteralFechas)
        Me.grpInterpretacion.Controls.Add(Me.txtLiteralCadenas)
        Me.grpInterpretacion.Controls.Add(Me.lblLiteralCadenas)
        Me.grpInterpretacion.Controls.Add(Me.txtSimboloDecimal)
        Me.grpInterpretacion.Controls.Add(Me.lblSimboloDecimal)
        Me.grpInterpretacion.Location = New System.Drawing.Point(230, 85)
        Me.grpInterpretacion.Name = "grpInterpretacion"
        Me.grpInterpretacion.Size = New System.Drawing.Size(282, 141)
        Me.grpInterpretacion.TabIndex = 5
        Me.grpInterpretacion.Text = "Interpretación SQL"
        '
        'txtFormatoFechas
        '
        Me.txtFormatoFechas.Location = New System.Drawing.Point(192, 104)
        Me.txtFormatoFechas.Name = "txtFormatoFechas"
        Me.txtFormatoFechas.Size = New System.Drawing.Size(73, 20)
        Me.txtFormatoFechas.TabIndex = 7
        '
        'lblFormatoFechas
        '
        Me.lblFormatoFechas.Location = New System.Drawing.Point(11, 107)
        Me.lblFormatoFechas.Name = "lblFormatoFechas"
        Me.lblFormatoFechas.Size = New System.Drawing.Size(94, 13)
        Me.lblFormatoFechas.TabIndex = 41
        Me.lblFormatoFechas.Text = "Formato de fechas:"
        '
        'txtLiteralFechas
        '
        Me.txtLiteralFechas.Location = New System.Drawing.Point(192, 78)
        Me.txtLiteralFechas.Name = "txtLiteralFechas"
        Me.txtLiteralFechas.Size = New System.Drawing.Size(73, 20)
        Me.txtLiteralFechas.TabIndex = 6
        '
        'lblLiteralFechas
        '
        Me.lblLiteralFechas.Location = New System.Drawing.Point(11, 81)
        Me.lblLiteralFechas.Name = "lblLiteralFechas"
        Me.lblLiteralFechas.Size = New System.Drawing.Size(83, 13)
        Me.lblLiteralFechas.TabIndex = 40
        Me.lblLiteralFechas.Text = "Literal de fechas:"
        '
        'txtLiteralCadenas
        '
        Me.txtLiteralCadenas.Location = New System.Drawing.Point(192, 52)
        Me.txtLiteralCadenas.Name = "txtLiteralCadenas"
        Me.txtLiteralCadenas.Size = New System.Drawing.Size(73, 20)
        Me.txtLiteralCadenas.TabIndex = 35
        '
        'lblLiteralCadenas
        '
        Me.lblLiteralCadenas.Location = New System.Drawing.Point(11, 55)
        Me.lblLiteralCadenas.Name = "lblLiteralCadenas"
        Me.lblLiteralCadenas.Size = New System.Drawing.Size(91, 13)
        Me.lblLiteralCadenas.TabIndex = 39
        Me.lblLiteralCadenas.Text = "Literal de cadenas:"
        '
        'txtSimboloDecimal
        '
        Me.txtSimboloDecimal.Location = New System.Drawing.Point(192, 28)
        Me.txtSimboloDecimal.Name = "txtSimboloDecimal"
        Me.txtSimboloDecimal.Size = New System.Drawing.Size(73, 20)
        Me.txtSimboloDecimal.TabIndex = 4
        '
        'lblSimboloDecimal
        '
        Me.lblSimboloDecimal.Location = New System.Drawing.Point(11, 31)
        Me.lblSimboloDecimal.Name = "lblSimboloDecimal"
        Me.lblSimboloDecimal.Size = New System.Drawing.Size(78, 13)
        Me.lblSimboloDecimal.TabIndex = 38
        Me.lblSimboloDecimal.Text = "Símbolo decimal:"
        '
        'frmOpcionesGlobales
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(525, 354)
        Me.Controls.Add(Me.grpInterpretacion)
        Me.Controls.Add(Me.grpDisenadoVisual)
        Me.Controls.Add(Me.grpOtras)
        Me.Controls.Add(Me.grpTitulo)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcionesGlobales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones globales"
        CType(Me.grpTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitulo.ResumeLayout(False)
        Me.grpTitulo.PerformLayout()
        CType(Me.txtRutaLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOtras.ResumeLayout(False)
        CType(Me.chkEnableSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDisenadoVisual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDisenadoVisual.ResumeLayout(False)
        CType(Me.chkSPs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVistas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTablas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpInterpretacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInterpretacion.ResumeLayout(False)
        Me.grpInterpretacion.PerformLayout()
        CType(Me.txtFormatoFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLiteralFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLiteralCadenas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSimboloDecimal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpTitulo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtRutaLocal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRutaLocal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpOtras As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpDisenadoVisual As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkEnableSQL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSPs As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVistas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTablas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpInterpretacion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFormatoFechas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFormatoFechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLiteralFechas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLiteralFechas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLiteralCadenas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLiteralCadenas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSimboloDecimal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSimboloDecimal As DevExpress.XtraEditors.LabelControl
End Class
