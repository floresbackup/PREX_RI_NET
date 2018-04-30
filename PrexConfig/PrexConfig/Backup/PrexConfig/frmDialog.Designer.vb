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
      Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
      Me.OK_Button = New System.Windows.Forms.Button
      Me.Cancel_Button = New System.Windows.Forms.Button
      Me.txtNombre = New DevExpress.XtraEditors.TextEdit
      Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
      Me.txtValor = New DevExpress.XtraEditors.TextEdit
      Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
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
      Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 68)
      Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
      Me.TableLayoutPanel1.RowCount = 1
      Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
      Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
      Me.TableLayoutPanel1.TabIndex = 2
      '
      'OK_Button
      '
      Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.OK_Button.Location = New System.Drawing.Point(3, 3)
      Me.OK_Button.Name = "OK_Button"
      Me.OK_Button.Size = New System.Drawing.Size(67, 23)
      Me.OK_Button.TabIndex = 3
      Me.OK_Button.Text = "Aceptar"
      '
      'Cancel_Button
      '
      Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
      Me.Cancel_Button.Name = "Cancel_Button"
      Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
      Me.Cancel_Button.TabIndex = 4
      Me.Cancel_Button.Text = "Cancelar"
      '
      'txtNombre
      '
      Me.txtNombre.EditValue = ""
      Me.txtNombre.Location = New System.Drawing.Point(133, 8)
      Me.txtNombre.Name = "txtNombre"
      Me.txtNombre.Size = New System.Drawing.Size(290, 22)
      Me.txtNombre.TabIndex = 0
      '
      'LabelControl5
      '
      Me.LabelControl5.Location = New System.Drawing.Point(12, 12)
      Me.LabelControl5.Name = "LabelControl5"
      Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
      Me.LabelControl5.TabIndex = 28
      Me.LabelControl5.Text = "Nombre:"
      '
      'txtValor
      '
      Me.txtValor.EditValue = ""
      Me.txtValor.Location = New System.Drawing.Point(133, 40)
      Me.txtValor.Name = "txtValor"
      Me.txtValor.Size = New System.Drawing.Size(290, 22)
      Me.txtValor.TabIndex = 1
      '
      'LabelControl3
      '
      Me.LabelControl3.Location = New System.Drawing.Point(12, 44)
      Me.LabelControl3.Name = "LabelControl3"
      Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
      Me.LabelControl3.TabIndex = 34
      Me.LabelControl3.Text = "Valor:"
      '
      'frmDialog
      '
      Me.AcceptButton = Me.OK_Button
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Cancel_Button
      Me.ClientSize = New System.Drawing.Size(435, 106)
      Me.Controls.Add(Me.txtValor)
      Me.Controls.Add(Me.LabelControl3)
      Me.Controls.Add(Me.txtNombre)
      Me.Controls.Add(Me.LabelControl5)
      Me.Controls.Add(Me.TableLayoutPanel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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

End Class
