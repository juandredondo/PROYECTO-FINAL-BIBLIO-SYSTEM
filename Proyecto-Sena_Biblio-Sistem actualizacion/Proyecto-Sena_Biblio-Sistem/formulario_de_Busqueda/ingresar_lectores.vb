Public Class ingresar_lectores

    Private Sub butonguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butonguardar.Click

        If textBoxid_lector.Text = Nothing And texboxnombre.Text = Nothing And TextBoxapellido.Text = Nothing And ComboBoxtipo_lect.Text = Nothing And ComboBoxsexo.Text = Nothing Then

            MsgBox("Usted no ha ingresado ninguna informacion", MsgBoxStyle.Exclamation, "Informacion")

        ElseIf textBoxid_lector.Text = Nothing Then

            MsgBox("El Campo Identificacion del Lector es Obligatorio", MsgBoxStyle.Exclamation, "Informacion")

        ElseIf texboxnombre.Text = Nothing Then
            MsgBox("El Campo Nombre del lector es Obligatorio", MsgBoxStyle.Exclamation, "Informacion")

        ElseIf TextBoxapellido.Text = Nothing Then
            MsgBox("El Campo Apellidos del lector es Obligatorio", MsgBoxStyle.Exclamation, "Informacion")

        ElseIf ComboBoxsexo.Text = Nothing Then
            MsgBox("El Campo sexo Obligatorio", MsgBoxStyle.Exclamation, "Informacion")

        ElseIf ComboBoxtipo_lect.Text = Nothing Then
            MsgBox("El Campo Tipo de lector es Obligatorio", MsgBoxStyle.Exclamation, "Informacion")
        Else

            Try
                Me.Validate()
                Me.LectoresBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Biblio_SystemDataSet)
                MsgBox("Se han guardado sus datos exitosamente", MsgBoxStyle.Information, "Informacion")

                My.Forms.Prestamos.TextBoxCod_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).cod_lector
                My.Forms.Prestamos.TextBoxnom_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).nom_lector
                My.Forms.Prestamos.TextBoxapellido_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).apellido
                My.Forms.Prestamos.TextBoxtipo_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).tipo_lector
                My.Forms.Prestamos.TextBoxgrado.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).Grado
                My.Forms.Prestamos.TextBoxcurso.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).Curso
                LectoresBindingSource.EndEdit()
                My.Forms.Prestamos.ButtonIr_lector.Enabled = False
                Me.Close()
            Catch ex As Exception
                My.Forms.Prestamos.TextBoxgrado.Text = ""
                My.Forms.Prestamos.TextBoxcurso.Text = ""
                My.Forms.Prestamos.ButtonIr_lector.Enabled = False
                Me.Close()
                LectoresBindingSource.EndEdit()
                Me.Close()
            End Try

          
        End If


    End Sub
    Private Sub ingresar_lectores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.lectores' Puede moverla o quitarla según sea necesario.

        LectoresBindingSource.EndEdit()
        LectoresBindingSource.AddNew()
        textBoxid_lector.Text = My.Forms.Prestamos.TextBoxCod_lector.Text
    End Sub

    Private Sub Buttoncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncancelar.Click
        Me.Close()
        LectoresBindingSource.CancelEdit()
        My.Forms.Prestamos.TextBoxCod_lector.Text = ""
  
    End Sub

    Private Sub ComboBoxtipo_lect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxtipo_lect.SelectedIndexChanged
        If ComboBoxtipo_lect.Text = "Estudiante" Then
            ComboBoxgrado.Enabled = True
            ComboBoxcurso.Enabled = True
        Else
            ComboBoxgrado.Enabled = False
            ComboBoxcurso.Enabled = False
            ComboBoxgrado.Text = ""
            ComboBoxcurso.Text = ""
        End If
    End Sub

    Private Sub textBoxid_lector_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxid_lector.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se aceptan numeros", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub

    Private Sub texboxnombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles texboxnombre.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub

    Private Sub TextBoxapellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxapellido.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se aceptan numeros", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub

    Private Sub ComboBoxsexo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxsexo.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("error", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub

    Private Sub ComboBoxgrado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxgrado.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("error", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub

    Private Sub ComboBoxcurso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxcurso.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("error", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub

  
    Private Sub ComboBoxtipo_lect_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxtipo_lect.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("error", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub
End Class