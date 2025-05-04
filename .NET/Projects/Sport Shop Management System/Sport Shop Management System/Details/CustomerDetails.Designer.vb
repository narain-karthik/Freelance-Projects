<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetails
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxPhone = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.LabelDOB = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelPhone = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.SaveButton)
        Me.MainPanel.Controls.Add(Me.DOBPicker)
        Me.MainPanel.Controls.Add(Me.TextBoxAddress)
        Me.MainPanel.Controls.Add(Me.TextBoxPhone)
        Me.MainPanel.Controls.Add(Me.TextBoxName)
        Me.MainPanel.Controls.Add(Me.TextBoxID)
        Me.MainPanel.Controls.Add(Me.LabelDOB)
        Me.MainPanel.Controls.Add(Me.LabelAddress)
        Me.MainPanel.Controls.Add(Me.LabelPhone)
        Me.MainPanel.Controls.Add(Me.LabelName)
        Me.MainPanel.Controls.Add(Me.LabelID)
        Me.MainPanel.Controls.Add(Me.LabelTitle)
        Me.MainPanel.Location = New System.Drawing.Point(30, 30)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(500, 450)
        Me.MainPanel.TabIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(180, 360)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(140, 40)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'DOBPicker
        '
        Me.DOBPicker.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBPicker.Location = New System.Drawing.Point(200, 287)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(230, 30)
        Me.DOBPicker.TabIndex = 10
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBoxAddress.Location = New System.Drawing.Point(200, 237)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(230, 30)
        Me.TextBoxAddress.TabIndex = 9
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBoxPhone.Location = New System.Drawing.Point(200, 187)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(230, 30)
        Me.TextBoxPhone.TabIndex = 8
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBoxName.Location = New System.Drawing.Point(200, 137)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(230, 30)
        Me.TextBoxName.TabIndex = 7
        '
        'TextBoxID
        '
        Me.TextBoxID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBoxID.Location = New System.Drawing.Point(200, 87)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(230, 30)
        Me.TextBoxID.TabIndex = 6
        '
        'LabelDOB
        '
        Me.LabelDOB.AutoSize = True
        Me.LabelDOB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelDOB.Location = New System.Drawing.Point(50, 290)
        Me.LabelDOB.Name = "LabelDOB"
        Me.LabelDOB.Size = New System.Drawing.Size(111, 23)
        Me.LabelDOB.TabIndex = 5
        Me.LabelDOB.Text = "Date of Birth:"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelAddress.Location = New System.Drawing.Point(50, 240)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(74, 23)
        Me.LabelAddress.TabIndex = 4
        Me.LabelAddress.Text = "Address:"
        '
        'LabelPhone
        '
        Me.LabelPhone.AutoSize = True
        Me.LabelPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelPhone.Location = New System.Drawing.Point(50, 190)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(131, 23)
        Me.LabelPhone.TabIndex = 3
        Me.LabelPhone.Text = "Phone Number:"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelName.Location = New System.Drawing.Point(50, 140)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(60, 23)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Name:"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelID.Location = New System.Drawing.Point(50, 90)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(110, 23)
        Me.LabelID.TabIndex = 1
        Me.LabelID.Text = "Customer ID:"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelTitle.Location = New System.Drawing.Point(130, 20)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(258, 41)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Customer Details"
        '
        'CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(560, 510)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "CustomerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelDOB As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents DOBPicker As DateTimePicker
    Friend WithEvents SaveButton As Button
End Class
