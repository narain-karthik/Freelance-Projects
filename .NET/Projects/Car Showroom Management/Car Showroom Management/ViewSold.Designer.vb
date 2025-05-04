<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSold
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
        Me.ViewSoldLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfPurchaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoldOutCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarDataSet5 = New Car_Showroom_Management.CarDataSet5()
        Me.SoldOutCarsTableAdapter = New Car_Showroom_Management.CarDataSet5TableAdapters.SoldOutCarsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoldOutCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewSoldLabel
        '
        Me.ViewSoldLabel.AutoSize = True
        Me.ViewSoldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSoldLabel.Location = New System.Drawing.Point(407, 45)
        Me.ViewSoldLabel.Name = "ViewSoldLabel"
        Me.ViewSoldLabel.Size = New System.Drawing.Size(164, 17)
        Me.ViewSoldLabel.TabIndex = 0
        Me.ViewSoldLabel.Text = "View Sold Out Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerEmailDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.CarModelDataGridViewTextBoxColumn, Me.CarPriceDataGridViewTextBoxColumn, Me.EngineNumberDataGridViewTextBoxColumn, Me.DateOfPurchaseDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SoldOutCarsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(51, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(851, 212)
        Me.DataGridView1.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'CustomerEmailDataGridViewTextBoxColumn
        '
        Me.CustomerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail"
        Me.CustomerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail"
        Me.CustomerEmailDataGridViewTextBoxColumn.Name = "CustomerEmailDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'CarModelDataGridViewTextBoxColumn
        '
        Me.CarModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel"
        Me.CarModelDataGridViewTextBoxColumn.HeaderText = "CarModel"
        Me.CarModelDataGridViewTextBoxColumn.Name = "CarModelDataGridViewTextBoxColumn"
        '
        'CarPriceDataGridViewTextBoxColumn
        '
        Me.CarPriceDataGridViewTextBoxColumn.DataPropertyName = "CarPrice"
        Me.CarPriceDataGridViewTextBoxColumn.HeaderText = "CarPrice"
        Me.CarPriceDataGridViewTextBoxColumn.Name = "CarPriceDataGridViewTextBoxColumn"
        '
        'EngineNumberDataGridViewTextBoxColumn
        '
        Me.EngineNumberDataGridViewTextBoxColumn.DataPropertyName = "EngineNumber"
        Me.EngineNumberDataGridViewTextBoxColumn.HeaderText = "EngineNumber"
        Me.EngineNumberDataGridViewTextBoxColumn.Name = "EngineNumberDataGridViewTextBoxColumn"
        '
        'DateOfPurchaseDataGridViewTextBoxColumn
        '
        Me.DateOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "DateOfPurchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.HeaderText = "DateOfPurchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.Name = "DateOfPurchaseDataGridViewTextBoxColumn"
        '
        'SoldOutCarsBindingSource
        '
        Me.SoldOutCarsBindingSource.DataMember = "SoldOutCars"
        Me.SoldOutCarsBindingSource.DataSource = Me.CarDataSet5
        '
        'CarDataSet5
        '
        Me.CarDataSet5.DataSetName = "CarDataSet5"
        Me.CarDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoldOutCarsTableAdapter
        '
        Me.SoldOutCarsTableAdapter.ClearBeforeFill = True
        '
        'ViewSold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 415)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ViewSoldLabel)
        Me.Name = "ViewSold"
        Me.Text = "ViewSold"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoldOutCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewSoldLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CarDataSet5 As Car_Showroom_Management.CarDataSet5
    Friend WithEvents SoldOutCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SoldOutCarsTableAdapter As Car_Showroom_Management.CarDataSet5TableAdapters.SoldOutCarsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EngineNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfPurchaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
