Imports System.Data.SqlClient
Imports System.Globalization

Public Class SalesDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PaintingManagement;Integrated Security=True"

    ' Product list and prices (same as PurchaseDetails)
    Private ReadOnly productPrices As New Dictionary(Of String, Decimal) From {
        {"Acrylic Paint (500ml)", 250D}, {"Oil Paint (200ml)", 350D}, {"Watercolor Paint (12 shades)", 200D},
        {"Paint Brush Set (6 pieces)", 150D}, {"Roller Brush (9 inch)", 120D}, {"Paint Thinner (1L)", 300D},
        {"Primer (1L)", 400D}, {"Varnish (500ml)", 450D}, {"Spray Paint (400ml)", 280D},
        {"Paint Can (1L)", 600D}, {"Paint Can (4L)", 2200D}, {"Drop Cloth (12x12 ft)", 180D},
        {"Painter's Tape (1 inch)", 100D}, {"Sandpaper (pack of 5)", 80D}, {"Paint Tray", 90D},
        {"Latex Gloves (pack of 10)", 50D}, {"Paint Scraper", 110D}
    }

    Private Sub SalesDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with product names
        ComboBoxProductName.Items.AddRange(productPrices.Keys.ToArray())
        ComboBoxProductName.SelectedIndex = 0 ' Select first item by default

        ' Initialize DataGridView columns with INR symbol
        With DataGridViewSales.Columns
            .Add("SNo", "S.No")
            .Add("ProductID", "Product ID")
            .Add("CustomerID", "Customer ID")
            .Add("CustomerName", "Customer Name")
            .Add("ProductName", "Product Name")
            .Add("SaleDate", "Sale Date")
            .Add("Quantity", "Quantity")
            .Add("Price", "Price (₹)")
            .Add("Total", "Total (₹)")
        End With
        DataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Generate initial IDs
        GenerateIDs()
    End Sub

    ' Auto-generate S.No and Product ID
    Private Sub GenerateIDs()
        Dim rowCount As Integer = DataGridViewSales.Rows.Count + 1
        TextBoxSNo.Text = rowCount.ToString()
        TextBoxProductID.Text = "P" & Now.Ticks Mod 10000 ' Simple unique ID
    End Sub

    ' Auto-fill Customer Name when Customer ID is entered
    Private Sub TextBoxCustomerID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxCustomerID.TextChanged
        Dim customerID As String = TextBoxCustomerID.Text.Trim()
        If Not String.IsNullOrEmpty(customerID) Then
            Dim query As String = "SELECT CustomerName FROM Customers WHERE CustomerID = @CustomerID"
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CustomerID", customerID)
                    Try
                        con.Open()
                        Dim result As Object = cmd.ExecuteScalar()
                        If result IsNot Nothing Then
                            TextBoxCustomerName.Text = result.ToString()
                        Else
                            TextBoxCustomerName.Text = "Customer not found"
                        End If
                    Catch ex As SqlException
                        MessageBox.Show("Error fetching customer: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBoxCustomerName.Text = ""
                    End Try
                End Using
            End Using
        Else
            TextBoxCustomerName.Text = ""
        End If
    End Sub

    ' Update Price and Total when Product or Quantity changes
    Private Sub ComboBoxProductName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBoxProductName.SelectedIndexChanged
        Dim selectedProduct As String = ComboBoxProductName.SelectedItem.ToString()
        Dim price As Decimal = productPrices(selectedProduct)
        TextBoxPrice.Text = price.ToString("N2", CultureInfo.CreateSpecificCulture("en-IN"))
        CalculateTotal()
    End Sub

    Private Sub TextBoxQuantity_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxQuantity.TextChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Dim quantity As Integer
        Dim price As Decimal
        If Integer.TryParse(TextBoxQuantity.Text, quantity) AndAlso Decimal.TryParse(TextBoxPrice.Text, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-IN"), price) Then
            Dim total As Decimal = quantity * price
            TextBoxTotal.Text = total.ToString("N2", CultureInfo.CreateSpecificCulture("en-IN"))
        Else
            TextBoxTotal.Text = "0.00"
        End If
    End Sub

    ' Add entry to DataGridView
    Private Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAdd.Click
        Dim customerID As String = TextBoxCustomerID.Text.Trim()
        Dim quantity As Integer
        If String.IsNullOrEmpty(customerID) Then
            MessageBox.Show("Please enter a Customer ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If TextBoxCustomerName.Text = "Customer not found" OrElse String.IsNullOrEmpty(TextBoxCustomerName.Text) Then
            MessageBox.Show("Invalid Customer ID. Please enter a valid ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrEmpty(TextBoxQuantity.Text) OrElse Not Integer.TryParse(TextBoxQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid positive quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataGridViewSales.Rows.Add(
            TextBoxSNo.Text,
            TextBoxProductID.Text,
            TextBoxCustomerID.Text,
            TextBoxCustomerName.Text,
            ComboBoxProductName.SelectedItem.ToString(),
            DateTimePickerSaleDate.Value.ToShortDateString(),
            TextBoxQuantity.Text,
            "₹" & TextBoxPrice.Text,
            "₹" & TextBoxTotal.Text
        )

        ' Reset form for next entry
        TextBoxCustomerID.Clear()
        TextBoxCustomerName.Clear()
        TextBoxQuantity.Clear()
        ComboBoxProductName.SelectedIndex = 0
        GenerateIDs()
    End Sub

    ' Save to database
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        If DataGridViewSales.Rows.Count = 0 Then
            MessageBox.Show("No sales details to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL Query to Insert Data
        Dim query As String = "INSERT INTO Sales (SNo, ProductID, CustomerID, CustomerName, ProductName, SaleDate, Quantity, Price, Total) " &
                              "VALUES (@SNo, @ProductID, @CustomerID, @CustomerName, @ProductName, @SaleDate, @Quantity, @Price, @Total)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    For Each row As DataGridViewRow In DataGridViewSales.Rows
                        If Not row.IsNewRow Then ' Skip the new row placeholder
                            Dim sNo As Integer = Convert.ToInt32(row.Cells("SNo").Value)
                            Dim productID As String = row.Cells("ProductID").Value.ToString()
                            Dim customerID As String = row.Cells("CustomerID").Value.ToString()
                            Dim customerName As String = row.Cells("CustomerName").Value.ToString()
                            Dim productName As String = row.Cells("ProductName").Value.ToString()
                            Dim saleDate As Date = Date.Parse(row.Cells("SaleDate").Value.ToString())
                            Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                            Dim priceStr As String = row.Cells("Price").Value.ToString().Replace("₹", "").Trim()
                            Dim totalStr As String = row.Cells("Total").Value.ToString().Replace("₹", "").Trim()
                            Dim price As Decimal = Decimal.Parse(priceStr, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-IN"))
                            Dim total As Decimal = Decimal.Parse(totalStr, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-IN"))

                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@SNo", sNo)
                            cmd.Parameters.AddWithValue("@ProductID", productID)
                            cmd.Parameters.AddWithValue("@CustomerID", customerID)
                            cmd.Parameters.AddWithValue("@CustomerName", customerName)
                            cmd.Parameters.AddWithValue("@ProductName", productName)
                            cmd.Parameters.AddWithValue("@SaleDate", saleDate)
                            cmd.Parameters.AddWithValue("@Quantity", quantity)
                            cmd.Parameters.AddWithValue("@Price", price)
                            cmd.Parameters.AddWithValue("@Total", total)

                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    MessageBox.Show("Sales details saved successfully to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridViewSales.Rows.Clear() ' Clear after saving
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