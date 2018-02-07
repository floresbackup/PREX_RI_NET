Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports System.Threading

Public Class AdmUsuarios

   Private Enum TiposValidacion
      CantidadAlfa = 1
      CantidadNum = 2
      CantidadEsp = 3
   End Enum

   Private DIAS_ANTES_RENOVACION As Integer
   Private DIAS_VTO_PASSWORD As Integer
   Private CANT_PASS_CONTROLADAS As Integer
   Private INTENTOS_PARA_BLOQUEAR As Integer
   Private CANTIDAD_ALFA As Integer
   Private CANTIDAD_NUM As Integer
   Private CANTIDAD_ESP As Integer

   Private oAdmTablas As New AdmTablas

   Private Sub InicializarVariables()

      Dim sSQL As String
      Dim ds As DataSet

      sSQL = "SELECT    * " & _
             "FROM      DIRSEG " & _
             "WHERE     DS_VIGENT = 1"
      ds = oAdmTablas.AbrirDataset(sSQL)

      Try

         With ds.Tables(0).Rows(0)

            If ds.Tables(0).Rows.Count = 0 Then

               ' Valores x DEFAULT
               DIAS_ANTES_RENOVACION = 10
               DIAS_VTO_PASSWORD = 30
               CANT_PASS_CONTROLADAS = 3
               INTENTOS_PARA_BLOQUEAR = 3
               CANTIDAD_ALFA = 4
               CANTIDAD_NUM = 2
               CANTIDAD_ESP = 0

            Else

               DIAS_ANTES_RENOVACION = .Item("DS_DIASRE")
               DIAS_VTO_PASSWORD = .Item("DS_DIASVT")
               CANT_PASS_CONTROLADAS = .Item("DS_CANTPC")
               INTENTOS_PARA_BLOQUEAR = .Item("DS_INTBLO")
               CANTIDAD_ALFA = .Item("DS_PASCAR")
               CANTIDAD_NUM = .Item("DS_PASNUM")
               CANTIDAD_ESP = .Item("DS_PASESP")

            End If

         End With

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "InicializarVariables")
      End Try

   End Sub

   Public Function ValidarUsuario(ByVal sNombreUsuario As String, _
                                  ByVal sPassword As String, _
                                  ByVal nCodEntidad As Long, _
                                  ByRef nDiasParaCambioPassword As Double, _
                                  Optional ByRef sMotivoError As String = "", _
                                  Optional ByVal bIngresaSeguridad As Boolean = False) As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim sPasswordActual As String

      sSQL = "SELECT       * " & _
             "FROM         USUARI " & _
             "WHERE        US_NOMBRE = '" & sNombreUsuario & "'"
      ds = oAdmTablas.Abrirdataset(sSQL)


      If ds.Tables(0).Rows.Count = 0 Then
         sMotivoError = "El nombre de usuario proporcionado no existe"
      Else

         With ds.Tables(0).Rows(0)

            If (.Item("US_CODENT") <> nCodEntidad) And (.Item("US_CODENT") <> 0) Then
               sMotivoError = "El usuario proporcionado no pertenece a la entidad seleccionada"
               GoTo CerrarDataSet
            End If

            If .Item("US_BLOQUE") <> 0 Then
               sMotivoError = "El usuario se encuentra bloqueado para iniciar la sesiÛn"
            Else
               If .Item("US_FECBAJ") > CDate("01-01-1900") Then
                  sMotivoError = "El usuario proporcionado fue dado de baja"
               Else

                  If bIngresaSeguridad Then
                     If .Item("US_ADMIN") = 0 Then
                        sMotivoError = "No dispone de privilegios para ingresar a este mÛdulo"
                        GoTo CerrarDataSet
                     End If
                  End If

                  sPasswordActual = .Item("US_PASSWO")

                  If sPasswordActual <> CalculateMD5(sPassword) Then

                     sMotivoError = "La contraseÒa ingresada es incorrecta"

                     If .Item("US_GRACIA") > 1 Then
                        sSQL = "UPDATE    USUARI " & _
                               "SET       US_GRACIA = US_GRACIA - 1 " & _
                               "WHERE     US_NOMBRE = '" & sNombreUsuario & "'"
                        oAdmTablas.EjecutarComandoSQL(sSQL)
                     Else
                        sSQL = "UPDATE    USUARI " & _
                               "SET       US_GRACIA = 0, " & _
                               "          US_BLOQUE = 1  " & _
                               "WHERE     US_NOMBRE = '" & sNombreUsuario & "'"
                        oAdmTablas.EjecutarComandoSQL(sSQL)
                     End If

                  Else

                     sSQL = "UPDATE    USUARI " & _
                            "SET       US_GRACIA = " & INTENTOS_PARA_BLOQUEAR & " " & _
                            "WHERE     US_NOMBRE = '" & sNombreUsuario & "'"
                     oAdmTablas.EjecutarComandoSQL(sSQL)

                     If .Item("US_CODUSU") > 1 Then ' AL AdminPREX NO !!!
                        nDiasParaCambioPassword = DateDiff(DateInterval.Day, Date.Today, CDate(.Item("US_FECVTO")))
                     Else
                        nDiasParaCambioPassword = 32767
                     End If

                     Return True

                  End If

               End If
            End If

         End With

      End If

