<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblScoreLabel = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(150, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(200, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Exam Result"
        '
        'picStudent
        '
        Me.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudent.Location = New System.Drawing.Point(175, 80)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(150, 150)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 1
        Me.picStudent.TabStop = False
        '
        'lblStudentName
        '
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(50, 240)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(400, 23)
        Me.lblStudentName.TabIndex = 2
        Me.lblStudentName.Text = "Student Name"
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreLabel
        '
        Me.lblScoreLabel.AutoSize = True
        Me.lblScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreLabel.Location = New System.Drawing.Point(150, 280)
        Me.lblScoreLabel.Name = "lblScoreLabel"
        Me.lblScoreLabel.Size = New System.Drawing.Size(110, 24)
        Me.lblScoreLabel.TabIndex = 3
        Me.lblScoreLabel.Text = "Total Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Blue
        Me.lblScore.Location = New System.Drawing.Point(280, 280)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(49, 24)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0/10"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(200, 320)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(95, 26)
        Me.lblPercent.TabIndex = 5
        Me.lblPercent.Text = "85.00 %"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(200, 380)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 35)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ResultForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreLabel)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.picStudent)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ResultForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Results"
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picStudent As PictureBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblScoreLabel As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents btnClose As Button
End Class
