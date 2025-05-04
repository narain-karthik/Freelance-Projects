Imports System.Data.SqlClient

Public Class VisitorDetailsForm

    ' Update your connection string as needed
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Gatepass;Integrated Security=True"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Validate inputs
        If txtVisitorName.Text = "" Or cmbGender.Text = "" Or txtContactNumber.Text = "" Then
            MessageBox.Show("Please fill all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert visitor details into the database
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "INSERT INTO VisitorDetails (VisitorName, Gender, ContactNumber, Email, Address, PurposeOfVisit, PersonToMeet, VisitDate, VisitTime, ExitTime, IDProofType, IDProofNumber) " &
                      "VALUES (@VisitorName, @Gender, @ContactNumber, @Email, @Address, @PurposeOfVisit, @PersonToMeet, @VisitDate, @VisitTime, @ExitTime, @IDProofType, @IDProofNumber)"


                Using cmd As New SqlCommand(query, con)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@VisitorName", txtVisitorName.Text)
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@PurposeOfVisit", txtPurposeOfVisit.Text)
                    cmd.Parameters.AddWithValue("@PersonToMeet", txtPersonToMeet.Text)
                    cmd.Parameters.AddWithValue("@VisitDate", dtpVisitDate.Value.Date)
                    cmd.Parameters.AddWithValue("@VisitTime", dtpVisitTime.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@ExitTime", dtpExitTime.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@IDProofType", cmbIDProofType.Text)
                    cmd.Parameters.AddWithValue("@IDProofNumber", txtIDProofNumber.Text)

                    ' Execute the query
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Visitor details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while saving visitor details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Optional: Clear all input fields after saving
    Private Sub ClearForm()
        txtVisitorName.Clear()
        cmbGender.SelectedIndex = -1
        txtContactNumber.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtPurposeOfVisit.Clear()
        txtPersonToMeet.Clear()
        dtpVisitDate.Value = DateTime.Now
        dtpVisitTime.Value = DateTime.Now
        dtpExitTime.Value = DateTime.Now
        cmbIDProofType.SelectedIndex = -1
        txtIDProofNumber.Clear()
    End Sub

End Class
