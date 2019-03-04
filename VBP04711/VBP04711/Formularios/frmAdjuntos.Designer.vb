<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjuntos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdjuntos))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanTop = New DevExpress.XtraEditors.PanelControl()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArchivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTop.SuspendLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanTop, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GridControl1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(527, 268)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanTop
        '
        Me.PanTop.Appearance.BackColor = System.Drawing.Color.White
        Me.PanTop.Appearance.Options.UseBackColor = True
        Me.PanTop.Controls.Add(Me.lblSubtitulo)
        Me.PanTop.Controls.Add(Me.lblTitulo)
        Me.PanTop.Controls.Add(Me.picLogo)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(3, 3)
        Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(521, 48)
        Me.PanTop.TabIndex = 7
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.Location = New System.Drawing.Point(34, 29)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(0, 13)
        Me.lblSubtitulo.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(0, 13)
        Me.lblTitulo.TabIndex = 1
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.picLogo.EditValue = Global.VBP04711.My.Resources.Resources.logo_prex
        Me.picLogo.Location = New System.Drawing.Point(460, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Properties.Appearance.Options.UseBackColor = True
        Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picLogo.Size = New System.Drawing.Size(59, 44)
        Me.picLogo.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCerrar)
        Me.PanelControl1.Controls.Add(Me.cmdVer)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 236)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(527, 32)
        Me.PanelControl1.TabIndex = 1
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(447, 5)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrar.TabIndex = 0
        Me.cmdCerrar.Text = "&Cerrar"
        '
        'cmdVer
        '
        Me.cmdVer.Location = New System.Drawing.Point(366, 5)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(75, 23)
        Me.cmdVer.TabIndex = 0
        Me.cmdVer.Text = "&Ver Adjunto"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(3, 57)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(521, 176)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre, Me.colArchivo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowValidationErrors = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsSelection.InvertSelection = True
        Me.GridView1.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNombre
        '
        Me.colNombre.Caption = "Archivos adjuntos"
        Me.colNombre.FieldName = "AD_NOMBRE"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        '
        'colArchivo
        '
        Me.colArchivo.Caption = "colArchivo"
        Me.colArchivo.FieldName = "AD_ARCHIV"
        Me.colArchivo.Name = "colArchivo"
        '
        'frmAdjuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 268)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdjuntos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adjuntos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colArchivo As DevExpress.XtraGrid.Columns.GridColumn
End Class
