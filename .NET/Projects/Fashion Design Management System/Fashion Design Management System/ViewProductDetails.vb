Public Class ViewProductDetails

    Private Sub ViewProductDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FashionDataSet2.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.FashionDataSet2.Products)

    End Sub
End Class