
Module modLocalMain

   Public DirectivaVigente As New clsSeguridad

   Sub Main()

      'Configuraci�n
      LeerXML()

      CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
      CulturaCargarTextos(CulturaActual.ToString)

      frmMain.ShowDialog()

   End Sub

End Module
