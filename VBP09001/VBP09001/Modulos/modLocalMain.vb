Module modLocalMain


    Sub Main()
        RunProgram("Emilse", "sally2006", "", "C:\Windows\Notepad.exe", "")
        'Configuración
        LeerXML()

        CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
        CulturaCargarTextos(CulturaActual.ToString)

        frmMain.Cargar()
        frmMain.ShowDialog()

    End Sub



End Module

