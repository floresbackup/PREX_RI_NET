<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.txtDecimalSeparator = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPathBCP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lblProgreso = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnDialogBCP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDecimalSeparator
        '
        Me.txtDecimalSeparator.Location = New System.Drawing.Point(147, 47)
        Me.txtDecimalSeparator.Name = "txtDecimalSeparator"
        Me.txtDecimalSeparator.Size = New System.Drawing.Size(25, 20)
        Me.txtDecimalSeparator.TabIndex = 26
        Me.txtDecimalSeparator.Text = ";"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Separador Terminos"
        '
        'txtPathBCP
        '
        Me.txtPathBCP.Location = New System.Drawing.Point(147, 20)
        Me.txtPathBCP.Name = "txtPathBCP"
        Me.txtPathBCP.ReadOnly = True
        Me.txtPathBCP.Size = New System.Drawing.Size(319, 20)
        Me.txtPathBCP.TabIndex = 25
        Me.txtPathBCP.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Directorio de archivo TXT"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(15, 105)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(386, 23)
        Me.progressBar.TabIndex = 30
        Me.progressBar.Visible = False
        '
        'lblProgreso
        '
        Me.lblProgreso.AutoSize = True
        Me.lblProgreso.Location = New System.Drawing.Point(12, 85)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(59, 13)
        Me.lblProgreso.TabIndex = 29
        Me.lblProgreso.Text = "lblProgreso"
        Me.lblProgreso.Visible = False
        '
        'btnProcesar
        '
        Me.btnProcesar.Image = Global.VBPIMPTXT.My.Resources.Resources.database_gear
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcesar.Location = New System.Drawing.Point(423, 105)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 28
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnDialogBCP
        '
        Me.btnDialogBCP.Image = Global.VBPIMPTXT.My.Resources.Resources.folder_open_3
        Me.btnDialogBCP.Location = New System.Drawing.Point(472, 18)
        Me.btnDialogBCP.Name = "btnDialogBCP"
        Me.btnDialogBCP.Size = New System.Drawing.Size(26, 23)
        Me.btnDialogBCP.TabIndex = 24
        Me.btnDialogBCP.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 147)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.lblProgreso)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.txtDecimalSeparator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDialogBCP)
        Me.Controls.Add(Me.txtPathBCP)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar TXT - DEUDORES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDecimalSeparator As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDialogBCP As Button
    Friend WithEvents txtPathBCP As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents progressBar As ProgressBar
    Friend WithEvents lblProgreso As Label
    Friend WithEvents btnProcesar As Button
End Class
