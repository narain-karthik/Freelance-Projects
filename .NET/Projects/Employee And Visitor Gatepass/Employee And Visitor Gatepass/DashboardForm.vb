
Public Class DashboardForm

    Private Sub EmployeeDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        ' Open EmployeeDetailsForm when Employee Details is clicked
        Dim employeeForm As New EmployeeDetailsForm()
        employeeForm.Show()
    End Sub

    Private Sub VisitorDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles VisitorDetailsToolStripMenuItem.Click
        ' Open VisitorDetailsForm when Visitor Details is clicked
        Dim visitorForm As New VisitorDetailsForm()
        visitorForm.Show()
    End Sub

    Private Sub PassRequestEmployeeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PassRequestEmployeeToolStripMenuItem.Click
        ' Open PassRequestEmployeeForm when Pass Request - Employee is clicked
        Dim passEmployeeForm As New PassRequestEmployeeForm()
        passEmployeeForm.Show()
    End Sub

    Private Sub PassRequestVistorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PassRequestVistorToolStripMenuItem.Click
        ' Open PassRequestVisitorForm when Pass Request - Visitor is clicked
        Dim passVisitorForm As New PassRequestVisitorForm()
        passVisitorForm.Show()
    End Sub

    Private Sub ViewEmployeeDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewEmployeeDetailsToolStripMenuItem.Click
        ' Open ViewEmployeeDetailsForm when View Employee Details is clicked
        Dim viewEmployeeForm As New ViewEmployeeDetailsForm()
        viewEmployeeForm.Show()
    End Sub

    Private Sub ViewVisitorDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewVisitorDetailsToolStripMenuItem.Click
        ' Open ViewVisitorDetailsForm when View Visitor Details is clicked
        Dim viewVisitorForm As New ViewVisitorDetailsForm()
        viewVisitorForm.Show()
    End Sub

    Private Sub ViewPassRequestEmployeeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewPassRequestEmployeeToolStripMenuItem.Click
        ' Open ViewPassRequestEmployeeForm when View Pass Request - Employee is clicked
        Dim viewPassEmployeeForm As New ViewPassRequestEmployeeForm()
        viewPassEmployeeForm.Show()
    End Sub

    Private Sub PassRequestVistorToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PassRequestVistorToolStripMenuItem1.Click
        ' Open ViewPassRequestVisitorForm when View Pass Request - Visitor is clicked
        Dim viewPassVisitorForm As New ViewPassRequestVisitorForm()
        viewPassVisitorForm.Show()
    End Sub

End Class

