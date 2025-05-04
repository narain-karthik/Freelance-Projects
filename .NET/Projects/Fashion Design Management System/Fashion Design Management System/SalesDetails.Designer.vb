<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.dtpSalesDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.dgvSalesDetails = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblSalesDate = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        CType(Me.dgvSalesDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(200, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(167, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sales Details"
        '
        'cmbProductName
        '
        Me.cmbProductName.Items.AddRange(New Object() {"Shirt", "Pant"})
        Me.cmbProductName.Location = New System.Drawing.Point(150, 60)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(200, 24)
        Me.cmbProductName.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(150, 100)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(200, 22)
        Me.txtQuantity.TabIndex = 4
        '
        'cmbSize
        '
        Me.cmbSize.Items.AddRange(New Object() {"M", "S", "XL", "XXL", "L"})
        Me.cmbSize.Location = New System.Drawing.Point(150, 140)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(200, 24)
        Me.cmbSize.TabIndex = 6
        '
        'cmbUnit
        '
        Me.cmbUnit.Location = New System.Drawing.Point(150, 120)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(200, 25)
        Me.cmbUnit.TabIndex = 5
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Location = New System.Drawing.Point(150, 180)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(200, 22)
        Me.txtSellingPrice.TabIndex = 8
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(150, 220)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(200, 22)
        Me.txtCustomerName.TabIndex = 10
        '
        'dtpSalesDate
        '
        Me.dtpSalesDate.Location = New System.Drawing.Point(150, 260)
        Me.dtpSalesDate.Name = "dtpSalesDate"
        Me.dtpSalesDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpSalesDate.TabIndex = 12
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(150, 300)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(200, 50)
        Me.txtRemarks.TabIndex = 14
        '
        'dgvSalesDetails
        '
        Me.dgvSalesDetails.Location = New System.Drawing.Point(30, 370)
        Me.dgvSalesDetails.Name = "dgvSalesDetails"
        Me.dgvSalesDetails.ReadOnly = True
        Me.dgvSalesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesDetails.Size = New System.Drawing.Size(520, 200)
        Me.dgvSalesDetails.TabIndex = 19
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(380, 60)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 30)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(380, 100)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(380, 140)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 30)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(380, 180)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 18
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
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(30, 140)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(100, 23)
        Me.lblSize.TabIndex = 5
        Me.lblSize.Text = "Size:"
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.Location = New System.Drawing.Point(30, 180)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblSellingPrice.TabIndex = 7
        Me.lblSellingPrice.Text = "Selling Price:"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Location = New System.Drawing.Point(30, 220)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(100, 23)
        Me.lblCustomerName.TabIndex = 9
        Me.lblCustomerName.Text = "Customer:"
        '
        'lblSalesDate
        '
        Me.lblSalesDate.Location = New System.Drawing.Point(30, 260)
        Me.lblSalesDate.Name = "lblSalesDate"
        Me.lblSalesDate.Size = New System.Drawing.Size(100, 23)
        Me.lblSalesDate.TabIndex = 11
        Me.lblSalesDate.Text = "Sales Date:"
        '
        'lblRemarks
        '
        Me.lblRemarks.Location = New System.Drawing.Point(30, 300)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(100, 23)
        Me.lblRemarks.TabIndex = 13
        Me.lblRemarks.Text = "Remarks:"
        '
        'SalesDetails
        '
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.cmbProductName)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.lblSellingPrice)
        Me.Controls.Add(Me.txtSellingPrice)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblSalesDate)
        Me.Controls.Add(Me.dtpSalesDate)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvSalesDetails)
        Me.Name = "SalesDetails"
        Me.Text = "Sales Details"
        CType(Me.dgvSalesDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private lblTitle As System.Windows.Forms.Label
    Private lblProductName As System.Windows.Forms.Label
    Private lblQuantity As System.Windows.Forms.Label
    Private lblSize As System.Windows.Forms.Label
    Private lblSellingPrice As System.Windows.Forms.Label
    Private lblCustomerName As System.Windows.Forms.Label
    Private lblSalesDate As System.Windows.Forms.Label
    Private lblRemarks As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox ' Added cmbUnit declaration
    Friend WithEvents txtSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents dtpSalesDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents dgvSalesDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
