<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabExams = New System.Windows.Forms.TabPage()
        Me.dgvExams = New System.Windows.Forms.DataGridView()
        Me.grpCreateExam = New System.Windows.Forms.GroupBox()
        Me.btnAddExam = New System.Windows.Forms.Button()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtExamTitle = New System.Windows.Forms.TextBox()
        Me.lblExamTitle = New System.Windows.Forms.Label()
        Me.tabQuestions = New System.Windows.Forms.TabPage()
        Me.dgvQuestions = New System.Windows.Forms.DataGridView()
        Me.grpAddQuestion = New System.Windows.Forms.GroupBox()
        Me.btnAddQuestion = New System.Windows.Forms.Button()
        Me.cmbCorrectOpt = New System.Windows.Forms.ComboBox()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.txtOptD = New System.Windows.Forms.TextBox()
        Me.lblOptD = New System.Windows.Forms.Label()
        Me.txtOptC = New System.Windows.Forms.TextBox()
        Me.lblOptC = New System.Windows.Forms.Label()
        Me.txtOptB = New System.Windows.Forms.TextBox()
        Me.lblOptB = New System.Windows.Forms.Label()
        Me.txtOptA = New System.Windows.Forms.TextBox()
        Me.lblOptA = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.cmbExamSelect = New System.Windows.Forms.ComboBox()
        Me.lblSelectExam = New System.Windows.Forms.Label()
        Me.tabStudents = New System.Windows.Forms.TabPage()
        Me.grpAddStudent = New System.Windows.Forms.GroupBox()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.picStudentPreview = New System.Windows.Forms.PictureBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.txtStudentPass = New System.Windows.Forms.TextBox()
        Me.lblStudentPass = New System.Windows.Forms.Label()
        Me.txtStudentUser = New System.Windows.Forms.TextBox()
        Me.lblStudentUser = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.tabResults = New System.Windows.Forms.TabPage()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabExams.SuspendLayout()
        CType(Me.dgvExams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCreateExam.SuspendLayout()
        Me.tabQuestions.SuspendLayout()
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddQuestion.SuspendLayout()
        Me.tabStudents.SuspendLayout()
        Me.grpAddStudent.SuspendLayout()
        CType(Me.picStudentPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResults.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabExams)
        Me.TabControl1.Controls.Add(Me.tabQuestions)
        Me.TabControl1.Controls.Add(Me.tabStudents)
        Me.TabControl1.Controls.Add(Me.tabResults)
        Me.TabControl1.Location = New System.Drawing.Point(12, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 500)
        Me.TabControl1.TabIndex = 2
        '
        'tabExams
        '
        Me.tabExams.Controls.Add(Me.dgvExams)
        Me.tabExams.Controls.Add(Me.grpCreateExam)
        Me.tabExams.Location = New System.Drawing.Point(4, 22)
        Me.tabExams.Name = "tabExams"
        Me.tabExams.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExams.Size = New System.Drawing.Size(752, 474)
        Me.tabExams.TabIndex = 0
        Me.tabExams.Text = "Manage Exams"
        Me.tabExams.UseVisualStyleBackColor = True
        '
        'dgvExams
        '
        Me.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExams.Location = New System.Drawing.Point(6, 100)
        Me.dgvExams.Name = "dgvExams"
        Me.dgvExams.Size = New System.Drawing.Size(740, 368)
        Me.dgvExams.TabIndex = 1
        '
        'grpCreateExam
        '
        Me.grpCreateExam.Controls.Add(Me.btnAddExam)
        Me.grpCreateExam.Controls.Add(Me.txtDuration)
        Me.grpCreateExam.Controls.Add(Me.lblDuration)
        Me.grpCreateExam.Controls.Add(Me.txtExamTitle)
        Me.grpCreateExam.Controls.Add(Me.lblExamTitle)
        Me.grpCreateExam.Location = New System.Drawing.Point(6, 6)
        Me.grpCreateExam.Name = "grpCreateExam"
        Me.grpCreateExam.Size = New System.Drawing.Size(740, 80)
        Me.grpCreateExam.TabIndex = 0
        Me.grpCreateExam.TabStop = False
        Me.grpCreateExam.Text = "Create New Exam"
        '
        'btnAddExam
        '
        Me.btnAddExam.Location = New System.Drawing.Point(580, 23)
        Me.btnAddExam.Name = "btnAddExam"
        Me.btnAddExam.Size = New System.Drawing.Size(100, 28)
        Me.btnAddExam.TabIndex = 4
        Me.btnAddExam.Text = "Add Exam"
        Me.btnAddExam.UseVisualStyleBackColor = True
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(441, 27)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtDuration.TabIndex = 3
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(360, 30)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(75, 13)
        Me.lblDuration.TabIndex = 2
        Me.lblDuration.Text = "Duration(Min):"
        '
        'txtExamTitle
        '
        Me.txtExamTitle.Location = New System.Drawing.Point(81, 27)
        Me.txtExamTitle.Name = "txtExamTitle"
        Me.txtExamTitle.Size = New System.Drawing.Size(256, 20)
        Me.txtExamTitle.TabIndex = 1
        '
        'lblExamTitle
        '
        Me.lblExamTitle.AutoSize = True
        Me.lblExamTitle.Location = New System.Drawing.Point(15, 30)
        Me.lblExamTitle.Name = "lblExamTitle"
        Me.lblExamTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblExamTitle.TabIndex = 0
        Me.lblExamTitle.Text = "Exam Title:"
        '
        'tabQuestions
        '
        Me.tabQuestions.Controls.Add(Me.dgvQuestions)
        Me.tabQuestions.Controls.Add(Me.grpAddQuestion)
        Me.tabQuestions.Location = New System.Drawing.Point(4, 22)
        Me.tabQuestions.Name = "tabQuestions"
        Me.tabQuestions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQuestions.Size = New System.Drawing.Size(752, 474)
        Me.tabQuestions.TabIndex = 1
        Me.tabQuestions.Text = "Manage Questions"
        Me.tabQuestions.UseVisualStyleBackColor = True
        '
        'dgvQuestions
        '
        Me.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuestions.Location = New System.Drawing.Point(6, 230)
        Me.dgvQuestions.Name = "dgvQuestions"
        Me.dgvQuestions.Size = New System.Drawing.Size(740, 238)
        Me.dgvQuestions.TabIndex = 1
        '
        'grpAddQuestion
        '
        Me.grpAddQuestion.Controls.Add(Me.btnAddQuestion)
        Me.grpAddQuestion.Controls.Add(Me.cmbCorrectOpt)
        Me.grpAddQuestion.Controls.Add(Me.lblCorrect)
        Me.grpAddQuestion.Controls.Add(Me.txtOptD)
        Me.grpAddQuestion.Controls.Add(Me.lblOptD)
        Me.grpAddQuestion.Controls.Add(Me.txtOptC)
        Me.grpAddQuestion.Controls.Add(Me.lblOptC)
        Me.grpAddQuestion.Controls.Add(Me.txtOptB)
        Me.grpAddQuestion.Controls.Add(Me.lblOptB)
        Me.grpAddQuestion.Controls.Add(Me.txtOptA)
        Me.grpAddQuestion.Controls.Add(Me.lblOptA)
        Me.grpAddQuestion.Controls.Add(Me.txtQuestion)
        Me.grpAddQuestion.Controls.Add(Me.lblQuestion)
        Me.grpAddQuestion.Controls.Add(Me.cmbExamSelect)
        Me.grpAddQuestion.Controls.Add(Me.lblSelectExam)
        Me.grpAddQuestion.Location = New System.Drawing.Point(6, 6)
        Me.grpAddQuestion.Name = "grpAddQuestion"
        Me.grpAddQuestion.Size = New System.Drawing.Size(740, 212)
        Me.grpAddQuestion.TabIndex = 0
        Me.grpAddQuestion.TabStop = False
        Me.grpAddQuestion.Text = "Add New Question"
        '
        'btnAddQuestion
        '
        Me.btnAddQuestion.Location = New System.Drawing.Point(500, 168)
        Me.btnAddQuestion.Name = "btnAddQuestion"
        Me.btnAddQuestion.Size = New System.Drawing.Size(120, 30)
        Me.btnAddQuestion.TabIndex = 14
        Me.btnAddQuestion.Text = "Add Question"
        Me.btnAddQuestion.UseVisualStyleBackColor = True
        '
        'cmbCorrectOpt
        '
        Me.cmbCorrectOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCorrectOpt.FormattingEnabled = True
        Me.cmbCorrectOpt.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmbCorrectOpt.Location = New System.Drawing.Point(100, 172)
        Me.cmbCorrectOpt.Name = "cmbCorrectOpt"
        Me.cmbCorrectOpt.Size = New System.Drawing.Size(100, 21)
        Me.cmbCorrectOpt.TabIndex = 13
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Location = New System.Drawing.Point(20, 175)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(79, 13)
        Me.lblCorrect.TabIndex = 12
        Me.lblCorrect.Text = "Correct Option:"
        '
        'txtOptD
        '
        Me.txtOptD.Location = New System.Drawing.Point(400, 137)
        Me.txtOptD.Name = "txtOptD"
        Me.txtOptD.Size = New System.Drawing.Size(200, 20)
        Me.txtOptD.TabIndex = 11
        '
        'lblOptD
        '
        Me.lblOptD.AutoSize = True
        Me.lblOptD.Location = New System.Drawing.Point(320, 140)
        Me.lblOptD.Name = "lblOptD"
        Me.lblOptD.Size = New System.Drawing.Size(52, 13)
        Me.lblOptD.TabIndex = 10
        Me.lblOptD.Text = "Option D:"
        '
        'txtOptC
        '
        Me.txtOptC.Location = New System.Drawing.Point(100, 137)
        Me.txtOptC.Name = "txtOptC"
        Me.txtOptC.Size = New System.Drawing.Size(200, 20)
        Me.txtOptC.TabIndex = 9
        '
        'lblOptC
        '
        Me.lblOptC.AutoSize = True
        Me.lblOptC.Location = New System.Drawing.Point(20, 140)
        Me.lblOptC.Name = "lblOptC"
        Me.lblOptC.Size = New System.Drawing.Size(51, 13)
        Me.lblOptC.TabIndex = 8
        Me.lblOptC.Text = "Option C:"
        '
        'txtOptB
        '
        Me.txtOptB.Location = New System.Drawing.Point(400, 107)
        Me.txtOptB.Name = "txtOptB"
        Me.txtOptB.Size = New System.Drawing.Size(200, 20)
        Me.txtOptB.TabIndex = 7
        '
        'lblOptB
        '
        Me.lblOptB.AutoSize = True
        Me.lblOptB.Location = New System.Drawing.Point(320, 110)
        Me.lblOptB.Name = "lblOptB"
        Me.lblOptB.Size = New System.Drawing.Size(51, 13)
        Me.lblOptB.TabIndex = 6
        Me.lblOptB.Text = "Option B:"
        '
        'txtOptA
        '
        Me.txtOptA.Location = New System.Drawing.Point(100, 107)
        Me.txtOptA.Name = "txtOptA"
        Me.txtOptA.Size = New System.Drawing.Size(200, 20)
        Me.txtOptA.TabIndex = 5
        '
        'lblOptA
        '
        Me.lblOptA.AutoSize = True
        Me.lblOptA.Location = New System.Drawing.Point(20, 110)
        Me.lblOptA.Name = "lblOptA"
        Me.lblOptA.Size = New System.Drawing.Size(51, 13)
        Me.lblOptA.TabIndex = 4
        Me.lblOptA.Text = "Option A:"
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(100, 57)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(500, 40)
        Me.txtQuestion.TabIndex = 3
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(20, 60)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(52, 13)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "Question:"
        '
        'cmbExamSelect
        '
        Me.cmbExamSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExamSelect.FormattingEnabled = True
        Me.cmbExamSelect.Location = New System.Drawing.Point(100, 27)
        Me.cmbExamSelect.Name = "cmbExamSelect"
        Me.cmbExamSelect.Size = New System.Drawing.Size(250, 21)
        Me.cmbExamSelect.TabIndex = 1
        '
        'lblSelectExam
        '
        Me.lblSelectExam.AutoSize = True
        Me.lblSelectExam.Location = New System.Drawing.Point(20, 30)
        Me.lblSelectExam.Name = "lblSelectExam"
        Me.lblSelectExam.Size = New System.Drawing.Size(69, 13)
        Me.lblSelectExam.TabIndex = 0
        Me.lblSelectExam.Text = "Select Exam:"
        '
        'tabStudents
        '
        Me.tabStudents.Controls.Add(Me.grpAddStudent)
        Me.tabStudents.Location = New System.Drawing.Point(4, 22)
        Me.tabStudents.Name = "tabStudents"
        Me.tabStudents.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStudents.Size = New System.Drawing.Size(752, 474)
        Me.tabStudents.TabIndex = 3
        Me.tabStudents.Text = "Manage Students"
        Me.tabStudents.UseVisualStyleBackColor = True
        '
        'grpAddStudent
        '
        Me.grpAddStudent.Controls.Add(Me.btnBrowseImage)
        Me.grpAddStudent.Controls.Add(Me.picStudentPreview)
        Me.grpAddStudent.Controls.Add(Me.btnAddStudent)
        Me.grpAddStudent.Controls.Add(Me.txtStudentPass)
        Me.grpAddStudent.Controls.Add(Me.lblStudentPass)
        Me.grpAddStudent.Controls.Add(Me.txtStudentUser)
        Me.grpAddStudent.Controls.Add(Me.lblStudentUser)
        Me.grpAddStudent.Controls.Add(Me.txtStudentName)
        Me.grpAddStudent.Controls.Add(Me.lblStudentName)
        Me.grpAddStudent.Location = New System.Drawing.Point(20, 20)
        Me.grpAddStudent.Name = "grpAddStudent"
        Me.grpAddStudent.Size = New System.Drawing.Size(500, 300)
        Me.grpAddStudent.TabIndex = 0
        Me.grpAddStudent.TabStop = False
        Me.grpAddStudent.Text = "Register New Student"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(30, 40)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(57, 13)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "Full Name:"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(120, 37)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(200, 20)
        Me.txtStudentName.TabIndex = 1
        '
        'lblStudentUser
        '
        Me.lblStudentUser.AutoSize = True
        Me.lblStudentUser.Location = New System.Drawing.Point(30, 80)
        Me.lblStudentUser.Name = "lblStudentUser"
        Me.lblStudentUser.Size = New System.Drawing.Size(58, 13)
        Me.lblStudentUser.TabIndex = 2
        Me.lblStudentUser.Text = "Username:"
        '
        'txtStudentUser
        '
        Me.txtStudentUser.Location = New System.Drawing.Point(120, 77)
        Me.txtStudentUser.Name = "txtStudentUser"
        Me.txtStudentUser.Size = New System.Drawing.Size(200, 20)
        Me.txtStudentUser.TabIndex = 3
        '
        'lblStudentPass
        '
        Me.lblStudentPass.AutoSize = True
        Me.lblStudentPass.Location = New System.Drawing.Point(30, 120)
        Me.lblStudentPass.Name = "lblStudentPass"
        Me.lblStudentPass.Size = New System.Drawing.Size(56, 13)
        Me.lblStudentPass.TabIndex = 4
        Me.lblStudentPass.Text = "Password:"
        '
        'txtStudentPass
        '
        Me.txtStudentPass.Location = New System.Drawing.Point(120, 117)
        Me.txtStudentPass.Name = "txtStudentPass"
        Me.txtStudentPass.PasswordChar = "*"c
        Me.txtStudentPass.Size = New System.Drawing.Size(200, 20)
        Me.txtStudentPass.TabIndex = 5
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(120, 240)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(120, 30)
        Me.btnAddStudent.TabIndex = 6
        Me.btnAddStudent.Text = "Create Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'picStudentPreview
        '
        Me.picStudentPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudentPreview.Location = New System.Drawing.Point(340, 37)
        Me.picStudentPreview.Name = "picStudentPreview"
        Me.picStudentPreview.Size = New System.Drawing.Size(120, 120)
        Me.picStudentPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentPreview.TabIndex = 7
        Me.picStudentPreview.TabStop = False
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.Location = New System.Drawing.Point(340, 163)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(120, 23)
        Me.btnBrowseImage.TabIndex = 8
        Me.btnBrowseImage.Text = "Upload Photo"
        Me.btnBrowseImage.UseVisualStyleBackColor = True
        '
        'tabResults
        '
        Me.tabResults.Controls.Add(Me.dgvResults)
        Me.tabResults.Location = New System.Drawing.Point(4, 22)
        Me.tabResults.Name = "tabResults"
        Me.tabResults.Padding = New System.Windows.Forms.Padding(3)
        Me.tabResults.Size = New System.Drawing.Size(752, 474)
        Me.tabResults.TabIndex = 2
        Me.tabResults.Text = "View Results"
        Me.tabResults.UseVisualStyleBackColor = True
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResults.Location = New System.Drawing.Point(3, 3)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(746, 468)
        Me.dgvResults.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(200, 20)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, Admin"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(680, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(92, 29)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.MaximizeBox = False
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.TabControl1.ResumeLayout(False)
        Me.tabExams.ResumeLayout(False)
        Me.grpCreateExam.ResumeLayout(False)
        Me.grpCreateExam.PerformLayout()
        CType(Me.dgvExams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabQuestions.ResumeLayout(False)
        Me.grpAddQuestion.ResumeLayout(False)
        Me.grpAddQuestion.PerformLayout()
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabStudents.ResumeLayout(False)
        Me.grpAddStudent.ResumeLayout(False)
        Me.grpAddStudent.PerformLayout()
        CType(Me.picStudentPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResults.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabExams As TabPage
    Friend WithEvents tabQuestions As TabPage
    Friend WithEvents tabResults As TabPage
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents grpCreateExam As GroupBox
    Friend WithEvents dgvExams As DataGridView
    Friend WithEvents btnAddExam As Button
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents txtExamTitle As TextBox
    Friend WithEvents lblExamTitle As Label
    Friend WithEvents grpAddQuestion As GroupBox
    Friend WithEvents dgvQuestions As DataGridView
    Friend WithEvents lblSelectExam As Label
    Friend WithEvents cmbExamSelect As ComboBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents lblOptA As Label
    Friend WithEvents txtOptA As TextBox
    Friend WithEvents lblOptB As Label
    Friend WithEvents txtOptB As TextBox
    Friend WithEvents lblOptC As Label
    Friend WithEvents txtOptC As TextBox
    Friend WithEvents lblOptD As Label
    Friend WithEvents txtOptD As TextBox
    Friend WithEvents lblCorrect As Label
    Friend WithEvents cmbCorrectOpt As ComboBox
    Friend WithEvents btnAddQuestion As Button
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents tabStudents As TabPage
    Friend WithEvents grpAddStudent As GroupBox
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents picStudentPreview As PictureBox
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents txtStudentPass As TextBox
    Friend WithEvents lblStudentPass As Label
    Friend WithEvents txtStudentUser As TextBox
    Friend WithEvents lblStudentUser As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblStudentName As Label
End Class
