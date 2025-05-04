Imports System.Data.SqlClient

Public Class Book_Pickup
    Inherits System.Web.UI.Page

    Private Property Range As Object

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SubmitButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Courier;Integrated Security=True"

            ' Validate input before proceeding
            ' Validate input before proceeding
            If String.IsNullOrWhiteSpace(PincodeTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(EmailTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(FullNameTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(StateDropDown.SelectedValue) OrElse
               String.IsNullOrWhiteSpace(CountryDropDown.SelectedValue) Then
                ' Display a JavaScript alert for validation
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('All fields are required.');", True)
                Exit Sub
            End If

            ' Validate and convert the pickup date before adding it to the SQL parameters
            Dim pickupDate As DateTime
            If Not DateTime.TryParse(PickupDateTextBox.Text, pickupDate) Then
                ' Display a JavaScript alert if the date is invalid
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Please enter a valid date.');", True)
                Exit Sub
            End If

            ' Using block for connection
            Using con As New SqlConnection(connectionString)
                ' Define the SQL query
                Dim query As String = "INSERT INTO InternationalPickupRequests (Pincode, Country, ContentType, Weight, Amount, PickupDate, PickupTime, Email, FullName, Phone, DoorNo, AreaCity, State, AadharNumber) " & _
                                      "VALUES (@Pincode, @Country, @ContentType, @Weight, @Amount, @PickupDate, @PickupTime, @Email, @FullName, @Phone, @DoorNo, @AreaCity, @State, @AadharNumber)"

                ' Create the command
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters (ensure the values are taken from your form controls)
                    cmd.Parameters.AddWithValue("@Pincode", PincodeTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Country", CountryDropDown.SelectedValue)
                    cmd.Parameters.AddWithValue("@ContentType", If(DocumentRadioButton.Checked, "document", "parcel"))

                    ' Correct references to WeightRange and AmountDisplay
                    cmd.Parameters.AddWithValue("@Weight", WeightRange.Value) ' Value from range slider
                    cmd.Parameters.AddWithValue("@Amount", AmountDisplay.InnerText) ' Value from amount display

                    ' Add the correctly parsed date to the parameters
                    cmd.Parameters.AddWithValue("@PickupDate", pickupDate)
                    cmd.Parameters.AddWithValue("@PickupTime", PickupTimeDropDown.SelectedValue)
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@FullName", FullNameTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(PhoneTextBox.Text), DBNull.Value, PhoneTextBox.Text.Trim()))
                    cmd.Parameters.AddWithValue("@DoorNo", If(String.IsNullOrWhiteSpace(DoorNoTextBox.Text), DBNull.Value, DoorNoTextBox.Text.Trim()))
                    cmd.Parameters.AddWithValue("@AreaCity", AreaCityDropDown.SelectedValue) ' AreaCity dropdown selected value
                    cmd.Parameters.AddWithValue("@State", StateDropDown.SelectedValue)
                    cmd.Parameters.AddWithValue("@AadharNumber", If(String.IsNullOrWhiteSpace(AadharTextBox.Text), DBNull.Value, AadharTextBox.Text.Trim()))

                    ' Open the connection and execute
                    con.Open()
                    cmd.ExecuteNonQuery()

                    ' Display a success message using JavaScript alert
                    ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Your pickup request has been submitted successfully! Our Staff will call you soon....');", True)
                End Using
            End Using

        Catch ex As Exception
            ' Display error message using JavaScript alert
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('An error occurred: " & ex.Message.Replace("'", "\'") & "');", True)
        End Try



    End Sub
End Class