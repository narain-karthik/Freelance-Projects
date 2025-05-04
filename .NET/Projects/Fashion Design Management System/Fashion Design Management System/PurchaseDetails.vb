Imports System.Data.SqlClient

Public Class PurchaseDetails
    ' Declare dgvPurchaseDetails with WithEvents
    WithEvents dgvPurchaseDetails As New DataGridView()

    ' SQL Connection
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fashion;Integrated Security=True")
    Dim selectedPurchaseID As Integer = -1

    ' Load on Form Open
    Private Sub PurchaseDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadProductNames()
        cmbSize.Items.AddRange(New String() {"S", "M", "L", "XL", "XXL"})
        cmbSize.SelectedIndex = 0
        dtpPurchaseDate.Value = Date.Today
        LoadPurchases()
    End Sub

    ' Load Products from Products table
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
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    ' Load Purchase Records
    Private Sub LoadPurchases()
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM PurchaseDetails", con)
            da.Fill(dt)
            ' Bind the DataTable to the DataGridView
            dgvPurchaseDetails.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading purchases: " & ex.Message)
        End Try
    End Sub

    ' Add New Record
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO PurchaseDetails (ProductName, Quantity, Size, PurchasePrice, SupplierName, PurchaseDate, Remarks) VALUES (@ProductName, @Quantity, @Size, @PurchasePrice, @SupplierName, @PurchaseDate, @Remarks)", con)
            cmd.Parameters.AddWithValue("@ProductName", cmbProductName.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@Size", cmbSize.Text)
            cmd.Parameters.AddWithValue("@PurchasePrice", Convert.ToDecimal(txtPurchasePrice.Text))
            cmd.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text)
            cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Purchase added successfully!")
            LoadPurchases()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error adding purchase: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Update Record
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If selectedPurchaseID = -1 Then
            MessageBox.Show("Please select a record to update.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE PurchaseDetails SET ProductName=@ProductName, Quantity=@Quantity, Size=@Size, PurchasePrice=@PurchasePrice, SupplierName=@SupplierName, PurchaseDate=@PurchaseDate, Remarks=@Remarks WHERE PurchaseID=@PurchaseID", con)
            cmd.Parameters.AddWithValue("@ProductName", cmbProductName.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@Size", cmbSize.Text)
            cmd.Parameters.AddWithValue("@PurchasePrice", Convert.ToDecimal(txtPurchasePrice.Text))
            cmd.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text)
            cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
            cmd.Parameters.AddWithValue("@PurchaseID", selectedPurchaseID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Purchase updated successfully!")
            LoadPurchases()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error updating purchase: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Delete Record
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If selectedPurchaseID = -1 Then
            MessageBox.Show("Please select a record to delete.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM PurchaseDetails WHERE PurchaseID=@PurchaseID", con)
            cmd.Parameters.AddWithValue("@PurchaseID", selectedPurchaseID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Purchase deleted successfully!")
            LoadPurchases()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error deleting purchase: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Clear Form
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    ' Helper function to clear the form fields
    Private Sub ClearForm()
        cmbProductName.SelectedIndex = -1
        txtQuantity.Clear()
        cmbSize.SelectedIndex = 0
        txtPurchasePrice.Clear()
        txtSupplierName.Clear()
        dtpPurchaseDate.Value = Date.Today
        txtRemarks.Clear()
        selectedPurchaseID = -1
    End Sub

    ' Load Selected Row into Form
    Private Sub dgvPurchaseDetails_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvPurchaseDetails.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPurchaseDetails.Rows(e.RowIndex)
            selectedPurchaseID = Convert.ToInt32(row.Cells("PurchaseID").Value)
            cmbProductName.Text = row.Cells("ProductName").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            cmbSize.Text = row.Cells("Size").Value.ToString()
            txtPurchasePrice.Text = row.Cells("PurchasePrice").Value.ToString()
            txtSupplierName.Text = row.Cells("SupplierName").Value.ToString()
            dtpPurchaseDate.Value = Convert.ToDateTime(row.Cells("PurchaseDate").Value)
            txtRemarks.Text = row.Cells("Remarks").Value.ToString()
        End If
    End Sub
End Class
