Public Class buscar_area_para__reporte

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        My.Forms.reporte.cod_area_TextBox.Text = Biblio_SystemDataSet.areas(AreasBindingSource.Position).Codigo_
        My.Forms.reporte.nom_area_TextBox2.Text = Biblio_SystemDataSet.areas(AreasBindingSource.Position).Nombre_
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        AreasTableAdapter.FillBybuscar_area(Biblio_SystemDataSet.areas, "%" & TextBox1.Text & "%")

    End Sub
End Class