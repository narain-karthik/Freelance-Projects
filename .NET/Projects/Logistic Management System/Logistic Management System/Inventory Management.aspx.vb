Imports System.Data.SqlClient
Imports System.Configuration

Partial Public Class InventoryManagement
    Inherits System.Web.UI.Page

    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadInventory()
            CalculateTurnover()
        End If
    End Sub

    ' Load inventory data from the database
    Private Sub LoadInventory()
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT * FROM Inventory", con)
                Using da As New SqlDataAdapter(cmd)
                    con.Open()
                    da.Fill(dt)
                End Using
            End Using
        End Using
        InventoryGridView.DataSource = dt
        InventoryGridView.DataBind()
    End Sub

    ' Determine stock status based on reorder point
    Protected Function GetStatus(ByVal stockLevel As Object, ByVal reorderPoint As Object) As String
        Dim stock As Integer = If(IsDBNull(stockLevel), 0, Convert.ToInt32(stockLevel))
        Dim reorder As Integer = If(IsDBNull(reorderPoint), 0, Convert.ToInt32(reorderPoint))
        Return If(stock <= reorder, "Low - Reorder Now", "In Stock")
    End Function

    ' Calculate average stock level (handling DBNull values)
    Private Sub CalculateTurnover()
        Dim totalStock As Integer = 0
        Dim itemCount As Integer = 0

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT COUNT(*) AS ItemCount, SUM(StockLevel) AS TotalStock FROM Inventory", con)
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        itemCount = If(Convert.IsDBNull(reader("ItemCount")), 0, Convert.ToInt32(reader("ItemCount")))
                        totalStock = If(Convert.IsDBNull(reader("TotalStock")), 0, Convert.ToInt32(reader("TotalStock")))
                    End If
                End Using
            End Using
        End Using

        Dim avgStock As Double = If(itemCount > 0, totalStock / itemCount, 0)
        lblTurnover.Text = "Average Stock Level: " & avgStock.ToString("F2") & " units per item."
    End Sub

    ' Refresh inventory data
    Protected Sub RefreshButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        LoadInventory()
        CalculateTurnover()
        StatusLabel.Text = "Inventory refreshed successfully."
        StatusLabel.Visible = True
    End Sub

    ' Create new inventory item
    Protected Sub btnCreateInventory_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Basic validation
        If String.IsNullOrEmpty(txtItemName.Text) Then
            ShowMessage(CreateStatusLabel, "Please enter an item name.", Drawing.Color.Red)
            Return
        End If
        If Not Integer.TryParse(txtStockLevel.Text, Nothing) OrElse CInt(txtStockLevel.Text) < 0 Then
            ShowMessage(CreateStatusLabel, "Please enter a valid stock level (0 or greater).", Drawing.Color.Red)
            Return
        End If
        If Not Integer.TryParse(txtReorderPoint.Text, Nothing) OrElse CInt(txtReorderPoint.Text) < 0 Then
            ShowMessage(CreateStatusLabel, "Please enter a valid reorder point (0 or greater).", Drawing.Color.Red)
            Return
        End If

        ' Insert into the database
        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("INSERT INTO Inventory (ItemName, Location, StockLevel, ReorderPoint) VALUES (@ItemName, @Location, @StockLevel, @ReorderPoint)", con)
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
                    cmd.Parameters.AddWithValue("@Location", ddlLocation.SelectedValue)
                    cmd.Parameters.AddWithValue("@StockLevel", CInt(txtStockLevel.Text))
                    cmd.Parameters.AddWithValue("@ReorderPoint", CInt(txtReorderPoint.Text))
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Refresh inventory
            LoadInventory()
            CalculateTurnover()

            ' Clear form and show success message
            txtItemName.Text = ""
            ddlLocation.SelectedIndex = 0
            txtStockLevel.Text = ""
            txtReorderPoint.Text = ""
            ShowMessage(CreateStatusLabel, "Inventory item created successfully!", Drawing.Color.Green)

        Catch ex As Exception
            ShowMessage(CreateStatusLabel, "Error: " & ex.Message, Drawing.Color.Red)
        End Try
    End Sub

    ' Helper method to display messages
    Private Sub ShowMessage(ByVal label As Label, ByVal message As String, ByVal color As Drawing.Color)
        label.Text = message
        label.ForeColor = color
        label.Visible = True
    End Sub

End Class
