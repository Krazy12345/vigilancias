Public Class Data4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Disciplina2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.save13 = TextBox1.Text
        My.Settings.save14 = TextBox2.Text
        My.Settings.save15 = RichTextBox1.Text
        My.Settings.save16 = RichTextBox2.Text
        My.Settings.Save()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.save13
        TextBox2.Text = My.Settings.save14
        RichTextBox1.Text = My.Settings.save15
        RichTextBox2.Text = My.Settings.save16
    End Sub


End Class
