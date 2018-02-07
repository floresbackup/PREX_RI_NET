Public Class frmTablaGeneral

    Private sSQLEjecutar As String
    Private sConnStringEjecutar As String
    Private nColumnaRetornar As Integer
    Private bMultiSeleccion As Boolean

    Private oAdmTablas As New AdmTablas
    Private ds As DataSet
    Private vRetorno As String
    Private nTipoCon As Integer

    Public Sub PasarInfo(ByVal sSQL As String, _
                         ByVal sConnString As String, _
                         ByVal nColumnaRetorno As Integer, _
                         ByVal bMultiSelect As Boolean, _
                         ByVal nTipoConexion As Integer)


        sSQLEjecutar = sSQL
        sConnStringEjecutar = sConnString
        nColumnaRetornar = nColumnaRetorno
        bMultiSeleccion = bMultiSelect
        nTipoCon = nTipoConexion

        gvwResultados.OptionsSelection.MultiSelect = bMultiSeleccion
        picTip.Visible = bMultiSeleccion
        lblTip.Visible = bMultiSeleccion

        Ejecutar()

    End Sub

    Private Sub Ejecutar()

        Try
            Cursor = Cursors.WaitCursor

            oAdmTablas.ConnectionString = sConnStringEjecutar

            If nTipoCon = 0 Then
                ds = oAdmTablas.AbrirDataset(sSQLEjecutar)
            ElseIf nTipoCon = 1 Then
                ds = oAdmTablas.AbrirDatasetNativo(sSQLEjecutar, False)
            ElseIf nTipoCon = 2 Then
                ds = oAdmTablas.AbrirDatasetOracleNativo(sSQLEjecutar)
            ElseIf nTipoCon = 3 Then
                ds = oAdmTablas.AbrirDatasetODBCNativo(sSQLEjecutar)
            Else
                ds = oAdmTablas.AbrirDataset(sSQLEjecutar)
            End If

            If ds Is Nothing Then
                GoTo ErrorConsulta
            End If

            GridResultados.DataSource = ds.Tables(0)
            gvwResultados.BestFitColumns()

            cmdAceptar.Enabled = ds.Tables(0).Rows.Count > 0

            Cursor = Cursors.Default

        Catch ex As Exception
            TratarError(ex)
        End Try

        Exit Sub

ErrorConsulta:

        Cursor = Cursors.Default
        cmdAceptar.Enabled = False

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim vValores() As VariantType
        Dim vValor As VariantType

        vRetorno = ""

        If bMultiSeleccion Then
            vValores = gvwResultados.GetSelectedRows

            For Each vValor In vValores
                vRetorno = vRetorno.ToString & gvwResultados.GetDataRow(vValor).Item(nColumnaRetornar - 1).ToString & ","
            Next

            If vRetorno.Length > 0 Then
                vRetorno = vRetorno.Substring(0, vRetorno.Length - 1)
            Else
                Exit Sub
            End If

        Else
            vRetorno = gvwResultados.GetDataRow(gvwResultados.FocusedRowHandle).Item(nColumnaRetornar - 1)
        End If

        RETORNO_CONSULTA_GENERAL = vRetorno
        Me.Close()

    End Sub

    Private Sub GridResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridResultados.Click

    End Sub

    Private Sub GridResultados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridResultados.DoubleClick
        If cmdAceptar.Enabled Then
            cmdAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub frmTablaGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RETORNO_CONSULTA_GENERAL = ""
        LocalizarFormulario()
    End Sub

    Private Sub LocalizarFormulario()
        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionTablaGeneral)
        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)
        lblTip.Text = DescripcionCadena(Cadenas.CDN_frmTablaGeneral_CTRLTip)
    End Sub

End Class