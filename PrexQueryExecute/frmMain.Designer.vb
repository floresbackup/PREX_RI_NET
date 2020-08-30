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
		Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
		Me.tabQuery = New DevExpress.XtraTab.XtraTabPage()
		Me.pnlQuery = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.toolBarMain = New System.Windows.Forms.ToolStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripDropDownButton()
		Me.subMnuOpenQuery = New System.Windows.Forms.ToolStripMenuItem()
		Me.subMnuSaveQuery = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuExecuteQuery = New System.Windows.Forms.ToolStripButton()
		Me.mnuClearConsulta = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuExportToExcel = New System.Windows.Forms.ToolStripButton()
		Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.tabResults = New DevExpress.XtraTab.XtraTabPage()
		CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabControl.SuspendLayout()
		Me.tabQuery.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.toolBarMain.SuspendLayout()
		Me.SuspendLayout()
		'
		'tabControl
		'
		Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl.Location = New System.Drawing.Point(4, 36)
		Me.tabControl.Margin = New System.Windows.Forms.Padding(4)
		Me.tabControl.Name = "tabControl"
		Me.tabControl.SelectedTabPage = Me.tabQuery
		Me.tabControl.Size = New System.Drawing.Size(1059, 514)
		Me.tabControl.TabIndex = 0
		Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabQuery, Me.tabResults})
		'
		'tabQuery
		'
		Me.tabQuery.Controls.Add(Me.pnlQuery)
		Me.tabQuery.Margin = New System.Windows.Forms.Padding(4)
		Me.tabQuery.Name = "tabQuery"
		Me.tabQuery.Size = New System.Drawing.Size(1052, 480)
		Me.tabQuery.Text = "&Consulta"
		'
		'pnlQuery
		'
		Me.pnlQuery.BackColor = System.Drawing.Color.White
		Me.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlQuery.Location = New System.Drawing.Point(0, 0)
		Me.pnlQuery.Margin = New System.Windows.Forms.Padding(4)
		Me.pnlQuery.Name = "pnlQuery"
		Me.pnlQuery.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)
		Me.pnlQuery.Size = New System.Drawing.Size(1052, 480)
		Me.pnlQuery.TabIndex = 1
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.tabControl, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.toolBarMain, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.777778!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.22222!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1067, 554)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'toolBarMain
		'
		Me.toolBarMain.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.toolBarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.ToolStripSeparator1, Me.mnuExecuteQuery, Me.mnuClearConsulta, Me.ToolStripSeparator2, Me.mnuExportToExcel})
		Me.toolBarMain.Location = New System.Drawing.Point(0, 0)
		Me.toolBarMain.Name = "toolBarMain"
		Me.toolBarMain.Size = New System.Drawing.Size(1067, 27)
		Me.toolBarMain.TabIndex = 1
		Me.toolBarMain.Text = "ToolStrip1"
		'
		'mnuFile
		'
		Me.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMnuOpenQuery, Me.subMnuSaveQuery})
		Me.mnuFile.Image = CType(resources.GetObject("mnuFile.Image"), System.Drawing.Image)
		Me.mnuFile.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Size = New System.Drawing.Size(73, 24)
		Me.mnuFile.Text = "&Archivo"
		'
		'subMnuOpenQuery
		'
		Me.subMnuOpenQuery.Image = CType(resources.GetObject("subMnuOpenQuery.Image"), System.Drawing.Image)
		Me.subMnuOpenQuery.Name = "subMnuOpenQuery"
		Me.subMnuOpenQuery.Size = New System.Drawing.Size(213, 26)
		Me.subMnuOpenQuery.Text = "A&brir consulta..."
		'
		'subMnuSaveQuery
		'
		Me.subMnuSaveQuery.Enabled = False
		Me.subMnuSaveQuery.Image = CType(resources.GetObject("subMnuSaveQuery.Image"), System.Drawing.Image)
		Me.subMnuSaveQuery.Name = "subMnuSaveQuery"
		Me.subMnuSaveQuery.Size = New System.Drawing.Size(213, 26)
		Me.subMnuSaveQuery.Text = "&Guardar consulta..."
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
		'
		'mnuExecuteQuery
		'
		Me.mnuExecuteQuery.Image = CType(resources.GetObject("mnuExecuteQuery.Image"), System.Drawing.Image)
		Me.mnuExecuteQuery.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuExecuteQuery.Name = "mnuExecuteQuery"
		Me.mnuExecuteQuery.Size = New System.Drawing.Size(115, 24)
		Me.mnuExecuteQuery.Text = "&Ejecutar (F5)"
		'
		'mnuClearConsulta
		'
		Me.mnuClearConsulta.Image = CType(resources.GetObject("mnuClearConsulta.Image"), System.Drawing.Image)
		Me.mnuClearConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuClearConsulta.Name = "mnuClearConsulta"
		Me.mnuClearConsulta.Size = New System.Drawing.Size(198, 24)
		Me.mnuClearConsulta.Text = "&Limpiar consulta (Ctrl+C)"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
		'
		'mnuExportToExcel
		'
		Me.mnuExportToExcel.Enabled = False
		Me.mnuExportToExcel.Image = CType(resources.GetObject("mnuExportToExcel.Image"), System.Drawing.Image)
		Me.mnuExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuExportToExcel.Name = "mnuExportToExcel"
		Me.mnuExportToExcel.Size = New System.Drawing.Size(139, 24)
		Me.mnuExportToExcel.Text = "E&xportar a Excel"
		'
		'openFileDialog
		'
		Me.openFileDialog.FileName = "OpenFileDialog1"
		'
		'tabResults
		'
		Me.tabResults.Margin = New System.Windows.Forms.Padding(4)
		Me.tabResults.Name = "tabResults"
		Me.tabResults.PageEnabled = False
		Me.tabResults.Size = New System.Drawing.Size(1052, 480)
		Me.tabResults.Text = "&Resultados"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1067, 554)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "PrexQueryExecute"
		CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabControl.ResumeLayout(False)
		Me.tabQuery.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.toolBarMain.ResumeLayout(False)
		Me.toolBarMain.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
	Friend WithEvents tabQuery As DevExpress.XtraTab.XtraTabPage
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents toolBarMain As ToolStrip
	Friend WithEvents mnuFile As ToolStripDropDownButton
	Friend WithEvents subMnuOpenQuery As ToolStripMenuItem
	Friend WithEvents subMnuSaveQuery As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents mnuExecuteQuery As ToolStripButton
	Friend WithEvents mnuClearConsulta As ToolStripButton
	Friend WithEvents pnlQuery As Panel
	Friend WithEvents openFileDialog As OpenFileDialog
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents mnuExportToExcel As ToolStripButton
	Friend WithEvents tabResults As DevExpress.XtraTab.XtraTabPage
End Class
