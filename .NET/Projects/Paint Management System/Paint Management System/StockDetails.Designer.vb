<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockDetails
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
        Me.LabelStockIn = New System.Windows.Forms.Label()
        Me.LabelStockOut = New System.Windows.Forms.Label()
        Me.LabelBalance = New System.Windows.Forms.Label()
        Me.TextBoxSNo = New System.Windows.Forms.TextBox()
        Me.TextBoxProductID = New System.Windows.Forms.TextBox()
        Me.ComboBoxProductName = New System.Windows.Forms.ComboBox()
        Me.TextBoxStockIn = New System.Windows.Forms.TextBox()
        Me.TextBoxStockOut = New System.Windows.Forms.TextBox()
        Me.TextBoxBalance = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DataGridViewStock = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewStock, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelStockIn
        '
        Me.LabelStockIn.AutoSize = True
        Me.LabelStockIn.Location = New System.Drawing.Point(12, 110)
        Me.LabelStockIn.Name = "LabelStockIn"
        Me.LabelStockIn.Size = New System.Drawing.Size(62, 17)
        Me.LabelStockIn.TabIndex = 3
        Me.LabelStockIn.Text = "Stock In:"
        '
        'LabelStockOut
        '
        Me.LabelStockOut.AutoSize = True
        Me.LabelStockOut.Location = New System.Drawing.Point(12, 140)
        Me.LabelStockOut.Name = "LabelStockOut"
        Me.LabelStockOut.Size = New System.Drawing.Size(74, 17)
        Me.LabelStockOut.TabIndex = 4
        Me.LabelStockOut.Text = "Stock Out:"
        '
        'LabelBalance
        '
        Me.LabelBalance.AutoSize = True
        Me.LabelBalance.Location = New System.Drawing.Point(12, 170)
        Me.LabelBalance.Name = "LabelBalance"
        Me.LabelBalance.Size = New System.Drawing.Size(63, 17)
        Me.LabelBalance.TabIndex = 5
        Me.LabelBalance.Text = "Balance:"
        '
        'TextBoxSNo
        '
        Me.TextBoxSNo.Location = New System.Drawing.Point(130, 17)
        Me.TextBoxSNo.Name = "TextBoxSNo"
        Me.TextBoxSNo.ReadOnly = True
        Me.TextBoxSNo.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxSNo.TabIndex = 6
        '
        'TextBoxProductID
        '
        Me.TextBoxProductID.Location = New System.Drawing.Point(130, 47)
        Me.TextBoxProductID.Name = "TextBoxProductID"
        Me.TextBoxProductID.ReadOnly = True
        Me.TextBoxProductID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxProductID.TabIndex = 7
        '
        'ComboBoxProductName
        '
        Me.ComboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProductName.Location = New System.Drawing.Point(130, 77)
        Me.ComboBoxProductName.Name = "ComboBoxProductName"
        Me.ComboBoxProductName.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxProductName.TabIndex = 8
        '
        'TextBoxStockIn
        '
        Me.TextBoxStockIn.Location = New System.Drawing.Point(130, 107)
        Me.TextBoxStockIn.Name = "TextBoxStockIn"
        Me.TextBoxStockIn.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxStockIn.TabIndex = 9
        '
        'TextBoxStockOut
        '
        Me.TextBoxStockOut.Location = New System.Drawing.Point(130, 137)
        Me.TextBoxStockOut.Name = "TextBoxStockOut"
        Me.TextBoxStockOut.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxStockOut.TabIndex = 10
        '
        'TextBoxBalance
        '
        Me.TextBoxBalance.Location = New System.Drawing.Point(130, 167)
        Me.TextBoxBalance.Name = "TextBoxBalance"
        Me.TextBoxBalance.ReadOnly = True
        Me.TextBoxBalance.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxBalance.TabIndex = 11
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(130, 200)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(80, 30)
        Me.ButtonAdd.TabIndex = 12
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(220, 200)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(80, 30)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'DataGridViewStock
        '
        Me.DataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStock.Location = New System.Drawing.Point(12, 240)
        Me.DataGridViewStock.Name = "DataGridViewStock"
        Me.DataGridViewStock.Size = New System.Drawing.Size(576, 200)
        Me.DataGridViewStock.TabIndex = 14
        '
        'StockDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.DataGridViewStock)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxBalance)
        Me.Controls.Add(Me.TextBoxStockOut)
        Me.Controls.Add(Me.TextBoxStockIn)
        Me.Controls.Add(Me.ComboBoxProductName)
        Me.Controls.Add(Me.TextBoxProductID)
        Me.Controls.Add(Me.TextBoxSNo)
        Me.Controls.Add(Me.LabelBalance)
        Me.Controls.Add(Me.LabelStockOut)
        Me.Controls.Add(Me.LabelStockIn)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LabelProductID)
        Me.Controls.Add(Me.LabelSNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StockDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Details - Painting Management System"
        CType(Me.DataGridViewStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSNo As System.Windows.Forms.Label
    Friend WithEvents LabelProductID As System.Windows.Forms.Label
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelStockIn As System.Windows.Forms.Label
    Friend WithEvents LabelStockOut As System.Windows.Forms.Label
    Friend WithEvents LabelBalance As System.Windows.Forms.Label
    Friend WithEvents TextBoxSNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProductID As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxProductName As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxStockIn As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStockOut As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBalance As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewStock As System.Windows.Forms.DataGridView
End Class