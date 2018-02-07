Module modGlobalFunciones

    Public fProcesando As frmProcesando

    Public Sub LeerINI()

        Dim sIniPath As String
        Dim sConnLocalPath As String

        Dim sLocalCommonIniPath As String
        Dim sTemp As String
        Dim oWriter As IO.StreamWriter

        sIniPath = Application.StartupPath & "\CONFIG.INI"
        sConnLocalPath = Application.StartupPath & "\CONNECT.DAT"

        LOCALE_PATH = Application.StartupPath & "\"
        RES_PATH = Application.StartupPath & "\RES\"

        LOGO_WELCOME_BACK_PATH = RES_PATH & "002.DAT"
        LOGO_ABOUT_PRODUCT_PATH = RES_PATH & "003.DAT"
        LOGO_ABOUT_LOGO_PATH = RES_PATH & "004.DAT"
        LOGO_LOGIN_PATH = RES_PATH & "005.DAT"
        LOGO_WELCOME_RIGHT_PATH = RES_PATH & "006.DAT"
        LOGO_WELCOME_LEFT_PATH = RES_PATH & "007.DAT"


        Try

            CONN_LOCAL = cEncrypt.DecryptString128Bit(IO.File.ReadAllText(sConnLocalPath))

            'CONN_LOCAL = INIRead(sIniPath, "OPCIONES", "CONN_LOCAL", "")
            'IO.File.WriteAllText(sConnLocalPath, cEncrypt.EncryptString128Bit(CONN_LOCAL))

            CONN_DEFAULT = INIRead(sIniPath, "OPCIONES", "CONN_DEFAULT", "")
            SIMBOLO_DECIMAL = INIRead(sIniPath, "OPCIONES", "SIMBOLO_DECIMAL", ".")
            LITERAL_CADENAS = INIRead(sIniPath, "OPCIONES", "LITERA_CADENAS", "'")
            LITERAL_FECHAS = INIRead(sIniPath, "OPCIONES", "LITERAL_FECHAS", "'")
            FORMATO_FECHAS = INIRead(sIniPath, "OPCIONES", "FORMATO_FECHAS", "yyyy-MM-dd")
            LOCAL_FOLDER = INIRead(sIniPath, "OPCIONES", "LOCAL_FOLDER", "C:\EDR\")
            HELP_PATH = INIRead(sIniPath, "OPCIONES", "HELP_PATH", "")
            DOMAIN_DEFAULT = INIRead(sIniPath, "OPCIONES", "DOMAIN", "")

            sTemp = INIRead(sIniPath, "OPCIONES", "AD_VALIDATION", "0")

            If IsNumeric(sTemp) Then
                If Val(sTemp) = 1 Then
                    VALIDATE_NT = True
                End If
            End If

            ' Otras opciones que no van en el INI

            ' Comun a todos, valores x default 

            If Not FolderExists(LOCAL_FOLDER) Then
                FileSystem.MkDir(LOCAL_FOLDER)
            End If

            sLocalCommonIniPath = LOCAL_FOLDER & "ASCOMMON.INI"
            LOCAL_COMMON_INI_PATH = sLocalCommonIniPath

            If Not FileExists(sLocalCommonIniPath) Then
                oWriter = IO.File.CreateText(sLocalCommonIniPath)
                oWriter.WriteLine("[OPCIONES]")
                oWriter.WriteLine("LAST_USER=1")
                oWriter.WriteLine("LAST_USER_NAME=Admin")
                oWriter.Flush()
            End If

            LAST_USER = Val(INIRead(sLocalCommonIniPath, "OPCIONES", "LAST_USER", "1"))
            LAST_USER_NAME = INIRead(sLocalCommonIniPath, "OPCIONES", "LAST_USER_NAME", "Admin")


        Catch ex As Exception
            TratarError(ex)
            End
        End Try
    End Sub

    Public Sub LeerINIUsuario()

        Dim sLocalIniPath As String
        Dim oWriter As IO.StreamWriter

        Try

            USER_FOLDER = LOCAL_FOLDER & Format(USUARIO_ACTUAL, "00000") & "\"
            GRID_LAYOUTS_PATH = USER_FOLDER & "LAYOUTS\GRID\"
            CUBE_LAYOUTS_PATH = USER_FOLDER & "LAYOUTS\CUBE\"
            SPOOL_PATH = USER_FOLDER & "SPOOL\"

            VerificarCarpetas()

            sLocalIniPath = USER_FOLDER & "User.ini"

            If Not FileExists(sLocalIniPath) Then
                oWriter = IO.File.CreateText(sLocalIniPath)
                oWriter.WriteLine("[OPCIONES]")
                oWriter.WriteLine("IDIOMA=1")
                oWriter.WriteLine("AUTOSAVE_LAYOUTS=0")
                oWriter.WriteLine("COLLAPSE_RIBBON=0")
                oWriter.WriteLine("THEME_ACTUAL=Caramel")
                oWriter.WriteLine("DESIGN_SPLIT=1")
                oWriter.WriteLine("USE_INTELLIPROMPT=1")
                oWriter.WriteLine("SHOW_WELCOME=1")
                oWriter.Flush()
            End If

            IDIOMA_ACTUAL = INIRead(sLocalIniPath, "OPCIONES", "IDIOMA", "1")
            AUTOSAVE_LAYOUTS = INIRead(sLocalIniPath, "OPCIONES", "AUTOSAVE_LAYOUTS", "0")
            COLLAPSE_RIBBON = INIRead(sLocalIniPath, "OPCIONES", "COLLAPSE_RIBBON", "0")
            THEME_ACTUAL = INIRead(sLocalIniPath, "OPCIONES", "THEME_ACTUAL", "Caramel")
            DESIGN_SPLIT = INIRead(sLocalIniPath, "OPCIONES", "DESIGN_SPLIT", "1")
            USE_INTELLIPROMPT = INIRead(sLocalIniPath, "OPCIONES", "USE_INTELLIPROMPT", "1")
            SHOW_WELCOME = INIRead(sLocalIniPath, "OPCIONES", "SHOW_WELCOME", "1")

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Public Sub GuardarOpcionUsuario(ByVal sNombreOpcion As String, ByVal vValor As VariantType)

        On Error Resume Next

        Dim sIniPath As String = USER_FOLDER & "User.ini"
        
        INIWrite(sIniPath, "OPCIONES", sNombreOpcion, vValor)

    End Sub

    Private Sub VerificarCarpetas()

        Try
            If Not FolderExists(LOCAL_FOLDER) Then
                FileSystem.MkDir(LOCAL_FOLDER)
            End If

            If Not FolderExists(USER_FOLDER) Then
                FileSystem.MkDir(USER_FOLDER)
            End If

            If Not FolderExists(GRID_LAYOUTS_PATH) Then
                FileSystem.MkDir(GRID_LAYOUTS_PATH)
            End If

            If Not FolderExists(CUBE_LAYOUTS_PATH) Then
                FileSystem.MkDir(CUBE_LAYOUTS_PATH)
            End If

            If Not FolderExists(SPOOL_PATH) Then
                FileSystem.MkDir(SPOOL_PATH)
            End If

        Catch ex As Exception
            TratarError(ex)
        End Try
    End Sub

    Public Sub TratarError(ByRef oEx As Exception)

        MsgBox(oEx.Message, MsgBoxStyle.Exclamation, Application.ProductName)

    End Sub

    Public Sub MensajeInformacion(ByVal sMensaje As String)

        MessageBox.Show(sMensaje, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub MensajeError(ByVal sMensaje As String)

        MessageBox.Show(sMensaje, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Public Function Pregunta(ByVal sMensaje As String) As DialogResult

        Return MessageBox.Show(sMensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Function

    Public Function AbrirConsultaGlobal(ByVal nCodigoConsulta As Integer) As Consulta

        Dim oAdmTemp As New AdmTablas
        Dim dsAux As DataSet
        Dim sSQL As String
        Dim oUDT As Consulta
        Dim nI As Integer

        Try
            oAdmTemp.ConnectionString = CONN_LOCAL
            sSQL = "SELECT      CONVAR.*, CONEXI.TG_DESCRI AS XX_CONEXI, CONEXI.TG_ALFA01 AS XX_CADCON, " & _
                   "            CATEGO.TG_DESCRI AS XX_CATEGO, CONEXI.TG_NUME01 AS XX_TIPCON, CONEXI.TG_NUME02 AS XX_ASYNCH, " & _
                   "            CX_OPTDEF, CX_SIMDEC, CX_LITSTR, CX_LITFEC, CX_FORFEC " & _
                   "FROM        CONVAR " & _
                   "LEFT JOIN   TABGEN CONEXI " & _
                   "ON          CV_CODCAD = CONEXI.TG_CODCON " & _
                   "AND         CONEXI.TG_CODTAB = 4 " & _
                   "LEFT JOIN   CONEXT " & _
                   "ON          CV_CODCAD = CX_CODCON " & _
                   "LEFT JOIN   TABGEN CATEGO " & _
                   "ON          CV_CATEGO = CATEGO.TG_CODCON " & _
                   "AND         CATEGO.TG_CODTAB = 3 " & _
                   "WHERE       CV_CODCON=" & nCodigoConsulta & vbCrLf
            sSQL = sSQL & _
                   "SELECT       * " & _
                   "FROM        CONDET " & _
                   "WHERE       CD_CODCON=" & nCodigoConsulta & " " & _
                   "ORDER BY    CD_ORDEN ASC" & vbCrLf
            sSQL = sSQL & _
                   "SELECT       * " & _
                   "FROM        CONFOR " & _
                   "WHERE       CF_CODCON=" & nCodigoConsulta & vbCrLf
            sSQL = sSQL & _
                   "SELECT       * " & _
                   "FROM        CONRES " & _
                   "WHERE       CR_CODCON=" & nCodigoConsulta & " " & _
                   "ORDER BY    CR_ORDEN ASC" & vbCrLf

            dsAux = oAdmTemp.AbrirDataset(sSQL)

            With oUDT

                'CABECERA
                .Codigo = nCodigoConsulta
                .Nombre = dsAux.Tables(0).Rows(0)("CV_NOMBRE")
                .Descripcion = dsAux.Tables(0).Rows(0)("CV_DESCRI")
                .CodigoCategoria = dsAux.Tables(0).Rows(0)("CV_CATEGO")
                .DescripcionCategoria = dsAux.Tables(0).Rows(0)("XX_CATEGO")
                .SQLPrevio = dsAux.Tables(0).Rows(0)("CV_SQLPRE")
                .SQLInicial = dsAux.Tables(0).Rows(0)("CV_SQLINI")
                .SQLFinal = dsAux.Tables(0).Rows(0)("CV_SQLFIN")
                .SQLPosterior = dsAux.Tables(0).Rows(0)("CV_SQLPOS")
                .CodigoConexion = dsAux.Tables(0).Rows(0)("CV_CODCAD")
                .NombreConexion = dsAux.Tables(0).Rows(0)("XX_CONEXI").ToString
                .CadenaConexion = cEncrypt.DecryptString128Bit(dsAux.Tables(0).Rows(0)("XX_CADCON").ToString)

                If .CadenaConexion = vbNullString Then
                    .CadenaConexion = CONN_DEFAULT
                End If

                .Protegida = (dsAux.Tables(0).Rows(0)("CV_PASSPR") = 1)
                .Password = dsAux.Tables(0).Rows(0)("CV_PASSWD")
                .OpcionesDefault = (dsAux.Tables(0).Rows(0)("CX_OPTDEF") = 1)
                .SimboloDecimal = dsAux.Tables(0).Rows(0)("CX_SIMDEC")
                .LiteralCadenas = dsAux.Tables(0).Rows(0)("CX_LITSTR")
                .LiteralFechas = dsAux.Tables(0).Rows(0)("CX_LITFEC")
                .FormatoFechas = dsAux.Tables(0).Rows(0)("CX_FORFEC")
                .ModoServidor = (dsAux.Tables(0).Rows(0)("CV_SERVER") = 1)
                .TipoConexion = dsAux.Tables(0).Rows(0)("XX_TIPCON")
                .EjecucionAsincrona = (dsAux.Tables(0).Rows(0)("XX_ASYNCH") = 1)


                'DETALLES
                ReDim .Detalles(0 To dsAux.Tables(1).Rows.Count - 1)

                For nI = 0 To dsAux.Tables(1).Rows.Count - 1
                    .Detalles(nI).Orden = dsAux.Tables(1).Rows(nI)("CD_ORDEN")
                    .Detalles(nI).Nombre = dsAux.Tables(1).Rows(nI)("CD_NOMPAR")
                    .Detalles(nI).TipoControl = dsAux.Tables(1).Rows(nI)("CD_TIPCON")
                    .Detalles(nI).TipoDatos = dsAux.Tables(1).Rows(nI)("CD_TIPDAT")
                    .Detalles(nI).Variable = dsAux.Tables(1).Rows(nI)("CD_VARIAB")
                    .Detalles(nI).ParteSQL = dsAux.Tables(1).Rows(nI)("CD_PARSQL")
                    .Detalles(nI).EsIN = (dsAux.Tables(1).Rows(nI)("CD_INSQL") = 1)
                    .Detalles(nI).TipoHelp = dsAux.Tables(1).Rows(nI)("CD_HELP")
                    .Detalles(nI).Requerido = (dsAux.Tables(1).Rows(nI)("CD_REQUER") = 1)
                    .Detalles(nI).SQLTablaGeneral = dsAux.Tables(1).Rows(nI)("CD_SQLTBG")
                    .Detalles(nI).CampoRetorno = dsAux.Tables(1).Rows(nI)("CD_CAMRET")
                    .Detalles(nI).ValorDefault = dsAux.Tables(1).Rows(nI)("CD_DEFAUL")
                    .Detalles(nI).OperadorValidacion = dsAux.Tables(1).Rows(nI)("CD_VALIDA")
                    .Detalles(nI).ValidacionValor1 = dsAux.Tables(1).Rows(nI)("CD_VALOR1")
                    .Detalles(nI).ValidacionValor2 = dsAux.Tables(1).Rows(nI)("CD_VALOR2")
                    .Detalles(nI).Valor = ""
                Next

                'FORMATOS
                ReDim .Formatos(0 To dsAux.Tables(2).Rows.Count - 1)

                For nI = 0 To dsAux.Tables(2).Rows.Count - 1
                    .Formatos(nI).ColumnaKey = dsAux.Tables(2).Rows(nI)("CF_COLKEY")
                    .Formatos(nI).Formato = dsAux.Tables(2).Rows(nI)("CF_FORMAT")
                    .Formatos(nI).TipoColumna = dsAux.Tables(2).Rows(nI)("CF_TIPCOL")
                Next

                'RESULTADOS
                ReDim .Resultados(0 To dsAux.Tables(3).Rows.Count - 1)

                For nI = 0 To dsAux.Tables(3).Rows.Count - 1
                    .Resultados(nI).Orden = dsAux.Tables(3).Rows(nI)("CR_ORDEN")
                    .Resultados(nI).Nombre = dsAux.Tables(3).Rows(nI)("CR_NOMBRE")
                Next

            End With

            Return oUDT

        Catch ex As Exception
            Return Nothing
            TratarError(ex)
        End Try

    End Function

    Public Function FechaSQL(ByVal dFecha As Date, ByVal sLiteralFechas As String, ByVal sFormatoFechas As String) As String
        FechaSQL = sLiteralFechas & Format(dFecha, sFormatoFechas) & sLiteralFechas
    End Function

    Public Function CadenaSQL(ByVal sCadena As String, ByVal sLiteralCadenas As String) As String
        CadenaSQL = sLiteralCadenas & sCadena & sLiteralCadenas
    End Function

    Public Function NumeroSQL(ByVal nNumero As Double, ByVal sSimboloDecimal As String) As String

        Dim sTemp As String
        sTemp = Format(nNumero.ToString, "Fixed")
        NumeroSQL = sTemp.Replace(",", sSimboloDecimal)

    End Function

    Public Sub Procesando(Optional ByVal bPermitirCancelar As Boolean = True, _
                          Optional ByVal sCaption As String = vbNullString, _
                          Optional ByVal sTipCaption As String = vbNullString)


        fProcesando = New frmProcesando

        fProcesando.Show()

        If Not bPermitirCancelar Then
            fProcesando.DeshabilitarCancelacion()
        End If

        If sCaption <> vbNullString Then
            fProcesando.lblProcesando.Text = sCaption
        End If

        If sTipCaption <> vbNullString Then
            fProcesando.lblTip.Text = sTipCaption
        End If


        fProcesando.Refresh()
        fProcesando.BringToFront()

    End Sub

    Public Sub FinProcesando()
        fProcesando.Close()
    End Sub

    Public Function SeleccionarConsulta() As Integer

        Dim oFrm As New frmSeleccionConsulta

        CONSULTA_SELECCIONADA = 0
        oFrm.ShowDialog()
        Return CONSULTA_SELECCIONADA

    End Function

    Public Sub ExportarGrillaPDF(ByRef oGridView As DevExpress.XtraGrid.Views.Grid.GridView, ByRef oFormOwner As Object)

        Dim oDlg As SaveFileDialog
        Dim sFileName As String

        oDlg = New SaveFileDialog
        oDlg.ValidateNames = True
        oDlg.OverwritePrompt = False
        oDlg.Filter = DescripcionCadena(Cadenas.CDN_FormatoExportacion_PDF_FilterDialog) & "|*.pdf"
        oDlg.FileName = SPOOL_PATH & "Doc.pdf"

        If oDlg.ShowDialog(oFormOwner) <> DialogResult.Cancel Then

            sFileName = oDlg.FileName.Trim

            If sFileName <> vbNullString Then
                Application.UseWaitCursor = True
                oGridView.ExportToPdf(sFileName)
                Process.Start(sFileName)
                Application.UseWaitCursor = False
            End If

        End If

    End Sub

    Public Function FileExists(ByVal FileFullPath As String) As Boolean

        Dim f As New IO.FileInfo(FileFullPath)
        Return f.Exists

    End Function

    Public Function FolderExists(ByVal FolderPath As String) As Boolean

        Dim f As New IO.DirectoryInfo(FolderPath)
        Return f.Exists

    End Function

End Module
