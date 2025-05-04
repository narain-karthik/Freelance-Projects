Public Class AboutUs
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not User.Identity.IsAuthenticated Then
                Response.Redirect("~/Login.aspx")
            End If
        End If
    End Sub
End Class