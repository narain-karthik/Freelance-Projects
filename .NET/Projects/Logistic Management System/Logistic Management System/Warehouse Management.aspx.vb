Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Partial Public Class WarehouseManagement
    Inherits System.Web.UI.Page

    ' Database connection helper
    Private Function GetConnection() As SqlConnection
        Return New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
    End Function

    ' Page Load Event - Load Data
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadStorageAssignments()
            LoadWorkflows()
            LoadResources()
        End If
    End Sub

    ' Load Storage Assignments from Database
    Private Sub LoadStorageAssignments()
        Using conn As SqlConnection = GetConnection()
            Dim query As String = "SELECT StorageID, Warehouse, Section, ItemName, Quantity FROM StorageAssignments"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Error fetching storage assignments: " & ex.Message)
            Finally
                conn.Close()
            End Try

            StorageGridView.DataSource = dt
            StorageGridView.DataBind()
        End Using
    End Sub

    ' Load Workflow Data from Database
    Private Sub LoadWorkflows()
        Using conn As SqlConnection = GetConnection()
            Dim query As String = "SELECT OrderID, CustomerName, PickStatus, PackStatus, ShipStatus FROM Workflows"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Error fetching workflow data: " & ex.Message)
            Finally
                conn.Close()
            End Try

            WorkflowGridView.DataSource = dt
            WorkflowGridView.DataBind()
        End Using
    End Sub

    ' Load Resource Data from Database
    Private Sub LoadResources()
        Using conn As SqlConnection = GetConnection()
            Dim query As String = "SELECT ResourceID, ResourceType, Name, Utilization FROM Resources"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Error fetching resource data: " & ex.Message)
            Finally
                conn.Close()
            End Try

            ResourceGridView.DataSource = dt
            ResourceGridView.DataBind()
        End Using
    End Sub

    ' Refresh Data Button Click Event
    Protected Sub RefreshButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        LoadStorageAssignments()
        LoadWorkflows()
        LoadResources()
        StatusLabel.Text = "Warehouse data refreshed successfully."
        StatusLabel.Visible = True
    End Sub

    ' Create New Storage Assignment
    Protected Sub btnCreateStorage_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Input Validation
        If String.IsNullOrEmpty(txtSection.Text) OrElse
           String.IsNullOrEmpty(txtItemName.Text) OrElse
           Not Integer.TryParse(txtQuantity.Text, Nothing) Then
            CreateStatusLabel.Text = "Please fill all fields correctly."
            CreateStatusLabel.ForeColor = Drawing.Color.Red
            CreateStatusLabel.Visible = True
            Return
        End If

        Using conn As SqlConnection = GetConnection()
            Dim query As String = "INSERT INTO StorageAssignments (Warehouse, Section, ItemName, Quantity) VALUES (@Warehouse, @Section, @ItemName, @Quantity)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Warehouse", ddlWarehouse.SelectedValue)
            cmd.Parameters.AddWithValue("@Section", txtSection.Text)
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
            cmd.Parameters.AddWithValue("@Quantity", CInt(txtQuantity.Text))

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                CreateStatusLabel.Text = "Storage assignment created successfully!"
                CreateStatusLabel.ForeColor = Drawing.Color.Green
                CreateStatusLabel.Visible = True
            Catch ex As Exception
                CreateStatusLabel.Text = "Error: " & ex.Message
                CreateStatusLabel.ForeColor = Drawing.Color.Red
                CreateStatusLabel.Visible = True
            Finally
                conn.Close()
            End Try
        End Using

        ' Reload the updated data
        LoadStorageAssignments()
    End Sub
End Class
