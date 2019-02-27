Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMain

    Private oAdmLocal As New AdmTablas
    Private nuevoRegistro As Boolean
    Public ErrorPermiso As Boolean = False
    Public Sub AnalizarCommand()

        Try

            Dim sParametros() As String
            Dim sItemParam() As String
            Dim nCodigoUsuario As Long
            Dim nCodigoTransaccion As Long
            Dim nCodigoEntidad As Long
            Dim nC As Integer

            '''''' USUARIO ''''''

            sParametros = Command.Split("/")

            For nC = 0 To sParametros.Length - 1

                sItemParam = sParametros(nC).Trim.Split(":")

                If sItemParam.Length = 2 Then

                    Select Case sItemParam(0).Trim.ToUpper
                        Case "U"
                            nCodigoUsuario = Val(sItemParam(1))
                        Case "T"
                            nCodigoTransaccion = Val(sItemParam(1))
                        Case "E"
                            nCodigoEntidad = Val(sItemParam(1))
                    End Select

                End If
            Next

            If nCodigoUsuario = 0 Then
                MensajeError("El parámetro código usuario es inválido.")
                Application.Exit()
            End If

            If nCodigoTransaccion = 0 Then
                MensajeError("El parámetro código de transacción es inválido.")
                Application.Exit()
            End If

            If nCodigoEntidad = 0 Then
                MensajeError("El parámetro código de entidad es inválido.")
                Application.Exit()
            End If

            CODIGO_TRANSACCION = nCodigoTransaccion
            CODIGO_ENTIDAD = nCodigoEntidad

            PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)

        Catch ex As Exception
            TratarError(ex, "AnalizarCommand")
            Application.Exit()
        End Try

    End Sub

    Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)

        Try
            Try
                Dim sSQL As String
                Dim ds As DataSet

                ''''' USUARIO '''''

                sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " &
                "FROM      USUARI " &
                "WHERE     US_CODUSU = " & nCodigoUsuario
                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Falla de seguridad - US_CODUSU: " & nCodigoUsuario)
                    Else
                        UsuarioActual.Codigo = nCodigoUsuario
                        UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE")
                        UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI")
                        UsuarioActual.Admin = .Rows(0).Item("US_ADMIN")
                        UsuarioActual.SoloLectura = False
                        lblUsuario.Text = UsuarioActual.Descripcion
                    End If

                End With

                ds = Nothing

                ''''' ENTIDAD '''''

                sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
                "FROM      TABGEN " &
                "WHERE     TG_CODTAB = 1 " &
                "AND       TG_CODCON = " & nCodigoEntidad
                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Parámetro de entidad no válido - TG_CODCON: " & nCodigoEntidad)
                    Else
                        NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI")
                        lblEntidad.Text = NOMBRE_ENTIDAD
                    End If

                End With

                ds = Nothing

                ''''' TRANSACCION '''''

                sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
                "FROM      MENUES " &
                "WHERE     MU_CODTRA = " & nCodigoTransaccion
                ds = oAdmLocal.AbrirDataset(sSQL)

                With ds.Tables(0)


                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Error en la línea de comandos. Parámetro de transacción incorrecto - MU_CODTRA: " & nCodigoTransaccion)
                    Else
                        lblTransaccion.Text = .Rows(0).Item("MU_DESCRI")
                        Me.Text = "Transacción:" & CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA")
                    End If

                End With

                ds = Nothing

                lblVersion.Text = "Versión: " & Application.ProductVersion
            Catch ex As Security.SecurityException
                MensajeError(ex.Message)
                ErrorPermiso = True
            End Try
        Catch ex As Exception
            TratarError(ex, "PresentarDatos")
            ErrorPermiso = True
        End Try

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oAdmLocal.ConnectionString = CONN_LOCAL
        AnalizarCommand()
        cargarTablas()

        limpiar()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cargarTablas()

        Dim sSQL As String
        Dim ds As DataSet

        Try

            sSQL = "SELECT       TG_CODTAB, CAST(TG_CODTAB AS VARCHAR) + ' - ' + TG_DESCRI AS TG_DESCRI, TG_ALFA02 " &
                "FROM         TABGEN " &
                "WHERE        TG_CODCON = 999999 " &
                "ORDER BY     TG_CODTAB "
            ds = oAdmLocal.AbrirDataset(sSQL)

            With ds.Tables(0)
                For Each row As DataRow In .Rows
                    cboTabla.Items.Add(New clsItem.Item(row(0), row(1), "" & row(2)))
                Next
            End With

            ds = Nothing

        Catch ex As Exception
            TratarError(ex, "cargarTablas")
        End Try

    End Sub

    Private Sub cboTabla_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTabla.SelectedIndexChanged
        cboTabla.ToolTipText = cboTabla.Text
    End Sub

    Private Sub btnPresentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentar.Click

        If Not (cboTabla.SelectedItem Is Nothing) Then

            Dim item As clsItem.Item

            item = cboTabla.SelectedItem
            presentarTabla(item.Valor)

        End If

    End Sub

    Private Sub presentarTabla(ByVal nCodigoTabla As Long)

        Dim sSQL As String
        Dim ds As New DataSet

        sSQL = "SELECT       * " &
             "FROM         TABGEN " &
             "WHERE        TG_CODTAB = " & nCodigoTabla & " " &
             "AND          TG_CODCON <> 999999 " &
             "ORDER BY     TG_CODCON "
        ds = oAdmLocal.AbrirDataset(sSQL)

        GridTG.DataSource = ds.Tables(0)
        GridTG.RefreshDataSource()
        GridTG.Refresh()
        gUsuarios.Columns.Item("TG_CODTAB").OptionsColumn.AllowEdit = False
        verificarColumnas(nCodigoTabla)

        habilitar(False)

    End Sub

    Private Sub verificarColumnas(ByVal nCodigoTabla As Long)

        Dim View As ColumnView = GridTG.MainView
        Dim Column As DevExpress.XtraGrid.Columns.GridColumn
        Dim sSQL As String
        Dim ds As New DataSet
        Dim sCadena As String = ""
        Dim nC As Integer = 0

        sSQL = "SELECT       * " &
             "FROM         TABGEN " &
             "WHERE        TG_CODTAB = " & nCodigoTabla & " " &
             "AND          TG_CODCON = 999999 " &
             "ORDER BY     TG_CODCON "
        ds = oAdmLocal.AbrirDataset(sSQL)

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("TG_ALFA02").ToString.Trim <> "" Then
                sCadena = ds.Tables(0).Rows(0).Item("TG_ALFA02").ToString.Trim
                For Each sCol As String In sCadena.Split("|")

                    If View.Columns.Count >= nC Then

                        Column = View.Columns(nC)
                        Column.Caption = sCol
                        Column.Visible = sCol.Trim <> ""
                        Column.Width = Column.GetBestWidth

                    End If

                    nC = nC + 1
                Next
            End If
        End If

    End Sub

    Private Sub habilitar(ByVal bHabilita As Boolean)

        cboTabla.Enabled = bHabilita
        btnPresentar.Enabled = bHabilita
        btnLimpiar.Enabled = Not bHabilita
        btnNuevaTabla.Enabled = bHabilita
        btnParamTabla.Enabled = Not bHabilita
        btnNuevoReg.Enabled = Not bHabilita
        btnEditarReg.Enabled = Not bHabilita
        btnEliminarReg.Enabled = Not bHabilita

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        nuevoRegistro = False

        Dim View As ColumnView = GridTG.MainView

        GridTG.DataSource = Nothing
        GridTG.RefreshDataSource()
        GridTG.Refresh()

        View.Columns.Clear()

        habilitar(True)

    End Sub

    Private Sub btnNuevoReg_Click(sender As Object, e As EventArgs) Handles btnNuevoReg.Click
        Dim tieneRegistros As Boolean = gUsuarios.RowCount > 0
        gUsuarios.AddNewRow()
        nuevoRegistro = True
        gUsuarios.OptionsBehavior.Editable = True
        If tieneRegistros Then
            gUsuarios.SetFocusedRowCellValue(gUsuarios.Columns.Item("TG_CODTAB"), CType(cboTabla.SelectedItem, clsItem.Item).Valor)
        End If
        gUsuarios.SetFocusedRowModified()
    End Sub

    Private Sub btnEditarReg_Click(sender As Object, e As EventArgs) Handles btnEditarReg.Click
        gUsuarios.OptionsBehavior.Editable = True
        gUsuarios.SetFocusedRowModified()
    End Sub

    Private Sub btnEliminarReg_Click(sender As Object, e As EventArgs) Handles btnEliminarReg.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim nCodigoTabla As String = CType(cboTabla.SelectedItem, clsItem.Item).Valor.ToString
                Try
                    If VerificaDuplicado() Then
                        Dim sql As String = "DELETE TABGEN WHERE TG_CODTAB = @TG_CODTAB and TG_CODCON = @TG_CODCON "
                        If Not oAdmLocal.EjecutarComandoSQL(ReemplazarVariablesGrilla(sql)) Then
                            Throw New Exception("No se ejecutó  correctamente comando Delete")
                        End If
                    End If
                Catch ex As Exception
                    If ex.Message.Contains("Faltan datos obligatorios") Then
                        gUsuarios.DeleteSelectedRows()
                    End If
                End Try

                presentarTabla(nCodigoTabla)
            Catch ex As Exception
                TratarError(ex, "EliminarRegistro")
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub gUsuarios_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gUsuarios.RowUpdated
        Dim vacio As Boolean = True

        For Each column As GridColumn In gUsuarios.Columns
            If Not IsDBNull(gUsuarios.GetFocusedRowCellValue(column)) OrElse
                gUsuarios.GetFocusedRowCellValue(column).ToString <> String.Empty Then
                vacio = False
                Exit For
            End If
        Next

        If vacio Then Exit Sub

        gUsuarios.OptionsBehavior.Editable = False
        If nuevoRegistro Then
            InsertarRegistro(e.RowHandle)
        Else
            ActualizarRegistro(e.RowHandle)
        End If

        nuevoRegistro = False
    End Sub

    Private Sub ActualizarRegistro(rowH As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor

            Try
                'If VerificaDuplicado() Then
                '    MensajeError("No se puede actualizar un registro duplicado [TG_CODTAB, TG_CODCON]")
                '    gUsuarios.OptionsBehavior.Editable = True
                '    Exit Sub
                'End If

                Dim nCodigoTabla As String = CType(cboTabla.SelectedItem, clsItem.Item).Valor.ToString

                Dim Sql As String = "UPDATE TABGEN SET TG_DESCRI='@TG_DESCRI', TG_NUME01=@TG_NUME01, " &
                " TG_NUME02 = @TG_NUME02, TG_ALFA01 = '@TG_ALFA01', " &
                  " TG_ALFA02 = '@TG_ALFA02', TG_FECH01 = '@TG_FECH01', TG_FECH02 = '@TG_FECH02', " &
                  "TG_ALFA03 = '@TG_ALFA03' WHERE TG_CODTAB = @TG_CODTAB and TG_CODCON = @TG_CODCON"

                Sql = ReemplazarVariablesGrilla(Sql)


                If Not oAdmLocal.EjecutarComandoSQL(Sql) Then
                    Throw New Exception("No se ejecutó  correctamente comando Update")
                End If
                presentarTabla(nCodigoTabla)
            Catch ex As Exception
                TratarError(ex, "ActualizarRegistro")
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function VerificaDuplicado() As Boolean
        Return oAdmLocal.DevolverValor("TABGEN", "TG_CODTAB", ReemplazarVariablesGrilla("TG_CODTAB = @TG_CODTAB and TG_CODCON = @TG_CODCON"), "0").ToString <> "0"
    End Function

    Private Sub InsertarRegistro(rowH As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                If VerificaDuplicado() Then
                    MensajeError("No se puede insertar un registro duplicado [TG_CODTAB, TG_CODCON]")
                    gUsuarios.OptionsBehavior.Editable = True
                    Exit Sub
                End If

                Dim nCodigoTabla As String = CType(cboTabla.SelectedItem, clsItem.Item).Valor.ToString

                Dim Sql As String = "INSERT INTO TABGEN (TG_CODTAB,TG_CODCON,TG_DESCRI,TG_NUME01,TG_NUME02,TG_ALFA01, " &
                  " TG_ALFA02,TG_FECH01,TG_FECH02,TG_ALFA03) " &
                "VALUES (" & nCodigoTabla & ",@TG_CODCON, '@TG_DESCRI', " &
                " @TG_NUME01, @TG_NUME02, '@TG_ALFA01', '@TG_ALFA02', " &
                " '@TG_FECH01', '@TG_FECH02', '@TG_ALFA03')"

                Sql = ReemplazarVariablesGrilla(Sql)

                If Not oAdmLocal.EjecutarComandoSQL(Sql) Then
                    Throw New Exception("No se ejecutó  correctamente comando Insert")
                End If
                presentarTabla(nCodigoTabla)
            Catch ex As Exception
                TratarError(ex, "InsertarRegistro")
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ReemplazarVariablesGrilla(Sql As String) As String
        If IsDBNull(gUsuarios.GetFocusedRowCellValue(gUsuarios.Columns.Item("TG_CODTAB"))) OrElse
            IsDBNull(gUsuarios.GetFocusedRowCellValue(gUsuarios.Columns.Item("TG_CODCON"))) OrElse
            gUsuarios.GetFocusedRowCellValue(gUsuarios.Columns.Item("TG_CODTAB")).ToString = String.Empty OrElse
            gUsuarios.GetFocusedRowCellValue(gUsuarios.Columns.Item("TG_CODCON")).ToString = String.Empty Then
            Throw New Exception("Faltan datos obligatorios [TG_CODTAB, TG_CODCON]")
        End If

        For Each column As GridColumn In gUsuarios.Columns
            If column.FieldName = "TG_FECH02" OrElse column.FieldName = "TG_FECH01" Then
                If gUsuarios.GetFocusedRowCellValue(column).ToString = String.Empty OrElse IsDBNull(gUsuarios.GetFocusedRowCellValue(column)) Then
                    Sql = Sql.Replace("@" & column.FieldName, "1900-01-01 00:00:00.000")
                Else
                    Sql = Sql.Replace("@" & column.FieldName, FechaSQL(DateTime.Parse(gUsuarios.GetFocusedRowCellValue(column).ToString)))
                End If
            Else
                If gUsuarios.GetFocusedRowCellValue(column).ToString = String.Empty OrElse IsDBNull(gUsuarios.GetFocusedRowCellValue(column)) Then
                    Sql = Sql.Replace("@" & column.FieldName, "")
                Else
                    Sql = Sql.Replace("@" & column.FieldName, gUsuarios.GetFocusedRowCellValue(column).ToString)
                End If
            End If
        Next
        Return Sql
    End Function

    Private Sub btnNuevaTabla_Click(sender As Object, e As EventArgs) Handles btnNuevaTabla.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim frmNuevaTabla As New frmAgregarTabla()
                If frmNuevaTabla.ShowDialog() = DialogResult.OK Then
                    If frmNuevaTabla.DatosOK Then

                        Dim Sql As String = "INSERT INTO TABGEN (TG_CODTAB,TG_CODCON,TG_DESCRI,TG_NUME01,TG_NUME02,TG_ALFA01, " &
                      " TG_ALFA02,TG_FECH01,TG_FECH02,TG_ALFA03) " &
                    "VALUES (" & frmNuevaTabla.CodigoTabla & ", 999999, '" & frmNuevaTabla.NombreTabla & "', " &
                    " NULL, NULL, NULL, NULL, NULL, NULL, NULL)"

                        If Not oAdmLocal.EjecutarComandoSQL(Sql) Then
                            Throw New Exception("Ocurrió un error al crear tabla.")
                        End If

                        frmNuevaTabla.Dispose()
                        limpiar()
                        cargarTablas()
                        SelItemCombo(cboTabla, frmNuevaTabla.CodigoTabla)
                        presentarTabla(frmNuevaTabla.CodigoTabla)
                    Else
                        MensajeError("Falta completar datos obligatorios.")
                    End If
                End If
            Catch ex As Exception
                TratarError(ex, "InsertarRegistro")
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
