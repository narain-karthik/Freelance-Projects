<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPurchaseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDetailsToolStripMenuItem, Me.ViewDetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddDetailsToolStripMenuItem
        '
        Me.AddDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseDetailsToolStripMenuItem, Me.SalesDetailsToolStripMenuItem, Me.CustomerDetailsToolStripMenuItem, Me.StockDetailsToolStripMenuItem})
        Me.AddDetailsToolStripMenuItem.Name = "AddDetailsToolStripMenuItem"
        Me.AddDetailsToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.AddDetailsToolStripMenuItem.Text = "Add Details"
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
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer Details"
        '
        'StockDetailsToolStripMenuItem
        '
        Me.StockDetailsToolStripMenuItem.Name = "StockDetailsToolStripMenuItem"
        Me.StockDetailsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.StockDetailsToolStripMenuItem.Text = "Stock Details"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPurchaseDetailsToolStripMenuItem, Me.ViewSalesDetailsToolStripMenuItem, Me.ViewCustomerDetailsToolStripMenuItem, Me.ViewStockDetailsToolStripMenuItem})
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'ViewPurchaseDetailsToolStripMenuItem
        '
        Me.ViewPurchaseDetailsToolStripMenuItem.Name = "ViewPurchaseDetailsToolStripMenuItem"
        Me.ViewPurchaseDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewPurchaseDetailsToolStripMenuItem.Text = "View Purchase Details"
        '
        'ViewSalesDetailsToolStripMenuItem
        '
        Me.ViewSalesDetailsToolStripMenuItem.Name = "ViewSalesDetailsToolStripMenuItem"
        Me.ViewSalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewSalesDetailsToolStripMenuItem.Text = "View Sales Details"
        '
        'ViewCustomerDetailsToolStripMenuItem
        '
        Me.ViewCustomerDetailsToolStripMenuItem.Name = "ViewCustomerDetailsToolStripMenuItem"
        Me.ViewCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewCustomerDetailsToolStripMenuItem.Text = "View Customer Details"
        '
        'ViewStockDetailsToolStripMenuItem
        '
        Me.ViewStockDetailsToolStripMenuItem.Name = "ViewStockDetailsToolStripMenuItem"
        Me.ViewStockDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewStockDetailsToolStripMenuItem.Text = "View Stock Details"
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ContentPanel.Location = New System.Drawing.Point(12, 60)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(776, 478)
        Me.ContentPanel.TabIndex = 1
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.Location = New System.Drawing.Point(12, 31)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(400, 28)
        Me.LabelWelcome.TabIndex = 2
        Me.LabelWelcome.Text = "Sree Aadhi Industries - Welcome, Admin!"
        '
        'ButtonLogout
        '
        Me.ButtonLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogout.ForeColor = System.Drawing.Color.White
        Me.ButtonLogout.Location = New System.Drawing.Point(708, 31)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(80, 28)
        Me.ButtonLogout.TabIndex = 3
        Me.ButtonLogout.Text = "Logout"
        Me.ButtonLogout.UseVisualStyleBackColor = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.ButtonLogout)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard - Production Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPurchaseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSalesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents LabelWelcome As System.Windows.Forms.Label
    Friend WithEvents ButtonLogout As System.Windows.Forms.Button
End Class