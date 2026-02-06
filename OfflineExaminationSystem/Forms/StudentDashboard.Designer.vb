<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboard
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.dgvAvailableExams = New System.Windows.Forms.DataGridView()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.btnStartExam = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.lblHistory = New System.Windows.Forms.Label()
        CType(Me.dgvAvailableExams, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(13, 13)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(155, 20)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, Student"
        '
        'dgvAvailableExams
        '
        Me.dgvAvailableExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvailableExams.Location = New System.Drawing.Point(17, 70)
        Me.dgvAvailableExams.MultiSelect = False
        Me.dgvAvailableExams.Name = "dgvAvailableExams"
        Me.dgvAvailableExams.ReadOnly = True
        Me.dgvAvailableExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAvailableExams.Size = New System.Drawing.Size(500, 150)
        Me.dgvAvailableExams.TabIndex = 1
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(17, 50)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(87, 13)
        Me.lblAvailable.TabIndex = 2
        Me.lblAvailable.Text = "Available Exams:"
        '
        'btnStartExam
        '
        Me.btnStartExam.Location = New System.Drawing.Point(530, 70)
        Me.btnStartExam.Name = "btnStartExam"
        Me.btnStartExam.Size = New System.Drawing.Size(120, 40)
        Me.btnStartExam.TabIndex = 3
        Me.btnStartExam.Text = "Start Selected Exam"
        Me.btnStartExam.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(600, 10)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(90, 30)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'dgvHistory
        '
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Location = New System.Drawing.Point(17, 260)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.Size = New System.Drawing.Size(500, 150)
        Me.dgvHistory.TabIndex = 5
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Location = New System.Drawing.Point(17, 240)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(94, 13)
        Me.lblHistory.TabIndex = 6
        Me.lblHistory.Text = "Your Exam History:"
        '
        'StudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.dgvHistory)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnStartExam)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.dgvAvailableExams)
        Me.Controls.Add(Me.lblWelcome)
        Me.MaximizeBox = False
        Me.Name = "StudentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Dashboard"
        CType(Me.dgvAvailableExams, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents dgvAvailableExams As DataGridView
    Friend WithEvents lblAvailable As Label
    Friend WithEvents btnStartExam As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents lblHistory As Label
End Class
