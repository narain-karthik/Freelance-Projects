<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPro
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
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComputerDataSet2 = New Computer_Sales_Management_System.ComputerDataSet2()
        Me.ProductDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDetailsTableAdapter = New Computer_Sales_Management_System.ComputerDataSet2TableAdapters.ProductDetailsTableAdapter()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComputerDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.Location = New System.Drawing.Point(244, 69)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(199, 17)
        Me.AdminLabel.TabIndex = 5
        Me.AdminLabel.Text = "View Product Details Page"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(187, 34)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(298, 25)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "Computer Sales Management"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ModuleNameDataGridViewTextBoxColumn, Me.StockNumberDataGridViewTextBoxColumn, Me.DateOfStockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(74, 143)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(546, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'ComputerDataSet2
        '
        Me.ComputerDataSet2.DataSetName = "ComputerDataSet2"
        Me.ComputerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductDetailsBindingSource
        '
        Me.ProductDetailsBindingSource.DataMember = "ProductDetails"
        Me.ProductDetailsBindingSource.DataSource = Me.ComputerDataSet2
        '
        'ProductDetailsTableAdapter
        '
        Me.ProductDetailsTableAdapter.ClearBeforeFill = True
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'ModuleNameDataGridViewTextBoxColumn
        '
        Me.ModuleNameDataGridViewTextBoxColumn.DataPropertyName = "ModuleName"
        Me.ModuleNameDataGridViewTextBoxColumn.HeaderText = "ModuleName"
        Me.ModuleNameDataGridViewTextBoxColumn.Name = "ModuleNameDataGridViewTextBoxColumn"
        '
        'StockNumberDataGridViewTextBoxColumn
        '
        Me.StockNumberDataGridViewTextBoxColumn.DataPropertyName = "StockNumber"
        Me.StockNumberDataGridViewTextBoxColumn.HeaderText = "StockNumber"
        Me.StockNumberDataGridViewTextBoxColumn.Name = "StockNumberDataGridViewTextBoxColumn"
        '
        'DateOfStockDataGridViewTextBoxColumn
        '
        Me.DateOfStockDataGridViewTextBoxColumn.DataPropertyName = "DateOfStock"
        Me.DateOfStockDataGridViewTextBoxColumn.HeaderText = "DateOfStock"
        Me.DateOfStockDataGridViewTextBoxColumn.Name = "DateOfStockDataGridViewTextBoxColumn"
        '
        'ViewPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 403)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "ViewPro"
        Me.Text = "ViewPro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComputerDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComputerDataSet2 As Computer_Sales_Management_System.ComputerDataSet2
    Friend WithEvents ProductDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDetailsTableAdapter As Computer_Sales_Management_System.ComputerDataSet2TableAdapters.ProductDetailsTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModuleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
