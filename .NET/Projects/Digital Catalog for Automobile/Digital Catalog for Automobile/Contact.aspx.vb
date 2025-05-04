Imports System.Data.SqlClient
Partial Class Contact
    Inherits System.Web.UI.Page

    ' This method will be triggered when the Submit button is clicked
    Protected Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            ' Define the connection string (replace with your actual connection string)
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Digital;Integrated Security=True"

            ' Validate input before proceeding
            If String.IsNullOrWhiteSpace(txtName.Text) OrElse
               String.IsNullOrWhiteSpace(txtContact.Text) OrElse
               String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
               String.IsNullOrWhiteSpace(txtCity.Text) OrElse
               String.IsNullOrWhiteSpace(ddlSubject.SelectedValue) OrElse
               String.IsNullOrWhiteSpace(txtMessage.Text) Then
                ' Display a JavaScript alert for validation
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('All fields are required.');", True)
                Exit Sub
            End If

            ' Using block for connection
            Using con As New SqlConnection(connectionString)
                ' Define the SQL query
                Dim query As String = "INSERT INTO Contact (Name, Contact, Email, City, Subject, Message) VALUES (@Name, @Contact, @Email, @City, @Subject, @Message)"

                ' Create the command
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters to the SQL command
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim())
                    cmd.Parameters.AddWithValue("@Subject", ddlSubject.SelectedValue.Trim()) ' Dropdown value
                    cmd.Parameters.AddWithValue("@Message", txtMessage.Text.Trim())

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
