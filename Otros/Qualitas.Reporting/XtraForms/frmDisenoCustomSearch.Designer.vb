<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisenoCustomSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisenoCustomSearch))
        Me.chkHabilitar = New DevExpress.XtraEditors.CheckEdit
        Me.grpParametros = New DevExpress.XtraEditors.GroupControl
        Me.txtVariable = New DevExpress.XtraEditors.TextEdit
        Me.txtMensaje = New DevExpress.XtraEditors.TextEdit
        Me.lblVariable = New DevExpress.XtraEditors.LabelControl
        Me.lblMensaje = New DevExpress.XtraEditors.LabelControl
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.chkHabilitar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParametros.SuspendLayout()
        CType(Me.txtVariable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMensaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkHabilitar
        '
        Me.chkHabilitar.Location = New System.Drawing.Point(13, 13)
        Me.chkHabilitar.Name = "chkHabilitar"
        Me.chkHabilitar.Properties.Caption = "Habilitar búsqueda personalizada"
        Me.chkHabilitar.Size = New System.Drawing.Size(264, 19)
        Me.chkHabilitar.TabIndex = 0
        '
        'grpParametros
        '
        Me.grpParametros.Controls.Add(Me.txtVariable)
        Me.grpParametros.Controls.Add(Me.txtMensaje)
        Me.grpParametros.Controls.Add(Me.lblVariable)
        Me.grpParametros.Controls.Add(Me.lblMensaje)
        Me.grpParametros.Enabled = False
        Me.grpParametros.Location = New System.Drawing.Point(12, 38)
        Me.grpParametros.Name = "grpParametros"
        Me.grpParametros.Size = New System.Drawing.Size(408, 100)
        Me.grpParametros.TabIndex = 1
        Me.grpParametros.Text = "Parámetros de la búsqueda"
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(229, 72)
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(163, 20)
        Me.txtVariable.TabIndex = 3
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(11, 47)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(381, 20)
        Me.txtMensaje.TabIndex = 2
        '
        'lblVariable
        '
        Me.lblVariable.Location = New System.Drawing.Point(11, 75)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(181, 13)
        Me.lblVariable.TabIndex = 1
        Me.lblVariable.Text = "Variable en SQL de ayuda contextual:"
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(11, 31)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(97, 13)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "Mensaje instructivo:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(223, 156)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 11
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(326, 156)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(97, 26)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmDisenoCustomSearch
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(435, 199)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.grpParametros)
        Me.Controls.Add(Me.chkHabilitar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDisenoCustomSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda personalizada"
        CType(Me.chkHabilitar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParametros.ResumeLayout(False)
        Me.grpParametros.PerformLayout()
        CType(Me.txtVariable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMensaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkHabilitar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpParametros As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblMensaje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMensaje As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblVariable As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVariable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
End Class
