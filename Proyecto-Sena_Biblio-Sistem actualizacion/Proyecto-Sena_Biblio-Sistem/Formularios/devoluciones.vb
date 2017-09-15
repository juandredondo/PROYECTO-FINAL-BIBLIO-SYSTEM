
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException

Public Class devoluciones
    Dim cuentalibrosprest As Integer = 0


    Private Sub buscarn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarn.Click
        
        My.Forms.devolrver_libro.ShowDialog()
        Try
            If Me.Codig_pTextBox1.Text <> Nothing Then

                Me.PrestamoXIDTableAdapter.FillprestamoXId(Me.Biblio_SystemDataSet.PrestamoXID, CType(Me.Codig_pTextBox1.Text, Decimal))




                Dim num As Integer
                num = DataGridView1.RowCount
                cuentalibrosprest = 0
                For I As Integer = 0 To num - 1
                    cuentalibrosprest = cuentalibrosprest + CInt(DataGridView1.Rows(I).Cells(1).Value)
                Next
                Me.label_total.Text = cuentalibrosprest.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try



    End Sub

    Private Sub devoluciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cont As Integer = 0
        Me.Contar_max_devolTableAdapter.FillBynumero_dev(Me.Biblio_SystemDataSet.contar_max_devol)
        cont = Me.Biblio_SystemDataSet.contar_max_devol(Me.Contar_max_devolBindingSource.Position).Column1
        If cont = 0 Then
            Me.IdDevol.Text = 1
        Else
            Me.Contar_max_devolTableAdapter.Fillmaxima_devol(Me.Biblio_SystemDataSet.contar_max_devol)
            cont = Me.Biblio_SystemDataSet.contar_max_devol(Me.Contar_max_devolBindingSource.Position).Column1
            cont = cont + 1
            Me.IdDevol.Text = cont.ToString
        End If
    End Sub

    Private Sub boton_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cancelar.Click
        Me.Close()
    End Sub

    Private Sub boton_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_guardar.Click

        If cuentalibrosprest = 0 Or Me.Codig_pTextBox1.Text = Nothing Then
            MsgBox("Debe llenar la información correspondiente", MsgBoxStyle.Exclamation, "Biblio-System")
        Else
            Dim conexion As New SqlConnection("Data Source=BIBLIOTECA3\INSTANCIABD;Initial Catalog=Biblio-System;User ID=sa;Password=programacion")
            Dim cmd As New SqlCommand("dbo.GuardarDev", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim parametro As New SqlParameter
            parametro.ParameterName = "CodDev"
            parametro.DbType = DbType.Int32
            parametro.Direction = ParameterDirection.Input
            parametro.Value = CInt(Me.IdDevol.Text)
            cmd.Parameters.Add(parametro)

            parametro = New SqlParameter
            parametro.ParameterName = "CodPrestamo"
            parametro.DbType = DbType.Int32
            parametro.Direction = ParameterDirection.Input
            parametro.Value = CInt(Me.Codig_pTextBox1.Text)
            cmd.Parameters.Add(parametro)


            parametro = New SqlParameter
            parametro.ParameterName = "fechadev"
            parametro.DbType = DbType.DateTime
            parametro.Direction = ParameterDirection.Input
            parametro.Value = Me.DateTimePicker1Devol.Text
            cmd.Parameters.Add(parametro)

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Dim devolver As New BibliotecaClase.guardarprestamos
            devolver.ejecutar_sql("Update Prestamos set Prestamos.Dev = 'SI' where cod_prestamo=" + CInt(Codig_pTextBox1.Text).ToString + "")
            For I As Integer = 0 To Val(Me.DataGridView1.RowCount) - 1
                devolver.ejecutar_sql(" UPDATE libros set num_copias=num_copias+" + CInt(Me.DataGridView1.Rows(I).Cells(1).Value).ToString + " where cod_libro=" + CInt(Me.DataGridView1.Rows(I).Cells(0).Value).ToString + "")
            Next

        End If

        MsgBox("Devolucion realizada con exito", MsgBoxStyle.Information, "Informacion")

        Me.Close()

    End Sub


End Class