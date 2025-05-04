Imports System.Data.SqlClient

Public Class StaffAttendance
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True"

    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        If StaffattendanceIDTextBox.Text = "" Or StaffIDTextBox.Text = "" Or NameTextBox.Text = "" Or StatusComboBox.Text = "" Then
            MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "INSERT INTO StaffAttendance (StaffAttendanceID, StaffID, Name, Date, TimeIn, TimeOut, Status) VALUES (@StaffAttendanceID, @StaffID, @Name, @Date, @TimeIn, @TimeOut, @Status)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@StaffAttendanceID", StaffattendanceIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@StaffID", StaffIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@Name", NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Date", DateTimePicker.Value.Date)
                    cmd.Parameters.AddWithValue("@TimeIn", TimeInDateTimePicker.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@TimeOut", TimeOutDateTimePicker.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@Status", StatusComboBox.SelectedItem.ToString())

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Attendance Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClearButton.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        StaffattendanceIDTextBox.Clear()
        StaffIDTextBox.Clear()
        NameTextBox.Clear()
        StatusComboBox.SelectedIndex = -1
        DateTimePicker.Value = DateTime.Now
        TimeInDateTimePicker.Value = DateTime.Now
        TimeOutDateTimePicker.Value = DateTime.Now
    End Sub

    ' 🔥 ADD THIS PART TO AUTO-FILL NAME WHEN STAFF ID IS ENTERED
    Private Sub StaffIDTextBox_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles StaffIDTextBox.Leave
        If StaffIDTextBox.Text.Trim() <> "" Then
            Try
                Using con As New SqlConnection(connectionString)
                    con.Open()

                    Dim query As String = "SELECT Name FROM Staff WHERE StaffID = @StaffID"
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@StaffID", StaffIDTextBox.Text.Trim())

                        Dim reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            NameTextBox.Text = reader("Name").ToString()
                        Else
                            MessageBox.Show("Staff ID not found.", "Invalid Staff ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            NameTextBox.Clear()
                        End If

                        reader.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            NameTextBox.Clear()
        End If
    End Sub

End Class
