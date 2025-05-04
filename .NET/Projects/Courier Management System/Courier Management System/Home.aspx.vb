Imports System.Data.SqlClient

Public Class Home
    Inherits System.Web.UI.Page

    ' Database connection string
    Private ReadOnly connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Courier;Integrated Security=True"

    ' Function to fetch package details
    Private Function GetPackageDetails(ByVal AWBNo As String) As DataTable
        Dim query As String = "SELECT Status, Destination, CurrentLocation, EstimatedDeliveryDate FROM PackageTracking WHERE AWBNo = @AWBNo"
        Dim dt As New DataTable()

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@AWBNo", SqlDbType.VarChar, 50).Value = AWBNo

                    Using da As New SqlDataAdapter(cmd)
                        conn.Open()
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Log error (Consider logging instead of suppressing the error)
            dt = Nothing
        End Try

        Return dt
    End Function

    ' Event handler for the "Track" button click
    Protected Sub btnTrack_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Validate input
        If String.IsNullOrWhiteSpace(awb.Text) Then
            ShowPopup("Please enter an AWB number.")
            Return
        End If

        ' Get the AWB number
        Dim AWBNo As String = awb.Text.Trim()

        ' Fetch package details
        Dim dt As DataTable = GetPackageDetails(AWBNo)

        ' Display results in a popup message
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim status As String = dt.Rows(0)("Status").ToString()
            Dim destination As String = dt.Rows(0)("Destination").ToString()
            Dim currentLocation As String = dt.Rows(0)("CurrentLocation").ToString()
            Dim estimatedDelivery As String = Convert.ToDateTime(dt.Rows(0)("EstimatedDeliveryDate")).ToString("dd-MMM-yyyy")

            ' Corrected message formatting
            Dim message As String = "Status: " & status & "\nDestination: " & destination & "\nCurrent Location: " & currentLocation & "\nEstimated Delivery: " & estimatedDelivery
            ShowPopup(message)
        Else
            ShowPopup("Package not found.")
        End If
    End Sub

    ' Function to show a JavaScript alert (popup)
    Private Sub ShowPopup(ByVal message As String)
        Dim script As String = "alert('" & message.Replace("'", "\'") & "');"
        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "PopupMessage", script, True)
    End Sub

End Class
