Imports System.Data.SqlClient

Public Class ViewAttendance

    Private Sub ViewAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AttendanceDataSet5.AttendanceRecords' table. You can move, or remove it, as needed.
        Me.AttendanceRecordsTableAdapter.Fill(Me.AttendanceDataSet5.AttendanceRecords)

    End Sub

    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
        Dim registerNumber As String = RegisterTextBox.Text.Trim()

        If String.IsNullOrEmpty(registerNumber) Then
            MessageBox.Show("Please enter a register number to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "SELECT * FROM [Attendance].[dbo].[AttendanceRecords] WHERE Register = @Register"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Register", registerNumber)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    ViewAttendanceDetailsDataGridView.DataSource = table
                Else
                    MessageBox.Show("No records found for the entered register number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Using
    End Sub
End Class