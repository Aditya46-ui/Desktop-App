Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Ensure the form can capture key presses
        lblStopwatch.Text = "00:00:00" ' Initialize the label text
        timerStopwatch.Interval = 1000 ' Set the timer interval to 1 second
        timerStopwatch.Stop() ' Ensure the timer is stopped initially
    End Sub

    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timerStopwatch.Stop()
            btnStartStopwatch.Text = "Resume Stopwatch"
        Else
            stopwatch.Start()
            timerStopwatch.Start()
            btnStartStopwatch.Text = "Pause Stopwatch"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SubmitForm()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStartStopwatch.PerformClick()
        End If
    End Sub

    Private Sub timerStopwatch_Tick(sender As Object, e As EventArgs) Handles timerStopwatch.Tick
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub SubmitForm()
        Dim submission = New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = stopwatch.Elapsed.TotalSeconds
        }

        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                Else
                    MessageBox.Show("Error: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        stopwatch.Reset()
        lblStopwatch.Text = "00:00:00"
        timerStopwatch.Stop()
        btnStartStopwatch.Text = "Start Stopwatch"
        Me.Close()
    End Sub


End Class



