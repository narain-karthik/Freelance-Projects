Public Class HomePage

    Private Sub CustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        Dim customerForm As New CustomerDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub SupplierDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierDetailsToolStripMenuItem.Click
        Dim customerForm As New SupplierDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub CustomerCreditDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerCreditDetailsToolStripMenuItem.Click
        Dim customerForm As New CustomerCreditDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub SupplierCreditDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierCreditDetailsToolStripMenuItem.Click
        Dim customerForm As New SupplierCreditDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        Dim customerForm As New ViewCustomerDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub CreditDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewSupplierDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewCustomerCreditDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomerCreditDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewCustomerCreditDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub ViewSupplierCreditDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSupplierCreditDetailsToolStripMenuItem.Click
        Dim customerForm As New ViewSupplierCreditDetails() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub
End Class