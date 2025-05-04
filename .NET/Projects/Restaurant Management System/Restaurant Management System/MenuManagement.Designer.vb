<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuManagement
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ItemIDLabel = New System.Windows.Forms.Label()
        Me.ItemNameLabel = New System.Windows.Forms.Label()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.Location = New System.Drawing.Point(50, 20)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(300, 40)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Menu Management"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemIDLabel
        '
        Me.ItemIDLabel.AutoSize = True
        Me.ItemIDLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ItemIDLabel.Location = New System.Drawing.Point(30, 90)
        Me.ItemIDLabel.Name = "ItemIDLabel"
        Me.ItemIDLabel.Size = New System.Drawing.Size(67, 23)
        Me.ItemIDLabel.TabIndex = 1
        Me.ItemIDLabel.Text = "Item ID"
        '
        'ItemNameLabel
        '
        Me.ItemNameLabel.AutoSize = True
        Me.ItemNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ItemNameLabel.Location = New System.Drawing.Point(30, 140)
        Me.ItemNameLabel.Name = "ItemNameLabel"
        Me.ItemNameLabel.Size = New System.Drawing.Size(96, 23)
        Me.ItemNameLabel.TabIndex = 2
        Me.ItemNameLabel.Text = "Item Name"
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CategoryLabel.Location = New System.Drawing.Point(30, 190)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(79, 23)
        Me.CategoryLabel.TabIndex = 3
        Me.CategoryLabel.Text = "Category"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PriceLabel.Location = New System.Drawing.Point(30, 240)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(47, 23)
        Me.PriceLabel.TabIndex = 4
        Me.PriceLabel.Text = "Price"
        '
        'ItemIDTextBox
        '
        Me.ItemIDTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ItemIDTextBox.Location = New System.Drawing.Point(140, 90)
        Me.ItemIDTextBox.Name = "ItemIDTextBox"
        Me.ItemIDTextBox.Size = New System.Drawing.Size(200, 30)
        Me.ItemIDTextBox.TabIndex = 5
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ItemNameTextBox.Location = New System.Drawing.Point(140, 140)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(200, 30)
        Me.ItemNameTextBox.TabIndex = 6
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PriceTextBox.Location = New System.Drawing.Point(140, 240)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 30)
        Me.PriceTextBox.TabIndex = 7
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"Starter", "Main Course", "Dessert", "Beverage"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(140, 190)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(200, 31)
        Me.CategoryComboBox.TabIndex = 8
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(120, 310)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(120, 45)
        Me.SaveButton.TabIndex = 9
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'MenuManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.ItemIDTextBox)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.CategoryLabel)
        Me.Controls.Add(Me.ItemNameLabel)
        Me.Controls.Add(Me.ItemIDLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MenuManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents ItemIDLabel As Label
    Friend WithEvents ItemNameLabel As Label
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents ItemIDTextBox As TextBox
    Friend WithEvents ItemNameTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents SaveButton As Button
End Class
