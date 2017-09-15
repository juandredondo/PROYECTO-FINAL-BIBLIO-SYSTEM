Public Class midificar_cantidad

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Dim contar As Integer
    Private Sub Buttonaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonaceptar.Click
        Dim can1 As Integer
        Dim can2 As Integer
        can1 = CInt(TextBox_ejemplares.Text)
        can2 = CInt(NumericUpDown_cantidad.Text)

        If can2 > can1 Then
            MsgBox("La cantidad a prestar no puede ser mayor al numero de ejemplares", MsgBoxStyle.Exclamation, "Informacion")
            NumericUpDown_cantidad.Text = (TextBox_ejemplares.Text)
        Else
            ' My.Forms.Prestamos.DataGridView1.Rows(contar).Cells(3).Value = NumericUpDown_cantidad.Value
            Me.Close()
        End If
    End Sub
End Class