
Imports System
Imports System.Text
Imports System.Collections
Imports System.DirectoryServices

Public Class cAutenticacionLDAP

    Public Function ValidateActiveDirectoryLogin(ByVal Domain As String, ByVal Username As String, ByVal Password As String) As Boolean
        Dim Success As Boolean = False
        Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://" & Domain, Username, Password)
        Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
        Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
        Try
            Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
            Success = Not (Results Is Nothing)
        Catch
            Success = False
        End Try

        'Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
        'Success = Not (Results Is Nothing)
        Return Success
    End Function

End Class
