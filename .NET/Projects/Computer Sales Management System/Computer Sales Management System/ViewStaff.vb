Public Class ViewStaff

    Private Sub ViewStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComputerDataSet.StaffDetails' table. You can move, or remove it, as needed.
        Me.StaffDetailsTableAdapter.Fill(Me.ComputerDataSet.StaffDetails)

    End Sub
End Class