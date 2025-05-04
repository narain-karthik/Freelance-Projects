<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserHome
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
        Me.UserpageLabel = New System.Windows.Forms.Label()
        Me.RegisterLabel = New System.Windows.Forms.Label()
        Me.RegisterTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ViewAttendanceDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CarDataSet6 = New Car_Showroom_Management.CarDataSet6()
        Me.SoldOutCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldOutCarsTableAdapter = New Car_Showroom_Management.CarDataSet6TableAdapters.SoldOutCarsTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfPurchaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ViewAttendanceDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoldOutCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserpageLabel
        '
        Me.UserpageLabel.AutoSize = True
        Me.UserpageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserpageLabel.Location = New System.Drawing.Point(400, 22)
        Me.UserpageLabel.Name = "UserpageLabel"
        Me.UserpageLabel.Size = New System.Drawing.Size(284, 25)
        Me.UserpageLabel.TabIndex = 0
        Me.UserpageLabel.Text = "Welcome to Staff User Page"
        '
        'RegisterLabel
        '
        Me.RegisterLabel.AutoSize = True
        Me.RegisterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterLabel.Location = New System.Drawing.Point(23, 77)
        Me.RegisterLabel.Name = "RegisterLabel"
        Me.RegisterLabel.Size = New System.Drawing.Size(130, 17)
        Me.RegisterLabel.TabIndex = 2
        Me.RegisterLabel.Text = "Register Number"
        '
        'RegisterTextBox
        '
        Me.RegisterTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RegisterTextBox.Location = New System.Drawing.Point(183, 77)
        Me.RegisterTextBox.Name = "RegisterTextBox"
        Me.RegisterTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RegisterTextBox.TabIndex = 3
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.SearchButton.Location = New System.Drawing.Point(324, 77)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 4
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ViewAttendanceDetailsDataGridView
        '
        Me.ViewAttendanceDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewAttendanceDetailsDataGridView.Location = New System.Drawing.Point(26, 122)
        Me.ViewAttendanceDetailsDataGridView.Name = "ViewAttendanceDetailsDataGridView"
        Me.ViewAttendanceDetailsDataGridView.RowTemplate.Height = 24
        Me.ViewAttendanceDetailsDataGridView.Size = New System.Drawing.Size(544, 176)
        Me.ViewAttendanceDetailsDataGridView.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "List of Car Sold Out & customer Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerEmailDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.CarModelDataGridViewTextBoxColumn, Me.CarPriceDataGridViewTextBoxColumn, Me.EngineNumberDataGridViewTextBoxColumn, Me.DateOfPurchaseDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SoldOutCarsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(121, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(841, 161)
        Me.DataGridView1.TabIndex = 7
        '
        'CarDataSet6
        '
        Me.CarDataSet6.DataSetName = "CarDataSet6"
        Me.CarDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoldOutCarsBindingSource
        '
        Me.SoldOutCarsBindingSource.DataMember = "SoldOutCars"
        Me.SoldOutCarsBindingSource.DataSource = Me.CarDataSet6
        '
        'SoldOutCarsTableAdapter
        '
        Me.SoldOutCarsTableAdapter.ClearBeforeFill = True
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
        'UserHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 519)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViewAttendanceDetailsDataGridView)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.RegisterTextBox)
        Me.Controls.Add(Me.RegisterLabel)
        Me.Controls.Add(Me.UserpageLabel)
        Me.Name = "UserHome"
        Me.Text = "UserHome"
        CType(Me.ViewAttendanceDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoldOutCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserpageLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents ViewAttendanceDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CarDataSet6 As Car_Showroom_Management.CarDataSet6
    Friend WithEvents SoldOutCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SoldOutCarsTableAdapter As Car_Showroom_Management.CarDataSet6TableAdapters.SoldOutCarsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EngineNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfPurchaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
