Imports System.IO
Imports System.Reflection

Module modLocalMain

	Sub Main()

		'Dim rutaLocalDll = Prex.Utils.Misc.Functions.ValidarYCopiarPathDll(CARPETA_LOCAL, System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies())
		AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Prex.Utils.Misc.Functions.LoadFromSameFolder

		'Configuración
		LeerXML()

		CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
		CulturaCargarTextos(CulturaActual.ToString)

		If Not frmMain.ErrorPermiso Then
			frmMain.ShowDialog()
		End If

	End Sub



	'Public Function LoadFromSameFolder(sender As Object, args As ResolveEventArgs) As Assembly
	'	Dim folderPath As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
	'	Dim assemblyPath As String = Path.Combine(Path.Combine(CARPETA_LOCAL, "Lib"), New AssemblyName(args.Name).Name + ".dll")
	'	If Not File.Exists(assemblyPath) Then Return Nothing

	'	Dim ass = Assembly.LoadFrom(assemblyPath)
	'	Return ass
	'End Function
End Module
