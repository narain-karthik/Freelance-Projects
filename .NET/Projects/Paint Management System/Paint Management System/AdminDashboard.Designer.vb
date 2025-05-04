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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PurchaseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPurchaseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ContentPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(226, 145)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(182, 25)
        Me.WelcomeLabel.TabIndex = 0
        Me.WelcomeLabel.Text = "Welcome, Admin!"
        Me.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseDetailsToolStripMenuItem, Me.ViewDetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(635, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PurchaseDetailsToolStripMenuItem
        '
        Me.PurchaseDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseDetailsToolStripMenuItem1, Me.CustomerDetailsToolStripMenuItem, Me.StockDetailsToolStripMenuItem, Me.SalesDetailsToolStripMenuItem})
        Me.PurchaseDetailsToolStripMenuItem.Name = "PurchaseDetailsToolStripMenuItem"
        Me.PurchaseDetailsToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.PurchaseDetailsToolStripMenuItem.Text = "Add Details"
        '
        'PurchaseDetailsToolStripMenuItem1
        '
        Me.PurchaseDetailsToolStripMenuItem1.Name = "PurchaseDetailsToolStripMenuItem1"
        Me.PurchaseDetailsToolStripMenuItem1.Size = New System.Drawing.Size(191, 24)
        Me.PurchaseDetailsToolStripMenuItem1.Text = "Purchase Details"
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
        'SalesDetailsToolStripMenuItem
        '
        Me.SalesDetailsToolStripMenuItem.Name = "SalesDetailsToolStripMenuItem"
        Me.SalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.SalesDetailsToolStripMenuItem.Text = "Sales Details"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPurchaseDetailsToolStripMenuItem, Me.ViewCustomerDetailsToolStripMenuItem, Me.ViewStockDetailsToolStripMenuItem, Me.ViewSalesDetailsToolStripMenuItem})
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
        'ViewSalesDetailsToolStripMenuItem
        '
        Me.ViewSalesDetailsToolStripMenuItem.Name = "ViewSalesDetailsToolStripMenuItem"
        Me.ViewSalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.ViewSalesDetailsToolStripMenuItem.Text = "View Sales Details"
        '
        'ContentPanel
        '
        Me.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContentPanel.Controls.Add(Me.Label2)
        Me.ContentPanel.Controls.Add(Me.Label1)
        Me.ContentPanel.Controls.Add(Me.LogoPictureBox)
        Me.ContentPanel.Controls.Add(Me.WelcomeLabel)
        Me.ContentPanel.Location = New System.Drawing.Point(12, 80)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(612, 303)
        Me.ContentPanel.TabIndex = 2
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.ErrorImage = CType(resources.GetObject("LogoPictureBox.ErrorImage"), System.Drawing.Image)
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(10, 10)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PANCHAVARNAM PAINTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(473, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Panchavarnam Paints – Ensuring Smooth & Reliable Management!"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 396)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Painting Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContentPanel.ResumeLayout(False)
        Me.ContentPanel.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PurchaseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPurchaseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSalesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class