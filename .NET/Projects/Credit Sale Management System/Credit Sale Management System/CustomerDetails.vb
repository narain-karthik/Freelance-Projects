Imports System.Data.SqlClient

Public Class CustomerDetails
    Private Sub CustomerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Load necessary data when the form loads
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Credit;Integrated Security=True"

        ' Updated query: Removed CustomerID from INSERT since it's an identity column
        Dim query As String = "INSERT INTO Customer (CustomerName, ContactNumber, EmailID, Address, DOB, RegistrationDate) " &
                              "VALUES (@CustomerName, @ContactNumber, @EmailID, @Address, @DOB, @RegistrationDate)"

        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    ' Remove CustomerID as SQL Server auto-generates it
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@ContactNumber", ContactNumberTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@EmailID", EmailIDTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@RegistrationDate", RegistrationDateDateTimePicker.Value)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Customer details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to add customer details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
End Class
