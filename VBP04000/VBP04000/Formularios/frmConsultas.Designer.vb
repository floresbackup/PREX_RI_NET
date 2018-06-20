<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultas))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.btnContraerTodo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExpandirTodo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFiltrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFiltrar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colXX_CATEGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCV_CODCON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCV_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Grid, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(421, 417)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(1, 385)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(1)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(419, 31)
        Me.PanelControl1.TabIndex = 0
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Location = New System.Drawing.Point(250, 5)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(333, 5)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 0
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblFiltro)
        Me.PanelControl2.Controls.Add(Me.txtNombre)
        Me.PanelControl2.Controls.Add(Me.btnContraerTodo)
        Me.PanelControl2.Controls.Add(Me.btnExpandirTodo)
        Me.PanelControl2.Controls.Add(Me.cmdFiltrar)
        Me.PanelControl2.Controls.Add(Me.btnFiltrar)
        Me.PanelControl2.Controls.Add(Me.Panel1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(1, 1)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(1)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(419, 68)
        Me.PanelControl2.TabIndex = 1
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(2, 75)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(161, 13)
        Me.lblFiltro.TabIndex = 3
        Me.lblFiltro.Text = "Nombre de la consulta contiene:"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(169, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 20)
        Me.txtNombre.TabIndex = 2
        '
        'btnContraerTodo
        '
        Me.btnContraerTodo.ImageOptions.Image = CType(resources.GetObject("btnContraerTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnContraerTodo.Location = New System.Drawing.Point(115, 41)
        Me.btnContraerTodo.Name = "btnContraerTodo"
        Me.btnContraerTodo.Size = New System.Drawing.Size(23, 23)
        Me.btnContraerTodo.TabIndex = 1
        Me.btnContraerTodo.ToolTip = "Contraer todo"
        '
        'btnExpandirTodo
        '
        Me.btnExpandirTodo.ImageOptions.Image = CType(resources.GetObject("btnExpandirTodo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExpandirTodo.Location = New System.Drawing.Point(86, 41)
        Me.btnExpandirTodo.Name = "btnExpandirTodo"
        Me.btnExpandirTodo.Size = New System.Drawing.Size(23, 23)
        Me.btnExpandirTodo.TabIndex = 1
        Me.btnExpandirTodo.ToolTip = "Expandir todo"
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFiltrar.Location = New System.Drawing.Point(361, 70)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(47, 23)
        Me.cmdFiltrar.TabIndex = 1
        Me.cmdFiltrar.Text = "Filtrar"
        Me.cmdFiltrar.ToolTip = "Copiar el contenido al portapapeles"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.ImageOptions.Image = CType(resources.GetObject("btnFiltrar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFiltrar.Location = New System.Drawing.Point(5, 41)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 1
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.ToolTip = "Copiar el contenido al portapapeles"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 30)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la consulta que desea realizar de la lista debajo..."
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(3, 73)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(415, 308)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colXX_CATEGO, Me.colCV_CODCON, Me.colCV_NOMBRE})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupFormat = "[#image]{1} {2}"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowPreview = True
        Me.GridView1.PreviewFieldName = "CV_DESCRI"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colXX_CATEGO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colXX_CATEGO
        '
        Me.colXX_CATEGO.FieldName = "XX_CATEGO"
        Me.colXX_CATEGO.GroupFormat.FormatString = " "
        Me.colXX_CATEGO.Name = "colXX_CATEGO"
        Me.colXX_CATEGO.Visible = True
        Me.colXX_CATEGO.VisibleIndex = 0
        '
        'colCV_CODCON
        '
        Me.colCV_CODCON.FieldName = "CV_CODCON"
        Me.colCV_CODCON.Name = "colCV_CODCON"
        '
        'colCV_NOMBRE
        '
        Me.colCV_NOMBRE.Caption = "Denominación de la consulta"
        Me.colCV_NOMBRE.FieldName = "CV_NOMBRE"
        Me.colCV_NOMBRE.Name = "colCV_NOMBRE"
        Me.colCV_NOMBRE.Visible = True
        Me.colCV_NOMBRE.VisibleIndex = 0
        '
        'frmConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(421, 417)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consultas varias - Listado"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnContraerTodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExpandirTodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFiltrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblFiltro As Label
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdFiltrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colXX_CATEGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCV_CODCON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCV_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
End Class
