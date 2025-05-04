<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllPurchaseOrders
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents btnRefresh As Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseManagementDataSet = New Purchase_Management_System.PurchaseManagementDataSet()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PurchaseOrdersTableAdapter = New Purchase_Management_System.PurchaseManagementDataSetTableAdapters.PurchaseOrdersTableAdapter()
        Me.PurchaseManagementDataSet1 = New Purchase_Management_System.PurchaseManagementDataSet1()
        Me.PurchaseOrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrdersTableAdapter1 = New Purchase_Management_System.PurchaseManagementDataSet1TableAdapters.PurchaseOrdersTableAdapter()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseManagementDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOrders
        '
        Me.dgvOrders.AutoGenerateColumns = False
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.OrderDateDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn})
        Me.dgvOrders.DataSource = Me.PurchaseOrdersBindingSource1
        Me.dgvOrders.Location = New System.Drawing.Point(20, 20)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.Size = New System.Drawing.Size(740, 300)
        Me.dgvOrders.TabIndex = 0
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate"
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        '
        'PurchaseOrdersBindingSource
        '
        Me.PurchaseOrdersBindingSource.DataMember = "PurchaseOrders"
        Me.PurchaseOrdersBindingSource.DataSource = Me.PurchaseManagementDataSet
        '
        'PurchaseManagementDataSet
        '
        Me.PurchaseManagementDataSet.DataSetName = "PurchaseManagementDataSet"
        Me.PurchaseManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(20, 340)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PurchaseOrdersTableAdapter
        '
        Me.PurchaseOrdersTableAdapter.ClearBeforeFill = True
        '
        'PurchaseManagementDataSet1
        '
        Me.PurchaseManagementDataSet1.DataSetName = "PurchaseManagementDataSet1"
        Me.PurchaseManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchaseOrdersBindingSource1
        '
        Me.PurchaseOrdersBindingSource1.DataMember = "PurchaseOrders"
        Me.PurchaseOrdersBindingSource1.DataSource = Me.PurchaseManagementDataSet1
        '
        'PurchaseOrdersTableAdapter1
        '
        Me.PurchaseOrdersTableAdapter1.ClearBeforeFill = True
        '
        'ViewAllPurchaseOrders
        '
        Me.ClientSize = New System.Drawing.Size(780, 400)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvOrders)
        Me.Name = "ViewAllPurchaseOrders"
        Me.Text = "View All Purchase Orders"
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseManagementDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PurchaseManagementDataSet As Purchase_Management_System.PurchaseManagementDataSet
    Friend WithEvents PurchaseOrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseOrdersTableAdapter As Purchase_Management_System.PurchaseManagementDataSetTableAdapters.PurchaseOrdersTableAdapter
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurchaseManagementDataSet1 As Purchase_Management_System.PurchaseManagementDataSet1
    Friend WithEvents PurchaseOrdersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseOrdersTableAdapter1 As Purchase_Management_System.PurchaseManagementDataSet1TableAdapters.PurchaseOrdersTableAdapter
End Class
