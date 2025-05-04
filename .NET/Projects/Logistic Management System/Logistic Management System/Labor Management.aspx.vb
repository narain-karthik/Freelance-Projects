Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class LaborManagement
    Inherits System.Web.UI.Page

    ' Database connection string
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("DBConnection").ConnectionString

    ' Load Task Assignments
    Private Sub LoadTasks()
        Dim query As String = "SELECT * FROM TaskAssignments"
        TaskGridView.DataSource = GetData(query)
        TaskGridView.DataBind()
    End Sub

    ' Load Employee Performance
    Private Sub LoadPerformance()
        Dim query As String = "SELECT * FROM EmployeePerformance"
        PerformanceGridView.DataSource = GetData(query)
        PerformanceGridView.DataBind()
    End Sub

    ' Load Compliance Data
    Private Sub LoadCompliance()
        Dim query As String = "SELECT * FROM LaborCompliance"
        ComplianceGridView.DataSource = GetData(query)
        ComplianceGridView.DataBind()
    End Sub

    ' Fetch Data from Database
    Private Function GetData(ByVal query As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Using sda As New SqlDataAdapter(cmd)
                    sda.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' Create a New Task Assignment
    Protected Sub btnCreateTask_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using con As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO TaskAssignments (EmployeeName, TaskDescription, ScheduledDate, Status) VALUES (@EmployeeName, @TaskDescription, @ScheduledDate, @Status)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@EmployeeName", ddlEmployee.SelectedValue)
                cmd.Parameters.AddWithValue("@TaskDescription", txtTaskDescription.Text)
                cmd.Parameters.AddWithValue("@ScheduledDate", Convert.ToDateTime(txtScheduledDate.Text))
                cmd.Parameters.AddWithValue("@Status", ddlStatus.SelectedValue)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        LoadTasks()
        CreateStatusLabel.Text = "Task assigned successfully!"
        CreateStatusLabel.Visible = True
    End Sub

    ' Log Employee Performance
    Protected Sub btnLogPerformance_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using con As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO EmployeePerformance (EmployeeName, TasksCompleted, ProductivityRate) VALUES (@EmployeeName, @TasksCompleted, @ProductivityRate)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@EmployeeName", ddlPerformanceEmployee.SelectedValue)
                cmd.Parameters.AddWithValue("@TasksCompleted", Convert.ToInt32(txtTasksCompleted.Text))
                cmd.Parameters.AddWithValue("@ProductivityRate", Convert.ToDecimal(txtProductivityRate.Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        LoadPerformance()
        PerformanceStatusLabel.Text = "Performance logged successfully!"
        PerformanceStatusLabel.Visible = True
    End Sub

    ' Log Labor Compliance
    Protected Sub btnLogCompliance_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using con As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO LaborCompliance (EmployeeName, HoursWorked) VALUES (@EmployeeName, @HoursWorked)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@EmployeeName", ddlComplianceEmployee.SelectedValue)
                cmd.Parameters.AddWithValue("@HoursWorked", Convert.ToDecimal(txtHoursWorked.Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        LoadCompliance()
        ComplianceStatusLabel.Text = "Compliance record added!"
        ComplianceStatusLabel.Visible = True
    End Sub

    ' Refresh Data
    Protected Sub RefreshButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        LoadTasks()
        LoadPerformance()
        LoadCompliance()
        StatusLabel.Text = "Data refreshed successfully!"
        StatusLabel.Visible = True
    End Sub

    ' Function for Compliance Status
    Protected Function GetComplianceStatus(ByVal hoursWorked As Object) As String
        If Convert.ToDecimal(hoursWorked) > 40 Then
            Return "Overworked - Compliance Alert!"
        Else
            Return "Compliant"
        End If
    End Function

    ' Page Load Event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadTasks()
            LoadPerformance()
            LoadCompliance()
        End If
    End Sub

End Class
