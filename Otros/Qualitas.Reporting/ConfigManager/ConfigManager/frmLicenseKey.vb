Public Class frmLicenseKey 

    Private Sub frmLicenseKey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtAuthenticationKey.Text = AUTHENTICATION_KEY
        txtLicenseKey.Text = LICENSE_KEY

        lblAppStatus.Text = IIf(MODO_DEMO, "DEMO MODE", "FULL MODE")

    End Sub


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click

        Dim sFileName As String
        Dim sFileContents As String

        Try

            If txtLicenseKey.Text = LICENSE_KEY_OK Then

                ' Guardar el archivo
                LICENSE_KEY = LICENSE_KEY_OK
                sFileName = Application.StartupPath & "\LICINFO.DAT"

                sFileContents = "<EDR License Info v.1.00.000>" & vbCrLf & _
                                AUTHENTICATION_KEY & vbCrLf & _
                                LICENSE_KEY_OK & vbCrLf & _
                                LICENSE_KEY & vbCrLf & _
                                "</EDR License Info v.1.00.000>"

                If IO.File.Exists(sFileName) Then
                    IO.File.Delete(sFileName)
                End If

                IO.File.WriteAllText(sFileName, cEncrypt.EncryptString128Bit(sFileContents))

                MensajeInformacion("Thanks for registering this product. The application will work in full mode.")
                frmMain.LeerConnLocal()
                Me.Close()

            Else
                MensajeError("Invalid license key")
                txtLicenseKey.Focus()
            End If

        Catch ex As Exception
            TratarError(ex)
        End Try


    End Sub

End Class