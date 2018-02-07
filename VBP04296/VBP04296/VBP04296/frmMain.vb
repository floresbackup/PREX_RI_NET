Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Imports ActiproSoftware.SyntaxEditor
Imports ActiproSoftware.SyntaxEditor.Commands
Imports ActiproSoftware.SyntaxEditor.Addons.Dynamic
Imports ActiproSoftware.Win32
Imports ActiproSoftware.WinUICore

Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmMain

   Private Structure Item
      Dim Valor As Long
      Dim Nombre As String

      Public Sub New(ByVal _Valor As Long, ByVal _Nombre As String)
         Valor = _Valor
         Nombre = _Nombre
      End Sub

      Public Overrides Function ToString() As String
         Return Me.Nombre
      End Function

   End Structure

   Private Sub btnSalir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
      Application.Exit()
   End Sub

   Private Sub btnQueryPrevio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryPrevio.Click
      QueryPresentar(sender)
   End Sub

   Private Sub btnQueryGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryGrid.Click
      QueryPresentar(sender)
   End Sub

   Private Sub btnQueryPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryPost.Click
      QueryPresentar(sender)
   End Sub

   Private Sub QueryPresentar(ByVal oControl As System.Object)

      Dim oFont As System.Drawing.Font

      btnQueryPrevio.Font = btnQueryCampos.Font
      btnQueryGrid.Font = btnQueryCampos.Font
      btnQueryPost.Font = btnQueryCampos.Font

      oFont = New System.Drawing.Font(btnQueryCampos.Font, FontStyle.Bold)
      oControl.Font = oFont

   End Sub

   Private Sub CargaInicial(Optional ByVal nCODCON As Long = 0)


      Dim sSQL As String = "SELECT    * " & _
                           "FROM      TABGEN " & _
                           "WHERE     TG_CODTAB =  1 " & _
                           "ORDER BY  TG_CODCON "

      Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(sSQL, CONN_LOCAL)
      Dim dt As DataTable = New DataTable

      'Dim View As ColumnView = Grid.MainView
      'Dim Column As Columns.GridColumn

      da.Fill(dt)

      'View.Columns.Clear()

      For Each dr As DataRow In dt.Rows
         cboEntidad.Properties.Items.Add(New Item(Convert.ToInt64(dr("TG_CODCON").ToString), dr("TG_DESCRI").ToString))
      Next

   End Sub

   Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      LeerXML()
      CargaInicial()
   End Sub

End Class