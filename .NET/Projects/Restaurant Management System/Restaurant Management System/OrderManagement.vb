Imports System.Data.SqlClient

Public Class OrderManagement
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True")
    Dim cmd As SqlCommand

    ' Auto-load a new OrderID when form opens
    Private Sub OrderManagement_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GenerateOrderID()
    End Sub

    ' Function to auto-generate OrderID (Example: 101, 102, etc.)
    Private Sub GenerateOrderID()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query As String = "SELECT ISNULL(OrderID, '10') FROM Orders"

            cmd = New SqlCommand(query, con)
            Dim lastOrderID As String = cmd.ExecuteScalar().ToString()

            Dim numPart As Integer = Convert.ToInt32(lastOrderID.Substring(3))
            numPart += 1

            OrderIDTextBox.Text = "ORD" & numPart.ToString()
        Catch ex As Exception
            MessageBox.Show("Error generating Order ID: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Fetch Table Name from TableDB when TableID is entered
    Private Sub GetTableName()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New SqlCommand("SELECT Name FROM TableDetails WHERE TableID = @TableID", con)
            cmd.Parameters.AddWithValue("@TableID", TableIDTextBox.Text.Trim())

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                NameTextBox.Text = dr("Name").ToString()
            Else
                NameTextBox.Text = ""
            End If

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error fetching Table Name: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' When you leave the TableID TextBox, it will fetch the Name automatically
    Private Sub TableIDTextBox_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TableIDTextBox.Leave
        GetTableName()
    End Sub

    ' Save Order when clicking the Save Button
    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query As String = "INSERT INTO Orders (OrderID, TableID, CustomerName, OrderStatus, FoodList, OrderDateTime) " &
                                  "VALUES (@OrderID, @TableID, @CustomerName, @OrderStatus, @FoodList, @OrderDateTime)"

            cmd = New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@OrderID", OrderIDTextBox.Text)
            cmd.Parameters.AddWithValue("@TableID", TableIDTextBox.Text)
            cmd.Parameters.AddWithValue("@CustomerName", NameTextBox.Text)
            cmd.Parameters.AddWithValue("@OrderStatus", OrderStatusComboBox.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@FoodList", FoodListTextBox.Text)
            cmd.Parameters.AddWithValue("@OrderDateTime", OrderDateTimePicker.Value)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Order Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form after saving
            ClearForm()

            ' Generate new OrderID for next order
            GenerateOrderID()

        Catch ex As Exception
            MessageBox.Show("Error saving order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    ' Clear all fields after save
    Private Sub ClearForm()
        TableIDTextBox.Text = ""
        NameTextBox.Text = ""
        OrderStatusComboBox.SelectedIndex = -1
        FoodListTextBox.Text = ""
        OrderDateTimePicker.Value = DateTime.Now
    End Sub

End Class
