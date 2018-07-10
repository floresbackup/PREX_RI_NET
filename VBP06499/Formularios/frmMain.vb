Public Class frmMain
    Private oAdmlocal As AdmTablas
    Private oAdmSIB As AdmTablas
    Public ErrorPermiso As Boolean = False

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        oAdmlocal = New AdmTablas
        oAdmSIB = New AdmTablas

        oAdmlocal.ConnectionString = CONN_LOCAL
        oAdmSIB.ConnectionString = CONN_SIB
    End Sub

    ' Private Sub dckStudio_CommandClick(ByVal Command As InnovaDSXP.Command)

    '     Select Case Command.Name

    '         Case "btnAyuda"

    '             Ayuda()

    '         Case "btnSalir"

    '             Unload Me

    'End Select

    ' End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    'Private Sub Form_Resize()

    '    On Error Resume Next

    '    With dckStudio
    '        .Width = ScaleWidth - 15
    '    End With

    'End Sub


    Public Sub AnalizarCommand()
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
                nCodigoUsuario = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoUsuario = Val(Mid(sTemp, nPos + 3))
            End If

            '''''' TRANSACCION ''''''

            nPos = InStr(1, UCase(sTemp), "/T:")

            If nPos = 0 Then
                MensajeError("Los argumentos de la línea de comandos no son válidos")
                End
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoTransaccion = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoTransaccion = Val(Mid(sTemp, nPos + 3))
            End If

            '''''' ENTIDAD ''''''

            nPos = InStr(1, UCase(sTemp), "/E:")

            If nPos = 0 Then
                MensajeError("Los argumentos de la línea de comandos no son válidos")
                End
            End If

            nPosAux = InStr(1, Mid(sTemp, nPos + 3), "/")

            If nPosAux > 0 Then
                nCodigoEntidad = Val(Mid(sTemp, nPos + 3, nPosAux - 1))
            Else
                nCodigoEntidad = Val(Mid(sTemp, nPos + 3))
            End If

            CODIGO_TRANSACCION = nCodigoTransaccion
            CODIGO_ENTIDAD = nCodigoEntidad

            PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)


        Catch ex As Exception
            TratarError(ex, "AnalizarCommand")
        End Try
    End Sub

    Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)
        Try
            Try
                Dim sSQL As String

                ''''' USUARIO '''''

                sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " &
              "FROM      USUARI " &
              "WHERE     US_CODUSU = " & nCodigoUsuario

                Dim ds As DataSet = oAdmlocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Falla de seguridad")
                    Else
                        UsuarioActual.Codigo = nCodigoUsuario
                        UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE")
                        UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI")
                        UsuarioActual.Admin = .Rows(0).Item("US_ADMIN")
                        UsuarioActual.SoloLectura = False
                        '  lblUsuario.Text = UsuarioActual.Descripcion
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
                        NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI")
                        'lblEntidad.Text = NOMBRE_ENTIDAD
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
                        'lblTransaccion.Text = .Rows(0).Item("MU_DESCRI")
                        Me.Text = CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA")
                    End If

                End With

                ds = Nothing

                'lblVersion.Text = "Versión: " & Application.ProductVersion
            Catch ex As Security.SecurityException
                MensajeError(ex.Message)
                ErrorPermiso = True
            End Try
        Catch ex As Exception
            TratarError(ex, "PresentarDatos")
            ErrorPermiso = True
        End Try

    End Sub


    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        oAdmlocal = Nothing
        oAdmSIB = Nothing

    End Sub
End Class