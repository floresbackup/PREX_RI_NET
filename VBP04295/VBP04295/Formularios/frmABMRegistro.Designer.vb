<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMRegistro
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
      Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
      Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
      Me.Cont = New DevExpress.XtraEditors.XtraScrollableControl
      CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanTop.SuspendLayout()
      CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.PanTop.Size = New System.Drawing.Size(575, 54)
      Me.PanTop.TabIndex = 7
      '
      'lblSubtitulo
      '
      Me.lblSubtitulo.Location = New System.Drawing.Point(34, 29)
      Me.lblSubtitulo.Name = "lblSubtitulo"
      Me.lblSubtitulo.Size = New System.Drawing.Size(201, 13)
      Me.lblSubtitulo.TabIndex = 2
      Me.lblSubtitulo.Text = "Complete los datos y haga clic en Guardar"
      '
      'lblTitulo
      '
      Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
      Me.lblTitulo.Appearance.Options.UseFont = True
      Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Size = New System.Drawing.Size(208, 13)
      Me.lblTitulo.TabIndex = 1
      Me.lblTitulo.Text = "Alta, Baja y Modificacion de registros"
      '
      'picLogo
      '
      Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
      Me.picLogo.EditValue = Global.VBP04295.My.Resources.Resources.Work_Sheet_New
      Me.picLogo.Location = New System.Drawing.Point(514, 2)
      Me.picLogo.Name = "picLogo"
      Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
      Me.picLogo.Properties.Appearance.Options.UseBackColor = True
      Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
      Me.picLogo.Size = New System.Drawing.Size(59, 50)
      Me.picLogo.TabIndex = 0
      '
      'cmdCancelar
      '
      Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.cmdCancelar.Location = New System.Drawing.Point(466, 100)
      Me.cmdCancelar.Name = "cmdCancelar"
      Me.cmdCancelar.Size = New System.Drawing.Size(95, 22)
      Me.cmdCancelar.TabIndex = 8
      Me.cmdCancelar.Text = "&Cancelar"
      '
      'cmdGuardar
      '
      Me.cmdGuardar.Location = New System.Drawing.Point(365, 100)
      Me.cmdGuardar.Name = "cmdGuardar"
      Me.cmdGuardar.Size = New System.Drawing.Size(95, 22)
      Me.cmdGuardar.TabIndex = 9
      Me.cmdGuardar.Text = "&Guardar"
      '
      'Cont
      '
      Me.Cont.Location = New System.Drawing.Point(12, 60)
      Me.Cont.Name = "Cont"
      Me.Cont.Size = New System.Drawing.Size(549, 28)
      Me.Cont.TabIndex = 10
      '
      'frmABMRegistro
      '
      Me.AcceptButton = Me.cmdGuardar
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.cmdCancelar
      Me.ClientSize = New System.Drawing.Size(575, 129)
      Me.Controls.Add(Me.Cont)
      Me.Controls.Add(Me.cmdGuardar)
      Me.Controls.Add(Me.cmdCancelar)
      Me.Controls.Add(Me.PanTop)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmABMRegistro"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = " ABM de Registros"
      CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanTop.ResumeLayout(False)
      Me.PanTop.PerformLayout()
      CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
   Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
   Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents Cont As DevExpress.XtraEditors.XtraScrollableControl
End Class
