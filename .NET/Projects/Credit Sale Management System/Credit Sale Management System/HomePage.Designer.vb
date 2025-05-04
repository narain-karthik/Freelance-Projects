<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerCreditDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierCreditDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerCreditDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSupplierCreditDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.SuppToolStripMenuItem, Me.ViewDetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerDetailsToolStripMenuItem, Me.CustomerCreditDetailsToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(235, 24)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer Details"
        '
        'CustomerCreditDetailsToolStripMenuItem
        '
        Me.CustomerCreditDetailsToolStripMenuItem.Name = "CustomerCreditDetailsToolStripMenuItem"
        Me.CustomerCreditDetailsToolStripMenuItem.Size = New System.Drawing.Size(235, 24)
        Me.CustomerCreditDetailsToolStripMenuItem.Text = "Customer Credit Details"
        '
        'SuppToolStripMenuItem
        '
        Me.SuppToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierDetailsToolStripMenuItem, Me.SupplierCreditDetailsToolStripMenuItem})
        Me.SuppToolStripMenuItem.Name = "SuppToolStripMenuItem"
        Me.SuppToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.SuppToolStripMenuItem.Text = "Supplier "
        '
        'SupplierDetailsToolStripMenuItem
        '
        Me.SupplierDetailsToolStripMenuItem.Name = "SupplierDetailsToolStripMenuItem"
        Me.SupplierDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.SupplierDetailsToolStripMenuItem.Text = "Supplier Details"
        '
        'SupplierCreditDetailsToolStripMenuItem
        '
        Me.SupplierCreditDetailsToolStripMenuItem.Name = "SupplierCreditDetailsToolStripMenuItem"
        Me.SupplierCreditDetailsToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.SupplierCreditDetailsToolStripMenuItem.Text = "Supplier Credit Details"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsToolStripMenuItem, Me.CreditDetailsToolStripMenuItem, Me.ViewCustomerCreditDetailsToolStripMenuItem, Me.ViewSupplierCreditDetailsToolStripMenuItem})
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(271, 24)
        Me.DetailsToolStripMenuItem.Text = "View Customer Details"
        '
        'CreditDetailsToolStripMenuItem
        '
        Me.CreditDetailsToolStripMenuItem.Name = "CreditDetailsToolStripMenuItem"
        Me.CreditDetailsToolStripMenuItem.Size = New System.Drawing.Size(271, 24)
        Me.CreditDetailsToolStripMenuItem.Text = "View Supplier Details"
        '
        'ViewCustomerCreditDetailsToolStripMenuItem
        '
        Me.ViewCustomerCreditDetailsToolStripMenuItem.Name = "ViewCustomerCreditDetailsToolStripMenuItem"
        Me.ViewCustomerCreditDetailsToolStripMenuItem.Size = New System.Drawing.Size(271, 24)
        Me.ViewCustomerCreditDetailsToolStripMenuItem.Text = "View Customer Credit Details"
        '
        'ViewSupplierCreditDetailsToolStripMenuItem
        '
        Me.ViewSupplierCreditDetailsToolStripMenuItem.Name = "ViewSupplierCreditDetailsToolStripMenuItem"
        Me.ViewSupplierCreditDetailsToolStripMenuItem.Size = New System.Drawing.Size(271, 24)
        Me.ViewSupplierCreditDetailsToolStripMenuItem.Text = "View Supplier Credit Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO CREDIT SALES MANAGEMENT SYSTEM"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 299)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerCreditDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierCreditDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomerCreditDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSupplierCreditDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
