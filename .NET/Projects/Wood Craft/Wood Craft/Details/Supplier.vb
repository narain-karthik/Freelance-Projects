Imports System.Data.SqlClient

Public Class Supplier
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

    Private Sub Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet1.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.WoodDataSet1.Supplier)

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim conn As SqlConnection = OpenConnection()
        If conn IsNot Nothing Then
            Try
                Dim query As String = "INSERT INTO Supplier (SupplierCode, SupplierName, PhoneNumber, Address, ItemCode) " & _
                                      "VALUES (@SupplierCode, @SupplierName, @PhoneNumber, @Address, @ItemCode)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SupplierCode", SupplierCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@SupplierName", SupplierNameTextBox.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Supplier saved successfully!")
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
                Dim query As String = "UPDATE Supplier SET SupplierName = @SupplierName, PhoneNumber = @PhoneNumber, " & _
                                      "Address = @Address, ItemCode = @ItemCode WHERE SupplierCode = @SupplierCode"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SupplierCode", SupplierCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@SupplierName", SupplierNameTextBox.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Supplier updated successfully!")
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
                Dim query As String = "DELETE FROM Supplier WHERE SupplierCode = @SupplierCode"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SupplierCode", SupplierCodeTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Supplier deleted successfully!")
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        SupplierCodeTextBox.Clear()
        SupplierNameTextBox.Clear()
        PhoneNumberTextBox.Clear()
        AddressTextBox.Clear()
        ItemCodeTextBox.Clear()
    End Sub
End Class