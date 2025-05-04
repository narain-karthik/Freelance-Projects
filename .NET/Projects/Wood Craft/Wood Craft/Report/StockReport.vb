Public Class StockReport

    Private Sub StockReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet5.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.WoodDataSet5.Stock)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class