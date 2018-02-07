<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
      Me.Label1 = New System.Windows.Forms.Label
      Me.lblEmpresa = New System.Windows.Forms.Label
      Me.lblLegales = New System.Windows.Forms.Label
      Me.lblVersion = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.lblEquipo = New System.Windows.Forms.Label
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label1.Location = New System.Drawing.Point(1, 331)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(186, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Se autoriza el uso de este producto a:"
      '
      'lblEmpresa
      '
      Me.lblEmpresa.AutoSize = True
      Me.lblEmpresa.BackColor = System.Drawing.Color.Transparent
      Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblEmpresa.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblEmpresa.Location = New System.Drawing.Point(2, 346)
      Me.lblEmpresa.Name = "lblEmpresa"
      Me.lblEmpresa.Size = New System.Drawing.Size(94, 13)
      Me.lblEmpresa.TabIndex = 1
      Me.lblEmpresa.Text = "EMPRESA XXX"
      '
      'lblLegales
      '
      Me.lblLegales.AutoSize = True
      Me.lblLegales.BackColor = System.Drawing.Color.Transparent
      Me.lblLegales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblLegales.ForeColor = System.Drawing.Color.AliceBlue
      Me.lblLegales.Location = New System.Drawing.Point(2, 362)
      Me.lblLegales.Name = "lblLegales"
      Me.lblLegales.Size = New System.Drawing.Size(349, 13)
      Me.lblLegales.TabIndex = 2
      Me.lblLegales.Text = "Proyecto Excelencia SRL®. Todos los derechos reservados."
      '
      'lblVersion
      '
      Me.lblVersion.BackColor = System.Drawing.Color.Transparent
      Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblVersion.ForeColor = System.Drawing.Color.AliceBlue
      Me.lblVersion.Location = New System.Drawing.Point(416, 363)
      Me.lblVersion.Name = "lblVersion"
      Me.lblVersion.Size = New System.Drawing.Size(121, 13)
      Me.lblVersion.TabIndex = 3
      Me.lblVersion.Text = "Versión #.##.##"
      Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
      Me.Label2.Location = New System.Drawing.Point(246, 281)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(265, 45)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "Solución integral para entidades financieras de la presentación de los diferentes" & _
          " regímenes informativos al BCRA (Banco Central de la República Argentina)."
      '
      'lblEquipo
      '
      Me.lblEquipo.BackColor = System.Drawing.Color.Transparent
      Me.lblEquipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblEquipo.ForeColor = System.Drawing.Color.Black
      Me.lblEquipo.Location = New System.Drawing.Point(241, 80)
      Me.lblEquipo.Name = "lblEquipo"
      Me.lblEquipo.Size = New System.Drawing.Size(265, 202)
      Me.lblEquipo.TabIndex = 5
      '
      'SplashScreen
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
      Me.ClientSize = New System.Drawing.Size(538, 378)
      Me.ControlBox = False
      Me.Controls.Add(Me.lblEquipo)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.lblVersion)
      Me.Controls.Add(Me.lblLegales)
      Me.Controls.Add(Me.lblEmpresa)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "SplashScreen"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblEmpresa As System.Windows.Forms.Label
   Friend WithEvents lblLegales As System.Windows.Forms.Label
   Friend WithEvents lblVersion As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblEquipo As System.Windows.Forms.Label

End Class
