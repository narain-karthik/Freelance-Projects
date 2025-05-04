<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAttendance
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
        Me.StaffAttendanceLabel = New System.Windows.Forms.Label()
        Me.StaffDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarDataSet1 = New Car_Showroom_Management.CarDataSet1()
        Me.StaffDetailsTableAdapter = New Car_Showroom_Management.CarDataSet1TableAdapters.StaffDetailsTableAdapter()
        Me.MarkDataGridView = New System.Windows.Forms.DataGridView()
        Me.MarkAttendanceCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarDataSet3 = New Car_Showroom_Management.CarDataSet3()
        Me.StaffDetailsTableAdapter1 = New Car_Showroom_Management.CarDataSet3TableAdapters.StaffDetailsTableAdapter()
        Me.SaveButton = New System.Windows.Forms.Button()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffAttendanceLabel
        '
        Me.StaffAttendanceLabel.AutoSize = True
        Me.StaffAttendanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffAttendanceLabel.Location = New System.Drawing.Point(391, 38)
        Me.StaffAttendanceLabel.Name = "StaffAttendanceLabel"
        Me.StaffAttendanceLabel.Size = New System.Drawing.Size(149, 20)
        Me.StaffAttendanceLabel.TabIndex = 0
        Me.StaffAttendanceLabel.Text = "Staff Attendance"
        '
        'StaffDetailsBindingSource
        '
        Me.StaffDetailsBindingSource.DataMember = "StaffDetails"
        Me.StaffDetailsBindingSource.DataSource = Me.CarDataSet1
        '
        'CarDataSet1
        '
        Me.CarDataSet1.DataSetName = "CarDataSet1"
        Me.CarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffDetailsTableAdapter
        '
        Me.StaffDetailsTableAdapter.ClearBeforeFill = True
        '
        'MarkDataGridView
        '
        Me.MarkDataGridView.AutoGenerateColumns = False
        Me.MarkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarkAttendanceCheckBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn})
        Me.MarkDataGridView.DataSource = Me.StaffDetailsBindingSource1
        Me.MarkDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MarkDataGridView.Location = New System.Drawing.Point(230, 97)
        Me.MarkDataGridView.Name = "MarkDataGridView"
        Me.MarkDataGridView.RowTemplate.Height = 24
        Me.MarkDataGridView.Size = New System.Drawing.Size(442, 208)
        Me.MarkDataGridView.TabIndex = 2
        '
        'MarkAttendanceCheckBoxColumn
        '
        Me.MarkAttendanceCheckBoxColumn.HeaderText = "Mark Attendance"
        Me.MarkAttendanceCheckBoxColumn.Name = "MarkAttendanceCheckBoxColumn"
        Me.MarkAttendanceCheckBoxColumn.Width = 150
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
        'StaffDetailsBindingSource1
        '
        Me.StaffDetailsBindingSource1.DataMember = "StaffDetails"
        Me.StaffDetailsBindingSource1.DataSource = Me.CarDataSet3
        '
        'CarDataSet3
        '
        Me.CarDataSet3.DataSetName = "CarDataSet3"
        Me.CarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffDetailsTableAdapter1
        '
        Me.StaffDetailsTableAdapter1.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(438, 330)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'StaffAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 403)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.MarkDataGridView)
        Me.Controls.Add(Me.StaffAttendanceLabel)
        Me.Name = "StaffAttendance"
        Me.Text = "StaffAttendance"
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StaffAttendanceLabel As System.Windows.Forms.Label
    Friend WithEvents CarDataSet1 As Car_Showroom_Management.CarDataSet1
    Friend WithEvents StaffDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffDetailsTableAdapter As Car_Showroom_Management.CarDataSet1TableAdapters.StaffDetailsTableAdapter
    Friend WithEvents MarkDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MarkAttendanceCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarDataSet3 As Car_Showroom_Management.CarDataSet3
    Friend WithEvents StaffDetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StaffDetailsTableAdapter1 As Car_Showroom_Management.CarDataSet3TableAdapters.StaffDetailsTableAdapter
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
