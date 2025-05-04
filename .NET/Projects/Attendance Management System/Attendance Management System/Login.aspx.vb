Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Page initialization if needed
        End If
    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If username = "admin" AndAlso password = "password" Then
            FormsAuthentication.RedirectFromLoginPage(username, False)
            Response.Redirect("~/Home.aspx")
        Else
            lblError.Text = "Invalid username or password"
            lblError.Visible = True
        End If
    End Sub
End Class