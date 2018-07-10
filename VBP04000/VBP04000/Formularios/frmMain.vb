'Tipos de campos de parametros Numerico/Texto/Fecha

Imports System.Linq
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

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
        Public Requerido As Boolean
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
    Private currentRepositoryItems As IDictionary(Of Integer, RepositoryItem)


    Public ErrorPermiso As Boolean = False


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
        currentRepositoryItems = New Dictionary(Of Integer, RepositoryItem)()
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

            lblVersion.Text = "Versión: " & Application.ProductVersion

            Exit Sub

        Catch ex As Exception
            TratarError(ex, "AnalizarCommand")
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
                ds = oAdmlocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Falla de seguridad")
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
                        Throw New Security.SecurityException("Parámetro de entidad no válido")
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
                        Throw New Security.SecurityException("Error en la línea de comandos. Parámetro de transacción incorrecto")
                    Else
                        lblTransaccion.Text = CType(.Rows(0).Item("MU_DESCRI"), String)
                        Me.Text = CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA").ToString
                        lblTitulo.Text = .Rows(0).Item("MU_TRANSA").ToString
                        lblSubtitulo.Text = .Rows(0).Item("MU_DESCRI").ToString
                    End If

                End With

                ds = Nothing
            Catch ex As Security.SecurityException
                MensajeError(ex.Message)
                ErrorPermiso = True
            End Try
        Catch ex As Exception
            TratarError(ex, "PresentarDatos")
            ErrorPermiso = True
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

    Private Sub cmdNuevaConsultaResultado_Click() Handles cmdNuevaConsultaResultado.ItemClick
        Try
            NuevaConsulta()
            LimpiarConsultaActual()
            HabilitarEjecucion(False)
            tabParametros.Select()
            tabPanel.SelectedTabPage = tabParametros
            HabilitarComandasResultados(False)
        Catch ex As Exception
            TratarError(ex)
        End Try
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


            GridParametros.DataSource = Nothing
            'GridViewParametros.Columns.Clear()
            GridParametros.Refresh()
            If udtConsultaActual IsNot Nothing Then
                With udtConsultaActual
                    .Detalles.Clear()
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
            End If

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

                    If udtConsultaActual.Detalles(i).Requerido Then
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

                AjusteColumnas()
                FormatearColumnas()

                If GridResultado.RowCount > 0 Then
                    Habilitar(True)
                    tabResultados.Select()
                    tabPanel.SelectedTabPage = tabResultados
                    HabilitarEjecucion(True)
                    HabilitarComandasResultados(True)
                Else
                    HabilitarComandasResultados(False)
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

    Private Sub HabilitarComandasResultados(habilita As Boolean)
        cmdNuevaConsultaResultado.Enabled = habilita
        cmdExportarResultado.Enabled = habilita
        cmdMostrarAgrupamiento.Enabled = habilita
        cmdCopiarResultados.Enabled = habilita
        cmdColumnasResultados.Enabled = habilita
        cmdCopiarResultados.Enabled = habilita
        cmdVistaPrevia.Enabled = habilita
    End Sub

    Private Sub FormatearColumnas()

        Try

            Dim sSQL As String

            sSQL = "SELECT * " &
                  "FROM   CONFOR " &
                  "WHERE  CF_CODCON = " & udtConsultaActual.CODIGO

            Dim rstAux As DataSet = oAdmlocal.AbrirDataset(sSQL)

            With rstAux.Tables(0)
                For Each row As DataRow In .Rows
                    Dim col As GridColumn = GridResultado.Columns.Item(row.Item("CF_COLKEY").ToString())
                    If col Is Nothing Then
                        Continue For
                    End If
                    col.DisplayFormat.FormatString = row.Item("CF_FORMAT").ToString()
                    col.GroupFormat.FormatString = row.Item("CF_FORMAT").ToString()
                Next
            End With

            'For Each oCol In Grid.Columns
            '   Debug.Print oCol.Key
            'Next

            rstAux = Nothing

        Catch ex As Exception
            Throw New Exception("Ocurrió un error en FormatearColumnas", ex)
        End Try
    End Sub
    Private Sub AjusteColumnas()
        For Each oCol As GridColumn In GridResultado.Columns

            If FORMATEAR_NUMEROS Then

                If IsNumericType(oCol.ColumnType) Then
                    If InStr(1, UCase(oCol.Caption), "NRO") <= 0 And
               InStr(1, UCase(oCol.Caption), "NUMERO") <= 0 And
               InStr(1, UCase(oCol.Caption), "COD") <= 0 And
               InStr(1, UCase(oCol.Caption), "CODIGO") <= 0 Then

                        oCol.DisplayFormat.FormatString = "#,##0.00"

                    End If
                End If

            End If
        Next

    End Sub

    Private Function IsNumericType(ByVal type As Type) As Boolean
        If type Is Nothing Then
            Return False
        End If

        Select Case Type.GetTypeCode(type)
            Case TypeCode.Byte, TypeCode.Decimal, TypeCode.Double, TypeCode.Int16, TypeCode.Int32, TypeCode.Int64, TypeCode.SByte, TypeCode.Single, TypeCode.UInt16, TypeCode.UInt32, TypeCode.UInt64
                Return True
            Case TypeCode.Object

                If type.IsGenericType AndAlso type.GetGenericTypeDefinition() = GetType(Nullable(Of)) Then
                    Return IsNumericType(Nullable.GetUnderlyingType(type))
                End If

                Return False
        End Select

        Return False
    End Function


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
                            'udtConsultaActual.Detalles(i).Valor = FechaSQL(udtConsultaActual.Detalles(i).Valor)
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
            If udtConsultaActual Is Nothing Then udtConsultaActual = New ConsultaVaria
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

            sSQL = "SELECT    *, '' as Valor " &
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
                    detalle.Requerido = Boolean.Parse(.Rows(0).Item("CD_REQUER").ToString())
                    detalle.SQLTablaGeneral = .Rows(0).Item("CD_SQLTBG").ToString()

                    udtConsultaActual.Detalles.Add(detalle)
                Next


            End With

            GridParametros.DataSource = rstAux.Tables(0)
            Grid.RefreshDataSource()
            Grid.Refresh()
            currentRepositoryItems.Clear()

            rstAux = Nothing
            For Each detalle As DetalleConsulta In udtConsultaActual.Detalles.OrderBy(Function(d) d.Orden)
                'Dim rowHandle As Integer = GridViewParametros.GetRowHandle(GridViewParametros.DataRowCount)
                'If GridViewParametros.IsNewItemRow(rowHandle) Then
                Dim colEditor As New GridColumn
                Dim oLookUp As RepositoryItem

                Select Case detalle.Help
                    Case 0
                        oLookUp = New RepositoryItemTextEdit()
                        oLookUp.Name = "input" & detalle.Variable
                        '.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    Case 1
                        oLookUp = New RepositoryItemDateEdit()

                        'oLookUp.EditFormat.FormatString = "MM/dd/yyyy"
                        'oLookUp.DisplayFormat.FormatString = "MM/dd/yyyy"

                        oLookUp.Name = "date" & detalle.Variable
                    Case 2
                        oLookUp = New RepositoryItemTextEdit()
                        oLookUp.Name = "input" & detalle.Variable
                End Select
                If Not currentRepositoryItems.ContainsKey(detalle.Help) Then
                    currentRepositoryItems.Add(detalle.Help, Nothing)
                End If

                'AddHandler oLookUp.EditValueChanged, AddressOf ReporitoryChangedValue

                oLookUp.Name = oLookUp.Name.Replace("@", String.Empty)
                GridParametros.RepositoryItems.Add(oLookUp)
                currentRepositoryItems(detalle.Help) = oLookUp
            Next

            GridViewParametros.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
            GridParametros.Refresh()

        Catch ex As Exception
            TratarError(ex, "AbrirConsulta")
        End Try
    End Sub

    Private Sub ReporitoryChangedValue(sender As Object, e As EventArgs)
        If e IsNot Nothing Then
            Select Case GridViewParametros.GetDataRow(GridViewParametros.GetSelectedRows().FirstOrDefault()).Item(7)
                Case 0
                Case 2
                    GridViewParametros.SetFocusedRowCellValue(colEditorParametro, CType(sender, DevExpress.XtraEditors.TextEdit).Text)
                Case 1
                    GridViewParametros.SetFocusedRowCellValue(colEditorParametro, CType(sender, DevExpress.XtraEditors.DateEdit).DateTime)

            End Select
        End If
    End Sub

    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GridViewParametros.CustomRowCellEdit
        Dim view As GridView = CType(sender, GridView)
        If GridParametros.RepositoryItems.Count > 0 AndAlso e.Column.Name = colEditorParametro.Name Then
            'colEditorParametro.ColumnEdit 
            e.RepositoryItem = currentRepositoryItems(GridViewParametros.GetDataRow(e.RowHandle).Item(7))
        End If

    End Sub

    Private Sub GridViewParametros_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridViewParametros.CellValueChanged
        If e.Column.Name <> colEditorParametro.Name Then
            Exit Sub
        End If

        Dim row As String = GridViewParametros.GetDataRow(e.RowHandle).Item(4).ToString()
        Select Case GridViewParametros.GetDataRow(GridViewParametros.GetSelectedRows().FirstOrDefault()).Item(7)
            Case 0
            Case 2
                udtConsultaActual.Detalles.FirstOrDefault(Function(d) d.Variable.ToUpper.Equals(row.ToUpper, StringComparison.InvariantCultureIgnoreCase)).Valor = e.Value
            Case 1
                udtConsultaActual.Detalles.FirstOrDefault(Function(d) d.Variable.ToUpper.Equals(row.ToUpper, StringComparison.InvariantCultureIgnoreCase)).Valor = Date.Parse(e.Value)

        End Select
    End Sub

    Private Sub cmdColumnasResultados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdColumnasResultados.ItemClick
        GridResultado.ColumnsCustomization()
    End Sub

    Private Sub cmdVistaPrevia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdVistaPrevia.ItemClick
        Try
            Me.Cursor = Cursors.WaitCursor
            Try
                If Not Grid.IsPrintingAvailable Then
                    Throw New Exception("The 'DevExpress.XtraPrinting' library is not found")
                End If
                GridResultado.ShowPrintPreview()
            Catch ex As Exception
                TratarError(ex, "VistaPrevia")
            End Try

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdExportarResultado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportarResultado.ItemClick
        Dim frmExportar As New frmExportar()
        frmExportar.PasarViewResultados("Consulta_" & CODIGO_TRANSACCION, "Consulta_" & CODIGO_TRANSACCION, GridResultado)
        frmExportar.Show()
    End Sub

    Private Sub cmdCopiarResultados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCopiarResultados.ItemClick
        GridResultado.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.PlainText
        GridResultado.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.True
        GridResultado.OptionsClipboard.CopyCollapsedData = DevExpress.Utils.DefaultBoolean.True

        GridResultado.OptionsSelection.MultiSelect = True
        GridResultado.SelectAll()
        GridResultado.CopyToClipboard()
        GridResultado.OptionsSelection.MultiSelect = False

        MensajeInformacion("Se han copiado los resultados en el portapapeles")
    End Sub

    Private Sub cmdMostrarAgrupamiento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMostrarAgrupamiento.ItemClick
        GridResultado.OptionsView.ShowGroupPanel = Not GridResultado.OptionsView.ShowGroupPanel
    End Sub
End Class
