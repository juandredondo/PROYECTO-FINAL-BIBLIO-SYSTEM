Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException

Public Class Prestamos
    ' Public J As Integer
    Public contar As Integer = 0
    Dim cuentalibrosprest As Integer = 0
    Dim bandera2 As Boolean
    'Dim control As Boolean
    ' Dim resta As Integer
    Dim total_libros As Integer



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbuscar_lector.Click
        My.Forms.buscar_lector.ShowDialog()
        ' ButtonIr_lector.Enabled = False
    End Sub

    'load
    Private Sub Prestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.detalle_prestamo' Puede moverla o quitarla según sea necesario.
        '¡' Me.Detalle_prestamoTableAdapter.Fill(Me.Biblio_SystemDataSet.detalle_prestamo)
        'TODO: esta línea de código carga datos en la tabla 'Biblio_SystemDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
        'Me.PrestamosTableAdapter.Fill(Me.Biblio_SystemDataSet.Prestamos)
        'para el numero auto incrementable
        Me.Fecha_devolucionDateTimePicker.MinDate = Me.Fecha_devolucionDateTimePicker.Value
        Dim con As Integer
        Me.Contar_max1TableAdapter.numero_total(Me.Biblio_SystemDataSet.contar_max1)
        con = Me.Biblio_SystemDataSet.contar_max1(Me.Contar_max1BindingSource.Position).Column1
        If con = 0 Then
            Me.Cod_prestamoLabel1.Text = 1
        Else
            Me.Contar_max1TableAdapter.Fillmax1(Me.Biblio_SystemDataSet.contar_max1)
            con = Me.Biblio_SystemDataSet.contar_max1(Me.Contar_max1BindingSource.Position).Column1
            con += 1
            Me.Cod_prestamoLabel1.Text = con.ToString
        End If
    End Sub

    'boton buscar libro
    Private Sub Buttonbusc_libro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonbusc_libro.Click
        My.Forms.Buscar_libro.ShowDialog()
    End Sub

    'boton cerrar

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cancelar.Click
        Me.Close()
    End Sub

    'button irlector
    Private Sub ButtonIr_lector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIr_lector.Click

        If TextBoxCod_lector.Text = Nothing Then
            MsgBox("No ha ingresado un codigo de lector", MsgBoxStyle.Exclamation, "Validacion")
        Else
            Dim con As Decimal
            con = Decimal.Parse(Me.TextBoxCod_lector.Text)
            If Me.LectoresTableAdapter.FillBycodigo_lector(Me.Biblio_SystemDataSet.lectores, con) Then
                Try

                    TextBoxnom_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).nom_lector
                    TextBoxapellido_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).apellido
                    TextBoxtipo_lector.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).tipo_lector
                    TextBoxgrado.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).Grado
                    TextBoxcurso.Text = Biblio_SystemDataSet.lectores(LectoresBindingSource.Position).Curso
                    ButtonIr_lector.Enabled = False
                    TextBoxCod_lector.Enabled = False


                Catch ex As Exception
                    TextBoxgrado.Text = ""
                    TextBoxcurso.Text = ""
                    ButtonIr_lector.Enabled = False
                End Try
            Else
                If MsgBox("Este lector no se encuentra registrado, ¿Desea registrarlo? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Forms.ingresar_lectores.textBoxid_lector.Text = Me.TextBoxCod_lector.Text
                    My.Forms.ingresar_lectores.ShowDialog()


                Else
                    TextBoxapellido_lector.Text = ""
                    TextBoxCod_lector.Text = ""
                    TextBoxcurso.Text = ""
                    TextBoxgrado.Text = ""
                    TextBoxnom_lector.Text = ""
                    TextBoxtipo_lector.Text = ""
                End If
            End If
        End If

    End Sub

    Private Sub TextBoxCod_lector_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCod_lector.TextChanged
        If TextBoxCod_lector.Text = Nothing Then
            ButtonIr_lector.Enabled = True
            TextBoxapellido_lector.Text = ""
            TextBoxcurso.Text = ""
            TextBoxgrado.Text = ""
            TextBoxnom_lector.Text = ""
            TextBoxtipo_lector.Text = ""
        End If

    End Sub

    Private Sub TextBoxtipo_lector_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxtipo_lector.TextChanged
        If TextBoxtipo_lector.Text = "propfesor " Or TextBoxtipo_lector.Text = "coordinador " Or TextBoxtipo_lector.Text = "  Rector" Or TextBoxtipo_lector.Text = "Particular" Or TextBoxtipo_lector.Text = "Secretaria" Then
            TextBoxcurso.Text = ""
            TextBoxgrado.Text = ""
        End If
    End Sub


    Private Sub TextBoxCod_lector_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCod_lector.KeyPress
        If Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se aceptan numeros", MsgBoxStyle.Exclamation, "VALIDACIÓN")
        End If
    End Sub

    'para llennar el datagrid  

    Private Sub eliminarbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarbutton.Click
        Dim num As Integer
        Dim num1 As Integer

        num1 = Me.DataGridView1.Rows.Count
        If num1 = 0 Then
            eliminarbutton.Enabled = False
            Buttonmodifi_cantidad.Enabled = False
            label_total.Text = 0
            contar = 0
        Else            'remueve la fila seleccionada


            num = Me.DataGridView1.CurrentRow.Cells(3).Value
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            contar = contar - 1

            num = DataGridView1.RowCount
            cuentalibrosprest = 0
            For I As Integer = 0 To num - 1
                cuentalibrosprest = cuentalibrosprest + CInt(DataGridView1.Rows(I).Cells(3).Value)
            Next
            Me.label_total.Text = cuentalibrosprest.ToString
            num1 = Me.DataGridView1.Rows.Count
            If num1 = 0 Then
                eliminarbutton.Enabled = False
                Buttonmodifi_cantidad.Enabled = False
                label_total.Text = 0
                contar = 0
            End If




        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.fecha_pretamo.Text = DateTime.Now.ToString
    End Sub


    Private Sub TextBoxcan_todal_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxcan_todal_total.TextChanged
        TextBoxcan_todal_total.Text = NumericUpDown1.Value
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

        TextBoxcan_todal_total.Text = NumericUpDown1.Value
    End Sub

    Private Sub Buttonmodifi_cantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonmodifi_cantidad.Click
        If MsgBox("¿Está seguro que desea modificar la cantidad a prestar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                ' se declara las variables
                Dim MiDato1, MiDato2, MIdato3, Midato4 As String

                'se le asignan las posiciones
                MiDato1 = DataGridView1.CurrentRow.Cells("cod_del_Libro").EditedFormattedValue.ToString
                MiDato2 = DataGridView1.CurrentRow.Cells("Nombre_Libro").EditedFormattedValue.ToString
                MIdato3 = DataGridView1.CurrentRow.Cells("ejemplares").EditedFormattedValue.ToString
                Midato4 = DataGridView1.CurrentRow.Cells("Cantidad").EditedFormattedValue.ToString

                'asignamos los valores a cada uno de los textbox
                My.Forms.midificar_cantidad.nombre_libro_textbox.Text = MiDato2
                My.Forms.midificar_cantidad.codigo_libro_textbox.Text = MiDato1
                My.Forms.midificar_cantidad.NumericUpDown_cantidad.Text = Midato4
                My.Forms.midificar_cantidad.TextBox_ejemplares.Text = MIdato3

                'se llama al formulario midificar cantidad
                My.Forms.midificar_cantidad.ShowDialog()

                'remplazamos los valores
                Me.DataGridView1.CurrentRow.Cells(3).Value = My.Forms.midificar_cantidad.NumericUpDown_cantidad.Value

                'contamos los registros
                Dim num As Integer
                num = DataGridView1.RowCount
                cuentalibrosprest = 0
                For I As Integer = 0 To num - 1
                    cuentalibrosprest = cuentalibrosprest + CInt(DataGridView1.Rows(I).Cells(3).Value)
                Next

                Me.label_total.Text = cuentalibrosprest.ToString


            Catch ex As Exception
                MsgBox("No hay libros para modificar", MsgBoxStyle.Exclamation, "informacion")
                Buttonmodifi_cantidad.Enabled = False
                eliminarbutton.Enabled = False
            End Try
        Else
        End If
    End Sub


    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click
        If cuentalibrosprest = 0 Or Me.TextBoxCod_lector.Text = Nothing Or Me.Cod_prestamoLabel1.Text = Nothing Then
            MsgBox("Debe llenar la información correspondiente, es posible que falten campos por llenar", MsgBoxStyle.Exclamation, "Biblio-System")
        Else

            Dim conexion As New SqlConnection("Data Source=BIBLIOTECA3\INSTANCIABD;Initial Catalog=Biblio-System;User ID=sa;Password=programacion")
            Dim cmd As New SqlCommand("dbo.GuardarPrestamo", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim parametro As New SqlParameter
            parametro.ParameterName = "CodPrestamo"
            parametro.DbType = DbType.Int32
            parametro.Direction = ParameterDirection.Input
            parametro.Value = CInt(Me.Cod_prestamoLabel1.Text)
            cmd.Parameters.Add(parametro)

            parametro = New SqlParameter
            parametro.ParameterName = "Codlector"
            parametro.DbType = DbType.Int32
            parametro.Direction = ParameterDirection.Input
            parametro.Value = CInt(Me.TextBoxCod_lector.Text)
            cmd.Parameters.Add(parametro)

            parametro = New SqlParameter
            parametro.ParameterName = "fechaprest"
            parametro.DbType = DbType.DateTime
            parametro.Direction = ParameterDirection.Input
            parametro.Value = Me.fecha_pretamo.Text
            cmd.Parameters.Add(parametro)

            parametro = New SqlParameter
            parametro.ParameterName = "fechadev"
            parametro.DbType = DbType.DateTime
            parametro.Direction = ParameterDirection.Input
            parametro.Value = Me.Fecha_devolucionDateTimePicker.Text
            cmd.Parameters.Add(parametro)

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            'declaramos u  objeto de la clase guardar prestamos
            Dim prestar As New BibliotecaClase.guardarprestamos

            'se recorrec el datagrid para llenar los campos en la tabla detalle de prestamos           
            For I As Integer = 0 To Val(Me.DataGridView1.RowCount) - 1
                prestar.ejecutar_sql("INSERT INTO detalle_prestamo(cod_prestamo,cod_libro,cant_total)Values (" + CInt(Cod_prestamoLabel1.Text).ToString + "," + CInt(Me.DataGridView1.Rows(I).Cells(0).Value).ToString + "," + CInt(Me.DataGridView1.Rows(I).Cells(3).Value).ToString + ") ")
                prestar.ejecutar_sql(" UPDATE libros set num_copias=num_copias-" + CInt(Me.DataGridView1.Rows(I).Cells(3).Value).ToString + " where cod_libro=" + CInt(Me.DataGridView1.Rows(I).Cells(0).Value).ToString + "")

            Next

            MsgBox("El prestamo se realizó satisfactoriamente", MsgBoxStyle.Information, "Informacion")
            Me.Close()
        End If
    End Sub



    Private Sub Buttonprestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonprestar.Click
        Dim can1 As Integer
        Dim can2 As Integer
        can1 = CInt(TextBoxCant_libro_pres.Text)
        can2 = CInt(TextBoxcan_todal_total.Text)

        If can2 > can1 Then
            MsgBox("La cantidad a prestar no puede ser mayor al numero de ejemplares", MsgBoxStyle.Exclamation, "Informacion")
            Try
                NumericUpDown1.Value = TextBoxCant_libro_pres.Text

            Catch ex As Exception
                TextBoxcod_libro.Text = ""
                TextBoxnomb_libro.Text = ""
                TextBoxeditorial.Text = ""
                TextBoxCant_libro_pres.Text = ""
                TextBoxcan_todal_total.Text = ""
                TextBoxnomb_area.Text = ""
                Buttonprestar.Enabled = False
            End Try

        Else

            'para que no se repita un libro
            Dim l As Integer = 0
            Dim cont As Integer = 0
            Dim bandera As Integer = 0
            cont = Me.DataGridView1.RowCount
            While (l < cont And bandera = 0)
                If Me.DataGridView1.Rows(l).Cells(0).Value = TextBoxcod_libro.Text Then
                    bandera2 = True
                    bandera = 1
                End If
                l = l + 1
            End While

            If bandera2 = True Then
                MsgBox("El libro que desea ingresar ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Informacion")

                TextBoxcod_libro.Text = ""
                TextBoxnomb_libro.Text = ""
                TextBoxeditorial.Text = ""
                TextBoxCant_libro_pres.Text = ""
                TextBoxcan_todal_total.Text = ""
                TextBoxnomb_area.Text = ""
                NumericUpDown1.Value = 1
                NumericUpDown1.Enabled = False
                Buttonprestar.Enabled = False
                bandera2 = False

            Else


                'para llenar el datagridview
                Me.DataGridView1.Rows.Add()
                Me.DataGridView1.Rows(contar).Cells(0).Value = TextBoxcod_libro.Text
                Me.DataGridView1.Rows(contar).Cells(1).Value = TextBoxnomb_libro.Text
                Me.DataGridView1.Rows(contar).Cells(3).Value = TextBoxcan_todal_total.Text
                Me.DataGridView1.Rows(contar).Cells(2).Value = TextBoxCant_libro_pres.Text
                Dim num As Integer
                num = DataGridView1.RowCount
                cuentalibrosprest = 0

                For I As Integer = 0 To num - 1
                    cuentalibrosprest = cuentalibrosprest + CInt(DataGridView1.Rows(I).Cells(3).Value)
                Next
                Me.label_total.Text = cuentalibrosprest.ToString
                contar += 1

                bandera2 = False
                TextBoxcod_libro.Text = ""
                TextBoxnomb_libro.Text = ""
                TextBoxeditorial.Text = ""
                TextBoxCant_libro_pres.Text = ""
                TextBoxcan_todal_total.Text = ""
                TextBoxnomb_area.Text = ""
                NumericUpDown1.Value = 1
                NumericUpDown1.Enabled = False
                Buttonprestar.Enabled = False
                eliminarbutton.Enabled = True
                Buttonmodifi_cantidad.Enabled = True





            End If
        End If

    End Sub

    Private Sub Fecha_devolucionDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha_devolucionDateTimePicker.ValueChanged

    End Sub
End Class