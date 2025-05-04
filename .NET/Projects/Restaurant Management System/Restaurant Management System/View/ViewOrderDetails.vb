Public Class ViewOrderDetails

    Private Sub ViewOrderDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet2.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.RestaurantDataSet2.Orders)

    End Sub
End Class