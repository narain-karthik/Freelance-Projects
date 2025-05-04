Public Class ViewPro

    Private Sub ViewPro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComputerDataSet2.ProductDetails' table. You can move, or remove it, as needed.
        Me.ProductDetailsTableAdapter.Fill(Me.ComputerDataSet2.ProductDetails)

    End Sub
End Class