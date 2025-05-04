Public Class ViewReservation

    Private Sub ViewReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RailwayDataSet1.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.RailwayDataSet1.Reservation)

    End Sub
End Class