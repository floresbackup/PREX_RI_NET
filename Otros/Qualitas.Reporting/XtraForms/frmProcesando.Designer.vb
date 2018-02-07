<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesando
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcesando))
        Me.picAnimation = New System.Windows.Forms.PictureBox
        Me.lblProcesando = New System.Windows.Forms.Label
        Me.lblTip = New System.Windows.Forms.Label
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.picAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAnimation
        '
        Me.picAnimation.ErrorImage = Nothing
        Me.picAnimation.Image = CType(resources.GetObject("picAnimation.Image"), System.Drawing.Image)
        Me.picAnimation.Location = New System.Drawing.Point(22, 12)
        Me.picAnimation.Name = "picAnimation"
        Me.picAnimation.Size = New System.Drawing.Size(43, 41)
        Me.picAnimation.TabIndex = 0
        Me.picAnimation.TabStop = False
        '
        'lblProcesando
        '
        Me.lblProcesando.AutoSize = True
        Me.lblProcesando.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcesando.Location = New System.Drawing.Point(71, 12)
        Me.lblProcesando.Name = "lblProcesando"
        Me.lblProcesando.Size = New System.Drawing.Size(84, 16)
        Me.lblProcesando.TabIndex = 1
        Me.lblProcesando.Text = "Procesando"
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.Location = New System.Drawing.Point(71, 31)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(253, 13)
        Me.lblTip.TabIndex = 2
        Me.lblTip.Text = "Presione el botón cancelar para detener la consulta"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(254, 57)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(104, 26)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Cancelar"
        '
        'frmProcesando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 95)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.lblProcesando)
        Me.Controls.Add(Me.picAnimation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProcesando"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.picAnimation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picAnimation As System.Windows.Forms.PictureBox
    Friend WithEvents lblProcesando As System.Windows.Forms.Label
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
End Class
