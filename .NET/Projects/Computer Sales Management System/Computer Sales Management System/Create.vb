Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient

Public Class Create
    ' Database Connection String (Update YOUR_SERVER_NAME)
    Dim connectionString As String = "Server=LAPTOP-SBLEMHDL\SQLEXPRESS;Database=Computer;Trusted_Connection=True;"

    ' Password Hashing Function
    Function HashPassword(ByVal password As String) As String
        Dim sha As New SHA256Managed()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
    End Function
    Private Sub LoginLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LoginLinkLabel.LinkClicked
        Dim LoginForm As New Login()
        LoginForm.Show()


    End Sub

    Private Sub CreateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateButton.Click
        ' Validate Input
        If UsernameTextBox.Text = "" Or NameTextBox.Text = "" Or PasswordTextBox.Text = "" Or RoleComboBox.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("INSERT INTO Users (Username, Name, Password, Role) VALUES (@Username, @Name, @Password, @Role)", conn)

        cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text)
        cmd.Parameters.AddWithValue("@Name", NameTextBox.Text)
        cmd.Parameters.AddWithValue("@Password", HashPassword(PasswordTextBox.Text)) ' Store hashed password
        cmd.Parameters.AddWithValue("@Role", RoleComboBox.SelectedItem.ToString())

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As SqlException When ex.Number = 2627
            MessageBox.Show("Username is already registered!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class