Imports DevExpress.XtraGrid.Views.Base

Public Class frmDrillDown
    Private ReadOnly Property NombreArchivoLatout
        Get
            Return IIf(CARPETA_LOCAL.EndsWith(System.IO.Path.DirectorySeparatorChar), CARPETA_LOCAL, CARPETA_LOCAL & IO.Path.DirectorySeparatorChar) & CODIGO_TRANSACCION & "_drilldown.xml"
        End Get
    End Property

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.ItemClick
        Grid.ShowPrintPreview()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.ItemClick
        frmExportar.PasarViewResultados(frmMain.Text, frmMain.lblTitulo.Text, GridView1)
        frmExportar.ShowDialog()
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.ItemClick
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
            'Column.OptionsColumn.FixedWidth = True

        Next

        'GridView1.RestoreLayoutFromXml("C:\Test.xml")

        Grid.DataSource = dt
        Grid.RefreshDataSource()
        Grid.Refresh()

        If System.IO.File.Exists(NombreArchivoLatout) Then
            GridView1.RestoreLayoutFromXml(NombreArchivoLatout)
        End If


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

    Private Sub cmdGuardarLaoyut_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGuardarLaoyut.ItemClick
        GridView1.SaveLayoutToXml(NombreArchivoLatout)
    End Sub



End Class