Module modLocalMain

   Sub Main()

      'Configuración
      LeerXML()

      CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
      CulturaCargarTextos(CulturaActual.ToString)

      frmMain.ShowDialog()

   End Sub

End Module
