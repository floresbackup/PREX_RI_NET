Imports System.IO

Module modArchivos

   Public Function NombreArchivo(ByVal sRutaArchivo As String) As String
      Return System.IO.Path.GetFileName(sRutaArchivo)
   End Function

   Public Function CopiarArchivo(ByVal sOrigen As String, ByVal sDestino As String, Optional ByVal bSobreescribe As Boolean = False) As Boolean

      File.Copy(sOrigen, sDestino, bSobreescribe)
      Application.DoEvents()
      Return File.Exists(sDestino)

   End Function

   Public Function ArchivoExiste(ByVal sRutaArchivo As String) As Boolean

      Return File.Exists(sRutaArchivo)

   End Function

   Public Function CarpetaExiste(ByVal sRuta As String) As Boolean

      Return Directory.Exists(sRuta)

   End Function

End Module
