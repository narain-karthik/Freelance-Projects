Imports System.Data.SqlClient

Public Class CustomerDetails
    ' Replace YOUR_SERVER, YOUR_DATABASE, and credentials accordingly
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Sport;Integrated Security=True"
    ' OR if using SQL Login:
    ' Dim connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;User ID=your_username;Password=your_password;"

    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        ' Validate your fields here (optional)

        ' Prepare SQL Insert Query
        Dim query As String = "INSERT INTO Customers (CustomerID, Name, Phone, Address, DOB) VALUES (@CustomerID, @Name, @Phone, @Address, @DOB)"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Pass parameters
                cmd.Parameters.AddWithValue("@CustomerID", TextBoxID.Text)
                cmd.Parameters.AddWithValue("@Name", TextBoxName.Text)
                cmd.Parameters.AddWithValue("@Phone", TextBoxPhone.Text)
                cmd.Parameters.AddWithValue("@Address", TextBoxAddress.Text)
                cmd.Parameters.AddWithValue("@DOB", DOBPicker.Value)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Customer details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error while saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class