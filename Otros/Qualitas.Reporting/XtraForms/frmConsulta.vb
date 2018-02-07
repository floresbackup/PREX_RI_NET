Imports DevExpress.XtraEditors

Public Class frmConsulta

    Private oAdmTablas As New AdmTablas
    Private curDs As System.Data.DataSet
    Private curIndex As Integer
    Private WithEvents oHelpButton As New Repository.RepositoryItemButtonEdit
    Private WithEvents oResultButton As New DevExpress.XtraBars.BarButtonItem
    Private WithEvents oDateButton As New Repository.RepositoryItemButtonEdit
    Private curRow As DevExpress.XtraVerticalGrid.Rows.BaseRow
    
    Public oConsultaAbierta As Consulta

    Private bFieldChooseVisible As Boolean
    Private bFieldChooseCuboVisible As Boolean

    Public Sub AbrirConsulta(ByVal nCodigo As Integer)

        Dim nI As Integer
        Dim oRow As DevExpress.XtraVerticalGrid.Rows.BaseRow
        Dim oItem As DevExpress.XtraEditors.Repository.RepositoryItem
        Dim oButton As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Dim oFecha As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Dim oTrackBar As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
        Dim oZoomTrackBar As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar

        Try

            oConsultaAbierta = AbrirConsultaGlobal(nCodigo)

            Me.Text = oConsultaAbierta.Nombre
            lblNombre.Text = oConsultaAbierta.Nombre
            lblConexion.Text = oConsultaAbierta.NombreConexion
            lblDescripcion.Text = oConsultaAbierta.Descripcion

            ' Opciones de la grilla
            GridResultados.ServerMode = oConsultaAbierta.ModoServidor

            ' Armado de parametros
            If oConsultaAbierta.Detalles.Length > 0 Then

                'GridParametros.Rows.Clear()

                For nI = 0 To oConsultaAbierta.Detalles.Length - 1

                    oRow = New DevExpress.XtraVerticalGrid.Rows.EditorRow

                    Select Case oConsultaAbierta.Detalles(nI).TipoControl
                        Case 0
                            oItem = New Repository.RepositoryItemTextEdit
                        Case 1
                            oItem = New Repository.RepositoryItemButtonEdit
                            oButton = oItem
                            AddHandler oButton.ButtonClick, AddressOf oHelpButton_ButtonClick
                        Case 2
                            oItem = New Repository.RepositoryItemDateEdit
                            oItem.EditFormat.FormatString = FORMATO_FECHAS
                            oItem.DisplayFormat.FormatString = FORMATO_FECHAS

                            oFecha = oItem
                            AddHandler oFecha.FormatEditValue, AddressOf oDateButton_FormatEditValue

                            oFecha.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
                            oFecha.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
                            oFecha.ShowPopupShadow = True
                            oFecha.ShowToday = True

                            oRow.Properties.Format.FormatString = FORMATO_FECHAS

                        Case 3
                            oItem = New Repository.RepositoryItemSpinEdit
                        Case 4
                            oItem = New Repository.RepositoryItemCheckEdit
                        Case 5
                            oItem = New Repository.RepositoryItemMemoEdit
                        Case 6
                            oItem = New Repository.RepositoryItemTimeEdit
                        Case 7
                            oItem = New Repository.RepositoryItemTrackBar

                            If IsNumeric(Val(oConsultaAbierta.Detalles(nI).ValidacionValor1)) And _
                               IsNumeric(Val(oConsultaAbierta.Detalles(nI).ValidacionValor2)) Then
                                oTrackBar = oItem
                                oTrackBar.Minimum = Val(oConsultaAbierta.Detalles(nI).ValidacionValor1)
                                oTrackBar.Maximum = Val(oConsultaAbierta.Detalles(nI).ValidacionValor2)
                            End If

                        Case 8
                            oItem = New Repository.RepositoryItemZoomTrackBar

                            If IsNumeric(Val(oConsultaAbierta.Detalles(nI).ValidacionValor1)) And _
                               IsNumeric(Val(oConsultaAbierta.Detalles(nI).ValidacionValor2)) Then
                                oZoomTrackBar = oItem
                                oZoomTrackBar.Minimum = Val(oConsultaAbierta.Detalles(nI).ValidacionValor1)
                                oZoomTrackBar.Maximum = Val(oConsultaAbierta.Detalles(nI).ValidacionValor2)
                            End If

                        Case 9
                            oItem = New Repository.RepositoryItemCalcEdit
                        Case Else
                            oItem = New Repository.RepositoryItemTextEdit
                    End Select

                    oItem.Name = "gridParam" & nI

                    oRow.Properties.RowEdit = oItem
                    oRow.Properties.Caption = oConsultaAbierta.Detalles(nI).Nombre & IIf(oConsultaAbierta.Detalles(nI).Requerido, " (*)", "")

                    If oConsultaAbierta.Detalles(nI).ValorDefault.Trim <> vbNullString Then
                        oRow.Properties.Value = ReemplazarVariables(oConsultaAbierta.Detalles(nI).ValorDefault.Trim)
                    End If

                    oRow.Height = 25
                    oRow.Tag = nI

                    GridParametros.Rows.Add(oRow)

                Next

                If oConsultaAbierta.Protegida Then

                    FinProcesando()

                    Dim fPassword As New frmPassword

                    fPassword.IniciarOpciones()
                    fPassword.PasarPassword(cEncrypt.DecryptString128Bit(oConsultaAbierta.Password))
                    fPassword.ShowDialog()

                    If Not PASSWORD_OK Then
                        Me.Tag = "InvalidPassword"
                    End If

                End If

            End If

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub tpReporte_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpReporte.Resize
        On Error Resume Next
        With pc001
            .Width = tpReporte.Width - .Left * 2
            .Height = tpReporte.Height - .Top - 10
        End With
    End Sub

    Private Sub tpResultados_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpResultados.Resize
        On Error Resume Next
        With GridResultados
            .Width = tpResultados.Width
            .Height = tpResultados.Height - rbcMain.Height
        End With
    End Sub

    Private Sub tpCubo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpCubo.Resize
        On Error Resume Next
        With oSplitter
            .Width = tpCubo.Width
            .Height = tpCubo.Height - rbcCubo.Height
        End With
    End Sub

    Private Sub frmConsulta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Static bFlag As Boolean

        If Not bFlag Then
            GridParametros.Focus()
            bFlag = True
        End If

    End Sub

    Private Sub frmConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        GuardarLayouts()

    End Sub

    Private Sub GuardarLayouts()

        On Error Resume Next

        Call GuardarLayoutGrid(True)
        Call GuardarLayoutCube(True)

    End Sub

    Private Sub frmConsulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        IniciarOpciones()

    End Sub

    Private Sub rbcMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbcMain.SizeChanged
        tpResultados_Resize(sender, e)
    End Sub

    Private Sub rbcCubo_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbcCubo.SizeChanged
        tpCubo_Resize(sender, e)
    End Sub

    Private Sub IniciarOpciones()

        LocalizarFormulario()
        rbcMain.Minimized = (COLLAPSE_RIBBON = 1)
        rbcCubo.Minimized = (COLLAPSE_RIBBON = 1)

        If COLLAPSE_RIBBON Then
            rbcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below
            rbcCubo.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below
        Else
            rbcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            rbcCubo.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        End If

        HabilitarToolbarResultados(False)
        HabilitarToolbarCubo(False)
        HabilitarToolbarReportes(False)
        CrearSuperTips(rbcMain)
        CrearSuperTips(rbcCubo)

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub PostEjecucion(Optional ByVal sSubTitulo As String = "")

        Dim oTitle As New DevExpress.XtraCharts.ChartTitle
        Dim oSubTitle As New DevExpress.XtraCharts.ChartTitle
        Dim oCol As DevExpress.XtraGrid.Columns.GridColumn

        gvwResultados.BestFitColumns()

        If MULTIFILTER_COLUMNS Then
            For Each oCol In gvwResultados.Columns
                oCol.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Next
        Else
            For Each oCol In gvwResultados.Columns
                oCol.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List
            Next
        End If

        pgCubo.Fields.Clear()
        pgCubo.DataSource = curDs.Tables(curIndex)

        pgCubo.RetrieveFields()

        chrGrafico.DataSource = pgCubo
        chrGrafico.SeriesDataMember = "Series"
        chrGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
        chrGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})

        chrGrafico.Titles.Clear()

        oTitle.Text = oConsultaAbierta.Nombre
        oTitle.Antialiasing = True

        If oConsultaAbierta.Resultados.Length > curIndex Then
            oSubTitle.Text = oConsultaAbierta.Resultados(curIndex).Nombre
        Else
            oSubTitle.Text = sSubTitulo
        End If

        oSubTitle.Antialiasing = True

        chrGrafico.Titles.Add(oTitle)
        chrGrafico.Titles.Add(oSubTitle)

        HabilitarToolbarResultados(curDs.Tables(curIndex).Rows.Count > 0)
        HabilitarToolbarCubo(curDs.Tables(curIndex).Rows.Count > 0)
        HabilitarToolbarReportes(curDs.Tables(curIndex).Rows.Count > 0)

        RestoreLayout()
        RestoreLayoutCubo()
        CheckFields()

        AplicarFormatos()

        If curDs.Tables(curIndex).Rows.Count > 0 Then
            CargarReportesConsulta()
        End If

    End Sub

    Private Sub AgregarOtrosResultados()

        Dim nI As Integer
        Dim nJ As Integer
        Dim oButton As DevExpress.XtraBars.BarButtonItem
        Dim sText As String
        Dim sNombreBoton As String

        If oConsultaAbierta.Resultados.Length >= 1 Then
            If oConsultaAbierta.Resultados(0).Orden = 1 Then
                sText = oConsultaAbierta.Resultados(0).Nombre
            Else
                sText = Format(1, "000")
            End If
        Else
            sText = Format(1, "000")
        End If

        curDs.DataSetName = oConsultaAbierta.Nombre

        btnResults000.Caption = sText
        popConjuntos.Caption = sText

        For nI = 0 To curDs.Tables.Count - 1

            If oConsultaAbierta.Resultados.Length > nI Then
                If oConsultaAbierta.Resultados(nI).Orden = nI + 1 Then
                    sText = oConsultaAbierta.Resultados(nI).Nombre
                Else

                    sText = Format(nI + 1, "000")

                    For nJ = 0 To oConsultaAbierta.Resultados.Length - 1
                        If oConsultaAbierta.Resultados(nJ).Orden = nI + 1 Then
                            sText = oConsultaAbierta.Resultados(nJ).Nombre
                            Exit For
                        End If
                    Next

                End If
            Else
                sText = Format(nI + 1, "000")
            End If


            sNombreBoton = "btnResults" & Format(nI, "000")
            curDs.Tables(nI).TableName = sText

            If Not BotonExiste(sNombreBoton) Then

                oButton = New DevExpress.XtraBars.BarButtonItem
                oButton.Name = sNombreBoton
                oButton.Caption = sText

                AddHandler oButton.ItemClick, AddressOf oResultButton_ItemClick

                popConjuntos.AddItem(oButton)

            End If

        Next

    End Sub

    Private Sub AlterarNombresDataset()

        Dim nI As Integer
        Dim oCol As DataColumn

        For nI = 0 To oConsultaAbierta.Formatos.Length - 1
            If oConsultaAbierta.Formatos(nI).Titulo.Trim <> "" Then
                If ColumnaExiste(oConsultaAbierta.Formatos(nI).ColumnaKey) Then

                    If curDs.Tables(curIndex).Columns.Contains(oConsultaAbierta.Formatos(nI).ColumnaKey) Then
                        oCol = curDs.Tables(curIndex).Columns(oConsultaAbierta.Formatos(nI).ColumnaKey)
                        oCol.Caption = oConsultaAbierta.Formatos(nI).Titulo.Trim
                    End If

                End If
            End If
        Next

    End Sub

    Private Sub AplicarFormatos()

        Dim nI As Integer
        Dim oCol As DevExpress.XtraGrid.Columns.GridColumn
        Dim oField As DevExpress.XtraPivotGrid.PivotGridField

        For nI = 0 To oConsultaAbierta.Formatos.Length - 1

            If ColumnaExiste(oConsultaAbierta.Formatos(nI).ColumnaKey) Then

                oCol = gvwResultados.Columns(oConsultaAbierta.Formatos(nI).ColumnaKey)

                If oConsultaAbierta.Formatos(nI).TipoColumna = 1 Then ' numerico
                    oCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    oCol.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                ElseIf oConsultaAbierta.Formatos(nI).TipoColumna = 2 Then ' Fechas
                    oCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    oCol.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                End If

                oCol.DisplayFormat.FormatString = oConsultaAbierta.Formatos(nI).Formato
                oCol.GroupFormat.FormatString = oConsultaAbierta.Formatos(nI).Formato

                oCol.SummaryItem.DisplayFormat() = "{0:" & oConsultaAbierta.Formatos(nI).Formato & "}"
                oCol.SummaryItem.Tag = 1

                If oConsultaAbierta.Formatos(nI).Titulo.Trim <> "" Then
                    oCol.Caption = oConsultaAbierta.Formatos(nI).Titulo.Trim
                    'oCol.FieldName = oConsultaAbierta.Formatos(nI).Titulo.Trim
                End If

                If oConsultaAbierta.Formatos(nI).Visible = 0 Then
                    oCol.Visible = False
                    oCol.Dispose()
                End If

            End If


        Next

        For nI = 0 To oConsultaAbierta.Formatos.Length - 1

            If ColumnaCuboExiste(oConsultaAbierta.Formatos(nI).ColumnaKey) Then

                oField = pgCubo.Fields(oConsultaAbierta.Formatos(nI).ColumnaKey)

                If oConsultaAbierta.Formatos(nI).TipoColumna = 1 Then ' numerico
                    oField.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    oField.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    oField.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    oField.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                ElseIf oConsultaAbierta.Formatos(nI).TipoColumna = 2 Then ' Fechas
                    oField.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    oField.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    oField.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    oField.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                End If

                oField.TotalValueFormat.FormatString = oConsultaAbierta.Formatos(nI).Formato
                oField.TotalCellFormat.FormatString = oConsultaAbierta.Formatos(nI).Formato
                oField.GrandTotalCellFormat.FormatString = oConsultaAbierta.Formatos(nI).Formato
                oField.CellFormat.FormatString = oConsultaAbierta.Formatos(nI).Formato

                If oConsultaAbierta.Formatos(nI).Titulo.Trim <> "" Then
                    oField.Caption = oConsultaAbierta.Formatos(nI).Titulo.Trim
                    'oCol.FieldName = oConsultaAbierta.Formatos(nI).Titulo.Trim
                End If

                If oConsultaAbierta.Formatos(nI).Visible = 0 Then
                    oField.Visible = False
                    oField.Dispose()
                End If

            End If

        Next

    End Sub

    Private Function ColumnaExiste(ByVal sNombre As String) As Boolean

        Dim oCol As DevExpress.XtraGrid.Columns.GridColumn

        For Each oCol In gvwResultados.Columns
            If oCol.FieldName = sNombre Then
                ColumnaExiste = True
                Exit Function
            End If
        Next

    End Function

    Private Function ColumnaCuboExiste(ByVal sNombre As String) As Boolean

        Dim oCol As DevExpress.XtraPivotGrid.PivotGridField

        For Each oCol In pgCubo.Fields
            If oCol.FieldName = sNombre Then
                ColumnaCuboExiste = True
                Exit Function
            End If
        Next

    End Function

    Private Function BotonExiste(ByVal sNombre As String) As Boolean

        Dim oButton As DevExpress.XtraBars.BarButtonItemLink

        For Each oButton In popConjuntos.ItemLinks
            If oButton.Item.Name = sNombre Then
                BotonExiste = True
                Exit Function
            End If
        Next

    End Function

    Private Sub oHelpButton_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles oHelpButton.ButtonClick

        Dim sSQL As String
        Dim sConn As String
        Dim nCampoRet As Integer
        Dim bMultiSel As Boolean
        Dim nTipoConexion As Integer
        Dim oFrm As frmTablaGeneral
        Dim fCustom As frmCustomSearch

        Dim bCustomSearchHabilitada As Boolean
        Dim sMensajeCustomSearch As String
        Dim sVariableCustomSearch As String

        bCustomSearchHabilitada = oConsultaAbierta.Detalles(curRow.Tag).UsaBusquedaPrevia
        sMensajeCustomSearch = oConsultaAbierta.Detalles(curRow.Tag).MensajeBusqueda
        sVariableCustomSearch = oConsultaAbierta.Detalles(curRow.Tag).VariableBusqueda

        If bCustomSearchHabilitada Then

            RETORNO_CUSTOM_SEARCH = ""

            fCustom = New frmCustomSearch(sMensajeCustomSearch)
            fCustom.ShowDialog()
            fCustom.Dispose()

            If RETORNO_CUSTOM_SEARCH = "" Then
                Exit Sub
            End If

            sSQL = ReemplazarVariables(Replace(oConsultaAbierta.Detalles(curRow.Tag).SQLTablaGeneral.ToUpper, sVariableCustomSearch.ToUpper, RETORNO_CUSTOM_SEARCH))

        Else

            sSQL = ReemplazarVariables(oConsultaAbierta.Detalles(curRow.Tag).SQLTablaGeneral)

        End If

        sConn = oConsultaAbierta.CadenaConexion
        nCampoRet = oConsultaAbierta.Detalles(curRow.Tag).CampoRetorno
        bMultiSel = oConsultaAbierta.Detalles(curRow.Tag).EsIN
        nTipoConexion = oConsultaAbierta.TipoConexion

        oFrm = New frmTablaGeneral
        oFrm.GridResultados.MenuManager = rbcMain

        oFrm.PasarInfo(sSQL, sConn, nCampoRet, bMultiSel, nTipoConexion)
        oFrm.ShowDialog()
        oFrm.Dispose()

        'MsgBox("Ejecutar " & sSQL & vbCrLf & vbCrLf & "Retornar campo " & nCampoRet, MsgBoxStyle.Information)
        If RETORNO_CONSULTA_GENERAL <> "" Then
            curRow.Properties.Value = RETORNO_CONSULTA_GENERAL
        End If

    End Sub



    Private Sub GridParametros_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs) Handles GridParametros.FocusedRowChanged
        curRow = e.Row
    End Sub

    Private Sub EstablecerValoresParametros()

        Dim nI As Integer
        Dim oRow As DevExpress.XtraVerticalGrid.Rows.BaseRow

        For nI = 0 To oConsultaAbierta.Detalles.Length - 1
            oRow = GridParametros.Rows(nI + 1) ' Sumar uno x la fila de categoria
            If oConsultaAbierta.Detalles(nI).TipoControl = 4 Then ' CheckBox
                If Not oRow.Properties.Value Is Nothing Then
                    If oRow.Properties.Value.ToString.ToUpper = "TRUE" Then
                        oConsultaAbierta.Detalles(nI).Valor = 1
                    ElseIf oRow.Properties.Value.ToString.ToUpper = "FALSE" Then
                        oConsultaAbierta.Detalles(nI).Valor = 0
                    Else
                        oConsultaAbierta.Detalles(nI).Valor = oRow.Properties.Value
                    End If
                Else
                    oConsultaAbierta.Detalles(nI).Valor = 0
                End If
            Else
                oConsultaAbierta.Detalles(nI).Valor = oRow.Properties.Value
            End If
        Next

    End Sub

    Private Sub Tabs_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles Tabs.SelectedPageChanged
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tabs_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles Tabs.SelectedPageChanging
        Me.Cursor = Cursors.WaitCursor
    End Sub

    Public Sub Ejecutar()

        Dim sSQL As String
        Dim nI As Integer
        Dim sFiltros() As String
        Dim sFiltro As String
        Dim sTemp As String
        Dim sErrorText As String
        Dim nJ As Integer

        Try

            Cursor = Cursors.WaitCursor
            Me.Tabs.Enabled = False

            Procesando(oConsultaAbierta.EjecucionAsincrona)
            Application.DoEvents()

            EstablecerValoresParametros()

            With oConsultaAbierta

                sSQL = .SQLInicial
                sSQL = sSQL & " " & vbCrLf

                For nI = 0 To .Detalles.Length - 1

                    If Not .Detalles(nI).Valor Is Nothing Then
                        If .Detalles(nI).Valor.Trim <> vbNullString Then

                            If .Detalles(nI).EsIN And InStr(.Detalles(nI).Valor, ",") > 0 Then

                                sFiltros = Split(.Detalles(nI).Valor, ",")
                                sFiltro = ""

                                For nJ = 0 To sFiltros.Length - 1

                                    If .Detalles(nI).TipoDatos = "F" Then
                                        sTemp = FechaSQL(sFiltros(nJ), .LiteralFechas, .FormatoFechas)
                                    ElseIf .Detalles(nI).TipoDatos = "N" Then
                                        sTemp = NumeroSQL(sFiltros(nJ), .SimboloDecimal)
                                    Else
                                        sTemp = CadenaSQL(sFiltros(nJ), .LiteralCadenas)
                                    End If

                                    sFiltro = sFiltro & sTemp & ","

                                Next

                                sFiltro = Mid(sFiltro, 1, Len(sFiltro) - 1)

                                sSQL = sSQL & " " & _
                                       .Detalles(nI).ParteSQL.Replace(.Detalles(nI).Variable, sFiltro)

                            Else

                                If .Detalles(nI).TipoDatos = "F" Then
                                    sSQL = sSQL & " " & _
                                          .Detalles(nI).ParteSQL.Replace(.Detalles(nI).Variable, FechaSQL(.Detalles(nI).Valor, .LiteralFechas, .FormatoFechas))
                                ElseIf .Detalles(nI).TipoDatos = "N" Then
                                    sSQL = sSQL & " " & _
                                          .Detalles(nI).ParteSQL.Replace(.Detalles(nI).Variable, NumeroSQL(.Detalles(nI).Valor, .SimboloDecimal))
                                Else
                                    sSQL = sSQL & " " & _
                                          .Detalles(nI).ParteSQL.Replace(.Detalles(nI).Variable, CadenaSQL(.Detalles(nI).Valor, .LiteralCadenas))
                                End If

                            End If

                        End If
                    End If

                    sSQL = sSQL & " " & vbCrLf

                Next

                sSQL = sSQL & " " & vbCrLf & .SQLFinal

                sSQL = ReemplazarVariables(sSQL)

                ' Ejecucion en si ...

                If .CadenaConexion <> vbNullString Then

                    oAdmTablas.ConnectionString = .CadenaConexion

                Else

                    oAdmTablas.ConnectionString = CONN_DEFAULT

                End If

                If .SQLPrevio <> vbNullString Then
                    Select Case oConsultaAbierta.TipoConexion
                        Case 0 : oAdmTablas.EjecutarComandoSQL(ReemplazarVariables(.SQLPrevio))
                        Case 1 : oAdmTablas.EjecutarComandoSQLNativo(ReemplazarVariables(.SQLPrevio))
                        Case 2 : oAdmTablas.EjecutarComandoOracleNativo(ReemplazarVariables(.SQLPrevio))
                        Case 3 : oAdmTablas.EjecutarComandoODBCNativo(ReemplazarVariables(.SQLPrevio))
                        Case Else : oAdmTablas.EjecutarComandoSQL(ReemplazarVariables(.SQLPrevio))
                    End Select
                End If

                curDs = New DataSet

                Select Case oConsultaAbierta.TipoConexion
                    Case 0 : curDs = oAdmTablas.AbrirDataset(sSQL, , sErrorText)
                    Case 1 : curDs = oAdmTablas.AbrirDatasetNativo(sSQL, oConsultaAbierta.EjecucionAsincrona, sErrorText)
                    Case 2 : curDs = oAdmTablas.AbrirDatasetOracleNativo(sSQL, sErrorText)
                    Case 3 : curDs = oAdmTablas.AbrirDatasetODBCNativo(sSQL, sErrorText)
                    Case Else : curDs = oAdmTablas.AbrirDataset(sSQL, , sErrorText)
                End Select

                If curDs Is Nothing Then
                    GoTo ConsultaCancelada
                End If

                curIndex = 0

                If .SQLPosterior <> vbNullString Then
                    Select Case oConsultaAbierta.TipoConexion
                        Case 0 : oAdmTablas.EjecutarComandoSQL(ReemplazarVariables(.SQLPosterior))
                        Case 1 : oAdmTablas.EjecutarComandoSQLNativo(ReemplazarVariables(.SQLPosterior))
                        Case 2 : oAdmTablas.EjecutarComandoOracleNativo(ReemplazarVariables(.SQLPosterior))
                        Case 3 : oAdmTablas.EjecutarComandoODBCNativo(ReemplazarVariables(.SQLPosterior))
                        Case Else : oAdmTablas.EjecutarComandoSQL(ReemplazarVariables(.SQLPosterior))
                    End Select
                End If

                AgregarOtrosResultados()
                MostrarTablaDataset()
                'RestoreLayout()
                'RestoreLayoutCubo()

                tpResultados.PageEnabled = True
                tpCubo.PageEnabled = True
                tpReporte.PageEnabled = True

                Tabs.SelectedTabPage = tpResultados
                FinProcesando()

                Cursor = Cursors.Default

            End With

            Me.Tabs.Enabled = True

        Catch ex As Exception

