Public Class ViewStaffDetails

    Private Sub ViewStaffDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDataSet.StaffDetails' table. You can move, or remove it, as needed.
        Me.StaffDetailsTableAdapter.Fill(Me.CarDataSet.StaffDetails)

    End Sub
End Class