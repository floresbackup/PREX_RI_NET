Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base

Public Class frmDrillDown

    Private isInitMenuHeader As Boolean
    Private itemColumna As DevExpress.Utils.Menu.DXMenuItem
    Private columnMenu As DevExpress.XtraGrid.Columns.GridColumn = Nothing
    Private Query As String

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
        Query = sSQL

        If System.IO.File.Exists(NombreArchivoLatout) Then
            GridView1.RestoreLayoutFromXml(NombreArchivoLatout)
            cmdResetLaoyut.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        End If


    End Sub

    'Private Sub advBandedGridView1_MouseDown(sender As Object, e As MouseEventArgs)
    '    Dim hitInfo = advBandedGridView1.CalcHitInfo(e.Location)
    '    If hitInfo.InRow Then
    '        If hitInfo.RowHandle < 0 Then
    '            MessageBox.Show("GroupRow click")
    '            'your code
    '        End If
    '    End If
    'End Sub

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
        cmdResetLaoyut.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        For Each item As DevExpress.Utils.Menu.DXMenuItem In e.Menu.Items
            item.Visible = True
        Next
        If e.HitInfo.InColumnPanel Then
            columnMenu = e.HitInfo.Column
            InicializarMenuTotalizadores(e.Menu)
            e.Allow = True
        ElseIf e.HitInfo.InGroupColumn Then
            columnMenu = e.HitInfo.Column
            e.Allow = True

            For Each item As DevExpress.Utils.Menu.DXMenuItem In e.Menu.Items

                If item.Caption = "agrupas" Then

                End If
            Next

        Else
                e.Allow = False
            columnMenu = Nothing
        End If
    End Sub

    Private Sub InicializarMenuTotalizadores(menuGrilla As GridViewMenu)

        itemColumna = New DevExpress.Utils.Menu.DXMenuItem("Totalizar: " & columnMenu.Caption)
        itemColumna.Appearance.BackColor = SystemColors.ActiveBorder
        itemColumna.BeginGroup = True
        menuGrilla.Items.Add(itemColumna)

        For Each item As ToolStripItem In popMnuTotalizador.Items
            Dim i As New DevExpress.Utils.Menu.DXMenuItem(item.Text)
            i.Tag = item.Tag
            If menuGrilla.Items.Count() = 0 Then
                i.BeginGroup = True
            Else
                AddHandler i.Click, AddressOf mnuRecuento_Click
            End If
            menuGrilla.Items.Add(i)
        Next
        isInitMenuHeader = True
    End Sub

    Private Sub mnuRecuento_Click(sender As Object, e As EventArgs)
        'Dim summary As DevExpress.XtraGrid.GridGroupSummaryItem = Me.GridView1.GroupSummary.Add()
        'summary.SummaryType = CType(sender, DevExpress.Utils.Menu.DXMenuItem).Tag
        'summary.FieldName = columnMenu.FieldName
        'summary.ShowInGroupColumnFooter = columnMenu
        columnMenu.Summary.Clear()
        Dim summaryItem As DevExpress.XtraGrid.GridColumnSummaryItem = columnMenu.Summary.Add(CType(sender, DevExpress.Utils.Menu.DXMenuItem).Tag)
        summaryItem.DisplayFormat = CType(sender, DevExpress.Utils.Menu.DXMenuItem).Caption.Replace("&", String.Empty) & " = {0}"
        GridView1.Appearance.FooterPanel.BackColor = SystemColors.ActiveBorder
    End Sub
    'Private Sub mnuMaximo_Click(sender As Object, e As EventArgs)
    '    Me.GridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Max, GridView1.FocusedColumn.FieldName, GridView1.FocusedColumn)
    'End Sub
    'Private Sub mnuMinimo_Click(sender As Object, e As EventArgs)
    '    Me.GridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Min, GridView1.FocusedColumn.FieldName, GridView1.FocusedColumn)
    'End Sub
    'Private Sub mnuPromedio_Click(sender As Object, e As EventArgs)
    '    Me.GridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Average, GridView1.FocusedColumn.FieldName, GridView1.FocusedColumn)
    'End Sub
    'Private Sub mnuSuma_Click(sender As Object, e As EventArgs)
    '    Me.GridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, GridView1.FocusedColumn.FieldName, GridView1.FocusedColumn)
    'End Sub

    Private Sub frmDrillDown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitMenuHeader = False
    End Sub

    Private Sub cmdResetLaoyut_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdResetLaoyut.ItemClick
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.SuspendLayout()
            If System.IO.File.Exists(NombreArchivoLatout) Then
                System.IO.File.Delete(NombreArchivoLatout)
            End If
            PasarDatos(Query)
        Finally
            Me.ResumeLayout()
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class