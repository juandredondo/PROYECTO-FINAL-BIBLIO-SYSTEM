Public Class converciondefecha
    Shared Function transformar_fecha(ByVal a As String)
        Dim y As String = Microsoft.VisualBasic.Right(a, 4)
        Dim m As String = Mid(a, 4, 2)
        Dim d As String = Microsoft.VisualBasic.Left(a, 2)
        Dim fech As String = y + "-" + m + "-" + d
        Return fech
    End Function
End Class
