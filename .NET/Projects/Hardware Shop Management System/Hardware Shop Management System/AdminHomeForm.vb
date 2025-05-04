Public Class AdminHomeForm

    Private Sub PURCHASEDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PURCHASEDETAILSToolStripMenuItem.Click
        Dim purchaseForm As New PurchaseDetailsForm()
        purchaseForm.Show()
    End Sub

    Private Sub SALESDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESDETAILSToolStripMenuItem.Click
        Dim salesForm As New SalesDetailsForm()
        salesForm.Show()
    End Sub

    Private Sub STOCKDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCKDETAILSToolStripMenuItem.Click
        Dim stockForm As New StockDetailsForm()
        stockForm.Show()
    End Sub

    Private Sub CUSTOMERDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERDETAILSToolStripMenuItem.Click
        Dim customerForm As New CustomerDetailsForm()
        customerForm.Show()
    End Sub
End Class