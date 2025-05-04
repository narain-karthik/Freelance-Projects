Public Class AdminHome

    Private Sub CustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New CustomerDetails()
        membersForm.Show()
    End Sub

    Private Sub SalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New SalesDetails()
        membersForm.Show()
    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New EmployeeDetails()
        membersForm.Show()
    End Sub

    Private Sub ViewCustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomerDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewCustomerDetails()
        membersForm.Show()
    End Sub

    Private Sub ViewSalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSalesDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewSalesDetails()
        membersForm.Show()
    End Sub

    Private Sub ViewEmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEmployeeDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewEmployeeDetails()
        membersForm.Show()
    End Sub
End Class