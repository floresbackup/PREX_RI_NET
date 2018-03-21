Imports System.Windows.Forms

Public Class frmOrigenDB

   Private nModoDB As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If DatosOK() Then
         DevolverCadena()
         Me.DialogResult = System.Windows.Forms.DialogResult.OK
         Me.Close()
      End If

   End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

   Public Sub Modo(ByVal nModo As Integer, Optional ByVal sArchivo As String = "")

      nModoDB = nModo

      Select Case nModo

         Case 1
            lblTitulo.Text = "Orígen Access"
            lblSubtitulo.Text = "Indique el usuario y contraseña Access si existe."
            txtDB.Text = sArchivo
            txtDB.Enabled = False
            Usuario.Text = "Admin"

         Case 2
            Servidor.Text = sArchivo
            txtDB.Enabled = True
            txtDB.Text = ""

         Case 3
            txtDB.Text = sArchivo
            DevolverCadena()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

      End Select

      lblServer.Enabled = (nModo = 2)
      Servidor.Enabled = (nModo = 2)
      chkNT.Enabled = (nModo = 2)

   End Sub

   Private Sub chkNT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNT.CheckedChanged

      Usuario.Enabled = (Not chkNT.Checked)
      Pass.Enabled = (Not chkNT.Checked)

   End Sub

   Private Function DatosOK() As Boolean

      If nModoDB = 2 And Servidor.Text.Trim = "" Then
         MensajeError("Debe especificar un servidor SQL")
         Servidor.Focus()
         Exit Function
      End If

      If Usuario.Text.Trim = "" And (Not chkNT.Checked) Then
         MensajeError("Debe especificar un nombre de usuario")
         Usuario.Focus()
         Exit Function
      End If

      DatosOK = True

   End Function

   Private Sub DevolverCadena()

      Select Case nModoDB

         Case 1
            ADOTEMP = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtDB.Text.Trim & ";Persist Security Info=False;Jet OLEDB:Database Password=" & Usuario.Text.Trim
            OLEDBDin = "OPENROWSET('Microsoft.Jet.OLEDB.4.0','" & TempOrigServidor() & System.IO.Path.GetFileName(txtDB.Text.Trim) & "';'" & Usuario.Text & "';'" & Pass.Text & "','SELECT * FROM "

         Case 2
            If chkNT.Checked Then
               ADOTEMP = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & txtDB.Text & ";Data Source=" & Servidor.Text
               OLEDBDin = "OPENROWSET('MSDASQL','DRIVER={SQL Server};SERVER=" & Servidor.Text & ";trusted_connection=yes;Integrated Security=SSPI', 'SELECT * FROM [" & txtDB.Text & "].dbo."
            Else
               ADOTEMP = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=" & Usuario.Text & ";Initial Catalog=" & txtDB.Text & ";Data Source=" & Servidor.Text & ";Password=" & Pass.Text
               OLEDBDin = "OPENROWSET('MSDASQL','DRIVER={SQL Server};SERVER=" & Servidor.Text & ";UID=" & Usuario.Text & ";PWD=" & Pass.Text & "',' * FROM [" & txtDB.Text & "].dbo."
            End If

            INPUT_GENERAL = Servidor.Text

         Case 3
            ADOTEMP = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtDB.Text & ";Extended Properties=DBASE IV;;"
            OLEDBDin = "OPENROWSET('MSDASQL','Driver={Microsoft dBase Driver (*.dbf)};DBQ=" & TempOrigServidor() & "','SELECT * FROM "

      End Select

   End Sub

End Class
