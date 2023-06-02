Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports OfficeOpenXml.FormulaParsing
Imports OfficeOpenXml

Public Class CharactersForm
    Dim connectionString As String = "Server=localhost;Database=star_wars;Uid=root;Pwd=mandalorian1901;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim name As String = NameTextBox1.Text
        Dim sex As String = SexComboBox.Text
        Dim birthYear As String = BirthYearTextBox3.Text
        Dim homeworld As String = HomeworldTextBox4.Text
        Dim species As String = SpeciesTextBox5.Text
        Dim type As String = TypeTextBox6.Text
        Dim starships As String = StarshipsTextBox7.Text
        Dim filmsAndTvShows As String = FilmsAndTvShowsTextBox8.Text
        connection.Open()
        Dim query As String = "INSERT INTO characters (name, sex, birth_year, homeworld, species, type, starships, films_tv_show) VALUES (@name, @sex, @birthYear, @homeworld, @species, @type, @starships, @filmsAndTvShows)"
        Using command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@sex", sex)
            command.Parameters.AddWithValue("@birthYear", birthYear)
            command.Parameters.AddWithValue("@homeworld", homeworld)
            command.Parameters.AddWithValue("@species", species)
            command.Parameters.AddWithValue("@type", type)
            command.Parameters.AddWithValue("@starships", starships)
            command.Parameters.AddWithValue("@filmsAndTvShows", filmsAndTvShows)
            command.ExecuteNonQuery()
        End Using


        connection.Close()

        Dim newRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add())
        newRow.Cells("NameColumn").Value = name
        newRow.Cells("SexColumn").Value = sex
        newRow.Cells("BirthYearColumn").Value = birthYear
        newRow.Cells("HomeworldColumn").Value = homeworld
        newRow.Cells("SpeciesColumn").Value = species
        newRow.Cells("TypeColumn").Value = type
        newRow.Cells("StarshipsColumn").Value = starships
        newRow.Cells("FilmsAndTvShowsColumn").Value = filmsAndTvShows

        MessageBox.Show("New character added successfully!")

            ClearFields()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim name As String = selectedRow.Cells("NameColumn").Value.ToString()

            connection.Open()

            Dim query As String = "DELETE FROM characters WHERE Name = @name"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@name", name)
                command.ExecuteNonQuery()
            End Using

            connection.Close()

            DataGridView1.Rows.Remove(selectedRow)

            MessageBox.Show("Character deleted successfully!")
        Else
            MessageBox.Show("Please select a character to delete.")
        End If
    End Sub

    Private Sub CharactersBackButton_Click(sender As Object, e As EventArgs) Handles CharactersBackButton.Click
        Me.Close()
        Dim mainMenuForm As New MainMenu()
        mainMenuForm.Show()
    End Sub

    Private Sub ClearFields()
        NameTextBox1.Text = ""
        SexComboBox.Text = ""
        BirthYearTextBox3.Text = ""
        HomeworldTextBox4.Text = ""
        SpeciesTextBox5.Text = ""
        TypeTextBox6.Text = ""
        StarshipsTextBox7.Text = ""
        FilmsAndTvShowsTextBox8.Text = ""
    End Sub

    Private Sub CharactersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        connection.Open()

        Dim query As String = "SELECT * FROM characters"
        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim dataSet As New DataSet()
        adapter.Fill(dataSet, "characters")
        DataGridView1.DataSource = dataSet.Tables("characters")

        connection.Close()
    End Sub

    Private Sub ExportToExcelButton_Click(sender As Object, e As EventArgs) Handles ExportToExcelButton.Click
        If DataGridView1.Rows.Count > 0 Then
            ' Create a new Excel application
            Dim excelApp As New Excel.Application()
            excelApp.Visible = True

            ' Create a new workbook and sheet
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
            Dim sheet As Excel.Worksheet = workbook.Sheets(1)

            ' Set the column headers
            For i As Integer = 0 To DataGridView1.Columns.Count - 1
                sheet.Cells(1, i + 1) = DataGridView1.Columns(i).HeaderText
            Next

            ' Populate the data rows
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    sheet.Cells(i + 2, j + 1) = DataGridView1.Rows(i).Cells(j).Value.ToString()
                Next
            Next

            ' Save the workbook
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files|*.xlsx"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                workbook.SaveAs(saveFileDialog.FileName)
                MessageBox.Show("Data exported to Excel successfully!")
            End If

            ' Close Excel application
            excelApp.Quit()
            releaseObject(sheet)
            releaseObject(workbook)
            releaseObject(excelApp)
        Else
            MessageBox.Show("No data to export.")
        End If
    End Sub


    Private Sub releaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class

