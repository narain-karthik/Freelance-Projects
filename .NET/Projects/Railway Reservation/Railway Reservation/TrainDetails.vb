Public Class TrainDetails

    Private Sub TrainDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RailwayDataSet3.TrainDetail' table. You can move, or remove it, as needed.
        Me.TrainDetailTableAdapter.Fill(Me.RailwayDataSet3.TrainDetail)

    End Sub
End Class