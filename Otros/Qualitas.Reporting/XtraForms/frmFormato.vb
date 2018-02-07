Public Class frmFormato 

    Private MODO As String
    Private COLKEY As String
    Private dsAux As DataSet

    Public Sub PasarDataset(ByVal oDataset As DataSet, ByVal sColKey As String)

        dsAux = oDataset
        COLKEY = sColKey

        If sColKey <> "" Then
            MODO = "M"
        Else
            MODO = "A"
        End If

        If MODO = "M" Then
            CargarRegistro()
        End If

    End Sub

    Private Sub CargarRegistro()

        Dim oRow As DataRow

        txtNombreColumna.Text = COLKEY

        For Each oRow In dsAux.Tables("FORMAT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CF_COLKEY") = COLKEY Then

                    txtFormato.Text = oRow.Item("CF_FORMAT")

                    Select Case oRow.Item("CF_TIPCOL")
                        Case 1 : cboTipoDatos.SelectedIndex = 0
                        Case 2 : cboTipoDatos.SelectedIndex = 1
                        Case Else : cboTipoDatos.SelectedIndex = 0
                    End Select

                    txtTitulo.Text = oRow.Item("CF_TITULO")
                    chkVisible.Checked = (oRow.Item("CF_VISIBL") = 1)

                    Exit For
                End If
            End If
        Next


    End Sub

    Public Sub IniciarOpciones()
        LocalizarFormulario()
        LlenarCombos()
    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionFormato)

        lblNombreColumna.Text = DescripcionCadena(Cadenas.CDN_frmFormato_NombreColumna)
        lblFormato.Text = DescripcionCadena(Cadenas.CDN_frmFormato_Formato)
        lblTipoDatos.Text = DescripcionCadena(Cadenas.CDN_frmFormato_TipoDatos)

        lblTitulo.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloRealColumna)
        chkVisible.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colVisibleEnGrillas)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub LlenarCombos()

        With cboTipoDatos.Properties.Items

            .Clear()
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoDatosNumerico))
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoDatosFecha))
        
            cboTipoDatos.SelectedIndex = 0

        End With
    End Sub

    Private Function DatosOK() As Boolean

        If ColKeyExiste(txtNombreColumna.Text.Trim) Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmFormato_NombreColumnaExiste))
            txtNombreColumna.Focus()
            Exit Function
        End If

        If txtNombreColumna.Text.Trim = "" Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmFormato_NombreVacio))
            txtNombreColumna.Focus()
            Exit Function
        End If

        'If txtFormato.Text.Trim = "" Then
        'MensajeError(DescripcionCadena(Cadenas.CDN_frmFormato_FormatoVacio))
        'txtFormato.Focus()
        'Exit Function
        'End If

        DatosOK = True

    End Function

    Private Function ColKeyExiste(ByVal sColKey As String) As Boolean

        Dim oRow As DataRow

        For Each oRow In dsAux.Tables("FORMAT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CF_COLKEY") <> COLKEY Then
                    If oRow.Item("CF_COLKEY") = sColKey Then
                        ColKeyExiste = True
                        Exit Function
                    End If
                End If
            End If
        Next

    End Function

    Private Function FilaActual() As DataRow

        Dim oRow As DataRow

        For Each oRow In dsAux.Tables("FORMAT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CF_COLKEY") = COLKEY Then
                    Return oRow
                    Exit Function
                End If
            End If
        Next

    End Function

    Private Sub Actualizar()

        Dim oRow As DataRow

        Try

            With dsAux.Tables("FORMAT")

                If MODO = "A" Then
                    oRow = .NewRow()
                Else
                    oRow = FilaActual()
                    oRow.BeginEdit()
                End If

                oRow.Item("CF_COLKEY") = txtNombreColumna.Text.Trim
                oRow.Item("CF_FORMAT") = txtFormato.Text.Trim

                Select Case cboTipoDatos.SelectedIndex
                    Case 0 : oRow.Item("CF_TIPCOL") = 1
                    Case 1 : oRow.Item("CF_TIPCOL") = 2
                End Select

                oRow.Item("CF_TITULO") = txtTitulo.Text.Trim
                oRow.Item("CF_VISIBL") = IIf(chkVisible.Checked, 1, 0)

                oRow.Item("CF_VISTXT") = IIf(chkVisible.Checked, _
                         DescripcionCadena(Cadenas.CDN_GeneralSi), _
                         DescripcionCadena(Cadenas.CDN_GeneralNo))

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