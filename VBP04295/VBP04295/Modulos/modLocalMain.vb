Module modLocalMain

   Sub Main()

        'Configuraci�n
        LeerXML()
		Dim rutaLocalDll = Prex.Utils.Misc.Functions.ValidarYCopiarPathDll(CARPETA_LOCAL, System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies())

		CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
        CulturaCargarTextos(CulturaActual.ToString)

        If Not frmMain.ErrorPermiso Then
            frmMain.ShowDialog()
        End If

    End Sub

End Module
