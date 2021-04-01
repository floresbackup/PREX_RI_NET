Module modLocalMain


    Sub Main()
        'Configuración
        LeerXML(False)
        Prex.Utils.Configuration.LeerXML(ARCHIVO_CONFIG, False)

        ObtenerConnectionCyberark()

        'Dim rutaLocalDll = Prex.Utils.Misc.Functions.ValidarYCopiarPathDll(CARPETA_LOCAL, System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies())
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Prex.Utils.Misc.Functions.LoadFromSameFolder

		CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
        CulturaCargarTextos(CulturaActual.ToString)
        If Not frmMain.ErrorPermiso Then
            frmMain.Cargar()
            frmMain.ShowDialog()
        End If

    End Sub



End Module

