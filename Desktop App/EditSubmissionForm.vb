Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class EditSubmissionForm
    Private index As Integer
    Private submission As Submission

    Public Sub New(submission As Submission, index As Integer)
        InitializeComponent()
        Me.submission = submission
        Me.index = index
        LoadSubmission()
    End Sub

    Private Sub LoadSubmission()
        txtName.Text = submission.name
        txtEmail.Text = submission.email
        txtPhone.Text = submission.phone
        txtGitHubLink.Text = submission.github_link
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        submission.name = txtName.Text
        submission.email = txtEmail.Text
        submission.phone = txtPhone.Text
        submission.github_link = txtGitHubLink.Text

        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response = client.PutAsync($"http://localhost:3000/edit?index={index}", content).Result
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated.")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Error: " & response.ReasonPhrase)
            End If
        End Using
    End Sub
End Class



