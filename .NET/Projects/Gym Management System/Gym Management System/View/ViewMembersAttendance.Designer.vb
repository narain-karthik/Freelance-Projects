<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMembersAttendance
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
        Me.GymDataSet3 = New Gym_Management_System.GymDataSet3()
        Me.MembersAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersAttendanceTableAdapter = New Gym_Management_System.GymDataSet3TableAdapters.MembersAttendanceTableAdapter()
        Me.MemberAttendanceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkoutTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GymDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberAttendanceIDDataGridViewTextBoxColumn, Me.MemberIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AttendanceDateDataGridViewTextBoxColumn, Me.TimeInDataGridViewTextBoxColumn, Me.TimeOutDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.WorkoutTypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MembersAttendanceBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(841, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'GymDataSet3
        '
        Me.GymDataSet3.DataSetName = "GymDataSet3"
        Me.GymDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersAttendanceBindingSource
        '
        Me.MembersAttendanceBindingSource.DataMember = "MembersAttendance"
        Me.MembersAttendanceBindingSource.DataSource = Me.GymDataSet3
        '
        'MembersAttendanceTableAdapter
        '
        Me.MembersAttendanceTableAdapter.ClearBeforeFill = True
        '
        'MemberAttendanceIDDataGridViewTextBoxColumn
        '
        Me.MemberAttendanceIDDataGridViewTextBoxColumn.DataPropertyName = "MemberAttendanceID"
        Me.MemberAttendanceIDDataGridViewTextBoxColumn.HeaderText = "MemberAttendanceID"
        Me.MemberAttendanceIDDataGridViewTextBoxColumn.Name = "MemberAttendanceIDDataGridViewTextBoxColumn"
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "MemberID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AttendanceDateDataGridViewTextBoxColumn
        '
        Me.AttendanceDateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDate"
        Me.AttendanceDateDataGridViewTextBoxColumn.HeaderText = "AttendanceDate"
        Me.AttendanceDateDataGridViewTextBoxColumn.Name = "AttendanceDateDataGridViewTextBoxColumn"
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
        'WorkoutTypeDataGridViewTextBoxColumn
        '
        Me.WorkoutTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkoutType"
        Me.WorkoutTypeDataGridViewTextBoxColumn.HeaderText = "WorkoutType"
        Me.WorkoutTypeDataGridViewTextBoxColumn.Name = "WorkoutTypeDataGridViewTextBoxColumn"
        '
        'ViewMembersAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 271)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewMembersAttendance"
        Me.Text = "ViewMembersAttendance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GymDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GymDataSet3 As Gym_Management_System.GymDataSet3
    Friend WithEvents MembersAttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersAttendanceTableAdapter As Gym_Management_System.GymDataSet3TableAdapters.MembersAttendanceTableAdapter
    Friend WithEvents MemberAttendanceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttendanceDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkoutTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
