Public Class frmMain

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Public Function LicenseKey(ByVal sAuthenticationKey As String) As String

        Dim sValores() As String
        Dim nValor As Double
        Dim sBytes As String
        Dim i As Integer

        Try

            sValores = Split(sAuthenticationKey, "-")
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

            LicenseKey = sBytes

        Catch ex As Exception
            MessageBox.Show(ex.Message, "EDR Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LicenseKey = ""
        End Try

    End Function

    Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click

        If txtAuthKey.Text.Trim = "" Then
            MessageBox.Show("You must enter the authentication key", "EDR Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtLicenseKey.Text = LicenseKey(txtAuthKey.Text.Trim)
        End If
    End Sub
End Class
