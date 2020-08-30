<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPanelResult
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.pnlResult = New System.Windows.Forms.Panel()
		Me.txtResultsError = New System.Windows.Forms.RichTextBox()
		Me.grdResults = New DevExpress.XtraGrid.GridControl()
		Me.gridViewResults = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.pnlResult.SuspendLayout()
		CType(Me.grdResults, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridViewResults, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlResult
		'
		Me.pnlResult.BackColor = System.Drawing.Color.White
		Me.pnlResult.Controls.Add(Me.txtResultsError)
		Me.pnlResult.Controls.Add(Me.grdResults)
		Me.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlResult.Location = New System.Drawing.Point(0, 0)
		Me.pnlResult.Margin = New System.Windows.Forms.Padding(4)
		Me.pnlResult.Name = "pnlResult"
		Me.pnlResult.Size = New System.Drawing.Size(1019, 532)
		Me.pnlResult.TabIndex = 3
		'
		'txtResultsError
		'
		Me.txtResultsError.BackColor = System.Drawing.Color.White
		Me.txtResultsError.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtResultsError.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
		Me.txtResultsError.ForeColor = System.Drawing.Color.Red
		Me.txtResultsError.Location = New System.Drawing.Point(55, 22)
		Me.txtResultsError.Margin = New System.Windows.Forms.Padding(4)
		Me.txtResultsError.Name = "txtResultsError"
		Me.txtResultsError.ReadOnly = True
		Me.txtResultsError.Size = New System.Drawing.Size(277, 129)
		Me.txtResultsError.TabIndex = 1
		Me.txtResultsError.Text = ""
		Me.txtResultsError.Visible = False
		'
		'grdResults
		'
		Me.grdResults.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
		Me.grdResults.Location = New System.Drawing.Point(381, 170)
		Me.grdResults.MainView = Me.gridViewResults
		Me.grdResults.Margin = New System.Windows.Forms.Padding(4)
		Me.grdResults.Name = "grdResults"
		Me.grdResults.Size = New System.Drawing.Size(533, 246)
		Me.grdResults.TabIndex = 0
		Me.grdResults.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewResults})
		Me.grdResults.Visible = False
		'
		'gridViewResults
		'
		Me.gridViewResults.GridControl = Me.grdResults
		Me.gridViewResults.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
		Me.gridViewResults.Name = "gridViewResults"
		Me.gridViewResults.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
		Me.gridViewResults.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
		Me.gridViewResults.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
		Me.gridViewResults.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
		Me.gridViewResults.OptionsBehavior.Editable = False
		Me.gridViewResults.OptionsBehavior.ReadOnly = True
		Me.gridViewResults.OptionsCustomization.AllowColumnMoving = False
		Me.gridViewResults.OptionsLayout.Columns.AddNewColumns = False
		Me.gridViewResults.OptionsLayout.Columns.RemoveOldColumns = False
		Me.gridViewResults.OptionsLayout.Columns.StoreLayout = False
		Me.gridViewResults.OptionsView.AutoCalcPreviewLineCount = True
		Me.gridViewResults.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
		'
		'ucPanelResult
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlResult)
		Me.Name = "ucPanelResult"
		Me.Size = New System.Drawing.Size(1019, 532)
		Me.pnlResult.ResumeLayout(False)
		CType(Me.grdResults, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridViewResults, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlResult As Panel
	Friend WithEvents txtResultsError As RichTextBox
	Friend WithEvents grdResults As DevExpress.XtraGrid.GridControl
	Public WithEvents gridViewResults As DevExpress.XtraGrid.Views.Grid.GridView
End Class
