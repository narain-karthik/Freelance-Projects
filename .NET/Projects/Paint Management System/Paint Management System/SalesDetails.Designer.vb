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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelSNo = New System.Windows.Forms.Label()
        Me.LabelProductID = New System.Windows.Forms.Label()
        Me.LabelCustomerID = New System.Windows.Forms.Label()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelSaleDate = New System.Windows.Forms.Label()
        Me.LabelQuantity = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.TextBoxSNo = New System.Windows.Forms.TextBox()
        Me.TextBoxProductID = New System.Windows.Forms.TextBox()
        Me.TextBoxCustomerID = New System.Windows.Forms.TextBox()
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox()
        Me.ComboBoxProductName = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DataGridViewSales = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelCustomerID
        '
        Me.LabelCustomerID.AutoSize = True
        Me.LabelCustomerID.Location = New System.Drawing.Point(12, 80)
        Me.LabelCustomerID.Name = "LabelCustomerID"
        Me.LabelCustomerID.Size = New System.Drawing.Size(89, 17)
        Me.LabelCustomerID.TabIndex = 2
        Me.LabelCustomerID.Text = "Customer ID:"
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Location = New System.Drawing.Point(12, 110)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(113, 17)
        Me.LabelCustomerName.TabIndex = 3
        Me.LabelCustomerName.Text = "Customer Name:"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(12, 140)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(102, 17)
        Me.LabelProductName.TabIndex = 4
        Me.LabelProductName.Text = "Product Name:"
        '
        'LabelSaleDate
        '
        Me.LabelSaleDate.AutoSize = True
        Me.LabelSaleDate.Location = New System.Drawing.Point(12, 170)
        Me.LabelSaleDate.Name = "LabelSaleDate"
        Me.LabelSaleDate.Size = New System.Drawing.Size(74, 17)
        Me.LabelSaleDate.TabIndex = 5
        Me.LabelSaleDate.Text = "Sale Date:"
        '
        'LabelQuantity
        '
        Me.LabelQuantity.AutoSize = True
        Me.LabelQuantity.Location = New System.Drawing.Point(12, 200)
        Me.LabelQuantity.Name = "LabelQuantity"
        Me.LabelQuantity.Size = New System.Drawing.Size(65, 17)
        Me.LabelQuantity.TabIndex = 6
        Me.LabelQuantity.Text = "Quantity:"
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Location = New System.Drawing.Point(12, 230)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(44, 17)
        Me.LabelPrice.TabIndex = 7
        Me.LabelPrice.Text = "Price:"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(12, 260)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(44, 17)
        Me.LabelTotal.TabIndex = 8
        Me.LabelTotal.Text = "Total:"
        '
        'TextBoxSNo
        '
        Me.TextBoxSNo.Location = New System.Drawing.Point(130, 17)
        Me.TextBoxSNo.Name = "TextBoxSNo"
        Me.TextBoxSNo.ReadOnly = True
        Me.TextBoxSNo.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxSNo.TabIndex = 9
        '
        'TextBoxProductID
        '
        Me.TextBoxProductID.Location = New System.Drawing.Point(130, 47)
        Me.TextBoxProductID.Name = "TextBoxProductID"
        Me.TextBoxProductID.ReadOnly = True
        Me.TextBoxProductID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxProductID.TabIndex = 10
        '
        'TextBoxCustomerID
        '
        Me.TextBoxCustomerID.Location = New System.Drawing.Point(130, 77)
        Me.TextBoxCustomerID.Name = "TextBoxCustomerID"
        Me.TextBoxCustomerID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCustomerID.TabIndex = 11
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(130, 107)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.ReadOnly = True
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxCustomerName.TabIndex = 12
        '
        'ComboBoxProductName
        '
        Me.ComboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProductName.Location = New System.Drawing.Point(130, 137)
        Me.ComboBoxProductName.Name = "ComboBoxProductName"
        Me.ComboBoxProductName.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxProductName.TabIndex = 13
        '
        'DateTimePickerSaleDate
        '
        Me.DateTimePickerSaleDate.Location = New System.Drawing.Point(130, 167)
        Me.DateTimePickerSaleDate.Name = "DateTimePickerSaleDate"
        Me.DateTimePickerSaleDate.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerSaleDate.TabIndex = 14
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(130, 197)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxQuantity.TabIndex = 15
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(130, 227)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.ReadOnly = True
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPrice.TabIndex = 16
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(130, 257)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotal.TabIndex = 17
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(130, 290)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(80, 30)
        Me.ButtonAdd.TabIndex = 18
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(220, 290)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(80, 30)
        Me.ButtonSave.TabIndex = 19
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'DataGridViewSales
        '
        Me.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSales.Location = New System.Drawing.Point(12, 330)
        Me.DataGridViewSales.Name = "DataGridViewSales"
        Me.DataGridViewSales.Size = New System.Drawing.Size(576, 150)
        Me.DataGridViewSales.TabIndex = 20
        '
        'SalesDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 490)
        Me.Controls.Add(Me.DataGridViewSales)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.TextBoxQuantity)
        Me.Controls.Add(Me.DateTimePickerSaleDate)
        Me.Controls.Add(Me.ComboBoxProductName)
        Me.Controls.Add(Me.TextBoxCustomerName)
        Me.Controls.Add(Me.TextBoxCustomerID)
        Me.Controls.Add(Me.TextBoxProductID)
        Me.Controls.Add(Me.TextBoxSNo)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.LabelQuantity)
        Me.Controls.Add(Me.LabelSaleDate)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Controls.Add(Me.LabelCustomerID)
        Me.Controls.Add(Me.LabelProductID)
        Me.Controls.Add(Me.LabelSNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SalesDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Details - Painting Management System"
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSNo As System.Windows.Forms.Label
    Friend WithEvents LabelProductID As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerID As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelSaleDate As System.Windows.Forms.Label
    Friend WithEvents LabelQuantity As System.Windows.Forms.Label
    Friend WithEvents LabelPrice As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents TextBoxSNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProductID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxProductName As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerSaleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewSales As System.Windows.Forms.DataGridView
End Class