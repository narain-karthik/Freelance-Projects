Imports System.Data.SqlClient

Public Class Booking
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Database connection string (Change as needed)
        Dim conn As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Dental;Integrated Security=True"
        Using connection As New SqlConnection(conn)
            Dim query As String = "INSERT INTO Appointments (FullName, DOB, Address, State, Email, Mobile, PreferredDateTime, Reason, Problem) VALUES (@FullName, @DOB, @Address, @State, @Email, @Mobile, @PreferredDateTime, @Reason, @Problem)"
            Using cmd As New SqlCommand(query, connection)
                ' Get the input data
                cmd.Parameters.AddWithValue("@FullName", full_name.Text)
                cmd.Parameters.AddWithValue("@DOB", dob.Text)
                cmd.Parameters.AddWithValue("@Address", address.Text)
                cmd.Parameters.AddWithValue("@State", state.SelectedValue)
                cmd.Parameters.AddWithValue("@Email", email.Text)
                cmd.Parameters.AddWithValue("@Mobile", mobile.Text)

                ' Ensure PreferredDateTime is converted to DateTime
                Dim preferredDateTime As DateTime
                If DateTime.TryParse(preferred_datetime.Text, preferredDateTime) Then
                    cmd.Parameters.AddWithValue("@PreferredDateTime", preferredDateTime)
                Else
                    ' Handle invalid date format if necessary
                    ' For example, show an error message or set it to a default value
                    cmd.Parameters.AddWithValue("@PreferredDateTime", DBNull.Value)
                End If

                cmd.Parameters.AddWithValue("@Reason", String.Join(",", reason.Items.Cast(Of ListItem)().Where(Function(i) i.Selected).Select(Function(i) i.Value)))
                cmd.Parameters.AddWithValue("@Problem", nature_of_problem.Text)

                connection.Open()
                cmd.ExecuteNonQuery()

                ' Display a success message using JavaScript alert
                ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Your Booking has been submitted successfully!');", True)
            End Using
        End Using
    End Sub
End Class
