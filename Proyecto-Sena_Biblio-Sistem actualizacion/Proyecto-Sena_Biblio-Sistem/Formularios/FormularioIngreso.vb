Public Class FormularioIngreso


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Ingreso As New BibliotecaClase.ClaseIngreso("Data Source=ZEUS;Initial Catalog=Biblio-System;User ID=sa;Password=programacion")
        Dim Respuesta As String
        Respuesta = Ingreso.VerificarAcceso(TextBoxLogin.Text, TextBoxPassword.Text)
        MessageBox.Show(Respuesta)
        If Respuesta.Substring(0, 1) = "B" Then
            Visible = False
            MDIParent1.ShowDialog()
            Close()
        End If
        TextBoxLogin.Text = ""
        TextBoxPassword.Text = ""
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
