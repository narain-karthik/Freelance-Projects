Public Class Form1

    
    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        ' Check if the username and password match the credentials
        If UsernameTextBox.Text = "admin" AndAlso PasswordTextBox.Text = "Admin" Then
            ' Open the Home page (replace "HomeForm" with your actual home page/form name)
            Dim homePage As New Home()
            homePage.Show()
            Me.Hide() ' Hide the login form
        Else
            ' Show an error message if the credentials are incorrect
            MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
