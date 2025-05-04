Imports System.Data.SqlClient

Public Class ViewCustomerDetails
    ' Connection string for SQL Server
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=ProductManagement;Integrated Security=True"

    Private Sub ViewCustomerDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

        ' Load data initially
        LoadCustomerData()
    End Sub

    ' Load customer data from the database
    Private Sub LoadCustomerData()
        DataGridViewCustomers.Rows.Clear() ' Clear existing rows

        Dim query As String = "SELECT SNo, CustomerID, CustomerName, CustomerAddress, PhoneNumber, EmailID FROM Customers"
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Try
                    con.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DataGridViewCustomers.Rows.Add(
                                reader("SNo").ToString(),
                                reader("CustomerID").ToString(),
                                reader("CustomerName").ToString(),
                                reader("CustomerAddress").ToString(),
                                reader("PhoneNumber").ToString(),
                                If(reader("EmailID") Is DBNull.Value, "", reader("EmailID").ToString())
                            )
                        End While
                    End Using
                Catch ex As SqlException
                    MessageBox.Show("Error fetching customer data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Refresh button to reload data
    Private Sub ButtonRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadCustomerData()
    End Sub
End Class