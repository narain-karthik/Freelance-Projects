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
        Me.ViewLabel = New System.Windows.Forms.Label()
        Me.ViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProofDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceDataSet = New Attendance_Application.AttendanceDataSet()
        Me.StaffDetailsTableAdapter = New Attendance_Application.AttendanceDataSetTableAdapters.StaffDetailsTableAdapter()
        Me.ViewButton = New System.Windows.Forms.Button()
        CType(Me.ViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewLabel
        '
        Me.ViewLabel.AutoSize = True
        Me.ViewLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ViewLabel.Location = New System.Drawing.Point(330, 27)
        Me.ViewLabel.Name = "ViewLabel"
        Me.ViewLabel.Size = New System.Drawing.Size(182, 25)
        Me.ViewLabel.TabIndex = 0
        Me.ViewLabel.Text = "View Staff Details"
        '
        'ViewDataGridView
        '
        Me.ViewDataGridView.AutoGenerateColumns = False
        Me.ViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.RegisterDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DOJDataGridViewTextBoxColumn, Me.IDProofDataGridViewTextBoxColumn})
        Me.ViewDataGridView.DataSource = Me.StaffDetailsBindingSource
        Me.ViewDataGridView.Location = New System.Drawing.Point(39, 68)
        Me.ViewDataGridView.Name = "ViewDataGridView"
        Me.ViewDataGridView.RowTemplate.Height = 24
        Me.ViewDataGridView.Size = New System.Drawing.Size(748, 271)
        Me.ViewDataGridView.TabIndex = 1
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'RegisterDataGridViewTextBoxColumn
        '
        Me.RegisterDataGridViewTextBoxColumn.DataPropertyName = "Register"
        Me.RegisterDataGridViewTextBoxColumn.HeaderText = "Register"
        Me.RegisterDataGridViewTextBoxColumn.Name = "RegisterDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DOJDataGridViewTextBoxColumn
        '
        Me.DOJDataGridViewTextBoxColumn.DataPropertyName = "DOJ"
        Me.DOJDataGridViewTextBoxColumn.HeaderText = "DOJ"
        Me.DOJDataGridViewTextBoxColumn.Name = "DOJDataGridViewTextBoxColumn"
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
        Me.StaffDetailsBindingSource.DataSource = Me.AttendanceDataSet
        '
        'AttendanceDataSet
        '
        Me.AttendanceDataSet.DataSetName = "AttendanceDataSet"
        Me.AttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffDetailsTableAdapter
        '
        Me.StaffDetailsTableAdapter.ClearBeforeFill = True
        '
        'ViewButton
        '
        Me.ViewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.Location = New System.Drawing.Point(366, 356)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(75, 23)
        Me.ViewButton.TabIndex = 2
        Me.ViewButton.Text = "View "
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'ViewStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 391)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.ViewDataGridView)
        Me.Controls.Add(Me.ViewLabel)
        Me.Name = "ViewStaffDetails"
        Me.Text = "ViewStaffDetails"
        CType(Me.ViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewLabel As System.Windows.Forms.Label
    Friend WithEvents ViewDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AttendanceDataSet As Attendance_Application.AttendanceDataSet
    Friend WithEvents StaffDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffDetailsTableAdapter As Attendance_Application.AttendanceDataSetTableAdapters.StaffDetailsTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOJDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDProofDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViewButton As System.Windows.Forms.Button
End Class
