Imports System.Data.SqlClient

Public Class Customer_Details
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadCustomers()
        End If
    End Sub

    Private Sub LoadCustomers()
        Dim dt As New DataTable()
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
            Using cmd As New SqlCommand("SELECT * FROM Customers", con)
                Using sda As New SqlDataAdapter(cmd)
                    sda.Fill(dt)
                End Using
            End Using
        End Using
        CustomerGridView.DataSource = dt
        CustomerGridView.DataBind()
    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
            Dim query As String = "SET IDENTITY_INSERT Customers ON; INSERT INTO Customers (CustomerID, CustomerName, Email, Phone) VALUES (@CustomerID, @CustomerName, @Email, @Phone); SET IDENTITY_INSERT Customers OFF;"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text)
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        LoadCustomers()
        lblMessage.Text = "Customer added successfully!"
        lblMessage.Visible = True
    End Sub

End Class
