<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.AddStaffDetailsButton = New System.Windows.Forms.Button()
        Me.ViewStaffButton = New System.Windows.Forms.Button()
        Me.StaffAttendanceButton = New System.Windows.Forms.Button()
        Me.ViewStaffAttendanceButton = New System.Windows.Forms.Button()
        Me.SoldOutButton = New System.Windows.Forms.Button()
        Me.ViewSoldOutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(400, 40)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(249, 25)
        Me.WelcomeLabel.TabIndex = 0
        Me.WelcomeLabel.Text = "Welcome to Admin Page"
        '
        'AddStaffDetailsButton
        '
        Me.AddStaffDetailsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStaffDetailsButton.Location = New System.Drawing.Point(58, 147)
        Me.AddStaffDetailsButton.Name = "AddStaffDetailsButton"
        Me.AddStaffDetailsButton.Size = New System.Drawing.Size(170, 25)
        Me.AddStaffDetailsButton.TabIndex = 1
        Me.AddStaffDetailsButton.Text = "Add Staff Deatils"
        Me.AddStaffDetailsButton.UseVisualStyleBackColor = True
        '
        'ViewStaffButton
        '
        Me.ViewStaffButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewStaffButton.Location = New System.Drawing.Point(58, 254)
        Me.ViewStaffButton.Name = "ViewStaffButton"
        Me.ViewStaffButton.Size = New System.Drawing.Size(170, 25)
        Me.ViewStaffButton.TabIndex = 2
        Me.ViewStaffButton.Text = "View Staff Deatils"
        Me.ViewStaffButton.UseVisualStyleBackColor = True
        '
        'StaffAttendanceButton
        '
        Me.StaffAttendanceButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffAttendanceButton.Location = New System.Drawing.Point(345, 147)
        Me.StaffAttendanceButton.Name = "StaffAttendanceButton"
        Me.StaffAttendanceButton.Size = New System.Drawing.Size(170, 25)
        Me.StaffAttendanceButton.TabIndex = 3
        Me.StaffAttendanceButton.Text = "Staff Attendance"
        Me.StaffAttendanceButton.UseVisualStyleBackColor = True
        '
        'ViewStaffAttendanceButton
        '
        Me.ViewStaffAttendanceButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewStaffAttendanceButton.Location = New System.Drawing.Point(345, 254)
        Me.ViewStaffAttendanceButton.Name = "ViewStaffAttendanceButton"
        Me.ViewStaffAttendanceButton.Size = New System.Drawing.Size(170, 25)
        Me.ViewStaffAttendanceButton.TabIndex = 4
        Me.ViewStaffAttendanceButton.Text = "View Staff Attendance"
        Me.ViewStaffAttendanceButton.UseVisualStyleBackColor = True
        '
        'SoldOutButton
        '
        Me.SoldOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoldOutButton.Location = New System.Drawing.Point(601, 147)
        Me.SoldOutButton.Name = "SoldOutButton"
        Me.SoldOutButton.Size = New System.Drawing.Size(170, 25)
        Me.SoldOutButton.TabIndex = 5
        Me.SoldOutButton.Text = "Sold Out Car Details"
        Me.SoldOutButton.UseVisualStyleBackColor = True
        '
        'ViewSoldOutButton
        '
        Me.ViewSoldOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSoldOutButton.Location = New System.Drawing.Point(601, 245)
        Me.ViewSoldOutButton.Name = "ViewSoldOutButton"
        Me.ViewSoldOutButton.Size = New System.Drawing.Size(170, 25)
        Me.ViewSoldOutButton.TabIndex = 6
        Me.ViewSoldOutButton.Text = "View Sold Out Details"
        Me.ViewSoldOutButton.UseVisualStyleBackColor = True
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 450)
        Me.Controls.Add(Me.ViewSoldOutButton)
        Me.Controls.Add(Me.SoldOutButton)
        Me.Controls.Add(Me.ViewStaffAttendanceButton)
        Me.Controls.Add(Me.StaffAttendanceButton)
        Me.Controls.Add(Me.ViewStaffButton)
        Me.Controls.Add(Me.AddStaffDetailsButton)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Name = "AdminHome"
        Me.Text = "AdminHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents AddStaffDetailsButton As System.Windows.Forms.Button
    Friend WithEvents ViewStaffButton As System.Windows.Forms.Button
    Friend WithEvents StaffAttendanceButton As System.Windows.Forms.Button
    Friend WithEvents ViewStaffAttendanceButton As System.Windows.Forms.Button
    Friend WithEvents SoldOutButton As System.Windows.Forms.Button
    Friend WithEvents ViewSoldOutButton As System.Windows.Forms.Button
End Class
