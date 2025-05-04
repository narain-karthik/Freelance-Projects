Public Class ViewStaffAttendance

    Private Sub ViewStaffAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GymDataSet2.StaffAttendance' table. You can move, or remove it, as needed.
        Me.StaffAttendanceTableAdapter.Fill(Me.GymDataSet2.StaffAttendance)

    End Sub
End Class