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
        Me.components = New System.ComponentModel.Container()
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
        Me.LabelSNo.Size = New System.Drawing.Size(39, 16)
        Me.LabelSNo.TabIndex = 0
        Me.LabelSNo.Text = "S.No:"
        '
        'LabelProductID
        '
        Me.LabelProductID.AutoSize = True
        Me.LabelProductID.Location = New System.Drawing.Point(12, 50)
        Me.LabelProductID.Name = "LabelProductID"
        Me.LabelProductID.Size = New System.Drawing.Size(70, 16)
        Me.LabelProductID.TabIndex = 1
        Me.LabelProductID.Text = "Product ID:"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(12, 80)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(94, 16)
        Me.LabelProductName.TabIndex = 2
        Me.LabelProductName.Text = "Product Name:"
        '
        'LabelPurchaseDate
        '
        Me.LabelPurchaseDate.AutoSize = True
        Me.LabelPurchaseDate.Location = New System.Drawing.Point(12, 110)
        Me.LabelPurchaseDate.Name = "LabelPurchaseDate"
        Me.LabelPurchaseDate.Size = New System.Drawing.Size(95, 16)
        Me.LabelPurchaseDate.TabIndex = 3
        Me.LabelPurchaseDate.Text = "Purchase Date:"
        '
        'LabelQuantity
        '
        Me.LabelQuantity.AutoSize = True
        Me.LabelQuantity.Location = New System.Drawing.Point(12, 140)
        Me.LabelQuantity.Name = "LabelQuantity"
        Me.LabelQuantity.Size = New System.Drawing.Size(62, 16)
        Me.LabelQuantity.TabIndex = 4
        Me.LabelQuantity.Text = "Quantity:"
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Location = New System.Drawing.Point(12, 170)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(43, 16)
        Me.LabelPrice.TabIndex = 5
        Me.LabelPrice.Text = "Price:"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(12, 200)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(43, 16)
        Me.LabelTotal.TabIndex = 6
        Me.LabelTotal.Text = "Total:"
        '
        'TextBoxSNo
        '
        Me.TextBoxSNo.Location = New System.Drawing.Point(120, 17)
        Me.TextBoxSNo.Name = "TextBoxSNo"
        Me.TextBoxSNo.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxSNo.TabIndex = 7
        '
        'TextBoxProductID
        '
        Me.TextBoxProductID.Location = New System.Drawing.Point(120, 47)
        Me.TextBoxProductID.Name = "TextBoxProductID"
        Me.TextBoxProductID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxProductID.TabIndex = 8
        Me.TextBoxProductID.ReadOnly = True ' Auto-generated
        '
        'ComboBoxProductName
        '
        Me.ComboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProductName.Location = New System.Drawing.Point(120, 77)
        Me.ComboBoxProductName.Name = "ComboBoxProductName"
        Me.ComboBoxProductName.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxProductName.TabIndex = 9
        '
        'DateTimePickerPurchaseDate
        '
        Me.DateTimePickerPurchaseDate.Location = New System.Drawing.Point(120, 107)
        Me.DateTimePickerPurchaseDate.Name = "DateTimePickerPurchaseDate"
        Me.DateTimePickerPurchaseDate.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerPurchaseDate.TabIndex = 10
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(120, 137)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxQuantity.TabIndex = 11
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(120, 167)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPrice.TabIndex = 12
        Me.TextBoxPrice.ReadOnly = True ' Auto-set based on product
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(120, 197)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTotal.TabIndex = 13
        Me.TextBoxTotal.ReadOnly = True ' Calculated
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(120, 230)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(80, 30)
        Me.ButtonAdd.TabIndex = 14
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(210, 230)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(80, 30)
        Me.ButtonSave.TabIndex = 15
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
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
        Me.Text = "Purchase Details - Painting Management System"
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