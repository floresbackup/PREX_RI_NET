<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmABMVar
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMVar))
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
		Me.lblHelpSQL = New DevExpress.XtraEditors.LabelControl()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.pnlQuery = New System.Windows.Forms.Panel()
		Me.cboHelp = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.lblVariable = New DevExpress.XtraEditors.LabelControl()
		Me.txtVariable = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.cboTipoDato = New DevExpress.XtraEditors.ComboBoxEdit()
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
		CType(Me.cboHelp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVariable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cboTipoDato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(555, 445)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'PanelControl3
		'
		Me.PanelControl3.Controls.Add(Me.lblHelpSQL)
		Me.PanelControl3.Controls.Add(Me.Panel2)
		Me.PanelControl3.Controls.Add(Me.pnlQuery)
		Me.PanelControl3.Controls.Add(Me.cboHelp)
		Me.PanelControl3.Controls.Add(Me.lblVariable)
		Me.PanelControl3.Controls.Add(Me.txtVariable)
		Me.PanelControl3.Controls.Add(Me.LabelControl5)
		Me.PanelControl3.Controls.Add(Me.LabelControl4)
		Me.PanelControl3.Controls.Add(Me.LabelControl2)
		Me.PanelControl3.Controls.Add(Me.cboTipoDato)
		Me.PanelControl3.Controls.Add(Me.txtTitulo)
		Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanelControl3.Location = New System.Drawing.Point(4, 53)
		Me.PanelControl3.Margin = New System.Windows.Forms.Padding(4)
		Me.PanelControl3.Name = "PanelControl3"
		Me.PanelControl3.Size = New System.Drawing.Size(547, 339)
		Me.PanelControl3.TabIndex = 3
		'
		'lblHelpSQL
		'
		Me.lblHelpSQL.Location = New System.Drawing.Point(9, 143)
		Me.lblHelpSQL.Margin = New System.Windows.Forms.Padding(4)
		Me.lblHelpSQL.Name = "lblHelpSQL"
		Me.lblHelpSQL.Size = New System.Drawing.Size(117, 16)
		Me.lblHelpSQL.TabIndex = 14
		Me.lblHelpSQL.Text = "Help SQL (si aplica):"
		'
		'Panel2
		'
		Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel2.BackColor = System.Drawing.Color.Transparent
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Location = New System.Drawing.Point(7, 138)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(532, 1)
		Me.Panel2.TabIndex = 13
		'
		'pnlQuery
		'
		Me.pnlQuery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlQuery.Location = New System.Drawing.Point(8, 166)
		Me.pnlQuery.Name = "pnlQuery"
		Me.pnlQuery.Size = New System.Drawing.Size(531, 168)
		Me.pnlQuery.TabIndex = 12
		'
		'cboHelp
		'
		Me.cboHelp.Location = New System.Drawing.Point(124, 101)
		Me.cboHelp.Margin = New System.Windows.Forms.Padding(4)
		Me.cboHelp.Name = "cboHelp"
		Me.cboHelp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.cboHelp.Size = New System.Drawing.Size(341, 22)
		Me.cboHelp.TabIndex = 4
		'
		'lblVariable
		'
		Me.lblVariable.Location = New System.Drawing.Point(64, 12)
		Me.lblVariable.Margin = New System.Windows.Forms.Padding(4)
		Me.lblVariable.Name = "lblVariable"
		Me.lblVariable.Size = New System.Drawing.Size(52, 16)
		Me.lblVariable.TabIndex = 10
		Me.lblVariable.Text = "Variable:"
		'
		'txtVariable
		'
		Me.txtVariable.Location = New System.Drawing.Point(124, 9)
		Me.txtVariable.Margin = New System.Windows.Forms.Padding(4)
		Me.txtVariable.Name = "txtVariable"
		Me.txtVariable.Size = New System.Drawing.Size(341, 22)
		Me.txtVariable.TabIndex = 1
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(83, 104)
		Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(30, 16)
		Me.LabelControl5.TabIndex = 8
		Me.LabelControl5.Text = "Help:"
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(56, 74)
		Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(60, 16)
		Me.LabelControl4.TabIndex = 7
		Me.LabelControl4.Text = "Tipo Dato:"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(76, 44)
		Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(37, 16)
		Me.LabelControl2.TabIndex = 5
		Me.LabelControl2.Text = "Título:"
		'
		'cboTipoDato
		'
		Me.cboTipoDato.Location = New System.Drawing.Point(124, 71)
		Me.cboTipoDato.Margin = New System.Windows.Forms.Padding(4)
		Me.cboTipoDato.Name = "cboTipoDato"
		Me.cboTipoDato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.cboTipoDato.Size = New System.Drawing.Size(341, 22)
		Me.cboTipoDato.TabIndex = 3
		'
		'txtTitulo
		'
		Me.txtTitulo.Location = New System.Drawing.Point(124, 41)
		Me.txtTitulo.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTitulo.Name = "txtTitulo"
		Me.txtTitulo.Size = New System.Drawing.Size(341, 22)
		Me.txtTitulo.TabIndex = 2
		'
		'PanelControl1
		'
		Me.PanelControl1.Controls.Add(Me.cmdGuardar)
		Me.PanelControl1.Controls.Add(Me.cmdCancelar)
		Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanelControl1.Location = New System.Drawing.Point(0, 396)
		Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
		Me.PanelControl1.Name = "PanelControl1"
		Me.PanelControl1.Size = New System.Drawing.Size(555, 49)
		Me.PanelControl1.TabIndex = 1
		'
		'cmdGuardar
		'
		Me.cmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.cmdGuardar.ImageOptions.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdGuardar.Location = New System.Drawing.Point(329, 9)
		Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
		Me.cmdGuardar.Name = "cmdGuardar"
		Me.cmdGuardar.Size = New System.Drawing.Size(104, 31)
		Me.cmdGuardar.TabIndex = 6
		Me.cmdGuardar.Text = "&Guardar"
		'
		'cmdCancelar
		'
		Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
		Me.cmdCancelar.Location = New System.Drawing.Point(441, 9)
		Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
		Me.cmdCancelar.Name = "cmdCancelar"
		Me.cmdCancelar.Size = New System.Drawing.Size(104, 31)
		Me.cmdCancelar.TabIndex = 7
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
		Me.Panel1.Size = New System.Drawing.Size(555, 49)
		Me.Panel1.TabIndex = 4
		'
		'LabelControl7
		'
		Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
		Me.LabelControl7.Appearance.Options.UseForeColor = True
		Me.LabelControl7.Location = New System.Drawing.Point(21, 27)
		Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
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
		Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
		Me.LabelControl6.Name = "LabelControl6"
		Me.LabelControl6.Size = New System.Drawing.Size(319, 17)
		Me.LabelControl6.TabIndex = 1
		Me.LabelControl6.Text = "Especifique los datos de la variable de entrada."
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(508, 0)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(47, 49)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'frmABMVar
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(555, 445)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmABMVar"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Datos de variable de entrada"
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl3.ResumeLayout(False)
		Me.PanelControl3.PerformLayout()
		CType(Me.cboHelp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVariable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cboTipoDato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents cboTipoDato As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents cboHelp As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents lblVariable As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txtVariable As DevExpress.XtraEditors.TextEdit
	Friend WithEvents pnlQuery As Panel
	Friend WithEvents lblHelpSQL As DevExpress.XtraEditors.LabelControl
	Friend WithEvents Panel2 As Panel
End Class
