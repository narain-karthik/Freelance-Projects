Imports System.Data.SqlClient

Public Class Unreservation
    Private Sub BookTicketButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BookTicketButton.Click
        Try
            ' Connection String (Modify this based on your SQL Server setup)
            Dim conString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Railway;Integrated Security=True"

            Using con As New SqlConnection(conString)
                con.Open()

                ' Insert Query
                Dim query As String = "INSERT INTO Unreservation (TrainNumber, TrainName, SourceStation, DestinationStation, UnreservationDate) " &
                                      "VALUES (@TrainNumber, @TrainName, @SourceStation, @DestinationStation, @UnreservationDate)"

                Using cmd As New SqlCommand(query, con)
                    ' Assigning values to parameters
                    cmd.Parameters.AddWithValue("@TrainNumber", TrainNumberComboBox.Text)
                    cmd.Parameters.AddWithValue("@TrainName", TrainNameComboBox.Text)
                    cmd.Parameters.AddWithValue("@SourceStation", FromComboBox.Text)
                    cmd.Parameters.AddWithValue("@DestinationStation", ToComboBox.Text)
                    cmd.Parameters.AddWithValue("@UnreservationDate", ReservationDateTimePicker.Value)

                    ' Execute the Insert command
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Show success message if insertion is successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Ticket Booked Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to Book Ticket. Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
