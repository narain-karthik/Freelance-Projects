Imports System.Data.SqlClient

Public Class Reservation
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Railway;Integrated Security=True"

    Private Sub BookTicketButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BookTicketButton.Click
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' SQL Query to Insert Data
                Dim query As String = "INSERT INTO Reservation (TrainNumber, TrainName, Source, Destination, TravelClass, ReservationDate, SeatNo, PassengerName, Age, Sex, SeniorCitizen, BookedBy, Status) VALUES (@TrainNumber, @TrainName, @Source, @Destination, @TravelClass, @ReservationDate, @SeatNo, @PassengerName, @Age, @Sex, @SeniorCitizen, 'Admin', 'Pending')"

                Using cmd As New SqlCommand(query, con)
                    ' Common Details for All Passengers
                    cmd.Parameters.AddWithValue("@TrainNumber", TrainNumberComboBox.Text)
                    cmd.Parameters.AddWithValue("@TrainName", TrainNameComboBox.Text)
                    cmd.Parameters.AddWithValue("@Source", FromComboBox.Text)
                    cmd.Parameters.AddWithValue("@Destination", ToComboBox.Text)
                    cmd.Parameters.AddWithValue("@TravelClass", ClassComboBox.Text)
                    cmd.Parameters.AddWithValue("@ReservationDate", ReservationDateTimePicker.Value.Date)

                    ' Insert up to 5 Passengers
                    InsertPassenger(cmd, SNo1ComboBox, Name1TextBox, Age1TextBox, Sex1ComboBox, SC1CheckBox)
                    InsertPassenger(cmd, SNo2ComboBox, Name2TextBox, Age2TextBox, Sex2ComboBox, SC2CheckBox)
                    InsertPassenger(cmd, SNo3ComboBox, Name3TextBox, Age3TextBox, Sex3ComboBox, SC3CheckBox)
                    InsertPassenger(cmd, SNo4ComboBox, Name4TextBox, Age4TextBox, Sex4ComboBox, SC4CheckBox)
                    InsertPassenger(cmd, SNo5ComboBox, Name5TextBox, Age5TextBox, Sex5ComboBox, SC5CheckBox)
                End Using
            End Using

            MessageBox.Show("Ticket(s) Booked Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to Insert a Passenger
    Private Sub InsertPassenger(ByVal cmd As SqlCommand, ByVal seatNo As ComboBox, ByVal name As TextBox, ByVal age As TextBox, ByVal sex As ComboBox, ByVal senior As CheckBox)
        If seatNo.Text <> "" And name.Text <> "" And age.Text <> "" And sex.Text <> "" Then
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@TrainNumber", TrainNumberComboBox.Text)
            cmd.Parameters.AddWithValue("@TrainName", TrainNameComboBox.Text)
            cmd.Parameters.AddWithValue("@Source", FromComboBox.Text)
            cmd.Parameters.AddWithValue("@Destination", ToComboBox.Text)
            cmd.Parameters.AddWithValue("@TravelClass", ClassComboBox.Text)
            cmd.Parameters.AddWithValue("@ReservationDate", ReservationDateTimePicker.Value.Date)
            cmd.Parameters.AddWithValue("@SeatNo", seatNo.Text)
            cmd.Parameters.AddWithValue("@PassengerName", name.Text)
            cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(age.Text))
            cmd.Parameters.AddWithValue("@Sex", sex.Text)
            cmd.Parameters.AddWithValue("@SeniorCitizen", If(senior.Checked, 1, 0))
            cmd.Parameters.AddWithValue("@BookedBy", "Admin")
            cmd.ExecuteNonQuery()
        End If
    End Sub

    ' Function to Clear Fields
    Private Sub ClearFields()
        TrainNumberComboBox.SelectedIndex = -1
        TrainNameComboBox.SelectedIndex = -1
        FromComboBox.SelectedIndex = -1
        ToComboBox.SelectedIndex = -1
        ClassComboBox.SelectedIndex = -1
        ReservationDateTimePicker.Value = DateTime.Now

        SNo1ComboBox.SelectedIndex = -1
        Name1TextBox.Clear()
        Age1TextBox.Clear()
        Sex1ComboBox.SelectedIndex = -1
        SC1CheckBox.Checked = False

        SNo2ComboBox.SelectedIndex = -1
        Name2TextBox.Clear()
        Age2TextBox.Clear()
        Sex2ComboBox.SelectedIndex = -1
        SC2CheckBox.Checked = False

        SNo3ComboBox.SelectedIndex = -1
        Name3TextBox.Clear()
        Age3TextBox.Clear()
        Sex3ComboBox.SelectedIndex = -1
        SC3CheckBox.Checked = False

        SNo4ComboBox.SelectedIndex = -1
        Name4TextBox.Clear()
        Age4TextBox.Clear()
        Sex4ComboBox.SelectedIndex = -1
        SC4CheckBox.Checked = False

        SNo5ComboBox.SelectedIndex = -1
        Name5TextBox.Clear()
        Age5TextBox.Clear()
        Sex5ComboBox.SelectedIndex = -1
        SC5CheckBox.Checked = False
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Try
            ' Reset Train Details
            TrainNumberComboBox.SelectedIndex = -1
            TrainNameComboBox.SelectedIndex = -1
            FromComboBox.SelectedIndex = -1
            ToComboBox.SelectedIndex = -1
            ClassComboBox.SelectedIndex = -1
            ReservationDateTimePicker.Value = DateTime.Now

            ' Reset Passenger Details
            SNo1ComboBox.SelectedIndex = -1
            Name1TextBox.Clear()
            Age1TextBox.Clear()
            Sex1ComboBox.SelectedIndex = -1
            SC1CheckBox.Checked = False

            SNo2ComboBox.SelectedIndex = -1
            Name2TextBox.Clear()
            Age2TextBox.Clear()
            Sex2ComboBox.SelectedIndex = -1
            SC2CheckBox.Checked = False

            SNo3ComboBox.SelectedIndex = -1
            Name3TextBox.Clear()
            Age3TextBox.Clear()
            Sex3ComboBox.SelectedIndex = -1
            SC3CheckBox.Checked = False

            SNo4ComboBox.SelectedIndex = -1
            Name4TextBox.Clear()
            Age4TextBox.Clear()
            Sex4ComboBox.SelectedIndex = -1
            SC4CheckBox.Checked = False

            SNo5ComboBox.SelectedIndex = -1
            Name5TextBox.Clear()
            Age5TextBox.Clear()
            Sex5ComboBox.SelectedIndex = -1
            SC5CheckBox.Checked = False

            MessageBox.Show("Form Cleared Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
