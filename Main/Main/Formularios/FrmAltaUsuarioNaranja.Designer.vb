<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaUsuarioNaranja
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtApellido = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtUsusario = New System.Windows.Forms.TextBox()
		Me.cboGrupos = New System.Windows.Forms.ComboBox()
		Me.btnAceptar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(11, 59)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(62, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Nombre:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(11, 89)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(62, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Apellido:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(21, 120)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(52, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Grupo:"
		'
		'txtNombre
		'
		Me.txtNombre.Location = New System.Drawing.Point(90, 56)
		Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(211, 22)
		Me.txtNombre.TabIndex = 2
		'
		'txtApellido
		'
		Me.txtApellido.Location = New System.Drawing.Point(90, 86)
		Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
		Me.txtApellido.Name = "txtApellido"
		Me.txtApellido.Size = New System.Drawing.Size(211, 22)
		Me.txtApellido.TabIndex = 3
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 29)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(61, 17)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Usuario:"
		'
		'txtUsusario
		'
		Me.txtUsusario.Location = New System.Drawing.Point(90, 26)
		Me.txtUsusario.Margin = New System.Windows.Forms.Padding(4)
		Me.txtUsusario.Name = "txtUsusario"
		Me.txtUsusario.ReadOnly = True
		Me.txtUsusario.Size = New System.Drawing.Size(211, 22)
		Me.txtUsusario.TabIndex = 1
		'
		'cboGrupos
		'
		Me.cboGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboGrupos.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cboGrupos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboGrupos.FormattingEnabled = True
		Me.cboGrupos.Location = New System.Drawing.Point(90, 116)
		Me.cboGrupos.Margin = New System.Windows.Forms.Padding(4)
		Me.cboGrupos.Name = "cboGrupos"
		Me.cboGrupos.Size = New System.Drawing.Size(211, 25)
		Me.cboGrupos.TabIndex = 4
		'
		'btnAceptar
		'
		Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnAceptar.Location = New System.Drawing.Point(176, 167)
		Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAceptar.Name = "btnAceptar"
		Me.btnAceptar.Size = New System.Drawing.Size(125, 28)
		Me.btnAceptar.TabIndex = 5
		Me.btnAceptar.Text = "&Aceptar"
		'
		'FrmAltaUsuarioNaranja
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(328, 211)
		Me.Controls.Add(Me.btnAceptar)
		Me.Controls.Add(Me.cboGrupos)
		Me.Controls.Add(Me.txtApellido)
		Me.Controls.Add(Me.txtUsusario)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmAltaUsuarioNaranja"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Nuevo usuario"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtNombre As TextBox
	Friend WithEvents txtApellido As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtUsusario As TextBox
	Friend WithEvents cboGrupos As ComboBox
	Friend WithEvents btnAceptar As Button
End Class
