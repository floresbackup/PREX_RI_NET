<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim tmrLoad As System.Windows.Forms.Timer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl
        Me.lblCopyright = New DevExpress.XtraEditors.LabelControl
        Me.picAnimation = New System.Windows.Forms.PictureBox
        tmrLoad = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrLoad
        '
        tmrLoad.Enabled = True
        tmrLoad.Interval = 500
        AddHandler tmrLoad.Tick, AddressOf Me.tmrLoad_Tick
        '
        'lblVersion
        '
        Me.lblVersion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Appearance.Options.UseFont = True
        Me.lblVersion.Location = New System.Drawing.Point(6, 316)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(42, 13)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Version"
        '
        'lblCopyright
        '
        Me.lblCopyright.Location = New System.Drawing.Point(6, 331)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(196, 13)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "Copyright 2008. EDR Business Software."
        '
        'picAnimation
        '
        Me.picAnimation.BackColor = System.Drawing.Color.Transparent
        Me.picAnimation.ErrorImage = Nothing
        Me.picAnimation.Image = CType(resources.GetObject("picAnimation.Image"), System.Drawing.Image)
        Me.picAnimation.Location = New System.Drawing.Point(49, 146)
        Me.picAnimation.Name = "picAnimation"
        Me.picAnimation.Size = New System.Drawing.Size(220, 19)
        Me.picAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picAnimation.TabIndex = 2
        Me.picAnimation.TabStop = False
        Me.picAnimation.Visible = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(508, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.picAnimation)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picAnimation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCopyright As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picAnimation As System.Windows.Forms.PictureBox

End Class
