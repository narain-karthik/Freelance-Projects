Imports System.Data.SqlClient

Public Class SupplierDetails
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Credit;Integrated Security=True"

    Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SubmitButton.Click
        ' Collecting Input Data
        Dim supplierName As String = SupplierNameTextBox.Text.Trim()
        Dim contactNumber As String = ContactNumberTextBox.Text.Trim()
        Dim emailID As String = EmailIDTextBox.Text.Trim()
        Dim address As String = AddressTextBox.Text.Trim()
        Dim dob As Date = DOBDateTimePicker.Value
        Dim registrationDate As Date = RegistrationDateDateTimePicker.Value

        ' Input Validation
        If String.IsNullOrEmpty(supplierName) OrElse String.IsNullOrEmpty(contactNumber) OrElse
           String.IsNullOrEmpty(emailID) OrElse String.IsNullOrEmpty(address) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' SQL Query to Insert Data
        Dim query As String = "INSERT INTO Supplier (SupplierName, ContactNumber, EmailID, Address, DOB, RegistrationDate) " &
                              "VALUES (@SupplierName, @ContactNumber, @EmailID, @Address, @DOB, @RegistrationDate)"

        ' Database Connection & Execution
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@SupplierName", supplierName)
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumber)
                cmd.Parameters.AddWithValue("@EmailID", emailID)
                cmd.Parameters.AddWithValue("@Address", address)
                cmd.Parameters.AddWithValue("@DOB", dob)
                cmd.Parameters.AddWithValue("@RegistrationDate", registrationDate)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Supplier details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As SqlException
                    MessageBox.Show("Error while inserting data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
