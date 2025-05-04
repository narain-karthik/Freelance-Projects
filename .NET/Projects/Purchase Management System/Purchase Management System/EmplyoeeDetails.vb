Imports System.Data.SqlClient

Public Class EmployeeForm
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PurchaseManagement;Integrated Security=True")

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            ' Open connection
            con.Open()

            ' Insert query
            Dim query As String = "INSERT INTO Employees (EmployeeName, ContactNumber, Address, Salary, DOB, Gender, Position, DOJ) VALUES (@EmployeeName, @ContactNumber, @Address, @Salary, @DOB, @Gender, @Position, @DOJ)"

            Using cmd As New SqlCommand(query, con)
                ' Add parameters
                cmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text))
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Position", PositionComboBox.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@DOJ", dtpDOJ.Value.Date)

                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Employee record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally clear form
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ClearForm()
        txtEmployeeID.Clear()
        txtEmployeeName.Clear()
        txtContactNumber.Clear()
        txtAddress.Clear()
        txtSalary.Clear()
        cmbGender.SelectedIndex = -1
        PositionComboBox.SelectedIndex = -1
        dtpDOB.Value = Date.Today
        dtpDOJ.Value = Date.Today
    End Sub
End Class
