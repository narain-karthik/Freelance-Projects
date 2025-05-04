Imports System.Data.SqlClient

Public Class StaffAttendance

    Private Sub StaffAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDataSet3.StaffDetails' table. You can move, or remove it, as needed.
        Me.StaffDetailsTableAdapter1.Fill(Me.CarDataSet3.StaffDetails)
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Try
            ' Define the connection string
            Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Car;Integrated Security=True"
            Using con As New SqlConnection(connectionString)
                con.Open() ' Open the database connection

                ' Start a database transaction to ensure atomicity
                Using tran As SqlTransaction = con.BeginTransaction()
                    ' Create the SQL command
                    Using cmd As New SqlCommand()
                        cmd.Connection = con
                        cmd.Transaction = tran

                        ' Loop through DataGridView rows
                        For Each row As DataGridViewRow In MarkDataGridView.Rows
                            ' Skip empty rows
                            If row.IsNewRow Then Continue For

                            ' Get the values from the row, with DBNull handling
                            Dim name As String = If(row.Cells("EmployeeNameDataGridViewTextBoxColumn").Value IsNot DBNull.Value, row.Cells("EmployeeNameDataGridViewTextBoxColumn").Value.ToString(), String.Empty)
                            Dim register As String = If(row.Cells("EmployeeIDDataGridViewTextBoxColumn").Value IsNot DBNull.Value, row.Cells("EmployeeIDDataGridViewTextBoxColumn").Value.ToString(), String.Empty)
                            Dim isMarked As Boolean = Convert.ToBoolean(row.Cells("MarkAttendanceCheckBoxColumn").Value)

                            ' Define the query for inserting/updating attendance
                            Dim query As String = "IF EXISTS (SELECT 1 FROM [Car].[dbo].[AttendanceRecords] WHERE Register = @Register AND Date = @Date) " & _
                                                  "UPDATE [Car].[dbo].[AttendanceRecords] SET IsPresent = @IsPresent, Name = @Name WHERE Register = @Register AND Date = @Date " & _
                                                  "ELSE " & _
                                                  "INSERT INTO [Car].[dbo].[AttendanceRecords] (Register, Name, Date, IsPresent) VALUES (@Register, @Name, @Date, @IsPresent)"

                            ' Set up the SQL command parameters
                            cmd.CommandText = query
                            cmd.Parameters.Clear() ' Clear previous parameters

                            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name
                            cmd.Parameters.Add("@Register", SqlDbType.NVarChar).Value = register
                            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Now.Date
                            cmd.Parameters.Add("@IsPresent", SqlDbType.Bit).Value = isMarked

                            ' Execute the query
                            cmd.ExecuteNonQuery()
                        Next

                        ' Commit the transaction if everything goes well
                        tran.Commit()
                    End Using
                End Using
            End Using

            ' Display success message
            MessageBox.Show("Attendance marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Handle errors and rollback transaction if needed
            MessageBox.Show("An error occurred while saving attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
