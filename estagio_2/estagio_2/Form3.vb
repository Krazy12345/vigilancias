Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.save1 = TextBox1.Text
        My.Settings.save2 = TextBox2.Text
        My.Settings.save3 = RichTextBox1.Text
        My.Settings.save4 = RichTextBox2.Text


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.save1
        TextBox2.Text = My.Settings.save2
        RichTextBox1.Text = My.Settings.save3
        RichTextBox2.Text = My.Settings.save4

    End Sub
End Class