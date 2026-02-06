<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblExamTitle = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.pnlQuestion = New System.Windows.Forms.Panel()
        Me.lblQNo = New System.Windows.Forms.Label()
        Me.lblQuestionText = New System.Windows.Forms.Label()
        Me.rbOptionA = New System.Windows.Forms.RadioButton()
        Me.rbOptionB = New System.Windows.Forms.RadioButton()
        Me.rbOptionC = New System.Windows.Forms.RadioButton()
        Me.rbOptionD = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.ExamTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExamTitle
        '
        Me.lblExamTitle.AutoSize = True
        Me.lblExamTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblExamTitle.Name = "lblExamTitle"
        Me.lblExamTitle.Size = New System.Drawing.Size(110, 24)
        Me.lblExamTitle.TabIndex = 0
        Me.lblExamTitle.Text = "Exam Title"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Red
        Me.lblTimer.Location = New System.Drawing.Point(650, 20)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(60, 24)
        Me.lblTimer.TabIndex = 1
        Me.lblTimer.Text = "00:00"
        '
        'pnlQuestion
        '
        Me.pnlQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQuestion.Controls.Add(Me.rbOptionD)
        Me.pnlQuestion.Controls.Add(Me.rbOptionC)
        Me.pnlQuestion.Controls.Add(Me.rbOptionB)
        Me.pnlQuestion.Controls.Add(Me.rbOptionA)
        Me.pnlQuestion.Controls.Add(Me.lblQuestionText)
        Me.pnlQuestion.Controls.Add(Me.lblQNo)
        Me.pnlQuestion.Location = New System.Drawing.Point(24, 60)
        Me.pnlQuestion.Name = "pnlQuestion"
        Me.pnlQuestion.Size = New System.Drawing.Size(740, 300)
        Me.pnlQuestion.TabIndex = 2
        '
        'lblQNo
        '
        Me.lblQNo.AutoSize = True
        Me.lblQNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQNo.Location = New System.Drawing.Point(15, 15)
        Me.lblQNo.Name = "lblQNo"
        Me.lblQNo.Size = New System.Drawing.Size(33, 17)
        Me.lblQNo.TabIndex = 0
        Me.lblQNo.Text = "Q1."
        '
        'lblQuestionText
        '
        Me.lblQuestionText.AutoSize = True
        Me.lblQuestionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionText.Location = New System.Drawing.Point(60, 15)
        Me.lblQuestionText.MaximumSize = New System.Drawing.Size(650, 0)
        Me.lblQuestionText.Name = "lblQuestionText"
        Me.lblQuestionText.Size = New System.Drawing.Size(102, 18)
        Me.lblQuestionText.TabIndex = 1
        Me.lblQuestionText.Text = "Question Here"
        '
        'rbOptionA
        '
        Me.rbOptionA.AutoSize = True
        Me.rbOptionA.Location = New System.Drawing.Point(63, 80)
        Me.rbOptionA.Name = "rbOptionA"
        Me.rbOptionA.Size = New System.Drawing.Size(66, 17)
        Me.rbOptionA.TabIndex = 2
        Me.rbOptionA.TabStop = True
        Me.rbOptionA.Text = "Option A"
        Me.rbOptionA.UseVisualStyleBackColor = True
        '
        'rbOptionB
        '
        Me.rbOptionB.AutoSize = True
        Me.rbOptionB.Location = New System.Drawing.Point(63, 120)
        Me.rbOptionB.Name = "rbOptionB"
        Me.rbOptionB.Size = New System.Drawing.Size(66, 17)
        Me.rbOptionB.TabIndex = 3
        Me.rbOptionB.TabStop = True
        Me.rbOptionB.Text = "Option B"
        Me.rbOptionB.UseVisualStyleBackColor = True
        '
        'rbOptionC
        '
        Me.rbOptionC.AutoSize = True
        Me.rbOptionC.Location = New System.Drawing.Point(63, 160)
        Me.rbOptionC.Name = "rbOptionC"
        Me.rbOptionC.Size = New System.Drawing.Size(66, 17)
        Me.rbOptionC.TabIndex = 4
        Me.rbOptionC.TabStop = True
        Me.rbOptionC.Text = "Option C"
        Me.rbOptionC.UseVisualStyleBackColor = True
        '
        'rbOptionD
        '
        Me.rbOptionD.AutoSize = True
        Me.rbOptionD.Location = New System.Drawing.Point(63, 200)
        Me.rbOptionD.Name = "rbOptionD"
        Me.rbOptionD.Size = New System.Drawing.Size(67, 17)
        Me.rbOptionD.TabIndex = 5
        Me.rbOptionD.TabStop = True
        Me.rbOptionD.Text = "Option D"
        Me.rbOptionD.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(664, 380)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 35)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next >>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(24, 380)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(100, 35)
        Me.btnPrev.TabIndex = 4
        Me.btnPrev.Text = "<< Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(340, 380)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 35)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit Exam"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'ExamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pnlQuestion)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblExamTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ExamForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam in Progress"
        Me.pnlQuestion.ResumeLayout(False)
        Me.pnlQuestion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExamTitle As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents pnlQuestion As Panel
    Friend WithEvents lblQNo As Label
    Friend WithEvents lblQuestionText As Label
    Friend WithEvents rbOptionA As RadioButton
    Friend WithEvents rbOptionB As RadioButton
    Friend WithEvents rbOptionC As RadioButton
    Friend WithEvents rbOptionD As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents ExamTimer As Timer
End Class
