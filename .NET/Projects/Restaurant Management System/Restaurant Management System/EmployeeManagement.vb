Imports System.Data.SqlClient

Public Class EmployeeManagement
    ' Declare your connection string at the top
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True"

    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        ' Use the declared connection string here
        Dim conn As New SqlConnection(connectionString)

        ' Corrected command with the correct query
        Dim cmd As New SqlCommand("INSERT INTO Employee (EmployeeID, Name, Role, Gender, DateOfBirth, Address, PhoneNumber, DateOfJoining) VALUES (@EmployeeID, @Name, @Role, @Gender, @DateOfBirth, @Address, @PhoneNumber, @DateOfJoining)", conn)

        ' Add parameters to avoid SQL injection
        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeIDTextBox.Text)
        cmd.Parameters.AddWithValue("@Name", NameTextBox.Text)
        cmd.Parameters.AddWithValue("@Role", RoleComboBox.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@Gender", GenderComboBox.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@DateOfBirth", DOBDateTimePicker.Value)
        cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
        cmd.Parameters.AddWithValue("@DateOfJoining", DOJDateTimePicker.Value)

        Try
            conn.Open() ' Open the connection
            cmd.ExecuteNonQuery() ' Execute the insert command
            MessageBox.Show("Employee data saved successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close() ' Close the connection
        End Try
    End Sub
End Class
