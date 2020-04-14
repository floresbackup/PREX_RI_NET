Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraLayout.Localization
Imports Prex.Utils
Public Class locale
	Inherits Localizer

	Public Overrides ReadOnly Property Language As String
		Get
			Return CultureInfo.CurrentCulture.IetfLanguageTag
		End Get
	End Property
End Class
Public Class Xtralocale
	Inherits LayoutResLocalizer

	Public Overrides ReadOnly Property Language As String
		Get
			Return CultureInfo.CurrentCulture.IetfLanguageTag
		End Get
	End Property
End Class

Module ModLocalMain
	Sub Main()

		'Configuración
		Dim currentDomain As AppDomain = AppDomain.CurrentDomain

		Configuration.LeerXML()
		Dim rutaLocalDll = Prex.Utils.Misc.Functions.ValidarYCopiarPathDll(Configuration.PrexConfig.CARPETA_LOCAL, System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies())
		AddHandler currentDomain.AssemblyResolve, AddressOf LoadFromSameFolder

		Configuration.PrexConfig.CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
		ConfiguracionCultura.CulturaCargarTextos(Configuration.PrexConfig.CulturaActual.ToString)

		'Dim cc = CultureInfo.CurrentCulture

		'LayoutResLocalizer.Active = New Xtralocale()
		'Localizer.Active = New locale()
		'LayoutLocalizer.Active = LayoutResLocalizer.Active
		'LayoutLocalizer.Active = LayoutResLocalizer.Active

		If Not frmMain.ErrorPermiso Then
			frmMain.ShowDialog()
		End If

	End Sub
	Public Function LoadFromSameFolder(sender As Object, args As ResolveEventArgs) As Assembly
		Dim folderPath As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
		Dim assemblyPath As String = Path.Combine(Path.Combine(Configuration.PrexConfig.CARPETA_LOCAL, "Lib"), New AssemblyName(args.Name).Name + ".dll")
		If Not File.Exists(assemblyPath) Then Return Nothing

		Dim ass = Assembly.LoadFrom(assemblyPath)
		Return ass
	End Function
End Module
