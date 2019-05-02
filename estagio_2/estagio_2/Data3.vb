Public Class Data3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.save9 = TextBox1.Text
        My.Settings.save10 = TextBox2.Text
        My.Settings.save11 = RichTextBox1.Text
        My.Settings.save12 = RichTextBox2.Text
        My.Settings.Save()


    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.save9
        TextBox2.Text = My.Settings.save10
        RichTextBox1.Text = My.Settings.save11
        RichTextBox2.Text = My.Settings.save12


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Disciplina2.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub
End Class