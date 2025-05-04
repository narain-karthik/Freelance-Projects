Imports System.Data.SqlClient

Public Class ViewStockDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PaintingManagement;Integrated Security=True"

    Private Sub ViewStockDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

        ' Load data initially
        LoadStockData()
    End Sub

    ' Load stock data from the database
    Private Sub LoadStockData()
        DataGridViewStock.Rows.Clear() ' Clear existing rows

        Dim query As String = "SELECT SNo, ProductID, ProductName, StockIn, StockOut, Balance FROM Stock"
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DataGridViewStock.Rows.Add(
                                reader("SNo").ToString(),
                                reader("ProductID").ToString(),
                                reader("ProductName").ToString(),
                                reader("StockIn").ToString(),
                                reader("StockOut").ToString(),
                                reader("Balance").ToString()
                            )
                        End While
                    End Using
                Catch ex As SqlException
                    MessageBox.Show("Error fetching stock data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Refresh button to reload data
    Private Sub ButtonRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadStockData()
    End Sub
End Class