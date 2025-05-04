Imports System.Data
Imports System.Data.SqlClient

Public Class AddEmployee
    Inherits System.Web.UI.Page

    Private ReadOnly connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=AttendanceWebsite;Integrated Security=True"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not User.Identity.IsAuthenticated Then
                Response.Redirect("~/Login.aspx")
            End If
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using connection As New SqlConnection(connectionString)
            Try
                ' Basic validation
                If String.IsNullOrEmpty(txtName.Text) Then
                    lblMessage.Text = "Please enter employee name"
                    lblMessage.CssClass = "error-message"
                    lblMessage.Visible = True
                    Return
                End If

                If String.IsNullOrEmpty(txtEmployeeID.Text) Then
                    lblMessage.Text = "Please enter employee ID"
                    lblMessage.CssClass = "error-message"
                    lblMessage.Visible = True
                    Return
                End If

                If ddlShift.SelectedValue = "" Then
                    lblMessage.Text = "Please select a shift"
                    lblMessage.CssClass = "error-message"
                    lblMessage.Visible = True
                    Return
                End If

                connection.Open()

                ' Check if employee ID already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Employees WHERE EmployeeID = @EmployeeID"
                Using checkCmd As New SqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        lblMessage.Text = "Employee ID already exists"
                        lblMessage.CssClass = "error-message"
                        lblMessage.Visible = True
                        Return
                    End If
                End Using

                ' Insert new employee
                Dim query As String = "INSERT INTO Employees (Name, EmployeeID, DateOfBirth, Address, PhoneNumber, PANCardNumber, DateOfJoining, Shift) " &
                                    "VALUES (@Name, @EmployeeID, @DateOfBirth, @Address, @PhoneNumber, @PANCardNumber, @DateOfJoining, @Shift)"

                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text)
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
                    cmd.Parameters.AddWithValue("@DateOfBirth", If(String.IsNullOrEmpty(txtDOB.Text), DBNull.Value, DateTime.Parse(txtDOB.Text)))
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@PANCardNumber", txtPAN.Text)
                    cmd.Parameters.AddWithValue("@DateOfJoining", If(String.IsNullOrEmpty(txtJoiningDate.Text), DBNull.Value, DateTime.Parse(txtJoiningDate.Text)))
                    cmd.Parameters.AddWithValue("@Shift", ddlShift.SelectedValue)

                    cmd.ExecuteNonQuery()
                End Using

                ' Show success message and clear form
                lblMessage.Text = "Employee {txtName.Text} (ID: {txtEmployeeID.Text}) added successfully!"
                lblMessage.CssClass = "success-message"
                lblMessage.Visible = True

                ' Clear form
                txtName.Text = ""
                txtEmployeeID.Text = ""
                txtDOB.Text = ""
                txtAddress.Text = ""
                txtPhone.Text = ""
                txtPAN.Text = ""
                txtJoiningDate.Text = ""
                ddlShift.SelectedIndex = 0

            Catch ex As SqlException
                lblMessage.Text = "Database error: " & ex.Message
                lblMessage.CssClass = "error-message"
                lblMessage.Visible = True
            Catch ex As Exception
                lblMessage.Text = "Error adding employee: " & ex.Message
                lblMessage.CssClass = "error-message"
                lblMessage.Visible = True
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Class