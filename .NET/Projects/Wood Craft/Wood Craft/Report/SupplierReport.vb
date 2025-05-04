Public Class SupplierReport

    Private Sub SupplierReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet1.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.WoodDataSet1.Supplier)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class