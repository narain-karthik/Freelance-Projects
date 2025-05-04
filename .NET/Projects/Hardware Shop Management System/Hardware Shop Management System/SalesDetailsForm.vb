Imports System.Data.SqlClient

Public Class SalesDetailsForm

    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Hardware;Integrated Security=True"

    Private Sub btnAddSales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddSales.Click
        Try
            ' Validation
            If String.IsNullOrWhiteSpace(ProductNameTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(QuantityTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(PriceTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(DateTextBox.Text) Then

                MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Using block for Connection
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO SalesDetails (ProductName, Quantity, Price, SaleDate) VALUES (@ProductName, @Quantity, @Price, @SaleDate)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text)
                    command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(QuantityTextBox.Text))
                    command.Parameters.AddWithValue("@Price", Convert.ToDecimal(PriceTextBox.Text))
                    command.Parameters.AddWithValue("@SaleDate", Convert.ToDateTime(DateTextBox.Text))

                    command.ExecuteNonQuery()
                    MessageBox.Show("Sales record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the sales record. Please try again." & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        ProductNameTextBox.Text = ""
        QuantityTextBox.Text = ""
        PriceTextBox.Text = ""
        DateTextBox.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
