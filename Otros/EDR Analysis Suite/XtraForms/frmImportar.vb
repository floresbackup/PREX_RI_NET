Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Controls

Public Class frmImportar

    Private oAdmTablas As New AdmTablas
    Public dsConsulta As New DataSet

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        InicioGeneral()

    End Sub

    Public Sub InicioGeneral()

        LocalizarFormulario()
        IniciarOpciones()
        HabilitarControles(False)

    End Sub

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionImportarConsulta)

        lblFileName.Text = DescripcionCadena(Cadenas.CDN_frmImportar_NombreArchivo)
        cmdValidar.Text = DescripcionCadena(Cadenas.CDN_frmImportar_Validar)
        lblNombreConsulta.Text = DescripcionCadena(Cadenas.CDN_frmImportar_NombreConsulta)
        lblDescripcion.Text = DescripcionCadena(Cadenas.CDN_frmImportar_DescripcionConsulta)
        lblCategoria.Text = DescripcionCadena(Cadenas.CDN_frmImportar_Categoria)
        lblConexion.Text = DescripcionCadena(Cadenas.CDN_frmImportar_Conexion)
        grpMain.Text = DescripcionCadena(Cadenas.CDN_frmImportar_HeaderInfoConsulta)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub IniciarOpciones()

        oAdmTablas.ConnectionString = CONN_LOCAL
        CargarTree()
        CargarConexiones()

        cboCategoria.Tag = ""

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

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub HabilitarControles(ByVal bHab As Boolean)

        txtFileName.Enabled = Not bHab
        cmdBrowse.Enabled = Not bHab
        cmdValidar.Enabled = Not bHab

        txtNombreConsulta.Enabled = bHab
        txtDescripcion.Enabled = bHab
        cboCategoria.Enabled = bHab
        cboConexion.Enabled = bHab

        cmdAceptar.Enabled = bHab

    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

        Dim oDlg As OpenFileDialog

        oDlg = New OpenFileDialog
        oDlg.ValidateNames = True
        oDlg.Filter = DescripcionCadena(Cadenas.CDN_frmExportar_SaveDialogFilter) & "|*.dat"
        oDlg.ShowDialog(Me)

        If oDlg.FileName.Trim <> vbNullString Then
            txtFileName.Text = oDlg.FileName.Trim
        End If

    End Sub

    Private Function Validar() As Boolean

        Dim sFile As String
        Dim sTempFile As String
        Dim sDecrypt As String

        Try

            Cursor = Cursors.WaitCursor

            sFile = txtFileName.Text.Trim
            sTempFile = LOCAL_FOLDER & "XMLTEMP.DAT"

            Call DecryptFile(sFile, sTempFile)

            dsConsulta.Tables.Clear()
            dsConsulta.ReadXml(sTempFile)

            IO.File.Delete(sTempFile)

            txtNombreConsulta.Text = dsConsulta.Tables(0).Rows(0)("CV_NOMBRE")
            txtDescripcion.Text = dsConsulta.Tables(0).Rows(0)("CV_DESCRI")

            Cursor = Cursors.Default

            Return True

        Catch ex As Exception
            Cursor = Cursors.Default
            TratarError(ex)
        End Try

    End Function

    Private Sub cmdValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdValidar.Click
        If Validar() Then
            HabilitarControles(True)
        End If
    End Sub

    Private Function DatosOK() As Boolean

        If txtNombreConsulta.Text.Trim = vbNullString Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_NombreVacio))
            txtNombreConsulta.Focus()
            Exit Function
        End If

        If cboCategoria.Tag.ToString = "" Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_SinCategoria))
            cboCategoria.Focus()
            Exit Function
        End If

        If cboConexion.EditValue = vbNullString Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_DatosOK_SinConexion))
            cboConexion.Focus()
            Exit Function
        End If

        If NombreConsultaExiste(txtNombreConsulta.Text.Trim) Then
            If Pregunta(DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_WarningNombreExiste).Replace("||", vbCrLf)) = Windows.Forms.DialogResult.No Then
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

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DatosOK() Then
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

            nCodConsulta = oAdmTablas.ProximoID("CONVAR", "CV_CODCON")

            sSQL = "SELECT  * " & _
                   "FROM    CONVAR " & _
                   "WHERE   CV_CODCON = " & nCodConsulta & " "

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            ''''' TRATAMIENTO TABLA CONVAR '''''

            With ds.Tables(0)

                oRow = .NewRow
                oRow("CV_CODCON") = nCodConsulta

                ' Iniciar edicion Campo a Campo '
                oRow("CV_NOMBRE") = txtNombreConsulta.Text.Trim
                oRow("CV_DESCRI") = txtDescripcion.Text.Trim
                oRow("CV_CATEGO") = Val(cboCategoria.Tag)
                oRow("CV_SQLPRE") = dsConsulta.Tables(0).Rows(0)("CV_SQLPRE")
                oRow("CV_SQLINI") = dsConsulta.Tables(0).Rows(0)("CV_SQLINI")
                oRow("CV_SQLFIN") = dsConsulta.Tables(0).Rows(0)("CV_SQLFIN")
                oRow("CV_SQLPOS") = dsConsulta.Tables(0).Rows(0)("CV_SQLPOS")
                oRow("CV_CODCAD") = cboConexion.EditValue
                oRow("CV_PASSPR") = dsConsulta.Tables(0).Rows(0)("CV_PASSPR")
                oRow("CV_PASSWD") = dsConsulta.Tables(0).Rows(0)("CV_PASSWD")
                oRow("CV_OPTDEF") = dsConsulta.Tables(0).Rows(0)("CV_OPTDEF")
                oRow("CV_SIMDEC") = dsConsulta.Tables(0).Rows(0)("CV_SIMDEC")
                oRow("CV_LITSTR") = dsConsulta.Tables(0).Rows(0)("CV_LITSTR")
                oRow("CV_LITFEC") = dsConsulta.Tables(0).Rows(0)("CV_LITFEC")
                oRow("CV_FORFEC") = dsConsulta.Tables(0).Rows(0)("CV_FORFEC")
                oRow("CV_SERVER") = dsConsulta.Tables(0).Rows(0)("CV_SERVER")
                oRow("CV_NATSQL") = dsConsulta.Tables(0).Rows(0)("CV_NATSQL")
                oRow("CV_ASYNCH") = dsConsulta.Tables(0).Rows(0)("CV_ASYNCH")
                ' Fin edicion Campo a Campo '

                .Rows.Add(oRow)

            End With

            da.Update(ds)
            ds.AcceptChanges()

            ''''' TRATAMIENTO TABLA CONDET '''''

            sSQL = "SELECT  * " & _
                   "FROM    CONDET " & _
                   "WHERE   CD_CODCON = " & nCodConsulta & " "

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

                For Each oRowTemp In dsConsulta.Tables(1).Rows
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

                For Each oRowTemp In dsConsulta.Tables(2).Rows
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

                For Each oRowTemp In dsConsulta.Tables(3).Rows
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

            ''''' TRATAMIENTO TABLA REPORT '''''

            'sSQL = "SELECT  * " & _
            '       "FROM    REPORT " & _
            '       "WHERE   RP_CODCON = " & nCodConsulta & " "

            'ds = oAdmTablas.AbrirDataset(sSQL, da)
            'cb = New OleDb.OleDbCommandBuilder(da)

            'With ds.Tables(0)

            '   For Each oRowTemp In dsConsulta.Tables(4).Rows
            '       If oRowTemp.RowState <> DataRowState.Deleted Then
            '           oRow = .NewRow
            '           oRow("RP_CODCON") = nCodConsulta
            '           oRow("RP_CODUSU") = USUARIO_ACTUAL
            '           oRow("RP_NOMBRE") = oRowTemp("RP_NOMBRE")
            '           oRow("RP_PATH") = ""
            '           oRow("RP_PUBLIC") = 1
            '           oRow("RP_STREAM") = StrToByteArray(oRowTemp("RP_STREAM"))
            '
            '           .Rows.Add(oRow)

            '       End If
            '   Next

            'End With

            'da.Update(ds)
            'ds.AcceptChanges()

            frmMainX.CargarTree()
            Cursor = Cursors.Default

            Me.Close()

        Catch ex As Exception

            TratarError(ex)

        End Try

    End Sub

    Public Shared Function StrToByteArray(ByVal str As String) As Byte()
        Dim encoding As New System.Text.ASCIIEncoding()
        Return encoding.GetBytes(str)
    End Function


End Class