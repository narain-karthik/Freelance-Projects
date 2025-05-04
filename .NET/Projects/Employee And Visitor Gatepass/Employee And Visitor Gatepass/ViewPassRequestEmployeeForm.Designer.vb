<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPassRequestEmployeeForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GatepassDataSet1 = New Employee_And_Visitor_Gatepass.GatepassDataSet1()
        Me.PassRequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PassRequestTableAdapter = New Employee_And_Visitor_Gatepass.GatepassDataSet1TableAdapters.PassRequestTableAdapter()
        Me.PassIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurposeOfVisitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationPlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfRequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatepassDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassRequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PassIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.PurposeOfVisitDataGridViewTextBoxColumn, Me.DestinationPlaceDataGridViewTextBoxColumn, Me.DateOfRequestDataGridViewTextBoxColumn, Me.PassStartDateDataGridViewTextBoxColumn, Me.PassEndDateDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn, Me.EndTimeDataGridViewTextBoxColumn, Me.TransportModeDataGridViewTextBoxColumn, Me.ApprovedByDataGridViewTextBoxColumn, Me.ApprovalStatusDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PassRequestBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1170, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'GatepassDataSet1
        '
        Me.GatepassDataSet1.DataSetName = "GatepassDataSet1"
        Me.GatepassDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PassRequestBindingSource
        '
        Me.PassRequestBindingSource.DataMember = "PassRequest"
        Me.PassRequestBindingSource.DataSource = Me.GatepassDataSet1
        '
        'PassRequestTableAdapter
        '
        Me.PassRequestTableAdapter.ClearBeforeFill = True
        '
        'PassIDDataGridViewTextBoxColumn
        '
        Me.PassIDDataGridViewTextBoxColumn.DataPropertyName = "PassID"
        Me.PassIDDataGridViewTextBoxColumn.HeaderText = "PassID"
        Me.PassIDDataGridViewTextBoxColumn.Name = "PassIDDataGridViewTextBoxColumn"
        Me.PassIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'DesignationDataGridViewTextBoxColumn
        '
        Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.HeaderText = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'PurposeOfVisitDataGridViewTextBoxColumn
        '
        Me.PurposeOfVisitDataGridViewTextBoxColumn.DataPropertyName = "PurposeOfVisit"
        Me.PurposeOfVisitDataGridViewTextBoxColumn.HeaderText = "PurposeOfVisit"
        Me.PurposeOfVisitDataGridViewTextBoxColumn.Name = "PurposeOfVisitDataGridViewTextBoxColumn"
        '
        'DestinationPlaceDataGridViewTextBoxColumn
        '
        Me.DestinationPlaceDataGridViewTextBoxColumn.DataPropertyName = "DestinationPlace"
        Me.DestinationPlaceDataGridViewTextBoxColumn.HeaderText = "DestinationPlace"
        Me.DestinationPlaceDataGridViewTextBoxColumn.Name = "DestinationPlaceDataGridViewTextBoxColumn"
        '
        'DateOfRequestDataGridViewTextBoxColumn
        '
        Me.DateOfRequestDataGridViewTextBoxColumn.DataPropertyName = "DateOfRequest"
        Me.DateOfRequestDataGridViewTextBoxColumn.HeaderText = "DateOfRequest"
        Me.DateOfRequestDataGridViewTextBoxColumn.Name = "DateOfRequestDataGridViewTextBoxColumn"
        '
        'PassStartDateDataGridViewTextBoxColumn
        '
        Me.PassStartDateDataGridViewTextBoxColumn.DataPropertyName = "PassStartDate"
        Me.PassStartDateDataGridViewTextBoxColumn.HeaderText = "PassStartDate"
        Me.PassStartDateDataGridViewTextBoxColumn.Name = "PassStartDateDataGridViewTextBoxColumn"
        '
        'PassEndDateDataGridViewTextBoxColumn
        '
        Me.PassEndDateDataGridViewTextBoxColumn.DataPropertyName = "PassEndDate"
        Me.PassEndDateDataGridViewTextBoxColumn.HeaderText = "PassEndDate"
        Me.PassEndDateDataGridViewTextBoxColumn.Name = "PassEndDateDataGridViewTextBoxColumn"
        '
        'StartTimeDataGridViewTextBoxColumn
        '
        Me.StartTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.HeaderText = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn"
        '
        'EndTimeDataGridViewTextBoxColumn
        '
        Me.EndTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime"
        Me.EndTimeDataGridViewTextBoxColumn.HeaderText = "EndTime"
        Me.EndTimeDataGridViewTextBoxColumn.Name = "EndTimeDataGridViewTextBoxColumn"
        '
        'TransportModeDataGridViewTextBoxColumn
        '
        Me.TransportModeDataGridViewTextBoxColumn.DataPropertyName = "TransportMode"
        Me.TransportModeDataGridViewTextBoxColumn.HeaderText = "TransportMode"
        Me.TransportModeDataGridViewTextBoxColumn.Name = "TransportModeDataGridViewTextBoxColumn"
        '
        'ApprovedByDataGridViewTextBoxColumn
        '
        Me.ApprovedByDataGridViewTextBoxColumn.DataPropertyName = "ApprovedBy"
        Me.ApprovedByDataGridViewTextBoxColumn.HeaderText = "ApprovedBy"
        Me.ApprovedByDataGridViewTextBoxColumn.Name = "ApprovedByDataGridViewTextBoxColumn"
        '
        'ApprovalStatusDataGridViewTextBoxColumn
        '
        Me.ApprovalStatusDataGridViewTextBoxColumn.DataPropertyName = "ApprovalStatus"
        Me.ApprovalStatusDataGridViewTextBoxColumn.HeaderText = "ApprovalStatus"
        Me.ApprovalStatusDataGridViewTextBoxColumn.Name = "ApprovalStatusDataGridViewTextBoxColumn"
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'ViewPassRequestEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 426)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewPassRequestEmployeeForm"
        Me.Text = "ViewPassRequestEmployeeForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatepassDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassRequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GatepassDataSet1 As Employee_And_Visitor_Gatepass.GatepassDataSet1
    Friend WithEvents PassRequestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PassRequestTableAdapter As Employee_And_Visitor_Gatepass.GatepassDataSet1TableAdapters.PassRequestTableAdapter
    Friend WithEvents PassIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurposeOfVisitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinationPlaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfRequestDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassStartDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassEndDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransportModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApprovedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApprovalStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
