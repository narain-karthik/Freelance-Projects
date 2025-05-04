Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancellation
    Inherits System.Windows.Forms.Form

    'Database Connection String (Modify as per your setup)
    Dim connectionString As String = "Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Railway;Integrated Security=True"

    Dim connection As SqlConnection = New SqlConnection(connectionString)

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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPNR = New System.Windows.Forms.Label()
        Me.txtPNR = New System.Windows.Forms.TextBox()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.btnCancelTicket = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' Label1 - Southern Railways
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Southern Railways"

        ' Label2 - Reservation
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reservation"

        ' Label for Enter PNR Number
        Me.lblPNR.AutoSize = True
        Me.lblPNR.Location = New System.Drawing.Point(50, 100)
        Me.lblPNR.Name = "lblPNR"
        Me.lblPNR.Size = New System.Drawing.Size(120, 17)
        Me.lblPNR.TabIndex = 3
        Me.lblPNR.Text = "Enter PNR Number:"

        ' TextBox for PNR Input
        Me.txtPNR.Location = New System.Drawing.Point(180, 97)
        Me.txtPNR.Name = "txtPNR"
        Me.txtPNR.Size = New System.Drawing.Size(200, 22)
        Me.txtPNR.TabIndex = 4

        ' DataGridView for Ticket Details
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Location = New System.Drawing.Point(50, 140)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.Size = New System.Drawing.Size(600, 150)
        Me.dgvTickets.TabIndex = 5

        ' Cancel Ticket Button
        Me.btnCancelTicket.Location = New System.Drawing.Point(200, 320)
        Me.btnCancelTicket.Name = "btnCancelTicket"
        Me.btnCancelTicket.Size = New System.Drawing.Size(120, 30)
        Me.btnCancelTicket.TabIndex = 6
        Me.btnCancelTicket.Text = "Cancel Ticket"
        Me.btnCancelTicket.UseVisualStyleBackColor = True
        AddHandler btnCancelTicket.Click, AddressOf btnCancelTicket_Click

        ' Back Button
        Me.btnBack.Location = New System.Drawing.Point(350, 320)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 30)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        AddHandler btnBack.Click, AddressOf btnBack_Click

        ' Cancellation Form Properties
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCancelTicket)
        Me.Controls.Add(Me.dgvTickets)
        Me.Controls.Add(Me.txtPNR)
        Me.Controls.Add(Me.lblPNR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cancellation"
        Me.Text = "Cancellation"

        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    ' Declare UI Elements
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPNR As System.Windows.Forms.Label
    Friend WithEvents txtPNR As System.Windows.Forms.TextBox
    Friend WithEvents dgvTickets As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelTicket As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button

    ' Function to load ticket details based on PNR Number
    Private Sub LoadTicketDetails()
        Try
            Dim query As String = "SELECT PNR_NO, Train_No, Train_Name, [From], [To] FROM Tickets WHERE PNR_NO = @PNR"
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@PNR", txtPNR.Text.Trim())

            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvTickets.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' Event: When user enters PNR and presses Enter
    Private Sub txtPNR_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPNR.TextChanged
        If txtPNR.Text.Trim() <> "" Then
            LoadTicketDetails()
        Else
            dgvTickets.DataSource = Nothing
        End If
    End Sub

    ' Event: Cancel selected ticket
    Private Sub btnCancelTicket_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelTicket.Click
        Try
            If dgvTickets.SelectedRows.Count > 0 Then
                Dim selectedPNR As String = dgvTickets.SelectedRows(0).Cells("PNR_NO").Value.ToString()

                Dim query As String = "DELETE FROM Tickets WHERE PNR_NO = @PNR"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@PNR", selectedPNR)

                connection.Open()
                Dim result As Integer = command.ExecuteNonQuery()
                connection.Close()

                If result > 0 Then
                    MessageBox.Show("Ticket canceled successfully.")
                    LoadTicketDetails()
                Else
                    MessageBox.Show("Failed to cancel ticket.")
                End If
            Else
                MessageBox.Show("Please select a ticket to cancel.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Event: Close the form
    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
