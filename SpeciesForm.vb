Public Class SpeciesForm
    Private Sub SpeciesBackButton_Click(sender As Object, e As EventArgs) Handles SpeciesBackButton.Click
        Me.Close()
        Dim mainMenuForm As New MainMenu()
        mainMenuForm.Show()
    End Sub
End Class
