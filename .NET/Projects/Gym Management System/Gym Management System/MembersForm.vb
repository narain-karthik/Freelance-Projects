Imports System.Data.SqlClient

Public Class MembersForm

    ' Change this connection string to your database
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True"

    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        ' Validate input
        If MembershipIDTextBox.Text = "" OrElse NameTextBox.Text = "" OrElse PhoneNumberTextBox.Text = "" Then
            MessageBox.Show("Please fill all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String = "INSERT INTO Members (MembershipID, Name, Address, PhoneNumber, DateOfJoining, Age, Weight, Height, Gender) " &
                                      "VALUES (@MembershipID, @Name, @Address, @PhoneNumber, @DateOfJoining, @Age, @Weight, @Height, @Gender)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MembershipID", MembershipIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@Name", NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                    cmd.Parameters.AddWithValue("@DateOfJoining", DOJTextBox.Text)
                    cmd.Parameters.AddWithValue("@Age", AgeTextBox.Text)
                    cmd.Parameters.AddWithValue("@Weight", WeightTextBox.Text)
                    cmd.Parameters.AddWithValue("@Height", HeightTextBox.Text)
                    cmd.Parameters.AddWithValue("@Gender", GenderComboBox.SelectedItem.ToString())

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Member details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        MembershipIDTextBox.Clear()
        NameTextBox.Clear()
        AddressTextBox.Clear()
        PhoneNumberTextBox.Clear()
        DOJTextBox.Clear()
        AgeTextBox.Clear()
        WeightTextBox.Clear()
        HeightTextBox.Clear()
        GenderComboBox.SelectedIndex = -1
    End Sub

    Private Sub MembersForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Populate Gender ComboBox
        GenderComboBox.Items.Add("Male")
        GenderComboBox.Items.Add("Female")
        GenderComboBox.Items.Add("Other")
    End Sub

End Class
