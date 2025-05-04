<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewVisitorDetailsForm
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
        Me.GatepassDataSet3 = New Employee_And_Visitor_Gatepass.GatepassDataSet3()
        Me.VisitorDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitorDetailsTableAdapter = New Employee_And_Visitor_Gatepass.GatepassDataSet3TableAdapters.VisitorDetailsTableAdapter()
        Me.VisitorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurposeOfVisitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonToMeetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExitTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProofTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProofNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatepassDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitorIDDataGridViewTextBoxColumn, Me.VisitorNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PurposeOfVisitDataGridViewTextBoxColumn, Me.PersonToMeetDataGridViewTextBoxColumn, Me.VisitDateDataGridViewTextBoxColumn, Me.VisitTimeDataGridViewTextBoxColumn, Me.ExitTimeDataGridViewTextBoxColumn, Me.IDProofTypeDataGridViewTextBoxColumn, Me.IDProofNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VisitorDetailsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1191, 393)
        Me.DataGridView1.TabIndex = 0
        '
        'GatepassDataSet3
        '
        Me.GatepassDataSet3.DataSetName = "GatepassDataSet3"
        Me.GatepassDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitorDetailsBindingSource
        '
        Me.VisitorDetailsBindingSource.DataMember = "VisitorDetails"
        Me.VisitorDetailsBindingSource.DataSource = Me.GatepassDataSet3
        '
        'VisitorDetailsTableAdapter
        '
        Me.VisitorDetailsTableAdapter.ClearBeforeFill = True
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
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PurposeOfVisitDataGridViewTextBoxColumn
        '
        Me.PurposeOfVisitDataGridViewTextBoxColumn.DataPropertyName = "PurposeOfVisit"
        Me.PurposeOfVisitDataGridViewTextBoxColumn.HeaderText = "PurposeOfVisit"
        Me.PurposeOfVisitDataGridViewTextBoxColumn.Name = "PurposeOfVisitDataGridViewTextBoxColumn"
        '
        'PersonToMeetDataGridViewTextBoxColumn
        '
        Me.PersonToMeetDataGridViewTextBoxColumn.DataPropertyName = "PersonToMeet"
        Me.PersonToMeetDataGridViewTextBoxColumn.HeaderText = "PersonToMeet"
        Me.PersonToMeetDataGridViewTextBoxColumn.Name = "PersonToMeetDataGridViewTextBoxColumn"
        '
        'VisitDateDataGridViewTextBoxColumn
        '
        Me.VisitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate"
        Me.VisitDateDataGridViewTextBoxColumn.HeaderText = "VisitDate"
        Me.VisitDateDataGridViewTextBoxColumn.Name = "VisitDateDataGridViewTextBoxColumn"
        '
        'VisitTimeDataGridViewTextBoxColumn
        '
        Me.VisitTimeDataGridViewTextBoxColumn.DataPropertyName = "VisitTime"
        Me.VisitTimeDataGridViewTextBoxColumn.HeaderText = "VisitTime"
        Me.VisitTimeDataGridViewTextBoxColumn.Name = "VisitTimeDataGridViewTextBoxColumn"
        '
        'ExitTimeDataGridViewTextBoxColumn
        '
        Me.ExitTimeDataGridViewTextBoxColumn.DataPropertyName = "ExitTime"
        Me.ExitTimeDataGridViewTextBoxColumn.HeaderText = "ExitTime"
        Me.ExitTimeDataGridViewTextBoxColumn.Name = "ExitTimeDataGridViewTextBoxColumn"
        '
        'IDProofTypeDataGridViewTextBoxColumn
        '
        Me.IDProofTypeDataGridViewTextBoxColumn.DataPropertyName = "IDProofType"
        Me.IDProofTypeDataGridViewTextBoxColumn.HeaderText = "IDProofType"
        Me.IDProofTypeDataGridViewTextBoxColumn.Name = "IDProofTypeDataGridViewTextBoxColumn"
        '
        'IDProofNumberDataGridViewTextBoxColumn
        '
        Me.IDProofNumberDataGridViewTextBoxColumn.DataPropertyName = "IDProofNumber"
        Me.IDProofNumberDataGridViewTextBoxColumn.HeaderText = "IDProofNumber"
        Me.IDProofNumberDataGridViewTextBoxColumn.Name = "IDProofNumberDataGridViewTextBoxColumn"
        '
        'ViewVisitorDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 393)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewVisitorDetailsForm"
        Me.Text = "ViewVisitorDetailsForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatepassDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GatepassDataSet3 As Employee_And_Visitor_Gatepass.GatepassDataSet3
    Friend WithEvents VisitorDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VisitorDetailsTableAdapter As Employee_And_Visitor_Gatepass.GatepassDataSet3TableAdapters.VisitorDetailsTableAdapter
    Friend WithEvents VisitorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitorNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurposeOfVisitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonToMeetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExitTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDProofTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDProofNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
