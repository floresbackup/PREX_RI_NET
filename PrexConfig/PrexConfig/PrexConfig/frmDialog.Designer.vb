<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialog
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.  
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.OK_Button = New System.Windows.Forms.Button()
		Me.Cancel_Button = New System.Windows.Forms.Button()
		Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		Me.txtValor = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.chkEncrypt = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(369, 128)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
		Me.TableLayoutPanel1.TabIndex = 2
		'
		'OK_Button
		'
		Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.OK_Button.Location = New System.Drawing.Point(4, 4)
		Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.OK_Button.Name = "OK_Button"
		Me.OK_Button.Size = New System.Drawing.Size(89, 28)
		Me.OK_Button.TabIndex = 4
		Me.OK_Button.Text = "Aceptar"
		'
		'Cancel_Button
		'
		Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
		Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Cancel_Button.Name = "Cancel_Button"
		Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
		Me.Cancel_Button.TabIndex = 5
		Me.Cancel_Button.Text = "Cancelar"
		'
		'txtNombre
		'
		Me.txtNombre.EditValue = ""
		Me.txtNombre.Location = New System.Drawing.Point(74, 10)
		Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(490, 24)
		Me.txtNombre.TabIndex = 0
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(16, 15)
		Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(50, 16)
		Me.LabelControl5.TabIndex = 28
		Me.LabelControl5.Text = "Nombre:"
		'
		'txtValor
		'
		Me.txtValor.EditValue = ""
		Me.txtValor.Location = New System.Drawing.Point(74, 49)
		Me.txtValor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtValor.Name = "txtValor"
		Me.txtValor.Size = New System.Drawing.Size(490, 24)
		Me.txtValor.TabIndex = 1
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(31, 54)
		Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(35, 16)
		Me.LabelControl3.TabIndex = 34
		Me.LabelControl3.Text = "Valor:"
		'
		'chkEncrypt
		'
		Me.chkEncrypt.AutoSize = True
		Me.chkEncrypt.Location = New System.Drawing.Point(74, 93)
		Me.chkEncrypt.Name = "chkEncrypt"
		Me.chkEncrypt.Size = New System.Drawing.Size(122, 21)
		Me.chkEncrypt.TabIndex = 3
		Me.chkEncrypt.Text = "Encriptar valor"
		Me.chkEncrypt.UseVisualStyleBackColor = True
		'
		'frmDialog
		'
		Me.AcceptButton = Me.OK_Button
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.Cancel_Button
		Me.ClientSize = New System.Drawing.Size(580, 174)
		Me.Controls.Add(Me.chkEncrypt)
		Me.Controls.Add(Me.txtValor)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.LabelControl5)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmDialog"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = " Prex Config"
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
   Friend WithEvents OK_Button As System.Windows.Forms.Button
   Friend WithEvents Cancel_Button As System.Windows.Forms.Button
   Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
   Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
   Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents chkEncrypt As CheckBox
End Class
