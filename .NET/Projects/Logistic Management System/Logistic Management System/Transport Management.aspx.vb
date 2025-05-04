Imports System.Data.SqlClient

Public Class TransportManagement
    Inherits System.Web.UI.Page

    Public Function GetData(ByVal query As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
            Using cmd As New SqlCommand(query, con)
                Using sda As New SqlDataAdapter(cmd)
                    sda.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Sub LoadRoutes()
        Dim dt As DataTable = GetData("SELECT * FROM DeliveryRoutes")
        RouteGridView.DataSource = dt
        RouteGridView.DataBind()
    End Sub

    Private Sub LoadShipments()
        Dim dt As DataTable = GetData("SELECT * FROM Shipments")
        ShipmentGridView.DataSource = dt
        ShipmentGridView.DataBind()
    End Sub

    Private Sub LoadResources()
        Dim dt As DataTable = GetData("SELECT * FROM Resources")
        ResourceGridView.DataSource = dt
        ResourceGridView.DataBind()
    End Sub

    Protected Sub btnCreateRoute_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
            Dim query As String = "INSERT INTO DeliveryRoutes (Origin, Destination, Distance, EstimatedTime) VALUES (@Origin, @Destination, @Distance, @EstimatedTime)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Origin", txtOrigin.Text)
                cmd.Parameters.AddWithValue("@Destination", txtDestination.Text)
                cmd.Parameters.AddWithValue("@Distance", Convert.ToDouble(txtDistance.Text))
                cmd.Parameters.AddWithValue("@EstimatedTime", Convert.ToDouble(txtEstimatedTime.Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        LoadRoutes()
        RouteStatusLabel.Text = "Route added successfully!"
        RouteStatusLabel.Visible = True
    End Sub

    Protected Sub btnCreateShipment_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
            Dim query As String = "INSERT INTO Shipments (VehicleID, CurrentLocation, Status, LastUpdated) VALUES (@VehicleID, @CurrentLocation, @Status, @LastUpdated)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@VehicleID", ddlVehicle.SelectedValue)
                cmd.Parameters.AddWithValue("@CurrentLocation", txtCurrentLocation.Text)
                cmd.Parameters.AddWithValue("@Status", ddlShipmentStatus.SelectedValue)
                cmd.Parameters.AddWithValue("@LastUpdated", DateTime.Now)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        LoadShipments()
        ShipmentStatusLabel.Text = "Shipment added successfully!"
        ShipmentStatusLabel.Visible = True
    End Sub

    Protected Sub btnCreateResource_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString)
            Dim query As String = "INSERT INTO Resources (VehicleID, DriverName, Schedule, FuelCost) VALUES (@VehicleID, @DriverName, @Schedule, @FuelCost)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@VehicleID", txtVehicleID.Text)
                cmd.Parameters.AddWithValue("@DriverName", txtDriverName.Text)
                cmd.Parameters.AddWithValue("@Schedule", txtSchedule.Text)
                cmd.Parameters.AddWithValue("@FuelCost", Convert.ToDecimal(txtFuelCost.Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        LoadResources()
        ResourceStatusLabel.Text = "Resource added successfully!"
        ResourceStatusLabel.Visible = True
    End Sub
    Protected Sub RefreshButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Refresh the data here
        LoadRoutes()
        LoadShipments()
        LoadResources()

        ' Provide user feedback
        StatusLabel.Text = "Data refreshed successfully!"
        StatusLabel.Visible = True
    End Sub

End Class
