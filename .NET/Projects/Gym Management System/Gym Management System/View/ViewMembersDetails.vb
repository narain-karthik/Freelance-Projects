Public Class ViewMembersDetails

    Private Sub ViewMembersDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GymDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.GymDataSet.Members)

    End Sub
End Class