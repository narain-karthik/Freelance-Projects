Partial Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Optionally pre-fill username for testing
            txtUsername.Text = ""
            lblMessage.Visible = False
        End If
    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Default credentials
        Const defaultUsername As String = "admin"
        Const defaultPassword As String = "admin"

        ' Get user input
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Validate credentials
        If username = defaultUsername AndAlso password = defaultPassword Then
            ' Successful login
            Session("LoggedIn") = True ' Set a session variable to track login status
            Response.Redirect("Home.aspx") ' Redirect to a default page
        Else
            ' Failed login
            lblMessage.Text = "Invalid username or password."
            lblMessage.Visible = True
        End If
    End Sub
End Class