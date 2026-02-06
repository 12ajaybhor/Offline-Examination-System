Imports OfflineExaminationSystem.Modules

Public Class LoginForm
    
    ' Global/Shared variable to store the logged-in user details
    Public Shared CurrentUserID As Integer
    Public Shared CurrentUserName As String
    Public Shared CurrentUserRole As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' In a real app, use Hashing. Here we compare plain text as per schema.
            Dim query As String = "SELECT UserID, FullName, Role FROM Users WHERE Username = @User AND PasswordHash = @Pass"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@User", username)
            params.Add("@Pass", password)

            Dim dt As DataTable = DatabaseHelper.ExecuteQueryParams(query, params)

            If dt.Rows.Count > 0 Then
                ' Login Success
                Dim row As DataRow = dt.Rows(0)
                CurrentUserID = Convert.ToInt32(row("UserID"))
                CurrentUserName = row("FullName").ToString()
                CurrentUserRole = row("Role").ToString()

                MessageBox.Show("Welcome, " & CurrentUserName, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Navigate based on Role
                Me.Hide()
                If CurrentUserRole = "Admin" Then
                    Dim adminDash As New AdminDashboard()
                    adminDash.Show()
                ElseIf CurrentUserRole = "Teacher" Then
                    Dim teacherDash As New TeacherDashboard()
                    teacherDash.Show()
                Else
                    Dim studentDash As New StudentDashboard()
                    studentDash.Show()
                End If
            Else
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handle closing of dashboards to return here or exit
    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
