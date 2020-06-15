
Imports System.IO
Imports System.Linq

Module modLocalMain

	Public CONSULTA_SELECCIONADA As Long
	Public FORMATEAR_NUMEROS As Boolean

	Sub Main()
		PrevInstance()
		'Configuración
		LeerXML()
		LeerXMLLocal()
		'Dim rutaLocalDll = Prex.Utils.Misc.Functions.ValidarYCopiarPathDll(CARPETA_LOCAL, System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies())
		AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Prex.Utils.Misc.Functions.LoadFromSameFolder

		CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
		CulturaCargarTextos(CulturaActual.ToString)


		Dim frmMain As New frmMain
		If Not frmMain.ErrorPermiso Then frmMain.ShowDialog()
	End Sub

	Private Sub PrevInstance()

		Dim MisProcesos() As Process

		MisProcesos = Process.GetProcessesByName(Application.ProductName.ToString)

		If MisProcesos.Length > 1 Then
			MessageBox.Show("Esta aplicación ya se encuentra activa")
			End
		End If

	End Sub

	Public Sub LeerXMLLocal()
		Try

			Dim sRuta As String
			Dim oConfigLocal As New dsConfig
			Dim carpetaConusuario As String = String.Empty

			Dim usuario As Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
			If usuario.Name.Split("\").Count() > 1 Then
				carpetaConusuario = Path.Combine(CARPETA_LOCAL, usuario.Name.Split("\").LastOrDefault())
			Else
				carpetaConusuario = Path.Combine(CARPETA_LOCAL, usuario.Name)
			End If

			If Not Directory.Exists(carpetaConusuario) Then
				Directory.CreateDirectory(carpetaConusuario)
			End If

			sRuta = Path.Combine(carpetaConusuario, NOMBRE_INI_LOCAL)

			If File.Exists(CARPETA_LOCAL & NOMBRE_INI_LOCAL) AndAlso Not File.Exists(sRuta) Then
				File.Copy(CARPETA_LOCAL & NOMBRE_INI_LOCAL, sRuta)
			End If

			If IO.File.Exists(sRuta) Then
				oConfigLocal.ReadXml(sRuta)

				For Each row As DataRow In oConfigLocal.Tables("CONFIG").Rows

					Select Case row("NOMBRE").ToString

						Case "FORMATEAR_NUMEROS"
							FORMATEAR_NUMEROS = Boolean.Parse(row("FORMATEAR_NUMEROS").ToString)

					End Select

				Next

			End If

		Catch ex As Exception
			TratarError(ex, "LeerXMLLocal")
		End Try

	End Sub




End Module
