Imports System.Data.SqlClient

Public Class MenuManagement
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True"

    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        ' Validate fields
        If ItemIDTextBox.Text = "" OrElse ItemNameTextBox.Text = "" OrElse CategoryComboBox.Text = "" OrElse PriceTextBox.Text = "" Then
            MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save to database
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "INSERT INTO MenuItems (ItemID, ItemName, Category, Price) VALUES (@ItemID, @ItemName, @Category, @Price)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ItemID", ItemIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Category", CategoryComboBox.Text)
                    cmd.Parameters.AddWithValue("@Price", Decimal.Parse(PriceTextBox.Text))

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Menu item saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear fields
                    ClearFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        ItemIDTextBox.Clear()
        ItemNameTextBox.Clear()
        PriceTextBox.Clear()
        CategoryComboBox.SelectedIndex = -1
    End Sub

End Class
