<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrderDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()

        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RestaurantDataSet2 = New Restaurant_Management_System.RestaurantDataSet2()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New Restaurant_Management_System.RestaurantDataSet2TableAdapters.OrdersTableAdapter()

        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodListDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()

        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()

        ' PanelHeader
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(52, 152, 219) ' Blue color
        Me.PanelHeader.Controls.Add(Me.lblTitle)

        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Height = 70
        Me.PanelHeader.Name = "PanelHeader"

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Text = "View Order Details"

        

        ' DataGridView1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.DataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.GridColor = System.Drawing.Color.LightGray
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 70)
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.DataSource = Me.OrdersBindingSource
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.OrderIDDataGridViewTextBoxColumn,
            Me.TableIDDataGridViewTextBoxColumn,
            Me.CustomerNameDataGridViewTextBoxColumn,
            Me.OrderStatusDataGridViewTextBoxColumn,
            Me.FoodListDataGridViewTextBoxColumn,
            Me.OrderDateTimeDataGridViewTextBoxColumn
        })

        ' RestaurantDataSet2
        Me.RestaurantDataSet2.DataSetName = "RestaurantDataSet2"
        Me.RestaurantDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema

        ' OrdersBindingSource
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.RestaurantDataSet2

        ' OrdersTableAdapter
        Me.OrdersTableAdapter.ClearBeforeFill = True

        ' Columns
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.Width = 80

        Me.TableIDDataGridViewTextBoxColumn.DataPropertyName = "TableID"
        Me.TableIDDataGridViewTextBoxColumn.HeaderText = "Table ID"
        Me.TableIDDataGridViewTextBoxColumn.Width = 80

        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 150

        Me.OrderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus"
        Me.OrderStatusDataGridViewTextBoxColumn.HeaderText = "Order Status"
        Me.OrderStatusDataGridViewTextBoxColumn.Width = 120

        Me.FoodListDataGridViewTextBoxColumn.DataPropertyName = "FoodList"
        Me.FoodListDataGridViewTextBoxColumn.HeaderText = "Food List"
        Me.FoodListDataGridViewTextBoxColumn.Width = 200

        Me.OrderDateTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderDateTime"
        Me.OrderDateTimeDataGridViewTextBoxColumn.HeaderText = "Order DateTime"
        Me.OrderDateTimeDataGridViewTextBoxColumn.Width = 150

        ' Form Settings
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 400)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Name = "ViewOrderDetails"
        Me.Text = "View Order Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label

    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RestaurantDataSet2 As Restaurant_Management_System.RestaurantDataSet2
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter As Restaurant_Management_System.RestaurantDataSet2TableAdapters.OrdersTableAdapter
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodListDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderDateTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
