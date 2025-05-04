Public Class ViewSalesDetails

    Private Sub ViewSalesDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FashionDataSet4.SalesDetails' table. You can move, or remove it, as needed.
        Me.SalesDetailsTableAdapter.Fill(Me.FashionDataSet4.SalesDetails)

    End Sub
End Class