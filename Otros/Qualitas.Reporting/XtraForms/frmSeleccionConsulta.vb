Public Class frmSeleccionConsulta

    Private oAdmTablas As New AdmTablas
    Private sLastSQLBusqueda As String

    Private Sub frmSeleccionConsulta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        On Error Resume Next
        Cursor = Cursors.Default
        txtBusqueda.Focus()
    End Sub

    Private Sub frmSeleccionConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CONSULTA_SELECCIONADA = 0
        oAdmTablas.ConnectionString = CONN_LOCAL
        LocalizarFormulario()
        CargarTree()

    End Sub

    Private Sub CargarTree()

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
        tvMain.SelectedNode = tvMain.Nodes("nodRaiz")

    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub LocalizarFormulario()
        ' Otros
        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionSeleccionConsulta)
        lblSeleccionarConsulta.Text = DescripcionCadena(Cadenas.CDN_frmSeleccionConsulta_lblSeleccionarConsulta)
        lblTip.Text = DescripcionCadena(Cadenas.CDN_frmSeleccionConsulta_lblTip)
        tvMain.Nodes("nodRaiz").Text = DescripcionCadena(Cadenas.CDN_nodRaizConsultas)
        tvMain.Nodes("nodBusqueda").Text = DescripcionCadena(Cadenas.CDN_nodRaizResultadosBusqueda)
        chkCategorias.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionCategorias)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub tvMain_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterCollapse
        If e.Node.Name.Substring(0, 1) = "C" Then
            e.Node.ImageIndex = 2
            e.Node.SelectedImageIndex = 2
        End If
    End Sub

    Private Sub tvMain_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterExpand
        If e.Node.Name.Substring(0, 1) = "C" Then
            e.Node.ImageIndex = 1
            e.Node.SelectedImageIndex = 1
        End If
    End Sub

    Private Sub tvMain_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMain.AfterSelect
        AnalizarNodo(e.Node)
    End Sub

    Private Sub RefreshView(ByVal bEsBusqueda As Boolean, _
                            Optional ByVal nCodCategoria As Integer = 0, _
                            Optional ByVal sCriterioBusqueda As String = vbNullString, _
                            Optional ByVal sCustomSQL As String = vbNullString)

        Dim sSQL As String
        Dim ds As New DataSet

        If sCustomSQL <> vbNullString Then
            sSQL = sCustomSQL
        Else
            If bEsBusqueda Then
                sSQL = "SELECT      0 AS XX_GLYPH, CV_CODCON, CV_NOMBRE, CV_DESCRI, TG_DESCRI " & _
                       "FROM        CONVAR " & _
                       "LEFT  JOIN  TABGEN " & _
                       "ON          CV_CATEGO = TG_CODCON " & _
                       "AND         TG_CODTAB = 3 " & _
                       "WHERE       CV_NOMBRE LIKE '%" & sCriterioBusqueda & "%' " & _
                       "OR          CV_DESCRI LIKE '%" & sCriterioBusqueda & "%' " & _
                       "ORDER BY    CV_NOMBRE ASC"

                sLastSQLBusqueda = sSQL

            Else
                sSQL = "SELECT      0 AS XX_GLYPH, CV_CODCON, CV_NOMBRE, CV_DESCRI " & _
                       "FROM        CONVAR " & _
                       "WHERE       CV_CATEGO = " & nCodCategoria & " " & _
                       "ORDER BY    CV_NOMBRE ASC"
            End If
        End If

        ds = oAdmTablas.AbrirDataset(sSQL)

        With gvwResultados

            Cursor = Cursors.AppStarting

            GridResultados.DataSource = ds.Tables(0)

            .Columns("CV_CODCON").Visible = False
            .Columns("CV_DESCRI").Visible = False

            If Not .Columns("TG_DESCRI") Is Nothing Then
                .Columns("TG_DESCRI").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            End If

            .Columns("XX_GLYPH").ColumnEdit = cboImages
            .Columns("XX_GLYPH").Width = 16

            .PreviewFieldName = "CV_DESCRI"
            .OptionsView.ShowHorzLines = False
            .OptionsView.ShowVertLines = False

            Cursor = Cursors.Default

        End With

    End Sub


    Private Sub tvMain_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvMain.NodeMouseClick
        AnalizarNodo(e.Node)
    End Sub

    Private Sub AnalizarNodo(ByVal oNode As TreeNode)
        If oNode.Name.Substring(0, 1) = "C" Then
            RefreshView(False, Val(oNode.Name.Substring(1)))
        ElseIf oNode.Name = "nodBusqueda" Then
            If sLastSQLBusqueda <> vbNullString Then
                RefreshView(False, , , sLastSQLBusqueda)
            End If
        End If
    End Sub
    Private Sub txtBusqueda_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.EditValueChanged
        If txtBusqueda.Text.Trim <> vbNullString Then
            tvMain.SelectedNode = tvMain.Nodes("nodBusqueda")
            RefreshView(True, , txtBusqueda.Text.Trim)
        End If
    End Sub

    Private Sub GridResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridResultados.Click

    End Sub

    Private Sub GridResultados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridResultados.KeyDown
        If e.KeyCode = Keys.Return Then
            cmdAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub GridResultados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridResultados.DoubleClick
        If cmdAceptar.Enabled Then
            cmdAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim nRet As Integer
        Dim oRow As DataRow
        nRet = 0

        oRow = gvwResultados.GetDataRow(gvwResultados.FocusedRowHandle)

        If Not oRow Is Nothing Then

            nRet = oRow.Item("CV_CODCON")

            CONSULTA_SELECCIONADA = nRet
            Me.Close()

        End If

    End Sub

    Private Sub txtBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Return Then
            cmdAceptar_Click(sender, e)
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            gvwResultados.MoveNext()
            e.Handled = False
        ElseIf e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
            gvwResultados.MovePrev()
            e.Handled = False
        End If
    End Sub


    Private Sub chkCategorias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCategorias.CheckedChanged
        If chkCategorias.Checked Then
            oSplitter.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        Else
            oSplitter.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        End If
    End Sub

End Class