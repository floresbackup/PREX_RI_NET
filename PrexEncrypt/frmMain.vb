Imports System.IO

Public Class frmMain
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        dialogCarpeta.SelectedPath = txtRutaGrabar.Text

        If dialogCarpeta.ShowDialog(Me) = DialogResult.OK Then
            txtRutaGrabar.Text = dialogCarpeta.SelectedPath
            txtUsuario.Select()
        End If

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        Dim sEncryptPath As String

        If DatosOK() Then

            If Strings.Right(txtRutaGrabar.Text, 1) = "\" Then
                txtRutaGrabar.Text = Strings.Left(txtRutaGrabar.Text, Len(txtRutaGrabar.Text) - 1)
            End If

            If rdoBtnSQL.Checked Then
                sEncryptPath = txtRutaGrabar.Text & "\PrExEncrypt.txt"
            Else
                sEncryptPath = txtRutaGrabar.Text & "\PrExEncr_RA.txt"
            End If

            GuardarArchivoEncriptado(sEncryptPath, txtUsuario.Text, TxtPassword.Text)

            MensajeInformacion("El USUARIO se ha encriptado exitosamente.")

            txtRutaGrabar.Text = ""
            txtUsuario.Text = ""
            TxtPasswordAnt.Text = ""
            TxtPassword.Text = ""
            TxtConfirma.Text = ""
            TxtPasswordAnt.BackColor = System.Drawing.Color.White ' &H80000005
            TxtPasswordAnt.Enabled = True


        End If
    End Sub

    Private Function Leer_Encrypt() As Boolean

        Dim sUsuario As String
        Dim sClave As String
        Dim sEncryptPath As String

        Leer_Encrypt = False

        If Strings.Right(txtRutaGrabar.Text, 1) = "\" Then
            txtRutaGrabar.Text = Strings.Left(txtRutaGrabar.Text, Len(txtRutaGrabar.Text) - 1)
        End If

        If rdoBtnSQL.Checked Then
            sEncryptPath = txtRutaGrabar.Text & "\PrExEncrypt.txt"
        Else
            sEncryptPath = txtRutaGrabar.Text & "\PrExEncr_RA.txt"
        End If

        Call LeerArchivoEncriptado(sEncryptPath, sUsuario, sClave)

        If sUsuario = txtUsuario.Text And sClave = TxtPasswordAnt.Text Then
            Leer_Encrypt = True
        End If

    End Function

    Public Sub GuardarArchivoEncriptado(ByVal sNombreArchivo As String, ByVal sNombreUsuario As String, ByVal sPassword As String)
        On Error Resume Next

        Dim oText As IO.StreamWriter
        oText = IO.File.CreateText(sNombreArchivo)
        oText.WriteLine(sBase64Encode(sNombreUsuario))
        oText.WriteLine(sBase64Encode(sPassword))
        oText.Close()
        oText = Nothing
    End Sub

    Public Sub LeerArchivoEncriptado(ByVal sNombreArchivo As String, ByRef sNombreUsuario As String, ByRef sPassword As String)
        On Error Resume Next

        Dim oText As StreamReader
        If File.Exists(sNombreArchivo) Then

            oText = IO.File.OpenText(sNombreArchivo)
            sNombreUsuario = sBase64Decode(oText.ReadLine).Replace(vbNullChar, String.Empty)
            sPassword = sBase64Decode(oText.ReadLine).Replace(vbNullChar, String.Empty)
            oText.Close()
            oText = Nothing
        Else
            MensajeError("No se encontró archivo existente")
        End If
    End Sub

    Public Function sBase64Decode(ByVal sCadena As String) As String
        'Return System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(sCadena))
        Return VB6Base64Decode(sCadena)
    End Function

    Public Function sBase64Encode(ByVal sCadena As String) As String
        'Return Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(sCadena))
        Return VB6Base64Encode(sCadena)
    End Function


    Private Sub TxtRutaGrabar_change() Handles txtRutaGrabar.TextChanged

        Dim sEncryptPath As String

        If Strings.Right(txtRutaGrabar.Text, 1) = "\" Then

            txtRutaGrabar.Text = Strings.Left(txtRutaGrabar.Text, Len(txtRutaGrabar) - 1)

        End If

        If rdoBtnSQL.Checked Then
            sEncryptPath = txtRutaGrabar.Text & "\PrExEncrypt.txt"
        Else
            sEncryptPath = txtRutaGrabar.Text & "\PrExEncr_RA.txt"
        End If

        If Dir(sEncryptPath) = "" Then

            TxtPasswordAnt.BackColor = System.Drawing.Color.SlateGray ' &H8000000F
            TxtPasswordAnt.Enabled = False
        Else
            TxtPasswordAnt.BackColor = System.Drawing.Color.White ' &H80000005
            TxtPasswordAnt.Enabled = True
        End If

    End Sub

    Public Sub MensajeError(ByVal sMensaje As String)
        MsgBox(sMensaje, vbExclamation, "Mensaje del sistema")
    End Sub

    Public Sub MensajeInformacion(ByVal sMensaje As String)
        MsgBox(sMensaje, vbInformation, "Mensaje del sistema")
    End Sub

    Private Function DatosOK() As Boolean

        If TxtPasswordAnt.Enabled = True Then
            If Not Leer_Encrypt() Then
                MensajeError("Usuario o contraseña incorrectos. Verifique.")
                txtUsuario.Select()
                Return False
            End If
        End If

        If Trim(txtRutaGrabar.Text) = "" Then
            MensajeError("Proporcione la ruta del archivo encriptado")
            txtRutaGrabar.Select()
            Return False
        End If

        If Trim(txtUsuario.Text) = "" Then
            MensajeError("Proporcione el nombre del usuario de conexión")
            txtUsuario.Select()
            Return False
        End If

        If TxtPasswordAnt.Enabled = True Then
            If Trim(TxtPasswordAnt.Text) = "" Then
                MensajeError("Proporcione la contraseña actual del usuario de conexión")
                TxtPasswordAnt.Select()
                Return False
            End If
        End If

        If Trim(TxtPassword.Text) = "" Then
            MensajeError("Proporcione la nueva contraseña del usuario de conexión")
            TxtPassword.Select()
            Return False
        End If

        If TxtPassword.Text <> TxtConfirma.Text Then
            MensajeError("La confirmación de la contraseña no coincide. Verifique")
            TxtConfirma.Select()
            Return False
        End If

        If Trim(TxtConfirma.Text) = "" Then
            MensajeError("Proporcione la confirmación de la contraseña del usuario de conexión")
            TxtConfirma.Select()
            Return False
        End If

        Return True

    End Function


End Class
