<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarkAttendance
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MarkLabel = New System.Windows.Forms.Label()
        Me.MarkDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkAttendanceCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StaffDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceDataSet3 = New Attendance_Application.AttendanceDataSet3()
        Me.StaffDetailsTableAdapter = New Attendance_Application.AttendanceDataSet3TableAdapters.StaffDetailsTableAdapter()
        Me.SaveButton = New System.Windows.Forms.Button()
        CType(Me.MarkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarkLabel
        '
        Me.MarkLabel.AutoSize = True
        Me.MarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarkLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MarkLabel.Location = New System.Drawing.Point(188, 56)
        Me.MarkLabel.Name = "MarkLabel"
        Me.MarkLabel.Size = New System.Drawing.Size(176, 25)
        Me.MarkLabel.TabIndex = 0
        Me.MarkLabel.Text = "Mark Attendance"
        '
        'MarkDataGridView
        '
        Me.MarkDataGridView.AutoGenerateColumns = False
        Me.MarkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.RegisterDataGridViewTextBoxColumn, Me.MarkAttendanceCheckBoxColumn})
        Me.MarkDataGridView.DataSource = Me.StaffDetailsBindingSource
        Me.MarkDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MarkDataGridView.Location = New System.Drawing.Point(58, 128)
        Me.MarkDataGridView.Name = "MarkDataGridView"
        Me.MarkDataGridView.RowTemplate.Height = 24
        Me.MarkDataGridView.Size = New System.Drawing.Size(442, 208)
        Me.MarkDataGridView.TabIndex = 1
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
        'MarkAttendanceCheckBoxColumn
        '
        Me.MarkAttendanceCheckBoxColumn.HeaderText = "Mark Attendance"
        Me.MarkAttendanceCheckBoxColumn.Name = "MarkAttendanceCheckBoxColumn"
        Me.MarkAttendanceCheckBoxColumn.Width = 150
        '
        'StaffDetailsBindingSource
        '
        Me.StaffDetailsBindingSource.DataMember = "StaffDetails"
        Me.StaffDetailsBindingSource.DataSource = Me.AttendanceDataSet3
        '
        'AttendanceDataSet3
        '
        Me.AttendanceDataSet3.DataSetName = "AttendanceDataSet3"
        Me.AttendanceDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffDetailsTableAdapter
        '
        Me.StaffDetailsTableAdapter.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(237, 371)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'MarkAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(562, 470)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.MarkDataGridView)
        Me.Controls.Add(Me.MarkLabel)
        Me.Name = "MarkAttendance"
        Me.Text = "MarkAttendance"
        CType(Me.MarkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarkLabel As System.Windows.Forms.Label
    Friend WithEvents MarkDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AttendanceDataSet3 As Attendance_Application.AttendanceDataSet3
    Friend WithEvents StaffDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffDetailsTableAdapter As Attendance_Application.AttendanceDataSet3TableAdapters.StaffDetailsTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarkAttendanceCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SaveButton As System.Windows.Forms.Button ' Declare the checkbox column
End Class
