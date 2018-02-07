<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Me.GridControl1 = New DevExpress.XtraGrid.GridControl
      Me.USUGRUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.INST_PREXRIDataSet = New WindowsApplication1.INST_PREXRIDataSet
      Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
      Me.colUG_CODUSU = New DevExpress.XtraGrid.Columns.GridColumn
      Me.colUG_CODGRU = New DevExpress.XtraGrid.Columns.GridColumn
      Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
      Me.XpCollectionGroup = New DevExpress.Xpo.XPCollection
      Me.USUGRUTableAdapter = New WindowsApplication1.INST_PREXRIDataSetTableAdapters.USUGRUTableAdapter
      Me.XpCollectionPerson = New DevExpress.Xpo.XPCollection
      CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.USUGRUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.INST_PREXRIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.XpCollectionGroup, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.XpCollectionPerson, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'GridControl1
      '
      Me.GridControl1.DataSource = Me.USUGRUBindingSource
      Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridControl1.EmbeddedNavigator.Name = ""
      Me.GridControl1.Location = New System.Drawing.Point(0, 0)
      Me.GridControl1.MainView = Me.GridView1
      Me.GridControl1.Name = "GridControl1"
      Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
      Me.GridControl1.Size = New System.Drawing.Size(518, 310)
      Me.GridControl1.TabIndex = 0
      Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
      '
      'USUGRUBindingSource
      '
      Me.USUGRUBindingSource.DataMember = "USUGRU"
      Me.USUGRUBindingSource.DataSource = Me.INST_PREXRIDataSet
      '
      'INST_PREXRIDataSet
      '
      Me.INST_PREXRIDataSet.DataSetName = "INST_PREXRIDataSet"
      Me.INST_PREXRIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'GridView1
      '
      Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUG_CODUSU, Me.colUG_CODGRU})
      Me.GridView1.GridControl = Me.GridControl1
      Me.GridView1.Name = "GridView1"
      '
      'colUG_CODUSU
      '
      Me.colUG_CODUSU.Caption = "UG_CODUSU"
      Me.colUG_CODUSU.FieldName = "UG_CODUSU"
      Me.colUG_CODUSU.Name = "colUG_CODUSU"
      Me.colUG_CODUSU.Visible = True
      Me.colUG_CODUSU.VisibleIndex = 0
      '
      'colUG_CODGRU
      '
      Me.colUG_CODGRU.Caption = "UG_CODGRU"
      Me.colUG_CODGRU.ColumnEdit = Me.RepositoryItemLookUpEdit1
      Me.colUG_CODGRU.FieldName = "UG_CODGRU"
      Me.colUG_CODGRU.Name = "colUG_CODGRU"
      Me.colUG_CODGRU.Visible = True
      Me.colUG_CODGRU.VisibleIndex = 1
      '
      'RepositoryItemLookUpEdit1
      '
      Me.RepositoryItemLookUpEdit1.AutoHeight = False
      Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
      Me.RepositoryItemLookUpEdit1.DataSource = Me.XpCollectionGroup
      Me.RepositoryItemLookUpEdit1.DisplayMember = "GroupName"
      Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
      Me.RepositoryItemLookUpEdit1.ValueMember = "Oid"
      '
      'XpCollectionGroup
      '
      Me.XpCollectionGroup.ObjectType = GetType(WindowsApplication1.Form1.PersonGroup)
      '
      'USUGRUTableAdapter
      '
      Me.USUGRUTableAdapter.ClearBeforeFill = True
      '
      'XpCollectionPerson
      '
      Me.XpCollectionPerson.ObjectType = GetType(WindowsApplication1.Form1.Person)
      Me.XpCollectionPerson.DisplayableProperties = "Name;Group!Key"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(518, 310)
      Me.Controls.Add(Me.GridControl1)
      Me.Name = "Form1"
      Me.Text = "Form1"
      CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.USUGRUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.INST_PREXRIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.XpCollectionGroup, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.XpCollectionPerson, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
   Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
   Friend WithEvents INST_PREXRIDataSet As WindowsApplication1.INST_PREXRIDataSet
   Friend WithEvents USUGRUBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents USUGRUTableAdapter As WindowsApplication1.INST_PREXRIDataSetTableAdapters.USUGRUTableAdapter
   Friend WithEvents colUG_CODUSU As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents colUG_CODGRU As DevExpress.XtraGrid.Columns.GridColumn
   Friend WithEvents XpCollectionPerson As DevExpress.Xpo.XPCollection
   Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
   Friend WithEvents XpCollectionGroup As DevExpress.Xpo.XPCollection

End Class
