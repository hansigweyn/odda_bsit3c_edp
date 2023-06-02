Public Class Login
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim mainForm As New MainMenu()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub

End Class
