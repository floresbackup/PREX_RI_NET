Imports DevExpress.XtraPivotGrid.Localization

Public Class cPivotGridLocalizer

    Inherits PivotGridLocalizer
    ' overriding the GetLocalizedString method
    Public Overrides Function GetLocalizedString(ByVal id As PivotGridStringId) As String

        Return DescripcionCadena(id + 60000, "XtraPivotGrid")

    End Function

End Class
