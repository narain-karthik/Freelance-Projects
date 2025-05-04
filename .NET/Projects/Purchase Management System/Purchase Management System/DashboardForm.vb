Public Class DashboardForm

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        Dim viewForm As New Suppliers()
        viewForm.ShowDialog()
    End Sub

    Private Sub ViewAllSuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllSuppliersToolStripMenuItem.Click
        Dim viewForm As New ViewAllSuppliers()
        viewForm.ShowDialog()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim viewForm As New Products()
        viewForm.ShowDialog()
    End Sub

    Private Sub ViewAllProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllProductsToolStripMenuItem.Click
        Dim viewForm As New ViewAllProducts()
        viewForm.ShowDialog()
    End Sub

    Private Sub PurchaseOrdersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrdersToolStripMenuItem.Click
        Dim viewForm As New PurchaseOrders()
        viewForm.ShowDialog()
    End Sub

    Private Sub ViewAllPurchaseOrdersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllPurchaseOrdersToolStripMenuItem.Click
        Dim viewForm As New ViewAllPurchaseOrders()
        viewForm.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        Dim viewForm As New Stock()
        viewForm.ShowDialog()
    End Sub

    Private Sub ViewStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockToolStripMenuItem.Click
        Dim viewForm As New ViewStock()
        viewForm.ShowDialog()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ' Logic to logout and maybe show LoginForm
        Me.Hide()
        Dim loginForm As New Form1()
        loginForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim viewForm As New EmployeeForm()
        viewForm.ShowDialog()
    End Sub

    Private Sub ViewEmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEmployeeDetailsToolStripMenuItem.Click
        Dim viewForm As New ViewEmployeeDetails()
        viewForm.ShowDialog()
    End Sub
End Class