CerrarDataSet:
      ds = Nothing

   End Function

   Public Sub New()

      oAdmTablas.ConnectionString = CONN_LOCAL

   End Sub

   Public Function DevolverHabilitacionesUsuario(ByVal nCodUsuario As Long) As String

      Dim sSQL As String
      Dim rstAux As DataSet
      Dim sTemp As String = ""

      sSQL = "SELECT       DISTINCT DP_CODTRA " & _
             "FROM         HABILI, USUARI, CABPER, DETPER " & _
             "WHERE        HA_TIPOBJ = 'U' " & _
             "AND          HA_CODOBJ = " & nCodUsuario & " " & _
             "AND          HA_CODPER = CP_CODPER " & _
             "AND          CP_CODPER = DP_CODPER " & _
             "AND          US_CODUSU = HA_CODOBJ " & _
             "UNION        " & _
             "SELECT       DISTINCT DP_CODTRA " & _
             "FROM         HABILI, USUARI, CABPER, DETPER, GRUPOS, USUGRU " & _
             "WHERE        HA_TIPOBJ = 'G' " & _
             "AND          HA_CODOBJ IN (" & _
             "                           SELECT       GR_CODGRU " & _
             "                           FROM         GRUPOS, USUGRU " & _
             "                           WHERE        GR_CODGRU = UG_CODGRU " & _
             "                           AND          UG_CODUSU = " & nCodUsuario & ") " & _
             "AND          HA_CODPER = CP_CODPER " & _
             "AND          CP_CODPER = DP_CODPER " & _
             "AND          GR_CODGRU = HA_CODOBJ"
      rstAux = oAdmTablas.AbrirDataset(sSQL)

      For Each row As DataRow In rstAux.Tables(0).Rows
         sTemp = sTemp & row("DP_CODTRA") & ","
      Next

      rstAux = Nothing

      sSQL = "SELECT       * " & _
             "FROM         HABEXT " & _
             "WHERE        HE_CODUSU = " & nCodUsuario & " " & _
             "AND          HE_HABILI = 1 " & _
             "ORDER BY     HE_HABILI DESC"

      rstAux = oAdmTablas.AbrirDataset(sSQL)

      For Each row As DataRow In rstAux.Tables(0).Rows
         sTemp = sTemp & row("HE_CODTRA") & ","
      Next

      rstAux = Nothing

      If sTemp <> "" Then
         sTemp = Left(sTemp, Len(sTemp) - 1)
      End If

      Return sTemp

   End Function

   Public Function DevolverInhabilitacionesUsuario(ByVal nCodUsuario As Long) As String

      Dim sSQL As String
      Dim rstAux As DataSet
      Dim sTemp As String = ""

      sSQL = "SELECT       * " & _
             "FROM         HABEXT " & _
             "WHERE        HE_CODUSU = " & nCodUsuario & " " & _
             "AND          HE_HABILI = 0 " & _
             "ORDER BY     HE_HABILI DESC"

      rstAux = oAdmTablas.AbrirDataset(sSQL)

      For Each row As DataRow In rstAux.Tables(0).Rows
         sTemp = sTemp & row("HE_CODTRA") & ","
      Next

      rstAux = Nothing

      If sTemp <> "" Then
         sTemp = Left(sTemp, Len(sTemp) - 1)
      End If

      Return sTemp

   End Function

   Public Function CambiarPassword(ByVal sNombreUsuario As String, _
                                   ByVal sNuevaPassword As String, _
                                   Optional ByRef sMotivoError As String = "") As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder = Nothing
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim row As DataRow
      Dim sPasswordActual As String
      Dim nCont As Integer

      Try

         sMotivoError = ""

         sSQL = "SELECT    * " & _
                "FROM      USUARI " & _
                "WHERE     US_NOMBRE = '" & sNombreUsuario & "'"
         ds = oAdmTablas.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               sMotivoError = "El usuario proporcionado no existe"
            Else

               row = .Rows(0)

               If row("US_BLOQUE") <> 0 Or row("US_FECBAJ") > CDate("01-01-1900") Then
                  sMotivoError = "No se puede cambiar la contraseÒa - Usuario bloqueado o dado de baja"
               Else

                  If Date.Today.AddDays(DIAS_ANTES_RENOVACION) < row("US_FECVTO") Then
                     sMotivoError = "No se puede renovar la contraseÒa en este momento"
                  Else

                     sPasswordActual = row("US_PASSWO")

                     If CalculateMD5(sNuevaPassword) = sPasswordActual Then
                        sMotivoError = "ContraseÒa no v·lida para renovaciÛn"
                     Else

                        If CANT_PASS_CONTROLADAS > 0 Then

                           For nCont = 1 To CANT_PASS_CONTROLADAS

                              If CalculateMD5(sNuevaPassword) = row("US_PASS0" & nCont) Then
                                 sMotivoError = "Su nueva contraseÒa debe diferir de sus claves anteriores"
                                 Exit For
                              End If

                           Next

                        End If

                        If CANTIDAD_ALFA > 0 And sMotivoError = "" Then
                           If CantidadCaracteres(TiposValidacion.CantidadAlfa, sNuevaPassword) < CANTIDAD_ALFA Then
                              sMotivoError = "La cantidad de caracteres alfabÈticos ingresada no es suficiente para satisfacer la directiva de seguridad actual"
                           End If
                        End If

                        If CANTIDAD_NUM > 0 And sMotivoError = "" Then
                           If CantidadCaracteres(TiposValidacion.CantidadNum, sNuevaPassword) < CANTIDAD_NUM Then
                              sMotivoError = "La cantidad de caracteres numÈricos ingresada no es suficiente para satisfacer la directiva de seguridad actual"
                           End If
                        End If

                        If CANTIDAD_ESP > 0 And sMotivoError = "" Then
                           If CantidadCaracteres(TiposValidacion.CantidadEsp, sNuevaPassword) < CANTIDAD_ESP Then
                              sMotivoError = "La cantidad de caracteres especiales ingresada no es suficiente para satisfacer la directiva de seguridad actual"
                           End If
                        End If

                        If sMotivoError = "" Then
                           row("US_FECVTO") = Date.Today.AddDays(DIAS_VTO_PASSWORD)
                           row("US_PASS05") = row("US_PASS04")
                           row("US_PASS04") = row("US_PASS03")
                           row("US_PASS03") = row("US_PASS02")
                           row("US_PASS02") = row("US_PASS01")
                           row("US_PASS01") = sPasswordActual
                           row("US_ENCRYP") = ""
                           row("US_PASSWO") = CalculateMD5(sNuevaPassword)
                           row("US_GRACIA") = INTENTOS_PARA_BLOQUEAR

                           da.Update(ds)
                           ds.AcceptChanges()
                        End If

                     End If

                  End If
               End If
            End If

         End With

         ds = Nothing

         Return (sMotivoError = "")

      Catch ex As Exception
         sMotivoError = ex.Message
         Return False
      End Try

   End Function

   Public Function CambiarPasswordPorAdmin(ByVal sNombreUsuario As String, _
                                           ByVal sNuevaPassword As String, _
                                           Optional ByRef sMotivoError As String = "") As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder = Nothing
      Dim da As OleDb.OleDbDataAdapter = Nothing
      Dim row As DataRow
      Dim sPasswordActual As String

      Try

         sSQL = "SELECT    * " & _
                "FROM      USUARI " & _
                "WHERE     US_NOMBRE = '" & sNombreUsuario & "'"
         ds = oAdmTablas.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               sMotivoError = "El usuario proporcionado no existe"
            Else

               row = .Rows(0)

               If row("US_BLOQUE") <> 0 Or row("US_FECBAJ") > CDate("01-01-1900") Then
                  sMotivoError = "No se puede cambiar la contraseÒa - Usuario bloqueado o dado de baja"
               Else

                  sPasswordActual = row("US_PASSWO")

                  If row("US_CODUSU") > 1 Then
                     row("US_FECVTO") = Date.Today '.AddDays(DIAS_VTO_PASSWORD)
                  Else
                     row("US_FECVTO") = CDate("31-12-1999")
                  End If

                  row("US_PASS05") = row("US_PASS04")
                  row("US_PASS04") = row("US_PASS03")
                  row("US_PASS03") = row("US_PASS02")
                  row("US_PASS02") = row("US_PASS01")
                  row("US_PASS01") = sPasswordActual
                  row("US_ENCRYP") = ""
                  row("US_PASSWO") = CalculateMD5(sNuevaPassword)
                  row("US_GRACIA") = INTENTOS_PARA_BLOQUEAR

                  da.Update(ds)
                  ds.AcceptChanges()

               End If
            End If

         End With

         ds = Nothing

         Return (sMotivoError = "")

      Catch ex As Exception
         sMotivoError = ex.Message
      End Try

   End Function

   Private Function CantidadCaracteres(ByVal eTipoVal As TiposValidacion, ByVal sPassword As String) As Integer

      Dim sCadenaComp As String = ""
      Dim i As Integer
      Dim nTemp As Integer

      Select Case eTipoVal
         Case TiposValidacion.CantidadAlfa
            sCadenaComp = "abcdefghijklmnÒopqrstuvwxyz·ÈÌÛ˙‰ÎÔˆ¸ABCDEFGHIJKLMN—OPQRSTUVWXYZ¡…Õ”⁄ƒÀœ÷‹"
         Case TiposValidacion.CantidadNum
            sCadenaComp = "1234567890"
         Case TiposValidacion.CantidadEsp
            sCadenaComp = "|∞!#$%&/()=?°ø'¥+®*}]{[-_.:,;^~\<>"
      End Select

      For i = 0 To sPassword.Length - 1
         If sCadenaComp.IndexOf(sPassword.Substring(i, 1)) > 0 Then
            '            If InStr(1, sCadenaComp, Mid(sPassword, i, 1)) > 0 Then
            nTemp = nTemp + 1
         End If
      Next

      Return nTemp

   End Function

   Public Function AsignarPerfilObjeto(ByVal sTipoObjeto As String, _
                                       ByVal nCodObjeto As Long, _
                                       ByVal nCodPerfil As Long, _
                                       Optional ByRef sMotivoError As String = "") As Boolean
      Dim sSQL As String
      Dim ds As DataSet
      Dim bResult As Boolean = False

      Try

         If sTipoObjeto = "G" Then

            sSQL = "SELECT    * " & _
                   "FROM      GRUPOS " & _
                   "WHERE     GR_CODGRU = " & nCodObjeto

         Else

            sSQL = "SELECT    * " & _
                   "FROM      USUARI " & _
                   "WHERE     US_CODUSU = " & nCodObjeto

         End If

         ds = oAdmTablas.AbrirDataset(sSQL)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               sMotivoError = "Usuario o grupo de usuarios inexistente"
               Exit Try
            End If

         End With

         sSQL = "DELETE    " & _
                "FROM      HABILI " & _
                "WHERE     HA_TIPOBJ = '" & sTipoObjeto & "' " & _
                "AND       HA_CODOBJ = " & nCodObjeto & " " & _
                "AND       HA_CODPER = " & nCodPerfil & " "
         oAdmTablas.EjecutarComandoAsincrono(sSQL)

         sSQL = "INSERT   " & _
                "INTO     HABILI (HA_TIPOBJ, HA_CODOBJ, HA_CODPER) " & _
                "VALUES   ('" & sTipoObjeto & "', " & nCodObjeto & ", " & nCodPerfil & ")"
         bResult = oAdmTablas.EjecutarComandoSQL(sSQL)

      Catch ex As Exception
         sMotivoError = ex.Message
      End Try

      ds = Nothing
      Return bResult

   End Function

End Class
