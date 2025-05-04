Public Class FareDetails

    Private Sub FareDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RailwayDataSet2.FareDetails' table. You can move, or remove it, as needed.
        Me.FareDetailsTableAdapter.Fill(Me.RailwayDataSet2.FareDetails)

    End Sub
End Class