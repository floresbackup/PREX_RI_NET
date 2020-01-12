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
        Me.tabProcesos = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlProceso = New DevExpress.XtraEditors.PanelControl()
        Me.btn = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlQuery = New DevExpress.XtraEditors.PanelControl()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnEjecutar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAgrupar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOrdenar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnColumnas = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFuente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFormato = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIzq = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCen = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAuto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFrente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFondo = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.tabDrillDown = New DevExpress.XtraTab.XtraTabControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.tabProcesos.SuspendLayout()
        CType(Me.pnlProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn.SuspendLayout()
        CType(Me.pnlQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDrillDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDrillDown.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn.Controls.Add(Me.StandaloneBarDockControl1)
        Me.btn.ImageOptions.Image = CType(resources.GetObject("btn.ImageOptions.Image"), System.Drawing.Image)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(681, 326)
        Me.btn.Text = "Query"
        '
        'pnlQuery
        '
        Me.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlQuery.Location = New System.Drawing.Point(0, 32)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Size = New System.Drawing.Size(681, 294)
        Me.pnlQuery.TabIndex = 1
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.CausesValidation = False
        Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl1.Manager = Me.BarManager1
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(681, 32)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnEjecutar, Me.btnGuardar, Me.btnAgrupar, Me.btnOrdenar, Me.btnColumnas, Me.BarButtonItem1, Me.btnFuente, Me.btnFormato, Me.btnIzq, Me.btnCen, Me.btnDer, Me.btnAuto, Me.btnFondo, Me.btnFrente, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 15
        '
        'Bar1
        '
        Me.Bar1.BarName = "Personalizada 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar1.FloatLocation = New System.Drawing.Point(118, 203)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEjecutar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnGuardar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAgrupar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnOrdenar, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnColumnas), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFuente, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFormato), New DevExpress.XtraBars.LinkPersistInfo(Me.btnIzq, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCen), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDer), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAuto, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFrente, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFondo)})
        Me.Bar1.StandaloneBarDockControl = Me.StandaloneBarDockControl1
        Me.Bar1.Text = "Personalizada 3"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Caption = "Actualizar datos columnas"
        Me.btnEjecutar.Id = 0
        Me.btnEjecutar.ImageOptions.Image = CType(resources.GetObject("btnEjecutar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEjecutar.ImageOptions.LargeImage = CType(resources.GetObject("btnEjecutar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEjecutar.Name = "btnEjecutar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar consulta"
        Me.btnGuardar.Id = 1
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageOptions.LargeImage = CType(resources.GetObject("btnGuardar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        '
        'btnAgrupar
        '
        Me.btnAgrupar.Caption = "Agrupar"
        Me.btnAgrupar.Id = 2
        Me.btnAgrupar.ImageOptions.Image = CType(resources.GetObject("btnAgrupar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgrupar.ImageOptions.LargeImage = CType(resources.GetObject("btnAgrupar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAgrupar.Name = "btnAgrupar"
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Caption = "Ordenar"
        Me.btnOrdenar.Id = 3
        Me.btnOrdenar.ImageOptions.Image = CType(resources.GetObject("btnOrdenar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOrdenar.ImageOptions.LargeImage = CType(resources.GetObject("btnOrdenar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnOrdenar.Name = "btnOrdenar"
        '
        'btnColumnas
        '
        Me.btnColumnas.Caption = "Columnas"
        Me.btnColumnas.Id = 4
        Me.btnColumnas.ImageOptions.Image = CType(resources.GetObject("btnColumnas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnColumnas.ImageOptions.LargeImage = CType(resources.GetObject("btnColumnas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnColumnas.Name = "btnColumnas"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Eliminar"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnFuente
        '
        Me.btnFuente.Caption = "Fuente"
        Me.btnFuente.Id = 6
        Me.btnFuente.ImageOptions.Image = CType(resources.GetObject("btnFuente.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFuente.ImageOptions.LargeImage = CType(resources.GetObject("btnFuente.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFuente.Name = "btnFuente"
        '
        'btnFormato
        '
        Me.btnFormato.Caption = "Formato"
        Me.btnFormato.Id = 7
        Me.btnFormato.ImageOptions.Image = CType(resources.GetObject("btnFormato.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFormato.ImageOptions.LargeImage = CType(resources.GetObject("btnFormato.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFormato.Name = "btnFormato"
        '
        'btnIzq
        '
        Me.btnIzq.Caption = "Izquierda"
        Me.btnIzq.Id = 8
        Me.btnIzq.ImageOptions.Image = CType(resources.GetObject("btnIzq.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIzq.ImageOptions.LargeImage = CType(resources.GetObject("btnIzq.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnIzq.Name = "btnIzq"
        '
        'btnCen
        '
        Me.btnCen.Caption = "Centro"
        Me.btnCen.Id = 9
        Me.btnCen.ImageOptions.Image = CType(resources.GetObject("btnCen.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCen.ImageOptions.LargeImage = CType(resources.GetObject("btnCen.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCen.Name = "btnCen"
        '
        'btnDer
        '
        Me.btnDer.Caption = "Derecha"
        Me.btnDer.Id = 10
        Me.btnDer.ImageOptions.Image = CType(resources.GetObject("btnDer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDer.ImageOptions.LargeImage = CType(resources.GetObject("btnDer.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDer.Name = "btnDer"
        '
        'btnAuto
        '
        Me.btnAuto.Caption = "Auto"
        Me.btnAuto.Id = 11
        Me.btnAuto.ImageOptions.Image = CType(resources.GetObject("btnAuto.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAuto.ImageOptions.LargeImage = CType(resources.GetObject("btnAuto.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAuto.Name = "btnAuto"
        '
        'btnFrente
        '
        Me.btnFrente.Caption = "Frente"
        Me.btnFrente.Id = 13
        Me.btnFrente.ImageOptions.Image = CType(resources.GetObject("btnFrente.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFrente.ImageOptions.LargeImage = CType(resources.GetObject("btnFrente.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFrente.Name = "btnFrente"
        '
        'btnFondo
        '
        Me.btnFondo.Caption = "Fondo"
        Me.btnFondo.Id = 12
        Me.btnFondo.ImageOptions.Image = CType(resources.GetObject("btnFondo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFondo.ImageOptions.LargeImage = CType(resources.GetObject("btnFondo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFondo.Name = "btnFondo"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(687, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 440)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(687, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 440)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(687, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 440)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 14
        Me.BarButtonItem2.Name = "BarButtonItem2"
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
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(635, 0)
        Me.PictureEdit1.MenuManager = Me.BarManager1
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(52, 40)
        Me.PictureEdit1.TabIndex = 2
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
        'frmDrillDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 440)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDrillDown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Drill Down Daotos"
        Me.tabProcesos.ResumeLayout(False)
        CType(Me.pnlProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn.ResumeLayout(False)
        CType(Me.pnlQuery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDrillDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDrillDown.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabProcesos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btn As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnEjecutar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAgrupar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOrdenar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnColumnas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFuente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFormato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnIzq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAuto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFrente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFondo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents tabDrillDown As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pnlQuery As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pnlProceso As DevExpress.XtraEditors.PanelControl
End Class
