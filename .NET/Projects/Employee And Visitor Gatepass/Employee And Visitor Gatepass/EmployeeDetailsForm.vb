Imports System.Data.SqlClient

Public Class EmployeeDetailsForm
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Gatepass;Integrated Security=True")
    Dim cmd As SqlCommand

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            con.Open()
            Dim query As String = "INSERT INTO Employees (Name, DOB, Gender, Contact, Email, Address, Department, Designation, DOJ) VALUES (@Name, @DOB, @Gender, @Contact, @Email, @Address, @Department, @Designation, @DOJ)"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value)
            cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text)
            cmd.Parameters.AddWithValue("@Designation", txtDesignation.Text)
            cmd.Parameters.AddWithValue("@DOJ", dtpDOJ.Value)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Saved Successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
