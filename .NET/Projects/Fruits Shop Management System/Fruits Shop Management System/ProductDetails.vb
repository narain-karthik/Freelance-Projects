Imports System.Data.SqlClient

Public Class ProductDetails

    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fruit;Integrated Security=True")
    Dim selectedFruitID As Integer = -1

    ' Load form
    Private Sub ProductDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cmbFruitName.Items.AddRange(New String() {"Apple", "Banana", "Orange", "Mango", "Grapes", "Pineapple", "Watermelon", "Papaya"})
        cmbUnit.Items.AddRange(New String() {"kg", "dozen", "piece"})

        cmbFruitName.SelectedIndex = 0
        cmbUnit.SelectedIndex = 0
        txtPricePerUnit.Text = "0.00"
        dtpPurchaseDate.Value = Date.Today
        dtpExpiryDate.Value = Date.Today.AddDays(7)

        LoadFruits()
    End Sub

    ' Load fruits into DataGridView
    Private Sub LoadFruits()
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM Fruits", con)
            da.Fill(dt)
            dgvFruits.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading fruits: " & ex.Message)
        End Try
    End Sub

    ' Add new fruit
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtPricePerUnit.Text.Trim() = "" Then txtPricePerUnit.Text = "0.00"

        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Fruits (FruitName, Quantity, Unit, PricePerUnit, Supplier, PurchaseDate, ExpiryDate) VALUES (@FruitName, @Quantity, @Unit, @PricePerUnit, @Supplier, @PurchaseDate, @ExpiryDate)", con)
            cmd.Parameters.AddWithValue("@FruitName", cmbFruitName.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@Unit", cmbUnit.Text)
            cmd.Parameters.AddWithValue("@PricePerUnit", Convert.ToDecimal(txtPricePerUnit.Text))
            cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text)
            cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
            cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Fruit added successfully!")
            LoadFruits()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error adding fruit: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Update fruit
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If selectedFruitID = -1 Then
            MessageBox.Show("Please select a fruit to update.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Fruits SET FruitName=@FruitName, Quantity=@Quantity, Unit=@Unit, PricePerUnit=@PricePerUnit, Supplier=@Supplier, PurchaseDate=@PurchaseDate, ExpiryDate=@ExpiryDate WHERE FruitID=@FruitID", con)
            cmd.Parameters.AddWithValue("@FruitName", cmbFruitName.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@Unit", cmbUnit.Text)
            cmd.Parameters.AddWithValue("@PricePerUnit", Convert.ToDecimal(txtPricePerUnit.Text))
            cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text)
            cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
            cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value)
            cmd.Parameters.AddWithValue("@FruitID", selectedFruitID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Fruit updated successfully!")
            LoadFruits()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error updating fruit: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Delete fruit
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If selectedFruitID = -1 Then
            MessageBox.Show("Please select a fruit to delete.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Fruits WHERE FruitID=@FruitID", con)
            cmd.Parameters.AddWithValue("@FruitID", selectedFruitID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Fruit deleted successfully!")
            LoadFruits()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error deleting fruit: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Clear form fields
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cmbFruitName.SelectedIndex = 0
        txtQuantity.Text = ""
        cmbUnit.SelectedIndex = 0
        txtPricePerUnit.Text = "0.00"
        txtSupplier.Text = ""
        dtpPurchaseDate.Value = Date.Today
        dtpExpiryDate.Value = Date.Today.AddDays(7)
        selectedFruitID = -1
    End Sub

    ' Handle grid row selection
    Private Sub dgvFruits_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvFruits.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvFruits.Rows(e.RowIndex)
            selectedFruitID = Convert.ToInt32(row.Cells("FruitID").Value)
            cmbFruitName.Text = row.Cells("FruitName").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            cmbUnit.Text = row.Cells("Unit").Value.ToString()
            txtPricePerUnit.Text = row.Cells("PricePerUnit").Value.ToString()
            txtSupplier.Text = row.Cells("Supplier").Value.ToString()
            dtpPurchaseDate.Value = Convert.ToDateTime(row.Cells("PurchaseDate").Value)
            dtpExpiryDate.Value = Convert.ToDateTime(row.Cells("ExpiryDate").Value)
        End If
    End Sub

End Class
