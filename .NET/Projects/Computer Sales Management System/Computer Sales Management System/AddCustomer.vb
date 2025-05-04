Imports System.Data.SqlClient

Public Class AddCustomer

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        ' Connection string to your database
        Dim connectionString As String = "Server=LAPTOP-SBLEMHDL\SQLEXPRESS;Database=Computer;Trusted_Connection=True;"

        ' SQL command to insert the customer data
        Dim insertQuery As String = "INSERT INTO CustomerDetails (Name, PhoneNumber, EmailID, Address) " & _
                                    "VALUES (@Name, @PhoneNumber, @EmailID, @Address)"

        ' Using statement ensures the resources are disposed of properly
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Name", NameTextBox.Text)
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                command.Parameters.AddWithValue("@EmailID", EmailIDTextBox.Text)
                command.Parameters.AddWithValue("@Address", AddressTextBox.Text)

                Try
                    ' Open the database connection
                    connection.Open()

                    ' Execute the insert query
                    command.ExecuteNonQuery()

                    ' Show a success message
                    MessageBox.Show("Customer details added successfully!")

                    ' Optionally, clear the form fields after submission
                    NameTextBox.Clear()
                    PhoneNumberTextBox.Clear()
                    EmailIDTextBox.Clear()
                    AddressTextBox.Clear()

                Catch ex As Exception
                    ' Display any errors that occur
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class