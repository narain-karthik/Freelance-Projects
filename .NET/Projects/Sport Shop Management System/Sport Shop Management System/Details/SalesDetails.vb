Imports System.Data.SqlClient

Public Class SalesDetails

    ' Declare your connection
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Sport;Integrated Security=True")

    Private Sub SalesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Fill the Items ComboBox with Sport Things
        ItemsComboBox.Items.Add("Football")
        ItemsComboBox.Items.Add("Basketball")
        ItemsComboBox.Items.Add("Tennis Racket")
        ItemsComboBox.Items.Add("Badminton Shuttlecock")
        ItemsComboBox.Items.Add("Cricket Bat")
        ItemsComboBox.Items.Add("Running Shoes")
        ItemsComboBox.Items.Add("Yoga Mat")
        ItemsComboBox.Items.Add("Skipping Rope")
    End Sub

    ' Auto-calculate Total Amount
    Private Sub QuantityTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles QuantityTextBox.TextChanged
        Dim amount As Decimal
        Dim quantity As Integer

        If Decimal.TryParse(AmountTextBox.Text, amount) AndAlso Integer.TryParse(QuantityTextBox.Text, quantity) Then
            TotalAmountTextBox.Text = (amount * quantity).ToString()
        Else
            TotalAmountTextBox.Clear()
        End If
    End Sub

    ' Auto-fill Name and Address when CustomerID is entered
    Private Sub CustomerIDTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerIDTextBox.TextChanged
        If Not String.IsNullOrEmpty(CustomerIDTextBox.Text) Then
            Try
                con.Open()
                Dim query As String = "SELECT Name, Address FROM Customers WHERE CustomerID = @CustomerID"
                Dim cmd As New SqlCommand(query, con)

                ' Add the parameter for CustomerID
                cmd.Parameters.AddWithValue("@CustomerID", CustomerIDTextBox.Text)

                ' Execute the query and read the result
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    ' Auto-fill Name and Address fields
                    NameTextBox.Text = reader("Name").ToString()
                    AddressTextBox.Text = reader("Address").ToString()
                Else
                    ' Clear fields if no customer found
                    NameTextBox.Clear()
                    AddressTextBox.Clear()
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            ' Clear Name and Address fields if CustomerID is empty
            NameTextBox.Clear()
            AddressTextBox.Clear()
        End If
    End Sub

    ' Save Button
    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        ' Validate fields
        If CustomerIDTextBox.Text = "" Or NameTextBox.Text = "" Or AddressTextBox.Text = "" Or ItemsComboBox.Text = "" Or AmountTextBox.Text = "" Or QuantityTextBox.Text = "" Or TotalAmountTextBox.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            con.Open()

            Dim query As String = "INSERT INTO SalesDetails (CustomerID, Name, Address, ItemName, Amount, Quantity, TotalAmount) VALUES (@CustomerID, @Name, @Address, @ItemName, @Amount, @Quantity, @TotalAmount)"
            Dim cmd As New SqlCommand(query, con)

            ' Add parameters
            cmd.Parameters.AddWithValue("@CustomerID", CustomerIDTextBox.Text)
            cmd.Parameters.AddWithValue("@Name", NameTextBox.Text)
            cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@ItemName", ItemsComboBox.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Amount", AmountTextBox.Text)
            cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
            cmd.Parameters.AddWithValue("@TotalAmount", TotalAmountTextBox.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear fields after saving
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Clear all fields
    Private Sub ClearFields()
        CustomerIDTextBox.Clear()
        NameTextBox.Clear()
        AddressTextBox.Clear()
        ItemsComboBox.SelectedIndex = -1
        AmountTextBox.Clear()
        QuantityTextBox.Clear()
        TotalAmountTextBox.Clear()
    End Sub

End Class
