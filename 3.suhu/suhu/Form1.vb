Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = Val(TextBox1.Text / 0.8) + Val(273.15)
    End Sub
End Class
