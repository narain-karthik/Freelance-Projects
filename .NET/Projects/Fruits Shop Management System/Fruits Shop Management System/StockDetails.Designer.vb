<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbFruitName = New System.Windows.Forms.ComboBox()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.dtpLastUpdated = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.dgvStockDetails = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblFruitName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblLastUpdated = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        CType(Me.dgvStockDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(200, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(166, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Stock Details"
        '
        'cmbFruitName
        '
        Me.cmbFruitName.Location = New System.Drawing.Point(160, 60)
        Me.cmbFruitName.Name = "cmbFruitName"
        Me.cmbFruitName.Size = New System.Drawing.Size(200, 24)
        Me.cmbFruitName.TabIndex = 2
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(160, 100)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(200, 22)
        Me.txtQuantityInStock.TabIndex = 4
        '
        'cmbUnit
        '
        Me.cmbUnit.Location = New System.Drawing.Point(160, 140)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(200, 24)
        Me.cmbUnit.TabIndex = 6
        '
        'dtpLastUpdated
        '
        Me.dtpLastUpdated.Location = New System.Drawing.Point(160, 180)
        Me.dtpLastUpdated.Name = "dtpLastUpdated"
        Me.dtpLastUpdated.Size = New System.Drawing.Size(200, 22)
        Me.dtpLastUpdated.TabIndex = 8
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(160, 220)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(200, 50)
        Me.txtRemarks.TabIndex = 10
        '
        'dgvStockDetails
        '
        Me.dgvStockDetails.Location = New System.Drawing.Point(30, 290)
        Me.dgvStockDetails.Name = "dgvStockDetails"
        Me.dgvStockDetails.ReadOnly = True
        Me.dgvStockDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockDetails.Size = New System.Drawing.Size(520, 200)
        Me.dgvStockDetails.TabIndex = 15
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
        'lblFruitName
        '
        Me.lblFruitName.Location = New System.Drawing.Point(30, 60)
        Me.lblFruitName.Name = "lblFruitName"
        Me.lblFruitName.Size = New System.Drawing.Size(100, 23)
        Me.lblFruitName.TabIndex = 1
        Me.lblFruitName.Text = "Fruit Name:"
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(30, 100)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 23)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity in Stock:"
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(30, 140)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(100, 23)
        Me.lblUnit.TabIndex = 5
        Me.lblUnit.Text = "Unit:"
        '
        'lblLastUpdated
        '
        Me.lblLastUpdated.Location = New System.Drawing.Point(30, 180)
        Me.lblLastUpdated.Name = "lblLastUpdated"
        Me.lblLastUpdated.Size = New System.Drawing.Size(100, 23)
        Me.lblLastUpdated.TabIndex = 7
        Me.lblLastUpdated.Text = "Last Updated:"
        '
        'lblRemarks
        '
        Me.lblRemarks.Location = New System.Drawing.Point(30, 220)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(100, 23)
        Me.lblRemarks.TabIndex = 9
        Me.lblRemarks.Text = "Remarks:"
        '
        'StockDetails
        '
        Me.ClientSize = New System.Drawing.Size(600, 520)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblFruitName)
        Me.Controls.Add(Me.cmbFruitName)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantityInStock)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.lblLastUpdated)
        Me.Controls.Add(Me.dtpLastUpdated)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvStockDetails)
        Me.Name = "StockDetails"
        Me.Text = "Stock Details"
        CType(Me.dgvStockDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lblTitle As System.Windows.Forms.Label
    Private lblFruitName As System.Windows.Forms.Label
    Private lblQuantity As System.Windows.Forms.Label
    Private lblUnit As System.Windows.Forms.Label
    Private lblLastUpdated As System.Windows.Forms.Label
    Private lblRemarks As System.Windows.Forms.Label
    Friend WithEvents cmbFruitName As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantityInStock As System.Windows.Forms.TextBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents dtpLastUpdated As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents dgvStockDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