ErrorConsulta:
            FinProcesando()
            Cursor = Cursors.Default
            Me.Tabs.Enabled = True
            TratarError(ex)
        End Try

        Exit Sub

ConsultaCancelada:
        FinProcesando()
        Cursor = Cursors.Default
        Me.Tabs.Enabled = True

        If CONSULTA_CANCELADA Then
            MensajeInformacion(DescripcionCadena(Cadenas.CDN_ConsultaCancelada))
        Else
            Dim fShowSQLError As New frmSQLError(sErrorText, sSQL)
            fShowSQLError.ShowDialog()
            fShowSQLError.Dispose()
        End If

        Exit Sub

    End Sub

    Private Function ReemplazarVariables(ByVal sCadena As String) As String

        On Error Resume Next

        Dim sTemp As String
        Dim nI As Integer
        Dim dFechaActual As Date
        Dim dHoraActual As String
        Dim dAhora As Date

        sTemp = sCadena
        dFechaActual = Now()

        sTemp = Replace(UCase(sTemp), "|AYER|", Format(dFechaActual.AddDays(-1), FORMATO_FECHAS))
        sTemp = Replace(UCase(sTemp), "|HOY|", Format(dFechaActual, FORMATO_FECHAS))
        sTemp = Replace(UCase(sTemp), "|ANIO|", dFechaActual.Year)
        sTemp = Replace(UCase(sTemp), "|MES|", dFechaActual.Month)
        sTemp = Replace(UCase(sTemp), "|DIA|", dFechaActual.Day)
        sTemp = Replace(UCase(sTemp), "|INICIO_MES|", Format(dFechaActual.AddDays(-dFechaActual.Day + 1), FORMATO_FECHAS))
        sTemp = Replace(UCase(sTemp), "|ULTIMO_FIN_DE_MES|", Format(dFechaActual.AddDays(-dFechaActual.Day), FORMATO_FECHAS))
        sTemp = Replace(UCase(sTemp), "|USUARIO_WINDOWS|", System.Environment.UserName)
        sTemp = Replace(UCase(sTemp), "|TERMINAL|", System.Environment.MachineName)
        sTemp = Replace(UCase(sTemp), "|WINVER|", System.Environment.OSVersion.VersionString)
        sTemp = Replace(UCase(sTemp), "|DIRECTORIO|", System.Environment.CurrentDirectory)
        sTemp = Replace(UCase(sTemp), "|USUARIO_ACTUAL|", USUARIO_ACTUAL)
        sTemp = Replace(UCase(sTemp), "|APP_ACTUAL|", APP_ACTUAL)

        EstablecerValoresParametros()

        For nI = 0 To oConsultaAbierta.Detalles.Length - 1
            If oConsultaAbierta.Detalles(nI).TipoDatos = "F" Then

                sTemp = Replace(UCase(sTemp), "|PARAM" & Format(nI + 1, "00") & "|", CDate(oConsultaAbierta.Detalles(nI).Valor))
                If Err.Number <> 0 Then
                    Err.Clear()
                    GoTo ReemplazoTexto
                End If

            ElseIf oConsultaAbierta.Detalles(nI).TipoDatos = "N" Then

                sTemp = Replace(UCase(sTemp), "|PARAM" & Format(nI + 1, "00") & "|", CDbl(oConsultaAbierta.Detalles(nI).Valor))
                If Err.Number <> 0 Then
                    Err.Clear()
                    GoTo ReemplazoTexto
                End If

            Else
