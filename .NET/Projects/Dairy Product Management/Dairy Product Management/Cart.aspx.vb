Imports System
Imports System.Collections.Generic

' Define a class to represent a cart item
Public Class CartItem
    Public Property ProductId As Integer
    Public Property ProductName As String
    Public Property ProductPrice As Decimal
    Public Property Quantity As Integer
End Class

' Cart page code-behind
Public Class Cart
    Inherits System.Web.UI.Page

    ' Get the current cart from session
    Private Function GetCart() As List(Of CartItem)
        Dim cartItems As List(Of CartItem) = CType(Session("Cart"), List(Of CartItem))
        If cartItems Is Nothing Then
            cartItems = New List(Of CartItem)()
            Session("Cart") = cartItems
        End If
        Return cartItems
    End Function

    ' Add an item to the cart
    Private Sub AddItemToCart(ByVal productId As Integer, ByVal productName As String, ByVal productPrice As Decimal, ByVal quantity As Integer)
        Dim cartItems = GetCart()

        ' Check if the item already exists in the cart
        Dim existingItem = cartItems.FirstOrDefault(Function(item) item.ProductId = productId)

        If existingItem IsNot Nothing Then
            ' Update quantity if item already exists
            existingItem.Quantity += quantity
        Else
            ' Add new item to the cart
            cartItems.Add(New CartItem With {
                .ProductId = productId,
                .ProductName = productName,
                .ProductPrice = productPrice,
                .Quantity = quantity
            })
        End If

        ' Update session
        Session("Cart") = cartItems
    End Sub

    ' Calculate the total price of all items in the cart
    Private Function CalculateTotal() As Decimal
        Dim cartItems = GetCart()
        Return cartItems.Sum(Function(item) item.ProductPrice * item.Quantity)
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' Check if we have parameters in the query string to add an item to the cart
        Dim productId As String = Request.QueryString("id")
        Dim productName As String = Request.QueryString("name")
        Dim productPrice As String = Request.QueryString("price")
        Dim productQuantity As String = Request.QueryString("quantity")

        If Not String.IsNullOrEmpty(productId) AndAlso Not String.IsNullOrEmpty(productName) AndAlso Not String.IsNullOrEmpty(productPrice) AndAlso Not String.IsNullOrEmpty(productQuantity) Then
            AddItemToCart(Integer.Parse(productId), productName, Decimal.Parse(productPrice), Integer.Parse(productQuantity))
            Response.Redirect("Cart.aspx") ' To prevent re-adding the item on refresh
        End If

        ' Display the cart items (this would be handled in the ASPX page as shown earlier)
        Dim cartItems As List(Of CartItem) = GetCart()

        If cartItems.Count > 0 Then
            ' Bind cart items to the Repeater or display them accordingly
        Else
            ' Handle empty cart scenario (e.g., display a message)
        End If

        ' Calculate and display the total amount
        Dim total As Decimal = CalculateTotal()
        ' Bind the total amount to a label or any control on the page
    End Sub
End Class
