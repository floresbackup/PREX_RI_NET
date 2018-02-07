<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearPeriodo
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
      Me.PanTop = New DevExpress.XtraEditors.PanelControl
      Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl
      Me.lblTitulo = New DevExpress.XtraEditors.LabelControl
      Me.picLogo = New DevExpress.XtraEditors.PictureEdit
      Me.lblPregunta = New DevExpress.XtraEditors.LabelControl
      Me.panDatos = New DevExpress.XtraEditors.PanelControl
      Me.lblPeriodo = New DevExpress.XtraEditors.LabelControl
      Me.cboFecVig = New DevExpress.XtraEditors.ComboBoxEdit
      Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
      Me.cmdCrearPeriodo = New DevExpress.XtraEditors.SimpleButton
      Me.chkDatos = New DevExpress.XtraEditors.CheckEdit
      CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanTop.SuspendLayout()
      CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.panDatos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panDatos.SuspendLayout()
      CType(Me.cboFecVig.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.chkDatos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'PanTop
      '
      Me.PanTop.Appearance.BackColor = System.Drawing.Color.White
      Me.PanTop.Appearance.Options.UseBackColor = True
      Me.PanTop.Controls.Add(Me.lblSubtitulo)
      Me.PanTop.Controls.Add(Me.lblTitulo)
      Me.PanTop.Controls.Add(Me.picLogo)
      Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
      Me.PanTop.Location = New System.Drawing.Point(0, 0)
      Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
      Me.PanTop.Name = "PanTop"
      Me.PanTop.Size = New System.Drawing.Size(392, 54)
      Me.PanTop.TabIndex = 15
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.Location = New System.Drawing.Point(24, 29)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(225, 13)
      Me.lblSubtitulo.TabIndex = 2
      Me.lblSubtitulo.Text = "Indique si desea crear el período e incluir datos"
      '
      'lblTitulo
      '
      Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
      Me.lblTitulo.Appearance.Options.UseFont = True
      Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(110, 13)
      Me.lblTitulo.TabIndex = 1
      Me.lblTitulo.Text = "El período no existe"
      '
      'picLogo
      '
      Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
      Me.picLogo.EditValue = Global.VBP04295.My.Resources.Resources.Calendar
      Me.picLogo.Location = New System.Drawing.Point(331, 2)
      Me.picLogo.Name = "picLogo"
      Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
      Me.picLogo.Properties.Appearance.Options.UseBackColor = True
      Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
      Me.picLogo.Size = New System.Drawing.Size(59, 50)
      Me.picLogo.TabIndex = 0
      '
      'lblPregunta
      '
      Me.lblPregunta.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPregunta.Appearance.Options.UseFont = True
      Me.lblPregunta.Location = New System.Drawing.Point(61, 80)
      Me.lblPregunta.Name = "lblPregunta"
      Me.lblPregunta.Size = New System.Drawing.Size(248, 18)
      Me.lblPregunta.TabIndex = 16
      Me.lblPregunta.Text = "¿ Desea crear un nuevo período ?"
      '
      'panDatos
      '
      Me.panDatos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
      Me.panDatos.Controls.Add(Me.lblPeriodo)
      Me.panDatos.Controls.Add(Me.cboFecVig)
      Me.panDatos.Location = New System.Drawing.Point(12, 130)
      Me.panDatos.Name = "panDatos"
      Me.panDatos.Size = New System.Drawing.Size(368, 53)
      Me.panDatos.TabIndex = 19
      '
      'lblPeriodo
      '
      Me.lblPeriodo.Location = New System.Drawing.Point(12, 21)
      Me.lblPeriodo.Name = "lblPeriodo"
      Me.lblPeriodo.Size = New System.Drawing.Size(40, 13)
      Me.lblPeriodo.TabIndex = 20
      Me.lblPeriodo.Text = "Período:"
      '
      'cboFecVig
      '
      Me.cboFecVig.Enabled = False
      Me.cboFecVig.Location = New System.Drawing.Point(70, 18)
      Me.cboFecVig.Name = "cboFecVig"
      Me.cboFecVig.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
      Me.cboFecVig.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
      Me.cboFecVig.Size = New System.Drawing.Size(286, 20)
      Me.cboFecVig.TabIndex = 19
      '
      'cmdCancelar
      '
      Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.cmdCancelar.Location = New System.Drawing.Point(296, 196)
      Me.cmdCancelar.Name = "cmdCancelar"
      Me.cmdCancelar.Size = New System.Drawing.Size(84, 23)
      Me.cmdCancelar.TabIndex = 20
      Me.cmdCancelar.Text = "&Cancelar"
      '
      'cmdCrearPeriodo
      '
      Me.cmdCrearPeriodo.Location = New System.Drawing.Point(206, 196)
      Me.cmdCrearPeriodo.Name = "cmdCrearPeriodo"
      Me.cmdCrearPeriodo.Size = New System.Drawing.Size(84, 23)
      Me.cmdCrearPeriodo.TabIndex = 21
      Me.cmdCrearPeriodo.Text = "Crear &Período"
      '
      'chkDatos
      '
      Me.chkDatos.Location = New System.Drawing.Point(25, 121)
      Me.chkDatos.Name = "chkDatos"
      Me.chkDatos.Properties.Caption = "Incluir los datos del período:"
      Me.chkDatos.Size = New System.Drawing.Size(153, 18)
      Me.chkDatos.TabIndex = 22
      '
      'frmCrearPeriodo
      '
      Me.AcceptButton = Me.cmdCrearPeriodo
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.cmdCancelar
      Me.ClientSize = New System.Drawing.Size(392, 228)
      Me.Controls.Add(Me.chkDatos)
      Me.Controls.Add(Me.cmdCrearPeriodo)
      Me.Controls.Add(Me.cmdCancelar)
      Me.Controls.Add(Me.panDatos)
      Me.Controls.Add(Me.lblPregunta)
      Me.Controls.Add(Me.PanTop)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCrearPeriodo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Crear período"
      CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanTop.ResumeLayout(False)
      Me.PanTop.PerformLayout()
      CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.panDatos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panDatos.ResumeLayout(False)
      Me.panDatos.PerformLayout()
      CType(Me.cboFecVig.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.chkDatos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
   Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
   Friend WithEvents lblPregunta As DevExpress.XtraEditors.LabelControl
   Friend WithEvents panDatos As DevExpress.XtraEditors.PanelControl
   Friend WithEvents lblPeriodo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents cboFecVig As DevExpress.XtraEditors.ComboBoxEdit
   Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cmdCrearPeriodo As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents chkDatos As DevExpress.XtraEditors.CheckEdit
End Class
