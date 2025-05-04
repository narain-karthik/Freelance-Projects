Imports System.Data.SqlClient

Public Class ViewStock
    Dim con As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=PurchaseManagement;Integrated Security=True")

    Private Sub ViewStock_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchaseManagementDataSet2.StockTransactions' table. You can move, or remove it, as needed.
        Me.StockTransactionsTableAdapter.Fill(Me.PurchaseManagementDataSet2.StockTransactions)

    End Sub


    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click

    End Sub

    

End Class
