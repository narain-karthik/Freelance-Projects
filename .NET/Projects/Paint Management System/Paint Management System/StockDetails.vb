Imports System.Data.SqlClient

Public Class StockDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PaintingManagement;Integrated Security=True"

    ' Product list (same as PurchaseDetails for consistency)
    Private ReadOnly productList As String() = {
        "Acrylic Paint (500ml)", "Oil Paint (200ml)", "Watercolor Paint (12 shades)",
        "Paint Brush Set (6 pieces)", "Roller Brush (9 inch)", "Paint Thinner (1L)",
        "Primer (1L)", "Varnish (500ml)", "Spray Paint (400ml)",
        "Paint Can (1L)", "Paint Can (4L)", "Drop Cloth (12x12 ft)",
        "Painter's Tape (1 inch)", "Sandpaper (pack of 5)", "Paint Tray",
        "Latex Gloves (pack of 10)", "Paint Scraper"
    }

    Private Sub StockDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with product names
        ComboBoxProductName.Items.AddRange(productList)
        ComboBoxProductName.SelectedIndex = 0 ' Select first item by default

        ' Initialize DataGridView columns
        With DataGridViewStock.Columns
            .Add("SNo", "S.No")
            .Add("ProductID", "Product ID")
            .Add("ProductName", "Product Name")
            .Add("StockIn", "Stock In")
            .Add("StockOut", "Stock Out")
            .Add("Balance", "Balance")
        End With
        DataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Generate initial IDs
        GenerateIDs()
    End Sub

    ' Auto-generate S.No and Product ID
    Private Sub GenerateIDs()
        Dim rowCount As Integer = DataGridViewStock.Rows.Count + 1
        TextBoxSNo.Text = rowCount.ToString()
        TextBoxProductID.Text = "P" & Now.Ticks Mod 10000 ' Simple unique ID
    End Sub

    ' Update Balance when Stock In or Stock Out changes
    Private Sub TextBoxStockIn_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxStockIn.TextChanged
        CalculateBalance()
    End Sub

    Private Sub TextBoxStockOut_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxStockOut.TextChanged
        CalculateBalance()
    End Sub

    Private Sub CalculateBalance()
        Dim stockIn As Integer
        Dim stockOut As Integer
        If Integer.TryParse(TextBoxStockIn.Text, stockIn) AndAlso Integer.TryParse(TextBoxStockOut.Text, stockOut) Then
            Dim balance As Integer = stockIn - stockOut
            TextBoxBalance.Text = balance.ToString()
        Else
            TextBoxBalance.Text = "0"
        End If
    End Sub

    ' Add entry to DataGridView
    Private Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAdd.Click
        Dim stockIn As Integer
        Dim stockOut As Integer
        If String.IsNullOrEmpty(TextBoxStockIn.Text) OrElse Not Integer.TryParse(TextBoxStockIn.Text, stockIn) OrElse stockIn < 0 Then
            MessageBox.Show("Please enter a valid non-negative Stock In value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrEmpty(TextBoxStockOut.Text) OrElse Not Integer.TryParse(TextBoxStockOut.Text, stockOut) OrElse stockOut < 0 Then
            MessageBox.Show("Please enter a valid non-negative Stock Out value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If stockOut > stockIn Then
            MessageBox.Show("Stock Out cannot exceed Stock In.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataGridViewStock.Rows.Add(
            TextBoxSNo.Text,
            TextBoxProductID.Text,
            ComboBoxProductName.SelectedItem.ToString(),
            TextBoxStockIn.Text,
            TextBoxStockOut.Text,
            TextBoxBalance.Text
        )

        ' Reset form for next entry
        TextBoxStockIn.Clear()
        TextBoxStockOut.Clear()
        TextBoxBalance.Clear()
        GenerateIDs()
    End Sub

    ' Save to database
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        If DataGridViewStock.Rows.Count = 0 Then
            MessageBox.Show("No stock details to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL Query to Insert Data
        Dim query As String = "INSERT INTO Stock (SNo, ProductID, ProductName, StockIn, StockOut, Balance) " &
                              "VALUES (@SNo, @ProductID, @ProductName, @StockIn, @StockOut, @Balance)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    For Each row As DataGridViewRow In DataGridViewStock.Rows
                        If Not row.IsNewRow Then ' Skip the new row placeholder
                            Dim sNo As Integer = Convert.ToInt32(row.Cells("SNo").Value)
                            Dim productID As String = row.Cells("ProductID").Value.ToString()
                            Dim productName As String = row.Cells("ProductName").Value.ToString()
                            Dim stockIn As Integer = Convert.ToInt32(row.Cells("StockIn").Value)
                            Dim stockOut As Integer = Convert.ToInt32(row.Cells("StockOut").Value)
                            Dim balance As Integer = Convert.ToInt32(row.Cells("Balance").Value)

                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@SNo", sNo)
                            cmd.Parameters.AddWithValue("@ProductID", productID)
                            cmd.Parameters.AddWithValue("@ProductName", productName)
                            cmd.Parameters.AddWithValue("@StockIn", stockIn)
                            cmd.Parameters.AddWithValue("@StockOut", stockOut)
                            cmd.Parameters.AddWithValue("@Balance", balance)

                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    MessageBox.Show("Stock details saved successfully to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridViewStock.Rows.Clear() ' Clear after saving
                    GenerateIDs()
                Catch ex As SqlException
                    MessageBox.Show("Error while inserting data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Error processing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class