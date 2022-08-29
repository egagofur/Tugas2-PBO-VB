Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = Val((2 * TextBox1.Text) + Val(4 * TextBox2.Text) + Val(4 * TextBox3.Text)) / 10
        If TextBox4.Text > 95 Then
            TextBox5.Text = "A"
        ElseIf TextBox4.Text > 85 Then
            TextBox5.Text = "B"
        ElseIf TextBox4.Text > 80 Then
            TextBox5.Text = "C"
        ElseIf TextBox4.Text > 70 Then
            TextBox5.Text = "D"
        ElseIf TextBox4.Text <= 69 Then
            TextBox5.Text = "E"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class