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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ItemCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.PuchaseQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SalesQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.StockQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WoodDataSet5 = New Wood_Craft.WoodDataSet5()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New Wood_Craft.WoodDataSet5TableAdapters.StockTableAdapter()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WoodDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wood Craft Stock Details Page"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Puchase Quantity "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sales Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stock Quantity"
        '
        'ItemCodeTextBox
        '
        Me.ItemCodeTextBox.Location = New System.Drawing.Point(459, 102)
        Me.ItemCodeTextBox.Name = "ItemCodeTextBox"
        Me.ItemCodeTextBox.Size = New System.Drawing.Size(155, 22)
        Me.ItemCodeTextBox.TabIndex = 6
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.Location = New System.Drawing.Point(459, 151)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(155, 22)
        Me.ItemNameTextBox.TabIndex = 7
        '
        'PuchaseQuantityTextBox
        '
        Me.PuchaseQuantityTextBox.Location = New System.Drawing.Point(459, 204)
        Me.PuchaseQuantityTextBox.Name = "PuchaseQuantityTextBox"
        Me.PuchaseQuantityTextBox.Size = New System.Drawing.Size(155, 22)
        Me.PuchaseQuantityTextBox.TabIndex = 8
        '
        'SalesQuantityTextBox
        '
        Me.SalesQuantityTextBox.Location = New System.Drawing.Point(459, 248)
        Me.SalesQuantityTextBox.Name = "SalesQuantityTextBox"
        Me.SalesQuantityTextBox.Size = New System.Drawing.Size(155, 22)
        Me.SalesQuantityTextBox.TabIndex = 9
        '
        'StockQuantityTextBox
        '
        Me.StockQuantityTextBox.Location = New System.Drawing.Point(459, 290)
        Me.StockQuantityTextBox.Name = "StockQuantityTextBox"
        Me.StockQuantityTextBox.Size = New System.Drawing.Size(155, 22)
        Me.StockQuantityTextBox.TabIndex = 10
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(757, 100)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 37)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(757, 171)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 37)
        Me.UpdateButton.TabIndex = 12
        Me.UpdateButton.Text = "Edit"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(757, 243)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 37)
        Me.DeleteButton.TabIndex = 13
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(757, 310)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 37)
        Me.CancelButton.TabIndex = 14
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.PurchaseQuantityDataGridViewTextBoxColumn, Me.SalesQuantityDataGridViewTextBoxColumn, Me.StockQuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StockBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(265, 375)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(541, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'WoodDataSet5
        '
        Me.WoodDataSet5.DataSetName = "WoodDataSet5"
        Me.WoodDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.WoodDataSet5
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        '
        'PurchaseQuantityDataGridViewTextBoxColumn
        '
        Me.PurchaseQuantityDataGridViewTextBoxColumn.DataPropertyName = "PurchaseQuantity"
        Me.PurchaseQuantityDataGridViewTextBoxColumn.HeaderText = "PurchaseQuantity"
        Me.PurchaseQuantityDataGridViewTextBoxColumn.Name = "PurchaseQuantityDataGridViewTextBoxColumn"
        '
        'SalesQuantityDataGridViewTextBoxColumn
        '
        Me.SalesQuantityDataGridViewTextBoxColumn.DataPropertyName = "SalesQuantity"
        Me.SalesQuantityDataGridViewTextBoxColumn.HeaderText = "SalesQuantity"
        Me.SalesQuantityDataGridViewTextBoxColumn.Name = "SalesQuantityDataGridViewTextBoxColumn"
        '
        'StockQuantityDataGridViewTextBoxColumn
        '
        Me.StockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity"
        Me.StockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity"
        Me.StockQuantityDataGridViewTextBoxColumn.Name = "StockQuantityDataGridViewTextBoxColumn"
        '
        'StockDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 537)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.StockQuantityTextBox)
        Me.Controls.Add(Me.SalesQuantityTextBox)
        Me.Controls.Add(Me.PuchaseQuantityTextBox)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.ItemCodeTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StockDetails"
        Me.Text = "StockDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WoodDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ItemCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PuchaseQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents WoodDataSet5 As Wood_Craft.WoodDataSet5
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As Wood_Craft.WoodDataSet5TableAdapters.StockTableAdapter
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurchaseQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalesQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
