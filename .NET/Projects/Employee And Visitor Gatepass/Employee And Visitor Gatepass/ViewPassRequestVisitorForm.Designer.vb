<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPassRequestVisitorForm
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
        Me.GatepassDataSet2 = New Employee_And_Visitor_Gatepass.GatepassDataSet2()
        Me.PassRequestVisitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PassRequestVisitorTableAdapter = New Employee_And_Visitor_Gatepass.GatepassDataSet2TableAdapters.PassRequestVisitorTableAdapter()
        Me.VisitorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitorContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitorIDProofDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurposeOfVisitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitingPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationPlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatepassDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassRequestVisitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitorIDDataGridViewTextBoxColumn, Me.VisitorNameDataGridViewTextBoxColumn, Me.VisitorContactDataGridViewTextBoxColumn, Me.VisitorIDProofDataGridViewTextBoxColumn, Me.PurposeOfVisitDataGridViewTextBoxColumn, Me.VisitingPersonDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DestinationPlaceDataGridViewTextBoxColumn, Me.VisitDateDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn, Me.EndTimeDataGridViewTextBoxColumn, Me.TransportModeDataGridViewTextBoxColumn, Me.ApprovedByDataGridViewTextBoxColumn, Me.ApprovalStatusDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PassRequestVisitorBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1169, 355)
        Me.DataGridView1.TabIndex = 0
        '
        'GatepassDataSet2
        '
        Me.GatepassDataSet2.DataSetName = "GatepassDataSet2"
        Me.GatepassDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PassRequestVisitorBindingSource
        '
        Me.PassRequestVisitorBindingSource.DataMember = "PassRequestVisitor"
        Me.PassRequestVisitorBindingSource.DataSource = Me.GatepassDataSet2
        '
        'PassRequestVisitorTableAdapter
        '
        Me.PassRequestVisitorTableAdapter.ClearBeforeFill = True
        '
        'VisitorIDDataGridViewTextBoxColumn
        '
        Me.VisitorIDDataGridViewTextBoxColumn.DataPropertyName = "VisitorID"
        Me.VisitorIDDataGridViewTextBoxColumn.HeaderText = "VisitorID"
        Me.VisitorIDDataGridViewTextBoxColumn.Name = "VisitorIDDataGridViewTextBoxColumn"
        Me.VisitorIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VisitorNameDataGridViewTextBoxColumn
        '
        Me.VisitorNameDataGridViewTextBoxColumn.DataPropertyName = "VisitorName"
        Me.VisitorNameDataGridViewTextBoxColumn.HeaderText = "VisitorName"
        Me.VisitorNameDataGridViewTextBoxColumn.Name = "VisitorNameDataGridViewTextBoxColumn"
        '
        'VisitorContactDataGridViewTextBoxColumn
        '
        Me.VisitorContactDataGridViewTextBoxColumn.DataPropertyName = "VisitorContact"
        Me.VisitorContactDataGridViewTextBoxColumn.HeaderText = "VisitorContact"
        Me.VisitorContactDataGridViewTextBoxColumn.Name = "VisitorContactDataGridViewTextBoxColumn"
        '
        'VisitorIDProofDataGridViewTextBoxColumn
        '
        Me.VisitorIDProofDataGridViewTextBoxColumn.DataPropertyName = "VisitorIDProof"
        Me.VisitorIDProofDataGridViewTextBoxColumn.HeaderText = "VisitorIDProof"
        Me.VisitorIDProofDataGridViewTextBoxColumn.Name = "VisitorIDProofDataGridViewTextBoxColumn"
        '
        'PurposeOfVisitDataGridViewTextBoxColumn
        '
        Me.PurposeOfVisitDataGridViewTextBoxColumn.DataPropertyName = "PurposeOfVisit"
        Me.PurposeOfVisitDataGridViewTextBoxColumn.HeaderText = "PurposeOfVisit"
        Me.PurposeOfVisitDataGridViewTextBoxColumn.Name = "PurposeOfVisitDataGridViewTextBoxColumn"
        '
        'VisitingPersonDataGridViewTextBoxColumn
        '
        Me.VisitingPersonDataGridViewTextBoxColumn.DataPropertyName = "VisitingPerson"
        Me.VisitingPersonDataGridViewTextBoxColumn.HeaderText = "VisitingPerson"
        Me.VisitingPersonDataGridViewTextBoxColumn.Name = "VisitingPersonDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'DestinationPlaceDataGridViewTextBoxColumn
        '
        Me.DestinationPlaceDataGridViewTextBoxColumn.DataPropertyName = "DestinationPlace"
        Me.DestinationPlaceDataGridViewTextBoxColumn.HeaderText = "DestinationPlace"
        Me.DestinationPlaceDataGridViewTextBoxColumn.Name = "DestinationPlaceDataGridViewTextBoxColumn"
        '
        'VisitDateDataGridViewTextBoxColumn
        '
        Me.VisitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate"
        Me.VisitDateDataGridViewTextBoxColumn.HeaderText = "VisitDate"
        Me.VisitDateDataGridViewTextBoxColumn.Name = "VisitDateDataGridViewTextBoxColumn"
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
        'ViewPassRequestVisitorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 355)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewPassRequestVisitorForm"
        Me.Text = "ViewPassRequestVisitorForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatepassDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassRequestVisitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GatepassDataSet2 As Employee_And_Visitor_Gatepass.GatepassDataSet2
    Friend WithEvents PassRequestVisitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PassRequestVisitorTableAdapter As Employee_And_Visitor_Gatepass.GatepassDataSet2TableAdapters.PassRequestVisitorTableAdapter
    Friend WithEvents VisitorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitorNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitorContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitorIDProofDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurposeOfVisitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitingPersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinationPlaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransportModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApprovedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApprovalStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
