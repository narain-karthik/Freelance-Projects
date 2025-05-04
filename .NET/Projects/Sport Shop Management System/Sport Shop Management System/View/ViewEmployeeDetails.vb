Public Class ViewEmployeeDetails

    Private Sub ViewEmployeeDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SportDataSet2.EmployeeDetails' table. You can move, or remove it, as needed.
        Me.EmployeeDetailsTableAdapter.Fill(Me.SportDataSet2.EmployeeDetails)

    End Sub
End Class