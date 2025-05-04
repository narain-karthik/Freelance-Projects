Imports System.Data.SqlClient

Public Class Staff

    Private Sub Staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        ' Connection string to your database
        Dim connectionString As String = "Server=LAPTOP-SBLEMHDL\SQLEXPRESS;Database=Computer;Trusted_Connection=True;"

        ' SQL command to insert the staff data
        Dim insertQuery As String = "INSERT INTO StaffDetails (Name, PhoneNumber, EmailID, Address, DateOfBirth, IDProof) " & _
                                    "VALUES (@Name, @PhoneNumber, @EmailID, @Address, @DateOfBirth, @IDProof)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(insertQuery, connection)
                ' Add parameters to the query to prevent SQL injection
                command.Parameters.AddWithValue("@Name", NameTextBox.Text)
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                command.Parameters.AddWithValue("@EmailID", EmailIDTextBox.Text)
                command.Parameters.AddWithValue("@Address", AddressTextBox.Text)
                command.Parameters.AddWithValue("@DateOfBirth", DOBDateTimePicker.Value.Date)
                command.Parameters.AddWithValue("@IDProof", IDProofTextBox.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery() ' Execute the insert query
                    MessageBox.Show("Staff details added successfully!")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class