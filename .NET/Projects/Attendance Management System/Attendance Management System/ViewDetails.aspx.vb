Imports System.Data
Imports System.Data.SqlClient

Public Class ViewDetails
    Inherits System.Web.UI.Page

    Private ReadOnly connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=AttendanceWebsite;Integrated Security=True"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not User.Identity.IsAuthenticated Then
                Response.Redirect("~/Login.aspx")
            End If
            gvDetails.Visible = False
        End If
    End Sub

    Protected Sub ddlView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        gvDetails.Columns.Clear() ' Clear existing columns
        If ddlView.SelectedValue <> "" Then
            If ddlView.SelectedValue = "Employees" Then
                LoadEmployeeDetails()
            ElseIf ddlView.SelectedValue = "Attendance" Then
                LoadAttendanceDetails()
            End If
            gvDetails.Visible = True
            lblMessage.Visible = False
        Else
            gvDetails.Visible = False
            lblMessage.Visible = False
        End If
    End Sub

    Private Sub LoadEmployeeDetails()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT EmployeeID, Name, DateOfBirth, Address, PhoneNumber, PANCardNumber, DateOfJoining, Shift FROM Employees"
                Using cmd As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Define columns dynamically
                    Dim bfEmployeeID As New BoundField()
                    bfEmployeeID.DataField = "EmployeeID"
                    bfEmployeeID.HeaderText = "Employee ID"
                    gvDetails.Columns.Add(bfEmployeeID)

                    gvDetails.Columns.Add(New TemplateField() With {
                        .HeaderText = "Name",
                        .ItemTemplate = New GridViewTemplate("Name", "highlight")
                    })

                    Dim bfDOB As New BoundField()
                    bfDOB.DataField = "DateOfBirth"
                    bfDOB.HeaderText = "Date of Birth"
                    bfDOB.DataFormatString = "{0:dd/MM/yyyy}"
                    gvDetails.Columns.Add(bfDOB)

                    Dim bfAddress As New BoundField()
                    bfAddress.DataField = "Address"
                    bfAddress.HeaderText = "Address"
                    gvDetails.Columns.Add(bfAddress)

                    Dim bfPhone As New BoundField()
                    bfPhone.DataField = "PhoneNumber"
                    bfPhone.HeaderText = "Phone Number"
                    gvDetails.Columns.Add(bfPhone)

                    Dim bfPAN As New BoundField()
                    bfPAN.DataField = "PANCardNumber"
                    bfPAN.HeaderText = "PAN Card"
                    gvDetails.Columns.Add(bfPAN)

                    Dim bfJoining As New BoundField()
                    bfJoining.DataField = "DateOfJoining"
                    bfJoining.HeaderText = "Date of Joining"
                    bfJoining.DataFormatString = "{0:dd/MM/yyyy}"
                    gvDetails.Columns.Add(bfJoining)

                    Dim bfShift As New BoundField()
                    bfShift.DataField = "Shift"
                    bfShift.HeaderText = "Shift"
                    gvDetails.Columns.Add(bfShift)

                    gvDetails.DataSource = dt
                    gvDetails.DataBind()
                End Using
            Catch ex As Exception
                lblMessage.Text = "Error loading employee details: " & ex.Message
                lblMessage.Visible = True
                gvDetails.Visible = False
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub LoadAttendanceDetails()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT EmployeeID, EmployeeName, AttendanceStatus, AttendanceDateTime, Shift FROM AttendanceRecords ORDER BY AttendanceDateTime DESC"
                Using cmd As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Define columns dynamically
                    Dim bfEmployeeID As New BoundField()
                    bfEmployeeID.DataField = "EmployeeID"
                    bfEmployeeID.HeaderText = "Employee ID"
                    gvDetails.Columns.Add(bfEmployeeID)

                    gvDetails.Columns.Add(New TemplateField() With {
                        .HeaderText = "Employee Name",
                        .ItemTemplate = New GridViewTemplate("EmployeeName", "highlight")
                    })

                    Dim bfStatus As New BoundField()
                    bfStatus.DataField = "AttendanceStatus"
                    bfStatus.HeaderText = "Status"
                    gvDetails.Columns.Add(bfStatus)

                    Dim bfDateTime As New BoundField()
                    bfDateTime.DataField = "AttendanceDateTime"
                    bfDateTime.HeaderText = "Date & Time"
                    bfDateTime.DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}"
                    gvDetails.Columns.Add(bfDateTime)

                    Dim bfShift As New BoundField()
                    bfShift.DataField = "Shift"
                    bfShift.HeaderText = "Shift"
                    gvDetails.Columns.Add(bfShift)

                    gvDetails.DataSource = dt
                    gvDetails.DataBind()
                End Using
            Catch ex As Exception
                lblMessage.Text = "Error loading attendance details: " & ex.Message
                lblMessage.Visible = True
                gvDetails.Visible = False
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Class

' Custom Template class for GridView
Public Class GridViewTemplate
    Implements ITemplate

    Private _dataField As String
    Private _cssClass As String

    Public Sub New(ByVal dataField As String, ByVal cssClass As String)
        _dataField = dataField
        _cssClass = cssClass
    End Sub

    Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
        Dim literal As New Literal()
        AddHandler literal.DataBinding, AddressOf Literal_DataBinding
        container.Controls.Add(literal)
    End Sub

    Private Sub Literal_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        Dim literal As Literal = DirectCast(sender, Literal)
        Dim row As GridViewRow = DirectCast(literal.NamingContainer, GridViewRow)
        Dim dataValue As Object = DataBinder.Eval(row.DataItem, _dataField)
        literal.Text = "<span class='" & _cssClass & "'>" & dataValue & "</span>"
    End Sub
End Class