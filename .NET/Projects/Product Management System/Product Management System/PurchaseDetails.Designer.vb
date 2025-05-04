<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseDetails
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
        Me.LabelSNo = New System.Windows.Forms.Label()
        Me.LabelProductID = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelPurchaseDate = New System.Windows.Forms.Label()
        Me.LabelQuantity = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.TextBoxSNo = New System.Windows.Forms.TextBox()
        Me.TextBoxProductID = New System.Windows.Forms.TextBox()
        Me.ComboBoxProductName = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerPurchaseDate = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DataGridViewPurchases = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelSNo
        '
        Me.LabelSNo.AutoSize = True
        Me.LabelSNo.Location = New System.Drawing.Point(12, 20)
        Me.LabelSNo.Name = "LabelSNo"
        Me.LabelSNo.Size = New System.Drawing.Size(43, 17)
        Me.LabelSNo.TabIndex = 0
        Me.LabelSNo.Text = "S.No:"
        '
        'LabelProductID
        '
        Me.LabelProductID.AutoSize = True
        Me.LabelProductID.Location = New System.Drawing.Point(12, 50)
        Me.LabelProductID.Name = "LabelProductID"
        Me.LabelProductID.Size = New System.Drawing.Size(78, 17)
        Me.LabelProductID.TabIndex = 1
        Me.LabelProductID.Text = "Product ID:"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(12, 80)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(102, 17)
        Me.LabelProductName.TabIndex = 2
        Me.LabelProductName.Text = "Product Name:"
        '
        'LabelPurchaseDate
        '
        Me.LabelPurchaseDate.AutoSize = True
        Me.LabelPurchaseDate.Location = New System.Drawing.Point(12, 110)
        Me.LabelPurchaseDate.Name = "LabelPurchaseDate"
        Me.LabelPurchaseDate.Size = New System.Drawing.Size(106, 17)
        Me.LabelPurchaseDate.TabIndex = 3
        Me.LabelPurchaseDate.Text = "Purchase Date:"
        '
        'LabelQuantity
        '
        Me.LabelQuantity.AutoSize = True
        Me.LabelQuantity.Location = New System.Drawing.Point(12, 140)
        Me.LabelQuantity.Name = "LabelQuantity"
        Me.LabelQuantity.Size = New System.Drawing.Size(96, 17)
        Me.LabelQuantity.TabIndex = 4
        Me.LabelQuantity.Text = "Quantity (Kg):"
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Location = New System.Drawing.Point(12, 170)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(87, 17)
        Me.LabelPrice.TabIndex = 5
        Me.LabelPrice.Text = "Price (₹/Kg):"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(12, 200)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(66, 17)
        Me.LabelTotal.TabIndex = 6
        Me.LabelTotal.Text = "Total (₹):"
        '
        'TextBoxSNo
        '
        Me.TextBoxSNo.Location = New System.Drawing.Point(130, 17)
        Me.TextBoxSNo.Name = "TextBoxSNo"
        Me.TextBoxSNo.ReadOnly = True
        Me.TextBoxSNo.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxSNo.TabIndex = 7
        '
        'TextBoxProductID
        '
        Me.TextBoxProductID.Location = New System.Drawing.Point(130, 47)
        Me.TextBoxProductID.Name = "TextBoxProductID"
        Me.TextBoxProductID.ReadOnly = True
        Me.TextBoxProductID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxProductID.TabIndex = 8
        '
        'ComboBoxProductName
        '
        Me.ComboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProductName.Location = New System.Drawing.Point(130, 77)
        Me.ComboBoxProductName.Name = "ComboBoxProductName"
        Me.ComboBoxProductName.Size = New System.Drawing.Size(300, 24)
        Me.ComboBoxProductName.TabIndex = 9
        '
        'DateTimePickerPurchaseDate
        '
        Me.DateTimePickerPurchaseDate.Location = New System.Drawing.Point(130, 107)
        Me.DateTimePickerPurchaseDate.Name = "DateTimePickerPurchaseDate"
        Me.DateTimePickerPurchaseDate.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerPurchaseDate.TabIndex = 10
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(130, 137)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxQuantity.TabIndex = 11
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(130, 167)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.ReadOnly = True
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPrice.TabIndex = 12
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(130, 197)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotal.TabIndex = 13
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Location = New System.Drawing.Point(130, 230)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(80, 30)
        Me.ButtonAdd.TabIndex = 14
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(220, 230)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(80, 30)
        Me.ButtonSave.TabIndex = 15
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'DataGridViewPurchases
        '
        Me.DataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPurchases.Location = New System.Drawing.Point(12, 270)
        Me.DataGridViewPurchases.Name = "DataGridViewPurchases"
        Me.DataGridViewPurchases.Size = New System.Drawing.Size(576, 200)
        Me.DataGridViewPurchases.TabIndex = 16
        '
        'PurchaseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 480)
        Me.Controls.Add(Me.DataGridViewPurchases)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.TextBoxQuantity)
        Me.Controls.Add(Me.DateTimePickerPurchaseDate)
        Me.Controls.Add(Me.ComboBoxProductName)
        Me.Controls.Add(Me.TextBoxProductID)
        Me.Controls.Add(Me.TextBoxSNo)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.LabelQuantity)
        Me.Controls.Add(Me.LabelPurchaseDate)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LabelProductID)
        Me.Controls.Add(Me.LabelSNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PurchaseDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Details - Product Management System"
        CType(Me.DataGridViewPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSNo As System.Windows.Forms.Label
    Friend WithEvents LabelProductID As System.Windows.Forms.Label
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelPurchaseDate As System.Windows.Forms.Label
    Friend WithEvents LabelQuantity As System.Windows.Forms.Label
    Friend WithEvents LabelPrice As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents TextBoxSNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProductID As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxProductName As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerPurchaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewPurchases As System.Windows.Forms.DataGridView
End Class