Public Class frmMain 

    Private oAdmTablas As New AdmTablas

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicioGeneral()
    End Sub

    Private Sub InicioGeneral()

        MODO_DEMO = True
        LeerConnLocal()

    End Sub

    Public Sub LeerConnLocal()

        Dim sFileName As String

        sFileName = Application.StartupPath & "\CONNECT.DAT"

        If IO.File.Exists(sFileName) Then

            CONN_LOCAL = cEncrypt.DecryptString128Bit(IO.File.ReadAllText(sFileName))
            txtConnString.Text = CONN_LOCAL
            oAdmTablas.ConnectionString = CONN_LOCAL

            ObtenerVariablesServidorSQL()

        Else
            ' El archivo de conexión a la BD no existe...

            MensajeInformacion("The local connection string has not been set. Please follow Step 1 to setup the connection to the local database in order to configure the license key")
            cmdLicenseKey.Enabled = False
            cmdAddConnections.Enabled = False

        End If

    End Sub

    Public Sub ObtenerVariablesServidorSQL()

        Dim sSQL As String
        Dim ds As DataSet

        sSQL = ""
        sSQL = sSQL & "SELECT CONVERT(char(20), SERVERPROPERTY('ServerName'))" & " " & vbCrLf
        sSQL = sSQL & "SELECT CONVERT(char(20), SERVERPROPERTY('Edition'))" & " " & vbCrLf
        sSQL = sSQL & "SELECT CONVERT(char(20), SERVERPROPERTY('ProductVersion'))" & " " & vbCrLf

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)

            With ds

                SERVER_NAME = .Tables(0).Rows(0)(0).ToString.Trim
                SERVER_EDITION = .Tables(1).Rows(0)(0).ToString.Trim
                SERVER_VERSION = .Tables(2).Rows(0)(0).ToString.Trim

            End With

            cmdLicenseKey.Enabled = True
            GenerarAuthenticationKey()

        Catch ex As Exception
            TratarError(ex)
            MensajeInformacion("The local connection string has not been set. Please follow Step 1 to setup the connection to the local database in order to configure the license key")
            cmdLicenseKey.Enabled = False
            cmdAddConnections.Enabled = False

        End Try

    End Sub

    Public Sub GenerarAuthenticationKey()

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

    End Sub

    Private Sub cmdLicenseKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLicenseKey.Click

        Dim fLicenseKey As New frmLicenseKey

        fLicenseKey.ShowDialog()
        fLicenseKey.Dispose()

    End Sub

    Private Sub cmdConfigureConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfigureConnection.Click
        Dim fConnString As New frmConnString

        fConnString.ShowDialog()
        fConnString.Dispose()
    End Sub
End Class