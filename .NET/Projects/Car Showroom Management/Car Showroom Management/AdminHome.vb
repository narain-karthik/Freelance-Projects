Public Class AdminHome

    Private Sub AdminHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to Admin Dashboard!", "Admin Home", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AddStaffDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStaffDetailsButton.Click
        Dim addStaffForm As New AddStaffDetails()
        addStaffForm.Show()
    End Sub

    Private Sub ViewStaffButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStaffButton.Click
        Dim addStaffForm As New ViewStaffDetails()
        addStaffForm.Show()
    End Sub

    Private Sub StaffAttendanceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffAttendanceButton.Click
        Dim addStaffForm As New StaffAttendance()
        addStaffForm.Show()

    End Sub

    Private Sub ViewStaffAttendanceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStaffAttendanceButton.Click
        Dim addStaffForm As New ViewStaffAttendance()
        addStaffForm.Show()
    End Sub

    Private Sub SoldOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoldOutButton.Click
        Dim addStaffForm As New SoldOut()
        addStaffForm.Show()
    End Sub

    Private Sub ViewSoldOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSoldOutButton.Click
        Dim addStaffForm As New ViewSold()
        addStaffForm.Show()
    End Sub
End Class