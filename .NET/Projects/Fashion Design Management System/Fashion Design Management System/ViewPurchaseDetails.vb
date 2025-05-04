Public Class ViewPurchaseDetails

    Private Sub ViewPurchaseDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FashionDataSet3.PurchaseDetails' table. You can move, or remove it, as needed.
        Me.PurchaseDetailsTableAdapter.Fill(Me.FashionDataSet3.PurchaseDetails)

    End Sub
End Class