Public Class Form1
    Dim Form2 As Form2
    Public Balance As Int32
    Public WinningMultiplier As Int32
    Public MaxNumber As Int32

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "---"
        Balance = 100
        TextBox1.Text = Balance
        MaxNumber = 10
        WinningMultiplier = 8

        TextBox2.Text = 1
        TextBox3.Text = 1
    End Sub

    Private Sub CheatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheatToolStripMenuItem.Click
        Form2 = New Form2()
        Form2.ParentForm = Me
        Form2.Show()

        Form2.TextBox1.Text = Balance
        Form2.TextBox2.Text = MaxNumber
        Form2.TextBox3.Text = WinningMultiplier
    End Sub

    Private Sub PlayGame() Handles Button1.Click
        Dim Number As Int32

        Dim RandomGenerator As Random
        RandomGenerator = New Random()

        If TextBox2.Text - 1 < Balance Then
            Number = RandomGenerator.Next(1, MaxNumber)
            Label3.Text = Number

            If Label3.Text = TextBox3.Text Then
                Balance = Balance + (TextBox2.Text * WinningMultiplier)
            Else
                Balance = Balance - TextBox2.Text
            End If

            TextBox1.Text = Balance
        Else
            TextBox1.Text = Balance
            MessageBox.Show("You can't afford this. Pick a smaller amount to bet.", "Alert!")
        End If

        If Balance = 0 Then
            MessageBox.Show("You lose!", "Game Over!")
            Balance = 100
            TextBox1.Text = Balance
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub
End Class
