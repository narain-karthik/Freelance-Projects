Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class login
    Inherits System.Web.UI.Page

    ' Hashing function to compare the entered password with the stored hash
    Function HashPassword(ByVal plainPassword As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim byteValue As Byte() = Encoding.UTF8.GetBytes(plainPassword)
            Dim hashValue As Byte() = sha256.ComputeHash(byteValue)
            Return BitConverter.ToString(hashValue).Replace("-", "").ToLower() ' Convert hash to hex string
        End Using
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Code for Page Load (if any needed)
    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Dairy;Integrated Security=True"

            ' Validate input before proceeding
            If String.IsNullOrWhiteSpace(txtPhone.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
                ' Display a JavaScript alert for validation
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Phone and Password are required.');", True)
                Exit Sub
            End If

            ' Using block for connection
            Using con As New SqlConnection(connectionString)
                ' Define the SQL query to fetch the hashed password from the database
                Dim query As String = "SELECT Password FROM Users WHERE Phone = @Phone"

                ' Create the command
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())

                    ' Open the connection
                    con.Open()

                    ' Execute the query and retrieve the hashed password from the database
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        Dim storedHash As String = result.ToString()

                        ' Check if the entered password matches the stored hashed password
                        If HashPassword(txtPassword.Text.Trim()) = storedHash Then
                            ' Successful login - store user info in session
                            Session("UserPhone") = txtPhone.Text.Trim()

                            ' Redirect to a protected page (Dashboard)
                            Response.Redirect("Home.aspx")
                        Else
                            ' Invalid password
                            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Invalid password.');", True)
                        End If
                    Else
                        ' No user found with the given phone number
                        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Phone number not found.');", True)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Display error message using JavaScript alert
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('An error occurred: " & ex.Message.Replace("'", "\'") & "');", True)

            ' Optionally log the error details for debugging purposes
            System.Diagnostics.Debug.WriteLine("Error: " & ex.Message) ' Or use a logging framework
        End Try
    End Sub
End Class
