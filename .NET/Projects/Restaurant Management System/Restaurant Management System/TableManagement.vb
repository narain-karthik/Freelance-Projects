Imports System.Data.SqlClient

Public Class TableManagement
    ' Connection string - change it to match your database
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        Try
            ' Open connection
            connection.Open()

            ' SQL Query to Insert table details
            Dim query As String = "INSERT INTO TableDetails (TableID, TableNumber, Name, Seats, Status, Location) " &
                                  "VALUES (@TableID, @TableNumber, @Name, @Seats, @Status, @Location)"

            ' Create command
            Using command As New SqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@TableID", TableIDTextBox.Text)
                command.Parameters.AddWithValue("@TableNumber", TableNumberTextBox.Text)
                command.Parameters.AddWithValue("@Name", NameTextBox.Text)
                command.Parameters.AddWithValue("@Seats", SeatsTextBox.Text)
                command.Parameters.AddWithValue("@Status", StatusComboBox.SelectedItem.ToString())
                command.Parameters.AddWithValue("@Location", LocationComboBox.SelectedItem.ToString())

                ' Execute command
                command.ExecuteNonQuery()
                MessageBox.Show("Table details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClearButton.Click
        TableIDTextBox.Clear()
        TableNumberTextBox.Clear()
        NameTextBox.Clear()
        SeatsTextBox.Clear()
        StatusComboBox.SelectedIndex = -1
        LocationComboBox.SelectedIndex = -1
    End Sub

End Class