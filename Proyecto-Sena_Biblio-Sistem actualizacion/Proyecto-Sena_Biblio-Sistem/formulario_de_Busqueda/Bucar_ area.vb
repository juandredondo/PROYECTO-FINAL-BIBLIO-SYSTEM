Public Class Bucar__area
    Dim bandera As Boolean
    Private Sub Bucar__area_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.areas' Puede moverla o quitarla según sea necesario.
        'Me.AreasTableAdapter.Fill(Me.Biblio_SystemDataSet.areas)
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.areas' Puede moverla o quitarla según sea necesario.
 
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        AreasTableAdapter.FillBybuscar_area(Biblio_SystemDataSet.areas, "%" & TextBox1.Text & "%")
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        My.Forms.Libros.cod_area_TextBox.Text = Biblio_SystemDataSet.areas(AreasBindingSource.Position).Codigo_
        My.Forms.Libros.nom_area_TextBox2.Text = Biblio_SystemDataSet.areas(AreasBindingSource.Position).Nombre_
        Me.Close()
    End Sub
End Class