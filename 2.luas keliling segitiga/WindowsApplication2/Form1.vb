Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jari = Val(TextBox1.Text)
        Keliling.Text = (jari * 2) * 3.14
        Luas.Text = jari * jari * 3.14
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
