Public Class ViewPassRequestEmployeeForm

    Private Sub ViewPassRequestEmployeeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GatepassDataSet1.PassRequest' table. You can move, or remove it, as needed.
        Me.PassRequestTableAdapter.Fill(Me.GatepassDataSet1.PassRequest)

    End Sub
End Class