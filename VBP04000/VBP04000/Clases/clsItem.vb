Public Class clsItem

   Public Structure Item
      Dim Valor As Object
      Dim Nombre As String
		Dim Tag As String
		Dim Format As Boolean


		Public Sub New(ByVal _Valor As Object, ByVal _Nombre As String)
			Valor = _Valor
			Nombre = _Nombre
		End Sub

		Public Sub New(ByVal _Valor As Object, ByVal _Nombre As String, ByVal _Tag As String, ByVal formatearFecha As Boolean)
			Valor = _Valor
			Nombre = _Nombre
			Tag = _Tag
			Format = formatearFecha
		End Sub

		Public Overrides Function ToString() As String
			Dim d As DateTime = Nothing
			If Format AndAlso DateTime.TryParse(Valor, d) Then Return d.ToString("dd/MM/yyyy")
			Return Me.Nombre
		End Function

	End Structure

End Class
