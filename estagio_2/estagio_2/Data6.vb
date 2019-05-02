Public Class Data6
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Disciplina3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.save21 = TextBox1.Text
        My.Settings.save22 = TextBox2.Text
        My.Settings.save23 = RichTextBox1.Text
        My.Settings.save24 = RichTextBox2.Text
        My.Settings.Save()

    End Sub

    Private Sub Data6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.save21
        TextBox2.Text = My.Settings.save22
        RichTextBox1.Text = My.Settings.save23
        RichTextBox2.Text = My.Settings.save24
    End Sub
End Class