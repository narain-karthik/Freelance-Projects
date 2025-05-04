Public Class ViewStaffAttendance

    Private Sub ViewStaffAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDataSet4.AttendanceRecords' table. You can move, or remove it, as needed.
        Me.AttendanceRecordsTableAdapter.Fill(Me.CarDataSet4.AttendanceRecords)

    End Sub
End Class