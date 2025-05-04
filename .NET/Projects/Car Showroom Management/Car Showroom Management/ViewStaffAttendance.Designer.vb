<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStaffAttendance
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
        Me.ViewAttendanceLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsPresentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AttendanceRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarDataSet4 = New Car_Showroom_Management.CarDataSet4()
        Me.AttendanceRecordsTableAdapter = New Car_Showroom_Management.CarDataSet4TableAdapters.AttendanceRecordsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewAttendanceLabel
        '
        Me.ViewAttendanceLabel.AutoSize = True
        Me.ViewAttendanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAttendanceLabel.Location = New System.Drawing.Point(230, 54)
        Me.ViewAttendanceLabel.Name = "ViewAttendanceLabel"
        Me.ViewAttendanceLabel.Size = New System.Drawing.Size(183, 17)
        Me.ViewAttendanceLabel.TabIndex = 0
        Me.ViewAttendanceLabel.Text = "View Attendance Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.RegisterDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.IsPresentDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.AttendanceRecordsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(533, 186)
        Me.DataGridView1.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegisterDataGridViewTextBoxColumn
        '
        Me.RegisterDataGridViewTextBoxColumn.DataPropertyName = "Register"
        Me.RegisterDataGridViewTextBoxColumn.HeaderText = "Register"
        Me.RegisterDataGridViewTextBoxColumn.Name = "RegisterDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'IsPresentDataGridViewCheckBoxColumn
        '
        Me.IsPresentDataGridViewCheckBoxColumn.DataPropertyName = "IsPresent"
        Me.IsPresentDataGridViewCheckBoxColumn.HeaderText = "IsPresent"
        Me.IsPresentDataGridViewCheckBoxColumn.Name = "IsPresentDataGridViewCheckBoxColumn"
        '
        'AttendanceRecordsBindingSource
        '
        Me.AttendanceRecordsBindingSource.DataMember = "AttendanceRecords"
        Me.AttendanceRecordsBindingSource.DataSource = Me.CarDataSet4
        '
        'CarDataSet4
        '
        Me.CarDataSet4.DataSetName = "CarDataSet4"
        Me.CarDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceRecordsTableAdapter
        '
        Me.AttendanceRecordsTableAdapter.ClearBeforeFill = True
        '
        'ViewStaffAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 403)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ViewAttendanceLabel)
        Me.Name = "ViewStaffAttendance"
        Me.Text = "ViewStaffAttendance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewAttendanceLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CarDataSet4 As Car_Showroom_Management.CarDataSet4
    Friend WithEvents AttendanceRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AttendanceRecordsTableAdapter As Car_Showroom_Management.CarDataSet4TableAdapters.AttendanceRecordsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsPresentDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
