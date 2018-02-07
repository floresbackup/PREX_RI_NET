Imports DevExpress.XtraBars.Localization

Public Class cBarsLocalizer

    Inherits BarLocalizer 
    ' overriding the GetLocalizedString method
    Public Overrides Function GetLocalizedString(ByVal id As BarString) As String

        Return DescripcionCadena(id + 40000)

    End Function

End Class
