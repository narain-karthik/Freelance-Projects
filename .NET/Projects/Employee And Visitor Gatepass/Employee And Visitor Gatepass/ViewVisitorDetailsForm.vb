Public Class ViewVisitorDetailsForm

    Private Sub ViewVisitorDetailsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GatepassDataSet3.VisitorDetails' table. You can move, or remove it, as needed.
        Me.VisitorDetailsTableAdapter.Fill(Me.GatepassDataSet3.VisitorDetails)

    End Sub
End Class