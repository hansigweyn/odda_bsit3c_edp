Public Class TypesForm
    Private Sub TypesBackButton_Click(sender As Object, e As EventArgs) Handles TypesBackButton.Click
        Me.Close()
        Dim mainMenuForm As New MainMenu()
        mainMenuForm.Show()
    End Sub
End Class
