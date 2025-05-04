Public Class Home

    Dim Response As Object

    Private Sub CustomerDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetails.Click
        Dim customerForm As New Customer() ' Replace CustomerForm with the actual form class
        customerForm.Show()
    End Sub

    Private Sub SupplierDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierDetails.Click
        Dim supplier As New Supplier()
        supplier.Show()
    End Sub

    Private Sub ItemDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDetails.Click
        Dim Item As New Item()
        Item.Show()
    End Sub

    Private Sub PurchaseDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseDetails.Click
        Dim pur As New Purchase()
        pur.Show()
    End Sub

    Private Sub SalesDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesDetails.Click
        Dim Sales As New Sales()
        Sales.Show()
    End Sub

    Private Sub StockDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockDetails.Click
        Dim St As New StockDetails()
        St.Show()
    End Sub

    Private Sub CustomerReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReport.Click
        Dim CR As New CustomerReport()
        CR.Show()
    End Sub

    Private Sub SupplierReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierReport.Click
        Dim SR As New SupplierReport()
        SR.Show()
    End Sub

    Private Sub ItemReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemReport.Click
        Dim IR As New ItemReport()
        IR.Show()
    End Sub

    Private Sub PurchaseReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReport.Click
        Dim PR As New PurchaseReport()
        PR.Show()
    End Sub

    Private Sub SalesReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReport.Click
        Dim SRR As New SalesReport()
        SRR.Show()
    End Sub

    Private Sub StockReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockReport.Click
        Dim SRRR As New StockReport()
        SRRR.Show()
    End Sub
End Class