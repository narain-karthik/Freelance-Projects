Imports System.Data.SqlClient

Public Class ProductDetails

    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fashion;Integrated Security=True")
    Dim selectedProductID As Integer = -1

    ' Declare WithEvents for controls
    WithEvents cmbProductName As ComboBox
    WithEvents cmbSize As ComboBox
    WithEvents dgvProducts As DataGridView

    ' Load form
    Private Sub ProductDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cmbProductName = New ComboBox()
        cmbSize = New ComboBox()
        dgvProducts = New DataGridView()

        ' Set combo box values
        cmbProductName.Items.AddRange(New String() {"Shirt", "Jeans", "Jacket", "Dress", "Sweater"})
        cmbSize.Items.AddRange(New String() {"S", "M", "L", "XL", "XXL"})

        cmbProductName.SelectedIndex = 0
        cmbSize.SelectedIndex = 0
        txtPricePerUnit.Text = "0.00"
        dtpPurchaseDate.Value = Date.Today
        dtpExpiryDate.Value = Date.Today.AddDays(30)

        LoadProducts()
    End Sub

    ' Load products into DataGridView
    Private Sub LoadProducts()
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM Products", con)
            da.Fill(dt)
            dgvProducts.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    ' Add new product
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtPricePerUnit.Text.Trim() = "" Then txtPricePerUnit.Text = "0.00"

        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Products (ProductName, Size, Quantity, PricePerUnit, Supplier, PurchaseDate, ExpiryDate) VALUES (@ProductName, @Size, @Quantity, @PricePerUnit, @Supplier, @PurchaseDate, @ExpiryDate)", con)
            cmd.Parameters.AddWithValue("@ProductName", cmbProductName.Text)
            cmd.Parameters.AddWithValue("@Size", cmbSize.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@PricePerUnit", Convert.ToDecimal(txtPricePerUnit.Text))
            cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text)
            cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
            cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Product added successfully!")
            LoadProducts()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Update product
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If selectedProductID = -1 Then
            MessageBox.Show("Please select a product to update.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Products SET ProductName=@ProductName, Size=@Size, Quantity=@Quantity, PricePerUnit=@PricePerUnit, Supplier=@Supplier, PurchaseDate=@PurchaseDate, ExpiryDate=@ExpiryDate WHERE ProductID=@ProductID", con)
            cmd.Parameters.AddWithValue("@ProductName", cmbProductName.Text)
            cmd.Parameters.AddWithValue("@Size", cmbSize.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@PricePerUnit", Convert.ToDecimal(txtPricePerUnit.Text))
            cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text)
            cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
            cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value)
            cmd.Parameters.AddWithValue("@ProductID", selectedProductID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Product updated successfully!")
            LoadProducts()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Delete product
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If selectedProductID = -1 Then
            MessageBox.Show("Please select a product to delete.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Products WHERE ProductID=@ProductID", con)
            cmd.Parameters.AddWithValue("@ProductID", selectedProductID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Product deleted successfully!")
            LoadProducts()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Clear form fields
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cmbProductName.SelectedIndex = 0
        txtQuantity.Text = ""
        cmbSize.SelectedIndex = 0
        txtPricePerUnit.Text = "0.00"
        txtSupplier.Text = ""
        dtpPurchaseDate.Value = Date.Today
        dtpExpiryDate.Value = Date.Today.AddDays(30)
        selectedProductID = -1
    End Sub

    ' Handle grid row selection
    Private Sub dgvProducts_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            selectedProductID = Convert.ToInt32(row.Cells("ProductID").Value)
            cmbProductName.Text = row.Cells("ProductName").Value.ToString()
            cmbSize.Text = row.Cells("Size").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            txtPricePerUnit.Text = row.Cells("PricePerUnit").Value.ToString()
            txtSupplier.Text = row.Cells("Supplier").Value.ToString()
            dtpPurchaseDate.Value = Convert.ToDateTime(row.Cells("PurchaseDate").Value)
            dtpExpiryDate.Value = Convert.ToDateTime(row.Cells("ExpiryDate").Value)
        End If
    End Sub

End Class
