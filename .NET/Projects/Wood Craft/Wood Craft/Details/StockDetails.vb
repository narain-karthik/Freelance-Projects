Imports System.Data.SqlClient

Public Class StockDetails
    Dim connectionString As String = "Server=LAPTOP-SBLEMHDL\SQLEXPRESS;Database=Wood;Trusted_Connection=True;"

    ' Function to open a connection to the database
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

    ' Save button logic
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim conn As SqlConnection = OpenConnection()
        If conn IsNot Nothing Then
            Try
                ' SQL query to insert a new stock record
                Dim query As String = "INSERT INTO Stock (ItemCode, ItemName, PurchaseQuantity, SalesQuantity, StockQuantity) " & _
                                      "VALUES (@ItemCode, @ItemName, @PurchaseQuantity, @SalesQuantity, @StockQuantity)"
                Dim cmd As New SqlCommand(query, conn)

                ' Adding parameters
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                cmd.Parameters.AddWithValue("@PurchaseQuantity", PuchaseQuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@SalesQuantity", SalesQuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@StockQuantity", StockQuantityTextBox.Text)

                ' Execute the query
                cmd.ExecuteNonQuery()
                MessageBox.Show("Stock details saved successfully!")
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    ' Update button logic
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Dim conn As SqlConnection = OpenConnection()
        If conn IsNot Nothing Then
            Try
                ' SQL query to update an existing stock record
                Dim query As String = "UPDATE Stock SET ItemName = @ItemName, PurchaseQuantity = @PurchaseQuantity, " & _
                                      "SalesQuantity = @SalesQuantity, StockQuantity = @StockQuantity WHERE ItemCode = @ItemCode"
                Dim cmd As New SqlCommand(query, conn)

                ' Adding parameters
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                cmd.Parameters.AddWithValue("@PurchaseQuantity", PuchaseQuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@SalesQuantity", SalesQuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@StockQuantity", StockQuantityTextBox.Text)

                ' Execute the query
                cmd.ExecuteNonQuery()
                MessageBox.Show("Stock details updated successfully!")
            Catch ex As Exception
                MessageBox.Show("Error updating data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    ' Delete button logic
    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim conn As SqlConnection = OpenConnection()
        If conn IsNot Nothing Then
            Try
                ' SQL query to delete a stock record
                Dim query As String = "DELETE FROM Stock WHERE ItemCode = @ItemCode"
                Dim cmd As New SqlCommand(query, conn)

                ' Adding parameters
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)

                ' Execute the query
                cmd.ExecuteNonQuery()
                MessageBox.Show("Stock details deleted successfully!")
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    ' Cancel button logic
    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        ' Clearing all textboxes
        ItemCodeTextBox.Clear()
        ItemNameTextBox.Clear()
        PuchaseQuantityTextBox.Clear()
        SalesQuantityTextBox.Clear()
        StockQuantityTextBox.Clear()
    End Sub

    Private Sub StockDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet5.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.WoodDataSet5.Stock)

    End Sub
End Class
