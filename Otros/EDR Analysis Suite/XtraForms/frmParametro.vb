Imports ActiproSoftware.SyntaxEditor

Public Class frmParametro

    Private MODO As String
    Private ORDEN As Integer
    Private CONEXION_ACTUAL As String
    Private TIPO_CONEXION As Integer
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

        For Each oRow In dsAux.Tables("PARAMS").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                iTmp = oRow.Item("CD_ORDEN")
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

        For Each oRow In dsAux.Tables("PARAMS").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CD_ORDEN") = ORDEN Then

                    txtNombre.Text = oRow.Item("CD_NOMPAR")

                    Select Case oRow.Item("CD_TIPDAT")
                        Case "N" : cboTipoDatos.SelectedIndex = 0
                        Case "F" : cboTipoDatos.SelectedIndex = 1
                        Case "T" : cboTipoDatos.SelectedIndex = 2
                        Case Else : cboTipoDatos.SelectedIndex = 0
                    End Select

                    cboTipoControl.SelectedIndex = oRow.Item("CD_TIPCON")
                    txtVariable.Text = oRow.Item("CD_VARIAB")
                    txtParteSQL.Text = oRow.Item("CD_PARSQL")
                    txtValorOmision.Text = oRow.Item("CD_DEFAUL")

                    chkMultiseleccion.Checked = oRow.Item("CD_INSQL") = 1
                    chkRequerido.Checked = oRow.Item("CD_REQUER") = 1

                    If oRow.Item("CD_VALIDA").ToString <> "" Then
                        chkValidacion.Checked = True
                        Select Case oRow.Item("CD_VALIDA")
                            Case "=" : cboValidacion.SelectedIndex = 0
                            Case "<>" : cboValidacion.SelectedIndex = 1
                            Case ">" : cboValidacion.SelectedIndex = 2
                            Case "<" : cboValidacion.SelectedIndex = 3
                            Case ">=" : cboValidacion.SelectedIndex = 4
                            Case "<=" : cboValidacion.SelectedIndex = 5
                            Case Else : cboValidacion.SelectedIndex = 6
                        End Select
                    Else
                        chkValidacion.Checked = False
                    End If

                    txtValor1.Text = oRow.Item("CD_VALOR1")
                    txtValor2.Text = oRow.Item("CD_VALOR2")

                    txtSQL.Text = oRow.Item("CD_SQLTBG")
                    txtIndiceColumna.EditValue = oRow.Item("CD_CAMRET")

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

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionParametro)

        tpGeneral.Text = DescripcionCadena(Cadenas.CDN_frmParametro_TabGeneral)
        tpCustomHelp.Text = DescripcionCadena(Cadenas.CDN_frmParametro_TabAyudaContextual)
        lblOrden.Text = DescripcionCadena(Cadenas.CDN_frmParametro_Orden)
        lblNombre.Text = DescripcionCadena(Cadenas.CDN_frmParametro_Nombre)
        lblTipoDatos.Text = DescripcionCadena(Cadenas.CDN_frmParametro_TipoDatos)
        lblTipoControl.Text = DescripcionCadena(Cadenas.CDN_frmParametro_TipoControl)
        lblVariable.Text = DescripcionCadena(Cadenas.CDN_frmParametro_Variable)
        lblParteSQL.Text = DescripcionCadena(Cadenas.CDN_frmParametro_InstruccionSQL)
        lblValorDefault.Text = DescripcionCadena(Cadenas.CDN_frmParametro_ValorDefault)
        chkMultiseleccion.Text = DescripcionCadena(Cadenas.CDN_frmParametro_PermitirMultifiltro)
        chkRequerido.Text = DescripcionCadena(Cadenas.CDN_frmParametro_Requerido)
        chkValidacion.Text = DescripcionCadena(Cadenas.CDN_frmParametro_Validacion)
        lblValor1.Text = DescripcionCadena(Cadenas.CDN_frmParametro_Valor1)
        lblValor2.Text = DescripcionCadena(Cadenas.CDN_frmParametro_Valor2)
        lblTipAyudaContextual.Text = DescripcionCadena(Cadenas.CDN_frmParametro_TipSQLHelp)
        lblIndiceColumna.Text = DescripcionCadena(Cadenas.CDN_frmParametro_IndiceColumna)

        cmdAsistenteSQL.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_BotonAsistenteSQL)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub LlenarCombos()

        With cboTipoDatos.Properties.Items

            .Clear()
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoDatosNumerico))
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoDatosFecha))
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoDatosTexto))

            cboTipoDatos.SelectedIndex = 0

        End With

        With cboTipoControl.Properties.Items

            .Clear()
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlTextEdit)) '0
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlButtonEdit)) '1
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlDateEdit)) '2
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlSpinEdit)) '3
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlCheckEdit)) '4
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlMemoEdit)) '5
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlTimeEdit)) '6
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlTrackBar)) '7
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlZoomTrackBar)) '8
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_TipoControlCalcEdit)) '9

            cboTipoControl.SelectedIndex = 0

        End With

        With cboValidacion.Properties.Items

            .Clear()
            .Add("=")
            .Add("<>")
            .Add(">")
            .Add("<")
            .Add(">=")
            .Add("<=")
            .Add(DescripcionCadena(Cadenas.CDN_frmParametro_ValidacionEntre))

            cboValidacion.SelectedIndex = 0

        End With

    End Sub


    Private Sub chkValidacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkValidacion.CheckedChanged

        cboValidacion.Enabled = chkValidacion.Checked
        txtValor1.Enabled = chkValidacion.Checked
        txtValor2.Enabled = chkValidacion.Checked And cboValidacion.SelectedIndex = cboValidacion.Properties.Items.Count - 1
        lblValor1.Enabled = txtValor1.Enabled
        lblValor2.Enabled = txtValor2.Enabled

        If chkValidacion.Checked Then
            cboValidacion.Focus()
        End If

    End Sub

    Private Sub cboValidacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboValidacion.SelectedIndexChanged
        txtValor2.Enabled = cboValidacion.SelectedIndex = cboValidacion.Properties.Items.Count - 1
        lblValor2.Enabled = txtValor2.Enabled
    End Sub

    Private Function DatosOK() As Boolean

        If OrdenExiste(txtOrden.EditValue) Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmParametro_DatosOK_OrdenExiste))
            txtOrden.Focus()
            Exit Function
        End If

        If txtNombre.Text.Trim = vbNullString Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmParametro_DatosOK_NombreVacio))
            txtNombre.Focus()
            Exit Function
        End If

        If txtVariable.Text.Trim = vbNullString Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmParametro_DatosOK_VariableVacia))
            txtVariable.Focus()
            Exit Function
        End If

        If txtParteSQL.Text.Trim = vbNullString Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmParametro_DatosOK_ParteSQLVacia))
            txtParteSQL.Focus()
            Exit Function
        End If

        If chkValidacion.Checked Then
            If txtValor1.Text.Trim = vbNullString Then
                Tabs.SelectedTabPage = tpGeneral
                MensajeError(DescripcionCadena(Cadenas.CDN_frmParametro_DatosOK_Valor1Vacio))
                txtValor1.Focus()
                Exit Function
            End If
        End If

        If chkValidacion.Checked Then
            If cboValidacion.SelectedIndex = cboValidacion.Properties.Items.Count - 1 Then
                If txtValor2.Text.Trim = vbNullString Then
                    Tabs.SelectedTabPage = tpGeneral
                    MensajeError(DescripcionCadena(Cadenas.CDN_frmParametro_DatosOK_Valor2Vacio))
                    txtValor2.Focus()
                    Exit Function
                End If
            End If
        End If

        If cboTipoControl.SelectedIndex = 1 Then
            If txtSQL.Text.Trim = vbNullString Then
                Tabs.SelectedTabPage = tpCustomHelp
                MensajeError(DescripcionCadena(Cadenas.CDN_frmParametro_DatosOK_HelpSQLVacio))
                txtSQL.Focus()
                Exit Function
            End If
        End If

        DatosOK = True

    End Function

    Private Function OrdenExiste(ByVal nOrden As Integer) As Boolean

        Dim oRow As DataRow

        For Each oRow In dsAux.Tables("PARAMS").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CD_ORDEN") <> ORDEN Then
                    If oRow.Item("CD_ORDEN") = nOrden Then
                        OrdenExiste = True
                        Exit Function
                    End If
                End If
            End If
        Next

    End Function

    Private Function FilaActual() As DataRow

        Dim oRow As DataRow

        For Each oRow In dsAux.Tables("PARAMS").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CD_ORDEN") = ORDEN Then
                    Return oRow
                    Exit Function
                End If
            End If
        Next

    End Function

    Private Sub Actualizar()

        Dim oRow As DataRow

        Try

            With dsAux.Tables("PARAMS")

                If MODO = "A" Then
                    oRow = .NewRow()
                Else
                    oRow = FilaActual()
                    oRow.BeginEdit()
                End If

                oRow.Item("CD_ORDEN") = txtOrden.EditValue
                oRow.Item("CD_NOMPAR") = txtNombre.Text.Trim
                oRow.Item("CD_TIPCON") = cboTipoControl.SelectedIndex

                Select Case cboTipoDatos.SelectedIndex
                    Case 0 : oRow.Item("CD_TIPDAT") = "N"
                    Case 1 : oRow.Item("CD_TIPDAT") = "F"
                    Case 2 : oRow.Item("CD_TIPDAT") = "T"
                End Select

                oRow.Item("CD_VARIAB") = txtVariable.Text.Trim
                oRow.Item("CD_PARSQL") = txtParteSQL.Text.Trim
                oRow.Item("CD_INSQL") = IIf(chkMultiseleccion.Checked, 1, 0)
                oRow.Item("CD_HELP") = 0
                oRow.Item("CD_REQUER") = IIf(chkRequerido.Checked, 1, 0)
                oRow.Item("CD_SQLTBG") = txtSQL.Text.Trim
                oRow.Item("CD_CAMRET") = txtIndiceColumna.EditValue
                oRow.Item("CD_DEFAUL") = txtValorOmision.Text.Trim

                If chkValidacion.Checked Then
                    If cboValidacion.SelectedIndex = cboValidacion.Properties.Items.Count - 1 Then
                        oRow.Item("CD_VALIDA") = "ENTRE"
                    Else
                        oRow.Item("CD_VALIDA") = cboValidacion.EditValue
                    End If
                Else
                    oRow.Item("CD_VALIDA") = ""
                End If

                oRow.Item("CD_VALOR1") = txtValor1.Text.Trim
                oRow.Item("CD_VALOR2") = txtValor2.Text.Trim

                oRow.Item("CD_REQTXT") = IIf(chkRequerido.Checked, _
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

    Private Sub txtSQL_TriggerActivated(ByVal sender As Object, ByVal e As ActiproSoftware.SyntaxEditor.TriggerEventArgs) Handles txtSQL.TriggerActivated
        If txtSQL.IntelliPrompt.MemberList.Count > 0 Then
            txtSQL.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Public Sub New(ByVal sConexionActual As String, ByVal nTipoConexion As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CONEXION_ACTUAL = sConexionActual
        TIPO_CONEXION = nTipoConexion

    End Sub

    Private Sub cmdAsistenteSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsistenteSQL.Click
        Dim fWiz As New frmSQLWizard(CONEXION_ACTUAL, TIPO_CONEXION, False)

        fWiz.ShowDialog()

        If SQL_ASISTENTE <> "" Then
            txtSQL.Text = SQL_ASISTENTE
        End If
    End Sub
End Class