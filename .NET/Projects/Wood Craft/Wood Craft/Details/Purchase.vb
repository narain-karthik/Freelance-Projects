Imports System.Data.SqlClient

Public Class Purchase
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
                Dim query As String = "INSERT INTO Purchase (InvoiceNo, ItemCode, ItemName, Quantity, PurchasedDate, UnitPrice, Amount, TaxAmount) " & _
                                      "VALUES (@InvoiceNo, @ItemCode, @ItemName, @Quantity, @PurchasedDate, @UnitPrice, @Amount, @TaxAmount)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@PurchasedDate", PuruchasedateTextBox.Text) ' Ensure date format is handled correctly
                cmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTextBox.Text)
                cmd.Parameters.AddWithValue("@Amount", AmountTextBox.Text)
                cmd.Parameters.AddWithValue("@TaxAmount", TaxAmountTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Purchase record saved successfully!")
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
                Dim query As String = "UPDATE Purchase SET ItemCode = @ItemCode, ItemName = @ItemName, Quantity = @Quantity, " & _
                                      "PurchasedDate = @PurchasedDate, UnitPrice = @UnitPrice, Amount = @Amount, TaxAmount = @TaxAmount " & _
                                      "WHERE InvoiceNo = @InvoiceNo"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemCode", ItemCodeTextBox.Text)
                cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@PurchasedDate", PuruchasedateTextBox.Text) ' Ensure date format is handled correctly
                cmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTextBox.Text)
                cmd.Parameters.AddWithValue("@Amount", AmountTextBox.Text)
                cmd.Parameters.AddWithValue("@TaxAmount", TaxAmountTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Purchase record updated successfully!")
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
                Dim query As String = "DELETE FROM Purchase WHERE InvoiceNo = @InvoiceNo"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Purchase record deleted successfully!")
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        InvoiceNoTextBox.Clear()
        ItemCodeTextBox.Clear()
        ItemNameTextBox.Clear()
        QuantityTextBox.Clear()
        PuruchasedateTextBox.Clear()
        UnitPriceTextBox.Clear()
        AmountTextBox.Clear()
        TaxAmountTextBox.Clear()
    End Sub

    Private Sub Purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WoodDataSet3.Purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter.Fill(Me.WoodDataSet3.Purchase)

    End Sub
End Class
