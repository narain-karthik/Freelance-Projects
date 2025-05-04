Imports System.Data.SqlClient

Public Class Sales
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
                Dim query As String = "INSERT INTO Sales (BillNo, ItemCode, ItemName, Quantity, SalesDate, CustomerCode, UnitPrice, Amount) " & _
                                      "VALUES (@BillNo, @ItemCode, @ItemName, @Quantity, @SalesDate, @CustomerCode, @UnitPrice, @Amount)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BillNo", BillNoTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@SalesDate", SalesDateDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@CustomerCode", CoustomerCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTextBox.Text)
                cmd.Parameters.AddWithValue("@Amount", AmountTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Sales data saved successfully!")
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
                Dim query As String = "UPDATE Sales SET ItemCode = @ItemCode, ItemName = @ItemName, Quantity = @Quantity, " & _
                                      "SalesDate = @SalesDate, CustomerCode = @CustomerCode, UnitPrice = @UnitPrice, Amount = @Amount " & _
                                      "WHERE BillNo = @BillNo"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BillNo", BillNoTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@SalesDate", SalesDateDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@CustomerCode", CoustomerCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTextBox.Text)
                cmd.Parameters.AddWithValue("@Amount", AmountTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Sales data updated successfully!")
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
                Dim query As String = "DELETE FROM Sales WHERE BillNo = @BillNo"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BillNo", BillNoTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Sales data deleted successfully!")
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        BillNoTextBox.Clear()
        ItemCodeTextBox.Clear()
        ItemNameTextBox.Clear()
        QuantityTextBox.Clear()
        CoustomerCodeTextBox.Clear()
        UnitPriceTextBox.Clear()
        AmountTextBox.Clear()
    End Sub

    Private Sub Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet4.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.WoodDataSet4.Sales)

    End Sub
End Class
