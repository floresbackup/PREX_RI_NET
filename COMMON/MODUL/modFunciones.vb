Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices

Module Impersonation

#Region "API Structures"
    <StructLayout(LayoutKind.Sequential)>
    Public Structure PROCESS_INFORMATION
        Dim hProcess As System.IntPtr
        Dim hThread As System.IntPtr
        Dim dwProcessId As Integer
        Dim dwThreadId As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure STARTUPINFO
        Dim cb As Integer
        Dim lpReserved As System.IntPtr
        Dim lpDesktop As System.IntPtr
        Dim lpTitle As System.IntPtr
        Dim dwX As Integer
        Dim dwY As Integer
        Dim dwXSize As Integer
        Dim dwYSize As Integer
        Dim dwXCountChars As Integer
        Dim dwYCountChars As Integer
        Dim dwFillAttribute As Integer
        Dim dwFlags As Integer
        Dim wShowWindow As Short
        Dim cbReserved2 As Short
        Dim lpReserved2 As System.IntPtr
        Dim hStdInput As System.IntPtr
        Dim hStdOutput As System.IntPtr
        Dim hStdError As System.IntPtr
    End Structure
#End Region

#Region "API Constants"
    Private Const LOGON_NETCREDENTIALS_ONLY As Integer = &H2
    Private Const NORMAL_PRIORITY_CLASS As Integer = &H20
    Private Const CREATE_DEFAULT_ERROR_MODE As Integer = &H4000000
    Private Const CREATE_NEW_CONSOLE As Integer = &H10
    Private Const CREATE_NEW_PROCESS_GROUP As Integer = &H200
    Private Const LOGON_WITH_PROFILE As Integer = &H1
#End Region

#Region "API Functions"
    Private Declare Unicode Function CreateProcessWithLogon Lib "Advapi32" Alias "CreateProcessWithLogonW" _
        (ByVal lpUsername As String,
         ByVal lpDomain As String,
         ByVal lpPassword As String,
         ByVal dwLogonFlags As Integer,
         ByVal lpApplicationName As String,
         ByVal lpCommandLine As String,
         ByVal dwCreationFlags As Integer,
         ByVal lpEnvironment As System.IntPtr,
         ByVal lpCurrentDirectory As System.IntPtr,
         ByRef lpStartupInfo As STARTUPINFO,
         ByRef lpProcessInfo As PROCESS_INFORMATION) As Integer

    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As System.IntPtr) As Integer

#End Region

    Public Sub RunProgram(ByVal UserName As String, ByVal Password As String, ByVal Domain As String, ByVal Application As String, ByVal CommandLine As String)
        Dim ruta = Directory.GetCurrentDirectory()
        Dim fullpath As String = Application + " " + CommandLine
        Dim siStartup As STARTUPINFO
        Dim piProcess As PROCESS_INFORMATION
        Dim intReturn As Integer

        Try

            If CommandLine Is Nothing OrElse CommandLine = "" Then CommandLine = String.Empty

            siStartup.cb = Marshal.SizeOf(siStartup)
            siStartup.dwFlags = 0

            If Application.Contains(ruta) Then
                fullpath = fullpath.Replace(ruta + "\", String.Empty)
            Else
                fullpath = ruta + "\" + Application + " " + CommandLine
            End If

            'MessageBox.Show(fullpath)
            intReturn = CreateProcessWithLogon(UserName, Domain, Password, LOGON_WITH_PROFILE, Application, fullpath,
                        NORMAL_PRIORITY_CLASS Or CREATE_DEFAULT_ERROR_MODE Or CREATE_NEW_CONSOLE Or CREATE_NEW_PROCESS_GROUP,
                        IntPtr.Zero, IntPtr.Zero, siStartup, piProcess)

            If intReturn = 0 Then
                Throw New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())
            End If

            CloseHandle(piProcess.hProcess)
            CloseHandle(piProcess.hThread)
            'Catch ex As Exception
            '    Throw ex
            'End Try

        Catch ex As Win32Exception
            If ex.NativeErrorCode = 1783 Then
                TratarError(New Exception("Datos de usuario RA inválidos (ERROR=1783) [Path: " & fullpath & " - Dominio: " & Domain & " - Usuario: " & UserName + "]", ex), "RunProgram")
            ElseIf ex.NativeErrorCode = 5 Then
                TratarError(New Exception("Credenciales inválidas (ERROR=5) [Path: " & fullpath & " - Dominio: " & Domain & " - Usuario: " & UserName + "]", ex), "RunProgram")
            Else
                TratarError(ex, "Error RunProgram", ex.Message & vbCrLf & "[Path: " & fullpath & " - Dominio: " & Domain & " - Usuario: " & UserName + "]")
            End If
        End Try

    End Sub

