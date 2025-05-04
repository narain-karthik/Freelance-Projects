Imports System.Data.SqlClient

Public Class Suppliers
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PurchaseManagement;Integrated Security=True")

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' Validate Inputs
        If txtSupplierName.Text = "" Then
            MessageBox.Show("Please enter Supplier Name.")
            Exit Sub
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Suppliers (SupplierName, Phone, Email, Address, GSTNumber) VALUES (@name, @phone, @email, @address, @gst)", con)
            cmd.Parameters.AddWithValue("@name", txtSupplierName.Text)
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@gst", txtGST.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Supplier saved successfully!")
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        txtSupplierID.Clear()
        txtSupplierName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtGST.Clear()
    End Sub
End Class
