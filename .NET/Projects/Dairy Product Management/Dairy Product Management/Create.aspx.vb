Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Create
    Inherits System.Web.UI.Page

    ' Hash the password before storing it in the database
    Function HashPassword(ByVal plainPassword As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim byteValue As Byte() = Encoding.UTF8.GetBytes(plainPassword)
            Dim hashValue As Byte() = sha256.ComputeHash(byteValue)
            Return BitConverter.ToString(hashValue).Replace("-", "").ToLower() ' Convert hash to hex string
        End Using
    End Function

    Protected Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegister.Click
        Try
            ' 1. Validate Input (Important!)
            If String.IsNullOrWhiteSpace(txtName.Text) OrElse
               String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
               String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
               String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
               String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then

                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('All fields are required.');", True)
                Exit Sub ' Stop execution if validation fails
            End If

            ' 2. Check if passwords match
            If txtPassword.Text <> txtConfirmPassword.Text Then
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Passwords do not match.');", True)
                Exit Sub
            End If

            ' 3. Hash the password
            Dim password As String = HashPassword(txtPassword.Text)

            ' 4. Database Connection and Insertion:
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Dairy;Integrated Security=True"

            Using con As New SqlConnection(connectionString)
                ' Check if the email already exists
                Dim checkEmailQuery As String = "SELECT COUNT(*) FROM Users WHERE Email = @Email"
                Using cmdCheck As New SqlCommand(checkEmailQuery, con)
                    cmdCheck.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    con.Open()
                    Dim emailExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    If emailExists > 0 Then
                        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Email already exists.');", True)
                        Exit Sub ' Stop execution if email already exists
                    End If
                End Using

                ' Insert the new user
                Dim query As String = "INSERT INTO Users (Name, Phone, Email, Password) VALUES (@Name, @Phone, @Email, @Password)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Password", password) ' Storing hashed password

                    cmd.ExecuteNonQuery()

                    ' Success Message and Clear Fields:
                    ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Registration successful!');", True)

                    ' Clear the form fields:
                    txtName.Text = ""
                    txtPhone.Text = ""
                    txtEmail.Text = ""
                    txtPassword.Text = ""
                    txtConfirmPassword.Text = ""
                End Using
            End Using

        Catch ex As Exception
            ' Error Handling:
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('An error occurred: " & ex.Message.Replace("'", "\'") & "');", True)
            System.Diagnostics.Debug.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Class
