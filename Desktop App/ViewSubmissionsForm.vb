Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync("http://localhost:3000/read")
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                    If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                        DisplaySubmission(currentIndex)
                    Else
                        MessageBox.Show("No submissions found.")
                        ClearLabels()
                    End If
                Else
                    MessageBox.Show("Error loading submissions: " & response.ReasonPhrase)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(index)
            lblName.Text = submission.name
            lblEmail.Text = submission.email
            lblPhone.Text = submission.phone
            lblGitHubLink.Text = submission.github_link
            lblStopwatchTime.Text = submission.stopwatch_time
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub ClearLabels()
        lblName.Text = ""
        lblEmail.Text = ""
        lblPhone.Text = ""
        lblGitHubLink.Text = ""
        lblStopwatchTime.Text = ""
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            If currentIndex > 0 Then
                currentIndex -= 1
                DisplaySubmission(currentIndex)
            Else
                MessageBox.Show("You are already at the first submission.")
            End If
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            If currentIndex < submissions.Count - 1 Then
                currentIndex += 1
                DisplaySubmission(currentIndex)
            Else
                MessageBox.Show("You are already at the last submission.")
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim editForm As New EditSubmissionForm(submissions(currentIndex), currentIndex)
            If editForm.ShowDialog() = DialogResult.OK Then
                LoadSubmissions()
                DisplaySubmission(currentIndex)
            End If
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim result = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Using client As New HttpClient()
                        Dim response = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
                        If response.IsSuccessStatusCode Then
                            MessageBox.Show("Submission deleted.")
                            LoadSubmissions()
                            If currentIndex >= submissions.Count Then
                                currentIndex = submissions.Count - 1
                            End If
                            DisplaySubmission(currentIndex)
                        Else
                            MessageBox.Show("Error deleting submission: " & response.ReasonPhrase)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error deleting submission: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email = txtSearchEmail.Text
        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter an email to search.")
            Return
        End If

        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync($"http://localhost:3000/search?email={email}")
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                    If submissions.Count > 0 Then
                        currentIndex = 0
                        DisplaySubmission(currentIndex)
                    Else
                        MessageBox.Show("No submissions found for this email.")
                        ClearLabels()
                    End If
                Else
                    MessageBox.Show("Error searching submissions: " & response.ReasonPhrase)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
            e.SuppressKeyPress = True ' Suppress the key event
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
            e.SuppressKeyPress = True ' Suppress the key event
        End If
    End Sub
End Class















