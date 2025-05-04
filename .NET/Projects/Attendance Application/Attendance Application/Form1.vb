Public Class Form1
    Private WithEvents lblUsername As Label
    Private WithEvents txtUsername As TextBox
    Private WithEvents lblPassword As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents lblRole As Label
    Private WithEvents cmbRole As ComboBox
    Private WithEvents btnLogin As Button
    Private WithEvents lnkCreateAccount As LinkLabel

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Button Click Event Handler for Login Button
    Private Sub BtnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = cmbRole.SelectedItem.ToString()

        If String.IsNullOrEmpty(role) Then
            MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If username = "admin" AndAlso password = "password" AndAlso role = "Admin" Then
            MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Navigate to Admin Home Page
            Dim adminHome As New AdminHomePage()
            adminHome.Show()
            Me.Hide()
        ElseIf username = "user" AndAlso password = "password" AndAlso role = "User" Then
            MessageBox.Show("Welcome, User!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Navigate to User Home Page
            Dim userHome As New UserHomePage()
            userHome.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials or role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Link Click Event Handler for Create Account LinkLabel
    Private Sub LnkCreateAccount_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Prevent duplicate click bindings
        RemoveHandler lnkCreateAccount.Click, AddressOf LnkCreateAccount_Click
        AddHandler lnkCreateAccount.Click, AddressOf LnkCreateAccount_Click

        ' Show a message and navigate to account creation
        MessageBox.Show("Redirecting to account creation.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Example: Redirect to account creation form
        ' Dim createAccountForm As New CreateAccountForm()
        ' createAccountForm.Show()
    End Sub

End Class
