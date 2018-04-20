Imports System.Data.OleDb
Imports DevExpress.Xpo

Public Class frmProceso

   Public Class cboTipo
      Inherits XPObject
      Public Sub New()
         Codigo = Nothing
         Descripcion = ""
      End Sub
      Public Codigo As Object
      Public Descripcion As String
   End Class

   Private daDis As OleDbDataAdapter
   Private dsDis As DataSet
   Private cbDis As OleDbCommandBuilder

   Private daRel As OleDbDataAdapter
   Private dsRel As DataSet
   Private cbRel As OleDbCommandBuilder

   Private daTXT As OleDbDataAdapter
   Private dsTXT As DataSet
   Private cbTXT As OleDbCommandBuilder
   Private conn As OleDbConnection

   Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
      Me.Close()
   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      conn = New OleDbConnection(CONN_LOCAL)

        ' Especificaciones al control ActiveX de edición de código SQL
        'Todo:   comente esto
        With cmSQL

            .Language = "SQL"
            .SetColor(CodeMax.cmColorItem.cmClrLineNumber, RGB(180, 180, 180))
            .SetColor(CodeMax.cmColorItem.cmClrLineNumberBk, RGB(90, 90, 90))
            .SetFontStyle(CodeMax.cmFontStyleItem.cmStyLineNumber, CodeMax.cmFontStyle.cmFontBold)
            .LineNumbering = True
            .LineNumberStart = 1
            .LineNumberStyle = CodeMax.cmLineNumStyle.cmDecimal
            .ColorSyntax = True
            .NormalizeCase = True

        End With

        ' Drop Down Tipo de grilla de diseño
        Dim oItem As cboTipo
      Dim xpCollectionTipo As New XPCollection(GetType(cboTipo))
      xpCollectionTipo.DisplayableProperties = "This;Codigo;Descripcion"

      oItem = New cboTipo
      oItem.Codigo = "T"
      oItem.Descripcion = "Texto"
      xpCollectionTipo.Add(oItem)

      oItem = New cboTipo
      oItem.Codigo = "F"
      oItem.Descripcion = "Fecha"
      xpCollectionTipo.Add(oItem)

      oItem = New cboTipo
      oItem.Codigo = "N"
      oItem.Descripcion = "Número"
      xpCollectionTipo.Add(oItem)

      Dim oLookUp As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
      oLookUp.Name = "luTipo"
      oLookUp.DataSource = xpCollectionTipo
      oLookUp.DisplayMember = "Descripcion"
      oLookUp.ValueMember = "Codigo"
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo"))
      oLookUp.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"))
      oLookUp.Columns("Codigo").Visible = False
      oLookUp.ShowFooter = False
      oLookUp.ShowHeader = False
      gridDis.RepositoryItems.Add(oLookUp)

      CType(gridDis.MainView, DevExpress.XtraGrid.Views.Base.ColumnView).Columns("TD_TIPO").ColumnEdit = oLookUp

      oLookUp = Nothing

   End Sub

   Protected Overrides Sub Finalize()
      MyBase.Finalize()
   End Sub

   Private Sub Iniciar()

      Try
         conn.Open()

         daTXT = New OleDbDataAdapter("SELECT * FROM TXTNOM", conn)
         dsTXT = New DataSet()

         daTXT.Fill(dsTXT)

         gridTXT.DataSource = dsTXT.Tables(0)
         gridTXT.RefreshDataSource()

      Catch ex As Exception
         TratarError(ex, "Iniciar")
      End Try

   End Sub

   Private Sub actualizarGridTXT()

      Try

         cbTXT = New OleDbCommandBuilder(daTXT)
         daTXT.Update(dsTXT)

      Catch ex As Exception
         TratarError(ex, "actualizarGridTXT")
      End Try

   End Sub

   Private Sub frmProceso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      conn.Close()
   End Sub

   Private Sub frmProceso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Iniciar()
   End Sub

   Private Sub viewTXT_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles viewTXT.FocusedRowChanged
      RefreshDisRelPro()
   End Sub

   Private Sub viewTXT_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles viewTXT.RowUpdated
      actualizarGridTXT()
   End Sub

   Private Sub viewTXT_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewTXT.RowCountChanged
      actualizarGridTXT()
   End Sub

   Private Sub RefreshDisRelPro()

      Dim sCod As String = ""
      Dim sSQL As String = ""

      sCod = viewTXT.GetDataRow(viewTXT.FocusedRowHandle).Item("TN_CODIGO").ToString
      sSQL = viewTXT.GetDataRow(viewTXT.FocusedRowHandle).Item("TN_PROCES").ToString
      sSQL = sBase64Decode(sSQL)

      Try

         daDis = Nothing
         dsDis = Nothing
         cbDis = Nothing

         daDis = New OleDbDataAdapter("SELECT * FROM TXTDIS WHERE TD_CODIGO = " & sCod & " ORDER BY TD_ORDEN", conn)
         dsDis = New DataSet()

         daDis.Fill(dsDis)

         gridDis.DataSource = dsDis.Tables(0)
         gridDis.RefreshDataSource()

         daRel = Nothing
         dsRel = Nothing
         cbRel = Nothing

         daRel = New OleDbDataAdapter("SELECT * FROM TXTREL WHERE TR_CODIGO = " & sCod & " ORDER BY TR_CODIGO, TR_CUADRO, TR_ORDENTXT", conn)
         dsRel = New DataSet()

         daRel.Fill(dsRel)

         gridRel.DataSource = dsRel.Tables(0)
         gridRel.RefreshDataSource()

         cmSQL.Text = sSQL

      Catch ex As Exception
         TratarError(ex, "RefreshDisRelPro")
      End Try

   End Sub

   Private Sub actualizarGridDis()

      Try

         cbDis = New OleDbCommandBuilder(daDis)
         daDis.Update(dsDis)

      Catch ex As Exception
         TratarError(ex, "actualizarGridDis")
      End Try

   End Sub

   Private Sub viewDis_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles viewDis.RowUpdated
      actualizarGridDis()
   End Sub

   Private Sub viewDis_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewDis.RowCountChanged
      actualizarGridDis()
   End Sub

   Private Sub actualizarGridRel()

      Try

         cbRel = New OleDbCommandBuilder(daRel)
         daRel.Update(dsRel)

      Catch ex As Exception
         TratarError(ex, "actualizarGridRel")
      End Try

   End Sub

   Private Sub viewRel_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles viewRel.RowUpdated
      actualizarGridRel()
   End Sub

   Private Sub viewRel_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewRel.RowCountChanged
      actualizarGridRel()
   End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

      If gridTXT.MainView.RowCount > 0 Then
         Actualizar()
      End If
   End Sub

   Private Sub Actualizar()

      Dim ds As New DataSet
      Dim da As OleDbDataAdapter
      Dim cb As OleDbCommandBuilder
      Dim sSQL As String
      Dim sCod As String = ""

      Try

         sCod = viewTXT.GetDataRow(viewTXT.FocusedRowHandle).Item("TN_CODIGO").ToString

         Dim oAdmTablas As New AdmTablas
         oAdmTablas.ConnectionString = CONN_LOCAL

         sSQL = "UPDATE TXTNOM SET TN_PROCES='" & sBase64Encode(cmSQL.Text) & "' WHERE TN_CODIGO=" & sCod
         oAdmTablas.EjecutarComandoSQL(sSQL)

         'sSQL = "SELECT    * " & _
         '       "FROM      TXTNOM " & _
         '       "WHERE     TN_CODIGO = " & sCod

         'da = New OleDbDataAdapter(sSQL, CONN_LOCAL)
         'da.Fill(ds)
         'cb = New OleDbCommandBuilder(da)

         'With ds.Tables(0)
         'If .Rows.Count > 0 Then
         '.Rows(0).Item("TN_PROCES") = sBase64Encode(cmSQL.Text)
         'da.Update(ds)
         'End If
         'End With

         MensajeInformacion("Proceso Actualizado")

      Catch ex As Exception
         TratarError(ex, "Actualizar")
      End Try

      ds = Nothing
      da = Nothing
      cb = Nothing

   End Sub

End Class