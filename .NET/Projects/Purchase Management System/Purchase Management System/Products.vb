Imports System.Data.SqlClient

Public Class Products
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PurchaseManagement;Integrated Security=True")

    Shared Property SelectedIndex As Integer

    Shared Property DisplayMember As String

    Shared Property ValueMember As String

    Private Sub Products_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Load default product names
        cmbProductName.Items.AddRange(New String() {
            "Rice", "Sugar", "Milk", "Oil", "Wheat", "Tea", "Coffee", "Biscuits", "Soap", "Shampoo"
        })
        cmbProductName.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If cmbProductName.Text = "" OrElse txtPurchasePrice.Text = "" OrElse txtSellingPrice.Text = "" Then
            MessageBox.Show("Please enter all fields.")
            Exit Sub
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Products (ProductName, PurchasePrice, SellingPrice) VALUES (@name, @purchase, @sell)", con)
            cmd.Parameters.AddWithValue("@name", cmbProductName.Text)
            cmd.Parameters.AddWithValue("@purchase", Convert.ToDecimal(txtPurchasePrice.Text))
            cmd.Parameters.AddWithValue("@sell", Convert.ToDecimal(txtSellingPrice.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product price saved successfully!")
            txtPurchasePrice.Clear()
            txtSellingPrice.Clear()
            cmbProductName.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Shared Function SelectedItem() As Object
        Throw New NotImplementedException
    End Function

    Shared Function Items() As Object
        Throw New NotImplementedException
    End Function

End Class
