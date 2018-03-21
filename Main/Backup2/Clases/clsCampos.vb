Public Class clsCampos

   Public Enum eTipoDatosCampos
      tdcNumeroEntero = 0
      tdcNumero2Decimales = 2
      tdcNumero4Decimales = 4
      tdcNumero6Decimales = 6
      tdcTexto = 84
      tdcFecha = 70
   End Enum

   Public Enum eValidacionCampos
      vcSinValidacion = 0
      vcValidaFecha = 1
      vcValidaEntidad = 2
      vcValidaCuenta = 3
      vcConvierteAdecimal = 50
      vcIncorporaEntidad = 98
      vcIncorporaFecha = 99
   End Enum

   'Variables
   Public Nombre As String
   Public Campo As String
   Public Inicio As Long
   Public Longitud As Long
   Public Fin As Long
   Public CampoDestino As String
   Public TipoDato As eTipoDatosCampos
   Public Formato As String
   Public Marca As Integer
   Public Relacion As String
   Public Valida As eValidacionCampos
   Public CodEntidad As Long
   Public Fecha As Date
   Public Clave As Integer
   Public Valor As Object
   Public TipoDatoADO As String
   Public Key As String

End Class
