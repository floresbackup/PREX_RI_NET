
Module modLocalMain

   Public NOMBRE_NUEVA_TABLA As String
   Public DESCRIPCION_NUEVA_TABLA As String
   Public FECHA_VIG_NUEVA_TABLA As Date

   Sub Main()

      'Configuración
      LeerXML()
		Dim rutaLocalDll = Prex.Utils.Misc.Functions.ValidarYCopiarPathDll(CARPETA_LOCAL, System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies())

		CulturaActual = System.Threading.Thread.CurrentThread.CurrentCulture
      CulturaCargarTextos(CulturaActual.ToString)
        If Not frmMain.ErrorPermiso Then
            frmMain.ShowDialog()
        End If

    End Sub

End Module
