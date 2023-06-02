Public Class FilmsAndTvShowsForm
    Private Sub FilmsAndTvShowsBackButton_Click(sender As Object, e As EventArgs) Handles FilmsAndTvShowsBackButton.Click
        Me.Close()
        Dim mainMenuForm As New MainMenu()
        mainMenuForm.Show()
    End Sub
End Class
