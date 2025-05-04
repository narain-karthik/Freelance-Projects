<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaffDetails
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
        Me.AddStaffDetailsLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.DOBLabel = New System.Windows.Forms.Label()
        Me.DOJLabel = New System.Windows.Forms.Label()
        Me.IDProofLabel = New System.Windows.Forms.Label()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DOJDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeEmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.IDProofTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddStaffDetailsLabel
        '
        Me.AddStaffDetailsLabel.AutoSize = True
        Me.AddStaffDetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStaffDetailsLabel.Location = New System.Drawing.Point(151, 26)
        Me.AddStaffDetailsLabel.Name = "AddStaffDetailsLabel"
        Me.AddStaffDetailsLabel.Size = New System.Drawing.Size(174, 25)
        Me.AddStaffDetailsLabel.TabIndex = 0
        Me.AddStaffDetailsLabel.Text = "Add Staff Details"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(13, 104)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(124, 17)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Employee Name"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel.Location = New System.Drawing.Point(13, 140)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(98, 17)
        Me.IDLabel.TabIndex = 2
        Me.IDLabel.Text = "Employee ID"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(12, 180)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(142, 17)
        Me.EmailLabel.TabIndex = 3
        Me.EmailLabel.Text = "Employee Email ID"
        '
        'DOBLabel
        '
        Me.DOBLabel.AutoSize = True
        Me.DOBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBLabel.Location = New System.Drawing.Point(13, 226)
        Me.DOBLabel.Name = "DOBLabel"
        Me.DOBLabel.Size = New System.Drawing.Size(100, 17)
        Me.DOBLabel.TabIndex = 4
        Me.DOBLabel.Text = "Date of Birth"
        '
        'DOJLabel
        '
        Me.DOJLabel.AutoSize = True
        Me.DOJLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOJLabel.Location = New System.Drawing.Point(13, 271)
        Me.DOJLabel.Name = "DOJLabel"
        Me.DOJLabel.Size = New System.Drawing.Size(118, 17)
        Me.DOJLabel.TabIndex = 5
        Me.DOJLabel.Text = "Date of Joining"
        '
        'IDProofLabel
        '
        Me.IDProofLabel.AutoSize = True
        Me.IDProofLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDProofLabel.Location = New System.Drawing.Point(13, 313)
        Me.IDProofLabel.Name = "IDProofLabel"
        Me.IDProofLabel.Size = New System.Drawing.Size(154, 17)
        Me.IDProofLabel.TabIndex = 6
        Me.IDProofLabel.Text = "ID Proof (PAN Card)"
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(165, 226)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DOBDateTimePicker.TabIndex = 7
        '
        'DOJDateTimePicker
        '
        Me.DOJDateTimePicker.Location = New System.Drawing.Point(165, 271)
        Me.DOJDateTimePicker.Name = "DOJDateTimePicker"
        Me.DOJDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DOJDateTimePicker.TabIndex = 8
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(165, 99)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmployeeNameTextBox.TabIndex = 9
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(165, 140)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmployeeIDTextBox.TabIndex = 10
        '
        'EmployeeEmailIDTextBox
        '
        Me.EmployeeEmailIDTextBox.Location = New System.Drawing.Point(165, 180)
        Me.EmployeeEmailIDTextBox.Name = "EmployeeEmailIDTextBox"
        Me.EmployeeEmailIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmployeeEmailIDTextBox.TabIndex = 11
        '
        'IDProofTextBox
        '
        Me.IDProofTextBox.Location = New System.Drawing.Point(165, 313)
        Me.IDProofTextBox.Name = "IDProofTextBox"
        Me.IDProofTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IDProofTextBox.TabIndex = 12
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(48, 384)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 13
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(165, 384)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 14
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(279, 384)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 15
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'AddStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.IDProofTextBox)
        Me.Controls.Add(Me.EmployeeEmailIDTextBox)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(Me.DOJDateTimePicker)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Me.IDProofLabel)
        Me.Controls.Add(Me.DOJLabel)
        Me.Controls.Add(Me.DOBLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AddStaffDetailsLabel)
        Me.Name = "AddStaffDetails"
        Me.Text = "AddStaffDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddStaffDetailsLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents DOBLabel As System.Windows.Forms.Label
    Friend WithEvents DOJLabel As System.Windows.Forms.Label
    Friend WithEvents IDProofLabel As System.Windows.Forms.Label
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DOJDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeEmailIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDProofTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
End Class
