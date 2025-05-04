Public Class ViewEmployeeDetails

    Private Sub ViewEmployeeDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.RestaurantDataSet.Employee)

    End Sub
End Class