End Module
Module modFunciones

    Public Enum eTipoDatoADO
        eNumero = 0
        eTexto = 1
        eFecha = 2
    End Enum
    Public Sub LeerXML()
        LeerXML(True)
    End Sub

    Public Sub LeerXML(consultarCyberRark As Boolean)

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

                        Case "CONN_SIB"
                            CONN_SIB = System.Text.ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(sTemp))

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

                        '28-11-2014 SE AGREGA PARA USUARIO ENCRIPTADO DE RUN AS
                        Case "RUTAENCR_RA"
                            RUTAENCR_RA = sTemp
                        Case "RUTA_PREFERIDA"
                            RUTA_PREFERIDA = sTemp
                        Case "DOMINIO_DEFAULT"
                        Case "DOMINIO"
                            DOMINIO_DEFAULT = sTemp
                        Case "DEBUG" 'SI EXISTE LA VARIABLE EN EL INI - 0 = NO / 1 = SI
                            GENERAR_LOG_SQL = IIf(Integer.Parse(sTemp) = 1, True, False)
                        Case "TIPOLOG" 'SI EXISTE LA VARIABLE EN EL INI - 1= Completo 2= Solo modificaciones no SELECT 3= Ninguna grabación
                            TIPO_LOG_SQL = Integer.Parse(sTemp)

                        Case "APPID"
                            APPID = sTemp
                        Case "WSDL"
                            WSDL = sTemp
                        Case "CertificatePath"
                            CertificatePath = sTemp
                        Case "CertificatePass"
                            CertificatePass = System.Text.ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(sTemp))
                        Case "CertificateCitiDocsPath"
                            CertificateCitiDocsPath = sTemp
                        Case "CertificateCitiDocsPass"
                            CertificateCitiDocsPass = System.Text.ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(sTemp))
                        Case "SAFE"
                            SAFE = sTemp
                        Case "STR_FOLDER"
                            STR_FOLDER = sTemp
                        Case "STR_OBJECT"
                            STR_OBJECT = sTemp
                        Case "STR_OBJECT_AD"
                            STR_OBJECT_AD = sTemp
                        Case "STR_REASON"
                            STR_REASON = sTemp
                        Case "AUTENTICACIONGOOGLE"
                            AUTENTICACIONGOOGLE = CBool(sTemp)
                        Case "FILE_GOOGLE_CREDENTIALS"
                            FILE_GOOGLE_CREDENTIALS = sTemp.Trim
                    End Select

                    If row("NOMBRE").ToString.Contains("ENTIDAD_NOMBRE") Then
                        Dim nroEntidad As Integer = Integer.Parse(row("NOMBRE").ToString.Replace("ENTIDAD_NOMBRE_", String.Empty))
                        If Not Entidades.ContainsKey(nroEntidad) Then
                            Entidades.Add(nroEntidad, ("", ""))
                        End If

                        Entidades(nroEntidad) = (sTemp, Entidades(nroEntidad).conn_local)
                    End If

                    If row("NOMBRE").ToString.Contains("ENTIDAD_CONN_LOCAL") Then
                        Dim nroEntidad As Integer = Integer.Parse(row("NOMBRE").ToString.Replace("ENTIDAD_CONN_LOCAL_", String.Empty))

                        If Not Entidades.ContainsKey(nroEntidad) Then
                            Entidades.Add(nroEntidad, ("", ""))
                        End If

                        Entidades(nroEntidad) = (Entidades(nroEntidad).nombre, System.Text.ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(sTemp)))
                    End If

                Next

            End If

            If consultarCyberRark Then
                ObtenerConnectionCyberark()
            End If



            'ConsultarCyberRark()

            If AUTENTICACIONSQL Then
                If File.Exists(CARPETA_LOCAL & "TEMP\conn.enc") Then
                    Dim sUser As String = ""
                    Dim sPass As String = ""
                    LeerArchivoEncriptado(CARPETA_LOCAL & "TEMP\conn.enc", sUser, sPass)
                    CONN_LOCAL = CONN_LOCAL & ";User id=" & sUser & ";Password=" & IIf(String.IsNullOrEmpty(CYBERRARKPASS), sPass, CYBERRARKPASS) & ";"
                Else
                    If Command().Trim <> "" And Command().ToUpper <> "/IDE" Then
                        MensajeError("No se encuentra el archivo encriptado con la conexion SQL")
                        End
                    End If
                End If

            End If
            'If Not String.IsNullOrEmpty(CYBERRARKPASS) Then
            '    MessageBox.Show($"CYBERRARKPASS {CYBERRARKPASS} - CONN_LOCAL {CONN_LOCAL}")
            'End If
        Catch ex As Exception
            TratarError(ex, "LeerXML")
        End Try
    End Sub

    Public Sub ObtenerConnectionCyberark()
        Dim r = Prex.Utils.Security.CitiSecurity.ConsultarCyberRark(WSDL, CertificatePath, CertificatePass, APPID, SAFE, STR_FOLDER, STR_OBJECT, STR_REASON)

        If Not String.IsNullOrEmpty(r.Item2) Then
            CYBERRARKPASS = r.Item2
        End If

        If Not String.IsNullOrEmpty(r.Item1) Then
            CONN_LOCAL = r.Item1
        End If
    End Sub

    'Public Function ConsultarCyberRark() As String
    '    CYBERRARKPASS = String.Empty
    '    If ID_SISTEMA > 0 Then

    '        Try


    '            'MessageBox.Show($"WSDL: {WSDL}, CertifcatePath: {CertifcatePath}, " & vbCrLf &
    '            '		$"CertifcatePass: {CertifcatePass}, APPID: {APPID}, " & vbCrLf &
    '            '		$"SAFE: {SAFE}, STR_FOLDER: {STR_FOLDER}, " & vbCrLf &
    '            '		$"STR_OBJECT: {STR_OBJECT}, STR_REASON: {STR_REASON}", "Parametros del servicio: ", MessageBoxButtons.OK, MessageBoxIcon.Information)


    '            Dim pass As String = Prex.Utils.Security.CitiSecurity.GetPassWordCyberRark(WSDL, CertificatePath, CertificatePass, APPID, SAFE, STR_FOLDER, STR_OBJECT, STR_REASON)

    '            'MessageBox.Show("CyberRark Pass: " & pass)


    '            Dim builder As New OleDb.OleDbConnectionStringBuilder(CONN_LOCAL)
    '            Dim passAnt = String.Empty
    '            Dim teniaPass As Boolean = False

    '            If builder.ContainsKey("Password") Then
    '                passAnt = builder("Password")
    '                teniaPass = True
    '                builder.Remove("Password")
    '            End If
    '            builder.Add("Password", pass)

    '            Try
    '                Dim conn As New OleDb.OleDbConnection(builder.ConnectionString)
    '                conn.Open()
    '                If (conn.State = ConnectionState.Open) Then
    '                    conn.Close()
    '                End If
    '                CYBERRARKPASS = pass
    '            Catch ex As OleDb.OleDbException
    '                builder.Remove("Password")
    '                If teniaPass Then
    '                    builder.Add("Password", passAnt)
    '                    pass = passAnt
    '                End If
    '            End Try

    '            CONN_LOCAL = builder.ConnectionString

    '            Return pass.Trim
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Error GetPassWordCyberRark", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Return String.Empty
    '        End Try

    '    Else
    '        Return String.Empty
    '    End If
    'End Function

    Public Sub TratarError(ByVal ex As Exception,
                           Optional ByVal sFuncion As String = "",
                           Optional ByVal sCustomError As String = "",
                           Optional ByVal bGuardaLog As Boolean = True)

        Dim frm As New frmError

        frm.txtCodigo.Text = ex.GetHashCode.ToString
        If Not ex.Source Is Nothing AndAlso Not ex.TargetSite Is Nothing Then
            frm.txtOrigen.Text = ex.Source & " - " & ex.TargetSite.Name
        End If
        frm.txtFuncion.Text = IIf(sFuncion = "", "", sFuncion)
        frm.txtFecha.Text = System.DateTime.Today.ToShortDateString
        frm.txtHora.Text = System.DateTime.Now.ToShortTimeString

        If sCustomError <> "" Then
            frm.txtDescripcion.Text = sCustomError
            frm.txtDescripcion.Text = frm.txtDescripcion.Text & vbCrLf & vbCrLf & "TRAZA:" & vbCrLf & ex.StackTrace
        Else
            frm.txtDescripcion.Text = ex.Message & "TRAZA:" & vbCrLf & vbCrLf & ex.StackTrace
            If ex.InnerException IsNot Nothing Then
                frm.txtDescripcion.Text = frm.txtDescripcion.Text & vbCrLf & vbCrLf & "INNEREX:" & vbCrLf & ex.InnerException.Message & vbCrLf & "TRAZA:" & vbCrLf & ex.InnerException.StackTrace
            End If
        End If

        If bGuardaLog Then
            GuardarLOG(AccionesLOG.AL_ERROR_SISTEMA, frm.txtDescripcion.Text & vbCrLf & vbCrLf & "Función/Proc.: " & sFuncion, CODIGO_TRANSACCION)
        End If

        frm.ShowDialog()

    End Sub

    Public Sub TratarErrorErr(ByVal ex As ErrObject,
                        Optional ByVal sFuncion As String = "",
                        Optional ByVal sCustomError As String = "",
                        Optional ByVal bGuardaLog As Boolean = True)

        TratarError(ex.GetException(), sFuncion, sCustomError, bGuardaLog)

    End Sub

    Public Function FlotanteSQL(ByVal nNumero As Double) As String
        Return Math.Round(nNumero, 6).ToString.Replace(",", ".")
        'Return Format(nNumero, "Fixed").Replace(",", ".")

    End Function

    Public Function FechaYHoraSQL(ByVal dFecha As DateTime) As String
        If dFecha = Date.MinValue Then
            Return "'" & Format(FechaCorrecta(1, 1900), FORMATO_FECHA) & " 00:00:00:000'"
        End If
        Return "'" & Format(dFecha, FORMATO_FECHA) & " " & Format(dFecha, "HH:mm:ss:fff") & "'"
    End Function


    Public Function FechaSQL(ByVal dFecha As Date) As String
        If dFecha = Date.MinValue Then
            Return "'" & Format(FechaCorrecta(1, 1900), FORMATO_FECHA) & "'"
        End If
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

        Dim oItem As Prex.Utils.Entities.clsItem

        For Each oItem In oCombo.Items
            If oItem.Nombre.ToUpper = sCadena.ToUpper Then
                oCombo.SelectedItem = oItem
            End If
        Next

    End Sub

    'Seleccióna un campo especificado de un ImageCombo a partir de la "Key".
    Public Sub SelComboDevExpress(ByVal oCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal sCadena As String)

        Dim oItem As Prex.Utils.Entities.clsItem

        For Each oItem In oCombo.Properties.Items
            If "K" & oItem.Valor.ToString.ToUpper = sCadena.ToUpper Then
                oCombo.SelectedItem = oItem
            End If
        Next

    End Sub

    'Seleccióna un item de un combo box o list box
    Public Sub SelComboBox(ByVal oCombo_List As Object, ByVal sCadena As String)

        Dim oItem As Prex.Utils.Entities.clsItem

        For Each oItem In oCombo_List.Items
            If oItem.Valor.ToUpper = sCadena.ToUpper Then
                oCombo_List.SelectedItem = oItem
            End If
        Next

    End Sub

    Public Sub SelItemCombo(ByVal oCombo As Object, ByVal nCodigo As Long)

        Dim oItem As Prex.Utils.Entities.clsItem

        For Each oItem In oCombo.Items
            If oItem.Valor = nCodigo Then
                oCombo.SelectedItem = oItem
            End If
        Next

    End Sub

    Public Sub CargarCombo(ByVal oCombo As Object, ByVal sSQL As String)


        Try
            For Each l As Prex.Utils.Entities.clsItem In ObtenerItemsCombo(sSQL)
                oCombo.Items.Add(l)
            Next

            Application.DoEvents()

        Catch ex As Exception
            TratarError(ex, "CargarCombo")
        End Try

    End Sub

    Public Function ObtenerItemsCombo(ByVal sSQL As String) As List(Of Prex.Utils.Entities.clsItem)
        'Dim ad As OleDb.OleDbDataAdapter
        'Dim dt As DataTable
        'Dim dr As DataRow
        Dim lista As New List(Of Prex.Utils.Entities.clsItem)
        Dim ad As New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
        Dim dt As New DataTable

        ad.Fill(dt)

        For Each dr As DataRow In dt.Rows
            lista.Add(New Prex.Utils.Entities.clsItem(dr(0).ToString, dr(1).ToString))
        Next

        Return lista
    End Function

    Public Sub AgregarItemCombo(ByVal oCombo As Object, ByVal nCodigo As Long, ByVal sDescripcion As String)

        Try

            oCombo.Items.Add(New Prex.Utils.Entities.clsItem(nCodigo, sDescripcion))

        Catch ex As Exception
            TratarError(ex, "AgregarItemCombo")
        End Try

    End Sub

    Public Sub QuitarItemCombo(ByVal oCombo As Object, ByVal nCodigo As Long)

        Try

            For Each item As Prex.Utils.Entities.clsItem In oCombo.Items
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

        Dim rutaNormalizada As String = sRuta

        If rutaNormalizada.Where(Function(c) c = "%").Count() = 2 Then
            rutaNormalizada = Environment.ExpandEnvironmentVariables(rutaNormalizada)
        End If

        If Right(rutaNormalizada, 1) <> "\" Then
            Return rutaNormalizada & "\"
        Else
            Return rutaNormalizada
        End If

    End Function
    Public Sub CargarComboDevExpress(ByVal oCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal sSQL As String)
        CargarComboDevExpress(oCombo, sSQL, False)
    End Sub
    Public Sub CargarComboDevExpress(ByVal oCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal sSQL As String, ByVal formatearFecha As Boolean)

        Dim ad As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim oRow As DataRow

        Try
            oCombo.Properties.Items.Clear()

            ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
            dt = New DataTable

            ad.Fill(dt)

            For Each oRow In dt.Rows
                Dim oItem As New Prex.Utils.Entities.clsItem(oRow(0), oRow(1).ToString, formatearFecha)

                oCombo.Properties.Items.Add(oItem)

            Next

        Catch ex As Exception
            'nada
        End Try

    End Sub

    'Obtiene el Key de un ImageCombo o ListView.
    Public Function Llave(ByVal oLlave As Object) As String

        Dim oItem As Prex.Utils.Entities.clsItem

        If Not (oLlave.SelectedItem Is Nothing) Then
            oItem = oLlave.SelectedItem
            Return oItem.Valor.ToString.TrimEnd.Substring(1)
        Else
            Return "0"
        End If

    End Function

    'Obtiene el Key de un ImageCombo o ListView.
    Public Function LlaveCombo(ByVal oLlave As Object) As Object

        Dim oItem As Prex.Utils.Entities.clsItem

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
        'Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(sCadena))
        Return VB6Base64Decode(sCadena).Replace(vbNullChar, String.Empty)
    End Function

    Public Function sBase64Encode(ByVal sCadena As String) As String
        'Return Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(sCadena))
        Return VB6Base64Encode(sCadena)
    End Function

    Public Function FechaCorrecta(ByVal nMes As Integer, ByVal nAnio As Integer) As Date

        Dim i As Integer
        Dim sTemp As String
        If nMes = 12 Then
            Return DateTime.Parse((nAnio + 1).ToString() & "-" & Format(1, "00") & "-01").AddDays(-1)
        Else
            Return DateTime.Parse(nAnio.ToString() & "-" & Format(nMes + 1, "00") & "-01").AddDays(-1)
        End If
        '  For i = 31 To 28 Step -1

        '   sTemp = Format(i, "00") & "-" & Format(nMes, "00") & "-" & nAnio

        '   If IsDate(sTemp) Then

        '      Return CDate(sTemp)
        '      Exit Function

        '   End If

        'Next

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

    Public Sub GuardarArchivoEncriptadoNew(ByVal sNombreArchivo As String, ByVal sNombreUsuario As String, ByVal sPassword As String)

        On Error Resume Next

        Dim oText As IO.StreamWriter

        oText = IO.File.CreateText(sNombreArchivo)

        oText.WriteLine(Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(sNombreUsuario)))
        oText.WriteLine(Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(Prex.Utils.Configuration.PrexConfig.CYBERRARKPASS)))
        oText.WriteLine(sPassword)
        oText.Close()

        oText = Nothing

    End Sub

    Public Sub GuardarArchivoEncriptado(ByVal sNombreArchivo As String, ByVal sNombreUsuario As String, ByVal sPassword As String)

        On Error Resume Next

        Dim oText As IO.StreamWriter

        oText = IO.File.CreateText(sNombreArchivo)

        'var plainTextBytes = System.Text.Encoding.UTF8.GetBytes("S_Mm4[Gi");
        'var dd = System.Convert.ToBase64String(plainTextBytes);
        oText.WriteLine(sBase64Encode(sNombreUsuario))
        oText.WriteLine(sBase64Encode(sPassword))
        oText.Close()

        oText = Nothing

    End Sub

    Public Sub LeerArchivoEncriptado(ByVal sNombreArchivo As String, ByRef sNombreUsuario As String, ByRef sPassword As String)

        Dim oText As StreamReader

        oText = IO.File.OpenText(sNombreArchivo)
        sNombreUsuario = sBase64Decode(oText.ReadLine).Replace(vbNullChar, String.Empty)
        sPassword = sBase64Decode(oText.ReadLine).Replace(vbNullChar, String.Empty)
        oText.Close()

        oText = Nothing

    End Sub

    Public Sub ValidarCamposNuevosLogSis(oAdmTablas As AdmTablas)
        Try
            Dim sql1 = "select ISNULL(COL_LENGTH('dbo.LogSis', 'LS_SECUEN') , 0)"
            Dim sql2 = "select ISNULL(COL_LENGTH('dbo.LogSis', 'LS_WKSTAT') , 0)"

            Dim ds As DataSet = oAdmTablas.AbrirDataset(sql1, guardaLog:=False)
            If ds Is Nothing Then
                Throw New Exception("No fue posible conectarse al SQL")

            End If
            If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(0).Rows(0).Item(0) = 0 Then
                oAdmTablas.EjecutarComandoAsincrono("ALTER TABLE dbo.LOGSIS ADD	LS_SECUEN int NOT NULL IDENTITY (1, 1)")
            End If

            ds = oAdmTablas.AbrirDataset(sql2)
            If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(0).Rows(0).Item(0) = 0 Then
                oAdmTablas.EjecutarComandoAsincrono("ALTER TABLE dbo.LOGSIS ADD LS_WKSTAT varchar(240) NULL")
            End If

        Catch ex As Exception
            Throw New Exception("Ocurrió un error ValidarCamposNuevosLogSis", ex)
        End Try
    End Sub

    Public Sub GuardarLOG(ByVal nAccionLOG As AccionesLOG,
                          ByVal sExtra As String,
                          Optional ByVal nCodigoTransaccion As Long = -1,
                          Optional ByVal nCodigoUsuario As Long = -1)

        Try

            Dim oAdmLOG As New AdmTablas
            Dim sSQL As String

            oAdmLOG.ConnectionString = CONN_LOCAL
            ValidarCamposNuevosLogSis(oAdmLOG)
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
            sSQL = sSQL.Replace("@FECLOG", FechaSQL(DateTime.Now))
            sSQL = sSQL.Replace("@HORLOG", "'" & Format(DateTime.Now, "HH:mm:ss") & "'")
            sSQL = sSQL.Replace("@ACCION", nAccionLOG)
            sSQL = sSQL.Replace("@CODTRA", nCodigoTransaccion)
            sSQL = sSQL.Replace("@EXTRA", "'" & sExtra.Replace("'", "") & "'")
            sSQL = sSQL.Replace("@WKSTAT", "'" & System.Environment.MachineName & "'")

            oAdmLOG.EjecutarComandoAsincrono(sSQL, "", 0, Nothing, True)

            oAdmLOG = Nothing

        Catch ex As Exception
            Throw New Exception("Ocurrio un error en GuardarLOG ", ex)
        End Try
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
    Public Function ReemplazarVariables(ByVal sSQL As String, ByVal controls As Control.ControlCollection) As String
        Return ReemplazarVariables(sSQL, controls, Nothing)
    End Function

    Public Function ReemplazarVariables(ByVal sSQL As String, ByVal controls As Control.ControlCollection, ByVal codProc As Long?) As String

        Try

            Dim lista As Dictionary(Of String, String) = ObtenerValoresControles(controls)
            For Each d As KeyValuePair(Of String, String) In lista
                sSQL = sSQL.Replace(d.Key, d.Value)
            Next

            If codProc.HasValue Then
                sSQL = Replace(sSQL, "@CODPRO", codProc.Value.ToString, , , vbTextCompare)
                sSQL = Replace(sSQL, "@CODUSU", UsuarioActual.Codigo, , , vbTextCompare)
                sSQL = Replace(sSQL, "@CODIGO_ENTIDAD", CODIGO_ENTIDAD.ToString, , , vbTextCompare)
                sSQL = Replace(sSQL, "@CODIGO_TRANSACCION", CODIGO_TRANSACCION.ToString, , , vbTextCompare)
            End If

            Return sSQL
        Catch ex As Exception
            Throw New Exception("Ocurrio un error en ReemplazarVariables ", ex)
		End Try

	End Function

    Public Function ObtenerValoresControles(ByVal controls As Windows.Forms.Control.ControlCollection) As Dictionary(Of String, String)
        Dim oCtl As Windows.Forms.Control
        Dim lista As New Dictionary(Of String, String)
        Dim sValor As String

        For Each oCtl In controls

            Select Case oCtl.GetType.ToString.Substring(oCtl.GetType.ToString.LastIndexOf(".") + 1)
                Case "ComboBox"
                    If TypeOf CType(oCtl, ComboBox).SelectedItem Is Prex.Utils.Entities.clsItem Then
                        Dim oItem As Prex.Utils.Entities.clsItem = CType(oCtl, ComboBox).SelectedItem
                        sValor = "'" + oItem.Valor.ToString + "'"
                    Else
                        sValor = "'" + CType(oCtl, ComboBox).SelectedItem.ToString + "'"
                    End If
                Case "ComboBoxEdit"
                    If TypeOf CType(oCtl, DevExpress.XtraEditors.ComboBoxEdit).SelectedItem Is Prex.Utils.Entities.clsItem Then
                        Dim oItem As Prex.Utils.Entities.clsItem = CType(oCtl, DevExpress.XtraEditors.ComboBoxEdit).SelectedItem
                        sValor = "'" + oItem.Valor.ToString + "'"
                    Else
                        sValor = "'" + CType(oCtl, DevExpress.XtraEditors.ComboBoxEdit).SelectedItem.ToString + "'"
                    End If
                Case "CheckBox"
                    sValor = IIf(CType(oCtl, CheckBox).Checked, oCtl.Tag, "")
                Case "CheckEdit"
                    sValor = IIf(CType(oCtl, DevExpress.XtraEditors.CheckEdit).Checked, oCtl.Tag, "")
                Case "DateTimePicker"
                    sValor = FechaSQL(DirectCast(oCtl, DateTimePicker).Value)
                Case "DateEdit"
                    sValor = FechaSQL(DirectCast(oCtl, DevExpress.XtraEditors.DateEdit).DateTime)
                Case "TextBox"
                    Dim oVar As clsVariables = CType(oCtl.Tag, clsVariables)
                    If ((oVar IsNot Nothing AndAlso oVar.Tipo = 1) OrElse Not IsNumeric(oCtl.Text)) Then
                        sValor = "'" & oCtl.Text & "'"
                    Else
                        sValor = oCtl.Text
                    End If

                Case Else

                    Dim valorDecimal As Decimal

                    If Decimal.TryParse(oCtl.Text.Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator), valorDecimal) Then
                        sValor = valorDecimal.ToString().Replace(",", ".")
                    Else
                        sValor = oCtl.Text
                    End If


            End Select


            If oCtl.Name.Substring(0, 1) = "_" Then
                If Not lista.ContainsKey(oCtl.Name.Substring(1)) Then
                    lista.Add(oCtl.Name.Substring(1), String.Empty)
                End If
                lista(oCtl.Name.Substring(1)) = sValor
            End If

        Next
        Return lista
    End Function

    Public Sub PresentarDatos(ByVal formulario As Form, ByVal nCodigoTransaccion As Long, ByVal nCodigoUsuario As Long, ByVal nCodigoEntidad As Long)

        Try
            Try

                Dim oAdmlocal As New AdmTablas
                oAdmlocal.ConnectionString = CONN_LOCAL

                Dim sSQL As String
                Dim ds As DataSet
                Dim sError As String = ""

                ''''' USUARIO '''''

                sSQL = "SELECT    US_CODUSU, US_NOMBRE, US_DESCRI, US_ADMIN " &
            "FROM      USUARI " &
            "WHERE     US_CODUSU = " & nCodigoUsuario
                ds = oAdmlocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Falla de seguridad - US_CODUSU: " & nCodigoUsuario)
                    Else
                        UsuarioActual.Codigo = nCodigoUsuario
                        UsuarioActual.Nombre = .Rows(0).Item("US_NOMBRE").ToString
                        UsuarioActual.Descripcion = .Rows(0).Item("US_DESCRI").ToString
                        UsuarioActual.Admin = CBool(.Rows(0).Item("US_ADMIN"))
                        UsuarioActual.SoloLectura = False
                        SetLabelTexto(formulario, "lblUsuario", UsuarioActual.Descripcion)
                    End If

                End With

                ds = Nothing

                ''''' ENTIDAD '''''

                sSQL = "SELECT    TG_CODCON, TG_DESCRI " &
            "FROM      TABGEN " &
            "WHERE     TG_CODTAB = 1 " &
            "AND       TG_CODCON = " & nCodigoEntidad
                ds = oAdmlocal.AbrirDataset(sSQL)

                With ds.Tables(0)

                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Parámetro de entidad no válido - TG_CODCON: " & nCodigoEntidad)
                    Else
                        NOMBRE_ENTIDAD = .Rows(0).Item("TG_DESCRI").ToString
                        SetLabelTexto(formulario, "lblEntidad", NOMBRE_ENTIDAD)
                    End If

                End With

                ds = Nothing

                ''''' TRANSACCION '''''

                sSQL = "SELECT    MU_TRANSA, MU_DESCRI " &
            "FROM      MENUES " &
            "WHERE     MU_CODTRA = " & nCodigoTransaccion
                ds = oAdmlocal.AbrirDataset(sSQL)

                With ds.Tables(0)


                    If .Rows.Count = 0 Then
                        Throw New Security.SecurityException("Error en la línea de comandos. Parámetro de transacción incorrecto - MU_CODTRA: " & nCodigoTransaccion)
                    Else
                        formulario.Text = "Transacción:" & CODIGO_TRANSACCION.ToString & " - " & .Rows(0).Item("MU_TRANSA").ToString
                        SetLabelTexto(formulario, "lblTransaccion", CType(.Rows(0).Item("MU_DESCRI"), String))
                        SetLabelTexto(formulario, "lblTitulo", .Rows(0).Item("MU_TRANSA").ToString)
                        SetLabelTexto(formulario, "lblSubtitulo", .Rows(0).Item("MU_DESCRI").ToString)
                    End If

                End With

                ds = Nothing
            Catch ex As Security.SecurityException
                MensajeError(ex.Message)
                formulario.Close()
            End Try
        Catch ex As Exception
            TratarError(ex, "PresentarDatos")
            formulario.Close()
        End Try

    End Sub

    Private Sub SetLabelTexto(formulario As Form, labelName As String, texto As String)
        Dim label As Control = formulario.Controls.Find(labelName, True).FirstOrDefault()
        If label IsNot Nothing Then
            If TryCast(label, Label) IsNot Nothing Then
                CType(label, Label).Text = texto
            End If
        End If
    End Sub


    Public Function NombreUsuarioNT() As String
        Return Environment.UserName
        'Dim sBuffer As String * 255
        'Dim lResult As Long
        'Dim nLen As Long

        'nLen = 255

        'lResult = GetUserName(sBuffer, nLen)
        'NombreUsuarioNT = Left(sBuffer, nLen - 1)

    End Function

    Public Function NombrePCLocal() As String
        Return Environment.MachineName
        'Dim sBuffer As String * 255
        'Dim lResult As Long
        'Dim nLen As Long

        'nLen = 255

        'lResult = GetComputerName(sBuffer, nLen)
        'NombrePCLocal = Left(sBuffer, nLen - 1)

    End Function
End Module
