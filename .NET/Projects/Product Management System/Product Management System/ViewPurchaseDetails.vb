Imports System.Data.SqlClient
Imports System.Globalization

Public Class ViewPurchaseDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=ProductManagement;Integrated Security=True"

    Private Sub ViewPurchaseDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Initialize DataGridView columns with INR symbol for Price and Total
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

        ' Load data initially
        LoadPurchaseData()
    End Sub

    ' Load purchase data from the database
    Private Sub LoadPurchaseData()
        DataGridViewPurchases.Rows.Clear() ' Clear existing rows

        Dim query As String = "SELECT SNo, ProductID, ProductName, PurchaseDate, Quantity, Price, Total FROM Purchases"
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DataGridViewPurchases.Rows.Add(
                                reader("SNo").ToString(),
                                reader("ProductID").ToString(),
                                reader("ProductName").ToString(),
                                Convert.ToDateTime(reader("PurchaseDate")).ToShortDateString(),
                                Convert.ToDecimal(reader("Quantity")).ToString("F2"),
                                "₹" & Convert.ToDecimal(reader("Price")).ToString("N2", CultureInfo.CreateSpecificCulture("en-IN")),
                                "₹" & Convert.ToDecimal(reader("Total")).ToString("N2", CultureInfo.CreateSpecificCulture("en-IN"))
                            )
                        End While
                    End Using
                Catch ex As SqlException
                    MessageBox.Show("Error fetching purchase data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Refresh button to reload data
    Private Sub ButtonRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadPurchaseData()
    End Sub
End Class