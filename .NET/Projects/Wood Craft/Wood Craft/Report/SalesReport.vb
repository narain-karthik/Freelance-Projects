Public Class SalesReport

    Private Sub SalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet4.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.WoodDataSet4.Sales)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class