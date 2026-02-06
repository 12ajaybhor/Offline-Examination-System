<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherDashboard
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
        Me.tabResults = New System.Windows.Forms.TabPage()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.tabAnalytics = New System.Windows.Forms.TabPage()
        Me.dgvAnalytics = New System.Windows.Forms.DataGridView()
        Me.lblAnalyticsTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabQuestions.SuspendLayout()
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddQuestion.SuspendLayout()
        Me.tabResults.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAnalytics.SuspendLayout()
        CType(Me.dgvAnalytics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabQuestions)
        Me.TabControl1.Controls.Add(Me.tabResults)
        Me.TabControl1.Controls.Add(Me.tabAnalytics)
        Me.TabControl1.Location = New System.Drawing.Point(12, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 500)
        Me.TabControl1.TabIndex = 2
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
        'tabAnalytics
        '
        Me.tabAnalytics.Controls.Add(Me.dgvAnalytics)
        Me.tabAnalytics.Controls.Add(Me.lblAnalyticsTitle)
        Me.tabAnalytics.Location = New System.Drawing.Point(4, 22)
        Me.tabAnalytics.Name = "tabAnalytics"
        Me.tabAnalytics.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAnalytics.Size = New System.Drawing.Size(752, 474)
        Me.tabAnalytics.TabIndex = 3
        Me.tabAnalytics.Text = "Analytics"
        Me.tabAnalytics.UseVisualStyleBackColor = True
        '
        'lblAnalyticsTitle
        '
        Me.lblAnalyticsTitle.AutoSize = True
        Me.lblAnalyticsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalyticsTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblAnalyticsTitle.Name = "lblAnalyticsTitle"
        Me.lblAnalyticsTitle.Size = New System.Drawing.Size(262, 20)
        Me.lblAnalyticsTitle.TabIndex = 0
        Me.lblAnalyticsTitle.Text = "Performance Analysis by Exan"
        '
        'dgvAnalytics
        '
        Me.dgvAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnalytics.Location = New System.Drawing.Point(20, 60)
        Me.dgvAnalytics.Name = "dgvAnalytics"
        Me.dgvAnalytics.Size = New System.Drawing.Size(710, 380)
        Me.dgvAnalytics.TabIndex = 1
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(200, 20)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, Teacher"
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
        'TeacherDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.MaximizeBox = False
        Me.Name = "TeacherDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Dashboard"
        Me.TabControl1.ResumeLayout(False)
        Me.tabQuestions.ResumeLayout(False)
        CType(Me.dgvQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddQuestion.ResumeLayout(False)
        Me.grpAddQuestion.PerformLayout()
        Me.tabResults.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAnalytics.ResumeLayout(False)
        Me.tabAnalytics.PerformLayout()
        CType(Me.dgvAnalytics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabQuestions As TabPage
    Friend WithEvents tabResults As TabPage
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
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
    Friend WithEvents tabAnalytics As TabPage
    Friend WithEvents dgvAnalytics As DataGridView
    Friend WithEvents lblAnalyticsTitle As Label
End Class
