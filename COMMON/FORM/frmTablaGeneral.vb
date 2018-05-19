Imports System.Linq
Imports DevExpress.XtraGrid.Columns

Public Class frmTablaGeneral

    Private sSQLEjecutar As String
    Private sConnStringEjecutar As String
    Private nColumnaRetornar As Integer
    Private bMultiSeleccion As Boolean
    Private bCheck As Boolean

    Private oAdmTablas As New AdmTablas
    Private ds As DataSet
    Private vRetorno As String
    Private nTipoCon As Integer
    Private sSeleccionar As String

    Public Sub PasarInfo(ByVal sSQL As String,
                        ByVal sConnString As String,
                        Optional ByVal nColumnaRetorno As Integer = 1,
                        Optional ByVal bMultiSelect As Boolean = False,
                        Optional ByVal sTitulo As String = "Tabla general",
                        Optional ByVal sMarcar As String = "")


        sSQLEjecutar = sSQL
        sConnStringEjecutar = sConnString
        nColumnaRetornar = nColumnaRetorno
        bMultiSeleccion = bMultiSelect
        lblTitulo.Text = sTitulo
        sSeleccionar = sMarcar
        gvwResultados.OptionsSelection.MultiSelect = bMultiSeleccion
        btnInvertirSel.Visible = bMultiSelect
        btnSelectAll.Visible = bMultiSelect

        If bMultiSeleccion Then
            gvwResultados.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        End If
        Ejecutar()

    End Sub

    Private Sub Ejecutar()

        Try
            Dim ad As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sSQLEjecutar, sConnStringEjecutar)
            Dim dt As New DataTable

            ad.Fill(dt)

            GridResultados.DataSource = dt
            GridResultados.RefreshDataSource()
            GridResultados.Refresh()
            gvwResultados.BestFitColumns()

            If bMultiSeleccion Then

                For Each oCol As DevExpress.XtraGrid.Columns.GridColumn In gvwResultados.Columns
                    If oCol.FieldName.ToLower.Contains("cod") Then
                        oCol.Caption = "Código"
                    ElseIf oCol.FieldName.ToLower.Contains("desc") Then
                        oCol.Caption = "Descripción"
                    End If
                    If oCol.VisibleIndex > 0 Then
                        oCol.OptionsColumn.AllowEdit = False
                    Else
                        If oCol.ColumnType.FullName.ToUpper = "SYSTEM.BOOLEAN" Then
                            bCheck = True
                        End If
                    End If
                Next
            End If

            If (sSeleccionar <> String.Empty) Then

                Dim listado As List(Of String) = sSeleccionar.Split("|").ToList()
                For i As Integer = 0 To gvwResultados.DataRowCount - 1
                    If listado.Contains(gvwResultados.GetRowCellValue(i, gvwResultados.Columns.Item(0)).ToString) Then
                        gvwResultados.SelectRow(i)
                    End If
                Next
            End If

            cmdAceptar.Enabled = gvwResultados.RowCount > 0

        Catch ex As Exception
            TratarError(ex, "Ejecutar")
        End Try

    End Sub

    Private Sub GridResultados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If cmdAceptar.Enabled Then
            cmdAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub frmTablaGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        INPUT_GENERAL = ""
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim vValores() As VariantType
        Dim vValor As VariantType

        vRetorno = ""

        If bMultiSeleccion Then
            If bCheck Then
                Dim dt As New DataTable
                dt = GridResultados.DataSource

                For Each oRow As DataRow In dt.Rows
                    If oRow(0) Then
                        vRetorno = vRetorno.ToString & oRow(nColumnaRetornar - 1).ToString & ","
                    End If
                Next

            Else
                vValores = gvwResultados.GetSelectedRows

                For Each vValor In vValores
                    vRetorno = vRetorno.ToString & gvwResultados.GetDataRow(vValor).Item(nColumnaRetornar - 1).ToString & ","
                Next
            End If

            If vRetorno.Length > 0 Then
                vRetorno = vRetorno.Substring(0, vRetorno.Length - 1)
            Else
                Exit Sub
            End If

        Else
            vRetorno = gvwResultados.GetDataRow(gvwResultados.FocusedRowHandle).Item(nColumnaRetornar - 1)
        End If

        INPUT_GENERAL = vRetorno
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmTablaGeneral_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e IsNot Nothing Then
            If Me.DialogResult = DialogResult.Cancel Then
                INPUT_GENERAL = ""
            End If
        End If
    End Sub

    Private Sub btnInvertirSel_Click(sender As Object, e As EventArgs)
        Try
            SuspendLayout()
            Me.Cursor = Cursors.WaitCursor
            For rowHandle As Integer = 0 To gvwResultados.RowCount - 1
                gvwResultados.InvertRowSelection(rowHandle)
            Next
        Finally
            ResumeLayout()
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs)
        If gvwResultados.SelectedRowsCount = gvwResultados.RowCount Then
            gvwResultados.ClearSelection()
        Else
            gvwResultados.SelectAll()
        End If
    End Sub

End Class