ReemplazoTexto:
                sTemp = Replace(UCase(sTemp), "|PARAM" & Format(nI + 1, "00") & "|", oConsultaAbierta.Detalles(nI).Valor)
            End If
        Next

        On Error Resume Next

        ReemplazarVariables = sTemp

    End Function

    Private Sub cmdEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEjecutar.Click
        If ValidacionOK() Then
            Ejecutar()
        End If

    End Sub

    Private Sub btnResults000_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResults000.ItemClick

        If Not curDs Is Nothing Then

            curIndex = 0

            If AUTOSAVE_LAYOUTS Then
                GuardarLayouts()
            End If

            popConjuntos.Caption = e.Item.Caption

            MostrarTablaDataset()

        End If

    End Sub

    Private Sub MostrarTablaDataset(Optional ByVal sSubTitulo As String = "")

        Cursor = Cursors.WaitCursor

        With GridResultados

            .DataSource = Nothing
            .RefreshDataSource()

            .FocusedView.LayoutChanged()
            .FocusedView.PopulateColumns()

            .DataSource = curDs.Tables(curIndex)
            .RefreshDataSource()

        End With

        'AlterarNombresDataset()

        PostEjecucion(sSubTitulo)

        On Error Resume Next
        GridResultados.FocusedView.ViewCaption = oConsultaAbierta.Resultados(curIndex).Nombre

        Cursor = Cursors.Default

    End Sub

    Private Sub oResultButton_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles oResultButton.ItemClick

        Dim nIndex As Integer

        nIndex = Val(e.Item.Name.Substring(e.Item.Name.Length - 3))
        curIndex = nIndex
        popConjuntos.Caption = e.Item.Caption

        If AUTOSAVE_LAYOUTS Then
            GuardarLayouts()
        End If

        MostrarTablaDataset(e.Item.Caption)

    End Sub

    Private Sub VistaPrevia()
        If GridResultados.IsPrintingAvailable Then
            GridResultados.ShowPrintPreview()
        End If
    End Sub

    Private Sub btnVistaPrevia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVistaPrevia.ItemClick
        VistaPrevia()
    End Sub

    Private Sub LocalizarFormulario()

        lblTituloConexion.Text = DescripcionCadena(Cadenas.CDN_GeneralConexion)
        lblTituloDescripcion.Text = DescripcionCadena(Cadenas.CDN_GeneralDescripcion)
        cmdEjecutar.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_btnEjecutar) & " (F5)"
        cmdCerrar.Text = DescripcionCadena(Cadenas.CDN_GeneralCerrar)

        GridParametros.Rows("catRow").Properties.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_HeaderParametros)
        tpParametros.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_TabParametros)
        tpResultados.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_TabResultados)
        tpCubo.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_TabCubo)
        rpgConjuntos.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoConjuntos)
        rpgImpresion.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoImpresion)
        rpgExportacion.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoExportar)
        rpgOtros.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoOtrasOpciones)
        popConjuntos.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonResultados)
        btnResults000.Caption = popConjuntos.Caption
        btnVistaPrevia.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonPreview)
        btnImprimir.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonImprimir)
        btnHTML.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonExportarHTML)
        btnAutofiltro.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_Autofiltro)
        btnGroupByBox.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_GroupByBox)
        btnFilasSubtotales.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_FilasSubtotales)
        btnFilaTotales.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_FilaTotal)
        btnColumnas.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_FieldChooser)
        btnGuardarLayout.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_GuardarLayout)
        btnCargarLayout.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_CargarLayout)

        rpOpciones.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_RibbonPageOpciones)

        rpCuboGrafico.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_RibbonPageCubo)
        oSplitter.Panel1.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoCubo)
        oSplitter.Panel2.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoGrafico)
        rpgComun.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoComun)
        rpgCubo.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoCubo)
        rpgGrafico.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_GrupoGrafico)

        btnAlternarVisibilidad.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_AlternarVisibilidad)
        btnCuboCustomizeFields.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_PersonalizarCamposCubo)
        btnVistaPreviaCubo.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonPreview)
        btnImprimirCubo.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonImprimir)
        btnGuardarLayoutCubo.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_GuardarLayout)
        btnCargarLayoutCubo.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_CargarLayout)
        btnColumnasCubo.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_FieldChooser)

        btnVistaPreviaGrafico.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_BotonPreview)
        popOrientacion.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_OrientacionGrafico)
        btnOrientacionVertical.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_OrientacionVertical)
        btnOrientacionHorizontal.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_OrientacionHorizontal)
        btnVerEjeX.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EjeX)
        btnVerEjeY.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EjeY)
        btnVerLeyendas.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_Leyendas)
        btnVerValores.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_Valores)

        popTipoGrafico.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloGrafico)
        btnPuntos2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloPuntos)
        btnLineas2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloLineas)
        btnBarras2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloBarras)
        btnBarrasApiladas2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloBarrasApiladas)
        btnArea2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloArea)
        btnTorta2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloTorta)

        btnStepLine2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloLineaHistograma)
        btnSpline2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloLineaCurva)
        btnSplineArea2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloAreaCurva)
        btnStackedArea2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloAreaApilada)
        btnStackedSplineArea2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloAreaCurvaApilada)
        btnFullStackedArea2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloAreaApiladaCompleta)
        btnFullStackedSplineArea2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloAreaCurvaApiladaCompleta)
        btnRadarPoint2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloRadarPunto)
        btnRadarLine2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloRadarLinea)
        btnRadarArea2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloRadarArea)
        btnDoughnut2D.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_EstiloDona)

        btnPuntos3D.Caption = btnPuntos2D.Caption
        btnLineas3D.Caption = btnLineas2D.Caption
        btnBarras3D.Caption = btnBarras2D.Caption
        btnBarrasApiladas3D.Caption = btnBarrasApiladas2D.Caption
        btnArea3D.Caption = btnArea2D.Caption
        btnTorta3D.Caption = btnTorta2D.Caption

        btnImagenGrafico.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_ImagenGrafico)
        btnRotado.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_GraficoRotado)

        ' Reportes

        tpReporte.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_TabInformes)
        cmdNuevoReporte.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeBotonNuevo)
        cmdAbrirReporte.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeBotonAbrir)
        cmdDisenarReporte.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeBotonDisenar)
        cmdEliminarReporte.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeBotonEliminar)
        cmdCargarDesdeArchivo.Text = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeCargarDesdeArchivo)

        lvReportes.Groups(0).Header = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeGrupoLVPropios)
        lvReportes.Groups(1).Header = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeGrupoLVPublicos)

        mnuContextNuevoReporte.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeMenuNuevo)
        mnuContextAbrirReporte.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeMenuAbrir)
        mnuContextDisenarReporte.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeMenuDisenar)
        mnuContextEliminarReporte.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeMenuEliminar)
        mnuContextCargarDesdeArchivo.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_InformeCargarDesdeArchivo)


    End Sub

    Private Sub CrearSuperTips(ByRef oRibbon As DevExpress.XtraBars.Ribbon.RibbonControl)

        'On Error Resume Next

        Dim rPage As DevExpress.XtraBars.Ribbon.RibbonPage
        Dim rPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Dim oButton As DevExpress.XtraBars.BarItemLink
        Dim oTip As DevExpress.Utils.SuperToolTip
        Dim oTipTitle As DevExpress.Utils.ToolTipTitleItem

        For Each rPage In oRibbon.Pages
            For Each rPageGroup In rPage.Groups
                For Each oButton In rPageGroup.ItemLinks

                    oTip = New DevExpress.Utils.SuperToolTip
                    oTipTitle = New DevExpress.Utils.ToolTipTitleItem

                    oTipTitle.Image = oButton.Glyph
                    oTipTitle.Text = oButton.Caption
                    oTip.Items.Add(oTipTitle)


                    oButton.Item.SuperTip = oTip
                Next
            Next
        Next

    End Sub

    Private Sub tpParametros_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpParametros.Resize
        On Error Resume Next
        With GridParametros
            .Width = tpParametros.Width
            .Height = tpParametros.Height - .Top
        End With
    End Sub

    Private Function ValidacionOK() As Boolean

        Dim nI As Integer
        Dim bHayError As Boolean
        Dim sMsjError As String
        Dim vValor 'As VariantType
        Dim vComp1 'As VariantType
        Dim vComp2 'As VariantType
        Dim sParams() As String
        Dim sParam As String

        Const COMODIN_PARAMETRO = "|PARAM|"
        Const COMODIN_VALOR_01 = "|V1|"
        Const COMODIN_VALOR_02 = "|V2|"

        Try

            EstablecerValoresParametros()

            ' Validar que todos los parametros requeridos tengan un valor

            For nI = 0 To oConsultaAbierta.Detalles.Length - 1
                If oConsultaAbierta.Detalles(nI).Requerido Then
                    If oConsultaAbierta.Detalles(nI).Valor Is Nothing Then
                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroRequerido).Replace(COMODIN_PARAMETRO, oConsultaAbierta.Detalles(nI).Nombre)
                        bHayError = True
                        Exit For
                    End If
                    If oConsultaAbierta.Detalles(nI).Valor.Trim = vbNullString Then
                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroRequerido).Replace(COMODIN_PARAMETRO, oConsultaAbierta.Detalles(nI).Nombre)
                        bHayError = True
                        Exit For
                    End If
                End If
            Next

            If bHayError Then
                MensajeError(sMsjError)
                Exit Function
            End If

            ' Validar que los tipos de datos sean coherentes

            For nI = 0 To oConsultaAbierta.Detalles.Length - 1
                If Not oConsultaAbierta.Detalles(nI).Valor Is Nothing Then
                    If oConsultaAbierta.Detalles(nI).Valor.Trim <> vbNullString Then
                        If Not oConsultaAbierta.Detalles(nI).EsIN Then
                            If oConsultaAbierta.Detalles(nI).TipoDatos = "N" Then
                                If Not IsNumeric(oConsultaAbierta.Detalles(nI).Valor) Then
                                    sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoNumerico).Replace(COMODIN_PARAMETRO, oConsultaAbierta.Detalles(nI).Nombre)
                                    bHayError = True
                                    Exit For
                                End If
                            ElseIf oConsultaAbierta.Detalles(nI).TipoDatos = "F" Then
                                If Not IsDate(oConsultaAbierta.Detalles(nI).Valor) Then
                                    sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoFecha).Replace(COMODIN_PARAMETRO, oConsultaAbierta.Detalles(nI).Nombre)
                                    bHayError = True
                                    Exit For
                                End If
                            End If
                        Else
                            '''' Y SI ES IN ????
                            sParams = Split(oConsultaAbierta.Detalles(nI).Valor, ",")
                            If sParams.Length > 0 Then
                                For Each sParam In sParams
                                    If oConsultaAbierta.Detalles(nI).TipoDatos = "N" Then
                                        If Not IsNumeric(sParam) Then
                                            sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoNumerico).Replace(COMODIN_PARAMETRO, oConsultaAbierta.Detalles(nI).Nombre)
                                            bHayError = True
                                            GoTo PrimerError
                                        End If
                                    ElseIf oConsultaAbierta.Detalles(nI).TipoDatos = "F" Then
                                        If Not IsDate(sParam) Then
                                            sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoFecha).Replace(COMODIN_PARAMETRO, oConsultaAbierta.Detalles(nI).Nombre)
                                            bHayError = True
                                            GoTo PrimerError
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
            Next

PrimerError:
            If bHayError Then
                MensajeError(sMsjError)
                Exit Function
            End If

            ' Validar que se cumplan las reglas de validación

            For nI = 0 To oConsultaAbierta.Detalles.Length - 1
                If Not oConsultaAbierta.Detalles(nI).Valor Is Nothing Then
                    If oConsultaAbierta.Detalles(nI).Valor.Trim <> vbNullString Then

                        If oConsultaAbierta.Detalles(nI).OperadorValidacion <> vbNullString Then

                            Select Case oConsultaAbierta.Detalles(nI).TipoDatos
                                Case "F"
                                    vValor = CDate(oConsultaAbierta.Detalles(nI).Valor)
                                    vComp1 = CDate(ReemplazarVariables(oConsultaAbierta.Detalles(nI).ValidacionValor1))
                                    If Trim(oConsultaAbierta.Detalles(nI).ValidacionValor2) <> "" Then
                                        vComp2 = ReemplazarVariables(CDate(oConsultaAbierta.Detalles(nI).ValidacionValor2))
                                    End If
                                Case "N"
                                    vValor = CDbl(oConsultaAbierta.Detalles(nI).Valor)
                                    vComp1 = CDbl(ReemplazarVariables(oConsultaAbierta.Detalles(nI).ValidacionValor1))
                                    If Trim(oConsultaAbierta.Detalles(nI).ValidacionValor2) <> "" Then
                                        vComp2 = ReemplazarVariables(CDbl(oConsultaAbierta.Detalles(nI).ValidacionValor2))
                                    End If
                                Case Else
                                    vValor = Trim(oConsultaAbierta.Detalles(nI).Valor)
                                    vComp1 = ReemplazarVariables(Trim(oConsultaAbierta.Detalles(nI).ValidacionValor1))
                                    vComp2 = ReemplazarVariables(Trim(oConsultaAbierta.Detalles(nI).ValidacionValor2))
                            End Select


                            Select Case oConsultaAbierta.Detalles(nI).OperadorValidacion
                                Case "="
                                    If vValor <> vComp1 Then
                                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoValidaIGUAL).Replace(COMODIN_PARAMETRO, _
                                                                      oConsultaAbierta.Detalles(nI).Nombre).Replace(COMODIN_VALOR_01, _
                                                                      vComp1).Replace(COMODIN_VALOR_02, _
                                                                      vComp2)
                                        bHayError = True
                                        Exit For
                                    End If
                                Case "<>"
                                    If vValor = vComp1 Then
                                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoValidaDISTINTO).Replace(COMODIN_PARAMETRO, _
                                                                      oConsultaAbierta.Detalles(nI).Nombre).Replace(COMODIN_VALOR_01, _
                                                                      vComp1).Replace(COMODIN_VALOR_02, _
                                                                      vComp2)
                                        bHayError = True
                                        Exit For
                                    End If
                                Case ">"
                                    If vValor <= vComp1 Then
                                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoValidaMAYOR).Replace(COMODIN_PARAMETRO, _
                                                                      oConsultaAbierta.Detalles(nI).Nombre).Replace(COMODIN_VALOR_01, _
                                                                      vComp1).Replace(COMODIN_VALOR_02, _
                                                                      vComp2)
                                        bHayError = True
                                        Exit For
                                    End If
                                Case "<"
                                    If vValor >= vComp1 Then
                                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoValidaMENOR).Replace(COMODIN_PARAMETRO, _
                                                                      oConsultaAbierta.Detalles(nI).Nombre).Replace(COMODIN_VALOR_01, _
                                                                      vComp1).Replace(COMODIN_VALOR_02, _
                                                                      vComp2)
                                        bHayError = True
                                        Exit For
                                    End If
                                Case ">="
                                    If vValor < vComp1 Then
                                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoValidaMAYORoIGUAL).Replace(COMODIN_PARAMETRO, _
                                                                      oConsultaAbierta.Detalles(nI).Nombre).Replace(COMODIN_VALOR_01, _
                                                                      vComp1).Replace(COMODIN_VALOR_02, _
                                                                      vComp2)
                                        bHayError = True
                                        Exit For
                                    End If
                                Case "<="
                                    If vValor > vComp1 Then
                                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoValidaMENORoIGUAL).Replace(COMODIN_PARAMETRO, _
                                                                      oConsultaAbierta.Detalles(nI).Nombre).Replace(COMODIN_VALOR_01, _
                                                                      vComp1).Replace(COMODIN_VALOR_02, _
                                                                      vComp2)
                                        bHayError = True
                                        Exit For
                                    End If
                                Case "BETWEEN", "ENTRE"
                                    If Not (vValor >= vComp1 And vValor <= vComp2) Then
                                        sMsjError = DescripcionCadena(Cadenas.CDN_ParametroNoValidaENTRE).Replace(COMODIN_PARAMETRO, _
                                                                      oConsultaAbierta.Detalles(nI).Nombre).Replace(COMODIN_VALOR_01, _
                                                                      vComp1).Replace(COMODIN_VALOR_02, _
                                                                      vComp2)
                                        bHayError = True
                                        Exit For
                                    End If
                            End Select
                        End If
                    End If
                End If
            Next

            If bHayError Then
                MensajeError(sMsjError)
                Exit Function
            End If

            ValidacionOK = True

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Function

    Private Sub oDateButton_FormatEditValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs) Handles oDateButton.FormatEditValue
        If Not e.Value Is Nothing Then
            e.Value = Format(CDate(e.Value), FORMATO_FECHAS)
        End If
    End Sub

    Private Sub HabilitarToolbarResultados(ByVal bHab As Boolean)
        popConjuntos.Enabled = bHab
        btnVistaPrevia.Enabled = bHab
        btnImprimir.Enabled = bHab
        btnExcel.Enabled = bHab
        btnPDF.Enabled = bHab
        btnHTML.Enabled = bHab
        btnAutofiltro.Enabled = bHab
        btnGroupByBox.Enabled = bHab
        btnFilasSubtotales.Enabled = bHab
        btnFilaTotales.Enabled = bHab
        btnColumnas.Enabled = bHab
        btnGuardarLayout.Enabled = bHab
    End Sub

    Private Sub HabilitarToolbarCubo(ByVal bHab As Boolean)

        btnCuboCustomizeFields.Enabled = bHab
        btnVistaPreviaCubo.Enabled = bHab
        btnImprimirCubo.Enabled = bHab
        btnExcelCubo.Enabled = bHab
        btnGuardarLayoutCubo.Enabled = bHab
        btnColumnasCubo.Enabled = bHab

        popOrientacion.Enabled = bHab
        popTipoGrafico.Enabled = bHab

        btnVerEjeX.Enabled = bHab
        btnVerEjeY.Enabled = bHab
        btnVerLeyendas.Enabled = bHab
        btnVerValores.Enabled = bHab

        btnExcelGrafico.Enabled = bHab
        btnImagenGrafico.Enabled = bHab

        btnAlternarVisibilidad.Enabled = bHab
        btnVistaPreviaGrafico.Enabled = bHab
        btnRotado.Enabled = bHab

    End Sub

    Private Sub HabilitarToolbarReportes(ByVal bHab As Boolean)

        cmdNuevoReporte.Enabled = bHab
        cmdAbrirReporte.Enabled = bHab
        cmdDisenarReporte.Enabled = bHab
        cmdEliminarReporte.Enabled = bHab
        cmdCargarDesdeArchivo.Enabled = bHab
        lvReportes.Enabled = bHab

    End Sub

    Private Sub btnExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick

        Dim fExcel As New frmExportarXLS

        fExcel.PasarViewResultados(popConjuntos.Caption, gvwResultados)
        fExcel.ShowDialog()
        fExcel.Dispose()

    End Sub

    Private Sub rbcMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcMain.Click

    End Sub

    Private Sub btnAutofiltro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAutofiltro.ItemClick
        gvwResultados.OptionsView.ShowAutoFilterRow = btnAutofiltro.Down
    End Sub

    Private Sub btnFilasSubtotales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilasSubtotales.ItemClick
        If btnFilasSubtotales.Down Then
            gvwResultados.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Else
            gvwResultados.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        End If
    End Sub

    Private Sub btnFilaTotales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilaTotales.ItemClick
        gvwResultados.OptionsView.ShowFooter = btnFilaTotales.Down
    End Sub

    Private Sub btnGuardarLayout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardarLayout.ItemClick

        GuardarLayoutGrid()

    End Sub

    Private Sub GuardarLayoutGrid(Optional ByVal bIgnoreDialog As Boolean = False)

        Dim oOpts As DevExpress.Utils.OptionsLayoutGrid
        Dim sFilename As String
        Dim sFileTemp As String
        Dim fSave As frmGuardarLayout

        sFilename = GRID_LAYOUTS_PATH & Format(USUARIO_ACTUAL, "000") & "_" & Format(oConsultaAbierta.Codigo, "00000000") & Format(curIndex, "000") & ".xml"

        oOpts = New DevExpress.Utils.OptionsLayoutGrid
        oOpts.StoreAllOptions = True
        oOpts.StoreAppearance = True
        oOpts.StoreVisualOptions = True
        oOpts.StoreDataSettings = True

        Try
            '''' RUTINA PARA GUARDARLO EN LA BASE '''
            CANCEL_SAVE_LAYOUT = True

            If Not bIgnoreDialog Then

                sFileTemp = LOCAL_FOLDER & "LAYOUT.TMP"
                Cursor = Cursors.WaitCursor
                gvwResultados.SaveLayoutToXml(sFileTemp, oOpts)
                Cursor = Cursors.Default

                fSave = New frmGuardarLayout(oConsultaAbierta.Codigo, curIndex, sFileTemp, 1)
                fSave.ShowDialog()
                fSave.Dispose()

            Else
                CANCEL_SAVE_LAYOUT = False
            End If

            If Not CANCEL_SAVE_LAYOUT Then
                Cursor = Cursors.WaitCursor
                gvwResultados.SaveLayoutToXml(sFilename, oOpts)
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub RestoreLayout(Optional ByVal sXMLFile As String = "")

        Dim oOpts As DevExpress.Utils.OptionsLayoutGrid
        Dim sFilename As String

        Cursor = Cursors.WaitCursor
        ' Grilla

        If sXMLFile <> "" Then
            sFilename = sXMLFile
        Else
            sFilename = GRID_LAYOUTS_PATH & Format(USUARIO_ACTUAL, "000") & "_" & Format(oConsultaAbierta.Codigo, "00000000") & Format(curIndex, "000") & ".xml"
        End If

        oOpts = New DevExpress.Utils.OptionsLayoutGrid
        oOpts.StoreAllOptions = True
        oOpts.StoreAppearance = True
        oOpts.StoreVisualOptions = True
        oOpts.StoreDataSettings = True

        If Dir(sFilename) <> vbNullString Then

            Try
                gvwResultados.RestoreLayoutFromXml(sFilename, oOpts)
                gvwResultados.Appearance.SelectedRow.BackColor = Color.FromArgb(30, 0, 0, 240)
                gvwResultados.Appearance.FocusedRow.BackColor = Color.FromArgb(60, 0, 0, 240)

                ActualizarBotonesEstado()

            Catch ex As Exception
                TratarError(ex)
            End Try

        End If

        Cursor = Cursors.Default

    End Sub

    Private Sub RestoreLayoutCubo(Optional ByVal sXMLFile As String = "")

        Dim oOpts As DevExpress.Utils.OptionsLayoutGrid
        Dim sFilename As String
        Dim oCol As DevExpress.XtraGrid.Columns.GridColumn

        Cursor = Cursors.WaitCursor
        ' Cubo

        If sXMLFile <> "" Then
            sFilename = sXMLFile
        Else
            sFilename = CUBE_LAYOUTS_PATH & Format(USUARIO_ACTUAL, "000") & "_" & Format(oConsultaAbierta.Codigo, "00000000") & Format(curIndex, "000") & ".xml"
        End If

        oOpts = New DevExpress.Utils.OptionsLayoutGrid
        oOpts.StoreAllOptions = True
        oOpts.StoreAppearance = True
        oOpts.StoreVisualOptions = True
        oOpts.StoreDataSettings = True

        If Dir(sFilename) <> vbNullString Then

            Try
                pgCubo.RestoreLayoutFromXml(sFilename, oOpts)
            Catch ex As Exception
                TratarError(ex)
            End Try

        End If

        sFilename = CUBE_LAYOUTS_PATH & Format(USUARIO_ACTUAL, "000") & "_" & Format(oConsultaAbierta.Codigo, "00000000") & "_STATE.xml"

        If Dir(sFilename) <> vbNullString Then

            Try
                pgCubo.LoadCollapsedStateFromFile(sFilename)
            Catch ex As Exception
                TratarError(ex)
            End Try

        End If

        ' Completar lo nuevo que quedo afuera

        For Each oCol In gvwResultados.Columns
            If pgCubo.Fields(oCol.FieldName) Is Nothing Then
                pgCubo.Fields.Add(oCol.FieldName, DevExpress.XtraPivotGrid.PivotArea.FilterArea)
            End If
        Next

        Cursor = Cursors.Default

    End Sub

    Private Sub btnGroupByBox_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGroupByBox.ItemClick
        gvwResultados.OptionsView.ShowGroupPanel = btnGroupByBox.Down
    End Sub

    Private Sub ActualizarBotonesEstado()
        btnAutofiltro.Down = gvwResultados.OptionsView.ShowAutoFilterRow
        btnFilasSubtotales.Down = gvwResultados.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        btnFilaTotales.Down = gvwResultados.OptionsView.ShowFooter
        btnGroupByBox.Down = gvwResultados.OptionsView.ShowGroupPanel

    End Sub

    Private Sub gvwResultados_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwResultados.EndGrouping

        Dim oSItem As DevExpress.XtraGrid.GridGroupSummaryItem
        Dim oCol As DevExpress.XtraGrid.Columns.GridColumn

