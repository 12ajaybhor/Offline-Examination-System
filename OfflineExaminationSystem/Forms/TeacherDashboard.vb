Imports OfflineExaminationSystem.Modules

Public Class TeacherDashboard

    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & LoginForm.CurrentUserName
        LoadExams()
        LoadQuestionsGrid()
        LoadResults()
        LoadAnalytics()
    End Sub

    ' --- QUESTION MANAGEMENT ---
    Private Sub LoadExams()
        Dim dt As DataTable = DatabaseHelper.ExecuteQuery("SELECT * FROM Exams")
        ' Populate ComboBox for Questions tab
        cmbExamSelect.DataSource = dt
        cmbExamSelect.DisplayMember = "Title"
        cmbExamSelect.ValueMember = "ExamID"
    End Sub

    Private Sub btnAddQuestion_Click(sender As Object, e As EventArgs) Handles btnAddQuestion.Click
        If cmbExamSelect.SelectedValue Is Nothing Then
            MessageBox.Show("Please select an Exam first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim examID As Integer = Convert.ToInt32(cmbExamSelect.SelectedValue)
        Dim qText As String = txtQuestion.Text.Trim()
        Dim optA As String = txtOptA.Text.Trim()
        Dim optB As String = txtOptB.Text.Trim()
        Dim optC As String = txtOptC.Text.Trim()
        Dim optD As String = txtOptD.Text.Trim()
        Dim correct As String = If(cmbCorrectOpt.SelectedItem IsNot Nothing, cmbCorrectOpt.SelectedItem.ToString(), "")

        If String.IsNullOrEmpty(qText) OrElse String.IsNullOrEmpty(optA) OrElse String.IsNullOrEmpty(optB) OrElse String.IsNullOrEmpty(correct) Then
             MessageBox.Show("Please fill at least Question, Option A, Option B and Correct Option.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
             Return
        End If

        Dim query As String = "INSERT INTO Questions (ExamID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption) VALUES (@EID, @QT, @A, @B, @C, @D, @Cor)"
        Dim params As New Dictionary(Of String, Object)
        params.Add("@EID", examID)
        params.Add("@QT", qText)
        params.Add("@A", optA)
        params.Add("@B", optB)
        params.Add("@C", optC)
        params.Add("@D", optD)
        params.Add("@Cor", correct)

        Dim rows As Integer = DatabaseHelper.ExecuteNonQueryParams(query, params)
        If rows > 0 Then
            MessageBox.Show("Question Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuestion.Clear()
            txtOptA.Clear()
            txtOptB.Clear()
            txtOptC.Clear()
            txtOptD.Clear()
            cmbCorrectOpt.SelectedIndex = -1
            LoadQuestionsGrid()
        End If
    End Sub

    Private Sub cmbExamSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExamSelect.SelectedIndexChanged
        LoadQuestionsGrid()
    End Sub

    Private Sub LoadQuestionsGrid()
        If cmbExamSelect.SelectedValue IsNot Nothing AndAlso IsNumeric(cmbExamSelect.SelectedValue) Then
             Dim dt As DataTable = DatabaseHelper.ExecuteQueryParams("SELECT QuestionID, QuestionText, CorrectOption FROM Questions WHERE ExamID = @EID", 
                                                                    New Dictionary(Of String, Object) From {{"@EID", cmbExamSelect.SelectedValue}})
             dgvQuestions.DataSource = dt
        End If
    End Sub

     ' --- RESULTS VIEW ---
    Private Sub LoadResults()
        Dim query As String = "SELECT r.ResultID, u.FullName, ex.Title, r.Score, r.TotalMarks, r.TakenAt FROM Results r JOIN Users u ON r.UserID = u.UserID JOIN Exams ex ON r.ExamID = ex.ExamID ORDER BY r.TakenAt DESC"
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
