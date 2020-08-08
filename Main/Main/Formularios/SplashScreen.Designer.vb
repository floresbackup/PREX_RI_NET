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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblEmpresa = New System.Windows.Forms.Label()
		Me.lblLegales = New System.Windows.Forms.Label()
		Me.lblVersion = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblFrameworkNet = New System.Windows.Forms.Label()
		Me.pnlDatos = New System.Windows.Forms.Panel()
		Me.pblCitiCiberrark = New System.Windows.Forms.Panel()
		Me.picErrorCiberrark = New System.Windows.Forms.PictureBox()
		Me.lblciti = New System.Windows.Forms.Label()
		Me.picOkCiberrark = New System.Windows.Forms.PictureBox()
		Me.lblEquipo = New System.Windows.Forms.Label()
		Me.pnlDatos.SuspendLayout()
		Me.pblCitiCiberrark.SuspendLayout()
		CType(Me.picErrorCiberrark, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picOkCiberrark, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
		Me.Label1.Location = New System.Drawing.Point(1, 407)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(249, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Se autoriza el uso de este producto a:"
		'
		'lblEmpresa
		'
		Me.lblEmpresa.AutoSize = True
		Me.lblEmpresa.BackColor = System.Drawing.Color.Transparent
		Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEmpresa.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblEmpresa.Location = New System.Drawing.Point(3, 426)
		Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblEmpresa.Name = "lblEmpresa"
		Me.lblEmpresa.Size = New System.Drawing.Size(116, 17)
		Me.lblEmpresa.TabIndex = 1
		Me.lblEmpresa.Text = "EMPRESA XXX"
		'
		'lblLegales
		'
		Me.lblLegales.AutoSize = True
		Me.lblLegales.BackColor = System.Drawing.Color.Transparent
		Me.lblLegales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLegales.ForeColor = System.Drawing.Color.AliceBlue
		Me.lblLegales.Location = New System.Drawing.Point(3, 446)
		Me.lblLegales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblLegales.Name = "lblLegales"
		Me.lblLegales.Size = New System.Drawing.Size(444, 17)
		Me.lblLegales.TabIndex = 2
		Me.lblLegales.Text = "Proyecto Excelencia SRL®. Todos los derechos reservados."
		'
		'lblVersion
		'
		Me.lblVersion.BackColor = System.Drawing.Color.Transparent
		Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersion.ForeColor = System.Drawing.Color.AliceBlue
		Me.lblVersion.Location = New System.Drawing.Point(555, 447)
		Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(161, 16)
		Me.lblVersion.TabIndex = 3
		Me.lblVersion.Text = "Versión #.##.##"
		Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label2
		'
		Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
		Me.Label2.Location = New System.Drawing.Point(325, 334)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(356, 68)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Solución integral para entidades financieras de la presentación de los diferentes" &
	" regímenes informativos al BCRA (Banco Central de la República Argentina)."
		'
		'lblFrameworkNet
		'
		Me.lblFrameworkNet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblFrameworkNet.BackColor = System.Drawing.Color.Transparent
		Me.lblFrameworkNet.ForeColor = System.Drawing.Color.SteelBlue
		Me.lblFrameworkNet.Location = New System.Drawing.Point(529, 385)
		Me.lblFrameworkNet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFrameworkNet.Name = "lblFrameworkNet"
		Me.lblFrameworkNet.Size = New System.Drawing.Size(152, 16)
		Me.lblFrameworkNet.TabIndex = 6
		Me.lblFrameworkNet.Text = ".Net Framework 4.5"
		Me.lblFrameworkNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'pnlDatos
		'
		Me.pnlDatos.AutoScroll = True
		Me.pnlDatos.BackColor = System.Drawing.Color.Transparent
		Me.pnlDatos.Controls.Add(Me.pblCitiCiberrark)
		Me.pnlDatos.Controls.Add(Me.lblEquipo)
		Me.pnlDatos.Location = New System.Drawing.Point(305, 90)
		Me.pnlDatos.Margin = New System.Windows.Forms.Padding(0)
		Me.pnlDatos.Name = "pnlDatos"
		Me.pnlDatos.Size = New System.Drawing.Size(382, 235)
		Me.pnlDatos.TabIndex = 7
		'
		'pblCitiCiberrark
		'
		Me.pblCitiCiberrark.BackColor = System.Drawing.Color.Transparent
		Me.pblCitiCiberrark.Controls.Add(Me.picErrorCiberrark)
		Me.pblCitiCiberrark.Controls.Add(Me.lblciti)
		Me.pblCitiCiberrark.Controls.Add(Me.picOkCiberrark)
		Me.pblCitiCiberrark.Location = New System.Drawing.Point(0, 210)
		Me.pblCitiCiberrark.Name = "pblCitiCiberrark"
		Me.pblCitiCiberrark.Size = New System.Drawing.Size(242, 30)
		Me.pblCitiCiberrark.TabIndex = 13
		Me.pblCitiCiberrark.Visible = False
		'
		'picErrorCiberrark
		'
		Me.picErrorCiberrark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picErrorCiberrark.Image = CType(resources.GetObject("picErrorCiberrark.Image"), System.Drawing.Image)
		Me.picErrorCiberrark.Location = New System.Drawing.Point(0, 2)
		Me.picErrorCiberrark.Margin = New System.Windows.Forms.Padding(4)
		Me.picErrorCiberrark.Name = "picErrorCiberrark"
		Me.picErrorCiberrark.Size = New System.Drawing.Size(24, 24)
		Me.picErrorCiberrark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picErrorCiberrark.TabIndex = 11
		Me.picErrorCiberrark.TabStop = False
		'
		'lblciti
		'
		Me.lblciti.AutoSize = True
		Me.lblciti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblciti.Location = New System.Drawing.Point(27, 7)
		Me.lblciti.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblciti.Name = "lblciti"
		Me.lblciti.Size = New System.Drawing.Size(137, 17)
		Me.lblciti.TabIndex = 10
		Me.lblciti.Text = "Conexión CyberRark"
		'
		'picOkCiberrark
		'
		Me.picOkCiberrark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picOkCiberrark.Image = CType(resources.GetObject("picOkCiberrark.Image"), System.Drawing.Image)
		Me.picOkCiberrark.Location = New System.Drawing.Point(-1, 2)
		Me.picOkCiberrark.Margin = New System.Windows.Forms.Padding(4)
		Me.picOkCiberrark.Name = "picOkCiberrark"
		Me.picOkCiberrark.Size = New System.Drawing.Size(24, 24)
		Me.picOkCiberrark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picOkCiberrark.TabIndex = 11
		Me.picOkCiberrark.TabStop = False
		'
		'lblEquipo
		'
		Me.lblEquipo.BackColor = System.Drawing.Color.Transparent
		Me.lblEquipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEquipo.ForeColor = System.Drawing.Color.SteelBlue
		Me.lblEquipo.Location = New System.Drawing.Point(0, 8)
		Me.lblEquipo.Margin = New System.Windows.Forms.Padding(0)
		Me.lblEquipo.Name = "lblEquipo"
		Me.lblEquipo.Size = New System.Drawing.Size(361, 235)
		Me.lblEquipo.TabIndex = 6
		'
		'SplashScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(717, 465)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblFrameworkNet)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.lblVersion)
		Me.Controls.Add(Me.lblLegales)
		Me.Controls.Add(Me.lblEmpresa)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.pnlDatos)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "SplashScreen"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.pnlDatos.ResumeLayout(False)
		Me.pblCitiCiberrark.ResumeLayout(False)
		Me.pblCitiCiberrark.PerformLayout()
		CType(Me.picErrorCiberrark, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picOkCiberrark, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblEmpresa As System.Windows.Forms.Label
   Friend WithEvents lblLegales As System.Windows.Forms.Label
   Friend WithEvents lblVersion As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFrameworkNet As Label
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents lblEquipo As Label
	Friend WithEvents pblCitiCiberrark As Panel
	Friend WithEvents picErrorCiberrark As PictureBox
	Friend WithEvents lblciti As Label
	Friend WithEvents picOkCiberrark As PictureBox
End Class
