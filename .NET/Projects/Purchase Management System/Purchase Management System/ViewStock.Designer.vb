<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStock
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    Friend WithEvents dgvStock As DataGridView
    Friend WithEvents btnRefresh As Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PurchaseManagementDataSet2 = New Purchase_Management_System.PurchaseManagementDataSet2()
        Me.StockTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTransactionsTableAdapter = New Purchase_Management_System.PurchaseManagementDataSet2TableAdapters.StockTransactionsTableAdapter()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseManagementDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStock
        '
        Me.dgvStock.AutoGenerateColumns = False
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.StockInDataGridViewTextBoxColumn, Me.StockOutDataGridViewTextBoxColumn, Me.AvailableStockDataGridViewTextBoxColumn})
        Me.dgvStock.DataSource = Me.StockTransactionsBindingSource
        Me.dgvStock.Location = New System.Drawing.Point(20, 20)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.Size = New System.Drawing.Size(500, 300)
        Me.dgvStock.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(220, 340)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PurchaseManagementDataSet2
        '
        Me.PurchaseManagementDataSet2.DataSetName = "PurchaseManagementDataSet2"
        Me.PurchaseManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockTransactionsBindingSource
        '
        Me.StockTransactionsBindingSource.DataMember = "StockTransactions"
        Me.StockTransactionsBindingSource.DataSource = Me.PurchaseManagementDataSet2
        '
        'StockTransactionsTableAdapter
        '
        Me.StockTransactionsTableAdapter.ClearBeforeFill = True
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'StockInDataGridViewTextBoxColumn
        '
        Me.StockInDataGridViewTextBoxColumn.DataPropertyName = "StockIn"
        Me.StockInDataGridViewTextBoxColumn.HeaderText = "StockIn"
        Me.StockInDataGridViewTextBoxColumn.Name = "StockInDataGridViewTextBoxColumn"
        '
        'StockOutDataGridViewTextBoxColumn
        '
        Me.StockOutDataGridViewTextBoxColumn.DataPropertyName = "StockOut"
        Me.StockOutDataGridViewTextBoxColumn.HeaderText = "StockOut"
        Me.StockOutDataGridViewTextBoxColumn.Name = "StockOutDataGridViewTextBoxColumn"
        '
        'AvailableStockDataGridViewTextBoxColumn
        '
        Me.AvailableStockDataGridViewTextBoxColumn.DataPropertyName = "AvailableStock"
        Me.AvailableStockDataGridViewTextBoxColumn.HeaderText = "AvailableStock"
        Me.AvailableStockDataGridViewTextBoxColumn.Name = "AvailableStockDataGridViewTextBoxColumn"
        '
        'ViewStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 400)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvStock)
        Me.Name = "ViewStock"
        Me.Text = "View Stock"
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseManagementDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PurchaseManagementDataSet2 As Purchase_Management_System.PurchaseManagementDataSet2
    Friend WithEvents StockTransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTransactionsTableAdapter As Purchase_Management_System.PurchaseManagementDataSet2TableAdapters.StockTransactionsTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailableStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
