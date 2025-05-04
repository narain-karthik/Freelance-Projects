Imports System.Data.SqlClient

Public Class SoldOut

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Try
            ' Define the connection string (replace with your actual DB connection string)
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Car;Integrated Security=True"
            Using con As New SqlConnection(connectionString)
                con.Open() ' Open the database connection

                ' Define the query for inserting the sold-out car record
                Dim query As String = "INSERT INTO SoldOutCars (CustomerName, CustomerEmail, PhoneNumber, CarModel, CarPrice, EngineNumber, DateOfPurchase) " & _
                                      "VALUES (@CustomerName, @CustomerEmail, @PhoneNumber, @CarModel, @CarPrice, @EngineNumber, @DateOfPurchase)"

                Using cmd As New SqlCommand(query, con)
                    ' Add parameters to the SQL query
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmailID.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                    cmd.Parameters.AddWithValue("@CarModel", CarModelComboBox.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@CarPrice", ComboBox1.SelectedItem.ToString()) ' Assuming ComboBox1 contains car price info
                    cmd.Parameters.AddWithValue("@EngineNumber", EngineTextBox.Text)
                    cmd.Parameters.AddWithValue("@DateOfPurchase", DOPDateTimePicker.Value)

                    ' Execute the query
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Display success message
            MessageBox.Show("Sold out car details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally, clear the form after saving
            ClearForm()
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("An error occurred while saving the sold-out car details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to clear form after saving
    Private Sub ClearForm()
        CustomerNameTextBox.Clear()
        CustomerEmailID.Clear()
        PhoneNumberTextBox.Clear()
        CarModelComboBox.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1
        EngineTextBox.Clear()
        DOPDateTimePicker.Value = DateTime.Now
    End Sub
End Class
