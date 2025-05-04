Imports System.Data.SqlClient
Public Class Customer
    Dim connectionString As String = "Server=LAPTOP-SBLEMHDL\SQLEXPRESS;Database=Wood;Trusted_Connection=True;"

    Private Function OpenConnection() As SqlConnection
        Dim conn As New SqlConnection(connectionString)
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            MessageBox.Show("Error opening connection: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.WoodDataSet.Customers)

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim conn As SqlConnection = OpenConnection()
        If conn IsNot Nothing Then
            Try
                Dim query As String = "INSERT INTO Customers (CustomerCode, CustomerName, PhoneNumber, Address) " & _
                                      "VALUES (@CustomerCode, @CustomerName, @PhoneNumber, @Address)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CustomerCode", CustomerCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Customer saved successfully!")
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Dim conn As SqlConnection = OpenConnection()
        If conn IsNot Nothing Then
            Try
                Dim query As String = "UPDATE Customers SET CustomerName = @CustomerName, PhoneNumber = @PhoneNumber, " & _
                                      "Address = @Address WHERE CustomerCode = @CustomerCode"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CustomerCode", CustomerCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Customer updated successfully!")
            Catch ex As Exception
                MessageBox.Show("Error updating data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim conn As SqlConnection = OpenConnection()
        If conn IsNot Nothing Then
            Try
                Dim query As String = "DELETE FROM Customers WHERE CustomerCode = @CustomerCode"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CustomerCode", CustomerCodeTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Customer deleted successfully!")
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        CustomerCodeTextBox.Clear()
        CustomerNameTextBox.Clear()
        PhoneNumberTextBox.Clear()
        AddressTextBox.Clear()
    End Sub
End Class