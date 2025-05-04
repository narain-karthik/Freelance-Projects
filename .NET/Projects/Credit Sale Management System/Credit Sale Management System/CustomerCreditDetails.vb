Imports System.Data.SqlClient

Public Class CustomerCreditDetails
    Private Sub CustomerCreditDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' TODO: Load necessary data when the form loads
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Credit;Integrated Security=True"
        Dim query As String = "INSERT INTO CustomerCredit (CreditID, CustomerID, TotalCreditLimit, CreditUsed, RemainingCredit, DueAmount, DueDate, InterestRate, PaymentStatus, LastPaymentDate, NextPaymentDueDate) " &
                              "VALUES (@CreditID, @CustomerID, @TotalCreditLimit, @CreditUsed, @RemainingCredit, @DueAmount, @DueDate, @InterestRate, @PaymentStatus, @LastPaymentDate, @NextPaymentDueDate)"

        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CreditID", CreditIDTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerIDTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@TotalCreditLimit", TotalCreditLimitTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@CreditUsed", CreditUsedTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@RemainingCredit", RemainingCreditTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@DueAmount", DueAmountTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@DueDate", DueDateTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@InterestRate", InterestRateTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatusTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@LastPaymentDate", LastPaymentDateDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@NextPaymentDueDate", NextPaymentDueDateDateTimePicker.Value)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Customer credit details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to add customer credit details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    ' Event to dynamically calculate remaining credit
    Private Sub CalculateRemainingCredit(ByVal sender As Object, ByVal e As EventArgs) Handles TotalCreditLimitTextBox.TextChanged, CreditUsedTextBox.TextChanged
        Dim totalCredit As Decimal
        Dim creditUsed As Decimal

        If Decimal.TryParse(TotalCreditLimitTextBox.Text, totalCredit) AndAlso Decimal.TryParse(CreditUsedTextBox.Text, creditUsed) Then
            RemainingCreditTextBox.Text = (totalCredit - creditUsed).ToString()
        Else
            RemainingCreditTextBox.Text = "0"
        End If
    End Sub
End Class
