Public Class DashboardForm

    Private Sub MembersDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembersDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New MembersForm()
        membersForm.Show()
    End Sub

    Private Sub StaffDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New StaffDetails()
        membersForm.Show()
    End Sub

    Private Sub StaffAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffAttendanceToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New StaffAttendance()
        membersForm.Show()
    End Sub

    Private Sub MembersAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembersAttendanceToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New MembersAttendance()
        membersForm.Show()
    End Sub

    Private Sub ViewMembersDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMembersDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewMembersDetails()
        membersForm.Show()
    End Sub

    Private Sub ViewStaffDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStaffDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewStaffDetails()
        membersForm.Show()
    End Sub

    Private Sub ViewStaffAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStaffAttendanceToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewStaffAttendance()
        membersForm.Show()
    End Sub

    Private Sub ViewMembersAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMembersAttendanceToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewMembersAttendance()
        membersForm.Show()
    End Sub
End Class