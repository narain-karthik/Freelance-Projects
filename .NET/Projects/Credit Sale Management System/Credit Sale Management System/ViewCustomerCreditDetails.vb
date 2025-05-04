Public Class ViewCustomerCreditDetails

    Private Sub ViewCustomerCreditDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CreditDataSet2.CustomerCredit' table. You can move, or remove it, as needed.
        Me.CustomerCreditTableAdapter.Fill(Me.CreditDataSet2.CustomerCredit)

    End Sub
End Class