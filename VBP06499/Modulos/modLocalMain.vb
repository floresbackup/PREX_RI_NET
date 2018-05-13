
Module modLocalMain

    Private Sub PrevInstance()

        Dim MisProcesos() As Process

        MisProcesos = Process.GetProcessesByName(Application.ProductName.ToString)

        If MisProcesos.Length > 1 Then
            MessageBox.Show("Esta aplicación ya se encuentra activa")
            End
        End If

    End Sub


    Public Sub Main()

        PrevInstance()
        LeerXML()

        Dim oAdmLocal As New AdmTablas
        oAdmLocal.ConnectionString = CONN_LOCAL

        Dim sMarcar As String = String.Empty

        Dim frmMain As New frmMain
        frmMain.AnalizarCommand()

        'oAdmLocal.PasarConnString CONN_LOCAL

        Dim sSQL = "SELECT      *                               " & vbCrLf
        sSQL = sSQL & "FROM (                                   " & vbCrLf
        sSQL = sSQL & "        SELECT      TG_CODCON, TG_DESCRI " & vbCrLf
        sSQL = sSQL & "        FROM        TABGEN               " & vbCrLf
        sSQL = sSQL & "        WHERE       TG_CODTAB = 100      " & vbCrLf
        sSQL = sSQL & "        AND         TG_CODCON <> 999999  " & vbCrLf
        sSQL = sSQL & "        AND         TG_NUME02 = 1        " & vbCrLf
        sSQL = sSQL & "                                         " & vbCrLf
        sSQL = sSQL & "        UNION ALL                        " & vbCrLf
        sSQL = sSQL & "                                         " & vbCrLf
        sSQL = sSQL & "        SELECT      TG_CODCON, TG_DESCRI " & vbCrLf
        sSQL = sSQL & "        FROM        TABGEN               " & vbCrLf
        sSQL = sSQL & "        WHERE       TG_CODTAB = 1000     " & vbCrLf
        sSQL = sSQL & "        AND         TG_CODCON <> 999999  " & vbCrLf
        sSQL = sSQL & "        AND         TG_NUME02 = 1        " & vbCrLf
        sSQL = sSQL & "                                         " & vbCrLf
        sSQL = sSQL & "     )  XXMONEDAS                        " & vbCrLf
        sSQL = sSQL & "ORDER BY    TG_CODCON "

        Dim RS As DataSet = oAdmLocal.AbrirDataset(sSQL)
        If (RS.Tables(0) Is Nothing) Then
            MessageBox.Show("No se encontró tabla monedas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For Each row As DataRow In RS.Tables(0).Rows
            sMarcar = sMarcar & row("TG_CODCON").ToString() & "|"
        Next

        RS = Nothing

        sSQL = "SELECT      *                              " & vbCrLf
        sSQL = sSQL & "FROM (                              " & vbCrLf
        sSQL = sSQL & "   SELECT      TG_CODCON, TG_DESCRI " & vbCrLf
        sSQL = sSQL & "   FROM        TABGEN               " & vbCrLf
        sSQL = sSQL & "   WHERE       TG_CODTAB = 100      " & vbCrLf
        sSQL = sSQL & "   AND         TG_CODCON <> 999999  " & vbCrLf
        sSQL = sSQL & "                                    " & vbCrLf
        sSQL = sSQL & "   UNION ALL                        " & vbCrLf
        sSQL = sSQL & "                                    " & vbCrLf
        sSQL = sSQL & "   SELECT      TG_CODCON, TG_DESCRI " & vbCrLf
        sSQL = sSQL & "   FROM        TABGEN               " & vbCrLf
        sSQL = sSQL & "   WHERE       TG_CODTAB = 1000     " & vbCrLf
        sSQL = sSQL & "   AND         TG_CODCON <> 999999  " & vbCrLf
        sSQL = sSQL & "                                    " & vbCrLf
        sSQL = sSQL & ")  XXMONEDAS                        " & vbCrLf
        sSQL = sSQL & "ORDER BY    TG_CODCON                           "

        INPUT_GENERAL = "Cancelar"
        'PasarInfo(ByVal oTextResult As TextBox,
        '             ByVal bMultiSelect As Boolean,
        '             ByVal sConnString As String,
        '             ByVal sSQL As String,
        '             ByVal nCodigoTabla As Double,
        '             ByVal sDescripcionTabla As String,
        '             Optional ByVal nRowHeight As Long = 0,
        '             Optional ByVal bDescripcionItem As Boolean = False,
        '             Optional ByVal sMarcarCasillas As String = "")
        ' frmMain.txtMonedas, True, CONN_LOCAL, sSQL, 0, "Monedas y Títulos", , , sMarcar

        Dim frmBuscadorTablaGeneral As New frmTablaGeneral()
        frmBuscadorTablaGeneral.PasarInfo(sSQL, CONN_LOCAL, 1, True, "Monedas y Títulos", sMarcar) 'agregar seleccion default
        frmBuscadorTablaGeneral.ShowDialog()
        frmMain.txtMonedas.Text = INPUT_GENERAL

        If frmMain.txtMonedas.Text <> "Cancelar" Then
            sSQL = "UPDATE TABGEN SET TG_NUME02 = 0 WHERE TG_CODTAB IN (100,1000)"
            oAdmLocal.EjecutarComandoSQL(sSQL)

            sSQL = "UPDATE TABGEN SET TG_NUME02 = 1 WHERE TG_CODTAB IN (100,1000) AND TG_CODCON IN (" & frmMain.txtMonedas.Text & ")"
            oAdmLocal.EjecutarComandoSQL(sSQL)

            INPUT_GENERAL = ""

            Dim frmPeriodoActual As New frmPeriodoActual()

            frmPeriodoActual.ShowDialog()

            If INPUT_GENERAL <> "" Then
                ActualizarMapa(Date.Parse(INPUT_GENERAL))
            End If

        End If
        frmMain = Nothing

    End Sub

    Public Sub ActualizarMapa(ByVal dFecha As Date)
        Try

            Dim oAdmLocal As New AdmTablas()
            oAdmLocal.ConnectionString = CONN_LOCAL

            Dim dFechaTK = oAdmLocal.DevolverValor("TABPAR", "MAX(TK_FECVIG)",
                  "      TK_CODENT = " & CODIGO_ENTIDAD & " AND TK_CUADRO BETWEEN 400 AND 498 " &
                  "AND   TK_FECVIG <= " & FechaSQL(dFecha), "")

            'REALIZO EL BACKUP DE DATCUA.
            oAdmLocal.EjecutarComandoSQL("DROP TABLE DATCUABAK")

            Dim sSQL = "SELECT    * " &
              "INTO      DATCUABAK " &
              "FROM      DATCUA " &
              "WHERE     DC_FECVIG=" & FechaSQL(dFecha) & " " &
              "AND       DC_CODENT=" & CODIGO_ENTIDAD & " " &
              "AND       DC_CUADRO BETWEEN 400 AND 498  "

            oAdmLocal.EjecutarComandoSQL(sSQL)

            sSQL = "DELETE   " &
              "FROM      DATCUA " &
              "WHERE     DC_FECVIG=" & FechaSQL(dFecha) & " " &
              "AND       DC_CODENT=" & CODIGO_ENTIDAD & " " &
              "AND       DC_CUADRO BETWEEN 400 AND 498 "
            oAdmLocal.EjecutarComandoSQL(sSQL)

            'REALIZO EL INSERT CON LOS NUEVOS DATOS
            sSQL = "SELECT    DISTINCT DC_CODCON " &
              "FROM      DATCUABAK " &
              "WHERE     DC_CUADRO BETWEEN 400 AND 498  "
            Dim RS As DataSet = oAdmLocal.AbrirDataset(sSQL)

            For Each row As DataRow In RS.Tables(0).Rows
                sSQL = "INSERT   " &
                       "INTO     DATCUA " &
                       "         (  " &
                       "            DC_FECVIG, DC_CODENT, DC_CODPAR, DC_CAMPO8, " &
                       "            DC_CODCON, DC_DESCRI, DC_DCORTA, DC_ACTIVA, " &
                       "            DC_CREOREND, DC_CUADRO, DC_MONFIJ, DC_ORDEN, " &
                       "            DC_OPERACION, DC_ESQUEMA, DC_NIVEL, DC_GENERATXT, " &
                       "            DC_NIVELTAB, DC_RELATIVO, DC_INDEX, DC_FECHACAR, " &
                       "            DC_USUARIO " &
                       "         ) " &
                       "SELECT   " & FechaSQL(dFecha) & ", TK_CODENT, TK_CODPAR, " &
                       "            TG_CODCON, '" & row("DC_CODCON").ToString() & "', TK_DESCRI, " &
                       "            TK_DCORTA, TK_ACTIVA, TK_CREOREND, TK_CUADRO, " &
                       "            TK_MONFIJ, TK_ORDEN, TK_OPERACION, TK_ESQUEMA, " &
                       "            TK_NIVEL, TK_GENERATXT, TK_NIVELTAB, TK_RELATIVO, " &
                       "            TK_INDEX, " & FechaSQL(DateTime.Now) & ", " &
                       "            '" & UsuarioActual.Nombre & "' " &
                       "FROM        TABPAR " &
                       "INNER JOIN  TABGEN " &
                       "ON          TG_CODTAB IN (100, 1000) " &
                       "AND         TG_CODCON <> 999999 " &
                       "AND         TG_NUME02 = 1 " &
                       "WHERE       TK_FECVIG = " & FechaSQL(dFechaTK) & " " &
                       "AND         TK_CODENT = " & CODIGO_ENTIDAD & " "

                sSQL = sSQL & " " &
                      "AND         TK_CUADRO IN (SELECT DISTINCT DC_CUADRO " &
                      "                          FROM   DATCUABAK " &
                      "                          WHERE  DC_CODENT = " & CODIGO_ENTIDAD & " " &
                      "                          AND    DC_FECVIG = " & FechaSQL(dFecha) & " " &
                      "                          AND    DC_CUADRO BETWEEN 400 AND 498)"


                oAdmLocal.EjecutarComandoAsincrono(sSQL)

                '"{CONDICION} " & _ FILA ELIMINADA POSTERIOR A "AND         TG_NUME02 = 1 " & _ PORQUE NO SE EXPLICA PARA QUE
                'SE USA IGUAL QUE LAS SIGUIENTES

                'oAdmLocal.EjecutarComandoAsincrono Replace(sSQL, "{CONDICION}", "AND TG_CODCON < 1000 ") & "AND TK_CAMPO8=0"
                'oAdmLocal.EjecutarComandoAsincrono Replace(sSQL, "{CONDICION}", "AND TG_CODCON = 1 ") & "AND TK_CAMPO8=1"
                'oAdmLocal.EjecutarComandoAsincrono Replace(sSQL, "{CONDICION}", "AND TG_CODCON = 2 ") & "AND TK_CAMPO8=10"
                'oAdmLocal.EjecutarComandoAsincrono Replace(sSQL, "{CONDICION}", " ") & "AND TK_CAMPO8=8"
                'oAdmLocal.EjecutarComandoAsincrono Replace(sSQL, "{CONDICION}", "AND TG_CODCON > 1000 ") & "AND TK_CAMPO8=9"

            Next

            RS = Nothing

            'REALIZO EL UPDATE CON LOS VALORES INGRESADOS EN LOS MESES DE LAS TABLAS BACKUP.
            sSQL = "UPDATE        DATCUA " &
              "SET           DC_MES0   = B.DC_MES0, " &
              "              DC_MES1   = B.DC_MES1, " &
              "              DC_MES2   = B.DC_MES2, " &
              "              DC_MES3   = B.DC_MES3, " &
              "              DC_MES4   = B.DC_MES4, " &
              "              DC_MES5   = B.DC_MES5, " &
              "              DC_MES6   = B.DC_MES6, "

            sSQL = sSQL &
                   "              DC_MES7   = B.DC_MES7, " &
                   "              DC_MES8   = B.DC_MES8, " &
                   "              DC_MES9   = B.DC_MES9, " &
                   "              DC_MES10  = B.DC_MES10, " &
                   "              DC_MES11  = B.DC_MES11, " &
                   "              DC_MES12  = B.DC_MES12, " &
                   "              DC_MES13  = B.DC_MES13, " &
                   "              DC_MES14  = B.DC_MES14, " &
                   "              DC_MES15  = B.DC_MES15, " &
                   "              DC_MES16  = B.DC_MES16, " &
                   "              DC_MES17  = B.DC_MES17, " &
                   "              DC_MES18  = B.DC_MES18, "

            sSQL = sSQL &
                   "              DC_MES19  = B.DC_MES19, " &
                   "              DC_MES20  = B.DC_MES20, " &
                   "              DC_MES21  = B.DC_MES21, " &
                   "              DC_MES22  = B.DC_MES22, " &
                   "              DC_MES23  = B.DC_MES23, " &
                   "              DC_MES24  = B.DC_MES24, " &
                   "              DC_MES25  = B.DC_MES25, " &
                   "              DC_MES26  = B.DC_MES26, " &
                   "              DC_MES27  = B.DC_MES27, " &
                   "              DC_MES28  = B.DC_MES28, " &
                   "              DC_MES29  = B.DC_MES29, " &
                   "              DC_MES30  = B.DC_MES30, " &
                   "              DC_MES31  = B.DC_MES31, " &
                   "              DC_MES32  = B.DC_MES32, " &
                   "              DC_MES33  = B.DC_MES33, " &
                   "              DC_MES34  = B.DC_MES34, " &
                   "              DC_MES35  = B.DC_MES35, " &
                   "              DC_MES36  = B.DC_MES36 "

            sSQL = sSQL &
                   "FROM          DATCUA A " &
                   "INNER JOIN    DATCUABAK B " &
                   "ON            A.DC_FECVIG = B.DC_FECVIG " &
                   "AND           A.DC_CODENT = B.DC_CODENT " &
                   "AND           A.DC_CODPAR = B.DC_CODPAR " &
                   "AND           A.DC_CAMPO8 = B.DC_CAMPO8 " &
                   "AND           A.DC_CODCON = B.DC_CODCON " &
                   "AND           A.DC_CUADRO = B.DC_CUADRO "

            oAdmLocal.EjecutarComandoAsincrono(sSQL)


        Catch ex As Exception
            TratarError(ex, "ActualizarMapa")
        End Try
    End Sub

End Module
