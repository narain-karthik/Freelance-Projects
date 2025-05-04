Imports System.Windows.Forms

Public Class Form1

    Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SubmitButton.Click
        ' Define default credentials
        Const defaultUsername As String = "admin"
        Const defaultPassword As String = "admin"

        ' Get entered credentials
        Dim enteredUsername As String = UsernameTextBox.Text.Trim()
        Dim enteredPassword As String = PasswordTextBox.Text.Trim()

        ' Check if credentials match
        If enteredUsername = defaultUsername AndAlso enteredPassword = defaultPassword Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Add your code here for successful login (e.g., opening another form)
            Dim home As New HomePage()
            home.Show()
            ' Hide the login form
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Clear the fields
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If
    End Sub

End Class