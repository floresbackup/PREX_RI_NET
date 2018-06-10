'Tipos de campos de parametros Numerico/Texto/Fecha

Public Class frmMain
    Private Class DetalleConsulta

        Public Orden As Integer
        Public NombreParametro As String
        Public TipoDatos As String
        Public Variable As String
        Public ParteSQL As String
        Public Valor As String
        Public EsIN As Boolean
        Public Help As Integer
        Public Requerido As Integer
        Public SQLTablaGeneral As String

    End Class

    Private Class ConsultaVaria

        Public CODIGO As Long
        Public Nombre As String
        Public Descripcion As String
        Public Layout As String
        Public Categoria As String
        Public SQLInicial As String
        Public SQLFinal As String
        Public NombreSP As String
        Public TipoInstruccion As Integer
        Public CadenaConexion As String
        Public Detalles As List(Of DetalleConsulta)

        Public Sub New()
            Detalles = New List(Of DetalleConsulta)()
        End Sub

    End Class

    Private oAdmlocal As New AdmTablas



    Private udtConsultaActual As ConsultaVaria
    Private nX As Long
    Private nY As Long
    Private nLastCol As Integer

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oAdmlocal.ConnectionString = CONN_LOCAL
        AnalizarCommand()
    End Sub


    Private Sub AnalizarCommand()
        Try

            Dim sTemp As String
            Dim nPos As Integer
            Dim nPosAux As Integer
            Dim nCodigoUsuario As Long
            Dim nCodigoTransaccion As Long
            Dim nCodigoEntidad As Long

            sTemp = Command()

            '''''' USUARIO ''''''

            nPos = InStr(1, UCase(sTemp), "/U:")

            If nPos = 0 Then
                MensajeError("Los argumentos de la línea de comandos no son válidos")
                End
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoUsuario = CLng(Val(Mid(sTemp, nPos + 3, nPosAux - 1)))
            Else
                nCodigoUsuario = CLng(Val(Mid(sTemp, nPos + 3)))
            End If

            '''''' TRANSACCION ''''''

            nPos = InStr(1, UCase(sTemp), "/T:")

            If nPos = 0 Then
                MensajeError("Los argumentos de la línea de comandos no son válidos")
                End
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoTransaccion = CLng(Val(Mid(sTemp, nPos + 3, nPosAux - 1)))
            Else
                nCodigoTransaccion = CLng(Val(Mid(sTemp, nPos + 3)))
            End If

            '''''' ENTIDAD ''''''

            nPos = InStr(1, UCase(sTemp), "/E:")

            If nPos = 0 Then
                MensajeError("Los argumentos de la línea de comandos no son válidos")
                End
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoEntidad = CLng(Val(Mid(sTemp, nPos + 3, nPosAux - 1)))
            Else
                nCodigoEntidad = CLng(Val(Mid(sTemp, nPos + 3)))
            End If

            CODIGO_TRANSACCION = nCodigoTransaccion
            CODIGO_ENTIDAD = nCodigoEntidad

            PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)

            Exit Sub

        Catch ex As Exception
            TratarError(ex, "AnalizarCommand")
        End Try


    End Sub


    Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)

        Try

            Dim sSQL As String
            Dim ds As DataSet
            Dim sError As String = ""

            ''''' USUARIO '''''

            sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " &
            "FROM      USUARI " &
            "WHERE     US_CODUSU = " & nCodigoUsuario
            ds = oAdmlocal.AbrirDataset(sSQL)

            With ds.Tables(0)

                If .Rows.Count = 0 Then
                    sError = "Falla de seguridad"
                Else
                    UsuarioActual.Codigo = nCodigoUsuario
                    UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE").ToString
                    UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI").ToString
                    UsuarioActual.Admin = CBool(.Rows(0).Item("US_ADMIN"))
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
            ds = oAdmlocal.AbrirDataset(sSQL)

            With ds.Tables(0)

                If .Rows.Count = 0 Then
                    sError = "Parámetro de entidad no válido"
                Else
                    NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI").ToString
                    lblEntidad.Text = NOMBRE_ENTIDAD
                End If

            End With

            ds = Nothing

            ''''' TRANSACCION '''''

            sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
            "FROM      MENUES " &
            "WHERE     MU_CODTRA = " & nCodigoTransaccion
            ds = oAdmlocal.AbrirDataset(sSQL)

            With ds.Tables(0)


                If .Rows.Count = 0 Then
                    sError = "Error en la línea de comandos. Parámetro de transacción incorrecto"
                Else
                    lblTransaccion.Text = CType(.Rows(0).Item("MU_DESCRI"), String)
                    Me.Text = CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA").ToString
                End If

            End With

            ds = Nothing

            lblVersion.Text = "Versión: " & Application.ProductVersion

            If sError <> "" Then
                MensajeError(sError)
                Application.Exit()
            End If

        Catch ex As Exception
            TratarError(ex, "AnalizarCommand")
            Application.Exit()
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Habilitar(False)
        HabilitarEjecucion(False)
    End Sub

    Private Sub Habilitar(ByVal bHab As Boolean)

        'Dim oCommand As InnovaDSXP.Command

        'For Each oCommand In dckResultados.Commands
        '    If oCommand.Type = dsxpCommandTypeToolButton Then
        '        oCommand.Enabled = bHab
        '    End If
        'Next

        'If Not bHab Then
        '    Tabs.Tabs(1).Selected = True
        'End If

    End Sub


    Private Sub HabilitarEjecucion(ByVal bHab As Boolean)
        btnAbrirConsulta.Enabled = Not bHab
        btnEjecutarConsulta.Enabled = bHab
        btnCancelar.Enabled = bHab

        GridParametros.Enabled = bHab

    End Sub

    Private Sub btnAbrirConsulta_Click(sender As Object, e As EventArgs) Handles btnAbrirConsulta.Click
        PreAbrirConsulta()
    End Sub
    Private Sub btnEjecutarConsulta_Click(sender As Object, e As EventArgs) Handles btnEjecutarConsulta.Click
        If CONSULTA_SELECCIONADA > 0 Then
            EjecutarConsulta()
        Else
            MensajeError("No se ha seleccionado ninguna consulta")
        End If
    End Sub

    Private Sub btnCancelar_click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            NuevaConsulta()
            LimpiarConsultaActual()
            HabilitarEjecucion(False)
        Catch ex As Exception
            TratarError(ex)
        End Try
    End Sub

    Private Sub EjecutarConsulta()
        If Validar() Then
            Actualizar()
        End If
    End Sub


    Private Sub NuevaConsulta()

        Try

            Grid.DataSource = Nothing
            GridResultado.Columns.Clear()

            Habilitar(False)

            HabilitarEjecucion(True)
            TAB()
            'tabPanel.SelectedTabPageIndex = 0
            tabParametros.Select()
            'LimpiarConsultaActual
            'HabilitarEjecucion False
        Catch ex As Exception
            Throw New Exception("Ocurrió un error en NuevaConsulta", ex)
        End Try
    End Sub

    Private Sub LimpiarConsultaActual()
        Try

            udtConsultaActual.Detalles.Clear()
            GridParametros.DataSource = Nothing
            GridViewParametros.Columns.Clear()
            GridParametros.Refresh()

            With udtConsultaActual
                .Categoria = ""
                .CODIGO = 0
                .Descripcion = ""
                .Layout = ""
                .Nombre = ""
                .SQLFinal = ""
                .SQLInicial = ""
                .NombreSP = ""
                .TipoInstruccion = 0
                .CadenaConexion = ""
            End With

            lblCategoriaConsulta.Text = ""
            lblCodigoConsulta.Text = ""
            lblDescripcionConsulta.Text = ""
            lblNombreConsulta.Text = ""

        Catch ex As Exception
            Throw New Exception("Ocurrió un error LimpiarConsultaActual", ex)
        End Try
    End Sub

    Private Function Validar() As Boolean

        Dim i As Integer

        If GridViewParametros.RowCount > 0 Then

            For i = 0 To udtConsultaActual.Detalles.Count - 1

                If Trim(udtConsultaActual.Detalles(i).Valor) <> "" Then

                    If udtConsultaActual.Detalles(i).TipoDatos.ToUpper = "F" Then
                        If Not IsDate(udtConsultaActual.Detalles(i).Valor) Then
                            MensajeError("Fecha no válida para el parámetro " & udtConsultaActual.Detalles(i).NombreParametro)
                            Return False
                        End If
                    ElseIf udtConsultaActual.Detalles(i).TipoDatos.ToUpper = "N" Then
                        If Not udtConsultaActual.Detalles(i).EsIN Then
                            If Not IsNumeric(udtConsultaActual.Detalles(i).Valor) Then
                                MensajeError("Tipo de datos no válido para el parámetro " & udtConsultaActual.Detalles(i).NombreParametro)
                                Return False
                            End If
                        End If
                    End If

                Else

                    If Math.Abs(udtConsultaActual.Detalles(i).Requerido) = 1 Then
                        MensajeError("El parámetro " & udtConsultaActual.Detalles(i).NombreParametro & " no puede quedar vacío")
                        Return False
                    End If

                End If

            Next

        End If

        Return True

    End Function


    Private Sub Actualizar(Optional ByVal sCustomSQL As String = vbNullString)
        Try
            Me.Cursor = Cursors.WaitCursor
            Try

                Dim sSQL As String = String.Empty
                Dim coneccion As String

                If sCustomSQL <> vbNullString Then
                    sSQL = sCustomSQL
                Else
                    sSQL = ConformarSQL()
                End If

                '    With GridResultado

                '        'If udtConsultaActual.Layout <> "" Then
                '        '    .LoadLayout App.Path & "\LAYOUTS\" & udtConsultaActual.Layout
                '        'End If

                '        If udtConsultaActual.CadenaConexion = "" Then
                '            .DatabaseName = CONN_LOCAL
                '        Else
                '            .DatabaseName = udtConsultaActual.CadenaConexion
                '        End If

                '        .RecordSource = sSQL

                '        If udtConsultaActual.Layout <> "" Then

                '            .Rebind True

                'Else

                '            .Rebind

                '            AjusteColumnas
                '            FormatearColumnas

                '        End If

                '    End With
                If udtConsultaActual.CadenaConexion = "" Then
                    coneccion = CONN_LOCAL
                Else
                    coneccion = udtConsultaActual.CadenaConexion
                End If

                Dim ad As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sSQL, coneccion)
                Dim dt As New DataTable
                ad.Fill(dt)

                Grid.DataSource = dt
                Grid.RefreshDataSource()
                Grid.Refresh()

                If GridResultado.RowCount > 0 Then
                    Habilitar(True)
                    tabResultados.Select()
                    HabilitarEjecucion(True)

                    '              set oCommand = dckResultados.Commands("btnCuadroAgrupar")

                    '              If Grid.GroupByBoxVisible = True Then
                    '                  oCommand.State = dsxpCommandToolButtonStateChecked
                    '              Else
                    '                  oCommand.State = dsxpCommandToolButtonStateUnchecked
                    '              End If

                    'Set oCommand = dckResultados.Commands("btnFilaTotales")

                    '      If Grid.GroupFooterStyle = jgexTotalsGroupFooter Then
                    '                  oCommand.State = dsxpCommandToolButtonStateChecked
                    '              Else
                    '                  oCommand.State = dsxpCommandToolButtonStateUnchecked
                    '              End If

                Else
                    MensajeError("No se han encontrado resultados según el criterio de búsqueda utilizado")
                End If

                Exit Sub

            Catch ex As Exception
                TratarError(ex, "Actualizar")
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ConformarSQL() As String

        Dim sSQL As String
        Dim sTemp As String
        Dim i As Integer

        If udtConsultaActual.TipoInstruccion = 1 Then ' CONSULTA SQL

            sSQL = udtConsultaActual.SQLInicial

            If GridViewParametros.RowCount > 0 Then

                For i = 0 To udtConsultaActual.Detalles.Count - 1

                    If Trim(udtConsultaActual.Detalles(i).Valor) <> "" Then

                        If udtConsultaActual.Detalles(i).TipoDatos.ToUpper = "F" Then
                            udtConsultaActual.Detalles(i).Valor = Format(udtConsultaActual.Detalles(i).Valor, FORMATO_FECHA)
                            sTemp = Replace(udtConsultaActual.Detalles(i).ParteSQL, udtConsultaActual.Detalles(i).Variable, FechaSQL(udtConsultaActual.Detalles(i).Valor))
                        ElseIf udtConsultaActual.Detalles(i).TipoDatos.ToUpper = "T" Then
                            sTemp = Replace(udtConsultaActual.Detalles(i).ParteSQL, udtConsultaActual.Detalles(i).Variable, "'" & udtConsultaActual.Detalles(i).Valor & "'")
                        Else
                            sTemp = Replace(udtConsultaActual.Detalles(i).ParteSQL, udtConsultaActual.Detalles(i).Variable, udtConsultaActual.Detalles(i).Valor)
                        End If

                        sSQL = sSQL & " " & sTemp & " "

                    End If

                Next

            End If

            sSQL = sSQL & " " & udtConsultaActual.SQLFinal

            ConformarSQL = sSQL

        Else ' PROCEDIMIENTO ALMACENADO

            sSQL = udtConsultaActual.NombreSP

            If GridViewParametros.RowCount > 0 Then

                For i = 0 To udtConsultaActual.Detalles.Count - 1

                    If Trim(udtConsultaActual.Detalles(i).Valor) <> "" Then

                        If udtConsultaActual.Detalles(i).TipoDatos.ToUpper = "F" Then
                            sSQL = sSQL & " " & FechaSQL(Date.Parse(udtConsultaActual.Detalles(i).Valor)) & ", "
                        ElseIf udtConsultaActual.Detalles(i).TipoDatos.ToUpper = "T" Then
                            sSQL = sSQL & " '" & udtConsultaActual.Detalles(i).Valor & "', "
                        Else
                            sSQL = sSQL & " " & udtConsultaActual.Detalles(i).Valor & ", "
                        End If

                    Else

                        sSQL = sSQL & ", "

                    End If

                Next

            End If

            If Strings.Right(sSQL, 2) = ", " Then
                sSQL = Mid(sSQL, 1, Len(sSQL) - 2)
            End If

            ConformarSQL = sSQL

        End If

        Debug.Print(sSQL)

    End Function


    Private Sub PreAbrirConsulta()

        CONSULTA_SELECCIONADA = 0

        Dim frmCons As New frmConsultas()
        frmCons.ShowDialog()

        If CONSULTA_SELECCIONADA > 0 Then

            If SeguridadConsulta(CONSULTA_SELECCIONADA) Then
                AbrirConsulta(CONSULTA_SELECCIONADA)
                HabilitarEjecucion(True)
            Else
                MensajeError("No dispone de privilegios para ejecutar esta consulta")
            End If
        End If

    End Sub

    Private Function SeguridadConsulta(ByVal nCodigo As Long) As Boolean
        Try

            Dim sSQL As String = "SELECT    COUNT(*) AS XX_TOTAL " &
                      "FROM   CONSEG " &
                      "WHERE  CS_CODUSU = " & UsuarioActual.Codigo & " " &
                      "AND    CS_CODCON = " & nCodigo

            Dim rstAux As DataSet = oAdmlocal.AbrirDataset(sSQL)
            Dim sReturn As Boolean = True
            If rstAux.Tables(0) Is Nothing Then
                sReturn = False
            Else
                With rstAux.Tables(0)
                    If .Rows.Count = 0 OrElse CInt(.Rows(0).Item("XX_TOTAL").ToString()) > 0 Then
                        sReturn = False
                    End If
                End With
            End If

            rstAux = Nothing
            Return sReturn
        Catch ex As Exception
            TratarError(ex, "SeguridadConsulta")
            Return False
        End Try
    End Function

    Private Sub AbrirConsulta(ByVal nCodigoConsulta As Long)
        Try
            Dim i As Integer

            Dim sSQL As String = "SELECT    CONVAR.*, TG_DESCRI " &
          "FROM  CONVAR, TABGEN " &
          "WHERE CV_CODCON = " & nCodigoConsulta & " " &
          "AND   CV_CATEGO = TG_CODCON " &
          "AND   TG_CODTAB = " & TablasGenerales.TGL_CATEGORIAS_CONVAR

            Dim rstAux As DataSet = oAdmlocal.AbrirDataset(sSQL)

            With rstAux.Tables(0)
                udtConsultaActual.Categoria = .Rows(0).Item("TG_DESCRI").ToString()
                udtConsultaActual.CODIGO = Long.Parse(.Rows(0).Item("CV_CODCON").ToString())
                udtConsultaActual.Descripcion = .Rows(0).Item("CV_DESCRI").ToString()
                udtConsultaActual.Layout = .Rows(0).Item("CV_LAYOUT").ToString()
                udtConsultaActual.Nombre = .Rows(0).Item("CV_NOMBRE").ToString()
                udtConsultaActual.SQLInicial = .Rows(0).Item("CV_SQLINI").ToString()
                udtConsultaActual.SQLFinal = .Rows(0).Item("CV_SQLFIN").ToString()
                udtConsultaActual.NombreSP = .Rows(0).Item("CV_NOMBSP").ToString()
                udtConsultaActual.TipoInstruccion = CInt(.Rows(0).Item("CV_TIPINS").ToString())
                udtConsultaActual.CadenaConexion = .Rows(0).Item("CV_CADCON").ToString()
            End With

            rstAux = Nothing

            lblCodigoConsulta.Text = udtConsultaActual.CODIGO.ToString
            lblNombreConsulta.Text = udtConsultaActual.Nombre
            lblDescripcionConsulta.Text = udtConsultaActual.Descripcion
            lblCategoriaConsulta.Text = udtConsultaActual.Categoria

            sSQL = "SELECT    * " &
                  "FROM      CONDET " &
                  "WHERE     CD_CODCON = " & nCodigoConsulta & " " &
                  "ORDER BY  CD_ORDEN ASC"

            rstAux = oAdmlocal.AbrirDataset(sSQL)

            With rstAux.Tables(0)

                For i = 1 To .Rows.Count
                    Dim detalle As DetalleConsulta = New DetalleConsulta()

                    detalle.NombreParametro = .Rows(0).Item("CD_NOMPAR").ToString()
                    detalle.Orden = CInt(.Rows(0).Item("CD_ORDEN").ToString())
                    detalle.ParteSQL = .Rows(0).Item("CD_PARSQL").ToString()
                    detalle.TipoDatos = .Rows(0).Item("CD_TIPDAT").ToString()
                    detalle.Variable = .Rows(0).Item("CD_VARIAB").ToString()
                    detalle.EsIN = Boolean.Parse(.Rows(0).Item("CD_INSQL").ToString())
                    detalle.Help = CInt(.Rows(0).Item("CD_HELP").ToString())
                    detalle.Requerido = CInt(.Rows(0).Item("CD_REQUER").ToString())
                    detalle.SQLTablaGeneral = .Rows(0).Item("CD_SQLTBG").ToString()

                    udtConsultaActual.Detalles.Add(detalle)
                Next


            End With

            rstAux = Nothing

            If i > 0 Then
                'GridParametros.Enabled = True
                'GridParametros.ItemCount = i
                'GridParametros.Refresh()
                'GridParametros.SetFocus
                ''SendKeys("{RIGHT}")
            End If

            Exit Sub
        Catch ex As Exception
            TratarError(ex, "AbrirConsulta")
        End Try
    End Sub
End Class
