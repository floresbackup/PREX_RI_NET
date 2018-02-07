Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Controls
Imports ActiproSoftware.SyntaxEditor

Public Class frmDisenoConsulta

    Private MODO As String
    Private oAdmTablas As New AdmTablas

    Private oConsultaAbierta As Consulta

    Public dsConsulta As New DataSet
    Private oOptions As New FindReplaceOptions

    Private CONEXION_ACTUAL As String

    Public Sub AbrirConsulta(ByVal nCodigoConsulta As Long)

        Try

            oConsultaAbierta = AbrirConsultaGlobal(nCodigoConsulta)

            If oConsultaAbierta.ProtegidaDiseno Then

                FinProcesando()

                Dim fPassword As New frmPassword

                fPassword.IniciarOpciones()
                fPassword.PasarPassword(cEncrypt.DecryptString128Bit(oConsultaAbierta.PasswordDiseno))
                fPassword.ShowDialog()

                If Not PASSWORD_OK Then
                    Me.Tag = "InvalidPassword"
                End If

            End If

            MODO = "M"
            CrearParametros()
            CargarDatosConsulta()

            Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionDisenoConsulta) & ": " & oConsultaAbierta.Nombre

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub CargarDatosConsulta()

        Dim oItemAux As ImageComboBoxItem

        With oConsultaAbierta

            txtNombreConsulta.Text = .Nombre
            txtDescripcion.Text = .Descripcion
            cboCategoria.Tag = .CodigoCategoria
            cboCategoria.EditValue = .DescripcionCategoria
            tvMain.SelectedNode = tvMain.Nodes.Find("C" & .CodigoCategoria, True)(0)

            oItemAux = cboConexion.Properties.Items.GetItem(CDec(.CodigoConexion))
            cboConexion.SelectedItem = oItemAux

            If .Protegida Then
                chkPasswordProtected.Checked = True
                txtPassword.Text = cEncrypt.DecryptString128Bit(.Password)
            End If

            If .ProtegidaDiseno Then
                chkPasswordDiseno.Checked = True
                txtPasswordDiseno.Text = cEncrypt.DecryptString128Bit(.PasswordDiseno)
            End If

            chkServerMode.Checked = .ModoServidor
            chkNativoSQL.Checked = False '.NativoSQL

            'If .NativoSQL Then
            chkEjecucionAsincrona.Checked = False '.EjecucionAsincrona
            'End If

            chkOpcionesDefault.Checked = .OpcionesDefault

            If Not .OpcionesDefault Then
                txtSimboloDecimal.Text = .SimboloDecimal
                txtLiteralCadenas.Text = .LiteralCadenas
                txtLiteralFechas.Text = .LiteralFechas
                txtFormatoFechas.Text = .FormatoFechas
            End If

            txtSQLInicial.Text = .SQLInicial
            txtSQLFinal.Text = .SQLFinal

            txtSQLPrevio.Text = .SQLPrevio
            txtSQLPosterior.Text = .SQLPosterior

        End With

    End Sub

    Private Sub CrearTablasTemporales()

        dsConsulta.Tables.Clear()
        dsConsulta.Tables.Add("PARAMS")
        dsConsulta.Tables.Add("FORMAT")
        dsConsulta.Tables.Add("RESULT")

        dsConsulta.Tables("PARAMS").Columns.Add("CD_ORDEN", Type.GetType("System.Int32"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_NOMPAR", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_TIPCON", Type.GetType("System.Int32"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_TIPDAT", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_VARIAB", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_PARSQL", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_INSQL", Type.GetType("System.Int32"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_HELP", Type.GetType("System.Int32"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_REQUER", Type.GetType("System.Int32"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_SQLTBG", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_CAMRET", Type.GetType("System.Int32"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_DEFAUL", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_VALIDA", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_VALOR1", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_VALOR2", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_REQTXT", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_USABUS", Type.GetType("System.Int32"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_MSJBUS", Type.GetType("System.String"))
        dsConsulta.Tables("PARAMS").Columns.Add("CD_VARBUS", Type.GetType("System.String"))

        dsConsulta.Tables("FORMAT").Columns.Add("CF_TIPCOL", Type.GetType("System.Int32"))
        dsConsulta.Tables("FORMAT").Columns.Add("CF_COLKEY", Type.GetType("System.String"))
        dsConsulta.Tables("FORMAT").Columns.Add("CF_FORMAT", Type.GetType("System.String"))
        dsConsulta.Tables("FORMAT").Columns.Add("CF_TITULO", Type.GetType("System.String"))
        dsConsulta.Tables("FORMAT").Columns.Add("CF_VISIBL", Type.GetType("System.Int32"))
        dsConsulta.Tables("FORMAT").Columns.Add("CF_VISTXT", Type.GetType("System.String"))

        dsConsulta.Tables("RESULT").Columns.Add("CR_ORDEN", Type.GetType("System.Int32"))
        dsConsulta.Tables("RESULT").Columns.Add("CR_NOMBRE", Type.GetType("System.String"))

    End Sub

    Private Sub CrearParametros()

        Dim i As Integer
        Dim oRow As DataRow

        If MODO = "M" Then

            dsConsulta.Tables("PARAMS").Rows.Clear()
            dsConsulta.Tables("FORMAT").Rows.Clear()
            dsConsulta.Tables("RESULT").Rows.Clear()

            For i = 0 To oConsultaAbierta.Detalles.Length - 1
                oRow = dsConsulta.Tables("PARAMS").NewRow()
                oRow("CD_ORDEN") = oConsultaAbierta.Detalles(i).Orden
                oRow("CD_NOMPAR") = oConsultaAbierta.Detalles(i).Nombre
                oRow("CD_TIPCON") = oConsultaAbierta.Detalles(i).TipoControl
                oRow("CD_TIPDAT") = oConsultaAbierta.Detalles(i).TipoDatos
                oRow("CD_VARIAB") = oConsultaAbierta.Detalles(i).Variable
                oRow("CD_PARSQL") = oConsultaAbierta.Detalles(i).ParteSQL
                oRow("CD_INSQL") = Math.Abs(Val(oConsultaAbierta.Detalles(i).EsIN))
                oRow("CD_HELP") = oConsultaAbierta.Detalles(i).TipoHelp
                oRow("CD_REQUER") = Math.Abs(Val(oConsultaAbierta.Detalles(i).Requerido))
                oRow("CD_SQLTBG") = oConsultaAbierta.Detalles(i).SQLTablaGeneral
                oRow("CD_CAMRET") = oConsultaAbierta.Detalles(i).CampoRetorno
                oRow("CD_DEFAUL") = oConsultaAbierta.Detalles(i).ValorDefault
                oRow("CD_VALIDA") = oConsultaAbierta.Detalles(i).OperadorValidacion
                oRow("CD_VALOR1") = oConsultaAbierta.Detalles(i).ValidacionValor1
                oRow("CD_VALOR2") = oConsultaAbierta.Detalles(i).ValidacionValor2

                oRow("CD_REQTXT") = IIf(oConsultaAbierta.Detalles(i).Requerido, _
                                        DescripcionCadena(Cadenas.CDN_GeneralSi), _
                                        DescripcionCadena(Cadenas.CDN_GeneralNo))

                oRow("CD_USABUS") = Math.Abs(Val(oConsultaAbierta.Detalles(i).UsaBusquedaPrevia))
                oRow("CD_MSJBUS") = oConsultaAbierta.Detalles(i).MensajeBusqueda
                oRow("CD_VARBUS") = oConsultaAbierta.Detalles(i).VariableBusqueda

                dsConsulta.Tables("PARAMS").Rows.Add(oRow)
            Next

            For i = 0 To oConsultaAbierta.Formatos.Length - 1
                oRow = dsConsulta.Tables("FORMAT").NewRow()
                oRow("CF_TIPCOL") = oConsultaAbierta.Formatos(i).TipoColumna
                oRow("CF_COLKEY") = oConsultaAbierta.Formatos(i).ColumnaKey
                oRow("CF_FORMAT") = oConsultaAbierta.Formatos(i).Formato
                oRow("CF_TITULO") = oConsultaAbierta.Formatos(i).Titulo
                oRow("CF_VISIBL") = oConsultaAbierta.Formatos(i).Visible

                oRow("CF_VISTXT") = IIf(oConsultaAbierta.Formatos(i).Visible, _
                        DescripcionCadena(Cadenas.CDN_GeneralSi), _
                        DescripcionCadena(Cadenas.CDN_GeneralNo))

                dsConsulta.Tables("FORMAT").Rows.Add(oRow)
            Next

            For i = 0 To oConsultaAbierta.Resultados.Length - 1
                oRow = dsConsulta.Tables("RESULT").NewRow()
                oRow("CR_ORDEN") = oConsultaAbierta.Resultados(i).Orden
                oRow("CR_NOMBRE") = oConsultaAbierta.Resultados(i).Nombre

                dsConsulta.Tables("RESULT").Rows.Add(oRow)
            Next

        End If

        RefrescarGrillas()

    End Sub

    Public Sub RefrescarGrillas()

        Dim oCol As Columns.GridColumn

        With GridParametros

            .DataSource = dsConsulta.Tables("PARAMS")
            .RefreshDataSource()

            For Each oCol In gvwParametros.Columns
                Select Case oCol.FieldName

                    Case "CD_ORDEN" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloOrden)
                    Case "CD_NOMPAR" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloNombre)
                    Case "CD_REQTXT" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloRequerido)
                    Case Else : oCol.Visible = False

                End Select

            Next

            gvwParametros.OptionsView.ColumnAutoWidth = True
            gvwParametros.BestFitColumns()

        End With

        With GridFormatos

            .DataSource = dsConsulta.Tables("FORMAT")
            .RefreshDataSource()

            For Each oCol In gwvFormatos.Columns
                Select Case oCol.FieldName

                    Case "CF_COLKEY" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloColumna)
                    Case "CF_TITULO" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloRealColumna)
                    Case "CF_FORMAT" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloFormato)
                    Case "CF_VISTXT" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colVisibleEnGrillas)
                    Case Else : oCol.Visible = False

                End Select

            Next

            gwvFormatos.OptionsView.ColumnAutoWidth = True
            gwvFormatos.BestFitColumns()

        End With

        With GridResultados

            .DataSource = dsConsulta.Tables("RESULT")
            .RefreshDataSource()

            For Each oCol In gvwResultados.Columns
                Select Case oCol.FieldName

                    Case "CR_ORDEN" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloOrden)
                    Case "CR_NOMBRE" : oCol.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_colTituloNombre)
                    Case Else : oCol.Visible = False

                End Select

            Next

            gvwResultados.OptionsView.ColumnAutoWidth = True
            gvwResultados.BestFitColumns()

        End With

    End Sub

    Public Sub InicioGeneral()

        LocalizarFormulario()
        CrearTablasTemporales()
        IniciarOpciones()

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionDisenoConsulta) & ": " & DescripcionCadena(Cadenas.CDN_mnuConsultaCrear)

        tpGeneral.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_FichaGeneral)
        tpSQL.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_FichaSQL)
        tpParametros.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_FichaParametros)
        tpFormatos.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_FichaFormatos)
        tpResultados.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_FichaResultados)

        rpgComun.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_RibbonGroupComun)
        rpgSQL.Text = tpSQL.Text
        rpgParametros.Text = tpParametros.Text
        rpgFormatos.Text = tpFormatos.Text
        rpgResultados.Text = tpResultados.Text

        btnGuardar.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_BotonGuardar)
        btnCerrar.Caption = DescripcionCadena(Cadenas.CDN_GeneralCerrar)
        btnSQLInicialFinal.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_BotonInstruccionesSQL)
        btnSQLPrevioPosterior.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_BotonSQLPrevioPosterior)
        btnModoSplitter.Caption = DescripcionCadena(Cadenas.CDN_frmConsulta_OrientacionVertical)
        btnAsistenteSQL.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_BotonAsistenteSQL)

        btnAgregarParametro.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_Agregar)
        btnModificarParametro.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_Propiedades)
        btnEliminarParametro.Caption = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_Eliminar)
        btnAgregarFormato.Caption = btnAgregarParametro.Caption
        btnEliminarFormato.Caption = btnEliminarParametro.Caption
        btnAgregarResultados.Caption = btnAgregarParametro.Caption
        btnEliminarResultados.Caption = btnEliminarParametro.Caption

        lblNombreConsulta.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblNombre)
        lblDescripcion.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblDescripcion)
        lblCategoria.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblCategoria)
        lblConexion.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblConexion)
        chkPasswordProtected.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_chkPassword)
        chkPasswordDiseno.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_chkPasswordDiseno)
        grpOpciones.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_FrameOpciones)
        chkServerMode.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_chkModoServidor)
        chkNativoSQL.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_chkNativoSQL)
        chkEjecucionAsincrona.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_chkAsincrona)
        chkOpcionesDefault.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_chkOpcionesDefault)

        lblSimboloDecimal.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblSimboloDecimal)
        lblLiteralCadenas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblLiteralCadenas)
        lblLiteralFechas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblLiteralFechas)
        lblFormatoFechas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblFormatoFechas)

        spInicialFinal.Panel1.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_HeaderSQLInicial)
        btnSQLInicial.Caption = spInicialFinal.Panel1.Text
        spInicialFinal.Panel2.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_HeaderSQLFinal)
        btnSQLFinal.Caption = spInicialFinal.Panel2.Text
        spPrevioPosterior.Panel1.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_HeaderSQLPrevio)
        btnSQLPrevio.Caption = spPrevioPosterior.Panel1.Text
        spPrevioPosterior.Panel2.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_HeaderSQLPosterior)
        btnSQLPosterior.Caption = spPrevioPosterior.Panel2.Text

        ' Popup Menu

        mnuDeshacer.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuDeshacer)
        mnuRehacer.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuRehacer)
        mnuCopiar.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuCopiar)
        mnuCortar.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuCortar)
        mnuPegar.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuPegar)
        mnuEliminar.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuEliminar)
        mnuSeleccionarTodo.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuSeleccionarTodo)
        mnuBuscar.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuBuscar)
        mnuReemplazar.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuReemplazar)
        mnuInsertarVariable.Caption = DescripcionCadena(Cadenas.CDN_frmParametro_mnuInsertarVariable)

    End Sub

    Private Sub IniciarOpciones()

        MODO = "A"
        oAdmTablas.ConnectionString = CONN_LOCAL
        InhabilitarGroups()
        CargarTree()
        CargarConexiones()

        txtSimboloDecimal.Text = SIMBOLO_DECIMAL
        txtLiteralCadenas.Text = LITERAL_CADENAS
        txtLiteralFechas.Text = LITERAL_FECHAS
        txtFormatoFechas.Text = FORMATO_FECHAS

        btnModoSplitter.Down = (DESIGN_SPLIT = 1)
        AlternarModoSplit(DESIGN_SPLIT)

        cboCategoria.Tag = ""
        EstablecerVariableConexion()

    End Sub

    Private Sub txtSQLInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSQLInicial.KeyDown
        If e.Control And e.KeyCode = Keys.Space Then
            On Error Resume Next
            txtSQLInicial.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Private Sub txtSQLFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSQLFinal.KeyDown
        If e.Control And e.KeyCode = Keys.Space Then
            On Error Resume Next
            txtSQLFinal.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Private Sub txtSQLPrevio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSQLPrevio.KeyDown
        If e.Control And e.KeyCode = Keys.Space Then
            On Error Resume Next
            txtSQLPrevio.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Private Sub txtSQLPosterior_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSQLPosterior.KeyDown
        If e.Control And e.KeyCode = Keys.Space Then
            On Error Resume Next
            txtSQLPosterior.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Private Sub txtSQLInicial_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSQLInicial.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            popMenu.ShowPopup(Cursor.Position)
        End If
    End Sub

    Private Sub txtSQLFinal_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSQLFinal.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            popMenu.ShowPopup(Cursor.Position)
        End If
    End Sub

    Private Sub txtSQLPrevio_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSQLPrevio.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            popMenu.ShowPopup(Cursor.Position)
        End If
    End Sub

    Private Sub txtSQLPosterior_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSQLPosterior.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            popMenu.ShowPopup(Cursor.Position)
        End If
    End Sub

    Private Sub btnSQLPrevioPosterior_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSQLPrevioPosterior.ItemClick
        spInicialFinal.Visible = False
        spPrevioPosterior.Visible = True
        spPrevioPosterior.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
    End Sub

    Private Sub btnSQLInicialFinal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSQLInicialFinal.ItemClick
        spPrevioPosterior.Visible = False
        spInicialFinal.Visible = True
        spInicialFinal.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
    End Sub

    Private Sub Tabs_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles Tabs.SelectedPageChanged

        InhabilitarGroups()

        Select Case True
            Case e.Page Is tpSQL : HabilitarBotonesPageGroup(rpgSQL, True)
            Case e.Page Is tpParametros : HabilitarBotonesPageGroup(rpgParametros, True)
            Case e.Page Is tpFormatos : HabilitarBotonesPageGroup(rpgFormatos, True)
            Case e.Page Is tpResultados : HabilitarBotonesPageGroup(rpgResultados, True)
        End Select

    End Sub

    Private Sub HabilitarBotonesPageGroup(ByVal oPG As Ribbon.RibbonPageGroup, ByVal bHab As Boolean)

        Dim oBtn As BarButtonItemLink

        For Each oBtn In oPG.ItemLinks
            oBtn.Item.Enabled = bHab
        Next

    End Sub

    Private Sub InhabilitarGroups()
        HabilitarBotonesPageGroup(rpgSQL, False)
        HabilitarBotonesPageGroup(rpgParametros, False)
        HabilitarBotonesPageGroup(rpgFormatos, False)
        HabilitarBotonesPageGroup(rpgResultados, False)
    End Sub

    Private Sub CargarTree()

        On Error Resume Next

        Dim ds As System.Data.DataSet
        Dim sSQL As String
        Dim nodX As TreeNode
        Dim nodPadre As TreeNode
        Dim i As Int32

        ' CATEGORIAS
        sSQL = "SELECT      TG_CODCON, TG_DESCRI, TG_NUME01 " & _
               "FROM        TABGEN " & _
               "WHERE       TG_CODTAB = 3 " & _
               "AND         TG_CODCON <> 999999 " & _
               "ORDER BY    TG_NUME01, TG_DESCRI ASC "

        ds = oAdmTablas.AbrirDataset(sSQL)
        tvMain.Nodes.Clear()

        nodX = New TreeNode
        nodX.Name = "nodRaiz"
        nodX.Text = DescripcionCadena(Cadenas.CDN_nodRaizConsultas)
        nodX.ImageIndex = 0
        tvMain.Nodes.Add(nodX)

        With ds.Tables(0)
            For i = 0 To .Rows.Count - 1
                nodX = New TreeNode
                nodX.Name = "C" & .Rows(i).Item("TG_CODCON").ToString
                nodX.Text = .Rows(i).Item("TG_DESCRI").ToString
                nodX.ImageIndex = 1
                nodX.SelectedImageIndex = 1

                If .Rows(i).Item("TG_NUME01") = 0 Then
                    nodPadre = tvMain.Nodes("nodRaiz")
                Else
                    nodPadre = tvMain.Nodes.Find("C" & .Rows(i).Item("TG_NUME01").ToString, True)(0)
                End If

                nodPadre.Nodes.Add(nodX)

            Next
        End With

        tvMain.ExpandAll()

    End Sub


    Private Sub cboCategoria_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoria.EditValueChanged

    End Sub

    Private Sub cboCategoria_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCategoria.QueryCloseUp
        If tvMain.SelectedNode Is Nothing Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub cboCategoria_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles cboCategoria.QueryResultValue

        If tvMain.SelectedNode Is Nothing Then
            e.Value = ""
            cboCategoria.Tag = ""
        Else
            If tvMain.SelectedNode.Name = "nodRaiz" Then
                e.Value = ""
                cboCategoria.Tag = ""
            Else
                e.Value = tvMain.SelectedNode.Text
                cboCategoria.Tag = Val(tvMain.SelectedNode.Name.Substring(1))
            End If
        End If

    End Sub

    Private Sub tvMain_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMain.NodeMouseClick
        If e.Node.Name = "nodRaiz" Then
            cboCategoria.EditValue = ""
            cboCategoria.Tag = ""
        Else
            cboCategoria.EditValue = e.Node.Text
            cboCategoria.Tag = Val(e.Node.Name.Substring(1))
        End If
    End Sub

    Private Sub tvMain_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMain.NodeMouseDoubleClick
        cboCategoria.ClosePopup()
    End Sub

    Private Sub CargarConexiones()

        Dim sSQL As String
        Dim ds As DataSet
        Dim oItem As ImageComboBoxItem
        Dim oItemAux As ImageComboBoxItem
        Dim i As Integer

        sSQL = "SELECT  TG_CODCON, TG_DESCRI " & _
               "FROM    TABGEN " & _
               "WHERE   TG_CODTAB = 4 " & _
               "AND     TG_CODCON <> 999999 " & _
               "ORDER BY TG_CODCON"

        ds = oAdmTablas.AbrirDataset(sSQL)
        cboConexion.Properties.Items.Clear()

        With ds.Tables(0)
            For i = 0 To .Rows.Count - 1
                oItem = New ImageComboBoxItem
                oItem.Description = .Rows(i).Item("TG_DESCRI")
                oItem.Value = .Rows(i).Item("TG_CODCON")

                cboConexion.Properties.Items.Add(oItem)

                If i = 0 Then
                    oItemAux = oItem
                End If
            Next
        End With

        If Not oItemAux Is Nothing Then
            cboConexion.SelectedItem = oItemAux
        End If

        If USE_INTELLIPROMPT = 1 Then
            RefrescarIntelliprompt()
        End If

    End Sub

    Private Sub btnAgregarParametro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregarParametro.ItemClick

        VentanaParametro(0)

    End Sub

    Private Sub btnAgregarFormato_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregarFormato.ItemClick

        VentanaFormato("")

    End Sub

    Private Sub chkPasswordProtected_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPasswordProtected.CheckedChanged
        txtPassword.Enabled = chkPasswordProtected.Checked
        If chkPasswordProtected.Checked Then
            On Error Resume Next
            txtPassword.Focus()
        End If
    End Sub

    Private Sub chkOpcionesDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOpcionesDefault.CheckedChanged
        txtSimboloDecimal.Enabled = Not chkOpcionesDefault.Checked
        txtLiteralCadenas.Enabled = Not chkOpcionesDefault.Checked
        txtLiteralFechas.Enabled = Not chkOpcionesDefault.Checked
        txtFormatoFechas.Enabled = Not chkOpcionesDefault.Checked
        lblSimboloDecimal.Enabled = Not chkOpcionesDefault.Checked
        lblLiteralCadenas.Enabled = Not chkOpcionesDefault.Checked
        lblLiteralFechas.Enabled = Not chkOpcionesDefault.Checked
        lblFormatoFechas.Enabled = Not chkOpcionesDefault.Checked

        If Not chkOpcionesDefault.Checked Then
            On Error Resume Next
            txtSimboloDecimal.Focus()
        End If

    End Sub

    Private Sub chkNativoSQL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNativoSQL.CheckedChanged
        chkEjecucionAsincrona.Enabled = chkNativoSQL.Checked

        If Not chkNativoSQL.Checked Then
            chkEjecucionAsincrona.Checked = False
        End If

    End Sub

    Private Sub btnSQLInicial_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSQLInicial.ItemClick
        spPrevioPosterior.Visible = False
        spInicialFinal.Visible = True
        spInicialFinal.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
    End Sub

    Private Sub btnSQLFinal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSQLFinal.ItemClick
        spPrevioPosterior.Visible = False
        spInicialFinal.Visible = True
        spInicialFinal.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub btnSQLPrevio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSQLPrevio.ItemClick
        spInicialFinal.Visible = False
        spPrevioPosterior.Visible = True
        spPrevioPosterior.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
    End Sub

    Private Sub btnSQLPosterior_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSQLPosterior.ItemClick
        spInicialFinal.Visible = False
        spPrevioPosterior.Visible = True
        spPrevioPosterior.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
    End Sub

    Private Sub GridParametros_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridParametros.MouseDoubleClick

        Dim iRows() As Integer
        Dim iRow As Integer
        Dim nOrden As Integer

        iRows = gvwParametros.GetSelectedRows()

        If iRows.Length > 0 Then

            iRow = iRows(0)
            nOrden = gvwParametros.GetRow(iRow).Item("CD_ORDEN")
            VentanaParametro(nOrden)

        End If

    End Sub

    Private Sub GridFormatos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridFormatos.MouseDoubleClick

        Dim iRows() As Integer
        Dim iRow As Integer
        Dim sColKey As String

        iRows = gwvFormatos.GetSelectedRows()

        If iRows.Length > 0 Then

            iRow = iRows(0)
            sColKey = gwvFormatos.GetRow(iRow).Item("CF_COLKEY")
            VentanaFormato(sColKey)

        End If

    End Sub

    Private Sub GridResultados_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridResultados.MouseDoubleClick

        Dim iRows() As Integer
        Dim iRow As Integer
        Dim nOrden As Integer

        iRows = gvwResultados.GetSelectedRows()

        If iRows.Length > 0 Then

            iRow = iRows(0)
            nOrden = gvwResultados.GetRow(iRow).Item("CR_ORDEN")
            VentanaResultado(nOrden)

        End If

    End Sub

    Private Sub VentanaParametro(ByVal nOrden As Integer)

        Dim fParam As frmParametro
        Dim iItem As IntelliPromptMemberListItem
        Dim sSQLConsulta As String


        Cursor = Cursors.WaitCursor

        sSQLConsulta = txtSQLInicial.Text & vbCrLf & txtSQLFinal.Text

        fParam = New frmParametro(CONEXION_ACTUAL, TipoConexion, sSQLConsulta)

        fParam.IniciarOpciones()
        fParam.PasarDataset(dsConsulta, nOrden)

        If USE_INTELLIPROMPT Then

            fParam.txtSQL.IntelliPrompt.MemberList.ImageList = il16x16

            For Each iItem In txtSQLInicial.IntelliPrompt.MemberList
                fParam.txtSQL.IntelliPrompt.MemberList.Add(iItem)
            Next

        End If

        Cursor = Cursors.Default
        fParam.ShowDialog()

        RefrescarGrillas()


    End Sub

    Private Sub VentanaFormato(ByVal sColKey As String)

        Dim fFormat As frmFormato

        Cursor = Cursors.WaitCursor
        fFormat = New frmFormato

        fFormat.IniciarOpciones()
        fFormat.PasarDataset(dsConsulta, sColKey)
        Cursor = Cursors.Default
        fFormat.ShowDialog()

        RefrescarGrillas()


    End Sub

    Private Sub VentanaResultado(ByVal nOrden As Integer)

        Dim fResult As frmResultado

        Cursor = Cursors.WaitCursor
        fResult = New frmResultado

        fResult.IniciarOpciones()
        fResult.PasarDataset(dsConsulta, nOrden)
        Cursor = Cursors.Default
        fResult.ShowDialog()

        RefrescarGrillas()


    End Sub

    Private Sub btnModificarParametro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificarParametro.ItemClick

        Dim iRows() As Integer
        Dim iRow As Integer
        Dim nOrden As Integer

        iRows = gvwParametros.GetSelectedRows()

        If iRows.Length > 0 Then

            iRow = iRows(0)
            nOrden = gvwParametros.GetRow(iRow).Item("CD_ORDEN")
            VentanaParametro(nOrden)

        End If

    End Sub

    Private Sub btnEliminarParametro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarParametro.ItemClick

        Dim iRows() As Integer
        Dim iRow As Integer
        Dim nOrden As Integer

        iRows = gvwParametros.GetSelectedRows()

        If iRows.Length > 0 Then

            iRow = iRows(0)
            nOrden = gvwParametros.GetRow(iRow).Item("CD_ORDEN")

            If Pregunta(DescripcionCadena(Cadenas.CDN_frmParametro_WarningEliminarParametro)) = Windows.Forms.DialogResult.Yes Then
                EliminarParametro(nOrden)
            End If

        End If

    End Sub

    Private Sub btnEliminarFormato_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarFormato.ItemClick

        Dim iRows() As Integer
        Dim iRow As Integer
        Dim sColKey As String

        iRows = gwvFormatos.GetSelectedRows()

        If iRows.Length > 0 Then

            iRow = iRows(0)
            sColKey = gwvFormatos.GetRow(iRow).Item("CF_COLKEY")

            If Pregunta(DescripcionCadena(Cadenas.CDN_frmFormato_WarningEliminarFormato)) = Windows.Forms.DialogResult.Yes Then
                EliminarFormato(sColKey)
            End If

        End If

    End Sub

    Private Sub btnEliminarResultados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarResultados.ItemClick

        Dim iRows() As Integer
        Dim iRow As Integer
        Dim nOrden As Integer

        iRows = gvwResultados.GetSelectedRows()

        If iRows.Length > 0 Then

            iRow = iRows(0)
            nOrden = gvwResultados.GetRow(iRow).Item("CR_ORDEN")

            If Pregunta(DescripcionCadena(Cadenas.CDN_frmResultado_WarningEliminarResultado)) = Windows.Forms.DialogResult.Yes Then
                EliminarResultado(nOrden)
            End If

        End If

    End Sub


    Private Sub EliminarParametro(ByVal nOrden As Integer)

        'On Error Resume Next

        Dim oRow As DataRow

        For Each oRow In dsConsulta.Tables("PARAMS").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CD_ORDEN") = nOrden Then
                    oRow.Delete()
                    Exit For
                End If
            End If
        Next

        RefrescarGrillas()

    End Sub

    Private Sub EliminarFormato(ByVal sColKey As String)

        Dim oRow As DataRow

        For Each oRow In dsConsulta.Tables("FORMAT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CF_COLKEY") = sColKey Then
                    oRow.Delete()
                    Exit For
                End If
            End If
        Next

        RefrescarGrillas()

    End Sub

    Private Sub EliminarResultado(ByVal nOrden As Integer)

        Dim oRow As DataRow

        For Each oRow In dsConsulta.Tables("RESULT").Rows
            If oRow.RowState <> DataRowState.Deleted Then
                If oRow.Item("CR_ORDEN") = nOrden Then
                    oRow.Delete()
                    Exit For
                End If
            End If
        Next

        RefrescarGrillas()

    End Sub


    Private Sub btnCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Function DatosOK() As Boolean

        Dim nCantidad As Integer

        If MODO_DEMO And MODO = "A" Then
            nCantidad = frmMainX.CantidadConsultas()
            If nCantidad >= 3 Then
                MensajeError(DescripcionCadena(Cadenas.CDN_GeneralHasta3ConsultasModoDemo))
                Exit Function
            End If
        End If

        If txtNombreConsulta.Text.Trim = vbNullString Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_NombreVacio))
            txtNombreConsulta.Focus()
            Exit Function
        End If

        If cboCategoria.Tag.ToString = "" Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_SinCategoria))
            cboCategoria.Focus()
            Exit Function
        End If

        If cboConexion.EditValue = vbNullString Then
            Tabs.SelectedTabPage = tpGeneral
            MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_SinConexion))
            cboConexion.Focus()
            Exit Function
        End If

        If chkPasswordProtected.Checked Then
            If txtPassword.Text = vbNullString Then
                Tabs.SelectedTabPage = tpGeneral
                MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_SinPassword))
                txtPassword.Focus()
                Exit Function
            End If
        End If

        If chkPasswordDiseno.Checked Then
            If txtPasswordDiseno.Text = vbNullString Then
                Tabs.SelectedTabPage = tpGeneral
                MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_SinPassword))
                txtPasswordDiseno.Focus()
                Exit Function
            End If
        End If

        If txtSQLInicial.Text.Trim = vbNullString And _
           txtSQLFinal.Text.Trim = vbNullString Then
            Tabs.SelectedTabPage = tpSQL
            MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_SinSQLInicialNiFinal))
            Exit Function
        End If

        If MODO = "A" Then
            If NombreConsultaExiste(txtNombreConsulta.Text.Trim) Then
                If Pregunta(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_WarningNombreExiste).Replace("||", vbCrLf)) = Windows.Forms.DialogResult.No Then
                    Exit Function
                End If
            End If
        Else
            If txtNombreConsulta.Text.Trim <> oConsultaAbierta.Nombre.Trim Then
                If NombreConsultaExiste(txtNombreConsulta.Text.Trim) Then
                    If Pregunta(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_WarningNombreExiste).Replace("||", vbCrLf)) = Windows.Forms.DialogResult.No Then
                        Exit Function
                    End If
                End If
            End If
        End If

        If dsConsulta.Tables("PARAMS").Rows.Count <= 0 Then
            If Pregunta(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_WarningSinParametros)) = Windows.Forms.DialogResult.No Then
                Exit Function
            End If
        End If

        DatosOK = True

    End Function

    Private Function NombreConsultaExiste(ByVal sNombre As String) As Boolean

        Dim sSQL As String
        Dim ds As DataSet
        Dim bResult As Boolean

        Try

            sSQL = "SELECT  COUNT(1) AS TOTAL " & _
                   "FROM    CONVAR " & _
                   "WHERE   CV_NOMBRE = " & CadenaSQL(sNombre, LITERAL_CADENAS)

            ds = oAdmTablas.AbrirDataset(sSQL)
            bResult = (ds.Tables(0).Rows(0)("TOTAL") > 0)
            ds = Nothing

            Return bResult

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Function

    Private Sub btnGuardar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick

        If DatosOK() Then

            ' Guardar '
            Guardar()

        End If

    End Sub

    Private Sub Guardar()

        Dim sSQL As String
        Dim ds As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim cb As OleDb.OleDbCommandBuilder
        Dim oRow As DataRow
        Dim oRowTemp As DataRow
        Dim oField As DataColumn
        Dim nCodConsulta As Long

        Try

            Cursor = Cursors.WaitCursor

            If MODO = "A" Then
                nCodConsulta = oAdmTablas.ProximoID("CONVAR", "CV_CODCON")
            Else
                nCodConsulta = oConsultaAbierta.Codigo
            End If

            sSQL = "SELECT  * " & _
                   "FROM    CONVAR " & _
                   "WHERE   CV_CODCON = " & nCodConsulta & " "

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            ''''' TRATAMIENTO TABLA CONVAR '''''

            With ds.Tables(0)

                If MODO = "A" Then
                    oRow = .NewRow
                    oRow("CV_CODCON") = nCodConsulta
                Else
                    oRow = .Rows(0)
                    oRow.BeginEdit()
                End If

                ' Iniciar edicion Campo a Campo '
                oRow("CV_NOMBRE") = txtNombreConsulta.Text.Trim
                oRow("CV_DESCRI") = txtDescripcion.Text.Trim
                oRow("CV_CATEGO") = Val(cboCategoria.Tag)
                oRow("CV_SQLPRE") = txtSQLPrevio.Text.Trim
                oRow("CV_SQLINI") = txtSQLInicial.Text.Trim
                oRow("CV_SQLFIN") = txtSQLFinal.Text.Trim
                oRow("CV_SQLPOS") = txtSQLPosterior.Text.Trim
                oRow("CV_CODCAD") = cboConexion.EditValue
                oRow("CV_PASSPR") = IIf(chkPasswordProtected.Checked, 1, 0)
                oRow("CV_PASSWD") = IIf(chkPasswordProtected.Checked, cEncrypt.EncryptString128Bit(txtPassword.Text), "")
                oRow("CV_PASSDS") = IIf(chkPasswordDiseno.Checked, 1, 0)
                oRow("CV_PASSDG") = IIf(chkPasswordDiseno.Checked, cEncrypt.EncryptString128Bit(txtPasswordDiseno.Text), "")
                oRow("CV_OPTDEF") = IIf(chkOpcionesDefault.Checked, 1, 0)
                oRow("CV_SIMDEC") = txtSimboloDecimal.Text.Trim
                oRow("CV_LITSTR") = txtLiteralCadenas.Text.Trim
                oRow("CV_LITFEC") = txtLiteralFechas.Text.Trim
                oRow("CV_FORFEC") = txtFormatoFechas.Text.Trim
                oRow("CV_SERVER") = IIf(chkServerMode.Checked, 1, 0)
                oRow("CV_NATSQL") = IIf(chkNativoSQL.Checked, 1, 0)
                oRow("CV_ASYNCH") = IIf(chkEjecucionAsincrona.Checked, 1, 0)
                ' Fin edicion Campo a Campo '

                If MODO = "A" Then
                    .Rows.Add(oRow)
                Else
                    oRow.EndEdit()
                End If

            End With

            da.Update(ds)
            ds.AcceptChanges()

            ''''' BORRAR LAS 3 TABLAS ANTES ''''

            sSQL = "DELETE " & _
                   "FROM    CONDET " & _
                   "WHERE   CD_CODCON = " & nCodConsulta

            oAdmTablas.EjecutarComandoSQL(sSQL)

            sSQL = "DELETE " & _
                   "FROM    CONFOR " & _
                   "WHERE   CF_CODCON = " & nCodConsulta

            oAdmTablas.EjecutarComandoSQL(sSQL)

            sSQL = "DELETE " & _
                   "FROM    CONRES " & _
                   "WHERE   CR_CODCON = " & nCodConsulta

            oAdmTablas.EjecutarComandoSQL(sSQL)

            ''''' TRATAMIENTO TABLA CONDET '''''

            sSQL = "SELECT  * " & _
                   "FROM    CONDET " & _
                   "WHERE   CD_CODCON = " & nCodConsulta & " "

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

                For Each oRowTemp In dsConsulta.Tables("PARAMS").Rows
                    If oRowTemp.RowState <> DataRowState.Deleted Then
                        oRow = .NewRow
                        oRow("CD_CODCON") = nCodConsulta
                        For Each oField In .Columns
                            If oField.ColumnName <> "CD_CODCON" Then
                                oRow(oField.ColumnName) = oRowTemp(oField.ColumnName)
                            End If
                        Next
                        .Rows.Add(oRow)
                    End If
                Next

            End With

            da.Update(ds)
            ds.AcceptChanges()

            ''''' TRATAMIENTO TABLA CONFOR '''''

            sSQL = "SELECT  * " & _
                   "FROM    CONFOR " & _
                   "WHERE   CF_CODCON = " & nCodConsulta & " "

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

                For Each oRowTemp In dsConsulta.Tables("FORMAT").Rows
                    If oRowTemp.RowState <> DataRowState.Deleted Then
                        oRow = .NewRow
                        oRow("CF_CODCON") = nCodConsulta
                        For Each oField In .Columns
                            If oField.ColumnName <> "CF_CODCON" Then
                                oRow(oField.ColumnName) = oRowTemp(oField.ColumnName)
                            End If
                        Next
                        .Rows.Add(oRow)
                    End If
                Next

            End With

            da.Update(ds)
            ds.AcceptChanges()

            ''''' TRATAMIENTO TABLA CONRES '''''

            sSQL = "SELECT  * " & _
                   "FROM    CONRES " & _
                   "WHERE   CR_CODCON = " & nCodConsulta & " "

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

                For Each oRowTemp In dsConsulta.Tables("RESULT").Rows
                    If oRowTemp.RowState <> DataRowState.Deleted Then
                        oRow = .NewRow
                        oRow("CR_CODCON") = nCodConsulta
                        For Each oField In .Columns
                            If oField.ColumnName <> "CR_CODCON" Then
                                oRow(oField.ColumnName) = oRowTemp(oField.ColumnName)
                            End If
                        Next
                        .Rows.Add(oRow)
                    End If
                Next

            End With

            da.Update(ds)
            ds.AcceptChanges()

            If MODO = "A" Then
                AbrirConsulta(nCodConsulta)
            End If

            frmMainX.CargarTree()
            Cursor = Cursors.Default

        Catch ex As Exception

            TratarError(ex)

        End Try

    End Sub

    Private Sub btnAgregarResultados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregarResultados.ItemClick
        VentanaResultado(0)
    End Sub

    Private Function TextoSQLActivo() As ActiproSoftware.SyntaxEditor.SyntaxEditor
        Return Me.ActiveControl
    End Function

    Private Sub mnuDeshacer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDeshacer.ItemClick

        With TextoSQLActivo()
            .Document.UndoRedo.Undo()
        End With

    End Sub

    Private Sub mnuRehacer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuRehacer.ItemClick
        With TextoSQLActivo()
            .Document.UndoRedo.Redo()
        End With
    End Sub


    Private Sub mnuCopiar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCopiar.ItemClick
        With TextoSQLActivo()
            .SelectedView.CopyToClipboard()
        End With
    End Sub

    Private Sub mnuCortar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCortar.ItemClick
        With TextoSQLActivo()
            .SelectedView.CutToClipboard()
        End With
    End Sub

    Private Sub mnuPegar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPegar.ItemClick
        With TextoSQLActivo()
            .SelectedView.PasteFromClipboard()
        End With
    End Sub

    Private Sub mnuEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick
        With TextoSQLActivo()
            .SelectedView.Delete()
        End With
    End Sub

    Private Sub mnuSeleccionarTodo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSeleccionarTodo.ItemClick
        With TextoSQLActivo()
            .SelectedView.Selection.SelectAll()
        End With
    End Sub


    Private Sub btnModoSplitter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModoSplitter.ItemClick

        If btnModoSplitter.Down Then
            DESIGN_SPLIT = 1
        Else
            DESIGN_SPLIT = 2
        End If

        AlternarModoSplit(DESIGN_SPLIT)
        GuardarOpcionUsuario("DESIGN_SPLIT", DESIGN_SPLIT)

    End Sub

    Private Sub AlternarModoSplit(ByVal nModo As Integer)
        If nModo = 1 Then
            spInicialFinal.Horizontal = True
            spPrevioPosterior.Horizontal = True
        Else
            spInicialFinal.Horizontal = False
            spPrevioPosterior.Horizontal = False
        End If
    End Sub

    Private Sub mnuBuscar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuBuscar.ItemClick

        Dim oEditor As ActiproSoftware.SyntaxEditor.SyntaxEditor = TextoSQLActivo()

        Dim fFindReplace As New frmBuscarReemplazar(oEditor, oOptions)
        fFindReplace.SoloBuscar()
        fFindReplace.ShowDialog()

    End Sub

    
    Private Sub mnuReemplazar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuReemplazar.ItemClick

        Dim oEditor As ActiproSoftware.SyntaxEditor.SyntaxEditor = TextoSQLActivo()

        Dim fFindReplace As New frmBuscarReemplazar(oEditor, oOptions)
        fFindReplace.ShowDialog()

    End Sub

    Private Sub RefrescarIntelliprompt()

        Dim sSQL As String
        Dim ds As DataSet
        Dim sConnString As String
        Dim oConn As OleDb.OleDbConnection
        Dim sqlConn As SqlClient.SqlConnection
        Dim oTable As DataTable
        Dim oRow As DataRow

        Dim dsDesc As DataSet
        Dim oTableDesc As DataTable
        Dim oRowDesc As DataRow
        Dim oRowDescs() As DataRow

        Dim bDummy01 As Boolean
        Dim sSchema As String

        Try

            Cursor = Cursors.AppStarting

            sSQL = "SELECT  DD_TIPOBJ, DD_NOMOBJ, DD_DESCRI, DD_COMENT " & _
                   "FROM    DICDAT " & _
                   "WHERE   DD_CODCON = " & cboConexion.EditValue

            dsDesc = oAdmTablas.AbrirDataset(sSQL)
            oTableDesc = dsDesc.Tables(0)

            txtSQLInicial.IntelliPrompt.MemberList.Clear()
            txtSQLFinal.IntelliPrompt.MemberList.Clear()
            txtSQLPrevio.IntelliPrompt.MemberList.Clear()
            txtSQLPosterior.IntelliPrompt.MemberList.Clear()
            txtSQLInicial.IntelliPrompt.MemberList.ImageList = il16x16
            txtSQLFinal.IntelliPrompt.MemberList.ImageList = il16x16
            txtSQLPosterior.IntelliPrompt.MemberList.ImageList = il16x16
            txtSQLPrevio.IntelliPrompt.MemberList.ImageList = il16x16

            AgregarPalabrasSQL(txtSQLInicial.IntelliPrompt.MemberList)
            AgregarPalabrasSQL(txtSQLFinal.IntelliPrompt.MemberList)
            AgregarPalabrasSQL(txtSQLPrevio.IntelliPrompt.MemberList)
            AgregarPalabrasSQL(txtSQLPosterior.IntelliPrompt.MemberList)

            sSchema = "TABLES"

            sSQL = "SELECT  TG_ALFA01 " & _
                   "FROM    TABGEN " & _
                   "WHERE   TG_CODTAB = 4 " & _
                   "AND     TG_CODCON = " & cboConexion.EditValue

            ds = oAdmTablas.AbrirDataset(sSQL)

            If ds.Tables(0).Rows.Count > 0 Then

                sConnString = cEncrypt.DecryptString128Bit(ds.Tables(0).Rows(0)(0))

