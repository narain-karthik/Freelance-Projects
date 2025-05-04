Imports System.Data.SqlClient

Public Class SupplierCreditDetails
    Private Sub CalculateRemainingCredit()
        Dim totalCredit As Decimal
        Dim creditUsed As Decimal

        If Decimal.TryParse(TotalCreditLimitTextBox.Text, totalCredit) AndAlso Decimal.TryParse(CreditUsedTextBox.Text, creditUsed) Then
            RemainingCreditTextBox.Text = (totalCredit - creditUsed).ToString()
        Else
            RemainingCreditTextBox.Text = "0"
        End If
    End Sub

    Private Sub CreditUsedTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CreditUsedTextBox.TextChanged
        CalculateRemainingCredit()
    End Sub

    Private Sub TotalCreditLimitTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TotalCreditLimitTextBox.TextChanged
        CalculateRemainingCredit()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SubmitButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Credit;Integrated Security=True"
        Dim query As String = "INSERT INTO SupplierCredit (SupplierID, TotalCreditLimit, CreditUsed, DueAmount, DueDate, InterestRate, PaymentStatus, LastPaymentDate, NextPaymentDueDate) " & _
                              "VALUES (@SupplierID, @TotalCreditLimit, @CreditUsed, @DueAmount, @DueDate, @InterestRate, @PaymentStatus, @LastPaymentDate, @NextPaymentDueDate)"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' REMOVED @CreditID since it's auto-generated
                cmd.Parameters.AddWithValue("@SupplierID", SupplierIDTextBox.Text)
                cmd.Parameters.AddWithValue("@TotalCreditLimit", TotalCreditLimitTextBox.Text)
                cmd.Parameters.AddWithValue("@CreditUsed", CreditUsedTextBox.Text)
                cmd.Parameters.AddWithValue("@DueAmount", DueAmountTextBox.Text)
                cmd.Parameters.AddWithValue("@DueDate", DueDateTextBox.Text)
                cmd.Parameters.AddWithValue("@InterestRate", InterestRateTextBox.Text)
                cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatusTextBox.Text)
                cmd.Parameters.AddWithValue("@LastPaymentDate", LastPaymentDateDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@NextPaymentDueDate", NextPaymentDueDateDateTimePicker.Value)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Supplier credit details saved successfully.")
            End Using
        End Using
    End Sub
End Class
