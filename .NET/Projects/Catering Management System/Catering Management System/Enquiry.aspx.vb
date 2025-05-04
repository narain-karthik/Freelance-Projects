Imports System.Data.SqlClient

Public Class Enquiry
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SubmitButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Catering;Integrated Security=True"

            ' Validate input before proceeding
            If String.IsNullOrWhiteSpace(NameTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(EmailIDTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(AddressTextBox.Text) Then
                ' Display a JavaScript alert for validation
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('All fields are required.');", True)
                Exit Sub
            End If

            ' Using block for connection
            Using con As New SqlConnection(connectionString)
                ' Define the SQL query with parameterized values
                Dim query As String = "INSERT INTO Enquiries (Name, Email, Phone, Address, Package, EventDate) VALUES (@Name, @Email, @Phone, @Address, @Package, @EventDate)"

                ' Create the command
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Name", NameTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", EmailIDTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", PhoneNumberTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Package", PackageDropDownList.SelectedValue)
                    cmd.Parameters.AddWithValue("@EventDate", DateTextBox.Text.Trim())

                    ' Open the connection and execute
                    con.Open()
                    cmd.ExecuteNonQuery()

                    ' Display a success message using JavaScript alert
                    ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Your enquiry has been submitted successfully!');", True)
                End Using
            End Using
        Catch ex As Exception
            ' Display error message using JavaScript alert
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('An error occurred: " & ex.Message.Replace("'", "\'") & "');", True)
        End Try
    End Sub
End Class