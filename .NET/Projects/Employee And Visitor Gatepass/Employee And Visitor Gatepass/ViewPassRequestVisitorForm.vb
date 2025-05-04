Public Class ViewPassRequestVisitorForm

    Private Sub ViewPassRequestVisitorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GatepassDataSet2.PassRequestVisitor' table. You can move, or remove it, as needed.
        Me.PassRequestVisitorTableAdapter.Fill(Me.GatepassDataSet2.PassRequestVisitor)

    End Sub
End Class