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
        Me.EpNameLabel = New System.Windows.Forms.Label()
        Me.EpRegisterLabel = New System.Windows.Forms.Label()
        Me.DOBLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.DOJLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.ENTextBox = New System.Windows.Forms.TextBox()
        Me.ERNTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PHTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DOJDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StaffLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EpNameLabel
        '
        Me.EpNameLabel.AutoSize = True
        Me.EpNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EpNameLabel.Location = New System.Drawing.Point(13, 72)
        Me.EpNameLabel.Name = "EpNameLabel"
        Me.EpNameLabel.Size = New System.Drawing.Size(134, 17)
        Me.EpNameLabel.TabIndex = 0
        Me.EpNameLabel.Text = "Employee Name: "
        '
        'EpRegisterLabel
        '
        Me.EpRegisterLabel.AutoSize = True
        Me.EpRegisterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EpRegisterLabel.Location = New System.Drawing.Point(13, 116)
        Me.EpRegisterLabel.Name = "EpRegisterLabel"
        Me.EpRegisterLabel.Size = New System.Drawing.Size(215, 17)
        Me.EpRegisterLabel.TabIndex = 1
        Me.EpRegisterLabel.Text = "Emplyoee Register Number :"
        '
        'DOBLabel
        '
        Me.DOBLabel.AutoSize = True
        Me.DOBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBLabel.Location = New System.Drawing.Point(12, 171)
        Me.DOBLabel.Name = "DOBLabel"
        Me.DOBLabel.Size = New System.Drawing.Size(110, 17)
        Me.DOBLabel.TabIndex = 2
        Me.DOBLabel.Text = "Date of Brith: "
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(13, 221)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(77, 17)
        Me.AddressLabel.TabIndex = 3
        Me.AddressLabel.Text = "Address: "
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneLabel.Location = New System.Drawing.Point(13, 268)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(125, 17)
        Me.PhoneLabel.TabIndex = 4
        Me.PhoneLabel.Text = "Phone Number: "
        '
        'DOJLabel
        '
        Me.DOJLabel.AutoSize = True
        Me.DOJLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOJLabel.Location = New System.Drawing.Point(13, 325)
        Me.DOJLabel.Name = "DOJLabel"
        Me.DOJLabel.Size = New System.Drawing.Size(128, 17)
        Me.DOJLabel.TabIndex = 5
        Me.DOJLabel.Text = "Date of Joining: "
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel.Location = New System.Drawing.Point(13, 371)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(180, 17)
        Me.IDLabel.TabIndex = 6
        Me.IDLabel.Text = "ID Proof Details (PAN) :"
        '
        'ENTextBox
        '
        Me.ENTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ENTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ENTextBox.Location = New System.Drawing.Point(236, 72)
        Me.ENTextBox.Name = "ENTextBox"
        Me.ENTextBox.Size = New System.Drawing.Size(167, 22)
        Me.ENTextBox.TabIndex = 7
        '
        'ERNTextBox
        '
        Me.ERNTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ERNTextBox.Location = New System.Drawing.Point(236, 116)
        Me.ERNTextBox.Name = "ERNTextBox"
        Me.ERNTextBox.Size = New System.Drawing.Size(167, 22)
        Me.ERNTextBox.TabIndex = 8
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.AddressTextBox.Location = New System.Drawing.Point(236, 216)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(167, 22)
        Me.AddressTextBox.TabIndex = 9
        '
        'PHTextBox
        '
        Me.PHTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PHTextBox.Location = New System.Drawing.Point(236, 268)
        Me.PHTextBox.Name = "PHTextBox"
        Me.PHTextBox.Size = New System.Drawing.Size(167, 22)
        Me.PHTextBox.TabIndex = 10
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.IDTextBox.Location = New System.Drawing.Point(236, 371)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(167, 22)
        Me.IDTextBox.TabIndex = 11
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.SaveButton.Location = New System.Drawing.Point(128, 434)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(93, 26)
        Me.SaveButton.TabIndex = 12
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(236, 171)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(167, 22)
        Me.DOBDateTimePicker.TabIndex = 13
        '
        'DOJDateTimePicker
        '
        Me.DOJDateTimePicker.Location = New System.Drawing.Point(236, 320)
        Me.DOJDateTimePicker.Name = "DOJDateTimePicker"
        Me.DOJDateTimePicker.Size = New System.Drawing.Size(167, 22)
        Me.DOJDateTimePicker.TabIndex = 14
        '
        'StaffLabel
        '
        Me.StaffLabel.AutoSize = True
        Me.StaffLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.StaffLabel.Location = New System.Drawing.Point(179, 28)
        Me.StaffLabel.Name = "StaffLabel"
        Me.StaffLabel.Size = New System.Drawing.Size(129, 25)
        Me.StaffLabel.TabIndex = 15
        Me.StaffLabel.Text = "Staff Details"
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.UpdateButton.Location = New System.Drawing.Point(257, 434)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(93, 26)
        Me.UpdateButton.TabIndex = 16
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.DeleteButton.Location = New System.Drawing.Point(381, 434)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(93, 26)
        Me.DeleteButton.TabIndex = 17
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'AddStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(514, 493)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.StaffLabel)
        Me.Controls.Add(Me.DOJDateTimePicker)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.PHTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.ERNTextBox)
        Me.Controls.Add(Me.ENTextBox)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.DOJLabel)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.DOBLabel)
        Me.Controls.Add(Me.EpRegisterLabel)
        Me.Controls.Add(Me.EpNameLabel)
        Me.Name = "AddStaffDetails"
        Me.Text = "AddStaffDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EpNameLabel As System.Windows.Forms.Label
    Friend WithEvents EpRegisterLabel As System.Windows.Forms.Label
    Friend WithEvents DOBLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneLabel As System.Windows.Forms.Label
    Friend WithEvents DOJLabel As System.Windows.Forms.Label
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents ENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ERNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DOJDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StaffLabel As System.Windows.Forms.Label
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
End Class
