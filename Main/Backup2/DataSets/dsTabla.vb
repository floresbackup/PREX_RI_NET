Partial Class dsTabla
   Partial Class DisenoDataTable

      Private Sub DisenoDataTable_DisenoRowChanging(ByVal sender As System.Object, ByVal e As DisenoRowChangeEvent) Handles Me.DisenoRowChanging

      End Sub

      Private Sub DisenoDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
         If (e.Column.ColumnName = Me.NombreColumn.ColumnName) Then
            'Agregar código de usuario aquí
         End If

      End Sub

   End Class

End Class
