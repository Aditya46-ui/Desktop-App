<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblName = New Label()
        txtName = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblPhoneNum = New Label()
        txtPhone = New TextBox()
        lblGithubLink = New Label()
        txtGithubLink = New TextBox()
        btnStartStopwatch = New Button()
        lblStopwatch = New Label()
        btnSubmit = New Button()
        timerStopwatch = New Timer(components)
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(30, 38)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(166, 35)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 27)
        txtName.TabIndex = 1
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(30, 88)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(166, 88)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 27)
        txtEmail.TabIndex = 3
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Location = New Point(30, 138)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(86, 20)
        lblPhoneNum.TabIndex = 4
        lblPhoneNum.Text = "Phone Num"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(166, 138)
        txtPhone.Margin = New Padding(3, 4, 3, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 27)
        txtPhone.TabIndex = 5
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(-1, 195)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(151, 20)
        lblGithubLink.TabIndex = 6
        lblGithubLink.Text = "Github Link For Task 2"
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(166, 192)
        txtGithubLink.Margin = New Padding(3, 4, 3, 4)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(200, 27)
        txtGithubLink.TabIndex = 7
        ' 
        ' btnStartStopwatch
        ' 
        btnStartStopwatch.BackColor = Color.LightYellow
        btnStartStopwatch.Location = New Point(30, 250)
        btnStartStopwatch.Margin = New Padding(3, 4, 3, 4)
        btnStartStopwatch.Name = "btnStartStopwatch"
        btnStartStopwatch.Size = New Size(252, 38)
        btnStartStopwatch.TabIndex = 8
        btnStartStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnStartStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.BackColor = SystemColors.ControlLight
        lblStopwatch.BorderStyle = BorderStyle.FixedSingle
        lblStopwatch.Location = New Point(310, 250)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(100, 37)
        lblStopwatch.TabIndex = 9
        lblStopwatch.Text = "00:00:00"
        lblStopwatch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.Location = New Point(46, 309)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(320, 62)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' timerStopwatch
        ' 
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 438)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatch)
        Controls.Add(btnStartStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(lblGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(lblPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateSubmissionForm"
        Text = "Naga Aditya, Slidely Task 2 - Create New Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnStartStopwatch As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents timerStopwatch As Timer
End Class

