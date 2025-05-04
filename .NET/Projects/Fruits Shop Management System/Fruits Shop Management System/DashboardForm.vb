Public Class DashboardForm

    Private Sub CustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        Dim customerForm As New CustomerDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub PurchaseDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseDetailsToolStripMenuItem.Click
        Dim customerForm As New PurchaseDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ProductDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductDetailsToolStripMenuItem.Click
        Dim customerForm As New ProductDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub

    Private Sub SalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesDetailsToolStripMenuItem.Click
        Dim customerForm As New SalesDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub

    Private Sub StockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockDetailsToolStripMenuItem.Click
        Dim customerForm As New StockDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewCustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomerDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewCustomerDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewPurchaseDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPurchaseDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewPurchaseDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewStockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewStockDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewSalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSalesDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewSalesDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewProductDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewProductDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewProductDetails() ' Replace PurchaseDetails Form with the actual form class
        customerForm.Show()
    End Sub
End Class