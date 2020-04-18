<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMPro
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMPro))
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.pnlHelp = New DevExpress.XtraEditors.PanelControl()
		Me.lblInfoParametro = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.txtParametros = New DevExpress.XtraEditors.TextEdit()
		Me.cboProcesos = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
		Me.txtTitulo = New DevExpress.XtraEditors.TextEdit()
		Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
		Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
		Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl3.SuspendLayout()
		CType(Me.pnlHelp, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlHelp.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtParametros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cboProcesos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.PanelControl3, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(571, 383)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'PanelControl3
		'
		Me.PanelControl3.Controls.Add(Me.LabelControl5)
		Me.PanelControl3.Controls.Add(Me.LabelControl4)
		Me.PanelControl3.Controls.Add(Me.LabelControl3)
		Me.PanelControl3.Controls.Add(Me.LabelControl2)
		Me.PanelControl3.Controls.Add(Me.pnlHelp)
		Me.PanelControl3.Controls.Add(Me.txtParametros)
		Me.PanelControl3.Controls.Add(Me.cboProcesos)
		Me.PanelControl3.Controls.Add(Me.txtDescripcion)
		Me.PanelControl3.Controls.Add(Me.txtTitulo)
		Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanelControl3.Location = New System.Drawing.Point(4, 53)
		Me.PanelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PanelControl3.Name = "PanelControl3"
		Me.PanelControl3.Size = New System.Drawing.Size(563, 277)
		Me.PanelControl3.TabIndex = 3
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(51, 165)
		Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(71, 16)
		Me.LabelControl5.TabIndex = 8
		Me.LabelControl5.Text = "Parámetros:"
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(73, 133)
		Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(50, 16)
		Me.LabelControl4.TabIndex = 7
		Me.LabelControl4.Text = "Proceso:"
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(57, 52)
		Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(65, 16)
		Me.LabelControl3.TabIndex = 6
		Me.LabelControl3.Text = "Descripción"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(89, 21)
		Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(37, 16)
		Me.LabelControl2.TabIndex = 5
		Me.LabelControl2.Text = "Título:"
		'
		'pnlHelp
		'
		Me.pnlHelp.Appearance.BackColor = System.Drawing.SystemColors.Info
		Me.pnlHelp.Appearance.BackColor2 = System.Drawing.SystemColors.Info
		Me.pnlHelp.Appearance.Options.UseBackColor = True
		Me.pnlHelp.Controls.Add(Me.lblInfoParametro)
		Me.pnlHelp.Controls.Add(Me.LabelControl1)
		Me.pnlHelp.Controls.Add(Me.PictureBox2)
		Me.pnlHelp.Location = New System.Drawing.Point(7, 193)
		Me.pnlHelp.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
		Me.pnlHelp.LookAndFeel.UseDefaultLookAndFeel = False
		Me.pnlHelp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.pnlHelp.Name = "pnlHelp"
		Me.pnlHelp.Size = New System.Drawing.Size(549, 84)
		Me.pnlHelp.TabIndex = 4
		'
		'lblInfoParametro
		'
		Me.lblInfoParametro.Location = New System.Drawing.Point(35, 38)
		Me.lblInfoParametro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lblInfoParametro.Name = "lblInfoParametro"
		Me.lblInfoParametro.Size = New System.Drawing.Size(0, 16)
		Me.lblInfoParametro.TabIndex = 2
		'
		'LabelControl1
		'
		Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LabelControl1.Appearance.Options.UseFont = True
		Me.LabelControl1.Location = New System.Drawing.Point(39, 7)
		Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(319, 17)
		Me.LabelControl1.TabIndex = 1
		Me.LabelControl1.Text = "Especificaciones sobre la carga de parámetros:"
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.VBP04296.My.Resources.Resources.dialog_information
		Me.PictureBox2.Location = New System.Drawing.Point(4, 4)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.PictureBox2.TabIndex = 0
		Me.PictureBox2.TabStop = False
		'
		'txtParametros
		'
		Me.txtParametros.Location = New System.Drawing.Point(137, 161)
		Me.txtParametros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtParametros.Name = "txtParametros"
		Me.txtParametros.Size = New System.Drawing.Size(341, 22)
		Me.txtParametros.TabIndex = 4
		'
		'cboProcesos
		'
		Me.cboProcesos.Location = New System.Drawing.Point(137, 129)
		Me.cboProcesos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cboProcesos.Name = "cboProcesos"
		Me.cboProcesos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.cboProcesos.Size = New System.Drawing.Size(341, 22)
		Me.cboProcesos.TabIndex = 3
		'
		'txtDescripcion
		'
		Me.txtDescripcion.Location = New System.Drawing.Point(137, 49)
		Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(341, 73)
		Me.txtDescripcion.TabIndex = 2
		'
		'txtTitulo
		'
		Me.txtTitulo.Location = New System.Drawing.Point(137, 17)
		Me.txtTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtTitulo.Name = "txtTitulo"
		Me.txtTitulo.Size = New System.Drawing.Size(341, 22)
		Me.txtTitulo.TabIndex = 1
		'
		'PanelControl1
		'
		Me.PanelControl1.Controls.Add(Me.cmdGuardar)
		Me.PanelControl1.Controls.Add(Me.cmdCancelar)
		Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanelControl1.Location = New System.Drawing.Point(0, 334)
		Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
		Me.PanelControl1.Name = "PanelControl1"
		Me.PanelControl1.Size = New System.Drawing.Size(571, 49)
		Me.PanelControl1.TabIndex = 1
		'
		'cmdGuardar
		'
		Me.cmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.cmdGuardar.ImageOptions.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdGuardar.Location = New System.Drawing.Point(345, 9)
		Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cmdGuardar.Name = "cmdGuardar"
		Me.cmdGuardar.Size = New System.Drawing.Size(104, 31)
		Me.cmdGuardar.TabIndex = 5
		Me.cmdGuardar.Text = "&Guardar"
		'
		'cmdCancelar
		'
		Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdCancelar.Location = New System.Drawing.Point(457, 9)
		Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cmdCancelar.Name = "cmdCancelar"
		Me.cmdCancelar.Size = New System.Drawing.Size(104, 31)
		Me.cmdCancelar.TabIndex = 6
		Me.cmdCancelar.Text = "&Cancelar"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Panel1.Controls.Add(Me.LabelControl7)
		Me.Panel1.Controls.Add(Me.LabelControl6)
		Me.Panel1.Controls.Add(Me.PictureBox1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(571, 49)
		Me.Panel1.TabIndex = 4
		'
		'LabelControl7
		'
		Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
		Me.LabelControl7.Appearance.Options.UseForeColor = True
		Me.LabelControl7.Location = New System.Drawing.Point(21, 27)
		Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl7.Name = "LabelControl7"
		Me.LabelControl7.Size = New System.Drawing.Size(157, 16)
		Me.LabelControl7.TabIndex = 2
		Me.LabelControl7.Text = "Complete todos los campos"
		'
		'LabelControl6
		'
		Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
		Me.LabelControl6.Appearance.Options.UseFont = True
		Me.LabelControl6.Appearance.Options.UseForeColor = True
		Me.LabelControl6.Location = New System.Drawing.Point(11, 4)
		Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.LabelControl6.Name = "LabelControl6"
		Me.LabelControl6.Size = New System.Drawing.Size(390, 17)
		Me.LabelControl6.TabIndex = 1
		Me.LabelControl6.Text = "Especifique los procesos previos a la ejecución del Query."
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
		Me.PictureBox1.Image = Global.VBP04296.My.Resources.Resources.run_build_configure
		Me.PictureBox1.Location = New System.Drawing.Point(515, 0)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(56, 49)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'frmABMPro
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(571, 383)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmABMPro"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Procesos Previos"
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl3.ResumeLayout(False)
		Me.PanelControl3.PerformLayout()
		CType(Me.pnlHelp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlHelp.ResumeLayout(False)
		Me.pnlHelp.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtParametros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cboProcesos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pnlHelp As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtParametros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboProcesos As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblInfoParametro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
