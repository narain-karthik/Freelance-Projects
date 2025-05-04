Imports System.Data.SqlClient

Public Class StockDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=ProductManagement;Integrated Security=True"

    ' Product list
    Private ReadOnly products As String() = {
        "Electrical Motor Stamping",
        "Monoblock Pump Stampings",
        "1071 Electrical Stamping",
        "Single Phase Electrical Motor Stampings",
        "4 Hp Electrical Motor Stampings",
        "Crno Lamination Stamping",
        "Mild Steel Electrical Stamping",
        "5 Hp Single Phase Electrical Stamping",
        "Monoblock Electro Stamping"
    }

    Private Sub StockDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with product names
        ComboBoxProductName.Items.AddRange(products)
        ComboBoxProductName.SelectedIndex = 0 ' Select first item by default

        ' Initialize DataGridView columns
        With DataGridViewStock.Columns
            .Add("SNo", "S.No")
            .Add("ProductID", "Product ID")
            .Add("ProductName", "Product Name")
            .Add("StockIn", "Stock In (Kg)")
            .Add("StockOut", "Stock Out (Kg)")
            .Add("Balance", "Balance (Kg)")
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
        Dim stockIn As Decimal
        Dim stockOut As Decimal
        Dim hasStockIn As Boolean = Decimal.TryParse(TextBoxStockIn.Text, stockIn) AndAlso stockIn >= 0
        Dim hasStockOut As Boolean = Decimal.TryParse(TextBoxStockOut.Text, stockOut) AndAlso stockOut >= 0

        If hasStockIn OrElse hasStockOut Then
            stockIn = If(hasStockIn, stockIn, 0)
            stockOut = If(hasStockOut, stockOut, 0)
            Dim balance As Decimal = stockIn - stockOut
            TextBoxBalance.Text = balance.ToString("F2") ' 2 decimal places
        Else
            TextBoxBalance.Text = "0.00"
        End If
    End Sub

    ' Add entry to DataGridView
    Private Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAdd.Click
        Dim stockIn As Decimal
        Dim stockOut As Decimal
        Dim hasStockIn As Boolean = Decimal.TryParse(TextBoxStockIn.Text, stockIn) AndAlso stockIn >= 0
        Dim hasStockOut As Boolean = Decimal.TryParse(TextBoxStockOut.Text, stockOut) AndAlso stockOut >= 0

        If Not hasStockIn AndAlso Not hasStockOut Then
            MessageBox.Show("Please enter a valid Stock In or Stock Out quantity (at least one must be provided).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataGridViewStock.Rows.Add(
            TextBoxSNo.Text,
            TextBoxProductID.Text,
            ComboBoxProductName.SelectedItem.ToString(),
            If(hasStockIn, stockIn.ToString("F2"), "0.00"),
            If(hasStockOut, stockOut.ToString("F2"), "0.00"),
            TextBoxBalance.Text
        )

        ' Reset form for next entry
        TextBoxStockIn.Clear()
        TextBoxStockOut.Clear()
        ComboBoxProductName.SelectedIndex = 0
        GenerateIDs()
    End Sub

    ' Save to database
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        If DataGridViewStock.Rows.Count = 0 Then
            MessageBox.Show("No stock details to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO Stock (SNo, ProductID, ProductName, StockIn, StockOut, Balance) " &
                              "VALUES (@SNo, @ProductID, @ProductName, @StockIn, @StockOut, @Balance)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    For Each row As DataGridViewRow In DataGridViewStock.Rows
                        If Not row.IsNewRow Then
                            Dim sNo As Integer = Convert.ToInt32(row.Cells("SNo").Value)
                            Dim productID As String = row.Cells("ProductID").Value.ToString()
                            Dim productName As String = row.Cells("ProductName").Value.ToString()
                            Dim stockIn As Decimal = Convert.ToDecimal(row.Cells("StockIn").Value)
                            Dim stockOut As Decimal = Convert.ToDecimal(row.Cells("StockOut").Value)
                            Dim balance As Decimal = Convert.ToDecimal(row.Cells("Balance").Value)

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
                    MessageBox.Show("Stock details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridViewStock.Rows.Clear()
                    GenerateIDs()
                Catch ex As SqlException
                    MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class