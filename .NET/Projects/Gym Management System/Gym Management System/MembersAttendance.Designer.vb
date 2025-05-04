<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembersAttendance
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

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MemberAttendanceIDTextBox = New System.Windows.Forms.TextBox()
        Me.MemberIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeInDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeOutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.WorkoutComboBox = New System.Windows.Forms.ComboBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Members Attendance Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Member Attendance ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Member ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Time In"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Time Out"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Workout Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Name"
        '
        'MemberAttendanceIDTextBox
        '
        Me.MemberAttendanceIDTextBox.Location = New System.Drawing.Point(190, 67)
        Me.MemberAttendanceIDTextBox.Name = "MemberAttendanceIDTextBox"
        Me.MemberAttendanceIDTextBox.Size = New System.Drawing.Size(160, 29)
        Me.MemberAttendanceIDTextBox.TabIndex = 9
        '
        'MemberIDTextBox
        '
        Me.MemberIDTextBox.Location = New System.Drawing.Point(190, 107)
        Me.MemberIDTextBox.Name = "MemberIDTextBox"
        Me.MemberIDTextBox.Size = New System.Drawing.Size(160, 29)
        Me.MemberIDTextBox.TabIndex = 10
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(190, 147)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(160, 29)
        Me.NameTextBox.TabIndex = 11
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(190, 187)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(160, 29)
        Me.DateTimePicker.TabIndex = 12
        '
        'TimeInDateTimePicker
        '
        Me.TimeInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeInDateTimePicker.Location = New System.Drawing.Point(190, 227)
        Me.TimeInDateTimePicker.Name = "TimeInDateTimePicker"
        Me.TimeInDateTimePicker.Size = New System.Drawing.Size(160, 29)
        Me.TimeInDateTimePicker.TabIndex = 13
        '
        'TimeOutDateTimePicker
        '
        Me.TimeOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeOutDateTimePicker.Location = New System.Drawing.Point(190, 267)
        Me.TimeOutDateTimePicker.Name = "TimeOutDateTimePicker"
        Me.TimeOutDateTimePicker.Size = New System.Drawing.Size(160, 29)
        Me.TimeOutDateTimePicker.TabIndex = 14
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.Items.AddRange(New Object() {"Present", "Absent", "Leave"})
        Me.StatusComboBox.Location = New System.Drawing.Point(190, 307)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(160, 29)
        Me.StatusComboBox.TabIndex = 15
        '
        'WorkoutComboBox
        '
        Me.WorkoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WorkoutComboBox.Items.AddRange(New Object() {"Cardio", "Strength", "Yoga", "Pilates", "Zumba"})
        Me.WorkoutComboBox.Location = New System.Drawing.Point(190, 347)
        Me.WorkoutComboBox.Name = "WorkoutComboBox"
        Me.WorkoutComboBox.Size = New System.Drawing.Size(160, 29)
        Me.WorkoutComboBox.TabIndex = 16
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SubmitButton.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.Location = New System.Drawing.Point(130, 400)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(140, 40)
        Me.SubmitButton.TabIndex = 17
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'MembersAttendance
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(400, 480)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MemberAttendanceIDTextBox)
        Me.Controls.Add(Me.MemberIDTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.TimeInDateTimePicker)
        Me.Controls.Add(Me.TimeOutDateTimePicker)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.WorkoutComboBox)
        Me.Controls.Add(Me.SubmitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MembersAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Attendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

    Friend WithEvents MemberAttendanceIDTextBox As TextBox
    Friend WithEvents MemberIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox

    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents TimeInDateTimePicker As DateTimePicker
    Friend WithEvents TimeOutDateTimePicker As DateTimePicker

    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents WorkoutComboBox As ComboBox

    Friend WithEvents SubmitButton As Button

End Class
