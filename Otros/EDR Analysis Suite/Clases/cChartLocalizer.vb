Imports DevExpress.XtraCharts.Localization

Public Class cChartLocalizer

    Inherits ChartLocalizer
    ' overriding the GetLocalizedString method
    Public Overrides Function GetLocalizedString(ByVal id As ChartStringId) As String

        Return DescripcionCadena(id + 70000)

    End Function

End Class
