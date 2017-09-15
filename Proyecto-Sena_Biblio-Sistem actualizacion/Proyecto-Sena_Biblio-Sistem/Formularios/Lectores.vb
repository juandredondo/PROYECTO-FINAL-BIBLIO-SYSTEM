Public Class Lectores

    Public Sub HabilitaBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal editar As Boolean, ByVal eliminar As Boolean, ByVal Cancelar As Boolean)
        Me.nuevo.Enabled = nuevo
        Me.Guardar.Enabled = guardar
        Me.Editar.Enabled = editar
        Me.Eliminar.Enabled = eliminar
        Me.Cancelar.Enabled = Cancelar
    End Sub

    Private Sub Lectores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.lectores' Puede moverla o quitarla según sea necesario.
        Me.LectoresTableAdapter.Fill(Me.Biblio_SystemDataSet.lectores)

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub textBoxid_lector_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxid_lector.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se aceptan numeros", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub


    Private Sub texboxnombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles texboxnombre.KeyPress
        'no acepta , numeros ,simbolos solamente numeros 
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



    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxtelef.KeyPress
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

    Private Sub ComboBoxtipo_lect_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxtipo_lect.KeyPress
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

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        LectoresBindingSource.EndEdit()
        LectoresBindingSource.AddNew()

        HabilitaBotones(False, True, False, False, True)
        textBoxid_lector.Enabled = True
        texboxnombre.Enabled = True
        TextBoxapellido.Enabled = True
        TextBoxdireccion.Enabled = True
        TextBoxtelef.Enabled = True
        ComboBoxsexo.Enabled = True
        ComboBoxtipo_lect.Enabled = True
        ComboBoxcurso.Enabled = True
        ComboBoxgrado.Enabled = True
       
        Label6.Visible = True

        BindingNavigator1.Enabled = False

        Editar.Enabled = False
        Eliminar.Enabled = False
        Guardar.Enabled = True

    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

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
                LectoresBindingSource.CancelEdit()


                HabilitaBotones(True, False, True, True, True)
                textBoxid_lector.Enabled = False
                texboxnombre.Enabled = False
                TextBoxapellido.Enabled = False
                TextBoxdireccion.Enabled = False
                TextBoxtelef.Enabled = False
                ComboBoxtipo_lect.Enabled = False
                ComboBoxsexo.Enabled = False
                ComboBoxgrado.Enabled = False
                ComboBoxcurso.Enabled = False
                BindingNavigator1.Enabled = True

            Catch ex As Exception
                MsgBox(" Ha ocurrido algun eror cuando se intenó guardar los datos,verifique los datos e intente nuevamente", MsgBoxStyle.Critical, "Error")

                LectoresBindingSource.CancelEdit()
                'textBoxid_lector.Text = ""
                ' texboxnombre.Text = ""
                'T'extBoxapellido.Text = ""
                ' TextBoxdireccion.Text = ""
                'TextBoxtelef.Text = ""
                'ComboBoxtipo_lect.Text = ""
                'ComboBoxsexo.Text = ""
                'ComboBoxgrado.Text = ""
                'ComboBoxcurso.Text = ""

            End Try

        End If
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        textBoxid_lector.Enabled = True
        texboxnombre.Enabled = True
        TextBoxapellido.Enabled = True
        TextBoxdireccion.Enabled = True
        TextBoxtelef.Enabled = False
        ComboBoxsexo.Enabled = True
        ComboBoxtipo_lect.Enabled = True
        HabilitaBotones(False, True, False, True, True)
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If (MsgBox("Eliminar registro?", MsgBoxStyle.YesNo, "eliminar") = MsgBoxResult.Yes) Then
            Try
                'se elimina el registro
                LectoresBindingSource.RemoveCurrent()
                'se actualiza a el dataset
                Me.Validate()
                Me.LectoresBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.Biblio_SystemDataSet)
                MsgBox("Lector Eliminado exitosamente!", MsgBoxStyle.Information, "Biblio-System")


            Catch ex As Exception
                Me.LectoresBindingSource.CancelEdit()

                MsgBox(" información relacionada en el sistema, por lo tanto no se puede eliminar", MsgBoxStyle.Critical)

            End Try


        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        LectoresBindingSource.CancelEdit()
        textBoxid_lector.Enabled = False
        texboxnombre.Enabled = False
        TextBoxapellido.Enabled = False
        TextBoxdireccion.Enabled = False
        TextBoxtelef.Enabled = False
        ComboBoxsexo.Enabled = False
        ComboBoxtipo_lect.Enabled = False
        ComboBoxcurso.Enabled = False
        ComboBoxgrado.Enabled = False
        BindingNavigator1.Enabled = True

        HabilitaBotones(True, False, True, True, True)

    End Sub
End Class