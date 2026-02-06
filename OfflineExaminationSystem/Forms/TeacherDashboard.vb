Imports OfflineExaminationSystem.Modules

Public Class TeacherDashboard

    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & LoginForm.CurrentUserName
        LoadStudents()
        LoadResults()
        LoadAnalytics()
    End Sub

    ' --- STUDENT VIEW ---
    Private Sub LoadStudents()
        Dim query As String = "SELECT FullName, Username FROM Users WHERE Role = 'Student' ORDER BY FullName"
        Dim dt As DataTable = DatabaseHelper.ExecuteQuery(query)
        dgvStudents.DataSource = dt
    End Sub

    ' --- RESULTS VIEW ---
    Private Sub LoadResults()
        Dim query As String = "SELECT r.ResultID, u.FullName, ex.Title, r.Score, r.TotalMarks, r.TakenAt FROM Results r JOIN Users u ON r.UserID = u.UserID JOIN Exams ex ON r.ExamID = ex.ExamID WHERE u.Role = 'Student' ORDER BY r.TakenAt DESC"
        Dim dt As DataTable = DatabaseHelper.ExecuteQuery(query)
        dgvResults.DataSource = dt
    End Sub

    ' --- ANALYTICS ---
    Private Sub LoadAnalytics()
        Dim query As String = "SELECT ex.Title AS ExamName, COUNT(r.ResultID) AS TotalAttempts, AVG(r.Score) AS AverageScore, AVG(r.Percentage) AS AveragePercentage, MAX(r.Score) AS MaxScore, MIN(r.Score) AS MinScore FROM Results r JOIN Exams ex ON r.ExamID = ex.ExamID GROUP BY ex.Title, ex.ExamID"
        Dim dt As DataTable = DatabaseHelper.ExecuteQuery(query)
        dgvAnalytics.DataSource = dt
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub
End Class
