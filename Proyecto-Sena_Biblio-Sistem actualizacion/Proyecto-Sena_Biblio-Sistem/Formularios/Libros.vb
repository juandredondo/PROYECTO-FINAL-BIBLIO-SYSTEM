Public Class Libros
    Public Sub HabilitaBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal editar As Boolean, ByVal eliminar As Boolean, ByVal Cancelar As Boolean)
        Me.nuevo.Enabled = nuevo
        Me.Guardar.Enabled = guardar
        Me.Editar.Enabled = Editar
        Me.Eliminar.Enabled = Eliminar
        Me.Cancelar.Enabled = Cancelar
    End Sub

    Private Sub Libros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.Libros' Puede moverla o quitarla según sea necesario.
        Me.LibrosTableAdapter.Fill(Me.Biblio_SystemDataSet.Libros)
        'LibrosBindingSource.AddNew()
        Num_copiasNumericUpDown.Value = 1
        Fecha_IngresoDateTimePicker.Value = "20/03/2010 17:31"

    End Sub

    Private Sub Buttoncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Cod_libroTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cod_libroTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True

            MsgBox("Solo se aceptan numeros", MsgBoxStyle.Exclamation, "Validación")
        End If
    End Sub

    Private Sub Nom_libroTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nom_libroTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True

            MsgBox("Solo se aceptan letras", MsgBoxStyle.Exclamation, "Validación")

        End If

    End Sub

    Private Sub cod_areaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cod_area_TextBox.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            e.Handled = True

            MsgBox("Solo se aceptan numeros", MsgBoxStyle.Exclamation, "Validación")
        End If
    End Sub

    Private Sub EditorialComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EditorialComboBox.KeyPress
        If Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True

            MsgBox("Solo se aceptan letras", MsgBoxStyle.Exclamation, "Validación")

        End If
    End Sub

    Private Sub Num_copiasNumericUpDown_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Num_copiasNumericUpDown.KeyPress
        If Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se aceptan numeros", MsgBoxStyle.Exclamation, "Validación")

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Forms.Bucar__area.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim con As String
        con = (Me.cod_area_TextBox.Text)
        Me.AreasTableAdapter.FillBybuscar_area(Me.Biblio_SystemDataSet.areas, con)
        nom_area_TextBox2.Text = Biblio_SystemDataSet.areas(AreasBindingSource.Position).Nombre_

    End Sub


    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        LibrosBindingSource.EndEdit()
        LibrosBindingSource.AddNew()

        HabilitaBotones(False, True, False, False, True)
        Cod_libroTextBox.Enabled = True
        Nom_libroTextBox.Enabled = True
        EditorialComboBox.Enabled = True
        ubicacionTextBox.Enabled = True
        cod_area_TextBox.Enabled = False
        Num_copiasNumericUpDown.Enabled = True
        Fecha_IngresoDateTimePicker.Enabled = True
        Button2.Visible = True
        Label6.Visible = True
        nom_area_TextBox2.Visible = True
        BindingNavigator1.Enabled = False

        Editar.Enabled = False
        Eliminar.Enabled = False
        Guardar.Enabled = True

    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If Cod_libroTextBox.Text = Nothing Then
            MsgBox("El campo Codigo del libro es obligatorio", MsgBoxStyle.Exclamation, "Validacion")

        ElseIf Nom_libroTextBox.Text = Nothing Then
            MsgBox("El campo Nombre del libro es obligatorio", MsgBoxStyle.Exclamation, "Validacion")


        ElseIf EditorialComboBox.Text = Nothing Then
            MsgBox("El campo Editorial es obligatorio", MsgBoxStyle.Exclamation, "Validacion")

        ElseIf ubicacionTextBox.Text = Nothing Then
            MsgBox("El campo Ubicacion del libro es obligatorio", MsgBoxStyle.Exclamation, "Validacion")
        ElseIf cod_area_TextBox.Text = Nothing Then
            MsgBox("El campo Codigo del area es obligatorio", MsgBoxStyle.Exclamation, "Validacion")

        Else
            Try
                Me.Validate()
                Me.LibrosBindingSource.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Me.Biblio_SystemDataSet)

                MsgBox("Se han guardado sus datos exitosamente", MsgBoxStyle.Information, "Informacion")
            Catch ex As Exception
                MsgBox(" Ha ocurrido algun error cuando se intentó guardar los datos,verifique los datos e intente nuevamente", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        Cod_libroTextBox.Enabled = True
        Nom_libroTextBox.Enabled = True
        ubicacionTextBox.Enabled = True
        Num_copiasNumericUpDown.Enabled = True
        Eliminar.Enabled = False
        nuevo.Enabled = False
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        LibrosBindingSource.CancelEdit()
        Cod_libroTextBox.Enabled = False
        Nom_libroTextBox.Enabled = False
        EditorialComboBox.Enabled = False
        ubicacionTextBox.Enabled = False
        cod_area_TextBox.Enabled = False

        Num_copiasNumericUpDown.Enabled = False
        Fecha_IngresoDateTimePicker.Enabled = False
        HabilitaBotones(True, False, True, True, True)


        Button2.Visible = False
        Label6.Visible = False
        nom_area_TextBox2.Visible = False
        BindingNavigator1.Enabled = True

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If (MsgBox("Eliminar registro?", MsgBoxStyle.YesNo, "eliminar") = MsgBoxResult.Yes) Then
            Try
                'se elimina el registro
                LibrosBindingSource.RemoveCurrent()
                'se actualiza a el dataset
                Me.Validate()
                Me.LibrosBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.Biblio_SystemDataSet)

                MsgBox("Libro Eliminado exitosamente!", MsgBoxStyle.Information, "Biblio-System")
                nom_area_TextBox2.Text = ""

            Catch ex As Exception
                Me.LibrosBindingSource.CancelEdit()
                MsgBox(" información relacionada en el sistema, por lo tanto no se puede eliminar", MsgBoxStyle.Critical)

            End Try
        End If
    End Sub
End Class
