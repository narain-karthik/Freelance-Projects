Imports System.Data
Imports System.Data.SqlClient

Public Class Attendance
    Inherits System.Web.UI.Page

    Private ReadOnly connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=AttendanceWebsite;Integrated Security=True"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not User.Identity.IsAuthenticated Then
                Response.Redirect("~/Login.aspx")
            End If
            gvEmployees.Visible = False
        End If
    End Sub

    Protected Sub ddlShift_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If ddlShift.SelectedValue <> "" Then
            LoadEmployeesByShift(ddlShift.SelectedValue)
            gvEmployees.Visible = True
            lblMessage.Visible = False
        Else
            gvEmployees.Visible = False
            lblMessage.Visible = False
        End If
    End Sub

    Private Sub LoadEmployeesByShift(ByVal shift As String)
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT EmployeeID, Name, Shift FROM Employees WHERE Shift = @Shift"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Shift", shift)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    gvEmployees.DataSource = dt
                    gvEmployees.DataBind()
                End Using
            Catch ex As Exception
                lblMessage.Text = "Error loading employees: " & ex.Message
                lblMessage.CssClass = "error-message"
                lblMessage.Visible = True
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Protected Sub btnMarkAttendance_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim args As String() = btn.CommandArgument.Split(","c)
        Dim employeeID As String = args(0)
        Dim employeeName As String = args(1)
        Dim row As GridViewRow = DirectCast(btn.NamingContainer, GridViewRow)
        Dim ddlStatus As DropDownList = DirectCast(row.FindControl("ddlStatus"), DropDownList)
        Dim status As String = ddlStatus.SelectedValue

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO AttendanceRecords (EmployeeID, EmployeeName, AttendanceStatus, AttendanceDateTime, Shift) " &
                                    "VALUES (@EmployeeID, @EmployeeName, @AttendanceStatus, @AttendanceDateTime, @Shift)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                    cmd.Parameters.AddWithValue("@EmployeeName", employeeName)
                    cmd.Parameters.AddWithValue("@AttendanceStatus", status)
                    cmd.Parameters.AddWithValue("@AttendanceDateTime", DateTime.Now)
                    cmd.Parameters.AddWithValue("@Shift", ddlShift.SelectedValue)
                    cmd.ExecuteNonQuery()
                End Using

                Dim currentTime As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                lblMessage.Text = "Attendance marked for " & employeeName & " (ID: " & employeeID & ") as " & status & " at " & currentTime
                lblMessage.CssClass = "success-message"
                lblMessage.Visible = True

                LoadEmployeesByShift(ddlShift.SelectedValue)

            Catch ex As Exception
                lblMessage.Text = "Error marking attendance: " & ex.Message
                lblMessage.CssClass = "error-message"
                lblMessage.Visible = True
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Class