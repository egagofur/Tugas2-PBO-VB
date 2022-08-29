Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Combo1.Items.Add("Menikah")
        Combo1.Items.Add("Bujang")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Combo1.Text = "Menikah" Then
            TextBox5.Text = Val((TextBox4.Text * 10) / 100)
        ElseIf Combo1.Text = "Bujang" Then
            TextBox5.Text = Val((TextBox4.Text * 0) / 100)
        End If

        If TextBox3.Text Then
            TextBox6.Text = Val((TextBox4.Text * 5 / 100) * TextBox3.Text)

            TextBox7.Text = Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        End If
    End Sub
End Class
