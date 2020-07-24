
Imports System.Configuration
Imports System.IO
Imports System.Linq
Imports System.Reflection

Module modLocalMain

	'Propiedades lanzador
	Public HABILITACIONES_ESPECIALES As String
	Public INHABILITACIONES_ESPECIALES As String
	Public LOADING_APP As Boolean

	'Ejecutar como...
	Public CODIGO_ENTIDAD_AUTH As Double
	Public NOMBRE_USU_AUTORIZADO As String
	Public USUARIO_AUTORIZADO As Boolean

	Sub Main()
		Dim paso = "Inicio"
		Try


			Dim bIniciar As Boolean = True

			PrevInstance()

			'Configuración
			paso = "LeerXML"
			LeerXML()
			paso = "UtilsLeerXML"
			Prex.Utils.Configuration.LeerXML()
			'Prex.Utils.Configuration.LeerXMLLocal()
			paso = "VerificarCarpetasLocales"
			Prex.Utils.Configuration.VerificarCarpetasLocales()
			Dim currentDomain As AppDomain = AppDomain.CurrentDomain

			Dim oSplash As New SplashScreen
			paso = "Show"

			oSplash.AcercaDe = False
			oSplash.Show()
			Application.DoEvents()

			Dim rutaLocalDll = Prex.Utils.Misc.Functions.ValidarYCopiarPathDll(CARPETA_LOCAL, System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies())
			If (rutaLocalDll.ToString().Any()) Then AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Prex.Utils.Misc.Functions.LoadFromSameFolder

			If UsuarioActual.Codigo = 0 Then
				If IO.File.Exists(CARPETA_LOCAL & "TEMP\conn.enc") Then
					IO.File.Delete(CARPETA_LOCAL & "TEMP\conn.enc")
				End If
			End If

			If Right(Command, 3) = "IDE" Then
				RUTA_BIN = ConfigurationManager.AppSettings.Item("PATHDEBUG")
			Else
				RUTA_BIN = NormalizarRuta(Application.StartupPath)
			End If
			paso = "InicioSesion"

			Dim oInicioSesion As New frmInicioSesion

			If Command.Length > 30 Then 'MORGAN SSOBA
				oInicioSesion.ModoAutenticacion = frmInicioSesion.eModoAutenticacion.AutenticacionExterna
				InicioSSOBA()
			ElseIf ID_SISTEMA > 0 Then
				oInicioSesion.ModoAutenticacion = frmInicioSesion.eModoAutenticacion.AutenticacionExterna
				bIniciar = InicioCITI()
			ElseIf SEGURIDAD_INTEGRADA Then 'BANCOR
				oInicioSesion.ModoAutenticacion = frmInicioSesion.eModoAutenticacion.AutenticacionExterna
				oInicioSesion.txtUsuario.Enabled = False
				oInicioSesion.txtPassword.Enabled = False
				oInicioSesion.cboDominio.Enabled = False
			ElseIf AUTENTICACIONSQL Then 'LOGIN POR SQL
				oInicioSesion.ModoAutenticacion = frmInicioSesion.eModoAutenticacion.AutenticacionSQL
			End If
			System.Threading.Thread.Sleep(2500)
			oSplash.Close()
			oSplash = Nothing
			Application.DoEvents()

			If oInicioSesion.ModoAutenticacion <> frmInicioSesion.eModoAutenticacion.AutenticacionExterna Then
				oInicioSesion.ShowDialog()
				bIniciar = oInicioSesion.Autenticado
			End If

			oInicioSesion = Nothing

			If bIniciar Then

				CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
				CulturaCargarTextos(CulturaActual.ToString)

				frmMain.ShowDialog()
				Prex.Utils.Configuration.PrexConfigLocal.LastUser = UsuarioActual.Nombre
				Prex.Utils.Configuration.GuardarXMLLocal()
				GuardarLOG(AccionesLOG.AL_INGRESO_SISTEMA, "", -1, UsuarioActual.Codigo)
			End If

			End
		Catch ex As Exception
			MessageBox.Show("Error en " & paso & Environment.NewLine & "Detalle:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub


	'Private Sub LeerDllDevExpress(pathDll As String)

	'	Dim strTempAssmbPath As New Dictionary(Of String, String)()
	'	Dim objExecutingAssemblies As Assembly = Assembly.GetExecutingAssembly()

	'	Dim arrReferencedAssmbNames As AssemblyName() = objExecutingAssemblies.GetReferencedAssemblies()

	'	For Each strAssmbName As AssemblyName In arrReferencedAssmbNames

	'		If strAssmbName.Name.ToLower().Contains("devexpress") Then
	'			strTempAssmbPath.Add(strAssmbName.FullName, pathDll & Path.DirectorySeparatorChar & strAssmbName.Name & ".dll")
	'		End If
	'	Next
	'	For Each ass As KeyValuePair(Of String, String) In strTempAssmbPath.ToList()
	'		Dim s As Assembly = Assembly.LoadFrom(ass.Value)
	'	Next


	'End Sub

	Private Sub PrevInstance()

		Dim MisProcesos() As Process

		MisProcesos = Process.GetProcessesByName(Application.ProductName.ToString)

		If MisProcesos.Length > 1 Then
			Dim usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name
			If MisProcesos.Any(Function(p) p.Id <> Process.GetCurrentProcess().Id AndAlso
				Prex.Utils.Misc.Functions.GetProcessOwner(p.Id).ToLower() = usuario.ToString.ToLower()) Then
				MessageBox.Show("Esta aplicación ya se encuentra activa")
				End
			End If

		End If

	End Sub

	Public Function GenerarConexionSSOBA() As Boolean

		On Error GoTo Maneja_Error

		Dim rstSSOBA As ADODB.Recordset
		Dim cSSOBA As Object
		Dim strMsg As String
		Dim sToken As String

		sToken = Command()

		'    UsuarioActual.Nombre = "admin"
		'    USUARIO_DB = "sa"
		'    PASSWORD_DB = "sa"
		'    GenerarConexionSSOBA = True
		'    Exit Function

		GenerarConexionSSOBA = False

		cSSOBA = CreateObject("SSOBAapi.cLogin")
		cSSOBA.ServiceName = WEBSERNAME
		'--------------------------------
		' Verifico el Token
		'--------------------------------
		rstSSOBA = cSSOBA.VerifyToken(sToken)
		If Not (rstSSOBA.BOF Or rstSSOBA.EOF) Then
			'--------------------------------
			UsuarioActual.Nombre = rstSSOBA.Fields("LOGIN").Value
			UsuarioActual.Descripcion = rstSSOBA.Fields("NOMBRE").Value
			'--------------------------------
		Else
			'--------------------------------
			MensajeError("Falta Usuario en SSOBA!!!")
			Return False
			GoTo Maneja_Error
			'--------------------------------
		End If
		'--------------------------------
		' Conecto con los Genericos
		'--------------------------------
		rstSSOBA = cSSOBA.GetUsuariosBaseDatos(sToken)
		If Not (rstSSOBA.BOF Or rstSSOBA.EOF) Then
			'--------------------------------
			rstSSOBA.Find("ORIGEN = '" & SRVORIGEN & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 1)

			If rstSSOBA.EOF Then
				MensajeError("Falta Usuario Generico de origen en SSOBA!!!")
				Return False
				GoTo Maneja_Error
			End If

			USUARIO_DB = rstSSOBA.Fields("LOGIN").Value
			PASSWORD_DB = rstSSOBA.Fields("PASSWORD").Value
			'--------------------------------
		Else
			'--------------------------------
			MensajeError("Falta Usuario Generico en SSOBA!!!")
			Return False
			GoTo Maneja_Error
			'--------------------------------
		End If
		'---------------------------

Maneja_Error:

		rstSSOBA = Nothing
		cSSOBA = Nothing

		If Err.Number <> 0 Then
			TratarErrorErr(Err, "GenerarConexionSSOBA")
		Else
			Return True
		End If

	End Function

	Private Sub InicioSSOBA()

		If GenerarConexionSSOBA() Then
			CONN_LOCAL = CONN_LOCAL & ";User id=" & USUARIO_DB & ";password=" & PASSWORD_DB & ";"
			GuardarArchivoEncriptado(CARPETA_LOCAL & "TEMP\conn.enc", USUARIO_DB, PASSWORD_DB)
			bJPMORGAN = True

			Dim oAdmTablas As New AdmTablas

			oAdmTablas.ConnectionString = CONN_LOCAL

			NOMBRE_ENTIDAD = oAdmTablas.DevolverValor("TABGEN", "TG_DESCRI", "TG_CODTAB=1 AND TG_NUME01=1")
			CODIGO_ENTIDAD = oAdmTablas.DevolverValor("TABGEN", "TG_CODCON", "TG_CODTAB=1 AND TG_NUME01=1")
			UsuarioActual.Codigo = oAdmTablas.DevolverValor("USUARI", "US_CODUSU", "WHERE US_NOMBRE = '" & UsuarioActual.Nombre & "'")

			oAdmTablas = Nothing

			GuardarLOG(AccionesLOG.AL_INGRESO_SISTEMA, "")

		End If

	End Sub

	Public Function InicioCITI() As Boolean
		GuardarLOG(AccionesLOG.AL_INGRESO_SISTEMA, "InicioCITI")
		Dim sNombre As String = String.Empty
		Dim sPerfil As String
		'        Dim sPerfil2 = String.Empty
		Try

			sPerfil = Nothing
			Dim sgResponse As String = String.Empty

			Dim SGInterface As SGInterface = FactorySGInstance.getInstanceInterface()
			Dim returnValue As Integer = -1
			returnValue = SGInterface.RsmsLogin(ID_SISTEMA.ToString(), "Gestión RI", SG_CONFIG, sgResponse)
			If (returnValue = 1) Then
				'SC08822|SC08822
				'SG_ME66396_160771_3265|#######
				'MessageBox.Show(frmMain, "Login devuelve: " & sgResponse, "Login SGLibrary", MessageBoxButtons.OK)
				Dim responseSplit As String() = sgResponse.Replace("[", String.Empty).Replace("]", String.Empty).Split(New String() {"|"}, StringSplitOptions.RemoveEmptyEntries)
				If (responseSplit.Where(Function(s) s.Any()).Any() AndAlso Not responseSplit.FirstOrDefault() Is Nothing) Then
					If responseSplit.Any(Function(s) s.ToLower.Contains("sg_")) Then
						Dim usuarioCiti As String() = responseSplit.FirstOrDefault(Function(s) s.ToLower.Contains("sg_")).Trim().Split(New String() {"_"}, StringSplitOptions.RemoveEmptyEntries)
						If usuarioCiti.Any AndAlso usuarioCiti.FirstOrDefault().ToLower() = "sg" Then
							sNombre = usuarioCiti(1)
						End If
					End If
					If sNombre = String.Empty AndAlso responseSplit.Count() > 1 Then
						sNombre = responseSplit.FirstOrDefault()
					End If
				Else
					sNombre = String.Empty
				End If

				sPerfil = SGInterface.AccFunctions().Replace("[", String.Empty).Replace("]", String.Empty).Trim
				'MessageBox.Show(frmMain, "Functions: " & sPerfil, "Login SGLibrary", MessageBoxButtons.OK)

				Dim oAdmTablas As New AdmTablas

				oAdmTablas.ConnectionString = CONN_LOCAL

				NOMBRE_ENTIDAD = oAdmTablas.DevolverValor("TABGEN", "TG_DESCRI", " TG_CODTAB=1 AND TG_NUME01=1").ToString()
				CODIGO_ENTIDAD = Long.Parse(oAdmTablas.DevolverValor("TABGEN", "TG_CODCON", " TG_CODTAB=1 AND TG_NUME01=1").ToString())
				UsuarioActual.Nombre = sNombre
				UsuarioActual.Codigo = Long.Parse(oAdmTablas.DevolverValor("USUARI", "US_CODUSU", " US_NOMBRE = '" & sNombre & "'", "0").ToString())
				UsuarioActual.Descripcion = oAdmTablas.DevolverValor("USUARI", "US_DESCRI", " US_NOMBRE = '" & sNombre & "'", sNombre).ToString

				oAdmTablas = Nothing

				GuardarLOG(AccionesLOG.AL_INGRESO_SISTEMA, "Perfil: " & sPerfil & " - SG Response: " & sgResponse)

				If Not frmMain.ActualizarSeguridad(sPerfil.Replace("[", String.Empty).Replace("]", String.Empty).Trim) Then
					Throw New Exception("No se encontró [DP_CODTRA] para el perfil " & sPerfil)
				End If
				CITI_PERFIL = sPerfil
				Return True
			Else
				Return False
			End If

		Catch ex As Exception
			TratarError(ex, "InicioCiti")
			Return False
		End Try

	End Function



End Module
