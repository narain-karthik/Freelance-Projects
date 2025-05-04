<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblDOJ = New System.Windows.Forms.Label()
        Me.dtpDOJ = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(40, 37)
        Me.lblEmployeeID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(91, 17)
        Me.lblEmployeeID.TabIndex = 0
        Me.lblEmployeeID.Text = "Employee ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(200, 33)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(265, 22)
        Me.txtEmployeeID.TabIndex = 1
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(40, 86)
        Me.lblEmployeeName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(115, 17)
        Me.lblEmployeeName.TabIndex = 2
        Me.lblEmployeeName.Text = "Employee Name:"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(200, 82)
        Me.txtEmployeeName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(265, 22)
        Me.txtEmployeeName.TabIndex = 3
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(40, 135)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(114, 17)
        Me.lblContactNumber.TabIndex = 4
        Me.lblContactNumber.Text = "Contact Number:"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(200, 132)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(265, 22)
        Me.txtContactNumber.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(40, 185)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 17)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(200, 181)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(265, 48)
        Me.txtAddress.TabIndex = 7
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(40, 246)
        Me.lblSalary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(52, 17)
        Me.lblSalary.TabIndex = 8
        Me.lblSalary.Text = "Salary:"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(200, 242)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(265, 22)
        Me.txtSalary.TabIndex = 9
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(40, 295)
        Me.lblDOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(91, 17)
        Me.lblDOB.TabIndex = 10
        Me.lblDOB.Text = "Date of Birth:"
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(200, 292)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(265, 22)
        Me.dtpDOB.TabIndex = 11
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(40, 345)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(60, 17)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = "Gender:"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(200, 341)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(265, 24)
        Me.cmbGender.TabIndex = 13
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(40, 394)
        Me.lblPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(58, 17)
        Me.lblPosition.TabIndex = 14
        Me.lblPosition.Text = "Position"
        '
        'lblDOJ
        '
        Me.lblDOJ.AutoSize = True
        Me.lblDOJ.Location = New System.Drawing.Point(40, 443)
        Me.lblDOJ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOJ.Name = "lblDOJ"
        Me.lblDOJ.Size = New System.Drawing.Size(107, 17)
        Me.lblDOJ.TabIndex = 16
        Me.lblDOJ.Text = "Date of Joining:"
        '
        'dtpDOJ
        '
        Me.dtpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOJ.Location = New System.Drawing.Point(200, 439)
        Me.dtpDOJ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDOJ.Name = "dtpDOJ"
        Me.dtpDOJ.Size = New System.Drawing.Size(265, 22)
        Me.dtpDOJ.TabIndex = 17
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(200, 492)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 37)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PositionComboBox
        '
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Items.AddRange(New Object() {"HR", "Staff", "Cashier ", " Stocker", "Manager"})
        Me.PositionComboBox.Location = New System.Drawing.Point(200, 394)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(265, 24)
        Me.PositionComboBox.TabIndex = 19
        '
        'EmplyoeeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 554)
        Me.Controls.Add(Me.PositionComboBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpDOJ)
        Me.Controls.Add(Me.lblDOJ)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EmplyoeeDetails"
        Me.Text = "Employee Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblSalary As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblDOB As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents lblGender As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblDOJ As Label
    Friend WithEvents dtpDOJ As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents PositionComboBox As System.Windows.Forms.ComboBox
End Class
