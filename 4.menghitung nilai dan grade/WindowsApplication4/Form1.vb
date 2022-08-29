Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nilaiakhir = (Val(UH.Text) / 10) + (Val(NT.Text) * 25 / 100) + (Val(UTS.Text) * 3 / 10) + (Val(UAS.Text) * 3 / 10) + (Val(KH.Text) * 1 / 20)
        If nilaiakhir > 90 Then
            GR.Text = "A"
        ElseIf nilaiakhir > 80 Then
            GR.Text = "B"
        ElseIf nilaiakhir > 70 Then
            GR.Text = "C"
        Else
            GR.Text = "D"
        End If
    End Sub
End Class