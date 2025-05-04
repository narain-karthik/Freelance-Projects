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

    Private components As System.ComponentModel.IContainer

    Private lblWelcome As System.Windows.Forms.Label
    Private WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPurchaseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSalesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProductDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPurchaseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.Location = New System.Drawing.Point(100, 50)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(426, 29)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to Fruits Shop Dashboard"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.Location = New System.Drawing.Point(480, 260)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(90, 35)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDetailsToolStripMenuItem, Me.ViewDetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddDetailsToolStripMenuItem
        '
        Me.AddDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerDetailsToolStripMenuItem, Me.PurchaseDetailsToolStripMenuItem, Me.SalesDetailsToolStripMenuItem, Me.StockDetailsToolStripMenuItem, Me.ProductDetailsToolStripMenuItem})
        Me.AddDetailsToolStripMenuItem.Name = "AddDetailsToolStripMenuItem"
        Me.AddDetailsToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.AddDetailsToolStripMenuItem.Text = "Add Details"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer Details"
        '
        'PurchaseDetailsToolStripMenuItem
        '
        Me.PurchaseDetailsToolStripMenuItem.Name = "PurchaseDetailsToolStripMenuItem"
        Me.PurchaseDetailsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.PurchaseDetailsToolStripMenuItem.Text = "Purchase Details"
        '
        'SalesDetailsToolStripMenuItem
        '
        Me.SalesDetailsToolStripMenuItem.Name = "SalesDetailsToolStripMenuItem"
        Me.SalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.SalesDetailsToolStripMenuItem.Text = "Sales Details"
        '
        'StockDetailsToolStripMenuItem
        '
        Me.StockDetailsToolStripMenuItem.Name = "StockDetailsToolStripMenuItem"
        Me.StockDetailsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.StockDetailsToolStripMenuItem.Text = "Stock Details"
        '
        'ProductDetailsToolStripMenuItem
        '
        Me.ProductDetailsToolStripMenuItem.Name = "ProductDetailsToolStripMenuItem"
        Me.ProductDetailsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ProductDetailsToolStripMenuItem.Text = "Product Details"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCustomerDetailsToolStripMenuItem, Me.ViewPurchaseDetailsToolStripMenuItem, Me.ViewStockDetailsToolStripMenuItem, Me.ViewSalesDetailsToolStripMenuItem, Me.ViewProductDetailsToolStripMenuItem})
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'ViewCustomerDetailsToolStripMenuItem
        '
        Me.ViewCustomerDetailsToolStripMenuItem.Name = "ViewCustomerDetailsToolStripMenuItem"
        Me.ViewCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewCustomerDetailsToolStripMenuItem.Text = "View Customer Details"
        '
        'ViewPurchaseDetailsToolStripMenuItem
        '
        Me.ViewPurchaseDetailsToolStripMenuItem.Name = "ViewPurchaseDetailsToolStripMenuItem"
        Me.ViewPurchaseDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewPurchaseDetailsToolStripMenuItem.Text = "View Purchase Details"
        '
        'ViewStockDetailsToolStripMenuItem
        '
        Me.ViewStockDetailsToolStripMenuItem.Name = "ViewStockDetailsToolStripMenuItem"
        Me.ViewStockDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewStockDetailsToolStripMenuItem.Text = "View Stock Details"
        '
        'ViewSalesDetailsToolStripMenuItem
        '
        Me.ViewSalesDetailsToolStripMenuItem.Name = "ViewSalesDetailsToolStripMenuItem"
        Me.ViewSalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewSalesDetailsToolStripMenuItem.Text = "View Sales Details"
        '
        'ViewProductDetailsToolStripMenuItem
        '
        Me.ViewProductDetailsToolStripMenuItem.Name = "ViewProductDetailsToolStripMenuItem"
        Me.ViewProductDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewProductDetailsToolStripMenuItem.Text = "View Product Details"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 320)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DashboardForm"
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DashboardForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Custom startup logic here (optional)
    End Sub

End Class
