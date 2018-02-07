<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQLWizard
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSQLWizard))
        Me.sypMain = New ActiveDatabaseSoftware.ActiveQueryBuilder.UniversalSyntaxProvider
        Me.OLEDBMDP = New ActiveDatabaseSoftware.ActiveQueryBuilder.OLEDBMetadataProvider
        Me.MSSQLMDP = New ActiveDatabaseSoftware.ActiveQueryBuilder.MSSQLMetadataProvider
        Me.oSplitter = New DevExpress.XtraEditors.SplitContainerControl
        Me.qbMain = New ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder
        Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList16 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtSQL = New DevExpress.XtraEditors.MemoEdit
        Me.ptbSQL = New ActiveDatabaseSoftware.ActiveQueryBuilder.PlainTextSQLBuilder
        Me.pcMain = New DevExpress.XtraEditors.PanelControl
        Me.pcLeft = New DevExpress.XtraEditors.PanelControl
        Me.cmdPropiedades = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAgregarObjeto = New DevExpress.XtraEditors.SimpleButton
        Me.pcRight = New DevExpress.XtraEditors.PanelControl
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.ODBCMDP = New ActiveDatabaseSoftware.ActiveQueryBuilder.ODBCMetadataProvider
        Me.ORAMDP = New ActiveDatabaseSoftware.ActiveQueryBuilder.OracleMetadataProvider
        CType(Me.oSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitter.SuspendLayout()
        CType(Me.txtSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcMain.SuspendLayout()
        CType(Me.pcLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcLeft.SuspendLayout()
        CType(Me.pcRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'sypMain
        '
        Me.sypMain.BuiltinFunctionNames = CType(resources.GetObject("sypMain.BuiltinFunctionNames"), System.Collections.Generic.List(Of String))
        '
        'OLEDBMDP
        '
        Me.OLEDBMDP.Connection = Nothing
        '
        'MSSQLMDP
        '
        Me.MSSQLMDP.Connection = Nothing
        '
        'oSplitter
        '
        Me.oSplitter.Dock = System.Windows.Forms.DockStyle.Top
        Me.oSplitter.Horizontal = False
        Me.oSplitter.Location = New System.Drawing.Point(0, 0)
        Me.oSplitter.Name = "oSplitter"
        Me.oSplitter.Panel1.Controls.Add(Me.qbMain)
        Me.oSplitter.Panel1.Text = "Panel1"
        Me.oSplitter.Panel2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oSplitter.Panel2.AppearanceCaption.Options.UseFont = True
        Me.oSplitter.Panel2.Controls.Add(Me.txtSQL)
        Me.oSplitter.Panel2.ShowCaption = True
        Me.oSplitter.Panel2.Text = "SQL"
        Me.oSplitter.Size = New System.Drawing.Size(666, 449)
        Me.oSplitter.SplitterPosition = 342
        Me.oSplitter.TabIndex = 1
        '
        'qbMain
        '
        Me.qbMain.AddObjectFormOptions.Height = 342
        Me.qbMain.AddObjectFormOptions.ImageIndexProcs = 2
        Me.qbMain.AddObjectFormOptions.ImageIndexTables = 0
        Me.qbMain.AddObjectFormOptions.ImageIndexViews = 1
        Me.qbMain.AddObjectFormOptions.ImageListLarge = Me.imageList32
        Me.qbMain.AddObjectFormOptions.ListViewStyle = System.Windows.Forms.View.LargeIcon
        Me.qbMain.AddObjectFormOptions.MinimumSize = New System.Drawing.Size(430, 430)
        Me.qbMain.AddObjectFormOptions.ShowSynonyms = False
        Me.qbMain.AddObjectFormOptions.Width = 294
        Me.qbMain.CriteriListOptions.CriteriaListFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qbMain.DiagramObjectColor = System.Drawing.SystemColors.Window
        Me.qbMain.DiagramObjectFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.qbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.qbMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qbMain.Location = New System.Drawing.Point(0, 0)
        Me.qbMain.MetadataProvider = Nothing
        Me.qbMain.MetadataTreeOptions.DatabaseImageIndex = 6
        Me.qbMain.MetadataTreeOptions.ImageList = Me.imageList16
        Me.qbMain.MetadataTreeOptions.ProceduresNodeImageIndex = 4
        Me.qbMain.MetadataTreeOptions.ProceduresNodeText = Nothing
        Me.qbMain.MetadataTreeOptions.SchemaImageIndex = 5
        Me.qbMain.MetadataTreeOptions.SynonymsNodeText = Nothing
        Me.qbMain.MetadataTreeOptions.SystemProceduresImageIndex = 2
        Me.qbMain.MetadataTreeOptions.SystemTablesImageIndex = 0
        Me.qbMain.MetadataTreeOptions.SystemViewsImageIndex = 1
        Me.qbMain.MetadataTreeOptions.TablesNodeImageIndex = 4
        Me.qbMain.MetadataTreeOptions.TablesNodeText = Nothing
        Me.qbMain.MetadataTreeOptions.TreeWidth = 200
        Me.qbMain.MetadataTreeOptions.UserProceduresImageIndex = 2
        Me.qbMain.MetadataTreeOptions.UserTablesImageIndex = 0
        Me.qbMain.MetadataTreeOptions.UserViewsImageIndex = 1
        Me.qbMain.MetadataTreeOptions.ViewsNodeImageIndex = 4
        Me.qbMain.MetadataTreeOptions.ViewsNodeText = Nothing
        Me.qbMain.Name = "qbMain"
        Me.qbMain.QueryStructureTreeOptions.FieldImageIndex = 8
        Me.qbMain.QueryStructureTreeOptions.FieldsImageIndex = 7
        Me.qbMain.QueryStructureTreeOptions.FieldsNodeText = "Expressions"
        Me.qbMain.QueryStructureTreeOptions.FromImageIndex = 4
        Me.qbMain.QueryStructureTreeOptions.FromNodeText = "Objects"
        Me.qbMain.QueryStructureTreeOptions.FromObjImageIndex = 0
        Me.qbMain.QueryStructureTreeOptions.ImageList = Me.imageList16
        Me.qbMain.QueryStructureTreeOptions.QueriesImageIndex = 3
        Me.qbMain.QueryStructureTreeOptions.UnionsNodeText = "Unions"
        Me.qbMain.Size = New System.Drawing.Size(662, 338)
        Me.qbMain.SleepModeText = Nothing
        Me.qbMain.SnapSize = New System.Drawing.Size(5, 5)
        Me.qbMain.SyntaxProvider = Me.sypMain
        Me.qbMain.TabIndex = 1
        Me.qbMain.TabsAppearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.qbMain.TreeFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.qbMain.UseAltNames = False
        '
        'imageList32
        '
        Me.imageList32.ImageStream = CType(resources.GetObject("imageList32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList32.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList32.Images.SetKeyName(0, "FilaSubTotales.png")
        Me.imageList32.Images.SetKeyName(1, "Vista.png")
        Me.imageList32.Images.SetKeyName(2, "Procedimiento.png")
        '
        'imageList16
        '
        Me.imageList16.ImageStream = CType(resources.GetObject("imageList16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList16.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList16.Images.SetKeyName(0, "0.bmp")
        Me.imageList16.Images.SetKeyName(1, "1.bmp")
        Me.imageList16.Images.SetKeyName(2, "2.bmp")
        Me.imageList16.Images.SetKeyName(3, "3.bmp")
        Me.imageList16.Images.SetKeyName(4, "4.bmp")
        Me.imageList16.Images.SetKeyName(5, "5.bmp")
        Me.imageList16.Images.SetKeyName(6, "6.bmp")
        Me.imageList16.Images.SetKeyName(7, "7.bmp")
        Me.imageList16.Images.SetKeyName(8, "8.bmp")
        '
        'txtSQL
        '
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQL.Location = New System.Drawing.Point(0, 0)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQL.Properties.Appearance.Options.UseFont = True
        Me.txtSQL.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSQL.Size = New System.Drawing.Size(662, 81)
        Me.txtSQL.TabIndex = 0
        '
        'ptbSQL
        '
        Me.ptbSQL.QueryBuilder = Me.qbMain
        Me.ptbSQL.UseAltNames = False
        '
        'pcMain
        '
        Me.pcMain.Controls.Add(Me.pcLeft)
        Me.pcMain.Controls.Add(Me.pcRight)
        Me.pcMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pcMain.Location = New System.Drawing.Point(0, 461)
        Me.pcMain.Name = "pcMain"
        Me.pcMain.Size = New System.Drawing.Size(666, 50)
        Me.pcMain.TabIndex = 2
        '
        'pcLeft
        '
        Me.pcLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcLeft.Controls.Add(Me.cmdPropiedades)
        Me.pcLeft.Controls.Add(Me.cmdAgregarObjeto)
        Me.pcLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcLeft.Location = New System.Drawing.Point(2, 2)
        Me.pcLeft.Name = "pcLeft"
        Me.pcLeft.Size = New System.Drawing.Size(190, 46)
        Me.pcLeft.TabIndex = 0
        '
        'cmdPropiedades
        '
        Me.cmdPropiedades.Location = New System.Drawing.Point(120, 9)
        Me.cmdPropiedades.Name = "cmdPropiedades"
        Me.cmdPropiedades.Size = New System.Drawing.Size(105, 28)
        Me.cmdPropiedades.TabIndex = 1
        Me.cmdPropiedades.Text = "Propiedades"
        Me.cmdPropiedades.Visible = False
        '
        'cmdAgregarObjeto
        '
        Me.cmdAgregarObjeto.Location = New System.Drawing.Point(8, 9)
        Me.cmdAgregarObjeto.Name = "cmdAgregarObjeto"
        Me.cmdAgregarObjeto.Size = New System.Drawing.Size(105, 28)
        Me.cmdAgregarObjeto.TabIndex = 0
        Me.cmdAgregarObjeto.Text = "Agregar objeto"
        '
        'pcRight
        '
        Me.pcRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcRight.Controls.Add(Me.cmdAceptar)
        Me.pcRight.Controls.Add(Me.cmdCancelar)
        Me.pcRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pcRight.Location = New System.Drawing.Point(382, 2)
        Me.pcRight.Name = "pcRight"
        Me.pcRight.Size = New System.Drawing.Size(282, 46)
        Me.pcRight.TabIndex = 1
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(58, 9)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(105, 28)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(169, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(105, 28)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'ODBCMDP
        '
        Me.ODBCMDP.Connection = Nothing
        '
        'ORAMDP
        '
        Me.ORAMDP.Connection = Nothing
        '
        'frmSQLWizard
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(666, 511)
        Me.Controls.Add(Me.pcMain)
        Me.Controls.Add(Me.oSplitter)
        Me.MinimizeBox = False
        Me.Name = "frmSQLWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Query builder"
        CType(Me.oSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitter.ResumeLayout(False)
        CType(Me.txtSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcMain.ResumeLayout(False)
        CType(Me.pcLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcLeft.ResumeLayout(False)
        CType(Me.pcRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcRight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sypMain As ActiveDatabaseSoftware.ActiveQueryBuilder.UniversalSyntaxProvider
    Friend WithEvents OLEDBMDP As ActiveDatabaseSoftware.ActiveQueryBuilder.OLEDBMetadataProvider
    Friend WithEvents MSSQLMDP As ActiveDatabaseSoftware.ActiveQueryBuilder.MSSQLMetadataProvider
    Friend WithEvents oSplitter As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtSQL As DevExpress.XtraEditors.MemoEdit
    Private WithEvents qbMain As ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder
    Private WithEvents imageList16 As System.Windows.Forms.ImageList
    Friend WithEvents pcMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pcRight As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pcLeft As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAgregarObjeto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPropiedades As DevExpress.XtraEditors.SimpleButton
    Private WithEvents ptbSQL As ActiveDatabaseSoftware.ActiveQueryBuilder.PlainTextSQLBuilder
    Private WithEvents imageList32 As System.Windows.Forms.ImageList
    Friend WithEvents ODBCMDP As ActiveDatabaseSoftware.ActiveQueryBuilder.ODBCMetadataProvider
    Friend WithEvents ORAMDP As ActiveDatabaseSoftware.ActiveQueryBuilder.OracleMetadataProvider
End Class
