Imports System.Data
Imports System.Data.SqlClient

Public Class AddStaffDetails

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
            Using con As New SqlConnection(connectionString)
                ' SQL query with placeholders for parameters
                Dim query As String = "INSERT INTO [Attendance].[dbo].[StaffDetails] " & _
                                      "(Name, Register, DOB, Address, Phone, DOJ, IDProof) " & _
                                      "VALUES (@Name, @Register, @DOB, @Address, @Phone, @DOJ, @IDProof)"

                Using cmd As New SqlCommand(query, con)
                    ' Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Name", ENTextBox.Text)
                    cmd.Parameters.AddWithValue("@Register", ERNTextBox.Text)
                    cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
                    cmd.Parameters.AddWithValue("@Phone", PHTextBox.Text)
                    cmd.Parameters.AddWithValue("@DOJ", DOJDateTimePicker.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@IDProof", IDTextBox.Text)

                    ' Open the connection and execute the query
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("You have registered successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            ' Display error message if something goes wrong
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
            Using con As New SqlConnection(connectionString)
                ' SQL query to update staff details
                Dim query As String = "UPDATE [Attendance].[dbo].[StaffDetails] SET " & _
                                      "Name = @Name, Register = @Register, DOB = @DOB, Address = @Address, " & _
                                      "Phone = @Phone, DOJ = @DOJ, IDProof = @IDProof WHERE Register = @Register"

                Using cmd As New SqlCommand(query, con)
                    ' Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Name", ENTextBox.Text)
                    cmd.Parameters.AddWithValue("@Register", ERNTextBox.Text)
                    cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
                    cmd.Parameters.AddWithValue("@Phone", PHTextBox.Text)
                    cmd.Parameters.AddWithValue("@DOJ", DOJDateTimePicker.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@IDProof", IDTextBox.Text)


                    ' Open the connection and execute the query
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff details updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            ' Display error message if something goes wrong
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
            Using con As New SqlConnection(connectionString)
                ' SQL query to delete staff details
                Dim query As String = "DELETE FROM [Attendance].[dbo].[StaffDetails] WHERE Register = @Register"

                Using cmd As New SqlCommand(query, con)
                    ' Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Register", ERNTextBox.Text) ' Assume there is a textbox for StaffID

                    ' Open the connection and execute the query
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff details deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            ' Display error message if something goes wrong
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
End Class
