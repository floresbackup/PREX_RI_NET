<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesando
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcesando))
      Me.gbProcesando = New System.Windows.Forms.GroupBox
      Me.lblMensajeProceso = New System.Windows.Forms.Label
      Me.lbl = New System.Windows.Forms.Label
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.gbProcesando.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'gbProcesando
      '
      Me.gbProcesando.Controls.Add(Me.lblMensajeProceso)
      Me.gbProcesando.Controls.Add(Me.lbl)
      Me.gbProcesando.Controls.Add(Me.PictureBox1)
      Me.gbProcesando.Location = New System.Drawing.Point(4, -3)
      Me.gbProcesando.Name = "gbProcesando"
      Me.gbProcesando.Size = New System.Drawing.Size(406, 57)
      Me.gbProcesando.TabIndex = 3
      Me.gbProcesando.TabStop = False
      '
      'lblMensajeProceso
      '
      Me.lblMensajeProceso.AutoSize = True
      Me.lblMensajeProceso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMensajeProceso.Location = New System.Drawing.Point(24, 34)
      Me.lblMensajeProceso.Name = "lblMensajeProceso"
      Me.lblMensajeProceso.Size = New System.Drawing.Size(184, 14)
      Me.lblMensajeProceso.TabIndex = 5
      Me.lblMensajeProceso.Text = "Aguarde un instante por favor..."
      '
      'lbl
      '
      Me.lbl.AutoSize = True
      Me.lbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbl.Location = New System.Drawing.Point(14, 13)
      Me.lbl.Name = "lbl"
      Me.lbl.Size = New System.Drawing.Size(95, 18)
      Me.lbl.TabIndex = 4
      Me.lbl.Text = "Procesando"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(366, 20)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
      Me.PictureBox1.TabIndex = 3
      Me.PictureBox1.TabStop = False
      '
      'frmProcesando
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(413, 58)
      Me.ControlBox = False
      Me.Controls.Add(Me.gbProcesando)
      Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmProcesando"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.gbProcesando.ResumeLayout(False)
      Me.gbProcesando.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents gbProcesando As System.Windows.Forms.GroupBox
   Friend WithEvents lblMensajeProceso As System.Windows.Forms.Label
   Friend WithEvents lbl As System.Windows.Forms.Label
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
