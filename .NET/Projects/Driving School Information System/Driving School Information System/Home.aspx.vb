Imports System.Data.SqlClient

Partial Class WebForm1
    Inherits System.Web.UI.Page

    ' Method to insert enquiry details into the database
    <System.Web.Services.WebMethod()>
    Public Shared Function InsertEnquiry(ByVal name As String, ByVal email As String, ByVal phone As String, ByVal dob As String, ByVal package As String) As String
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=DrivingSc;Integrated Security=True"

            ' Using block for connection
            Using con As New SqlConnection(connectionString)
                ' Define the SQL query
                Dim query As String = "INSERT INTO Enquiry (Name, Email, Phone, DOB, Package) VALUES (@Name, @Email, @Phone, @DOB, @Package)"

                ' Create the command
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Phone", phone)
                    cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(dob))
                    cmd.Parameters.AddWithValue("@Package", package)

                    ' Open the connection and execute
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return "Success"
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function
        
End Class
