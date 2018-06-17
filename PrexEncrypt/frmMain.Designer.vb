<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.rdoBtnWindows = New System.Windows.Forms.RadioButton()
        Me.rdoBtnSQL = New System.Windows.Forms.RadioButton()
        Me.cmdGrabar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtConfirma = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtPasswordAnt = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtRutaGrabar = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.dialogCarpeta = New DevExpress.XtraEditors.XtraFolderBrowserDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TxtConfirma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TxtPasswordAnt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRutaGrabar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.74803!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.25197!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(506, 295)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.rdoBtnWindows)
        Me.PanelControl3.Controls.Add(Me.rdoBtnSQL)
        Me.PanelControl3.Controls.Add(Me.cmdGrabar)
        Me.PanelControl3.Controls.Add(Me.cmdCancelar)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 254)
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(506, 41)
        Me.PanelControl3.TabIndex = 2
        '
        'rdoBtnWindows
        '
        Me.rdoBtnWindows.AutoSize = True
        Me.rdoBtnWindows.Location = New System.Drawing.Point(127, 12)
        Me.rdoBtnWindows.Name = "rdoBtnWindows"
        Me.rdoBtnWindows.Size = New System.Drawing.Size(87, 17)
        Me.rdoBtnWindows.TabIndex = 9
        Me.rdoBtnWindows.Text = "For Windows"
        Me.rdoBtnWindows.UseVisualStyleBackColor = True
        '
        'rdoBtnSQL
        '
        Me.rdoBtnSQL.AutoSize = True
        Me.rdoBtnSQL.Checked = True
        Me.rdoBtnSQL.Location = New System.Drawing.Point(12, 12)
        Me.rdoBtnSQL.Name = "rdoBtnSQL"
        Me.rdoBtnSQL.Size = New System.Drawing.Size(98, 17)
        Me.rdoBtnSQL.TabIndex = 9
        Me.rdoBtnSQL.TabStop = True
        Me.rdoBtnSQL.Text = "For SQL Server"
        Me.rdoBtnSQL.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGrabar.ImageOptions.Image = CType(resources.GetObject("cmdGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGrabar.Location = New System.Drawing.Point(335, 9)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGrabar.TabIndex = 7
        Me.cmdGrabar.Text = "&Encriptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(419, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.TxtConfirma)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.TxtPassword)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 167)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(506, 87)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(59, 49)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl7.TabIndex = 3
        Me.LabelControl7.Text = "Confirmación:"
        '
        'TxtConfirma
        '
        Me.TxtConfirma.Location = New System.Drawing.Point(135, 45)
        Me.TxtConfirma.Name = "TxtConfirma"
        Me.TxtConfirma.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirma.Size = New System.Drawing.Size(240, 22)
        Me.TxtConfirma.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(65, 19)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "Contraseña:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(135, 15)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(240, 22)
        Me.TxtPassword.TabIndex = 5
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdBrowse)
        Me.PanelControl1.Controls.Add(Me.TxtPasswordAnt)
        Me.PanelControl1.Controls.Add(Me.txtUsuario)
        Me.PanelControl1.Controls.Add(Me.txtRutaGrabar)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(506, 167)
        Me.PanelControl1.TabIndex = 0
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImageOptions.Image = CType(resources.GetObject("cmdBrowse.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBrowse.Location = New System.Drawing.Point(468, 74)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(23, 23)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtPasswordAnt
        '
        Me.TxtPasswordAnt.Location = New System.Drawing.Point(135, 128)
        Me.TxtPasswordAnt.Name = "TxtPasswordAnt"
        Me.TxtPasswordAnt.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordAnt.Size = New System.Drawing.Size(240, 22)
        Me.TxtPasswordAnt.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(135, 102)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(240, 22)
        Me.txtUsuario.TabIndex = 3
        '
        'txtRutaGrabar
        '
        Me.txtRutaGrabar.Location = New System.Drawing.Point(135, 76)
        Me.txtRutaGrabar.Name = "txtRutaGrabar"
        Me.txtRutaGrabar.Size = New System.Drawing.Size(327, 22)
        Me.txtRutaGrabar.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(8, 131)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Contraseña anterior:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(79, 105)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Usuario:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Guardar en carpeta:"
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelControl4.Appearance.BackColor2 = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelControl4.Appearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.Appearance.Options.UseBorderColor = True
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.picLogo)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.PanelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl4.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(500, 61)
        Me.PanelControl4.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(37, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(347, 26)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Proporcione una ruta donde grabar el archivo que contiene el usuario de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la cone" &
    "xión al SQL Server y su contraseña, ambos encriptados."
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(9, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(131, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Encriptación de usuario"
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.picLogo.EditValue = CType(resources.GetObject("picLogo.EditValue"), Object)
        Me.picLogo.Location = New System.Drawing.Point(438, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Properties.Appearance.Options.UseBackColor = True
        Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picLogo.Size = New System.Drawing.Size(59, 55)
        Me.picLogo.TabIndex = 1
        '
        'dialogCarpeta
        '
        Me.dialogCarpeta.AllowDragDrop = False
        Me.dialogCarpeta.SelectedPath = "XtraFolderBrowserDialog1"
        Me.dialogCarpeta.ShowNewFolderButton = False
        Me.dialogCarpeta.Title = "Seleccionar Carpeta"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(506, 295)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Encriptación - Sistema PrexRI"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.TxtConfirma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TxtPasswordAnt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRutaGrabar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdGrabar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtConfirma As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtPasswordAnt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRutaGrabar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dialogCarpeta As DevExpress.XtraEditors.XtraFolderBrowserDialog
    Friend WithEvents rdoBtnWindows As RadioButton
    Friend WithEvents rdoBtnSQL As RadioButton
End Class
