Public Class ViewStockDetails

    Private Sub ViewStockDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FashionDataSet5.FashionStockDetails' table. You can move, or remove it, as needed.
        Me.FashionStockDetailsTableAdapter.Fill(Me.FashionDataSet5.FashionStockDetails)

    End Sub
End Class