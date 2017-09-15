Public Class Buscar_libro



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Buscar_libroTableAdapter.Fillbuscar_libro(Biblio_SystemDataSet.buscar_libro, "%" & TextBox1.Text & "%")
    End Sub


    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

    
            My.Forms.Prestamos.TextBoxcod_libro.Text = Biblio_SystemDataSet.buscar_libro(BuscarlibroBindingSource.Position).cod_libro
            My.Forms.Prestamos.TextBoxeditorial.Text = Biblio_SystemDataSet.buscar_libro(BuscarlibroBindingSource.Position).editorial
            My.Forms.Prestamos.TextBoxnomb_area.Text = Biblio_SystemDataSet.buscar_libro(BuscarlibroBindingSource.Position).nomb_area
            My.Forms.Prestamos.TextBoxnomb_libro.Text = Biblio_SystemDataSet.buscar_libro(BuscarlibroBindingSource.Position).nom_libro
            My.Forms.Prestamos.TextBoxCant_libro_pres.Text = Biblio_SystemDataSet.buscar_libro(BuscarlibroBindingSource.Position).num_copias
            Me.Close()
            My.Forms.Prestamos.NumericUpDown1.Enabled = True
            My.Forms.Prestamos.Buttonprestar.Enabled = True

   
    End Sub

    Private Sub Buscar_libro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Buscar_libroTableAdapter.FillBy(Biblio_SystemDataSet.buscar_libro)
    End Sub
End Class