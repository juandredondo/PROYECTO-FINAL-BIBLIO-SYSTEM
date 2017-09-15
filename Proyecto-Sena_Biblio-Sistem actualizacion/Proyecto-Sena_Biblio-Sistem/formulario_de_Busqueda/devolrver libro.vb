Public Class devolrver_libro
   

    Private Sub devolrver_libro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.DEVOLUCIONES_LIBROS' Puede moverla o quitarla según sea necesario.
        Me.DEVOLUCIONES_LIBROSTableAdapter.FillDEVOLUCIONES(Me.Biblio_SystemDataSet.DEVOLUCIONES_LIBROS)
        

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
        Try
            DEVOLUCIONES_LIBROSTableAdapter.FillByCONSULTADEVOLVER(Biblio_SystemDataSet.DEVOLUCIONES_LIBROS, "%" & TextBox1.Text & "%")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try


    End Sub

    Private Sub Devolver_liDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Devolver_liDataGridView.CellClick

        My.Forms.devoluciones.Codig_pTextBox1.Text = Me.Devolver_liDataGridView.Rows(e.RowIndex).Cells(0).Value()
        My.Forms.devoluciones.fecha_pTextBox2.Text = Me.Devolver_liDataGridView.Rows(e.RowIndex).Cells(1).Value()
        My.Forms.devoluciones.cod_lectTextBox4.Text = Me.Devolver_liDataGridView.Rows(e.RowIndex).Cells(2).Value()
        My.Forms.devoluciones.nomb_lecTextBox5.Text = Me.Devolver_liDataGridView.Rows(e.RowIndex).Cells(3).Value()
        My.Forms.devoluciones.Apellido_leTextBox6.Text = Me.Devolver_liDataGridView.Rows(e.RowIndex).Cells(4).Value()
        My.Forms.devoluciones.fechdev.Text = Me.Devolver_liDataGridView.Rows(e.RowIndex).Cells(5).Value()


        Me.Close()
    End Sub
End Class