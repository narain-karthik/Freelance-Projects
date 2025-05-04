Public Class ViewStaffDetails

    Private Sub ViewStaffDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GymDataSet1.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.GymDataSet1.Staff)

    End Sub
End Class