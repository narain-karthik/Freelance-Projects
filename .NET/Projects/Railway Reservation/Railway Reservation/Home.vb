Public Class Home

    Private Sub ReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem.Click
        Dim reservation As New Reservation()
        reservation.Show()
    End Sub

    Private Sub UnreservationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnreservationToolStripMenuItem1.Click
        Dim unreservation As New Unreservation()
        unreservation.Show()
    End Sub

    Private Sub UnreservationToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnreservationToolStripMenuItem2.Click
        Dim VUR As New ViewUnreservation()
        VUR.Show()
    End Sub

    Private Sub ReservationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem1.Click
        Dim VR As New ViewReservation()
        VR.Show()
    End Sub

    Private Sub FareDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FareDetailsToolStripMenuItem1.Click
        Dim FD As New FareDetails()
        FD.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim A As New Form1()
        A.Show()
    End Sub

    Private Sub TrainDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainDetailsToolStripMenuItem.Click
        Dim Train As New TrainDetails()
        Train.Show()
    End Sub

    Private Sub CancellationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellationToolStripMenuItem.Click
        Dim cancle As New Cancellation()
        cancle.Show()
    End Sub

    Private Sub CancellationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellationToolStripMenuItem1.Click
        Dim view As New ViewCancellation()
        view.Show()
    End Sub
End Class