Restart:
        For Each oSItem In gvwResultados.GroupSummary
            If oSItem.ShowInGroupColumnFooter Is Nothing Then
                gvwResultados.GroupSummary.Remove(oSItem)
                GoTo Restart
            End If
        Next
        'gvwResultados.GroupSummary.Clear()

        For Each oCol In gvwResultados.GroupedColumns
            oSItem = New DevExpress.XtraGrid.GridGroupSummaryItem
            oSItem.FieldName = oCol.FieldName

            oSItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            oSItem.DisplayFormat = " - {0:n0} " & DescripcionCadena(Cadenas.CDN_GeneralOcurrencias)
            gvwResultados.GroupSummary.Add(oSItem)

            Exit For
        Next

    End Sub

    Private Sub gvwResultados_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwResultados.HideCustomizationForm
        btnColumnas.Down = False
        bFieldChooseVisible = False
    End Sub

    Private Sub gvwResultados_Layout(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwResultados.Layout

        ActualizarBotonesEstado()

        If AUTOSAVE_LAYOUTS Then

            GuardarLayouts()

        End If

    End Sub

    Private Sub btnHTML_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHTML.ItemClick
        frmExportarHTML.PasarViewResultados(popConjuntos.Caption, oConsultaAbierta.Nombre, gvwResultados)
        frmExportarHTML.ShowDialog()
        frmExportarHTML.Dispose()
    End Sub

    Private Sub btnColumnas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnColumnas.ItemClick

        If bFieldChooseVisible Then
            gvwResultados.DestroyCustomization()
        Else
            gvwResultados.ColumnsCustomization()
        End If

    End Sub

    Private Sub gvwResultados_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwResultados.ShowCustomizationForm
        btnColumnas.Down = True
        bFieldChooseVisible = True
    End Sub

    Private Sub btnGuardarLayoutCubo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardarLayoutCubo.ItemClick

        GuardarLayoutCube()

    End Sub

    Private Sub GuardarLayoutCube(Optional ByVal bIgnoreDialog As Boolean = False)

        Dim oOpts As DevExpress.Utils.OptionsLayoutGrid
        Dim sFilename As String
        Dim sFileTemp As String
        Dim fSave As frmGuardarLayout

        sFilename = CUBE_LAYOUTS_PATH & Format(USUARIO_ACTUAL, "000") & "_" & Format(oConsultaAbierta.Codigo, "00000000") & Format(curIndex, "000") & ".xml"

        oOpts = New DevExpress.Utils.OptionsLayoutGrid
        oOpts.StoreAllOptions = True
        oOpts.StoreAppearance = True
        oOpts.StoreVisualOptions = True
        oOpts.StoreDataSettings = True

        Try

            '''' RUTINA PARA GUARDARLO EN LA BASE '''
            CANCEL_SAVE_LAYOUT = True

            If Not bIgnoreDialog Then

                sFileTemp = LOCAL_FOLDER & "LAYOUT.TMP"
                Cursor = Cursors.WaitCursor
                pgCubo.SaveLayoutToXml(sFileTemp, oOpts)
                Cursor = Cursors.Default

                fSave = New frmGuardarLayout(oConsultaAbierta.Codigo, curIndex, sFileTemp, 2)
                fSave.ShowDialog()
                fSave.Dispose()

            Else

                CANCEL_SAVE_LAYOUT = False

            End If


            If Not CANCEL_SAVE_LAYOUT Then
                Cursor = Cursors.WaitCursor
                pgCubo.SaveLayoutToXml(sFilename, oOpts)
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            TratarError(ex)
        End Try

        sFilename = CUBE_LAYOUTS_PATH & Format(USUARIO_ACTUAL, "000") & "_" & Format(oConsultaAbierta.Codigo, "00000000") & Format(curIndex, "000") & "_STATE.xml"

        Try
            If Not CANCEL_SAVE_LAYOUT Then
                Cursor = Cursors.WaitCursor
                pgCubo.SaveCollapsedStateToFile(sFilename)
                Cursor = Cursors.Default
            End If
        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub btnVerLeyendas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerLeyendas.ItemClick
        chrGrafico.Legend.Visible = btnVerLeyendas.Down
    End Sub

    Private Sub btnVerValores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerValores.ItemClick

        Dim oSerie As DevExpress.XtraCharts.Series

        For Each oSerie In chrGrafico.Series
            oSerie.Label.Visible = btnVerValores.Down

        Next oSerie

    End Sub

    Private Sub btnOrientacionVertical_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOrientacionVertical.ItemClick
        pgCubo.ChartDataVertical = True
        ActualizarGrafico()
    End Sub

    Private Sub btnOrientacionHorizontal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOrientacionHorizontal.ItemClick
        pgCubo.ChartDataVertical = False
        ActualizarGrafico()
    End Sub

    Private Sub btnAlternarVisibilidad_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlternarVisibilidad.ItemClick
        Select Case oSplitter.PanelVisibility
            Case SplitPanelVisibility.Panel1
                oSplitter.PanelVisibility = SplitPanelVisibility.Panel2
            Case SplitPanelVisibility.Panel2
                oSplitter.PanelVisibility = SplitPanelVisibility.Both
            Case SplitPanelVisibility.Both
                oSplitter.PanelVisibility = SplitPanelVisibility.Panel1
        End Select
    End Sub

    Private Sub btnPuntos2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPuntos2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Point)
        ActualizarGrafico()
    End Sub

    Private Sub btnLineas2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLineas2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Line)
        ActualizarGrafico()
    End Sub

    Private Sub btnBarras2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBarras2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
        ActualizarGrafico()
    End Sub

    Private Sub btnBarrasApiladas2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBarrasApiladas2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.StackedBar)
        ActualizarGrafico()
    End Sub

    Private Sub btnArea2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArea2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Area)
        ActualizarGrafico()
    End Sub

    Private Sub btnTorta2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTorta2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Pie)
        ActualizarGrafico()
    End Sub

    Private Sub btnLineas3D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLineas3D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Line3D)
        ActualizarGrafico()
    End Sub

    Private Sub btnBarras3D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBarras3D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.ManhattanBar)
        ActualizarGrafico()
    End Sub

    Private Sub btnArea3D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnArea3D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Area3D)
        ActualizarGrafico()
    End Sub

    Private Sub btnTorta3D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTorta3D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Pie3D)
        ActualizarGrafico()
    End Sub

    Private Sub btnCuboCustomizeFields_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCuboCustomizeFields.ItemClick

        'Dim oField As New DevExpress.XtraPivotGrid.PivotGridField

        'oField.Caption = "VARIACION CAPITAL"
        'oField.FieldName = "CAPITAL"
        'oField.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.AutomaticTotals
        'oField.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentVariation
        'oField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        'pgCubo.Fields.Add(oField)

        Dim fCustomizeFields As New frmPersonalizarCubo(Me)

        fCustomizeFields.PasarCubo(pgCubo)
        fCustomizeFields.ShowDialog(Me)

    End Sub

    Private Sub pgCubo_CellDoubleClick(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles pgCubo.CellDoubleClick

        Dim fDrillDown As New frmDrillDown

        Cursor = Cursors.WaitCursor

        fDrillDown.GridResultados.DataSource = e.CreateDrillDownDataSource()
        fDrillDown.AjustarColumnas(gvwResultados)
        fDrillDown.gvwResultados.BestFitColumns()
        fDrillDown.ShowDialog()
        fDrillDown.Dispose()

        Cursor = Cursors.Default

    End Sub

    Private Sub pgCubo_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs) Handles pgCubo.CustomDrawCell
        If e.DataField.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentVariation Then
            If Not e.Value Is Nothing Then
                If IsNumeric(e.Value) Then
                    If CDec(e.Value) >= 0 Then
                        e.Appearance.ForeColor = Color.Blue
                    Else
                        e.Appearance.ForeColor = Color.Red
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnExcelCubo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcelCubo.ItemClick

        Dim fExcel As New frmExportarXLS

        fExcel.PasarTablaDinamica(popConjuntos.Caption, pgCubo)
        fExcel.ShowDialog()
        fExcel.Dispose()

    End Sub

    Private Sub btnPDF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPDF.ItemClick
        ExportarGrillaPDF(gvwResultados, Me)
    End Sub

    Private Sub btnVistaPreviaCubo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVistaPreviaCubo.ItemClick
        If pgCubo.IsPrintingAvailable Then
            pgCubo.ShowPrintPreview()
        End If
    End Sub

    Private Sub btnVistaPreviaGrafico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVistaPreviaGrafico.ItemClick
        If chrGrafico.IsPrintingAvailable Then
            If oSplitter.PanelVisibility <> SplitPanelVisibility.Panel1 Then
                chrGrafico.ShowPrintPreview()
            End If
        End If
    End Sub

    Private Sub btnRotado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRotado.ItemClick
        On Error Resume Next
        CType(chrGrafico.Diagram, DevExpress.XtraCharts.XYDiagram).Rotated = btnRotado.Down
    End Sub

    Private Sub btnVerEjeX_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerEjeX.ItemClick

        On Error Resume Next

        Dim oView As Object

        oView = chrGrafico.SeriesTemplate.View
        oView.AxisX.Visible = btnVerEjeX.Down

    End Sub

    Private Sub btnVerEjeY_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerEjeY.ItemClick

        On Error Resume Next

        Dim oView As Object

        oView = chrGrafico.SeriesTemplate.View
        oView.AxisY.Visible = btnVerEjeY.Down

    End Sub

    Private Sub ActualizarGrafico()

        Dim oSerie As DevExpress.XtraCharts.SeriesBase
        Dim oView As Object

        For Each oSerie In chrGrafico.Series
            oSerie.Label.Visible = btnVerValores.Down

        Next oSerie

        chrGrafico.Legend.Visible = btnVerLeyendas.Down

        On Error Resume Next

        oView = chrGrafico.SeriesTemplate.View
        oView.AxisX.Visible = btnVerEjeX.Down
        oView.AxisY.Visible = btnVerEjeY.Down

    End Sub

    Private Sub btnExcelGrafico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcelGrafico.ItemClick

        Dim oDlg As SaveFileDialog

        If oSplitter.PanelVisibility <> SplitPanelVisibility.Panel1 Then


            oDlg = New SaveFileDialog
            oDlg.ValidateNames = True
            oDlg.OverwritePrompt = False
            oDlg.Filter = DescripcionCadena(Cadenas.CDN_frmExportarXLS_SaveDialogFilter) & "|*.xls"
            oDlg.ShowDialog(Me)

            If oDlg.FileName.Trim <> vbNullString Then

                Cursor = Cursors.WaitCursor
                chrGrafico.ExportToXls(oDlg.FileName.Trim)
                Process.Start(oDlg.FileName.Trim)
                Cursor = Cursors.Default

            End If

        End If

    End Sub

    Private Sub pgCubo_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles pgCubo.HideCustomizationForm
        btnColumnasCubo.Down = False
        bFieldChooseCuboVisible = False
    End Sub

    Private Sub pgCubo_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles pgCubo.ShowCustomizationForm
        btnColumnasCubo.Down = True
        bFieldChooseCuboVisible = True
    End Sub

    Private Sub btnColumnasCubo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnColumnasCubo.ItemClick
        If bFieldChooseCuboVisible Then
            pgCubo.DestroyCustomization()
        Else
            pgCubo.FieldsCustomization()
        End If
    End Sub

    Private Sub btnImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
        If GridResultados.IsPrintingAvailable Then
            GridResultados.Print()
        End If
    End Sub

    Private Sub btnImagenGrafico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImagenGrafico.ItemClick

        Dim fExpImg As New frmExportarImagen

        fExpImg.PasarChart(chrGrafico, popConjuntos.Caption)
        fExpImg.ShowDialog()
        fExpImg.Dispose()

    End Sub

    Private Sub pgCubo_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles pgCubo.Layout

        If AUTOSAVE_LAYOUTS Then

            GuardarLayouts()

        End If

    End Sub

    Private Sub cmdNuevoReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevoReporte.Click
        NuevoReporte()
    End Sub

    Private Sub NuevoReporte()

        On Error Resume Next

        Cursor = Cursors.WaitCursor

        Dim r As New DevExpress.XtraReports.UI.XtraReport
        Dim oForm As New DevExpress.XtraReports.UserDesigner.XRDesignFormEx
        Dim fSave As frmGuardarReporte

        Dim b1 As DevExpress.XtraReports.UI.Band
        Dim b2 As DevExpress.XtraReports.UI.Band
        Dim b3 As DevExpress.XtraReports.UI.Band
        Dim b4 As DevExpress.XtraReports.UI.Band
        Dim b5 As DevExpress.XtraReports.UI.Band

        b1 = DevExpress.XtraReports.UI.XtraReportBase.CreateBand(DevExpress.XtraReports.UI.BandKind.ReportHeader)
        b2 = DevExpress.XtraReports.UI.XtraReportBase.CreateBand(DevExpress.XtraReports.UI.BandKind.PageHeader)
        b3 = DevExpress.XtraReports.UI.XtraReportBase.CreateBand(DevExpress.XtraReports.UI.BandKind.Detail)
        b4 = DevExpress.XtraReports.UI.XtraReportBase.CreateBand(DevExpress.XtraReports.UI.BandKind.PageFooter)
        b5 = DevExpress.XtraReports.UI.XtraReportBase.CreateBand(DevExpress.XtraReports.UI.BandKind.ReportFooter)

        r.Bands.Add(b1)
        r.Bands.Add(b2)
        r.Bands.Add(b3)
        r.Bands.Add(b4)
        r.Bands.Add(b5)

        r.DataSource = curDs
        r.DataMember = curDs.Tables(curIndex).TableName

        oForm.OpenReport(r)
        oForm.ShowDialog()

        If oForm.FileName <> "" Then
            ' Mostrar el dialogo para guardar los datos del reporte

            REPORTE_NOMBRE = ""
            fSave = New frmGuardarReporte(oConsultaAbierta.Codigo, oForm.FileName)
            Cursor = Cursors.Default
            fSave.ShowDialog()

            If REPORTE_NOMBRE <> "" Then
                AgregarReporte(r, oForm.FileName, REPORTE_NOMBRE, REPORTE_PUBLICO)
            End If

        End If

        oForm.Dispose()
        r.Dispose()

        Cursor = Cursors.Default

    End Sub

    Private Sub CargarReporteDesdeArchivo()

        Dim oDlg As OpenFileDialog
        Dim sFileName As String
        Dim r As New DevExpress.XtraReports.UI.XtraReport

        oDlg = New OpenFileDialog
        oDlg.ValidateNames = True
        oDlg.Filter = "REPX|*.repx"
        oDlg.ShowDialog(Me)

        Try


            If oDlg.FileName.Trim <> vbNullString Then
                sFileName = oDlg.FileName.Trim

                REPORTE_NOMBRE = ""

                Dim fSave As New frmGuardarReporte(oConsultaAbierta.Codigo, sFileName)

                Cursor = Cursors.Default
                fSave.ShowDialog()

                If REPORTE_NOMBRE <> "" Then
                    r.LoadLayout(sFileName)

                    AgregarReporte(r, sFileName, REPORTE_NOMBRE, REPORTE_PUBLICO)
                End If

            End If

        Catch ex As Exception
            TratarError(ex)
        End Try


    End Sub

    Private Sub AgregarReporte(ByVal oRep As DevExpress.XtraReports.UI.XtraReport, _
                               ByVal sFileName As String, _
                               ByVal sNombreReporte As String, _
                               ByVal bPublic As Boolean)

        Dim sSQL As String
        Dim ds As DataSet
        Dim oRow As DataRow
        Dim da As OleDb.OleDbDataAdapter
        Dim cb As OleDb.OleDbCommandBuilder
        Dim stReporte As New IO.MemoryStream
        Dim oAdmLocal As New AdmTablas
        Dim sTempPath As String

        Cursor = Cursors.WaitCursor

        sSQL = "SELECT  * " & _
               "FROM    REPORT " & _
               "WHERE   1 = 0 "

        Try

            oAdmLocal.ConnectionString = CONN_LOCAL

            ds = oAdmLocal.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

                oRow = .NewRow()
                oRow.Item("RP_CODCON") = oConsultaAbierta.Codigo
                oRow.Item("RP_CODUSU") = USUARIO_ACTUAL
                oRow.Item("RP_NOMBRE") = sNombreReporte
                oRow.Item("RP_PATH") = sFileName

                If bPublic Then
                    oRow.Item("RP_PUBLIC") = 1

                    'sTempPath = LOCAL_FOLDER & "TMP_REP.REPX"
                    'oRep.SaveLayout(sTempPath)
                    'oRep.SaveLayout(stReporte)

                    oRow.Item("RP_STREAM") = IO.File.ReadAllText(sFileName)
                    'oRow.Item("RP_STREAM") = IO.File.ReadAllText(sTempPath)
                    'oRow.Item("RP_STREAM") = stReporte.ToArray

                Else
                    oRow.Item("RP_PUBLIC") = 0
                End If

                .Rows.Add(oRow)

                da.Update(ds)
                ds.AcceptChanges()

            End With

            CargarReportesConsulta()

            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try

    End Sub

    Private Sub EditarReporte(ByVal oRep As DevExpress.XtraReports.UI.XtraReport, _
                              ByVal sFileName As String, _
                              ByVal sNombreReporte As String, _
                              ByVal bPublic As Boolean)

        Dim sSQL As String
        Dim ds As DataSet
        Dim oRow As DataRow
        Dim da As OleDb.OleDbDataAdapter
        Dim cb As OleDb.OleDbCommandBuilder
        Dim stReporte As New IO.MemoryStream
        Dim oAdmLocal As New AdmTablas
        Dim sTempPath As String

        Cursor = Cursors.WaitCursor

        sSQL = "SELECT  * " & _
               "FROM    REPORT " & _
               "WHERE   RP_CODUSU = " & USUARIO_ACTUAL & " " & _
               "AND     RP_CODCON = " & oConsultaAbierta.Codigo & " " & _
               "AND     RP_NOMBRE = '" & sNombreReporte & "'"

        Try

            oAdmLocal.ConnectionString = CONN_LOCAL

            ds = oAdmLocal.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

                oRow = .Rows(0)
                oRow.BeginEdit()

                oRow.Item("RP_PATH") = sFileName

                If bPublic Then
                    oRow.Item("RP_PUBLIC") = 1

                    sTempPath = LOCAL_FOLDER & "TMP_REP.REPX"
                    oRep.SaveLayout(sTempPath)
                    'oRep.SaveLayout(stReporte)

                    oRow.Item("RP_STREAM") = IO.File.ReadAllText(sTempPath)
                    'oRow.Item("RP_STREAM") = stReporte.ToArray
                Else
                    oRow.Item("RP_PUBLIC") = 0
                End If

                oRow.EndEdit()

                da.Update(ds)
                ds.AcceptChanges()

            End With

            CargarReportesConsulta()

            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try

    End Sub

    Private Sub AbrirReporteEjecucion(ByVal itmX As ListViewItem)

        Dim stReporte As IO.MemoryStream
        Dim sSQL As String
        Dim ds As DataSet
        Dim oAdmLocal As AdmTablas
        Dim r As New DevExpress.XtraReports.UI.XtraReport
        Dim nCodUsuario As Long
        Dim bBytes() As Byte
        Dim sTempPath As String

        Cursor = Cursors.WaitCursor

        Try

            If itmX.Tag = 0 Then
                ' Privado
                r.LoadLayout(itmX.SubItems(1).Text)

            Else
                ' publico

                oAdmLocal = New AdmTablas
                oAdmLocal.ConnectionString = CONN_LOCAL
                nCodUsuario = Val(itmX.Name.Substring(1, 4))

                sSQL = "SELECT  RP_STREAM " & _
                       "FROM    REPORT " & _
                       "WHERE   RP_CODUSU = " & nCodUsuario & " " & _
                       "AND     RP_CODCON = " & oConsultaAbierta.Codigo & " " & _
                       "AND     RP_NOMBRE = '" & itmX.Text & "'"

                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)
                    If .Rows.Count > 0 Then

                        sTempPath = LOCAL_FOLDER & "TMP_REP.REPX"
                        IO.File.WriteAllText(sTempPath, .Rows(0).Item("RP_STREAM"))
                        r.LoadLayout(sTempPath)

                        'stReporte = New IO.MemoryStream
                        'bBytes = .Rows(0).Item("RP_STREAM")
                        'stReporte.Write(bBytes, 0, bBytes.Length - 1)
                        'r.LoadLayout(stReporte)

                    End If
                End With

            End If

            r.DataSource = curDs
            'r.DataMember = curDs.Tables(curIndex).TableName

            Cursor = Cursors.Default
            r.ShowPreviewDialog()

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try


    End Sub


    Private Sub AbrirReporteDiseno(ByVal itmX As ListViewItem)

        Dim stReporte As IO.MemoryStream
        Dim sSQL As String
        Dim ds As DataSet
        Dim oAdmLocal As AdmTablas
        Dim r As New DevExpress.XtraReports.UI.XtraReport
        Dim oForm As New DevExpress.XtraReports.UserDesigner.XRDesignFormEx
        Dim nCodUsuario As Long
        Dim bBytes() As Byte
        Dim fSave As frmGuardarReporte
        Dim bPublic As Boolean
        Dim sTempPath As String

        Cursor = Cursors.WaitCursor



        Try

            If itmX.Tag = 0 Then
                ' Privado
                r.LoadLayout(itmX.SubItems(1).Text)
                

            Else
                ' publico

                bPublic = True

                oAdmLocal = New AdmTablas
                oAdmLocal.ConnectionString = CONN_LOCAL
                nCodUsuario = Val(itmX.Name.Substring(1, 4))

                sSQL = "SELECT  RP_STREAM " & _
                       "FROM    REPORT " & _
                       "WHERE   RP_CODUSU = " & nCodUsuario & " " & _
                       "AND     RP_CODCON = " & oConsultaAbierta.Codigo & " " & _
                       "AND     RP_NOMBRE = '" & itmX.Text & "'"

                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)
                    If .Rows.Count > 0 Then

                        sTempPath = LOCAL_FOLDER & "TMP_REP.REPX"
                        IO.File.WriteAllText(sTempPath, .Rows(0).Item("RP_STREAM"))
                        r.LoadLayout(sTempPath)

                        'stReporte = New IO.MemoryStream
                        'bBytes = .Rows(0).Item("RP_STREAM")
                        'stReporte.Write(bBytes, 0, bBytes.Length - 1)
                        'r.LoadLayout(stReporte)


                    End If
                End With

            End If

            'r.DataSource = curDs.Tables(curIndex)
            Cursor = Cursors.Default



            If Not bPublic Then
                oForm.FileName = itmX.SubItems(1).Text
            Else
                oForm.FileName = LOCAL_FOLDER & "REPTMP.REPX"
            End If

            r.DataSource = curDs
            r.DataMember = curDs.Tables(curIndex).TableName

            oForm.OpenReport(r)

            oForm.ShowDialog()

            If oForm.FileName <> "" Then
                ' Mostrar el dialogo para guardar los datos del reporte

                EditarReporte(r, oForm.FileName, itmX.Text, itmX.Tag = 1)

            End If

            oForm.Dispose()
            r.Dispose()


        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try


    End Sub

    Private Sub EliminarReporte(ByVal itmX As ListViewItem)

        Dim sSQL As String
        Dim oAdmLocal As New AdmTablas

        sSQL = "DELETE      " & _
               "FROM        REPORT " & _
               "WHERE       RP_CODUSU = " & USUARIO_ACTUAL & " " & _
               "AND         RP_CODCON = " & oConsultaAbierta.Codigo & " " & _
               "AND         RP_NOMBRE = '" & itmX.Text & "'"

        oAdmLocal.ConnectionString = CONN_LOCAL
        Call oAdmLocal.EjecutarComandoSQL(sSQL)

        CargarReportesConsulta()

    End Sub

    Private Function PermisoDisenoReporte(ByVal itmX As ListViewItem) As Boolean

        Return Val(itmX.Name.Substring(1, 4)) = USUARIO_ACTUAL

    End Function

    Private Sub lvReportes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvReportes.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not lvReportes.FocusedItem Is Nothing Then
                AbrirReporteEjecucion(lvReportes.FocusedItem)
            End If
        End If
    End Sub

    Private Sub CargarReportesConsulta()

        Dim sSQL As String
        Dim ds As DataSet
        Dim oRow As DataRow
        Dim oAdmLocal As New AdmTablas
        Dim itmX As ListViewItem
        Dim nI As Integer
        Dim sSubItem As String

        Cursor = Cursors.WaitCursor

        sSQL = "SELECT  RP_CODUSU, RP_CODCON, RP_NOMBRE, RP_PATH, RP_PUBLIC " & _
               "FROM    REPORT " & _
               "WHERE   RP_CODCON = " & oConsultaAbierta.Codigo & " " & _
               "AND    (RP_CODUSU = " & USUARIO_ACTUAL & " OR RP_PUBLIC = 1) " & _
               "ORDER BY RP_PUBLIC, RP_NOMBRE"

        Try

            oAdmLocal.ConnectionString = CONN_LOCAL

            ds = oAdmLocal.AbrirDataset(sSQL)
            lvReportes.Items.Clear()

            With ds.Tables(0)

                For nI = 0 To .Rows.Count - 1

                    oRow = .Rows(nI)

                    itmX = New ListViewItem

                    itmX.Text = oRow.Item("RP_NOMBRE").ToString
                    itmX.Name = "K" & Format(oRow.Item("RP_CODUSU"), "0000") & Format(oRow.Item("RP_CODCON"), "0000")
                    itmX.Tag = oRow.Item("RP_PUBLIC").ToString

                    If oRow.Item("RP_PUBLIC") = 0 Then

                        sSubItem = oRow.Item("RP_PATH")
                        itmX.ImageIndex = 0
                        itmX.Group = lvReportes.Groups(0)

                    Else

                        sSubItem = "Público"
                        itmX.ImageIndex = 1
                        itmX.Group = lvReportes.Groups(1)

                    End If

                    itmX.SubItems.Add(sSubItem)
                    lvReportes.Items.Add(itmX)

                Next

            End With

            EvaluarHabilitacionReportes(False)

            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try

    End Sub

    Private Sub lvReportes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvReportes.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If (lvReportes.SelectedItems.Count > 0) Then
                If Not lvReportes.FocusedItem Is Nothing Then
                    popContextReportes.ShowPopup(Control.MousePosition)
                End If
            End If
        End If
    End Sub

    Private Sub lvReportes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvReportes.SelectedIndexChanged

        Dim bHab As Boolean

        bHab = (Not lvReportes.FocusedItem Is Nothing) And (lvReportes.SelectedItems.Count > 0)
        EvaluarHabilitacionReportes(bHab)
        

    End Sub

    Private Sub EvaluarHabilitacionReportes(ByVal bHab As Boolean)
        cmdAbrirReporte.Enabled = bHab
        cmdDisenarReporte.Enabled = bHab
        cmdEliminarReporte.Enabled = bHab

        mnuContextAbrirReporte.Enabled = bHab
        mnuContextDisenarReporte.Enabled = bHab
        mnuContextEliminarReporte.Enabled = bHab
    End Sub

    Private Sub cmdAbrirReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbrirReporte.Click
        If lvReportes.SelectedItems.Count > 0 Then
            If Not lvReportes.FocusedItem Is Nothing Then
                AbrirReporteEjecucion(lvReportes.FocusedItem)
            End If
        End If
    End Sub

    Private Sub mnuContextAbrirReporte_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuContextAbrirReporte.ItemClick
        If lvReportes.SelectedItems.Count > 0 Then
            If Not lvReportes.FocusedItem Is Nothing Then
                AbrirReporteEjecucion(lvReportes.FocusedItem)
            End If
        End If
    End Sub

    Private Sub cmdDisenarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisenarReporte.Click
        If lvReportes.SelectedItems.Count > 0 Then
            If Not lvReportes.FocusedItem Is Nothing Then
                Cursor = Cursors.WaitCursor
                If PermisoDisenoReporte(lvReportes.FocusedItem) Then
                    AbrirReporteDiseno(lvReportes.FocusedItem)
                Else
                    Cursor = Cursors.Default
                    MensajeError(DescripcionCadena(Cadenas.CDN_frmConsulta_InformeEdicionNoPermitida))
                End If
                Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub mnuContextDisenarReporte_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuContextDisenarReporte.ItemClick
        If lvReportes.SelectedItems.Count > 0 Then
            If Not lvReportes.FocusedItem Is Nothing Then
                Cursor = Cursors.WaitCursor
                If PermisoDisenoReporte(lvReportes.FocusedItem) Then
                    AbrirReporteDiseno(lvReportes.FocusedItem)
                Else
                    Cursor = Cursors.Default
                    MensajeError(DescripcionCadena(Cadenas.CDN_frmConsulta_InformeEdicionNoPermitida))
                End If
                Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub mnuContextNuevoReporte_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuContextNuevoReporte.ItemClick
        NuevoReporte()
    End Sub


    Private Sub cmdEliminarReporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEliminarReporte.Click
        If lvReportes.SelectedItems.Count > 0 Then
            If Not lvReportes.FocusedItem Is Nothing Then
                If PermisoDisenoReporte(lvReportes.FocusedItem) Then
                    If Pregunta(DescripcionCadena(Cadenas.CDN_frmConsulta_InformeWarningEliminar)) = Windows.Forms.DialogResult.Yes Then
                        EliminarReporte(lvReportes.FocusedItem)
                    End If
                Else
                    MensajeError(DescripcionCadena(Cadenas.CDN_frmConsulta_InformeEliminacionNoPermitida))
                End If
            End If
        End If
    End Sub

    Private Sub mnuContextEliminarReporte_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuContextEliminarReporte.ItemClick
        If lvReportes.SelectedItems.Count > 0 Then
            If Not lvReportes.FocusedItem Is Nothing Then
                If PermisoDisenoReporte(lvReportes.FocusedItem) Then
                    If Pregunta(DescripcionCadena(Cadenas.CDN_frmConsulta_InformeWarningEliminar)) = Windows.Forms.DialogResult.Yes Then
                        EliminarReporte(lvReportes.FocusedItem)
                    End If
                Else
                    MensajeError(DescripcionCadena(Cadenas.CDN_frmConsulta_InformeEliminacionNoPermitida))
                End If
            End If
        End If

    End Sub

    Private Sub cmdCargarDesdeArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCargarDesdeArchivo.Click
        CargarReporteDesdeArchivo()
    End Sub

    Private Sub mnuContextCargarDesdeArchivo_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuContextCargarDesdeArchivo.ItemClick
        CargarReporteDesdeArchivo()
    End Sub

    Private Sub btnCargarLayout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCargarLayout.ItemClick

        Dim fOpen As frmCargarLayout
        Dim sFileXML As String

        sFileXML = LOCAL_FOLDER & "TMPLYT.XML"
        fOpen = New frmCargarLayout(oConsultaAbierta.Codigo, curIndex, sFileXML, 1)

        fOpen.ShowDialog()
        fOpen.Dispose()

        If LOAD_LAYOUT_SUCCESS Then
            RestoreLayout(sFileXML)
            GuardarLayoutGrid(True)
        End If

    End Sub

    Private Sub btnCargarLayoutCubo_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCargarLayoutCubo.ItemClick

        Dim fOpen As frmCargarLayout
        Dim sFileXML As String

        sFileXML = LOCAL_FOLDER & "TMPLYT.XML"
        fOpen = New frmCargarLayout(oConsultaAbierta.Codigo, curIndex, sFileXML, 2)
        fOpen.ShowDialog()
        fOpen.Dispose()

        If LOAD_LAYOUT_SUCCESS Then
            RestoreLayoutCubo(sFileXML)
            GuardarLayoutCube(True)
            CheckFields()
        End If

    End Sub


    Private Sub GridParametros_EditorKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridParametros.EditorKeyDown
        If e.KeyCode = Keys.F5 Then
            cmdEjecutar_Click(sender, e)
        ElseIf e.KeyCode = Keys.F1 Then
            ''''' F1 ''''

        End If
    End Sub

    Private Sub GridParametros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridParametros.KeyDown
        If e.KeyCode = Keys.F5 Then
            cmdEjecutar_Click(sender, e)
        ElseIf e.KeyCode = Keys.F1 Then
            ''''' F1 ''''

        End If
    End Sub

    Private Sub btnStepLine2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStepLine2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.StepLine)
        ActualizarGrafico()
    End Sub

    Private Sub btnSpline2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSpline2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Spline)
        ActualizarGrafico()
    End Sub

    Private Sub btnStackedArea2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStackedArea2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.StackedArea)
        ActualizarGrafico()
    End Sub

    Private Sub btnFullStackedArea2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFullStackedArea2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.FullStackedArea)
        ActualizarGrafico()
    End Sub

    Private Sub btnSplineArea2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSplineArea2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.SplineArea)
        ActualizarGrafico()
    End Sub

    Private Sub btnStackedSplineArea2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStackedSplineArea2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.StackedSplineArea)
        ActualizarGrafico()
    End Sub

    Private Sub btnFullStackedSplineArea2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFullStackedSplineArea2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.FullStackedSplineArea)
        ActualizarGrafico()
    End Sub

    Private Sub btnRadarPoint2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRadarPoint2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.RadarPoint)
        ActualizarGrafico()
    End Sub

    Private Sub btnRadarLine2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRadarLine2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.RadarLine)
        ActualizarGrafico()
    End Sub

    Private Sub btnRadarArea2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRadarArea2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.RadarArea)
        ActualizarGrafico()
    End Sub

    Private Sub btnDoughnut2D_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDoughnut2D.ItemClick
        chrGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Doughnut)
        ActualizarGrafico()
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub pgCubo_CustomEditValue(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomEditValueEventArgs) Handles pgCubo.CustomEditValue

        If SHOW_PERCENT_PB Then
            If e.DataField.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn Or _
               e.DataField.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfRow Then

                e.Value = Convert.ToDouble(e.Value) * 100.0F

            End If
        End If

    End Sub


    Private Sub pgCubo_FieldAreaChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldEventArgs) Handles pgCubo.FieldAreaChanged

        If SHOW_PERCENT_PB Then

            With e.Field

                .AllowEdit = False

                If .SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn Or _
                   .SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfRow Then

                    .FieldEdit = Me.riProgressBar
                    .CellFormat.FormatString = "N"

                Else


                    .FieldEdit = Nothing

                End If

            End With

        End If

    End Sub

    Public Sub CheckFields()
        Dim oField As DevExpress.XtraPivotGrid.PivotGridField

        If SHOW_PERCENT_PB Then

            Cursor = Cursors.WaitCursor

            For Each oField In pgCubo.Fields

                With oField

                    .AllowEdit = False

                    If .SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn Or _
                       .SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfRow Then

                        .FieldEdit = Me.riProgressBar
                        .CellFormat.FormatString = "N"

                    Else

                        .FieldEdit = Nothing

                    End If

                End With

            Next

            Cursor = Cursors.Default

        End If

    End Sub

    Private Sub pgCubo_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles pgCubo.CustomCellDisplayText

        If SHOW_PERCENT_PB Then
            If e.DataField.SummaryDisplayType <> DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn And _
               e.DataField.SummaryDisplayType <> DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfRow Then

                e.DisplayText = Format(e.Value, e.DataField.CellFormat.FormatString)
                e.DataField.FieldEdit = Nothing

            End If
        End If
    End Sub
End Class
