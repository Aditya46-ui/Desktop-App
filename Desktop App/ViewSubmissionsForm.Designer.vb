<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHubLink = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        lblStopwatchTime = New Label()
        btnSearch = New Button()
        txtSearchEmail = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(364, 55)
        lblName.Name = "lblName"
        lblName.Size = New Size(0, 20)
        lblName.TabIndex = 0
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(364, 94)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(0, 20)
        lblEmail.TabIndex = 1
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(364, 136)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(0, 20)
        lblPhone.TabIndex = 2
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(364, 176)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(0, 20)
        lblGitHubLink.TabIndex = 3
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(136, 259)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(203, 29)
        btnPrevious.TabIndex = 4
        btnPrevious.Text = "Previous (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(364, 259)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(203, 29)
        btnNext.TabIndex = 5
        btnNext.Text = "Next (CTRL+N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(136, 294)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(203, 29)
        btnEdit.TabIndex = 6
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(364, 294)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(203, 29)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(364, 221)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(0, 20)
        lblStopwatchTime.TabIndex = 8
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(510, 371)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(128, 29)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearchEmail
        ' 
        txtSearchEmail.Location = New Point(253, 371)
        txtSearchEmail.Name = "txtSearchEmail"
        txtSearchEmail.Size = New Size(251, 27)
        txtSearchEmail.TabIndex = 10
        txtSearchEmail.Text = "Enter Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(253, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 14
        Label4.Text = "GitHub Link"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(271, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 13
        Label3.Text = "Phone"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(271, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 12
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(271, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 11
        Label1.Text = "Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(233, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 20)
        Label5.TabIndex = 15
        Label5.Text = "Stopwatch Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(136, 375)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 20)
        Label6.TabIndex = 16
        Label6.Text = "Search by Email"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSearchEmail)
        Controls.Add(btnSearch)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class



