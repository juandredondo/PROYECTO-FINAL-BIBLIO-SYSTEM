
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException


Public Class ClaseIngreso
    Public CadenaConexion As String

    Sub New(ByVal Cadena As String)
        CadenaConexion = Cadena
    End Sub
    Public Function VerificarAcceso(ByVal User As String, ByVal Pass As String) As String
        Dim Conexion As New SqlConnection(CadenaConexion)
        Dim Comando As New SqlCommand("Select dbo.validar_usuario('" & User & "','" & Pass & "')", Conexion)
        Dim Resultado As String
        Try
            Conexion.Open()
            Resultado = Comando.ExecuteScalar().ToString
        Catch ex As Exception
            Resultado = "Usuario o Password incorrecto"
        Finally
            Conexion.Close()
        End Try
        Return Resultado
    End Function

End Class
