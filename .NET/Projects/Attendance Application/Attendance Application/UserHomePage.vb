Public Class UserHomePage
    Inherits Form

    Private Sub btnViewAttendance_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAttendance.Click
        ' Create a new instance of the AddStaffDetails form and show it
        Dim addStaffForm As New ViewAttendance()
        addStaffForm.Show()
    End Sub
End Class
