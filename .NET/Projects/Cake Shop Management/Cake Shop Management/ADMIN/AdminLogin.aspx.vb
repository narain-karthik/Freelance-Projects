Public Class AdminLogin
    Inherits System.Web.UI.Page

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Hardcoded user validation
        If username = "admin" And password = "admin123" Then
            Response.Redirect("AdminDashboard.aspx")
        ElseIf username = "chief" And password = "chief123" Then
            Response.Redirect("ChiefDashboard.aspx")
        Else
            lblMessage.Text = "Invalid username or password."
            ' Optional: clear textboxes or set focus
            txtUsername.Focus()
        End If
    End Sub
End Class
