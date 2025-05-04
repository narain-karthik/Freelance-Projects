Public Class ViewCancellation

    Private Sub ViewCancellation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RailwayDataSet4.Tickets' table. You can move, or remove it, as needed.
        Me.TicketsTableAdapter.Fill(Me.RailwayDataSet4.Tickets)

    End Sub
End Class