<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Me.Sintaxis = New WindowsApplication1.SyntaxRTB
      Me.m_Boton = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'Sintaxis
      '
      Me.Sintaxis.AcceptsTab = True
      Me.Sintaxis.CaseSensitive = False
      Me.Sintaxis.Location = New System.Drawing.Point(12, 39)
      Me.Sintaxis.Name = "Sintaxis"
      Me.Sintaxis.Size = New System.Drawing.Size(509, 373)
      Me.Sintaxis.TabIndex = 0
      Me.Sintaxis.Text = ""
      '
      'm_Boton
      '
      Me.m_Boton.Location = New System.Drawing.Point(471, 420)
      Me.m_Boton.Name = "m_Boton"
      Me.m_Boton.Size = New System.Drawing.Size(75, 23)
      Me.m_Boton.TabIndex = 1
      Me.m_Boton.Text = "Salir"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(579, 455)
      Me.Controls.Add(Me.Sintaxis)
      Me.Controls.Add(Me.m_Boton)
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.ResumeLayout(False)

   End Sub

   Private Sintaxis As SyntaxRTB
   Private m_Boton As Windows.Forms.Button

End Class
