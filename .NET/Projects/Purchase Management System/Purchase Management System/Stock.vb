Imports System.Data.SqlClient

Public Class Stock
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PurchaseManagement;Integrated Security=True")

    Private Sub Stock_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT ProductID, ProductName FROM Products", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbProductName.Items.Add(New With {
                    .Text = reader("ProductName").ToString(),
                    .Value = reader("ProductID")
                })
            End While
            con.Close()
            cmbProductName.DisplayMember = "Text"
            cmbProductName.ValueMember = "Value"
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbProductName.SelectedIndexChanged
        txtAvailable.Text = ""
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        If cmbProductName.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a product.")
            Return
        End If

        Dim productId = CType(cmbProductName.SelectedItem, Object).Value
        Dim stockIn As Integer = If(txtStockIn.Text <> "", Convert.ToInt32(txtStockIn.Text), 0)
        Dim stockOut As Integer = If(txtStockOut.Text <> "", Convert.ToInt32(txtStockOut.Text), 0)

        If stockIn = 0 AndAlso stockOut = 0 Then
            MessageBox.Show("Please enter either Stock In or Stock Out.")
            Return
        End If

        ' Calculate Total Available Stock (do not fetch from product table)
        Dim totalAvailableStock As Integer = stockIn - stockOut
        txtAvailable.Text = totalAvailableStock.ToString()

        Try
            con.Open()

            ' Insert into StockTransactions only
            Dim insertCmd As New SqlCommand("INSERT INTO StockTransactions (ProductID, StockIn, StockOut, AvailableStock) VALUES (@ProductID, @StockIn, @StockOut, @AvailableStock)", con)
            insertCmd.Parameters.AddWithValue("@ProductID", productId)
            insertCmd.Parameters.AddWithValue("@StockIn", stockIn)
            insertCmd.Parameters.AddWithValue("@StockOut", stockOut)
            insertCmd.Parameters.AddWithValue("@AvailableStock", totalAvailableStock)
            insertCmd.ExecuteNonQuery()

            con.Close()
            MessageBox.Show("Stock transaction saved successfully.")
        Catch ex As Exception
            MessageBox.Show("Error saving stock transaction: " & ex.Message)
            con.Close()
        End Try
    End Sub

    

End Class
