<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerCreditDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CreditIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCreditLimitTextBox = New System.Windows.Forms.TextBox()
        Me.CreditUsedTextBox = New System.Windows.Forms.TextBox()
        Me.RemainingCreditTextBox = New System.Windows.Forms.TextBox()
        Me.DueAmountTextBox = New System.Windows.Forms.TextBox()
        Me.DueDateTextBox = New System.Windows.Forms.TextBox()
        Me.InterestRateTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentStatusTextBox = New System.Windows.Forms.TextBox()
        Me.LastPaymentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NextPaymentDueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOMER CREDIT DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CREDIT ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CUSTOMER ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TOTAL CREDIT LIMIT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CREDIT USED"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "REMAINING CREDIT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DUE AMOUNT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "DUE DATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "INTEREST RATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "PAYMENT STATUS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(50, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "LAST PAYMENT DATE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(50, 396)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "NEXT PAYMENT DUE DATE"
        '
        'CreditIDTextBox
        '
        Me.CreditIDTextBox.Location = New System.Drawing.Point(256, 72)
        Me.CreditIDTextBox.Name = "CreditIDTextBox"
        Me.CreditIDTextBox.Size = New System.Drawing.Size(172, 22)
        Me.CreditIDTextBox.TabIndex = 12
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(256, 100)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(172, 22)
        Me.CustomerIDTextBox.TabIndex = 13
        '
        'TotalCreditLimitTextBox
        '
        Me.TotalCreditLimitTextBox.Location = New System.Drawing.Point(256, 136)
        Me.TotalCreditLimitTextBox.Name = "TotalCreditLimitTextBox"
        Me.TotalCreditLimitTextBox.Size = New System.Drawing.Size(172, 22)
        Me.TotalCreditLimitTextBox.TabIndex = 14
        '
        'CreditUsedTextBox
        '
        Me.CreditUsedTextBox.Location = New System.Drawing.Point(256, 169)
        Me.CreditUsedTextBox.Name = "CreditUsedTextBox"
        Me.CreditUsedTextBox.Size = New System.Drawing.Size(172, 22)
        Me.CreditUsedTextBox.TabIndex = 15
        '
        'RemainingCreditTextBox
        '
        Me.RemainingCreditTextBox.Location = New System.Drawing.Point(256, 200)
        Me.RemainingCreditTextBox.Name = "RemainingCreditTextBox"
        Me.RemainingCreditTextBox.Size = New System.Drawing.Size(172, 22)
        Me.RemainingCreditTextBox.TabIndex = 16
        '
        'DueAmountTextBox
        '
        Me.DueAmountTextBox.Location = New System.Drawing.Point(256, 238)
        Me.DueAmountTextBox.Name = "DueAmountTextBox"
        Me.DueAmountTextBox.Size = New System.Drawing.Size(172, 22)
        Me.DueAmountTextBox.TabIndex = 17
        '
        'DueDateTextBox
        '
        Me.DueDateTextBox.Location = New System.Drawing.Point(256, 267)
        Me.DueDateTextBox.Name = "DueDateTextBox"
        Me.DueDateTextBox.Size = New System.Drawing.Size(172, 22)
        Me.DueDateTextBox.TabIndex = 18
        '
        'InterestRateTextBox
        '
        Me.InterestRateTextBox.Location = New System.Drawing.Point(256, 303)
        Me.InterestRateTextBox.Name = "InterestRateTextBox"
        Me.InterestRateTextBox.Size = New System.Drawing.Size(172, 22)
        Me.InterestRateTextBox.TabIndex = 19
        '
        'PaymentStatusTextBox
        '
        Me.PaymentStatusTextBox.Location = New System.Drawing.Point(256, 334)
        Me.PaymentStatusTextBox.Name = "PaymentStatusTextBox"
        Me.PaymentStatusTextBox.Size = New System.Drawing.Size(172, 22)
        Me.PaymentStatusTextBox.TabIndex = 20
        '
        'LastPaymentDateDateTimePicker
        '
        Me.LastPaymentDateDateTimePicker.Location = New System.Drawing.Point(256, 365)
        Me.LastPaymentDateDateTimePicker.Name = "LastPaymentDateDateTimePicker"
        Me.LastPaymentDateDateTimePicker.Size = New System.Drawing.Size(172, 22)
        Me.LastPaymentDateDateTimePicker.TabIndex = 21
        '
        'NextPaymentDueDateDateTimePicker
        '
        Me.NextPaymentDueDateDateTimePicker.Location = New System.Drawing.Point(256, 396)
        Me.NextPaymentDueDateDateTimePicker.Name = "NextPaymentDueDateDateTimePicker"
        Me.NextPaymentDueDateDateTimePicker.Size = New System.Drawing.Size(172, 22)
        Me.NextPaymentDueDateDateTimePicker.TabIndex = 22
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(223, 439)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(89, 34)
        Me.SubmitButton.TabIndex = 23
        Me.SubmitButton.Text = "SUBMIT"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CustomerCreditDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 485)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.NextPaymentDueDateDateTimePicker)
        Me.Controls.Add(Me.LastPaymentDateDateTimePicker)
        Me.Controls.Add(Me.PaymentStatusTextBox)
        Me.Controls.Add(Me.InterestRateTextBox)
        Me.Controls.Add(Me.DueDateTextBox)
        Me.Controls.Add(Me.DueAmountTextBox)
        Me.Controls.Add(Me.RemainingCreditTextBox)
        Me.Controls.Add(Me.CreditUsedTextBox)
        Me.Controls.Add(Me.TotalCreditLimitTextBox)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.CreditIDTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CustomerCreditDetails"
        Me.Text = "CustomerCreditDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CreditIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCreditLimitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditUsedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemainingCreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DueAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DueDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InterestRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastPaymentDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NextPaymentDueDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
End Class
