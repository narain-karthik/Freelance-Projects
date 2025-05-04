Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient

Public Class Login
    ' Update with your actual SQL Server details
    Dim connectionString As String = "Server=LAPTOP-SBLEMHDL\SQLEXPRESS;Database=Computer;Trusted_Connection=True;"

    ' Hashing function for password verification
    Function HashPassword(ByVal password As String) As String
        Dim sha As New SHA256Managed()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
    End Function
    Private Sub CreateAccountLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CreateAccountLink.LinkClicked
        Dim createForm As New Create()
        createForm.Show()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        ' Validate Input
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Or RoleComboBox.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("SELECT Password, Role FROM Users WHERE Username = @Username", conn)
        cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text)

        Try
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Check if user exists
            If reader.Read() Then
                Dim storedHash As String = reader("Password").ToString()
                Dim userRole As String = reader("Role").ToString()

                ' Verify password
                If storedHash = HashPassword(PasswordTextBox.Text) Then
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Redirect based on Role
                    If userRole = "Admin" Then
                        Dim adminHome As New AdminHome()
                        adminHome.Show()
                    Else
                        Dim userHome As New StaffHome()
                        userHome.Show()
                    End If

                    Me.Hide() ' Hide login form after successful login
                Else
                    MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class