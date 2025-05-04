Public Class ViewMenuDetails

    Private Sub ViewMenuDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet1.MenuItems' table. You can move, or remove it, as needed.
        Me.MenuItemsTableAdapter.Fill(Me.RestaurantDataSet1.MenuItems)

    End Sub
End Class