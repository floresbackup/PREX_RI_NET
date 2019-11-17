Public Class clsItem

    Public Class Item
        Public Property Valor As Object
        Public Property Nombre As String

        Public Sub New(ByVal _Valor As Object, ByVal _Nombre As String)
            Valor = _Valor
            Nombre = _Nombre
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Nombre
        End Function

    End Class

End Class