Restart:

                bDummy01 = True

                sqlConn = New SqlClient.SqlConnection(sConnString)
                sqlConn.Open()

                If Err.Number = 0 Then

                    oTable = sqlConn.GetSchema(sSchema)

                Else

OtroIntento:
                    Err.Clear()
                    bDummy01 = False
                    oConn = New OleDb.OleDbConnection(sConnString)
                    oConn.Open()
                    oTable = oConn.GetSchema()

                End If

                bDummy01 = False
                Dim iItem As IntelliPromptMemberListItem

                For Each oRow In oTable.Rows

                    Application.DoEvents()

                    If sSchema = "TABLES" Then
                        iItem = New IntelliPromptMemberListItem(oRow("TABLE_NAME"), 4)
                        oRowDescs = oTableDesc.Select("DD_NOMOBJ='" & oRow("TABLE_NAME") & "' AND DD_TIPOBJ = 'T'")

                    ElseIf sSchema = "VIEWS" Then
                        iItem = New IntelliPromptMemberListItem(oRow("TABLE_NAME"), 5)
                        oRowDescs = oTableDesc.Select("DD_NOMOBJ='" & oRow("TABLE_NAME") & "' AND DD_TIPOBJ = 'V'")

                    ElseIf sSchema = "COLUMNS" Then
                        iItem = New IntelliPromptMemberListItem(oRow("COLUMN_NAME"), 6)
                        oRowDescs = oTableDesc.Select("DD_NOMOBJ='" & oRow("COLUMN_NAME") & "' AND DD_TIPOBJ = 'C'")

                    ElseIf sSchema = "PROCEDURES" Then
                        iItem = New IntelliPromptMemberListItem(oRow("ROUTINE_NAME"), 7)
                        oRowDescs = oTableDesc.Select("DD_NOMOBJ='" & oRow("ROUTINE_NAME") & "' AND DD_TIPOBJ = 'P'")

                    End If

            If oRowDescs.Length > 0 Then
                        iItem.Description = oRowDescs(0)("DD_DESCRI") & vbCr & vbLf & vbCrLf & vbCrLf & oRowDescs(0)("DD_COMENT")
            End If

            txtSQLInicial.IntelliPrompt.MemberList.Add(iItem)
            txtSQLFinal.IntelliPrompt.MemberList.Add(iItem)
            txtSQLPrevio.IntelliPrompt.MemberList.Add(iItem)
            txtSQLPosterior.IntelliPrompt.MemberList.Add(iItem)

                Next

                If sSchema = "TABLES" Then
                    sSchema = "VIEWS"
                    GoTo Restart
                ElseIf sSchema = "VIEWS" Then
                    sSchema = "COLUMNS"
                    GoTo Restart
                ElseIf sSchema = "COLUMNS" Then
                    sSchema = "PROCEDURES"
                    GoTo Restart
                End If

            End If

            Cursor = Cursors.Default

        Catch ex As Exception

            Cursor = Cursors.Default

            If bDummy01 Then
                GoTo OtroIntento
            Else

                oTable = Nothing
                oConn = Nothing
                sqlConn = Nothing

            End If

        End Try

    End Sub

    Public Sub AgregarPalabrasSQL(ByRef oMemberList As IntelliPromptMemberList)

        Dim sPalabras As String
        Dim sPal() As String
        Dim iItem As IntelliPromptMemberListItem
        Dim i As Integer

        sPalabras = "ADD,ALTER,AS,ASC,AUTHORIZATION,BACKUP,BEGIN,BREAK,BROWSE,BULK,BY,CASCADE,CHECK,CHECKPOINT,CLOSE,CLUSTERED," & _
                    "COLUMN,COMMIT,COMMITTED,COMPUTE,CONFIRM,CONSTRAINT,CONTAINS,CONTINUE,CONTROLROW,CREATE,CROSS,CURRENT,CURRENT_DATE," & _
                    "CURRENT_TIME,CURSOR,DATABASE,DBCC,DEALLOCATE,DECLARE,DEFAULT,DELETE,DENY,DESC,DISK,DISTINCT,DISTRIBUTED," & _
                    "DROP,DUMMY,DUMP,ELSE,END,ERRLVL,ERROREXIT,ESCAPE,EXCEPT,EXEC,EXECUTE,EXIT,FETCH,FILE,FILLFACTOR,FLOPPY," & _
                    "FOR,FOREIGN,FREETEXT,FROM,FULL,FUNCTION,GO,GOTO,GRANT,GROUP,HAVING,HOLDLOCK,IDENTITY_INSERT,IDENTITYCOL,IF,INDEX," & _
                    "INNER,INSERT,INTERSECT,INTO,IS,ISOLATION,KEY,KILL,LEVEL,LINENO,LOAD,MIRROREXIT,NEXT,NOCHECK,NONCLUSTERED," & _
                    "NULL,OF,OFF,OFFSETS,ON,ONCE,ONLY,OPEN,OPENDATASOURCE,OPTION,ORDER,OVER,PERCENT,PERM,PERMANENT,PIPE," & _
                    "PLAN,PREPARE,PRIMARY,PRINT,PRIVILEGES,PROC,PROCEDURE,PROCESSEXIT,PUBLIC,RAISERROR,READ,READTEXT,RECONFIGURE," & _
                    "REFERENCES,REPEATABLE,REPLICATION,RESTORE,RESTRICT,RETURNS,RETURN,REVOKE,ROLLBACK,ROWCOUNT,ROWGUIDCOL,RULE,SAVE,SCHEMA," & _
                    "SELECT,SERIALIZABLE,SET,SETUSER,SHUTDOWN,STATISTICS,TABLE,TAPE,TEMP,TEMPORARY,TEXTSIZE,THEN,TO,TOP,TRAN," & _
                    "TRANSACTION,TRIGGER,TRUNCATE,TSEQUAL,UNCOMMITTED,UNION,UNIQUE,UPDATE,UPDATETEXT,USE,VALUES,VIEW,WAITFOR," & _
                    "WHEN,WHERE,WHILE,WITH,WORK,WRITETEXT"

        sPal = Split(sPalabras, ",")
        For i = 0 To sPal.Length - 1
            iItem = New IntelliPromptMemberListItem(sPal(i), 8)
            oMemberList.Add(iItem)
        Next

        sPalabras = "ABS,ACOS,APP_NAME,ASCII,ASIN,ATAN,ATN2,AVG,CASE,CAST,CEILING,CHARINDEX,COALESCE,COL_LENGTH," & _
            "COL_NAME,COLUMNPROPERTY,CONTAINSTABLE,CONVERT,COS,COT,COUNT,CURRENT_TIMESTAMP,CURRENT_USER,CURSOR_STATUS," & _
            "DATABASEPROPERTY,DATALENGTH,DATEADD,DATEDIFF,DATENAME,DATEPART,DAY,DB_ID,DB_NAME,DEGREES,DIFFERENCE," & _
            "EXP,FILE_ID,FILE_NAME,FILEGROUP_ID,FILEGROUP_NAME,FILEGROUPPROPERTY,FILEPROPERTY,FLOOR,FORMATMESSAGE," & _
            "FREETEXTTABLE,FULLTEXTCATALOGPROPERTY,FULLTEXTSERVICEPROPERTY,GETANSINULL,GETDATE,GROUPING,HOST_ID," & _
            "HOST_NAME,IDENT_INCR,IDENT_SEED,IDENTITY,INDEX_COL,INDEXPROPERTY,IS_MEMBER,IS_SRVROLEMEMBER,ISDATE," & _
            "ISNULL,ISNUMERIC,LEN,LOG,LOG10,LOWER,LTRIM,MAX,MIN,MONTH,NEWID,NULLIF,OBJECT_ID,OBJECT_NAME," & _
            "OBJECTPROPERTY,OPENQUERY,OPENROWSET,PARSENAME,PATINDEX,PERMISSIONS,PI,POWER,QUOTENAME,RADIANS,RAND," & _
            "REPLACE,REPLICATE,REVERSE,ROUND,RTRIM,SCOPE_IDENTITY,SESSION_USER,SIGN,SIN,SOUNDEX,SPACE,SQRT,SQUARE,STATS_DATE," & _
            "STDEV,STDEVP,STR,STUFF,SUBSTRING,SUM,SUSER_ID,SUSER_NAME,SUSER_SID,SUSER_SNAME,SYSTEM_USER,TAN," & _
            "TEXTPTR,TEXTVALID,TYPEPROPERTY,UNICODE,UPPER,USER,USER_ID,USER_NAME,VAR,VARP,YEAR"

        sPal = Split(sPalabras, ",")
        For i = 0 To sPal.Length - 1
            iItem = New IntelliPromptMemberListItem(sPal(i), 9)
            oMemberList.Add(iItem)
        Next

        sPalabras = "ALL,AND,ANY,BETWEEN,EXISTS,IN,LEFT,JOIN,LIKE,NOT,OR,OUTER,RIGHT,SOME"

        sPal = Split(sPalabras, ",")
        For i = 0 To sPal.Length - 1
            iItem = New IntelliPromptMemberListItem(sPal(i), 10)
            oMemberList.Add(iItem)
        Next

        sPalabras = "bigint,binary,bit,char,character,datetime,dec,decimal,double,float,int,integer,image,long,money,national,nchar,ntext," & _
                    "number,nvarchar,precision,raw,real,single,smalldatetime,smallint,smallmoney,text,timestamp,tinyint," & _
                    "uniqueidentifier,varbinary,varchar,varchar2,varying"

        sPal = Split(sPalabras, ",")
        For i = 0 To sPal.Length - 1
            iItem = New IntelliPromptMemberListItem(sPal(i), 11)
            oMemberList.Add(iItem)
        Next


    End Sub

    Private Sub cboConexion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConexion.SelectedIndexChanged

        If USE_INTELLIPROMPT = 1 Then
            RefrescarIntelliprompt()
        End If

        EstablecerVariableConexion()

    End Sub

    Public Sub EstablecerVariableConexion()

        On Error Resume Next

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = "SELECT  TG_ALFA01 " & _
               "FROM    TABGEN " & _
               "WHERE   TG_CODTAB = 4 " & _
               "AND     TG_CODCON = " & cboConexion.EditValue

        ds = oAdmTablas.AbrirDataset(sSQL)

        If ds.Tables(0).Rows.Count > 0 Then

            CONEXION_ACTUAL = cEncrypt.DecryptString128Bit(ds.Tables(0).Rows(0)(0))

        End If
    End Sub

    Private Sub txtSQLInicial_TriggerActivated(ByVal sender As Object, ByVal e As ActiproSoftware.SyntaxEditor.TriggerEventArgs) Handles txtSQLInicial.TriggerActivated
        If txtSQLInicial.IntelliPrompt.MemberList.Count > 0 Then
            txtSQLInicial.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Private Sub txtSQLFinal_TriggerActivated(ByVal sender As Object, ByVal e As ActiproSoftware.SyntaxEditor.TriggerEventArgs) Handles txtSQLFinal.TriggerActivated
        If txtSQLFinal.IntelliPrompt.MemberList.Count > 0 Then
            txtSQLFinal.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Private Sub txtSQLPrevio_TriggerActivated(ByVal sender As Object, ByVal e As ActiproSoftware.SyntaxEditor.TriggerEventArgs) Handles txtSQLPrevio.TriggerActivated
        If txtSQLPrevio.IntelliPrompt.MemberList.Count > 0 Then
            txtSQLPrevio.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Private Sub txtSQLPosterior_TriggerActivated(ByVal sender As Object, ByVal e As ActiproSoftware.SyntaxEditor.TriggerEventArgs) Handles txtSQLPosterior.TriggerActivated
        If txtSQLPosterior.IntelliPrompt.MemberList.Count > 0 Then
            txtSQLPosterior.IntelliPrompt.MemberList.Show()
        End If
    End Sub

    Private Sub btnAsistenteSQL_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAsistenteSQL.ItemClick


        Dim nTipoCon = TipoConexion()
        Dim fWizard As New frmSQLWizard(CONEXION_ACTUAL, nTipoCon)

        fWizard.txtSQL.Text = txtSQLInicial.Text & vbCrLf & vbCrLf & txtSQLFinal.Text

        Try

            fWizard.qbMain.SyncSQL = fWizard.txtSQL.Text

        Catch ex As Exception
            '''' tratar el error de parseo ''''
        End Try

        Try
            fWizard.ShowDialog()
        Catch ex As Exception
            TratarError(ex)
        End Try


        If SQL_ASISTENTE <> "" Then
            DescomponerSQL()
        End If

    End Sub

    Public Function TipoConexion() As Long

        Dim nTipoCon As Long
        Dim sSQL As String
        Dim ds As DataSet

        sSQL = "SELECT  TG_NUME01 " & _
               "FROM    TABGEN " & _
               "WHERE   TG_CODTAB = 4 " & _
               "AND     TG_CODCON = " & cboConexion.EditValue

        ds = oAdmTablas.AbrirDataset(sSQL)
        nTipoCon = ds.Tables(0).Rows(0)("TG_NUME01")
        ds.Dispose()
        Return nTipoCon

    End Function
    Private Sub DescomponerSQL()

        On Error Resume Next

        Dim nPosGroupBy As Integer
        Dim nPosOrderBy As Integer
        Dim sParte1 As String = ""
        Dim sParte2 As String = ""
        Dim nPosWhere As Integer

        If SQL_ASISTENTE.Length > 0 Then

            nPosGroupBy = InStrRev(UCase(SQL_ASISTENTE), "GROUP BY")
            nPosOrderBy = InStrRev(UCase(SQL_ASISTENTE), "ORDER BY")

            If nPosGroupBy > 0 Then
                sParte1 = Mid(SQL_ASISTENTE, 1, nPosGroupBy - 1)
                sParte2 = Mid(SQL_ASISTENTE, nPosGroupBy)
            Else
                If nPosOrderBy > 0 Then
                    sParte1 = Mid(SQL_ASISTENTE, 1, nPosOrderBy - 1)
                    sParte2 = Mid(SQL_ASISTENTE, nPosOrderBy)
                Else
                    sParte1 = SQL_ASISTENTE
                    sParte2 = ""
                End If
            End If

            If sParte1.Length > 0 Then

                nPosWhere = InStrRev(UCase(SQL_ASISTENTE), "WHERE")

                If nPosWhere = 0 Then
                    sParte1 = sParte1 & vbCrLf & "WHERE 1 = 1 " & vbCrLf
                End If

                txtSQLInicial.Text = sParte1
                txtSQLFinal.Text = sParte2

            End If

        End If

    End Sub

    Private Sub mnuInsertarVariable_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuInsertarVariable.ItemClick

        Dim fVars As New frmVariables

        fVars.ShowDialog()
        fVars.Dispose()

        If VARIABLE_SELECCIONADA <> "" Then
            With TextoSQLActivo()
                .SelectedView.SelectedText = VARIABLE_SELECCIONADA
            End With
        End If

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        txtSQLPrevio.Enabled = EDICION_SQL_HABILITADA
        txtSQLInicial.Enabled = EDICION_SQL_HABILITADA
        txtSQLFinal.Enabled = EDICION_SQL_HABILITADA
        txtSQLPosterior.Enabled = EDICION_SQL_HABILITADA

    End Sub

    Private Sub chkPasswordDiseno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPasswordDiseno.CheckedChanged
        txtPasswordDiseno.Enabled = chkPasswordDiseno.Checked
        If chkPasswordDiseno.Checked Then
            On Error Resume Next
            txtPasswordDiseno.Focus()
        End If
    End Sub
End Class
