Imports System.IO

Module modFunciones

   Public Sub LeerXML()

      Try

         Dim sTemp As String

         If File.Exists(ARCHIVO_CONFIG) Then
            oConfig.ReadXml(ARCHIVO_CONFIG)

            For Each row As DataRow In oConfig.Tables("CONFIG").Rows

               sTemp = row("VALOR").ToString

               Select Case row("NOMBRE").ToString

                  Case "CONN_LOCAL"
                     CONN_LOCAL = System.Text.ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(sTemp))

                  Case "FFECHA"
                     FORMATO_FECHA = sTemp

                  Case "CARPETA_LOCAL"
                     CARPETA_LOCAL = sTemp

                  Case "NOMBRE_INI_LOCAL"
                     NOMBRE_INI_LOCAL = sTemp

               End Select

               Application.DoEvents()
            Next

         End If

      Catch ex As Exception
         TratarError(ex, "LeerXML")
      End Try

   End Sub

   Public Sub TratarError(ByVal ex As Exception, _
                          ByVal sFuncion As String, _
                          Optional ByVal sCustomError As String = "", _
                          Optional ByVal bGuadaLog As Boolean = True)

      Dim frm As New frmError

      frm.txtCodigo.Text = ex.StackTrace
      frm.txtOrigen.Text = ex.Source
      frm.txtFuncion.Text = sFuncion
      frm.txtFecha.Text = System.DateTime.Today.ToShortDateString
      frm.txtHora.Text = System.DateTime.Now.ToShortTimeString

      If sCustomError <> "" Then
         frm.txtDescripcion.Text = sCustomError
      Else
         frm.txtDescripcion.Text = ex.Message
      End If

      If bGuadaLog Then
         '        GuardarLOG(AL_ERROR_SISTEMA, .Description & vbCrLf & vbCrLf & "Función/Proc.: " & sFuncion, CODIGO_TRANSACCION)
      End If

      frm.ShowDialog()

   End Sub

End Module
