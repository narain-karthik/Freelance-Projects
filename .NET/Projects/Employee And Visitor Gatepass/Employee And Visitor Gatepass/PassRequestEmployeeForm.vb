
Imports System.Data.SqlClient

Public Class PassRequestEmployeeForm
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Gatepass;Integrated Security=True"
    ' OR if you have SQL authentication use:
    ' Dim connectionString As String = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD"

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Using con As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO PassRequest (EmployeeName, EmployeeID, Department, Designation, ContactNumber, PurposeOfVisit, DestinationPlace, DateOfRequest, PassStartDate, PassEndDate, StartTime, EndTime, TransportMode, ApprovedBy, Remarks) " &
                      "VALUES (@EmployeeName, @EmployeeID, @Department, @Designation, @ContactNumber, @PurposeOfVisit, @DestinationPlace, @DateOfRequest, @PassStartDate, @PassEndDate, @StartTime, @EndTime, @TransportMode, @ApprovedBy, @Remarks)"

            Using cmd As New SqlCommand(query, con)
                ' Add parameters safely
                cmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text)
                cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text)
                cmd.Parameters.AddWithValue("@Designation", txtDesignation.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
                cmd.Parameters.AddWithValue("@PurposeOfVisit", txtPurposeOfVisit.Text)
                cmd.Parameters.AddWithValue("@DestinationPlace", txtDestinationPlace.Text)
                cmd.Parameters.AddWithValue("@DateOfRequest", dtpDateOfRequest.Value.Date)
                cmd.Parameters.AddWithValue("@PassStartDate", dtpPassStartDate.Value.Date)
                cmd.Parameters.AddWithValue("@PassEndDate", dtpPassEndDate.Value.Date)
                cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value.ToShortTimeString())
                cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value.ToShortTimeString())
                cmd.Parameters.AddWithValue("@TransportMode", cmbTransportMode.Text)
                cmd.Parameters.AddWithValue("@ApprovedBy", cmbApprovedBy.Text)
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Pass Request Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class