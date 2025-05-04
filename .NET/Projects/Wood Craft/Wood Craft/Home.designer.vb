<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(651, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerDetails, Me.SupplierDetails, Me.ItemDetails, Me.PurchaseDetails, Me.SalesDetails, Me.StockDetails})
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'CustomerDetails
        '
        Me.CustomerDetails.Name = "CustomerDetails"
        Me.CustomerDetails.Size = New System.Drawing.Size(191, 24)
        Me.CustomerDetails.Text = "Customer Details"
        '
        'SupplierDetails
        '
        Me.SupplierDetails.Name = "SupplierDetails"
        Me.SupplierDetails.Size = New System.Drawing.Size(191, 24)
        Me.SupplierDetails.Text = "Supplier Details"
        '
        'ItemDetails
        '
        Me.ItemDetails.Name = "ItemDetails"
        Me.ItemDetails.Size = New System.Drawing.Size(191, 24)
        Me.ItemDetails.Text = "Item Details"
        '
        'PurchaseDetails
        '
        Me.PurchaseDetails.Name = "PurchaseDetails"
        Me.PurchaseDetails.Size = New System.Drawing.Size(191, 24)
        Me.PurchaseDetails.Text = "Purchase Details"
        '
        'SalesDetails
        '
        Me.SalesDetails.Name = "SalesDetails"
        Me.SalesDetails.Size = New System.Drawing.Size(191, 24)
        Me.SalesDetails.Text = "Sales Details"
        '
        'StockDetails
        '
        Me.StockDetails.Name = "StockDetails"
        Me.StockDetails.Size = New System.Drawing.Size(191, 24)
        Me.StockDetails.Text = "Stock Details"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerReport, Me.SupplierReport, Me.ItemReport, Me.PurchaseReport, Me.SalesReport, Me.StockReport})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'CustomerReport
        '
        Me.CustomerReport.Name = "CustomerReport"
        Me.CustomerReport.Size = New System.Drawing.Size(190, 24)
        Me.CustomerReport.Text = "Customer Report"
        '
        'SupplierReport
        '
        Me.SupplierReport.Name = "SupplierReport"
        Me.SupplierReport.Size = New System.Drawing.Size(190, 24)
        Me.SupplierReport.Text = "Supplier Report"
        '
        'ItemReport
        '
        Me.ItemReport.Name = "ItemReport"
        Me.ItemReport.Size = New System.Drawing.Size(190, 24)
        Me.ItemReport.Text = "Item Report"
        '
        'PurchaseReport
        '
        Me.PurchaseReport.Name = "PurchaseReport"
        Me.PurchaseReport.Size = New System.Drawing.Size(190, 24)
        Me.PurchaseReport.Text = "Purchase Report"
        '
        'SalesReport
        '
        Me.SalesReport.Name = "SalesReport"
        Me.SalesReport.Size = New System.Drawing.Size(190, 24)
        Me.SalesReport.Text = "Sales Report"
        '
        'StockReport
        '
        Me.StockReport.Name = "StockReport"
        Me.StockReport.Size = New System.Drawing.Size(190, 24)
        Me.StockReport.Text = "Stock Report"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(169, 56)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(307, 25)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Wood Craft Admin Home Page"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 199)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerDetails As ToolStripMenuItem
    Friend WithEvents SupplierDetails As ToolStripMenuItem
    Friend WithEvents ItemDetails As ToolStripMenuItem
    Friend WithEvents PurchaseDetails As ToolStripMenuItem
    Friend WithEvents SalesDetails As ToolStripMenuItem
    Friend WithEvents StockDetails As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerReport As ToolStripMenuItem
    Friend WithEvents SupplierReport As ToolStripMenuItem
    Friend WithEvents ItemReport As ToolStripMenuItem
    Friend WithEvents PurchaseReport As ToolStripMenuItem
    Friend WithEvents SalesReport As ToolStripMenuItem
    Friend WithEvents StockReport As ToolStripMenuItem
    Friend WithEvents Label As System.Windows.Forms.Label
End Class
