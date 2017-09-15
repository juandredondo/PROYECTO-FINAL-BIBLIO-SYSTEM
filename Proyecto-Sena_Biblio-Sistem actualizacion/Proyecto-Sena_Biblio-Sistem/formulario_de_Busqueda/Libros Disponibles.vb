Public Class Libros_Disponibles

    Private Sub Libros_Disponibles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.Libros' Puede moverla o quitarla según sea necesario.
        Me.LibrosTableAdapter.Fill(Me.Biblio_SystemDataSet.Libros)

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        LibrosTableAdapter.FillByJUAN(Biblio_SystemDataSet.Libros, "%" & TextBox1.Text & "%")

    End Sub
End Class