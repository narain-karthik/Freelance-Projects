<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.dtpPurchaseDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.dgvFashionPurchaseDetails = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblPurchaseDate = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        CType(Me.dgvFashionPurchaseDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(190, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(310, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Fashion Purchase Details"
        '
        'cmbProductName
        '
        Me.cmbProductName.Location = New System.Drawing.Point(150, 60)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(200, 24)
        Me.cmbProductName.TabIndex = 2
        '
        'cmbSize
        '
        Me.cmbSize.Location = New System.Drawing.Point(150, 100)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(200, 24)
        Me.cmbSize.TabIndex = 4
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(150, 140)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(200, 22)
        Me.txtQuantity.TabIndex = 6
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.Location = New System.Drawing.Point(150, 180)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(200, 22)
        Me.txtPurchasePrice.TabIndex = 8
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(150, 220)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(200, 22)
        Me.txtSupplierName.TabIndex = 10
        '
        'dtpPurchaseDate
        '
        Me.dtpPurchaseDate.Location = New System.Drawing.Point(150, 260)
        Me.dtpPurchaseDate.Name = "dtpPurchaseDate"
        Me.dtpPurchaseDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpPurchaseDate.TabIndex = 12
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(150, 300)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(200, 50)
        Me.txtRemarks.TabIndex = 14
        '
        'dgvFashionPurchaseDetails
        '
        Me.dgvFashionPurchaseDetails.Location = New System.Drawing.Point(30, 370)
        Me.dgvFashionPurchaseDetails.Name = "dgvFashionPurchaseDetails"
        Me.dgvFashionPurchaseDetails.ReadOnly = True
        Me.dgvFashionPurchaseDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFashionPurchaseDetails.Size = New System.Drawing.Size(520, 200)
        Me.dgvFashionPurchaseDetails.TabIndex = 19
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
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(30, 100)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(100, 23)
        Me.lblSize.TabIndex = 3
        Me.lblSize.Text = "Size:"
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(30, 140)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 23)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(30, 180)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Purchase Price:"
        '
        'lblSupplier
        '
        Me.lblSupplier.Location = New System.Drawing.Point(30, 220)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(100, 23)
        Me.lblSupplier.TabIndex = 9
        Me.lblSupplier.Text = "Supplier:"
        '
        'lblPurchaseDate
        '
        Me.lblPurchaseDate.Location = New System.Drawing.Point(30, 260)
        Me.lblPurchaseDate.Name = "lblPurchaseDate"
        Me.lblPurchaseDate.Size = New System.Drawing.Size(100, 23)
        Me.lblPurchaseDate.TabIndex = 11
        Me.lblPurchaseDate.Text = "Purchase Date:"
        '
        'lblRemarks
        '
        Me.lblRemarks.Location = New System.Drawing.Point(30, 300)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(100, 23)
        Me.lblRemarks.TabIndex = 13
        Me.lblRemarks.Text = "Remarks:"
        '
        'PurchaseDetails
        '
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.cmbProductName)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtPurchasePrice)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.lblPurchaseDate)
        Me.Controls.Add(Me.dtpPurchaseDate)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvFashionPurchaseDetails)
        Me.Name = "PurchaseDetails"
        Me.Text = "Fashion Purchase Details"
        CType(Me.dgvFashionPurchaseDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lblTitle As System.Windows.Forms.Label
    Private lblProductName As System.Windows.Forms.Label
    Private lblSize As System.Windows.Forms.Label
    Private lblQuantity As System.Windows.Forms.Label
    Private lblPrice As System.Windows.Forms.Label
    Private lblSupplier As System.Windows.Forms.Label
    Private lblPurchaseDate As System.Windows.Forms.Label
    Private lblRemarks As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchasePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents dtpPurchaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents dgvFashionPurchaseDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
