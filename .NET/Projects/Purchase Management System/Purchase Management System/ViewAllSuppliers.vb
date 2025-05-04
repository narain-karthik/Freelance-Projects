Imports System.Data.SqlClient

Public Class ViewAllSuppliers
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PurchaseManagement;Integrated Security=True")

    Private Sub ViewAllSuppliers_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadSuppliers()
    End Sub

    Private Sub LoadSuppliers()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("SELECT SupplierID, SupplierName, Phone, Email, Address, GSTNumber FROM Suppliers", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvSuppliers.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        LoadSuppliers()
    End Sub
End Class
