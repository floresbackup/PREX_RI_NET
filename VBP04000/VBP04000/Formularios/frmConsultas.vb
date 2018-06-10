Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmConsultas



    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Devolver()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub


    Private Sub cmdFiltrar_Click(sender As Object, e As EventArgs) Handles cmdFiltrar.Click
        If Trim(txtNombre.Text) <> "" Then
            Cargar(txtNombre.Text.Trim)
        Else
            MensajeError("Proporcione parte del nombre de la consulta que busca")
            txtNombre.Select()
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        MostrarFiltro(TableLayoutPanel1.RowStyles.Item(0).Height = 70)
    End Sub

    Private Sub frmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cargar()
        MostrarFiltro(False)
    End Sub

    Private Sub MostrarFiltro(bMostrar As Boolean)
        If bMostrar Then
            TableLayoutPanel1.RowStyles.Item(0).Height = 100
        Else
            TableLayoutPanel1.RowStyles.Item(0).Height = 70
        End If
        txtNombre.Visible = bMostrar
        lblFiltro.Visible = bMostrar
        cmdFiltrar.Visible = bMostrar
    End Sub

    Private Sub Cargar(Optional ByVal sFiltroNombre As String = "")
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim sSql = String.Empty

                If sFiltroNombre <> "" Then

                    sSql = "SELECT       TG_DESCRI AS XX_CATEGO, CV_CODCON, CV_NOMBRE, CV_DESCRI " &
                   "FROM         CONVAR " &
                   "INNER JOIN   TABGEN  " &
                   "ON           CV_CATEGO = TG_CODCON " &
                   "LEFT JOIN    CONSEG " &
                   "ON           CS_CODCON = CV_CODCON " &
                   "AND          CS_CODUSU = " & UsuarioActual.Codigo & " " &
                   "WHERE        CS_CODUSU IS NULL " &
                   "AND          TG_CODTAB = " & TablasGenerales.TGL_CATEGORIAS_CONVAR & " " &
                   "AND          CV_NOMBRE LIKE '%" & sFiltroNombre & "%' " &
                   "ORDER        BY TG_DESCRI, CV_NOMBRE"

                Else

                    sSql = "SELECT       TG_DESCRI AS XX_CATEGO, CV_CODCON, CV_NOMBRE, CV_DESCRI " &
                   "FROM         CONVAR " &
                   "INNER JOIN   TABGEN  " &
                   "ON           CV_CATEGO = TG_CODCON " &
                   "LEFT JOIN    CONSEG " &
                   "ON           CS_CODCON = CV_CODCON " &
                   "AND          CS_CODUSU = " & UsuarioActual.Codigo & " " &
                   "WHERE        CS_CODUSU IS NULL " &
                   "AND          TG_CODTAB = " & TablasGenerales.TGL_CATEGORIAS_CONVAR & " " &
                   "ORDER        BY TG_DESCRI, CV_NOMBRE"

                End If


                Dim ad As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sSql, CONN_LOCAL)
                Dim dt As New DataTable
                ad.Fill(dt)

                Grid.DataSource = dt
                Grid.RefreshDataSource()
                Grid.Refresh()
                GridView1.Columns("XX_CATEGO").Group()



                If GridView1.RowCount > 0 Then
                    Grid.Select()
                ElseIf txtNombre.Visible Then
                    txtNombre.Select()
                End If
            Catch ex As Exception
                TratarError(ex, "Cargar")
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub Devolver()
        Dim nConsulta As Long
        If GridView1.RowCount > 0 Then
            If GridView1.SelectedRowsCount > 0 Then

                'If Not GridView1.GetSelectedRows() Then
                nConsulta = GridView1.GetDataRow(GridView1.GetSelectedRows().FirstOrDefault()).Item(1)

                CONSULTA_SELECCIONADA = nConsulta
                Me.Close()
                'End If
            End If
        End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim hitInfo As GridHitInfo = GridView1.CalcHitInfo(CType(e, MouseEventArgs).Location)
        If Not hitInfo.InGroupRow AndAlso GridView1.SelectedRowsCount > 0 Then
            Devolver()
        End If
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter AndAlso GridView1.SelectedRowsCount > 0 Then
            Devolver()
        End If
    End Sub

    Private Sub btnExpandirTodo_Click(sender As Object, e As EventArgs) Handles btnExpandirTodo.Click
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub btnContraerTodo_Click(sender As Object, e As EventArgs) Handles btnContraerTodo.Click
        GridView1.CollapseAllGroups()
    End Sub

End Class