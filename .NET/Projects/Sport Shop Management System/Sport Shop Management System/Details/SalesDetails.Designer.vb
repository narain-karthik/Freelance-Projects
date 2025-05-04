<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesDetails
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

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SalesIDLabel = New System.Windows.Forms.Label()
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.PurchaseDateLabel = New System.Windows.Forms.Label()
        Me.ItemsLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.SalesIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ItemsComboBox = New System.Windows.Forms.ComboBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TotalAmountLabel = New System.Windows.Forms.Label()
        Me.TotalAmountTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.Location = New System.Drawing.Point(95, 20)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(178, 37)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Sales Details"
        '
        'SalesIDLabel
        '
        Me.SalesIDLabel.AutoSize = True
        Me.SalesIDLabel.Location = New System.Drawing.Point(15, 30)
        Me.SalesIDLabel.Name = "SalesIDLabel"
        Me.SalesIDLabel.Size = New System.Drawing.Size(70, 23)
        Me.SalesIDLabel.TabIndex = 0
        Me.SalesIDLabel.Text = "Sales ID"
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Location = New System.Drawing.Point(15, 70)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(106, 23)
        Me.CustomerIDLabel.TabIndex = 2
        Me.CustomerIDLabel.Text = "Customer ID"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(15, 110)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(56, 23)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(15, 150)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(70, 23)
        Me.AddressLabel.TabIndex = 6
        Me.AddressLabel.Text = "Address"
        '
        'PurchaseDateLabel
        '
        Me.PurchaseDateLabel.AutoSize = True
        Me.PurchaseDateLabel.Location = New System.Drawing.Point(15, 190)
        Me.PurchaseDateLabel.Name = "PurchaseDateLabel"
        Me.PurchaseDateLabel.Size = New System.Drawing.Size(120, 23)
        Me.PurchaseDateLabel.TabIndex = 8
        Me.PurchaseDateLabel.Text = "Purchase Date"
        '
        'ItemsLabel
        '
        Me.ItemsLabel.AutoSize = True
        Me.ItemsLabel.Location = New System.Drawing.Point(15, 230)
        Me.ItemsLabel.Name = "ItemsLabel"
        Me.ItemsLabel.Size = New System.Drawing.Size(52, 23)
        Me.ItemsLabel.TabIndex = 10
        Me.ItemsLabel.Text = "Items"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(15, 270)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(72, 23)
        Me.AmountLabel.TabIndex = 12
        Me.AmountLabel.Text = "Amount"
        '
        'SalesIDTextBox
        '
        Me.SalesIDTextBox.Location = New System.Drawing.Point(150, 27)
        Me.SalesIDTextBox.Name = "SalesIDTextBox"
        Me.SalesIDTextBox.Size = New System.Drawing.Size(170, 30)
        Me.SalesIDTextBox.TabIndex = 1
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(150, 67)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(170, 30)
        Me.CustomerIDTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(150, 107)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(170, 30)
        Me.NameTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(150, 147)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(170, 30)
        Me.AddressTextBox.TabIndex = 7
        '
        'PurchaseDateTimePicker
        '
        Me.PurchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PurchaseDateTimePicker.Location = New System.Drawing.Point(150, 187)
        Me.PurchaseDateTimePicker.Name = "PurchaseDateTimePicker"
        Me.PurchaseDateTimePicker.Size = New System.Drawing.Size(170, 30)
        Me.PurchaseDateTimePicker.TabIndex = 9
        '
        'ItemsComboBox
        '
        Me.ItemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ItemsComboBox.FormattingEnabled = True
        Me.ItemsComboBox.Location = New System.Drawing.Point(150, 227)
        Me.ItemsComboBox.Name = "ItemsComboBox"
        Me.ItemsComboBox.Size = New System.Drawing.Size(170, 31)
        Me.ItemsComboBox.TabIndex = 11
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(150, 267)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(170, 30)
        Me.AmountTextBox.TabIndex = 13
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(15, 310)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(76, 23)
        Me.QuantityLabel.TabIndex = 14
        Me.QuantityLabel.Text = "Quantity"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(150, 307)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(170, 30)
        Me.QuantityTextBox.TabIndex = 15
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.AutoSize = True
        Me.TotalAmountLabel.Location = New System.Drawing.Point(15, 350)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(113, 23)
        Me.TotalAmountLabel.TabIndex = 16
        Me.TotalAmountLabel.Text = "Total Amount"
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(150, 347)
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.ReadOnly = True
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(170, 30)
        Me.TotalAmountTextBox.TabIndex = 17
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(140, 460)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(120, 40)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SalesIDLabel)
        Me.GroupBox1.Controls.Add(Me.SalesIDTextBox)
        Me.GroupBox1.Controls.Add(Me.CustomerIDLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerIDTextBox)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.PurchaseDateLabel)
        Me.GroupBox1.Controls.Add(Me.PurchaseDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.ItemsLabel)
        Me.GroupBox1.Controls.Add(Me.ItemsComboBox)
        Me.GroupBox1.Controls.Add(Me.AmountLabel)
        Me.GroupBox1.Controls.Add(Me.AmountTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.TotalAmountLabel)
        Me.GroupBox1.Controls.Add(Me.TotalAmountTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 400)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Sales Information"
        '
        'SalesDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(400, 520)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TitleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SalesDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents SalesIDLabel As Label
    Friend WithEvents CustomerIDLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents PurchaseDateLabel As Label
    Friend WithEvents ItemsLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents SalesIDTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PurchaseDateTimePicker As DateTimePicker
    Friend WithEvents ItemsComboBox As ComboBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents TotalAmountLabel As Label
    Friend WithEvents TotalAmountTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
