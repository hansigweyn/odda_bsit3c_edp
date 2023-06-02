Public Class MainMenu
    Private Sub CharactersButton_Click(sender As Object, e As EventArgs) Handles CharactersButton.Click
        Dim charactersForm As New CharactersForm()
        charactersForm.Show()
        Me.Hide()
    End Sub

    Private Sub PlanetsButton_Click(sender As Object, e As EventArgs) Handles PlanetsButton.Click
        Dim planetsForm As New PlanetsForm()
        planetsForm.Show()
        Me.Hide()
    End Sub

    Private Sub StarshipsButton_Click(sender As Object, e As EventArgs) Handles StarshipsButton.Click
        Dim starshipsForm As New StarshipsForm()
        starshipsForm.Show()
        Me.Hide()
    End Sub

    Private Sub TypeButton_Click(sender As Object, e As EventArgs) Handles TypesButton.Click
        Dim typesForm As New TypesForm()
        typesForm.Show()
        Me.Hide()
    End Sub

    Private Sub SpeciesButton_Click(sender As Object, e As EventArgs) Handles SpeciesButton.Click
        Dim speciesForm As New SpeciesForm()
        speciesForm.Show()
        Me.Hide()
    End Sub

    Private Sub FilmsAndTvShowsButton_Click(sender As Object, e As EventArgs) Handles FilmsAndTvShowsButton.Click
        Dim filmsAndTvShowsForm As New FilmsAndTvShowsForm()
        filmsAndTvShowsForm.Show()
        Me.Hide()
    End Sub
End Class
