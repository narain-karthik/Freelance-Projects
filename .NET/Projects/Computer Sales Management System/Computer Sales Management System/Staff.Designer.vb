<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.DOBLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.IDProofTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(53, 33)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(298, 25)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "Computer Sales Management"
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.Location = New System.Drawing.Point(122, 69)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(164, 17)
        Me.AdminLabel.TabIndex = 4
        Me.AdminLabel.Text = "Add Staff Detail Page"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(16, 135)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(49, 17)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneLabel.Location = New System.Drawing.Point(16, 179)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(115, 17)
        Me.PhoneLabel.TabIndex = 6
        Me.PhoneLabel.Text = "Phone Number"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(16, 221)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(67, 17)
        Me.EmailLabel.TabIndex = 7
        Me.EmailLabel.Text = "Email ID"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(16, 263)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(67, 17)
        Me.AddressLabel.TabIndex = 8
        Me.AddressLabel.Text = "Address"
        '
        'DOBLabel
        '
        Me.DOBLabel.AutoSize = True
        Me.DOBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBLabel.Location = New System.Drawing.Point(16, 297)
        Me.DOBLabel.Name = "DOBLabel"
        Me.DOBLabel.Size = New System.Drawing.Size(100, 17)
        Me.DOBLabel.TabIndex = 9
        Me.DOBLabel.Text = "Date of Birth"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel.Location = New System.Drawing.Point(19, 334)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(154, 17)
        Me.IDLabel.TabIndex = 10
        Me.IDLabel.Text = "ID Proof (PAN Card)"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(198, 135)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(153, 22)
        Me.NameTextBox.TabIndex = 11
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(198, 179)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(153, 22)
        Me.PhoneNumberTextBox.TabIndex = 12
        '
        'EmailIDTextBox
        '
        Me.EmailIDTextBox.Location = New System.Drawing.Point(198, 221)
        Me.EmailIDTextBox.Name = "EmailIDTextBox"
        Me.EmailIDTextBox.Size = New System.Drawing.Size(153, 22)
        Me.EmailIDTextBox.TabIndex = 13
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(198, 263)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(153, 22)
        Me.AddressTextBox.TabIndex = 14
        '
        'IDProofTextBox
        '
        Me.IDProofTextBox.Location = New System.Drawing.Point(198, 334)
        Me.IDProofTextBox.Name = "IDProofTextBox"
        Me.IDProofTextBox.Size = New System.Drawing.Size(153, 22)
        Me.IDProofTextBox.TabIndex = 15
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(198, 297)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(153, 22)
        Me.DOBDateTimePicker.TabIndex = 16
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(150, 396)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 17
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 463)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Me.IDProofTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.EmailIDTextBox)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.DOBLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Staff"
        Me.Text = "Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents AdminLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneLabel As System.Windows.Forms.Label
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents DOBLabel As System.Windows.Forms.Label
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDProofTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
End Class
