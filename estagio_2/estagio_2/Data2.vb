Public Class Data2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Disciplina1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.save5 = TextBox1.Text
        My.Settings.save6 = TextBox2.Text
        My.Settings.save7 = RichTextBox1.Text
        My.Settings.save8 = RichTextBox2.Text
        My.Settings.Save()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.save5
        TextBox2.Text = My.Settings.save6
        RichTextBox1.Text = My.Settings.save7
        RichTextBox2.Text = My.Settings.save8



    End Sub
End Class