Imports System.Data.SqlClient
Imports System.Globalization

Public Class PurchaseDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PaintingManagement;Integrated Security=True"

    ' Dictionary to store product names and their prices in INR
    Private ReadOnly productPrices As New Dictionary(Of String, Decimal) From {
        {"Acrylic Paint (500ml)", 250D}, {"Oil Paint (200ml)", 350D}, {"Watercolor Paint (12 shades)", 200D},
        {"Paint Brush Set (6 pieces)", 150D}, {"Roller Brush (9 inch)", 120D}, {"Paint Thinner (1L)", 300D},
        {"Primer (1L)", 400D}, {"Varnish (500ml)", 450D}, {"Spray Paint (400ml)", 280D},
        {"Paint Can (1L)", 600D}, {"Paint Can (4L)", 2200D}, {"Drop Cloth (12x12 ft)", 180D},
        {"Painter's Tape (1 inch)", 100D}, {"Sandpaper (pack of 5)", 80D}, {"Paint Tray", 90D},
        {"Latex Gloves (pack of 10)", 50D}, {"Paint Scraper", 110D}
    }

    Private Sub PurchaseDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with product names
        ComboBoxProductName.Items.AddRange(productPrices.Keys.ToArray())
        ComboBoxProductName.SelectedIndex = 0 ' Select first item by default

        ' Initialize DataGridView columns with INR symbol
        With DataGridViewPurchases.Columns
            .Add("SNo", "S.No")
            .Add("ProductID", "Product ID")
            .Add("ProductName", "Product Name")
            .Add("PurchaseDate", "Purchase Date")
            .Add("Quantity", "Quantity")
            .Add("Price", "Price (₹)")
            .Add("Total", "Total (₹)")
        End With
        DataGridViewPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Generate initial IDs
        GenerateIDs()
    End Sub

    ' Auto-generate S.No and Product ID
    Private Sub GenerateIDs()
        Dim rowCount As Integer = DataGridViewPurchases.Rows.Count + 1
        TextBoxSNo.Text = rowCount.ToString()
        TextBoxProductID.Text = "P" & Now.Ticks Mod 10000 ' Simple unique ID
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
        If String.IsNullOrEmpty(TextBoxQuantity.Text) OrElse Not Integer.TryParse(TextBoxQuantity.Text, Nothing) OrElse CInt(TextBoxQuantity.Text) <= 0 Then
            MessageBox.Show("Please enter a valid positive quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataGridViewPurchases.Rows.Add(
            TextBoxSNo.Text,
            TextBoxProductID.Text,
            ComboBoxProductName.SelectedItem.ToString(),
            DateTimePickerPurchaseDate.Value.ToShortDateString(),
            TextBoxQuantity.Text,
            "₹" & TextBoxPrice.Text,
            "₹" & TextBoxTotal.Text
        )

        ' Reset form for next entry
        GenerateIDs()
        TextBoxQuantity.Clear()
        ComboBoxProductName.SelectedIndex = 0
    End Sub

    ' Save to database
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        If DataGridViewPurchases.Rows.Count = 0 Then
            MessageBox.Show("No purchase details to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL Query to Insert Data
        Dim query As String = "INSERT INTO Purchases (SNo, ProductID, ProductName, PurchaseDate, Quantity, Price, Total) " &
                              "VALUES (@SNo, @ProductID, @ProductName, @PurchaseDate, @Quantity, @Price, @Total)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    For Each row As DataGridViewRow In DataGridViewPurchases.Rows
                        If Not row.IsNewRow Then ' Skip the new row placeholder
                            Dim sNo As Integer = Convert.ToInt32(row.Cells("SNo").Value)
                            Dim productID As String = row.Cells("ProductID").Value.ToString()
                            Dim productName As String = row.Cells("ProductName").Value.ToString()
                            Dim purchaseDate As Date = Date.Parse(row.Cells("PurchaseDate").Value.ToString())
                            Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                            Dim priceStr As String = row.Cells("Price").Value.ToString().Replace("₹", "").Trim()
                            Dim totalStr As String = row.Cells("Total").Value.ToString().Replace("₹", "").Trim()
                            Dim price As Decimal = Decimal.Parse(priceStr, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-IN"))
                            Dim total As Decimal = Decimal.Parse(totalStr, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-IN"))

                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@SNo", sNo)
                            cmd.Parameters.AddWithValue("@ProductID", productID)
                            cmd.Parameters.AddWithValue("@ProductName", productName)
                            cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate)
                            cmd.Parameters.AddWithValue("@Quantity", quantity)
                            cmd.Parameters.AddWithValue("@Price", price)
                            cmd.Parameters.AddWithValue("@Total", total)

                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    MessageBox.Show("Purchase details saved successfully to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridViewPurchases.Rows.Clear() ' Clear after saving
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