Imports System.Data.SqlClient

Public Class CustomerDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PaintingManagement;Integrated Security=True"

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

        ' Generate initial IDs
        GenerateIDs()
    End Sub

    ' Auto-generate S.No and Customer ID
    Private Sub GenerateIDs()
        Dim rowCount As Integer = DataGridViewCustomers.Rows.Count + 1
        TextBoxSNo.Text = rowCount.ToString()
        TextBoxCustomerID.Text = "C" & Now.Ticks Mod 10000 ' Simple unique ID
    End Sub

    ' Add entry to DataGridView
    Private Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAdd.Click
        ' Collecting Input Data
        Dim customerName As String = TextBoxCustomerName.Text.Trim()
        Dim customerAddress As String = TextBoxCustomerAddress.Text.Trim()
        Dim phoneNumber As String = TextBoxPhoneNumber.Text.Trim()
        Dim emailID As String = TextBoxEmailID.Text.Trim()

        ' Input Validation
        If String.IsNullOrEmpty(customerName) OrElse String.IsNullOrEmpty(customerAddress) OrElse
           String.IsNullOrEmpty(phoneNumber) OrElse String.IsNullOrEmpty(emailID) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Basic phone number and email validation
        If Not IsNumeric(phoneNumber) OrElse phoneNumber.Length <> 10 Then
            MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not emailID.Contains("@") OrElse Not emailID.Contains(".") Then
            MessageBox.Show("Please enter a valid email ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataGridViewCustomers.Rows.Add(
            TextBoxSNo.Text,
            TextBoxCustomerID.Text,
            customerName,
            customerAddress,
            phoneNumber,
            emailID
        )

        ' Reset form for next entry
        TextBoxCustomerName.Clear()
        TextBoxCustomerAddress.Clear()
        TextBoxPhoneNumber.Clear()
        TextBoxEmailID.Clear()
        GenerateIDs()
    End Sub

    ' Save to database
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSave.Click
        If DataGridViewCustomers.Rows.Count = 0 Then
            MessageBox.Show("No customer details to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL Query to Insert Data
        Dim query As String = "INSERT INTO Customers (SNo, CustomerID, CustomerName, CustomerAddress, PhoneNumber, EmailID) " &
                              "VALUES (@SNo, @CustomerID, @CustomerName, @CustomerAddress, @PhoneNumber, @EmailID)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    For Each row As DataGridViewRow In DataGridViewCustomers.Rows
                        If Not row.IsNewRow Then ' Skip the new row placeholder
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
                            cmd.Parameters.AddWithValue("@EmailID", emailID)

                            cmd.ExecuteNonQuery()
                        End If
                    Next
                    MessageBox.Show("Customer details saved successfully to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridViewCustomers.Rows.Clear() ' Clear after saving
                    GenerateIDs()
                Catch ex As SqlException
                    MessageBox.Show("Error while inserting data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Error processing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class