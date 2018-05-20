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
        Public Detalles As DetalleConsulta

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

        '     Dim dckCommand As CommandToolButton

        'Set dckCommand = dckMenu.Commands("btnAbrirConsulta")
        'dckCommand.Enabled = Not bHab

        'Set dckCommand = dckMenu.Commands("btnEjecutarConsulta")
        'dckCommand.Enabled = bHab

        'Set dckCommand = dckMenu.Commands("btnCancelar")
        'dckCommand.Enabled = bHab

        '     GridParametros.Enabled = bHab

    End Sub

End Class
