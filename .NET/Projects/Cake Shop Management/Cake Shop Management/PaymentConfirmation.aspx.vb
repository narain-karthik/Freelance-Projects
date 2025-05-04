Imports System

Public Class PaymentConfirmation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' Check if there is any session data to display
        Dim orderDetails As List(Of CartItem) = CType(Session("Cart"), List(Of CartItem))
        Dim totalAmount As Decimal = 0
        Dim paymentMethod As String = ""

        If orderDetails IsNot Nothing AndAlso orderDetails.Count > 0 Then
            ' Display the order details
            lblFullName.Text = Session("FullName").ToString()
            lblEmail.Text = Session("Email").ToString()
            lblAddress.Text = Session("Address").ToString()
            lblOrderDetails.Text = String.Join("<br />", orderDetails.Select(Function(item) item.ProductName & " - ₹" & item.ProductPrice & " x " & item.Quantity))
            totalAmount = orderDetails.Sum(Function(item) item.ProductPrice * item.Quantity)
            lblTotalAmount.Text = "₹" & totalAmount.ToString("F2")
            paymentMethod = Session("PaymentMethod").ToString()
            lblPaymentMethod.Text = paymentMethod

            ' Assuming payment status is stored after successful payment (e.g., "Successful")
            lblPaymentStatus.Text = "Payment Successful"
        End If
    End Sub

    Protected Sub btnHome_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Redirect to the homepage
        Response.Redirect("~/Home.aspx")
    End Sub
End Class
