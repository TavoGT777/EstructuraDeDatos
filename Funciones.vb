Imports System.Data
Imports System.Windows.Forms
Imports System.IO
Public Class Funciones
    Dim resultado1 As Integer
    Public Function F(x As Integer) As Integer
        If (x > 100) Then
            Return (x - 10)
        Else
            Return (F(F(x + 11)))
        End If
    End Function
    Public Function Factorial(n As Integer) As Integer
        resultado1 = 1
        For i = 1 To n Step 1
            resultado1 = resultado1 * i
        Next i
        Return resultado1
    End Function
    Public Function Elevar(x As Integer, y As Integer) As Integer
        resultado1 = x ^ y
        Return resultado1
    End Function
End Class
