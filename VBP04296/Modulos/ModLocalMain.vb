Imports Prex.Utils

Module ModLocalMain
    Sub Main()

        'Configuración
        Configuration.LeerXML()

        Configuration.PrexConfig.CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
        ConfiguracionCultura.CulturaCargarTextos(Configuration.PrexConfig.CulturaActual.ToString)
        If Not frmMain.ErrorPermiso Then
            frmMain.ShowDialog()
        End If

    End Sub

End Module
