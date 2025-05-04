Public Class Form1

    Private Sub LoginButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoginButton.Click
        Dim username As String = LoginTextBox.Text.Trim()
        Dim password As String = PasswordTextBox.Text.Trim()

        If username = "admin" AndAlso password = "admin" Then
            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' You can open your Admin Home form here
            Dim adminHome As New AdminHomeForm()
            adminHome.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoginTextBox.Clear()
            PasswordTextBox.Clear()
            LoginTextBox.Focus()
        End If
    End Sub

End Class
