Imports System.Data.SqlClient

Public Class ViewStaffDetails

    Private Sub ViewStaffDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AttendanceDataSet.StaffDetails' table. You can move, or remove it, as needed.
        Me.StaffDetailsTableAdapter.Fill(Me.AttendanceDataSet.StaffDetails)

    End Sub

    Private Sub ViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
            Using con As New SqlConnection(connectionString)
                ' SQL query to fetch staff details
                Dim query As String = "SELECT * FROM [Attendance].[dbo].[StaffDetails]"

                ' Create a DataAdapter to fill the data into a DataTable
                Using da As New SqlDataAdapter(query, con)
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the database
                    da.Fill(dt)

                    ' Bind the data to a DataGridView
                    ViewDataGridView.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            ' Display error message if something goes wrong
            MessageBox.Show("An error occurred while fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class