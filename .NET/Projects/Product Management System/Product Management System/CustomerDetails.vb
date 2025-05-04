Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class CustomerDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=ProductManagement;Integrated Security=True"

    Private Sub CustomerDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Initialize DataGridView columns
        With DataGridViewCustomers.Columns
            .Add("SNo", "S.No")
            .Add("CustomerID", "Customer ID")
            .Add("CustomerName", "Customer Name")
            .Add("CustomerAddress", "Customer Address")
            .Add("PhoneNumber", "Phone Number")
            .Add("EmailID", "Email ID")
        End With
        DataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Generate initial S.No
        GenerateSNo()
    End Sub

    ' Auto-generate S.No
    Private Sub GenerateSNo()
        Dim rowCount As Integer = DataGridViewCustomers.Rows.Count + 1
        TextBoxSNo.Text = rowCount.ToString()
    End Sub

    ' Validate inputs
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrEmpty(TextBoxCustomerID.Text.Trim()) Then
            MessageBox.Show("Customer ID is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrEmpty(TextBoxCustomerName.Text.Trim()) Then
            MessageBox.Show("Customer Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrEmpty(TextBoxCustomerAddress.Text.Trim()) Then
            MessageBox.Show("Customer Address is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Not Regex.IsMatch(TextBoxPhoneNumber.Text.Trim(), "^\d{10}$") Then
            MessageBox.Show("Phone Number must be a 10-digit number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Not String.IsNullOrEmpty(TextBoxEmailID.Text.Trim()) AndAlso Not Regex.IsMatch(TextBoxEmailID.Text.Trim(), "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Please enter a valid Email ID (e.g., example@domain.com).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' Add entry to DataGridView
    Private Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAdd.Click
        If Not ValidateInputs() Then
            Return
        End If

        DataGridViewCustomers.Rows.Add(
            TextBoxSNo.Text,
            TextBoxCustomerID.Text.Trim(),
            TextBoxCustomerName.Text.Trim(),
            TextBoxCustomerAddress.Text.Trim(),
            TextBoxPhoneNumber.Text.Trim(),
            TextBoxEmailID.Text.Trim()
        )

        ' Reset form for next entry
        TextBoxCustomerID.Clear()
        TextBoxCustomerName.Clear()
        TextBoxCustomerAddress.Clear()
        TextBoxPhoneNumber.Clear()
        TextBoxEmailID.Clear()
        GenerateSNo()
    End Sub

    ' Save to database
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        If DataGridViewCustomers.Rows.Count = 0 Then
            MessageBox.Show("No customer details to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO Customers (SNo, CustomerID, CustomerName, CustomerAddress, PhoneNumber, EmailID) " &
                              "VALUES (@SNo, @CustomerID, @CustomerName, @CustomerAddress, @PhoneNumber, @EmailID)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    For Each row As DataGridViewRow In DataGridViewCustomers.Rows
                        If Not row.IsNewRow Then
                            Dim sNo As Integer = Convert.ToInt32(row.Cells("SNo").Value)
                            Dim customerID As String = row.Cells("CustomerID").Value.ToString()
                            Dim customerName As String = row.Cells("CustomerName").Value.ToString()
                            Dim customerAddress As String = row.Cells("CustomerAddress").Value.ToString()
                            Dim phoneNumber As String = row.Cells("PhoneNumber").Value.ToString()
                            Dim emailID As String = row.Cells("EmailID").Value.ToString()

                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@SNo", sNo)
                            cmd.Parameters.AddWithValue("@CustomerID", customerID)
                            cmd.Parameters.AddWithValue("@CustomerName", customerName)
                            cmd.Parameters.AddWithValue("@CustomerAddress", customerAddress)
                            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                            cmd.Parameters.AddWithValue("@EmailID", If(String.IsNullOrEmpty(emailID), DBNull.Value, emailID))

                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    MessageBox.Show("Customer details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridViewCustomers.Rows.Clear()
                    GenerateSNo()
                Catch ex As SqlException
                    MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class