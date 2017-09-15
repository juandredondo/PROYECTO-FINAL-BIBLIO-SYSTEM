Public Class buscar_lector


    Private Sub buscar_lector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.lectores' Puede moverla o quitarla según sea necesario.
        Me.LectoresTableAdapter.Fill(Me.Biblio_SystemDataSet.lectores)
    

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        Try

            My.Forms.Prestamos.TextBoxCod_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).cod_lector
            My.Forms.Prestamos.TextBoxnom_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).nom_lector
            My.Forms.Prestamos.TextBoxapellido_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).apellido
            My.Forms.Prestamos.TextBoxtipo_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).tipo_lector
            My.Forms.Prestamos.TextBoxgrado.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).Grado
            My.Forms.Prestamos.TextBoxcurso.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).Curso
            My.Forms.Prestamos.ButtonIr_lector.Enabled = False
        Catch ex As Exception
            My.Forms.Prestamos.TextBoxgrado.Text = ""
            My.Forms.Prestamos.TextBoxcurso.Text = ""
            My.Forms.Prestamos.ButtonIr_lector.Enabled = False

            If My.Forms.Prestamos.TextBoxCod_lector.Text = "" And My.Forms.Prestamos.TextBoxnom_lector.Text = "" And My.Forms.Prestamos.TextBoxcurso.Text = "" And My.Forms.Prestamos.TextBoxgrado.Text = "" And My.Forms.Prestamos.TextBoxtipo_lector.Text = "" Then
                My.Forms.Prestamos.ButtonIr_lector.Enabled = True

            End If
        End Try

        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        LectoresTableAdapter.FillBybucar_lector(Biblio_SystemDataSet.lectores, "%" & TextBox1.Text & "%")
    End Sub

 
End Class