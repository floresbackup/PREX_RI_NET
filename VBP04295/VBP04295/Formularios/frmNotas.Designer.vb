<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotas
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotas))
        Me.PanTop = New DevExpress.XtraEditors.PanelControl()
        Me.lblSubtitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CM_CLAVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CM_FECPRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XX_CODUSU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CM_COMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolBarra = New System.Windows.Forms.ToolStrip()
        Me.btnNegrita = New System.Windows.Forms.ToolStripButton()
        Me.btnCursiva = New System.Windows.Forms.ToolStripButton()
        Me.btnSubrayado = New System.Windows.Forms.ToolStripButton()
        Me.btnSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnIzquierda = New System.Windows.Forms.ToolStripButton()
        Me.btnCentro = New System.Windows.Forms.ToolStripButton()
        Me.btnDerecha = New System.Windows.Forms.ToolStripButton()
        Me.btnSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDeshacer = New System.Windows.Forms.ToolStripButton()
        Me.btnRehacer = New System.Windows.Forms.ToolStripButton()
        Me.btnSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCortar = New System.Windows.Forms.ToolStripButton()
        Me.btnCopiar = New System.Windows.Forms.ToolStripButton()
        Me.btnPegar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnSep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblFuente = New System.Windows.Forms.ToolStripLabel()
        Me.cboFuente = New System.Windows.Forms.ToolStripComboBox()
        Me.lblTamano = New System.Windows.Forms.ToolStripLabel()
        Me.cboTamano = New System.Windows.Forms.ToolStripComboBox()
        Me.PanResto = New DevExpress.XtraEditors.PanelControl()
        Me.panRTF = New DevExpress.XtraEditors.PanelControl()
        Me.rtfNota = New VBP04295.RichTextBoxPrintCtrl()
        Me.panBotones = New DevExpress.XtraEditors.PanelControl()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.pDiagRTF = New System.Windows.Forms.PrintDialog()
        Me.pDocRTF = New System.Drawing.Printing.PrintDocument()
        Me.pSetupRTF = New System.Windows.Forms.PageSetupDialog()
        Me.pPreviewRTF = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTop.SuspendLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolBarra.SuspendLayout()
        CType(Me.PanResto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanResto.SuspendLayout()
        CType(Me.panRTF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panRTF.SuspendLayout()
        CType(Me.panBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanTop
        '
        Me.PanTop.Appearance.BackColor = System.Drawing.Color.White
        Me.PanTop.Appearance.Options.UseBackColor = True
        Me.PanTop.Controls.Add(Me.lblSubtitulo)
        Me.PanTop.Controls.Add(Me.lblTitulo)
        Me.PanTop.Controls.Add(Me.picLogo)
        Me.PanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTop.Location = New System.Drawing.Point(0, 0)
        Me.PanTop.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanTop.Name = "PanTop"
        Me.PanTop.Size = New System.Drawing.Size(699, 54)
        Me.PanTop.TabIndex = 15
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.Location = New System.Drawing.Point(24, 29)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(354, 13)
        Me.lblSubtitulo.TabIndex = 2
        Me.lblSubtitulo.Text = "Seleccione un comentario previo o bien ingrese uno y haga clic en guardar"
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(151, 13)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Ver o agregar comentarios"
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.picLogo.EditValue = Global.VBP04295.My.Resources.Resources.Note1
        Me.picLogo.Location = New System.Drawing.Point(638, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Properties.Appearance.Options.UseBackColor = True
        Me.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picLogo.Size = New System.Drawing.Size(59, 50)
        Me.picLogo.TabIndex = 0
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grid.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.Grid.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 54)
        Me.Grid.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.Grid.LookAndFeel.UseWindowsXPTheme = True
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(699, 123)
        Me.Grid.TabIndex = 16
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CM_CLAVE, Me.CM_FECPRO, Me.XX_CODUSU, Me.CM_COMENT})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.GroupPanelText = "Arrastre el encabezado de columna aquí para agrupar por esa columna"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "WindowsXP"
        Me.GridView1.RowHeight = 19
        '
        'CM_CLAVE
        '
        Me.CM_CLAVE.Caption = "Clave"
        Me.CM_CLAVE.FieldName = "CM_CLAVE"
        Me.CM_CLAVE.Name = "CM_CLAVE"
        Me.CM_CLAVE.OptionsColumn.AllowEdit = False
        Me.CM_CLAVE.OptionsColumn.AllowFocus = False
        Me.CM_CLAVE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.CM_CLAVE.OptionsColumn.AllowMove = False
        Me.CM_CLAVE.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'CM_FECPRO
        '
        Me.CM_FECPRO.Caption = "Fecha / Hora"
        Me.CM_FECPRO.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.CM_FECPRO.FieldName = "CM_FECPRO"
        Me.CM_FECPRO.Name = "CM_FECPRO"
        Me.CM_FECPRO.OptionsColumn.AllowEdit = False
        Me.CM_FECPRO.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.CM_FECPRO.Visible = True
        Me.CM_FECPRO.VisibleIndex = 0
        Me.CM_FECPRO.Width = 150
        '
        'XX_CODUSU
        '
        Me.XX_CODUSU.Caption = "Usuario"
        Me.XX_CODUSU.FieldName = "XX_CODUSU"
        Me.XX_CODUSU.Name = "XX_CODUSU"
        Me.XX_CODUSU.OptionsColumn.AllowEdit = False
        Me.XX_CODUSU.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.XX_CODUSU.OptionsColumn.AllowSize = False
        Me.XX_CODUSU.OptionsColumn.FixedWidth = True
        Me.XX_CODUSU.OptionsColumn.ReadOnly = True
        Me.XX_CODUSU.OptionsColumn.ShowInCustomizationForm = False
        Me.XX_CODUSU.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.XX_CODUSU.Visible = True
        Me.XX_CODUSU.VisibleIndex = 1
        Me.XX_CODUSU.Width = 200
        '
        'CM_COMENT
        '
        Me.CM_COMENT.Caption = "Comentario"
        Me.CM_COMENT.FieldName = "CM_COMENT"
        Me.CM_COMENT.Name = "CM_COMENT"
        Me.CM_COMENT.OptionsColumn.AllowEdit = False
        Me.CM_COMENT.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'ToolBarra
        '
        Me.ToolBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNegrita, Me.btnCursiva, Me.btnSubrayado, Me.btnSep1, Me.btnIzquierda, Me.btnCentro, Me.btnDerecha, Me.btnSep2, Me.btnDeshacer, Me.btnRehacer, Me.btnSep3, Me.btnCortar, Me.btnCopiar, Me.btnPegar, Me.ToolStripSeparator1, Me.btnDelete, Me.btnSep4, Me.lblFuente, Me.cboFuente, Me.lblTamano, Me.cboTamano})
        Me.ToolBarra.Location = New System.Drawing.Point(0, 177)
        Me.ToolBarra.Name = "ToolBarra"
        Me.ToolBarra.Size = New System.Drawing.Size(699, 25)
        Me.ToolBarra.TabIndex = 17
        Me.ToolBarra.Text = "ToolStrip1"
        '
        'btnNegrita
        '
        Me.btnNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNegrita.Image = Global.VBP04295.My.Resources.Resources.Bold_2
        Me.btnNegrita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNegrita.Name = "btnNegrita"
        Me.btnNegrita.Size = New System.Drawing.Size(23, 22)
        Me.btnNegrita.Text = "Negrita"
        '
        'btnCursiva
        '
        Me.btnCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCursiva.Image = Global.VBP04295.My.Resources.Resources.Italic_2
        Me.btnCursiva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCursiva.Name = "btnCursiva"
        Me.btnCursiva.Size = New System.Drawing.Size(23, 22)
        Me.btnCursiva.Text = "Cursiva"
        '
        'btnSubrayado
        '
        Me.btnSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSubrayado.Image = Global.VBP04295.My.Resources.Resources.Underline_2
        Me.btnSubrayado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSubrayado.Name = "btnSubrayado"
        Me.btnSubrayado.Size = New System.Drawing.Size(23, 22)
        Me.btnSubrayado.Text = "Subrayado"
        '
        'btnSep1
        '
        Me.btnSep1.Name = "btnSep1"
        Me.btnSep1.Size = New System.Drawing.Size(6, 25)
        '
        'btnIzquierda
        '
        Me.btnIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIzquierda.Image = Global.VBP04295.My.Resources.Resources.Align_Left_3
        Me.btnIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(23, 22)
        Me.btnIzquierda.Text = "Alinear a la izquierda"
        '
        'btnCentro
        '
        Me.btnCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCentro.Image = Global.VBP04295.My.Resources.Resources.Align_Centre_3
        Me.btnCentro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCentro.Name = "btnCentro"
        Me.btnCentro.Size = New System.Drawing.Size(23, 22)
        Me.btnCentro.Text = "Alinear al centro"
        '
        'btnDerecha
        '
        Me.btnDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDerecha.Image = Global.VBP04295.My.Resources.Resources.Align_Right_3
        Me.btnDerecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(23, 22)
        Me.btnDerecha.Text = "Alinear a la derecha"
        '
        'btnSep2
        '
        Me.btnSep2.Name = "btnSep2"
        Me.btnSep2.Size = New System.Drawing.Size(6, 25)
        '
        'btnDeshacer
        '
        Me.btnDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeshacer.Image = Global.VBP04295.My.Resources.Resources.Undo
        Me.btnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(23, 22)
        Me.btnDeshacer.Text = "Deshacer"
        '
        'btnRehacer
        '
        Me.btnRehacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRehacer.Image = Global.VBP04295.My.Resources.Resources.Redo
        Me.btnRehacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRehacer.Name = "btnRehacer"
        Me.btnRehacer.Size = New System.Drawing.Size(23, 22)
        Me.btnRehacer.Text = "Rehacer"
        '
        'btnSep3
        '
        Me.btnSep3.Name = "btnSep3"
        Me.btnSep3.Size = New System.Drawing.Size(6, 25)
        '
        'btnCortar
        '
        Me.btnCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCortar.Image = Global.VBP04295.My.Resources.Resources.Cut
        Me.btnCortar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCortar.Name = "btnCortar"
        Me.btnCortar.Size = New System.Drawing.Size(23, 22)
        Me.btnCortar.Text = "Cortar"
        '
        'btnCopiar
        '
        Me.btnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopiar.Image = Global.VBP04295.My.Resources.Resources.Copy
        Me.btnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(23, 22)
        Me.btnCopiar.Text = "Copiar"
        '
        'btnPegar
        '
        Me.btnPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPegar.Image = Global.VBP04295.My.Resources.Resources.Paste
        Me.btnPegar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPegar.Name = "btnPegar"
        Me.btnPegar.Size = New System.Drawing.Size(23, 22)
        Me.btnPegar.Text = "Pegar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = Global.VBP04295.My.Resources.Resources.Note_Delete
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.Visible = False
        '
        'btnSep4
        '
        Me.btnSep4.Name = "btnSep4"
        Me.btnSep4.Size = New System.Drawing.Size(6, 25)
        '
        'lblFuente
        '
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(46, 22)
        Me.lblFuente.Text = "Fuente:"
        '
        'cboFuente
        '
        Me.cboFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuente.Name = "cboFuente"
        Me.cboFuente.Size = New System.Drawing.Size(121, 25)
        '
        'lblTamano
        '
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(54, 22)
        Me.lblTamano.Text = "Tamaño:"
        '
        'cboTamano
        '
        Me.cboTamano.Name = "cboTamano"
        Me.cboTamano.Size = New System.Drawing.Size(75, 25)
        '
        'PanResto
        '
        Me.PanResto.Controls.Add(Me.panRTF)
        Me.PanResto.Controls.Add(Me.panBotones)
        Me.PanResto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanResto.Location = New System.Drawing.Point(0, 202)
        Me.PanResto.Name = "PanResto"
        Me.PanResto.Size = New System.Drawing.Size(699, 204)
        Me.PanResto.TabIndex = 18
        '
        'panRTF
        '
        Me.panRTF.Controls.Add(Me.rtfNota)
        Me.panRTF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panRTF.Location = New System.Drawing.Point(2, 2)
        Me.panRTF.Name = "panRTF"
        Me.panRTF.Size = New System.Drawing.Size(695, 167)
        Me.panRTF.TabIndex = 22
        '
        'rtfNota
        '
        Me.rtfNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfNota.HideSelection = False
        Me.rtfNota.Location = New System.Drawing.Point(2, 2)
        Me.rtfNota.Name = "rtfNota"
        Me.rtfNota.ShowSelectionMargin = True
        Me.rtfNota.Size = New System.Drawing.Size(691, 163)
        Me.rtfNota.TabIndex = 22
        Me.rtfNota.Text = ""
        '
        'panBotones
        '
        Me.panBotones.Controls.Add(Me.cmdImprimir)
        Me.panBotones.Controls.Add(Me.cmdGuardar)
        Me.panBotones.Controls.Add(Me.cmdCerrar)
        Me.panBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panBotones.Location = New System.Drawing.Point(2, 169)
        Me.panBotones.Name = "panBotones"
        Me.panBotones.Size = New System.Drawing.Size(695, 33)
        Me.panBotones.TabIndex = 21
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(5, 5)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 23)
        Me.cmdImprimir.TabIndex = 2
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(86, 5)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 1
        Me.cmdGuardar.Text = "&Guardar"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(167, 5)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrar.TabIndex = 0
        Me.cmdCerrar.Text = "&Cerrar"
        '
        'pDiagRTF
        '
        Me.pDiagRTF.UseEXDialog = True
        '
        'pDocRTF
        '
        '
        'pPreviewRTF
        '
        Me.pPreviewRTF.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.pPreviewRTF.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.pPreviewRTF.ClientSize = New System.Drawing.Size(400, 300)
        Me.pPreviewRTF.Enabled = True
        Me.pPreviewRTF.Icon = CType(resources.GetObject("pPreviewRTF.Icon"), System.Drawing.Icon)
        Me.pPreviewRTF.Name = "pPreviewRTF"
        Me.pPreviewRTF.Visible = False
        '
        'frmNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 406)
        Me.Controls.Add(Me.PanResto)
        Me.Controls.Add(Me.ToolBarra)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.PanTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comentarios"
        CType(Me.PanTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTop.ResumeLayout(False)
        Me.PanTop.PerformLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolBarra.ResumeLayout(False)
        Me.ToolBarra.PerformLayout()
        CType(Me.PanResto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanResto.ResumeLayout(False)
        CType(Me.panRTF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panRTF.ResumeLayout(False)
        CType(Me.panBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanTop As DevExpress.XtraEditors.PanelControl
   Friend WithEvents lblSubtitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
   Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
   Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
   Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents CM_CLAVE As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents CM_FECPRO As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents XX_CODUSU As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents CM_COMENT As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents ToolBarra As System.Windows.Forms.ToolStrip
   Friend WithEvents btnNegrita As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnCursiva As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnSubrayado As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnSep1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnIzquierda As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnCentro As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnDerecha As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnSep2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnDeshacer As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnRehacer As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnSep3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnCortar As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnCopiar As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnPegar As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnSep4 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents lblFuente As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboFuente As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents lblTamano As System.Windows.Forms.ToolStripLabel
   Friend WithEvents cboTamano As System.Windows.Forms.ToolStripComboBox
   Friend WithEvents PanResto As DevExpress.XtraEditors.PanelControl
   Friend WithEvents panRTF As DevExpress.XtraEditors.PanelControl
   Friend WithEvents panBotones As DevExpress.XtraEditors.PanelControl
   Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
   Friend WithEvents pDiagRTF As System.Windows.Forms.PrintDialog
   Friend WithEvents pDocRTF As System.Drawing.Printing.PrintDocument
   Friend WithEvents pSetupRTF As System.Windows.Forms.PageSetupDialog
   Friend WithEvents pPreviewRTF As System.Windows.Forms.PrintPreviewDialog
   Friend WithEvents rtfNota As VBP04295.RichTextBoxPrintCtrl
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
