Imports System.Data.SqlClient

Public Class ViewStockDetails

    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fruit;Integrated Security=True")

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM StockDetails", con)
            da.Fill(dt)
            dgvStockDetails.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading stock details: " & ex.Message)
        End Try
    End Sub

End Class
