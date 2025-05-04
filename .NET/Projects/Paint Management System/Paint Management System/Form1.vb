Public Class Form1
    ' Login button click event
    Private Sub LoginButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextBox.Text.Trim()
        Dim password As String = PasswordTextBox.Text.Trim()

        ' Basic validation
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Placeholder for actual login logic (e.g., check against a database)
        If username = "admin" AndAlso password = "password123" Then ' Example credentials
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Open the AdminDashboard form and hide the login form
            Dim dashboard As New AdminDashboard()
            dashboard.Show()
            Me.Hide() ' Hides the login form instead of closing it
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Clear button click event
    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClearButton.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        UsernameTextBox.Focus() ' Sets focus back to username field
    End Sub

    ' Optional: Allow Enter key to trigger login
    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginButton.PerformClick()
        End If
    End Sub
End Class