Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException


Public Class guardarprestamos

    Public Sub ejecutar_sql(ByVal s As String)
        Dim conexion As New SqlConnection("Data Source=BIBLIOTECA3\INSTANCIABD;Initial Catalog=Biblio-System;User ID=sa;Password=programacion")
        Dim cmd As New SqlCommand()

        cmd = conexion.CreateCommand
        cmd.Connection = conexion
        Try
            conexion.Open()
            cmd.CommandText = s
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
