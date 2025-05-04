<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderManagement
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
        Me.OrderIDLabel = New System.Windows.Forms.Label()
        Me.TableIDLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.FoodListLabel = New System.Windows.Forms.Label()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.TableIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.OrderStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.FoodListTextBox = New System.Windows.Forms.TextBox()
        Me.OrderDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TitleLabel.Location = New System.Drawing.Point(50, 20)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(300, 30)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "ORDER MANAGEMENT"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderIDLabel
        '
        Me.OrderIDLabel.AutoSize = True
        Me.OrderIDLabel.Location = New System.Drawing.Point(40, 80)
        Me.OrderIDLabel.Name = "OrderIDLabel"
        Me.OrderIDLabel.Size = New System.Drawing.Size(66, 17)
        Me.OrderIDLabel.TabIndex = 1
        Me.OrderIDLabel.Text = "Order ID:"
        '
        'TableIDLabel
        '
        Me.TableIDLabel.AutoSize = True
        Me.TableIDLabel.Location = New System.Drawing.Point(40, 120)
        Me.TableIDLabel.Name = "TableIDLabel"
        Me.TableIDLabel.Size = New System.Drawing.Size(65, 17)
        Me.TableIDLabel.TabIndex = 2
        Me.TableIDLabel.Text = "Table ID:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(40, 160)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(49, 17)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(40, 200)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(93, 17)
        Me.StatusLabel.TabIndex = 4
        Me.StatusLabel.Text = "Order Status:"
        '
        'FoodListLabel
        '
        Me.FoodListLabel.AutoSize = True
        Me.FoodListLabel.Location = New System.Drawing.Point(40, 240)
        Me.FoodListLabel.Name = "FoodListLabel"
        Me.FoodListLabel.Size = New System.Drawing.Size(70, 17)
        Me.FoodListLabel.TabIndex = 5
        Me.FoodListLabel.Text = "Food List:"
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.Location = New System.Drawing.Point(40, 280)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(118, 17)
        Me.DateTimeLabel.TabIndex = 6
        Me.DateTimeLabel.Text = "Order Date Time:"
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.Location = New System.Drawing.Point(170, 77)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.OrderIDTextBox.TabIndex = 7
        '
        'TableIDTextBox
        '
        Me.TableIDTextBox.Location = New System.Drawing.Point(170, 117)
        Me.TableIDTextBox.Name = "TableIDTextBox"
        Me.TableIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TableIDTextBox.TabIndex = 8
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(170, 157)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NameTextBox.TabIndex = 9
        '
        'OrderStatusComboBox
        '
        Me.OrderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrderStatusComboBox.FormattingEnabled = True
        Me.OrderStatusComboBox.Items.AddRange(New Object() {"Pending", "Preparing", "Served", "Completed", "Cancelled"})
        Me.OrderStatusComboBox.Location = New System.Drawing.Point(170, 197)
        Me.OrderStatusComboBox.Name = "OrderStatusComboBox"
        Me.OrderStatusComboBox.Size = New System.Drawing.Size(200, 24)
        Me.OrderStatusComboBox.TabIndex = 10
        '
        'FoodListTextBox
        '
        Me.FoodListTextBox.Location = New System.Drawing.Point(170, 237)
        Me.FoodListTextBox.Name = "FoodListTextBox"
        Me.FoodListTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FoodListTextBox.TabIndex = 11
        '
        'OrderDateTimePicker
        '
        Me.OrderDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.OrderDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.OrderDateTimePicker.Location = New System.Drawing.Point(170, 277)
        Me.OrderDateTimePicker.Name = "OrderDateTimePicker"
        Me.OrderDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.OrderDateTimePicker.TabIndex = 12
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.LightGreen
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.Location = New System.Drawing.Point(100, 330)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(90, 35)
        Me.SaveButton.TabIndex = 13
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LightCoral
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ClearButton.Location = New System.Drawing.Point(210, 330)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(90, 35)
        Me.ClearButton.TabIndex = 14
        Me.ClearButton.Text = "CLEAR"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'OrderManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(420, 400)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.OrderDateTimePicker)
        Me.Controls.Add(Me.FoodListTextBox)
        Me.Controls.Add(Me.OrderStatusComboBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.TableIDTextBox)
        Me.Controls.Add(Me.OrderIDTextBox)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.FoodListLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.TableIDLabel)
        Me.Controls.Add(Me.OrderIDLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "OrderManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents OrderIDLabel As Label
    Friend WithEvents TableIDLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents FoodListLabel As Label
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents TableIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents OrderStatusComboBox As ComboBox
    Friend WithEvents FoodListTextBox As TextBox
    Friend WithEvents OrderDateTimePicker As DateTimePicker
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearButton As Button
End Class
