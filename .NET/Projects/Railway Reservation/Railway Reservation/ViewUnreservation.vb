Public Class ViewUnreservation

    Private Sub ViewUnreservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RailwayDataSet.Unreservation' table. You can move, or remove it, as needed.
        Me.UnreservationTableAdapter.Fill(Me.RailwayDataSet.Unreservation)

    End Sub
End Class