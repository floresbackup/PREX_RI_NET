<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColumnaCubo
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
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblNombreColumna = New DevExpress.XtraEditors.LabelControl
        Me.txtNombreColumna = New DevExpress.XtraEditors.TextEdit
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl
        Me.lblUbicacion = New DevExpress.XtraEditors.LabelControl
        Me.cboUbicacion = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtFormato = New DevExpress.XtraEditors.TextEdit
        Me.lblFormato = New DevExpress.XtraEditors.LabelControl
        Me.cboFuncion = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblFuncion = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoResumen = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblTipoResumen = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoFormato = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboColumnas = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.txtNombreColumna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUbicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFuncion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoResumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoFormato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboColumnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(192, 186)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(295, 186)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'lblNombreColumna
        '
        Me.lblNombreColumna.Location = New System.Drawing.Point(12, 12)
        Me.lblNombreColumna.Name = "lblNombreColumna"
        Me.lblNombreColumna.Size = New System.Drawing.Size(109, 13)
        Me.lblNombreColumna.TabIndex = 8
        Me.lblNombreColumna.Text = "Nombre de la columna:"
        '
        'txtNombreColumna
        '
        Me.txtNombreColumna.Enabled = False
        Me.txtNombreColumna.Location = New System.Drawing.Point(127, 9)
        Me.txtNombreColumna.Name = "txtNombreColumna"
        Me.txtNombreColumna.Size = New System.Drawing.Size(265, 20)
        Me.txtNombreColumna.TabIndex = 0
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(127, 35)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(265, 20)
        Me.txtTitulo.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(12, 38)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(30, 13)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "T�tulo:"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.Location = New System.Drawing.Point(12, 90)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(49, 13)
        Me.lblUbicacion.TabIndex = 13
        Me.lblUbicacion.Text = "Ubicaci�n:"
        '
        'cboUbicacion
        '
        Me.cboUbicacion.Location = New System.Drawing.Point(127, 87)
        Me.cboUbicacion.Name = "cboUbicacion"
        Me.cboUbicacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUbicacion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUbicacion.Size = New System.Drawing.Size(265, 20)
        Me.cboUbicacion.TabIndex = 5
        '
        'txtFormato
        '
        Me.txtFormato.Location = New System.Drawing.Point(127, 61)
        Me.txtFormato.Name = "txtFormato"
        Me.txtFormato.Size = New System.Drawing.Size(166, 20)
        Me.txtFormato.TabIndex = 3
        '
        'lblFormato
        '
        Me.lblFormato.Location = New System.Drawing.Point(12, 64)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(44, 13)
        Me.lblFormato.TabIndex = 15
        Me.lblFormato.Text = "Formato:"
        '
        'cboFuncion
        '
        Me.cboFuncion.Location = New System.Drawing.Point(127, 113)
        Me.cboFuncion.Name = "cboFuncion"
        Me.cboFuncion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFuncion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFuncion.Size = New System.Drawing.Size(264, 20)
        Me.cboFuncion.TabIndex = 6
        '
        'lblFuncion
        '
        Me.lblFuncion.Location = New System.Drawing.Point(12, 116)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(105, 13)
        Me.lblFuncion.TabIndex = 17
        Me.lblFuncion.Text = "Funci�n de agregado:"
        '
        'cboTipoResumen
        '
        Me.cboTipoResumen.Location = New System.Drawing.Point(127, 139)
        Me.cboTipoResumen.Name = "cboTipoResumen"
        Me.cboTipoResumen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoResumen.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoResumen.Size = New System.Drawing.Size(264, 20)
        Me.cboTipoResumen.TabIndex = 7
        '
        'lblTipoResumen
        '
        Me.lblTipoResumen.Location = New System.Drawing.Point(12, 142)
        Me.lblTipoResumen.Name = "lblTipoResumen"
        Me.lblTipoResumen.Size = New System.Drawing.Size(83, 13)
        Me.lblTipoResumen.TabIndex = 19
        Me.lblTipoResumen.Text = "Tipo de res�men:"
        '
        'cboTipoFormato
        '
        Me.cboTipoFormato.Location = New System.Drawing.Point(299, 61)
        Me.cboTipoFormato.Name = "cboTipoFormato"
        Me.cboTipoFormato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoFormato.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoFormato.Size = New System.Drawing.Size(92, 20)
        Me.cboTipoFormato.TabIndex = 4
        '
        'cboColumnas
        '
        Me.cboColumnas.Location = New System.Drawing.Point(127, 9)
        Me.cboColumnas.Name = "cboColumnas"
        Me.cboColumnas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColumnas.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboColumnas.Size = New System.Drawing.Size(265, 20)
        Me.cboColumnas.TabIndex = 1
        Me.cboColumnas.Visible = False
        '
        'frmColumnaCubo
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(403, 223)
        Me.Controls.Add(Me.cboTipoFormato)
        Me.Controls.Add(Me.cboTipoResumen)
        Me.Controls.Add(Me.lblTipoResumen)
        Me.Controls.Add(Me.cboFuncion)
        Me.Controls.Add(Me.lblFuncion)
        Me.Controls.Add(Me.txtFormato)
        Me.Controls.Add(Me.lblFormato)
        Me.Controls.Add(Me.cboUbicacion)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtNombreColumna)
        Me.Controls.Add(Me.lblNombreColumna)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cboColumnas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColumnaCubo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Columna"
        CType(Me.txtNombreColumna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUbicacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFuncion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoResumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoFormato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboColumnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNombreColumna As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreColumna As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUbicacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboUbicacion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtFormato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFormato As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFuncion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblFuncion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoResumen As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblTipoResumen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoFormato As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboColumnas As DevExpress.XtraEditors.ComboBoxEdit
End Class
