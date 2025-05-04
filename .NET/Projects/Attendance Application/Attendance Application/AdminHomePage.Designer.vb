<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomePage
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    ' Required method for Designer support
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAdminWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAttendanceDetails = New System.Windows.Forms.Button()
        Me.btnMarkAttendance = New System.Windows.Forms.Button()
        Me.btnAddStaffDetails = New System.Windows.Forms.Button()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAdminWelcome
        '
        Me.lblAdminWelcome.AutoSize = True
        Me.lblAdminWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminWelcome.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblAdminWelcome.Location = New System.Drawing.Point(214, 51)
        Me.lblAdminWelcome.Name = "lblAdminWelcome"
        Me.lblAdminWelcome.Size = New System.Drawing.Size(354, 25)
        Me.lblAdminWelcome.TabIndex = 0
        Me.lblAdminWelcome.Text = "Welcome to the Admin Home Page!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(282, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AC Jain & Co Company"
        '
        'btnAttendanceDetails
        '
        Me.btnAttendanceDetails.BackColor = System.Drawing.Color.Aqua
        Me.btnAttendanceDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendanceDetails.Location = New System.Drawing.Point(468, 150)
        Me.btnAttendanceDetails.Name = "btnAttendanceDetails"
        Me.btnAttendanceDetails.Size = New System.Drawing.Size(200, 30)
        Me.btnAttendanceDetails.TabIndex = 2
        Me.btnAttendanceDetails.Text = "Attendance Details"
        Me.btnAttendanceDetails.UseVisualStyleBackColor = False
        '
        'btnMarkAttendance
        '
        Me.btnMarkAttendance.BackColor = System.Drawing.Color.Aqua
        Me.btnMarkAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkAttendance.Location = New System.Drawing.Point(468, 230)
        Me.btnMarkAttendance.Name = "btnMarkAttendance"
        Me.btnMarkAttendance.Size = New System.Drawing.Size(200, 30)
        Me.btnMarkAttendance.TabIndex = 4
        Me.btnMarkAttendance.Text = "Mark Attendance"
        Me.btnMarkAttendance.UseVisualStyleBackColor = False
        '
        'btnAddStaffDetails
        '
        Me.btnAddStaffDetails.BackColor = System.Drawing.Color.Aqua
        Me.btnAddStaffDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaffDetails.Location = New System.Drawing.Point(65, 230)
        Me.btnAddStaffDetails.Name = "btnAddStaffDetails"
        Me.btnAddStaffDetails.Size = New System.Drawing.Size(200, 30)
        Me.btnAddStaffDetails.TabIndex = 5
        Me.btnAddStaffDetails.Text = "Add Staff Details"
        Me.btnAddStaffDetails.UseVisualStyleBackColor = False
        '
        'ViewButton
        '
        Me.ViewButton.BackColor = System.Drawing.Color.Aqua
        Me.ViewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.Location = New System.Drawing.Point(65, 150)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(200, 30)
        Me.ViewButton.TabIndex = 6
        Me.ViewButton.Text = "View Staff Details"
        Me.ViewButton.UseVisualStyleBackColor = False
        '
        'AdminHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(769, 466)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.btnAddStaffDetails)
        Me.Controls.Add(Me.btnMarkAttendance)
        Me.Controls.Add(Me.btnAttendanceDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAdminWelcome)
        Me.Name = "AdminHomePage"
        Me.Text = "Admin Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lblAdminWelcome As System.Windows.Forms.Label
    Private WithEvents btnAttendanceDetails As System.Windows.Forms.Button
    Private WithEvents btnMarkAttendance As System.Windows.Forms.Button
    Private WithEvents btnAddStaffDetails As System.Windows.Forms.Button

    ' Event Handlers for Button Clicks
    Private Sub BtnAttendanceDetails_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Code to redirect to Attendance Details
    End Sub

    Private Sub BtnWorkingStaffDetails_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Code to redirect to Working Staff Details
    End Sub

    Private Sub BtnMarkAttendance_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Code to redirect to Mark Attendance
    End Sub

    Private Sub BtnAddStaffDetails_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the AddStaffDetails form and show it
        Dim addStaffForm As New AddStaffDetails()
        addStaffForm.Show()
    End Sub
    Private WithEvents ViewButton As System.Windows.Forms.Button
End Class
