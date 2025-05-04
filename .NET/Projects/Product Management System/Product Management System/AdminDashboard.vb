Public Class AdminDashboard
    Private Sub AdminDashboard_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set default content or leave blank
        LabelWelcome.Text = "Sree Aadhi Industries - Welcome, Admin!  (" & DateTime.Now.ToString("dd/MM/yyyy") & ")"
    End Sub

    ' Clear the content panel before loading a new form
    Private Sub ClearContentPanel()
        ContentPanel.Controls.Clear()
    End Sub

    ' Add Details Menu Items
    Private Sub PurchaseDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PurchaseDetailsToolStripMenuItem.Click
        ClearContentPanel()
        Dim purchaseForm As New PurchaseDetails()
        purchaseForm.TopLevel = False
        purchaseForm.FormBorderStyle = FormBorderStyle.None
        purchaseForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(purchaseForm)
        purchaseForm.Show()
    End Sub

    Private Sub SalesDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SalesDetailsToolStripMenuItem.Click
        ClearContentPanel()
        Dim salesForm As New SalesDetails()
        salesForm.TopLevel = False
        salesForm.FormBorderStyle = FormBorderStyle.None
        salesForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(salesForm)
        salesForm.Show()
    End Sub

    Private Sub CustomerDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        ClearContentPanel()
        Dim customerForm As New CustomerDetails()
        customerForm.TopLevel = False
        customerForm.FormBorderStyle = FormBorderStyle.None
        customerForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(customerForm)
        customerForm.Show()
    End Sub

    Private Sub StockDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StockDetailsToolStripMenuItem.Click
        ClearContentPanel()
        Dim stockForm As New StockDetails()
        stockForm.TopLevel = False
        stockForm.FormBorderStyle = FormBorderStyle.None
        stockForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(stockForm)
        stockForm.Show()
    End Sub

    ' View Details Menu Items
    Private Sub ViewPurchaseDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewPurchaseDetailsToolStripMenuItem.Click
        ClearContentPanel()
        Dim viewPurchaseForm As New ViewPurchaseDetails()
        viewPurchaseForm.TopLevel = False
        viewPurchaseForm.FormBorderStyle = FormBorderStyle.None
        viewPurchaseForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(viewPurchaseForm)
        viewPurchaseForm.Show()
    End Sub

    Private Sub ViewSalesDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewSalesDetailsToolStripMenuItem.Click
        ClearContentPanel()
        Dim viewSalesForm As New ViewSalesDetails()
        viewSalesForm.TopLevel = False
        viewSalesForm.FormBorderStyle = FormBorderStyle.None
        viewSalesForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(viewSalesForm)
        viewSalesForm.Show()
    End Sub

    Private Sub ViewCustomerDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewCustomerDetailsToolStripMenuItem.Click
        ClearContentPanel()
        Dim viewCustomerForm As New ViewCustomerDetails()
        viewCustomerForm.TopLevel = False
        viewCustomerForm.FormBorderStyle = FormBorderStyle.None
        viewCustomerForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(viewCustomerForm)
        viewCustomerForm.Show()
    End Sub

    Private Sub ViewStockDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewStockDetailsToolStripMenuItem.Click
        ClearContentPanel()
        Dim viewStockForm As New ViewStockDetails()
        viewStockForm.TopLevel = False
        viewStockForm.FormBorderStyle = FormBorderStyle.None
        viewStockForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(viewStockForm)
        viewStockForm.Show()
    End Sub

    ' Logout button
    Private Sub ButtonLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close() ' Or redirect to login form if implemented
        End If
    End Sub
End Class