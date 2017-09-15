Partial Class Biblio_SystemDataSet
    Partial Class DEVOLUCIONES_LIBROSDataTable

        Private Sub DEVOLUCIONES_LIBROSDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cod_prestamoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class buscar_libroDataTable

        Private Sub buscar_libroDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cod_libroColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

 

    Partial Class numero_totalDataTable

    End Class

End Class
