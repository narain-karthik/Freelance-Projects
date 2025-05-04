<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassRequestVisitorForm
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
        Me.lblVisitorName = New System.Windows.Forms.Label()
        Me.txtVisitorName = New System.Windows.Forms.TextBox()
        Me.lblVisitorContact = New System.Windows.Forms.Label()
        Me.txtVisitorContact = New System.Windows.Forms.TextBox()
        Me.lblVisitorIDProof = New System.Windows.Forms.Label()
        Me.txtVisitorIDProof = New System.Windows.Forms.TextBox()
        Me.lblPurposeOfVisit = New System.Windows.Forms.Label()
        Me.txtPurposeOfVisit = New System.Windows.Forms.TextBox()
        Me.lblVisitingPerson = New System.Windows.Forms.Label()
        Me.cmbVisitingPerson = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.lblDestinationPlace = New System.Windows.Forms.Label()
        Me.txtDestinationPlace = New System.Windows.Forms.TextBox()
        Me.lblVisitDate = New System.Windows.Forms.Label()
        Me.dtpVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.lblTransportMode = New System.Windows.Forms.Label()
        Me.cmbTransportMode = New System.Windows.Forms.ComboBox()
        Me.lblApprovedBy = New System.Windows.Forms.Label()
        Me.cmbApprovedBy = New System.Windows.Forms.ComboBox()
        Me.lblApprovalStatus = New System.Windows.Forms.Label()
        Me.txtApprovalStatus = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVisitorName
        '
        Me.lblVisitorName.AutoSize = True
        Me.lblVisitorName.Location = New System.Drawing.Point(30, 30)
        Me.lblVisitorName.Name = "lblVisitorName"
        Me.lblVisitorName.Size = New System.Drawing.Size(92, 17)
        Me.lblVisitorName.TabIndex = 0
        Me.lblVisitorName.Text = "Visitor Name:"
        '
        'txtVisitorName
        '
        Me.txtVisitorName.Location = New System.Drawing.Point(150, 27)
        Me.txtVisitorName.Name = "txtVisitorName"
        Me.txtVisitorName.Size = New System.Drawing.Size(200, 22)
        Me.txtVisitorName.TabIndex = 1
        '
        'lblVisitorContact
        '
        Me.lblVisitorContact.AutoSize = True
        Me.lblVisitorContact.Location = New System.Drawing.Point(30, 70)
        Me.lblVisitorContact.Name = "lblVisitorContact"
        Me.lblVisitorContact.Size = New System.Drawing.Size(129, 17)
        Me.lblVisitorContact.TabIndex = 2
        Me.lblVisitorContact.Text = "Visitor Contact No.:"
        '
        'txtVisitorContact
        '
        Me.txtVisitorContact.Location = New System.Drawing.Point(150, 70)
        Me.txtVisitorContact.Name = "txtVisitorContact"
        Me.txtVisitorContact.Size = New System.Drawing.Size(200, 22)
        Me.txtVisitorContact.TabIndex = 3
        '
        'lblVisitorIDProof
        '
        Me.lblVisitorIDProof.AutoSize = True
        Me.lblVisitorIDProof.Location = New System.Drawing.Point(30, 110)
        Me.lblVisitorIDProof.Name = "lblVisitorIDProof"
        Me.lblVisitorIDProof.Size = New System.Drawing.Size(106, 17)
        Me.lblVisitorIDProof.TabIndex = 4
        Me.lblVisitorIDProof.Text = "Visitor ID Proof:"
        '
        'txtVisitorIDProof
        '
        Me.txtVisitorIDProof.Location = New System.Drawing.Point(150, 107)
        Me.txtVisitorIDProof.Name = "txtVisitorIDProof"
        Me.txtVisitorIDProof.Size = New System.Drawing.Size(200, 22)
        Me.txtVisitorIDProof.TabIndex = 5
        '
        'lblPurposeOfVisit
        '
        Me.lblPurposeOfVisit.AutoSize = True
        Me.lblPurposeOfVisit.Location = New System.Drawing.Point(30, 150)
        Me.lblPurposeOfVisit.Name = "lblPurposeOfVisit"
        Me.lblPurposeOfVisit.Size = New System.Drawing.Size(111, 17)
        Me.lblPurposeOfVisit.TabIndex = 6
        Me.lblPurposeOfVisit.Text = "Purpose of Visit:"
        '
        'txtPurposeOfVisit
        '
        Me.txtPurposeOfVisit.Location = New System.Drawing.Point(150, 147)
        Me.txtPurposeOfVisit.Multiline = True
        Me.txtPurposeOfVisit.Name = "txtPurposeOfVisit"
        Me.txtPurposeOfVisit.Size = New System.Drawing.Size(300, 60)
        Me.txtPurposeOfVisit.TabIndex = 7
        '
        'lblVisitingPerson
        '
        Me.lblVisitingPerson.AutoSize = True
        Me.lblVisitingPerson.Location = New System.Drawing.Point(30, 230)
        Me.lblVisitingPerson.Name = "lblVisitingPerson"
        Me.lblVisitingPerson.Size = New System.Drawing.Size(106, 17)
        Me.lblVisitingPerson.TabIndex = 8
        Me.lblVisitingPerson.Text = "Visiting Person:"
        '
        'cmbVisitingPerson
        '
        Me.cmbVisitingPerson.Items.AddRange(New Object() {"Family", "Friend", "Other"})
        Me.cmbVisitingPerson.Location = New System.Drawing.Point(150, 227)
        Me.cmbVisitingPerson.Name = "cmbVisitingPerson"
        Me.cmbVisitingPerson.Size = New System.Drawing.Size(200, 24)
        Me.cmbVisitingPerson.TabIndex = 9
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(30, 270)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(86, 17)
        Me.lblDepartment.TabIndex = 10
        Me.lblDepartment.Text = "Department:"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Items.AddRange(New Object() {"HR", "IT", "Manager", "Working Staff"})
        Me.cmbDepartment.Location = New System.Drawing.Point(150, 267)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(200, 24)
        Me.cmbDepartment.TabIndex = 11
        '
        'lblDestinationPlace
        '
        Me.lblDestinationPlace.AutoSize = True
        Me.lblDestinationPlace.Location = New System.Drawing.Point(30, 310)
        Me.lblDestinationPlace.Name = "lblDestinationPlace"
        Me.lblDestinationPlace.Size = New System.Drawing.Size(122, 17)
        Me.lblDestinationPlace.TabIndex = 12
        Me.lblDestinationPlace.Text = "Destination Place:"
        '
        'txtDestinationPlace
        '
        Me.txtDestinationPlace.Location = New System.Drawing.Point(150, 307)
        Me.txtDestinationPlace.Name = "txtDestinationPlace"
        Me.txtDestinationPlace.Size = New System.Drawing.Size(200, 22)
        Me.txtDestinationPlace.TabIndex = 13
        '
        'lblVisitDate
        '
        Me.lblVisitDate.AutoSize = True
        Me.lblVisitDate.Location = New System.Drawing.Point(30, 350)
        Me.lblVisitDate.Name = "lblVisitDate"
        Me.lblVisitDate.Size = New System.Drawing.Size(72, 17)
        Me.lblVisitDate.TabIndex = 14
        Me.lblVisitDate.Text = "Visit Date:"
        '
        'dtpVisitDate
        '
        Me.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVisitDate.Location = New System.Drawing.Point(150, 347)
        Me.dtpVisitDate.Name = "dtpVisitDate"
        Me.dtpVisitDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpVisitDate.TabIndex = 15
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(30, 390)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(77, 17)
        Me.lblStartTime.TabIndex = 16
        Me.lblStartTime.Text = "Start Time:"
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(150, 387)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(200, 22)
        Me.dtpStartTime.TabIndex = 17
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(30, 430)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(72, 17)
        Me.lblEndTime.TabIndex = 18
        Me.lblEndTime.Text = "End Time:"
        '
        'dtpEndTime
        '
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(150, 427)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(200, 22)
        Me.dtpEndTime.TabIndex = 19
        '
        'lblTransportMode
        '
        Me.lblTransportMode.AutoSize = True
        Me.lblTransportMode.Location = New System.Drawing.Point(30, 470)
        Me.lblTransportMode.Name = "lblTransportMode"
        Me.lblTransportMode.Size = New System.Drawing.Size(113, 17)
        Me.lblTransportMode.TabIndex = 20
        Me.lblTransportMode.Text = "Transport Mode:"
        '
        'cmbTransportMode
        '
        Me.cmbTransportMode.Items.AddRange(New Object() {"Car", "Bike", "Auto"})
        Me.cmbTransportMode.Location = New System.Drawing.Point(150, 467)
        Me.cmbTransportMode.Name = "cmbTransportMode"
        Me.cmbTransportMode.Size = New System.Drawing.Size(200, 24)
        Me.cmbTransportMode.TabIndex = 21
        '
        'lblApprovedBy
        '
        Me.lblApprovedBy.AutoSize = True
        Me.lblApprovedBy.Location = New System.Drawing.Point(30, 510)
        Me.lblApprovedBy.Name = "lblApprovedBy"
        Me.lblApprovedBy.Size = New System.Drawing.Size(93, 17)
        Me.lblApprovedBy.TabIndex = 22
        Me.lblApprovedBy.Text = "Approved By:"
        '
        'cmbApprovedBy
        '
        Me.cmbApprovedBy.Items.AddRange(New Object() {"Approved", "Pending", "Rejected"})
        Me.cmbApprovedBy.Location = New System.Drawing.Point(150, 507)
        Me.cmbApprovedBy.Name = "cmbApprovedBy"
        Me.cmbApprovedBy.Size = New System.Drawing.Size(200, 24)
        Me.cmbApprovedBy.TabIndex = 23
        '
        'lblApprovalStatus
        '
        Me.lblApprovalStatus.AutoSize = True
        Me.lblApprovalStatus.Location = New System.Drawing.Point(30, 550)
        Me.lblApprovalStatus.Name = "lblApprovalStatus"
        Me.lblApprovalStatus.Size = New System.Drawing.Size(112, 17)
        Me.lblApprovalStatus.TabIndex = 24
        Me.lblApprovalStatus.Text = "Approval Status:"
        '
        'txtApprovalStatus
        '
        Me.txtApprovalStatus.Location = New System.Drawing.Point(150, 547)
        Me.txtApprovalStatus.Name = "txtApprovalStatus"
        Me.txtApprovalStatus.ReadOnly = True
        Me.txtApprovalStatus.Size = New System.Drawing.Size(200, 22)
        Me.txtApprovalStatus.TabIndex = 25
        Me.txtApprovalStatus.Text = "Pending" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(30, 590)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(68, 17)
        Me.lblRemarks.TabIndex = 26
        Me.lblRemarks.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(150, 587)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(300, 60)
        Me.txtRemarks.TabIndex = 27
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmit.Location = New System.Drawing.Point(200, 670)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 30)
        Me.btnSubmit.TabIndex = 28
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'PassRequestVisitorForm
        '
        Me.ClientSize = New System.Drawing.Size(550, 750)
        Me.Controls.Add(Me.lblVisitorName)
        Me.Controls.Add(Me.txtVisitorName)
        Me.Controls.Add(Me.lblVisitorContact)
        Me.Controls.Add(Me.txtVisitorContact)
        Me.Controls.Add(Me.lblVisitorIDProof)
        Me.Controls.Add(Me.txtVisitorIDProof)
        Me.Controls.Add(Me.lblPurposeOfVisit)
        Me.Controls.Add(Me.txtPurposeOfVisit)
        Me.Controls.Add(Me.lblVisitingPerson)
        Me.Controls.Add(Me.cmbVisitingPerson)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.lblDestinationPlace)
        Me.Controls.Add(Me.txtDestinationPlace)
        Me.Controls.Add(Me.lblVisitDate)
        Me.Controls.Add(Me.dtpVisitDate)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.dtpStartTime)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.lblTransportMode)
        Me.Controls.Add(Me.cmbTransportMode)
        Me.Controls.Add(Me.lblApprovedBy)
        Me.Controls.Add(Me.cmbApprovedBy)
        Me.Controls.Add(Me.lblApprovalStatus)
        Me.Controls.Add(Me.txtApprovalStatus)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "PassRequestVisitorForm"
        Me.Text = "Visitor Pass Request Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVisitorName As Label
    Friend WithEvents txtVisitorName As TextBox
    Friend WithEvents lblVisitorContact As Label
    Friend WithEvents txtVisitorContact As TextBox
    Friend WithEvents lblVisitorIDProof As Label
    Friend WithEvents txtVisitorIDProof As TextBox
    Friend WithEvents lblPurposeOfVisit As Label
    Friend WithEvents txtPurposeOfVisit As TextBox
    Friend WithEvents lblVisitingPerson As Label
    Friend WithEvents cmbVisitingPerson As ComboBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents lblDestinationPlace As Label
    Friend WithEvents txtDestinationPlace As TextBox
    Friend WithEvents lblVisitDate As Label
    Friend WithEvents dtpVisitDate As DateTimePicker
    Friend WithEvents lblStartTime As Label
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents lblEndTime As Label
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents lblTransportMode As Label
    Friend WithEvents cmbTransportMode As ComboBox
    Friend WithEvents lblApprovedBy As Label
    Friend WithEvents cmbApprovedBy As ComboBox
    Friend WithEvents lblApprovalStatus As Label
    Friend WithEvents txtApprovalStatus As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents btnSubmit As Button
End Class
