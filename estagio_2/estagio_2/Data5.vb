Public Class Data5
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Disciplina3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.save17 = TextBox1.Text
        My.Settings.save18 = TextBox2.Text
        My.Settings.save19 = RichTextBox1.Text
        My.Settings.save20 = RichTextBox2.Text
        My.Settings.Save()

    End Sub

    Private Sub Data5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.save17
        TextBox2.Text = My.Settings.save18
        RichTextBox1.Text = My.Settings.save19
        RichTextBox2.Text = My.Settings.save20
    End Sub
End Class