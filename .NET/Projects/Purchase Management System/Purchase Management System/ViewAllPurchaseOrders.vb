Public Class ViewAllPurchaseOrders

    Private Sub ViewAllPurchaseOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchaseManagementDataSet1.PurchaseOrders' table. You can move, or remove it, as needed.
        Me.PurchaseOrdersTableAdapter1.Fill(Me.PurchaseManagementDataSet1.PurchaseOrders)


    End Sub

    
End Class