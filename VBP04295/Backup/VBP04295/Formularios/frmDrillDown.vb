Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports WebSupergoo
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Localization
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraPivotGrid.Localization
Imports DevExpress.XtraCharts.Localization
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraReports.Localization
Imports DevExpress.XtraEditors.Controls

Public Class frmDrillDown

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Grid.ShowPrintPreview()

    End Sub

   Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

      frmExportar.PasarViewResultados(frmMain.Text, frmMain.lblTitulo.Text, GridView1)
      frmExportar.ShowDialog()

   End Sub

   Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
      Me.Close()
   End Sub

   Public Sub PasarDatos(ByVal sSQL As String)

      Dim ad As OleDb.OleDbDataAdapter
      Dim dt As DataTable
      Dim View As ColumnView = Grid.MainView
      Dim Column As DevExpress.XtraGrid.Columns.GridColumn

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

        View.Columns.Clear()

      For Each oCol As DataColumn In dt.Columns

            Column = View.Columns.AddField(oCol.ColumnName)
         Column.Width = 100
         Column.VisibleIndex = oCol.Ordinal
         Column.Visible = True
         Column.Caption = oCol.Caption
            Column.OptionsColumn.FixedWidth = True

      Next

      Grid.DataSource = dt
      Grid.RefreshDataSource()
      Grid.Refresh()

    End Sub

    Private Sub GridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles GridView1.GridMenuItemClick


        ' In some cases the SummaryType is not null, but the SummaryItems is null
        ' For that reason we are validating that to prevent the crash
        If e.SummaryItem IsNot Nothing Then
            ' We need to set the handle as true. This should be the default value, Stupid Grid!
            e.Handled = True

            Select Case e.SummaryType
                Case DevExpress.Data.SummaryItemType.Sum
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "SUM={0}")
                Case DevExpress.Data.SummaryItemType.Average
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Average, "AVE={0}")
                Case DevExpress.Data.SummaryItemType.Count
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Count, "COUNT={0}")
                Case DevExpress.Data.SummaryItemType.Max
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Max, "MAX={0}")
                Case DevExpress.Data.SummaryItemType.Min
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Min, "MIN={0}")
                Case DevExpress.Data.SummaryItemType.None
                    e.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.None, "")
            End Select
        Else
            e.Handled = False

        End If
    End Sub
End Class