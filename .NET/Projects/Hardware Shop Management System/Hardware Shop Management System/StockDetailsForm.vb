Imports System.Data.SqlClient

Public Class StockDetailsForm
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Hardware;Integrated Security=True"

    Private Sub btnAddStock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddStock.Click
        Dim con As New SqlConnection(connectionString)
        Try
            con.Open()

            Dim query As String = "INSERT INTO StockDetails (ProductID, ProductName, OneProductPrice, StockQuantity) VALUES (@ProductID, @ProductName, @OneProductPrice, @StockQuantity)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ProductID", ProductIDTextBox.Text)
                cmd.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text)
                cmd.Parameters.AddWithValue("@OneProductPrice", OneProductPriceTextBox.Text)
                cmd.Parameters.AddWithValue("@StockQuantity", StockDetailsTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Stock details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

End Class
