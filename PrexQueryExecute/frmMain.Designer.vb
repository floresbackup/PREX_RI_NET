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
		Me.txtQuery = New System.Windows.Forms.RichTextBox()
		Me.tabResults = New DevExpress.XtraTab.XtraTabPage()
		Me.txtResultsError = New System.Windows.Forms.RichTextBox()
		Me.grdResults = New DevExpress.XtraGrid.GridControl()
		Me.gridViewResults = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.toolBarMain = New System.Windows.Forms.ToolStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripDropDownButton()
		Me.subMnuOpenQuery = New System.Windows.Forms.ToolStripMenuItem()
		Me.subMnuSaveQuery = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuExecuteQuery = New System.Windows.Forms.ToolStripButton()
		Me.mnuClearConsulta = New System.Windows.Forms.ToolStripButton()
		Me.pnlQuery = New System.Windows.Forms.Panel()
		Me.pnlResult = New System.Windows.Forms.Panel()
		Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
		CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabControl.SuspendLayout()
		Me.tabQuery.SuspendLayout()
		Me.tabResults.SuspendLayout()
		CType(Me.grdResults, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridViewResults, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.toolBarMain.SuspendLayout()
		Me.pnlQuery.SuspendLayout()
		Me.pnlResult.SuspendLayout()
		Me.SuspendLayout()
		'
		'tabControl
		'
		Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl.Location = New System.Drawing.Point(3, 29)
		Me.tabControl.Name = "tabControl"
		Me.tabControl.SelectedTabPage = Me.tabQuery
		Me.tabControl.Size = New System.Drawing.Size(794, 418)
		Me.tabControl.TabIndex = 0
		Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabQuery, Me.tabResults})
		'
		'tabQuery
		'
		Me.tabQuery.Controls.Add(Me.pnlQuery)
		Me.tabQuery.Name = "tabQuery"
		Me.tabQuery.Size = New System.Drawing.Size(788, 390)
		Me.tabQuery.Text = "&Consulta"
		'
		'txtQuery
		'
		Me.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtQuery.Location = New System.Drawing.Point(10, 10)
		Me.txtQuery.Name = "txtQuery"
		Me.txtQuery.ShowSelectionMargin = True
		Me.txtQuery.Size = New System.Drawing.Size(778, 380)
		Me.txtQuery.TabIndex = 0
		Me.txtQuery.Text = ""
		Me.txtQuery.WordWrap = False
		'
		'tabResults
		'
		Me.tabResults.Controls.Add(Me.pnlResult)
		Me.tabResults.Name = "tabResults"
		Me.tabResults.PageEnabled = False
		Me.tabResults.Size = New System.Drawing.Size(788, 390)
		Me.tabResults.Text = "&Resultados"
		'
		'txtResultsError
		'
		Me.txtResultsError.BackColor = System.Drawing.Color.White
		Me.txtResultsError.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtResultsError.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
		Me.txtResultsError.ForeColor = System.Drawing.Color.Red
		Me.txtResultsError.Location = New System.Drawing.Point(41, 18)
		Me.txtResultsError.Name = "txtResultsError"
		Me.txtResultsError.ReadOnly = True
		Me.txtResultsError.Size = New System.Drawing.Size(208, 105)
		Me.txtResultsError.TabIndex = 1
		Me.txtResultsError.Text = ""
		Me.txtResultsError.Visible = False
		'
		'grdResults
		'
		Me.grdResults.Location = New System.Drawing.Point(286, 138)
		Me.grdResults.MainView = Me.gridViewResults
		Me.grdResults.Name = "grdResults"
		Me.grdResults.Size = New System.Drawing.Size(400, 200)
		Me.grdResults.TabIndex = 0
		Me.grdResults.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewResults})
		Me.grdResults.Visible = False
		'
		'gridViewResults
		'
		Me.gridViewResults.GridControl = Me.grdResults
		Me.gridViewResults.Name = "gridViewResults"
		Me.gridViewResults.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
		Me.gridViewResults.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
		Me.gridViewResults.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
		Me.gridViewResults.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
		Me.gridViewResults.OptionsBehavior.ReadOnly = True
		Me.gridViewResults.OptionsCustomization.AllowColumnMoving = False
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
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'toolBarMain
		'
		Me.toolBarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.ToolStripSeparator1, Me.mnuExecuteQuery, Me.mnuClearConsulta})
		Me.toolBarMain.Location = New System.Drawing.Point(0, 0)
		Me.toolBarMain.Name = "toolBarMain"
		Me.toolBarMain.Size = New System.Drawing.Size(800, 25)
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
		Me.mnuFile.Size = New System.Drawing.Size(61, 22)
		Me.mnuFile.Text = "&Archivo"
		'
		'subMnuOpenQuery
		'
		Me.subMnuOpenQuery.Image = CType(resources.GetObject("subMnuOpenQuery.Image"), System.Drawing.Image)
		Me.subMnuOpenQuery.Name = "subMnuOpenQuery"
		Me.subMnuOpenQuery.Size = New System.Drawing.Size(180, 22)
		Me.subMnuOpenQuery.Text = "A&brir consulta..."
		'
		'subMnuSaveQuery
		'
		Me.subMnuSaveQuery.Enabled = False
		Me.subMnuSaveQuery.Image = CType(resources.GetObject("subMnuSaveQuery.Image"), System.Drawing.Image)
		Me.subMnuSaveQuery.Name = "subMnuSaveQuery"
		Me.subMnuSaveQuery.Size = New System.Drawing.Size(180, 22)
		Me.subMnuSaveQuery.Text = "&Guardar consulta..."
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'mnuExecuteQuery
		'
		Me.mnuExecuteQuery.Image = CType(resources.GetObject("mnuExecuteQuery.Image"), System.Drawing.Image)
		Me.mnuExecuteQuery.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuExecuteQuery.Name = "mnuExecuteQuery"
		Me.mnuExecuteQuery.Size = New System.Drawing.Size(92, 22)
		Me.mnuExecuteQuery.Text = "&Ejecutar (F5)"
		'
		'mnuClearConsulta
		'
		Me.mnuClearConsulta.Image = CType(resources.GetObject("mnuClearConsulta.Image"), System.Drawing.Image)
		Me.mnuClearConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.mnuClearConsulta.Name = "mnuClearConsulta"
		Me.mnuClearConsulta.Size = New System.Drawing.Size(161, 22)
		Me.mnuClearConsulta.Text = "&Limpiar consulta (Ctrl+C)"
		'
		'pnlQuery
		'
		Me.pnlQuery.BackColor = System.Drawing.Color.White
		Me.pnlQuery.Controls.Add(Me.txtQuery)
		Me.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlQuery.Location = New System.Drawing.Point(0, 0)
		Me.pnlQuery.Name = "pnlQuery"
		Me.pnlQuery.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
		Me.pnlQuery.Size = New System.Drawing.Size(788, 390)
		Me.pnlQuery.TabIndex = 1
		'
		'pnlResult
		'
		Me.pnlResult.BackColor = System.Drawing.Color.White
		Me.pnlResult.Controls.Add(Me.txtResultsError)
		Me.pnlResult.Controls.Add(Me.grdResults)
		Me.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlResult.Location = New System.Drawing.Point(0, 0)
		Me.pnlResult.Name = "pnlResult"
		Me.pnlResult.Size = New System.Drawing.Size(788, 390)
		Me.pnlResult.TabIndex = 2
		'
		'openFileDialog
		'
		Me.openFileDialog.FileName = "OpenFileDialog1"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "PrexQueryExecute"
		CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabControl.ResumeLayout(False)
		Me.tabQuery.ResumeLayout(False)
		Me.tabResults.ResumeLayout(False)
		CType(Me.grdResults, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridViewResults, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.toolBarMain.ResumeLayout(False)
		Me.toolBarMain.PerformLayout()
		Me.pnlQuery.ResumeLayout(False)
		Me.pnlResult.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
	Friend WithEvents tabQuery As DevExpress.XtraTab.XtraTabPage
	Friend WithEvents tabResults As DevExpress.XtraTab.XtraTabPage
	Friend WithEvents txtQuery As RichTextBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents toolBarMain As ToolStrip
	Friend WithEvents mnuFile As ToolStripDropDownButton
	Friend WithEvents subMnuOpenQuery As ToolStripMenuItem
	Friend WithEvents subMnuSaveQuery As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents mnuExecuteQuery As ToolStripButton
	Friend WithEvents mnuClearConsulta As ToolStripButton
	Friend WithEvents txtResultsError As RichTextBox
	Friend WithEvents grdResults As DevExpress.XtraGrid.GridControl
	Friend WithEvents gridViewResults As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents pnlQuery As Panel
	Friend WithEvents pnlResult As Panel
	Friend WithEvents openFileDialog As OpenFileDialog
End Class
