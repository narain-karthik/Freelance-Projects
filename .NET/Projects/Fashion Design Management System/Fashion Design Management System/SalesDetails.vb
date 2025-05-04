Imports System.Data.SqlClient

Public Class SalesDetails

    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fashion;Integrated Security=True")
    Dim selectedSalesID As Integer = -1

    Private Sub SalesDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadProductNames()
        cmbUnit.Items.AddRange(New String() {"Piece", "Set", "Bundle"})
        cmbUnit.SelectedIndex = 0
        dtpSalesDate.Value = Date.Today
        LoadSales()
    End Sub

    Private Sub LoadProductNames()
        cmbProductName.Items.Clear()
        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT DISTINCT ProductName FROM Products", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbProductName.Items.Add(reader("ProductName").ToString())
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading product names: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSales()
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM SalesDetails", con)
            da.Fill(dt)
            dgvSalesDetails.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO SalesDetails (ProductName, Quantity, Unit, SellingPrice, CustomerName, SalesDate, Remarks) VALUES (@ProductName, @Quantity, @Unit, @SellingPrice, @CustomerName, @SalesDate, @Remarks)", con)
            cmd.Parameters.AddWithValue("@ProductName", cmbProductName.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@Unit", cmbUnit.Text)
            cmd.Parameters.AddWithValue("@SellingPrice", Convert.ToDecimal(txtSellingPrice.Text))
            cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
            cmd.Parameters.AddWithValue("@SalesDate", dtpSalesDate.Value)
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Sales entry added successfully!")
            LoadSales()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error adding sales: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If selectedSalesID = -1 Then
            MessageBox.Show("Please select a record to update.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE SalesDetails SET ProductName=@ProductName, Quantity=@Quantity, Unit=@Unit, SellingPrice=@SellingPrice, CustomerName=@CustomerName, SalesDate=@SalesDate, Remarks=@Remarks WHERE SalesID=@SalesID", con)
            cmd.Parameters.AddWithValue("@ProductName", cmbProductName.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@Unit", cmbUnit.Text)
            cmd.Parameters.AddWithValue("@SellingPrice", Convert.ToDecimal(txtSellingPrice.Text))
            cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
            cmd.Parameters.AddWithValue("@SalesDate", dtpSalesDate.Value)
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
            cmd.Parameters.AddWithValue("@SalesID", selectedSalesID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Sales entry updated!")
            LoadSales()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error updating sales: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If selectedSalesID = -1 Then
            MessageBox.Show("Please select a record to delete.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM SalesDetails WHERE SalesID=@SalesID", con)
            cmd.Parameters.AddWithValue("@SalesID", selectedSalesID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Sales entry deleted.")
            LoadSales()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error deleting sales: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cmbProductName.SelectedIndex = -1
        txtQuantity.Text = ""
        cmbUnit.SelectedIndex = 0
        txtSellingPrice.Text = ""
        txtCustomerName.Text = ""
        dtpSalesDate.Value = Date.Today
        txtRemarks.Text = ""
        selectedSalesID = -1
    End Sub

    Private Sub dgvSalesDetails_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSalesDetails.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSalesDetails.Rows(e.RowIndex)
            selectedSalesID = Convert.ToInt32(row.Cells("SalesID").Value)
            cmbProductName.Text = row.Cells("ProductName").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            cmbUnit.Text = row.Cells("Unit").Value.ToString()
            txtSellingPrice.Text = row.Cells("SellingPrice").Value.ToString()
            txtCustomerName.Text = row.Cells("CustomerName").Value.ToString()
            dtpSalesDate.Value = Convert.ToDateTime(row.Cells("SalesDate").Value)
            txtRemarks.Text = row.Cells("Remarks").Value.ToString()
        End If
    End Sub

End Class
