Public Class clsItem

   Public Structure Item
      Dim Valor As Object
      Dim Nombre As String
        Dim Periodo As String

        Public Sub New(ByVal _Valor As Object, ByVal _Nombre As String)
            Valor = _Valor
            Nombre = _Nombre
        End Sub

        Public Sub New(ByVal _Valor As Object, ByVal _Nombre As String, ByVal _periodo As String)
            Valor = _Valor
            Nombre = _Nombre
            Periodo = _periodo
        End Sub

        Public Overrides Function ToString() As String
         Return Me.Nombre
      End Function

   End Structure

End Class
