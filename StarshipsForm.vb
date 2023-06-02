Public Class StarshipsForm
    Private Sub StarshipsBackButton_Click(sender As Object, e As EventArgs) Handles StarshipsBackButton.Click
        Me.Close()
        Dim mainMenuForm As New MainMenu()
        mainMenuForm.Show()
    End Sub
End Class
