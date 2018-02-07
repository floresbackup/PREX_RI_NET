<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionesUsuario
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
        Me.lblIdioma = New DevExpress.XtraEditors.LabelControl
        Me.chkGuardarLayouts = New DevExpress.XtraEditors.CheckEdit
        Me.chkColapsarRibbons = New DevExpress.XtraEditors.CheckEdit
        Me.cmdRestablecerLayouts = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdioma = New DevExpress.XtraEditors.ImageComboBoxEdit
        Me.lblTema = New DevExpress.XtraEditors.LabelControl
        Me.cboTema = New DevExpress.XtraEditors.ComboBoxEdit
        Me.chkIntelliprompt = New DevExpress.XtraEditors.CheckEdit
        Me.chkWelcome = New DevExpress.XtraEditors.CheckEdit
        CType(Me.chkGuardarLayouts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkColapsarRibbons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIdioma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIntelliprompt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkWelcome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIdioma
        '
        Me.lblIdioma.Location = New System.Drawing.Point(12, 12)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(36, 13)
        Me.lblIdioma.TabIndex = 0
        Me.lblIdioma.Text = "Idioma:"
        '
        'chkGuardarLayouts
        '
        Me.chkGuardarLayouts.Location = New System.Drawing.Point(12, 87)
        Me.chkGuardarLayouts.Name = "chkGuardarLayouts"
        Me.chkGuardarLayouts.Properties.Caption = "Guardar diseño de vistas automáticamente"
        Me.chkGuardarLayouts.Size = New System.Drawing.Size(302, 18)
        Me.chkGuardarLayouts.TabIndex = 1
        '
        'chkColapsarRibbons
        '
        Me.chkColapsarRibbons.Location = New System.Drawing.Point(12, 112)
        Me.chkColapsarRibbons.Name = "chkColapsarRibbons"
        Me.chkColapsarRibbons.Properties.Caption = "Iniciar las barras de herramientas colapsadas"
        Me.chkColapsarRibbons.Size = New System.Drawing.Size(302, 18)
        Me.chkColapsarRibbons.TabIndex = 3
        '
        'cmdRestablecerLayouts
        '
        Me.cmdRestablecerLayouts.Location = New System.Drawing.Point(271, 83)
        Me.cmdRestablecerLayouts.Name = "cmdRestablecerLayouts"
        Me.cmdRestablecerLayouts.Size = New System.Drawing.Size(164, 28)
        Me.cmdRestablecerLayouts.TabIndex = 2
        Me.cmdRestablecerLayouts.Text = "Restablecer diseños de vistas"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(337, 186)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(233, 186)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(98, 29)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cboIdioma
        '
        Me.cboIdioma.Location = New System.Drawing.Point(112, 9)
        Me.cboIdioma.Name = "cboIdioma"
        Me.cboIdioma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIdioma.Size = New System.Drawing.Size(323, 20)
        Me.cboIdioma.TabIndex = 0
        '
        'lblTema
        '
        Me.lblTema.Location = New System.Drawing.Point(12, 38)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(94, 13)
        Me.lblTema.TabIndex = 6
        Me.lblTema.Text = "Tema de aplicación:"
        '
        'cboTema
        '
        Me.cboTema.EditValue = "Un solo archivo - Un encabezado por página"
        Me.cboTema.Location = New System.Drawing.Point(112, 35)
        Me.cboTema.Name = "cboTema"
        Me.cboTema.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTema.Properties.Items.AddRange(New Object() {"Caramel", "Money Twins", "Lilian", "The Asphalt World", "iMaginary", "Black", "Blue", "Coffee", "Liquid Sky", "London Liquid Sky", "Glass Oceans", "Stardust", "Office 2007 Black", "Office 2007 Blue", "Office 2007 Silver"})
        Me.cboTema.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTema.Size = New System.Drawing.Size(323, 20)
        Me.cboTema.TabIndex = 7
        '
        'chkIntelliprompt
        '
        Me.chkIntelliprompt.Location = New System.Drawing.Point(12, 137)
        Me.chkIntelliprompt.Name = "chkIntelliprompt"
        Me.chkIntelliprompt.Properties.Caption = "Utilizar Intelliprompt al editar código SQL"
        Me.chkIntelliprompt.Size = New System.Drawing.Size(302, 18)
        Me.chkIntelliprompt.TabIndex = 4
        '
        'chkWelcome
        '
        Me.chkWelcome.Location = New System.Drawing.Point(12, 161)
        Me.chkWelcome.Name = "chkWelcome"
        Me.chkWelcome.Properties.Caption = "Mostrar ventana de bienvenida"
        Me.chkWelcome.Size = New System.Drawing.Size(302, 18)
        Me.chkWelcome.TabIndex = 5
        '
        'frmOpcionesUsuario
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(447, 227)
        Me.Controls.Add(Me.chkWelcome)
        Me.Controls.Add(Me.chkIntelliprompt)
        Me.Controls.Add(Me.cboTema)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.cboIdioma)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdRestablecerLayouts)
        Me.Controls.Add(Me.chkColapsarRibbons)
        Me.Controls.Add(Me.chkGuardarLayouts)
        Me.Controls.Add(Me.lblIdioma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcionesUsuario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferencias de usuario"
        CType(Me.chkGuardarLayouts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkColapsarRibbons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIdioma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIntelliprompt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkWelcome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdioma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkGuardarLayouts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkColapsarRibbons As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdRestablecerLayouts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboIdioma As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents lblTema As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTema As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkIntelliprompt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkWelcome As DevExpress.XtraEditors.CheckEdit
End Class
