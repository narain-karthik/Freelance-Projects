<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserHomePage
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required method for Designer support - do not modify
    'the contents of this method with the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblUserWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewAttendance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUserWelcome
        '
        Me.lblUserWelcome.AutoSize = True
        Me.lblUserWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserWelcome.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblUserWelcome.Location = New System.Drawing.Point(135, 83)
        Me.lblUserWelcome.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblUserWelcome.Name = "lblUserWelcome"
        Me.lblUserWelcome.Size = New System.Drawing.Size(338, 25)
        Me.lblUserWelcome.TabIndex = 0
        Me.lblUserWelcome.Text = "Welcome to the User Home Page!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(192, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AC Jain & Co Company"
        '
        'btnViewAttendance
        '
        Me.btnViewAttendance.Location = New System.Drawing.Point(197, 184)
        Me.btnViewAttendance.Margin = New System.Windows.Forms.Padding(5)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.Size = New System.Drawing.Size(232, 66)
        Me.btnViewAttendance.TabIndex = 3
        Me.btnViewAttendance.Text = "View Attendance"
        Me.btnViewAttendance.UseVisualStyleBackColor = True
        '
        'UserHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(650, 469)
        Me.Controls.Add(Me.btnViewAttendance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUserWelcome)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "UserHomePage"
        Me.Text = "User Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblUserWelcome As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnViewAttendance As System.Windows.Forms.Button

    ' Event handler for button click
    Private Sub btnViewAttendance_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the AddStaffDetails form and show it
        Dim addStaffForm As New ViewAttendance()
        addStaffForm.Show()
    End Sub
End Class
