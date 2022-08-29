Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonproses.Click
        TextBox6.Text = Val(0.5 * TextBox1.Text * TextBox2.Text)
        TextBox7.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
    End Sub
End Class