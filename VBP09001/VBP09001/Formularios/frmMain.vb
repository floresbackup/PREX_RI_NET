Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmMain

   Private oAdmLocal As New AdmTablas
   Private dFechaProx As Date
   Private Formato As New Collection

   Public Sub AnalizarCommand()

      Try

         Dim sParametros() As String
         Dim sItemParam() As String
         Dim nCodigoUsuario As Long
         Dim nCodigoTransaccion As Long
         Dim nCodigoEntidad As Long
         Dim nC As Integer

         '''''' USUARIO ''''''

         sParametros = Command.Split("/")

         For nC = 0 To sParametros.Length - 1

            sItemParam = sParametros(nC).Trim.Split(":")

            If sItemParam.Length = 2 Then

               Select Case sItemParam(0).Trim.ToUpper
                  Case "U"
                     nCodigoUsuario = Val(sItemParam(1))
                  Case "T"
                     nCodigoTransaccion = Val(sItemParam(1))
                  Case "E"
                     nCodigoEntidad = Val(sItemParam(1))
               End Select

            End If
         Next

         If nCodigoUsuario = 0 Then
            MensajeError("El parámetro código usuario es inválido.")
            Application.Exit()
         End If

         If nCodigoTransaccion = 0 Then
            MensajeError("El parámetro código de transacción es inválido.")
            Application.Exit()
         End If

         If nCodigoEntidad = 0 Then
            MensajeError("El parámetro código de entidad es inválido.")
            Application.Exit()
         End If

         CODIGO_TRANSACCION = nCodigoTransaccion
         CODIGO_ENTIDAD = nCodigoEntidad

         PresentarDatos(nCodigoTransaccion, nCodigoUsuario, nCodigoEntidad)

      Catch ex As Exception
         TratarError(ex, "AnalizarCommand")
         Application.Exit()
      End Try

   End Sub

   Private Sub PresentarDatos(ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)

      Try

         Dim sSQL As String
         Dim ds As DataSet
         Dim sError As String = ""

         ''''' USUARIO '''''

         sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " & _
                "FROM      USUARI " & _
                "WHERE     US_CODUSU = " & nCodigoUsuario
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               sError = "Falla de seguridad"
            Else
               UsuarioActual.Codigo = nCodigoUsuario
               UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE")
               UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI")
               UsuarioActual.Admin = .Rows(0).Item("US_ADMIN")
               UsuarioActual.SoloLectura = False
               lblUsuario.Text = UsuarioActual.Descripcion
            End If

         End With

         ds = Nothing

         ''''' ENTIDAD '''''

         sSQL = "SELECT    TG_CODCON, TG_DESCRI " & _
                "FROM      TABGEN " & _
                "WHERE     TG_CODTAB = 1 " & _
                "AND       TG_CODCON = " & nCodigoEntidad
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               sError = "Parámetro de entidad no válido"
            Else
               NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI")
               lblEntidad.Text = NOMBRE_ENTIDAD
            End If

         End With

         ds = Nothing

         ''''' TRANSACCION '''''

         sSQL = "SELECT    MU_TRANSA, MU_DESCRI " & _
                "FROM      MENUES " & _
                "WHERE     MU_CODTRA = " & nCodigoTransaccion
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)


            If .Rows.Count = 0 Then
               sError = "Error en la línea de comandos. Parámetro de transacción incorrecto"
            Else
               lblTransaccion.Text = .Rows(0).Item("MU_DESCRI")
               Me.Text = CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA")
            End If

         End With

         ds = Nothing

         lblVersion.Text = "Versión: " & Application.ProductVersion

         If sError <> "" Then
            MensajeError(sError)
            Application.Exit()
         End If

      Catch ex As Exception
         TratarError(ex, "AnalizarCommand")
         Application.Exit()
      End Try

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL
      AnalizarCommand()



   End Sub

   Public Sub Cargar()

      CargarArchivos()
      IniciarControles()
      txtCarpeta.Text = NormalizarRuta(Application.StartupPath)

      Dim sRutaDefault As String
      Dim nOpcionRuta As Integer

        'nOpcionRuta = Val(NoNulo(oAdmLocal.DevolverValor("TABGEN", "TG_NUME01", "TG_CODTAB=10 AND TG_CODCON=1000", ""), False))
        'sRutaDefault = NoNulo(oAdmLocal.DevolverValor("TXTNOM", "TN_RUTA", "TG_CODTAB=10 AND TG_CODCON=1000", "Ruta"))



        txtCarpeta.Text = CARPETA_LOCAL
        txtCarpeta.Enabled = True


    End Sub

   Private Function PreparaTXT_5603(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

      Dim sSQL As String

      Try

         If oAdmLocal.ExisteTabla(sTabla) Then
            oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
         End If

         sSQL = "SELECT        DF_FECVIG AS PERIODO, " & _
                "              DF_FECVIG AS FECHAVIG," & _
                "              0         AS CUADRO,  " & _
                "              DF_CODPAR AS CODIGO,  " & _
                "              DF_CAMPO8 AS CAMPO8,  " & _
                "              DF_CODCON AS CODCON,  " & _
                "              DF_RESNOT,            " & _
                "              DF_FECRES,            " & _
                "              DF_PTORES,            " & _
                "              DF_SECUEN,            " & _
                "              DF_DESCRI,            " & _
                "              DF_IMPORT AS IMPORTE, " & _
                "              1         AS GENERATXT " & _
                "INTO          TXTSAL2               " & _
                "FROM          DATFRA                " & _
                "WHERE         DF_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND           DF_CODENT = " & CODIGO_ENTIDAD & " "
         oAdmLocal.EjecutarComandoSQL(sSQL)

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_5603")
      End Try

   End Function

   Private Function PreparaTXT_5610(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

      Dim sSQL As String

      Try

         If oAdmLocal.ExisteTabla(sTabla) Then
            oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
         End If

         sSQL = "SELECT        DI_FECVIG AS PERIODO,  " & _
                "              DI_FECVIG AS FECHAVIG, " & _
                "              0         AS CUADRO,   " & _
                "              DI_CODPAR AS CODIGO,   " & _
                "              DI_CAMPO8 AS CAMPO8,   " & _
                "              DI_CODCON AS CODCON,   " & _
                "              DI_TIPIDE,             " & _
                "              DI_NROIDE,             " & _
                "              DI_DENOMI,             " & _
                "              DI_PTONOR,             " & _
                "              DI_IMPORTE AS IMPORTE, " & _
                "              1         AS GENERATXT " & _
                "INTO          TXTSAL3                " & _
                "FROM          DATINC                 " & _
                "WHERE         DI_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND           DI_CODENT = " & CODIGO_ENTIDAD & " "
         oAdmLocal.EjecutarComandoSQL(sSQL)

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_5610")
      End Try

   End Function

   Private Function PreparaTXT_5611(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

      Dim sSQL As String

      Try

         If oAdmLocal.ExisteTabla(sTabla) Then
            oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
         End If

         sSQL = "SELECT        DP_FECVIG AS PERIODO,  " & _
                "              DP_FECVIG AS FECHAVIG, " & _
                "              0         AS CUADRO,   " & _
                "              DP_CODPAR AS CODIGO,   " & _
                "              DP_CAMPO8 AS CAMPO8,   " & _
                "              DP_CODCON AS CODCON,   " & _
                "              DP_1ERMES,             " & _
                "              DP_2DOMES,             " & _
                "              1         AS GENERATXT " & _
                "INTO          TXTSAL4                " & _
                "FROM          DATPER                 " & _
                "WHERE         DP_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND           DP_CODENT = " & CODIGO_ENTIDAD & " "
         oAdmLocal.EjecutarComandoSQL(sSQL)

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_5611")
      End Try

   End Function

   Private Function PreparaTXT_5601(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

      Dim sSQL As String

      Try

         If oAdmLocal.ExisteTabla(sTabla) Then
            oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
         End If

         sSQL = "SELECT        DC_FECVIG     AS PERIODO,  " & _
                "              DC_FECVIG     AS FECHAVIG, " & _
                "              DC_CUADRO     AS CUADRO,   " & _
                "              DC_CODPAR     AS CODIGO,   " & _
                "              DC_CAMPO8     AS CAMPO8,   " & _
                "              DC_CODCON     AS CODCON,   " & _
                "              DC_MES1 * DC_OPERACION  AS IMPORTE,  " & _
                "              DC_GENERATXT  AS GENERATXT " & _
                "INTO          TXTSAL                     " & _
                "FROM          DATCUA                     " & _
                "WHERE         DC_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND           DC_CUADRO IN (331, 351, 352, 353, 361, 371, 381, 391, 392) " & _
                "AND           DC_CODENT = " & CODIGO_ENTIDAD & " "
         oAdmLocal.EjecutarComandoSQL(sSQL)

         '-----------------------------------------------------------------------------------------
         ' AGREGADO PARA ELIMINAR LAS PARTIDAS DIARIOS EN R.MERCADO QUE NO CORRESPONDEN AL MES
         '-----------------------------------------------------------------------------------------

         sSQL = "DELETE " & _
                "FROM         TXTSAL " & _
                "WHERE        PERIODO = " & FechaSQL(dFecha) & " " & _
                "AND          CUADRO IN (351, 352, 353) " & _
                "AND          RIGHT(CODIGO,2) > DAY(PERIODO) "
         oAdmLocal.EjecutarComandoSQL(sSQL)

         sSQL = "DELETE " & _
                "FROM         TXTSAL " & _
                "WHERE        PERIODO = " & FechaSQL(dFecha) & " " & _
                "AND          CUADRO NOT IN (351, 352) " & _
                "AND          IMPORTE = 0 "
         oAdmLocal.EjecutarComandoSQL(sSQL)

         sSQL = "DELETE " & _
                "FROM         TXTSAL " & _
                "WHERE        PERIODO = " & FechaSQL(dFecha) & " " & _
                "AND          CUADRO IN (351, 352) " & _
                "AND          LEFT(CODIGO, 6) IN ( " & _
                "                                  SELECT   CODPAR " & _
                "                                  FROM     ( " & _
                "                                              SELECT      LEFT(CODIGO, 6) AS CODPAR, SUM(IMPORTE) AS IMPORT " & _
                "                                              FROM        TXTSAL " & _
                "                                              WHERE       CUADRO IN (351, 352) " & _
                "                                              GROUP BY    LEFT(CODIGO, 6) " & _
                "                                           )  XXTEMP " & _
                "                                  WHERE    IMPORT = 0 " & _
                "                                ) "

         oAdmLocal.EjecutarComandoSQL(sSQL)

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_5601")
      End Try

   End Function


   Private Function PreparaTXT_5605(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

      Dim sSQL As String

      Try

         If oAdmLocal.ExisteTabla(sTabla) Then
            oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
         End If

         sSQL = "SELECT        DB_FECVIG AS PERIODO, " & _
                "              DB_FECVIG AS FECHAVIG," & _
                "              DB_CODCON AS CODCON,  " & _
                "              DB_CUADRO AS CUADRO,  " & _
                "              DB_CODPAR AS CODIGO,  " & _
                "              DB_CAMPO8 AS CAMPO8, "

         sSQL = sSQL & "  DB_MES0  * DB_OPERACION AS DB_MES0 , "
         sSQL = sSQL & "  DB_MES1  * DB_OPERACION AS DB_MES1 , "
         sSQL = sSQL & "  DB_MES2  * DB_OPERACION AS DB_MES2 , "
         sSQL = sSQL & "  DB_MES3  * DB_OPERACION AS DB_MES3 , "
         sSQL = sSQL & "  DB_MES4  * DB_OPERACION AS DB_MES4 , "
         sSQL = sSQL & "  DB_MES5  * DB_OPERACION AS DB_MES5 , "
         sSQL = sSQL & "  DB_MES6  * DB_OPERACION AS DB_MES6 , "
         sSQL = sSQL & "  DB_MES7  * DB_OPERACION AS DB_MES7 , "
         sSQL = sSQL & "  DB_MES8  * DB_OPERACION AS DB_MES8 , "
         sSQL = sSQL & "  DB_MES9  * DB_OPERACION AS DB_MES9 , "
         sSQL = sSQL & "  DB_MES10 * DB_OPERACION AS DB_MES10, "
         sSQL = sSQL & "  DB_MES11 * DB_OPERACION AS DB_MES11, "
         sSQL = sSQL & "  DB_MES12 * DB_OPERACION AS DB_MES12, "
         sSQL = sSQL & "  DB_MES13 * DB_OPERACION AS DB_MES13, "
         sSQL = sSQL & "  DB_MES14 * DB_OPERACION AS DB_MES14, "
         sSQL = sSQL & "  DB_MES15 * DB_OPERACION AS DB_MES15, "
         sSQL = sSQL & "  DB_MES16 * DB_OPERACION AS DB_MES16, "
         sSQL = sSQL & "  DB_MES17 * DB_OPERACION AS DB_MES17, "
         sSQL = sSQL & "  DB_MES18 * DB_OPERACION AS DB_MES18, "
         sSQL = sSQL & "  DB_MES19 * DB_OPERACION AS DB_MES19, "
         sSQL = sSQL & "  DB_MES20 * DB_OPERACION AS DB_MES20, "
         sSQL = sSQL & "  DB_MES21 * DB_OPERACION AS DB_MES21, "
         sSQL = sSQL & "  DB_MES22 * DB_OPERACION AS DB_MES22, "
         sSQL = sSQL & "  DB_MES23 * DB_OPERACION AS DB_MES23, "
         sSQL = sSQL & "  DB_MES24 * DB_OPERACION AS DB_MES24, "
         sSQL = sSQL & "  DB_MES25 * DB_OPERACION AS DB_MES25, "
         sSQL = sSQL & "  DB_MES26 * DB_OPERACION AS DB_MES26, "
         sSQL = sSQL & "  DB_MES27 * DB_OPERACION AS DB_MES27, "
         sSQL = sSQL & "  DB_MES28 * DB_OPERACION AS DB_MES28, "
         sSQL = sSQL & "  DB_MES29 * DB_OPERACION AS DB_MES29, "
         sSQL = sSQL & "  DB_MES30 * DB_OPERACION AS DB_MES30, "
         sSQL = sSQL & "  DB_MES31 * DB_OPERACION AS DB_MES31, "
         sSQL = sSQL & "  DB_MES32 * DB_OPERACION AS DB_MES32, "
         sSQL = sSQL & "  DB_MES33 * DB_OPERACION AS DB_MES33, "
         sSQL = sSQL & "  DB_MES34 * DB_OPERACION AS DB_MES34, "
         sSQL = sSQL & "  DB_MES35 * DB_OPERACION AS DB_MES35, "
         sSQL = sSQL & "  DB_MES36 * DB_OPERACION AS DB_MES36, "
         sSQL = sSQL & "  DB_MES37 * DB_OPERACION AS DB_MES37, "
         sSQL = sSQL & "  DB_MES38 * DB_OPERACION AS DB_MES38, "
         sSQL = sSQL & "  DB_MES39 * DB_OPERACION AS DB_MES39, "
         sSQL = sSQL & "  DB_MES40 * DB_OPERACION AS DB_MES40, "
         sSQL = sSQL & "  DB_MES41 * DB_OPERACION AS DB_MES41, "
         sSQL = sSQL & "  DB_MES42 * DB_OPERACION AS DB_MES42, "
         sSQL = sSQL & "  DB_MES43 * DB_OPERACION AS DB_MES43, "
         sSQL = sSQL & "  DB_MES44 * DB_OPERACION AS DB_MES44, "
         sSQL = sSQL & "  DB_MES45 * DB_OPERACION AS DB_MES45, "
         sSQL = sSQL & "  DB_MES46 * DB_OPERACION AS DB_MES46, "
         sSQL = sSQL & "  DB_MES47 * DB_OPERACION AS DB_MES47, "
         sSQL = sSQL & "  DB_MES48 * DB_OPERACION AS DB_MES48, "
         sSQL = sSQL & "  DB_MES49 * DB_OPERACION AS DB_MES49, "
         sSQL = sSQL & "  DB_MES50 * DB_OPERACION AS DB_MES50, "
         sSQL = sSQL & "  DB_MES51 * DB_OPERACION AS DB_MES51, "
         sSQL = sSQL & "  DB_MES52 * DB_OPERACION AS DB_MES52, "
         sSQL = sSQL & "  DB_MES53 * DB_OPERACION AS DB_MES53, "

         sSQL = sSQL & _
                "              DB_GENERATXT AS GENERATXT " & _
                "INTO          " & sTabla & "                " & _
                "FROM          DATBAN                " & _
                "WHERE         DB_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND           DB_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND           DB_CUADRO IN (341,342,343) " & _
                "ORDER BY      DB_CUADRO, DB_CODPAR"
         oAdmLocal.EjecutarComandoSQL(sSQL)

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_5605")
      End Try
   End Function

   Private Function PreparaTXT_5607(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

      Dim sSQL As String

      Try

         If oAdmLocal.ExisteTabla(sTabla) Then
            oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
         End If

         sSQL = "SELECT        DB_FECVIG AS PERIODO, " & _
                "              DB_FECVIG AS FECHAVIG," & _
                "              DB_CODCON AS CODCON,  " & _
                "              DB_CUADRO AS CUADRO,  " & _
                "              DB_CODPAR AS CODIGO,  " & _
                "              DB_CAMPO8 AS CAMPO8, "

         sSQL = sSQL & "  DB_MES0  * DB_OPERACION AS DB_MES0 , "
         sSQL = sSQL & "  DB_MES1  * DB_OPERACION AS DB_MES1 , "
         sSQL = sSQL & "  DB_MES2  * DB_OPERACION AS DB_MES2 , "
         sSQL = sSQL & "  DB_MES3  * DB_OPERACION AS DB_MES3 , "
         sSQL = sSQL & "  DB_MES4  * DB_OPERACION AS DB_MES4 , "
         sSQL = sSQL & "  DB_MES5  * DB_OPERACION AS DB_MES5 , "
         sSQL = sSQL & "  DB_MES6  * DB_OPERACION AS DB_MES6 , "
         sSQL = sSQL & "  DB_MES7  * DB_OPERACION AS DB_MES7 , "
         sSQL = sSQL & "  DB_MES8  * DB_OPERACION AS DB_MES8 , "
         sSQL = sSQL & "  DB_MES9  * DB_OPERACION AS DB_MES9 , "
         sSQL = sSQL & "  DB_MES10 * DB_OPERACION AS DB_MES10, "
         sSQL = sSQL & "  DB_MES11 * DB_OPERACION AS DB_MES11, "
         sSQL = sSQL & "  DB_MES12 * DB_OPERACION AS DB_MES12, "
         sSQL = sSQL & "  DB_MES13 * DB_OPERACION AS DB_MES13, "
         sSQL = sSQL & "  DB_MES14 * DB_OPERACION AS DB_MES14, "
         sSQL = sSQL & "  DB_MES15 * DB_OPERACION AS DB_MES15, "
         sSQL = sSQL & "  DB_MES16 * DB_OPERACION AS DB_MES16, "
         sSQL = sSQL & "  DB_MES17 * DB_OPERACION AS DB_MES17, "
         sSQL = sSQL & "  DB_MES18 * DB_OPERACION AS DB_MES18, "
         sSQL = sSQL & "  DB_MES19 * DB_OPERACION AS DB_MES19, "
         sSQL = sSQL & "  DB_MES20 * DB_OPERACION AS DB_MES20, "
         sSQL = sSQL & "  DB_MES21 * DB_OPERACION AS DB_MES21, "
         sSQL = sSQL & "  DB_MES22 * DB_OPERACION AS DB_MES22, "
         sSQL = sSQL & "  DB_MES23 * DB_OPERACION AS DB_MES23, "
         sSQL = sSQL & "  DB_MES24 * DB_OPERACION AS DB_MES24, "
         sSQL = sSQL & "  DB_MES25 * DB_OPERACION AS DB_MES25, "
         sSQL = sSQL & "  DB_MES26 * DB_OPERACION AS DB_MES26, "
         sSQL = sSQL & "  DB_MES27 * DB_OPERACION AS DB_MES27, "
         sSQL = sSQL & "  DB_MES28 * DB_OPERACION AS DB_MES28, "
         sSQL = sSQL & "  DB_MES29 * DB_OPERACION AS DB_MES29, "
         sSQL = sSQL & "  DB_MES30 * DB_OPERACION AS DB_MES30, "
         sSQL = sSQL & "  DB_MES31 * DB_OPERACION AS DB_MES31, "
         sSQL = sSQL & "  DB_MES32 * DB_OPERACION AS DB_MES32, "
         sSQL = sSQL & "  DB_MES33 * DB_OPERACION AS DB_MES33, "
         sSQL = sSQL & "  DB_MES34 * DB_OPERACION AS DB_MES34, "
         sSQL = sSQL & "  DB_MES35 * DB_OPERACION AS DB_MES35, "
         sSQL = sSQL & "  DB_MES36 * DB_OPERACION AS DB_MES36, "
         sSQL = sSQL & "  DB_MES37 * DB_OPERACION AS DB_MES37, "
         sSQL = sSQL & "  DB_MES38 * DB_OPERACION AS DB_MES38, "
         sSQL = sSQL & "  DB_MES39 * DB_OPERACION AS DB_MES39, "
         sSQL = sSQL & "  DB_MES40 * DB_OPERACION AS DB_MES40, "
         sSQL = sSQL & "  DB_MES41 * DB_OPERACION AS DB_MES41, "
         sSQL = sSQL & "  DB_MES42 * DB_OPERACION AS DB_MES42, "
         sSQL = sSQL & "  DB_MES43 * DB_OPERACION AS DB_MES43, "
         sSQL = sSQL & "  DB_MES44 * DB_OPERACION AS DB_MES44, "
         sSQL = sSQL & "  DB_MES45 * DB_OPERACION AS DB_MES45, "
         sSQL = sSQL & "  DB_MES46 * DB_OPERACION AS DB_MES46, "
         sSQL = sSQL & "  DB_MES47 * DB_OPERACION AS DB_MES47, "
         sSQL = sSQL & "  DB_MES48 * DB_OPERACION AS DB_MES48, "
         sSQL = sSQL & "  DB_MES49 * DB_OPERACION AS DB_MES49, "
         sSQL = sSQL & "  DB_MES50 * DB_OPERACION AS DB_MES50, "
         sSQL = sSQL & "  DB_MES51 * DB_OPERACION AS DB_MES51, "
         sSQL = sSQL & "  DB_MES52 * DB_OPERACION AS DB_MES52, "
         sSQL = sSQL & "  DB_MES53 * DB_OPERACION AS DB_MES53, "
         sSQL = sSQL & "  DB_MES54 * DB_OPERACION AS DB_MES54, "

         sSQL = sSQL & _
                "              DB_GENERATXT AS GENERATXT " & _
                "INTO          " & sTabla & "                " & _
                "FROM          DATBAN                 " & _
                "WHERE         DB_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND           DB_CODENT = " & CODIGO_ENTIDAD & " " & _
                "AND           DB_CUADRO IN (344,345) " & _
                "ORDER BY      DB_CUADRO, DB_CODPAR"
         oAdmLocal.EjecutarComandoSQL(sSQL)

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_5607")
      End Try

   End Function

   Private Sub GenerarPDF(ByVal nCod As Long, ByVal dFecha As Date)

      Dim sSQL As String
      Dim ds As DataSet
      Dim sRuta As String = ""
      Dim sRetorno As String = ""

      Try

         sSQL = "SELECT    DISTINCT CAST(0 AS BIT) AS [Sel.], " & _
                "          NO_SUBCOD AS [Sub. Cód.], " & _
                "          NO_TITULO AS [Título] " & _
                "FROM      NOTAS " & _
                "WHERE     NO_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND       NO_CUADRO = " & IIf(nCod = 2813, "'NOTASCYA'", "'NOTASSUP'")
         frmTablaGeneral.PasarInfo(sSQL, CONN_LOCAL, 2, True, "Notas")

         If frmTablaGeneral.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            sRetorno = INPUT_GENERAL & ","
         Else
            Exit Try
         End If

         sSQL = "SELECT    * " & _
                "FROM      NOTAS " & _
                "WHERE     NO_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND       NO_CUADRO = " & IIf(nCod = 2813, "'NOTASCYA'", "'NOTASSUP'")
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            For Each row As DataRow In .Rows

               If sRetorno.IndexOf(row("NO_SUBCOD").ToString & ",") <> -1 Then
                  sRuta = NormalizarRuta(txtCarpeta.Text) & IIf(nCod = 2813, "P", "S") & Format(row("NO_CODIGO"), "000") & "_" & Format(row("NO_SUBCOD"), "000") & ".PDF"
                  ConvertirRTFenPDFLocal(row("NO_DESCRI"), sRuta)
               End If

            Next

         End With

         MensajeInformacion("Notas generadas")

         If chkOpen.Checked Then
            Process.Start(sRuta)
         End If

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "GenerarPDF")
      End Try

   End Sub

   Private Function PreparaTXT_RESTO(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

      Dim sSQL As String
      Dim nCuadro As Long

      Try

         If oAdmLocal.ExisteTabla(sTabla) Then
            oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
         End If

         nCuadro = oAdmLocal.DevolverValor("TXTREL", "TR_CUADRO", "TR_TABLATRABAJO = '" & sTabla & "' AND TR_ORDENTXT = 1", "")


         sSQL = "SELECT        DC_FECVIG     AS PERIODO,  " & _
                "              DC_FECVIG     AS FECHAVIG, " & _
                "              DC_CUADRO     AS CUADRO,   " & _
                "              DC_CODPAR     AS CODIGO,   " & _
                "              DC_CAMPO8     AS CAMPO8,   " & _
                "              DC_CODCON     AS CODCON,   " & _
                "              DC_MES1  * DC_OPERACION  AS IMPORTE,  " & _
                "              DC_GENERATXT  AS GENERATXT " & _
                "INTO          " & sTabla & " " & _
                "FROM          DATCUA                     " & _
                "WHERE         DC_FECVIG = " & FechaSQL(dFecha) & " " & _
                "AND           DC_CUADRO = " & nCuadro & " " & _
                "AND           DC_CODENT = " & CODIGO_ENTIDAD & " "
         oAdmLocal.EjecutarComandoSQL(sSQL)

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_RESTO")
      End Try

   End Function

   Private Function PreparaTXT_4401(ByVal sTabla As String, ByVal dFecha As Date) As Boolean

      Dim sSQL As String = ""

      Try

         If oAdmLocal.ExisteTabla(sTabla) Then
            oAdmLocal.EjecutarComandoSQL("DROP TABLE " & sTabla)
         End If

         sSQL = ""
         sSQL = sSQL & "SELECT      DC_FECVIG                  AS FECHAVIG,  " & vbCrLf
         sSQL = sSQL & "            DC_FECVIG                  AS PERIODO, " & vbCrLf
         sSQL = sSQL & "            DATEADD(year, -1, DC_FECVIG) AS PERIODO2, " & vbCrLf
         sSQL = sSQL & "            DC_CODPAR                  AS CODIGO,  " & vbCrLf
         sSQL = sSQL & "            DC_CODPAR                  AS PARTIDA,  " & vbCrLf
         sSQL = sSQL & "            DC_CAMPO8                  AS CAMPO8,   " & vbCrLf
         sSQL = sSQL & "            DC_CUADRO                  AS CUADRO,   " & vbCrLf
         sSQL = sSQL & "            DC_CODCON                  AS CODCON,   " & vbCrLf
         sSQL = sSQL & "            DC_MES0 * DC_OPERACION     AS DC_MES0,  " & vbCrLf
         sSQL = sSQL & "            DC_MES1 * DC_OPERACION     AS DC_MES1, " & vbCrLf
         sSQL = sSQL & "            DC_MES2 * DC_OPERACION     AS DC_MES2, " & vbCrLf
         sSQL = sSQL & "            DC_MES3 * DC_OPERACION     AS DC_MES3, " & vbCrLf
         sSQL = sSQL & "            DC_MES4 * DC_OPERACION     AS DC_MES4, " & vbCrLf
         sSQL = sSQL & "            DC_MES5 * DC_OPERACION     AS DC_MES5, " & vbCrLf
         sSQL = sSQL & "            DC_MES6 * DC_OPERACION     AS DC_MES6, " & vbCrLf
         sSQL = sSQL & "            DC_MES7 * DC_OPERACION     AS DC_MES7, " & vbCrLf
         sSQL = sSQL & "            DC_MES8 * DC_OPERACION     AS DC_MES8, " & vbCrLf
         sSQL = sSQL & "            DC_MES9 * DC_OPERACION     AS DC_MES9, " & vbCrLf
         sSQL = sSQL & "            DC_MES10 * DC_OPERACION    AS DC_MES10, " & vbCrLf
         sSQL = sSQL & "            DC_MES11 * DC_OPERACION    AS DC_MES11, " & vbCrLf
         sSQL = sSQL & "            DC_ALFA01                  AS DC_ALFA01, " & vbCrLf
         sSQL = sSQL & "            DC_ALFA02                  AS DC_ALFA02, " & vbCrLf
         sSQL = sSQL & "            DC_ALFA03                  AS DC_ALFA03, " & vbCrLf
         sSQL = sSQL & "            DC_ALFA04                  AS DC_ALFA04, " & vbCrLf
         sSQL = sSQL & "            DC_FECH01                  AS DC_FECH01, " & vbCrLf
         sSQL = sSQL & "            DC_GENERATXT               AS GENERATXT " & vbCrLf
         sSQL = sSQL & "INTO        TXT4401                 " & vbCrLf
         sSQL = sSQL & "FROM        DATCUA                  " & vbCrLf
         sSQL = sSQL & "WHERE       DC_FECVIG = @FECVIG     " & vbCrLf
         sSQL = sSQL & "AND         DC_CODENT = @CODENT     " & vbCrLf
         sSQL = sSQL & "AND         (DC_CUADRO BETWEEN 7101 AND 7115 " & vbCrLf
         sSQL = sSQL & "OR           DC_CUADRO BETWEEN 7001 AND 7004) " & vbCrLf
         sSQL = Replace(sSQL, "@FECVIG", FechaSQL(dFecha))
         sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)

         oAdmLocal.EjecutarComandoSQL(sSQL)

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_4401")
      End Try

   End Function


   Private Function PreparaTXT_Dinamico(ByVal nCodigo As Long, _
                                        ByVal dFecha As Date) As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim sError As String

      Try

         sSQL = "SELECT * FROM TXTNOM WHERE TN_CODIGO = " & nCodigo
         ds = oAdmLocal.AbrirDataset(sSQL)

         sSQL = ""

         If ds.Tables(0).Rows.Count > 0 Then
            sSQL = sBase64Decode(ds.Tables(0).Rows(0).Item("TN_PROCES"))
         End If

         sSQL = Replace(sSQL, "@FECDES", FechaSQL(dFecha.AddDays((dFecha.Day) * -1 + 1)))
         sSQL = Replace(sSQL, "@FECHAS", FechaSQL(dFecha))
         sSQL = Replace(sSQL, "@FECVIG", FechaSQL(dFecha))
         sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)

         If Not oAdmLocal.EjecutarComandoAsincrono(sSQL, sError) Then
            MensajeError(sError)
         End If

         ds = Nothing

         Return True

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_Dinamico")
      End Try

   End Function

   Private Sub ConvertirHTMLenPDFLocal(ByVal sRutaHTML As String, ByVal sRutaPDF As String, Optional ByVal bVertical As Boolean = True)

      Dim oDoc As WebSupergoo.ABCpdf7.Doc
      Dim oId As Long
      Dim w, h, l, b, i As Long

      Try

         oDoc = New WebSupergoo.ABCpdf7.Doc

         oDoc.Rect.Inset(50, 15)

         If Not bVertical Then

            w = oDoc.MediaBox.Width
            h = oDoc.MediaBox.Height
            l = oDoc.MediaBox.Left
            b = oDoc.MediaBox.Bottom
            oDoc.Transform.Rotate(90, l, b)
            oDoc.Transform.Translate(w, 0)

            ' rotate our rectangle
            oDoc.Rect.Width = h
            oDoc.Rect.Height = w

         End If

         oId = oDoc.AddImageUrl("file:///" & Replace(sRutaHTML, "\", "/"), True, 0, True)

         Do
            'oDoc.FrameRect

            If oDoc.GetInfo(oId, "Truncated") <> "1" Then
               Exit Do
            End If

            oDoc.Page = oDoc.AddPage()
            oId = oDoc.AddImageToChain(oId)
            Application.DoEvents()

         Loop

         For i = 1 To oDoc.PageCount
            oDoc.PageNumber = i
            oDoc.Flatten()
         Next

         oDoc.Save(sRutaPDF)

         oDoc = Nothing

         Exit Sub

      Catch ex As Exception
         TratarError(ex, "ConvertirHTMLenPDFLocal")
      End Try

   End Sub

   Private Sub ConvertirRTFenPDFLocal(ByVal sRTF As String, ByVal sRutaPDF As String, Optional ByVal bVertical As Boolean = True)

      Dim oDoc As Object = Nothing
      Dim oApp As Object = Nothing
      Dim sArchivoRTF As String = ""
      Dim bAbierto As Boolean

      Try

         oApp = CreateObject("Word.Application")
         oDoc = CreateObject("Word.Document")

         sArchivoRTF = NormalizarRuta(CARPETA_LOCAL) & "TEMP\" & NombreArchivo(Application.ExecutablePath) & ".RTF"

         If ArchivoExiste(sArchivoRTF) Then
            Kill(sArchivoRTF)
         End If

         File.WriteAllText(sArchivoRTF, sRTF)

         oDoc = oApp.Documents.Open(sArchivoRTF)

         bAbierto = True

         With oApp.ActiveDocument.PageSetup
            .TopMargin = 50
            .LeftMargin = 50
            .RightMargin = 50
            .BottomMargin = 50
         End With

         oDoc.SaveAs(sArchivoRTF & ".HTML", 10)

         oDoc.Close(False)
         bAbierto = False

         Application.DoEvents()
         ConvertirHTMLenPDFLocal(sArchivoRTF & ".html", sRutaPDF, bVertical)

      Catch ex As Exception
         TratarError(ex, "RTF_HTML")
      End Try

      If bAbierto Then
         oDoc.Close(False)
      End If

      oDoc = Nothing
      oApp = Nothing

   End Sub

    Private Sub CargarArchivos()

        Dim sSQL As String
        Dim ds As DataSet
        Try
            RemoveHandler cboArchivos.SelectedIndexChanged, AddressOf cboArchivos_SelectedIndexChanged
            Try

                sSQL = "SELECT * " &
                "FROM TXTNOM " &
                "ORDER BY TN_NOMBRETXT"

                ds = oAdmLocal.AbrirDataset(sSQL)
                cboArchivos.Items.Clear()
                cboArchivos.Items.Add(New clsItem.Item("", "<Seleccionar ...>"))
                With ds.Tables(0)

                    For Each row As DataRow In .Rows

                        cboArchivos.Items.Add(New clsItem.Item(row("TN_CODIGO"), row("TN_NOMBRETXT")))

                    Next

                End With

                ds = Nothing

                If cboArchivos.Items.Count > 0 Then
                    cboArchivos.SelectedIndex = 0
                End If

            Catch ex As Exception
                TratarError(ex, "CargarArchivos")
            End Try

        Finally
            AddHandler cboArchivos.SelectedIndexChanged, AddressOf cboArchivos_SelectedIndexChanged
        End Try
    End Sub

    Private Sub IniciarControles()

        Dim i As Integer
        Dim oFecha As Date = Date.Today

        For i = 1 To 12
            cboMes.Items.Add(New clsItem.Item(i, MonthName(i).ToUpper))
        Next

        For i = oFecha.Year - 10 To oFecha.Year + 10
            cboAno.Items.Add(New clsItem.Item(i, i.ToString))
        Next

        ResetFecha(oFecha)
    End Sub

    Private Sub ResetFecha(ByVal oFecha As Date)
        If oFecha.Month <= 3 Then
            cboAno.Text = oFecha.Year - 1
            cboMes.SelectedIndex = 11
        Else
            cboAno.Text = oFecha.Year
            cboMes.SelectedIndex = oFecha.Month - 2
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
      Me.Close()
   End Sub

   Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

      Dim oDlg As New FolderBrowserDialog

      If oDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         txtCarpeta.Text = oDlg.SelectedPath
      End If

   End Sub

   Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click

        'Dim oItem As clsItem.Item

        'If DatosOK Then

        '   Me.lblStatus.Text = ""
        '   Me.lblStatus.Visible = True

        '   oItem = cboArchivos.SelectedItem
        '      'Todo: si es diario no hacer fecha correcta y cambiar los controles a dia mes anio
        '      If oItem.Valor = 2813 Or oItem.Valor = 2816 Then
        '      GenerarPDF(oItem.Valor, FechaCorrecta(cboMes.SelectedIndex + 1, Val(cboAno.Text)))
        '   Else
        '      GenerarTXT(oItem.Valor, FechaCorrecta(cboMes.SelectedIndex + 1, Val(cboAno.Text)))
        '   End If



        '  End If

        Dim oItem As clsItem.Item
        Dim sSQL As String
        Dim rstAux As DataSet
        Dim nCont As Integer

        'Agregado para usar un SP que grabe en otro lado - 2013/10/03

        Dim nRutPre = oAdmLocal.DevolverValor("TABGEN", "ISNULL(TG_NUME01, 0)", " TG_CODTAB = 10 AND TG_CODCON = 10", "")

        Dim sRutaPrevia = oAdmLocal.DevolverValor("TABGEN", "ISNULL(TG_ALFA01, '')", " TG_CODTAB = 10 AND TG_CODCON = 10")

        ' FIN AGREGADO SP

        If DatosOK() Then

            Dim dFecPro As Date

            'Todo: hacer combo de dia
            'If cboArchivos.SelectedItem.Tag = "D" Then
            '    dFecPro = CDate(cboDia.Text & "/" & DatoItemCombo(cboMes) & "/" & cboAnio.Text)
            'Else
            dFecPro = FechaCorrecta(cboMes.SelectedIndex + 1, Val(cboAno.Text))
            ' End If

            If (Val(Llave(cboArchivos)) >= 4300 And
             Val(Llave(cboArchivos)) <= 4399) Or
             (Val(Llave(cboArchivos)) >= 3901 And
             Val(Llave(cboArchivos)) <= 3903) Or
             (Val(Llave(cboArchivos)) >= 2900 And
             Val(Llave(cboArchivos)) <= 2910) Then

                nCont = 1

                'Programado para soportar TXTs de más de un diseño
                sSQL = "SELECT    DISTINCT TN_CODIGO " &
                "FROM      TXTNOM " &
                "WHERE     UPPER(TN_NOMBRETXT) = '" & UCase(LTrim(RTrim(cboArchivos.Text))) & "' " &
                "ORDER BY  TN_CODIGO"

                rstAux = oAdmLocal.AbrirDataset(sSQL)
                With rstAux.Tables(0)
                    For Each row As DataRow In .Rows
                        GenerarTXTMultiple
                    Next
                End With
                rstAux = Nothing
            Else
                GenerarTXT(oItem.Valor, FechaCorrecta(cboMes.SelectedIndex + 1, Val(cboAno.Text)))
            End If

        End If



    End Sub

    Private Sub GenerarTXTMultiple(ByVal nCod As Long, ByVal dFecha As Date, nReg As Integer, nPosic As Integer)

        On Error GoTo Err_Trap

        Dim oText As TextStream
        Dim sFile As String
        Dim sSQL As String
        Dim rstTemp As Recordset
        Dim rstCuadros As Recordset
        Dim rstAux As Recordset
        Dim rstTrabajo As Recordset
        Dim rstFormato As Recordset
        Dim i As Integer
        Dim sTabla As String
        Dim sCampo As String
        Dim sCuadro As String
        Dim nOrdenTXT As Integer
        Dim sLine As String
        Dim dNewValue As Date
        Dim vDato As Variant
        Dim j As Long
        Dim sFiltroTrabajo As String
        Dim nOrden As Integer
        Dim dFechaReal As Date
        Dim sCampoLog As String
        Dim sArchFTP As String
        Dim nGrabaSegTXT As Integer

        Screen.MousePointer = 11

        cmdGenerar.Enabled = False

        dFechaReal = dFecha

        sFile = txtCarpeta & cboArchivos.Text
        If nPosic = 1 Then
   Set oText = oFSO.CreateTextFile(sFile)
Else
   Set oText = oFSO.OpenTextFile(sFile, ForAppending)
End If

        sSQL = "SELECT MAX(TR_FECHAVIG) AS MAX_FECHA " &
       "FROM TXTREL " &
       "WHERE TR_FECHAVIG <= " & FechaSQL(dFecha) & " " &
       "AND TR_CODIGO = " & nCod

Set rstTemp = oAdmlocal.AbrirRecordset(sSQL, True)

With rstTemp
            If .BOF And .EOF Then
Salir:
                MensajeError "No existe el diseño para la fecha ingresada"
      Exit Sub
            Else
                If IsNull(!MAX_FECHA) Then
                    GoTo Salir
                Else
                    dFechaProx = !MAX_FECHA
                End If
            End If
        End With

Set rstTemp = Nothing

sSQL = "SELECT DISTINCT TR_CUADRO, TR_TABLATRABAJO FROM TXTREL " &
       "WHERE TR_CODIGO = " & nCod & " " &
       "AND TR_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
       "ORDER BY TR_CUADRO ASC"

Set rstCuadros = oAdmlocal.AbrirRecordset(sSQL, True)

' Ver formato ----------
   
sSQL = "SELECT   * " &
       "FROM     TXTDIS " &
       "WHERE    TD_CODIGO = " & nCod & " " &
       "AND      TD_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
       "ORDER BY TD_ORDEN"

Set rstFormato = oAdmlocal.AbrirRecordset(sSQL, True)

ReDim Preserve Formato(1)

        Do Until rstFormato.EOF
            With rstFormato
                Formato(!TD_ORDEN).CODIGO = !TD_CODIGO
                Formato(!TD_ORDEN).DECIMALES = !TD_CANTDECIMALES
                Formato(!TD_ORDEN).DESCRI = "" & !TD_DESCRIPCION
                Formato(!TD_ORDEN).FECVIG = !TD_FECHAVIG
                Formato(!TD_ORDEN).FORMATOCAMPO = "" & !TD_FORMATO
                Formato(!TD_ORDEN).INICIO = !TD_INICIO
                Formato(!TD_ORDEN).LONGITUD = !TD_LONGITUD
                Formato(!TD_ORDEN).Tipo = "" & !TD_TIPO
                .MoveNext
            End With
            ReDim Preserve Formato(UBound(Formato) + 1)
        Loop

Set rstFormato = Nothing

'-- Generar TXT
sTabla = rstCuadros!TR_TABLATRABAJO

        '-- Generar Tabla de Trabajo
        If Not (PreparaTxt(dFechaReal, sTabla, nCod)) Then
            cmdGenerar.Enabled = True
            lblStatus = ""
            Screen.MousePointer = 0
            Exit Sub
        End If

        Do Until rstCuadros.EOF

            sCuadro = rstCuadros!TR_CUADRO

            sSQL = "SELECT * " &
          "FROM " & sTabla & " " &
          "WHERE FECHAVIG = " & FechaSQL(dFecha) & " " &
          "AND CUADRO = '" & sCuadro & "' " &
          "AND GENERATXT = 1 " &
          FiltroTablaTrabajo(sTabla) & " " &
          "ORDER BY CODIGO, CAMPO8, PERIODO"
                
   Set rstTrabajo = oAdmlocal.AbrirRecordset(sSQL, True)
         
    sSQL = "SELECT * " &
           "FROM TXTREL " &
           "WHERE TR_CODIGO = " & nCod & " " &
           "AND TR_CUADRO = '" & sCuadro & "' " &
           "AND TR_FECHAVIG = " & FechaSQL(dFechaProx) & " " &
           "ORDER BY TR_ORDENTXT ASC"
        
    Set rstAux = oAdmlocal.AbrirRecordset(sSQL, True)
   
   Do Until rstTrabajo.EOF

                rstAux.MoveFirst

                Do Until rstAux.EOF
                    nOrden = rstAux!TR_ORDENTXT

                    If "" & rstAux!TR_CAMPOTRABAJO = "" Then ' Dato fijo !!

                        If InStr(1, "" & rstAux!TR_DATOFIJO, "[") > 0 Then

                            Select Case rstAux!TR_DATOFIJO

                                Case "[RECTIFICATIVA]"
                                    sLine = sLine & IIf(chkRectivicativa.Value = 1, "R", "N")
                                Case "[ENTIDAD]"
                                    sLine = sLine & Format(NoNulo(CODIGO_ENTIDAD, 0), Left(Formato(nOrden).FORMATOCAMPO, Formato(nOrden).LONGITUD))

                            End Select

                        Else

                            Select Case Formato(nOrden).Tipo

                                Case "N"
                                    sLine = sLine & Format(NoNulo(rstAux!TR_DATOFIJO, 0), Left(Formato(nOrden).FORMATOCAMPO, Formato(nOrden).LONGITUD))

                                Case "F"
                                    If NoNulo(rstAux!TR_DATOFIJO, 0) = 0 Then
                                        sLine = sLine & String(Formato(nOrden).LONGITUD, "0")
                                    Else
                                        sLine = sLine & Format(NoNulo(rstAux!TR_DATOFIJO, 0), Left(Formato(nOrden).FORMATOCAMPO, Formato(nOrden).LONGITUD))
                                    End If

                                Case Else
                                    sLine = sLine & RellenarCadena(Trim("" & rstAux!TR_DATOFIJO), Formato(nOrden).LONGITUD)

                            End Select
                        End If

                        ' Ver rutina --------

                    Else

                        sCampo = rstAux!TR_CAMPOTRABAJO

                        Select Case Formato(nOrden).Tipo

                            Case "N"
                                vDato = NoNulo(rstTrabajo.Fields(sCampo).Value, "0")
                                If Formato(nOrden).DECIMALES > 0 Then
                                    sLine = sLine & Format(vDato * Val("1" & String(Formato(nOrden).DECIMALES, "0")), Formato(nOrden).FORMATOCAMPO)
                                Else
                                    If vDato >= 0 Then

                                        ' Exclusivo para Deudores a partir de JULIO 2017
                                        If vDato = 0 And Formato(nOrden).CODIGO >= 4301 And Formato(nOrden).CODIGO <= 4316 Then

                                            sLine = sLine & IIf(Formato(nOrden).FORMATOCAMPO = "", "", Format(vDato, Formato(nOrden).FORMATOCAMPO))

                                        Else

                                            sLine = sLine & Format(vDato, Formato(nOrden).FORMATOCAMPO)

                                        End If

                                    Else
                                        sLine = sLine & Format(vDato, Right(Formato(nOrden).FORMATOCAMPO, Formato(nOrden).LONGITUD - 1))
                                    End If
                                End If

                                If Right("" & rstAux!TR_DATOFIJO, 1) = ";" Then
                                    sLine = sLine & ";"
                                End If

                            Case "T"

                                If Right("" & rstAux!TR_DATOFIJO, 1) = ";" Then

                                    vDato = RTrim("" & rstTrabajo.Fields(sCampo).Value)
                                    sLine = sLine & vDato & ";"

                                ElseIf Right("" & rstAux!TR_DATOFIJO, 2) = "||" Then

                                    vDato = RTrim("" & rstTrabajo.Fields(sCampo).Value)
                                    sLine = sLine & vDato & ""

                                Else

                                    vDato = Trim("" & rstTrabajo.Fields(sCampo).Value)
                                    sLine = sLine & RellenarCadena(vDato, Formato(nOrden).LONGITUD)

                                End If

                            Case "F"

                                vDato = NoNulo(rstTrabajo.Fields(sCampo).Value, "0")

                                Select Case rstAux!TR_DATOFIJO

                                    Case "[PERIODOANT]"

                                        dNewValue = UnAnioMenos(vDato)
                                        sLine = sLine & Format(dNewValue, Formato(nOrden).FORMATOCAMPO)

                                    Case Else ' VACIO !!

                                        If vDato = "0" Then

                                            If Right("" & rstAux!TR_DATOFIJO, 1) = ";" Then

                                                sLine = sLine

                                            Else

                                                sLine = sLine & Format(vDato, String(Len(Formato(nOrden).FORMATOCAMPO), "0"))

                                            End If

                                        Else
                                            sLine = sLine & Format(vDato, Formato(nOrden).FORMATOCAMPO)
                                        End If

                                End Select

                        End Select

                    End If

                    rstAux.MoveNext
                    DoEvents
                Loop

                rstTrabajo.MoveNext
                j = j + 1
                oText.WriteLine sLine
      sLine = ""
                sbMain.SimpleText = "Procesados: " & j & " ..."

                lblStatus.Refresh()
                DoEvents
            Loop
   
   Set rstTrabajo = Nothing
   Set rstAux = Nothing
   rstCuadros.MoveNext

        Loop
   
Set rstCuadros = Nothing

If nPosic = nReg Then

            cmdGenerar.Enabled = True

            'Agregado para que grabe en un servidor FTP - 2014/08/26
            'SOLO METROPOLIS
            If CODIGO_ENTIDAD = 44068 Or CODIGO_ENTIDAD = 432 Then

                sArchFTP = cboArchivos.Text

                SubirFTP "192.9.200.249", "/proyex/" + CStr(Year(dFechaReal) * 100 + Month(dFechaReal)) + "/", "reginf", "metropolis", sFile, sArchFTP

    End If

            ' FIN AGREGADO FTP

            nGrabaSegTXT = IIf(oAdmLocal.DevolverValor("TABGEN", "ISNULL(TG_NUME02, 0)", "",
                                 " TG_CODTAB = 3 AND TG_CODCON = 60", "") = " inexistente", 0,
                   oAdmLocal.DevolverValor("TABGEN", "ISNULL(TG_NUME02, 0)", "",
                                 " TG_CODTAB = 3 AND TG_CODCON = 60", ""))


            If nGrabaSegTXT = 1 Then

                AdjuntarArchivo sFile,
         Left(cboArchivos.Text, InStr(1, cboArchivos.Text, ".", vbTextCompare) - 1) & "_" & CStr(Year(Of Date)() * 10000 + Month(Of Date)() * 100 + Day(Of Date)()) & "_" & Right("00" & CStr(Hour(Time)), 2) & ":" & Right("00" & CStr(Minute(Time)), 2),
         Left(cboArchivos.Text, InStr(1, cboArchivos.Text, ".", vbTextCompare) - 1) & "_" & CStr(Year(dFechaReal) * 100 + Month(dFechaReal)) & "_" & IIf(chkRectivicativa.Value = 1, "R", "N")

   End If

            ' FIN AGREGADO TXTADJ

            'Agregado para que genere LOG

            If chkRectivicativa.Value = 0 And nGenerado = 0 Then
                GuardarLOG 61, "Archivo: " + cboArchivos.Text + ", Ruta: " + txtCarpeta + ", Período: " + CStr(dFechaReal) + ", Filas: " + Str(j), CODIGO_TRANSACCION, UsuarioActual.Codigo
   ElseIf chkRectivicativa.Value = 0 And nGenerado >= 1 Then
                GuardarLOG 63, "Archivo Nro.(" + Str(nGenerado) + "): " + cboArchivos.Text + ", Ruta: " + txtCarpeta + ", Período: " + CStr(dFechaReal) + ", Filas: " + Str(j), CODIGO_TRANSACCION, UsuarioActual.Codigo
   ElseIf chkRectivicativa.Value = 1 And nGenerado = 0 Then
                GuardarLOG 62, "Archivo: " + cboArchivos.Text + ", Ruta: " + txtCarpeta + ", Período: " + CStr(dFechaReal) + ", Filas: " + Str(j), CODIGO_TRANSACCION, UsuarioActual.Codigo
   ElseIf chkRectivicativa.Value = 1 And nGenerado >= 1 Then
                GuardarLOG 64, "Archivo Nro.(" + Str(nGenerado) + "): " + cboArchivos.Text + ", Ruta: " + txtCarpeta + ", Período: " + CStr(dFechaReal) + ", Filas: " + Str(j), CODIGO_TRANSACCION, UsuarioActual.Codigo
   End If
            ' FIN AGREGADO para que genere LOG

            Screen.MousePointer = 0
            MensajeInformacion "Proceso finalizado"
   lblStatus = ""

            If chkOpen.Value = 1 Then
                ShellEx sFile
   End If

        End If

        Exit Sub

Err_Trap:

        TratarError "GenerarTXTMultiple", "Campo: " & sCampo & vbCrLf & Err.Description
   lblStatus = ""

    End Sub


    Private Function DatosOK() As Boolean

      Dim bTemp As Boolean

      If cboArchivos.SelectedItem Is Nothing Then
         MensajeError("Seleccione el archivo TXT a generar")
         cboArchivos.Focus()
         Exit Function
      End If

      If txtCarpeta.Text.Trim = "" Or Not Directory.Exists(txtCarpeta.Text) Then
         MensajeError("La carpeta seleccionada no es válida o no ha sido creada")
         txtCarpeta.Focus()
         Exit Function
      End If

      txtCarpeta.Text = NormalizarRuta(txtCarpeta.Text)
      
      bTemp = File.Exists(txtCarpeta.Text & cboArchivos.Text)

      If bTemp Then
         If MsgBox("El archivo ya existe. ¿Desea sobreescribirlo?", vbQuestion + vbYesNo + vbDefaultButton2, "Pregunta") = vbNo Then
            Exit Function
         End If
      End If

      Return True

   End Function

   Private Sub GenerarTXT(ByVal nCod As Long, ByVal dFecha As Date)

      Dim oText As StreamWriter
      Dim sFile As String
      Dim sSQL As String
      Dim rstTemp As DataSet
      Dim rstCuadros As DataSet
      Dim rstAux As DataSet
      Dim rstTrabajo As DataSet
      Dim rstFormato As DataSet
      Dim sTabla As String
      Dim sCampo As String
      Dim sCuadro As String
      Dim sLine As String = ""
      Dim dNewValue As Date
      Dim vDato As Object
      Dim j As Long
      Dim nOrden As Integer
      Dim dFechaReal As Date
      Dim oForm As clsFormato

        '      Try

        Me.Cursor = Cursors.WaitCursor
        cmdGenerar.Enabled = False

        dFechaReal = dFecha

      sFile = txtCarpeta.Text & cboArchivos.Text
      If File.Exists(sFile) Then
         File.Delete(sFile)
      End If
      oText = File.CreateText(sFile)

      sSQL = "SELECT    MAX(TR_FECHAVIG) AS MAX_FECHA " & _
             "FROM      TXTREL " & _
             "WHERE     TR_FECHAVIG <= " & FechaSQL(dFecha) & " " & _
             "AND       TR_CODIGO = " & nCod

      rstTemp = oAdmLocal.AbrirDataset(sSQL)

      With rstTemp.Tables(0)
         If .Rows.Count = 0 Then
Salir:
            MensajeError("No existe el diseño para la fecha ingresada")
            Exit Sub
         Else
            If .Rows(0).Item("MAX_FECHA") Is DBNull.Value Then
               GoTo Salir
            Else
               dFechaProx = .Rows(0).Item("MAX_FECHA")
            End If
         End If
      End With

      rstTemp = Nothing

      sSQL = "SELECT    DISTINCT TR_CUADRO, TR_TABLATRABAJO " & _
             "FROM      TXTREL " & _
             "WHERE     TR_CODIGO = " & nCod & " " & _
             "AND       TR_FECHAVIG = " & FechaSQL(dFechaProx) & " " & _
             "ORDER BY  TR_CUADRO ASC"

      rstCuadros = oAdmLocal.AbrirDataset(sSQL)

      ' Ver formato ----------

      sSQL = "SELECT   * " & _
             "FROM     TXTDIS " & _
             "WHERE    TD_CODIGO = " & nCod & " " & _
             "AND      TD_FECHAVIG = " & FechaSQL(dFechaProx) & " " & _
             "ORDER BY TD_ORDEN"

      rstFormato = oAdmLocal.AbrirDataset(sSQL)

      Formato.Clear()

      With rstFormato.Tables(0)

         For Each row As DataRow In .Rows

            oForm = New clsFormato

            oForm.Codigo = row("TD_CODIGO")
            oForm.Decimales = row("TD_CANTDECIMALES")
            oForm.Descripcion = row("TD_DESCRIPCION")
            oForm.Fecha = row("TD_FECHAVIG")
            oForm.FormatoCampo = "" & row("TD_FORMATO")
            oForm.Inicio = row("TD_INICIO")
            oForm.Longitud = row("TD_LONGITUD")
            oForm.Tipo = row("TD_TIPO")
            oForm.Key = "K" & row("TD_ORDEN")

            If oForm.FormatoCampo = "yyyymmdd" Then oForm.FormatoCampo = "yyyyMMdd"
            If oForm.FormatoCampo = "yyyymm" Then oForm.FormatoCampo = "yyyyMM"

            Formato.Add(oForm, oForm.Key)

            oForm = Nothing

         Next

      End With

      rstFormato = Nothing

      '-- Generar TXT
      sTabla = rstCuadros.Tables(0).Rows(0).Item("TR_TABLATRABAJO")

      '-- Generar Tabla de Trabajo
      If Not (PreparaTxt(dFechaReal, sTabla)) Then
         cmdGenerar.Enabled = True
         lblStatus.Text = ""
         Me.Cursor = Cursors.Default
         Exit Sub
      End If

      For Each row As DataRow In rstCuadros.Tables(0).Rows

         sCuadro = row("TR_CUADRO")

         sSQL = "SELECT       * " & _
                "FROM         " & sTabla & " " & _
                "WHERE        FECHAVIG = " & FechaSQL(dFecha) & " " & _
                "AND          CUADRO = '" & sCuadro & "' " & _
                "AND          GENERATXT = 1 " & _
                              FiltroTablaTrabajo(sTabla) & " " & _
                "ORDER BY     CODIGO, CAMPO8, PERIODO"
         rstTrabajo = oAdmLocal.AbrirDataset(sSQL)

         sSQL = "SELECT       * " & _
                "FROM         TXTREL " & _
                "WHERE        TR_CODIGO = " & nCod & " " & _
                "AND          TR_CUADRO = '" & sCuadro & "' " & _
                "AND          TR_FECHAVIG = " & FechaSQL(dFechaProx) & " " & _
                "ORDER BY     TR_ORDENTXT ASC"
         rstAux = oAdmLocal.AbrirDataset(sSQL)

         For Each rowTrabajo As DataRow In rstTrabajo.Tables(0).Rows

            'If j = 102 Then Stop

            For Each rowAux As DataRow In rstAux.Tables(0).Rows

               nOrden = rowAux("TR_ORDENTXT")

               If "" & rowAux("TR_CAMPOTRABAJO") = "" Then ' Dato fijo !!

                  If InStr(1, "" & rowAux("TR_DATOFIJO"), "[") > 0 Then

                     Select Case "" & rowAux("TR_DATOFIJO")

                        Case "[RECTIFICATIVA]"
                           sLine = sLine & IIf(chkRectivicativa.Checked, "R", "N")

                        Case "[ENTIDAD]"
                           sLine = sLine & Format(CODIGO_ENTIDAD, Microsoft.VisualBasic.Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))

                     End Select

                  Else

                     Select Case CType(Formato(nOrden), clsFormato).Tipo

                        Case "N"
                           If IsNumeric(rowAux("TR_DATOFIJO")) Then
                              sLine = sLine & Format(Val(rowAux("TR_DATOFIJO")), Microsoft.VisualBasic.Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
                           ElseIf IsDate(rowAux("TR_DATOFIJO")) Then
                              sLine = sLine & Format(CDate(rowAux("TR_DATOFIJO")), Microsoft.VisualBasic.Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
                           Else
                              sLine = sLine & Format(NoNulo(rowAux("TR_DATOFIJO")), Microsoft.VisualBasic.Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
                           End If
                        Case "F"
                           If NoNulo(rowAux("TR_DATOFIJO"), False) = 0 Then
                              'sLine = sLine & "".PadLeft(CType(Formato(nOrden), clsFormato).Longitud, "0")
                              sLine = sLine & New String("0", CType(Formato(nOrden), clsFormato).Longitud)
                           Else
                              sLine = sLine & Format(CDate(rowAux("TR_DATOFIJO")), Microsoft.VisualBasic.Strings.Left(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud))
                           End If

                        Case Else
                           sLine = sLine & RellenarCadena(Trim("" & rowAux("TR_DATOFIJO")), CType(Formato(nOrden), clsFormato).Longitud)

                     End Select
                  End If

                  ' Ver rutina --------

               Else

                  sCampo = rowAux("TR_CAMPOTRABAJO")

                  Select Case CType(Formato(nOrden), clsFormato).Tipo

                     Case "N"
                        vDato = Val(rowTrabajo(sCampo))
                                If CType(Formato(nOrden), clsFormato).Decimales > 0 Then
                                    sLine = sLine & Format(vDato * Val("1" & "".PadLeft(CType(Formato(nOrden), clsFormato).Decimales, "0")), CType(Formato(nOrden), clsFormato).FormatoCampo)
                                Else
                                    If vDato >= 0 Then
                                        sLine = sLine & Format(vDato, CType(Formato(nOrden), clsFormato).FormatoCampo)
                                    Else
                                        sLine = sLine & Format(vDato, Microsoft.VisualBasic.Strings.Right(CType(Formato(nOrden), clsFormato).FormatoCampo, CType(Formato(nOrden), clsFormato).Longitud - 1))
                                    End If
                                End If

                                If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
                                    sLine = sLine & ";"
                                End If
                            Case "T"

                                If  Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then ' Right("" & rowAux("TR_DATOFIJO", 1) = ";" Then

                                    vDato = rowTrabajo(sCampo).ToString.Trim
                                    sLine = sLine & vDato.ToString & ";"

                                ElseIf Strings.Right(rowAux("TR_DATOFIJO").ToString, 2) = "||" Then 'Right("" & rstAux!TR_DATOFIJO, 2) = "||" Then

                                    vDato = rowTrabajo(sCampo).ToString.Trim
                                    sLine = sLine & vDato.ToString & ""

                                Else

                                    vDato = Trim(rowTrabajo(sCampo).ToString)
                                    sLine = sLine & RellenarCadena(vDato, CType(Formato(nOrden), clsFormato).Longitud)

                                End If

                                'Codigo anterior
                                'vDato = Trim(rowTrabajo(sCampo).ToString)
                                'sLine = sLine & RellenarCadena(vDato, CType(Formato(nOrden), clsFormato).Longitud)

                            Case "F"
                                vDato = NoNulo(rowTrabajo(sCampo))

                                Select Case rowAux("TR_DATOFIJO").ToString

                                    Case "[PERIODOANT]"

                                        dNewValue = UnAnioMenos(DateTime.Parse(vDato.ToString))
                                        sLine = sLine & Format(dNewValue, Formato(nOrden).FORMATOCAMPO)

                                    Case Else ' VACIO !!

                                        If vDato.ToString = "0" Then

                                            If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
                                                sLine = sLine
                                            Else
                                                sLine = sLine & Format(vDato, "".PadLeft(Len(Formato(nOrden).FORMATOCAMPO), "0"))
                                            End If

                                        Else

                                            sLine = sLine & Format(vDato, Formato(nOrden).FORMATOCAMPO)

                                        End If

                                End Select

                                If Strings.Right(rowAux("TR_DATOFIJO").ToString, 1) = ";" Then
                                    sLine = sLine & ";"
                                End If


                        End Select

               End If

            Next

            j = j + 1
            oText.WriteLine(sLine)
            sLine = ""
            lblStatus.Text = "Procesados: " & j.ToString & " ..."
            Application.DoEvents()

         Next

         rstTrabajo = Nothing
         rstAux = Nothing

      Next

      oText.Close()
      oText = Nothing

      rstCuadros = Nothing

      cmdGenerar.Enabled = True

      Me.Cursor = Cursors.Default

      MensajeInformacion("Proceso finalizado")

      Me.lblStatus.Visible = True

      If chkOpen.Checked Then
         Process.Start(sFile)
      End If

        'Exit Sub

        '   Catch ex As Exception
        ' Me.Cursor = Cursors.Default
        ' TratarError(ex, "GenerarTXT", "Campo: " & sCampo & vbCrLf & Err.Description)
        ' End Try



    End Sub

   Private Function PreparaTxt(ByVal dFecha As Date, _
                            Optional ByVal sTabla As String = "", _
                            Optional ByVal nCod As Long = 0) As Boolean

      Dim oItem As clsItem.Item

      oItem = cboArchivos.SelectedItem

      Select Case oItem.Valor

         Case 6301 To 6303
            PreparaTxt = PreparaTXT_Anticipos(sTabla, dFecha)

         Case 5601
            PreparaTxt = PreparaTXT_5601(sTabla, dFecha)

         Case 5603
            PreparaTxt = PreparaTXT_5603(sTabla, dFecha)

         Case 5605
            PreparaTxt = PreparaTXT_5605(sTabla, dFecha)

         Case 5607
            PreparaTxt = PreparaTXT_5607(sTabla, dFecha)

         Case 5610
            PreparaTxt = PreparaTXT_5610(sTabla, dFecha)

         Case 5611
            PreparaTxt = PreparaTXT_5611(sTabla, dFecha)

            'Case 4401
            '   PreparaTxt = PreparaTXT_4401(sTabla, dFecha)

         Case 4300 To 4399
            PreparaTxt = PreparaTXT_Dinamico(nCod, dFecha)

         Case Else

            PreparaTxt = PreparaTXT_Dinamico(oItem.Valor, dFecha)

      End Select

   End Function

   Private Function PreparaTXT_Anticipos(ByVal sTabla As String, _
                                         ByVal dFecha As Date) As Boolean

      Dim sSQL As String
      Dim RS As DataSet
      Dim sError As String

      Try

         sSQL = "SELECT    * " & _
                "FROM      TXTNOM " & _
                "WHERE     TN_CODIGO = 6303 "
         RS = oAdmLocal.AbrirDataset(sSQL)

         sSQL = ""

         If RS.Tables(0).Rows.Count > 0 Then
            sSQL = sBase64Decode("" & RS.Tables(0).Rows(0).Item("TN_PROCES"))
         End If

         sSQL = Replace(sSQL, "@FECDES", FechaSQL(dFecha.AddDays((dFecha.Day) * -1 + 1)))
         sSQL = Replace(sSQL, "@FECHAS", FechaSQL(dFecha))
         sSQL = Replace(sSQL, "@CODENT", CODIGO_ENTIDAD)

         If Not oAdmLocal.EjecutarComandoAsincrono(sSQL, sError) Then
            MensajeError(sError)
         End If

      Catch ex As Exception
         TratarError(ex, "PreparaTXT_Anticipos")
      End Try

      RS = Nothing

   End Function

   Private Function FiltroTablaTrabajo(ByVal sTabla As String) As String

      Dim sSQL As String
      Dim ds As DataSet
      Dim sTemp As String = ""

      sSQL = "SELECT * " & _
             "FROM TXTFIL " & _
             "WHERE TF_TABLA = '" & sTabla & "'"

      ds = oAdmLocal.AbrirDataset(sSQL)

      With ds.Tables(0)

         For Each row As DataRow In .Rows

            sTemp = sTemp & "AND " & row("TF_CONDICION") & " "

         Next

      End With

      ds = Nothing

      FiltroTablaTrabajo = sTemp

   End Function

   Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

      If e.KeyCode = 116 Then

         Dim oGral As New frmInputGeneral

         oGral.PasarInfoVentana("Modo diseño", "Ingrese la contraseña")
         oGral.txtResultado.UseSystemPasswordChar = True

         If oGral.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                If INPUT_GENERAL = "Prex123" Then
                    Dim _frmProceso As New frmProceso()

                    _frmProceso.ShowDialog(Me)
                    _frmProceso = Nothing
                Else
                    MensajeError("Login Incorrecto")
            End If

         End If

      End If

   End Sub

    Private Sub cboArchivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArchivos.SelectedIndexChanged
        Dim sRutaDefault As String = CType(NoNulo(oAdmLocal.DevolverValor("TXTNOM", "TN_RUTA", $"TN_NOMBRETXT='{CType(cboArchivos.SelectedItem, clsItem.Item).Nombre}'", String.Empty), True), String)

        If (sRutaDefault.Length() > 0) Then
            txtCarpeta.Text = NormalizarRuta(sRutaDefault)
            txtCarpeta.Enabled = False
        Else
            txtCarpeta.Enabled = True
            txtCarpeta.Text = CARPETA_LOCAL
        End If

        cmdBrowse.Visible = txtCarpeta.Enabled
        chkOpen.Visible = txtCarpeta.Enabled
        lblStatus.Text = ""
        Me.lblStatus.Visible = False
        ResetFecha(Date.Today)
    End Sub
End Class