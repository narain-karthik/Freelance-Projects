Imports System.Data.SqlClient

Public Class CustomerDetails

    ' SQL Server connection
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Fashion;Integrated Security=True")
    Dim selectedCustomerId As Integer = -1

    ' Load customers on form load
    Private Sub CustomerDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    ' Load all customers
    Private Sub LoadCustomers()
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM Customers", con)
            da.Fill(dt)
            dgvCustomers.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try
    End Sub

    ' Add new customer
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Customers (Name, Phone, Email, Address) VALUES (@Name, @Phone, @Email, @Address)", con)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Customer added successfully!")
            LoadCustomers()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error adding customer: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Update selected customer
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If selectedCustomerId = -1 Then
            MessageBox.Show("Please select a customer to update.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Customers SET Name=@Name, Phone=@Phone, Email=@Email, Address=@Address WHERE Id=@Id", con)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Id", selectedCustomerId)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Customer updated successfully!")
            LoadCustomers()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error updating customer: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Delete selected customer
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If selectedCustomerId = -1 Then
            MessageBox.Show("Please select a customer to delete.")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Customers WHERE Id=@Id", con)
            cmd.Parameters.AddWithValue("@Id", selectedCustomerId)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Customer deleted successfully!")
            LoadCustomers()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error deleting customer: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' Clear form inputs
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtName.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        selectedCustomerId = -1
    End Sub

    ' Populate form when row is selected
    Private Sub dgvCustomers_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCustomers.Rows(e.RowIndex)
            selectedCustomerId = Convert.ToInt32(row.Cells("Id").Value)
            txtName.Text = row.Cells("Name").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtAddress.Text = row.Cells("Address").Value.ToString()
        End If
    End Sub

End Class
