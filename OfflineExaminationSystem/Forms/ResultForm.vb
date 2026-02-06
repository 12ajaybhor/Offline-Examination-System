Imports OfflineExaminationSystem.Modules
Imports System.IO

Public Class ResultForm
    Private _score As Integer
    Private _total As Integer
    Private _percent As Decimal

    Public Sub New(score As Integer, total As Integer, percent As Decimal)
        InitializeComponent()
        _score = score
        _total = total
        _percent = percent
    End Sub

    Private Sub ResultForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStudentName.Text = LoginForm.CurrentUserName
        lblScore.Text = _score & " / " & _total
        lblPercent.Text = _percent.ToString("F2") & " %"

        LoadStudentImage()
    End Sub

    Private Sub LoadStudentImage()
        Try
            Dim query As String = "SELECT ProfileImage FROM Users WHERE UserID = @UID"
            Dim params As New Dictionary(Of String, Object) From {{"@UID", LoginForm.CurrentUserID}}
            Dim dt As DataTable = DatabaseHelper.ExecuteQueryParams(query, params)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                If Not IsDBNull(row("ProfileImage")) Then
                    Dim imgBytes As Byte() = DirectCast(row("ProfileImage"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        picStudent.Image = Image.FromStream(ms)
                    End Using
                End If
            End If
        Catch ex As Exception
            ' If error loading image, just ignore or show default
            MessageBox.Show("Error loading profile image: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim dash As New StudentDashboard()
        dash.Show()
        Me.Close()
    End Sub
End Class
