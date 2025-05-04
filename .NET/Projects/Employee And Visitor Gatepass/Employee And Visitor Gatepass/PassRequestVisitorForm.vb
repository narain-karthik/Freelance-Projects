Imports System.Data.SqlClient

Public Class PassRequestVisitorForm
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Gatepass;Integrated Security=True")

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query As String = "INSERT INTO PassRequestVisitor (VisitorName, VisitorContact, VisitorIDProof, PurposeOfVisit, VisitingPerson, Department, DestinationPlace, VisitDate, StartTime, EndTime, TransportMode, ApprovedBy, ApprovalStatus, Remarks) " &
                                  "VALUES (@VisitorName, @VisitorContact, @VisitorIDProof, @PurposeOfVisit, @VisitingPerson, @Department, @DestinationPlace, @VisitDate, @StartTime, @EndTime, @TransportMode, @ApprovedBy, @ApprovalStatus, @Remarks)"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@VisitorName", txtVisitorName.Text)
                cmd.Parameters.AddWithValue("@VisitorContact", txtVisitorContact.Text)
                cmd.Parameters.AddWithValue("@VisitorIDProof", txtVisitorIDProof.Text)
                cmd.Parameters.AddWithValue("@PurposeOfVisit", txtPurposeOfVisit.Text)
                cmd.Parameters.AddWithValue("@VisitingPerson", cmbVisitingPerson.Text)
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text)
                cmd.Parameters.AddWithValue("@DestinationPlace", txtDestinationPlace.Text)
                cmd.Parameters.AddWithValue("@VisitDate", dtpVisitDate.Value.Date)
                cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@TransportMode", cmbTransportMode.Text)
                cmd.Parameters.AddWithValue("@ApprovedBy", cmbApprovedBy.Text)
                cmd.Parameters.AddWithValue("@ApprovalStatus", txtApprovalStatus.Text)
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Visitor Pass Request Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

End Class