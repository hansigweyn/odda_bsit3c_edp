Public Class PlanetsForm
    Private Sub PlanetsBackButton_Click(sender As Object, e As EventArgs) Handles PlanetsBackButton.Click
        Me.Close()
        Dim mainMenuForm As New MainMenu()
        mainMenuForm.Show()
    End Sub
End Class
