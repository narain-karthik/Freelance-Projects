Imports System.Data.SqlClient
Imports System.Globalization

Public Class PurchaseDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=ProductManagement;Integrated Security=True"

    ' Product list and prices
    Private ReadOnly productPrices As New Dictionary(Of String, Decimal) From {
        {"Electrical Motor Stamping", 105D},
        {"Monoblock Pump Stampings", 105D},
        {"1071 Electrical Stamping", 110D},
        {"Single Phase Electrical Motor Stampings", 105D},
        {"4 Hp Electrical Motor Stampings", 105D},
        {"Crno Lamination Stamping", 140D},
        {"Mild Steel Electrical Stamping", 105D},
        {"5 Hp Single Phase Electrical Stamping", 105D},
        {"Monoblock Electro Stamping", 105D}
    }

    Private Sub PurchaseDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with product names
        ComboBoxProductName.Items.AddRange(productPrices.Keys.ToArray())
        ComboBoxProductName.SelectedIndex = 0 ' Select first item by default

        ' Initialize DataGridView columns
        With DataGridViewPurchases.Columns
            .Add("SNo", "S.No")
            .Add("ProductID", "Product ID")
            .Add("ProductName", "Product Name")
            .Add("PurchaseDate", "Purchase Date")
            .Add("Quantity", "Quantity (Kg)")
            .Add("Price", "Price (₹/Kg)")
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
        Dim quantity As Decimal
        Dim price As Decimal
        If Decimal.TryParse(TextBoxQuantity.Text, quantity) AndAlso Decimal.TryParse(TextBoxPrice.Text, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-IN"), price) AndAlso quantity >= 0 Then
            Dim total As Decimal = quantity * price
            TextBoxTotal.Text = total.ToString("N2", CultureInfo.CreateSpecificCulture("en-IN"))
        Else
            TextBoxTotal.Text = "0.00"
        End If
    End Sub

    ' Add entry to DataGridView
    Private Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAdd.Click
        Dim quantity As Decimal
        If String.IsNullOrEmpty(TextBoxQuantity.Text) OrElse Not Decimal.TryParse(TextBoxQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid positive quantity in Kg.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        TextBoxQuantity.Clear()
        ComboBoxProductName.SelectedIndex = 0
        GenerateIDs()
    End Sub

    ' Save to database
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        If DataGridViewPurchases.Rows.Count = 0 Then
            MessageBox.Show("No purchase details to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO Purchases (SNo, ProductID, ProductName, PurchaseDate, Quantity, Price, Total) " &
                              "VALUES (@SNo, @ProductID, @ProductName, @PurchaseDate, @Quantity, @Price, @Total)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    For Each row As DataGridViewRow In DataGridViewPurchases.Rows
                        If Not row.IsNewRow Then
                            Dim sNo As Integer = Convert.ToInt32(row.Cells("SNo").Value)
                            Dim productID As String = row.Cells("ProductID").Value.ToString()
                            Dim productName As String = row.Cells("ProductName").Value.ToString()
                            Dim purchaseDate As Date = Date.Parse(row.Cells("PurchaseDate").Value.ToString())
                            Dim quantity As Decimal = Convert.ToDecimal(row.Cells("Quantity").Value)
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
                    MessageBox.Show("Purchase details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridViewPurchases.Rows.Clear()
                    GenerateIDs()
                Catch ex As SqlException
                    MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class