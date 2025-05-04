Imports System.Data.SqlClient

Public Class MarkAttendance

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MarkAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AttendanceDataSet3.StaffDetails' table. You can move, or remove it, as needed.
        Me.StaffDetailsTableAdapter.Fill(Me.AttendanceDataSet3.StaffDetails)

    End Sub

    Private Sub MarkDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MarkDataGridView.CellContentClick

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
            Using con As New SqlConnection(connectionString)
                con.Open() ' Open the database connection

                ' Loop through DataGridView rows
                For Each row As DataGridViewRow In MarkDataGridView.Rows
                    ' Skip empty rows
                    If row.IsNewRow Then Continue For

                    ' Get the values from the row
                    Dim name As String = row.Cells("NameDataGridViewTextBoxColumn").Value.ToString()
                    Dim register As String = row.Cells("RegisterDataGridViewTextBoxColumn").Value.ToString()
                    Dim isMarked As Boolean = Convert.ToBoolean(row.Cells("MarkAttendanceCheckBoxColumn").Value)

                    ' Define the query for inserting/updating attendance
                    Dim query As String = "IF EXISTS (SELECT 1 FROM [Attendance].[dbo].[AttendanceRecords] WHERE Register = @Register AND Date = @Date) " & _
                                          "UPDATE [Attendance].[dbo].[AttendanceRecords] SET IsPresent = @IsPresent, Name = @Name WHERE Register = @Register AND Date = @Date " & _
                                          "ELSE " & _
                                          "INSERT INTO [Attendance].[dbo].[AttendanceRecords] (Register, Name, Date, IsPresent) VALUES (@Register, @Name, @Date, @IsPresent)"

                    Using cmd As New SqlCommand(query, con)
                        ' Add parameters to the query
                        cmd.Parameters.AddWithValue("@Name", name)
                        cmd.Parameters.AddWithValue("@Register", register)
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date)
                        cmd.Parameters.AddWithValue("@IsPresent", isMarked)

                        ' Execute the query
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            ' Display success message
            MessageBox.Show("Attendance marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("An error occurred while saving attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class