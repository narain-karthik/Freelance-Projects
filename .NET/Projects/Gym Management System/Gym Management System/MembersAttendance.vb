Imports System.Data.SqlClient

Public Class MembersAttendance

    ' Set your connection string here
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True"

    ' Auto-fill Name when Member ID is entered
    Private Sub MemberIDTextBox_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles MemberIDTextBox.Leave
        If MemberIDTextBox.Text <> "" Then
            FetchMemberName()
        End If
    End Sub

    ' Fetch Member Name from database
    Private Sub FetchMemberName()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT Name FROM Members WHERE MembershipID = @MembershipID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@MembershipID", MemberIDTextBox.Text)

                Try
                    con.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        NameTextBox.Text = reader("Name").ToString()
                    Else
                        NameTextBox.Text = ""
                        MessageBox.Show("Member ID not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error fetching member name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Save Attendance record to database
    Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SubmitButton.Click
        Using con As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO MembersAttendance (MemberAttendanceID, MemberID, Name, AttendanceDate, TimeIn, TimeOut, Status, WorkoutType) VALUES (@MemberAttendanceID, @MemberID, @Name, @AttendanceDate, @TimeIn, @TimeOut, @Status, @WorkoutType)"

            Using cmd As New SqlCommand(query, con)
                ' Add parameters
                cmd.Parameters.AddWithValue("@MemberAttendanceID", MemberAttendanceIDTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberID", MemberIDTextBox.Text)
                cmd.Parameters.AddWithValue("@Name", NameTextBox.Text)
                cmd.Parameters.AddWithValue("@AttendanceDate", DateTimePicker.Value.Date)
                cmd.Parameters.AddWithValue("@TimeIn", TimeInDateTimePicker.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@TimeOut", TimeOutDateTimePicker.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@Status", StatusComboBox.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@WorkoutType", WorkoutComboBox.SelectedItem.ToString())

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Attendance saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error saving attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class
