Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim gaji = Val(TextBox3.Text)
        Dim hari = Val(TextBox5.Text)
        Dim tunjangan = hari * 10000
        Dim potongan = gaji * 25 / 1000
        Dim hasil

        If (ya.SelectedIndex = 0) Then
            hasil = gaji * 5 / 100
            Dim total = (gaji + hasil + tunjangan) - potongan
            TextBox4.Text = total
        Else
            Dim total = (gaji + tunjangan) - potongan
            TextBox4.Text = total
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
