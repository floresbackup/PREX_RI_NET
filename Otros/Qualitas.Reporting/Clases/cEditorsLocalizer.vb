Imports DevExpress.XtraEditors.Controls

Public Class cEditorsLocalizer

    Inherits Localizer
    ' overriding the GetLocalizedString method
    Public Overrides Function GetLocalizedString(ByVal id As StringId) As String

        Return DescripcionCadena(id + 30000, "XtraEditors")

    End Function

End Class
