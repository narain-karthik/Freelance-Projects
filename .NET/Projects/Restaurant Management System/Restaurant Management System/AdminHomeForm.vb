Public Class AdminHomeForm

    Private Sub TableManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableManagementToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New TableManagement()
        membersForm.Show()
    End Sub

    Private Sub MenuManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuManagementToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New MenuManagement()
        membersForm.Show()
    End Sub

    Private Sub OrderManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderManagementToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New OrderManagement()
        membersForm.Show()
    End Sub

    Private Sub EmployeeManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeManagementToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New EmployeeManagement()
        membersForm.Show()
    End Sub

    
    Private Sub ViewTableDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTableDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewTableDetails()
        membersForm.Show()
    End Sub

    Private Sub ViewMenuDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMenuDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewMenuDetails()
        membersForm.Show()
    End Sub

    Private Sub ViewOrderDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewOrderDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewOrderDetails()
        membersForm.Show()
    End Sub

    Private Sub ViewEmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEmployeeDetailsToolStripMenuItem.Click
        ' Open the Members Form
        Dim membersForm As New ViewEmployeeDetails()
        membersForm.Show()
    End Sub
End Class