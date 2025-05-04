Public Class AdminDashboard

    Private Sub PurchaseDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseDetailsToolStripMenuItem1.Click
        Dim customerForm As New PurchaseDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub


    Private Sub CustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        Dim customerForm As New CustomerDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub StockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockDetailsToolStripMenuItem.Click
        Dim customerForm As New StockDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub SalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesDetailsToolStripMenuItem.Click
        Dim customerForm As New SalesDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewPurchaseDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPurchaseDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewPurchaseDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewCustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomerDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewCustomerDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewStockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewStockDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewSalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSalesDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewSalesDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub
End Class