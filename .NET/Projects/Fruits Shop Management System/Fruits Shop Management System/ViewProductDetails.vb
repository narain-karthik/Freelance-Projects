Imports System.Data.SqlClient

Public Class ViewProductDetails

    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fruit;Integrated Security=True")

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM Fruits", con)
            da.Fill(dt)
            dgvProductDetails.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading product details: " & ex.Message)
        End Try
    End Sub

End Class
