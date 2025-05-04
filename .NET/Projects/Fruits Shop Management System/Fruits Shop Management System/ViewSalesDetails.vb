Imports System.Data.SqlClient

Public Class ViewSalesDetails

    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fruit;Integrated Security=True")

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM SalesDetails", con)
            da.Fill(dt)
            dgvSalesDetails.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message)
        End Try
    End Sub

End Class
