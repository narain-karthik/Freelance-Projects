Imports System.Data.SqlClient

Public Class StaffDetails

    ' Define your connection string (replace YOUR_SERVER and YOUR_DATABASE with your actual details)
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True"

    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        ' Create a new SQL connection
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' Insert query
                Dim query As String = "INSERT INTO Staff (StaffID, Name, Age, Gender, PhoneNumber, Role, DOJ, Address, Salary) VALUES (@StaffID, @Name, @Age, @Gender, @PhoneNumber, @Role, @DOJ, @Address, @Salary)"

                ' Create the command
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@StaffID", StaffIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@Name", NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Age", AgeTextBox.Text)
                    cmd.Parameters.AddWithValue("@Gender", GenderComboBox.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                    cmd.Parameters.AddWithValue("@Role", RoleComboBox.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@DOJ", DOJDateTimePicker.Value.Date)
                    cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
                    cmd.Parameters.AddWithValue("@Salary", SalaryTextBox.Text)

                    ' Execute the command
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Staff details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Optionally, clear the form after saving
                    ClearForm()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error saving staff details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Clear form method
    Private Sub ClearForm()
        StaffIDTextBox.Clear()
        NameTextBox.Clear()
        AgeTextBox.Clear()
        GenderComboBox.SelectedIndex = -1
        PhoneNumberTextBox.Clear()
        RoleComboBox.SelectedIndex = -1
        DOJDateTimePicker.Value = DateTime.Now
        AddressTextBox.Clear()
        SalaryTextBox.Clear()
    End Sub

End Class