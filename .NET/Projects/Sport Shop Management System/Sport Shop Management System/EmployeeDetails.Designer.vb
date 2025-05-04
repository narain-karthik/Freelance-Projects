Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetails
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.DOJDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' Form Title
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(110, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE DETAILS"
        Me.Label1.ForeColor = Color.MidnightBlue

        ' Employee ID Label
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EMPLOYEE ID"

        ' Name Label
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAME"

        ' Phone Number Label
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PHONE NUMBER"

        ' Address Label
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ADDRESS"

        ' Date of Joining Label
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DATE OF JOINING"

        ' Date of Birth Label
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DATE OF BIRTH"

        ' Role Label
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ROLE"

        ' Employee ID TextBox
        Me.IDTextBox.Location = New System.Drawing.Point(175, 91)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(180, 22)
        Me.IDTextBox.TabIndex = 8

        ' Name TextBox
        Me.NameTextBox.Location = New System.Drawing.Point(175, 131)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(180, 22)
        Me.NameTextBox.TabIndex = 9

        ' Phone Number TextBox
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(175, 172)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(180, 22)
        Me.PhoneNumberTextBox.TabIndex = 10

        ' Address TextBox
        Me.AddressTextBox.Location = New System.Drawing.Point(175, 217)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(180, 22)
        Me.AddressTextBox.TabIndex = 11

        ' Date of Joining DateTimePicker
        Me.DOJDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOJDateTimePicker.Location = New System.Drawing.Point(175, 260)
        Me.DOJDateTimePicker.Name = "DOJDateTimePicker"
        Me.DOJDateTimePicker.Size = New System.Drawing.Size(180, 22)
        Me.DOJDateTimePicker.TabIndex = 12

        ' Date of Birth DateTimePicker
        Me.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(175, 298)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(180, 22)
        Me.DOBDateTimePicker.TabIndex = 13

        ' Role ComboBox
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Items.AddRange(New Object() {"Admin", "Manager", "Staff"})
        Me.RoleComboBox.Location = New System.Drawing.Point(175, 341)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(180, 24)
        Me.RoleComboBox.TabIndex = 14

        ' Save Button
        Me.SaveButton.BackColor = Color.CornflowerBlue
        Me.SaveButton.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.SaveButton.ForeColor = Color.White
        Me.SaveButton.Location = New System.Drawing.Point(175, 380)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 35)
        Me.SaveButton.TabIndex = 15
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = True
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        ' Form settings
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.RoleComboBox)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Me.DOJDateTimePicker)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeDetails"
        Me.Text = "EmployeeDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOJDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RoleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button

    ' Add SQL Connection and Save Logic
    Dim conn As New SqlConnection("Data Source=LAPTOP-SBLEMHDL\SQLEXPRESS;Initial Catalog=Sport;Integrated Security=True")

    ' Save button click event
    Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        Try
            ' Open the database connection
            conn.Open()

            ' SQL Insert query to save the data
            Dim query As String = "INSERT INTO EmployeeDetails (EmployeeID, Name, PhoneNumber, Address, DOJ, DOB, Role) " & _
                                  "VALUES (@EmployeeID, @Name, @PhoneNumber, @Address, @DOJ, @DOB, @Role)"

            ' Create a command object to execute the SQL query
            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters to the SQL query
            cmd.Parameters.AddWithValue("@EmployeeID", IDTextBox.Text)
            cmd.Parameters.AddWithValue("@Name", NameTextBox.Text)
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
            cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@DOJ", DOJDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@Role", RoleComboBox.SelectedItem.ToString())

            ' Execute the query
            cmd.ExecuteNonQuery()

            ' Show success message
            MessageBox.Show("Employee details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub
End Class
