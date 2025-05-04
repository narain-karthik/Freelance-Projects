Imports System.Data.SqlClient

Public Class Contact
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SubmitButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Dairy;Integrated Security=True"

            ' Validate input before proceeding
            If String.IsNullOrWhiteSpace(NameTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(PhoneTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(EmailTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(MessageTextBox.Text) Then
                ' Display a JavaScript alert for validation
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('All fields are required.');", True)
                Exit Sub
            End If

            ' Using block for connection
            Using con As New SqlConnection(connectionString)
                ' Define the SQL query
                Dim query As String = "INSERT INTO Contact (Name,  Phone, Email, Message) VALUES (@Name, @Phone, @Email, @Message)"

                ' Create the command
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@Name", NameTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", PhoneTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Message", MessageTextBox.Text.Trim())

                    ' Open the connection and execute
                    con.Open()
                    cmd.ExecuteNonQuery()

                    ' Display a success message using JavaScript alert
                    ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Your message has been sent successfully!');", True)
                End Using
            End Using
        Catch ex As Exception
            ' Display error message using JavaScript alert
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('An error occurred: " & ex.Message.Replace("'", "\'") & "');", True)
        End Try
    End Sub
End Class