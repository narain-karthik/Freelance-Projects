<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAttendance
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.StaffattendanceIDLabel = New System.Windows.Forms.Label()
        Me.StaffIDLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TimeInLabel = New System.Windows.Forms.Label()
        Me.TimeOutLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.StaffattendanceIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeInDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeOutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TitleLabel.Location = New System.Drawing.Point(50, 20)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(350, 40)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Staff Attendance Details"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StaffattendanceIDLabel
        '
        Me.StaffattendanceIDLabel.AutoSize = True
        Me.StaffattendanceIDLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StaffattendanceIDLabel.Location = New System.Drawing.Point(50, 80)
        Me.StaffattendanceIDLabel.Name = "StaffattendanceIDLabel"
        Me.StaffattendanceIDLabel.Size = New System.Drawing.Size(124, 23)
        Me.StaffattendanceIDLabel.TabIndex = 1
        Me.StaffattendanceIDLabel.Text = "Attendance ID:"
        '
        'StaffIDLabel
        '
        Me.StaffIDLabel.AutoSize = True
        Me.StaffIDLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StaffIDLabel.Location = New System.Drawing.Point(50, 120)
        Me.StaffIDLabel.Name = "StaffIDLabel"
        Me.StaffIDLabel.Size = New System.Drawing.Size(69, 23)
        Me.StaffIDLabel.TabIndex = 2
        Me.StaffIDLabel.Text = "Staff ID:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NameLabel.Location = New System.Drawing.Point(50, 160)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(60, 23)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name:"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DateLabel.Location = New System.Drawing.Point(50, 200)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(50, 23)
        Me.DateLabel.TabIndex = 4
        Me.DateLabel.Text = "Date:"
        '
        'TimeInLabel
        '
        Me.TimeInLabel.AutoSize = True
        Me.TimeInLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TimeInLabel.Location = New System.Drawing.Point(50, 240)
        Me.TimeInLabel.Name = "TimeInLabel"
        Me.TimeInLabel.Size = New System.Drawing.Size(71, 23)
        Me.TimeInLabel.TabIndex = 5
        Me.TimeInLabel.Text = "Time In:"
        '
        'TimeOutLabel
        '
        Me.TimeOutLabel.AutoSize = True
        Me.TimeOutLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TimeOutLabel.Location = New System.Drawing.Point(50, 280)
        Me.TimeOutLabel.Name = "TimeOutLabel"
        Me.TimeOutLabel.Size = New System.Drawing.Size(85, 23)
        Me.TimeOutLabel.TabIndex = 6
        Me.TimeOutLabel.Text = "Time Out:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StatusLabel.Location = New System.Drawing.Point(50, 320)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(60, 23)
        Me.StatusLabel.TabIndex = 7
        Me.StatusLabel.Text = "Status:"
        '
        'StaffattendanceIDTextBox
        '
        Me.StaffattendanceIDTextBox.Location = New System.Drawing.Point(180, 80)
        Me.StaffattendanceIDTextBox.Name = "StaffattendanceIDTextBox"
        Me.StaffattendanceIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.StaffattendanceIDTextBox.TabIndex = 8
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.Location = New System.Drawing.Point(180, 120)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.StaffIDTextBox.TabIndex = 9
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(180, 160)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NameTextBox.TabIndex = 10
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(180, 200)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker.TabIndex = 11
        '
        'TimeInDateTimePicker
        '
        Me.TimeInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeInDateTimePicker.Location = New System.Drawing.Point(180, 240)
        Me.TimeInDateTimePicker.Name = "TimeInDateTimePicker"
        Me.TimeInDateTimePicker.ShowUpDown = True
        Me.TimeInDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.TimeInDateTimePicker.TabIndex = 12
        '
        'TimeOutDateTimePicker
        '
        Me.TimeOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeOutDateTimePicker.Location = New System.Drawing.Point(180, 280)
        Me.TimeOutDateTimePicker.Name = "TimeOutDateTimePicker"
        Me.TimeOutDateTimePicker.ShowUpDown = True
        Me.TimeOutDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.TimeOutDateTimePicker.TabIndex = 13
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.Items.AddRange(New Object() {"Present", "Absent", "Leave"})
        Me.StatusComboBox.Location = New System.Drawing.Point(180, 320)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(200, 24)
        Me.StatusComboBox.TabIndex = 14
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Teal
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(90, 380)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(120, 40)
        Me.SaveButton.TabIndex = 15
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Gray
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(230, 380)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(120, 40)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'StaffAttendance
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(450, 500)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.StaffattendanceIDLabel)
        Me.Controls.Add(Me.StaffIDLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.TimeInLabel)
        Me.Controls.Add(Me.TimeOutLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.StaffattendanceIDTextBox)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.TimeInDateTimePicker)
        Me.Controls.Add(Me.TimeOutDateTimePicker)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ClearButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "StaffAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Attendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents StaffattendanceIDLabel As Label
    Friend WithEvents StaffIDLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents TimeInLabel As Label
    Friend WithEvents TimeOutLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents StaffattendanceIDTextBox As TextBox
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents TimeInDateTimePicker As DateTimePicker
    Friend WithEvents TimeOutDateTimePicker As DateTimePicker
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearButton As Button
End Class
