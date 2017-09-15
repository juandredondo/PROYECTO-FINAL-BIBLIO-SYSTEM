Public Class lista_de_lectores

    Private Sub lista_de_lectores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.lectores' Puede moverla o quitarla según sea necesario.
        Me.LectoresTableAdapter.Fill(Me.Biblio_SystemDataSet.lectores)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.LectoresTableAdapter.FillBymao(Biblio_SystemDataSet.lectores, "%" & TextBox1.Text & "%")
    End Sub
End Class