Partial Class PaymentConfirmation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                ' Check if Session data exists
                If Session("FullName") Is Nothing OrElse Session("Cart") Is Nothing Then
                    Response.Redirect("~/Home.aspx")
                    Exit Sub
                End If

                ' Populate labels from Session with null checks
                lblFullName.Text = If(Session("FullName") IsNot Nothing, Session("FullName").ToString(), String.Empty)
                lblEmail.Text = If(Session("Email") IsNot Nothing, Session("Email").ToString(), String.Empty)
                lblAddress.Text = If(Session("Address") IsNot Nothing, Session("Address").ToString(), String.Empty)
                lblPaymentMethod.Text = If(Session("PaymentMethod") IsNot Nothing, Session("PaymentMethod").ToString(), String.Empty)

                ' Handle cart details for OrderDetails and TotalAmount
                Dim cartItems As List(Of CartItem) = TryCast(Session("Cart"), List(Of CartItem))
                If cartItems IsNot Nothing AndAlso cartItems.Count > 0 Then
                    lblOrderDetails.Text = String.Join("<br />", cartItems.Select(Function(item) item.ProductName & " - ₹" & item.ProductPrice & " x " & item.Quantity))
                    Dim total As Decimal = cartItems.Sum(Function(item) item.ProductPrice * item.Quantity)
                    lblTotalAmount.Text = "₹" & total.ToString("F2")
                Else
                    lblOrderDetails.Text = "No items found"
                    lblTotalAmount.Text = "₹0.00"
                End If

                ' Set Payment Status
                lblPaymentStatus.Text = "Success"

            Catch ex As Exception
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('An error occurred: " & ex.Message.Replace("'", "\'") & "');", True)
                lblPaymentStatus.Text = "Error"
            End Try
        End If
    End Sub

    Protected Sub btnHome_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHome.Click
        ' Clear session data
        Session.Remove("Cart")
        Session.Remove("FullName")
        Session.Remove("Email")
        Session.Remove("Address")
        Session.Remove("PaymentMethod")

        ' Redirect to the homepage
        Response.Redirect("~/Home.aspx")
    End Sub
End Class