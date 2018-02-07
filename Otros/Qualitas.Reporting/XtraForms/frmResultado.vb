Public Class frmResultado 

    Private MODO As String
    Private ORDEN As Integer
    Private dsAux As DataSet

    Public Sub PasarDataset(ByVal oDataset As DataSet, ByVal nOrden As Integer)

        dsAux = oDataset
        ORDEN = nOrden

        If ORDEN > 0 Then
            MODO = "M"
        Else
            MODO = "A"
        End If

        If MODO = "M" Then
            CargarRegistro()
        Else
            txtOrden.EditValue = ProximoIndice()
        End If

    End Sub

    Private Function ProximoIndice() As Integer

        Dim iRes As Integer
        Dim iTmp As Integer
        Dim oRow As DataRow

        iRes = 0

        For Each oRow In dsAux.Tables("RESULT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                iTmp = oRow.Item("CR_ORDEN")
                If iTmp > iRes Then
                    iRes = iTmp
                End If
            End If
        Next

        Return iRes + 1

    End Function

    Private Sub CargarRegistro()

        Dim oRow As DataRow

        txtOrden.EditValue = ORDEN

        For Each oRow In dsAux.Tables("RESULT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CR_ORDEN") = ORDEN Then
                    txtNombre.Text = oRow.Item("CR_NOMBRE")
                    Exit For
                End If
            End If
        Next


    End Sub

    Public Sub IniciarOpciones()
        LocalizarFormulario()
    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionResultado)

        lblOrden.Text = DescripcionCadena(Cadenas.CDN_frmResultado_Orden)
        lblNombre.Text = DescripcionCadena(Cadenas.CDN_frmResultado_Nombre)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Function DatosOK() As Boolean

        If OrdenExiste(txtOrden.EditValue) Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmResultado_OrdenExiste))
            txtOrden.Focus()
            Exit Function
        End If

        If txtNombre.Text.Trim = vbNullString Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmResultado_NombreVacio))
            txtNombre.Focus()
            Exit Function
        End If

        DatosOK = True

    End Function

    Private Function OrdenExiste(ByVal nOrden As Integer) As Boolean

        Dim oRow As DataRow

        For Each oRow In dsAux.Tables("RESULT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CR_ORDEN") <> ORDEN Then
                    If oRow.Item("CR_ORDEN") = nOrden Then
                        OrdenExiste = True
                        Exit Function
                    End If
                End If
            End If
        Next

    End Function

    Private Function FilaActual() As DataRow

        Dim oRow As DataRow

        For Each oRow In dsAux.Tables("RESULT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CR_ORDEN") = ORDEN Then
                    Return oRow
                    Exit Function
                End If
            End If
        Next

    End Function

    Private Sub Actualizar()

        Dim oRow As DataRow

        Try

            With dsAux.Tables("RESULT")

                If MODO = "A" Then
                    oRow = .NewRow()
                Else
                    oRow = FilaActual()
                    oRow.BeginEdit()
                End If

                oRow.Item("CR_ORDEN") = txtOrden.EditValue
                oRow.Item("CR_NOMBRE") = txtNombre.Text.Trim

                If MODO = "A" Then
                    .Rows.Add(oRow)
                Else
                    oRow.EndEdit()
                End If

                dsAux.AcceptChanges()

            End With

            Me.Close()

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DatosOK() Then
            Actualizar()
        End If
    End Sub


End Class