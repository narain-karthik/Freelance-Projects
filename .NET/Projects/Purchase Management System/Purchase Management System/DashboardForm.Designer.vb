<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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

    'UI Components
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllSuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllPurchaseOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStockToolStripMenuItem As ToolStripMenuItem

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllPurchaseOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewEmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 37)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(149, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(149, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuppliersToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.PurchaseOrdersToolStripMenuItem, Me.StockToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(96, 29)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(229, 30)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(229, 30)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'PurchaseOrdersToolStripMenuItem
        '
        Me.PurchaseOrdersToolStripMenuItem.Name = "PurchaseOrdersToolStripMenuItem"
        Me.PurchaseOrdersToolStripMenuItem.Size = New System.Drawing.Size(229, 30)
        Me.PurchaseOrdersToolStripMenuItem.Text = "Purchase Orders"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(229, 30)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(229, 30)
        Me.ToolStripMenuItem1.Text = "Employee"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllSuppliersToolStripMenuItem, Me.ViewAllProductsToolStripMenuItem, Me.ViewAllPurchaseOrdersToolStripMenuItem, Me.ViewStockToolStripMenuItem, Me.ViewEmployeeDetailsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(67, 29)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewAllSuppliersToolStripMenuItem
        '
        Me.ViewAllSuppliersToolStripMenuItem.Name = "ViewAllSuppliersToolStripMenuItem"
        Me.ViewAllSuppliersToolStripMenuItem.Size = New System.Drawing.Size(305, 30)
        Me.ViewAllSuppliersToolStripMenuItem.Text = "View All Suppliers"
        '
        'ViewAllProductsToolStripMenuItem
        '
        Me.ViewAllProductsToolStripMenuItem.Name = "ViewAllProductsToolStripMenuItem"
        Me.ViewAllProductsToolStripMenuItem.Size = New System.Drawing.Size(305, 30)
        Me.ViewAllProductsToolStripMenuItem.Text = "View All Products"
        '
        'ViewAllPurchaseOrdersToolStripMenuItem
        '
        Me.ViewAllPurchaseOrdersToolStripMenuItem.Name = "ViewAllPurchaseOrdersToolStripMenuItem"
        Me.ViewAllPurchaseOrdersToolStripMenuItem.Size = New System.Drawing.Size(305, 30)
        Me.ViewAllPurchaseOrdersToolStripMenuItem.Text = "View All Purchase Orders"
        '
        'ViewStockToolStripMenuItem
        '
        Me.ViewStockToolStripMenuItem.Name = "ViewStockToolStripMenuItem"
        Me.ViewStockToolStripMenuItem.Size = New System.Drawing.Size(305, 30)
        Me.ViewStockToolStripMenuItem.Text = "View Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PURCHASE MANAGEMENT SYSTEM"
        '
        'ViewEmployeeDetailsToolStripMenuItem
        '
        Me.ViewEmployeeDetailsToolStripMenuItem.Name = "ViewEmployeeDetailsToolStripMenuItem"
        Me.ViewEmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(305, 30)
        Me.ViewEmployeeDetailsToolStripMenuItem.Text = "View Employee Details"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 295)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "📊 Admin Dashboard - Purchase Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
