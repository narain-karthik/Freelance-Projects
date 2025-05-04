Imports System.Data.SqlClient

Public Class CustomerDetailsForm
    ' Database connection string (Update as per your server and database)
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Hardware;Integrated Security=True"

    Private Sub btnAddStock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddStock.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(CustomerIDTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(CustomerNameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(CustomerAddressTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(CustomerPhoneNumberTextBox.Text) Then
            MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert into database
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "INSERT INTO Customers (CustomerID, CustomerName, CustomerAddress, CustomerPhoneNumber) VALUES (@CustomerID, @CustomerName, @CustomerAddress, @CustomerPhoneNumber)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(CustomerIDTextBox.Text))
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddressTextBox.Text)
                    cmd.Parameters.AddWithValue("@CustomerPhoneNumber", CustomerPhoneNumberTextBox.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while adding customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        ClearForm()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ClearForm()
        CustomerIDTextBox.Clear()
        CustomerNameTextBox.Clear()
        CustomerAddressTextBox.Clear()
        CustomerPhoneNumberTextBox.Clear()
        CustomerIDTextBox.Focus()
    End Sub
End Class
