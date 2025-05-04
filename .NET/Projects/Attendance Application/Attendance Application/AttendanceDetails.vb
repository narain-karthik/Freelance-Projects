Imports System.Data.SqlClient

Public Class AttendanceDetails

    Private Sub AttendanceDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AttendanceDataSet4.AttendanceRecords' table. You can move, or remove it, as needed.
        Me.AttendanceRecordsTableAdapter.Fill(Me.AttendanceDataSet4.AttendanceRecords)

    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Try
            ' Get the selected row
            If ViewAttendanceDetailsDataGridView.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = ViewAttendanceDetailsDataGridView.SelectedRows(0)

                ' Extract values from the selected row
                Dim register As String = selectedRow.Cells("RegisterDataGridViewTextBoxColumn").Value.ToString()
                Dim name As String = selectedRow.Cells("NameDataGridViewTextBoxColumn").Value.ToString()
                Dim [date] As Date = Date.Parse(selectedRow.Cells("DateDataGridViewTextBoxColumn").Value.ToString())
                Dim isPresent As Boolean = Convert.ToBoolean(selectedRow.Cells("IsPresentDataGridViewCheckBoxColumn").Value)

                ' Update query
                Dim query As String = "UPDATE [Attendance].[dbo].[AttendanceRecords] SET Name = @Name, IsPresent = @IsPresent WHERE Register = @Register AND Date = @Date"

                ' Database connection
                Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Name", name)
                        cmd.Parameters.AddWithValue("@IsPresent", isPresent)
                        cmd.Parameters.AddWithValue("@Register", register)
                        cmd.Parameters.AddWithValue("@Date", [date])

                        con.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Try
            ' Get the selected row
            If ViewAttendanceDetailsDataGridView.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = ViewAttendanceDetailsDataGridView.SelectedRows(0)

                ' Extract the Register and Date values
                Dim register As String = selectedRow.Cells("RegisterDataGridViewTextBoxColumn").Value.ToString()
                Dim [date] As Date = Date.Parse(selectedRow.Cells("DateDataGridViewTextBoxColumn").Value.ToString())

                ' Delete query
                Dim query As String = "DELETE FROM [Attendance].[dbo].[AttendanceRecords] WHERE Register = @Register AND Date = @Date"

                ' Database connection
                Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True"
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Register", register)
                        cmd.Parameters.AddWithValue("@Date", [date])

                        con.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Remove row from DataGridView
                ViewAttendanceDetailsDataGridView.Rows.Remove(selectedRow)

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewAttendanceDetailsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ViewAttendanceDetailsDataGridView.CellContentClick

    End Sub
End Class