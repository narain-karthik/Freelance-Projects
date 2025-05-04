<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoldOut
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
        Me.SoldOutLabel = New System.Windows.Forms.Label()
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.DOPLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.CarModelLabel = New System.Windows.Forms.Label()
        Me.CarpriceLabel = New System.Windows.Forms.Label()
        Me.EngineLabel = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerEmailID = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CarModelComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DOPDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EngineTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SoldOutLabel
        '
        Me.SoldOutLabel.AutoSize = True
        Me.SoldOutLabel.Location = New System.Drawing.Point(151, 33)
        Me.SoldOutLabel.Name = "SoldOutLabel"
        Me.SoldOutLabel.Size = New System.Drawing.Size(136, 17)
        Me.SoldOutLabel.TabIndex = 0
        Me.SoldOutLabel.Text = "Sold Out Car Details"
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = True
        Me.CustomerLabel.Location = New System.Drawing.Point(16, 106)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(109, 17)
        Me.CustomerLabel.TabIndex = 1
        Me.CustomerLabel.Text = "Customer Name"
        '
        'DOPLabel
        '
        Me.DOPLabel.AutoSize = True
        Me.DOPLabel.Location = New System.Drawing.Point(16, 178)
        Me.DOPLabel.Name = "DOPLabel"
        Me.DOPLabel.Size = New System.Drawing.Size(118, 17)
        Me.DOPLabel.TabIndex = 2
        Me.DOPLabel.Text = "Date of Purchase"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(16, 145)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(123, 17)
        Me.EmailLabel.TabIndex = 3
        Me.EmailLabel.Text = "Customer Email ID"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(16, 213)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(103, 17)
        Me.PhoneLabel.TabIndex = 4
        Me.PhoneLabel.Text = "Phone Number"
        '
        'CarModelLabel
        '
        Me.CarModelLabel.AutoSize = True
        Me.CarModelLabel.Location = New System.Drawing.Point(16, 249)
        Me.CarModelLabel.Name = "CarModelLabel"
        Me.CarModelLabel.Size = New System.Drawing.Size(72, 17)
        Me.CarModelLabel.TabIndex = 5
        Me.CarModelLabel.Text = "Car Model"
        '
        'CarpriceLabel
        '
        Me.CarpriceLabel.AutoSize = True
        Me.CarpriceLabel.Location = New System.Drawing.Point(16, 288)
        Me.CarpriceLabel.Name = "CarpriceLabel"
        Me.CarpriceLabel.Size = New System.Drawing.Size(66, 17)
        Me.CarpriceLabel.TabIndex = 6
        Me.CarpriceLabel.Text = "Car Price"
        '
        'EngineLabel
        '
        Me.EngineLabel.AutoSize = True
        Me.EngineLabel.Location = New System.Drawing.Point(16, 321)
        Me.EngineLabel.Name = "EngineLabel"
        Me.EngineLabel.Size = New System.Drawing.Size(106, 17)
        Me.EngineLabel.TabIndex = 7
        Me.EngineLabel.Text = "Engine Number"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(184, 101)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CustomerNameTextBox.TabIndex = 10
        '
        'CustomerEmailID
        '
        Me.CustomerEmailID.Location = New System.Drawing.Point(184, 140)
        Me.CustomerEmailID.Name = "CustomerEmailID"
        Me.CustomerEmailID.Size = New System.Drawing.Size(200, 22)
        Me.CustomerEmailID.TabIndex = 11
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(184, 208)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PhoneNumberTextBox.TabIndex = 12
        '
        'CarModelComboBox
        '
        Me.CarModelComboBox.FormattingEnabled = True
        Me.CarModelComboBox.Items.AddRange(New Object() {"Maruti Alto ", "Maruti Swift ", "Maruti Dzire ", "Maruti Baleno ", "Maruti Vitara Brezza", "Maruti Celerio ", "Maruti Ertiga "})
        Me.CarModelComboBox.Location = New System.Drawing.Point(184, 246)
        Me.CarModelComboBox.Name = "CarModelComboBox"
        Me.CarModelComboBox.Size = New System.Drawing.Size(200, 24)
        Me.CarModelComboBox.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Maruti Alto: ₹3.5 lakh - ₹5.5 lakh", "", "Maruti Swift: ₹6 lakh - ₹8 lakh", "", "Maruti Dzire: ₹6 lakh - ₹9 lakh", "", "Maruti Baleno: ₹7.5 lakh - ₹10 lakh", "", "Maruti Vitara Brezza: ₹8 lakh - ₹12 lakh", "", "Maruti Celerio: ₹5 lakh - ₹7 lakh", "", "Maruti Ertiga: ₹9 lakh - ₹12 lakh"})
        Me.ComboBox1.Location = New System.Drawing.Point(184, 285)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox1.TabIndex = 14
        '
        'DOPDateTimePicker
        '
        Me.DOPDateTimePicker.Location = New System.Drawing.Point(184, 178)
        Me.DOPDateTimePicker.Name = "DOPDateTimePicker"
        Me.DOPDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DOPDateTimePicker.TabIndex = 15
        '
        'EngineTextBox
        '
        Me.EngineTextBox.Location = New System.Drawing.Point(184, 318)
        Me.EngineTextBox.Name = "EngineTextBox"
        Me.EngineTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EngineTextBox.TabIndex = 16
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(184, 381)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 17
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SoldOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.EngineTextBox)
        Me.Controls.Add(Me.DOPDateTimePicker)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CarModelComboBox)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.CustomerEmailID)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.EngineLabel)
        Me.Controls.Add(Me.CarpriceLabel)
        Me.Controls.Add(Me.CarModelLabel)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.DOPLabel)
        Me.Controls.Add(Me.CustomerLabel)
        Me.Controls.Add(Me.SoldOutLabel)
        Me.Name = "SoldOut"
        Me.Text = "SoldOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SoldOutLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerLabel As System.Windows.Forms.Label
    Friend WithEvents DOPLabel As System.Windows.Forms.Label
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneLabel As System.Windows.Forms.Label
    Friend WithEvents CarModelLabel As System.Windows.Forms.Label
    Friend WithEvents CarpriceLabel As System.Windows.Forms.Label
    Friend WithEvents EngineLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerEmailID As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarModelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DOPDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EngineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
