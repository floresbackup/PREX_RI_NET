<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminarConsulta))
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.picWarning = New System.Windows.Forms.PictureBox
        Me.lblWarning01 = New DevExpress.XtraEditors.LabelControl
        Me.lblWarning02 = New DevExpress.XtraEditors.LabelControl
        Me.lblNombreConsulta = New DevExpress.XtraEditors.LabelControl
        CType(Me.picWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(234, 100)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(337, 100)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'picWarning
        '
        Me.picWarning.Image = CType(resources.GetObject("picWarning.Image"), System.Drawing.Image)
        Me.picWarning.Location = New System.Drawing.Point(12, 12)
        Me.picWarning.Name = "picWarning"
        Me.picWarning.Size = New System.Drawing.Size(48, 48)
        Me.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picWarning.TabIndex = 11
        Me.picWarning.TabStop = False
        '
        'lblWarning01
        '
        Me.lblWarning01.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning01.Appearance.Options.UseFont = True
        Me.lblWarning01.Location = New System.Drawing.Point(66, 12)
        Me.lblWarning01.Name = "lblWarning01"
        Me.lblWarning01.Size = New System.Drawing.Size(50, 13)
        Me.lblWarning01.TabIndex = 12
        Me.lblWarning01.Text = "Atención"
        '
        'lblWarning02
        '
        Me.lblWarning02.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning02.Appearance.Options.UseFont = True
        Me.lblWarning02.Location = New System.Drawing.Point(66, 31)
        Me.lblWarning02.Name = "lblWarning02"
        Me.lblWarning02.Size = New System.Drawing.Size(365, 13)
        Me.lblWarning02.TabIndex = 13
        Me.lblWarning02.Text = "La siguiente consulta será eliminada de forma definitiva. ¿ Desea continuar ?"
        '
        'lblNombreConsulta
        '
        Me.lblNombreConsulta.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreConsulta.Appearance.Options.UseFont = True
        Me.lblNombreConsulta.Location = New System.Drawing.Point(66, 65)
        Me.lblNombreConsulta.Name = "lblNombreConsulta"
        Me.lblNombreConsulta.Size = New System.Drawing.Size(58, 16)
        Me.lblNombreConsulta.TabIndex = 14
        Me.lblNombreConsulta.Text = "Atención"
        '
        'frmEliminarConsulta
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(446, 138)
        Me.Controls.Add(Me.lblNombreConsulta)
        Me.Controls.Add(Me.lblWarning02)
        Me.Controls.Add(Me.lblWarning01)
        Me.Controls.Add(Me.picWarning)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEliminarConsulta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar consulta"
        CType(Me.picWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picWarning As System.Windows.Forms.PictureBox
    Friend WithEvents lblWarning01 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblWarning02 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNombreConsulta As DevExpress.XtraEditors.LabelControl
End Class
