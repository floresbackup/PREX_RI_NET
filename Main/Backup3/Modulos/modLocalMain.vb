
Module modLocalMain

   Public NOMBRE_NUEVA_TABLA As String
   Public DESCRIPCION_NUEVA_TABLA As String
   Public FECHA_VIG_NUEVA_TABLA As Date

   Sub Main()

      'Configuraci�n
      LeerXML()

      CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
      CulturaCargarTextos(CulturaActual.ToString)

      frmMain.ShowDialog()

   End Sub

End Module
