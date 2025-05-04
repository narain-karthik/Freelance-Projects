<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetailsForm
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

    Private components As System.ComponentModel.IContainer

    'Required by the Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.lblDOJ = New System.Windows.Forms.Label()
        Me.dtpDOJ = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitle.Location = New System.Drawing.Point(180, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(293, 46)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Employee Details"
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.Location = New System.Drawing.Point(50, 70)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeID.TabIndex = 1
        Me.lblEmployeeID.Text = "Employee ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.BackColor = System.Drawing.Color.LightGray
        Me.txtEmployeeID.Location = New System.Drawing.Point(200, 70)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(300, 22)
        Me.txtEmployeeID.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(50, 110)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(200, 110)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(300, 22)
        Me.txtName.TabIndex = 4
        '
        'lblDOB
        '
        Me.lblDOB.Location = New System.Drawing.Point(50, 150)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(100, 23)
        Me.lblDOB.TabIndex = 5
        Me.lblDOB.Text = "Date of Birth:"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(200, 150)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(300, 22)
        Me.dtpDOB.TabIndex = 6
        '
        'lblGender
        '
        Me.lblGender.Location = New System.Drawing.Point(50, 190)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(100, 23)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender:"
        '
        'cmbGender
        '
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(200, 190)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(300, 24)
        Me.cmbGender.TabIndex = 8
        '
        'lblContact
        '
        Me.lblContact.Location = New System.Drawing.Point(50, 230)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(100, 23)
        Me.lblContact.TabIndex = 9
        Me.lblContact.Text = "Contact Number:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(200, 230)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(300, 22)
        Me.txtContact.TabIndex = 10
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(50, 270)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 23)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email Address:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(200, 270)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(300, 22)
        Me.txtEmail.TabIndex = 12
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(50, 310)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(100, 23)
        Me.lblAddress.TabIndex = 13
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(200, 310)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(300, 50)
        Me.txtAddress.TabIndex = 14
        '
        'lblDepartment
        '
        Me.lblDepartment.Location = New System.Drawing.Point(50, 380)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(100, 23)
        Me.lblDepartment.TabIndex = 15
        Me.lblDepartment.Text = "Department:"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Items.AddRange(New Object() {"HR", "Sales", "IT", "Finance", "Operations"})
        Me.cmbDepartment.Location = New System.Drawing.Point(200, 380)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(300, 24)
        Me.cmbDepartment.TabIndex = 16
        '
        'lblDesignation
        '
        Me.lblDesignation.Location = New System.Drawing.Point(50, 420)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(100, 23)
        Me.lblDesignation.TabIndex = 17
        Me.lblDesignation.Text = "Designation:"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(200, 420)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(300, 22)
        Me.txtDesignation.TabIndex = 18
        '
        'lblDOJ
        '
        Me.lblDOJ.Location = New System.Drawing.Point(50, 460)
        Me.lblDOJ.Name = "lblDOJ"
        Me.lblDOJ.Size = New System.Drawing.Size(100, 23)
        Me.lblDOJ.TabIndex = 19
        Me.lblDOJ.Text = "Date of Joining:"
        '
        'dtpDOJ
        '
        Me.dtpDOJ.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOJ.Location = New System.Drawing.Point(200, 460)
        Me.dtpDOJ.Name = "dtpDOJ"
        Me.dtpDOJ.Size = New System.Drawing.Size(300, 22)
        Me.dtpDOJ.TabIndex = 20
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(120, 520)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 33)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(240, 520)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 33)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(360, 520)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 33)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'EmployeeDetailsForm
        '
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.lblDesignation)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.lblDOJ)
        Me.Controls.Add(Me.dtpDOJ)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "EmployeeDetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Details Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblEmployeeID As Label
    Private WithEvents txtEmployeeID As TextBox
    Private WithEvents lblName As Label
    Private WithEvents txtName As TextBox
    Private WithEvents lblDOB As Label
    Private WithEvents dtpDOB As DateTimePicker
    Private WithEvents lblGender As Label
    Private WithEvents cmbGender As ComboBox
    Private WithEvents lblContact As Label
    Private WithEvents txtContact As TextBox
    Private WithEvents lblEmail As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents lblAddress As Label
    Private WithEvents txtAddress As TextBox
    Private WithEvents lblDepartment As Label
    Private WithEvents cmbDepartment As ComboBox
    Private WithEvents lblDesignation As Label
    Private WithEvents txtDesignation As TextBox
    Private WithEvents lblDOJ As Label
    Private WithEvents dtpDOJ As DateTimePicker
    Private WithEvents btnSave As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnClose As Button
End Class
