Module modGlobalLicenciamiento

    Private oAdmTablas As New AdmTablas

    Public Sub ComprobarModoDemo()

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = ""
        sSQL = sSQL & "SELECT CONVERT(char(20), SERVERPROPERTY('ServerName'))" & " " & vbCrLf
        sSQL = sSQL & "SELECT CONVERT(char(20), SERVERPROPERTY('Edition'))" & " " & vbCrLf
        sSQL = sSQL & "SELECT CONVERT(char(20), SERVERPROPERTY('ProductVersion'))" & " " & vbCrLf

        Try

            oAdmTablas.ConnectionString = CONN_LOCAL

            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds

                SERVER_NAME = .Tables(0).Rows(0)(0).ToString.Trim
                SERVER_EDITION = .Tables(1).Rows(0)(0).ToString.Trim
                SERVER_VERSION = .Tables(2).Rows(0)(0).ToString.Trim

            End With

            GenerarAuthenticationKey()

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Public Sub GenerarAuthenticationKey()

        On Error Resume Next

        Dim i As Integer
        Dim sCompleteKey As String
        Dim sBytes As String
        Dim nKeyCode As Integer

        sBytes = ""
        sCompleteKey = SERVER_NAME & SERVER_EDITION & SERVER_VERSION

        For i = 0 To sCompleteKey.Length - 1 Step 2
            nKeyCode = Asc(sCompleteKey.Chars(i)) * 235 - 214 + 133
            If i Mod 2 = 0 Or _
               i = 3 Then

                nKeyCode = nKeyCode + 437
            End If

            sBytes = sBytes & Format(nKeyCode, "00000") & "-"
        Next

        sBytes = sBytes.Substring(0, sBytes.Length - 1)

        If sBytes.Length > 35 Then
            sBytes = sBytes.Substring(0, 35)
        End If

        AUTHENTICATION_KEY = sBytes
        GenerarLicenseKeyOK()

    End Sub

    Public Sub GenerarLicenseKeyOK()

        On Error Resume Next

        Dim sValores() As String
        Dim nValor As Double
        Dim sBytes As String
        Dim i As Integer

        sValores = Split(AUTHENTICATION_KEY, "-")
        sBytes = ""

        For i = 0 To sValores.Length - 1
            nValor = Val(sValores(i))

            Select Case i
                Case 0 : nValor = nValor - 800 * 34.57894
                Case 1 : nValor = nValor + 422 * 15.43723
                Case 2 : nValor = nValor - 994 * 11.48835
                Case 3 : nValor = nValor + 242 * 54.90573
                Case 4 : nValor = nValor - 472 * 28.38702
                Case 5 : nValor = nValor + 787 * 73.32461
            End Select

            If nValor < 0 Then nValor = nValor * -1

            sBytes = sBytes & Format(nValor, "00000") & "-"

        Next

        sBytes = sBytes.Substring(0, sBytes.Length - 1)

        LICENSE_KEY_OK = sBytes
        LeerLicenseKey()

    End Sub

    Public Sub LeerLicenseKey()

        Dim sFileName As String
        Dim sFileContents As String
        Dim sLineas() As String

        sFileName = Application.StartupPath & "\LICINFO.DAT"

        ' Estructura del archivo de licencias
        '
        ' <EDR License Info v.1.00.000>
        ' AUTHENTICATION_KEY
        ' LICENSE_KEY_OK
        ' LICENSE_KEY que ingresa el cliente
        ' </EDR License Info v.1.00.000>

        'sFileContents = "<EDR License Info v.1.00.000>" & vbCrLf & _
        '                "19861-19626-16336-20096-10931-11636" & vbCrLf & _
        '                "07802-26141-04917-33383-02468-69342" & vbCrLf & _
        '                "07802-26141-04917-33383-02468-69343" & vbCrLf & _
        '                "</EDR License Info v.1.00.000>"

        Try


            If IO.File.Exists(sFileName) Then

                sFileContents = cEncrypt.DecryptString128Bit(IO.File.ReadAllText(sFileName))
                sLineas = Split(sFileContents, vbCrLf)
                LICENSE_KEY = sLineas(3)

                If LICENSE_KEY = LICENSE_KEY_OK Then
                    MODO_DEMO = False
                End If

            Else
                ' NO hay info
                MODO_DEMO = True

                'IO.File.WriteAllText(sFileName, cEncrypt.EncryptString128Bit(sFileContents))

            End If

        Catch ex As Exception
            MODO_DEMO = True
        End Try

    End Sub

End Module
