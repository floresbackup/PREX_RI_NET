<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormato))
        Me.txtFormato = New DevExpress.XtraEditors.TextEdit
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.lblFormato = New DevExpress.XtraEditors.LabelControl
        Me.txtNombreColumna = New DevExpress.XtraEditors.TextEdit
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblNombreColumna = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoDatos = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblTipoDatos = New DevExpress.XtraEditors.LabelControl
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl
        Me.chkVisible = New DevExpress.XtraEditors.CheckEdit
        CType(Me.txtFormato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreColumna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDatos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFormato
        '
        Me.txtFormato.Location = New System.Drawing.Point(132, 64)
        Me.txtFormato.Name = "txtFormato"
        Me.txtFormato.Size = New System.Drawing.Size(297, 20)
        Me.txtFormato.TabIndex = 2
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(229, 139)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 5
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'lblFormato
        '
        Me.lblFormato.Location = New System.Drawing.Point(12, 67)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(44, 13)
        Me.lblFormato.TabIndex = 21
        Me.lblFormato.Text = "Formato:"
        '
        'txtNombreColumna
        '
        Me.txtNombreColumna.Location = New System.Drawing.Point(132, 12)
        Me.txtNombreColumna.Name = "txtNombreColumna"
        Me.txtNombreColumna.Size = New System.Drawing.Size(297, 20)
        Me.txtNombreColumna.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(332, 139)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'lblNombreColumna
        '
        Me.lblNombreColumna.Location = New System.Drawing.Point(12, 15)
        Me.lblNombreColumna.Name = "lblNombreColumna"
        Me.lblNombreColumna.Size = New System.Drawing.Size(109, 13)
        Me.lblNombreColumna.TabIndex = 20
        Me.lblNombreColumna.Text = "Nombre de la columna:"
        '
        'cboTipoDatos
        '
        Me.cboTipoDatos.Location = New System.Drawing.Point(132, 90)
        Me.cboTipoDatos.Name = "cboTipoDatos"
        Me.cboTipoDatos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDatos.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoDatos.Size = New System.Drawing.Size(297, 20)
        Me.cboTipoDatos.TabIndex = 3
        '
        'lblTipoDatos
        '
        Me.lblTipoDatos.Location = New System.Drawing.Point(12, 93)
        Me.lblTipoDatos.Name = "lblTipoDatos"
        Me.lblTipoDatos.Size = New System.Drawing.Size(69, 13)
        Me.lblTipoDatos.TabIndex = 25
        Me.lblTipoDatos.Text = "Tipo de datos:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(132, 38)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(297, 20)
        Me.txtTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(12, 41)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(98, 13)
        Me.lblTitulo.TabIndex = 27
        Me.lblTitulo.Text = "Título de la columna:"
        '
        'chkVisible
        '
        Me.chkVisible.EditValue = True
        Me.chkVisible.Location = New System.Drawing.Point(12, 139)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Properties.Caption = "Visible en grillas"
        Me.chkVisible.Size = New System.Drawing.Size(174, 19)
        Me.chkVisible.TabIndex = 28
        '
        'frmFormato
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(441, 186)
        Me.Controls.Add(Me.chkVisible)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cboTipoDatos)
        Me.Controls.Add(Me.lblTipoDatos)
        Me.Controls.Add(Me.txtFormato)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblFormato)
        Me.Controls.Add(Me.txtNombreColumna)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblNombreColumna)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFormato"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formato"
        CType(Me.txtFormato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreColumna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDatos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFormato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblFormato As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreColumna As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNombreColumna As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoDatos As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblTipoDatos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkVisible As DevExpress.XtraEditors.CheckEdit
End Class
