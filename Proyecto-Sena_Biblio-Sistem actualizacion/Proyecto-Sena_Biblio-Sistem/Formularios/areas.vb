Public Class areas
    Public Sub HabilitaBotones(ByVal nuevo As Boolean, ByVal guardar As Boolean, ByVal editar As Boolean, ByVal eliminar As Boolean, ByVal Cancelar As Boolean)
        Me.nuevo.Enabled = nuevo
        Me.Guardar.Enabled = guardar
        Me.Editar.Enabled = editar
        Me.Eliminar.Enabled = eliminar
        Me.Cancelar.Enabled = Cancelar
    End Sub
   

    Private Sub areas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.Biblio_SystemDataSet.areas)
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.Biblio_SystemDataSet.areas)
      
    End Sub

    Private Sub AreasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Me.Validate()
            Me.AreasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Biblio_SystemDataSet)

        Catch ex As Exception
            MsgBox("Error:" + " Este lector ya esta registrado", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        AreasBindingSource.EndEdit()
        AreasBindingSource.AddNew()
        Codigo_TextBox.Enabled = True
        Nombre_TextBox.Enabled = True
        HabilitaBotones(False, True, False, False, True)

    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        Nombre_TextBox.Enabled = True
        Codigo_TextBox.Enabled = True
        HabilitaBotones(False, True, False, True, True)
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

        Try
            Me.Validate()
            Me.AreasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Biblio_SystemDataSet)

            MsgBox("Se han guardado sus datos exitosamente", MsgBoxStyle.Information, "Informacion")
            Codigo_TextBox.Enabled = False
            Nombre_TextBox.Enabled = False


            HabilitaBotones(True, False, True, True, True)
        Catch ex As Exception
            MsgBox("Ha ocurrido algun eror cuando se intenó guardar los datos,verifique los datos e intente nuevamente", MsgBoxStyle.Exclamation, "informacion")
        End Try
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If (MsgBox("Eliminar registro?", MsgBoxStyle.YesNo, "eliminar") = MsgBoxResult.Yes) Then
            Try
                'se elimina el registro
                AreasBindingSource.RemoveCurrent()
                'se actualiza a el dataset
                Me.Validate()
                Me.AreasBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.Biblio_SystemDataSet)
                MsgBox("Lector Eliminado exitosamente!", MsgBoxStyle.Information, "Biblio-System")


            Catch ex As Exception
                Me.AreasBindingSource.CancelEdit()
                MsgBox(" información relacionada en el sistema, por lo tanto no se puede eliminar", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        AreasBindingSource.CancelEdit()
        Codigo_TextBox.Enabled = False
        Nombre_TextBox.Enabled = False
        HabilitaBotones(True, False, True, True, True)
    End Sub
End Class
