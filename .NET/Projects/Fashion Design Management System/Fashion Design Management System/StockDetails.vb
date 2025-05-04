Imports System.Data.SqlClient

Public Class StockDetails
    ' Assuming you have a SqlConnection object
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fashion;Integrated Security=True")

    ' Form Load Event to Load Data into DataGridView
    Private Sub StockDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Method to load data into DataGridView from the database
    Private Sub LoadData()
        ' Open the connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' Load the data from the database into the DataGridView
        Dim query As String = "SELECT * FROM FashionStockDetails"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        adapter.Fill(dt)

        ' Bind the DataTable to the DataGridView
        dgvFashionStockDetails.DataSource = dt

        ' Close the connection
        con.Close()
    End Sub

    ' Method to clear the form fields
    Private Sub ClearFields()
        cmbProductName.SelectedIndex = -1
        txtQuantityInStock.Clear()
        cmbSize.SelectedIndex = -1
        cmbColor.SelectedIndex = -1
        dtpLastUpdated.Value = DateTime.Now
        txtRemarks.Clear()
    End Sub

    ' Add Button Click Event
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        ' Make sure the connection is open
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' Create the SQL query to insert the data into the database
        Dim query As String = "INSERT INTO FashionStockDetails (ProductName, QuantityInStock, Size, Color, LastUpdated, Remarks) " & _
                              "VALUES (@ProductName, @QuantityInStock, @Size, @Color, @LastUpdated, @Remarks)"

        ' Create the SqlCommand and pass the query and connection
        Dim cmd As New SqlCommand(query, con)

        ' Add parameters to prevent SQL injection and insert the values
        cmd.Parameters.AddWithValue("@ProductName", cmbProductName.Text)
        cmd.Parameters.AddWithValue("@QuantityInStock", Convert.ToInt32(txtQuantityInStock.Text))
        cmd.Parameters.AddWithValue("@Size", cmbSize.Text)
        cmd.Parameters.AddWithValue("@Color", cmbColor.Text)
        cmd.Parameters.AddWithValue("@LastUpdated", dtpLastUpdated.Value)
        cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

        ' Execute the query
        cmd.ExecuteNonQuery()

        ' Close the connection
        con.Close()

        ' Optional: Clear the form fields after adding
        ClearFields()

        ' Refresh the data grid view
        LoadData()
    End Sub

    ' Update Button Click Event
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        ' Make sure the connection is open
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' Update SQL query
        Dim query As String = "UPDATE FashionStockDetails SET ProductName=@ProductName, QuantityInStock=@QuantityInStock, " & _
                              "Size=@Size, Color=@Color, LastUpdated=@LastUpdated, Remarks=@Remarks WHERE StockID=@StockID"

        ' Create the SqlCommand and pass the query and connection
        Dim cmd As New SqlCommand(query, con)

        ' Add parameters to prevent SQL injection and update the values
        cmd.Parameters.AddWithValue("@ProductName", cmbProductName.Text)
        cmd.Parameters.AddWithValue("@QuantityInStock", Convert.ToInt32(txtQuantityInStock.Text))
        cmd.Parameters.AddWithValue("@Size", cmbSize.Text)
        cmd.Parameters.AddWithValue("@Color", cmbColor.Text)
        cmd.Parameters.AddWithValue("@LastUpdated", dtpLastUpdated.Value)
        cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
        cmd.Parameters.AddWithValue("@StockID", dgvFashionStockDetails.SelectedRows(0).Cells("StockID").Value)

        ' Execute the query
        cmd.ExecuteNonQuery()

        ' Close the connection
        con.Close()

        ' Refresh the data grid view
        LoadData()
    End Sub

    ' Delete Button Click Event
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        ' Make sure the connection is open
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' Delete SQL query
        Dim query As String = "DELETE FROM FashionStockDetails WHERE StockID=@StockID"

        ' Create the SqlCommand and pass the query and connection
        Dim cmd As New SqlCommand(query, con)

        ' Add parameter for StockID
        cmd.Parameters.AddWithValue("@StockID", dgvFashionStockDetails.SelectedRows(0).Cells("StockID").Value)

        ' Execute the query
        cmd.ExecuteNonQuery()

        ' Close the connection
        con.Close()

        ' Refresh the data grid view
        LoadData()
    End Sub

    ' Clear Button Click Event
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ' Clear the form fields
        ClearFields()
    End Sub

End Class
