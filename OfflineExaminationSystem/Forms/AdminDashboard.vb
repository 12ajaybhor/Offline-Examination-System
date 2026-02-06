Imports OfflineExaminationSystem.Modules
Imports System.IO

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & LoginForm.CurrentUserName
        LoadExams()
        LoadQuestionsGrid()
        LoadResults()
    End Sub

    ' --- EXAM MANAGEMENT ---
    Private Sub LoadExams()
        Dim dt As DataTable = DatabaseHelper.ExecuteQuery("SELECT * FROM Exams")
        dgvExams.DataSource = dt
        
        ' Also populate ComboBox for Questions tab
        cmbExamSelect.DataSource = dt
        cmbExamSelect.DisplayMember = "Title"
        cmbExamSelect.ValueMember = "ExamID"
    End Sub

    Private Sub btnAddExam_Click(sender As Object, e As EventArgs) Handles btnAddExam.Click
        Dim title As String = txtExamTitle.Text.Trim()
        Dim durationStr As String = txtDuration.Text.Trim()
        Dim duration As Integer

        If String.IsNullOrEmpty(title) OrElse String.IsNullOrEmpty(durationStr) Then
            MessageBox.Show("Please enter Title and Duration.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(durationStr, duration) Then
            MessageBox.Show("Duration must be a number (minutes).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO Exams (Title, DurationMinutes, PassingScore, CreatedBy) VALUES (@Title, @Dur, 0, @User)"
        Dim params As New Dictionary(Of String, Object)
        params.Add("@Title", title)
        params.Add("@Dur", duration)
        params.Add("@User", LoginForm.CurrentUserID)

        Dim rows As Integer = DatabaseHelper.ExecuteNonQueryParams(query, params)
        If rows > 0 Then
            MessageBox.Show("Exam Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtExamTitle.Clear()
            txtDuration.Clear()
            LoadExams()
        End If
    End Sub

    ' --- QUESTION MANAGEMENT ---
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

    ' --- STUDENT MANAGEMENT ---
    Private _currentImageBytes As Byte() = Nothing

    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If opf.ShowDialog() = DialogResult.OK Then
            picStudentPreview.Image = Image.FromFile(opf.FileName)
            _currentImageBytes = File.ReadAllBytes(opf.FileName)
        End If
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim name As String = txtStudentName.Text.Trim()
        Dim user As String = txtStudentUser.Text.Trim()
        Dim pass As String = txtStudentPass.Text.Trim()

        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(pass) Then
            MessageBox.Show("Please enter all details.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO Users (Username, PasswordHash, FullName, Role, ProfileImage) VALUES (@User, @Pass, @Name, 'Student', @Img)"
        Dim params As New Dictionary(Of String, Object)
        params.Add("@User", user)
        params.Add("@Pass", pass)
        params.Add("@Name", name)
        
        If _currentImageBytes IsNot Nothing Then
            params.Add("@Img", _currentImageBytes)
        Else
            ' Handle DBNULL for blob if needed, usually we can pass DBNull.Value
            params.Add("@Img", DBNull.Value)
        End If

        Dim rows As Integer = DatabaseHelper.ExecuteNonQueryParams(query, params)
        If rows > 0 Then
            MessageBox.Show("Student Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtStudentName.Clear()
            txtStudentUser.Clear()
            txtStudentPass.Clear()
            picStudentPreview.Image = Nothing
            _currentImageBytes = Nothing
        End If
    End Sub

     ' --- RESULTS VIEW ---
    Private Sub LoadResults()
        Dim query As String = "SELECT r.ResultID, u.FullName, ex.Title, r.Score, r.TotalMarks, r.TakenAt FROM Results r JOIN Users u ON r.UserID = u.UserID JOIN Exams ex ON r.ExamID = ex.ExamID ORDER BY r.TakenAt DESC"
        Dim dt As DataTable = DatabaseHelper.ExecuteQuery(query)
        dgvResults.DataSource = dt
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub
End Class
