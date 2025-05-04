<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSupplierCreditDetails
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CreditDataSet3 = New Credit_Sale_Management_System.CreditDataSet3()
        Me.SupplierCreditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierCreditTableAdapter = New Credit_Sale_Management_System.CreditDataSet3TableAdapters.SupplierCreditTableAdapter()
        Me.CreditIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCreditLimitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingCreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastPaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextPaymentDueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierCreditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(466, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Supplier Credit Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CreditIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.TotalCreditLimitDataGridViewTextBoxColumn, Me.CreditUsedDataGridViewTextBoxColumn, Me.RemainingCreditDataGridViewTextBoxColumn, Me.DueAmountDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn, Me.InterestRateDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewTextBoxColumn, Me.LastPaymentDateDataGridViewTextBoxColumn, Me.NextPaymentDueDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SupplierCreditBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(27, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1177, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'CreditDataSet3
        '
        Me.CreditDataSet3.DataSetName = "CreditDataSet3"
        Me.CreditDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierCreditBindingSource
        '
        Me.SupplierCreditBindingSource.DataMember = "SupplierCredit"
        Me.SupplierCreditBindingSource.DataSource = Me.CreditDataSet3
        '
        'SupplierCreditTableAdapter
        '
        Me.SupplierCreditTableAdapter.ClearBeforeFill = True
        '
        'CreditIDDataGridViewTextBoxColumn
        '
        Me.CreditIDDataGridViewTextBoxColumn.DataPropertyName = "CreditID"
        Me.CreditIDDataGridViewTextBoxColumn.HeaderText = "CreditID"
        Me.CreditIDDataGridViewTextBoxColumn.Name = "CreditIDDataGridViewTextBoxColumn"
        Me.CreditIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        '
        'TotalCreditLimitDataGridViewTextBoxColumn
        '
        Me.TotalCreditLimitDataGridViewTextBoxColumn.DataPropertyName = "TotalCreditLimit"
        Me.TotalCreditLimitDataGridViewTextBoxColumn.HeaderText = "TotalCreditLimit"
        Me.TotalCreditLimitDataGridViewTextBoxColumn.Name = "TotalCreditLimitDataGridViewTextBoxColumn"
        '
        'CreditUsedDataGridViewTextBoxColumn
        '
        Me.CreditUsedDataGridViewTextBoxColumn.DataPropertyName = "CreditUsed"
        Me.CreditUsedDataGridViewTextBoxColumn.HeaderText = "CreditUsed"
        Me.CreditUsedDataGridViewTextBoxColumn.Name = "CreditUsedDataGridViewTextBoxColumn"
        '
        'RemainingCreditDataGridViewTextBoxColumn
        '
        Me.RemainingCreditDataGridViewTextBoxColumn.DataPropertyName = "RemainingCredit"
        Me.RemainingCreditDataGridViewTextBoxColumn.HeaderText = "RemainingCredit"
        Me.RemainingCreditDataGridViewTextBoxColumn.Name = "RemainingCreditDataGridViewTextBoxColumn"
        Me.RemainingCreditDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DueAmountDataGridViewTextBoxColumn
        '
        Me.DueAmountDataGridViewTextBoxColumn.DataPropertyName = "DueAmount"
        Me.DueAmountDataGridViewTextBoxColumn.HeaderText = "DueAmount"
        Me.DueAmountDataGridViewTextBoxColumn.Name = "DueAmountDataGridViewTextBoxColumn"
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        '
        'InterestRateDataGridViewTextBoxColumn
        '
        Me.InterestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate"
        Me.InterestRateDataGridViewTextBoxColumn.HeaderText = "InterestRate"
        Me.InterestRateDataGridViewTextBoxColumn.Name = "InterestRateDataGridViewTextBoxColumn"
        '
        'PaymentStatusDataGridViewTextBoxColumn
        '
        Me.PaymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.Name = "PaymentStatusDataGridViewTextBoxColumn"
        '
        'LastPaymentDateDataGridViewTextBoxColumn
        '
        Me.LastPaymentDateDataGridViewTextBoxColumn.DataPropertyName = "LastPaymentDate"
        Me.LastPaymentDateDataGridViewTextBoxColumn.HeaderText = "LastPaymentDate"
        Me.LastPaymentDateDataGridViewTextBoxColumn.Name = "LastPaymentDateDataGridViewTextBoxColumn"
        '
        'NextPaymentDueDateDataGridViewTextBoxColumn
        '
        Me.NextPaymentDueDateDataGridViewTextBoxColumn.DataPropertyName = "NextPaymentDueDate"
        Me.NextPaymentDueDateDataGridViewTextBoxColumn.HeaderText = "NextPaymentDueDate"
        Me.NextPaymentDueDateDataGridViewTextBoxColumn.Name = "NextPaymentDueDateDataGridViewTextBoxColumn"
        '
        'ViewSupplierCreditDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 478)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewSupplierCreditDetails"
        Me.Text = "ViewSupplierCreditDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierCreditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CreditDataSet3 As Credit_Sale_Management_System.CreditDataSet3
    Friend WithEvents SupplierCreditBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierCreditTableAdapter As Credit_Sale_Management_System.CreditDataSet3TableAdapters.SupplierCreditTableAdapter
    Friend WithEvents CreditIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCreditLimitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditUsedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemainingCreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterestRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastPaymentDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NextPaymentDueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
