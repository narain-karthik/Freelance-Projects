Public Class ItemReport

    Private Sub ItemReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet2.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.WoodDataSet2.Item)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class