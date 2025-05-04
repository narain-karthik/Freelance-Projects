Imports System.Data.SqlClient

Public Class ViewCustomerDetails

    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fruit;Integrated Security=True")

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM Customers", con)
            da.Fill(dt)
            dgvCustomerDetails.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try
    End Sub

End Class
