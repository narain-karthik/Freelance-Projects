Public Class ViewTableDetails

    Private Sub ViewTableDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet3.TableDetails' table. You can move, or remove it, as needed.
        Me.TableDetailsTableAdapter.Fill(Me.RestaurantDataSet3.TableDetails)

    End Sub
End Class