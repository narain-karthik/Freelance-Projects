Imports System.Data.SqlClient

Public Class Item
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

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim conn As SqlConnection = OpenConnection()
        If conn IsNot Nothing Then
            Try
                Dim query As String = "INSERT INTO Item (ItemCode, ItemName, UnitPrice, MaximumLevel, RecordedLevel) " & _
                                      "VALUES (@ItemCode, @ItemName, @UnitPrice, @MaximumLevel, @RecordedLevel)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                cmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTextBox.Text)
                cmd.Parameters.AddWithValue("@MaximumLevel", MaximumLevelTextBox.Text)
                cmd.Parameters.AddWithValue("@RecordedLevel", RecordedLevelTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Item saved successfully!")
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
                Dim query As String = "UPDATE Item SET ItemName = @ItemName, UnitPrice = @UnitPrice, " & _
                                      "MaximumLevel = @MaximumLevel, RecordedLevel = @RecordedLevel WHERE ItemCode = @ItemCode"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                cmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTextBox.Text)
                cmd.Parameters.AddWithValue("@MaximumLevel", MaximumLevelTextBox.Text)
                cmd.Parameters.AddWithValue("@RecordedLevel", RecordedLevelTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Item updated successfully!")
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
                Dim query As String = "DELETE FROM Item WHERE ItemCode = @ItemCode"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Item deleted successfully!")
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        ItemCodeTextBox.Clear()
        ItemNameTextBox.Clear()
        UnitPriceTextBox.Clear()
        MaximumLevelTextBox.Clear()
        RecordedLevelTextBox.Clear()
    End Sub

    Private Sub Item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet2.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.WoodDataSet2.Item)

    End Sub
End Class