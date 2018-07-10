
Module modLocalMain

   Public NOMBRE_NUEVA_TABLA As String
   Public DESCRIPCION_NUEVA_TABLA As String
   Public FECHA_VIG_NUEVA_TABLA As Date

   Public TABLA_DESTINO As String
   Public ADOTEMP As String
   Public OLEDBDin As String

   Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Object, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long

   Private Declare Function WritePrivateProfileString _
      Lib "kernel32" Alias "WritePrivateProfileStringA" _
     (ByVal lpSectionName As String, _
      ByVal lpKeyName As String, _
      ByVal lpString As String, _
      ByVal lpFileName As String) As Long


   Public Enum eTipoDatosCampos
      tdcNumeroEntero = 0
      tdcNumero2Decimales = 2
      tdcNumero4Decimales = 4
      tdcNumero6Decimales = 6
      tdcTexto = 84
      tdcFecha = 70
   End Enum

   Public Enum eValidacionCampos
      vcSinValidacion = 0
      vcValidaFecha = 1
      vcValidaEntidad = 2
      vcValidaCuenta = 3
      vcConvierteAdecimal = 50
      vcIncorporaEntidad = 98
      vcIncorporaFecha = 99
   End Enum

    Sub Main()

        'Configuración
        LeerXML()

        CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
        CulturaCargarTextos(CulturaActual.ToString)
        If Not frmMain.ErrorPermiso Then
            frmMain.ShowDialog()
        End If

    End Sub

    Public Function TempOrig() As String

      TempOrig = ""

      Try

         Dim ds As DataSet
         Dim oAdmTablas As New AdmTablas
         Dim sSQL As String

         oAdmTablas.ConnectionString = CONN_LOCAL

         sSQL = "SELECT    TG_ALFA01 " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 10 " & _
                "AND       TG_CODCON = 1 "
         ds = oAdmTablas.AbrirDataset(sSQL)

         If ds.Tables(0).Rows.Count = 0 Then
            MensajeError("Debe parametrizar la ruta de acceso en el servidor de bases de datos para archivos de origen con LinkedServer (Tabla general 10).")
         Else
            Return NormalizarRuta(ds.Tables(0).Rows(0).Item("TG_ALFA01"))
         End If

         If Not System.IO.File.Exists(TempOrig) Then
            MensajeError("No tiene acceso a la ruta de origenes de datos o se encuentra mal parametrizada(Tabla general 10)")
            Return ""
         End If

         ds = Nothing
         oAdmTablas = Nothing

      Catch ex As Exception
         TratarError(ex, "TempOrig")
      End Try

   End Function

   Public Function TempOrigServidor() As String

      Dim oAdmTablas As New AdmTablas

      oAdmTablas.ConnectionString = CONN_LOCAL

      Return NormalizarRuta(oAdmTablas.DevolverValor("TABGEN", "TG_ALFA01", "TG_CODTAB=10 AND TG_CODCON=1", ""))

      oAdmTablas = Nothing

   End Function

   Public Sub EscribirINI(ByVal sModulo As String, ByVal sLlave As String, ByVal sValor As String, ByVal sArchivo As String)

      WritePrivateProfileString(sModulo, sLlave, sValor, sArchivo)

   End Sub

   Public Function TipoDatosCampo(ByVal sTipo As String) As eTipoDatosCampos

      If Left(sTipo, 1) = "N" Then
         TipoDatosCampo = Val(Right(sTipo, 1))
      Else
         TipoDatosCampo = Asc(Trim(sTipo))
      End If

   End Function

   Public Function TipoDatosCampoChar(ByVal eTipo As eTipoDatosCampos) As String

      If eTipo = eTipoDatosCampos.tdcTexto Or eTipo = eTipoDatosCampos.tdcFecha Then
         TipoDatosCampoChar = Chr(eTipo) & " "
      Else
         TipoDatosCampoChar = "N" & eTipo
      End If

   End Function

   Public Function TipoDatosSQL(ByVal sTipo As String, ByVal nLongitud As Long) As String

      Dim sTipoDato As String = "[varchar] (50)"

      Select Case Left(sTipo, 1)

         Case "N"
            sTipoDato = "[Numeric] (18," & nLongitud & ")"

         Case "F"
            sTipoDato = "[datetime]"

         Case "T"
            If nLongitud = 0 Then
               nLongitud = 50
            End If
            sTipoDato = "[varchar] (" & nLongitud & ")"

      End Select

      Return sTipoDato

   End Function
End Module
