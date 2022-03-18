Public Class Form1
    Dim Func As New Funciones
    Public X2, x As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        X2 = Func.Factorial(Val(TextBox1.Text))
        Label2.Text = X2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        X2 = Func.Elevar(Val(TextBox1.Text), Val(TextBox2.Text))
        Label2.Text = X2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        X2 = Func.F(Val(TextBox1.Text))
        Label2.Text = X2
    End Sub

End Class
