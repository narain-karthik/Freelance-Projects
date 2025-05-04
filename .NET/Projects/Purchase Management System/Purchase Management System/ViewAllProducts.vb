Imports System.Data.SqlClient

Public Class ViewAllProducts
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PurchaseManagement;Integrated Security=True")

    Private Sub ViewAllProducts_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("SELECT ProductID, ProductName, PurchasePrice, SellingPrice FROM Products", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvProducts.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        LoadProducts()
    End Sub
End Class
