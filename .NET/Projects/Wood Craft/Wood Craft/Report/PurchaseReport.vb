Public Class PurchaseReport

    Private Sub PurchaseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet3.Purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter.Fill(Me.WoodDataSet3.Purchase)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class