Public Class ViewSold

    Private Sub ViewSold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDataSet5.SoldOutCars' table. You can move, or remove it, as needed.
        Me.SoldOutCarsTableAdapter.Fill(Me.CarDataSet5.SoldOutCars)

    End Sub
End Class