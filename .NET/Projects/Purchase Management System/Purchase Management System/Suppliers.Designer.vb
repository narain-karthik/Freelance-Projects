<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers
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

    Friend WithEvents lblSupplierID As Label
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblGST As Label
    Friend WithEvents txtGST As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSupplierID
        '
        Me.lblSupplierID.Location = New System.Drawing.Point(30, 30)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(100, 23)
        Me.lblSupplierID.TabIndex = 0
        Me.lblSupplierID.Text = "Supplier ID"
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Location = New System.Drawing.Point(150, 30)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.ReadOnly = True
        Me.txtSupplierID.Size = New System.Drawing.Size(100, 22)
        Me.txtSupplierID.TabIndex = 1
        '
        'lblSupplierName
        '
        Me.lblSupplierName.Location = New System.Drawing.Point(30, 70)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(100, 23)
        Me.lblSupplierName.TabIndex = 2
        Me.lblSupplierName.Text = "Supplier Name"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(150, 70)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(200, 22)
        Me.txtSupplierName.TabIndex = 3
        '
        'lblPhone
        '
        Me.lblPhone.Location = New System.Drawing.Point(30, 110)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 23)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 110)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 22)
        Me.txtPhone.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(30, 150)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 23)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 150)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 7
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(30, 190)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(100, 23)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(150, 190)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 50)
        Me.txtAddress.TabIndex = 9
        '
        'lblGST
        '
        Me.lblGST.Location = New System.Drawing.Point(30, 260)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(100, 23)
        Me.lblGST.TabIndex = 10
        Me.lblGST.Text = "GST Number (Optional)"
        '
        'txtGST
        '
        Me.txtGST.Location = New System.Drawing.Point(150, 260)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(200, 22)
        Me.txtGST.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(150, 310)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(250, 310)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        '
        'Suppliers
        '
        Me.ClientSize = New System.Drawing.Size(420, 370)
        Me.Controls.Add(Me.lblSupplierID)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.lblSupplierName)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblGST)
        Me.Controls.Add(Me.txtGST)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Suppliers"
        Me.Text = "Supplier Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
