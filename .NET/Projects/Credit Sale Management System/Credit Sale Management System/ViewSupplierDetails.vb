Public Class ViewSupplierDetails

    Private Sub ViewSupplierDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CreditDataSet1.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.CreditDataSet1.Supplier)

    End Sub
End Class