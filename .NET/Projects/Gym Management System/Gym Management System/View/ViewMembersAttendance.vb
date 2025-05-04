Public Class ViewMembersAttendance

    Private Sub ViewMembersAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GymDataSet3.MembersAttendance' table. You can move, or remove it, as needed.
        Me.MembersAttendanceTableAdapter.Fill(Me.GymDataSet3.MembersAttendance)

    End Sub
End Class