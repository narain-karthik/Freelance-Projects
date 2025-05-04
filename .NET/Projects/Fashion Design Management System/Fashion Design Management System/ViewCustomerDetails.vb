Public Class ViewCustomerDetails

    Private Sub ViewCustomerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FashionDataSet1.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.FashionDataSet1.Customers)

    End Sub
End Class