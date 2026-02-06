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
        Me.tabStudents = New System.Windows.Forms.TabPage()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.tabResults = New System.Windows.Forms.TabPage()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.tabAnalytics = New System.Windows.Forms.TabPage()
        Me.dgvAnalytics = New System.Windows.Forms.DataGridView()
        Me.lblAnalyticsTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabStudents.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResults.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAnalytics.SuspendLayout()
        CType(Me.dgvAnalytics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabStudents)
        Me.TabControl1.Controls.Add(Me.tabResults)
        Me.TabControl1.Controls.Add(Me.tabAnalytics)
        Me.TabControl1.Location = New System.Drawing.Point(12, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 500)
        Me.TabControl1.TabIndex = 2
        '
        'tabStudents
        '
        Me.tabStudents.Controls.Add(Me.dgvStudents)
        Me.tabStudents.Location = New System.Drawing.Point(4, 22)
        Me.tabStudents.Name = "tabStudents"
        Me.tabStudents.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStudents.Size = New System.Drawing.Size(752, 474)
        Me.tabStudents.TabIndex = 0
        Me.tabStudents.Text = "View Students"
        Me.tabStudents.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudents.Location = New System.Drawing.Point(3, 3)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.Size = New System.Drawing.Size(746, 468)
        Me.dgvStudents.TabIndex = 0
        '
        'tabResults
        '
        Me.tabResults.Controls.Add(Me.dgvResults)
        Me.tabResults.Location = New System.Drawing.Point(4, 22)
        Me.tabResults.Name = "tabResults"
        Me.tabResults.Padding = New System.Windows.Forms.Padding(3)
        Me.tabResults.Size = New System.Drawing.Size(752, 474)
        Me.tabResults.TabIndex = 1
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
        Me.tabAnalytics.TabIndex = 2
        Me.tabAnalytics.Text = "Analytics"
        Me.tabAnalytics.UseVisualStyleBackColor = True
        '
        'dgvAnalytics
        '
        Me.dgvAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnalytics.Location = New System.Drawing.Point(20, 60)
        Me.dgvAnalytics.Name = "dgvAnalytics"
        Me.dgvAnalytics.Size = New System.Drawing.Size(710, 380)
        Me.dgvAnalytics.TabIndex = 1
        '
        'lblAnalyticsTitle
        '
        Me.lblAnalyticsTitle.AutoSize = True
        Me.lblAnalyticsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalyticsTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblAnalyticsTitle.Name = "lblAnalyticsTitle"
        Me.lblAnalyticsTitle.Size = New System.Drawing.Size(262, 20)
        Me.lblAnalyticsTitle.TabIndex = 0
        Me.lblAnalyticsTitle.Text = "Performance Analysis by Exam"
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
        Me.tabStudents.ResumeLayout(False)
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResults.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAnalytics.ResumeLayout(False)
        Me.tabAnalytics.PerformLayout()
        CType(Me.dgvAnalytics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabStudents As TabPage
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents tabResults As TabPage
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents tabAnalytics As TabPage
    Friend WithEvents dgvAnalytics As DataGridView
    Friend WithEvents lblAnalyticsTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
End Class
