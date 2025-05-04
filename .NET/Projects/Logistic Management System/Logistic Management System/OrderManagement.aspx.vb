Imports System.Data.SqlClient
Imports System.Configuration

Partial Public Class OrderManagement
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadOrders()
        End If
    End Sub

    Private Sub LoadOrders()
        Dim dt As New DataTable()
        Dim query As String = "SELECT OrderID, CustomerName, OrderDate, Status FROM Orders"

        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
            Using cmd As New SqlCommand(query, con)
                Using da As New SqlDataAdapter(cmd)
                    con.Open()
                    da.Fill(dt)
                End Using
            End Using
        End Using

        OrderGridView.DataSource = dt
        OrderGridView.DataBind()
    End Sub

    Protected Sub RefreshButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        LoadOrders()
        StatusLabel.Text = "Orders refreshed successfully."
        StatusLabel.Visible = True
    End Sub

    Protected Sub OrderGridView_RowCommand(ByVal sender As Object, ByVal e As GridViewCommandEventArgs)
        If e.CommandName = "UpdateStatus" Then
            Dim rowIndex As Integer = Convert.ToInt32(e.CommandArgument)
            Dim orderID As Integer = Convert.ToInt32(OrderGridView.DataKeys(rowIndex).Value)

            Dim query As String = "UPDATE Orders SET Status = 'Shipped' WHERE OrderID = @OrderID"

            Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@OrderID", orderID)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            StatusLabel.Text = "Status updated for Order ID: " & orderID
            StatusLabel.Visible = True
            LoadOrders()
        End If
    End Sub

    Protected Sub btnCreateOrder_Click(ByVal sender As Object, ByVal e As EventArgs)
        If String.IsNullOrEmpty(txtCustomerName.Text) Then
            CreateStatusLabel.Text = "Please enter a customer name."
            CreateStatusLabel.ForeColor = Drawing.Color.Red
            CreateStatusLabel.Visible = True
            Return
        End If

        Dim query As String = "INSERT INTO Orders (CustomerName, OrderDate, Status) VALUES (@CustomerName, @OrderDate, @Status)"

        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now)
                cmd.Parameters.AddWithValue("@Status", ddlStatus.SelectedValue)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        txtCustomerName.Text = ""
        ddlStatus.SelectedIndex = 0
        CreateStatusLabel.Text = "Order created successfully!"
        CreateStatusLabel.ForeColor = Drawing.Color.Green
        CreateStatusLabel.Visible = True

        LoadOrders()
    End Sub
End Class
