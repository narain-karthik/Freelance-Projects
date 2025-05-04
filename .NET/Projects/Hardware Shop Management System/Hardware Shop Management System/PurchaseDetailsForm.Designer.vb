Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseDetailsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.btnAddPurchase = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProuductIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()

        ' Form Background
        Me.BackColor = System.Drawing.Color.FromArgb(240, 248, 255)

        ' btnAddPurchase
        Me.btnAddPurchase.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPurchase.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPurchase.ForeColor = System.Drawing.Color.White
        Me.btnAddPurchase.Location = New System.Drawing.Point(20, 390)
        Me.btnAddPurchase.Name = "btnAddPurchase"
        Me.btnAddPurchase.Size = New System.Drawing.Size(140, 40)
        Me.btnAddPurchase.TabIndex = 1
        Me.btnAddPurchase.Text = "Add Purchase"
        Me.btnAddPurchase.UseVisualStyleBackColor = False

        ' btnRefresh
        Me.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(190, 390)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(140, 40)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False

        ' btnClose
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(360, 390)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(140, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False

        ' Labels
        Dim labels() As System.Windows.Forms.Label = {Label1, Label2, Label3, Label4, Label5}
        For Each lbl As Label In labels
            lbl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            lbl.ForeColor = System.Drawing.Color.DarkSlateGray
        Next

        ' Label1
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PRODUCT ID"

        ' Label2
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PRODUCT NAME"

        ' Label3
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PRODUCT PRICE"

        ' Label4
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "QUANTITY"

        ' Label5
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "AMOUNT"

        ' TextBoxes
        Dim textboxes() As System.Windows.Forms.TextBox = {ProuductIDTextBox, ProductNameTextBox, ProductPriceTextBox, QuantityTextBox, AmountTextBox}
        For Each txt As TextBox In textboxes
            txt.BackColor = System.Drawing.Color.WhiteSmoke
            txt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            txt.BorderStyle = BorderStyle.FixedSingle
        Next

        ' ProuductIDTextBox
        Me.ProuductIDTextBox.Location = New System.Drawing.Point(190, 60)
        Me.ProuductIDTextBox.Name = "ProuductIDTextBox"
        Me.ProuductIDTextBox.Size = New System.Drawing.Size(220, 25)
        Me.ProuductIDTextBox.TabIndex = 9

        ' ProductNameTextBox
        Me.ProductNameTextBox.Location = New System.Drawing.Point(190, 110)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(220, 25)
        Me.ProductNameTextBox.TabIndex = 10

        ' ProductPriceTextBox
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(190, 160)
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(220, 25)
        Me.ProductPriceTextBox.TabIndex = 11

        ' QuantityTextBox
        Me.QuantityTextBox.Location = New System.Drawing.Point(190, 210)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(220, 25)
        Me.QuantityTextBox.TabIndex = 12

        ' AmountTextBox
        Me.AmountTextBox.Location = New System.Drawing.Point(190, 260)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(220, 25)
        Me.AmountTextBox.TabIndex = 13

        ' PurchaseDetailsForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 460)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.ProductPriceTextBox)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(Me.ProuductIDTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAddPurchase)
        Me.Name = "PurchaseDetailsForm"
        Me.Text = "Purchase Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    ' Controls
    Friend WithEvents btnAddPurchase As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProuductIDTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductPriceTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox

    ' === DATABASE CONNECTION STRING ===
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Hardware;Integrated Security=True"

    ' === BUTTON EVENTS ===
    Private Sub btnAddPurchase_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddPurchase.Click
        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("INSERT INTO PurchaseDetails (ProductID, ProductName, ProductPrice, Quantity, Amount) VALUES (@ProductID, @ProductName, @ProductPrice, @Quantity, @Amount)", conn)

        cmd.Parameters.AddWithValue("@ProductID", ProuductIDTextBox.Text)
        cmd.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text)
        cmd.Parameters.AddWithValue("@ProductPrice", ProductPriceTextBox.Text)
        cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
        cmd.Parameters.AddWithValue("@Amount", AmountTextBox.Text)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Purchase Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        ProuductIDTextBox.Clear()
        ProductNameTextBox.Clear()
        ProductPriceTextBox.Clear()
        QuantityTextBox.Clear()
        AmountTextBox.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
