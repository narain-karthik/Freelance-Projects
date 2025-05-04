Public Class CustomerReport

    
    Private Sub CustomerReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.WoodDataSet.Customers)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class