Imports System.Data.SqlClient

Public Class PurchaseOrders
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PurchaseManagement;Integrated Security=True")

    Private Sub PurchaseOrders_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadSuppliers()
        LoadProducts()
    End Sub

    Private Sub LoadSuppliers()
        Try
            cmbSupplier.Items.Clear()
            con.Open()
            Dim cmd As New SqlCommand("SELECT SupplierID, SupplierName FROM Suppliers", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cmbSupplier.Items.Add(New With {
                    .Text = reader("SupplierName").ToString(),
                    .Value = reader("SupplierID")
                })
            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading suppliers: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub LoadProducts()
        Try
            cmbProductName.Items.Clear()
            con.Open()
            Dim cmd As New SqlCommand("SELECT ProductID, ProductName, PurchasePrice FROM Products", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cmbProductName.Items.Add(New With {
                    .Text = reader("ProductName").ToString(),
                    .Value = reader("ProductID"),
                    .Price = reader("PurchasePrice")
                })
            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbProductName.SelectedIndexChanged
        Dim selected = CType(cmbProductName.SelectedItem, Object)
        txtPurchasePrice.Text = selected.Price.ToString()
        CalculateTotal()
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtQuantity.TextChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Dim qty As Integer
        Dim price As Decimal

        Integer.TryParse(txtQuantity.Text, qty)
        Decimal.TryParse(txtPurchasePrice.Text, price)

        txtTotalAmount.Text = (qty * price).ToString("F2")
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        ' Validate required fields
        If cmbSupplier.SelectedItem Is Nothing Or cmbProductName.SelectedItem Is Nothing Or txtQuantity.Text = "" Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve values
        Dim supplierId = CType(cmbSupplier.SelectedItem, Object).Value
        Dim productId = CType(cmbProductName.SelectedItem, Object).Value
        Dim orderDate = dtpOrderDate.Value
        Dim purchasePrice As Decimal
        Dim quantity As Integer
        Dim totalAmount As Decimal

        ' Validate numeric fields
        If Not Decimal.TryParse(txtPurchasePrice.Text, purchasePrice) Then
            MessageBox.Show("Invalid purchase price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show("Invalid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        totalAmount = purchasePrice * quantity

        ' Insert into PurchaseOrders table
        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO PurchaseOrders (SupplierID, OrderDate, ProductID, PurchasePrice, Quantity, TotalAmount) VALUES (@SupplierID, @OrderDate, @ProductID, @PurchasePrice, @Quantity, @TotalAmount)", con)
            cmd.Parameters.AddWithValue("@SupplierID", supplierId)
            cmd.Parameters.AddWithValue("@OrderDate", orderDate)
            cmd.Parameters.AddWithValue("@ProductID", productId)
            cmd.Parameters.AddWithValue("@PurchasePrice", purchasePrice)
            cmd.Parameters.AddWithValue("@Quantity", quantity)
            cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)

            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Purchase Order Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error submitting order: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub ClearForm()
        txtQuantity.Clear()
        txtPurchasePrice.Clear()
        txtTotalAmount.Clear()
        cmbSupplier.SelectedIndex = -1
        cmbProductName.SelectedIndex = -1
    End Sub

End Class
