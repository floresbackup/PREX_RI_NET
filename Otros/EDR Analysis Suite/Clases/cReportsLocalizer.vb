Imports DevExpress.XtraReports.Localization

Public Class cReportsLocalizer

    Inherits ReportLocalizer
    ' overriding the GetLocalizedString method
    Public Overrides Function GetLocalizedString(ByVal id As ReportStringId) As String

        Return DescripcionCadena(id + 90000)

    End Function

End Class
