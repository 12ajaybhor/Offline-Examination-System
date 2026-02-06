Imports OfflineExaminationSystem.Modules

Public Class ExamForm
    Private _examID As Integer
    Private _duration As Integer
    Private _questions As DataTable
    Private _currentQuestionIndex As Integer = 0
    Private _userAnswers As Dictionary(Of Integer, String) ' QuestionID -> SelectedOption (A/B/C/D)
    Private _timeLeft As TimeSpan

    Public Sub New(examId As Integer, title As String, durationMinutes As Integer)
        InitializeComponent()
        _examID = examId
        _duration = durationMinutes
        lblExamTitle.Text = title
        _userAnswers = New Dictionary(Of Integer, String)()
        _timeLeft = TimeSpan.FromMinutes(_duration)
    End Sub

    Private Sub ExamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestions()
        DisplayQuestion()
        
        lblTimer.Text = _timeLeft.ToString("mm\:ss")
        ExamTimer.Interval = 1000 ' 1 second
        ExamTimer.Start()
    End Sub

    Private Sub LoadQuestions()
        Dim query As String = "SELECT QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD FROM Questions WHERE ExamID = @EID ORDER BY QuestionID ASC"
        Dim params As New Dictionary(Of String, Object) From {{"@EID", _examID}}
        _questions = DatabaseHelper.ExecuteQueryParams(query, params)

        If _questions.Rows.Count = 0 Then
            MessageBox.Show("No questions found for this exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub DisplayQuestion()
        If _questions Is Nothing OrElse _questions.Rows.Count = 0 Then Return

        Dim row As DataRow = _questions.Rows(_currentQuestionIndex)
        Dim qID As Integer = Convert.ToInt32(row("QuestionID"))

        lblQNo.Text = "Q" & (_currentQuestionIndex + 1) & "."
        lblQuestionText.Text = row("QuestionText").ToString()
        rbOptionA.Text = row("OptionA").ToString()
        rbOptionB.Text = row("OptionB").ToString()
        rbOptionC.Text = row("OptionC").ToString()
        rbOptionD.Text = row("OptionD").ToString()

        ' Reset selection
        rbOptionA.Checked = False
        rbOptionB.Checked = False
        rbOptionC.Checked = False
        rbOptionD.Checked = False

        ' Restore previous answer if any
        If _userAnswers.ContainsKey(qID) Then
            Dim ans As String = _userAnswers(qID)
            Select Case ans
                Case "A" : rbOptionA.Checked = True
                Case "B" : rbOptionB.Checked = True
                Case "C" : rbOptionC.Checked = True
                Case "D" : rbOptionD.Checked = True
            End Select
        End If

        ' Update Navigation Buttons
        btnPrev.Enabled = _currentQuestionIndex > 0
        btnNext.Enabled = _currentQuestionIndex < _questions.Rows.Count - 1
    End Sub

    Private Sub SaveAnswer()
        Dim row As DataRow = _questions.Rows(_currentQuestionIndex)
        Dim qID As Integer = Convert.ToInt32(row("QuestionID"))
        Dim selected As String = ""

        If rbOptionA.Checked Then selected = "A"
        If rbOptionB.Checked Then selected = "B"
        If rbOptionC.Checked Then selected = "C"
        If rbOptionD.Checked Then selected = "D"

        If Not String.IsNullOrEmpty(selected) Then
            If _userAnswers.ContainsKey(qID) Then
                _userAnswers(qID) = selected
            Else
                _userAnswers.Add(qID, selected)
            End If
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        SaveAnswer()
        _currentQuestionIndex += 1
        DisplayQuestion()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        SaveAnswer()
        _currentQuestionIndex -= 1
        DisplayQuestion()
    End Sub

    Private Sub ExamTimer_Tick(sender As Object, e As EventArgs) Handles ExamTimer.Tick
        _timeLeft = _timeLeft.Subtract(TimeSpan.FromSeconds(1))
        lblTimer.Text = _timeLeft.ToString("mm\:ss")

        If _timeLeft.TotalSeconds <= 0 Then
            ExamTimer.Stop()
            MessageBox.Show("Time is up! Submitting exam automatically.", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SubmitExam()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SaveAnswer()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to submit?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SubmitExam()
        End If
    End Sub

    Private Sub SubmitExam()
        ExamTimer.Stop()
        SaveAnswer() ' Ensure last answer is saved
        
        Dim totalQuestions As Integer = _questions.Rows.Count
        Dim score As Integer = 0
        
        ' Fetch correct answers to calculate score
        ' Ideally we should do this calculation on the server/DB side for security, but doing it here for simplicity as per requirements.
        Dim query As String = "SELECT QuestionID, CorrectOption FROM Questions WHERE ExamID = @EID"
        Dim params As New Dictionary(Of String, Object) From {{"@EID", _examID}}
        Dim correctAnswers As DataTable = DatabaseHelper.ExecuteQueryParams(query, params)
        
        For Each row As DataRow In correctAnswers.Rows
            Dim qID As Integer = Convert.ToInt32(row("QuestionID"))
            Dim correctOpt As String = row("CorrectOption").ToString()
            
            If _userAnswers.ContainsKey(qID) AndAlso _userAnswers(qID) = correctOpt Then
                score += 1
            End If
        Next
        
        Dim percentage As Decimal = (score / totalQuestions) * 100
        
        ' Save Result to DB
        Dim insertQuery As String = "INSERT INTO Results (UserID, ExamID, Score, TotalMarks, Percentage) VALUES (@UID, @EID, @Score, @Total, @Perc)"
        Dim valParams As New Dictionary(Of String, Object)
        valParams.Add("@UID", LoginForm.CurrentUserID)
        valParams.Add("@EID", _examID)
        valParams.Add("@Score", score)
        valParams.Add("@Total", totalQuestions)
        valParams.Add("@Perc", percentage)
        

        DatabaseHelper.ExecuteNonQueryParams(insertQuery, valParams)
        
        ' Show Result Page instead of MessageBox
        Dim resultPage As New ResultForm(score, totalQuestions, percentage)
        resultPage.Show()
        Me.Close()
    End Sub

End Class
