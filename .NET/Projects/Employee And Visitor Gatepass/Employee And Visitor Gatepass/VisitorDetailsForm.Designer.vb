<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitorDetailsForm
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
        Me.txtVisitorName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPurposeOfVisit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPersonToMeet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpVisitTime = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpExitTime = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbIDProofType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIDProofNumber = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visitor Name"
        '
        'txtVisitorName
        '
        Me.txtVisitorName.Location = New System.Drawing.Point(180, 30)
        Me.txtVisitorName.Name = "txtVisitorName"
        Me.txtVisitorName.Size = New System.Drawing.Size(220, 30)
        Me.txtVisitorName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(180, 70)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(220, 31)
        Me.cmbGender.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contact Number"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(180, 110)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(220, 30)
        Me.txtContactNumber.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(180, 150)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(220, 30)
        Me.txtEmail.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(180, 190)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(220, 30)
        Me.txtAddress.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Purpose of Visit"
        '
        'txtPurposeOfVisit
        '
        Me.txtPurposeOfVisit.Location = New System.Drawing.Point(180, 230)
        Me.txtPurposeOfVisit.Name = "txtPurposeOfVisit"
        Me.txtPurposeOfVisit.Size = New System.Drawing.Size(220, 30)
        Me.txtPurposeOfVisit.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Person to Meet"
        '
        'txtPersonToMeet
        '
        Me.txtPersonToMeet.Location = New System.Drawing.Point(180, 270)
        Me.txtPersonToMeet.Name = "txtPersonToMeet"
        Me.txtPersonToMeet.Size = New System.Drawing.Size(220, 30)
        Me.txtPersonToMeet.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Visit Date"
        '
        'dtpVisitDate
        '
        Me.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVisitDate.Location = New System.Drawing.Point(180, 310)
        Me.dtpVisitDate.Name = "dtpVisitDate"
        Me.dtpVisitDate.Size = New System.Drawing.Size(200, 30)
        Me.dtpVisitDate.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Visit Time"
        '
        'dtpVisitTime
        '
        Me.dtpVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpVisitTime.Location = New System.Drawing.Point(180, 350)
        Me.dtpVisitTime.Name = "dtpVisitTime"
        Me.dtpVisitTime.ShowUpDown = True
        Me.dtpVisitTime.Size = New System.Drawing.Size(200, 30)
        Me.dtpVisitTime.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 390)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 23)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Exit Time"
        '
        'dtpExitTime
        '
        Me.dtpExitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpExitTime.Location = New System.Drawing.Point(180, 390)
        Me.dtpExitTime.Name = "dtpExitTime"
        Me.dtpExitTime.ShowUpDown = True
        Me.dtpExitTime.Size = New System.Drawing.Size(200, 30)
        Me.dtpExitTime.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 430)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 23)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ID Proof Type"
        '
        'cmbIDProofType
        '
        Me.cmbIDProofType.Items.AddRange(New Object() {"Aadhar", "Driving License", "PAN Card", "Passport"})
        Me.cmbIDProofType.Location = New System.Drawing.Point(180, 430)
        Me.cmbIDProofType.Name = "cmbIDProofType"
        Me.cmbIDProofType.Size = New System.Drawing.Size(220, 31)
        Me.cmbIDProofType.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 470)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "ID Proof Number"
        '
        'txtIDProofNumber
        '
        Me.txtIDProofNumber.Location = New System.Drawing.Point(180, 470)
        Me.txtIDProofNumber.Name = "txtIDProofNumber"
        Me.txtIDProofNumber.Size = New System.Drawing.Size(220, 30)
        Me.txtIDProofNumber.TabIndex = 23
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(180, 520)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'VisitorDetailsForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 650)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVisitorName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPurposeOfVisit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPersonToMeet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpVisitDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpVisitTime)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpExitTime)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbIDProofType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtIDProofNumber)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Name = "VisitorDetailsForm"
        Me.Text = "Visitor Details Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtVisitorName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPurposeOfVisit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPersonToMeet As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpVisitDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpVisitTime As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpExitTime As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbIDProofType As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIDProofNumber As TextBox
    Friend WithEvents btnSave As Button
End Class
