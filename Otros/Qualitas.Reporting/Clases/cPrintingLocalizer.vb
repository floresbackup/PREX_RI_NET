Imports DevExpress.XtraPrinting.Localization

Public Class cPrintingLocalizer

    Inherits PreviewLocalizer
    ' overriding the GetLocalizedString method
    Public Overrides Function GetLocalizedString(ByVal id As PreviewStringId) As String

        Return DescripcionCadena(id + 80000, "XtraPrinting")

    End Function

End Class
