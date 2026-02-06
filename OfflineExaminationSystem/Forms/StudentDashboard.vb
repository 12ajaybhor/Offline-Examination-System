Imports OfflineExaminationSystem.Modules

Public Class StudentDashboard

    Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & LoginForm.CurrentUserName
        LoadAvailableExams()
        LoadHistory()
    End Sub

    Private Sub LoadAvailableExams()
        ' Show exams that are active
        Dim query As String = "SELECT ExamID, Title, DurationMinutes, PassingScore FROM Exams WHERE IsActive = 1"
        Dim dt As DataTable = DatabaseHelper.ExecuteQuery(query)
        dgvAvailableExams.DataSource = dt
    End Sub

    Private Sub LoadHistory()
        Dim query As String = "SELECT ex.Title, r.Score, r.TotalMarks, r.Percentage, r.TakenAt FROM Results r JOIN Exams ex ON r.ExamID = ex.ExamID WHERE r.UserID = " & LoginForm.CurrentUserID
        Dim dt As DataTable = DatabaseHelper.ExecuteQuery(query)
        dgvHistory.DataSource = dt
    End Sub

    Private Sub btnStartExam_Click(sender As Object, e As EventArgs) Handles btnStartExam.Click
        If dgvAvailableExams.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an exam to start.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim row As DataGridViewRow = dgvAvailableExams.SelectedRows(0)
        Dim examId As Integer = Convert.ToInt32(row.Cells("ExamID").Value)
        Dim examTitle As String = row.Cells("Title").Value.ToString()
        Dim duration As Integer = Convert.ToInt32(row.Cells("DurationMinutes").Value)

        ' Check if already taken? (Optional logic, skipping for simplicity or allowing retakes)
        
        Dim examForm As New ExamForm(examId, examTitle, duration)
        examForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub
End Class
