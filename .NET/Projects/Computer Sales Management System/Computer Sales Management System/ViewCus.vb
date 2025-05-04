Public Class ViewCus

    Private Sub ViewCus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComputerDataSet1.CustomerDetails' table. You can move, or remove it, as needed.
        Me.CustomerDetailsTableAdapter.Fill(Me.ComputerDataSet1.CustomerDetails)

    End Sub
End Class