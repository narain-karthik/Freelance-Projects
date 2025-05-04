Imports System.Data.SqlClient

Public Class AddStaffDetails
    Dim connectionString As String = "Server=LAPTOP-SBLEMHDL\SQLEXPRESS;Database=Car;Trusted_Connection=True;"
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO StaffDetails (EmployeeName, EmployeeEmail, DateOfBirth, DateOfJoining, IDProof) VALUES (@Name, @Email, @DOB, @DOJ, @IDProof)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", EmployeeNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Email", EmployeeEmailIDTextBox.Text)
                cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value.Date)
                cmd.Parameters.AddWithValue("@DOJ", DOJDateTimePicker.Value.Date)
                cmd.Parameters.AddWithValue("@IDProof", IDProofTextBox.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Staff details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If EmployeeIDTextBox.Text = "" Then
            MessageBox.Show("Please enter Employee ID to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE StaffDetails SET EmployeeName=@Name, EmployeeEmail=@Email, DateOfBirth=@DOB, DateOfJoining=@DOJ, IDProof=@IDProof WHERE EmployeeID=@ID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", EmployeeIDTextBox.Text)
                cmd.Parameters.AddWithValue("@Name", EmployeeNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Email", EmployeeEmailIDTextBox.Text)
                cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value.Date)
                cmd.Parameters.AddWithValue("@DOJ", DOJDateTimePicker.Value.Date)
                cmd.Parameters.AddWithValue("@IDProof", IDProofTextBox.Text)

                conn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Staff details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                conn.Close()
            End Using
        End Using
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If EmployeeIDTextBox.Text = "" Then
            MessageBox.Show("Please enter Employee ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM StaffDetails WHERE EmployeeID=@ID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", EmployeeIDTextBox.Text)

                conn.Open()
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Staff details deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                conn.Close()
            End Using
        End Using
    End Sub
End Class