
Module modLocalMain

   Public DirectivaVigente As New clsSeguridad

   Sub Main()

      'Configuraci�n
      LeerXML()

      CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
      CulturaCargarTextos(CulturaActual.ToString)
        If Not frmMain.ErrorPermiso Then
            frmMain.ShowDialog()
        End If

    End Sub

End Module
