Imports System.Data.SqlClient

Public Class Payment
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Fetch cart details and total amount from session
            Dim cartItems As List(Of CartItem) = Session("Cart")
            If cartItems IsNot Nothing AndAlso cartItems.Count > 0 Then
                ' Display the ordered product details
                lblOrderDetails.Text = String.Join("<br />", cartItems.Select(Function(item) item.ProductName & " - ₹" & item.ProductPrice & " x " & item.Quantity))
                Dim total As Decimal = cartItems.Sum(Function(item) item.ProductPrice * item.Quantity)
                lblTotalAmount.Text = "₹" & total.ToString("F2")

                ' Set the UPI Amount as the total amount
                txtUPIAmount.Text = total.ToString("F2")
            End If
        End If
    End Sub

    Protected Sub ddlPaymentMethod_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlPaymentMethod.SelectedIndexChanged
        ' Toggle payment details based on selected payment method
        If ddlPaymentMethod.SelectedValue = "UPI" Then
            upiDetails.Style("display") = "block"
            cardDetails.Style("display") = "none"
        ElseIf ddlPaymentMethod.SelectedValue = "Card" Then
            upiDetails.Style("display") = "none"
            cardDetails.Style("display") = "block"
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            ' Debug: Show raw Total Amount value
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Total Amount (raw): " & lblTotalAmount.Text & "');", True)

            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Dairy;Integrated Security=True"

            ' Validate input fields
            If String.IsNullOrWhiteSpace(txtName.Text) OrElse
               String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
               String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
               String.IsNullOrWhiteSpace(txtPincode.Text) OrElse
               String.IsNullOrWhiteSpace(txtPhoneNumber.Text) OrElse
               String.IsNullOrWhiteSpace(lblOrderDetails.Text) OrElse
               String.IsNullOrWhiteSpace(lblTotalAmount.Text) OrElse
               String.IsNullOrWhiteSpace(ddlPaymentMethod.SelectedValue) Then
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('All fields are required.');", True)
                Exit Sub
            End If

            ' Validate Total Amount
            Dim totalAmount As Decimal
            Dim totalAmountText As String = lblTotalAmount.Text.Trim().Replace("₹", "").Replace(",", "")

            If Not Decimal.TryParse(totalAmountText, totalAmount) Then
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Invalid Total Amount format. Please check your order details.');", True)
                Exit Sub
            End If

            ' Using block for database connection
            Using con As New SqlConnection(connectionString)
                ' Define the SQL query
                Dim query As String = "INSERT INTO Payments (FullName, Email, Address, Pincode, PhoneNumber, OrderDetails, TotalAmount, PaymentMethod, UPI_ID, CardNumber, CardholderName, CVV, ExpirationDate) VALUES (@FullName, @Email, @Address, @Pincode, @PhoneNumber, @OrderDetails, @TotalAmount, @PaymentMethod, @UPI_ID, @CardNumber,@CardholderName, @CVV, @ExpirationDate)"

                ' Create the SQL command
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@FullName", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                    cmd.Parameters.AddWithValue("@Pincode", txtPincode.Text.Trim())
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@OrderDetails", lblOrderDetails.Text.Trim())
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    cmd.Parameters.AddWithValue("@PaymentMethod", ddlPaymentMethod.SelectedValue)

                    ' Handle UPI Payment
                    If ddlPaymentMethod.SelectedValue = "UPI" Then
                        cmd.Parameters.AddWithValue("@UPI_ID", txtUPI.Text.Trim())
                        cmd.Parameters.AddWithValue("@CardNumber", DBNull.Value)
                        cmd.Parameters.AddWithValue("@CardholderName", DBNull.Value)
                        cmd.Parameters.AddWithValue("@CVV", DBNull.Value)
                        cmd.Parameters.AddWithValue("@ExpirationDate", DBNull.Value)
                    Else ' Handle Card Payment
                        cmd.Parameters.AddWithValue("@UPI_ID", DBNull.Value)
                        cmd.Parameters.AddWithValue("@CardNumber", txtCardNumber.Text.Trim())
                        cmd.Parameters.AddWithValue("@CardholderName", txtCardName.Text.Trim())
                        cmd.Parameters.AddWithValue("@CVV", txtCVV.Text.Trim())
                        cmd.Parameters.AddWithValue("@ExpirationDate", txtExpDate.Text.Trim())
                    End If

                    ' Open the connection and execute the command
                    con.Open()
                    cmd.ExecuteNonQuery()
                    ' After the payment is successful and inserted into the database, store order details in session
                    Session("FullName") = txtName.Text.Trim()
                    Session("Email") = txtEmail.Text.Trim()
                    Session("Address") = txtAddress.Text.Trim()
                    Session("PaymentMethod") = ddlPaymentMethod.SelectedValue
                    Session("Cart") = Session("Cart") ' This stores the cart details in session again

                    ' Redirect to confirmation page
                    Response.Redirect("~/PaymentConfirmation.aspx")

                    ' Display success message
                    ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Payment Successful!');", True)
                End Using
            End Using

        Catch ex As Exception
            ' Handle errors
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('An error occurred: " & ex.Message.Replace("'", "\'") & "');", True)
        End Try
    End Sub



    Private Function ValidateForm() As Boolean
        ' Basic form validation (add more as necessary)
        If String.IsNullOrEmpty(txtName.Text) OrElse
           String.IsNullOrEmpty(txtEmail.Text) OrElse
           String.IsNullOrEmpty(txtAddress.Text) OrElse
           String.IsNullOrEmpty(txtPincode.Text) OrElse
           String.IsNullOrEmpty(txtPhoneNumber.Text) OrElse
           (ddlPaymentMethod.SelectedValue = "UPI" AndAlso String.IsNullOrEmpty(txtUPI.Text)) OrElse
           (ddlPaymentMethod.SelectedValue = "Card" AndAlso (String.IsNullOrEmpty(txtCardNumber.Text) OrElse String.IsNullOrEmpty(txtCardName.Text) OrElse String.IsNullOrEmpty(txtCVV.Text) OrElse String.IsNullOrEmpty(txtExpDate.Text))) Then
            Response.Write("<script>alert('Please fill in all the required fields.');</script>")
            Return False
        End If
        Return True
    End Function
End Class
