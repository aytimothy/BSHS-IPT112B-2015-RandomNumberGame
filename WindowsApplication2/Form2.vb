Public Class Form2
    Public ParentForm As Form1

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ParentForm.Balance = TextBox1.Text
        ParentForm.TextBox1.Text = ParentForm.Balance
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ParentForm.MaxNumber = TextBox2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ParentForm.WinningMultiplier = TextBox3.Text
    End Sub
End Class