<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMenuDetails
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RestaurantDataSet1 = New Restaurant_Management_System.RestaurantDataSet1()
        Me.MenuItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuItemsTableAdapter = New Restaurant_Management_System.RestaurantDataSet1TableAdapters.MenuItemsTableAdapter()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnClose = New System.Windows.Forms.Button()

        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        'DataGridView1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.ItemIDDataGridViewTextBoxColumn,
            Me.ItemNameDataGridViewTextBoxColumn,
            Me.CategoryDataGridViewTextBoxColumn,
            Me.PriceDataGridViewTextBoxColumn
        })
        Me.DataGridView1.DataSource = Me.MenuItemsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(10, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(580, 300)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.BackgroundColor = Color.WhiteSmoke
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        'RestaurantDataSet1
        Me.RestaurantDataSet1.DataSetName = "RestaurantDataSet1"
        Me.RestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema

        'MenuItemsBindingSource
        Me.MenuItemsBindingSource.DataMember = "MenuItems"
        Me.MenuItemsBindingSource.DataSource = Me.RestaurantDataSet1

        'MenuItemsTableAdapter
        Me.MenuItemsTableAdapter.ClearBeforeFill = True

        'ItemIDDataGridViewTextBoxColumn
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item ID"
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemIDDataGridViewTextBoxColumn.Width = 80

        'ItemNameDataGridViewTextBoxColumn
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemNameDataGridViewTextBoxColumn.Width = 200

        'CategoryDataGridViewTextBoxColumn
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Width = 150

        'PriceDataGridViewTextBoxColumn
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price (₹)"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 100

        'BtnClose
        Me.BtnClose.Text = "Close"
        Me.BtnClose.Font = New Font("Segoe UI", 10)
        Me.BtnClose.BackColor = Color.FromArgb(220, 53, 69)
        Me.BtnClose.ForeColor = Color.White
        Me.BtnClose.FlatStyle = FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(240, 320)
        Me.BtnClose.Size = New System.Drawing.Size(100, 35)
        AddHandler BtnClose.Click, AddressOf BtnClose_Click

        'ViewMenuDetails Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Color.White
        Me.ClientSize = New System.Drawing.Size(600, 370)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Name = "ViewMenuDetails"
        Me.Text = "Menu Items - Restaurant Management System"
        Me.Padding = New Padding(10)

        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RestaurantDataSet1 As Restaurant_Management_System.RestaurantDataSet1
    Friend WithEvents MenuItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuItemsTableAdapter As Restaurant_Management_System.RestaurantDataSet1TableAdapters.MenuItemsTableAdapter
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnClose As System.Windows.Forms.Button

    'Close Button Handler
    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

End Class
