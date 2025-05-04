<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.dtpLastUpdated = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.dgvFashionStockDetails = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblLastUpdated = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        CType(Me.dgvFashionStockDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(200, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(178, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Fashion Stock"
        '
        'cmbProductName
        '
        Me.cmbProductName.Items.AddRange(New Object() {"Shirt", "T-shirt", "Jeans", "Dress", "Jacket", "Skirt", "Sweater"})
        Me.cmbProductName.Location = New System.Drawing.Point(160, 60)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(200, 24)
        Me.cmbProductName.TabIndex = 2
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(160, 100)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(200, 22)
        Me.txtQuantityInStock.TabIndex = 4
        '
        'cmbSize
        '
        Me.cmbSize.Items.AddRange(New Object() {"M", "S", "L", "XL", "XXL"})
        Me.cmbSize.Location = New System.Drawing.Point(160, 140)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(200, 24)
        Me.cmbSize.TabIndex = 6
        '
        'cmbColor
        '
        Me.cmbColor.Items.AddRange(New Object() {"Blue", "Gold", "Red", "White"})
        Me.cmbColor.Location = New System.Drawing.Point(160, 180)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(200, 24)
        Me.cmbColor.TabIndex = 7
        '
        'dtpLastUpdated
        '
        Me.dtpLastUpdated.Location = New System.Drawing.Point(160, 220)
        Me.dtpLastUpdated.Name = "dtpLastUpdated"
        Me.dtpLastUpdated.Size = New System.Drawing.Size(200, 22)
        Me.dtpLastUpdated.TabIndex = 8
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(160, 260)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(200, 50)
        Me.txtRemarks.TabIndex = 10
        '
        'dgvFashionStockDetails
        '
        Me.dgvFashionStockDetails.Location = New System.Drawing.Point(30, 330)
        Me.dgvFashionStockDetails.Name = "dgvFashionStockDetails"
        Me.dgvFashionStockDetails.ReadOnly = True
        Me.dgvFashionStockDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFashionStockDetails.Size = New System.Drawing.Size(520, 200)
        Me.dgvFashionStockDetails.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(400, 60)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(400, 100)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(400, 140)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 30)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(400, 180)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        '
        'lblProductName
        '
        Me.lblProductName.Location = New System.Drawing.Point(30, 60)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(100, 23)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "Product Name:"
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(30, 100)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 23)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity in Stock:"
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(30, 140)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(100, 23)
        Me.lblSize.TabIndex = 5
        Me.lblSize.Text = "Size:"
        '
        'lblColor
        '
        Me.lblColor.Location = New System.Drawing.Point(30, 180)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(100, 23)
        Me.lblColor.TabIndex = 6
        Me.lblColor.Text = "Color:"
        '
        'lblLastUpdated
        '
        Me.lblLastUpdated.Location = New System.Drawing.Point(30, 220)
        Me.lblLastUpdated.Name = "lblLastUpdated"
        Me.lblLastUpdated.Size = New System.Drawing.Size(100, 23)
        Me.lblLastUpdated.TabIndex = 7
        Me.lblLastUpdated.Text = "Last Updated:"
        '
        'lblRemarks
        '
        Me.lblRemarks.Location = New System.Drawing.Point(30, 260)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(100, 23)
        Me.lblRemarks.TabIndex = 9
        Me.lblRemarks.Text = "Remarks:"
        '
        'StockDetails
        '
        Me.ClientSize = New System.Drawing.Size(600, 540)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.cmbProductName)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantityInStock)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.lblLastUpdated)
        Me.Controls.Add(Me.dtpLastUpdated)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvFashionStockDetails)
        Me.Name = "StockDetails"
        Me.Text = "Fashion Stock Details"
        CType(Me.dgvFashionStockDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lblTitle As System.Windows.Forms.Label
    Private lblProductName As System.Windows.Forms.Label
    Private lblQuantity As System.Windows.Forms.Label
    Private lblSize As System.Windows.Forms.Label
    Private lblColor As System.Windows.Forms.Label
    Private lblLastUpdated As System.Windows.Forms.Label
    Private lblRemarks As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantityInStock As System.Windows.Forms.TextBox
    Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
    Friend WithEvents cmbColor As System.Windows.Forms.ComboBox
    Friend WithEvents dtpLastUpdated As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents dgvFashionStockDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class