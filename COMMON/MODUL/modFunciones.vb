Imports System.IO

Module modFunciones

   Public Enum eTipoDatoADO
      eNumero = 0
      eTexto = 1
      eFecha = 2
   End Enum

   Public Sub LeerXML()

      Try

         Dim sTemp As String

            If Not File.Exists(ARCHIVO_CONFIG) Then
                'ARCHIVO_CONFIG = ARCHIVO_CONFIG_DEV
                MensajeError("No se encuentra el archivo encriptado con la conexion SQL")
            End If

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
                            CARPETA_LOCAL = NormalizarRuta(sTemp)

                        Case "NOMBRE_INI_LOCAL"
                            NOMBRE_INI_LOCAL = sTemp

                        Case "AUTENTICACIONSQL"
                            AUTENTICACIONSQL = CBool(sTemp)

                        Case "SEGURIDAD_INTEGRADA"
                            SEGURIDAD_INTEGRADA = CBool(sTemp)

                        Case "NOMBRE_SQLSERVER"
                            NOMBRE_SQLSERVER = sTemp

                        Case "NOMBRE_EMPRESA"
                            NOMBRE_EMPRESA = sTemp

                        Case "IDENTIFICACION_PC"
                            IDENTIFICACION_PC = sTemp

                        Case "LOG_AUDITORIA"
                            LOG_AUDITORIA = sTemp

                        Case "NOMBRE_BD"
                            NOMBRE_BD = sTemp

                        Case "ID_SISTEMA"
                            ID_SISTEMA = Val(sTemp)

                        Case "SG_CONFIG"
                            SG_CONFIG = sTemp

                        Case "SIMBOLO_DECIMAL"
                            SIMBOLO_DECIMAL = sTemp.Substring(0, 1)

                        Case "RUTA_AYUDA"
                            RUTA_AYUDA = sTemp

                    End Select

            Next

         End If

         If AUTENTICACIONSQL Then

            If File.Exists(CARPETA_LOCAL & "TEMP\conn.enc") Then

               Dim sUser As String = ""
               Dim sPass As String = ""

               LeerArchivoEncriptado(CARPETA_LOCAL & "TEMP\conn.enc", sUser, sPass)
               CONN_LOCAL = CONN_LOCAL & ";User id=" & sUser & ";Password=" & sPass & ";"

            Else

               If Command().Trim <> "" And Command().ToUpper <> "/IDE" Then

                  MensajeError("No se encuentra el archivo encriptado con la conexion SQL")
                  End

               End If

            End If

         End If

      Catch ex As Exception
         TratarError(ex, "LeerXML")
      End Try

   End Sub

   Public Sub TratarError(ByVal ex As Exception, _
                          Optional ByVal sFuncion As String = "", _
                          Optional ByVal sCustomError As String = "", _
                          Optional ByVal bGuardaLog As Boolean = True)

      Dim frm As New frmError

      frm.txtCodigo.Text = ex.GetHashCode.ToString
      frm.txtOrigen.Text = ex.Source & " - " & ex.TargetSite.Name
      frm.txtFuncion.Text = IIf(sFuncion = "", "", sFuncion)
      frm.txtFecha.Text = System.DateTime.Today.ToShortDateString
      frm.txtHora.Text = System.DateTime.Now.ToShortTimeString

      If sCustomError <> "" Then
         frm.txtDescripcion.Text = sCustomError
      Else
         frm.txtDescripcion.Text = ex.Message
      End If

      frm.txtDescripcion.Text = frm.txtDescripcion.Text & vbCrLf & vbCrLf & "TRAZA:" & vbCrLf & ex.StackTrace
      If bGuardaLog Then
         '        GuardarLOG(AL_ERROR_SISTEMA, .Description & vbCrLf & vbCrLf & "Función/Proc.: " & sFuncion, CODIGO_TRANSACCION)
      End If

      frm.ShowDialog()

   End Sub

   Public Sub TratarErrorErr(ByVal ex As ErrObject, _
                       Optional ByVal sFuncion As String = "", _
                       Optional ByVal sCustomError As String = "", _
                       Optional ByVal bGuardaLog As Boolean = True)

      TratarError(ex.GetException(), sFuncion, sCustomError, bGuardaLog)

   End Sub

   Public Function FlotanteSQL(ByVal nNumero As Double) As String

      Return Format(nNumero, "Fixed").Replace(",", ".")

   End Function

   Public Function FechaSQL(ByVal dFecha As Date) As String

      Return "'" & Format(dFecha, FORMATO_FECHA) & "'"

   End Function

   Public Function Pregunta(ByVal sMensaje As String) As DialogResult

      Return MsgBox(sMensaje, vbQuestion + vbYesNo, "Pregunta")

   End Function

   Public Sub MensajeInformacion(ByVal sMensaje As String)

      MsgBox(sMensaje, vbInformation, "Mensaje del sistema")

   End Sub

   Public Sub MensajeError(ByVal sMensaje As String)

      MsgBox(sMensaje, vbExclamation, "Mensaje del sistema")

   End Sub

   Public Function TipoDatosADO(ByVal nTipo As Integer, Optional ByRef nTipoDato As Integer = 0) As String

      Select Case nTipo

         Case 7, 133, 134, 135
            Return "Fecha/Hora"
            nTipoDato = 2
         Case 128, 136, 129, 200, 202, 130, 8, 201, 203
            Return "Texto"
            nTipoDato = 1
         Case Else
            Return "Numérico"
            nTipoDato = 0

      End Select

   End Function

   Public Function TipoDatoADO(ByVal nTipo As Integer) As eTipoDatoADO

      Select Case nTipo
         Case 7, 133, 134, 135
            Return eTipoDatoADO.eFecha
         Case 128, 136, 129, 200, 202, 130, 8, 201, 203
            Return eTipoDatoADO.eTexto
         Case Else
            Return eTipoDatoADO.eNumero
      End Select

   End Function

   'Seleccióna un campo especificado de un ImageCombo a partir de la "Key".
   Public Sub SelCombo(ByVal oCombo As Object, ByVal sCadena As String)

      Dim oItem As clsItem.Item

      For Each oItem In oCombo.Items
         If oItem.Nombre.ToUpper = sCadena.ToUpper Then
            oCombo.SelectedItem = oItem
         End If
      Next

   End Sub

   'Seleccióna un campo especificado de un ImageCombo a partir de la "Key".
   Public Sub SelComboDevExpress(ByVal oCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal sCadena As String)

      Dim oItem As clsItem.Item

      For Each oItem In oCombo.Properties.Items
         If "K" & oItem.Valor.ToString.ToUpper = sCadena.ToUpper Then
            oCombo.SelectedItem = oItem
         End If
      Next

   End Sub

   'Seleccióna un item de un combo box o list box
   Public Sub SelComboBox(ByVal oCombo_List As Object, ByVal sCadena As String)

      Dim oItem As clsItem.Item

      For Each oItem In oCombo_List.Items
            If oItem.Valor.ToUpper = sCadena.ToUpper Then
                oCombo_List.SelectedItem = oItem
            End If
        Next

   End Sub

   Public Sub SelItemCombo(ByVal oCombo As Object, ByVal nCodigo As Long)

      Dim oItem As clsItem.Item

      For Each oItem In oCombo.Items
         If oItem.Valor = nCodigo Then
            oCombo.SelectedItem = oItem
         End If
      Next

   End Sub

   Public Sub CargarCombo(ByVal oCombo As Object, ByVal sSQL As String)

      Dim ad As OleDb.OleDbDataAdapter
      Dim dt As DataTable
      Dim dr As DataRow
      Dim nC As Integer = 0

      Try

         ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
         dt = New DataTable

         ad.Fill(dt)

         oCombo.Items.Clear()

         For Each dr In dt.Rows
            oCombo.Items.Add(New clsItem.Item(Convert.ToInt64(dr(0).ToString), dr(1).ToString))
         Next

         Application.DoEvents()

      Catch ex As Exception
         TratarError(ex, "CargarCombo")
      End Try

   End Sub

   Public Sub AgregarItemCombo(ByVal oCombo As Object, ByVal nCodigo As Long, ByVal sDescripcion As String)

      Try

         oCombo.Items.Add(New clsItem.Item(nCodigo, sDescripcion))

      Catch ex As Exception
         TratarError(ex, "AgregarItemCombo")
      End Try

   End Sub

   Public Sub QuitarItemCombo(ByVal oCombo As Object, ByVal nCodigo As Long)

      Try

         For Each item As clsItem.Item In oCombo.Items
            If item.Valor = nCodigo Then
               oCombo.Items.Remove(item)
               Exit For
            End If
         Next

      Catch ex As Exception
         TratarError(ex, "QuitarItemCombo")
      End Try

   End Sub

   Public Function NormalizarRuta(ByVal sRuta As String) As String

      If Right(sRuta, 1) <> "\" Then
         NormalizarRuta = sRuta & "\"
      Else
         NormalizarRuta = sRuta
      End If

   End Function

   Public Sub CargarComboDevExpress(ByVal oCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal sSQL As String)

      Dim ad As OleDb.OleDbDataAdapter
      Dim dt As DataTable
      Dim oRow As DataRow
      Dim oItem As clsItem.Item

      Try
         oCombo.Properties.Items.Clear()

         ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
         dt = New DataTable

         ad.Fill(dt)

         For Each oRow In dt.Rows

            oItem.Valor = oRow(0)
            oItem.Nombre = oRow(1).ToString
            oCombo.Properties.Items.Add(oItem)

         Next

      Catch ex As Exception
         'nada
      End Try

   End Sub

   'Obtiene el Key de un ImageCombo o ListView.
   Public Function Llave(ByVal oLlave As Object) As String

      Dim oItem As clsItem.Item

      If Not (oLlave.SelectedItem Is Nothing) Then
         oItem = oLlave.SelectedItem
            Return oItem.Valor.ToString.TrimEnd.Substring(1)
        Else
         Return "0"
      End If

   End Function

   'Obtiene el Key de un ImageCombo o ListView.
   Public Function LlaveCombo(ByVal oLlave As Object) As Object

      Dim oItem As clsItem.Item

      If Not (oLlave.SelectedItem Is Nothing) Then
         oItem = oLlave.SelectedItem
         Return oItem.Valor
      Else
         Return Nothing
      End If

   End Function

   'Alias creado para compatibilidad con la versión anterior del sistema
   Public Function sBase64Decode(ByVal sCadena As String) As String
      'Return System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(sCadena))
      Return VB6Base64Decode(sCadena)
   End Function

   Public Function sBase64Encode(ByVal sCadena As String) As String
      'Return Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(sCadena))
      Return VB6Base64Encode(sCadena)
   End Function

   Public Function FechaCorrecta(ByVal nMes As Integer, ByVal nAnio As Integer) As Date

      Dim i As Integer
      Dim sTemp As String

      For i = 31 To 28 Step -1

         sTemp = Format(i, "00") & "-" & Format(nMes, "00") & "-" & nAnio

         If IsDate(sTemp) Then

            Return CDate(sTemp)
            Exit Function

         End If

      Next

   End Function

   Public Function RellenarCadena(ByVal sCadena As String, ByVal nCantCaracteres As Integer) As String

      Dim nLen As Integer

      nLen = Len(sCadena)

      If nLen >= nCantCaracteres Then
         RellenarCadena = Left(sCadena, nCantCaracteres)
      Else
         RellenarCadena = sCadena & "".PadLeft(nCantCaracteres - nLen, " ")
      End If

   End Function

   Public Function UnAnioMenos(ByVal dFecha As Date) As Date

      Dim nAnio As Integer
      Dim nMes As Integer
      Dim nDia As Integer
      Dim sDate As String

      nAnio = Year(dFecha) - 1
      nMes = Month(dFecha)
      nDia = dFecha.Day

      sDate = nDia & "/" & nMes & "/" & nAnio

      Do Until IsDate(sDate)
         nDia = nDia - 1
         sDate = nDia & "/" & nMes & "/" & nAnio
      Loop

      UnAnioMenos = CDate(sDate)

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

      oText = IO.File.OpenText(sNombreArchivo)
      sNombreUsuario = sBase64Decode(oText.ReadLine)
      sPassword = sBase64Decode(oText.ReadLine)
      oText.Close()

      oText = Nothing

   End Sub

   Public Sub GuardarLOG(ByVal nAccionLOG As AccionesLOG, _
                         ByVal sExtra As String, _
                         Optional ByVal nCodigoTransaccion As Long = -1, _
                         Optional ByVal nCodigoUsuario As Long = -1)

      On Error Resume Next

      Dim oAdmLOG As New AdmTablas
      Dim sSQL As String

      oAdmLOG.ConnectionString = CONN_LOCAL

      If nCodigoUsuario = -1 Then nCodigoUsuario = UsuarioActual.Codigo
      If nCodigoTransaccion = 0 Then nCodigoTransaccion = -1

        sSQL = "INSERT " &
             "INTO 			LOGSIS " &
             "					( " &
             "						LS_CODUSU, " &
             "						LS_FECLOG, " &
             "						LS_HORLOG, " &
             "						LS_ACCION, " &
             "						LS_CODTRA, " &
             "						LS_EXTRA, " &
             "                      LS_WKSTAT " &
             "					) " &
             "VALUES " &
             "					( " &
             "						@CODUSU, " &
             "						@FECLOG, " &
             "						@HORLOG, " &
             "						@ACCION, " &
             "						@CODTRA, " &
             "						@EXTRA, " &
             "                      @WKSTAT) "

        sSQL = sSQL.Replace("@CODUSU", nCodigoUsuario)
        sSQL = sSQL.Replace("@FECLOG", "'" & DateTime.Now.ToString("yyyy-MM-dd") & "'")
        sSQL = sSQL.Replace("@HORLOG", "'" & Format(DateTime.Now, "HH:mm:ss") & "'")
        sSQL = sSQL.Replace("@ACCION", nAccionLOG)
        sSQL = sSQL.Replace("@CODTRA", nCodigoTransaccion)
        sSQL = sSQL.Replace("@EXTRA", "'" & sExtra & "'")
        sSQL = sSQL.Replace("@WKSTAT", "'" & System.Environment.MachineName & "'")

        oAdmLOG.EjecutarComandoAsincrono(sSQL)

      oAdmLOG = Nothing

   End Sub

   Public Function CalculateMD5(ByVal sCadena As String) As String

      Dim sRetorno As String = ""
      Dim oMD5 As New Security.Cryptography.MD5CryptoServiceProvider
      Dim oHash() As Byte = System.Text.Encoding.ASCII.GetBytes(sCadena)

      oHash = oMD5.ComputeHash(oHash)

      For Each b As Byte In oHash
         sRetorno += b.ToString("x2")
      Next

      Return sRetorno

   End Function

   Public Function ValGrilla(ByVal oGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal sCampo As String) As Object

      Dim vResult As Object

      vResult = oGridView.GetDataRow(oGridView.FocusedRowHandle).Item(sCampo)

      Return vResult

   End Function

   Public Function FiltrarNumero(ByVal sChar As Char) As Char

      Dim nKey As Integer = Asc(sChar)

      Return IIf((nKey >= 48 And nKey <= 57) Or nKey = 8, Chr(nKey), Chr(0))

   End Function

   Public Function FiltrarFlotante(ByVal sChar As Char) As Char

      Dim nKey As Integer = Asc(sChar)

      If nKey = Asc(".") Or nKey = Asc(",") Then
         nKey = Asc(SIMBOLO_DECIMAL)
      End If

      Return IIf(FiltrarNumero(Chr(nKey)) <> Chr(0) Or nKey = Asc(SIMBOLO_DECIMAL), Chr(nKey), Chr(0))

   End Function

   Public Function VerificaCUIT(ByVal sCUIT As String) As Boolean

      Dim nResult(11) As Double
      Dim Multiplic(10) As Double
      Dim nCont As Integer

      'Verifico que el cuit ingresado sea numérico y tenga 11 números
      If (Not IsNumeric(sCUIT)) Or (Len(sCUIT) < 11) Then
         Exit Function
      End If

      'Cargo los valores de multiplicación
      Multiplic(1) = 6
      Multiplic(2) = 7
      Multiplic(3) = 8
      Multiplic(4) = 9
      Multiplic(5) = 4
      Multiplic(6) = 5
      Multiplic(7) = 6
      Multiplic(8) = 7
      Multiplic(9) = 8
      Multiplic(10) = 9

      'Multiplico cada número del CUIT por los valores de multiplicación
      'de correspondiente y luego voy sumandolos en la variable nResult(11)
      For nCont = 1 To 10
         nResult(nCont) = Val(Mid(sCUIT, nCont, 1)) * Multiplic(nCont)
         nResult(11) = nResult(11) + nResult(nCont)
      Next nCont

      'Si el residuo del resultado dividido 11 es igual al digito verificador entonces TRUE
      If (nResult(11) Mod 11) = Val(Right(sCUIT, 1)) Then
         Return True
      End If

   End Function

   Public Sub Ayuda()

      On Error Resume Next

      Dim sTemp As String
      Dim oTrx As New System.Diagnostics.Process

      sTemp = Replace(RUTA_AYUDA, UCase("|TRANSACCION|"), CODIGO_TRANSACCION)

      oTrx.StartInfo.FileName = sTemp
      oTrx.StartInfo.UseShellExecute = True
      oTrx.Start()

   End Sub

   Public Function NoNulo(ByVal vValor As Object, Optional ByVal bDevolverString As Boolean = True) As Object
      If IsDBNull(vValor) Then
         If bDevolverString Then
            Return ""
         Else
            Return 0
         End If
      Else
         Return vValor
      End If
   End Function

End Module
