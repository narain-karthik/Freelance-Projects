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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GymDataSet2 = New Gym_Management_System.GymDataSet2()
        Me.StaffAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffAttendanceTableAdapter = New Gym_Management_System.GymDataSet2TableAdapters.StaffAttendanceTableAdapter()
        Me.StaffAttendanceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GymDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffAttendanceIDDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TimeInDataGridViewTextBoxColumn, Me.TimeOutDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffAttendanceBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(739, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'GymDataSet2
        '
        Me.GymDataSet2.DataSetName = "GymDataSet2"
        Me.GymDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffAttendanceBindingSource
        '
        Me.StaffAttendanceBindingSource.DataMember = "StaffAttendance"
        Me.StaffAttendanceBindingSource.DataSource = Me.GymDataSet2
        '
        'StaffAttendanceTableAdapter
        '
        Me.StaffAttendanceTableAdapter.ClearBeforeFill = True
        '
        'StaffAttendanceIDDataGridViewTextBoxColumn
        '
        Me.StaffAttendanceIDDataGridViewTextBoxColumn.DataPropertyName = "StaffAttendanceID"
        Me.StaffAttendanceIDDataGridViewTextBoxColumn.HeaderText = "StaffAttendanceID"
        Me.StaffAttendanceIDDataGridViewTextBoxColumn.Name = "StaffAttendanceIDDataGridViewTextBoxColumn"
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
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
        'TimeInDataGridViewTextBoxColumn
        '
        Me.TimeInDataGridViewTextBoxColumn.DataPropertyName = "TimeIn"
        Me.TimeInDataGridViewTextBoxColumn.HeaderText = "TimeIn"
        Me.TimeInDataGridViewTextBoxColumn.Name = "TimeInDataGridViewTextBoxColumn"
        '
        'TimeOutDataGridViewTextBoxColumn
        '
        Me.TimeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut"
        Me.TimeOutDataGridViewTextBoxColumn.HeaderText = "TimeOut"
        Me.TimeOutDataGridViewTextBoxColumn.Name = "TimeOutDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'ViewStaffAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 334)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewStaffAttendance"
        Me.Text = "ViewStaffAttendance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GymDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GymDataSet2 As Gym_Management_System.GymDataSet2
    Friend WithEvents StaffAttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffAttendanceTableAdapter As Gym_Management_System.GymDataSet2TableAdapters.StaffAttendanceTableAdapter
    Friend WithEvents StaffAttendanceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
