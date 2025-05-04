Imports System.Data.SqlClient

Public Class AddProduct

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        ' Connection string to your database
        Dim connectionString As String = "Server=LAPTOP-SBLEMHDL\SQLEXPRESS;Database=Computer;Trusted_Connection=True;"  ' Replace with your server name

        ' SQL command to insert the product data
        Dim insertQuery As String = "INSERT INTO ProductDetails (ProductName, ModuleName, StockNumber, DateOfStock) " & _
                                    "VALUES (@ProductName, @ModuleName, @StockNumber, @DateOfStock)"

        ' Using statement ensures the resources are disposed of properly
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@ProductName", TextBox1.Text)  ' Product name
                command.Parameters.AddWithValue("@ModuleName", StockNumberTextBox.Text)  ' Module name
                command.Parameters.AddWithValue("@StockNumber", Convert.ToInt32(StockTextBox.Text))  ' Stock number
                command.Parameters.AddWithValue("@DateOfStock", DOSDateTimePicker.Value)  ' Date of stock

                Try
                    ' Open the database connection
                    connection.Open()

                    ' Execute the insert query
                    command.ExecuteNonQuery()

                    ' Show a success message
                    MessageBox.Show("Product details added successfully!")

                    ' Optionally, clear the form fields after submission
                    TextBox1.Clear()
                    StockNumberTextBox.Clear()
                    StockTextBox.Clear()
                    DOSDateTimePicker.Value = DateTime.Now

                Catch ex As Exception
                    ' Display any errors that occur
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class