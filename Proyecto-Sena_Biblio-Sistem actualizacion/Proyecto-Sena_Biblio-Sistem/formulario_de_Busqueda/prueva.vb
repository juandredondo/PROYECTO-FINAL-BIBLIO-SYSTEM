Public Class prueva



    Private Sub prueva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.devoluciones' Puede moverla o quitarla según sea necesario.
        Me.DevolucionesTableAdapter.Fill(Me.Biblio_SystemDataSet.devoluciones)
      
    End Sub
End Class