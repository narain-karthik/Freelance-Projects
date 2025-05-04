Public Class ViewSupplierCreditDetails

    Private Sub ViewSupplierCreditDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CreditDataSet3.SupplierCredit' table. You can move, or remove it, as needed.
        Me.SupplierCreditTableAdapter.Fill(Me.CreditDataSet3.SupplierCredit)

    End Sub
End Class