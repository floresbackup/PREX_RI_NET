Imports DevExpress.XtraGrid.Localization

Public Class cGridLocalizer

    Inherits GridLocalizer
    ' overriding the GetLocalizedString method
    Public Overrides Function GetLocalizedString(ByVal id As GridStringId) As String
        
        Return DescripcionCadena(id + 50000)

    End Function

End Class
