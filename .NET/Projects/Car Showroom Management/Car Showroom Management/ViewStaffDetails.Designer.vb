<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStaffDetails
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
        Me.ViewStaffDetailsLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfJoiningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProofDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarDataSet = New Car_Showroom_Management.CarDataSet()
        Me.StaffDetailsTableAdapter = New Car_Showroom_Management.CarDataSetTableAdapters.StaffDetailsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewStaffDetailsLabel
        '
        Me.ViewStaffDetailsLabel.AutoSize = True
        Me.ViewStaffDetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewStaffDetailsLabel.Location = New System.Drawing.Point(373, 61)
        Me.ViewStaffDetailsLabel.Name = "ViewStaffDetailsLabel"
        Me.ViewStaffDetailsLabel.Size = New System.Drawing.Size(135, 17)
        Me.ViewStaffDetailsLabel.TabIndex = 0
        Me.ViewStaffDetailsLabel.Text = "View Staff Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.EmployeeEmailDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.DateOfJoiningDataGridViewTextBoxColumn, Me.IDProofDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(123, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(644, 215)
        Me.DataGridView1.TabIndex = 1
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        '
        'EmployeeEmailDataGridViewTextBoxColumn
        '
        Me.EmployeeEmailDataGridViewTextBoxColumn.DataPropertyName = "EmployeeEmail"
        Me.EmployeeEmailDataGridViewTextBoxColumn.HeaderText = "EmployeeEmail"
        Me.EmployeeEmailDataGridViewTextBoxColumn.Name = "EmployeeEmailDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'DateOfJoiningDataGridViewTextBoxColumn
        '
        Me.DateOfJoiningDataGridViewTextBoxColumn.DataPropertyName = "DateOfJoining"
        Me.DateOfJoiningDataGridViewTextBoxColumn.HeaderText = "DateOfJoining"
        Me.DateOfJoiningDataGridViewTextBoxColumn.Name = "DateOfJoiningDataGridViewTextBoxColumn"
        '
        'IDProofDataGridViewTextBoxColumn
        '
        Me.IDProofDataGridViewTextBoxColumn.DataPropertyName = "IDProof"
        Me.IDProofDataGridViewTextBoxColumn.HeaderText = "IDProof"
        Me.IDProofDataGridViewTextBoxColumn.Name = "IDProofDataGridViewTextBoxColumn"
        '
        'StaffDetailsBindingSource
        '
        Me.StaffDetailsBindingSource.DataMember = "StaffDetails"
        Me.StaffDetailsBindingSource.DataSource = Me.CarDataSet
        '
        'CarDataSet
        '
        Me.CarDataSet.DataSetName = "CarDataSet"
        Me.CarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffDetailsTableAdapter
        '
        Me.StaffDetailsTableAdapter.ClearBeforeFill = True
        '
        'ViewStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 507)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ViewStaffDetailsLabel)
        Me.Name = "ViewStaffDetails"
        Me.Text = "ViewStaffDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewStaffDetailsLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CarDataSet As Car_Showroom_Management.CarDataSet
    Friend WithEvents StaffDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffDetailsTableAdapter As Car_Showroom_Management.CarDataSetTableAdapters.StaffDetailsTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfJoiningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDProofDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
