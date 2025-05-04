Imports System.Data.SqlClient
Imports System.Globalization

Public Class ViewSalesDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PaintingManagement;Integrated Security=True"

    Private Sub ViewSalesDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

        ' Load data initially
        LoadSalesData()
    End Sub

    ' Load sales data from the database
    Private Sub LoadSalesData()
        DataGridViewSales.Rows.Clear() ' Clear existing rows

        Dim query As String = "SELECT SNo, ProductID, CustomerID, CustomerName, ProductName, SaleDate, Quantity, Price, Total FROM Sales"
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DataGridViewSales.Rows.Add(
                                reader("SNo").ToString(),
                                reader("ProductID").ToString(),
                                reader("CustomerID").ToString(),
                                reader("CustomerName").ToString(),
                                reader("ProductName").ToString(),
                                Convert.ToDateTime(reader("SaleDate")).ToShortDateString(),
                                reader("Quantity").ToString(),
                                "₹" & Convert.ToDecimal(reader("Price")).ToString("N2", CultureInfo.CreateSpecificCulture("en-IN")),
                                "₹" & Convert.ToDecimal(reader("Total")).ToString("N2", CultureInfo.CreateSpecificCulture("en-IN"))
                            )
                        End While
                    End Using
                Catch ex As SqlException
                    MessageBox.Show("Error fetching sales data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Refresh button to reload data
    Private Sub ButtonRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadSalesData()
    End Sub
End Class