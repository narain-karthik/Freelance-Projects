Imports System.Data.SqlClient

Public Class StockDetails

    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fruit;Integrated Security=True")
    Dim selectedStockID As Integer = -1

    Private Sub StockDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadFruitNames()
        cmbUnit.Items.AddRange(New String() {"kg", "dozen", "piece"})
        cmbUnit.SelectedIndex = 0
        dtpLastUpdated.Value = Date.Today
        LoadStock()
    End Sub

    Private Sub LoadFruitNames()
        cmbFruitName.Items.Clear()
        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT DISTINCT FruitName FROM Fruits", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbFruitName.Items.Add(reader("FruitName").ToString())
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading fruit names: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadStock()
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM StockDetails", con)
            da.Fill(dt)
            dgvStockDetails.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading stock: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO StockDetails (FruitName, QuantityInStock, Unit, LastUpdated, Remarks) VALUES (@FruitName, @QuantityInStock, @Unit, @LastUpdated, @Remarks)", con)
            cmd.Parameters.AddWithValue("@FruitName", cmbFruitName.Text)
            cmd.Parameters.AddWithValue("@QuantityInStock", Convert.ToInt32(txtQuantityInStock.Text))
            cmd.Parameters.AddWithValue("@Unit", cmbUnit.Text)
            cmd.Parameters.AddWithValue("@LastUpdated", dtpLastUpdated.Value)
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Stock added successfully!")
            LoadStock()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error adding stock: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If selectedStockID = -1 Then
            MessageBox.Show("Please select a stock entry to update.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE StockDetails SET FruitName=@FruitName, QuantityInStock=@QuantityInStock, Unit=@Unit, LastUpdated=@LastUpdated, Remarks=@Remarks WHERE StockID=@StockID", con)
            cmd.Parameters.AddWithValue("@FruitName", cmbFruitName.Text)
            cmd.Parameters.AddWithValue("@QuantityInStock", Convert.ToInt32(txtQuantityInStock.Text))
            cmd.Parameters.AddWithValue("@Unit", cmbUnit.Text)
            cmd.Parameters.AddWithValue("@LastUpdated", dtpLastUpdated.Value)
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
            cmd.Parameters.AddWithValue("@StockID", selectedStockID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Stock updated successfully!")
            LoadStock()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If selectedStockID = -1 Then
            MessageBox.Show("Please select a stock entry to delete.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM StockDetails WHERE StockID=@StockID", con)
            cmd.Parameters.AddWithValue("@StockID", selectedStockID)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Stock deleted successfully!")
            LoadStock()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error deleting stock: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cmbFruitName.SelectedIndex = -1
        txtQuantityInStock.Clear()
        cmbUnit.SelectedIndex = 0
        dtpLastUpdated.Value = Date.Today
        txtRemarks.Clear()
        selectedStockID = -1
    End Sub

    Private Sub dgvStockDetails_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvStockDetails.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStockDetails.Rows(e.RowIndex)
            selectedStockID = Convert.ToInt32(row.Cells("StockID").Value)
            cmbFruitName.Text = row.Cells("FruitName").Value.ToString()
            txtQuantityInStock.Text = row.Cells("QuantityInStock").Value.ToString()
            cmbUnit.Text = row.Cells("Unit").Value.ToString()
            dtpLastUpdated.Value = Convert.ToDateTime(row.Cells("LastUpdated").Value)
            txtRemarks.Text = row.Cells("Remarks").Value.ToString()
        End If
    End Sub

End Class
