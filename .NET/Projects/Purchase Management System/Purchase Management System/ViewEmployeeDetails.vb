Public Class ViewEmployeeDetails

    Private Sub ViewEmployeeDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchaseManagementDataSet4.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter1.Fill(Me.PurchaseManagementDataSet4.Employees)

    End Sub
End Class