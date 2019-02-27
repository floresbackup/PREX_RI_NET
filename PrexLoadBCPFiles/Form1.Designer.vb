<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtPathBCP = New System.Windows.Forms.TextBox()
		Me.txtPathFMT = New System.Windows.Forms.TextBox()
		Me.txtDecimalSeparator = New System.Windows.Forms.TextBox()
		Me.txtSQLUser = New System.Windows.Forms.TextBox()
		Me.txtSQLServer = New System.Windows.Forms.TextBox()
		Me.txtUserPass = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtDataBase = New System.Windows.Forms.TextBox()
		Me.btnDialogFMT = New System.Windows.Forms.Button()
		Me.btnProcesar = New System.Windows.Forms.Button()
		Me.btnDialogBCP = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.progressBar = New System.Windows.Forms.ProgressBar()
		Me.lblProgress = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(22, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(134, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Directorio de archivos BCP"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(21, 38)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(135, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Directorio de archivos FMT"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(86, 98)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(70, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Servidor SQL"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(48, 64)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(108, 13)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Separador Decimales"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(344, 124)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(61, 13)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Contraseña"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(113, 124)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(43, 13)
		Me.Label6.TabIndex = 2
		Me.Label6.Text = "Usuario"
		'
		'txtPathBCP
		'
		Me.txtPathBCP.Location = New System.Drawing.Point(162, 9)
		Me.txtPathBCP.Name = "txtPathBCP"
		Me.txtPathBCP.ReadOnly = True
		Me.txtPathBCP.Size = New System.Drawing.Size(340, 20)
		Me.txtPathBCP.TabIndex = 4
		Me.txtPathBCP.TabStop = False
		'
		'txtPathFMT
		'
		Me.txtPathFMT.Location = New System.Drawing.Point(162, 35)
		Me.txtPathFMT.Name = "txtPathFMT"
		Me.txtPathFMT.ReadOnly = True
		Me.txtPathFMT.Size = New System.Drawing.Size(340, 20)
		Me.txtPathFMT.TabIndex = 4
		Me.txtPathFMT.TabStop = False
		'
		'txtDecimalSeparator
		'
		Me.txtDecimalSeparator.Location = New System.Drawing.Point(161, 61)
		Me.txtDecimalSeparator.Name = "txtDecimalSeparator"
		Me.txtDecimalSeparator.Size = New System.Drawing.Size(25, 20)
		Me.txtDecimalSeparator.TabIndex = 3
		'
		'txtSQLUser
		'
		Me.txtSQLUser.Location = New System.Drawing.Point(161, 121)
		Me.txtSQLUser.Name = "txtSQLUser"
		Me.txtSQLUser.Size = New System.Drawing.Size(137, 20)
		Me.txtSQLUser.TabIndex = 6
		'
		'txtSQLServer
		'
		Me.txtSQLServer.Location = New System.Drawing.Point(162, 95)
		Me.txtSQLServer.Name = "txtSQLServer"
		Me.txtSQLServer.Size = New System.Drawing.Size(136, 20)
		Me.txtSQLServer.TabIndex = 4
		'
		'txtUserPass
		'
		Me.txtUserPass.Location = New System.Drawing.Point(411, 121)
		Me.txtUserPass.Name = "txtUserPass"
		Me.txtUserPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtUserPass.Size = New System.Drawing.Size(123, 20)
		Me.txtUserPass.TabIndex = 7
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(304, 98)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(101, 13)
		Me.Label7.TabIndex = 2
		Me.Label7.Text = "Base Datos Destino"
		'
		'txtDataBase
		'
		Me.txtDataBase.Location = New System.Drawing.Point(411, 95)
		Me.txtDataBase.Name = "txtDataBase"
		Me.txtDataBase.Size = New System.Drawing.Size(123, 20)
		Me.txtDataBase.TabIndex = 5
		'
		'btnDialogFMT
		'
		Me.btnDialogFMT.Image = Global.PrexLoadBCPFiles.My.Resources.Resources.folder_open_16
		Me.btnDialogFMT.Location = New System.Drawing.Point(508, 33)
		Me.btnDialogFMT.Name = "btnDialogFMT"
		Me.btnDialogFMT.Size = New System.Drawing.Size(26, 23)
		Me.btnDialogFMT.TabIndex = 2
		Me.btnDialogFMT.UseVisualStyleBackColor = True
		'
		'btnProcesar
		'
		Me.btnProcesar.Image = Global.PrexLoadBCPFiles.My.Resources.Resources.save16x16_8_bit
		Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnProcesar.Location = New System.Drawing.Point(459, 181)
		Me.btnProcesar.Name = "btnProcesar"
		Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
		Me.btnProcesar.TabIndex = 8
		Me.btnProcesar.Text = "Procesar"
		Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnProcesar.UseVisualStyleBackColor = True
		'
		'btnDialogBCP
		'
		Me.btnDialogBCP.Image = Global.PrexLoadBCPFiles.My.Resources.Resources.folder_open_16
		Me.btnDialogBCP.Location = New System.Drawing.Point(508, 7)
		Me.btnDialogBCP.Name = "btnDialogBCP"
		Me.btnDialogBCP.Size = New System.Drawing.Size(26, 23)
		Me.btnDialogBCP.TabIndex = 1
		Me.btnDialogBCP.UseVisualStyleBackColor = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'progressBar
		'
		Me.progressBar.Location = New System.Drawing.Point(12, 181)
		Me.progressBar.Name = "progressBar"
		Me.progressBar.Size = New System.Drawing.Size(441, 23)
		Me.progressBar.TabIndex = 9
		Me.progressBar.Value = 50
		Me.progressBar.Visible = False
		'
		'lblProgress
		'
		Me.lblProgress.AutoSize = True
		Me.lblProgress.Location = New System.Drawing.Point(13, 165)
		Me.lblProgress.Name = "lblProgress"
		Me.lblProgress.Size = New System.Drawing.Size(39, 13)
		Me.lblProgress.TabIndex = 10
		Me.lblProgress.Text = "Label8"
		Me.lblProgress.Visible = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(564, 225)
		Me.Controls.Add(Me.lblProgress)
		Me.Controls.Add(Me.progressBar)
		Me.Controls.Add(Me.btnDialogFMT)
		Me.Controls.Add(Me.btnProcesar)
		Me.Controls.Add(Me.btnDialogBCP)
		Me.Controls.Add(Me.txtUserPass)
		Me.Controls.Add(Me.txtDataBase)
		Me.Controls.Add(Me.txtSQLServer)
		Me.Controls.Add(Me.txtSQLUser)
		Me.Controls.Add(Me.txtDecimalSeparator)
		Me.Controls.Add(Me.txtPathFMT)
		Me.Controls.Add(Me.txtPathBCP)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents txtPathBCP As TextBox
	Friend WithEvents txtPathFMT As TextBox
	Friend WithEvents txtDecimalSeparator As TextBox
	Friend WithEvents txtSQLUser As TextBox
	Friend WithEvents txtSQLServer As TextBox
	Friend WithEvents txtUserPass As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtDataBase As TextBox
	Friend WithEvents btnDialogBCP As Button
	Friend WithEvents btnProcesar As Button
	Friend WithEvents btnDialogFMT As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents progressBar As ProgressBar
	Friend WithEvents lblProgress As Label
End Class
