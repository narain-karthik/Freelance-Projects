<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetails
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelSNo = New System.Windows.Forms.Label()
        Me.LabelCustomerID = New System.Windows.Forms.Label()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.LabelCustomerAddress = New System.Windows.Forms.Label()
        Me.LabelPhoneNumber = New System.Windows.Forms.Label()
        Me.LabelEmailID = New System.Windows.Forms.Label()
        Me.TextBoxSNo = New System.Windows.Forms.TextBox()
        Me.TextBoxCustomerID = New System.Windows.Forms.TextBox()
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox()
        Me.TextBoxCustomerAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxEmailID = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DataGridViewCustomers = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelSNo
        '
        Me.LabelSNo.AutoSize = True
        Me.LabelSNo.Location = New System.Drawing.Point(12, 20)
        Me.LabelSNo.Name = "LabelSNo"
        Me.LabelSNo.Size = New System.Drawing.Size(43, 17)
        Me.LabelSNo.TabIndex = 0
        Me.LabelSNo.Text = "S.No:"
        '
        'LabelCustomerID
        '
        Me.LabelCustomerID.AutoSize = True
        Me.LabelCustomerID.Location = New System.Drawing.Point(12, 50)
        Me.LabelCustomerID.Name = "LabelCustomerID"
        Me.LabelCustomerID.Size = New System.Drawing.Size(89, 17)
        Me.LabelCustomerID.TabIndex = 1
        Me.LabelCustomerID.Text = "Customer ID:"
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Location = New System.Drawing.Point(12, 80)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(113, 17)
        Me.LabelCustomerName.TabIndex = 2
        Me.LabelCustomerName.Text = "Customer Name:"
        '
        'LabelCustomerAddress
        '
        Me.LabelCustomerAddress.AutoSize = True
        Me.LabelCustomerAddress.Location = New System.Drawing.Point(12, 110)
        Me.LabelCustomerAddress.Name = "LabelCustomerAddress"
        Me.LabelCustomerAddress.Size = New System.Drawing.Size(128, 17)
        Me.LabelCustomerAddress.TabIndex = 3
        Me.LabelCustomerAddress.Text = "Customer Address:"
        '
        'LabelPhoneNumber
        '
        Me.LabelPhoneNumber.AutoSize = True
        Me.LabelPhoneNumber.Location = New System.Drawing.Point(12, 140)
        Me.LabelPhoneNumber.Name = "LabelPhoneNumber"
        Me.LabelPhoneNumber.Size = New System.Drawing.Size(107, 17)
        Me.LabelPhoneNumber.TabIndex = 4
        Me.LabelPhoneNumber.Text = "Phone Number:"
        '
        'LabelEmailID
        '
        Me.LabelEmailID.AutoSize = True
        Me.LabelEmailID.Location = New System.Drawing.Point(12, 170)
        Me.LabelEmailID.Name = "LabelEmailID"
        Me.LabelEmailID.Size = New System.Drawing.Size(63, 17)
        Me.LabelEmailID.TabIndex = 5
        Me.LabelEmailID.Text = "Email ID:"
        '
        'TextBoxSNo
        '
        Me.TextBoxSNo.Location = New System.Drawing.Point(130, 17)
        Me.TextBoxSNo.Name = "TextBoxSNo"
        Me.TextBoxSNo.ReadOnly = True
        Me.TextBoxSNo.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxSNo.TabIndex = 6
        '
        'TextBoxCustomerID
        '
        Me.TextBoxCustomerID.Location = New System.Drawing.Point(130, 47)
        Me.TextBoxCustomerID.Name = "TextBoxCustomerID"
        Me.TextBoxCustomerID.ReadOnly = True
        Me.TextBoxCustomerID.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCustomerID.TabIndex = 7
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(130, 77)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxCustomerName.TabIndex = 8
        '
        'TextBoxCustomerAddress
        '
        Me.TextBoxCustomerAddress.Location = New System.Drawing.Point(130, 107)
        Me.TextBoxCustomerAddress.Name = "TextBoxCustomerAddress"
        Me.TextBoxCustomerAddress.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxCustomerAddress.TabIndex = 9
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(130, 137)
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(150, 22)
        Me.TextBoxPhoneNumber.TabIndex = 10
        '
        'TextBoxEmailID
        '
        Me.TextBoxEmailID.Location = New System.Drawing.Point(130, 167)
        Me.TextBoxEmailID.Name = "TextBoxEmailID"
        Me.TextBoxEmailID.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxEmailID.TabIndex = 11
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(130, 200)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(80, 30)
        Me.ButtonAdd.TabIndex = 12
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(220, 200)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(80, 30)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'DataGridViewCustomers
        '
        Me.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomers.Location = New System.Drawing.Point(12, 240)
        Me.DataGridViewCustomers.Name = "DataGridViewCustomers"
        Me.DataGridViewCustomers.Size = New System.Drawing.Size(576, 200)
        Me.DataGridViewCustomers.TabIndex = 14
        '
        'CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.DataGridViewCustomers)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxEmailID)
        Me.Controls.Add(Me.TextBoxPhoneNumber)
        Me.Controls.Add(Me.TextBoxCustomerAddress)
        Me.Controls.Add(Me.TextBoxCustomerName)
        Me.Controls.Add(Me.TextBoxCustomerID)
        Me.Controls.Add(Me.TextBoxSNo)
        Me.Controls.Add(Me.LabelEmailID)
        Me.Controls.Add(Me.LabelPhoneNumber)
        Me.Controls.Add(Me.LabelCustomerAddress)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Controls.Add(Me.LabelCustomerID)
        Me.Controls.Add(Me.LabelSNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CustomerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details - Painting Management System"
        CType(Me.DataGridViewCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSNo As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerID As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerName As System.Windows.Forms.Label
    Friend WithEvents LabelCustomerAddress As System.Windows.Forms.Label
    Friend WithEvents LabelPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents LabelEmailID As System.Windows.Forms.Label
    Friend WithEvents TextBoxSNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmailID As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewCustomers As System.Windows.Forms.DataGridView
End Class