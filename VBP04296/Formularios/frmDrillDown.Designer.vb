<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrillDown
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrillDown))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.tabDrillDown = New DevExpress.XtraTab.XtraTabControl()
        Me.tabProcesos = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlProceso = New DevExpress.XtraEditors.PanelControl()
        Me.btn = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlQuery = New DevExpress.XtraEditors.PanelControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.tabDrillDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDrillDown.SuspendLayout()
        Me.tabProcesos.SuspendLayout()
        CType(Me.pnlProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn.SuspendLayout()
        CType(Me.pnlQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Controls.Add(Me.lblSubtitulo)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 40)
        Me.Panel1.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 3)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(349, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Especifique el Query que devolvera los registros del Drill Down"
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblSubtitulo.Appearance.Options.UseForeColor = True
        Me.lblSubtitulo.Location = New System.Drawing.Point(23, 22)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(551, 13)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "Para especificar valores de la grilla que lanza el drill down especifique @ y el " &
    "nombre de campo (ej. @DC_CUADRO)"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(635, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(52, 40)
        Me.PictureEdit1.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(3, 403)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(681, 34)
        Me.PanelControl1.TabIndex = 1
        '
        'cmdGuardar
        '
        Me.cmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdGuardar.ImageOptions.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(516, 6)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "&Guardar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(597, 6)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 0
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'tabDrillDown
        '
        Me.tabDrillDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDrillDown.Location = New System.Drawing.Point(0, 43)
        Me.tabDrillDown.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.tabDrillDown.Name = "tabDrillDown"
        Me.tabDrillDown.SelectedTabPage = Me.btn
        Me.tabDrillDown.Size = New System.Drawing.Size(687, 357)
        Me.tabDrillDown.TabIndex = 0
        Me.tabDrillDown.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.btn, Me.tabProcesos})
        '
        'tabProcesos
        '
        Me.tabProcesos.Controls.Add(Me.pnlProceso)
        Me.tabProcesos.ImageOptions.Image = CType(resources.GetObject("tabProcesos.ImageOptions.Image"), System.Drawing.Image)
        Me.tabProcesos.Name = "tabProcesos"
        Me.tabProcesos.Size = New System.Drawing.Size(681, 326)
        Me.tabProcesos.Text = "Procesos previos"
        '
        'pnlProceso
        '
        Me.pnlProceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProceso.Location = New System.Drawing.Point(0, 0)
        Me.pnlProceso.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlProceso.Name = "pnlProceso"
        Me.pnlProceso.Size = New System.Drawing.Size(681, 326)
        Me.pnlProceso.TabIndex = 0
        '
        'btn
        '
        Me.btn.Controls.Add(Me.pnlQuery)
        Me.btn.ImageOptions.Image = CType(resources.GetObject("btn.ImageOptions.Image"), System.Drawing.Image)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(681, 326)
        Me.btn.Text = "Query"
        '
        'pnlQuery
        '
        Me.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlQuery.Location = New System.Drawing.Point(0, 0)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Size = New System.Drawing.Size(681, 326)
        Me.pnlQuery.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tabDrillDown, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(687, 440)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'frmDrillDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 440)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDrillDown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Drill Down Daotos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.tabDrillDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDrillDown.ResumeLayout(False)
        Me.tabProcesos.ResumeLayout(False)
        CType(Me.pnlProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn.ResumeLayout(False)
        CType(Me.pnlQuery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabDrillDown As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents btn As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlQuery As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabProcesos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlProceso As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
