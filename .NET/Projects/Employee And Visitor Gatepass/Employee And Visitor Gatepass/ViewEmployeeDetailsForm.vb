Public Class ViewEmployeeDetailsForm

    Private Sub ViewEmployeeDetailsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GatepassDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.GatepassDataSet.Employees)

    End Sub
End Class